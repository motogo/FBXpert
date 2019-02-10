using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class TriggerForm : IEditForm
    {
        TriggerClass TriggerObject = null;
        TriggerClass OrgTriggerObject = null;
        DBRegistrationClass _dbReg = null;
        TreeNode Tn = null;
        ContextMenuStrip Cm = null;
        
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        int messages_count = 0;
        int error_count = 0;
        List<TableClass> _tables = null;
        public TriggerForm(Form parent, DBRegistrationClass drc, TreeNode tn, ContextMenuStrip cm, List<TableClass> tables)
        {
            FormEvents.DisableEvents(this,"TriggerForm");
            InitializeComponent();
            this.MdiParent = parent;
            Tn = tn;
            TriggerClass tc = (TriggerClass)tn.Tag;
            Cm = cm;
            _tables = tables;
            TriggerObject = tc;
            OrgTriggerObject = tc;
            _dbReg = drc;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append("Messages (" + (messages_count).ToString() + ") ");
            if (error_count > 0) sb.Append("Errors (" + (error_count).ToString() + ")");

            fctMessages.AppendText("INFO  " + k.Meldung);
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        public void MakeSQL()
        {          
            EditToData();
            bool ok =  (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit) ? MakeSQLAlter() : MakeSQLNew();            
            ShowCaptions();
        }

        public bool MakeSQLNew()
        {            
            string active = TriggerObject.Active ? "ACTIVE" : "DEACTIVE";
            string triggerTypeStr = EnumHelper.GetDescription(TriggerObject.Type); // StaticVariablesClass.GetTriggerTypeStr(TriggerObject.Type);

            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append($@"{SQLPatterns.SetTermStart}{Environment.NewLine}");
            sb.Append($@"CREATE TRIGGER {TriggerObject.Name} ");            
            sb.Append($@"FOR {TriggerObject.RelationName}");
            sb.Append($@"{Environment.NewLine}{active} ");
            sb.Append($@"{triggerTypeStr} ");
            sb.Append($@"POSITION {TriggerObject.Sequence}");
            sb.Append($@"{Environment.NewLine}{TriggerObject.Source}{Environment.NewLine}");
            sb.Append($@"^{Environment.NewLine}");
            sb.Append($@"{SQLPatterns.SetTermEnd}{Environment.NewLine}");
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}");
         
            SQLToUI();
            return true;
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

        public bool MakeSQLAlter()
        {           
            SQLScript.Clear();
            var sb = new StringBuilder();
            
            string active = OrgTriggerObject.Active ? "ACTIVE" : "DEACTIVE";
            string triggerTypeStr = EnumHelper.GetDescription(OrgTriggerObject.Type); //StaticVariablesClass.GetTriggerTypeStr(OrgTriggerObject.Type);
            
            SQLScript.Add($@"DROP TRIGGER {OrgTriggerObject.Name};");
            SQLScript.Add($@"{SQLPatterns.Commit}{Environment.NewLine}");
            sb.Append($@"SET TERM ^ ;{Environment.NewLine}");
            sb.Append($@"CREATE TRIGGER {TriggerObject.Name} ");            
            sb.Append($@"FOR {TriggerObject.RelationName}");
            sb.Append($@"{Environment.NewLine}{active} ");
            sb.Append($@"{triggerTypeStr} ");
            sb.Append($@"POSITION {TriggerObject.Sequence}");
            sb.Append($@"{Environment.NewLine}{TriggerObject.Source}{Environment.NewLine}");
            sb.Append($@"{SQLPatterns.ScriptTerminator}{Environment.NewLine}");
            sb.Append($@"{SQLPatterns.SetTermEnd}{Environment.NewLine}");
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            
            SQLToUI();
            return true;
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
            txtTriggerName.Enabled = (BearbeitenMode != StateClasses.EditStateClass.eBearbeiten.eEdit);            
        }
        
        public override void DataToEdit()
        {
            txtTriggerName.Text     = TriggerObject.Name;                       
            fctGenDescription.Text  = TriggerObject.Description;    
            cbIsActive.Checked      = TriggerObject.Active;
            txtGenValue.Text        = TriggerObject.Sequence.ToString();
            cbTable.Text            = TriggerObject.RelationName.Trim();
            cbINSERT.Checked        = false;
            cbUPDATE.Checked        = false;
            cbDELETE.Checked        = false;

            switch(TriggerObject.Type)
            {
                case eTriggerType.beforeInsert :                    rbBEFORE.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    break;
                case eTriggerType.afterInsert  :                    rbAFTER.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    break;
                case eTriggerType.beforeUpdate :                    rbBEFORE.Checked = true;
                                                                    cbUPDATE.Checked = true;
                                                                    break;
                case eTriggerType.afterUpdate  :                    rbAFTER.Checked = true;
                                                                    cbUPDATE.Checked = true;
                                                                    break;
                case eTriggerType.beforeDelete :                    rbBEFORE.Checked = true;
                                                                    cbDELETE.Checked = true;
                                                                    break;
                case eTriggerType.afterDelete  :                    rbAFTER.Checked = true;
                                                                    cbDELETE.Checked = true;
                                                                    break;
                case eTriggerType.beforeInsertOrUpdate :            rbBEFORE.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    cbUPDATE.Checked = true;
                                                                    break;
                case eTriggerType.afterInsertOrUpdate  :            rbAFTER.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    cbUPDATE.Checked = true;
                                                                    break;
                case eTriggerType.beforeInsertOrDelete :            rbBEFORE.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    cbDELETE.Checked = true;
                                                                    break;
                case eTriggerType.afterInsertOrDelete  :            rbAFTER.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    cbDELETE.Checked = true;
                                                                    break;
                case eTriggerType.beforeInsertOrUpdateOrDelete :    rbBEFORE.Checked = true;
                                                                    cbDELETE.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    cbUPDATE.Checked = true;
                                                                    break;
                case eTriggerType.afterInsertOrUpdateOrDelete :     rbAFTER.Checked = true;
                                                                    cbDELETE.Checked = true;
                                                                    cbINSERT.Checked = true;
                                                                    cbUPDATE.Checked = true;
                                                                    break;

            }
        }

        

        public int RefreshDependenciesTo()
        {            
            string cmd_index0 = "SELECT RDB$DEPENDENCIES.RDB$FIELD_NAME as Field ,RDB$DEPENDENCIES.RDB$DEPENDENT_NAME as DepentTo,CASE RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE";
            string case0 = EnumClass.Instance().GetDependenciesTypeSQLCase() + " AS  DependentType FROM RDB$DEPENDENCIES";
            string cmd_index_where = "WHERE UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '" + TriggerObject.Name + "' AND RDB$DEPENDENCIES.RDB$FIELD_NAME IS NOT NULL";
            string cmd_index_order = "ORDER BY RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME";
            string cmd_index = cmd_index0 + " " + case0 + " " + cmd_index_where + " " + cmd_index_order + ";";

            dsDependenciesTo.Clear();
            dgvDependenciesTo.AutoGenerateColumns = true;
          
            try
            {
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsDependenciesTo);
                con.Close();
                dgvDependenciesTo.DataMember = "Table";
                return dsDependenciesTo.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
               _localNotify?.AddToERROR($@"{StaticFunctionsClass.DateTimeNowStr()}->TableManegeForm->RefreshDependenciesFrom->{ex.Message}");
            }
                      
            return 0;
        }

        
        private void TriggerForm_Load(object sender, EventArgs e)
        {           
            SetComboBox();
            DataToEdit();
            SetEnables();
           
            RefreshDependenciesTo();
            MakeSQL();
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForTriggers();
            FormEvents.ClearEvents(sender);
        }

        public void SetComboBox()
        {   
            cbTable.Items.Clear();
            cbTable.Items.AddRange(_tables.ToArray());            
        }

        public void ShowCaptions()
        {
            lblTableName.Text = (TriggerObject != null) ?  $@"Edit Trigger: {TriggerObject.Name}" : "Edit Trigger";            
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Trigger");
        }

        private void EditToData()
        {
            TriggerObject.Name = txtTriggerName.Text.Trim();
            TriggerObject.Active = cbIsActive.Checked;

            eTriggerType typ = eTriggerType.none;

            string temp = rbBEFORE.Checked ? "BEFORE" : "AFTER";
            if(cbINSERT.Checked)
            {
                typ = (rbBEFORE.Checked) ? eTriggerType.beforeInsert : eTriggerType.afterInsert;
            }
            if(cbUPDATE.Checked)
            {
                if(typ == eTriggerType.none)
                {
                   typ = (rbBEFORE.Checked) ? eTriggerType.beforeUpdate : eTriggerType.afterUpdate;
                }
                else
                {
                    typ = (rbBEFORE.Checked) ? eTriggerType.beforeInsertOrUpdate : eTriggerType.afterInsertOrUpdate;
                }
            }
            if(cbDELETE.Checked)
            {
                if(typ == eTriggerType.none)
                {
                    typ = (rbBEFORE.Checked) ? eTriggerType.beforeDelete : eTriggerType.afterDelete;
                }
                else if((typ == eTriggerType.beforeInsert)||(typ == eTriggerType.afterInsert))
                {
                    typ = (rbBEFORE.Checked) ? eTriggerType.beforeInsertOrDelete : eTriggerType.afterInsertOrDelete;
                }
                else if((typ == eTriggerType.beforeInsertOrUpdate)||(typ == eTriggerType.afterInsertOrUpdate))
                {
                    typ = (rbBEFORE.Checked) ? eTriggerType.beforeInsertOrUpdateOrDelete : eTriggerType.afterInsertOrUpdateOrDelete;
                }
            }
            
            TriggerObject.Type = typ;
            TriggerObject.Sequence = StaticFunctionsClass.ToIntDef(txtGenValue.Text,0);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            TextChanged();
        }

        private void TextChanged()
        {
            if(!FormEvents.IsActive(this,"TextChanged")) return;
            MakeSQL();
        }
        
        private void Create()
        {                          
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
                        
            string info = (riFailure==null) 
                ? $@"Trigger {_dbReg.Alias}->{TriggerObject.RelationName}->{TriggerObject.Name} updated." 
                : $@"Trigger {_dbReg.Alias}->{TriggerObject.RelationName}->{TriggerObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadTriggers,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);  

            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;
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

        private void hsCreate_Click(object sender, EventArgs e)
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

        private void fctGenDescription_Load(object sender, EventArgs e)
        {

        }

        private void fctSQL_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
           
        }
    }
}
