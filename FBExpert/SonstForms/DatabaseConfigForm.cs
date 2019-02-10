using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageLibrary;
using StateClasses;
using System;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class DatabaseConfigForm : IEditForm
    {
        DBRegistrationClass _dbReg = null;
       
        public DatabaseConfigForm(Form parent, DBRegistrationClass reg)
        {
            InitializeComponent();
            this.MdiParent = parent;

            if (reg == null)
            {
                _dbReg = new DBRegistrationClass();
            }
            else
            {
                _dbReg = reg;
            }
                      
        }

        public void SetBearbeitenMode(EditStateClass.eBearbeiten bea)
        {
            BearbeitenMode = bea;
        }

        public static void RefreshCharacterSets(string cn_name)
        {
            string cmd0 = "SELECT RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME FROM RDB$CHARACTER_SETS";
           
            string cmd = cmd0 + ";";

            ConnectionClass cc = ConnectionPoolClass.Instance().GetConnection(cn_name);
            cc.ShowExceptionMode = MessageLibrary.ShowError.no;
            DbDataReader dr = cc.ExecuteQuery(cmd, false);
            if (dr != null)
            {                
                if (cc.HasRows())
                {
                    int n = 0;
                    while (cc.Read())
                    {                        
                        string cset = cc.GetValue(0).ToString().Trim();                        
                        n++;
                    }                    
                }
                cc.CloseConnection();
            }            
        }

        
        public void SetNotifyEvent(NotifiesList nofifyInf)
        {
            
        }
        public void EditToData()
        {
            _dbReg.Alias = txtDatabaseAlias.Text;
           // DBReg.Charset = cbCharSet.Text;
            _dbReg.CharSet = cbCharSet.Text;
            _dbReg.Collation = cbCollation.Text;
            _dbReg.PacketSize = StaticFunctionsClass.ToIntDef(txtPacketsize.Text, 0);
            _dbReg.Password = txtPassword.Text;
            _dbReg.User = txtUser.Text;

            if(rb25_32.Checked) _dbReg.Version = eDBVersion.FB25_32;
            else if(rb25_64.Checked) _dbReg.Version = eDBVersion.FB25_64;
            else if(rb3_32.Checked) _dbReg.Version = eDBVersion.FB3_32;
            else if(rb3_64.Checked) _dbReg.Version = eDBVersion.FB3_64;
            else if(rb4_32.Checked) _dbReg.Version = eDBVersion.FB4_32;
            else if(rb4_64.Checked) _dbReg.Version = eDBVersion.FB4_64;

            
            _dbReg.FirebirdBinaryPath = txtFirebirdBinaryPath.Text;
            SetServerDatas();

           // DBReg.Server = txtServer.Text;            
            _dbReg.Port = StaticFunctionsClass.ToIntDef(txtPort.Text,3050);
            _dbReg.Role = txtRole.Text;
            _dbReg.DatabasePath = txtLocation.Text;
            
            _dbReg.Pooling = cbPooling.Checked;
            _dbReg.MaxPoolSize = StaticFunctionsClass.ToIntDef(txtMaxPoolSize.Text, 15);
            _dbReg.MinPoolSize = StaticFunctionsClass.ToIntDef(txtMinPoolSize.Text, 0);
            _dbReg.ConnectionLifetime = StaticFunctionsClass.ToIntDef(txtConnectionLifetime.Text, 0);
            _dbReg.InitialScriptingPath = txtDefaultScriptPath.Text;
            _dbReg.InitialReportPath = txtDefaultReportPath.Text;
            _dbReg.InitialTerminator = ";";
            _dbReg.AlternativeTerminator = txtAlternativeSetTermCharacter.Text;
            _dbReg.SkipForSelect = StaticFunctionsClass.ToLongDef(txtSkipForSelect.Text, 1000);
            _dbReg.MaxRowsForSelect = StaticFunctionsClass.ToLongDef(txtTableMaxRows.Text, 0);
            _dbReg.ClientLibrary = txtClientLibrary.Text;
            if(rbGenerateDBGenerator.Checked)
            {             
                _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.GeneratorInteger;
            }
            else if(rbGenerateGUID.Checked)
            {             
                _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.GUID;
            }
            else if(rbGenerateUUID.Checked)
            {             
                _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.UUID;
            }
            else if(rbGenerateHEXGUID.Checked)
            {             
                _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.HEXGUID;
            }

            _dbReg.CodeSettings.SourceCodeNamespace = txtDBNamespace.Text;
            _dbReg.CodeSettings.SourceCodeOutputPath = txtSourcecodeOutputPath.Text;
        }

        public void SetServerDatas()
        {
            if (rbEmbedded.Checked)
            {
                //_dbReg.ServerType = eConnectionType.embedded;
                _dbReg.Server = "";
                _dbReg.ConnectionType = eConnectionType.embedded;
            }
            else if (rbRemote.Checked)
            {
                //_dbReg.ServerType = eConnectionType.remote;
                _dbReg.Server = txtServer.Text;
                _dbReg.ConnectionType = eConnectionType.server;
            }
            else
            {
                //_dbReg.ServerType = eConnectionType.local;
                _dbReg.Server = "localhost";
                _dbReg.ConnectionType = eConnectionType.localhost;
            }
        }

        bool DoEvent = true;

        public override void DataToEdit()
        {
            DoEvent = false;
            txtLocation.Text = _dbReg.DatabasePath;           
            txtServer.Text = _dbReg.Server;
            if(_dbReg.Version == eDBVersion.FB25_32) rb25_32.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB25_64) rb25_64.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB3_32) rb3_32.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB3_64) rb3_64.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB4_32) rb4_32.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB4_64) rb4_64.Checked = true;
            
            txtFirebirdBinaryPath.Text = _dbReg.FirebirdBinaryPath;
            txtServer.Enabled = _dbReg.ConnectionType == eConnectionType.server;
            switch (_dbReg.ConnectionType)
            {
                case eConnectionType.server:
                    rbRemote.Checked = true;
                    
                    break;
                case eConnectionType.localhost:
                    rbLocal.Checked = true;
                    
                    break;
                default:
                    rbEmbedded.Checked = true;
                    
                    break;
            }
            
            cbCharSet.SelectedIndex   = cbCharSet.FindString(_dbReg.CharSet);
            cbCollation.SelectedIndex = cbCollation.FindString(_dbReg.Collation);

            txtPacketsize.Text          = _dbReg.PacketSize.ToString();
            txtPort.Text                = _dbReg.Port.ToString();
            txtUser.Text                = _dbReg.User;
            txtPassword.Text            = _dbReg.Password;
            txtDatabaseAlias.Text       = _dbReg.Alias;
            txtRole.Text                = _dbReg.Role;
            txtMaxPoolSize.Text         = _dbReg.MaxPoolSize.ToString();
            txtMinPoolSize.Text         = _dbReg.MinPoolSize.ToString();
            txtConnectionLifetime.Text  = _dbReg.ConnectionLifetime.ToString();
            
            cbPooling.Checked                   = _dbReg.Pooling;
            txtClientLibrary.Text               = _dbReg.ClientLibrary;
            txtAlternativeSetTermCharacter.Text = _dbReg.AlternativeTerminator;
            
            txtDefaultScriptPath.Text =  _dbReg.InitialScriptingPath;          
            txtDefaultReportPath.Text = _dbReg.InitialReportPath;

            txtSkipForSelect.Text = _dbReg.SkipForSelect.ToString();
            txtTableMaxRows.Text  = _dbReg.MaxRowsForSelect.ToString();
           
            SetServerUIVisiblies();
            
            txtConnectionString.Text = ConnectionStrings.Instance().MakeConnectionString(_dbReg);
            if(_dbReg.CodeSettings == null) _dbReg.CodeSettings = new CodeSettingsClass();
            
            txtDBNamespace.Text = _dbReg.CodeSettings.SourceCodeNamespace;
            txtSourcecodeOutputPath.Text = _dbReg.CodeSettings.SourceCodeOutputPath;
          
            if(_dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.GeneratorInteger)  rbGenerateDBGenerator.Checked = true;
            else if(_dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.GUID)         rbGenerateGUID.Checked = true;
            else if(_dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.HEXGUID)      rbGenerateHEXGUID.Checked = true;
          
            DoEvent = true;
        }

        public void SaveConfig()
        {            
            _dbReg.State = eRegState.none;
            var tn = _dbReg.GetNode();
            tn.Text = _dbReg.Alias;
            if (BearbeitenMode == EditStateClass.eBearbeiten.eEdit)
            {
                var drc = DatabaseDefinitions.Instance().Databases.Find(x=>x.Position == _dbReg.Position);                
            }
            else
            {
                _dbReg.Position = DatabaseDefinitions.Instance().Databases.Count+1;
                DatabaseDefinitions.Instance().Databases.Add(_dbReg);
                DataToEdit();
            }

            DatabaseDefinitions.Instance().SerializeCurrent("User changed");

            _dbReg.State = Cloned ? eRegState.create : eRegState.update;

            BearbeitenMode = EditStateClass.eBearbeiten.eEdit;
            if (_connectionDataChanged)
            {                
                NotifiesClass.Instance().Notify.RaiseInfo($@"Configuration saved for {_dbReg.Alias}->Proc:{Name}->SaveConfig",  StaticVariablesClass.DatabaseConfigDataSaved,(object) _dbReg);
                DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo($@"{_dbReg.Alias}->Proc:{Name}->SaveConfig",  StaticVariablesClass.DatabaseConfigDataSaved,(object) _dbReg);                
                _connectionDataChanged = false;
            }

            if (_dataChanged)
            {
                tn.Text = _dbReg.Alias;
                _dataChanged = false;
            }

            if (Cloned) Close();
        }

        public void SetServerUIVisiblies()
        {
            switch (_dbReg.ConnectionType)
            {
                case eConnectionType.embedded:
                    rbEmbedded.Checked = true;
                    txtServer.Enabled = false;
                    
                    break;
                case eConnectionType.localhost:
                    rbLocal.Checked = true;
                    txtServer.Enabled = false;
                    
                    break;
                default:
                    rbRemote.Checked = true;
                    txtServer.Enabled = true;
                    
                    break;
            }
        }
        
        public void NewDataToEdit()
        {
            DoEvent = false;
            var dc = new DefaultConnectionClass();
            _dbReg = new DBRegistrationClass();

            dc.DatabasePath                 = $@"{Application.StartupPath}\temp\new_database.fdb";
            txtLocation.Text                = dc.DatabasePath;            
            txtServer.Text                  = dc.Server;
            cbCharSet.SelectedIndex         = cbCharSet.FindString(dc.CharSet);
            cbCharSet.SelectedIndex         = cbCollation.FindString(dc.Collation);
            txtPacketsize.Text              = dc.PacketSize.ToString();
            txtPort.Text                    = dc.Port.ToString();
            txtUser.Text                    = dc.User;
            txtPassword.Text                = dc.Password;
            txtDatabaseAlias.Text           = @"NEW_DATABASE";
            txtRole.Text                    = dc.Role;
            txtMaxPoolSize.Text             = dc.MaxPoolSize.ToString();
            txtMinPoolSize.Text             = dc.MinPoolSize.ToString();
            txtConnectionLifetime.Text      = dc.ConnectionLifetime.ToString();
            txtClientLibrary.Text           = dc.ClientLibrary;            
            cbPooling.Checked               = dc.Pooling;

            SetServerUIVisiblies();
            DoEvent = true;
        }
      
        public bool Cloned = false;
        private void DatabaseConfigForm_Load(object sender, EventArgs e)
        {  
            oldserver = _dbReg.Server;
            fbdPath.SelectedPath = $@"{Application.StartupPath}\{_dbReg.Version}\fbclient.dll";
            if(this.Left < DbExplorerForm.Instance().Width + 16) this.Left = DbExplorerForm.Instance().Width + 16;
            LanguageChanged();                
            ShowCaptions();

            if (BearbeitenMode == EditStateClass.eBearbeiten.eEdit)
            {
                DataToEdit();
                if (Cloned) BearbeitenMode = EditStateClass.eBearbeiten.eInsert;
            }
            else
            {                
                NewDataToEdit();
            }
        }

        private void LanguageChanged()
        {
            hsClose.ToolTipText = LanguageClass.Instance().GetString("CLOSE_FORM");    
            hsSave.Text = LanguageClass.Instance().GetString("UPDATE_CHANGES");    
        }


        public void ShowCaptions()
        {
            lblTableName.Text = $@"Database Config: {_dbReg.Alias}";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Database Config");
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            EditToData();
            SaveConfig();                     
        }
        

        private void dataChanged()
        {
            SetServerUIVisiblies();
            _dataChanged = true;
        }

        private bool _connectionDataChanged = false;
        private bool _dataChanged = false;
        private void connectionDataChanged()
        {           
            SetServerDatas();
            SetServerUIVisiblies();
            string connectionString = ConnectionStrings.Instance().MakeConnectionString(_dbReg);
            txtConnectionString.Text = connectionString;
            _connectionDataChanged = true;
        }

        
        private void hsConnect_Click(object sender, EventArgs e)
        {
            pnlConnectState.BackColor = System.Drawing.Color.Yellow;
            EditToData();            
            try
            {
                AppStaticFunctionsClass.GetLifetime(txtConnectionString.Text);
                pnlConnectState.BackColor = System.Drawing.Color.Green;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                pnlConnectState.BackColor = System.Drawing.Color.Red;
            }
        }

        private void hsLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.fdb";
            openFileDialog1.Filter = @"Firebird DB|*.fdb|All|*.*";
            openFileDialog1.Title =  LanguageClass.Instance().GetString("SELECT_DATABSE");

            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                txtLocation.Text = openFileDialog1.FileName;
            }
        }
        
        private void hsCreateDatabase_Click(object sender, EventArgs e)
        {
            var fi = new FileInfo(txtLocation.Text);
            
            if(fi.Exists)
            {
                object[] param = {$@"{txtServer.Text}:{txtLocation.Text}",Environment.NewLine};
                if(SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseExistsCaption","OverrideExistingDatabase", SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Asterisk, null, param)== SEDialogResult.Yes)                
                {
                    DBProviderSet.CreateDatabase(txtLocation.Text, txtServer.Text, txtUser.Text, txtPassword.Text,
                    StaticFunctionsClass.ToIntDef(txtPacketsize.Text,AppSettingsClass.Instance().DatabaseSettings.DefaultPacketSize), true, true);
                }
            }
            else
            {
                if (!fi.Directory.Exists) return;
                DBProviderSet.CreateDatabase(txtLocation.Text, txtServer.Text, txtUser.Text, txtPassword.Text,
                StaticFunctionsClass.ToIntDef(txtPacketsize.Text, AppSettingsClass.Instance().DatabaseSettings.DefaultPacketSize), true, true);
            }            
        }

        private void hsClone_Click(object sender, EventArgs e)
        {
            _dbReg = _dbReg.Clone();
            _dbReg.Alias = $@"{_dbReg.Alias}_clone{(DateTime.Now.Ticks/10000).ToString()}";
            DataToEdit();
            //txtDatabaseAlias.Text =  txtDatabaseAlias.Text + "_clone";
            BearbeitenMode = EditStateClass.eBearbeiten.eInsert;
            EditToData();
        }

        private void hsChangeFullPath_Click(object sender, EventArgs e)
        {
            txtLocation.Text = DBStaticData.IsFullPath(txtLocation.Text) ? DBStaticData.ChangeToShortPath(txtLocation.Text) : DBStaticData.ChangeToFullPath(txtLocation.Text);
        }

        string oldserver = string.Empty;

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbLocal.Checked) return;
            txtServer.Text = "localhost";
            txtServer.Enabled = false;
            SetServerDatas();
            connectionDataChanged();
        }

        

        private void rbRemote_CheckedChanged(object sender, EventArgs e)
        {
            if ((!DoEvent) || (!rbRemote.Checked)) return;
            txtServer.Text = oldserver;
            txtServer.Enabled = true;
            SetServerDatas();
            connectionDataChanged();
        }

        private void rbEmbedded_CheckedChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            if (!rbEmbedded.Checked) return;
            txtServer.Enabled = false;
            txtServer.Text = "";
            SetServerDatas();
            connectionDataChanged();
        }
        
        private void txtPacketsize_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.PacketSize = StaticFunctionsClass.ToIntDef(txtPacketsize.Text, 0);
            connectionDataChanged();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.DatabasePath = txtLocation.Text;
            connectionDataChanged();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Server = txtServer.Text;
            SetServerDatas();
            connectionDataChanged();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.User = txtUser.Text;
            connectionDataChanged();
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Role = txtRole.Text;
            connectionDataChanged();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Port = StaticFunctionsClass.ToIntDef(txtPort.Text.Trim(), 3050);
            connectionDataChanged();
        }

        private void cbCharSet_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.CharSet = cbCharSet.Text;
            connectionDataChanged();
        }

        private void cbCollation_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Collation = cbCollation.Text;
            connectionDataChanged();
        }

        private void txtClientLibrary_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.ClientLibrary = txtClientLibrary.Text;
            connectionDataChanged();
        }

        private void cbPooling_CheckedChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Pooling = (cbPooling.Checked==true);
            connectionDataChanged();
        }

        private void txtMinPoolSize_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.MinPoolSize = StaticFunctionsClass.ToIntDef(txtMinPoolSize.Text.Trim(), 0);
            connectionDataChanged();
        }

        private void txtMaxPoolSize_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.MaxPoolSize = StaticFunctionsClass.ToIntDef(txtMaxPoolSize.Text.Trim(), 15);
            connectionDataChanged();
        }

        private void txtConnectionLifetime_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Lifetime = StaticFunctionsClass.ToIntDef(txtLifetime.Text.Trim(), 0);
            connectionDataChanged();
        }

        private void txtSkipForSelect_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.SkipForSelect = StaticFunctionsClass.ToIntDef(txtSkipForSelect.Text.Trim(), 1000);
        }

       

        private void txtAlternativeSetTermCHaracter_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.AlternativeTerminator = txtAlternativeSetTermCharacter.Text;
        }

        private void txtDefaultScriptPath_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.InitialScriptingPath = txtDefaultScriptPath.Text;
        }

        private void hsLoadClientLib_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.dll";
            openFileDialog1.Filter = "DLL|*.dll|All|*.*";
            openFileDialog1.Title = LanguageClass.Instance().GetString("CHOOSE_CLIENT_LIBRARY");
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            FileInfo fi = new FileInfo(openFileDialog1.FileName);
            txtClientLibrary.Text = fi.FullName;
        }

        private void hsClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void hsLoadDefaultScriptPath_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = _dbReg.InitialScriptingPath;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtDefaultScriptPath.Text = fbdPath.SelectedPath;
        }

        private void hsLoadDefaultReportPath_Click(object sender, EventArgs e)
        {            
            fbdPath.SelectedPath = _dbReg.InitialReportPath;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtDefaultReportPath.Text = fbdPath.SelectedPath;

        }

        private void dataChanged(object sender, EventArgs e)
        {
            dataChanged();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hsSourcecodeFolder_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = _dbReg.CodeSettings.SourceCodeOutputPath;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtSourcecodeOutputPath.Text = fbdPath.SelectedPath;
        }

        private void hsCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
