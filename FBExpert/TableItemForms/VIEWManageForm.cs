using BasicClassLibrary;
using BrightIdeasSoftware;
using DBBasicClassLibrary;
using Enums;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageFormLibrary;
using SESpaltenEditor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FBExpert
{

    
    public partial class VIEWManageForm : INormalForm
    {      
        private static VIEWManageForm instance = null;      
        public static VIEWManageForm Instance()
        {                    
            return (instance);
        }

        private ViewClass _viewObject = null;
        private StreamWriter sw = null;

        private int messages_count = 0;
        private int error_count = 0;
        private NotifiesClass _localNofity = new NotifiesClass();
        private DBRegistrationClass DBReg = null;
        private TreeNode TnSelected = null;
        private bool writefile = false;
        private int pi = 0;
        private string filename = string.Empty;
        private List<string> exportList = new List<string>();
        private GridStoreClass gridStore;
        public VIEWManageForm(Form parent, DBRegistrationClass drc, TreeNode tnSelected)
        {
            InitializeComponent();
            this.MdiParent = parent;
            instance = this;
            ViewClass viewObject = (ViewClass)tnSelected.Tag;           
            _localNofity.ErrorGranularity = eMessageGranularity.never;
            _localNofity.Register4Info(MeldungRaised);
            _localNofity.Register4Error(ErrorRaised);
            
            TnSelected = tnSelected;
            _viewObject = (ViewClass)tnSelected.Tag;

            DBReg = drc;
            txtMaxRows.Text = AppSettingsClass.Instance.SQLVariables.MaxRowsForSelect.ToString();
            this.GetDataWorker.WorkerReportsProgress = true;
            this.GetDataWorker.WorkerSupportsCancellation = true;
            this.GetDataWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetData_DoWork);
            this.GetDataWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwGetData_ProgressChanged);
            this.GetDataWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetData_RunWorkerCompleted);

            gridStore = new GridStoreClass(dgvResults);
        }

        AutocompleteClass ac;

        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctCREATEINSERTSQL, DBReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.Activate();
        }

        public void RefreshLanguageText()
        {
            hsPageRefresh.Text          = LanguageClass.Instance.GetString("REFRESH");
            hsExportData.Text           = LanguageClass.Instance.GetString("EXPORT");
            hsCancelGettingData.Text    = LanguageClass.Instance.GetString("CANCEL_READING");
            hsCancelExport.Text         = LanguageClass.Instance.GetString("CANCEL_READING");
            hsSaveSQL.Text              = LanguageClass.Instance.GetString("SAVE_SQL");
            hsLoadSQL.Text              = LanguageClass.Instance.GetString("LOAD_SQL");
            hsRunStatement.Text         = LanguageClass.Instance.GetString("EXECUTE_SQL");
            hsRefreshExportData.Text    = LanguageClass.Instance.GetString("REFRESH");
            
            rbINSERT.Text               = LanguageClass.Instance.GetString("INSERT");
            rbUPDATE.Text               = LanguageClass.Instance.GetString("UPDATE");
            rbINSERTUPDATE.Text         = LanguageClass.Instance.GetString("INSERT_UPDATE");
            
            tabPageFIELDS.Text          = LanguageClass.Instance.GetString("FIELDS");
            tabPageDATA.Text            = LanguageClass.Instance.GetString("DATA");
            tabPageDependenciesTo.Text  = LanguageClass.Instance.GetString("DEPENDENCIES_TO");
            tabPageExport.Text          = LanguageClass.Instance.GetString("EXPORT_DATA");
            tabPageMessages.Text        = LanguageClass.Instance.GetString("MESSAGES");
            
            gbMaxRows.Text              = LanguageClass.Instance.GetString("MAX_ROWS");
            gbExportFile.Text           = LanguageClass.Instance.GetString("FILE");
            gbInsertUpdate.Text         = LanguageClass.Instance.GetString("INSERT_UPDATE_TYPE");
            
            cbExportToScreen.Text       = LanguageClass.Instance.GetString("EXPORT_TO_SCREEN");
            cbExportToFile.Text         = LanguageClass.Instance.GetString("EXPORT_TO_FILE");
            
            ckGetDatas.Text             = LanguageClass.Instance.GetString("READ_DATAS");
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowCaptions()
        {
            lblTableName.Text = (_viewObject != null) ? $@"View: {_viewObject.Name}" : "View";            
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Manage Views");
        }

        

        void ErrorRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = System.Drawing.Color.Red;
            fctMessages.AppendText(k.Meldung);
            string posTxt = AppStaticFunctionsClass.getErrorPosText(k.Meldung);
            if (!string.IsNullOrEmpty(posTxt))
            {
                fctMessages.AppendText(posTxt);
            }
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"{LanguageClass.Instance.GetString("MESSAGES")} ({messages_count}) ");
            if (error_count > 0) sb.Append($@"{LanguageClass.Instance.GetString("ERRORS")} ({error_count})");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();                       
        }

        void MeldungRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = System.Drawing.Color.Blue;
            fctMessages.AppendText(k.Meldung);
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"{LanguageClass.Instance.GetString("MESSAGES")} ({messages_count}) ");
            if (error_count > 0) sb.Append($@"{LanguageClass.Instance.GetString("ERRORS")} ({error_count})");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();            
        }


        public int RefreshDependenciesTo()
        {                                
            dsDependencies.Clear();
            dgvDependencies.AutoGenerateColumns = true;

            string cmd_index = SQLStatementsClass.Instance.GetViewManagerDependenciesTO(DBReg.Version, _viewObject.Name);
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con );
                ds.Fill(dsDependencies);
                con.Close();               
            }
            catch(Exception ex)
            {                
              NotifiesClass.Instance.AddToERROR($@"{BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr()} ViewManagerForm->RefreshDependenciesTo->{ex.Message}");
            }
            bsDependencies.DataMember = "Table";

            return dsDependencies.Tables[0].Rows.Count;

        }

        public int RefreshDependenciesFrom()
        {                  
            dsDependencies.Clear();
            dgvDependencies.AutoGenerateColumns = true;
            string cmd_index = SQLStatementsClass.Instance.GetViewManagerDependenciesFROM(DBReg.Version, _viewObject.Name);
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsDependencies);
                con.Close();              
            }
            catch(Exception ex)
            {
                NotifiesClass.Instance.AddToERROR($@"{BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr()} {this.Name}->RefreshDependenciesFrom->{ex.Message}");
            }
            bsDependencies.DataMember = "Table";
            return dsDependencies.Tables[0].Rows.Count;
        }

        public int RefreshFields()
        {
            if (string.IsNullOrEmpty(_viewObject.Name)) return fastObjectListView1.Items.Count;
            
            string cmd =  SQLStatementsClass.Instance.GetViewFields(DBReg.Version, _viewObject.Name);

            fastObjectListView1.SetObjects(null,false);
            //fastObjectListView1.Items.Clear();
            

            dgExportGrid.Rows.Clear();
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                con.Open();
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();                                                                                           
                if (dread.HasRows)
                {                       
                    while (dread.Read())
                    {                                                    
                        string fieldstr     =  dread.GetValue(0).ToString();
                        string posstr       = dread.GetValue(1).ToString();
                        string domainname   = dread.GetValue(2).ToString();
                        string typename     = dread.GetValue(3).ToString();
                        string typelength   = dread.GetValue(4).ToString();
                        string basefield = dread.GetValue(5).ToString();
                        string nullflag = dread.GetValue(6).ToString();
                        string updateflag = dread.GetValue(7).ToString();
                        string charactersetname = dread.GetValue(8).ToString();
                        string collatename = dread.GetValue(9).ToString();

                        ViewFieldClass vf = new ViewFieldClass()
                        {
                            Name = fieldstr.Trim(),
                            Position = BasicClassLibrary.StaticFunctionsClass.ToIntDef(posstr.Trim(), -1),
                            UpdateFlag = BasicClassLibrary.StaticFunctionsClass.ToIntDef(updateflag.Trim(), 0),
                            BaseField = basefield.Trim()
                        };
                        vf.Domain.FieldType = typename.Trim();
                        vf.Domain.Length = BasicClassLibrary.StaticFunctionsClass.ToIntDef(typelength, -1);
                        vf.Domain.Name = domainname.Trim();
                        vf.Domain.NotNull = (BasicClassLibrary.StaticFunctionsClass.ToIntDef(posstr, 0) == 1);
                        vf.Domain.CharSet = charactersetname.Trim();
                        vf.Domain.Collate = collatename.Trim();
                        object[] obarr_export = { posstr.Trim(), fieldstr.Trim(), true, true };

                        fastObjectListView1.AddObject(vf);
                        dgExportGrid.Rows.Add(obarr_export);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR($@"{BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr()} {this.Name}->RefreshDependenciesFrom->{ex.Message}");
            }               
            return fastObjectListView1.Items.Count;
        }
       




        public string MakeFieldsCmd()
        {
            var sb = new StringBuilder();
            ViewFieldClass firstObject = null;
            int i = 0;
            foreach (ViewFieldClass lvi in fastObjectListView1.Objects)
            {
                if (i == 0) firstObject = lvi;
                i++;
                if (sb.ToString().Length > 0)
                {
                    sb.Append(",");
                }
               
                sb.Append(lvi.Name);
            }

            sb.Append($@" FROM {_viewObject.Name}");

            if (firstObject != null)
            {
                if (rbSQLAsc.Checked)
                    sb.Append($@" ORDER BY {firstObject.Name} {EnumHelper.GetDescription(eSort.ASC)}");
                else if (rbSQLDesc.Checked)
                    sb.Append($@" ORDER BY {firstObject.Name} {EnumHelper.GetDescription(eSort.DESC)}");
            }
            else
            {
                rbSQLAsc.Checked = false;
                rbSQLDesc.Checked = false;
            }

            sfbViewData.SQLKonjunktion = "WHERE";
            string SCmd = sfbViewData.SQLCmd;
            if (SCmd.Length > 0)
            {
                sb.Append(SCmd);
            }
            sb.Append(";");
            string cmd = sb.ToString();
            return cmd;
        }

        public FbConnection _dataConnection = null;

        private BrightIdeasSoftware.OLVColumn colFieldname;
        private BrightIdeasSoftware.OLVColumn colFieldPosition;
        private BrightIdeasSoftware.OLVColumn colFieldType;
        private BrightIdeasSoftware.OLVColumn colLength;
        private BrightIdeasSoftware.OLVColumn colCharset;
        private BrightIdeasSoftware.OLVColumn colCollate;
        private BrightIdeasSoftware.OLVColumn colDomainName;
        private BrightIdeasSoftware.OLVColumn colScale;
        private BrightIdeasSoftware.OLVColumn colBaseField;
        private BrightIdeasSoftware.OLVColumn colNotNull;
        private BrightIdeasSoftware.OLVColumn colUpdateFlag;


        public void MakeFieldGrid()
        {
            colFieldname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colFieldPosition = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colFieldType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colBaseField = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colNotNull = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colUpdateFlag = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colLength = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colCharset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colCollate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colDomainName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colScale = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));

            colFieldType.TextAlign = HorizontalAlignment.Center;
            colFieldPosition.TextAlign = HorizontalAlignment.Right;
            colFieldname.Text = "Name";
            colFieldPosition.Text = "Pos";
            colFieldType.Text = "Type";
            colBaseField.Text = "Base Field";
            colNotNull.Text = "NotNull";
            colUpdateFlag.Text = "UpdFlag";
            colLength.Text = "Length";
            colCharset.Text = "Charset";
            colCollate.Text = "Collate";
            colDomainName.Text = "Domain";
            colScale.Text = "Scale";

            colFieldPosition.Width = 50;
            colFieldname.Width = 250;
            colBaseField.Width = 250;
            colNotNull.Width = 70;
            colFieldType.Width = 100;
            colLength.Width = 70;
            colCharset.Width = 100;
            colCollate.Width = 100;
            colDomainName.Width = 120;
            colScale.Width = 40;
            colUpdateFlag.Width = 70;

            fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {

            colFieldPosition,
            colFieldname,
            colFieldType,
            colLength,
            colNotNull,
            colScale,
            colCharset,
            colCollate,
            colDomainName,
            colBaseField,
            colUpdateFlag
            });
            fastObjectListView1.CellEditUseWholeCell = false;
            fastObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            fastObjectListView1.HideSelection = false;
            fastObjectListView1.Location = new System.Drawing.Point(0, 0);
            fastObjectListView1.Name = "fastObjectListView1";
            fastObjectListView1.ShowGroups = false;
            fastObjectListView1.TabIndex = 4;
            fastObjectListView1.UseCompatibleStateImageBehavior = false;
            fastObjectListView1.View = System.Windows.Forms.View.Details;
            fastObjectListView1.VirtualMode = true;
        }

        //Getters (Formatierungen, Zuweisungen der Objektvariablen zu dem ObjektListView
        private void SetupColumns()
        {
            colFieldname.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Name; };
            colBaseField.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).BaseField; };
            colFieldPosition.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Position; };
            colFieldType.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Domain.FieldType; };

            colLength.AspectGetter = delegate (object x)
            {
                if (((ViewFieldClass)x).Domain.FieldType == "VARYING") return ((ViewFieldClass)x).Domain.Length.ToString();
                return "";
            };

            this.colNotNull.AspectGetter = delegate (object x)
            {
                if (((ViewFieldClass)x).Domain.NotNull) return "ISOK";
                return "NOTOK";
            };
            this.colNotNull.Renderer = new MappedImageRenderer(new Object[] {
                "ISOK",FBXpert.Properties.Resources.help_about_blue_x22,
                "NOTOK", FBXpert.Properties.Resources.nichts_x22
            });

            colUpdateFlag.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).UpdateFlag; };
            colScale.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Domain.Scale; };
            colCharset.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Domain.CharSet; };
            colCollate.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Domain.Collate; };
            colDomainName.AspectGetter = delegate (object x) { return ((ViewFieldClass)x).Domain.Name; };
        }


        public void SetMaxRows(int maxrows)
        {
            txtMaxRows.Text = maxrows.ToString();
        }

        public void SetOrder(eSort sort)
        {
            if (sort == eSort.ASC)
            {
                rbSQLAsc.Checked = true;
            }
            else if (sort == eSort.DESC)
            {
                rbSQLDesc.Checked = true;
            }
            else
            {
                rbSQLDesc.Checked = false;
                rbSQLAsc.Checked = false;
            }

        }
        public int RefreshDatas(string cmd)
        {
            int errorsCnt = 0;
            
            if (string.IsNullOrEmpty(_viewObject.Name))  return dsViewContent.Tables[0].Rows.Count;            
            try
            {
                dgvResults.AutoGenerateColumns = true;
                GetDataWorker.ReportProgress(1, "Reading data...");
                long skip = 0;    
                
                if (_dataConnection != null)
                {
                  if(_dataConnection.State != System.Data.ConnectionState.Closed)   _dataConnection.Close();
                }
                _dataConnection = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));                    
                _dataConnection.Open();
                var cnt = AppSettingsClass.Instance.SQLVariables.SkipForSelect;
                var sk = AppSettingsClass.Instance.SQLVariables.SkipForSelect;
                if ((maxRows > 0) && (cnt > maxRows))
                {
                    cnt = maxRows;
                    sk = cnt;
                }
                string cmds = string.Empty;
                if (maxRows > 0)
                {
                    GetDataWorker.ReportProgress(0, $@"SELECT FIRST {maxRows} {cmd.Trim()}");
                }
                else
                {
                    GetDataWorker.ReportProgress(0, $@"SELECT {cmd.Trim()}");
                }

                while ((cnt >= sk) && (skip < maxRows||maxRows <= 0))
                {
                    try
                    {
                        if (this.GetDataWorker.CancellationPending) return 0;
                        cmds = $@"SELECT FIRST {sk} SKIP {skip} {cmd};";
                        var ds = new FbDataAdapter(cmds, _dataConnection);
                        
                        cnt = ds.Fill(dsViewContent);                      
                        GetDataWorker.ReportProgress(1, "..." + skip.ToString());                        
                        skip += cnt;     
                    }
                    catch(Exception ex)
                    {
                        _localNofity.AddToERROR($@"{BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr()}->{this.Name}->RefreshDatas({cmds}), msg:{ex.Message}");
                        errorsCnt++;
                        
                        if(errorsCnt > errorsAllowed)
                        {
                            GetDataWorker.CancelAsync();
                        }
                    }
                }
                _dataConnection.Close();                  
            }
            catch(Exception ex)
            {
                NotifiesClass.Instance.AddToERROR($@"{BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr()}->{this.Name}->RefreshDatas({cmd}), msg:{ex.Message}");
            }                               
            return dsViewContent.Tables[0].Rows.Count;
        }

        private void RefreshDLL()
        {
            fctDLL.Text = _viewObject.SQL;
            fctCREATEINSERTSQL.Text = (cbAlterView.Checked) 
                ? (cbPretty.Checked) ? AppStaticFunctionsClass.MakeSqlPretty(_viewObject.CREATEINSERT_SQL) : _viewObject.CREATEINSERT_SQL 
                : (cbPretty.Checked) ? AppStaticFunctionsClass.MakeSqlPretty(_viewObject.CREATE_SQL) : _viewObject.CREATE_SQL;
            if (!fctCREATEINSERTSQL.Text.Trim().EndsWith(";")) fctCREATEINSERTSQL.Text += ";";
        }

        string _cmd = null;

        public void ClearDataGrid()
        {
            dgvResults.Columns.Clear();
            dsViewContent.Clear();
            dsViewContent.Tables[0].Columns.Clear();
            dgvResults.AutoGenerateColumns = true;
        }

        WorkerClass GetDataWorker = new WorkerClass();


        public void CreateTabControl()
        {
            tabControlViews.TabPages.Clear();
            tabControlViews.TabPages.Add(tabPageFIELDS);
            if(getData) tabControlViews.TabPages.Add(tabPageDATA);
            tabControlViews.TabPages.Add(tabDDL);
            tabControlViews.TabPages.Add(tabUpdateInsert);
            tabControlViews.TabPages.Add(tabPageDependenciesTo);
            tabControlViews.TabPages.Add(tabPageMessages);
            if (getData) tabControlViews.TabPages.Add(tabPageExport);
        }

        int errorsAllowed = 0;
        long maxRows = 0;
        public void TextToData()
        {
            errorsAllowed = BasicClassLibrary.StaticFunctionsClass.ToIntDef(txtMaxAllowedErrors.Text, 0);
            maxRows = BasicClassLibrary.StaticFunctionsClass.ToLongDef(txtMaxRows.Text, 0);
        }
        public void RefreshAll()
        {
            TextToData();
            CreateTabControl();
            dgvResults.Visible = false;
            bsViewContent.DataMember = null;
            int rf = RefreshFields();
            _cmd = MakeFieldsCmd();
            
            bsViewContent.DataMember = null;
            
            sfbViewData.Enabled = false;
            Application.DoEvents();
            GetDataWorker.CancelGettingData();
            
            if(GetDataWorker.CancellingDone())
            {
                ClearDataGrid();

                if (!GetDataWorker.IsBusy)
                {                       
                    GetDataWorker.RunWorkerAsync();
                }
                int rd = RefreshDependenciesTo();
            
                tabPageDependenciesTo.Text = $@"Dependencies ({rd})";
                tabPageFIELDS.Text = $@"Fields ({rf})";

                RefreshDLL();
                ShowCaptions();
                cbCAuto.Checked = !cbCAuto.Checked;
                cbCAuto.Checked = !cbCAuto.Checked;
            }
        }

        public void RefreshStruct()
        {
            TextToData();
            CreateTabControl();
            dgvResults.Visible = false;
            bsViewContent.DataMember = null;
            dgvResults.Enabled = false;
            pnlDataUpper.Enabled = false;
            int rf = RefreshFields();
            _cmd = MakeFieldsCmd();

            bsViewContent.DataMember = null;

            sfbViewData.Enabled = false;
            Application.DoEvents();
            GetDataWorker.CancelGettingData();

            if (GetDataWorker.CancellingDone())
            {
                ClearDataGrid();

                
                int rd = RefreshDependenciesTo();

                tabPageDependenciesTo.Text = $@"Dependencies ({rd})";
                tabPageFIELDS.Text = $@"Fields ({rf})";

                RefreshDLL();
                ShowCaptions();
                cbCAuto.Checked = !cbCAuto.Checked;
                cbCAuto.Checked = !cbCAuto.Checked;
            }
        }

        public void SpaltenEdit()
        {
            var sp = SPALTENEditForm.Instance(this, null,true);
            sp.Notify.Register4Info(SpaltenNotify_SpaltenOnRaiseInfoHandler);

            sp.SetGrid(dgvResults, _viewObject.Name,DBReg.Alias);
            sp.ShowDialog();
        }

        private void SpaltenNotify_SpaltenOnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            if (dgvResults.Columns.Count <= 0) return;
            if (k.Key.ToString() == SESpaltenEditor.Consts.ChangeCheckKey)
            {
                int n = StaticFunctionsClass.ToIntDef(k.Meldung, -1);
                if ((n >= 0) && (dgvResults.Columns.Count > n))
                {
                    dgvResults.Columns[n].Visible = (bool)k.Data;
                }
            }
            else if (k.Key.ToString() == SESpaltenEditor.Consts.SwapItemKey)
            {
                //Columns swapped
                Point pt = (Point)k.Data;
                int d1 = dgvResults.Columns[pt.X].DisplayIndex;
                int d2 = dgvResults.Columns[pt.Y].DisplayIndex;

                dgvResults.Columns[pt.X].DisplayIndex = d2;
                dgvResults.Columns[pt.Y].DisplayIndex = d1;
            }
            else if (k.Key.ToString() == SESpaltenEditor.Consts.CloseForm)
            {
                gridStore.StoreGridDesign();
            }
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void hsRefreshData_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }
        bool getData = false;
        public bool GetData
        {
            set
            {
                getData = value;
                ckGetDatas.Checked = value;
            }
            get
            {
                return getData;
            }
        }
        private void VIEWManageForm_Load(object sender, EventArgs e)
        {
            
            FormDesign.SetFormLeft(this);
            MakeFieldGrid();
            SetupColumns();
            RefreshLanguageText();
            fctMessages.Clear();
            
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
            if(getData) RefreshAll();
            else RefreshStruct();
            // DBReg.AutocompleteSetTextobjectForDatabase(fctCREATEINSERTSQL);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            firsttab = StaticPaintClass.TabControl_DrawItem(this, e, sender, firsttab);
        }

        bool firsttab = false;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            firsttab = false;
        }

        private void spezialfilterBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (GetDataWorker.IsBusy) return;
                        
            sfbViewData.Enabled = false;
            Application.DoEvents();
            GetDataWorker.RunWorkerAsync();                
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sfbViewData.dcFilter = dgvResults.Columns[e.ColumnIndex];
            sfbViewData.FilterText = string.Empty;
            sfbViewData.cbChecked = false;
            sfbViewData.SelectFilter();
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            saveSQLFile.FileName = $@"{_viewObject.Name}.sql";
            if (saveSQLFile.ShowDialog() != DialogResult.OK) return;            
            fctCREATEINSERTSQL.SaveToFile(saveSQLFile.FileName,Encoding.UTF8);               
        }
        
        private void hsRunStatement_ClickAsync(object sender, EventArgs e)
        {            
            GetDataWorker.CancelGettingData();
            if(GetDataWorker.CancellingDone(5000))
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.Clear();
                dgvResults.AutoGenerateColumns = true;                               
                DoCreateAlter(fctCREATEINSERTSQL.Lines,DBReg);
                DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo($@"{Name}->RunStatement", StaticVariablesClass.ReloadViews, TnSelected);      
                return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(),"Canceling getting data failed","Timeout for canceling getting data has arrived (5000 ms)");
        }

        private void DoCreateAlter(IList<string> cmd,DBRegistrationClass DBReg)
        {
            var SQLcommand = new SQLCommandsClass(DBReg);
            SQLcommand.Notify.Register4Info(MeldungRaised);
            SQLcommand.Notify.Register4Error(ErrorRaised);
            IList<string> cmd2 = new List<string>();
            foreach(string s in cmd)
            {
                if (s.Trim().StartsWith("/*")) continue;
                if (string.IsNullOrEmpty(s)) continue;
                cmd2.Add(s);
            }
            
            var ri = SQLcommand.ExecuteCommand(cmd2,true);            
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
            messages_count = 0;
            error_count = 0;
            var sb = new StringBuilder();
            sb.Append($@"{LanguageClass.Instance.GetString("MESSAGES")} ({messages_count}) ");            
            sb.Append($@"{LanguageClass.Instance.GetString("ERRORS")} ({error_count})");
            tabPageMessages.Text = sb.ToString();
        }

        private void cmsText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiUpdateInsertCopyToClipboard)
            {
                Clipboard.SetText(fctCREATEINSERTSQL.SelectedText);
            }
            else if(e.ClickedItem == tsmiUpdateInsertPaste)
            {                
                fctCREATEINSERTSQL.Text = fctCREATEINSERTSQL.Text.Insert(fctCREATEINSERTSQL.SelectionStart, Clipboard.GetText());
            }
            else if (e.ClickedItem == tsmiDDLCopyToClipboard)
            {
                Clipboard.SetText(fctDLL.SelectedText);
            }
            else if (e.ClickedItem == tsmiDDLPaste)
            {              
                fctDLL.Text = fctDLL.Text.Insert(fctDLL.SelectionStart, Clipboard.GetText());
            }
            else if (e.ClickedItem == tsmiMessageCopyToClipboard)
            {
                Clipboard.SetText(fctMessages.SelectedText);
            }
            else if (e.ClickedItem == tsmiMessagePaste)
            {                
                fctMessages.Text = fctMessages.Text.Insert(fctMessages.SelectionStart, Clipboard.GetText());
            }
        }
        
        private void hsRefreshDependenciesTo_Click(object sender, EventArgs e)
        {
            RefreshDependenciesTo();
        }

        private void VIEWManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
            GetDataWorker.CancelGettingData();
          
            if (_localNofity != null)
            {
                _localNofity.Notify.ClearEvents();                
            }
            GC.Collect();          
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if(ofdSQL.ShowDialog() != DialogResult.OK) return;            
            fctCREATEINSERTSQL.OpenFile(ofdSQL.FileName);               
        }

        private void DeactivateGrid()
        {
            ExtensionMethods.DoubleBuffered(dgvResults,true);
            dgvResults.SuspendLayout();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void ActivateGrid()
        {            
            dgvResults.ResumeLayout(false);
            dgvResults.Visible = true;
            Cursor.Current = Cursors.Default;            
        }
        
        private void bwGetData_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {                  
            DeactivateGrid();     
            stopwatch.Restart();
            RefreshDatas(_cmd);
        }

        private void bwGetData_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {            
            if (e.ProgressPercentage == 1)
            {
                tabPageDATA.Text = e.UserState.ToString();
            }
            else if (e.ProgressPercentage == 0)
            {
                txtSQL.Text = e.UserState.ToString();
            }
        }

        private void bwGetData_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            string utime = stopwatch.ElapsedMilliseconds.ToString();
            stopwatch.Restart();
            bsViewContent.DataSource = dsViewContent;
            if (bsViewContent.DataMember != null)
            {
                bsViewContent.DataMember = "Table";
                tabPageDATA.Text = $@"Data ({dsViewContent.Tables[0].Rows.Count})";
            }
            
            dgvResults.DataSource = bsViewContent;            
            sfbViewData.Enabled = true;
            gridStore.RestoreGridDesign();
            ActivateGrid();
            stopwatch.Stop(); 
            utime+= $@" / {stopwatch.ElapsedMilliseconds}";
            txtUsedTime.Text = utime;
        }
        private void hsCancelGettingData_Click(object sender, EventArgs e)
        {
            GetDataWorker.CancelGettingData();
        }
        
        Stopwatch stopwatch = new Stopwatch();
        private void cbAlterView_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDLL();
        }

        private void cbCAuto_CheckedChanged(object sender, EventArgs e)
        {
            cbCAuto_Checked();
        }

        private void cbCAuto_Checked()
        {
            if (cbCAuto.Checked)
            {
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvResults.ReadOnly = true;
                dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                
            }
            else
            {
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvResults.ReadOnly = false;
                dgvResults.SelectionMode = DataGridViewSelectionMode.CellSelect;               
            }
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            fctDLL.Clear();
        }

        private void hsRefreshwws_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void fctCREATEINSERTSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if(ac != null) ac.Show();                
                e.Handled = true;
            }
        }       

        private void hsExport_Click(object sender, EventArgs e)
        {
            if (bwExport.IsBusy) return;
            
            pbExport.Value   = 0;
            pbExport.Minimum = 0;
            pbExport.Maximum = dsViewContent.Tables[0].Rows.Count;
            fcbExport.Clear();
            pi = 0;
            writefile = cbExportToFile.Checked;
            if (cbExportToFile.Checked)
            {
                writefile = false;
                if (saveSQLFile.ShowDialog() == DialogResult.OK)
                {
                    filename = saveSQLFile.FileName;
                    writefile = true;
                }
            }

            if (cbExportToScreen.Checked)
            {                
                exportList.Clear();
            }
            hsCancelExport.Enabled = true;
            hsExportData.Enabled = false;
            if (writefile)
            {
                if (filename.Length > 0)
                {
                    sw = new StreamWriter(filename, false, (cbCharSet.SelectedItem as EncodingClass).encoding);
                }
                else
                {
                    writefile = false;
                }
            }

            bwExport.RunWorkerAsync();               
        }
        public ViewFieldClass FindField(string fname)
        {
            _viewObject.Fields.TryGetValue(fname, out ViewFieldClass result);
            return result;
        }

        private void ExportForInsertUpdate(bool insertupdate)
        {
            var sb = new StringBuilder();
            var cols = new StringBuilder();
            bool fcol = true;

            foreach (DataGridViewRow row in dgExportGrid.Rows)
            {
                bool act  = (bool)row.Cells["colExportActive"].Value;
                bool whre = (bool)row.Cells["colExportWhere"].Value;
                if (!act && !whre) continue;
                
                if (fcol) cols.Append($@"{row.Cells["ColExportFieldName"].Value}");
                else      cols.Append($@",{row.Cells["ColExportFieldName"].Value}");
                fcol = false;                   
            }

            int i = 0;

            foreach (DataRow dr in dsViewContent.Tables[0].Rows)
            {
                sb.Clear();
                Thread.Sleep(5);
                if (this.bwExport.CancellationPending)
                {
                    return;
                }
                
                string cmdpattern = (insertupdate) ? SQLPatterns.UpdateInsertPattern : SQLPatterns.InsertPattern;
                
                string tablename = _viewObject.Name;
                cmdpattern = cmdpattern.Replace(SQLPatterns.TableKey, tablename);
                cmdpattern = cmdpattern.Replace(SQLPatterns.ColumnKey, cols.ToString());
                bool first = true;

                foreach (DataGridViewRow row in dgExportGrid.Rows)
                {
                    bool act = (bool)row.Cells["colExportActive"].Value;
                    bool whre = (bool)row.Cells["colExportWhere"].Value;
                    if (!act && !whre) continue;
                    
                    string scmd = string.Empty;
                    string fstr = row.Cells["colExportFieldName"].Value.ToString();
                    var str = FindField(fstr);

                    string valuestr = dr[str.Name].ToString();

                    if (str.Domain.FieldType.StartsWith("VAR") || str.Domain.FieldType.StartsWith("TIME") || str.Domain.FieldType.StartsWith("DATE"))
                    {
                        if (valuestr.Length <= 0) scmd = "null";
                        else scmd = $@"'{valuestr}'";
                    }
                    else
                    {
                        if (valuestr.Length <= 0) scmd = "null";
                        else scmd = valuestr;
                    }

                    if (first)
                    {
                        sb.Append(scmd);
                    }
                    else
                    {
                        sb.Append($@", {scmd}");
                    }
                    first = false;                       
                }
                cmdpattern = cmdpattern.Replace(SQLPatterns.ValueKey, sb.ToString());
                bwExport.ReportProgress(i, cmdpattern);
                i++;
            }
        }

        private void ExportForUpdate()
        {
            int i = 0;
            foreach (DataRow dr in dsViewContent.Tables[0].Rows)
            {
                var sb = new StringBuilder();
                string cmdpattern = string.Empty;

                cmdpattern = SQLPatterns.UpdatePattern;

                string tablename = _viewObject.Name;
                cmdpattern = cmdpattern.Replace(SQLPatterns.TableKey, tablename);
                string primarystr = string.Empty;
                bool first = true;

                foreach (DataGridViewRow row in dgExportGrid.Rows)
                {
                    Thread.Sleep(5);
                    bool act = (bool)row.Cells["colExportActive"].Value;
                    bool whre = (bool)row.Cells["colExportWhere"].Value;
                    if (!act && !whre) continue;
                    
                    string fstr = row.Cells["colExportFieldName"].Value.ToString();
                    var str = FindField(fstr);

                    string scmd = string.Empty;
                    string valuestr = dr[str.Name].ToString();

                    if (str.Domain.FieldType.StartsWith("VAR") || str.Domain.FieldType.StartsWith("TIME") || str.Domain.FieldType.StartsWith("DATE"))
                    {                        
                        scmd = (valuestr.Length <= 0) ? $@"{str.Name} = null" : $@"{str.Name} = '{valuestr}'";
                    }
                    else
                    {
                        scmd = (valuestr.Length <= 0) ? $@"{str.Name} = null" : $@"{str.Name} = {valuestr}";
                    }

                    if (!whre)
                    {
                        if (first)
                        {
                            sb.Append(scmd);
                        }
                        else
                        {
                            sb.Append($@", {scmd}");
                        }
                        first = false;
                    }
                    else
                    {
                        primarystr = scmd;
                    }
                       
                }
                cmdpattern = cmdpattern.Replace("#REPLACE_COLVAL", sb.ToString());
                cmdpattern = cmdpattern.Replace("#REPLACE_PRIMARY", primarystr);

                bwExport.ReportProgress(i, cmdpattern);
                i++;
            }
        }

        private void bwExport_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (rbINSERT.Checked)
            {
                ExportForInsertUpdate(false);
            }
            else if (rbINSERTUPDATE.Checked)
            {
                ExportForInsertUpdate(true);
            }
            else if (rbUPDATE.Checked)
            {
                ExportForUpdate();
            }
        }

        private void bwExport_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (cbExportToScreen.Checked)
            {
                exportList.Add($@"{e.UserState};{Environment.NewLine}");                
            }
            if (writefile)
            {
                sw.WriteLine($@"{e.UserState};");
            }

            pi++;

            int n = (pbExport.Maximum / 100);
            if (n <= 0) n = 1;

            if ((pi % n) == 0)
            {
                tabPageExport.Text = $@"Export ({pi})";
                pbExport.Value = pi;
            }
        }
        
        private void bwExport_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (writefile)
            {
                sw.Close();
            }

            if (cbExportToScreen.Checked)
            {
                fcbExport.BeginUpdate();
                foreach (string str in exportList)
                {
                    fcbExport.AppendText(str);
                }
                fcbExport.EndUpdate();
            }

            pbExport.Value   = 0;
            pbExport.Minimum = 0;
            pbExport.Maximum = 0;

            tabPageExport.Text = $@"Export ({pi})";
            hsCancelExport.Enabled = false;
            hsExportData.Enabled = true;
        }

        private void cbPretty_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDLL();
        }

        private void cmdDATA_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiSpaltenEdit)
            {
                SpaltenEdit();
            }
        }

        private void ckGetDatas_CheckedChanged(object sender, EventArgs e)
        {
            getData = ckGetDatas.Checked;
        }
    }
    

    
}
