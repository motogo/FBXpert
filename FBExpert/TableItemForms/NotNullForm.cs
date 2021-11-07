using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class NotNullForm : IEditForm
    {
        private DBRegistrationClass _dbReg = null;
        private int messages_count = 0;
        private int error_count = 0;
        private NotifiesClass _localNotify = new NotifiesClass();
        private AutocompleteClass ac = null;

        private ContextMenuStrip Cm =null;
        private ContextMenuStrip CmGroup =null;
        private NotNullsClass NotNullObject = null;
        private List<TableClass> _tables = new List<TableClass>();
        private TableClass OrgTable = null;
        private string initialConstraintName = String.Empty;
        public NotNullForm(Form parent,  DBRegistrationClass dbReg,List<TableClass> tables , NotNullsClass notnullObject, ContextMenuStrip cmGroup, ContextMenuStrip cm)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
            _dbReg = dbReg;
            _tables = tables;
            Cm = cm;
            CmGroup = cmGroup;
           
            if(notnullObject == null)
            {
                NotNullObject = new NotNullsClass
                {
                    Name = "NEW_CNSTR",
                    ConstraintType = eConstraintType.NOTNULL
                };
                initialConstraintName = string.Empty;
            }
            else
            {
               
                NotNullObject = notnullObject;
                initialConstraintName = notnullObject.Name;
            }
            OrgTable = tables.Find(X=>X.Name == notnullObject.TableName);
            NotNullObject.TableName = OrgTable.Name;
            
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
        }

        public void ShowCaptions()
        {
            lblTableName.Text = (NotNullObject != null) ? $@"NotNullConstraint: {NotNullObject.Name}" : "NotNullConstraint";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Manage Constraints");
        }

        public void SetControlSizes()
        {
            pnlFieldUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlMessagesUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlDependenciesUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlSQLUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlInfoUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }

        public void EditToData()
        {

        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0) sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            StringBuilder sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0) sb.Append($@"Errors ({error_count})");
            string errStr = AppStaticFunctionsClass.GetErrorCodeString(k.Meldung,_dbReg);
            fctMessages.AppendText($@"ERROR {errStr}");
            
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }



        bool InFieldList(string fieldName)
        {
            foreach(ListViewItem fld in lvFields.Items)
            {
                string fn = fld.SubItems[0].Text;
                if(fn == fieldName)
                {
                    return true;
                }
            }
            return false;
        }
        bool SetFieldText(string constraintName)
        {
            foreach (ListViewItem fld in lvFields.Items)
            {
                string cn = fld.SubItems[1].Text;
                if (cn == constraintName)
                {
                    cbFields.Text = fld.SubItems[0].Text;
                    return true;
                }
            }
            cbFields.SelectedIndex = -1;
            return false;
        }

        bool SetConstraintText(string FieldName)
        {
            foreach (ListViewItem fld in lvFields.Items)
            {
                string cn = fld.SubItems[0].Text;
                if (cn == FieldName)
                {
                    txtConstraintName.Text = fld.SubItems[1].Text;
                    return true;
                }
            }
            txtConstraintName.Text = string.Empty;
            return false;
        }

        public void MakeSQL()
        {
            MakeSQOAlter();
            ShowCaptions();
        }

        bool DataFilled = false;

        public void GetFieldConstraintList(string TableName)
        {
            string cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableConstraintsByTableName(_dbReg.Version, eConstraintType.NOTNULL, TableName);
            DataFilled = false;

            try
            {
                lvFields.Items.Clear();
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(_dbReg));
                con.Open();
                string PkColumn = string.Empty;
                string IndexName = string.Empty;
                FbCommand fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                List<string> fields = new List<string>();
                if (dread.HasRows)
                {
                    while (dread.Read())
                    {
                         TableName = dread.GetValue(0).ToString().Trim();
                         string FieldName = dread.GetValue(6).ToString().Trim();
                         string[] st = new string[2];
                         st[0] = FieldName;
                         st[1] = TableName;
                         ListViewItem lvi = new ListViewItem(st);
                         lvFields.Items.Add(lvi);
                    }
                    DataFilled = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(StaticFunctionsClass.DateTimeNowStr() + "->NotNullForm->RefreshConstraints()->" + ex.Message);
            }
        }

        public List<string> SQLScript = new List<string>();

        public void SQLToUI()
        {
            fctSQL.Clear();
            foreach (string str in SQLScript)
            {
                fctSQL.AppendText(str + Environment.NewLine);
            }
        }

        public void MakeSQOAlter()
        {           

            SQLScript.Clear();
            if (cbFields.Text.Length > 0)
            {
                if(InFieldList(cbFields.Text))
                {
                    SQLScript.Add($@"ALTER TABLE {cbTable.Text} ALTER {cbFields.Text} DROP NOT NULL;");
                    SQLScript.Add("COMMIT;");
                }
                //alter table Adventures add id int constraint IdNotNull not null //
                SQLScript.Add($@"ALTER TABLE {cbTable.Text} ALTER {cbFields.Text} SET NOT NULL;");
                SQLScript.Add("COMMIT;");
            }
            
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FillFields(TableClass tc)
        {
            cbFields.Items.Clear();
            cbFields.Items.AddRange(tc.Fields.Values.ToArray());
            lvFields.Items.Clear();
        }


        public void GetFieldConstraints()
        {
            foreach (string fn in NotNullObject.FieldNames.Values)
            {
                string[] st = new string[2];
                st[0] = fn;
                ListViewItem lvi = new ListViewItem(st);
                lvFields.Items.Add(lvi);
            }
        }
        public void DataToEdit()
        {
            cbTable.Items.Clear();
            cbTable.Items.AddRange(_tables.ToArray());

            cbTable.Text = NotNullObject.TableName;
            TableClass tc = cbTable.SelectedItem as TableClass;
            FillFields(tc);
            
            foreach (string fn in NotNullObject.FieldNames.Values)
            {
                string[] st = new string[2];
                st[0] = fn;
                ListViewItem lvi = new ListViewItem(st);
                lvFields.Items.Add(lvi);
            }

            
            DataFilled = true;
        }


        public void SetUIControls()
        {
            
        }

      
        
        private void NotNullForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            DataToEdit();
            txtConstraintName.Text = initialConstraintName;
            cbTable.Text = NotNullObject.TableName;
   
            GetFieldConstraintList(cbTable.Text);
            SetFieldText(txtConstraintName.Text);
            MakeSQL();
            SetAutocompeteObjects(_tables);
        }

        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddProcedureCommands();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);                        
            ac.Activate();
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (DataFilled)
                MakeSQL();
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
           
        }

        private void Create()
        {
            

            //var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, AppSettingsClass.Instance.SQLVariables.GetNewLine(), AppSettingsClass.Instance.SQLVariables.CommentStart, AppSettingsClass.Instance.SQLVariables.CommentEnd, AppSettingsClass.Instance.SQLVariables.SingleLineComment, "SCRIPT");
            var riList =_sql.ExecuteCommands(fctSQL.Lines); 
          
            var riFailure = riList.Find(x=>x.commandDone == false);                                    
            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);

            string info = (riFailure==null) 
                ? $@"NotNull {_dbReg.Alias}->Field:{cbFields.Text}->NOT NULL Constraint:{txtConstraintName.Text} updated." 
                : $@"NotNull {_dbReg.Alias}->Field:{cbFields.Text}->NOT NULL Constraint {txtConstraintName.Text} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadConstraits,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);
        }

        private void txtIndexName_TextChanged(object sender, EventArgs e)
        {
        
            if (DataFilled)
            {
                MakeSQL();
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableClass tc = cbTable.SelectedItem as TableClass;

            FillFields(tc);
            GetFieldConstraintList(tc.Name);

            cbFields.SelectedIndex = cbFields.Items.Count > 0 ? 0 : -1;

            SetConstraintText(cbFields.Text);
        

                if (DataFilled)
            {                
                MakeSQL();
            }
        }
        
        private void lvFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFields.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvFields.SelectedItems[0];

                cbFields.Text = lvi.SubItems[0].Text;
                txtConstraintName.Text = (InFieldList(cbFields.Text)) ? lvi.SubItems[1].Text : string.Empty;
            }
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

        void SelectFieldListEntry(string FieldName)
        {
            lvFields.SelectedItems.Clear();
            if (InFieldList(FieldName))
            {
                for (int i = 0; i < lvFields.Items.Count; i++)
                {
                    if (lvFields.Items[i].SubItems[0].Text == FieldName)
                    {
             
                        lvFields.Items[i].Selected = true;
                    }
                }
            }
        }
        private void cbFields_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetConstraintText(cbFields.Text);
            SelectFieldListEntry(cbFields.Text);
            MakeSQL();
        }
    }    
}
