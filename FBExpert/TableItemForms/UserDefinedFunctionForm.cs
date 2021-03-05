using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FormInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class UserDefinedFunctionForm : IEditForm
    {
        UserDefinedFunctionClass UserDefinedFunctionObject = null;
        UserDefinedFunctionClass OldUserDefinedFunctionObject = null;
        DBRegistrationClass _dbReg = null;
        AutocompleteClass ac = null;
        TreeNode Tn = null;
        ContextMenuStrip Cm = null;
        NotifiesClass _localNotify = new NotifiesClass();
        int messages_count = 0;
        int error_count = 0;
        
        public UserDefinedFunctionForm(Form parent, DBRegistrationClass dbReg, TreeNode tn, ContextMenuStrip cm,StateClasses.EditStateClass.eBearbeiten mode)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Cm = cm;
            Tn = tn;
            
            try
            {
                BearbeitenMode = mode;
               
                if(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert)
                {                    
                    UserDefinedFunctionObject = new UserDefinedFunctionClass();
                    UserDefinedFunctionObject.Name = "NEW_UserDefinedFunction";
                }
                else
                {
                    UserDefinedFunctionObject = (UserDefinedFunctionClass)tn.Tag;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            OldUserDefinedFunctionObject = (UserDefinedFunctionClass) UserDefinedFunctionObject.Clone();
                                   
            _dbReg = dbReg;
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
            
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = System.Drawing.Color.Blue;            
            fctMessages.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} INFO  {k.Meldung}");
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
           
            fctMessages.CurrentLineColor = System.Drawing.Color.Red;
            fctMessages.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} ERROR  {k.Meldung}");
            fctMessages.ScrollLeft();
        }

        public void MakeSQL()
        {                        
            SQLScript = StaticTreeClass.Instance().MakeSQLDeclareUserDefinedFunction(UserDefinedFunctionObject,OldUserDefinedFunctionObject,true);            
            SQLToUI(SQLScript);
            ShowCaptions();
           
        }

        

        public List<string> SQLScript = new List<string>();

        public void SQLToUI(List<string> SQLScript)
        {
            fctSQL.Clear();
            foreach (string str in SQLScript)
            {
               fctSQL.AppendText(str + Environment.NewLine);
            }
        }

        

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
           
        }

        public override void DataToEdit()
        {            
            for (int i = 0; i < UserDefinedFunctionObject.ParameterIn.Count; i++)
            {                
                var pc = UserDefinedFunctionObject.ParameterIn[i];
                string[] columns = { "IN",pc.Name,pc.RawType };
                var lvi = new ListViewItem(columns);               
                var pci = new ParameterListItem();
                pci.direction = eParameterTypDirection.din;
                pci.pc = pc;
                lvi.Tag = pci;              
            }

            for (int i = 0; i < UserDefinedFunctionObject.ParameterOut.Count; i++)
            {                
                var pc = UserDefinedFunctionObject.ParameterOut[i];
                string[] columns = {"OUT",pc.Name,pc.RawType };
                var lvi = new ListViewItem(columns);
                var pci = new ParameterListItem();
                pci.direction = eParameterTypDirection.dout;
                pci.pc = pc;
                lvi.Tag = pci;                              
            }
        }
        public void EditToData()
        {
            
        }
               
        private void UserDefinedFunctionForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            DataToEdit();
            SetEnables();            
            MakeSQL();
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForUserDefinedFunction();
        }

        public void ShowCaptions()
        {
            lblCaption.Text = (UserDefinedFunctionObject != null) ? $@"UserDefinedFunction:{UserDefinedFunctionObject.Name}" : "UserDefinedFunction";            
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit UserDefinedFunction");
        }
        
        private void Create()
        {
            //var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _dbReg.NewLine, _dbReg.CommentStart, _dbReg.CommentEnd, _dbReg.SingleLineComment, "SCRIPT");

            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone == false);

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);
            
            string info = (riFailure==null) 
                ? $@"Constraint {_dbReg.Alias}->{UserDefinedFunctionObject.Name} updated." 
                : $@"Constraint {_dbReg.Alias}->{UserDefinedFunctionObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadUserDefinedFunctions,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);     

            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;            
        }
        private void hsSave_Click(object sender, EventArgs e)
        {            
            Create();
        }
      
        private void hsNew_Click(object sender, EventArgs e)
        {
            UserDefinedFunctionObject = new UserDefinedFunctionClass();
            UserDefinedFunctionObject.Name = "NEW_UserDefinedFunction";
            var pc = new ParameterClass();
            pc.Name = "";
            pc.RawType = "INTEGER";
            pc.FieldType = "LONG";
            pc.TypeNumber = 8;
            pc.Length = 4;
            pc.Precision = 0;

            UserDefinedFunctionObject.ParameterOut.Add(pc);
            pc = new ParameterClass();
            
            pc.Name = "XX";
            pc.RawType = "INTEGER";
            pc.FieldType = "LONG";
            pc.TypeNumber = 8;
            pc.Length = 4;
            pc.Precision = 0;
            UserDefinedFunctionObject.ParameterIn.Add(pc);
            UserDefinedFunctionObject.Description = "";
            OldUserDefinedFunctionObject = (UserDefinedFunctionClass) UserDefinedFunctionObject.Clone();
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            DataToEdit();
            MakeSQL();
        }

        private void fctSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if (ac != null)
                {
                    ac.Show();
                }
                e.Handled = true;
            }
        }

        private void hsRunStatement_Click(object sender, EventArgs e)
        {
            //var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _dbReg.NewLine, _dbReg.CommentStart, _dbReg.CommentEnd, _dbReg.SingleLineComment, "SCRIPT");
            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone == false);      
            var riOk = riList.Find(x=>x.commandDone == true);
            long costs = AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);
            
            var sb = new StringBuilder();
            if(riFailure != null)
            {                
                messages_count++;
                if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
                if (error_count > 0)    sb.Append($@"Errors ({error_count})");           
            }
                                   
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();            
            lblUsedMs.Text = costs.ToString();
        }
    }
}
