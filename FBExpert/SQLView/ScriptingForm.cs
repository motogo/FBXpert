using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FirebirdSql.Data.FirebirdClient;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FBXpert.SQLView
{
    public partial class ScriptingForm
    {
        private DBRegistrationClass _actScriptingDbReg;
        private FileInfo _fi;
        private string _lastDirectory;                     
        private AutocompleteClass _ac;
        
        private readonly NotifiesClass _notifies = new NotifiesClass();     
        private DBBasicClassLibrary.SQLScriptingClass _sql = null;

        public ScriptingForm(DBRegistrationClass drc)
        {
            InitializeComponent();
            MdiParent = FbXpertMainForm.Instance();
            _actScriptingDbReg = drc;
            _lastDirectory = _actScriptingDbReg.InitialScriptingPath;
            _notifies.Register4Info(FormMeldungRaised);
            _notifies.Register4Error(FormErrorRaised);                   
            
            fcbSQL.Clear();
            fcbSQL.SelectionStart = 0;
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_actScriptingDbReg);
            _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _actScriptingDbReg.NewLine, _actScriptingDbReg.CommentStart, _actScriptingDbReg.CommentEnd, _actScriptingDbReg.SingleLineComment, "SCRIPT");
            _sql.RegisterInfoNotify(EventMeldungRaised);
        }

        public ScriptingForm(DBRegistrationClass drc, List<string> script)
        {
            InitializeComponent();
            MdiParent = FbXpertMainForm.Instance();
            _actScriptingDbReg = drc;
            _lastDirectory = _actScriptingDbReg.InitialScriptingPath;
            _notifies.Register4Info(FormMeldungRaised);
            _notifies.Register4Error(FormErrorRaised);
                     
            fcbSQL.Clear();            
            fcbSQL.SelectionStart = 0;           
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_actScriptingDbReg);
            _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _actScriptingDbReg.NewLine, _actScriptingDbReg.CommentStart, _actScriptingDbReg.CommentEnd, _actScriptingDbReg.SingleLineComment, "SCRIPT");
            foreach (string str in script)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.EndsWith(Environment.NewLine))
                    {
                       this.AppendSql(str);
                    }
                    else
                    {
                        this.AppendSql(str + Environment.NewLine);
                    }
                }
                else
                {
                    this.AppendSql(Environment.NewLine);
                }                
            }
        }
                
        public void FormMeldungRaised(object sender, MessageEventArgs e)
        {
           fcbNotify.AppendText(e.Meldung);
        }
        public void ScriptInfoRaised(object sender, MessageEventArgs e)
        {
            if(e.Data.GetType() == typeof(SCRIPTCommandClass))
            {
                var sc = (SCRIPTCommandClass)e.Data;
                fcbNotify.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} {e.Meldung}->{e.Key}->{sc.CommandType}->done in {sc.Costs} ms{Environment.NewLine}");
            }
            else
            {
                fcbNotify.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} {e.Meldung}->{e.Key}{Environment.NewLine}");
            }
        }

        public void EventMeldungRaised(object sender, MessageEventArgs e)
        {
           if(e.Key.ToString() == StaticVariablesClass.CommandDone)
           {
               if(pbProgress.Value >= pbProgress.Maximum) pbProgress.Value = 0;
               pbProgress.Value++;
               lblGauge.Text = $@"Progress execute commands (done:{pbProgress.Value})";                               
               Application.DoEvents();  

               var cc = (DBBasicClassLibrary.SCRIPTCommandClass) e.Data;
               ListViewItem lvi = lvCommands.FindItemWithText(cc.GUID);
               if(lvi != null)
               {
                   lvi.SubItems[3].Text = cc.Costs.ToString();
               }
           }
           else if(e.Key.ToString() == StaticVariablesClass.CommandPrepared)
           {
               var cdc = (DBBasicClassLibrary.SCRIPTCommandClass) e.Data;
               string cmdtxt =  SQLCommand.RemoveNotNeccessaryCharsStatic(cdc.CommandText);
               string[] cols = {cdc.GUID.ToString(),cmdtxt,cdc.CommandType.ToString(),"" };
               ListViewItem lvi = new ListViewItem(cols);               
               lvi.Text = cdc.GUID;
               lvi.Tag = cdc;
               lvCommands.Items.Add(lvi);    
               lvCommands.Items[lvCommands.Items.Count - 1].EnsureVisible();
               gbCommandsDone.Text = $@"Commands:{lvCommands.Items.Count}";
           }
           else if(e.Key.ToString() == StaticVariablesClass.AddCommandLine)
           {                
               pbProgress.Value++;
               lblGauge.Text = $@"Progress prepare commands (done:{pbProgress.Value})";                               
               Application.DoEvents();        
           }           
        }

        public void FormErrorRaised(object sender, MessageEventArgs e)
        {            
            fcbNotify.AppendText($@"{e.Meldung}{ Environment.NewLine}");
        }

        public void ScriptErrorRaised(object sender, MessageEventArgs e)
        {
            if (e.Data.GetType() == typeof(SCRIPTCommandClass))
            {
                var sc = (SCRIPTCommandClass)e.Data;
                fcbNotify.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} {e.Meldung}->{e.Key}->{sc.CommandType}->done in {sc.Costs} ms{Environment.NewLine}");
            }
            else
            {
                fcbNotify.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} {e.Meldung}->{e.Key}{Environment.NewLine}");
            }
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void DefaultForm_Load(object sender, EventArgs e)
        {                                           
            ofdSQL.InitialDirectory = DBStaticData.ChangeToFullPath(_actScriptingDbReg.InitialScriptingPath);
            GetDatabases();
            ShowCaptions();
            Anzeige();
            SetFilesVibibilies();    
            tabScripting.SelectedTab = tabSQL;
            
            if(fcbSQL.Lines.Count > 0) fcbSQL.Enabled = true;
            hsRunSQLDirect.Enabled = false;
            hsPrepareCommands.Enabled = fcbSQL.LinesCount > 0;
          //  SEHotSpot.Controller.Instance().SetHookForm(this);
          //  SEHotSpot.Controller.Instance().SetupKeyboardHooks(this); // ctrl = new SEHotSpot.Controller();
            //ctrl.SetupKeyboardHooks(this);
        }

        private void GetDatabases()
        {
            cbConnection.Items.Clear();
            foreach (var dbr in DatabaseDefinitions.Instance().Databases)
            {
                cbConnection.Items.Add(dbr);
            }
            if (FbXpertMainForm.Instance().ActRegistrationObject != null)
            {                
               int n = cbConnection.FindString(FbXpertMainForm.Instance().ActRegistrationObject.ToString());
               cbConnection.SelectedIndex = n;
            }
        }
        
        public void ShowCaptions()
        {
            lblCaption.Text = "Scripting";
            Text = DevelopmentClass.Instance().GetDBInfo(_actScriptingDbReg,"Scripting");
        }

        private void Save()
        {
            sfSQL.InitialDirectory = _lastDirectory;
            if (sfSQL.ShowDialog() == DialogResult.OK)
            {
                fcbSQL.SaveToFile(sfSQL.FileName,Encoding.UTF8);
            }
        }

        private void hsSave_Click(object sender, EventArgs e)
        {            
            Save();
        }

        private void hsLoadScript_Click(object sender, EventArgs e)
        {
            LoadSingleFile();
        }

        private void LoadSingleFile()
        {
            ofdSQL.InitialDirectory = _lastDirectory;
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;            
            fcbSQL.Clear();
            Cursor = Cursors.WaitCursor;            
            var fi = new FileInfo(ofdSQL.FileName);
            _lastDirectory = fi.DirectoryName;
            gbSQL.Text = fi.FullName;
            
            fcbSQL.BeginUpdate();                       
            fcbSQL.OpenFile(ofdSQL.FileName, Encoding.UTF8);
            fcbSQL.EndUpdate();                
            Cursor = Cursors.Default;
            
            Anzeige();            
        }

        public void Anzeige()
        {
           gbSQLText.Text = $@"SQL number of lines:{fcbSQL.Lines.Count}";
        }
        
        public void BeginUpdate()
        {
            fcbSQL.BeginUpdate();
            fcbSQL.Enabled = false;
        }
        
        public void EndUpdate()
        {
            fcbSQL.EndUpdate();
            fcbSQL.Enabled = true;
        }

        public void AppendSql(string sql)
        {
            fcbSQL.AppendText(sql);
        }
        
        public void ClearSql()
        {
            fcbSQL.Clear();
        }
        
        private void hsMakeExecutableCommands_Click(object sender, EventArgs e)
        {           
            if (lvFiles.Items.Count <= 0) return;
                                    
            Cursor = Cursors.WaitCursor;
            foreach (ListViewItem lvi in lvFiles.SelectedItems)
            {
                var fi = (FileInfo) lvi.Tag;
                if (fi == null) continue;
                gbSQL.Text = fi.FullName;                            
                Application.DoEvents();                                
                ExecuteCommandsFromFile(fi.FullName);                                
            }
            Cursor = Cursors.Default;
            Application.DoEvents();                    
        }
                      
        private FbConnection CreateConnection(string sqlCmd, FbConnection fbConn)
        {
            /*
            CONNECT 'LOCALHOST:D:\Data\test.fdb' USER 'SYSDBA' PASSWORD 'masterkey';
            */
            string sql = sqlCmd.ToUpper();
            string location = "D:\\Data\\test111.FDB";
           
            string user = "SYSDBA";
            string password = "masterkey";
                        
            int inx = sql.IndexOf("CONNECT ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 8);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg  = cmd3.Substring(0, inx2);

                int inx3 = arg.IndexOf(":\\", StringComparison.Ordinal);
                int inx4 = arg.IndexOf(":", StringComparison.Ordinal);
                if (inx4 < inx3)
                {
                    //server
                  
                    location = arg.Substring(inx4 + 1);
                    location = location.Replace("'", "");
                }
                else
                {
                    //nur dateipfad
                  
                    location = arg.Replace("'", ""); 
                }
            }

            inx = sql.IndexOf("USER ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                var cmd3 = sqlCmd.Substring(inx + 5);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                var arg = cmd3.Substring(0, inx2);
                user = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PASSWORD ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                var cmd3 = sqlCmd.Substring(inx + 9);
                
                var arg = cmd3.Substring(0);
                password = arg.Replace("'", ""); 
            }

            var drc = new DBRegistrationClass
            {
                DatabasePath = location,
                Dialect = 3,
                Password = password,
                User = user,
                Alias = "ConScript",
                CharSet = "UTF8",
                Server = "localhost",
                ConnectionType = eConnectionType.server
            };


            string connstr = ConnectionStrings.Instance().MakeConnectionString(drc);
            if (fbConn?.State == System.Data.ConnectionState.Open)
            {
                fbConn.Close();
            }
            fbConn = new FbConnection(connstr);
            fbConn.Open();
            _notifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " ...Opening database via script" + drc);
            _notifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " ...Database state:"+fbConn.State.ToString());
            return fbConn;

        }

        private bool CreateDatabase(string sqlCmd)
        {
            /*
                CREATE DATABASE 'localhost:D:\Data\kj\KJFERT59.FDB'
                USER 'SYSDBA' PASSWORD 'masterkey'
                PAGE_SIZE 8192
                DEFAULT CHARACTER SET NONE;
                */
            string sql = sqlCmd.ToUpper();
            string location = "D:\\Data\\test111.FDB";
            string server = "localhost";
            string user = "SYSDBA";
            string password = "masterkey";
            string packetsize = "8192";
            
            int inx = sql.IndexOf("CREATE DATABASE ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 16);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);

                int inx3 = arg.IndexOf(":\\", StringComparison.Ordinal);
                int inx4 = arg.IndexOf(":", StringComparison.Ordinal);
                if (inx4 < inx3)
                {
                    //server
                    server = arg.Substring(0, inx4).Replace("'", "");
                    location = arg.Substring(inx4 + 1);
                    location = location.Replace("'", "");
                }
                else
                {
                    //nur dateipfad
                    server = "localhost";
                    location = arg.Replace("'", ""); 
                }
            }

            inx = sql.IndexOf("USER ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 5);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                user = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PASSWORD ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 9);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                password = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PAGE_SIZE ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 10);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                packetsize = arg;
            }

            try
            {
                _notifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} ...Creating new database via script {server}:{location}");
                DBProviderSet.CreateDatabase(location, server, user, password, StaticFunctionsClass.ToIntDef(packetsize, AppSettingsClass.Instance().DatabaseSettings.DefaultPacketSize));
            }
            catch (Exception ex)
            {               
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> CreateDatabase()", ex));                      
            }

            return true;
        }
        
        private FbConnection IsCreateDatabaseOrConnect(string cmd, FbConnection fbcon)
        {
            
            FbConnection useCon = fbcon;
            string cmd1 = cmd.Trim();

            while (cmd1.IndexOf("\r\n", StringComparison.Ordinal) >= 0)
            {
                cmd1 = cmd1.Replace("\r\n", " ");
            }

            while (cmd1.IndexOf("  ", StringComparison.Ordinal) >= 0)
            {
                cmd1 = cmd1.Replace("  ", " ");
            }

            string cmd2 = cmd1.ToUpper();
            if (cmd2.StartsWith("CREATE DATABASE"))
            {
                CreateDatabase(cmd1);                
                return useCon;
            }
            else if(cmd2.StartsWith("CONNECT"))
            {
                useCon = CreateConnection(cmd1,fbcon);                
                return useCon;
            }           
            return null;
        }
               
        private void RunSingleCommand(DBBasicClassLibrary.SCRIPTCommandClass command)
        {            
            _notifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()}->{command.CommandType}->Executing");
            Application.DoEvents();
            
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_actScriptingDbReg);
            _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _actScriptingDbReg.NewLine, _actScriptingDbReg.CommentStart, _actScriptingDbReg.CommentEnd, _actScriptingDbReg.SingleLineComment, "SCRIPT");
            _sql.ScriptNotify.Register4Info(ScriptInfoRaised);
            _sql.ScriptNotify.Register4Error(ScriptErrorRaised);
            _sql.Commands.Clear();                                            
            FbConnection fbConn = null;
            FbCommand fbCmd = null;
            bool connOpen = false;
           
            if (_actScriptingDbReg.DatabasePath.Length > 0)
            {              
                try
                {
                    fbConn = new FbConnection(_connstr);
                    fbConn.Open();
                    connOpen = fbConn.State == System.Data.ConnectionState.Open;
                }
                catch(Exception ex)
                {
                    Enabled = false;                        
                    object[] param = {ex.Message};
                    SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseExceptionCaption","ErrorWhileOpeningDatabase",  SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation,null,param);
                    Enabled = true;
                    BringToFront();
                }
            }                
            
            if (connOpen)
            {      
                var sw = new Stopwatch();
                sw.Start();                                
                FbConnection usedCon = IsCreateDatabaseOrConnect(command.CommandText,fbConn);
                if(usedCon != null)
                {
                    //Create database oder connect database
                    fbConn = usedCon;                
                }
                else // kein create oder connect, voreingestellte connetion wird verwended
                {                                       
                    fbCmd = new FbCommand(command.CommandText, fbConn);
                    fbCmd.Transaction = fbConn.BeginTransaction();                                                                          
                    try
                    {                                                                
                        if(command.CommandType == SQLCommandType.commit)
                        {
                            fbCmd.Transaction.Commit();                       
                        }
                        else
                        {
                           fbCmd.ExecuteNonQuery(); 
                           if(fbCmd.Transaction!= null) fbCmd.Transaction.Commit(); 
                        }          
                        
                    }
                    catch (Exception ex)
                    {
                        if(fbCmd.Transaction != null)
                        {
                           fbCmd.Transaction.Rollback();                           
                        }
                        fbCmd.Transaction = null;
                        _notifies?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"Command error {fbCmd.CommandText}", ex));                            
                    }
                    
                }                                                                                                                                 
                if (connOpen) fbConn.Close();
                sw.Stop();                                
                Cursor = Cursors.Default;
                _notifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()}->{command.CommandType}->done in {sw.ElapsedMilliseconds} ms");
                Application.DoEvents();
            }
            else
            {
                _notifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} Database {_actScriptingDbReg.Alias} not open ");
                Application.DoEvents();
            }
        }
                              
        private void PrepareCommandsFromSQL()
        {            
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_actScriptingDbReg);
            _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _actScriptingDbReg.NewLine, _actScriptingDbReg.CommentStart, _actScriptingDbReg.CommentEnd, _actScriptingDbReg.SingleLineComment, "SCRIPT");            
            _sql.RegisterInfoNotify(EventMeldungRaised);
            if (cbClearBeforePreparing.Checked)
            {                               
                lvCommands.Items.Clear();
            }
            pbProgress.Maximum = fcbSQL.Lines.Count;;
            pbProgress.Minimum = 0;
            pbProgress.Value = 0;
            _sql.PrepareCommands(fcbSQL.Lines,cbClearBeforePreparing.Checked);       
            int clearAfter = StaticFunctionsClass.ToIntDef(txtClear.Text, 1000);                   
        }
                
        private void ExecuteCommandsFromFile(string filename)
        {
            var fi = new FileInfo(filename);
            if(!fi.Exists) return;
            
            var content = new StringBuilder();
            _notifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} Prepare executing script in file {filename}");
            Application.DoEvents();            
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_actScriptingDbReg);
            _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _actScriptingDbReg.NewLine, _actScriptingDbReg.CommentStart, _actScriptingDbReg.CommentEnd, _actScriptingDbReg.SingleLineComment, "SCRIPT");
            _sql.RegisterInfoNotify(EventMeldungRaised);
            _sql.Commands.Clear();
                                                            
            int lineCount = 0;
            int clearAfter = StaticFunctionsClass.ToIntDef(txtClear.Text, 1000);
                                             
            fcbCommands.Clear();
            fcbCommands.BeginUpdate();            
            content.Clear();
            long mx = fi.Length / 20;
            pbProgress.Maximum = (int) mx;
            pbProgress.Minimum = 0;
            pbProgress.Value = 0;

            using (var sr = new StreamReader(fi.FullName, Encoding.Default))
            {  
                if(pbProgress.Maximum >= pbProgress.Minimum) pbProgress.Value = 0;
                var startDt = DateTime.Now;
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();                                                               
                    bool cmdeady = _sql.AddCommandLine($@"{str}{Environment.NewLine}");
                    if (!cmdeady) continue;                                        
                    lineCount++;
                    var returnList =_sql.RunPreparedCommands();                                    
                    _sql.Commands.Clear();                       
                }
                fcbCommands.EndUpdate();                                        
                Cursor = Cursors.Default;                
                _notifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} Preparing done {lineCount.ToString()} commands");
                Application.DoEvents();
            }            
        }
                                        
        private void cmsSQLText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDDLCopyToClipboard)
            {
                Clipboard.SetText(fcbSQL.SelectedText);
            }
            else if (e.ClickedItem == tsmiDDLPaste)
            {
                if ((fcbSQL.SelectionStart < 0)||(fcbSQL.SelectionStart >= fcbSQL.Text.Length)) fcbSQL.Text = fcbSQL.Text.Insert(0, Clipboard.GetText());
                else fcbSQL.Text =  fcbSQL.Text.Insert(fcbSQL.SelectionStart, Clipboard.GetText());
            }            
        }                       

        private void hsLoad_Click(object sender, EventArgs e)
        {
            ofdSQL.InitialDirectory = _lastDirectory;
            if (ofdSQL.ShowDialog() == DialogResult.OK)
            {
               txtSQLLocation.Text = ofdSQL.FileName;               
               _fi = new FileInfo(txtSQLLocation.Text);
               txtFileSize.Text = (_fi.Length/1024).ToString();
               _lastDirectory = _fi.DirectoryName;
            }
        }

        private void hsAddBackupFile_Click(object sender, EventArgs e)
        {
            int fLength = StaticFunctionsClass.ToIntDef(txtFileSize.Text.Trim(), 0);
            string[] obarr = { txtSQLLocation.Text, fLength.ToString() };
            var lvi = new ListViewItem(obarr)
            {
                Tag = _fi
            };
            lvFiles.Items.Add(lvi);
        }

        private void hsRemoveBackupFile_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count <= 0) return;
            lvFiles.SelectedItems[0].Remove();
        }
       
        private void hsClearCmds_Click(object sender, EventArgs e)
        {
            fcbCommands.Clear();
        }

        private void hsClearSQL_Click(object sender, EventArgs e)
        {
            fcbSQL.Clear();
        }

        private void hsPrepareCommands_Click(object sender, EventArgs e)
        {                                 
            tabScripting.SelectedTab = tabPagePreparedCommands;
            PrepareCommandsFromSQL();
            lvCommands.Items[0].Selected = true; 
        }

        private void txtSQLLocation_TextChanged(object sender, EventArgs e)
        {
            gbSQL.Text = txtSQLLocation.Text;
        }

        private void lvFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilesVibibilies();            
        }

        public void SetFilesVibibilies()
        {
            hsRunSQLDirect.Enabled = (lvFiles.SelectedItems.Count > 0);
            if (lvFiles.Items.Count <= 0) return;
            if (lvFiles.SelectedItems.Count <= 0) return;
            var lvi = lvFiles.SelectedItems[0];
            if (lvi == null) return;
            
            var fii = (FileInfo)lvi.Tag;
            txtSQLLocation.Text = fii.FullName;                                                          
        }
       
        private void cbConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            _actScriptingDbReg = cbConnection.SelectedItem as DBRegistrationClass;
            _ac = new AutocompleteClass(fcbSQL, _actScriptingDbReg);
            _ac.RefreshAutocompleteForDatabase();
           // _ac2 = new AutocompleteClass(fcbCommands, _actScriptingDbReg);
            _ac.AssignToObject(fcbCommands);
        }

        private void fcbSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != (Keys.K | Keys.Control)) return;
            _ac?.Show();
            e.Handled = true;
        }

        private void fcbCommands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != (Keys.K | Keys.Control)) return;
            _ac?.Show();
            e.Handled = true;
        }

        private void tabScripting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabScripting.SelectedTab == tabPageFiles)
            {
                hsRunSQLDirect.Enabled = (lvFiles.SelectedItems.Count > 0);
                hsPrepareCommands.Enabled = false;
            }
            else
            {
                hsRunSQLDirect.Enabled = false;
                hsPrepareCommands.Enabled = fcbSQL.LinesCount > 0;
            }
        }

        private void fcbSQL_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData != (Keys.K | Keys.Control)) return;
            _ac?.Show();
            e.Handled = true;
        }

        private void lvCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
           fcbCommands.Text = string.Empty;
           if(lvCommands.SelectedItems.Count > 0)
           {
               //KeyValuePair<string,SCRIPTCommandClass> dc = (KeyValuePair<string,SCRIPTCommandClass>) lvCommands.SelectedItems[0].Tag;           

               var dc =  (DBBasicClassLibrary.SCRIPTCommandClass) lvCommands.SelectedItems[0].Tag;         
               fcbCommands.Text = dc.CommandText;
           }
           Application.DoEvents();
        }

        private void hsRunActualCommand_Click(object sender, EventArgs e)
        {
            if(lvCommands.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvCommands.SelectedItems[0];
                //var cc = (KeyValuePair<string,DBBasicClassLibrary.SCRIPTCommandClass>) lvi.Tag;
                var cc = (DBBasicClassLibrary.SCRIPTCommandClass) lvi.Tag;
                RunSingleCommand(cc);
            }
        }

        private void hsRunAllCommands_Click(object sender, EventArgs e)
        {           
            pbProgress.Maximum = _sql.CommandsCount;
            pbProgress.Minimum = 0;
            pbProgress.Value = 0;
            _sql.ScriptNotify.Register4Info(ScriptInfoRaised);
            _sql.ScriptNotify.Register4Error(ScriptErrorRaised);
            _sql.RunPreparedCommands();            
        }

        private void hsRunSQLDirect_Click(object sender, EventArgs e)
        {

        }

        private void hotSpot4_Click(object sender, EventArgs e)
        {

        }

        private void tabSQL_Click(object sender, EventArgs e)
        {

        }

    }
}
