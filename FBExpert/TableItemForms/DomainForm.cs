using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using StateClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class DomainForm : IEditForm
    {
        DomainClass DomainObject = null;
        
        DBRegistrationClass _dbReg = null;
        AutocompleteClass ac = null;
        NotifiesClass _localNotify = new NotifiesClass();
        NotifiesClass _localTableNotify = new NotifiesClass();
        int messages_count = 0;
        int error_count = 0;
        TreeNode Tn = null;
        ContextMenuStrip Cm = null;
        List<TableClass> _tables = null;

        public DomainForm(Form parent, DBRegistrationClass dbReg, List<TableClass> tables, TreeNode tn, ContextMenuStrip cm)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = dbReg;
            _tables = tables;
            DomainClass tc = (DomainClass)tn.Tag;     
            if(tc == null)
            {
                DomainObject = new DomainClass();
                DomainObject.Name           = "NEW_DOMAIN";
                DomainObject.NotNull        = false;
                DomainObject.FieldType      = "INTEGER";
                DomainObject.CharSet        = "NONE";
                DomainObject.Collate        = "NONE";
                DomainObject.DefaultValue   = string.Empty;
                DomainObject.Check          = string.Empty;
            }
            else
            {
               DomainObject = tc;
            }

            
            Cm = cm;
            Tn = tn;
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
            _localTableNotify.Register4Info(TableInfoRaised);
        }
        public DomainForm(Form parent, DBRegistrationClass dbReg,  DomainClass domainObject)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = dbReg;
            Cm = null;
            Tn = null;
            DomainObject = domainObject;
            _localNotify.Register4Info(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
        }

        private void TableInfoRaised(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == "CHECK")
              txtCheck.Text = (string)k.Data;
            
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


        public void MakeSQL()
        {
            hsCreate.Enabled = (txtName.Text.Length > 0);
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
        public void SQLToUI()
        {
            fctSQL.Clear();
            foreach (string str in SQLScript)
            {
                fctSQL.AppendText($@"{str}{Environment.NewLine}");
            }
        }

       
        bool DataFilled = false;

        public void MakeSQLNew()
        {            
            SQLScript.Clear();
            cbCollate.Enabled = true;
            var sb = new StringBuilder();
           
            sb.Append($@"CREATE DOMAIN {txtName.Text} AS ");
            sb.Append($@"{StaticVariablesClass.CompleteRawType(cbTypes.Text.Trim(), StaticFunctionsClass.ToIntDef(txtLength.Text.Trim(), 0))}");
            if(cbCharSet.Enabled)
            {
                if (cbCharSet.Text != "NONE")
                {
                    sb.Append($@" CHARACTER SET {cbCharSet.Text}");
                }
            }
            if(cbCollate.Enabled)
            {
                if (cbCollate.Text != "NONE")
                {
                    sb.Append($@" COLLATE {cbCollate.Text}");
                }            
            }
            if (!string.IsNullOrEmpty(txtDefault.Text))
            {
                sb.Append($@" DEFAULT  '{txtDefault.Text}'");
            }

            sb.AppendLine($@";");
            sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");

            if(ckNotNullCheck.Checked)
            {                
                sb.AppendLine($@"ALTER DOMAIN {txtName.Text} ADD CONSTRAINT CHECK ({txtCheck}"); 
                sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }

            if (!string.IsNullOrEmpty(fctDescription.Text))
            {
                sb.AppendLine($@"COMMENT ON DOMAIN {txtName.Text} IS '{fctDescription.Text}';");
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }

            SQLScript.Add(sb.ToString());
            SQLToUI();
        }
        
        public void MakeSQOAlter()
        {
            SQLScript.Clear();
            cbCollate.Enabled = false;
            var sb = new StringBuilder();

            if (DomainObject.Name != txtName.Text)
            {
                sb.Append($@"ALTER DOMAIN {DomainObject.Name} TO {txtName.Text};");
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }
           
            sb.Append($@"ALTER DOMAIN {txtName.Text} TYPE {StaticVariablesClass.CompleteRawType(cbTypes.Text.Trim(), StaticFunctionsClass.ToIntDef(txtLength.Text.Trim(),0))}");   
            if(cbCharSet.Enabled)
            {
                if (cbCharSet.Text != "NONE")
                {
                    sb.Append($@" CHARACTER SET {cbCharSet.Text}");
                }
            }
            sb.AppendLine($@";");
            sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            
            if (txtDefault.Text != DomainObject._defaultValue)
            {
                string defstr = (cbTypes.Text.IndexOf("CHAR") >= 0)   ? $@"'{txtDefault.Text}'" : txtDefault.Text ;
                string cmd    = string.IsNullOrEmpty(txtDefault.Text) ? $@"ALTER DOMAIN {txtName.Text} SET DEFAULT NULL;" : $@"ALTER DOMAIN {txtName.Text} SET DEFAULT {defstr};";
                sb.AppendLine(cmd);                
                sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }

            if(txtCheck.Text.Length > 0)
            {
                sb.AppendLine($@"ALTER DOMAIN {txtName.Text} DROP CONSTRAINT; /* drop check constraint */"); 
                if(ckNotNullCheck.Checked)
                {
                    sb.AppendLine($@"ALTER DOMAIN {txtName.Text} ADD CONSTRAINT CHECK ({txtCheck.Text}); /* adds not null flag to domain */");
                }
                sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }
            else if(ckNotNullCheck.Checked == DomainObject.NotNull)
            {
                sb.AppendLine($@"ALTER DOMAIN {txtName.Text} DROP CONSTRAINT; /* drop check constraint */"); 
                if(ckNotNullCheck.Checked)
                {
                    sb.AppendLine($@"ALTER DOMAIN {txtName.Text} ADD CONSTRAINT CHECK (VALUE IS NOT NULL); /* adds not null flag to domain */");
                }
                sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }

            if (fctDescription.Text != DomainObject.Description)
            {
                sb.AppendLine($@"COMMENT ON DOMAIN {txtName.Text} IS '{fctDescription.Text}';");                
                sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }
                        
            SQLScript.Add(sb.ToString());
            SQLToUI();
        }


        public List<string> SQLScript = new List<string>();

        

        public void SetBearbeitenMode(EditStateClass.eBearbeiten bea)
        {

        }

        public void SetDataBearbeitenMode(EditStateClass.eAction bea)
        {

        }

        private void ClearEdit()
        {
            txtName.Text        = "NEW_DOMAINNAME";
            cbTypes.Text        = "INTEGER";
            txtCheck.Text       = string.Empty;
            ckNotNullCheck.Checked   = false;
            txtDefault.Text     = string.Empty;
            cbCharSet.Text      = _dbReg.CharSet;
            cbCollate.Text      = _dbReg.Collation;
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RefreshTypes()
        {
            cbTypes.Items.Clear();
                        
            DBTypeList dbList = new DBTypeList();
            foreach(DBDataTypes dt in dbList.Values)
            {
                cbTypes.Items.Add(dt);
            }

        }

        public void SearchType()
        {
            string rt = StaticVariablesClass.ConvertRawTypeToRawName(DomainObject.FieldType);
            int inx = cbTypes.FindStringExact(rt);
            cbTypes.SelectedIndex = inx;
            gbLength.Enabled = StaticVariablesClass.HasRawLength(cbTypes.Text.Trim());
        }

        public void SetCombo()
        {
            RefreshTypes();            
        }

        public void DataToEdit()
        {            
            txtName.Text        = DomainObject.Name;
            fctDescription.Text = DomainObject.Description;
            SearchType();
            txtLength.Text      = DomainObject.Length.ToString();
            txtDefault.Text     = DomainObject.DefaultValue.StartsWith("default") ? DomainObject.DefaultValue.Substring(7).Trim() : DomainObject.DefaultValue.Trim();
            cbCharSet.Text      = DomainObject.CharSet.Length > 0 ? DomainObject.CharSet : "NONE";
            cbCollate.Text      = DomainObject.Collate.Length > 0 ? DomainObject.Collate : "NONE";
            txtCheck.Text       = DomainObject.Check;
            ckNotNullCheck.Checked   = DomainObject.NotNull;
            SetControlsEnabled();
            MakeSQL();
        }
        public void EditToData()
        {
            DomainObject.FieldType    = cbTypes.Text;
            DomainObject.Description  = fctDescription.Text;
            DomainObject.DefaultValue = txtDefault.Text;
            DomainObject.NotNull      = ckNotNullCheck.Checked;
            DomainObject.CharSet      = cbCharSet.Text;
            DomainObject.Collate      = cbCollate.Text;
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
           
        }

        
        private void Create()
        {            
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, AppSettingsClass.Instance.SQLVariables.GetNewLine(), AppSettingsClass.Instance.SQLVariables.CommentStart, AppSettingsClass.Instance.SQLVariables.CommentEnd, AppSettingsClass.Instance.SQLVariables.SingleLineComment, "SCRIPT");

            var riList =_sql.ExecuteCommands(fctSQL.Lines);
            var riFailure = riList.Find(x=>x.commandDone == false);

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);

            string info = (riFailure==null) 
                ? $@"Domain {_dbReg.Alias}->{DomainObject.Name} updated." 
                : $@"Domain {_dbReg.Alias}->{DomainObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors";
                                            
            //DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadDomains,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);
            EditToData();
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(_dbReg));
            con.Open();
            foreach (string cmd in fctSQL.Lines)
            {
                FbCommand cmd1 = new FbCommand(cmd, con);
                cmd1.ExecuteNonQuery();
            }
            con.Close();
        }

        private void DomainForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            SetCombo();
            DataToEdit();
            DataFilled = true;
            ShowCaptions();
            AddExamples();
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
            SetAutocompeteObjects(_tables);
        }

        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.Activate();
        }

        public void AddExamples()
        {
            fcbExamples.Text = string.Empty;
            fcbExamples.AppendText($@"CREATE DOMAIN <domainname> AS VARCHAR(2048) CHARACTER SET UTF8 COLLATE UTF8; /* create domain */{Environment.NewLine}");
            fcbExamples.AppendText($@"ALTER DOMAIN domain <domainname> ADD CONSTRAINT CHECK (VALUE IS NOT NULLl); /* add not null flag to domain */{Environment.NewLine}");
            fcbExamples.AppendText($@"ALTER DOMAIN <domainname> DROP CONSTRAINT; /* drop check constraint */){Environment.NewLine}");
        }
        
        public void ShowCaptions()
        {
            lblTableName.Text = (DomainObject != null) ? $"Domain: {DomainObject.Name}" : "Domain";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Domain");
        }
                  
        public void SetNew()
        {
            SetBearbeitenMode(EditStateClass.eBearbeiten.eInsert);
            ClearEdit();                        
            txtName.Select();            
            MakeSQL();
        }

        private void hsAddDomain_Click(object sender, EventArgs e)
        {
            SetNew();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(!DataFilled) return;
            MakeSQL();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if(!DataFilled) return;
            MakeSQL();
        }

        public void SetControlsEnabled()
        {
            gbLength.Enabled = StaticVariablesClass.HasRawLength(cbTypes.Text.Trim());
            cbCharSet.Enabled = cbTypes.Text.IndexOf("CHAR") >= 0;
            cbCollate.Enabled = cbTypes.Text.IndexOf("CHAR") >= 0;
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            if(cbTypes.Text.IndexOf("CHAR") >= 0) 
            {
                cbCharSet.Text = _dbReg.CharSet;
                cbCollate.Text = _dbReg.Collation;
            }
            SetControlsEnabled();
            MakeSQL();
        }

        private void cbNotNull_CheckedChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();
        }

        private void fctDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            Create();
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

        private void txtDefault_TextChanged(object sender, EventArgs e)
        {
            if(!DataFilled) return;
            MakeSQL();  
        }

        private void cbCharSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();
        }

        private void cbCollate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();
        }

        private void txtCheck_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            ckNotNullCheck.Enabled = (txtCheck.Text.Length > 0 );
            MakeSQL();
        }

        private void hsSelectDefault_Click(object sender, EventArgs e)
        {
            
            SelectDefaultForm sd = new SelectDefaultForm(this.MdiParent, _localTableNotify, "CHECK", StaticVariablesClass.DefaultCheckVariables);
            sd.Show();
        }
    }
}
 