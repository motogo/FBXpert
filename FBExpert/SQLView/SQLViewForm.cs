using BasicClassLibrary;
using BasicForms;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using Initialization;
using MessageLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace SQLView
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    partial class SQLViewForm1 : INormalForm
	{
	    private HistoryMode _history;
	    private SQLCommandsClass _sqLcommand = null;        
        private eColorDesigns _appDesign = eColorDesigns.Gray;
        private eColorDesigns _developDesign = eColorDesigns.Gray;
	    private readonly DBRegistrationClass _dbReg = null;
        private string _cmd = string.Empty;
        private int _cmdDone = 0;
        private int _cmdError = 0;        
	    private readonly NotifiesList _localNotifies = new NotifiesList();
	    //private AutocompleteClass _ac = null;        
        private bool _testlauf = true;
	    private readonly List<string> _obcmd = new List<string>();        
        
        eSort _lastSort = eSort.DESC;

        public SQLViewForm1(DBRegistrationClass ca,  Form mdiParent = null, eColorDesigns appDesign = eColorDesigns.Gray, eColorDesigns developDesign = eColorDesigns.Gray, bool testMode = false)
        {
            MdiParent = mdiParent;
            _dbReg = ca;
            
            _appDesign = appDesign;
            _developDesign = developDesign;
            InitializeComponent();

            var nf = new NotifiesClass();
            nf.gaugeNotify.OnRaiseGaugeHandler += new NotifyGauge.RaiseGaugeHandler(GaugeRaised);
            _localNotifies.AddNotify(nf,"SQLViewForm");
            _localNotifies.AddNotify(NotifiesClass.Instance(),"GLOBAL");
            _sqLcommand = new SQLCommandsClass(_dbReg,_localNotifies.Find("SQLViewForm"));     
            tabPageSucceeded.Text = "commands succeded DESC";
            Meldungen();
            Errors();                        
            History();                     
            ClearDevelopDesign(_developDesign);
            SetDesign(_appDesign);
            cbTestlauf.Checked = testMode;
            cbTestlauf.Visible = testMode;     
            
        }
           
        void Meldungen()
        {
            var nf = _localNotifies.Find("SQLViewForm");
            if (nf == null) return;            
            if (cbMeldungen.Checked) nf.Notify.OnRaiseInfoHandler += new NotifyInfos.RaiseNotifyHandler(InfoRaised);
            else                     nf.Notify.OnRaiseInfoHandler -= new NotifyInfos.RaiseNotifyHandler(InfoRaised);
               
        }

        void Errors()
        {
            var nf = _localNotifies.Find("SQLViewForm");
            if (nf == null) return;            
            if (cbMeldungen.Checked) nf.Notify.OnRaiseErrorHandler += new NotifyInfos.RaiseNotifyHandler(ErrorRaised);
            else                     nf.Notify.OnRaiseErrorHandler -= new NotifyInfos.RaiseNotifyHandler(ErrorRaised);                           
        }
        
        void History()
        {
            _history = (cbHistory.Checked) ?  HistoryMode.AddToHistory : HistoryMode.NoHistory;            
        }

        void GaugeRaised(object sender, MessageEventIntArgs k)
        {
            progressBar1.Value += k.N;
        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            if (DoInfoNotifications)
            {
                _cmdDone++;
                tabMELDUNG.Text = $@"Messages ({_cmdDone})";
                if (((txtMeldIntervall.Inhalt.Length > 0)&&(cbErrAutoclear.Checked))&&(rtfMELDUNG.Lines.Length > Int32.Parse(txtMeldIntervall.Inhalt)))
                {                   
                    rtfMELDUNG.Clear();                   
                }
                
                if (rbMeldAppend.Checked)
                {
                    rtfMELDUNG.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} {k.Meldung}");
                    if (cbAutoScroll.Checked)
                    {
                        rtfMELDUNG.SelectionStart = rtfMELDUNG.TextLength;
                        rtfMELDUNG.Select(rtfMELDUNG.TextLength, 0);
                        rtfMELDUNG.ScrollToCaret();
                        rtfMELDUNG.Refresh();
                    }
                }
                else
                {
                    rtfMELDUNG.SelectionStart = 0;
                    rtfMELDUNG.Select(0, 0);
                    rtfMELDUNG.Text.Insert(0, $@"{StaticFunctionsClass.DateTimeNowStr()} {k.Meldung}");
                    rtfMELDUNG.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} {k.Meldung}");
                }                
            }

            var nf = _localNotifies.Find("GLOBAL");
            if(nf == null) return;            
            nf.Notify.OnRaiseInfo(k);               
        }
        
        void ErrorRaised(object sender, MessageEventArgs k)
        {
            _cmdError++;
            tabERRORS.Text = $@"Errors ({_cmdError})";

            if ((txtErrIntervall.Inhalt.Length > 0)&&(cbErrAutoclear.Checked))
            {
                if (rtfERRORS.Lines.Length > Int32.Parse(txtErrIntervall.Inhalt))
                {
                    rtfERRORS.Clear();
                }
            }
            if (rbErrAppend.Checked)
            {
                rtfERRORS.AppendText(k.Meldung);
                if (cbAutoSrcollErr.Checked)
                {
                    rtfERRORS.SelectionStart = rtfERRORS.TextLength;
                    rtfERRORS.Select(rtfERRORS.TextLength, 0);
                    rtfERRORS.ScrollToCaret();
                    rtfERRORS.Refresh();
                }
            }
            else
            {
                rtfERRORS.Text.Insert(0, k.Meldung);
            }
            NotifiesClass nf = _localNotifies.Find("GLOBAL");
            if (nf != null)
            {
                nf.Notify.OnRaiseError(k);
            }
        }

        private void btnDO_SQL_Click(object sender, EventArgs e)
        {            
            ExecSql(HistoryMode.AddToHistory);
            tcSQLCONTROL.SelectedTab = tabRESULT;
        }

        private void ExecSqlThread(HistoryMode toHistory)
        {
            ThreadStart ts = new ThreadStart(ExecSql);
            Thread th = new Thread(ts);
            th.Start();
            while (th.ThreadState == System.Threading.ThreadState.Stopped)
            {
                Thread.Sleep(100);
            }
        }

        private void ExecSql()
        {
            ExecSqlTh(HistoryMode.NoHistory,(string[])txtSQL.Lines);
        }

        private string GetTerm(string[] cmds)
        {
            string term = "";

            for (int i = cmds.Length - 1; i > 0; i--)
            {
                if (cmds[i].Trim().Length > 0)
                {
                    term = cmds[i].Trim().Substring(cmds[i].Trim().Length - 1, 1);
                    break;
                }
            }
            if (term.Trim().Length <= 0)
            {
                term = ";";
            }
            return(term);
        }
        
        private void AddToHistory(HistoryMode toHistory,string cmd)
        {
            if (toHistory != HistoryMode.AddToHistory)  return;            
            if(!clbHISTORY.Items.Contains(cmd)) 
            {
                if(_lastSort == eSort.DESC)
                {
                    clbHISTORY.Items.Insert(0,cmd);    
                }
                else
                {
                    clbHISTORY.Items.Add(cmd);    
                }
            }
            lastSuccessfulCommand = cmd;
            lastCommand = cmd;
        }
        private void AddToFailedHistory(HistoryMode toHistory, string cmd)
        {
            if (toHistory != HistoryMode.AddToHistory) return;            
            if (!clbFAILED_HISTORY.Items.Contains(cmd)) 
            {
                if(_lastSort == eSort.DESC)
                {
                    clbFAILED_HISTORY.Items.Insert(0,cmd);       
                }
                else
                {
                    clbFAILED_HISTORY.Items.Add(cmd);    
                }    
            }
            lastCommand = cmd;
        }

        private void AddToHistory(HistoryMode toHistory, string[] cmds)
        {
            if (toHistory != HistoryMode.AddToHistory) return;            
            foreach (string cmd in cmds)
            {
                AddToHistory(toHistory,cmd);
            }               
        }

        private void AddToFailedHistory(HistoryMode toHistory, string[] cmds)
        {
            if (toHistory != HistoryMode.AddToHistory) return;            
            foreach (string cmd in cmds)
            {
                AddToFailedHistory(toHistory, cmd);
            }               
        }

        private void ExecSqlTh(HistoryMode toHistory, string[] cmds)
        {            
            dataSet1.Clear();
            dgvResults.AutoGenerateColumns = true;
            string term = GetTerm(cmds);
            string connectionstr = ConnectionStrings.Instance().MakeConnectionString(_dbReg);            
            var ri  = _sqLcommand.ExecuteCommandsAddToDataset(dataSet1,cmds,true);
            dataSet1 = ri.dataSet;            
            AddToHistory(toHistory,cmds);            
            bindingSource1.DataMember = "Table";            
        }
        
     
        private void ArrayToText(string[] ob)
        {
            string stc;
            for (int i = 0; i < ob.Length; i++)
            {
                stc = (string)ob[i];
                txtSQL.AppendText(stc + "\r\n");
            }            
        }
        
        private SQLCommandsReturnInfoClass ExecSql(HistoryMode toHistory)
        {           
            dataSet1.Clear();
            dgvResults.AutoGenerateColumns = true;
            if(txtSQL.Text.Length <= 0) return new SQLCommandsReturnInfoClass();
         
            _sqLcommand.SetEncoding(cbEncoding.Text);
            var ri  = _sqLcommand.ExecuteCommandWithGlobalConnection(txtSQL.Lines);
            lblUsedMs.Text = ri.costs.ToString();
            dataSet1 = ri.dataSet;
           
            if(dataSet1?.Tables.Count > 0)
            {           
                bindingSource1.DataSource = dataSet1;
                bindingSource1.DataMember = "Table";
            }
            else if (ri.lastCommandType == SQLCommandType.select)
            {
                NotifiesClass.Instance().AddToERROR("SQLViewForm->ExecSql->No datas selected");
                _localNotifies?.AddToERROR("SQLViewForm->ExecSql->No datas selected");
            }

            if (ri.commandDone)
            {
                AddToHistory(toHistory, ri.lastSQL);
            }
            else
            {
                AddToFailedHistory(toHistory, ri.lastSQL);
            }
            return ri;        
        }
        private void LoadSQL()
        {
            if (SQLViewLastRunClass.Instance().ScriptPath != null)
            {
                if (SQLViewLastRunClass.Instance().ScriptPath.Length > 0)
                {
                    ofdSQL.InitialDirectory = SQLViewLastRunClass.Instance().ScriptPath;
                }
            }
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;
            
            txtSQL.Clear();
            var fi = new FileInfo(ofdSQL.FileName);
            using (System.IO.StreamReader file = new StreamReader(fi.FullName, Encoding.UTF8))
            {
                SQLViewLastRunClass.Instance().ScriptPath = fi.Directory.FullName;                   
                var sql = new StringBuilder();
                string line = string.Empty;
                while ((line = file.ReadLine()) != null)
                {                                              
                    txtSQL.AppendText(line+Environment.NewLine);                        
                }                    
                file.Close();
            }               
        }
        
        private void LoadReplacelist()
        {            
            string line;
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;
            
            using (System.IO.StreamReader file = new StreamReader(ofdSQL.FileName, Encoding.Default))
            {                                       
                rtbReplace.Clear();
                var sql = new StringBuilder();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = (int)(file.BaseStream.Length / 1000L)+1;
                while ((line = file.ReadLine()) != null)
                {                       
                    sql.AppendLine(line);                        
                    Application.DoEvents();
                    progressBar1.Value = (int)(file.BaseStream.Position / 1000L);
                }                    
                file.Close();
                rtbReplace.Text = sql.ToString();
            }                               
        }
        
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (sfdSQL.ShowDialog() != DialogResult.OK) return;            
            txtSQL.SaveToFile(sfdSQL.FileName,Encoding.UTF8);                               
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataSet1.AcceptChanges();
        }

        private void clbHISTORY_DoubleClick(object sender, EventArgs e)
        {
           txtSQL.Clear();
           UserStartReady();            
           txtSQL.AppendText(clbHISTORY.Items[clbHISTORY.SelectedIndex].ToString().Trim()+ Environment.NewLine);           
           tcSQLCONTROL.SelectedTab = tabSQLTEXT;           
        }

        private void clbFAILED_HISTORY_DoubleClick(object sender, EventArgs e)
        {
            txtSQL.Clear();
            UserStartReady();            
            txtSQL.AppendText(clbFAILED_HISTORY.Items[clbFAILED_HISTORY.SelectedIndex].ToString().Trim() + Environment.NewLine);            
            tcSQLCONTROL.SelectedTab = tabSQLTEXT;
        }
        string lastSuccessfulCommand = string.Empty;
        string lastCommand = string.Empty;
        private void SQLViewForm_Load(object sender, EventArgs e)
        {
            txtSQL.Clear();            
            UserStart();
            Testlauf();
            EditMode(cbEditMode.Checked);
            Text = DevelopmentClass.Instance().GetDBInfo(_dbReg,"SQLView for ");
           
            hsBreak.Enabled = false;

            int n = LoadHistory(_lastSort);
                        
            txtRowHeight.Text = dgvResults.RowTemplate.Height.ToString();
            txtSQL.Focus();
            SetEncoding();   
            
        }
        AutocompleteClass ac;
        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(txtSQL, _dbReg);
            ac.RefreshAutocompleteForDatabase(tables,null,null);
        }

        private int LoadHistory(eSort sort)
        {
            clbHISTORY.Items.Clear();
            var fi = new FileInfo($@"{Application.StartupPath}\SQLHistory.txt");
            if (fi.Exists)
            {
                var rt = new RichTextBox();
                rt.LoadFile(fi.FullName,RichTextBoxStreamType.PlainText);
                foreach (string str in rt.Lines)
                {
                    if(str.Length <= 0) continue;
                    if(sort == eSort.DESC) clbHISTORY.Items.Insert(0,str); 
                    else clbHISTORY.Items.Add(str);                                        
                } 
                
                if(clbHISTORY.Items.Count > 0)
                {
                    lastSuccessfulCommand = (sort == eSort.DESC) 
                        ? clbHISTORY.Items[0].ToString() 
                        : clbHISTORY.Items[clbHISTORY.Items.Count-1].ToString();
                    lastCommand = lastSuccessfulCommand;
                }
                return clbHISTORY.Items.Count;
            }
            return 0;
        }

        private void ExecuteHistorySelected()
        {
            txtSQL.Clear();            
            txtSQL.AppendText($@"{clbHISTORY.Items[clbHISTORY.SelectedIndex]}{Environment.NewLine}");            
            tcSQLCONTROL.SelectedTab = tabSQLTEXT;
            ExecSql(HistoryMode.NoHistory);
            tcSQLCONTROL.SelectedTab = tabRESULT;        
        }

        private void SQLViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var rt = new RichTextBox();            
            if(_lastSort == eSort.DESC)
            {
                for(int i = clbHISTORY.Items.Count-1; i >= 0; i--)           
                {
                    string str = clbHISTORY.Items[i].ToString();
                    rt.AppendText($@"{str}{Environment.NewLine}");
                }  
            }
            else
            {
                for(int i = 0; i < clbHISTORY.Items.Count; i++)           
                {
                    string str = clbHISTORY.Items[i].ToString();
                    rt.AppendText($@"{str}{Environment.NewLine}");
                }
            }

            rt.SaveFile(Application.StartupPath+"\\SQLHistory.txt",RichTextBoxStreamType.PlainText);            
            rt = new RichTextBox();

            for (int i = 0; i < clbFAILED_HISTORY.Items.Count; i++)
            {
                string str = clbFAILED_HISTORY.Items[i].ToString();
                rt.AppendText($@"{str}{Environment.NewLine}");
            }
            rt.SaveFile(Application.StartupPath + "\\SQLHistoryFailed.txt", RichTextBoxStreamType.PlainText);

            _localNotifies.ClearAllEvents("SQLViewForm");            
            this.WindowState = FormWindowState.Normal;
        }
        
        private void txtSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if ((txtSQL.Text.Length <= 0)||(!e.Shift)||(e.KeyCode != Keys.Return)) return;            
            ExecSql(HistoryMode.AddToHistory);
            tcSQLCONTROL.SelectedTab = tabRESULT;                                
        }

        private string leseNextLine(System.IO.StreamReader file)
        {                        
            if (!file.EndOfStream) return file.ReadLine();            
            return (null);
        }
        
        private object[] leseAll(System.IO.StreamReader file)
        {
            int counter = 0;
            string line;
            var al = new ArrayList();
            while ((line = file.ReadLine()) != null) 
            {
                al.Add(line);
                counter++;
            }
            return (al.ToArray());
        }
        private void FillScript()
        {
            string strcmd;
            var al = new ArrayList();
            string[] strarr = (string[] )txtSQL.Lines;
            txtSQL.Clear();
            string term = ";";
            string termold = "^";
            int tpos;
            
            foreach (string str in strarr)
            {
                tpos = str.IndexOf("SET TERM");
                if(tpos > -1)
                {
                    termold = term;
                    term = str.Substring(tpos+9,1);                   
                }

                strcmd = str.Trim();
                if (strcmd.EndsWith(";"))
                {
                    strcmd = strcmd.Substring(0, strcmd.Length - 1) + "~";
                }
                txtSQL.AppendText(strcmd);
            }

            string cmdstr = txtSQL.Text.Replace("\n", "");
            
            txtSQL.Clear();
            foreach (string st in cmdstr.Split('~'))
            {
                txtSQL.AppendText(st+Environment.NewLine);
            }
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
            Cursor.Current = Cursors.Default;
        }

        private SQLCommandsReturnInfoClass RunSQL(HistoryMode hMode)
        {
            DeactivateGrid();
            UserStart();
            _obcmd.Clear();
            _obcmd.AddRange(txtSQL.Lines);
            var ri = ExecSql(hMode);
            if(dgvResults.RowCount > 1)
            {
              tcSQLCONTROL.SelectedTab = tabRESULT;
            }
            UserBreak();
            ActivateGrid();
            return ri;
        }

        public bool DoInfoNotifications = true;

        /*
        SQL> SELECT T.MON$ATTACHMENT_ID, T.MON$TRANSACTION_ID,
CON> IO.MON$PAGE_READS, IO.MON$PAGE_WRITES,
CON> IO.MON$PAGE_FETCHES, IO.MON$PAGE_MARKS
CON> FROM MON$TRANSACTIONS AS T
CON> JOIN MON$IO_STATS as IO
CON> ON (IO.MON$STAT_ID = T.MON$STAT_ID)
CON> WHERE T.MON$ATTACHMENT_ID = CURRENT_CONNECTION;
        */

        public void MemoryusagePerStatement()
        {
            lvPerformance.Items.Clear();
            if(_dbReg.Version < eDBVersion.FB3_32)
            {
                lvPerformance.Items.Add($@"{Environment.NewLine}No performance for database {_dbReg.Alias} V{_dbReg.Version} available !!!");
                return;
            }
            var scmd = new StringBuilder();
            scmd.Append("SELECT STMT.MON$ATTACHMENT_ID,  STMT.MON$SQL_TEXT,  MEM.MON$MEMORY_USED, R.MON$RECORD_SEQ_READS,R.MON$RECORD_IDX_READS,R.MON$RECORD_INSERTS,R.MON$RECORD_UPDATES,R.MON$RECORD_DELETES,R.MON$RECORD_CONFLICTS");
            scmd.Append(" FROM MON$STATEMENTS s ");
            scmd.Append(" join mon$record_stats r on r.mon$stat_id = s.mon$stat_id");
            scmd.Append(" join MON$MEMORY_USAGE mem on r.mon$stat_id = mem.mon$stat_id");
            scmd.Append(" JOIN MON$STATEMENTS stmt on stmt.mon$stat_id = r.mon$stat_id ORDER BY mem.MON$MEMORY_USED DESC");

            string cmd = scmd.ToString();
            var ri = _sqLcommand.ExecuteCommandWithGlobalConnection(cmd,false);           
            if (ri.dataSet.Tables.Count <= 0) return;
            foreach (DataRow dr in ri.dataSet.Tables[0].Rows)
            {                    
                object ob1 = dr[1]; //SQL Text
                if ((ob1.ToString().IndexOf(".MON$") >= 0)) continue; //&&(ob1.ToString().IndexOf(".RDB$") < 0))
                
                object ob2 = dr[2]; //Memory used
                object ob3 = dr[3]; //sseq reads
                object ob4 = dr[4]; //idx reads
                object ob5 = dr[5]; //inserts
                object ob6 = dr[6]; //updates
                object ob7 = dr[7]; //deletes
                object ob8 = dr[8]; //deletes
                string[] sarr = new string[8];
                sarr[0] = ob1.ToString();
                sarr[1] = ob2.ToString();
                sarr[2] = ob3.ToString();
                sarr[3] = ob4.ToString();
                sarr[4] = ob5.ToString();
                sarr[5] = ob6.ToString();
                sarr[6] = ob7.ToString();
                sarr[7] = ob8.ToString();

                var lvi = new ListViewItem(sarr);
                lvPerformance.Items.Add(lvi);
                   
            }

            if (ri.connection?.State != ConnectionState.Open) return;            
            ri.connection.Close();               
        }

        public void RefreshPLAN()
        {          
            fctPlan.Clear();
            if(_dbReg.Version < eDBVersion.FB3_32)
            {
                fctPlan.AppendText($@"{Environment.NewLine}No plan for database {_dbReg.Alias} V{_dbReg.Version} available !!!");
                return;
            }

            var _globalCon = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
            string sql = txtSQL.Text.Trim();
            if(sql.EndsWith(";")) sql = sql.Substring(0, sql.Length - 1);
            
            string cmd = "SELECT MON$STATEMENTS.MON$STATEMENT_ID,MON$STATEMENTS.MON$SQL_TEXT,MON$STATEMENTS.MON$EXPLAINED_PLAN FROM MON$STATEMENTS WHERE MON$STATEMENTS.MON$SQL_TEXT = @sql";
          
            DoInfoNotifications = false;
            _globalCon.Open();

            var fbcmd = new FbCommand(cmd,_globalCon);
            fbcmd.Parameters.Add("@sql",sql);
            var dr = fbcmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {                    
                    object ob1 = dr.GetValue(1);
                    object ob2 = dr.GetValue(2);
                    fctPlan.AppendText(ob1.ToString() + Environment.NewLine);
                    fctPlan.AppendText(ob2.ToString() + Environment.NewLine);
                    fctPlan.AppendText(Environment.NewLine);
                    fctPlan.AppendText($@"------------------------------------------------------------------{Environment.NewLine}");
                }
            }
            _globalCon.Close();                      
        }
        
        private void Testlauf()
        {
            _testlauf = cbTestlauf.Checked;
        }
        
        private void RunSQLFromFile()
        {
            progressBar1.Value = progressBar1.Minimum;
            UserActionClass.Instance().UserAction = UserActionType.none;           
            if (!string.IsNullOrEmpty(SQLViewLastRunClass.Instance().ScriptPath))
            {
                ofdSQL.InitialDirectory = SQLViewLastRunClass.Instance().ScriptPath;
            }
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;
            
            hsRunSQLfromFile.Enabled = false;

            dataSet1.Clear();
            dgvResults.AutoGenerateColumns = true;
            var fi = new FileInfo(ofdSQL.FileName);
            progressBar1.Value = 0;
            progressBar1.Maximum = (int)fi.Length;
            hsBreak.Enabled = true;
            string connectionstr = ConnectionStrings.Instance().MakeConnectionString(_dbReg);
            string[] strarr = File.ReadAllLines(fi.FullName);
            var sb = new StringBuilder();

            var ri = _sqLcommand.ExecuteCommandsAddToDataset(dataSet1,strarr,true);
            dataSet1 = ri.dataSet;
            
            hsRunSQLfromFile.Enabled = true;
            SQLViewLastRunClass.Instance().ScriptPath = fi.Directory.FullName;
            UserBreak();                     
        }

        private void UserBreak()
        {
            UserActionClass.Instance().UserAction = UserActionType.abort;
        }
        private void UserStart()
        {           
            UserActionClass.Instance().UserAction = UserActionType.none;
        }
        private void UserStartReady()
        {
            UserActionClass.Instance().UserAction = UserActionType.none;           
            hsBreak.Enabled = false;
            hsRunSQL.Enabled = true;
            hsRunSQLfromFile.Enabled = true;
        }          
        
        private void SetEncoding()
        {            
            int inx = cbEncoding.FindString(_dbReg.CharSet);
            cbEncoding.SelectedIndex = inx;                        
        }

        private void cbTestlauf_CheckedChanged(object sender, EventArgs e)
        {
            Testlauf();
        }
       
        private void cbErrors_CheckedChanged(object sender, EventArgs e)
        {
            Errors();
        }

        private void cbMeldungen_CheckedChanged(object sender, EventArgs e)
        {
            Meldungen();
        }

        private void cbHistory_CheckedChanged(object sender, EventArgs e)
        {
            History();
        }

        private void ReplaceText()
        {
            foreach (string line in rtbReplace.Lines)
            {
                ReplaceText(line);
            }
        }
        private void ReplaceText(string line)
        {            
            if (line.IndexOf(';') <= 0) return;
            string[] rpl = line.Split(';');
            txtSQL.Text = txtSQL.Text.Replace(rpl[0], rpl[1]);
        }        

        private void btnLoadMeld_Click(object sender, EventArgs e)
        {
            if (fbdLog.ShowDialog() != DialogResult.OK) return;
            txtMeldLogFilePath.Inhalt = fbdLog.SelectedPath;
        }

        private void hsRefreshConfig_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            var pf = SQLViewLastRunClass.Instance();
            secDATABASEPATH.Inhalt = pf.ServerDatabasePfad;
            secSERVERNAME.Inhalt = pf.ServerName;
        }
        
        private void hsClose_Click(object sender, EventArgs e)
        {
            UserActionClass.Instance().UserAction = UserActionType.none; Close();
        }
        private void hsRunSQL_Click(object sender, EventArgs e)
        {            
            ExecuteSQL(_history);            
        }
        Stopwatch stopwatch = new Stopwatch();
        private void ExecuteSQL(HistoryMode hMode)
        {
            dgvResults.Visible = false; 
            stopwatch.Restart();
            DoInfoNotifications = true;
            if(cbClearListBeforeExcecute.Checked)
            {
                _cmdDone = 0;
                rtfMELDUNG.Clear();
                rtfERRORS.Clear();
            }
            var ri = RunSQL(hMode);
            _cmd = ri.lastSQL;
            if (ri.lastCommandType == SQLCommandType.select)
            {
                if (_dbReg.Version >= eDBVersion.FB3_32)
                {
                    RefreshPLAN();
                }
            }
            if (ri.commandDone)
            {
                MemoryusagePerStatement();
            }
            stopwatch.Stop();
            txtUsedTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            EditMode(cbEditMode.Checked);   
            tabRESULT.Text = $@"Results ({dgvResults.Rows.Count})";
            tabHistory.Text = $@"History ({clbHISTORY.Items.Count})";
            dgvResults.Visible = true; 
        }

        private void hsClearText_Click(object sender, EventArgs e)
        {
            txtSQL.Clear();
        }

        private void hsRunSQLfromFile_Click(object sender, EventArgs e)
        {
            RunSQLFromFile();
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            LoadSQL();
            hsLoadSQL.Enabled = true;
        }

        private void hsReplaceText_Click(object sender, EventArgs e)
        {
            ReplaceText();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            UserBreak();
        }

        private void hsClearInfo_Click(object sender, EventArgs e)
        {
            rtfMELDUNG.Clear();
            tabMELDUNG.Text = "Messages";
        }

        private void hsExecuteHistorySelected_Click(object sender, EventArgs e)
        {
            ExecuteHistorySelected();
        }

        private void hsClearHistoryAll_Click(object sender, EventArgs e)
        {
            clbHISTORY.Items.Clear();
        }

        private void hsClearErrorAll_Click(object sender, EventArgs e)
        {
            rtfERRORS.Clear();
            tabERRORS.Text = @"Errors";
        }

        private void hsLoadListReplaces_Click(object sender, EventArgs e)
        {
            LoadReplacelist();
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if (sfdSQL.ShowDialog() != DialogResult.OK) return;
            txtSQL.SaveToFile(sfdSQL.FileName, Encoding.UTF8);
        }
        
        private void hsSaveDataset_Click(object sender, EventArgs e)
        {            
            try
            {
                DataSet dsUpdate = dataSet1.GetChanges(DataRowState.Modified);
                DataSet dsInsert = dataSet1.GetChanges(DataRowState.Added);
                DataSet dsDeleted = dataSet1.GetChanges(DataRowState.Deleted);
                string constr = ConnectionStrings.Instance().MakeConnectionString(_dbReg);
                var cn = new FbConnection(constr);
                string cm1 = _cmd;
                var da = new FbDataAdapter(cm1, cn);
                var cb = new FbCommandBuilder(da);  
               
                da.AcceptChangesDuringUpdate = true;
                if (dsUpdate != null)
                {   
                    var fc = cb.GetUpdateCommand();
                    da.UpdateCommand = fc;
                    if (dsUpdate.Tables[0].Rows.Count > 0)
                    {
                       _localNotifies?.AddToINFO($@"Table {dsUpdate.Tables[0].TableName} updated {dsUpdate.Tables[0].Rows.Count} records affected");
                        da.Update(dsUpdate);
                    }
                }
                if (dsInsert != null)
                {
                    var fi = cb.GetInsertCommand();
                    da.InsertCommand = fi;                    
                    _localNotifies?.AddToINFO($@"Table {dsInsert.Tables[0].TableName} added {dsInsert.Tables[0].Rows.Count} records affected");
                    da.Update(dsInsert);                        
                }
                if (dsDeleted != null)
                {
                    var fd = cb.GetDeleteCommand();                
                    da.DeleteCommand = fd;
                    if (dsDeleted.Tables[0].Rows.Count > 0)
                    {
                       _localNotifies?.AddToINFO($@"Table {dsDeleted.Tables[0].TableName} deleted {dsDeleted.Tables[0].Rows.Count} records affected");
                        da.Update(dsDeleted);
                    }
                }                
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Views und Tabels ohne Primary Key können nicht editiert werden.");
                sb.AppendLine(ex.Message);
                MessageBox.Show(sb.ToString(),"Dataset Update failed");
                //NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> Savedataset_Click()", ex));   
                _localNotifies?.AddToERROR(sb.ToString());
            }
            bindingSource1.DataMember = null;                                
            var ri = RunSQL(_history);
            _cmd = ri.lastSQL;
            if (ri.lastCommandType != SQLCommandType.@select) return;
            //ClearDataGrid();
            RefreshPLAN();

        }

        private void cmsSQLText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDDLCopyToClipboard)
            {
                if(!string.IsNullOrEmpty(txtSQL.SelectedText))
                Clipboard.SetText(txtSQL.SelectedText);
            }
            else if (e.ClickedItem == tsmiDDLPaste)
            {
              string txt =  Clipboard.GetText();
              if(!string.IsNullOrEmpty(txt))
              txtSQL.Text = txtSQL.Text.Insert(txtSQL.SelectionStart,txt);
            }
            else if(e.ClickedItem == tsmiLastCommand)
            {
               txtSQL.Clear();
               UserStartReady();            
               txtSQL.AppendText($@"{lastCommand}{Environment.NewLine}");           
               tcSQLCONTROL.SelectedTab = tabSQLTEXT;  
            }
            else if(e.ClickedItem == tsmiInsertLastSuccessfullCommand)
            {
               txtSQL.Clear();
               UserStartReady();            
               txtSQL.AppendText($@"{lastSuccessfulCommand}{Environment.NewLine}");           
               tcSQLCONTROL.SelectedTab = tabSQLTEXT;  
            }
            else if(e.ClickedItem ==  tsmiExecuteLastSucessfullCommand)
            {
               txtSQL.Clear();
               UserStartReady();            
               txtSQL.AppendText($@"{lastSuccessfulCommand}{Environment.NewLine}");           
               tcSQLCONTROL.SelectedTab = tabSQLTEXT;  
               ExecuteSQL(HistoryMode.NoHistory);  
            }
        }

        private void hsRefreshXMLScheme_Click(object sender, EventArgs e)
        {
            fctXMLScheme.Text = dataSet1.GetXmlSchema();
        }

        private void hsRefreshXMLData_Click(object sender, EventArgs e)
        {
            fctXMLData.Text = dataSet1.GetXml();
        }

        private void hsSaveXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialogXML.ShowDialog() != DialogResult.OK) return;
            fctXMLData.SaveToFile(saveFileDialogXML.FileName, Encoding.UTF8);
        }

        private void hsSaveXMLScheme_Click(object sender, EventArgs e)
        {
            if (saveFileDialogXML.ShowDialog() != DialogResult.OK) return;
            fctXMLScheme.SaveToFile(saveFileDialogXML.FileName, Encoding.UTF8);
        }

        private void hsRefreshPerformance_Click(object sender, EventArgs e)
        {
            MemoryusagePerStatement();
        }

        private void hsCrearAllFailed_Click(object sender, EventArgs e)
        {
            clbFAILED_HISTORY.Items.Clear();
        }

        private void hsClearHistorySelected_Click(object sender, EventArgs e)
        {
            for (int i = clbHISTORY.Items.Count; i > 0; i--)
            {
                if (clbHISTORY.GetItemChecked(i - 1)) clbHISTORY.Items.RemoveAt(i - 1);
            }

            for (int i = clbFAILED_HISTORY.Items.Count; i > 0; i--)
            {
                if (clbFAILED_HISTORY.GetItemChecked(i - 1)) clbFAILED_HISTORY.Items.RemoveAt(i - 1);
            }
        }

        private void txtSQL_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData != (Keys.K | Keys.Control)) return;
            if(ac != null) ac.Show();
            e.Handled = true;
        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            EditMode(cbEditMode.Checked);
        }

        private void EditMode(bool enabled)
        {
            dgvResults.AutoSizeColumnsMode = (enabled) ? DataGridViewAutoSizeColumnsMode.None : DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResults.ReadOnly = !enabled;
            dgvResults.RowHeadersVisible     = enabled;
            dgvResults.AllowUserToAddRows    = enabled;
            dgvResults.AllowUserToDeleteRows = enabled;
            dgvResults.SelectionMode = (enabled) ? DataGridViewSelectionMode.CellSelect : DataGridViewSelectionMode.FullRowSelect;
            hsUpdateDataset.Enabled    = enabled;
            bnTableContentDeleteItem.Enabled = enabled;              
        }

        private void dgvResults_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string msg = e.Exception.Message;
        }

        private void cbRowManually_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRowManually.Checked)
            {                
                dgvResults.Invalidate();
            }
        }

        private void dgvResults_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {           
            int rh = StaticFunctionsClass.ToIntDef(txtRowHeight.Text, dgvResults.RowTemplate.Height);
            foreach(DataGridViewRow x in dgvResults.Rows)
            {
              x.MinimumHeight = rh;
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

        private void Sort()
        {
            object[] obj = new object[clbHISTORY.Items.Count];
            clbHISTORY.BeginUpdate();
            clbHISTORY.Items.CopyTo(obj,0);
            clbHISTORY.Items.Clear();
            foreach(object ob in obj)
            {
                clbHISTORY.Items.Insert(0,ob);
            }
            clbHISTORY.EndUpdate();
        }

        private void cmsHistory_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiSortASC)
            {
                if(_lastSort != eSort.ASC)
                {
                    Sort();
                    _lastSort = eSort.ASC;
                    tabPageSucceeded.Text = "commands succeded ASC";
                }                
            }
            else if(e.ClickedItem == tsmiSortDESC)
            {
                if(_lastSort != eSort.DESC)
                {
                    Sort();
                    _lastSort = eSort.DESC;
                    tabPageSucceeded.Text = "commands succeded DESC";
                }
            }
        }

        private void hsPageRefresh_Click(object sender, EventArgs e)
        {            
            ExecuteSQL(_history);            
        }
    }
}