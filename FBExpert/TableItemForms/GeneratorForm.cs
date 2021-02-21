
using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class GeneratorForm : IEditForm
    {
        GeneratorClass GeneratorObject = null;
        DBRegistrationClass _dbReg = null;
        TreeNode Tn = null;
        ContextMenuStrip Cm = null;
        NotifiesClass _localNotify = new NotifiesClass();
        int messages_count = 0;
        int error_count = 0;
        
        public GeneratorForm(Form parent, DBRegistrationClass drc, TreeNode tn, ContextMenuStrip cm)
        {
            InitializeComponent();
            MdiParent = parent;
            Tn = tn;
            Cm = cm;
            var tc = (GeneratorClass)tn.Tag;
            
            GeneratorObject = tc;
            _dbReg = drc;
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count})");
            if (error_count > 0)    sb.Append($@"Errors   ({error_count})");

            fctMessages.AppendText($@"INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count})");
            if (error_count > 0)    sb.Append($@"Errors   ({error_count})");
            string errStr = AppStaticFunctionsClass.GetErrorCodeString(k.Meldung,_dbReg);
            fctMessages.AppendText($@"ERROR {errStr}");
            
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }
                       
        public void MakeSQL()
        {
            hsSave.Enabled = (txtGenName.Text.Length > 0);
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                MakeSQOAlter();
            }
            else
            {
                MakeSQLNew();
            }
            ShowCaptions();
        }

        public void ShowCaptions()
        {
            lblCaption.Text = (GeneratorObject != null) ? $@"Generator: {GeneratorObject.Name}" : "Generator";            
            Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Generator");
        }

        public void MakeSQLNew()
        {           
            SQLScript.Clear();
            
            string GenName = txtGenName.Text.Trim();
            
            if(!string.IsNullOrEmpty(GenName))
            {
                int? NewValue = StaticFunctionsClass.ToIntDef(txtGenNewValue.Text.Trim(), null);
                int? IncrementValue = StaticFunctionsClass.ToIntDef(txtIncrementValue.Text.Trim(), null);
                var sb = new StringBuilder();
                sb.Append($@"CREATE SEQUENCE {GenName};{Environment.NewLine}");
                if(NewValue !=null)
                {
                    string cmd = ((IncrementValue !=null ) &&(IncrementValue.Value > 0))
                        ?$@"ALTER SEQUENCE {txtGenName.Text.Trim()} RESTART WITH {NewValue.Value} INCREMENT BY {IncrementValue.Value};{Environment.NewLine}" 
                        :$@"ALTER SEQUENCE {txtGenName.Text.Trim()} RESTART WITH {NewValue.Value};{Environment.NewLine}";

                    sb.Append(cmd);
                }
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}"); 
                sb.Append($@"COMMENT ON GENERATOR {GenName} IS '{fctGenDescription.Text}';{Environment.NewLine}");
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}"); 
                SQLScript.Add(sb.ToString());            
            }
            else
            {
                SQLScript.Add("/* Generator name is not defined */");           
            }
            SQLToUI();
        }
        public void MakeSQOAlter()
        {
            SQLScript.Clear();
            
            int? NewValue = StaticFunctionsClass.ToIntDef(txtGenNewValue.Text.Trim(), null);
            int? IncrementValue = StaticFunctionsClass.ToIntDef(txtIncrementValue.Text.Trim(), null);
            
            if((NewValue != null)&&(!string.IsNullOrEmpty(txtGenName.Text)))
            {
                string cmd = ((IncrementValue !=null ) &&(IncrementValue.Value > 0))
                ?$@"ALTER SEQUENCE {txtGenName.Text.Trim()} RESTART WITH {NewValue.Value} INCREMENT BY {IncrementValue.Value};{Environment.NewLine}" 
                :$@"ALTER SEQUENCE {txtGenName.Text.Trim()} RESTART WITH {NewValue.Value};{Environment.NewLine}";
                var sb = new StringBuilder();
                sb.Append(cmd);
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}"); 
                sb.Append($@"COMMENT ON GENERATOR {txtGenName.Text.Trim()} IS '{fctGenDescription.Text}';{Environment.NewLine}");
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}"); 
                SQLScript.Add(sb.ToString());           
            }
            else
            {
                if(string.IsNullOrEmpty(txtGenName.Text)) SQLScript.Add("/* Generator name is not defined */{Environment.NewLine}");  
                if(NewValue != null)                      SQLScript.Add("/* NewValue is not defined */{Environment.NewLine}");           
            }
            SQLToUI();
        }

        public List<string> SQLScript = new List<string>();

        public void SQLToUI()
        {
            fctSQL.Clear();
            foreach (string str in SQLScript)
            {
               fctSQL.AppendText($@"{str}{Environment.NewLine}");
            }
        }
       
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
            //txtGenName.Enabled = txtGenInitValue.Enabled = (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit);            
        }

        public override void DataToEdit()
        {
            txtGenName.Text        = GeneratorObject.Name;
            txtGenValue.Text       = GeneratorObject.Value.ToString();
            txtGenNewValue.Text   = GeneratorObject.Value.ToString();
            fctGenDescription.Text = GeneratorObject.Description;            
        }

        public int RefreshDependenciesTo()
        {                                        
            string cmd = SQLStatementsClass.Instance().GetDepentenciesGenerators(_dbReg.Version, GeneratorObject.Name);
            try
            { 
                dsDependenciesTo.Clear();
                dgvDependenciesTo.AutoGenerateColumns = true;

                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                var ds = new FbDataAdapter(cmd, con);
                ds.Fill(dsDependenciesTo);
                con.Close();
                bsDependenciesTo.DataMember = "Table";
                return dsDependenciesTo.Tables[0].Rows.Count;

            }
            catch(Exception ex)
            {
                NotifiesClass.Instance().AddToERROR($@"{StaticFunctionsClass.DateTimeNowStr()} GeneratorForm -> RefreshDependenciesTo: {ex.Message}");
            }
            return 0;                       
        }
        
        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            DataToEdit();
            SetEnables();
            RefreshDependenciesTo();
            MakeSQL();
        }

        private void GeneratorTextChanged(object sender, EventArgs e)
        {
            MakeSQL();
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            MakeSQL();
        }
               
        private void Create()
        {           
           
            
            //var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _dbReg.NewLine, _dbReg.CommentStart, _dbReg.CommentEnd, _dbReg.SingleLineComment, "SCRIPT");
            var riList =_sql.ExecuteCommands(fctSQL.Lines); 
              
            var riFailure = riList.Find(x=>x.commandDone == false);

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);
            
            string info = (riFailure==null) 
                ? $@"Constraint {_dbReg.Alias}->{GeneratorObject.Name} updated." 
                : $@"Constraint {_dbReg.Alias}->{GeneratorObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadGenerators,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);  
        }
        private void hsExcecute_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if(saveSQLFile.ShowDialog() != DialogResult.OK) return;            
            fctSQL.SaveToFile(saveSQLFile.FileName,Encoding.UTF8);       
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if(ofdSQL.ShowDialog() != DialogResult.OK) return;            
            fctSQL.OpenFile(ofdSQL.FileName); 
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
        }
    }
}
