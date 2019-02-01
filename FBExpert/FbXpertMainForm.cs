using BasicClassLibrary;
using BasicForms;
using FBExpert;
using FBExpert.DataClasses;
using FBXDesigns;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SonstForms;
using FBXpert.SQLView;
using MessageLibrary;
using StateClasses;
using System;
using System.IO;
using System.Reflection;
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
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {
                _instance = new FbXpertMainForm();        
            }
            return (_instance);
        }

        private FbXpertMainForm()
        {
            InitializeComponent();
                        
            NotificationsForm.Instance().Init();
            NotifiesClass.Instance().Notify.OnRaiseInfoHandler += InfoRaised;
            NotifiesClass.Instance().Notify.OnRaiseErrorHandler += ErrorRaised;
            
            LanguageClass.Instance().OnRaiseLanguageChangedHandler += FBXpertMainForm_OnRaiseLanguageChangedHandler;
            NotificationsForm.Instance().SetMDIForm(this);
                                             
            string appfile = Application.StartupPath + "\\config\\AppSettings.json";
            if (File.Exists(appfile))
            {
                AppSettingsClass appset = fastJSON.JSON.ToObject(File.ReadAllText(appfile)) as AppSettingsClass;
                AppSettingsClass.Instance().Load(appset);
            }
            else
            {
                AppSettingsClass.Instance();                                
            }          
            NotifiesClass.Instance().InfoThreshold = eInfoLevel.normal;
           
            //(eInfoLevel) AppSettingsClass.Instance().BehavierSettings.DebugThreshold;
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
            //            frm.Show();
                        frm.WindowState = FormWindowState.Normal;
            //            frm.BringToFront();
                    }
                }
            }
            
            if(e.ClickedItem.Text.EndsWith("Copyright"))
            {
                CopyrightForm cp = CopyrightForm.Instance(this);
               
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
                var pc = new ProgressClockForm(this)
                {
                    X = 50,
                    Y = 200
                };
                pc.Show();                
            }
            else if (e.ClickedItem == tsmiDesign)
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
                var cfg = new DatabaseConfigForm(Instance(), ActRegistrationObject)
                {
                    Cloned = false
                };
                cfg.SetBearbeitenMode(EditStateClass.eBearbeiten.eEdit);
                cfg.Show();
            }
            else if(e.ClickedItem == tsmiGerman)
            {
                LanguageClass.Instance().ChangeLanguage(LanguageClass.German);                
            }
            else if (e.ClickedItem == tsmiEnglish)
            {
                LanguageClass.Instance().ChangeLanguage(LanguageClass.English);                
            }
            else if (e.ClickedItem == tsmiJapanese)
            {
                LanguageClass.Instance().ChangeLanguage(LanguageClass.Japanese);
            }
        }

        public void RefreshLanguage()
        {
            tsmiUtilities.Text = LanguageClass.Instance().GetString("UTILITIES");
            tsmiNotifications.Text = LanguageClass.Instance().GetString("NOTIFICATIONS") + @" (" +(_errors+_notifications).ToString()+@")";
            tsmiShowWindows.Text = LanguageClass.Instance().GetString("SHOWWINDOWS");            
            tsmiErrors.Text = LanguageClass.Instance().GetString("ERRORS")+ @" (" + (_errors).ToString() + @")";
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
            LanguageClass.Instance().InitFile(this,$@"{Application.StartupPath}\Languages\","Language",".","de");
            LanguageClass.Instance().OnRaiseLanguageExceptionHandler += FbXpertMainForm_OnRaiseLanguageExceptionHandler;
            LanguageClass.Instance().ChangeLanguage(LanguageClass.German);
            string vers = BasicClassLibrary.Globals.GetAppVersion(this);
            string appname = BasicClassLibrary.Globals.GetAppName(this);
            Text = $@"{appname} V {vers}";

            Application.DoEvents();
            var cf = FBXInfo.Instance();
            cf.MdiParent = this;
            cf.Show();
                                    
            _dbe = DbExplorerForm.Instance(this);
            if (_dbe.ReadDatabaseDefinition())
            {
                Application.DoEvents();
                NotifiesClass.Instance().InfoThreshold = eInfoLevel.normal;
                _dbe.SetCaption();
                _dbe.Show();
                _dbe.Enabled = false;
                _dbe.MakeDatabaseTree(false);
                _dbe.OpenActiveDatabases();
               if (NotificationsForm.Instance().Visible) NotificationsForm.Instance().Close();            
               NotifiesClass.Instance().InfoThreshold = eInfoLevel.few;
            }                                       
            DbExplorerForm.Instance().Enabled = true;
            LanguageClass.Instance().ChangeLanguage(LanguageClass.German);
        }

        private void FbXpertMainForm_OnRaiseLanguageExceptionHandler(object sender, LanguageExceptionEventArgs k)
        {
            Console.WriteLine(k);
        }

        public static bool FormOnClosing = false;
        private void FBXpertMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {       
            FormOnClosing = true;
            //CopyrightForm.Instance().Close();
            //DbExplorerForm.Instance().Close();
            DatabaseDefinitions.Instance().SerializeCurrent("Definition data changed");    
            LanguageClass.Instance().OnRaiseLanguageChangedHandler -= FBXpertMainForm_OnRaiseLanguageChangedHandler;
            Application.Exit();
        }

        private void testMToolStripMenuItem_Click(object sender, EventArgs e)
        {                       
            SEMessageBox.ShowMDIDialog(Instance(), "Error while opening database", "test", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation);            
        }
    }
}
