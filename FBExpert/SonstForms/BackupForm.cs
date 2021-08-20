using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.Globals;
using FormInterfaces;
using MessageFormLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class BackupForm : IEditForm
    {
        
        DBRegistrationClass DBReg = null;
        public BackupForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;            
            DBReg = drc;
            _dbReg = DBReg.Clone();
        }
                             
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void BackupForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            ShowCaptions();
            DataToEdit();           
        }

        public void ShowCaptions()
        {
            lblCaption.Text = $@"Database Backup/Restore:{DBReg.Alias}";
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Database Backup/Restore");
        }

        DBRegistrationClass _dbReg = null;

        public override void DataToEdit()
        {            
            txtRestoreDestinationDatabasePath.Text = DBReg.DatabasePath;
            txtBackupSourceDatabasePath.Text = DBReg.DatabasePath;

            if(DBReg.ConnectionType == eConnectionType.embedded)
            {                
                rbEmbedded.Checked = true;
                txtServer.Text = "";
            }            
            else
            {
                rbRemote.Checked = true;
                txtServer.Text = DBReg.Server;
            }
        }

        private DBRegistrationClass EditToData()
        {                       
            if(rbEmbedded.Checked)
            {                
                _dbReg.ConnectionType = eConnectionType.embedded;
            }
            else if(rbRemote.Checked)
            {                
                _dbReg.ConnectionType = eConnectionType.server;
                _dbReg.Server = txtServer.Text;
            }
            _dbReg.DatabasePath = txtBackupSourceDatabasePath.Text;
            return _dbReg;
        }

        private void hsBackup_Click(object sender, EventArgs e)
        {            
            n = 0;
            lvBackupMessage.Items.Clear();
            EditToData();
            
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

        int n = 0;
        
        private void Backup_ServiceOutput(object sender, FirebirdSql.Data.Services.ServiceOutputEventArgs e)
        {
           
            n++;
            StaticFunctionsClass.SetDoubleBuffered(lvBackupMessage);
        
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
            StaticFunctionsClass.SetDoubleBuffered(lvBackupMessage);
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
            var ca = new ConnectionAttributes();
            ca.Server = DBReg.Server;
          //SE  ca.Client = DRC.Client;
            ca.DatabasePath = txtRestoreDestinationDatabasePath.Text;
            ca.Password = DBReg.Password;
            ca.User = DBReg.User;
            ca.ConnectionType = DBReg.ConnectionType;
            ca.CharSet = DBReg.CharSet;
            ca.PacketSize = DBReg.PacketSize;
            ca.Port = DBReg.Port;

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
            FirebirdSql.Data.Services.FbBackupFile bf = new FirebirdSql.Data.Services.FbBackupFile(txtBackupLocation.Text);
            bf.BackupLength = StaticFunctionsClass.ToIntDef(txtBackupFileSize.Text.Trim(), 0);
            string[] obarr = { bf.BackupFile,bf.BackupLength.ToString() };
            ListViewItem lvi = new ListViewItem(obarr);
            lvi.Tag = bf;
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
            FirebirdSql.Data.Services.FbBackupFile bf = new FirebirdSql.Data.Services.FbBackupFile(txtRestoreLocation.Text);
            bf.BackupLength = StaticFunctionsClass.ToIntDef(txtRestoreFileSize.Text.Trim(), 0);
            string[] obarr = { bf.BackupFile, bf.BackupLength.ToString() };
            ListViewItem lvi = new ListViewItem(obarr);
            lvi.Tag = bf;
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
            ofdBackup.InitialDirectory = DBReg.DatabasePath;
            String guidstr = Guid.NewGuid().ToString();
            ofdBackup.FileName = $@"{DBReg.Alias.Replace(" ","")}_{guidstr}.fbk";
            ofdBackup.Title = "Backupfile";
            if(ofdBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = ofdBackup.FileName;
            }
        }

        private void hsLoadRestoreFile_Click(object sender, EventArgs e)
        {
            ofdRestore.InitialDirectory = DBReg.DatabasePath;
            ofdRestore.Title = "Restore to...";
            ofdRestore.FileName = "Database.fbd";
            if (ofdRestore.ShowDialog() == DialogResult.OK)
            {
                txtRestoreLocation.Text = ofdRestore.FileName;
            }
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            ofdRestoreFromDatabase.InitialDirectory = DBReg.DatabasePath;            
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

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            rbCheckedChanged();            
        }

        private void rbRemote_CheckedChanged(object sender, EventArgs e)
        {
            rbCheckedChanged();            
        }
        private void rbCheckedChanged()
        {
            if(rbRemote.Checked)
            {
                txtServer.Enabled = true;
                txtServer.Text = DBReg.Server;
            }
            else if(rbEmbedded.Checked)
            {
                txtServer.Enabled = false;
                txtServer.Text = "";
            }
            
            EditToData();
            txtBackupSourceDatabasePath.Text = _dbReg.DatabasePath;
        }

        private void rbEmbedded_CheckedChanged(object sender, EventArgs e)
        {
            rbCheckedChanged();            
        }

        private void hsChooseDatabase_Click(object sender, EventArgs e)
        {
            ofdDatabase.InitialDirectory = DBReg.DatabasePath;
            ofdDatabase.FileName = txtBackupSourceDatabasePath.Text;
            ofdDatabase.Title = "Databasefile";
            if (ofdDatabase.ShowDialog() == DialogResult.OK)
            {
                txtBackupSourceDatabasePath.Text = ofdDatabase.FileName;
            }
        }
    }  
}
