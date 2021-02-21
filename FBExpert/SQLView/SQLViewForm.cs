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
using MessageFormLibrary;
using System;
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
        private readonly DBRegistrationClass _dbRegOrg = null;
        private readonly DBRegistrationClass _dbrRegLocal = null;
        private string _cmd = string.Empty;
        private int _cmdDone = 0;
        private int _cmdError = 0;
               
        private bool _testlauf = true;
        private readonly List<string> _obcmd = new List<string>();
        List<TableClass> _tables = null;
        eSort _lastSort = eSort.DESC;
        string lastSuccessfulCommand = string.Empty;
        string lastCommand = string.Empty;
        AutocompleteClass ac;
        public NotifiesClass SQLnotify = new NotifiesClass();

        public SQLViewForm1(DBRegistrationClass ca, List<TableClass> tables, Form mdiParent = null, eColorDesigns appDesign = eColorDesigns.Gray, eColorDesigns developDesign = eColorDesigns.Gray, bool testMode = false)
        {
            MdiParent = mdiParent;
            _dbRegOrg = ca;
            _dbrRegLocal = _dbRegOrg.Clone();
            _tables = tables;
            _appDesign = appDesign;
            _developDesign = developDesign;
            InitializeComponent();
            if (cbErrors.Checked) SQLnotify.Register4Error(ErrorRaised);
            if (cbMeldungen.Checked) SQLnotify.Register4Info(InfoRaised);
                        
            _sqLcommand = new SQLCommandsClass(_dbrRegLocal);
            _sqLcommand.Notify.Register4Info(InfoRaised);
            _sqLcommand.Notify.Register4Error(ErrorRaised);

            History();
            ClearDevelopDesign(_developDesign);
            SetDesign(_appDesign);
            cbTestlauf.Checked = testMode;
            cbTestlauf.Visible = testMode;
            LanguageChanged();
            LanguageClass.Instance().RegisterChangeNotifiy(OnRaiseLanguageChangedHandler);
        }

        private void OnRaiseLanguageChangedHandler(object sender, LanguageChangedEventArgs k)
        {
            LanguageChanged();
        }

        private void LanguageChanged()
        {
            tabHistory.Text                 = $@"{LanguageClass.Instance().GetString("History")} ({dgvSQLHistory.Rows.Count})";
            hsClearHistory.Text             = LanguageClass.Instance().GetString("DeleteHistory");
            hsExecuteHistorySelected.Text   = LanguageClass.Instance().GetString("EXECUTE_SQL");
            hsRunSQL.Text                   = LanguageClass.Instance().GetString("EXECUTE_SQL");
            hsRefreshHistory.Text           = LanguageClass.Instance().GetString("REFRESH");
            hsPageRefresh.Text              = LanguageClass.Instance().GetString("REFRESH");
        }


        void History()
        {
            _history = (cbHistory.Checked) ? HistoryMode.AddToHistory : HistoryMode.NoHistory;
        }

        void GaugeRaised(object sender, MessageEventIntArgs k)
        {
            pbRunSQL.Value += k.N;
        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            if (DoInfoNotifications)
            {
                _cmdDone++;
                tabMELDUNG.Text = $@"Messages ({_cmdDone})";
                
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
        }

        void ErrorRaised(object sender, MessageEventArgs k)
        {
            _cmdError++;
            tabERRORS.Text = $@"Errors ({_cmdError})";

            if (rbErrAppend.Checked)
            {
                rtfERRORS.AppendText(k.Meldung);
                string posTxt = AppStaticFunctionsClass.getErrorPosText(k.Meldung);
                if (!string.IsNullOrEmpty(posTxt))
                {
                    rtfERRORS.AppendText(posTxt);
                }

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
            ExecSqlTh(HistoryMode.NoHistory, (string[])txtSQL.Lines);
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
                return (";");
            }
            return (term);
        }

        private string HistoryFile
        {
            get
            {
                return $@"{Application.StartupPath}\SQL\{_dbRegOrg.Alias}_SQLHistoryData.db";
            }
        }

        private bool AddToHistory(HistoryMode toHistory, string cmd)
        {
            if (toHistory != HistoryMode.AddToHistory) return false;
            bool ok = false;
            try
            {                
                var sh = new SQLHistoryClass(_dbRegOrg.Alias, HistoryFile);
                ok = sh.InsertHistory(cmd, eSQLHistoryType.succeeded);
                sh.HistoryRefresh(dgvSQLHistory,bsHistory, cbSQLsucceded.Checked, cbSQLfailed.Checked, cbAllHistory.Checked);
                sh.SortGrid(dgvSQLHistory, 1);
                lastCommand = cmd;
            }
            catch(Exception ex)
            {
                SQLnotify.AddToERROR(ex.Message);
            }
            return ok;
        }
        private bool AddToFailedHistory(HistoryMode toHistory, string cmd)
        {
            if (toHistory != HistoryMode.AddToHistory) return false;
            bool ok = false;
            try
            {
                var sh = new SQLHistoryClass(_dbRegOrg.Alias, HistoryFile);
                ok = sh.InsertHistory(cmd, eSQLHistoryType.failed);
                sh.HistoryRefresh(dgvSQLHistory,  bsHistory, cbSQLsucceded.Checked, cbSQLfailed.Checked, cbAllHistory.Checked);
                sh.SortGrid(dgvSQLHistory, 1);
            }            
            catch(Exception ex)
            {
                SQLnotify.AddToERROR(ex.Message);
            }
            return ok;
        }

        private void AddToHistory(HistoryMode toHistory, string[] cmds)
        {
            if (toHistory != HistoryMode.AddToHistory) return;
            foreach (string cmd in cmds)
            {
                AddToHistory(toHistory, cmd);
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
            dsResults.Clear();
            dgvResults.AutoGenerateColumns = true;
         
            var ri = _sqLcommand.ExecuteCommandsAddToDataset(dsResults, cmds, true);
            if (ri.commandDone)
            {
                AddToHistory(toHistory, cmds);
            }
            else
            {
                AddToFailedHistory(toHistory, cmds);
            }
            dsResults = ri.dataSet;
            bsResults.DataMember = "Table";
        }


        private SQLCommandsReturnInfoClass ExecSql(HistoryMode toHistory)
        {
            dsResults.Clear();
            dgvResults.AutoGenerateColumns = true;
            if (txtSQL.Text.Length <= 0) return new SQLCommandsReturnInfoClass();

            _sqLcommand.SetEncoding(cbEncoding.Text);

            var ri = _sqLcommand.ExecuteCommandWithGlobalConnection(txtSQL.Lines);
            if (ri.commandDone)
            {
                AddToHistory(toHistory, ri.lastSQL);
            }
            else
            {
                AddToFailedHistory(toHistory, ri.lastSQL);
            }

            lblUsedMs.Text = ri.costs.ToString();
            dsResults = ri.dataSet;

            if (dsResults?.Tables.Count > 0)
            {
                ckShowResults.Text = $@"Show results ({dsResults.Tables[0].Rows.Count})";
                if (ckShowResults.Checked)
                {
                    NotifiesClass.Instance().AddToINFO($@"SQLViewForm->ExecSql-> {dsResults.Tables[0].Rows.Count} datas selected");
                    SQLnotify.AddToINFO($@"SQLViewForm->ExecSql-> {dsResults.Tables[0].Rows.Count} datas selected");
                    bsResults.DataSource = dsResults;
                    bsResults.DataMember = "Table";
                }
                else
                {
                    NotifiesClass.Instance().AddToINFO($@"SQLViewForm->ExecSql-> {dsResults.Tables[0].Rows.Count} datas selected, but not visible in results");
                    SQLnotify.AddToINFO($@"SQLViewForm->ExecSql-> {dsResults.Tables[0].Rows.Count} datas selected, but not visible in results");
                }
            }
            else if (ri.lastCommandType == SQLCommandType.select)
            {
                NotifiesClass.Instance().AddToERROR("SQLViewForm->ExecSql->No datas selected");
                SQLnotify.AddToERROR("SQLViewForm->ExecSql->No datas selected");
            }

            return ri;
        }
        bool doExport = false;
        private int ExecSqlForExport(HistoryMode toHistory)
        {
            if (txtSQL.Text.Length <= 0) return 0;
            if (ckClearExportListBeforeExecute.Checked) fctXMLData.Clear();
            
            System.IO.StreamWriter file = null;
            doExport = true;
            if (ckExportToFile.Checked)
            {
                saveFileDialogCSV.DefaultExt = ".csv";
                saveFileDialogCSV.Filter = "CSV|*.csv|All|*.*";
                saveFileDialogCSV.InitialDirectory = _dbrRegLocal.InitialExportPath;
                if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
                {
                    file = new System.IO.StreamWriter(saveFileDialogCSV.FileName, false, Encoding.UTF8);
                }
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            this.Cursor = Cursors.WaitCursor;
            var Con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbrRegLocal));
            Con.Open();

            var cmd1 = new FbCommand(txtSQL.Text, Con);

            string quote = "\"";
            var data = cmd1.ExecuteReader();
            int n = 0;
            pbExport.Minimum = 0;
            pbExport.Value = 0;
            pbExport.Maximum = 10000;
            bool first = true;

            while (data.Read())
            {
                if (!doExport)
                {
                    if (file != null) file.Close();
                    Con.Close();
                    this.Cursor = Cursors.Default;
                    sw.Stop();
                    lblExportCosts.Text = sw.ElapsedMilliseconds.ToString();
                    return n;
                }

                if (first)
                {
                    first = false;
                    var sbh = new StringBuilder();
                    for (int i = 0; i < data.FieldCount; i++)
                    {
                        string line = (ckMaskData.Checked) ? $@"{quote}{data.GetName(i)}{quote}{cbCSVSeperator.Text}" : $@"{data.GetName(i)}{cbCSVSeperator.Text}";
                        sbh.Append(line);
                    }
                    if (ckExportToScreen.Checked)
                    {
                        fctXMLData.AppendText($@"{sbh.ToString()}{Environment.NewLine}");
                    }
                    if (ckExportToFile.Checked)
                    {
                        file.WriteLine(sbh.ToString());
                    }
                }

                var sb = new StringBuilder();
                for (int i = 0; i < data.FieldCount; i++)
                {
                    string line = (ckMaskData.Checked)
                        ? string.IsNullOrEmpty(data.GetString(i))
                            ? $@"{data.GetString(i)}{cbCSVSeperator.Text}"
                            : $@"{quote}{data.GetString(i)}{quote}{cbCSVSeperator.Text}"
                        : $@"{data.GetString(i)}{cbCSVSeperator.Text}";

                    sb.Append(line);
                }
                if (ckExportToScreen.Checked)
                {
                    fctXMLData.AppendText($@"{sb.ToString()}{Environment.NewLine}");
                }
                if (ckExportToFile.Checked)
                {
                    file.WriteLine(sb.ToString());
                }
                n++;
                if (cbShowExportProgress.Checked)
                {
                    if (n % 100 == 0) pbExport.Value = n % 10000;
                    gbExportProgress.Text = $@"Processed:{n}";
                    Application.DoEvents();
                }
            }

            if (file != null) file.Close();
            Con.Close();
            this.Cursor = Cursors.Default;
            sw.Stop();
            lblExportCosts.Text = sw.ElapsedMilliseconds.ToString();
            return n;
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
                    txtSQL.AppendText(line + Environment.NewLine);
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
                pbRunSQL.Minimum = 0;
                pbRunSQL.Maximum = (int)(file.BaseStream.Length / 1000L) + 1;
                while ((line = file.ReadLine()) != null)
                {
                    sql.AppendLine(line);
                    Application.DoEvents();
                    pbRunSQL.Value = (int)(file.BaseStream.Position / 1000L);
                }
                file.Close();
                rtbReplace.Text = sql.ToString();
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (sfdSQL.ShowDialog() != DialogResult.OK) return;
            txtSQL.SaveToFile(sfdSQL.FileName, Encoding.UTF8);
        }

        public bool TestOpen(string databaseString, DBRegistrationClass dbReg)
        {            
            string server = dbReg.MakeServerFromText(txtDatabase.Text);
            string path = dbReg.MakeDatabasepathFromText(txtDatabase.Text);

            _sqLcommand.ReplaceConnection(server, path);
            _dbrRegLocal.Server = server;
            _dbrRegLocal.DatabasePath = path;
            string connectionString = ConnectionStrings.Instance().MakeConnectionString(_dbrRegLocal);
            string lifeTime = AppStaticFunctionsClass.GetLifetime(connectionString, (int)_dbrRegLocal.Version >= (int)eDBVersion.FB3_32);
            hsLifeTime.ToolTipActive = true;
            hsLifeTime.ToolTipText = connectionString;
            hsLifeTime.Marked = !string.IsNullOrEmpty(lifeTime);
            hsLifeTime.Text = lifeTime;
            return (lifeTime != "-1");
        }
        private void SQLViewForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            txtSQL.Clear();
            UserStart();
            Testlauf();
            EditMode(cbEditMode.Checked);
            this.Text = $@"SQLView for {_dbrRegLocal.Alias}";
            txtDatabase.Text = _dbrRegLocal.GetFullDatabasePath();
            TestOpen(txtDatabase.Text, _dbrRegLocal);
            hsBreak.Enabled = false;

            LoadHistory(_lastSort);
            LanguageChanged();
            txtRowHeight.Text = dgvResults.RowTemplate.Height.ToString();
            txtSQL.Focus();
            SetEncoding();
            SetAutocompeteObjects(_tables);
        }

        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(txtSQL, _dbRegOrg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.Activate();
        }
        SQLHistoryClass sh = null;
        private void LoadHistory(eSort sort)
        {
            try
            {
                sh = new SQLHistoryClass(_dbRegOrg.Alias, $@"{Application.StartupPath}\SQL\{_dbRegOrg.Alias}_SQLHistoryData.db");
                sh.HistoryRefresh(dgvSQLHistory, bsHistory, cbSQLsucceded.Checked, cbSQLfailed.Checked, cbAllHistory.Checked);
                sh.SortGrid(dgvSQLHistory, 1, false);
            }
            catch (Exception ex)
            {
                SQLnotify.AddToERROR(ex.Message);
            }
        }

        private void ExecuteHistorySelected()
        {
            if (dgvSQLHistory.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dr in dgvSQLHistory.SelectedRows)
                {
                    string sql = dr.Cells[3].Value.ToString();
                    txtSQL.Clear();
                    txtSQL.AppendText($@"{sql}{Environment.NewLine}");
                    ExecSql(HistoryMode.NoHistory);
                }
                tcSQLCONTROL.SelectedTab = tabRESULT;
            }
        }

        private void SQLViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void txtSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if ((txtSQL.Text.Length <= 0) || (!e.Shift) || (e.KeyCode != Keys.Return)) return;
            ExecSql(HistoryMode.AddToHistory);
            tcSQLCONTROL.SelectedTab = tabRESULT;
        }

        private string leseNextLine(System.IO.StreamReader file)
        {
            if (!file.EndOfStream) return file.ReadLine();
            return (null);
        }

        private void FillScript()
        {
            string strcmd;
            
            string[] strarr = (string[])txtSQL.Lines;
            txtSQL.Clear();

            int tpos;

            foreach (string str in strarr)
            {
                tpos = str.IndexOf("SET TERM");
                
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
                txtSQL.AppendText($@"{st}{Environment.NewLine}");
            }
        }

        private void DeactivateGrid()
        {
            ExtensionMethods.DoubleBuffered(dgvResults, true);
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
            if (dgvResults.RowCount > 1)
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
            if (_dbrRegLocal.Version < eDBVersion.FB3_32)
            {
                lvPerformance.Items.Add($@"{Environment.NewLine}No performance for database {_dbrRegLocal.Alias} V{_dbrRegLocal.Version} available !!!");
                return;
            }
            var scmd = new StringBuilder();
            scmd.Append("SELECT STMT.MON$ATTACHMENT_ID,  STMT.MON$SQL_TEXT,  MEM.MON$MEMORY_USED, R.MON$RECORD_SEQ_READS,R.MON$RECORD_IDX_READS,R.MON$RECORD_INSERTS,R.MON$RECORD_UPDATES,R.MON$RECORD_DELETES,R.MON$RECORD_CONFLICTS");
            scmd.Append(" FROM MON$STATEMENTS s ");
            scmd.Append(" JOIN mon$record_stats r on r.mon$stat_id = s.mon$stat_id");
            scmd.Append(" JOIN MON$MEMORY_USAGE mem on r.mon$stat_id = mem.mon$stat_id");
            scmd.Append(" JOIN MON$STATEMENTS stmt on stmt.mon$stat_id = r.mon$stat_id ORDER BY mem.MON$MEMORY_USED DESC");

            string cmd = scmd.ToString();
            var ri = _sqLcommand.ExecuteCommandWithGlobalConnection(cmd, false);
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
            try
            {
                if (_dbrRegLocal.Version < eDBVersion.FB3_32)
                {
                    fctPlan.AppendText($@"{Environment.NewLine}No plan for database {_dbrRegLocal.Alias} V{_dbrRegLocal.Version} available !!!");
                    return;
                }

                var _globalCon = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbrRegLocal));
                string sql = txtSQL.Text.Trim();
                if (sql.EndsWith(";")) sql = sql.Substring(0, sql.Length - 1);

                string cmd = "SELECT MON$STATEMENTS.MON$STATEMENT_ID,MON$STATEMENTS.MON$SQL_TEXT,MON$STATEMENTS.MON$EXPLAINED_PLAN FROM MON$STATEMENTS WHERE MON$STATEMENTS.MON$SQL_TEXT = @sql";

                DoInfoNotifications = false;
                _globalCon.Open();

                var fbcmd = new FbCommand(cmd, _globalCon);
                fbcmd.Parameters.Add("@sql", sql);
                var dr = fbcmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        object ob1 = dr.GetValue(1);
                        object ob2 = dr.GetValue(2);
                        fctPlan.AppendText($@"{ob1}{Environment.NewLine}");
                        fctPlan.AppendText($@"{ob2}{Environment.NewLine}");
                        fctPlan.AppendText(Environment.NewLine);
                        fctPlan.AppendText($@"------------------------------------------------------------------{Environment.NewLine}");
                    }
                }
                _globalCon.Close();
            }
            catch(Exception ex)
            {
                SQLnotify.AddToERROR(ex.Message);
            }
        }

        private void Testlauf()
        {
            _testlauf = cbTestlauf.Checked;
        }

        private void RunSQLFromFile()
        {
            pbRunSQL.Value = pbRunSQL.Minimum;
            UserActionClass.Instance().UserAction = UserActionType.none;
            if (!string.IsNullOrEmpty(SQLViewLastRunClass.Instance().ScriptPath))
            {
                ofdSQL.InitialDirectory = SQLViewLastRunClass.Instance().ScriptPath;
            }
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;

            hsRunSQLfromFile.Enabled = false;

            dsResults.Clear();
            dgvResults.AutoGenerateColumns = true;
            var fi = new FileInfo(ofdSQL.FileName);
            pbRunSQL.Value = 0;
            pbRunSQL.Maximum = (int)fi.Length;
            hsBreak.Enabled = true;
           // string connectionstr = ConnectionStrings.Instance().MakeConnectionString(_dbRegOrg);
            string[] strarr = File.ReadAllLines(fi.FullName);
            
            var ri = _sqLcommand.ExecuteCommandsAddToDataset(dsResults, strarr, true);
            dsResults = ri.dataSet;

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
            int inx = cbEncoding.FindString(_dbrRegLocal.CharSet);
            cbEncoding.SelectedIndex = inx;
        }

        private void cbTestlauf_CheckedChanged(object sender, EventArgs e)
        {
            Testlauf();
        }

        private void cbErrors_CheckedChanged(object sender, EventArgs e)
        {
            if (cbErrors.Checked)
                SQLnotify.Register4Error(ErrorRaised);
            else SQLnotify.Unegister4Error(ErrorRaised);
        }

        private void cbMeldungen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMeldungen.Checked)
                SQLnotify.Register4Info(InfoRaised);
            else SQLnotify.Unegister4Info(InfoRaised);
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
            rh = StaticFunctionsClass.ToIntDef(txtRowHeight.Text, dgvResults.RowTemplate.Height);
            if (!hsLifeTime.Marked)
            {
                //Datenbank wurde geändert, neu einloggen -> bei fehler return
                if (!TestOpen(txtDatabase.Text, _dbrRegLocal)) return;
            }

            stopwatch.Restart();
            DoInfoNotifications = true;
            if (cbClearListBeforeExcecute.Checked)
            {
                _cmdDone = 0;
                _cmdError = 0;
                rtfMELDUNG.Clear();
                rtfERRORS.Clear();
            }
            var ri = RunSQL(hMode);
            _cmd = ri.lastSQL;
            if (ri.lastCommandType == SQLCommandType.select)
            {
                if (_dbrRegLocal.Version >= eDBVersion.FB3_32)
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
            tabRESULT.Text = (dsResults.Tables.Count > 0) ? $@"Results ({dsResults.Tables[0].Rows.Count})" : $@"Results (0)";

            RefreshHistory();
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
                DataSet dsUpdate = dsResults.GetChanges(DataRowState.Modified);
                DataSet dsInsert = dsResults.GetChanges(DataRowState.Added);
                DataSet dsDeleted = dsResults.GetChanges(DataRowState.Deleted);
                string constr = ConnectionStrings.Instance().MakeConnectionString(_dbrRegLocal);
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
                        SQLnotify.AddToINFO($@"Table {dsUpdate.Tables[0].TableName} updated {dsUpdate.Tables[0].Rows.Count} records affected");
                        da.Update(dsUpdate);
                    }
                }
                if (dsInsert != null)
                {
                    var fi = cb.GetInsertCommand();
                    da.InsertCommand = fi;
                    SQLnotify.AddToINFO($@"Table {dsInsert.Tables[0].TableName} added {dsInsert.Tables[0].Rows.Count} records affected");
                    da.Update(dsInsert);
                }
                if (dsDeleted != null)
                {
                    var fd = cb.GetDeleteCommand();
                    da.DeleteCommand = fd;
                    if (dsDeleted.Tables[0].Rows.Count > 0)
                    {
                        SQLnotify.AddToINFO($@"Table {dsDeleted.Tables[0].TableName} deleted {dsDeleted.Tables[0].Rows.Count} records affected");
                        da.Update(dsDeleted);
                    }
                }
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Views und Tabels ohne Primary Key können nicht editiert werden.");
                sb.AppendLine(ex.Message);
                MessageBox.Show(sb.ToString(), "Dataset Update failed");
                SQLnotify.AddToERROR(sb.ToString());
            }
            bsResults.DataMember = null;
            var ri = RunSQL(_history);
            _cmd = ri.lastSQL;
            if (ri.lastCommandType != SQLCommandType.@select) return;

            RefreshPLAN();
        }

        private void cmsSQLText_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDDLCopyToClipboard)
            {
                if (!string.IsNullOrEmpty(txtSQL.SelectedText))
                    Clipboard.SetText(txtSQL.SelectedText);
            }
            else if (e.ClickedItem == tsmiDDLPaste)
            {
                string txt = Clipboard.GetText();
                if (!string.IsNullOrEmpty(txt))
                    txtSQL.Text = txtSQL.Text.Insert(txtSQL.SelectionStart, txt);
            }
            else if (e.ClickedItem == tsmiLastCommand)
            {
                txtSQL.Clear();
                UserStartReady();
                txtSQL.AppendText($@"{lastCommand}{Environment.NewLine}");
                tcSQLCONTROL.SelectedTab = tabSQLTEXT;
            }
            else if (e.ClickedItem == tsmiInsertLastSuccessfullCommand)
            {
                txtSQL.Clear();
                UserStartReady();
                txtSQL.AppendText($@"{lastSuccessfulCommand}{Environment.NewLine}");
                tcSQLCONTROL.SelectedTab = tabSQLTEXT;
            }
            else if (e.ClickedItem == tsmiExecuteLastSucessfullCommand)
            {
                txtSQL.Clear();
                UserStartReady();
                txtSQL.AppendText($@"{lastSuccessfulCommand}{Environment.NewLine}");
                tcSQLCONTROL.SelectedTab = tabSQLTEXT;
                ExecuteSQL(HistoryMode.NoHistory);
            }
            else if(e.ClickedItem == tsmiInsertPK)
            {
                //int s = txtSQL.Selection.Start;
                txtSQL.InsertText(" PRIMARY KEY NOT NULL");

            }
        }

        private void hsRefreshXMLScheme_Click(object sender, EventArgs e)
        {
            fctXMLScheme.Text = dsResults.GetXmlSchema();
        }

        private void hsRefreshXMLData_Click(object sender, EventArgs e)
        {
            fctXMLData.Text = dsResults.GetXml();
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

        private void txtSQL_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if (ac != null) ac.Show();
                e.Handled = true;
            }
        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            EditMode(cbEditMode.Checked);
        }

        private void EditMode(bool enabled)
        {
            dgvResults.AutoSizeColumnsMode = (enabled) ? DataGridViewAutoSizeColumnsMode.None : DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResults.ReadOnly = !enabled;
            dgvResults.RowHeadersVisible = enabled;
            dgvResults.AllowUserToAddRows = enabled;
            dgvResults.AllowUserToDeleteRows = enabled;
            dgvResults.SelectionMode = (enabled) ? DataGridViewSelectionMode.CellSelect : DataGridViewSelectionMode.FullRowSelect;
            hsUpdateDataset.Enabled = enabled;
            bnTableContentDeleteItem.Enabled = enabled;
        }

        private void dgvResults_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //string msg = e.Exception.Message;
        }

        private void cbRowManually_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRowManually.Checked)
            {
                dgvResults.Invalidate();
            }
        }

        private void dgvResults_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //int rh = StaticFunctionsClass.ToIntDef(txtRowHeight.Text, dgvResults.RowTemplate.Height);
            foreach (DataGridViewRow x in dgvResults.Rows)
            {
                x.MinimumHeight = rh;
            }
        }
        int rh = 22;
        private void txtRowHeight_TextChanged(object sender, EventArgs e)
        {
            if (cbRowManually.Checked)
            {
                cbRowManually.Checked = false;
            }
            rh = StaticFunctionsClass.ToIntDef(txtRowHeight.Text, dgvResults.RowTemplate.Height);
        }
        private void txtRowHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbRowManually.Checked = true;
            }
        }

        private void hsPageRefresh_Click(object sender, EventArgs e)
        {
            ExecuteSQL(_history);
        }

        private void hsLifeTime_Click(object sender, EventArgs e)
        {
            TestOpen(txtDatabase.Text, _dbrRegLocal);
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            hsLifeTime.Marked = false;
        }


        private void exportToHtml(string filename)
        {
            var sb = new StringBuilder();
            sb.Append("<html >");
            sb.Append("<head>");
            sb.Append("</head>");
            sb.Append("<body>");
            sb.Append("<table border='1px' cellpadding='1' cellspacing='1' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>");
            sb.Append("<tr >");
            foreach (DataColumn myColumn in dsResults.Tables[0].Columns)
            {
                sb.Append("<td >");
                sb.Append(myColumn.ColumnName);
                sb.Append("</td>");

            }
            sb.Append("</tr>");
            foreach (DataRow myRow in dsResults.Tables[0].Rows)
            {
                sb.Append("<tr >");
                foreach (DataColumn myColumn in dsResults.Tables[0].Columns)
                {
                    sb.Append("<td >");
                    sb.Append(myRow[myColumn.ColumnName].ToString());
                    sb.Append("</td>");

                }
                sb.Append("</tr>");
            }

            //Close tags.   
            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");

            if (ckExportToScreen.Checked)
            {
                fctXMLData.Clear();
                fctXMLData.Language = FastColoredTextBoxNS.Language.HTML;
                fctXMLData.AppendText(sb.ToString());
            }
            if (ckExportToFile.Checked)
                File.WriteAllText(filename, sb.ToString());
        }

        public static string WriteCSV(string input, char seperator)
        {
            try
            {
                if (input == null)
                    return string.Empty;

                bool containsQuote = false;
                bool containsComma = false;
                int len = input.Length;
                for (int i = 0; i < len && (containsComma == false || containsQuote == false); i++)
                {
                    char ch = input[i];
                    if (ch == '"')
                        containsQuote = true;
                    else if (ch == seperator)
                        containsComma = true;
                }

                // test test test;te"s"t2  
                // test;"test;te""s""t2";

                // test test testte"s"t2  
                // test;test;te"s"t2;

                if (containsQuote && containsComma)
                    input = input.Replace("\"", "\"\"");

                if (containsComma)
                    return "\"" + input + "\"";
                else
                    return input;
            }
            catch
            {
                throw;
            }
        }

        private async void exportCSV(string filename, char seperator)
        {
            DataTable dt = dsResults.Tables[0];
            fctXMLData.Clear();
            fctXMLData.Language = FastColoredTextBoxNS.Language.Custom;
            bool first = true;
            if (ckExportToFile.Checked)
            {
                using (StreamWriter writer = File.CreateText(filename))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        var sb = new StringBuilder();
                        if (first)
                        {
                            foreach (DataColumn dc in dt.Columns)
                            {
                                sb.Append($@"{WriteCSV(dc.ColumnName, seperator)}{seperator}");
                            }
                            sb.Remove(sb.Length - 1, 1);

                            await writer.WriteLineAsync(sb.ToString());
                            if (ckExportToScreen.Checked)
                            {
                                fctXMLData.AppendText(sb.ToString());
                            }
                            first = false;
                            sb = new StringBuilder();
                        }

                        foreach (DataColumn dc in dt.Columns)
                        {
                            sb.Append($@"{WriteCSV(dr[dc.ColumnName].ToString(), seperator)}{seperator}");
                        }
                        sb.Remove(sb.Length - 1, 1);

                        await writer.WriteLineAsync(sb.ToString());
                        if (ckExportToScreen.Checked)
                        {
                            fctXMLData.AppendText(sb.ToString());
                        }
                    }
                }
            }
            else if (ckExportToScreen.Checked)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var sb = new StringBuilder();
                    if (first)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            sb.Append($@"{WriteCSV(dc.ColumnName, seperator)}{seperator}");
                        }
                        sb.Remove(sb.Length - 1, 1);
                        sb.AppendLine();
                        fctXMLData.AppendText(sb.ToString());
                        first = false;
                        sb = new StringBuilder();
                    }

                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append($@"{WriteCSV(dr[dc.ColumnName].ToString(), seperator)}{seperator}");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.AppendLine();
                    fctXMLData.AppendText(sb.ToString());
                }
            }

        }

        private void hsExportCSV_Click(object sender, EventArgs e)
        {
            if (ckExportToFile.Checked)
            {
                saveFileDialogCSV.DefaultExt = ".csv";
                saveFileDialogCSV.Filter = "CSV|*.csv|All|*.*";
                saveFileDialogCSV.InitialDirectory = _dbrRegLocal.InitialExportPath;
                if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
                {
                    string s = cbCSVSeperator.Text.Trim();
                    exportCSV(saveFileDialogCSV.FileName, s[0]);
                }
            }
            else
            {
                string s = cbCSVSeperator.Text.Trim();
                exportCSV("", s[0]);
            }
        }

        private void hsExportHTML_Click(object sender, EventArgs e)
        {
            if (ckExportToFile.Checked)
            {
                saveFileDialogCSV.DefaultExt = ".html";
                saveFileDialogCSV.Filter = "HTML|*.html|All|*.*";
                saveFileDialogCSV.InitialDirectory = _dbrRegLocal.InitialExportPath;
                if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
                {
                    exportToHtml(saveFileDialogCSV.FileName);
                }
            }
            else
            {
                exportToHtml("");
            }
        }

        private void HotSpot2_Click(object sender, EventArgs e)
        {
            int n = ExecSqlForExport(_history);
            lblExportLinesCount.Text = n.ToString();
        }

        private void HsExportBreak_Click(object sender, EventArgs e)
        {
            doExport = false;
        }

        private void HsRefreshHistory_Click(object sender, EventArgs e)
        {
            RefreshHistory();
        }
        private void RefreshHistory()
        {
            try
            {
                sh.HistoryRefresh(dgvSQLHistory,  bsHistory, cbSQLsucceded.Checked, cbSQLfailed.Checked, cbAllHistory.Checked);
                sh.SortGrid(dgvSQLHistory, 1);
            }
            catch (Exception ex)
            {
                SQLnotify.AddToERROR(ex.Message);
            }
            tabHistory.Text = $@"{LanguageClass.Instance().GetString("History")} ({dgvSQLHistory.Rows.Count})";
        }
        
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView grid = sender as DataGridView;
            if (grid.SelectedRows.Count > 0)
            {
                var row = grid.SelectedRows[0];
                txtSQL.Text = row.Cells[3].Value.ToString();
                tcSQLCONTROL.SelectedTab = tabSQLTEXT;
            }
        }

        private void DgvSQLHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            sh.SwapSortGrid(grid, e.ColumnIndex);           
        }        
        private void CbAllHistory_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                sh.HistoryRefresh(dgvSQLHistory,bsHistory, cbSQLsucceded.Checked, cbSQLfailed.Checked, cbAllHistory.Checked);
                sh.SortGrid(dgvSQLHistory, 1);
            }
            catch (Exception ex)
            {
                SQLnotify.AddToERROR(ex.Message);
            }
        }

        private void CmsHistory_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDeleteHistoryEntry)
            {
                int n = 0;
                foreach (DataGridViewRow dr in dgvSQLHistory.SelectedRows)
                {
                    if (sh.DeleteHistoryEntry((int)dr.Cells[0].Value)) n++;
                }
                if (n > 0)
                {
                    try
                    {
                        sh.HistoryRefresh(dgvSQLHistory,  bsHistory, cbSQLsucceded.Checked, cbSQLfailed.Checked, cbAllHistory.Checked);
                        sh.SortGrid(dgvSQLHistory, 1);
                    }
                    catch (Exception ex)
                    {
                        SQLnotify.AddToERROR(ex.Message);
                    }
                }
            }
            else if (e.ClickedItem == tsmiHistoryCopyToSQL)
            {
                if (dgvSQLHistory.SelectedRows.Count > 0)
                {
                    txtSQL.Clear();
                    tcSQLCONTROL.SelectedTab = tabSQLTEXT;
                }
                foreach (DataGridViewRow dr in dgvSQLHistory.SelectedRows)
                {
                    string sql = dr.Cells[3].Value.ToString();
                    txtSQL.AppendText($@"{sql}{Environment.NewLine}");
                }
            }
            else if (e.ClickedItem == tsmiHistoryExecuteSQL)
            {
                ExecuteHistorySelected();                
            }
        }

        private void SQLViewForm1_Enter(object sender, EventArgs e)
        {
          //  SEHotSpot.Controller.Instance().SetHookForm(this);
        }

        private void hsClearHistory_Click(object sender, EventArgs e)
        {
            if (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DeleteHistory", "DoYouWantDeleteHistory", FormStartPosition.CenterScreen, SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation) == SEDialogResult.Yes)
            {
                File.Delete(HistoryFile);
                RefreshHistory();
            }
        }

        private void ckShowResults_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}