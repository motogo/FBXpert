﻿using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.MiscClasses;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageLibrary;
using StateClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FBXpert;
using FBXpert.Globals;
using FBXpert.SQLStatements;

namespace FBExpert
{
    public partial class DomainForm : IEditForm
    {
        DomainClass DomainObject = null;
        DomainClass OrgDomainObject = null;
        DBRegistrationClass _dbReg = null;
        AutocompleteClass ac = null;
        NotifiesClass _localNotify = new NotifiesClass();
        int messages_count = 0;
        int error_count = 0;
        TreeNode Tn = null;
        ContextMenuStrip Cm = null;

        public DomainForm(Form parent, DBRegistrationClass dbReg,  TreeNode tn, ContextMenuStrip cm)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = dbReg;
            DomainClass tc = (DomainClass)tn.Tag;     
            if(tc == null)
            {
                DomainObject = new DomainClass();
                DomainObject.Name = "NEW_DOMAIN";
                DomainObject.NotNull = false;
                DomainObject.FieldType = "INTEGER";
                DomainObject.CharSet = "NONE";
                DomainObject.Collate = "NONE";
                DomainObject.DefaultValue = string.Empty;
                DomainObject.Check = string.Empty;
            }
            else
            {
               DomainObject = tc;
            }
            if(!string.IsNullOrEmpty(DomainObject.DefaultValue))
            {
                Console.WriteLine();
            }
            OrgDomainObject = (DomainClass) DomainObject.Clone();
         
            Cm = cm;
            Tn = tn;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;
          
        }
        public DomainForm(Form parent, DBRegistrationClass dbReg,  DomainClass domainObject)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dbReg = dbReg;
            Cm = null;
            Tn = null;
            DomainObject = domainObject;
          
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

            fctMessages.AppendText($@"ERROR {k.Meldung}");
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
                fctSQL.AppendText(str + Environment.NewLine);
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

            if(cbNotNull.Checked)
            {
                sb.AppendLine($@"ALTER DOMAIN {txtName.Text} ADD CONSTRAINT CHECK (VALUE IS NOT NULL); /* adds not null flag to domain */");
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
                if(cbNotNull.Checked)
                {
                    sb.AppendLine($@"ALTER DOMAIN {txtName.Text} ADD CONSTRAINT CHECK ({txtCheck.Text}); /* adds not null flag to domain */");
                }
                sb.AppendLine($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }
            else if(cbNotNull.Checked != DomainObject.NotNull)
            {
                sb.AppendLine($@"ALTER DOMAIN {txtName.Text} DROP CONSTRAINT; /* drop check constraint */"); 
                if(cbNotNull.Checked)
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

        public EditStateClass.eAction GetLastActionState()
        {
            return EditStateClass.eAction.eNone;
        }

        public void SetBearbeitenMode(EditStateClass.eBearbeiten bea)
        {

        }

        public void SetDataBearbeitenMode(EditStateClass.eAction bea)
        {

        }

        private void ClearEdit()
        {            
            txtName.Text = "NEW_DOMAINNAME";
            cbTypes.Text = "INTEGER";
            txtCheck.Text = string.Empty;
            cbNotNull.Checked = false;
            txtDefault.Text = string.Empty;
            cbCharSet.Text = _dbReg.CharSet;
            cbCollate.Text = _dbReg.Collation;
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

        public override void DataToEdit()
        {            
            txtName.Text        = DomainObject.Name;                        
            fctDescription.Text = DomainObject.Description;
            SearchType();            
            txtLength.Text      = DomainObject.Length.ToString();
            txtDefault.Text     = DomainObject.DefaultValue.StartsWith("default") ? DomainObject.DefaultValue.Substring(7).Trim() : DomainObject.DefaultValue.Trim();
            cbCharSet.Text      = DomainObject.CharSet.Length > 0 ? DomainObject.CharSet : "NONE";
            cbCollate.Text      = DomainObject.Collate.Length > 0 ? DomainObject.Collate : "NONE";
            txtCheck.Text       = DomainObject.Check;
            cbNotNull.Checked   = DomainObject.NotNull;
            SetControlsEnabled();
            MakeSQL();
        }
        public void EditToData()
        {
            DomainObject.FieldType    = cbTypes.Text;
            DomainObject.Description  = fctDescription.Text;
            DomainObject.DefaultValue = txtDefault.Text;
            DomainObject.NotNull      = cbNotNull.Checked;
            DomainObject.CharSet      = cbCharSet.Text;
            DomainObject.Collate      = cbCollate.Text;            
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
           
        }

        
        private void Create()
        {
            //EditToData();
            //SQLStatementsClass.Instance().ExecuteCommands(fctSQL.Lines, _dbReg, true, localNotify);
                                                                              
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
            

            string info = (riFailure==null) 
                ? $@"Domain {_dbReg.Alias}->{DomainObject.Name} updated." 
                : $@"Domain {_dbReg.Alias}->{DomainObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadDomains,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);
            EditToData();
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
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
            SetCombo();
            DataToEdit();
            DataFilled = true;
            ShowCaptions();
            AddExcamples();
            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForDatabase();
           
        }

        public void AddExcamples()
        {
            fcbExamples.Text = string.Empty;
            fcbExamples.AppendText($@"CREATE DOMAIN <domainname> AS VARCHAR(2048) CHARACTER SET UTF8 COLLATE UTF8; /* creates domain */{Environment.NewLine}");
            fcbExamples.AppendText($@"ALTER DOMAIN domain <domainname> ADD CONSTRAINT CHECK (VALUE IS NOT NULLl); /* adds not null flag to domain */{Environment.NewLine}");
            fcbExamples.AppendText($@"ALTER DOMAIN <domainname> DROP CONSTRAINT; /* dorop check constraint */){Environment.NewLine}");
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
            cbNotNull.Enabled = (txtCheck.Text.Length > 0 );
            MakeSQL();
        }
    }
}
 