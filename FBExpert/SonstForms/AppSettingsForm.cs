﻿using BasicClassLibrary;
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
            numDefaultPacketSize.Value = AppSettingsClass.Instance.DatabaseSettings.DefaultPacketSize;
            numDefaultPort.Value = AppSettingsClass.Instance.DatabaseSettings.DefaultPort;
            numOpenDatabaseCount.Value = AppSettingsClass.Instance.DatabaseSettings.OpenDatabaseCount;

            txtSQLCommentEnd.Text = AppSettingsClass.Instance.SQLVariables.CommentEnd;
            txtSQLCommentStart.Text = AppSettingsClass.Instance.SQLVariables.CommentStart;

            txtDefaulUser.Text = AppSettingsClass.Instance.DatabaseSettings.DefaultUser;
            txtDefaultPassword.Text = AppSettingsClass.Instance.DatabaseSettings.DefaultPassword;
            txtDatabasesConfigPath.Text = AppSettingsClass.Instance.PathSettings.DatabasesConfigPath;
            txtScriptingPath.Text = AppSettingsClass.Instance.PathSettings.ScriptingPath;
            txtTemporaryPath.Text = AppSettingsClass.Instance.PathSettings.TempPath;
            txtDatabasesConfigFile.Text = $@"{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}";
            txtInfoPath.Text = AppSettingsClass.Instance.PathSettings.InfoPath;
            txtExportPath.Text = AppSettingsClass.Instance.PathSettings.ExportPath;
            txtSQLExportPath.Text = AppSettingsClass.Instance.PathSettings.SQLExportPath;
            txtSQLHistoryPath.Text = AppSettingsClass.Instance.PathSettings.SQLHistoryPath;
            txtSQLNewLine.Text = AppSettingsClass.Instance.SQLVariables.GetNewLineString();

            txtSQLMaxRowForSelect.Text = AppSettingsClass.Instance.SQLVariables.MaxRowsForSelect.ToString();
            txtSkipForSelect.Text = AppSettingsClass.Instance.SQLVariables.SkipForSelect.ToString();
            txtSQLSingleLineCommand.Text = AppSettingsClass.Instance.SQLVariables.SingleLineComment;
            txtSQLAlternativeTerminator.Text = AppSettingsClass.Instance.SQLVariables.AlternativeTerminator;
            txtSQLInitialTerminator.Text = AppSettingsClass.Instance.SQLVariables.InitialTerminator;
        }
        public void EditToData()
        {
            AppSettingsClass.Instance.Stamp = DateTime.Now;
            AppSettingsClass.Instance.DatabaseSettings.DefaultPacketSize = (int) numDefaultPacketSize.Value;
            AppSettingsClass.Instance.DatabaseSettings.DefaultPort = (int) numDefaultPort.Value;
            AppSettingsClass.Instance.DatabaseSettings.DefaultPassword = txtDefaultPassword.Text;
            AppSettingsClass.Instance.DatabaseSettings.DefaultUser = txtDefaulUser.Text;
            AppSettingsClass.Instance.DatabaseSettings.OpenDatabaseCount = (int)numOpenDatabaseCount.Value;
            AppSettingsClass.Instance.PathSettings.DatabasesConfigPath = txtDatabasesConfigPath.Text;
           
            AppSettingsClass.Instance.PathSettings.TempPath = txtTemporaryPath.Text;
            AppSettingsClass.Instance.PathSettings.ScriptingPath = txtScriptingPath.Text;
            AppSettingsClass.Instance.PathSettings.DatabaseConfigFile = txtDatabasesConfigFile.Text;
            AppSettingsClass.Instance.PathSettings.InfoPath = txtInfoPath.Text;
            AppSettingsClass.Instance.PathSettings.ExportPath = txtExportPath.Text;
            AppSettingsClass.Instance.PathSettings.SQLExportPath = txtSQLExportPath.Text;
            AppSettingsClass.Instance.PathSettings.SQLHistoryPath = txtSQLHistoryPath.Text;

            AppSettingsClass.Instance.SQLVariables.SetNewLine(txtSQLNewLine.Text);
            AppSettingsClass.Instance.SQLVariables.CommentStart = txtSQLCommentStart.Text;
            AppSettingsClass.Instance.SQLVariables.CommentEnd = txtSQLCommentEnd.Text;
            AppSettingsClass.Instance.SQLVariables.SkipForSelect = StaticFunctionsClass.ToIntDef(txtSkipForSelect.Text, StaticVariablesClass.SQLSkipForSelect);
            AppSettingsClass.Instance.SQLVariables.MaxRowsForSelect = StaticFunctionsClass.ToIntDef(txtSQLMaxRowForSelect.Text, StaticVariablesClass.SQLMaxRowForSelect);
            AppSettingsClass.Instance.SQLVariables.SingleLineComment = txtSQLSingleLineCommand.Text;
            AppSettingsClass.Instance.SQLVariables.AlternativeTerminator = txtSQLAlternativeTerminator.Text;
            AppSettingsClass.Instance.SQLVariables.InitialTerminator = txtSQLInitialTerminator.Text;
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
