using BasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using System;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class AppSettingsForm
    {                   
        public AppSettingsForm(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;            
        }        
       
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
            
        }

        public void DataToEdit()
        {
            txtDefaultPacketsize.Text = AppSettingsClass.Instance.DatabaseSettings.DefaultPacketSize.ToString();
            txtDefaulUser.Text = AppSettingsClass.Instance.DatabaseSettings.DefaultUser;
            txtDefaultPassword.Text = AppSettingsClass.Instance.DatabaseSettings.DefaultPassword;
            txtDatabasesConfigPath.Text = AppSettingsClass.Instance.PathSettings.DatabasesConfigPath;
            txtScriptingPath.Text = AppSettingsClass.Instance.PathSettings.ScriptingPath;
            txtTemporaryPath.Text = AppSettingsClass.Instance.PathSettings.TempPath;
            txtDatabasesConfigFile.Text = $@"{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}";
            
        }
        public void EditToData()
        {
            AppSettingsClass.Instance.Stamp = DateTime.Now;
            AppSettingsClass.Instance.DatabaseSettings.DefaultPacketSize = StaticFunctionsClass.ToIntDef(txtDefaultPacketsize.Text,8192);
            AppSettingsClass.Instance.DatabaseSettings.DefaultPassword = txtDefaultPassword.Text;
            AppSettingsClass.Instance.DatabaseSettings.DefaultUser = txtDefaulUser.Text;
            AppSettingsClass.Instance.PathSettings.DatabasesConfigPath = txtDatabasesConfigPath.Text;
           
            AppSettingsClass.Instance.PathSettings.TempPath = txtTemporaryPath.Text;
            AppSettingsClass.Instance.PathSettings.ScriptingPath = txtScriptingPath.Text;
            AppSettingsClass.Instance.PathSettings.DatabaseConfigFile = txtDatabasesConfigFile.Text;
        }


        private void AppSettingsForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            this.Text = $@"App settings file:{AppSettingsClass.Instance.Path}";
            DataToEdit();
            SetEnables();            
        }

        private void SaveAppSettings()
        {
            EditToData();
            AppSettingsClass.Instance.SaveSettings();
        }
      
        private void hsSave_Click(object sender, EventArgs e)
        {
            EditToData();
            SaveAppSettings();
        }        

        private void hsScriptingPath_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtScriptingPath.Text = fbdPath.SelectedPath;
        }

        private void hsTemporaryPath_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtTemporaryPath.Text = fbdPath.SelectedPath;
        }

        private void hsDatabasesConfigPath_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() == DialogResult.OK)
            {
              txtDatabasesConfigPath.Text = fbdPath.SelectedPath;
            }
        }

        private void hsDatabaseConfigFile_Click(object sender, EventArgs e)
        {
            ofdFiles.InitialDirectory = txtDatabasesConfigPath.Text;
            if(ofdFiles.ShowDialog() == DialogResult.OK)
            {
                txtDatabasesConfigFile.Text = ofdFiles.FileName;
            }
        }
    }
}
