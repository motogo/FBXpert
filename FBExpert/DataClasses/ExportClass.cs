using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpertLib.DataClasses;
using FBXpert.SQLView;
using FBXpertLib;
using FBXpertLib.DataClasses;
using FBXpertLib.Globals;
using FBXpertLib.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using MessageFormLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;

namespace FBXpert.DataClasses
{
    class ExportClass
    {        
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExportFieldName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExportActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExportWhere;
        
        private DataSet _dsTableContent;
        private DBRegistrationClass _dbReg;
               
        private System.Windows.Forms.ColumnHeader colFIELDPOSITION;
        private System.Windows.Forms.ColumnHeader colTYPE;
        private System.Windows.Forms.ColumnHeader colLENGTH;
        private System.Windows.Forms.ColumnHeader colFIELDNOTNULL;
        private System.Windows.Forms.ColumnHeader colFIELDNAME;
        private System.Windows.Forms.ColumnHeader colRAWTYPE;
        private System.Windows.Forms.ColumnHeader colDOMAINDEFAULTVALUE;
        private System.Windows.Forms.ColumnHeader colSCALE;
        private System.Windows.Forms.ColumnHeader colPRIMARY;
        private System.Windows.Forms.ColumnHeader colUNIQUE;
        private System.Windows.Forms.ColumnHeader colCHARSET;
        private System.Windows.Forms.ColumnHeader colCOLLATE;
        private System.Windows.Forms.ColumnHeader colDOMAINNAME;
        private System.Windows.Forms.ColumnHeader colDOMAINNOTNULL;
        private System.Windows.Forms.ColumnHeader colFIELDDEFAULTVALUE;
        private System.Windows.Forms.ColumnHeader colFK;

        private NotifiesClass _localNotify = null;
        private FbConnection _dataConnection = null;

        private readonly string _exportInfo = string.Empty;
        public string GetExportInfo()
        {
            return _exportInfo;
        }
        
        public void Init(DBRegistrationClass dbReg, NotifiesClass localNotifies)
        {
            _dbReg = dbReg;
            _localNotify = localNotifies;
            
            this.colFIELDPOSITION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFIELDNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLENGTH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRAWTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFIELDNOTNULL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFIELDDEFAULTVALUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSCALE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPRIMARY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUNIQUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCHARSET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCOLLATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOMAINNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOMAINNOTNULL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOMAINDEFAULTVALUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
           
            // 
            // colFIELDPOSITION
            // 
            this.colFIELDPOSITION.Text = "Pos";
            this.colFIELDPOSITION.Width = 40;
            // 
            // colFIELDNAME
            // 
            this.colFIELDNAME.DisplayIndex = 4;
            this.colFIELDNAME.Text = "Field Name";
            this.colFIELDNAME.Width = 300;
            // 
            // colTYPE
            // 
            this.colTYPE.DisplayIndex = 5;
            this.colTYPE.Text = "FieldType";
            this.colTYPE.Width = 100;
            // 
            // colLENGTH
            // 
            this.colLENGTH.DisplayIndex = 6;
            this.colLENGTH.Text = "Length";
            this.colLENGTH.Width = 50;
            // 
            // colRAWTYPE
            // 
            this.colRAWTYPE.DisplayIndex = 7;
            this.colRAWTYPE.Text = "RAW FieldType";
            this.colRAWTYPE.Width = 120;
            // 
            // colFIELDNOTNULL
            // 
            this.colFIELDNOTNULL.DisplayIndex = 9;
            this.colFIELDNOTNULL.Text = "Field Not Null";
            this.colFIELDNOTNULL.Width = 80;
            // 
            // colFIELDDEFAULTVALUE
            // 
            this.colFIELDDEFAULTVALUE.DisplayIndex = 10;
            this.colFIELDDEFAULTVALUE.Text = "Field Default Value";
            this.colFIELDDEFAULTVALUE.Width = 100;
            // 
            // colSCALE
            // 
            this.colSCALE.DisplayIndex = 11;
            this.colSCALE.Text = "Scale";
            // 
            // colPRIMARY
            // 
            this.colPRIMARY.DisplayIndex = 1;
            this.colPRIMARY.Text = "PK";
            this.colPRIMARY.Width = 30;
            // 
            // colUNIQUE
            // 
            this.colUNIQUE.DisplayIndex = 3;
            this.colUNIQUE.Text = "UQ";
            this.colUNIQUE.Width = 30;
            // 
            // colCHARSET
            // 
            this.colCHARSET.DisplayIndex = 12;
            this.colCHARSET.Text = "Charset";
            // 
            // colCOLLATE
            // 
            this.colCOLLATE.DisplayIndex = 13;
            this.colCOLLATE.Text = "Collate";
            // 
            // colFK
            // 
            this.colFK.DisplayIndex = 2;
            this.colFK.Text = "FK";
            this.colFK.Width = 30;
            // 
            // colDOMAINNAME
            // 
            this.colDOMAINNAME.DisplayIndex = 8;
            this.colDOMAINNAME.Text = "Domain Name";
            this.colDOMAINNAME.Width = 106;
            // 
            // colDOMAINNOTNULL
            // 
            this.colDOMAINNOTNULL.Text = "Domain Not Null";
            // 
            // colDOMAINDEFAULTVALUE
            // 
            this.colDOMAINDEFAULTVALUE.Text = "Domain Default Value";
            this.colDOMAINDEFAULTVALUE.Width = 100;

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dsTableContent = new System.Data.DataSet();

            // 
            // dgvResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            

            this.colPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExportFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExportActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colExportWhere = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            
            // 
            // colPOS
            // 
            this.colPOS.HeaderText = "Pos";
            this.colPOS.Name = "colPOS";
            this.colPOS.Width = 40;
            // 
            // ColExportFieldName
            // 
            this.ColExportFieldName.HeaderText = "Field";
            this.ColExportFieldName.Name = "ColExportFieldName";
            this.ColExportFieldName.Width = 160;
            // 
            // colExportActive
            // 
            this.colExportActive.HeaderText = "E";
            this.colExportActive.Name = "colExportActive";
            this.colExportActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExportActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colExportActive.Width = 24;
            // 
            // colExportWhere
            // 
            this.colExportWhere.HeaderText = "W";
            this.colExportWhere.Name = "colExportWhere";
            this.colExportWhere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExportWhere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colExportWhere.Width = 24;            
        }

        public string TestForValidation(string txt)
        {
            string cmd = txt.Replace(" ,", ",");
            cmd = cmd.Replace(", ", ",");
            int changed = 0;                                
            string[] arr = cmd.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                string arrcmd = arr[i].Trim();
                int n = arrcmd.IndexOf("'", 1);
                if ((n > -1) && (n < arrcmd.Length - 1))
                {
                    arrcmd = arrcmd.Insert(n, "'");                    
                    arr[i] = arrcmd;
                    changed++;
                }
            }

            if (changed > 0)
            {
                var sb = new StringBuilder();               
                bool first = true;
                foreach (string str in arr)
                {
                    if (!first)
                    {
                        sb.Append(",");
                    }
                    sb.Append(str);
                    first = false;
                }                    
                return sb.ToString();
            }            
            return cmd;
        }

        public string GetTableColumns(TableClass tableObject)
        {
            bool first = true;
            StringBuilder cols = new StringBuilder();
            foreach (var tcf in tableObject.Fields.Values)
            {
                if (tcf.State != CheckState.Checked) continue;                
                if (first)
                {
                    cols.Append(tcf.Name);
                }
                else
                {
                    cols.Append(", " + tcf.Name);
                }
                first = false;                   
            }
            return cols.ToString();
        }
         public int RefreshDataCount = 0;
        public string RefreshDatas(TableClass tableObject,string cols)
        {            
            RefreshDataCount = 0;
            _dsTableContent.Clear();
            if ((string.IsNullOrEmpty(tableObject.Name)) || (string.IsNullOrEmpty(cols))) return string.Empty;
            
            string cmd = $@"{SQLConstants.SELECT} {cols} FROM {tableObject.Name}";
            
            _dsTableContent.Tables.Clear(); //[0].Columns.Clear();
                                    
            if ((_dataConnection != null) && (_dataConnection.State != System.Data.ConnectionState.Closed)) _dataConnection.Close();
            
            using(var c = new TransactionScope())
            {
                using(var _dataConnection = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(_dbReg)))
                {
                     _dataConnection.Open();                                
                     if(tableObject.primary_constraint != null)
                     {
                         bool frst = true;
                         string fstr = "(";
                         foreach(string fname in tableObject.primary_constraint.FieldNames.Values)
                         {
                             fstr += (frst) ? fname : $@",{fname}";                            
                             frst = false;
                         }
                         fstr += ")";
                         cmd +=  " ORDER BY " + fstr;
                     }
            
                     var ds = new FbDataAdapter(cmd, _dataConnection);
                     try
                     {
                         RefreshDataCount = ds.Fill(_dsTableContent);
                     }
                     catch(OutOfMemoryException ex)
                     {
                        
                        return ex.Message;
                     }
                     finally
                     {
                        _dataConnection.Close();
                     }
                }
                c.Complete();
            }               
            return string.Empty;
        }
       
        

        public Dictionary<string,string> ExportForInsertUpdate(eCreateMode createMode,TableClass tableObject, string cols)
        {
            var sb = new StringBuilder();                                   
            int i = 0;
            var lst = new Dictionary<string,string>();
            foreach (DataRow dr in _dsTableContent.Tables[0].Rows)
            {
                string tablename = tableObject.Name;
                string scmd = string.Empty;
                bool first = true;
                sb.Clear();                
                
                string cmdpattern = (createMode == eCreateMode.recreate) ? SQLPatterns.UpdateInsertPattern : SQLPatterns.InsertPattern;
                                
                foreach (var tcf in tableObject.Fields)
                {
                    if (tcf.Value.State != CheckState.Checked) continue;
                    
                    string valuestr = dr[tcf.Value.Name].ToString();

                    if (tcf.Value.Domain.FieldType.StartsWith("VAR"))
                    {
                        scmd = (valuestr.Length <= 0) ? "null" : $@"'{valuestr}'";
                    }
                    else if (tcf.Value.Domain.FieldType.StartsWith("TIME"))
                    {
                        scmd = (valuestr.Length <= 0) ? "null" : $@"'{valuestr}'";
                    }
                    else if (tcf.Value.Domain.FieldType.StartsWith("DATE"))
                    {                        
                        scmd = (valuestr.Length <= 0) ? "null" : $@"'{valuestr}'";
                        int inx = scmd.IndexOf(" ");
                        if(inx > 6)
                        {
                            scmd = $@"{scmd.Remove(inx)}'";
                        }
                    }
                    else
                    {
                        scmd = (valuestr.Length <= 0) ? "null" : valuestr;
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

                cmdpattern = cmdpattern.Replace("#REPLACE_TABLE", tablename);
                cmdpattern = cmdpattern.Replace("#REPLACE_COLUMNS", cols);                
                cmdpattern = cmdpattern.Replace("#REPLACE_VALUES", sb.ToString());
                i++;
                lst.Add(i.ToString(),cmdpattern+";");
                
            }            
            return lst;        
        }
    }
  
    class ExportWorkers
    {
        private NotifiesClass _localNotify = null;
        public DBRegistrationClass AktDBReg = null;
        private System.ComponentModel.BackgroundWorker _bgw = new System.ComponentModel.BackgroundWorker();
        
        public List<string> _allDatabaseContent = null;        
        public List<string> _allTableContent = null;
        private List<string> _allPKConstraintsContent = null;
        private List<string> _allFKConstraintsContent = null;
        private List<string> _allViewContent = null;
        private List<string> _allDomainContent = null;
        private List<string> _allGeneratorContent = null;
        private List<string> _allIndexContent = null;
        private List<string> _allTriggerContent = null;
        private List<string> _allProcedureContent = null;
        private List<string> _allProcedureDefinitionContent = null;
        private List<string> _allFunctionContent = null;
        private List<string> _allFunctionDefinitionContent = null;

        //public FileInfo SQLFileInfo = null;    
        public string SQLFileName = string.Empty;
        public string SQLDirectoryName = string.Empty;
        public eSQLFileWriteMode WriteToFile = eSQLFileWriteMode.none;
        public bool ShowScripting = true;
        public bool CommitAfterStatement = false;
        public bool CreateConnectionStatement = false;
        public bool CreateDatabaseStatement = false;
        public eCreateMode CreateMode = eCreateMode.create;

        public EncodingClass CharSet = new EncodingClass(Encoding.UTF8);

        public ExportWorkers(NotifiesClass localNotify)
        {
            _localNotify = localNotify;
            // 
            // bgw
            // 
            this._bgw.WorkerReportsProgress = true;
            this._bgw.WorkerSupportsCancellation = false;
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoTableDataWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressTableDataChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunTableDataWorkerCompleted);
                                
        }
        

        public List<TableClass> alltables = null;
        public List<ViewClass> allviews = null;
        public Dictionary<string,PrimaryKeyClass> allPKConstraints = null;
        public Dictionary<string,ForeignKeyClass> allFKConstraints = null;
        public Dictionary<string,DomainClass> allDomains = null;
        public Dictionary<string,GeneratorClass> allGenerator = null;
        public Dictionary<string,TriggerClass> allTrigger = null;
        public Dictionary<string,ProcedureClass> allProcedures = null;
        public Dictionary<string,FunctionClass> allFunctions = null;
        public Dictionary<string,IndexClass> allIndeces = null;
        private StreamWriter _sw = null;
       


        public void WaitForWorker()
        {
            while (_bgw.IsBusy)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }

        #region TableData
        public void StartworkerGetTableData(List<TableClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {   
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; 
            SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoTableDataWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressTableDataChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunTableDataWorkerCompleted);

            NotificationsForm.Instance().Show();
            if (WriteToFile != eSQLFileWriteMode.none)
            {
                if (SQLDirectoryName != null)
                {
                    _localNotify?.AddToINFO($@"Writing tables SQL data to {SQLDirectoryName}");                    
                }
            } 
            
            _bgw.RunWorkerAsync(allobjects);               
        }

        private void bgw_DoTableDataWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var allTableList = e.Argument as List<TableClass>;
            ExportClass ec = new ExportClass();
            _allTableContent = new List<string>()
            {
                {$@"/* ********* Tables data for {AktDBReg.Alias} ********** */"},
                {Environment.NewLine},
                {$@"/* ********* Date: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */" }
            };

            int n = 4;
            if (CreateDatabaseStatement)
            {
                _allTableContent.Add($@"/* ********* Create Database for {AktDBReg.Alias} ********** */");
            }

            if (CreateConnectionStatement)
            {
                _allTableContent.Add($@"/* ********* Connect Database for {AktDBReg.Alias} ********** */");
            }

           
            foreach (var str in allTableList)
            {
                Application.DoEvents();
                
                if (str.State != CheckState.Checked) continue;
                
             
                                    
                _bgw.ReportProgress(n++, $@"Reading data for {str.Name}...");

                ec.Init(AktDBReg,_localNotify);
                
                string cols = ec.GetTableColumns(str);
                if (string.IsNullOrEmpty(cols)) return;
                                    
               string donestr = ec.RefreshDatas(str, cols);
               if(donestr.Length > 0)
               {                    
                   _bgw.ReportProgress(n++, $@"ERROR reading data:{donestr}");
                   _bgw.CancelAsync();
                    break;
               }
               int datacount = ec.RefreshDataCount;
                
                Dictionary<string,string> lst = ec.ExportForInsertUpdate(CreateMode, str, cols);
                foreach(string obj in lst.Values)
                {
                    _allTableContent.Add(obj);
                }
               
                _allTableContent.Add($@"/* {str.Name} */{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");
                

                if(CommitAfterStatement)
                {
                    _allTableContent.Add($@"{SQLPatterns.Commit}{Environment.NewLine}");                    
                }
                

                if(WriteToFile   != eSQLFileWriteMode.none)
                {
                    try
                    {
                        if(WriteToFile == eSQLFileWriteMode.seperated)
                        {
                            _sw = null;
                            _sw = new StreamWriter(SQLDirectoryName+"\\"+str+".sql", false, CharSet.encoding);
                        }
                        foreach (string wstr in _allTableContent)
                        {
                            _sw.WriteLine(wstr);
                        }
                        if(WriteToFile == eSQLFileWriteMode.seperated)
                        {
                            if(_sw != null) _sw.Close();
                        }
                    }
                    catch(Exception ex)
                    {                       
                        _bgw.ReportProgress(1,$@"ERROR write to file {str.Name}, {ex.Message}");     
                    }
                }
                _bgw.ReportProgress(1,$@"Done for {str.Name} ({datacount}) datarows");                                          
            }
        }

        private void bgw_ProgressTableDataChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {            
            var ec = (string) e.UserState;
            if (ec == null) return;
                        
            try
            {
                if(ec.StartsWith("ERROR"))
                {
                    _localNotify?.AddToERROR(ec);
                }
                else
                {
                    _localNotify?.AddToINFO(ec);
                }
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"ExportClass->bgw_ProgressTableDataChanged->ec:{ec}", ex));                                                   
            }
                             
        }
        
        private void bgw_RunTableDataWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //NotificationsForm.Instance().Close();
            if (WriteToFile != eSQLFileWriteMode.none)
            {
                if(_sw != null) _sw.Close();
                _localNotify?.AddToINFO(_allTableContent.Count.ToString() + " lines written to file");                
            }

            if (!ShowScripting) return;                        
            ScriptingForm sc = new ScriptingForm(AktDBReg,_allTableContent);
            sc.BeginUpdate();
            sc.Show();
            Application.DoEvents();                                  
        }
        #endregion

        
      
        public void MakeScript()
        {
            var sc = new ScriptingForm(AktDBReg);
            sc.BeginUpdate();
            sc.Show();
            Application.DoEvents();
            int n = 0;
            sc.ClearSql();

            //Domains
            //Generators
            //StoredProcedures Head
            //Tables
            //Views
            //PrimaryKeys
            //ForeignKeys
            //Indicies
            //SET TERM ^ ;
            //Triggers
            //SET TERM ; ^
            //SET TERM ^ ;
            //StoredProcedure
            //SET TERM ; ^
            //Descriptions-Comments


            if(_allDatabaseContent != null)
            {
                foreach (string str in _allDatabaseContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            if(_allDomainContent != null)
            {
                foreach (string str in _allDomainContent)
            {
                  sc.AppendSql(str + Environment.NewLine);
            }
            }   
            if(_allGeneratorContent != null)
            {
                foreach (string str in _allGeneratorContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allFunctionDefinitionContent != null)
            {
                foreach (string str in _allFunctionDefinitionContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allProcedureDefinitionContent != null)
            {
                foreach (string str in _allProcedureDefinitionContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allTableContent != null)
            {
                foreach (string str in _allTableContent)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        if (str.EndsWith(Environment.NewLine))
                        {
                            sc.AppendSql(str);
                        }
                        else
                        {
                            sc.AppendSql(str + Environment.NewLine);
                        }
                    }
                    else
                    {
                        sc.AppendSql(Environment.NewLine);
                    }
                    n++;
                    if (n > 1000)
                    {
                        Application.DoEvents();
                        n = 0;
                    }
                }
            }
            if(_allPKConstraintsContent != null)
            {
                foreach (string str in _allPKConstraintsContent)
            {
                    sc.AppendSql(str + Environment.NewLine);
            }
            }
            if(_allFKConstraintsContent != null)
            {
                foreach (string str in _allFKConstraintsContent)
            {
                    sc.AppendSql(str + Environment.NewLine);
            }
            }
            if(_allIndexContent != null)
            {
                foreach (string str in _allIndexContent)
            {
                   sc.AppendSql(str + Environment.NewLine);
            }
            }
            if(_allTriggerContent != null)
            {
                foreach (string str in _allTriggerContent)
                {
                   sc.AppendSql(str + Environment.NewLine);
                }
            }
                    
            if(_allViewContent != null)
            {
                foreach (string str in _allViewContent)
                {
                   sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allFunctionContent != null)
            {
                foreach (string str in _allFunctionContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            
            if(_allProcedureContent != null)
            {
                foreach (string str in _allProcedureContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            

            sc.EndUpdate();  
        }

        public void MakeFiles()
        {
            var sc = new ScriptingForm(AktDBReg);
            sc.BeginUpdate();
            sc.Show();
            Application.DoEvents();
            int n = 0;
            sc.ClearSql();
             
            //Domains
            //Generators
            //StoredProcedures Head
            //Tables
            //Views
            //PrimaryKeys
            //ForeignKeys
            //Indicies
            //SET TERM ^ ;
            //Triggers
            //SET TERM ; ^
            //SET TERM ^ ;
            //StoredProcedure
            //SET TERM ; ^
            //Descriptions-Comments


            if(_allDatabaseContent != null)
            {
                foreach (string str in _allDatabaseContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            if(_allDomainContent != null)
            {
                foreach (string str in _allDomainContent)
            {
                  sc.AppendSql(str + Environment.NewLine);
            }
            }   
            if(_allGeneratorContent != null)
            {
                foreach (string str in _allGeneratorContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allFunctionDefinitionContent != null)
            {
                foreach (string str in _allFunctionDefinitionContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allProcedureDefinitionContent != null)
            {
                foreach (string str in _allProcedureDefinitionContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allTableContent != null)
            {
                foreach (string str in _allTableContent)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        if (str.EndsWith(Environment.NewLine))
                        {
                            sc.AppendSql(str);
                        }
                        else
                        {
                            sc.AppendSql(str + Environment.NewLine);
                        }
                    }
                    else
                    {
                        sc.AppendSql(Environment.NewLine);
                    }
                    n++;
                    if (n > 1000)
                    {
                        Application.DoEvents();
                        n = 0;
                    }
                }
            }
            if(_allPKConstraintsContent != null)
            {
                foreach (string str in _allPKConstraintsContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            if(_allFKConstraintsContent != null)
            {
                foreach (string str in _allFKConstraintsContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            if(_allIndexContent != null)
            {
                foreach (string str in _allIndexContent)
                {
                       sc.AppendSql(str + Environment.NewLine);
                }
            }
            if(_allTriggerContent != null)
            {
                foreach (string str in _allTriggerContent)
                {
                   sc.AppendSql(str + Environment.NewLine);
                }
            }
                    
            if(_allViewContent != null)
            {
                foreach (string str in _allViewContent)
                {
                   sc.AppendSql(str + Environment.NewLine);
                }
            }

            if(_allFunctionContent != null)
            {
                foreach (string str in _allFunctionContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            
            if(_allProcedureContent != null)
            {
                foreach (string str in _allProcedureContent)
                {
                        sc.AppendSql(str + Environment.NewLine);
                }
            }
            

            sc.EndUpdate();  
        }


        #region TableStructure
        public void StartworkerGetTableStructure(List<TableClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {        
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetTableStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetTableStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetTableStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO($@"Creating table structure AlterInsert SQL for {DBReg.Alias}");
            
            if (SQLDirectoryName != null)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL data to {SQLDirectoryName}");
            } 
            
            _bgw.RunWorkerAsync(allobjects);            
        }

        private void bgw_DoGetTableStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<TableClass> tb = (List<TableClass>) e.Argument;
            Dictionary<string,TableClass> alltables = new Dictionary<string, TableClass>();
            foreach(var itm in tb)
            {
                alltables.Add(itm.Name,itm);
            }
            
            _allTableContent = new List<string>();         
            int n = 0;
           
            var tlst = StaticTreeClass.Instance().GetAllTablesAlterInsertSQL(AktDBReg, alltables,CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding);                                           
            _bgw.ReportProgress(n++, tlst);    
            
        }

        private void bgw_ProgressGetTableStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            foreach(var obj in e.UserState as List<string>)
            {
                _allTableContent.Add(obj);
            }
        }

        private void bgw_RunWorkerGetTableStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
           // NotificationsForm.Instance().Close();
            if (WriteToFile != eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL table structure {_allTableContent.Count} lines to file");               
            }
            
            _bgw.CancelAsync();
        }
        #endregion

        private void bgw_DoGetViewStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var alltables = e.Argument as List<ViewClass>;
            _allViewContent = new List<string>();                       
            var vlst = StaticTreeClass.Instance().GetAllViewsAlterInsertSQL(AktDBReg, alltables,CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding);            
            if(vlst != null) _bgw.ReportProgress(1, vlst);
        }

        private void bgw_ProgressGetViewStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allViewContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetViewStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            
        }

        #region DatabaseStructure
        public void StartworkerGetDatabaseStructure(DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {        
           
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork                += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetDatabaseStructureWork);
            this._bgw.ProgressChanged       += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetDatabaseStructureChanged);
            this._bgw.RunWorkerCompleted    += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetDatabaseStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO($@"Creating Database structure AlterInsert SQL for {DBReg.Alias}");            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL data to {SQLDirectoryName}");
            }
            
            _bgw.RunWorkerAsync();            
        }

        private void bgw_DoGetDatabaseStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var dbReg = AktDBReg;
            _allDatabaseContent = new List<string>();                     
            if (CreateDatabaseStatement)
            {
                _allDatabaseContent.Add($@"/* ********* Create Database for {AktDBReg.Alias} ********** */{Environment.NewLine}");
                _allDatabaseContent.Add($@"CREATE DATABASE '{dbReg.Server}:{dbReg.DatabasePath}'{Environment.NewLine}USER '{dbReg.User}' PASSWORD '{dbReg.Password}'{Environment.NewLine}PAGE_SIZE {dbReg.PacketSize}{Environment.NewLine}DEFAULT CHARACTER SET {dbReg.CharSet};");
            }

            if (CreateConnectionStatement)
            {
                _allDatabaseContent.Add($@"/* ********* Connect Database for {AktDBReg.Alias} ********** */{Environment.NewLine}");
                _allDatabaseContent.Add($@"CONNECT '{dbReg.Server}:{dbReg.DatabasePath}' USER '{dbReg.User}' PASSWORD '{dbReg.Password}';");
            }                        
        }

        private void bgw_ProgressGetDatabaseStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {      
            
        }

        private void bgw_RunWorkerGetDatabaseStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {           
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL Database structure {_allDatabaseContent.Count} lines to file");                
            }
            
            _bgw.CancelAsync();
        }
        #endregion

        #region PKTableStructure
        public void StartworkerGetPKTableStructure(Dictionary<string,PrimaryKeyClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetPKTableStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetPKTableStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetPKTableStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating table structure AlterInsert SQL for " + DBReg.Alias);
            
                       
            _bgw.RunWorkerAsync(allobjects);            
        }

        private void bgw_DoGetPKTableStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {           
            var obj = e.Argument as Dictionary<string,PrimaryKeyClass>;
            _allPKConstraintsContent = new List<string>();            
            var tlst = StaticTreeClass.Instance().GetAllPKTablesAlterInsertSQL(AktDBReg, obj, CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            if(tlst != null) _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetPKTableStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allPKConstraintsContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetPKTableStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
           
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL primary key structure {_allPKConstraintsContent.Count} lines to {SQLDirectoryName}");
                
            }           
        }
        #endregion

        #region FKTableStructure
        public void StartworkerGetFKTableStructure(Dictionary<string,ForeignKeyClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetFKTableStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetFKTableStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetFKTableStructureCompleted);
            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating table structure AlterInsert SQL for " + DBReg.Alias);
                        
            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetFKTableStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            

            var obj = e.Argument as Dictionary<string,ForeignKeyClass>;
            _allFKConstraintsContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllFKTablesAlterInsertSQL(AktDBReg, obj, CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            if(tlst != null) _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetFKTableStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allFKConstraintsContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetFKTableStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL foreign key structure {_allFKConstraintsContent.Count} lines to {SQLDirectoryName}");            
            }            
        }
        #endregion

        #region IndexStructure
        public void StartworkerGetIndecesStructure(Dictionary<string,IndexClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetIndecesStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetIndecesStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetIndecesStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating index structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetIndecesStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allIndeces = e.Argument as Dictionary<string,IndexClass>;
            _allIndexContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllIndecesAlterInsertSQL(AktDBReg, allIndeces, CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetIndecesStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allIndexContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetIndecesStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {           
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL index structure {_allIndexContent.Count} lines to {SQLDirectoryName}");                
            }            
        }
        #endregion

        #region TriggerStructure
        public void StartworkerGetTriggerStructure(Dictionary<string,TriggerClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetTriggerStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetTriggerStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetTriggerStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating trigger structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetTriggerStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allTriggers = e.Argument as Dictionary<string,TriggerClass>;
            _allTriggerContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllTriggersAlterInsertSQL(AktDBReg, allTriggers, CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetTriggerStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allTriggerContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetTriggerStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL trigger structure {_allTriggerContent.Count} lines to file {SQLDirectoryName}");                
            }            
        }
        #endregion

        #region ProcedureStructure
        public void StartworkerGetProcedureStructure(Dictionary<string,ProcedureClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetProcedureStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetProcedureStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetProcedureStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating procedure structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetProcedureStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allProcedures = e.Argument as Dictionary<string,ProcedureClass>;
            _allProcedureContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllProcedureAlterInsertSQL(AktDBReg, allProcedures, CreateMode, CommitAfterStatement,true,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetProcedureStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allProcedureContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetProcedureStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL procedure structure {_allProcedureContent.Count} lines to {SQLDirectoryName}");                
            }            
        }
        #endregion

        #region ProcedureDefinitionStructure
        public void StartworkerGetProcedureDefinitionStructure(Dictionary<string,ProcedureClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetProcedureDefinitionStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetProcedureDefinitionStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetProcedureDefinitionStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating procedure structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetProcedureDefinitionStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allProcedures = e.Argument as Dictionary<string,ProcedureClass>;
            _allProcedureDefinitionContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllProcedureAlterInsertSQL(AktDBReg, allProcedures, CreateMode, CommitAfterStatement,false,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetProcedureDefinitionStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allProcedureDefinitionContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetProcedureDefinitionStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL procedure structure {_allProcedureDefinitionContent.Count} lines to file {SQLDirectoryName}");                
            }            
        }
        #endregion


        #region FunctionStructure
        public void StartworkerGetFunctionStructure(Dictionary<string,FunctionClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetFunctionStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetFunctionStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetFunctionStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating function structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetFunctionStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allFunctions = e.Argument as Dictionary<string,FunctionClass>;
            _allFunctionContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllFunctionAlterInsertSQL(AktDBReg, allFunctions, CreateMode, CommitAfterStatement,true,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetFunctionStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allFunctionContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetFunctionStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL function structure {_allFunctionContent.Count} lines to {SQLDirectoryName}");                
            }            
        }
        #endregion

        #region FunctionDefinitionStructure
        public void StartworkerGetFunctionDefinitionStructure(Dictionary<string,FunctionClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetFunctionDefinitionStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetFunctionDefinitionStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetFunctionDefinitionStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating function structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetFunctionDefinitionStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allFunctions = e.Argument as Dictionary<string,FunctionClass>;
            _allFunctionDefinitionContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllFunctionAlterInsertSQL(AktDBReg, allFunctions, CreateMode, CommitAfterStatement,false,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetFunctionDefinitionStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allFunctionDefinitionContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetFunctionDefinitionStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL function structure {_allFunctionDefinitionContent.Count} lines to {SQLDirectoryName}");                
            }            
        }
        #endregion
        
        #region DomainStructure
        public void StartworkerGetDomainStructure(Dictionary<string,DomainClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetDomainStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetDomainStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetDomainStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating domain structure SQL for " + DBReg.Alias);
            


            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetDomainStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            var allDomain = e.Argument as Dictionary<string,DomainClass>;
            _allDomainContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllDomainAlterInsertSQL(AktDBReg, allDomain, CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetDomainStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allDomainContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetDomainStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL domain structure {_allDomainContent.Count} lines to file {SQLDirectoryName}");                
            }            
        }
        #endregion

        #region DomainStructure
        public void StartworkerGetGeneratorStructure(Dictionary<string,GeneratorClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
            SQLDirectoryName = sqlDirectoryName; SQLFileName = sqlFileName;
            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetGeneratorStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetGeneratorStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetGeneratorStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating generator structure SQL for " + DBReg.Alias);
            

            _bgw.RunWorkerAsync(allobjects);
        }

        private void bgw_DoGetGeneratorStructureWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var allGenerator = e.Argument as Dictionary<string,GeneratorClass>;
            _allGeneratorContent = new List<string>();
            var tlst = StaticTreeClass.Instance().GetAllGeneratorAlterInsertSQL(AktDBReg, allGenerator, CreateMode, CommitAfterStatement,SQLDirectoryName,SQLFileName,WriteToFile,CharSet.encoding); 
            _bgw.ReportProgress(1, tlst);
        }

        private void bgw_ProgressGetGeneratorStructureChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _allGeneratorContent.AddRange(e.UserState as List<string>);
        }

        private void bgw_RunWorkerGetGeneratorStructureCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            if (WriteToFile == eSQLFileWriteMode.all)
            {
                NotifiesClass.Instance.AddToINFO($@"Writing SQL generator structure {_allGeneratorContent.Count} lines to {SQLDirectoryName}");         
            }
        }
        #endregion

        #region ViewStructure
        public void StartworkerGetViewStructure(List<ViewClass> allobjects, DBRegistrationClass DBReg, string sqlDirectoryName, string sqlFileName)
        {
            if(allobjects?.Count <= 0) return;
            AktDBReg = DBReg;
           
            SQLDirectoryName = sqlDirectoryName;
            SQLFileName = sqlFileName;

            WaitForWorker();

            this._bgw = new System.ComponentModel.BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };
            this._bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoGetViewStructureWork);
            this._bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressGetViewStructureChanged);
            this._bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerGetViewStructureCompleted);

            NotificationsForm.Instance().Show();
            
            NotifiesClass.Instance.AddToINFO("Creating view structure SQL for " + DBReg.Alias);
            
                        
            _bgw.RunWorkerAsync(allobjects);
        }

        
        #endregion
    }
}
