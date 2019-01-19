using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.Globals;
using MessageLibrary;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class BinariesForm : Form
    {
        private DBRegistrationClass _dbReg = null;
        public BinariesForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = drc;
            
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeISQLOptions()
        {
            string serverTypeStr = (_dbReg.ConnectionType == eConnectionType.embedded) ? "" : $@"{_dbReg.Server}: : ";
            
            txtISQLParameters.Text = $"-user {_dbReg.User} -password **** -database connect {serverTypeStr}{_dbReg.DatabasePath}";
            if(cbISQLNoFireTriggers.Checked) txtISQLParameters.Text += " -nod";
            if(cbNoAutocommit.Checked) txtISQLParameters.Text += " -n";
            if(cbNoWarnings.Checked) txtISQLParameters.Text += " -now";
            if((cbOutputFile.Checked)&&(!string.IsNullOrEmpty(txtOutputFile.Text)))
            {
                txtISQLParameters.Text += $@" -o {txtOutputFile.Text}";
            }
            if((cbInputFile.Checked)&&(File.Exists(txtInputFile.Text)))
            {
                txtISQLParameters.Text += $@" -i {txtInputFile.Text}";
            }
        }

        private void MakeGFIXOptions()
        {
            string serverTypeStr = (_dbReg.ConnectionType == eConnectionType.embedded) ? "" : $@"{_dbReg.Server}: : ";
            txtGFIXParameters.Text = $"-user {_dbReg.User} -password **** -validate {serverTypeStr}{_dbReg.DatabasePath}";            
        }

        private string MakeGBAKConnectOptions()
        {
            //string serverTypeStr = _dbReg.ServerType == eServerType.server ? $@"{_dbReg.Server}:" : "";
            return $"-user {_dbReg.User} -password **** "; //
        }

        private void MakeGSTATOptions()
        {
            string serverTypeStr = (_dbReg.ConnectionType == eConnectionType.embedded) ? "" : $@"{_dbReg.Server}: : ";
            txtGSTATParameters.Text = $"-user {_dbReg.User} -password **** -r -d {serverTypeStr}{_dbReg.DatabasePath}";           
        }

        private void hsRUN_Click(object sender, EventArgs e)
        {
            if(tcCenter.SelectedTab == tabISQL)
            {
                DoISQL();
            }
            else if(tcCenter.SelectedTab == tabGSTAT)
            {
                 TableStatistics();
            }
            else if(tcCenter.SelectedTab == tabGFIX)
            {
                
                DoGFIX();
            }
            else if(tcCenter.SelectedTab == tabGBAK)
            {
                DoGBAK();
            }
        }
        private void DoISQL()
        {
            //string args = $"-u SYSDBA -p masterkey -r -d {dbReg.DatabasePath}";                        
            FileInfo fi = new FileInfo($@"{_dbReg.FirebirdBinaryPath}\isql.exe");   
            if(fi.Exists)
            {
                string arg = txtISQLPassword.Text.Replace("****",_dbReg.Password);
                var psi = new ProcessStartInfo(fi.FullName,txtISQLParameters.Text);                            
                psi.UseShellExecute = false;
            
                var ps = new Process();
                ps.StartInfo = psi;
                ps.Start();
           
                ps.WaitForExit();
                ps.Close();
            }
            else
            {
                 object[] p = {fi.FullName, Environment.NewLine };
                 SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "FileNotExists", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, p);
            }
        }

        
        private void DoGFIX()
        {
            fctGFIXOutput.Clear();
            string args = txtGFIXParameters.Text.Replace("****",_dbReg.Password);
            var psi = new ProcessStartInfo($@"{_dbReg.FirebirdBinaryPath}\gfix.exe",args);            
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            fctGFIXOutput.AppendText($@"Starting of GFIX{Environment.NewLine}");
            var ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
            
            var reader = ps.StandardOutput;
            string output = reader.ReadToEnd();       
            fctGFIXOutput.AppendText(output);
            
            ps.WaitForExit();
            ps.Close();
            fctGFIXOutput.AppendText($@"{Environment.NewLine}End of GFIX{Environment.NewLine}");
            
        }

        void MakeBackupVersion()
        {
            string cmd = $@"{MakeGBAKConnectOptions()} -z";
            txtGBAKParameters.Text = cmd;
//            -validate {serverTypeStr}{_dbReg.DatabasePath}";            
        }

        void MakeBackupParameters()
        {
            string serverTypeStr = ((int) _dbReg.ConnectionType).ToString();
            FileInfo fi = new FileInfo(_dbReg.DatabasePath);
            string cmd = $@"{MakeGBAKConnectOptions()} -B -V {serverTypeStr}{_dbReg.DatabasePath} {fi.DirectoryName}\{fi.Name.Replace(fi.Extension,".fbk")}";
            txtGBAKParameters.Text = cmd;
//            -validate {serverTypeStr}{_dbReg.DatabasePath}";            
        }
        StreamWatcher sw = null;
        Process ps = null;
        private void DoGBAK()
        {
            textBox1.Clear();
            string args = txtGBAKParameters.Text.Replace("****",_dbReg.Password);
            var psi = new ProcessStartInfo($@"{_dbReg.FirebirdBinaryPath}\gbak.exe",args);            
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            textBox1.AppendText($@"Starting of GBAK{Environment.NewLine}");

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
           
        }

        private void Ps_Exited(object sender, EventArgs e)
        {
           backgroundWorker1.CancelAsync();
            if(sw != null)
           sw.MessageAvailable -= Sw_MessageAvailable;
            sw = null;
            
        }

        //BackgroundWorker backgroundWorker1 = null;

        private void TableStatistics()
        {
            fctGSTATOutput.Clear();
            fctGSTATOutput.AppendText($@"Starting of GSTAT{Environment.NewLine}");
            
            string args = txtGSTATParameters.Text.Replace("****",_dbReg.Password);
            string binfile = $@"{_dbReg.FirebirdBinaryPath}\gstat.exe";
            FileInfo fi = new FileInfo(binfile);
            if(fi.Exists)
            {
                var psi = new ProcessStartInfo(binfile,args);            
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
            
            
                var ps = new Process();
            
                ps.StartInfo = psi;
                ps.Start();
                var reader = ps.StandardOutput;
                string output = reader.ReadToEnd();     
                fctGSTATOutput.AppendText(output);
            
               

                ps.WaitForExit();
                ps.Close();
                fctGSTATOutput.AppendText("END of statistics");
            }
            else
            {
                fctGSTATOutput.AppendText($@"File not exists:{fi.FullName}");
            }
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
            textBox1.AppendText($@"{Environment.NewLine}End of of GSTAT{Environment.NewLine}");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {           
            while(!backgroundWorker1.CancellationPending)
            {
               Application.DoEvents();
               // Thread.Sleep(5000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   
            int l = e.UserState.ToString().Length;
            /*
            if(e.UserState.ToString().StartsWith("\0\0\0\0\0"))
            {
                backgroundWorker1.CancelAsync();
              
                sw = null;
                
            }
            */
            textBox1.AppendText(e.UserState.ToString());
            //richTextBox1.Select(richTextBox1.TextLength-1,1);
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
            
           //fcbGBAKOutput.AppendText(e.UserState.ToString());    
            //fcbGBAKOutput.SelectionStart = fcbGBAKOutput.Text.Length;          
           // fcbGBAKOutput.Refresh(); 
            //this.Refresh();
        }

        private void BinariesForm_Load(object sender, EventArgs e)
        {
            txtISQLUser.Text = _dbReg.User;
            txtISQLPassword.Text = _dbReg.Password;

            txtGBAKUser.Text = _dbReg.User;
            txtGBAKPassword.Text = _dbReg.Password;

            MakeISQLOptions();
            MakeGSTATOptions();
            MakeGFIXOptions();
            MakeGBAKConnectOptions();
        }

        private void cbISQLOptions_CheckedChanged(object sender, EventArgs e)
        {
            MakeISQLOptions();
        }

        private void cbOutputFile_CheckedChanged(object sender, EventArgs e)
        {
            txtOutputFile.Enabled = cbOutputFile.Checked;
            txtInputFile.Enabled = cbInputFile.Checked;
            MakeISQLOptions();
        }

        private void hsSelectFolderOutputFile_Click(object sender, EventArgs e)
        {
            if(ofdFiles.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = ofdFiles.FileName;
                MakeISQLOptions();
            }
        }

        private void hsSelectFolderInputFile_Click(object sender, EventArgs e)
        {
            if(ofdFiles.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = ofdFiles.FileName;
                MakeISQLOptions();
            }
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {
            MakeISQLOptions();
        }

        private void txtInputFile_TextChanged(object sender, EventArgs e)
        {
            MakeISQLOptions();
        }

        private void cbBackupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBackupType.Text == "Version")
            {
                MakeBackupVersion();
            }
            else if(cbBackupType.Text == "Backup")
            {
                MakeBackupParameters();
            }
        }
    }
}
