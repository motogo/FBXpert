using APPHelpLibrary;
using BasicClassLibrary;
using BasicForms;
using FBExpert;
using FBXDesigns;
using FBXpert.SonstForms;
using FBXpert.SQLView;
using FBXpertLib;
using Initialization;
using MessageFormLibrary;
using SELanguage;
using SEMessageBoxLibrary;
using StateClasses;
using System;
using System.IO;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class FbXpertMainForm
    {
        private DbExplorerForm _dbe;
        
        public DBRegistrationClass ActRegistrationObject = null;
        public TableClass ActTableObject = null;
        public FieldClass ActFieldObject = null;
        public TableFieldClass ActTableFieldObject = null;
        public ViewFieldClass ActViewFieldObject = null;
        public ViewClass ActViewObject = null;
        public RoleClass ActRoleObject = null;
        public ConstraintsClass ActConstraintsObject = null;
        public ForeignKeyClass ActForeignkeyObject = null;
        public DomainClass ActDomainObject = null;      
        public IndexClass ActIndexObject = null;
        public ProcedureClass ActProcedureObject = null;
        public TriggerClass ActTriggerObject = null;
        public GeneratorClass ActGeneratorObject = null;
        public FunctionClass ActFunctionObject = null;
        public eColorDesigns AppDesign = eColorDesigns.Gray;
        public eColorDesigns DevelopDesign = eColorDesigns.Gray;

        private int _errors;
        private int _notifications;

        private static FbXpertMainForm _instance;
        
        public static FbXpertMainForm Instance()
        {
            /*
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {
                _instance = new FbXpertMainForm($@"{ApplicationPathClass.Instance.ApplicationPath}\config\AppSettings.json");        
            }
            */
            return (_instance);
        }
        
        public static FbXpertMainForm CreateInstance(string[] args)
        {
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {                
                _instance = (args.Length > 0) ? new FbXpertMainForm(args[0]) : new FbXpertMainForm($@"{ApplicationPathClass.Instance.ApplicationPath}\config\AppSettings.json");             
            }
            
            return (_instance);
        }

        private FbXpertMainForm(string appSettingsFile)
        {
            InitializeComponent();
                        
            NotificationsForm.Instance().Init();
            NotifiesClass.Instance.Register4Info(InfoRaised);
            NotifiesClass.Instance.Register4Error(ErrorRaised);
            
            LanguageClass.Instance.RegisterChangeNotifiy(FBXpertMainForm_OnRaiseLanguageChangedHandler);
            NotificationsForm.Instance().SetMDIForm(this);
            //SEMessageBox.ShowDialog("#FBXpert", $@"#FbXpertMainForm", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation);
            string appfile = appSettingsFile;
            if (File.Exists(appfile))
            {
                //AppSettingsClass.Instance.GetSettings(appfile);
                try
                {
                    AppSettingsClass appset = fastJSON.JSON.ToObject(File.ReadAllText(appfile)) as AppSettingsClass;
                    appset.Path = appfile;
                    AppSettingsClass.Instance.Load(appset);
                }
                catch(Exception ex)
                {
                    if(SEMessageBox.ShowDialog( "#Load AppSettings", $@"#App Settings cannot be loaded, do you want to use default settings", FormStartPosition.CenterScreen, SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation) == SEDialogResult.Yes)
                    {
                        appfile = AppSettingsClass.Instance.SaveDefaultSettings();
                        
                        AppSettingsClass appset = fastJSON.JSON.ToObject(File.ReadAllText(appfile)) as AppSettingsClass;
                        appset.Path = appfile;
                        AppSettingsClass.Instance.Load(appset);
                    }

                }
            }
            else
            {
                AppSettingsClass.Instance.Path = appfile;
            }          
            NotifiesClass.Instance.InfoGranularity = eMessageGranularity.normal;
           
            //(eMessageGranularity) AppSettingsClass.Instance.BehavierSettings.DebugThreshold;
        }

        private void FBXpertMainForm_OnRaiseLanguageChangedHandler(object sender, LanguageChangedEventArgs k)
        {
            RefreshLanguage();
        }
       
        void ErrorRaised(object sender, MessageEventArgs k)
        {
            _errors++;            
            tsmiNotifications.Text  = $@"{LanguageClass.Instance.GetString("NOTIFICATIONS")} ({_errors+_notifications})";
            tsmiErrors.Text         = $@"{LanguageClass.Instance.GetString("ERRORS")} ({_errors})";
        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            _notifications = (k.Key.ToString() == StaticVariablesClass.ClearNotifies) ? 0 : _notifications++;
            tsmiNotifications.Text  = $@"{LanguageClass.Instance.GetString("NOTIFICATIONS")} ({_errors + _notifications})";
            tsmiNotes.Text          = $@"{LanguageClass.Instance.GetString("NOTES")} ({_notifications})";
        }
        
        public override void FormLoadFirst()
        {            
            base.FormLoadFirst();
            ClearDevelopDesign(DevelopDesign);
            AppDesign = SetDesign(AppDesign);
        }

        public override void FormLoadAgain()
        {
        }
        public override bool DataOK()
        {
            return true;
        }

        private void ShowDbExplorer()
        {
            _dbe = DbExplorerForm.Instance(this);
            _dbe.WindowState = FormWindowState.Normal;        
            _dbe.Show();
            _dbe.BringToFront();
        }     

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {       
            
            
            var v = this.MdiChildren;
            if(!e.ClickedItem.Text.EndsWith("Copyright"))
            {
                foreach(Form frm in v)
                {
                    if(e.ClickedItem.Text.EndsWith(frm.Text))
                    {            
                        frm.WindowState = FormWindowState.Normal;
                    }
                }
            }
            
            if(e.ClickedItem.Text.EndsWith("Copyright"))
            {
                var cp = CopyrightForm.Instance(this);
                cp.WindowState = FormWindowState.Normal;
                cp.Show();
                cp.Select();
                cp.Left = FBXInfo.Instance.Left - 100;
                cp.Top = FBXInfo.Instance.Top-100;
            }
            else if(e.ClickedItem == tsmiExit)
            {               
                Instance().Close();
            }            
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDesignEarth)
            {
                AppDesign = ReloadDesign(eColorDesigns.Earth);
                /*
                var pc = new ProgressClockForm(this)
                {
                    X = 50,
                    Y = 200
                };
                pc.Show();                
                */
            }
            else if (e.ClickedItem == tsmiDesignGray)
            {
                AppDesign = ReloadDesign(eColorDesigns.Gray);
            }
            else if (e.ClickedItem == tsmiAppSettings)
            {
                var af = new AppSettingsForm(this);
                af.Show();
            }
            else if (e.ClickedItem == tsmiDatabaseDesign)
            {
                DatabaseDesignForm.Instance.SetParent(MdiParent);
                DatabaseDesignForm.Instance.Show();
            }
            else if (e.ClickedItem == tsmiCreateUUID)
            {
                var uuid = new UUIDForm(MdiParent);
                uuid.Show();
            }
            else if (e.ClickedItem == tsmiScripting)
            {
                var dbReg = new DBRegistrationClass();
                var dbm = new ScriptingForm(dbReg);
                dbm.Show();
            }
            else if (e.ClickedItem == tsmiDatabasRegistration)
            {
                var cfg = new DatabaseConfigForm(Instance(), ActRegistrationObject, DbExplorerForm.Instance().GetTree(), DbExplorerForm.Instance().GetTree().Nodes.Count, EditStateClass.eBearbeiten.eEdit);                
                cfg.Show();
            }
            else if(e.ClickedItem == tsmiGerman)
            {
                LanguageClass.Instance.ChangeLanguage(LanguageConsts.Deutsch);                
            }
            else if (e.ClickedItem == tsmiEnglish)
            {
                LanguageClass.Instance.ChangeLanguage(LanguageConsts.Englisch);                
            }
            else if (e.ClickedItem == tsmiJapanese)
            {
                LanguageClass.Instance.ChangeLanguage(LanguageConsts.Japanisch);
            }
        }

        public void RefreshLanguage()
        {
            tsmiUtilities.Text      = LanguageClass.Instance.GetString("UTILITIES");
            tsmiNotifications.Text  = $@"{LanguageClass.Instance.GetString("NOTIFICATIONS")} ({_errors+_notifications})";
            tsmiShowWindows.Text    = LanguageClass.Instance.GetString("SHOWWINDOWS");
            tsmiErrors.Text         = $@"{LanguageClass.Instance.GetString("ERRORS")} ({_errors})";
            Refresh();
        }
        
        private void cmsNotifications_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiNotes)
            {
                NotificationsForm.Instance().SetMDIForm(this);
                int wdh = DbExplorerForm.Instance().Width + 16;
                NotificationsForm.Instance().SetLeft = wdh;    
                NotificationsForm.Instance().Set();
                NotificationsForm.Instance().Show();
            }
            else if (e.ClickedItem == tsmiErrors)
            {
                NotificationsForm.Instance().SetMDIForm(this);
                NotificationsForm.Instance().SetLeft = DbExplorerForm.Instance().Width + 16;
                NotificationsForm.Instance().Set();
                NotificationsForm.Instance().Show();
            }
        }        

        private void FBXpertMainForm_Load(object sender, EventArgs e)
        {
            //   LanguageClass.Instance.InitEmbedded(this,"FBXpert.Languages","Language","de");
            //SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#FBXpert", "#FBXpertMainForm_Load", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation);
            ProgramAttributes.Instance.Init(System.Reflection.Assembly.GetExecutingAssembly());
            LanguageClass.Instance.InitFile(this.GetType().Assembly, $@"{ApplicationPathClass.Instance.ApplicationPath}\Languages\","Language",".","de");
            LanguageClass.Instance.OnRaiseLanguageExceptionHandler += FbXpertMainForm_OnRaiseLanguageExceptionHandler;
            LanguageClass.Instance.ChangeLanguage(LanguageConsts.Deutsch);
            string test = LanguageClass.Instance.GetString("test");
            
            
            this.Text = $@"{ProgramAttributes.Instance.GetAppName()} V {ProgramAttributes.Instance.GetAppVersion()}";
            ApplicationHelp.Instance.Init(this, "FBXpert_de.chm");
            Application.DoEvents();
            
            FBXInfo.Instance.MdiParent = this;
            FBXInfo.Instance.Show();
                                    
            _dbe = DbExplorerForm.Instance(this);

            string pf = $@"{AppSettingsClass.Instance.PathSettings.DatabasesConfigPath}\{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}";
            bool dz = DatabaseDefinitions.Instance.Deserialize(pf);
            SetLastLoadedDefinition(pf);
            if (dz)
            {
                Application.DoEvents();
                NotifiesClass.Instance.InfoGranularity = eMessageGranularity.normal;
                _dbe.SetCaption();
                _dbe.Show();
                _dbe.Enabled = false;
                _dbe.MakeDatabaseTree(false);
                int n = DatabaseDefinitions.Instance.CountToOpen();
                if(n > AppSettingsClass.Instance.DatabaseSettings.OpenDatabaseCount)
                { 
                    object[] p = { n, Environment.NewLine };
                    if (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "OpenDatabases", "DoYouWantOpenDatabases", FormStartPosition.CenterScreen,
                            SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation, null, p) == SEDialogResult.Yes)
                    {
                        _dbe.OpenActiveDatabases();
                    }
                    else
                    {
                        DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
                        DatabaseDefinitions.Instance.MarkDatabasesActiv(false);
                    }
                }
                else
                {
                    _dbe.OpenActiveDatabases();
                }
                if (NotificationsForm.Instance().Visible) NotificationsForm.Instance().Close();            
                NotifiesClass.Instance.InfoGranularity = eMessageGranularity.few;
            }
            DbExplorerForm.Instance().Enabled = true;
            LanguageClass.Instance.ChangeLanguage(LanguageConsts.Deutsch);
            SEHotSpot.Controller.Instance.NewKeyboardHooks(this);
            DbExplorerForm.Instance().Select();
        }

        public void SetLastLoadedDefinition(string lld)
        {
           lblLastLoadedDefinition.Text = lld;
        }

        private void FbXpertMainForm_OnRaiseLanguageExceptionHandler(object sender, LanguageExceptionEventArgs k)
        {
            //Console.WriteLine(k);
        }

        public static bool FormOnClosing = false;
        private void FBXpertMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {       
            FormOnClosing = true;
            DatabaseDefinitions.Instance.SerializeCurrent("Definition data changed");
            LanguageClass.Instance.UnRegisterChangeNotifiy(FBXpertMainForm_OnRaiseLanguageChangedHandler);
            
          //  Application.Exit();
        }

        private void testMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm tf = new TestForm();
            tf.MdiParent = this;
            tf.Show();
        }

        private void cmsAbout_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiHelp)
            {
               
                ApplicationHelp.Instance.ShowHelp(1);
            }
        }

        private void FbXpertMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSettingsClass.Instance.SaveSettings(false);
        }
    }
}
