using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.Globals;
using FBXpert.SonstForms;
using FBXpertLib;
using FormInterfaces;
using Initialization;
using SEMessageBoxLibrary;
using StateClasses;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class DatabaseConfigForm : IEditForm
    {
        DBRegistrationClass _dbReg = null;
        private bool _connectionDataChanged = false;
        private bool _dataChanged = false;
        bool DoEvent = true;


        public DatabaseConfigForm(Form parent, DBRegistrationClass reg, TreeView aktTree, int aktPosition, EditStateClass.eBearbeiten bMode)
        {
            InitializeComponent();
            this.MdiParent = parent;
            if(reg == null)
            {
                //Insert neuer Knoten
                SetBearbeitenMode(EditStateClass.eBearbeiten.eInsert);
                _dbReg = reg;

                var newNode = new TreeNode();
                _dbReg.SetNode(newNode);
                aktTree.Nodes.Insert(aktPosition, newNode);                
                NewDataToEdit();                
            }
            else if(bMode == EditStateClass.eBearbeiten.eInsert)
            {
                //Neuer TreeKnoten als Cloned anfügen
                _dbReg = reg;

                var newNode = new TreeNode
                {
                    Name = "DATABASE"
                };
                _dbReg.SetNode(newNode);
                aktTree.Nodes.Insert(aktPosition, newNode);
                SetBearbeitenMode(bMode);                
                DataToEdit();                
            }            
            else
            {
                _dbReg = reg;
                SetBearbeitenMode(bMode);
                DataToEdit();
            }                      
        }

        public void SetBearbeitenMode(EditStateClass.eBearbeiten bea)
        {
            BearbeitenMode = bea;
        }
        /*
        public static void RefreshCharacterSets(string cn_name)
        {
            string cmd0 = "SELECT RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME FROM RDB$CHARACTER_SETS";
           
            string cmd = cmd0 + ";";

            ConnectionClass cc = ConnectionPoolClass.Instance.GetConnection(cn_name);
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
        */

       


        public void EditToData()
        {                       
            if(rb25_32.Checked) _dbReg.Version          = eDBVersion.FB25_32;
            else if(rb25_64.Checked) _dbReg.Version     = eDBVersion.FB25_64;
            else if(rb3_32.Checked) _dbReg.Version      = eDBVersion.FB3_32;
            else if(rb3_64.Checked) _dbReg.Version      = eDBVersion.FB3_64;
            else if(rb4_32.Checked) _dbReg.Version      = eDBVersion.FB4_32;
            else if(rb4_64.Checked) _dbReg.Version      = eDBVersion.FB4_64;

            _dbReg.Alias                                = txtDatabaseAlias.Text;
            _dbReg.CharSet                              = cbCharSet.Text;
            _dbReg.Collation                            = cbCollation.Text;
            _dbReg.PacketSize                           = (int)numPacketSize.Value;
            _dbReg.Password                             = txtPassword.Text;
            _dbReg.User                                 = txtUser.Text;
            _dbReg.SetFirebirdBinaryPath(txtFirebirdBinaryPath.Text);
            _dbReg.Port                                 = (int) numPort.Value;
            _dbReg.Role                                 = txtRole.Text;
            _dbReg.DatabasePath                         = txtLocation.Text;
            _dbReg.Pooling                              = cbPooling.Checked;
            _dbReg.MaxPoolSize                          = StaticFunctionsClass.ToIntDef(txtMaxPoolSize.Text, 15);
            _dbReg.MinPoolSize                          = StaticFunctionsClass.ToIntDef(txtMinPoolSize.Text, 0);
            _dbReg.ConnectionLifetime                   = StaticFunctionsClass.ToIntDef(txtConnectionLifetime.Text, 0);
            /*
            _dbReg.InitialScriptingPath                 = txtDefaultScriptPath.Text;
            _dbReg.InitialReportPath                    = txtDefaultReportPath.Text;
            _dbReg.InitialExportPath                    = txtDefaultExportPath.Text;
            _dbReg.InitialSQLExportPath                 = txtDefaultSQLExportPath.Text;
            _dbReg.InitialInfoPath                      = txtInfoPath.Text;
            
            _dbReg.InitialTerminator                    = ";";
            _dbReg.AlternativeTerminator                = txtAlternativeSetTermCharacter.Text;
            _dbReg.SkipForSelect                        = StaticFunctionsClass.ToLongDef(txtSkipForSelect.Text, 1000);
            _dbReg.MaxRowsForSelect                     = StaticFunctionsClass.ToLongDef(txtTableMaxRows.Text, 0);
            */
            _dbReg.ClientLibrary = txtClientLibrary.Text;
            _dbReg.CodeSettings.SourceCodeNamespace     = txtDBNamespace.Text;
            _dbReg.CodeSettings.SourceCodeOutputPath    = txtSourcecodeOutputPath.Text;
            SetServerDatas();

            if (rbGenerateDBGenerator.Checked)
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

           
        }

        public void SetServerDatas()
        {
            if (rbEmbedded.Checked)
            {                
                _dbReg.Server = "";
                _dbReg.ConnectionType = eConnectionType.embedded;
            }
            else if (rbRemote.Checked)
            {                
                _dbReg.Server = txtServer.Text;
                _dbReg.ConnectionType = eConnectionType.server;
            }
        }
        
        public void DataToEdit()
        {
            DoEvent = false;            
            if(_dbReg.Version == eDBVersion.FB25_32) rb25_32.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB25_64) rb25_64.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB3_32) rb3_32.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB3_64) rb3_64.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB4_32) rb4_32.Checked = true;
            else if(_dbReg.Version == eDBVersion.FB4_64) rb4_64.Checked = true;

            if (_dbReg.ConnectionType== eConnectionType.server) rbRemote.Checked = true;
            else rbEmbedded.Checked = true;

            txtConnectionString.Text = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            if (_dbReg.CodeSettings == null) _dbReg.CodeSettings = new CodeSettingsClass();

            if (_dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.GeneratorInteger) rbGenerateDBGenerator.Checked = true;
            else if (_dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.GUID) rbGenerateGUID.Checked = true;
            else if (_dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.HEXGUID) rbGenerateHEXGUID.Checked = true;


            GetClientLibraryAndBinPath();
            _dbReg.ClientLibrary = txtClientLibrary.Text;
            txtLocation.Text                    = _dbReg.DatabasePath;
            txtServer.Text                      = _dbReg.Server;
            //txtFirebirdBinaryPath.Text          = _dbReg._firebirdBinaryPath;            
            txtServer.Enabled                   = _dbReg.ConnectionType == eConnectionType.server;                        
            cbCharSet.SelectedIndex             = cbCharSet.FindString(_dbReg.CharSet);
            cbCollation.SelectedIndex           = cbCollation.FindString(_dbReg.Collation);
            numPacketSize.Value                 = _dbReg.PacketSize;
            numPort.Value                       = _dbReg.Port;
            txtUser.Text                        = _dbReg.User;
            txtPassword.Text                    = _dbReg.Password;
            txtDatabaseAlias.Text               = _dbReg.Alias;
            txtRole.Text                        = _dbReg.Role;
            txtMaxPoolSize.Text                 = _dbReg.MaxPoolSize.ToString();
            txtMinPoolSize.Text                 = _dbReg.MinPoolSize.ToString();
            txtConnectionLifetime.Text          = _dbReg.ConnectionLifetime.ToString();            
            cbPooling.Checked                   = _dbReg.Pooling;
            //txtClientLibrary.Text               = _dbReg.ClientLibrary;
            /*
            txtAlternativeSetTermCharacter.Text = _dbReg.AlternativeTerminator;  
            
            txtDefaultScriptPath.Text           = _dbReg.InitialScriptingPath;
            txtDefaultReportPath.Text           = _dbReg.InitialReportPath;
            txtInfoPath.Text                    = _dbReg.InitialInfoPath;
            
            txtDefaultSQLExportPath.Text        = _dbReg.InitialSQLExportPath;
            
            txtSkipForSelect.Text               = _dbReg.SkipForSelect.ToString();
            txtTableMaxRows.Text                = _dbReg.MaxRowsForSelect.ToString();
            */
            txtDBNamespace.Text                 = _dbReg.CodeSettings.SourceCodeNamespace;
            txtSourcecodeOutputPath.Text        = _dbReg.CodeSettings.SourceCodeOutputPath;
            //txtOpenDatabasesCount.Text          = DatabaseDefinitions.Instance.OpenDatabaseCount.ToString();
            SetServerUIVisiblies();
            connectionDataChanged();
            DoEvent = true;
        }

        

        public void SaveConfig()
        {            
            _dbReg.State = eRegState.none;
            var tn = _dbReg.GetNode();
            tn.Text = _dbReg.Alias;
            if (BearbeitenMode == EditStateClass.eBearbeiten.eEdit)
            {
                var drc = DatabaseDefinitions.Instance.Databases.Find(x=>x.Position == _dbReg.Position);
                _dbReg.State = eRegState.update;
            }
            else
            {
                _dbReg.Position = DatabaseDefinitions.Instance.Databases.Count+1;
                DatabaseDefinitions.Instance.Databases.Add(_dbReg);
                DataToEdit();
                _dbReg.State = eRegState.create;               
            }

            DatabaseDefinitions.Instance.SerializeCurrent("User changed");
           
            BearbeitenMode = EditStateClass.eBearbeiten.eEdit;
            if ((_connectionDataChanged) || (_dbReg.State != eRegState.update))
            {                
                NotifiesClass.Instance.Notify.RaiseInfo($@"Configuration saved for {_dbReg.Alias}->Proc:{Name}->SaveConfig",  StaticVariablesClass.DatabaseConfigDataSaved,(object) _dbReg);
                DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo($@"{_dbReg.Alias}->Proc:{Name}->SaveConfig",  StaticVariablesClass.DatabaseConfigDataSaved,(object) _dbReg);                
                _connectionDataChanged = false;
            }

            if (_dataChanged)
            {
                tn.Text = _dbReg.Alias;
                _dataChanged = false;
            }            
        }

        public void SetServerUIVisiblies()
        {
            switch (_dbReg.ConnectionType)
            {
                case eConnectionType.embedded:
                    rbEmbedded.Checked = true;
                    txtServer.Enabled = false;
                    
                    break;
              
                default:
                    rbRemote.Checked = true;
                    txtServer.Enabled = true;
                    
                    break;
            }

            gbDatabaseLocation.Text = $@"Database Location";
            try
            {
                FileInfo fi = new FileInfo(txtLocation.Text);
                if (fi.Exists)
                {
                    gbDatabaseLocation.Text = $@"Database Location {fi.Length/(1024*1024)} MB";
                }
            }
            catch
            {

            }

        }
        
        public void NewDataToEdit()
        {
            DoEvent = false;
            var dc = new DefaultConnectionClass();
            _dbReg = new DBRegistrationClass();

            dc.DatabasePath                 = $@"{ApplicationPathClass.Instance.ApplicationPath}\temp\new_database.fdb";
            txtLocation.Text                = dc.DatabasePath;            
            txtServer.Text                  = dc.Server;
            cbCharSet.SelectedIndex         = cbCharSet.FindString(dc.CharSet);
            cbCharSet.SelectedIndex         = cbCollation.FindString(dc.Collation);
            numPacketSize.Value             = (int) dc.PacketSize;
            numPort.Value                   = (int) dc.Port;
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

        public void SetControlSizes()
        {
           pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }

        private void DatabaseConfigForm_Load(object sender, EventArgs e)
        {  
            oldserver = _dbReg.Server;
            SetControlSizes();

            FormDesign.SetFormLeft(this);
            LanguageChanged();                
            ShowCaptions();
            GetClientLibraryAndBinPath();
            FileInfo fi = new FileInfo(_dbReg.DatabasePath);
            SetPasswordMark();
            txtCreateDatabaseLocationFile.Text = fi.Exists ? $@"{fi.DirectoryName}\{fi.Name.Replace(fi.Extension, $@"_new{fi.Extension}")}"  : "dbnew.fdb";
        }

        private void LanguageChanged()
        {
            hsClose.ToolTipText = LanguageClass.Instance.GetString("CLOSE_FORM");    
            hsSave.Text = LanguageClass.Instance.GetString("UPDATE_CHANGES");    
        }

        public void ShowCaptions()
        {
            lblFormName.Text = $@"Database Config: {_dbReg.Alias}";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Database Config");
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            EditToData();
            SaveConfig();    
            Close();
        }
        
        private void dataChanged()
        {
            SetServerUIVisiblies();
            _dataChanged = true;
        }
       
        private void connectionDataChanged()
        {           
            SetServerDatas();
            SetServerUIVisiblies();
            string connectionString = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            txtConnectionString.Text = connectionString;
            _connectionDataChanged = true;
        }

        private void hsConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {
            string _funcStr = "Connect()";
            pnlConnectState.BackColor = System.Drawing.Color.Yellow;
            Application.DoEvents();  
            string lfText = string.Empty;
            try
            {
                lfText = (rb25_32.Checked||rb25_64.Checked) 
                    ? AppStaticFunctionsClass.GetLifetime(txtConnectionString.Text, false) 
                    : AppStaticFunctionsClass.GetLifetime(txtConnectionString.Text,true);
                
                pnlConnectState.BackColor = System.Drawing.Color.Green;
            }
            catch(Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{ex.Message}->{_funcStr}", ex),_funcStr);
                lfText = "-1";
            }

            if(lfText == "-1")
            {
                pnlConnectState.BackColor = System.Drawing.Color.Red;
            }
            
            txtLifetime.Text = lfText;
        }

        private void hsLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt  = "*.fdb";
            openFileDialog1.Filter      = @"Firebird DB|*.fdb|All|*.*";
            openFileDialog1.Title       =  LanguageClass.Instance.GetString("SELECT_DATABASE");
            openFileDialog1.CheckFileExists = true;
            FileInfo fi = new FileInfo(txtLocation.Text);
            if (fi.Exists)
            {
                openFileDialog1.FileName = fi.Name;
            }
            if (fi.Directory.Exists)
            {
                
                openFileDialog1.InitialDirectory = fi.DirectoryName;
            }
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                txtLocation.Text = openFileDialog1.FileName;
            }
        }
        
        private void hsCreateDatabase_Click(object sender, EventArgs e)
        {
            var fi = new FileInfo(txtCreateDatabaseLocationFile.Text);
            bool ok = false;
            if(fi.Exists)
            {
                object[] param = {$@"{txtServer.Text}:{txtCreateDatabaseLocationFile.Text}",Environment.NewLine};
                if(SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseExistsCaption","OverrideExistingDatabase", SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Asterisk, null, param)== SEDialogResult.Yes)                
                {
                    ok = DBProviderSet.CreateDatabase(txtCreateDatabaseLocationFile.Text, txtServer.Text,(int) numPort.Value, txtUser.Text, txtPassword.Text, (int) numPacketSize.Value,txtClientLibrary.Text, true, true);
                }
            }
            else
            {
                if (!fi.Directory.Exists) return;
                ok = DBProviderSet.CreateDatabase(txtCreateDatabaseLocationFile.Text, txtServer.Text, (int)numPort.Value, txtUser.Text, txtPassword.Text, (int)numPacketSize.Value, txtClientLibrary.Text, true, true);
            }
            
            if(!ok)
            {
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseError", "DatabaseNotCreated", SEMessageBoxButtons.OK, SEMessageBoxIcon.Asterisk, null, null);               
            }
        }

        private void hsClone_Click(object sender, EventArgs e)
        {
            _dbReg = _dbReg.Clone();
            _dbReg.Alias = $@"{_dbReg.Alias}_clone{DateTimeFunctions.GetMSecondsFromNow()}";
            DataToEdit();
           
            BearbeitenMode = EditStateClass.eBearbeiten.eInsert;
            EditToData();
        }

        private void hsChangeFullPath_Click(object sender, EventArgs e)
        {
            txtLocation.Text = DBStaticData.IsFullPath(txtLocation.Text) ? DBStaticData.ChangeToShortPath(txtLocation.Text) : DBStaticData.ChangeToFullPath(txtLocation.Text);
        }

        string oldserver = string.Empty;
            
        private void rbRemote_CheckedChanged(object sender, EventArgs e)
        {
            if ((!DoEvent) || (!rbRemote.Checked)) return;
            txtServer.Text = string.IsNullOrEmpty(oldserver) ? "localhost" : oldserver;
            txtServer.Enabled = true;
            EditToData();
            SetServerDatas();
            connectionDataChanged();
        }

        private void rbEmbedded_CheckedChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            if (!rbEmbedded.Checked) return;
            txtServer.Enabled = false;
            oldserver = txtServer.Text;
            txtServer.Text = "";
            
            EditToData();
            SetServerDatas();
            connectionDataChanged();
        }
        
        private void txtPacketsize_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.PacketSize = (int) numPacketSize.Value;
            connectionDataChanged();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.DatabasePath = txtLocation.Text;
            gbDatabaseLocation.Text = $@"Database Location";
            try
            {
                FileInfo fi = new FileInfo(txtLocation.Text);
                if (fi.Exists)
                {
                    gbDatabaseLocation.Text = $@"Database Location {fi.Length}";
                }
            }
            catch
            {

            }
            
                
            
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
            _dbReg.Port = (int) numPort.Value;
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
            //_dbReg._clientLibrary = txtClientLibrary.Text;
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

        private void txtAlternativeSetTermCHaracter_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            AppSettingsClass.Instance.SQLVariables.AlternativeTerminator = txtAlternativeSetTermCharacter.Text;
        }

        private void hsLoadClientLib_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.dll";
            openFileDialog1.Filter = "DLL|*.dll|All|*.*";
            openFileDialog1.Title = LanguageClass.Instance.GetString("CHOOSE_CLIENT_LIBRARY");
            openFileDialog1.InitialDirectory = ApplicationPathClass.Instance.ApplicationPath;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            FileInfo fi = new FileInfo(openFileDialog1.FileName);
            txtClientLibrary.Text = fi.FullName;
        }

        private void hsClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void dataChanged(object sender, EventArgs e)
        {
            dataChanged();
        }
       
        private void hsSourcecodeFolder_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = _dbReg.CodeSettings.SourceCodeOutputPath;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtSourcecodeOutputPath.Text = fbdPath.SelectedPath;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvent) return;
            _dbReg.Password = txtPassword.Text;
            connectionDataChanged();
        }

        private void cbCharSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string charset = cbCharSet.Text;
            if(charset == "NONE")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("NONE");
            }
            else if (charset == "ASCII")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("ASCII");
            }
            else if (charset == "UTF8")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("UTF8");
                cbCollation.Items.Add("UNICODE");
                cbCollation.Items.Add("UNICODE_CI");
                cbCollation.Items.Add("UNICODE_CI_AI");
            }
            else if (charset == "ISO8859_1")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("ISO8859_1");
                cbCollation.Items.Add("DA_DA");
                
                cbCollation.Items.Add("DE_DE");
                cbCollation.Items.Add("DU_NL");
                cbCollation.Items.Add("EN_UK");
                cbCollation.Items.Add("EN_US");
                cbCollation.Items.Add("ES_ES");
                cbCollation.Items.Add("ES_ES_CI_AI");
                cbCollation.Items.Add("FI_FI");
                cbCollation.Items.Add("FR_CA");
                cbCollation.Items.Add("FR_FR");
                cbCollation.Items.Add("FR_FR_CI_AI");
                cbCollation.Items.Add("IS_IS");
                cbCollation.Items.Add("IT_IT");
                cbCollation.Items.Add("NO_NO");
                cbCollation.Items.Add("PT_PT");
                cbCollation.Items.Add("PT_BR");
                cbCollation.Items.Add("SV_SV");
            }
            else if (charset == "UNICODE_FSS")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("UNICODE_FSS");
            }
            else if (charset == "WIN1250")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("WIN1250");
            }
            else if (charset == "WIN1251")
            {
                cbCollation.Items.Clear();
                cbCollation.Items.Add("WIN1251");
                cbCollation.Items.Add("WIN1251_UA");
                cbCollation.Items.Add("PXW_CYRL");
            }

        }

       

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.fdb";
            openFileDialog1.Filter = @"Firebird DB|*.fdb|All|*.*";
            openFileDialog1.Title = LanguageClass.Instance.GetString("SELECT_DATABASE_NEW");
            openFileDialog1.CheckFileExists = false;

            FileInfo fi = new FileInfo(txtCreateDatabaseLocationFile.Text);
            if (fi.Exists)
            {
                openFileDialog1.FileName = fi.Name;
            }
            else
            {
                openFileDialog1.FileName = "NewDB.fdb";
            }
            if (fi.Directory.Exists)
            {
                openFileDialog1.InitialDirectory = fi.DirectoryName;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              txtCreateDatabaseLocationFile.Text = openFileDialog1.FileName;
            }
        }

        private void GetClientLibraryAndBinPath()
        {
            string clfolder = string.Empty;
            if(rb4_64.Checked)
            {
                clfolder = $@"FB4\X64";
            }
            else if(rb4_32.Checked)
            {
                clfolder = $@"FB4\X32";
            }
            else if (rb3_64.Checked)
            {
                clfolder = $@"FB3\X64";
            }
            else if (rb3_32.Checked)
            {
                clfolder = $@"FB3\X32";
            }
            else if (rb25_64.Checked)
            {
                clfolder = $@"FB25\X64";
            }
            else if (rb25_32.Checked)
            {
                clfolder = $@"FB25\X32";
            }
            FileInfo fi = new FileInfo($@"{ApplicationPathClass.Instance.ApplicationPath}\ClientLibraries\{clfolder}\fbclient.dll");
            DirectoryInfo di = new DirectoryInfo($@"{ApplicationPathClass.Instance.ApplicationPath}\ClientLibraries\{clfolder}");
            FileInfo fi_isql = new FileInfo($@"{ApplicationPathClass.Instance.ApplicationPath}\ClientLibraries\{clfolder}\isql.exe");
            txtClientLibrary.Text = $@"{ApplicationPathClass.Instance.ApplicationPath}\ClientLibraries\{clfolder}\fbclient.dll";
            txtClientLibrary.BackColor = (fi.Exists) ? SystemColors.Info : Color.Red;
            txtFirebirdBinaryPath.Text = $@"{ApplicationPathClass.Instance.ApplicationPath}\ClientLibraries\{clfolder}";
            txtFirebirdBinaryPath.BackColor = (di.Exists) ? SystemColors.Info : Color.Red;
            if (di.Exists)
            {
                txtFirebirdBinaryPath.BackColor = (fi_isql.Exists) ? SystemColors.Info : Color.Orange;
            }
        }

        private void dbVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (DoEvent)
            {
                GetClientLibraryAndBinPath();
                EditToData();
                connectionDataChanged();
            }
        }

        private void hsGlobalApplicationSettings_Click(object sender, EventArgs e)
        {
            var af = new AppSettingsForm( FbXpertMainForm.Instance());
            af.Show();
        }
        private void hsShowPassword_MarkedReached(object sender, SeControlsLib.MarkedEventArgs e)
        {
            SetPasswordMark();
        }
        private void SetPasswordMark()
        {
            if(hsShowPassword.IsMarked())
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
