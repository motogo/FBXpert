using BasicClassLibrary;
using BasicFormClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FormInterfaces;
using SEMessageBoxLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class BackupForm : IEditForm
    {
        
        private DBRegistrationClass dbRegOrg = null;
        private DBRegistrationClass _dbReg = null;
        private int n = 0;
        public BackupForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;            
            dbRegOrg = drc;
            _dbReg = dbRegOrg.Clone();
        }

        public void  EditToData()
        {

        }
                             
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void SetControlSizes()
        {
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlBackupUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlRestoreUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }
        public bool TestOpen(DBRegistrationClass dbReg)
        {
            string server = dbReg.MakeServerFromText(dbReg.DatabasePath);
            string path = dbReg.MakeDatabasepathFromText(dbReg.DatabasePath);
            _dbReg.Server = server;
            _dbReg.DatabasePath = path;
            string connectionString = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            string lifeTime = AppStaticFunctionsClass.GetLifetime(connectionString, (int)_dbReg.Version >= (int)eDBVersion.FB3_32);
            hsLifeTime.ToolTipActive = true;
            hsLifeTime.ToolTipText = connectionString;
            hsLifeTime.Marked = !string.IsNullOrEmpty(lifeTime);
            hsLifeTime.Text = lifeTime;
            return (lifeTime != "-1");
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            AppStaticFunctionsClass.GetDatabases(cbConnection, dbRegOrg);
            TestOpen(dbRegOrg);

            txtBackupLocation.Text = dbRegOrg.DatabasePath.ToLower().Replace(".fdb",".fbk");
            txtRestoreLocation.Text = dbRegOrg.DatabasePath.ToLower().Replace(".fdb", ".fbk");
            txtRestoreDestinationDatabasePath.Text = dbRegOrg.DatabasePath;

            FormDesign.SetFormLeft(this);
            ShowCaptions();
        }

        public void ShowCaptions()
        {
            this.Text = DevelopmentClass.Instance().GetDBInfo(dbRegOrg, "Database Backup/Restore");
        }

        public void DataToEdit()
        {            
          //DontRemove    
        }

        private void hsBackup_Click(object sender, EventArgs e)
        {            
            n = 0;
            lvBackupMessage.Items.Clear();
         
            _dbReg = (DBRegistrationClass) cbConnection.SelectedItem;
            string cns = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var bu = new BackupClass(cns);
            var lf = new List<FirebirdSql.Data.Services.FbBackupFile>();
            for(int i = 0; i < lvBackup.Items.Count; i++)
            {
                ListViewItem lvi = lvBackup.Items[i];
                FirebirdSql.Data.Services.FbBackupFile bf = (FirebirdSql.Data.Services.FbBackupFile)lvi.Tag;
                lf.Add(bf);                
            }
            bu.SetFiles(lf.ToArray());
            bu.Backup.ServiceOutput += Backup_ServiceOutput;
            if (cbBackupIgnoreChecksum.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.IgnoreChecksums);
            }
            if (cbBackupDisableTriggers.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.NoDatabaseTriggers);
            }
            if (cbBackupMetatdataOnly.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.MetaDataOnly);
            }
            if (!cbBackupGarbageCollect.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.NoGarbageCollect);
            }
            if (!cbBackupTransportable.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.NonTransportable);
            }
            if (cbBackupOldDescriptions.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.OldDescriptions);
            }
            if (cbBackupConvert.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.Convert);
            }
            if (cbBackupLimbo.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.IgnoreLimbo);
            }
            if (cbBackupExpand.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbBackupFlags.Expand);
            }
            try
            { 
                bu.Execute();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Backup_ServiceOutput(object sender, FirebirdSql.Data.Services.ServiceOutputEventArgs e)
        {
            n++;
            StaticFormsFunctionsClass.SetDoubleBuffered(lvBackupMessage);
        
            lvBackupMessage.BeginUpdate();
            string[] m = {n.ToString(), e.Message, StaticFunctionsClass.DateTimeNowStr() };
            ListViewItem lvi = new ListViewItem(m);

            lvBackupMessage.Items.Add(lvi);
            lvBackupMessage.Items[lvBackupMessage.Items.Count - 1].EnsureVisible();
            lvBackupMessage.EndUpdate();
                     
            if (n % 20 == 0)
            {                
                Application.DoEvents();                
            }            
        }
        private void Restore_ServiceOutput(object sender, FirebirdSql.Data.Services.ServiceOutputEventArgs e)
        {
            n++;
            StaticFormsFunctionsClass.SetDoubleBuffered(lvBackupMessage);
            lvBackupMessage.BeginUpdate();

            string[] m = { n.ToString(), e.Message, StaticFunctionsClass.DateTimeNowStr() };
            ListViewItem lvi = new ListViewItem(m );

            lvRestoreMessage.Items.Add(lvi);
            lvRestoreMessage.Items[lvRestoreMessage.Items.Count - 1].EnsureVisible();
            lvRestoreMessage.EndUpdate();

            if (n % 20 == 0)
            {
                Application.DoEvents();
            }
        }

        private void hsRestore_Click(object sender, EventArgs e)
        {
            n = 0;
            var ca = new ConnectionAttributes
            {
                Server = dbRegOrg.Server,
                //SE  ca.Client = DRC.Client;
                DatabasePath = txtRestoreDestinationDatabasePath.Text,
                Password = dbRegOrg.Password,
                User = dbRegOrg.User,
                ConnectionType = dbRegOrg.ConnectionType,
                CharSet = dbRegOrg.CharSet,
                PacketSize = dbRegOrg.PacketSize,
                Port = dbRegOrg.Port
            };

            string connstr = ConnectionStrings.Instance.MakeConnectionString(ca);

            lvRestoreMessage.Items.Clear();
            var bu = new RestoreClass(connstr);
            bu.Restore.ServiceOutput += Restore_ServiceOutput;
            
            var lf = new List<FirebirdSql.Data.Services.FbBackupFile>();

            for (int i = 0; i < lvRestore.Items.Count; i++)
            {
                ListViewItem lvi = lvRestore.Items[i];
                FirebirdSql.Data.Services.FbBackupFile bf = (FirebirdSql.Data.Services.FbBackupFile)lvi.Tag;
                
                lf.Add(bf);
            }
            bu.SetFiles(lf.ToArray());
            
            if (rbReplaceDatabase.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.Replace);
            }
            else
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.Create);
            }
            if (cbRestoreNoIndices.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.DeactivateIndexes);
            }
            if(cbRestoreNoShadows.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.NoShadow);
            }
            if (cbRestoreInvidualCommit.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.IndividualCommit);
            }
            if (cbRestoreMetatdataOnly.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.MetaDataOnly);
            }
            if (cbRestoreNoVaildy.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.NoValidity);
            }
            if (cbRestoreUseAllSpace.Checked)
            {
                bu.AddOptions(FirebirdSql.Data.Services.FbRestoreFlags.UseAllSpace);
            }
            ConnectionPoolClass.Instance.CloseAllConnections();
            if(ConnectionPoolClass.Instance.AktCON != null)
            ConnectionPoolClass.Instance.AktCON.Close();
            bu.Execute();
            DbExplorerForm.Instance().MakeDatabaseTree(true);
        }

        private void hsAddBackupFile_Click(object sender, EventArgs e)
        {
            FirebirdSql.Data.Services.FbBackupFile bf = new FirebirdSql.Data.Services.FbBackupFile(txtBackupLocation.Text)
            {
                BackupLength = StaticFunctionsClass.ToIntDef(txtBackupFileSize.Text.Trim(), 0)
            };
            string[] obarr = { bf.BackupFile,bf.BackupLength.ToString() };
            ListViewItem lvi = new ListViewItem(obarr)
            {
                Tag = bf
            };
            lvBackup.Items.Add(lvi);           
        }

        private void hsRemoveFile_Click(object sender, EventArgs e)
        {
            if(lvBackup.SelectedItems.Count <= 0) return;
            ListViewItem lvi = lvBackup.SelectedItems[0];
            lvi = null;
            lvBackup.SelectedItems[0].Remove();
        }

        private void hsAddRestoreFile_Click(object sender, EventArgs e)
        {
            FirebirdSql.Data.Services.FbBackupFile bf = new FirebirdSql.Data.Services.FbBackupFile(txtRestoreLocation.Text)
            {
                BackupLength = StaticFunctionsClass.ToIntDef(txtRestoreFileSize.Text.Trim(), 0)
            };
            string[] obarr = { bf.BackupFile, bf.BackupLength.ToString() };
            ListViewItem lvi = new ListViewItem(obarr)
            {
                Tag = bf
            };
            lvRestore.Items.Add(lvi);
        }

        private void hsRemoveRestoreFile_Click(object sender, EventArgs e)
        {
            if (lvBackup.SelectedItems.Count <= 0) return;
            
            ListViewItem lvi = lvBackup.SelectedItems[0];
            lvi = null;
            lvRestore.SelectedItems[0].Remove();            
        }
        
        private void hsLoadBackupFile_Click(object sender, EventArgs e)
        {
            
            FileInfo fi = new FileInfo(txtBackupLocation.Text);
            ofdBackup.InitialDirectory = fi.DirectoryName;
            String guidstr = Guid.NewGuid().ToString();
            ofdBackup.FileName = $@"{dbRegOrg.Alias.Replace(" ","")}_{guidstr}.fbk";
            ofdBackup.Title = "Backupfile";
            if(ofdBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = ofdBackup.FileName;
            }
        }

        private void hsLoadRestoreFile_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(txtRestoreLocation.Text);
            ofdRestore.InitialDirectory = fi.DirectoryName;
            ofdRestore.Title = "Restore to...";
            ofdRestore.FileName = "Database.fbd";
            if (ofdRestore.ShowDialog() == DialogResult.OK)
            {
                txtRestoreLocation.Text = ofdRestore.FileName;
            }
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(txtRestoreDestinationDatabasePath.Text);
            ofdRestoreFromDatabase.InitialDirectory = fi.DirectoryName;            
            ofdRestoreFromDatabase.Title = "Restore from Database";
            
            if (ofdRestoreFromDatabase.ShowDialog() == DialogResult.OK)
            {
                txtRestoreDestinationDatabasePath.Text = ofdRestoreFromDatabase.FileName;
            }
        }

        private void rbCreateDatabase_CheckedChanged(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(txtRestoreDestinationDatabasePath.Text);
            if(fi.Exists&&rbCreateDatabase.Checked)
            {
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseExceptionCaption","DatabaseFileExistsNoCreate",  SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation,null,null);
                rbReplaceDatabase.Checked = true;
            }
        }
    }  
}
