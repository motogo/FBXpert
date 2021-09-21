using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using Initialization;
using MessageLibrary.SendMessages;
using SharedStorages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class EventsForm : IEditForm
    {
        DBRegistrationClass _dbReg = null;
        NotifiesClass _localNotify = new NotifiesClass();
        int messages_count = 0;
        int error_count = 0;
        FbRemoteEvent revent = null;
       
        public EventsForm(Form parent, DBRegistrationClass dbReg)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = dbReg;
           
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);

            string cn = ConnectionStrings.Instance.MakeConnectionString(dbReg);
            revent = new FbRemoteEvent(cn);                     
            revent.RemoteEventCounts += Revent_RemoteEventCounts;
        }

        public void RefreshLanguageText()
        {
            lblTableName.Text = LanguageClass.Instance.GetString("EVENTS_TRACKING");   
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, LanguageClass.Instance.GetString("EVENTS_TRACKING")); 
            hsSaveTRACKING.Text = LanguageClass.Instance.GetString("SAVE_TRACKING");
            hsLoadTRACKING.Text = LanguageClass.Instance.GetString("LOAD_TRACKING");
        }

        private void Revent_RemoteEventCounts(object sender, FbRemoteEventCountsEventArgs e)
        {
            fctSQL.AppendText($@"{Environment.NewLine}{StaticFunctionsClass.DateTimeNowStr()} Event occured ->{e.Name}->{e.Counts}");
        }

        public EventsForm(Form parent, DBRegistrationClass dbReg,  DomainClass domainObject)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = dbReg;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler  += Notify_OnRaiseInfoHandler;           
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");
            string errStr = AppStaticFunctionsClass.GetErrorCodeString(k.Meldung,_dbReg);
            fctMessages.AppendText($@"ERROR {errStr}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        public override void FormLoadFirst()
        {
            base.FormLoadFirst();
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
        }

        public override void FormLoadAgain()
        {
        }

        public string SharedName
        {
            get
            {
                return($@"{_dbReg.Alias.Replace(" ","_")}_{Name}");
            }
        }

        [Serializable]
        class MerkeWerte
        {           
            public string cbEventName;
        };

        private MerkeWerte _mw = new MerkeWerte();
        private readonly SharedStorage _ss = new SharedStorage();

        private void LoadUserDesign()
        {
            _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
            _ss.StorageName = SharedName;
            _ss.DestroyWhenDisposed = false;
            try
            {
                var mw2 = (MerkeWerte)_ss[SharedName];
                if (mw2 == null) return;
                _mw = mw2;
                cbEvents.Text = _mw.cbEventName;
            }
            catch (Exception ex)
            {                                                                                                              
                SendMessageClass.Instance.SendAllErrors($@"{SharedName}->LoadUserDesign()->{ex.Message}");
            }
        }

        private void SaveUserDesign()
        {
            if ((_mw != null) && (_ss != null))
            {     
                try
                {
                    _mw.cbEventName = cbEvents.Text;
                    _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
                    _ss.StorageName = SharedName;
                    _ss.AddOrUpdate(SharedName, _mw);
                }
                catch(Exception ex)
                {
                    SendMessageClass.Instance.SendAllErrors($@"{SharedName}->SaveUserDesign()->{ex.Message}");
                }
            }
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetCombo()
        {
           cbEvents.Items.Clear();
           foreach(TriggerClass tc in triggers.Values)
           {
                if(tc.Source.Contains("_EVENT"))
                {
                    //POST_EVENT 'new_user'; 
                    int inx1 = tc.Source.IndexOf("_EVENT")+6;
                    int inx2 = tc.Source.IndexOf(";",inx1);
                    string cmd = tc.Source.Substring(inx1,inx2-inx1).Trim().Replace("'","");
                    cbEvents.Items.Add(cmd);
                }
           }
           if(cbEvents.Items.Count > 0) cbEvents.SelectedIndex = 0;
        }

        public void DataToEdit()
        {     
        
        }
        
        public void EditToData()
        {

        }

        Dictionary<string,TriggerClass> triggers = null;

        private void EventsForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            triggers = StaticTreeClass.Instance().GetAllTriggerObjects(_dbReg);
            lvEvents.Items.Clear();
            SetCombo();
            LoadUserDesign();
            DataToEdit();
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
            RefreshLanguageText();
            Restart();
        }
        AutocompleteClass ac;
        public void SetAutocompeteObjects(List<TableClass> tables, List<SystemTableClass> systemtables, Dictionary<string,ViewClass> views)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.AddAutocompleteForSystemtables(systemtables);
            ac.AddAutocompleteForViews(views);
            ac.Activate();
        }
               
        private void fctSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if(ac != null) ac.Show();
                e.Handled = true;
            }
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            
            if(saveTRACKINGFile.ShowDialog() != DialogResult.OK) return;            
               fctSQL.SaveToFile(saveTRACKINGFile.FileName,Encoding.UTF8);       
               
            /*
               string cn = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
               FbConnection connection = new FbConnection(cn);
               connection.Open();


               DataTable metadataCollections = connection.GetSchema();
           metadataCollections.WriteXml("D:\\temp\\meta.xml");

            DataTable userTables = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });

            DataTable viewTables = connection.GetSchema("Views", new string[] { null, null, null, "VIEW" });
            DataTable procTables = connection.GetSchema("Procedures", new string[] { null, null, null, "PROCEDURE" });
            DataTable pTables = connection.GetSchema("P", new string[] { null, null, null, "PROCEDURES" });
            DataTable cTables = connection.GetSchema("Constraints", new string[] { null, null, null, "CONSTRAINT" });
            */
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if(ofdTRACKING.ShowDialog() != DialogResult.OK) return;            
            fctSQL.OpenFile(ofdTRACKING.FileName); 
        }

        private void hsAddField_Click(object sender, EventArgs e)
        {
            string[] cols = {cbEvents.Text};
            ListViewItem lvi = new ListViewItem(cols);
            lvEvents.Items.Add(lvi);
            Restart();
        }

        private void CancelTracking()
        {
            revent.CancelEvents();
            fctSQL.AppendText($@"{Environment.NewLine}{StaticFunctionsClass.DateTimeNowStr()} Event tracking stopped...{Environment.NewLine}");
        }
        private void Restart()
        {
            fctSQL.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} Event tracking stopped...{Environment.NewLine}");
            hsTracking.Marked = false;
            var events = new List<string>();
            foreach(ListViewItem lvi in lvEvents.Items)
            {
                if(string.IsNullOrEmpty(lvi.Text)) continue;
                events.Add(lvi.Text);
            }
            if(events.Count > 0)
            {
                revent.CancelEvents();
                revent.QueueEvents(events.ToArray());
                fctSQL.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} Event tracking restarted...{Environment.NewLine}");
                hsTracking.Marked = true;
            }
            else
            {
                fctSQL.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} No events will be tracked !!!{Environment.NewLine}");
            }
        }

        private void hsTracking_Click(object sender, EventArgs e)
        {
            if(hsTracking.Marked)
            {
                Restart();
            }
            else
            {
                CancelTracking();
            }
        }

        private void EventsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserDesign();
        }
    }
}
 