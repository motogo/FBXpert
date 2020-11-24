using BasicClassLibrary;
using BasicForms;
using FBExpert;
using FBExpert.DataClasses;
using FBXDesigns;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SonstForms;
using FBXpert.SQLView;
using MessageFormLibrary;
using SELanguage;
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
                _instance = new FbXpertMainForm($@"{Application.StartupPath}\config\AppSettings.json");        
            }
            */
            return (_instance);
        }
        
        public static FbXpertMainForm CreateInstance(string[] args)
        {
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {                
                _instance = (args.Length > 0) ? new FbXpertMainForm(args[0]) : new FbXpertMainForm($@"{Application.StartupPath}\config\AppSettings.json");             
            }
            
            return (_instance);
        }

        private FbXpertMainForm(string appSettingsFile)
        {
            InitializeComponent();
                        
            NotificationsForm.Instance().Init();
            NotifiesClass.Instance().Register4Info(InfoRaised);
            NotifiesClass.Instance().Register4Error(ErrorRaised);
            
            LanguageClass.Instance().RegisterChangeNotifiy(FBXpertMainForm_OnRaiseLanguageChangedHandler);
            NotificationsForm.Instance().SetMDIForm(this);

            string appfile = appSettingsFile;
            if (File.Exists(appfile))
            {
                AppSettingsClass appset = fastJSON.JSON.ToObject(File.ReadAllText(appfile)) as AppSettingsClass;
                appset.Path = appfile;
                AppSettingsClass.Instance().Load(appset);
            }
            else
            {
                AppSettingsClass.Instance();                                
            }          
            NotifiesClass.Instance().InfoGranularity = eMessageGranularity.normal;
           
            //(eMessageGranularity) AppSettingsClass.Instance().BehavierSettings.DebugThreshold;
        }

        private void FBXpertMainForm_OnRaiseLanguageChangedHandler(object sender, LanguageChangedEventArgs k)
        {
            RefreshLanguage();
        }
       
        void ErrorRaised(object sender, MessageEventArgs k)
        {
            _errors++;            
            tsmiNotifications.Text = LanguageClass.Instance().GetString("NOTIFICATIONS") + @" (" +(_errors+_notifications).ToString()+@")";
            tsmiErrors.Text = LanguageClass.Instance().GetString("ERRORS")+ @" (" + (_errors).ToString() + @")";
        }

        void InfoRaised(object sender, MessageEventArgs k)
        {            
            if (k.Key.ToString() == "CLEAR_NOTIFIES")
            {
                _notifications = 0;
            }
            else
            {
                _notifications++;
            }
            tsmiNotifications.Text = LanguageClass.Instance().GetString("NOTIFICATIONS") + @" (" + (_errors + _notifications).ToString() + @")";
            tsmiNotes.Text = LanguageClass.Instance().GetString("NOTES") + @" (" + (_notifications).ToString() + @")";
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
                cp.Left = FBXInfo.Instance().Left - 100;
                cp.Top = FBXInfo.Instance().Top-100;
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
                DatabaseDesignForm.Instance().SetParent(MdiParent);
                DatabaseDesignForm.Instance().Show();
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
                LanguageClass.Instance().ChangeLanguage(LanguageConsts.Deutsch);                
            }
            else if (e.ClickedItem == tsmiEnglish)
            {
                LanguageClass.Instance().ChangeLanguage(LanguageConsts.Englisch);                
            }
            else if (e.ClickedItem == tsmiJapanese)
            {
                LanguageClass.Instance().ChangeLanguage(LanguageConsts.Japanisch);
            }
        }

        public void RefreshLanguage()
        {
            tsmiUtilities.Text      = LanguageClass.Instance().GetString("UTILITIES");
            tsmiNotifications.Text  = $@"{LanguageClass.Instance().GetString("NOTIFICATIONS")} ({_errors+_notifications})";
            tsmiShowWindows.Text    = LanguageClass.Instance().GetString("SHOWWINDOWS");
            tsmiErrors.Text         = $@"{LanguageClass.Instance().GetString("ERRORS")} ({_errors})";
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
         //   LanguageClass.Instance().InitEmbedded(this,"FBXpert.Languages","Language","de");
            LanguageClass.Instance().InitFile(this.GetType().Assembly, $@"{Application.StartupPath}\Languages\","Language",".","de");
            LanguageClass.Instance().OnRaiseLanguageExceptionHandler += FbXpertMainForm_OnRaiseLanguageExceptionHandler;
            LanguageClass.Instance().ChangeLanguage(LanguageConsts.Deutsch);
            string test = LanguageClass.Instance().GetString("test");
            string vers = BasicClassLibrary.Globals.GetAppVersion(this);
            string appname = BasicClassLibrary.Globals.GetAppName(this);
            this.Text = $@"{appname} V {vers}";

            Application.DoEvents();
            var cf = FBXInfo.Instance();
            cf.MdiParent = this;
            cf.Show();
                                    
            _dbe = DbExplorerForm.Instance(this);
            if (_dbe.ReadDatabaseDefinition())
            {
                Application.DoEvents();
                NotifiesClass.Instance().InfoGranularity = eMessageGranularity.normal;
                _dbe.SetCaption();
                _dbe.Show();
                _dbe.Enabled = false;
                _dbe.MakeDatabaseTree(false);
                int n = DatabaseDefinitions.Instance().CountToOpen();
                if(n > DatabaseDefinitions.Instance().OpenDatabaseCount)
                { 
                    object[] p = { n, Environment.NewLine };
                    if (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "OpenDatabases", "DoYouWantOpenDatabases", FormStartPosition.CenterScreen,
                            SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation, null, p) == SEDialogResult.Yes)
                    {
                        _dbe.OpenActiveDatabases();
                    }
                    else
                    {
                        DatabaseDefinitions.Instance().DataState = EditStateClass.eDataState.UnSaved;
                        DatabaseDefinitions.Instance().MarkDatabasesActiv(false);
                    }
                }
                else
                {
                    _dbe.OpenActiveDatabases();
                }
                if (NotificationsForm.Instance().Visible) NotificationsForm.Instance().Close();            
                NotifiesClass.Instance().InfoGranularity = eMessageGranularity.few;
            }
            DbExplorerForm.Instance().Enabled = true;
            LanguageClass.Instance().ChangeLanguage(LanguageConsts.Deutsch);
            SEHotSpot.Controller.Instance().SetupKeyboardHooks(this);
            DbExplorerForm.Instance().Select();
        }

        private void FbXpertMainForm_OnRaiseLanguageExceptionHandler(object sender, LanguageExceptionEventArgs k)
        {
            Console.WriteLine(k);
        }

        public static bool FormOnClosing = false;
        private void FBXpertMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {       
            FormOnClosing = true;
            DatabaseDefinitions.Instance().SerializeCurrent("Definition data changed");    
            LanguageClass.Instance().UnRegisterChangeNotifiy(FBXpertMainForm_OnRaiseLanguageChangedHandler);
            Application.Exit();
        }

        private void testMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMessageBox.ShowMDIDialog(Instance(), "Error while opening database", "test", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation);            
        }
    }
}
