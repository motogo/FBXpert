using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FBXpert.ValuesEditForms;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageFormLibrary;
using SESpaltenEditor;
using StateClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class TABLEManageForm : INormalForm
    {
        private readonly TableClass _tableObject    = null;
        private TableFieldClass _actFieldObject     = null;
        private List<TableClass> _actTables         = null;
        private DBRegistrationClass _dbReg          = null;
        private readonly NotifiesClass _localNotify = null;

        private int _messagesCount              = 0;
        private int _errorCount                 = 0;

        private string _cmd                     = string.Empty;
        private bool _firstTab                  = false;
        private FbConnection _dataConnection    = null;
        private StreamWriter _sw                = null;
        private string _fileName                = string.Empty;
        private bool _writeFile                 = false;

        private int _pi = 0;
        private string _pkColumnName = string.Empty;
        private TreeNode _tnSelected = null;

        private string  cn = null;
        private bool IndexDataFilled    = false;
        private bool UniqueDataFilled   = false;
        private bool PKDataFilled       = false;
        private bool FKDataFilled       = false;
        private bool CheckDataFilled    = false;
        private bool DataFilled         = false;

        private string SelectedIndexName            = string.Empty;
        private string SelectedPKConstraintName     = string.Empty;
        private string SelectedFKConstraintName     = string.Empty;
        private string SelectedUniqueConstraintName = string.Empty;
        private string SelectedCheckConstraintName  = string.Empty;

        
        private string SelectedPKFieldName      = string.Empty;
        private string SelectedFKFieldName      = string.Empty;
        private string SelectedUniqueFieldName  = string.Empty;
        private string SelectedCheckFieldName   = string.Empty;

        private bool _indexChanged      = false;
        private bool _constraintChanged = false;    
        private bool _tableChanged      = false;

        List<string> exportList = new List<string>();

        Stopwatch stopwatch = new Stopwatch();

        public void SetMDIParent(Form parent)
        {
            this.MdiParent = parent;
        }

        public void SetRegistration(DBRegistrationClass drc)
        {
            _dbReg = drc;
        }
        
        public TABLEManageForm(Form parent, DBRegistrationClass drc, TreeNode tnSelected, List<TableClass> actTables)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _tnSelected = tnSelected;
            var tc = (TableClass)tnSelected.Tag;
            _tableObject = tc.Clone() as TableClass;
            _localNotify = new NotifiesClass()
            {
                ErrorGranularity = eMessageGranularity.never
            };
            _localNotify.Register4Info(InfoRaised);
            _localNotify.Register4Error(ErrorRaised);
            
            _dbReg = drc;
            _actTables = actTables;
            txtMaxRows.Text = _dbReg.MaxRowsForSelect.ToString();
            this.GetDataWorker.WorkerReportsProgress = true;
            this.GetDataWorker.WorkerSupportsCancellation = true;
            this.GetDataWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetData_DoWork);
            this.GetDataWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwGetData_ProgressChanged);
            this.GetDataWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetData_RunWorkerCompleted);
            gridStore = new GridStoreClass(dgvResults);
        }
        WorkerClass GetDataWorker = new WorkerClass();

        AutocompleteClass ac;

        public void SetAutocompeteObjects(List<TableClass> tables,Dictionary<string,SystemTableClass> systemtables)
        {
            ac = new AutocompleteClass(fctTableCreateDLL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.AddAutocompleteForSystemtables(systemtables);
            ac.Activate();
        }

        GridStoreClass gridStore;
        
        public void RefreshLanguageText()
        {
            hsPageRefresh.Text           = LanguageClass.Instance().GetString("REFRESH");
            hsExportData.Text            = LanguageClass.Instance().GetString("EXPORT");
            hsCancelGettingData.Text     = LanguageClass.Instance().GetString("CANCEL_READING");
            hsCancelExport.Text          = LanguageClass.Instance().GetString("CANCEL_READING");
            hsNewField.Text              = LanguageClass.Instance().GetString("ADD_FIELD");
            hsDropField.Text             = LanguageClass.Instance().GetString("DROP_FIELD");
            hsEditField.Text             = LanguageClass.Instance().GetString("EDIT_FIELD");
            hsSaveSQL.Text               = LanguageClass.Instance().GetString("SAVE_SQL");
            hsLoadSQL.Text               = LanguageClass.Instance().GetString("LOAD_SQL");
            hsRunStatement.Text          = LanguageClass.Instance().GetString("EXECUTE_SQL");
            hsAddIndex.Text              = LanguageClass.Instance().GetString("ADD_INDEX");
            hsDropIndex.Text             = LanguageClass.Instance().GetString("DROP_INDEX");
            hsEditIndex.Text             = LanguageClass.Instance().GetString("EDIT_INDEX");
            hsRefreshExportData.Text     = LanguageClass.Instance().GetString("REFRESH");
            rbINSERT.Text                = LanguageClass.Instance().GetString("INSERT");
            rbUPDATE.Text                = LanguageClass.Instance().GetString("UPDATE");
            rbINSERTUPDATE.Text          = LanguageClass.Instance().GetString("INSERT_UPDATE");
            tabPageFIELDS.Text           = LanguageClass.Instance().GetString("FIELDS");
            tabPageDATA.Text             = LanguageClass.Instance().GetString("DATA");
            tabPageDependenciesTo.Text   = LanguageClass.Instance().GetString("DEPENDENCIES_TO");
            tabPageDependenciesFrom.Text = LanguageClass.Instance().GetString("DEPENDENCIES_FROM");
            tabPageExport.Text           = LanguageClass.Instance().GetString("EXPORT_DATA");
            tabPageMessages.Text         = LanguageClass.Instance().GetString("MESSAGES");
            gbMaxRows.Text               = LanguageClass.Instance().GetString("MAX_ROWS");
            cbExportToScreen.Text        = LanguageClass.Instance().GetString("EXPORT_TO_SCREEN");
            cbExportToFile.Text          = LanguageClass.Instance().GetString("EXPORT_TO_FILE");
            gbExportFile.Text            = LanguageClass.Instance().GetString("FILE");
            gbInsertUpdate.Text          = LanguageClass.Instance().GetString("INSERT_UPDATE_TYPE");
            ckGetDatas.Text              = LanguageClass.Instance().GetString("READ_DATAS");
        }

        void ErrorRaised(object sender, MessageEventArgs k)
        {
            try
            {
                fctMessages.CurrentLineColor = System.Drawing.Color.Red;
                fctMessages.AppendText(k.Meldung);
                var sb = new StringBuilder();
                _errorCount++;
                if (_messagesCount > 0) sb.AppendLine($@"{LanguageClass.Instance().GetString("MESSAGES")} ({_messagesCount})");
                if (_errorCount > 0)    sb.AppendLine($@"{LanguageClass.Instance().GetString("ERRORS")} ({_errorCount})");
                tabPageMessages.Text = sb.ToString();
                fctMessages.ScrollLeft();
            }
            catch //(Exception ex)
            {
            }

            NotifiesClass.Instance().Notify.OnRaiseError(k);
        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = System.Drawing.Color.Blue;
            fctMessages.AppendText(k.Meldung);
            var sb = new StringBuilder();
            _messagesCount++;
            if (_messagesCount > 0) sb.AppendLine($@"{LanguageClass.Instance().GetString("MESSAGES")} ({_messagesCount})");
            if (_errorCount > 0)    sb.AppendLine($@"{LanguageClass.Instance().GetString("ERRORS")} ({_errorCount})");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();

            if (k.Key.ToString() == StaticVariablesClass.ReloadFields)
            {
                if (getData) RefreshAll();
                else RefreshStruct();
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadIndex)
            {
                if (getData) RefreshAll();
                else RefreshStruct();
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadForeignKeysForTable)
            {
                ForeignKeys = RefreshForeignKeys();
                AnzeigeConstraints();
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadConstraintsKeysForTable)
            {
                ForeignKeys =  RefreshForeignKeys();
                Uniques = RefreshUniques();
                DependenciesTo = RefreshDependenciesTo();
                DependenciesFrom = RefreshDependenciesFrom();
                AnzeigeConstraints();
            }
            NotifiesClass.Instance().Notify.OnRaiseInfo(k);            
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            if ((_dbReg != null) && (!string.IsNullOrEmpty(_tnSelected.Text)))
            {                
                StaticTreeClass.Instance().UpdateTableNodes(_tnSelected, _tableObject, _dbReg);                
            }
            
            Close();
        }

        public int RefreshPrimaryKeys()
        {                        
            string cmd_index = SQLStatementsClass.Instance().RefreshTablePrimaryKeys(_dbReg.Version,_tableObject.Name);
            dsPrimaryKeys.Clear();
            dgvPrimaryKeys.AutoGenerateColumns = true;
            try
            { 
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                var ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsPrimaryKeys);
                con.Close();            
                bsPrimaryKeys.DataMember = "Table";
                PKDataFilled = true;
                SelectPrimaryKeyID();
                return dsPrimaryKeys.Tables[0].Rows.Count;
            }
            catch(Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshPrimaryKeys() -> {_dbReg.Alias}", ex));                      
                
            }
            return 0;
        }

        public string[] GetPrimaryKeys()
        {
            string cmd_index = SQLStatementsClass.Instance().GetTablePrimaryKeys(_dbReg.Version, _tableObject.Name);

            try
            { 
                string PkColumn = string.Empty;
                string ConstraintName = string.Empty;
                int n = 0;
                using(TransactionScope c = new TransactionScope())
                {
                    using(var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg)))
                    {
                        con.Open();                        
                        var fcmd = new FbCommand(cmd_index, con);
                        var dread = fcmd.ExecuteReader();                        
                        if (dread.HasRows)
                        {
                            while (dread.Read())
                            {
                                string PkType = dread.GetValue(1).ToString().Trim();
                                if (PkType != "PRIMARY KEY") continue;                        
                                PkColumn        = dread.GetValue(2).ToString().Trim();
                                ConstraintName  = dread.GetValue(0).ToString().Trim();
                                n++;                           
                            }
                        }
                        con.Close();
                    }
                    c.Complete();
                }
                if (n > 1) _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> GetPrimaryKeys() -> {_dbReg.Alias}", $@"found more {n} lines for PrimaryKey"));                                                          
                return new string[] { ConstraintName, PkColumn };
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> GetPrimaryKeys() -> {_dbReg.Alias}", ex));                                      
            }
            return new string[] { string.Empty, string.Empty };
        }

        public int RefreshForeignKeys()
        {          
            dsForeignKeys.Clear();
            dgvForeignKeys.AutoGenerateColumns = true;
            string cmd_index = SQLStatementsClass.Instance().GetAllTableForeignKeys(_dbReg.Version, eTableType.withoutsystem, _tableObject.Name);
           //string cmd_index = SQLStatementsClass.Instance().GetTableForeignKeysForDataset(_dbReg.Version, _tableObject.Name);
            try
            {
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                var ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsForeignKeys);
                con.Close();

                bsForeignKeys.DataMember = "Table";
                FKDataFilled = true;
                dgvForeignKeys.Columns["RELATION_NAME"].Visible = false;
                dgvForeignKeys.Columns["FOREIGN_KEY_NAME"].Visible = false;
                dgvForeignKeys.Columns["CONSTRAINT_TYPE"].Visible = false;

                SelectForeignKeyID();
                return dsForeignKeys.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}->RefreshForeignKeys() -> {_dbReg.Alias}", ex));                    
            }                                            
            return 0;
        }
       
        public int RefreshIndices()
        {
            string cmd_index = IndexSQLStatementsClass.Instance().GetTableFieldIndicies(_dbReg.Version,_tableObject.Name);
            IndexDataFilled = false;
            dsIndicies.Clear();
            dgvIndicies.AutoGenerateColumns = true;

            try
            {
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                var ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsIndicies);
                con.Close();
                bsIndicies.DataMember = "Table";
                IndexDataFilled = true;
                SelectIndexID();
                return dsIndicies.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshIndices() -> {_dbReg.Alias}", ex));                    
            }                                           
            return 0;
        }

        public int RefreshDependenciesTo()
        {            
            dsDependenciesTo.Clear();
            dgvDependenciesTo.AutoGenerateColumns = true;            
            string cmd_index = SQLStatementsClass.Instance().GetTableManagerDependenciesTO(_dbReg.Version, _tableObject.Name);
            try
            {
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                var ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsDependenciesTo);
                con.Close();
                bsDependenciesTo.DataMember = "Table";
                return dsDependenciesTo.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshDependenciesTo() -> {_dbReg.Alias}", ex));                    
            }                           
            return 0;
        }

        public int RefreshDependenciesFrom()
        {           
            dsDependenciesFrom.Clear();
            dgvDependenciesFrom.AutoGenerateColumns = true;
            string cmd_index = SQLStatementsClass.Instance().GetTableManagerDependenciesFROM(_dbReg.Version, _tableObject.Name);
            try
            {
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                var ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsDependenciesFrom);
                con.Close();
                bsDependenciesFrom.DataMember = "Table";
                return dsDependenciesFrom.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}->RefreshDependenciesFrom()->{_dbReg.Alias}", ex));                    
            }                            
            return 0;
        }

        public int RefreshUniques()
        {
            dsUniques.Clear();
            UniqueDataFilled = false;
            dgvUniques.AutoGenerateColumns = true;

            string cmd_index = SQLStatementsClass.Instance().GetTableUniques(_dbReg.Version, _tableObject.Name);

            try
            {
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsUniques);
                con.Close();
                bsUniques.DataMember = "Table";
                UniqueDataFilled = true;
                SelectUniqueID();
                return dsUniques.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshUniques() -> {_dbReg.Alias}", ex));                    
            }
            return 0;
        }

        public void DropField()
        {
            if (lvFields.SelectedItems == null) return;            
            if (lvFields.SelectedItems.Count <= 0) return;
            
            var tfc = (TableFieldClass)lvFields.SelectedItems[0].Tag;
            string cmd = $@"ALTER TABLE {_tableObject.Name} DROP {tfc.Name}";

            SQLStatementsClass.Instance().ExecSql(cmd,_dbReg,_localNotify);                                                  
        }
        
        public int RefreshFields()
        {            
            if (string.IsNullOrEmpty(_tableObject.Name)) return 0;
            string _funcStr = $@"RefreshFields()";
            int n = 0;
            string cmd = SQLStatementsClass.Instance().GetTableFields(_dbReg.Version, _tableObject.Name);
            lvFields.Items.Clear();
            dgExportGrid.Rows.Clear();
            _tableObject.Fields = new Dictionary<string, TableFieldClass>();

            string[] pk = GetPrimaryKeys();
            _pkColumnName = pk[1];
            string ConstraintName = pk[0];
            try
            {
                using(TransactionScope c = new TransactionScope())
                {
                    using(var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg)))
                    {                
                        con.Open();
                        var fcmd = new FbCommand(cmd, con);
                        var dread = fcmd.ExecuteReader();
                        if (dread.HasRows)
                        {
                            while (dread.Read())
                            {
                                TableFieldClass tfc = new TableFieldClass();
                                string TabName = dread.GetValue(0).ToString().Trim();
                                tfc.Name = dread.GetValue(1).ToString().Trim();
                                StaticTreeClass.Instance().GetConstraintsObjectsForTable(eConstraintType.NOTNULL, _tableObject, _dbReg);
                                tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                                tfc.Domain.FieldType = dread.GetValue(4).ToString().Trim();
                                tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                                tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                                tfc.Domain.Name = dread.GetValue(6).ToString().Trim();

                                if (tfc.Name == _pkColumnName)
                                {                                   
                                    tfc.PK_ConstraintName = ConstraintName;                                   
                                }
                                
                                tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                                tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                                tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                                tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();

                                bool NNField  = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;
                                bool NN = _tableObject.IsNotNull(tfc.Name);

                                tfc.Domain.NotNull = NN;
                                if (NNField != NN)
                                {
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{_tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NN},Flag:{NNField})"));
                                }
                                tfc.Domain.DefaultValue = dread.GetValue(12).ToString().Trim();
                                if(tfc.Domain.DefaultValue.Length > 0 )
                                {
                                    if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                                    {
                                        tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                                    }
                                    if(tfc.Domain.DefaultValue.Length > 1)
                                    {
                                        Console.WriteLine();
                                    }
                                }
                                tfc.Description = dread.GetValue(13).ToString().Trim();
                                tfc.Domain.Description = dread.GetValue(14).ToString().Trim();
                                if((tfc.Domain.Description.Length > 0)||(tfc.Description.Length > 0))
                                {
                                    Console.WriteLine();
                                }
                                bool PK = _tableObject.IsPrimary(tfc.Name);
                                bool UQ = _tableObject.IsUnique(tfc.Name);                                

                                string[] obarr = { tfc.Position.ToString(), tfc.Name, tfc.Domain.FieldType, tfc.Domain.Length.ToString(), tfc.Domain.RawType, StaticVariablesClass.ToMark(NN), tfc.DefaultValue, tfc.Domain.Scale.ToString(), StaticVariablesClass.ToMark(PK), StaticVariablesClass.ToMark(UQ), tfc.Domain.CharSet, tfc.Domain.Collate, "1", tfc.Domain.Name, StaticVariablesClass.ToMark(NN), tfc.Domain.DefaultValue };
                                object[] obarr_export = { tfc.Position.ToString(), tfc.Name, !PK, PK };

                                var lvi = new ListViewItem(obarr)
                                {
                                    Tag = tfc,
                                    Checked = true
                                };

                                lvFields.Items.Add(lvi);

                                dgExportGrid.Rows.Add(obarr_export);

                                _tableObject.Fields.Add(tfc.Name,tfc);
                            }
                        }
                        con.Dispose();
                        con.Close();
                    }
                    c.Complete();
                }
            }
            catch(Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}->RefreshFields()->{_dbReg.Alias}", ex));                    
            }
               
            return n;
        }

        public void SpaltenEdit()
        {
            var sp = SPALTENEditForm.Instance(this, null,true);
            sp.Notify.Register4Info(SpaltenNotify_SpaltenOnRaiseInfoHandler);

            sp.SetGrid(dgvResults,  _tableObject.Name, _dbReg.Alias);
            sp.ShowDialog();
        }

        private void SpaltenNotify_SpaltenOnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == SESpaltenEditor.Consts.ChangeCheckKey)
            {
                int n = StaticFunctionsClass.ToIntDef(k.Meldung, -1);
                if ((n >= 0)&&(dgvResults.Columns.Count > n))
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
            else if(k.Key.ToString() == SESpaltenEditor.Consts.CloseForm)
            {
                gridStore.StoreGridDesign();
            }
        }

        public void RefreshDLL()
        {
            fctTableCreateDLL.Text = AppStaticFunctionsClass.CreateComment() + CreateDLLClass.CreateTabelDLL(_tableObject,eCreateMode.create);
        }

        public string MakeFieldsCmd()
        {
            var sb = new StringBuilder();
            foreach(ListViewItem lvi in lvFields.Items)
            {
                var obarr = (TableFieldClass) lvi.Tag;
                if(obarr == null) continue;                
                if(sb.ToString().Length > 0) sb.Append(",");
                Type tp = obarr.Domain.GetType();
                if(!string.IsNullOrEmpty(obarr.PK_ConstraintName))
                {
                   if(string.IsNullOrEmpty(cn)) cn = obarr.Name;
                }
                if(obarr.Domain.FieldType ==  "BLOB")
                {
                    sb.Append($@"'<BLOB>{cn}' as DOKUBLOB");                
                }
                else
                {
                   sb.Append(obarr.Name);                
                }
            }
            
            sb.Append($@" FROM {_tableObject.Name}");
            sfbTableData.SQLKonjunktion = SQLConstants.WHERE;
            string SCmd = sfbTableData.SQLCmd;
            if (SCmd.Length > 0)
            {
                sb.Append(SCmd);
            }
            if(_pkColumnName.Length > 0)
            {
                sb.Append($@" ORDER BY {_pkColumnName} {EnumHelper.GetDescription(eSort.ASC)}");
            }
            
            string cmd = $@"{sb};";
            txtSQL.Text = $@"SELECT {cmd}";
            return cmd;
        }
        bool getData;
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
        public void RefreshDatas(string cmd)
        {           
           if (string.IsNullOrEmpty(_tableObject.Name)) return;
           
           long maxRows = 0;
           long.TryParse(txtMaxRows.Text.Trim(), out maxRows);

           int errorsCnt = 0;
           int errorsAllowed = StaticFunctionsClass.ToIntDef(txtMaxAllowedErrors.Text,0);
           GetDataWorker.ReportProgress(1, "Reading..." );
           
           long skip = 0;
           if (_dataConnection?.State != System.Data.ConnectionState.Closed)   _dataConnection?.Close();
           
           _dataConnection = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
           _dataConnection.Open();
           
           long cnt = _dbReg.SkipForSelect;
           long sk = _dbReg.SkipForSelect;
           if ((maxRows > 0) && (cnt > maxRows))
           {
               cnt = maxRows;
               sk = cnt;
           }

           dsTableContent = new DataSet();
           string cmd2 = string.Empty;
           while ((cnt >= sk)&&(skip < maxRows||maxRows <= 0))
           {
               try
               {
                   if (this.GetDataWorker.CancellationPending) return;                   
                   cmd2 = $@"SELECT FIRST {sk} SKIP {skip} {cmd.Trim()}";
                   var ds = new FbDataAdapter(cmd2, _dataConnection);
                   cnt = ds.Fill(dsTableContent);                   
                   GetDataWorker.ReportProgress(1, "..."+skip.ToString());
                   skip += sk;
               }
               catch(Exception ex)
               {
                   _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshDatas({cmd}) -> {_dbReg.Alias}", ex)); 
                    errorsCnt++;
                        
                    if(errorsCnt > errorsAllowed)
                    {
                        GetDataWorker.CancelAsync();
                    }
               }
           }                              
           
        }

        private void SelectIndexID()
        {
            if (!IndexDataFilled) return;            
            var ob = (DataRowView)bsIndicies.Current;
            if (ob == null) return;            
            SelectedIndexName = ob.Row["INDEX_NAME"].ToString().Trim(); 
            if(string.IsNullOrEmpty(SelectedIndexName))
            {
                hsAddIndex.Enabled  = true;
                hsEditIndex.Enabled = false;
                hsDropIndex.Enabled = false;
            }
            else
            {
                hsAddIndex.Enabled  = true;
                hsEditIndex.Enabled = true;
                hsDropIndex.Enabled = true;
            }
        }

        private void SelectPrimaryKeyID()
        {
            if (!PKDataFilled) return;            
            var ob = (DataRowView)  bsPrimaryKeys.Current;
            if (ob == null) return;            
            SelectedPKConstraintName = ob.Row["CONSTRAINT_NAME"].ToString(); 
            SelectedPKFieldName = ob.Row["FIELDNAME"].ToString(); 
            if(string.IsNullOrEmpty(SelectedPKConstraintName))
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = false;
                 hsDropConstraint.Enabled = false;
            }
            else
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = true;
                 hsDropConstraint.Enabled = true;
            }
        }

        private void SelectUniqueID()
        {
            if (!UniqueDataFilled) return;            
            var ob = (DataRowView)  bsUniques.Current;
            if (ob == null) return;            
            SelectedUniqueConstraintName = ob.Row["CONSTRAINT_NAME"].ToString().Trim(); 
            SelectedUniqueFieldName = ob.Row["FIELD_NAME"].ToString().Trim();
            if(string.IsNullOrEmpty(SelectedUniqueConstraintName))
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = false;
                 hsDropConstraint.Enabled = false;
            }
            else
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = true;
                 hsDropConstraint.Enabled = true;
            }
        }

        private void SelectForeignKeyID()
        {
            if (!FKDataFilled) return;            
            var ob = (DataRowView)  bsForeignKeys.Current;
            if (ob == null) return;
            //SelectedFKConstraintName = ob.Row["FOREIGN_KEY_NAME"].ToString().Trim(); 
            SelectedFKConstraintName = ob.Row["CONSTRAINT_NAME"].ToString().Trim();
            SelectedFKFieldName = ob.Row["FIELD_NAME"].ToString().Trim();
            if(string.IsNullOrEmpty(SelectedFKConstraintName))
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = false;
                 hsDropConstraint.Enabled = false;
            }
            else
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = true;
                 hsDropConstraint.Enabled = true;
            }
        }

        private void SelectCheckID()
        {
            if (!CheckDataFilled) return;            
            var ob = (DataRowView)  bsForeignKeys.Current;
            if (ob == null) return;            
            SelectedCheckConstraintName = ob.Row["CONSTRAINT_NAME"].ToString().Trim(); 
            SelectedCheckFieldName = ob.Row["FIELD_NAME"].ToString().Trim();
            if(string.IsNullOrEmpty(SelectedCheckConstraintName))
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = false;
                 hsDropConstraint.Enabled = false;
            }
            else
            {
                 hsAddConstraint.Enabled  = true;
                 hsEditConstraint.Enabled = true;
                 hsDropConstraint.Enabled = true;
            }
        }

        private void AddIndex()
        {
            var tff = new IndexForm(FbXpertMainForm.Instance(), _tableObject, _dbReg, _actTables);
            tff.RegisterNotify(InfoRaised);
            
            tff.Show();
            _indexChanged = true;
        }

        private int GetNewNr(DataGridView dgv, string colName)
        {
            int nnr = 0;
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow rw in dgv.Rows)
                {
                    string str = rw.Cells[colName].Value.ToString();
                    string[] strarr = str.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                    int NewNr = StaticFunctionsClass.ToIntDef(strarr[strarr.Length - 1].Trim(), -1);
                    if (NewNr > nnr) nnr = NewNr;
                }
            }
            return nnr;
        }

        private void AddConstraint()
        {
            var _constraintObject = new ConstraintsClass();
             
            _constraintObject.ConstraintType = eConstraintType.NONE;
            _constraintObject.Name = $@"CN_{_tableObject.Name}_NEW";
            if(tabControlConstraints.SelectedTab == tabPageForeignKeys)
            {
                int nnr = GetNewNr(dgvForeignKeys, "CONSTRAINT_NAME");
                
                _constraintObject.Name = $@"FK_{_tableObject.Name}_{nnr+1}";
                _constraintObject.ConstraintType = eConstraintType.FOREIGNKEY;
                
                ForeignKeyForm fk = new ForeignKeyForm(FbXpertMainForm.Instance(), _dbReg, _actTables, _tableObject.Name, null,nnr+1);
                fk._localNotify.Register4Info(InfoRaised);
                fk.Show();
                 _indexChanged = true;
                return;
            }
            else if(tabControlConstraints.SelectedTab == tabPagePrimaryKeys)
            {
                _constraintObject.Name = $@"PK_{_tableObject.Name}_NEW";
                _constraintObject.ConstraintType = eConstraintType.PRIMARYKEY;
                
                var cf = new PrimaryKeyForm(MdiParent, _actTables, _tableObject,  _dbReg)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                cf.Show();  
                _indexChanged = true;
                return;
            }
            else if(tabControlConstraints.SelectedTab == tabPageUniques)
            {
                _constraintObject.Name = $@"UN_{_tableObject.Name}_NEW";
                _constraintObject.ConstraintType = eConstraintType.UNIQUE;
                var tff = new ConstraintsForm(FbXpertMainForm.Instance(), _tableObject,_actTables, _dbReg,_constraintObject);
            tff.RegisterNotify(InfoRaised);
            tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eInsert);
            tff.Show();
            }
            else if(tabControlConstraints.SelectedTab == tabPageChecks)
            {
                _constraintObject.Name = $@"CK_{_tableObject.Name}_NEW";
                _constraintObject.ConstraintType = eConstraintType.CHECK;
                var tff = new ConstraintsForm(FbXpertMainForm.Instance(), _tableObject,_actTables, _dbReg,_constraintObject);
            tff.RegisterNotify(InfoRaised);
            tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eInsert);
            tff.Show();
            }
            
            

            
            _indexChanged = true;
        }

        private void DropIndex()
        {
            var result = IndexSQLStatementsClass.Instance().DropIndex(SelectedIndexName.Trim(), _dbReg, _localNotify);
            object[] p = { SelectedIndexName.Trim(), _dbReg.Alias, Environment.NewLine };
            if(result.commandDone)
            {            
                 SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "IndexDeletedTitle","IndexDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;
                if (getData) RefreshAll();
                else RefreshStruct();
                _indexChanged = true;
                 
                 return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "IndexDeletedTitle","IndexNotDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;  
        }

        private void DropPKConstraint()
        {
            var result = SQLStatementsClass.Instance().DropConstraint(SelectedPKConstraintName.Trim(), _dbReg, _localNotify);
            object[] p = { SelectedPKConstraintName.Trim(), _dbReg.Alias, Environment.NewLine };
            if(result.commandDone)
            {            
                 SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;
                 if (getData) RefreshAll();
                 else RefreshStruct();
                _indexChanged = true;
                 
                 return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintNotDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;  
        }

        private void DropFKConstraint()
        {
            
            var result = SQLStatementsClass.Instance().DropTableConstraint(_tableObject.Name, SelectedFKConstraintName.Trim(), _dbReg, _localNotify);
           // var result = SQLStatementsClass.Instance().DropConstraint(SelectedFKConstraintName.Trim(), _dbReg, _localNotify);
            object[] p = { SelectedFKConstraintName.Trim(), _dbReg.Alias, Environment.NewLine };
            if(result.commandDone)
            {            
                 SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;
                 if (getData) RefreshAll();
                 else RefreshStruct();
                _indexChanged = true;
                 
                 return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintNotDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;  
        }

        private void DropUniqueConstraint()
        {
            var result = SQLStatementsClass.Instance().DropConstraint(SelectedUniqueConstraintName.Trim(), _dbReg, _localNotify);
            object[] p = { SelectedUniqueConstraintName.Trim(), _dbReg.Alias, Environment.NewLine };
            if(result.commandDone)
            {            
                 SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;
                 if (getData) RefreshAll();
                 else RefreshStruct();
                _indexChanged = true;
                 
                 return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintNotDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;  
        }

        private void DropChaeckConstraint()
        {
            var result = SQLStatementsClass.Instance().DropConstraint(SelectedCheckConstraintName.Trim(), _dbReg, _localNotify);
            object[] p = { SelectedCheckConstraintName.Trim(), _dbReg.Alias, Environment.NewLine };
            if(result.commandDone)
            {            
                 SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;
                 if (getData) RefreshAll();
                 else RefreshStruct();
                _indexChanged = true;
                 
                 return;
            }
            SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "ConstraintDeletedTitle","ConstraintNotDeleted", FormStartPosition.CenterScreen,SEMessageBoxButtons.OK, SEMessageBoxIcon.Information, null, p) ;  
        }

        private void EditIndex()
        {            
            IndexForm tff = new IndexForm(FbXpertMainForm.Instance(), SelectedIndexName, _dbReg, _actTables,StateClasses.EditStateClass.eBearbeiten.eEdit);
            
            tff.RegisterNotify(InfoRaised);
            tff.Show();
            _indexChanged = true;
        }

        private void EditConstraint()
        {            
            var _constraintObject = new ConstraintsClass();
            
            if(tabControlConstraints.SelectedTab == tabPagePrimaryKeys)
            {
                _constraintObject = _tableObject.primary_constraint;
                var tff = new ConstraintsForm(FbXpertMainForm.Instance(),_tableObject,_actTables, _dbReg, _constraintObject);
                tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eEdit);
                tff.RegisterNotify(InfoRaised);
                tff.Show();
            }
            else if(tabControlConstraints.SelectedTab == tabPageUniques)
            {
                UniquesClass uc = null;
                _tableObject.uniques_constraints.TryGetValue(SelectedUniqueConstraintName,out uc);
                _constraintObject = uc;
                 var tff = new ConstraintsForm(FbXpertMainForm.Instance(),_tableObject, _actTables,_dbReg, _constraintObject);
                tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eEdit);
                tff.RegisterNotify(InfoRaised);
                tff.Show();
            }
            else if(tabControlConstraints.SelectedTab == tabPageForeignKeys)
            {
                ForeignKeyClass uc = null;
                _tableObject.ForeignKeys.TryGetValue(SelectedFKConstraintName,out uc);
                _constraintObject = uc;

                Dictionary<string,TableClass> allTables = StaticTreeClass.Instance().GetAllTableObjectsComplete(_dbReg);

                var _tables = new List<TableClass>();
                foreach(var tab in allTables.Values)
                {
                    _tables.Add(tab);
                }
                
                var tff = new ForeignKeyForm(MdiParent, _dbReg, _tables, string.Empty, uc,-1);
                tff._localNotify.Register4Info(InfoRaised);
                tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eEdit);
                tff.Show();

                
                
            }
            else if(tabControlConstraints.SelectedTab == tabPageChecks)
            {
                ConstraintsClass uc = null;
                _tableObject.check_constraints.TryGetValue(SelectedCheckConstraintName,out uc);
                _constraintObject = uc;
                var tff = new ConstraintsForm(FbXpertMainForm.Instance(),_tableObject, _actTables,_dbReg, _constraintObject);
                tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eEdit);
                tff.RegisterNotify(InfoRaised);
                tff.Show();                
            }

           
            _constraintChanged = true;
            AnzeigeConstraints();
        }

        public void ShowCaptions()
        {
            lblTableName.Text = (_tableObject != null) ? $@"Table: {_tableObject.Name}" : "Table";            
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Manage Tables"); 
        }

        public void CreateTabControl()
        {
            tabControl.TabPages.Clear();
            tabControl.TabPages.Add(tabPageFIELDS);
            if (getData) tabControl.TabPages.Add(tabPageDATA);
            tabControl.TabPages.Add(tabDDL);
            tabControl.TabPages.Add(tabConstraints);
            tabControl.TabPages.Add(tabIndicies);
            tabControl.TabPages.Add(tabPageDependenciesTo);
            tabControl.TabPages.Add(tabPageDependenciesFrom);
            tabControl.TabPages.Add(tabPageMessages);
            if (getData) tabControl.TabPages.Add(tabPageExport);
            tabControl.TabPages.Add(tabPageTablestatistics);
        }

        int PrimaryKeys;
        int ForeignKeys;
        int Uniques;
        int DependenciesTo;
        int DependenciesFrom;
        private void AnzeigeConstraints()
        {
            tabPagePrimaryKeys.Text = $@"Primary Keys ({PrimaryKeys})";
            tabPageForeignKeys.Text = $@"Foreign Keys ({ForeignKeys})";
            tabPageUniques.Text = $@"Uniques ({Uniques})";
            tabConstraints.Text = $@"Constraints ({(PrimaryKeys + ForeignKeys + Uniques)})";
        }
        private void RefreshAll()
        {
            DataFilled = false;
            dgvResults.Visible = false;
            CreateTabControl();
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            tabPageFIELDS.Text = $@"Fields ({RefreshFields()})";

            _cmd = MakeFieldsCmd();

            bsTableContent.DataMember   = null;
            hsRefreshData.Enabled       = false;
            sfbTableData.Enabled        = false;
            Application.DoEvents();
            GetDataWorker.CancelGettingData();
            if(GetDataWorker.CancellingDone())
            {
                ClearDataGrid();

                PrimaryKeys         = RefreshPrimaryKeys();
                ForeignKeys         = RefreshForeignKeys();
                Uniques             = RefreshUniques();
                DependenciesTo      = RefreshDependenciesTo();
                DependenciesFrom    = RefreshDependenciesFrom();

                AnzeigeConstraints();
            
                tabIndicies.Text                = $@"Indicies ({RefreshIndices()})";
                tabPageDependenciesTo.Text      = $@"Dependencies ({DependenciesTo})";
                tabPageDependenciesFrom.Text    = $@"Dependencies ({DependenciesFrom})";

                RefreshDLL();
                cbEditMode.Checked = !cbEditMode.Checked;
                cbEditMode.Checked = !cbEditMode.Checked;
                ShowCaptions();
                this.Cursor = Cursors.Default;
                GetDataWorker.RunWorkerAsync();      
                DataFilled = true;
                SelectID(); 
            }
        }

        private void RefreshStruct()
        {
            DataFilled = false;
            dgvResults.Visible = false;
            CreateTabControl();
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            tabPageFIELDS.Text = $@"Fields ({RefreshFields()})";

            _cmd = MakeFieldsCmd();

            bsTableContent.DataMember = null;
            hsRefreshData.Enabled = false;
            sfbTableData.Enabled = false;
            Application.DoEvents();
            GetDataWorker.CancelGettingData();
            if (GetDataWorker.CancellingDone())
            {

                ClearDataGrid();


                PrimaryKeys = RefreshPrimaryKeys();
                ForeignKeys = RefreshForeignKeys();
                Uniques = RefreshUniques();
                DependenciesTo = RefreshDependenciesTo();
                DependenciesFrom = RefreshDependenciesFrom();

                AnzeigeConstraints();

                tabIndicies.Text = $@"Indicies ({RefreshIndices()})";
                tabPageDependenciesTo.Text = $@"Dependencies ({DependenciesTo})";
                tabPageDependenciesFrom.Text = $@"Dependencies ({DependenciesFrom})";

                RefreshDLL();
                cbEditMode.Checked = !cbEditMode.Checked;
                cbEditMode.Checked = !cbEditMode.Checked;
                ShowCaptions();
                this.Cursor = Cursors.Default;
                //GetDataWorker.RunWorkerAsync();
                DataFilled = true;
                SelectID();
            }
        }

        public void ClearDataGrid()
        {
            dgvResults.Columns.Clear();
            dsTableContent.Clear();
            dsTableContent.Tables[0].Columns.Clear();
            dgvResults.AutoGenerateColumns = true;
        }

        private void RefreshTableData()
        {          
            MakeFieldsCmd();
            bsTableContent.DataMember   = null;          
            hsRefreshData.Enabled       = false;
            sfbTableData.Enabled        = false;
            Application.DoEvents();

            if (GetDataWorker.IsBusy) return;
            
            ClearDataGrid();
            dgvResults.RowTemplate.Height = 30;
            GetDataWorker.RunWorkerAsync();                                
        }

        public void SetButtonDefaults()
        {
            hsAddIndex.Enabled  = true;
            hsEditIndex.Enabled = false;
            hsDropIndex.Enabled = false;
        }

        public void LoadData()
        {                
            if (DbExplorerForm.Instance().Visible)
            {
                this.Left = DbExplorerForm.Instance().Width + 16;
            }

            cbCharSet.Items.Clear();
            cbCharSet.Items.Add(new EncodingClass(Encoding.UTF8));
            cbCharSet.Items.Add(new EncodingClass(Encoding.ASCII));
            cbCharSet.Items.Add(new EncodingClass(Encoding.Default));
            cbCharSet.Items.Add(new EncodingClass(Encoding.Unicode));

            cbCharSet.SelectedIndex = 0;
            cbCharSet.Visible = cbExportToFile.Checked;

            fctMessages.Clear();
            
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
            if (getData) RefreshAll();
            else RefreshStruct();
        }

        public void SelectID()
        {
            try
            {
                if (lvFields.SelectedItems == null) return;                
                if (lvFields.SelectedItems.Count <= 0) return;
                
                try
                {
                    ListViewItem lvi = lvFields.SelectedItems[0];
                    TableFieldClass tfc = lvi.Tag as TableFieldClass;
                }
                catch (Exception ex)
                {
                    _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}->SelectID()", ex));                        
                }                                 
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}->SelectID()", ex));                        
            }
        }

        private void EditField()
        {
            if (_actFieldObject == null) return;            
            var tff = new FieldForm(_dbReg,FbXpertMainForm.Instance(), _tnSelected, _actFieldObject, _localNotify, StateClasses.EditStateClass.eBearbeiten.eEdit);
            
            tff.Show();                               
        }
        
        public bool IsNullable(string colbez)
        {
            foreach(TableFieldClass tf in _tableObject.Fields.Values)
            {
                if(tf.Name != colbez) continue;                
                if (tf.Domain != null) return (!tf.Domain.NotNull);
                else return !_tableObject.IsNotNull(tf.Name);                   
            }
            return false;
        }

        public TableFieldClass FindField(string fname)
        {   
            TableFieldClass tfc = null;
            _tableObject?.Fields.TryGetValue(fname, out tfc);            
            return tfc;
        }

        private void ExportForInsertUpdate(string fn,bool insertupdate)
        {
            var sb = new StringBuilder();
            var cols = new StringBuilder();
            bool fcol = true;

            foreach (DataGridViewRow row in dgExportGrid.Rows)
            {
                bool act = (bool) row.Cells["colExportActive"].Value;
                bool whre = (bool)row.Cells["colExportWhere"].Value;
                if (!act && !whre) continue;
                
                if (fcol) cols.Append(row.Cells["ColExportFieldName"].Value.ToString());
                else      cols.Append("," + row.Cells["ColExportFieldName"].Value.ToString());
                fcol = false;                   
            }
       
            int i = 0;            
            foreach (DataRow dr in dsTableContent.Tables[0].Rows)
            {
                sb.Clear();
                Thread.Sleep(5);
                if (this.bwExport.CancellationPending) return;
                                
                string cmdpattern = insertupdate ? SQLPatterns.UpdateInsertPattern : SQLPatterns.InsertPattern;
                                
                string tablename = _tableObject.Name;
                cmdpattern = cmdpattern.Replace(SQLPatterns.TableKey, tablename).Replace(SQLPatterns.ColumnKey, cols.ToString());
                
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

                    if ( str.Domain.FieldType.StartsWith("VAR") || str.Domain.FieldType.StartsWith("TIME") || str.Domain.FieldType.StartsWith("DATE") )
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
                        sb.Append(", " + scmd);
                    }
                    first = false;                       
                }
                cmdpattern = cmdpattern.Replace(SQLPatterns.ValueKey, sb.ToString());
                bwExport.ReportProgress(i++,cmdpattern);                                
            }          
        }

        private void ExportForUpdate(string fn)
        {
            int i = 0;
            foreach (DataRow dr in dsTableContent.Tables[0].Rows)
            {
                var sb = new StringBuilder();
                string tablename = _tableObject.Name;
                                
                string cmdpattern = SQLPatterns.UpdatePattern.Replace(SQLPatterns.TableKey, tablename);
                                                
                string primarystr = string.Empty;
                bool first = true;

                foreach (DataGridViewRow row in dgExportGrid.Rows)
                {
                    Thread.Sleep(5);
                    bool act = (bool)row.Cells["colExportActive"].Value;
                    bool whre = (bool)row.Cells["colExportWhere"].Value;
                    if (!act&&!whre) continue;
                    
                    string fstr = row.Cells["colExportFieldName"].Value.ToString();
                    var str = FindField(fstr);

                    string scmd = string.Empty;
                    string valuestr = dr[str.Name].ToString();

                    if (str.Domain.FieldType.StartsWith("VAR") || str.Domain.FieldType.StartsWith("TIME") || str.Domain.FieldType.StartsWith("DATE"))
                    {
                        if (valuestr.Length <= 0) scmd = $@"{str.Name} = null";
                        else                      scmd = $@"{str.Name} = '{valuestr}'";
                    }
                    else
                    {
                        if (valuestr.Length <= 0) scmd = $@"{str.Name} = null";
                        else                      scmd = $@"{str.Name} = {valuestr}";
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
                cmdpattern = cmdpattern.Replace(SQLPatterns.ValueKey, sb.ToString()).Replace(SQLPatterns.PrimaryKey, primarystr);                
                bwExport.ReportProgress(i++,cmdpattern);                
            }
        }

        private void TableStatistic()
        {
            fctTableStatistics.Clear();
            string fn = $@"{Application.StartupPath}\FB{_dbReg.Version}\Firebird\gstat.exe";
            if(File.Exists(fn))
            {
                string args = $"-u {_dbReg.User} -p {_dbReg.Password} -d {_dbReg.DatabasePath} -r -t {_tableObject.Name.ToUpper()}";
            
                var psi = new ProcessStartInfo(fn,args);            
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;   
                psi.CreateNoWindow = true;
            
                var ps = new Process();
                ps.StartInfo = psi;
                ps.Start();
                StreamReader reader = ps.StandardOutput;
                string output = reader.ReadToEnd();       
                fctTableStatistics.AppendText(output);

                ps.WaitForExit();
                ps.Close();
            }
            else
            {
                 _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> TableStatistic()", $@"Application {fn} not exists"));     
            }
        }
        
        private void hsRefresh_Click(object sender, EventArgs e)
        {
            if (getData) RefreshAll();
            else RefreshStruct();
        }
      
        private void hsRefreshData_Click(object sender, EventArgs e)
        {
            RefreshTableData();
        }
        
        private void TABLEManageForm_Load(object sender, EventArgs e)
        {
            _indexChanged = false;
            _tableChanged = false;
            SetButtonDefaults();
            TableStatistic();
            LoadData();
            RefreshLanguageText();  
            txtRowHeight.Text = dgvResults.RowTemplate.Height.ToString();
        }
       
        private void lvFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditField();
        }
       
        private void bindingSource1_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;            
            SelectID();               
        }

        private void SaveDataset_Click(object sender, EventArgs e)
        {            
            try
            {
                DataSet dsUpdate = dsTableContent.GetChanges(DataRowState.Modified);
                DataSet dsInsert = dsTableContent.GetChanges(DataRowState.Added);
                DataSet dsDeleted = dsTableContent.GetChanges(DataRowState.Deleted);

                string cm1 = $@"{SQLConstants.SELECT} {_cmd}";
                var da = new FbDataAdapter(cm1, _dataConnection);
                var cb = new FbCommandBuilder(da);  
               
                da.AcceptChangesDuringUpdate = true;
                if (dsUpdate != null)
                {   
                    var fc = cb.GetUpdateCommand();
                    da.UpdateCommand = fc;
                    if (dsUpdate.Tables[0].Rows.Count > 0)
                    {
                        _localNotify?.AddToINFO($@"Table {_tableObject.Name} updated {dsUpdate.Tables[0].Rows.Count} records affected");
                        da.Update(dsUpdate);
                    }
                }
                if (dsInsert != null)
                {
                    var fi = cb.GetInsertCommand();
                    da.InsertCommand = fi;                    
                    _localNotify?.AddToINFO($@"Table {_tableObject.Name} added {dsInsert.Tables[0].Rows.Count} records affected");
                    da.Update(dsInsert);                        
                }
                if (dsDeleted != null)
                {
                    var fd = cb.GetDeleteCommand();                
                    da.DeleteCommand = fd;
                    if (dsDeleted.Tables[0].Rows.Count > 0)
                    {
                        _localNotify?.AddToINFO($@"Table {_tableObject.Name} deleted {dsDeleted.Tables[0].Rows.Count} records affected");
                        da.Update(dsDeleted);
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> Savedataset_Click()", ex));                                        
            }
            bsTableContent.DataMember = null;                                
            if (!cbAutoRefresh.Checked) return;
            
            MakeFieldsCmd();
            if (GetDataWorker.IsBusy) return;
            
            ClearDataGrid();
            GetDataWorker.RunWorkerAsync();                                    
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;            
            this.dgvResults.Tag = this.dgvResults.CurrentCell.Value;                               
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            _firstTab = StaticPaintClass.TabControl_DrawItem(this, e, sender, _firstTab);
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _firstTab = false;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           sfbTableData.dcFilter = dgvResults.Columns[e.ColumnIndex];
           sfbTableData.FilterText = string.Empty;
           sfbTableData.cbChecked = false;
           sfbTableData.SelectFilter();
        }

        private void spezialfilterBox1_CbCheckedChanged(object sender, EventArgs e)
        {
            _cmd = MakeFieldsCmd();
            bsTableContent.DataMember = null;          
            if (GetDataWorker.IsBusy) return;            
            ClearDataGrid();
            GetDataWorker.RunWorkerAsync();               
        }                

        private void hsNewField_Click(object sender, EventArgs e)
        {
            var NewFieldObject = new TableFieldClass()
            {
                Name = "NEW_FIELD",
            };
            NewFieldObject.Domain.Name = "";
            NewFieldObject.Domain.Length = 8;
            NewFieldObject.Domain.FieldType = "VARCHAR";
            NewFieldObject.Domain.CharSet = _dbReg.CharSet;
            NewFieldObject.Domain.Collate = _dbReg.Collation;
            NewFieldObject.Domain.RawType = "VARCHAR(8)";
            NewFieldObject.Domain.Scale = 8;
            NewFieldObject.Domain.Precision = 3;
            var tff = new FieldForm(_dbReg,null,_tnSelected, NewFieldObject,_localNotify,StateClasses.EditStateClass.eBearbeiten.eInsert);
            
            tff.ShowDialog();
            if (getData) RefreshAll();
            else RefreshStruct();
        }

        private void hsRefreshAll_Click_1(object sender, EventArgs e)
        {
            RefreshFields();            
        }

        private void hsDropField_Click(object sender, EventArgs e)
        {
            DropField();
            if (getData) RefreshAll();
            else RefreshStruct();
        }

        private void lvFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            hsDropField.Enabled = (lvFields.SelectedItems != null);
            if(lvFields.SelectedItems == null) return;            
            if (lvFields.SelectedItems.Count <= 0) return;            
            if (lvFields.SelectedItems[0].Tag == null) return;            
            _actFieldObject = (TableFieldClass)lvFields.SelectedItems[0].Tag;                                  
        }

        private void hsEditField_Click(object sender, EventArgs e)
        {
            EditField();
        }
        
        private void cmsText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDDLCopyToClipboard)
            {
                Clipboard.SetText(fctTableCreateDLL.SelectedText);
            }
            else if (e.ClickedItem == tsmiDDLPaste)
            {
                fctTableCreateDLL.Text = fctTableCreateDLL.Text.Insert(fctTableCreateDLL.SelectionStart, Clipboard.GetText());
            }
            else if (e.ClickedItem == tsmiMessageCopyToClipboard)
            {
                Clipboard.SetText(fctMessages.SelectedText);
            }
            else if (e.ClickedItem == tsmiMessagePaste)
            {
                fctMessages.Text = fctMessages.Text.Insert(fctMessages.SelectionStart, Clipboard.GetText());
            }
            if (e.ClickedItem == tsmiEXPORTDataCopyToCLipboard)
            {
                Clipboard.SetText(fcbExport.SelectedText);
            }
            else if (e.ClickedItem == tsmiEXPORTDataPasteFromClipboard)
            {
               fcbExport.Text = fctTableCreateDLL.Text.Insert(fctTableCreateDLL.SelectionStart, Clipboard.GetText());
            }
        }

        private void hsRefreshDependenciesTo_Click(object sender, EventArgs e)
        {
            RefreshDependenciesTo();
        }

        private void hsRefreshDependenciesFrom_Click(object sender, EventArgs e)
        {
            RefreshDependenciesFrom();
        }

        private void hsAddIndex_Click(object sender, EventArgs e)
        {
            AddIndex();
        }
        
        private void bwGetData_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            string timedone = stopwatch.ElapsedMilliseconds.ToString();
            bsTableContent.DataSource = dsTableContent;
            dgvResults.DataSource = bsTableContent;
            hsRefreshData.Enabled = true;
            sfbTableData.Enabled = true;  
            if (bsTableContent.DataMember == null) return;
            
            bsTableContent.DataMember = "Table";
            tabPageDATA.Text = $@"Data ({dsTableContent.Tables[0].Rows.Count})";
            sfbTableData.SetDataColumns(dgvResults.Columns);
            gridStore.RestoreGridDesign();
            ActivateGrid();
            stopwatch.Stop();
            timedone += $@" / {stopwatch.ElapsedMilliseconds}";
            txtUsedTime.Text = timedone;
        }

        private void bwGetData_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            tabPageDATA.Text = e.UserState.ToString();
        }

        private void DeactivateGrid()
        {
            ExtensionMethods.DoubleBuffered(dgvResults,true);
            //dgvResults.Visible = false;
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
            
            stopwatch.Restart();
            DeactivateGrid();
            dgvResults.SuspendLayout();
            sfbTableData.SQLVorfilterCmd = $@"SELECT {_cmd}";
            RefreshDatas(_cmd);           
        }

        private void hsCancelGettingData_Click(object sender, EventArgs e)
        {
            if (!GetDataWorker.IsBusy) return;            
            GetDataWorker.CancelAsync();               
        }

        private void TABLEManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
            GetDataWorker.CancelGettingData();
            if (bwExport.IsBusy)
            {
                bwExport.CancelAsync();
            }
            fcbExport.Clear();
            if (_dataConnection?.State != System.Data.ConnectionState.Closed)  
            {    
                _dataConnection?.Dispose();
                _dataConnection?.Close();
            }
            if(_indexChanged || _tableChanged || _constraintChanged) 
            {
                DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllTables,$@"Proc:{this.Name}"); 
            }

            _localNotify.Notify.OnRaiseInfoHandler  -= new NotifyInfos.RaiseNotifyHandler(InfoRaised);
            _localNotify.Notify.OnRaiseErrorHandler -= new NotifyInfos.RaiseNotifyHandler(ErrorRaised);
        }
        
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int rh = StaticFunctionsClass.ToIntDef(txtRowHeight.Text, dgvResults.RowTemplate.Height);
            foreach(DataGridViewRow x in dgvResults.Rows)
            {
              x.MinimumHeight = rh;
            }
            if (dgvResults.CurrentCell == null) return;
            if (dgvResults.SelectionMode == DataGridViewSelectionMode.FullRowSelect) return;
            try
            { 
                Rectangle newRect;
                if(dgvResults.CurrentCell.OwningColumn.Name.IndexOf("BLR")>0)
                {
                    Console.WriteLine();
                }
                if (e.Value == null || e.RowIndex < 0) return;
                
                string vs = e.Value.ToString();
                object o  = e.Value;
                string os = o.GetType().ToString();
                newRect = new Rectangle(e.CellBounds.X + 1,
                    e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                    e.CellBounds.Height - 4);
                
                using (Brush gridBrush = new SolidBrush(this.dgvResults.GridColor),backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {         
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                        if ((e.ColumnIndex == dgvResults.CurrentCell.ColumnIndex) && (e.RowIndex == dgvResults.CurrentCell.RowIndex))
                        {                            
                            e.PaintBackground(e.CellBounds,true);                           
                        } 
                        
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                            e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                            e.CellBounds.Top, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom);
                        
                        e.PaintContent(e.CellBounds);
                        e.Handled = true;
                    }
                }                   
            }
            catch(Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> dataGridView1_CellPainting()", ex));                                        
            }
            
        }

        private void cmdDATA_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (dgvResults.CurrentCell == null) return;
            if(e.ClickedItem == tsmiSetToNULL)
            {
                dgvResults.BeginEdit(false);
                if (dgvResults.CurrentCell.ValueType.Name == "String")
                {
                    dgvResults.CurrentCell.Value = dgvResults.CurrentCell.DefaultNewRowValue;
                }
                else
                {                                      
                    if (IsNullable(dgvResults.Columns[dgvResults.CurrentCell.ColumnIndex].Name))
                    {
                        dgvResults.CurrentCell.Value = System.DBNull.Value;
                    }                    
                }
                dgvResults.EndEdit();                
                dgvResults.InvalidateCell(dgvResults.CurrentCell);            
            }
            else if(e.ClickedItem == tsmiSpaltenEdit)
            {
                SpaltenEdit();
            }
            else if(e.ClickedItem == tsmiReadBLOB)
            {                                                                       
                       
                if (dgvResults.CurrentCell.Value.GetType().Name != "DBNull")
                {                    
                    string kenner = "<BLOB>";
                    string cl = (dgvResults.CurrentCell.Value.ToString().StartsWith(kenner)) ? dgvResults.CurrentCell.Value.ToString().Substring(kenner.Length) : "ID";                                        
                    string cmd = $@"SELECT {dgvResults.CurrentCell.OwningColumn.Name} FROM {_tableObject.Name} WHERE {cl} = '{dgvResults.CurrentRow.Cells[cl].Value.ToString()}'";
                  
                    var fbCommand = new FbCommand(cmd, _dataConnection);
                    var fbDataReader = fbCommand.ExecuteReader();
                    if (fbDataReader.Read()) 
                    {
                        var v = fbDataReader[0];
                        Type tp = v.GetType();
                        
                        if(tp.FullName.StartsWith("System."))
                        {
                            byte[] blob = null;
                            if(tp.FullName ==  "System.Byte[]")
                            {
                                blob = (byte[]) v;                                    
                            }
                            else if(tp.FullName ==  "System.String")
                            {
                                string vv = v.ToString();                                    
                                char[] chr = vv.ToCharArray();
                                blob = new byte[chr.Length];
                                for(int i = 0; i < chr.Length; i++)
                                {
                                    blob[i] = (byte)chr[i];
                                }                               
                            }
                            else if(tp.FullName.StartsWith("System.Int"))
                            {                                                                        
                                if(tp.FullName == "System.Int16")
                                {
                                    var vv = (Int16) v;
                                    blob =  BitConverter.GetBytes(vv);        
                                }
                                else if(tp.FullName == "System.Int32")
                                {
                                    var vv = (Int32) v;
                                    blob =  BitConverter.GetBytes(vv);        
                                }
                                else if(tp.FullName == "System.Int64")
                                {
                                    var vv = (Int64) v;
                                    blob =  BitConverter.GetBytes(vv);        
                                }                 
                            }
                            else if(tp.FullName == "System.Double")
                            {                                                                 
                                var vv = (Double) v;
                                blob =  BitConverter.GetBytes(vv);                                 
                            }
                            else if(tp.FullName.StartsWith("System.Bool"))
                            {                                                                 
                                var vv = (bool) v;
                                blob =  BitConverter.GetBytes(vv);                                 
                            }
                            else if(tp.FullName == "System.DateTime")
                            {                                                                   
                                var vv = (DateTime) v;
                                blob =  BitConverter.GetBytes(vv.Ticks);                                                                                        
                            }
                            BlobEditForm bef = new BlobEditForm();
                            bef.SetBytes(blob);
                            bef.ShowDialog();  
                            blob = null;
                        }                            
                    }                   
                }                    
            }
            else if(e.ClickedItem == tsmiDate)
            {
                DateTime dt = DateTime.Now;               
                if (dt.GetType() == dgvResults.CurrentCell.ValueType)
                {
                    if (dgvResults.CurrentCell.Value.GetType().Name != "DBNull")
                    {
                        dt = (DateTime)dgvResults.CurrentCell.Value;
                    }
                    DateTimeForm df = new DateTimeForm(this.MdiParent,dt);
                    df.ShowDialog();
                    if(df.Value > DateTime.MinValue)
                    {
                        dgvResults.CurrentCell.Value = df.Value;
                        dgvResults.CurrentCell.ValueType = dt.GetType();
                    }                    
                }
            }
            else if(e.ClickedItem == tsmiInsertGUID)
            {
                string guid = StaticFunctionsClass.GetNewGUID();
                dgvResults.CurrentCell.Value = guid;
                dgvResults.CurrentCell.ValueType = guid.GetType();
            }
            else if(e.ClickedItem == tsmiInsertGUIDHEX)
            {
                string guid = StaticFunctionsClass.GetNewGUIDHEX();
                dgvResults.CurrentCell.Value = guid;
                dgvResults.CurrentCell.ValueType = guid.GetType();
            }
            else if (e.ClickedItem == tsmiInsertNow)
            {
                DateTime dt = DateTime.Now;
                dgvResults.CurrentCell.Value = dt;
                dgvResults.CurrentCell.ValueType = dt.GetType();
            }
            else if (e.ClickedItem == tsmiInsert0)
            {
                int x = 0;
                dgvResults.CurrentCell.Value = x;
                dgvResults.CurrentCell.ValueType = x.GetType();
            }
            else if (e.ClickedItem == tsmiInsert1)
            {
                int x = 1;
                dgvResults.CurrentCell.Value = x;
                dgvResults.CurrentCell.ValueType = x.GetType();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object ob = dgvResults.CurrentCell.Value;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {       
            if(e.ColumnIndex < 0) return;
            object ob = dgvResults.CurrentCell.Value;
            string obt = ob.GetType().Name;
            string tn = dgvResults.CurrentCell.ValueType.Name;
            tsmiDate.Visible = (tn == "DateTime")||((tn == "DateTime")&&(obt == "DBNull"));
            tsmiSetToNULL.Visible = IsNullable(dgvResults.Columns[e.ColumnIndex].Name);
                       
            this.Text = $@"CellClick  {e.ColumnIndex} {e.RowIndex}{dgvResults.CurrentCell.Value.ToString()} {dgvResults.CurrentCell.ValueType.ToString()}";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvResults.BeginEdit(false);
        }

        private void hsRunStatement_Click(object sender, EventArgs e)
        {
            GetDataWorker.CancelGettingData();
            if(GetDataWorker.CancellingDone())
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.Clear();
                dgvResults.AutoGenerateColumns = true;
            
                var SQLcommand = new SQLCommandsClass(_dbReg);
                SQLcommand.Notify.Register4Info(InfoRaised);
                SQLcommand.Notify.Register4Error(ErrorRaised);

                IList<string> cmd2 = new List<string>();
                foreach (string s in fctTableCreateDLL.Lines)
                {
                    if (s.Trim().StartsWith("/*")) continue;
                    if (string.IsNullOrEmpty(s)) continue;
                    cmd2.Add(s);
                }


                var ri = SQLcommand.ExecuteCommand(cmd2,false);
                lblUsedMs.Text = ri.costs.ToString();
                if (GetDataWorker.IsBusy) return;
            
                hsRefreshData.Enabled = false;
                ClearDataGrid();
                GetDataWorker.RunWorkerAsync();       
                _tableChanged = true;
            }
        }
       
        private void hsSave_Click(object sender, EventArgs e)
        {
            if (saveSQLFile.ShowDialog() != DialogResult.OK) return;            
            fctTableCreateDLL.SaveToFile(saveSQLFile.FileName, Encoding.UTF8);              
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;            
            fctTableCreateDLL.OpenFile(ofdSQL.FileName);               
        }
       
        private void hsExport_Click(object sender, EventArgs e)
        {           
            if (bwExport.IsBusy) return;
                         
            pbExport.Value = 0;
            pbExport.Minimum = 0;
            pbExport.Maximum = dsTableContent.Tables[0].Rows.Count;
            fcbExport.Clear();
            _pi = 0;
            _writeFile = cbExportToFile.Checked;
            if (cbExportToFile.Checked)
            {
                _writeFile = false;
                if (saveSQLFile.ShowDialog() == DialogResult.OK)
                {
                    _fileName = saveSQLFile.FileName;
                    _writeFile = true;
                }
            }

            if (cbExportToScreen.Checked) exportList.Clear();
            hsCancelExport.Enabled = true;
            hsExportData.Enabled = false;
            if (_writeFile)
            {
                if (_fileName.Length > 0)
                {
                    _sw = new StreamWriter(_fileName, false, (cbCharSet.SelectedItem as EncodingClass).encoding);
                }
                else
                {
                    _writeFile = false;
                }
            }
            bwExport.RunWorkerAsync();                     
        }
        
        private void bwExport_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (rbINSERT.Checked)
            {
                ExportForInsertUpdate(_fileName, false);
            }
            else if (rbINSERTUPDATE.Checked)
            {
                ExportForInsertUpdate(_fileName, true);
            }
            else if (rbUPDATE.Checked)
            {
                ExportForUpdate(_fileName);
            }
        }

        private void bwExport_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (_writeFile)
            {
                _sw.Close();
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
            
            tabPageExport.Text = $@"Export ({_pi})";
            hsCancelExport.Enabled = false;
            hsExportData.Enabled = true;
        }
              
        private void bwExport_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (cbExportToScreen.Checked)
            {
                exportList.Add($@"{e.UserState};{Environment.NewLine}");                
            }
            if (_writeFile)
            {
                _sw.WriteLine($@"{e.UserState};");
            }
            _pi++;
            int n = (pbExport.Maximum / 100);
            if (n <= 0) n = 1; 

            if ((_pi % n) != 0) return;
            
            tabPageExport.Text = $@"Export ({_pi})";
            pbExport.Value = _pi;               
        }
       
        private void hsCancelExport_Click(object sender, EventArgs e)
        {
            if(!bwExport.IsBusy) return;            
            bwExport.CancelAsync();                            
        }

        private void cbExportToFile_CheckedChanged(object sender, EventArgs e)
        {
            cbCharSet.Visible = cbExportToFile.Checked;
        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {            
            if (cbEditMode.Checked)
            {
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvResults.ReadOnly = false;
                dgvResults.RowHeadersVisible = true;
                dgvResults.AllowUserToAddRows = true;
                dgvResults.AllowUserToDeleteRows = true;
                dgvResults.SelectionMode = DataGridViewSelectionMode.CellSelect;
                hsSaveSQL.Enabled = true;
                bnTableContentDeleteItem.Enabled = true;
            }
            else
            {                
                dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvResults.ReadOnly = true;
                dgvResults.RowHeadersVisible = false;
                dgvResults.AllowUserToAddRows = false;
                dgvResults.AllowUserToDeleteRows = false;
                dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                hsSaveSQL.Enabled = false;
                bnTableContentDeleteItem.Enabled = false;
            }            
        }
                
        private void bsIndicies_CurrentChanged(object sender, EventArgs e)
        {
            SelectIndexID();
        }

        private void hsEditIndex_Click(object sender, EventArgs e)
        {
            EditIndex();
        }
        
        private void hsRefreshMaxRows_Click(object sender, EventArgs e)
        {
            RefreshTableData();            
        }

        private void dgvResults_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int ri = e.RowIndex;
            int ci = e.ColumnIndex;
        }

        private void fctTableCreateDLL_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData != (Keys.K | Keys.Control))) return;                                                           
            if(ac != null) ac.Show();              
            e.Handled = true;               
        }
        
        private void hsDropIndex_Click(object sender, EventArgs e)
        {
            DropIndex();
        }
                
        private void hsRefreshTableStatistics_Click(object sender, EventArgs e)
        {
           TableStatistic(); 
        }
        
        private void hsAddConstraint_Click(object sender, EventArgs e)
        {
            AddConstraint();
        }
        
        private void hsEditConstraint_Click(object sender, EventArgs e)
        {
            EditConstraint();
        }

        private void hsDropConstraint_Click(object sender, EventArgs e)
        {
            //DropPKConstraint();
            if(tabControlConstraints.SelectedTab == tabPagePrimaryKeys)
            {
               DropPKConstraint();
            }
            else if(tabControlConstraints.SelectedTab == tabPageUniques)
            {
                DropUniqueConstraint();
            }
            else if(tabControlConstraints.SelectedTab == tabPageForeignKeys)
            {
                DropFKConstraint();
            }
            else if(tabControlConstraints.SelectedTab == tabPageChecks)
            {
                DropChaeckConstraint();
            }
        }

        private void bsPrimaryKeys_CurrentChanged(object sender, EventArgs e)
        {
            SelectPrimaryKeyID();
        }

        private void bsForeignKeys_CurrentChanged(object sender, EventArgs e)
        {
            SelectForeignKeyID();
        }

        private void bsChecks_CurrentChanged(object sender, EventArgs e)
        {
            SelectCheckID();
        }

        private void bsUniques_CurrentChanged(object sender, EventArgs e)
        {
            SelectUniqueID();
        }

        private void tabControlConstraints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlConstraints.SelectedTab == tabPagePrimaryKeys)
            {
                SelectPrimaryKeyID();
            }
            else if(tabControlConstraints.SelectedTab == tabPageChecks)
            {
                SelectCheckID();
            }
            else if(tabControlConstraints.SelectedTab == tabPageUniques)
            {
                SelectUniqueID();
            }
            else if(tabControlConstraints.SelectedTab == tabPageForeignKeys)
            {
                 SelectForeignKeyID();
            }
        }

        private void cbRowManually_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRowManually.Checked)
            {                
                dgvResults.Invalidate();
            }
        }

        private void txtRowHeight_TextChanged(object sender, EventArgs e)
        {
            if(cbRowManually.Checked)
            {                
                cbRowManually.Checked = false;                
            }
        }

        private void txtRowHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                cbRowManually.Checked = true;
            }
        }

        private void dgvResults_Resize(object sender, EventArgs e)
        {            
            ActivateGrid();
        }

        private void ckGetDatas_CheckedChanged(object sender, EventArgs e)
        {
            getData = ckGetDatas.Checked;
        }
    }
}
