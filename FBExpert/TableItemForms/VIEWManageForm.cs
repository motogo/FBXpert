﻿using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        ViewClass ViewObject = null;
        StreamWriter sw = null;
        NotifiesList Notifies = new NotifiesList();
        AutocompleteClass ac = null;
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNofity = new NotifiesClass();
        DBRegistrationClass DBReg = null;
        TreeNode TnSelected = null;
        bool writefile = false;
        int pi = 0;
        string filename = string.Empty;
        public VIEWManageForm(Form parent, DBRegistrationClass drc, TreeNode tnSelected)
        {
            InitializeComponent();
            this.MdiParent = parent;
            instance = this;
            ViewClass viewObject = (ViewClass)tnSelected.Tag;

            _localNofity.NotifyType = eNotifyType.ErrorWithoutMessage;
            _localNofity.AllowErrors = false;
                
            
            _localNofity.Notify.OnRaiseInfoHandler += new NotifyInfos.RaiseNotifyHandler(MeldungRaised);
            _localNofity.Notify.OnRaiseErrorHandler += new NotifyInfos.RaiseNotifyHandler(ErrorRaised);
            //Notifies.AddNotify(localNofity,"VIEWManageForm");
            //Notifies.AddNotify(NotifiesClass.Instance(),"GLOBAL");
            TnSelected = tnSelected;
            ViewObject = (ViewClass)tnSelected.Tag;
            InitMessages();
            
            DBReg = drc;
            txtMaxRows.Text = DBReg.MaxRowsForSelect.ToString();
            this.GetDataWorker.WorkerReportsProgress = true;
            this.GetDataWorker.WorkerSupportsCancellation = true;
            this.GetDataWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.GetDataWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.GetDataWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
        }

        public void RefreshLanguageText()
        {
            hsPageRefresh.Text = LanguageClass.Instance().GetString("REFRESH");
            hsExportData.Text = LanguageClass.Instance().GetString("EXPORT");
            hsCancelGettingData.Text = LanguageClass.Instance().GetString("CANCEL_READING");
            hsCancelExport.Text = LanguageClass.Instance().GetString("CANCEL_READING");
            
            hsSaveSQL.Text = LanguageClass.Instance().GetString("SAVE_SQL");
            hsLoadSQL.Text = LanguageClass.Instance().GetString("LOAD_SQL");
            hsRunStatement.Text = LanguageClass.Instance().GetString("EXECUTE_SQL");
            
            hsRefreshExportData.Text = LanguageClass.Instance().GetString("REFRESH");
            rbINSERT.Text = LanguageClass.Instance().GetString("INSERT");
            rbUPDATE.Text = LanguageClass.Instance().GetString("UPDATE");
            rbINSERTUPDATE.Text = LanguageClass.Instance().GetString("INSERT_UPDATE");
            tabPageFIELDS.Text = LanguageClass.Instance().GetString("FIELDS");
            tabPageDATA.Text = LanguageClass.Instance().GetString("DATA");
            tabPageDependenciesTo.Text = LanguageClass.Instance().GetString("DEPENDENCIES_TO");
            
            tabPageExport.Text = LanguageClass.Instance().GetString("EXPORT_DATA");
            tabPageMessages.Text = LanguageClass.Instance().GetString("MESSAGES");
            gbMaxRows.Text = LanguageClass.Instance().GetString("MAX_ROWS");
            cbExportToScreen.Text = LanguageClass.Instance().GetString("EXPORT_TO_SCREEN");
            cbExportToFile.Text = LanguageClass.Instance().GetString("EXPORT_TO_FILE");
            gbExportFile.Text = LanguageClass.Instance().GetString("FILE");
            gbInsertUpdate.Text = LanguageClass.Instance().GetString("INSERT_UPDATE_TYPE");

        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void InitMessages()
        {
            
        }

        public void ShowCaptions()
        {
            if (ViewObject != null)
            {
                lblTableName.Text = "View: " + ViewObject.Name;
            }
            else
            {
                lblTableName.Text = "View";
            }
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Manage Views");
        }

        void ErrorRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = System.Drawing.Color.Red;
            fctMessages.AppendText(k.Meldung);
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"{LanguageClass.Instance().GetString("MESSAGES")} ({messages_count}) ");
            if (error_count > 0) sb.Append($@"{LanguageClass.Instance().GetString("ERRORS")} ({error_count})");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();                       
        }

        

        void MeldungRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = System.Drawing.Color.Blue;
            fctMessages.AppendText(k.Meldung);
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"{LanguageClass.Instance().GetString("MESSAGES")} ({messages_count}) ");
            if (error_count > 0) sb.Append($@"{LanguageClass.Instance().GetString("ERRORS")} ({error_count})");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();            
        }


        public int RefreshDependenciesTo()
        {                                
            dsDependencies.Clear();
            dgvDependencies.AutoGenerateColumns = true;

            string cmd_index = SQLStatementsClass.Instance().GetViewManagerDependenciesTO(DBReg.Version, ViewObject.Name);
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con );
                ds.Fill(dsDependencies);
                con.Close();
               
            }
            catch(Exception ex)
            {
                
              NotifiesClass.Instance().AddToERROR(BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr() + " ViewManagerForm->RefreshDependenciesTo->" + ex.Message);
            }
            bsDependencies.DataMember = "Table";

            return dsDependencies.Tables[0].Rows.Count;

        }

        public int RefreshDependenciesFrom()
        {            
      
            dsDependencies.Clear();
            dgvDependencies.AutoGenerateColumns = true;
            string cmd_index = SQLStatementsClass.Instance().GetViewManagerDependenciesFROM(DBReg.Version, ViewObject.Name);
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsDependencies);
                con.Close();              
            }
            catch(Exception ex)
            {

                NotifiesClass.Instance().AddToERROR(BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr() + " ViewManagerForm->RefreshDependenciesFrom->" + ex.Message);
            }
            bsDependencies.DataMember = "Table";

            return dsDependencies.Tables[0].Rows.Count;

        }
        public int RefreshFields()
        {
            if (string.IsNullOrEmpty(ViewObject.Name)) return lvFields.Items.Count;
            
            string cmd =  SQLStatementsClass.Instance().GetViewFields(DBReg.Version, ViewObject.Name);
            ViewFieldClass vf = null;
            lvFields.Items.Clear();
            dgExportGrid.Rows.Clear();
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                con.Open();
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();                                                                                           
                if (dread.HasRows)
                {                       
                    while (dread.Read())
                    {                            
                        object ob = dread.GetValue(0);
                        object ob_field_position = dread.GetValue(1);

                        string fieldstr = ob.ToString();
                        string posstr = ob_field_position.ToString();
                        string typename = dread.GetValue(3).ToString();
                        string typelength = dread.GetValue(4).ToString();

                        vf = new ViewFieldClass()
                        {
                            Name = fieldstr.Trim()
                        };

                        string[] obarr = { posstr.Trim(), fieldstr.Trim(), typename.Trim(), typelength.Trim() };
                        object[] obarr_export = { posstr.Trim(), fieldstr.Trim(), true, true };

                        var lvi = new ListViewItem(obarr)
                        {
                            Tag = vf,
                            Checked = true
                        };
                        lvFields.Items.Add(lvi);
                        dgExportGrid.Rows.Add(obarr_export);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr() + " ViewManagerForm->RefreshDependenciesFrom->" + ex.Message);
            }               
            return lvFields.Items.Count;
        }
       
        public string MakeFieldsCmd()
        {
            var sb = new StringBuilder();
            foreach (ListViewItem lvi in lvFields.Items)
            {
                if (sb.ToString().Length > 0)
                {
                    sb.Append(",");
                }
                var obarr = (ViewFieldClass)lvi.Tag;
                sb.Append(obarr.Name);
            }

            sb.Append(" FROM " + ViewObject.Name);
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

        public int RefreshDatas(string cmd)
        {
            int errorsCnt = 0;
            int errorsAllowed = BasicClassLibrary.StaticFunctionsClass.ToIntDef(txtMaxAllowedErrors.Text,0);
            if (string.IsNullOrEmpty(ViewObject.Name))  return dsViewContent.Tables[0].Rows.Count;            
            try
            {
                long.TryParse(txtMaxRows.Text, out var maxRows);
                
                dgvResults.AutoGenerateColumns = true;
                GetDataWorker.ReportProgress(1, "Reading data...");
                long skip = 0;    
                
                if (_dataConnection != null)
                {
                  if(_dataConnection.State != System.Data.ConnectionState.Closed)   _dataConnection.Close();
                }
                _dataConnection = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));                    
                _dataConnection.Open();
                var cnt = DBReg.SkipForSelect;
                var sk = DBReg.SkipForSelect;
                if ((maxRows > 0) && (cnt > maxRows))
                {
                    cnt = maxRows;
                    sk = cnt;
                }
                string cmds = string.Empty;
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
                NotifiesClass.Instance().AddToERROR($@"{BasicClassLibrary.StaticFunctionsClass.DateTimeNowStr()}->{this.Name}->RefreshDatas({cmd}), msg:{ex.Message}");
            }                               
            return dsViewContent.Tables[0].Rows.Count;
        }

        private void RefreshDLL()
        {
            fctDLL.Text = ViewObject.SQL;
            fctCREATEINSERTSQL.Text = (cbAlterView.Checked) 
                ? (cbPretty.Checked) ? AppStaticFunctionsClass.MakeSqlPretty(ViewObject.CREATEINSERT_SQL) : ViewObject.CREATEINSERT_SQL 
                : (cbPretty.Checked) ? AppStaticFunctionsClass.MakeSqlPretty(ViewObject.CREATE_SQL) : ViewObject.CREATE_SQL;            
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
        public void RefreshAll()
        {
            bsViewContent.DataMember = null;
            int rf = RefreshFields();
            _cmd = MakeFieldsCmd();
            
            bsViewContent.DataMember = null;          
            hsRefreshData.Enabled = false;
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
            
                tabPageDependenciesTo.Text = "Dependencies (" + rd.ToString() + ")";
                tabPageFIELDS.Text = "Fields (" + rf.ToString() + ")";

                RefreshDLL();
                ShowCaptions();
                cbCAuto.Checked = !cbCAuto.Checked;
                cbCAuto.Checked = !cbCAuto.Checked;
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

        private void VIEWManageForm_Load(object sender, EventArgs e)
        {
            if (DbExplorerForm.Instance().Visible)
            {
                this.Left = DbExplorerForm.Instance().Width + 16;
            }
            RefreshLanguageText();
            fctMessages.Clear();
            ac = new AutocompleteClass(fctCREATEINSERTSQL, DBReg);
            ac.RefreshAutocompleteForView(ViewObject.Name);
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);            
            RefreshAll();
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

        private void spezialfilterBox1_CbCheckedChanged(object sender, EventArgs e)
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
            if(saveSQLFile.ShowDialog() != DialogResult.OK) return;
            
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
                DoCreateAlter(fctCREATEINSERTSQL.Lines,DBReg,_localNofity,Name);
                DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo($@"{Name}->RunStatement", StaticVariablesClass.ReloadViews, TnSelected);      
                return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(),"Cancelling getting Data failed","Timeout for cancelling getting Data has arrived (5000 ms)");

        }

        private void DoCreateAlter(IList<string> cmd,DBRegistrationClass DBReg, NotifiesClass _localNofity, string Name)
        {
            var SQLcommand = new SQLCommandsClass(DBReg, _localNofity);
            var ri = SQLcommand.ExecuteCommand(cmd,true);            
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
            messages_count = 0;
            error_count = 0;
            var sb = new StringBuilder();
            sb.Append($@"{LanguageClass.Instance().GetString("MESSAGES")} ({messages_count}) ");            
            sb.Append($@"{LanguageClass.Instance().GetString("ERRORS")} ({error_count})");
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            RefreshDatas(_cmd);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {            
            tabPageDATA.Text = e.UserState.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            bsViewContent.DataSource = dsViewContent;
            if (bsViewContent.DataMember != null)
            {
                bsViewContent.DataMember = "Table";
                tabPageDATA.Text = $@"Data ({dsViewContent.Tables[0].Rows.Count.ToString()})";
            }
            
            dgvResults.DataSource = bsViewContent;
            hsRefreshData.Enabled = true;
            sfbViewData.Enabled = true;
            
        }
        private void hsCancelGettingData_Click(object sender, EventArgs e)
        {
            GetDataWorker.CancelGettingData();
        }
        

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

        private void hsRefreshMaxRows_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void fctCREATEINSERTSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if (ac != null)
                {
                    ac.Show();
                }
                e.Handled = true;
            }
        }       

        private void hsExport_Click(object sender, EventArgs e)
        {
            if (bwExport.IsBusy) return;
            

            pbExport.Value = 0;
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
            ViewObject.Fields.TryGetValue(fname, out ViewFieldClass result);
            return result;
        }

        private void ExportForInsertUpdate(string fn, bool insertupdate)
        {
            var sb = new StringBuilder();
            var cols = new StringBuilder();
            bool fcol = true;

            foreach (DataGridViewRow row in dgExportGrid.Rows)
            {
                bool act  = (bool)row.Cells["colExportActive"].Value;
                bool whre = (bool)row.Cells["colExportWhere"].Value;
                if (!act && !whre) continue;
                
                if (fcol) cols.Append(row.Cells["ColExportFieldName"].Value.ToString());
                else      cols.Append("," + row.Cells["ColExportFieldName"].Value.ToString());
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
                
                string tablename = ViewObject.Name;
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
                        else scmd = "'" + valuestr + "'";
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
                        sb.Append(", " + scmd);
                    }
                    first = false;                       
                }
                cmdpattern = cmdpattern.Replace(SQLPatterns.ValueKey, sb.ToString());
                bwExport.ReportProgress(i, cmdpattern);
                i++;
            }
        }

        private void ExportForUpdate(string fn)
        {
            int i = 0;
            foreach (DataRow dr in dsViewContent.Tables[0].Rows)
            {
                var sb = new StringBuilder();
                string cmdpattern = string.Empty;

                cmdpattern = SQLPatterns.UpdatePattern;

                string tablename = ViewObject.Name;
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
                            sb.Append(", " + scmd);
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
                ExportForInsertUpdate(filename, false);
            }
            else if (rbINSERTUPDATE.Checked)
            {
                ExportForInsertUpdate(filename, true);
            }
            else if (rbUPDATE.Checked)
            {
                ExportForUpdate(filename);
            }
        }

        private void bwExport_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (cbExportToScreen.Checked)
            {
                exportList.Add($@"{e.UserState.ToString()};{Environment.NewLine}");                
            }
            if (writefile)
            {
                sw.WriteLine($@"{e.UserState.ToString()};");
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
        List<string> exportList = new List<string>();
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

            pbExport.Value = 0;
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
    }
}
