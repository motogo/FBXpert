using BasicClassLibrary;
using FBXpert.Globals;
using MessageFormLibrary;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class BinariesForm : Form
    {
        private DBRegistrationClass _dbReg = null;
        private StreamWatcher sw = null;
        private StreamWatcher sw_error = null;
        private Process ps = null;
        public BinariesForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = drc;
            txtRestoreFile.Text = _dbReg.DatabasePath.ToLower().Replace("fbd","fbk");
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeISQLParameters()
        {
            //string serverTypeStr = (_dbReg.ConnectionType == eConnectionType.embedded) ? "" : $@"{_dbReg.Server}: : ";
            //txtISQLParameters.Text = $"-user {txtISQLUser.Text} -password **** -database connect \"{_dbReg.GetFullDatabasePath().Replace("//","")}\"";
            txtISQLParameters.Text = $"-user {txtISQLUser.Text} -password **** -database connect \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void MakeGFIXParameters()
        {
            //string serverTypeStr = (_dbReg.ConnectionType == eConnectionType.embedded) ? "" : $@"{_dbReg.Server}: : ";
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -validate \"{_dbReg.GetFullDatabasePath()}\"";
        }
        
        private void MakeGSTATParameters()
        {
            var cmd = new StringBuilder();
            cmd.Append($@"-user {_dbReg.User} -password ****");

            if (cbGSTATDisplayVersion.Checked)
            {
                cmd.Append(" -z");
            }

            if (cbGSTATAnalyzeHeaderOnly.Checked)
            {
                cmd.Append(" -h");
            }
            else
            { 
                if(cbGSTATAnalyzeAverageRecords.Checked)
                { 
                  cmd.Append(" -r");
                }

                if(cbGSTATAnalyzeDataPages.Checked)
                {
                    cmd.Append(" -d");
                }

                if(cbGSTATAnalyzeIndexLeafPages.Checked)
                {
                    cmd.Append(" -i");
                }

                if(cbGSTATAnalyzeSystemRelations.Checked)
                {
                    cmd.Append(" -s");
                }

                if(cbGSTATAnalyzeDatasAndIndexPages.Checked)
                {
                    cmd.Append(" -a");
                }                
            }
            cmd.Append($" \"{ _dbReg.GetFullDatabasePath()}\"");

            if (!cbGSTATAnalyzeHeaderOnly.Checked)
            {
                if(cbGSTATTablename.Checked)
                {
                    cmd.Append($@" -t {txtGSTATTablename.Text}");
                }
            }
            txtGSTATParameters.Text = cmd.ToString();
        }

        void MakeVERSIONParameters()
        {
            var cmd = new StringBuilder();
            cmd.Append($"-user {txtGBAKUser.Text} -password ****  -z");     
            cmd.Append($" \"{_dbReg.GetFullDatabasePath()}\""); 
            txtGBAKParameters.Text = cmd.ToString();
        }

        void MakeBackupParameters()
        {
            //FileInfo fi = new FileInfo(txtDatabaseLocation.Text);
            var cmd = new StringBuilder();
            cmd.Append($@" -B");
            if (cbBackupReportActions.Checked)
            {
                cmd.Append(" -V");
            }
            
            if(txtServerLocation.Text.Length > 0)
            { 
                cmd.Append($@" {txtServerLocation.Text}:{txtDatabaseLocation.Text} {txtBackupLocation.Text} ");
            }
            else
            {
                cmd.Append($@" {txtDatabaseLocation.Text} {txtBackupLocation.Text} ");
            }

            cmd.Append($"-user {txtGBAKUser.Text} -password **** ");
            if (cbBackupTransportable.Checked)
            {
                cmd.Append(" -T");
            }

            if (cbBackupOldDescriptions.Checked)
            {
                cmd.Append(" -OL");
            }

            if (!cbBackupTransportable.Checked)
            {
                cmd.Append(" -NT");
            }

            if (cbBackupDisableTriggers.Checked)
            {
                cmd.Append(" -NOD");
            }

            if (cbBackupLimbo.Checked)
            {
                cmd.Append(" -L");
            }

            if (cbBackupExpand.Checked)
            {
                cmd.Append(" -E");
            }

            if (cbBackupIgnoreChecksum.Checked)
            {
                cmd.Append(" -IG");
            }

            if (cbBackupGarbageCollect.Checked)
            {
                cmd.Append(" -G");
            }

            if (cbBackupConvert.Checked)
            {
                cmd.Append(" -CO");
            }


            if (cbBackupMetatdataOnly.Checked)
            {
                cmd.Append(" -M");
            }

            txtGBAKParameters.Text = cmd.ToString();
            //            -validate {serverTypeStr}{_dbReg.DatabasePath}";            
        }
        void MakeRestoreParameters()
        {           
            var cmd = new StringBuilder();
            cmd.Append($@" -C"); //Restore
            if (cbRestoreReportActions.Checked)
            {
                cmd.Append(" -V");
            }
            cmd.Append($" {txtRestoreFile.Text} \"{_dbReg.GetFullDatabasePath()}\"");
            cmd.Append($@" -user {txtGBAKUser.Text} -password **** ");

            if (rbRestoreRecreate.Checked)
            {
                cmd.Append(" -REP");
            }
            if (ckRestoreDeactivateIndexes.Checked)
            {
                cmd.Append(" -I");
            }
            if (rbRestoreOverride.Checked)
            {

            }
            if (cbFIX_FSS_METADATA.Checked)
            {
                cmd.Append($@" -FIX_FSS_METADATA {txtRestoreFIX_META.Text}");
            }

            if (cbFIXFSSData.Checked)
            {
                cmd.Append($@" -FIX_FSS_DATA {txtRestoreFIX_META.Text}");
            }

            if (cbRestoreOverrideDefaultPageSize.Checked)
            {
                cmd.Append($@" -P {txtRestorePageSize.Text}");
            }

            if (cbRestoreNoShadows.Checked)
            {
                cmd.Append($@" -K");
            }

            if (cbRestoreOneTableAtATime.Checked)
            {
                cmd.Append($@" -O");
            }

            if (cbRestoreNoDataValidy.Checked)
            {
                cmd.Append($@" -N");
            }

            if (cbRestoreNoSpaceRecordVersions.Checked)
            {
                cmd.Append($@" -USE_ALL_SPACE");
            }

            if (rbRestoreReadWrite.Checked)
            {
                cmd.Append($@" -MO read_write");
            }
            else if (rbRestoreReadOnly.Checked)
            {
                cmd.Append($@" -MO read_only");
            }

            txtGBAKParameters.Text = cmd.ToString();
            //            -validate {serverTypeStr}{_dbReg.DatabasePath}";            
        }

        private void hsRUN_Click(object sender, EventArgs e)
        {           
            DoISQL();            
        }
        private void DoISQL()
        {                                
            var fi = new FileInfo($@"{_dbReg.FirebirdBinaryPath}\isql.exe");   
            if(!fi.Exists)
            {
                object[] p = { fi.FullName, Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "FileNotExists", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, p);
                return;
            }

            //string arg = txtISQLPassword.Text.Replace("****",_dbReg.Password);
            var psi = new ProcessStartInfo(fi.FullName,txtISQLParameters.Text.Replace("****", _dbReg.Password));                            
                            
            psi.RedirectStandardOutput  = false;
            psi.RedirectStandardError   = false;
            psi.UseShellExecute         = true;
            psi.CreateNoWindow          = false;

            var ps = new Process();
            ps.StartInfo = psi;
            ps.Start();           
            ps.WaitForExit();
                        
          //  fctISQLOutput.AppendText(ps.StandardOutput.ReadToEnd());            
          //  fctISQLOutput.AppendText(ps.StandardError.ReadToEnd());

            ps.Close();            
        }        
        private void DoGFIX()
        {
            FileInfo fi = new FileInfo($@"{_dbReg.FirebirdBinaryPath}\gfix.exe");
            if (!fi.Exists)
            {
                object[] p = { fi.FullName, Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "FileNotExists", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, p);
                return;
            }

            fctGFIXOutput.Clear();
            string args = txtGFIXParameters.Text.Replace("****",_dbReg.Password);
            var psi = new ProcessStartInfo($@"{_dbReg.FirebirdBinaryPath}\gfix.exe",args);            
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            fctGFIXOutput.AppendText($@"Starting of GFIX{Environment.NewLine}");
            var ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
            ps.WaitForExit();
            
            fctGFIXOutput.AppendText(ps.StandardOutput.ReadToEnd());                
            fctGFIXOutput.AppendText(ps.StandardError.ReadToEnd());

            ps.Close();
            fctGFIXOutput.AppendText($@"{Environment.NewLine}End of GFIX{Environment.NewLine}");            
        }
        
        private void DoGBAK()
        {
            FileInfo fi = new FileInfo($@"{_dbReg.FirebirdBinaryPath}\gbak.exe");
            if (!fi.Exists)
            {
                object[] p = { fi.FullName, Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "FileNotExists", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, p);
                return;
            }
            fctGBAKOutput.Clear();
            string args = txtGBAKParameters.Text.Replace("****",_dbReg.Password);
            var psi = new ProcessStartInfo($@"{_dbReg.FirebirdBinaryPath}\gbak.exe",args);            
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            fctGBAKOutput.AppendText($@"Starting of GBAK{Environment.NewLine}");
            
            backgroundWorker1 = new BackgroundWorker();            
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.RunWorkerAsync(); 
            
            ps = new Process();
            ps.StartInfo = psi;
            ps.EnableRaisingEvents = true;
            ps.Exited += Ps_Exited;
            
            ps.Start();
            sw = new StreamWatcher(ps.StandardOutput.BaseStream);
            sw.MessageAvailable += Sw_MessageAvailable;
            sw_error = new StreamWatcher(ps.StandardError.BaseStream);
            sw_error.MessageAvailable += Sw_MessageAvailable;
        }

        private void Ps_Exited(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            if(sw != null)
                sw.MessageAvailable -= Sw_MessageAvailable;
            if (sw_error != null)
                sw_error.MessageAvailable -= Sw_MessageAvailable;

            sw = null;
            sw_error = null;
            ps = null;
        }        

        private void DoGSTAT()
        {
            fctGSTATOutput.Clear();
            fctGSTATOutput.AppendText($@"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} Starting of GSTAT{Environment.NewLine}");
            
            string args = txtGSTATParameters.Text.Replace("****",_dbReg.Password); 
            string binfile = $@"{_dbReg.FirebirdBinaryPath}\gstat.exe";
            FileInfo fi = new FileInfo(binfile);
            if(!fi.Exists)
            {
                object[] p = { fi.FullName, Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "FileNotExists", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, p);
                return;
            }
            var psi = new ProcessStartInfo(binfile,args);
            psi.RedirectStandardOutput  = true;
            psi.RedirectStandardError   = true;
            psi.UseShellExecute         = false;
            psi.CreateNoWindow          = true;
             
            var ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
            
            fctGSTATOutput.AppendText(ps.StandardOutput.ReadToEnd());
            fctGSTATOutput.AppendText(ps.StandardError.ReadToEnd());

            ps.WaitForExit();
            ps.Close();
            
            fctGSTATOutput.AppendText("END of statistics");
        }

        private void Sw_MessageAvailable(object sender, MessageAvailableEventArgs e)
        {
            if((!backgroundWorker1.CancellationPending)&&(backgroundWorker1.IsBusy))
            {              
              backgroundWorker1.ReportProgress(0,e.MessageString);
            }           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fctGBAKOutput.AppendText($@"{Environment.NewLine}End of of GBAK{Environment.NewLine}");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            while (!backgroundWorker1.CancellationPending)
            {
               Application.DoEvents();               
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   
            int l = e.UserState.ToString().Length;
            fctGBAKOutput.AppendText(e.UserState.ToString());
            fctGBAKOutput.SelectionStart = fctGBAKOutput.TextLength;
            fctGBAKOutput.ScrollLeft();
            //fctGBAKOutput.sc.ScrollToCaret();            
        }

        private void BinariesForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            txtISQLUser.Text         = _dbReg.User;
            txtISQLPassword.Text     = _dbReg.Password;
            txtGBAKUser.Text         = _dbReg.User;
            txtGBAKPassword.Text     = _dbReg.Password;
            txtISQLUser.Text         = _dbReg.User;
            txtISQLPassword.Text     = _dbReg.Password;
            txtGSTATUser.Text        = _dbReg.User;
            txtGSTATPassword.Text    = _dbReg.Password;
            txtGFIXUser.Text         = _dbReg.User;
            txtGFIXPassword.Text     = _dbReg.Password;
            txtServerLocation.Text   = _dbReg.GetServerLocation();
            txtDatabaseLocation.Text = _dbReg.DatabasePath;

            LanguageChanged();
            MakeISQLParameters();
            MakeGSTATParameters();
            MakeGFIXParameters();
            MakeBackupParameters();
            MakeRestoreParameters();
            MakeVERSIONParameters();

        }

        private void LanguageChanged()
        {
          tabPageRestore.Text = LanguageClass.Instance().GetString("DatabaseRestore");
          tabPageBackup.Text  = LanguageClass.Instance().GetString("DatabaseBackup");
          tabPageVersion.Text = LanguageClass.Instance().GetString("DatabaseVersion");
        }              
              
        private void cbRestore_CheckedChanged(object sender, EventArgs e)
        {
            MakeRestoreParameters();
        }

        private void CbRestoreOverrideDefaultPageSize_CheckedChanged(object sender, EventArgs e)
        {
            txtRestorePageSize.Enabled = cbRestoreOverrideDefaultPageSize.Checked;
            MakeRestoreParameters();
        }

        private void TabPageRestore_Enter(object sender, EventArgs e)
        {
            MakeRestoreParameters();
        }

        private void TabPageBackup_Enter(object sender, EventArgs e)
        {
            MakeBackupParameters();
        }

        private void CbRestoreOverridePageBuffers_CheckedChanged(object sender, EventArgs e)
        {
            txtRestoreOverridePageBuffers.Enabled = cbRestoreOverridePageBuffers.Checked;
            MakeRestoreParameters();
        }

        private void CbBackup_CheckedChanged(object sender, EventArgs e)
        {
            MakeBackupParameters();
        }

        private void TcCenter_Enter(object sender, EventArgs e)
        {
            MakeGSTATParameters();
        }

        private void CbGSTATTablename_CheckedChanged(object sender, EventArgs e)
        {
            txtGSTATTablename.Enabled = cbGSTATTablename.Checked;
            MakeGSTATParameters();
        }

        private void CbGSTATAnalyzeHeaderOnly_CheckedChanged(object sender, EventArgs e)
        {
            gbGSTATOptions2.Enabled = !cbGSTATAnalyzeHeaderOnly.Checked;
            MakeGSTATParameters();
        }

        private void cbGSTATChecked_Changed(object sender, EventArgs e)
        {
            MakeGSTATParameters();
        }

        public string GetVersion()
        {
            return cbShowVersion.Checked ? "-z" : string.Empty;
        }


        private void HsGFIXShutdownMulti_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -shut multi -force {txtGFIXShutdownSeconds.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXShutdownSingle_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -shut single -force {txtGFIXShutdownSeconds.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXShutdownFull_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -shut full -force {txtGFIXShutdownSeconds.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXSetOnline_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -online multi {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXOnlineFull_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -online {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXOnlineSingle_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -online single {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXONlineMulti_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -online multi {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXSweep_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -sweep {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HotSpot2_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -h {txtGFIXSweepInterval.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXPageCapacityReserve_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -u reserve {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXPageFillFull_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -u full {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXBuffers_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -b {txtGFIXBuffers.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXBufferServerDefault_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -b 0 {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXReadWriteMode_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -mo read_write {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXAccessRead_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -mo read_only {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXENableForcedWrites_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -w sync {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXDisableForcedWrites_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -w async {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXLimboTransactions_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -list {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXAutomatetRecovery_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -two_phase all {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXRecoverLimboTrans_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -commit all {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HotSpot3_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -commit {txtGFIXLimboIDRecover.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HotSpot4_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -two_phase {txtGFIXTowWayLimboID.Text} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXResolveLimboAll_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -rollback all {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsGFIXResolveLimbID_Click(object sender, EventArgs e)
        {
            txtGFIXParameters.Text = $"-user {txtGFIXUser.Text} -password **** -rollback {txtGFIXLimboIDRecover.Text.Trim()} {GetVersion()} \"{_dbReg.GetFullDatabasePath()}\"";
        }

        private void HsRunGFIX_Click(object sender, EventArgs e)
        {                                                         
            DoGFIX();
        }

        private void HsRunGSTAT_Click(object sender, EventArgs e)
        {
            DoGSTAT();
        }

        private void HsRunGBAK_Click(object sender, EventArgs e)
        {
            DoGBAK();
        }

        private void HsLoadDatabaseFile_Click(object sender, EventArgs e)
        {
            if(ofdDatabase.ShowDialog() == DialogResult.OK)
            {
                txtDatabaseLocation.Text = ofdDatabase.FileName;
            }
        }

        private void HsLoadBackupFile_Click(object sender, EventArgs e)
        {
            if (ofdBackup.ShowDialog() == DialogResult.OK)
            {
               txtBackupLocation.Text = ofdBackup.FileName;
            }
        }

        private void TxtDatabaseLocation_TextChanged(object sender, EventArgs e)
        {
            MakeBackupParameters();
        }

        private void TabGBAK_Enter(object sender, EventArgs e)
        {
            if(tabControlGBAK.SelectedTab == tabPageBackup)
            {
                MakeBackupParameters();
            }
            else if(tabControlGBAK.SelectedTab == tabPageRestore)
            {
                MakeRestoreParameters();
            }
            else
            {
                MakeVERSIONParameters();
            }
        }

        private void HotSpot5_Click(object sender, EventArgs e)
        {
            if(ofdBackup.ShowDialog() == DialogResult.OK)
            {
                txtRestoreFile.Text = ofdBackup.FileName;
            }
        }

        private void rtbGFIXArguments_TextChanged(object sender, EventArgs e)
        {

        }

        private void hsClearGBAKOutput_Click(object sender, EventArgs e)
        {
            fctGBAKOutput.Clear();
        }

        private void hsClearGSTATOutput_Click(object sender, EventArgs e)
        {
            fctGSTATOutput.Clear();
        }

        private void ckRestoreDeactivateIndexes_CheckedChanged(object sender, EventArgs e)
        {
            MakeRestoreParameters();
        }
    }
}
