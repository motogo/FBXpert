using BasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using FBXpert.SQLStatements;

namespace FBExpert
{
    public partial class CreateNewTableForm : IEditForm
    {
        TableClass _tableObject = null;
        TableFieldClass _fieldObject = null;
        DBRegistrationClass _dbReg = null;
        NotifiesClass _localNotify = new NotifiesClass();
        NotifiesClass _localTableNotify = null;
        int _errorCount = 0;
        int _messagesCount = 0;       
        bool _dataFilled = false;
      
        public CreateNewTableForm(DBRegistrationClass dbReg, Form parent,  NotifiesClass lnotify)
        {
            InitializeComponent();
            MdiParent = parent;
            _dbReg = dbReg;
           
        
            _tableObject = new TableClass();
            _tableObject.Name = "NEW_TABLE";
            
            _fieldObject = new TableFieldClass();
            _fieldObject.Name = "ID";
            //_fieldObject.RawType = "INTEGER";
            _fieldObject.Domain.Name = "ID";
            _fieldObject.Domain.RawType = "INTEGER";
            _localTableNotify = lnotify;
                                    
            _dataFilled = false;
            DataToEdit();
            cbPrimaryKey.Enabled = true;
            _localTableNotify.Notify.OnRaiseInfoHandler += new NotifyInfos.RaiseNotifyHandler(TableInfoRaised);
            _localNotify.Notify.OnRaiseInfoHandler += new NotifyInfos.RaiseNotifyHandler(InfoRaised);
            _localNotify.Notify.OnRaiseErrorHandler += new NotifyInfos.RaiseNotifyHandler(ErrorRaised);
        }
      
        public override void  DataToEdit()
        {
            txtTableName.Text = _tableObject.Name;
            txtFieldName.Text = _fieldObject.Name;
            txtLength.Text    = _fieldObject.Domain.Length.ToString();            
        }

        private void ErrorRaised(object sender, MessageEventArgs k)
        {
            var tc = _tableObject;
            var sb = new StringBuilder();
            _errorCount++;
            if (_messagesCount > 0) sb.Append("Messages (" + (_messagesCount).ToString() + ") ");
            if (_errorCount > 0) sb.Append("Errors (" + (_errorCount).ToString() + ")");
                       
            fctMessages.AppendText("ERROR " + k.Meldung);
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void InfoRaised(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            _messagesCount++;
            if (_messagesCount > 0) sb.Append("Messages (" + (_messagesCount).ToString() + ") ");
            if (_errorCount > 0) sb.Append("Errors (" + (_errorCount).ToString() + ")");

            fctMessages.AppendText("INFO  " + k.Meldung);
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void TableInfoRaised(object sender, MessageEventArgs k)
        {
            if(k.Key.ToString() != "SELECT_DEFAULTS") return;            
            txtDefault.Text = (string) k.Data;                            
        }

        public void SetVisible()
        {
            int left = gbTypes.Left;
            bool varchar = (cbTypes.Text == "VARCHAR");
            bool numeric = (cbTypes.Text == ("NUMERIC") || (cbTypes.Text.StartsWith("DOUBLE")));
            bool zahl    = (cbTypes.Text == ("INTEGER") || (cbTypes.Text.StartsWith("SMALLINT")));
            
            gbTextProperties.Visible = ((varchar)|| (zahl));               
                        
            gbPrecisionProperties.Visible = numeric;
                       
            // DATE, TIMESTAMP
            gbPrecisionProperties.Visible = (numeric || varchar || zahl);
            gbTextProperties.Visible      = (numeric || varchar || zahl);
        }
     
        public void MakeSQL(bool force=false)
        {                       
            MakeSQLNew(force);                
            ShowCaptions();            
        }

        public bool IsSameType(TableFieldClass fo, string type, string fieldlength, string fieldprec, string fieldscale)
        {
            string st1 = GetTypeString(type, fieldlength, fieldprec, fieldscale);
            string st2 = GetTypeString(fo.Domain.RawType, fo.Domain.Length.ToString(), fo.Domain.Precision.ToString(), fo.Domain.Scale.ToString());
            return (st1 == st2);
        }

        public string GetTypeString(string type, string fieldlength, string fieldprec, string fieldscale )
        {
            var sb = new StringBuilder();
            if (type == "VARCHAR")
            {
                int length = StaticFunctionsClass.ToIntDef(fieldlength, 0);
                //int digits = StaticFunctionsClass.ToIntDef(txtScale.Text, 0);
                if (length > 0)
                {
                    sb.Append($@"VARCHAR({length})");
                }
                else
                {                    
                    length = StaticFunctionsClass.ToIntDef(fieldlength, 0);
                    sb.Append($@"VARCHAR({length})");
                }                
            }
            else if (type == "NUMERIC")
            {
                // NUMERIC(8, 3)
                int prec = StaticFunctionsClass.ToIntDef(fieldprec, 0);
                int digits = StaticFunctionsClass.ToIntDef(fieldscale, 0);
                if (digits < prec)
                {
                    sb.Append($@"NUMERIC({prec},{digits})");
                }
                else
                {
                    txtPrecisionLength.Text = "1";
                    txtScale.Text = "0";                   
                    sb.Append($@"NUMERIC(1,0)");
                }
            }
            else
            {
                sb.Append(type);
            }
            return sb.ToString();
        }

        public void MakeSQLNew(bool force = false)
        {
            DomainClass Domain = null;
           
            if ((cbDOMAIN.SelectedItem != null)&&(cbDOMAIN.Text.Length > 0))
            {
                Domain = cbDOMAIN.SelectedItem as DomainClass;
            }
            
            if(Domain == null) tabControlFld.SelectedTab = tabPageField;
                
            bool usefieldtype =  tabControlFld.SelectedTab == tabPageField; 

            SQLScript.Clear();
            var sb = new StringBuilder();

            sb.Append($@"CREATE TABLE {_tableObject.Name}{Environment.NewLine}({Environment.NewLine}    {txtFieldName.Text} ");
            
            if (!usefieldtype)
            {
                string cmd = (Domain != null) 
                    ? $@"{Domain.Name}"
                    : $@"{cbDOMAIN.Text}";
                sb.Append(cmd);
                //Anlegen mit domain -> keine collation und charset...
                if ((!usefieldtype) && (Domain.FieldType == "VARYING"))
                {
                    sb.Append(" /* domain */ ");
                }

                if (cbPrimaryKey.Checked)
                {               
                    sb.Append(" PRIMARY KEY");
                }
                
                
                cmd = (Domain != null) 
                    ? $@"{Environment.NewLine}    /* raw:{Domain.RawType} intern:[{Domain.FieldType}] */" 
                    : $@"{Environment.NewLine}    /* {GetTypeString(cbTypes.Text, txtLength.Text, txtPrecisionLength.Text, txtScale.Text)} */";
                sb.Append(cmd);
            }
            else
            {
                //Keine Domain
                //sb.Append(GetTypeString(cbTypes.Text, txtLength.Text, txtPrecisionLength.Text, txtScale.Text));
                sb.Append(GetTypeString(cbTypes.Text, txtLength.Text, txtPrecisionLength.Text, txtScale.Text));
                if (cbTypes.Text == "VARCHAR")
                {
                    //Lege Column mit Datentyp an                
                    if (cbCharSet.Text.Length > 0)
                    {
                        sb.Append(" CHARACTER SET " + cbCharSet.Text);
                    }
                    if (cbCollate.Text.Length > 0)
                    {
                        sb.Append(" COLLATE " + cbCollate.Text);
                    }                    
                }
                
                if (txtDefault.Text.Length > 0)
                {
                    sb.Append(" DEFAULT " + txtDefault.Text.Trim());
                }

                if (cbPrimaryKey.Checked)
                {               
                    sb.Append(" PRIMARY KEY");
                }
                
                if (cbNotNull.Checked)
                {
                    sb.Append(" NOT NULL");
                }
            }

            sb.Append($@"{Environment.NewLine});");
            SQLScript.Add(sb.ToString());

            sb.Clear();

            //COMMENT ON COLUMN TADRESSEN.TTT IS '  rrrrrrrrrrrrrrrr'
            if(fctDescription.Text.Length > 0)
            {
                sb.Clear();
                sb.Append($@"COMMENT ON COLUMN {_tableObject.Name}.{txtFieldName.Text.Trim()} IS '{fctDescription.Text}';");
                SQLScript.Add(sb.ToString());
                SQLScript.Add(SQLPatterns.Commit);               
            }

            SQLToUI();
        }

        public List<string> SQLScript = new List<string>();

        public void SQLToUI()
        {
            fctSQL.Clear();
            foreach(string str in SQLScript)
            {
               fctSQL.AppendText(str+Environment.NewLine);
            }
        }
        
       
        public void FillCombos()
        {
            var domains = StaticTreeClass.Instance().GetDomainObjects(_dbReg);
            cbDOMAIN.Items.Clear();
            foreach(DomainClass domain in domains.Values)
            {
              cbDOMAIN.Items.Add(domain);
            }
            cbDOMAIN.Text = "";
        }

        void FieldDataToEdit()
        {
            txtFieldName.Text       = _fieldObject.Name;
            fctDescription.Text     = _fieldObject.Description;
            cbPrimaryKey.Checked    = _tableObject.IsPrimary(_fieldObject.Name); 
            cbNotNull.Checked       = _tableObject.IsNotNull(_fieldObject.Name);
        }
        void DomainDataToEdit(DomainClass Domain)
        {
            txtLength.Text          = Domain.Length.ToString();
            txtScale.Text           = Domain.Scale.ToString();
            txtPrecisionLength.Text = Domain.Precision.ToString();
            cbDOMAIN.Text           = Domain.Name;
            cbTypes.Text            = StaticVariablesClass.ConvertRawTypeToRawName(Domain.FieldType);
            cbCharSet.Text = (Domain.CharSet == null) ? "NONE" : Domain.CharSet;
            cbCollate.Text = (Domain.Collate == null) ? "NONE" : Domain.Collate;
        }
        private void CreateNewTableForm_Load(object sender, EventArgs e)
        {
            if (this.Left < DbExplorerForm.Instance().Width + 16) this.Left = DbExplorerForm.Instance().Width + 16;
        
            _dataFilled = false;
                      
            FillCombos();
            
            SetVisible();
            _dataFilled = true;
            MakeSQL(true);         
        }

        public void ShowCaptions()
        {
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert)
            {
                lblCaption.Text = (_fieldObject != null) ? $@"Edit Table Field:{_fieldObject.Name}" : lblCaption.Text = "Edit Table Field";                
            }
            else
            {
                lblCaption.Text = (_fieldObject != null) ? $@"New Table Field:{_fieldObject.Name}" : lblCaption.Text = "Edit Table Field";                                
            }
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Table Field");
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;             
            SetVisible();
            MakeSQL();               
        }

        private void hsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;                                    
            MakeSQL();               
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;                       
            MakeSQL();               
        }

        private void cbCharSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;            
            MakeSQL();               
        }

        private void cbCollate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;            
            MakeSQL();               
        }

        private void txtPrecisionLength_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;                      
            MakeSQL();               
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;                       
            MakeSQL();               
        }
              
        private void hsSave_Click(object sender, EventArgs e)
        { 
        }

        private void Create()
        {             
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
                       
            string info = (riFailure==null) 
                ? $@"Table {_dbReg.Alias}->{_tableObject.Name} updated." 
                : $@"Table {_dbReg.Alias}->{_tableObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadTable,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);   
            
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
            _messagesCount = 0;
            _errorCount = 0;
        }

        private void hsEditDomain_Click(object sender, EventArgs e)
        {
            var df = new DomainForm(this.MdiParent, _dbReg, _fieldObject.Domain);
            df.Show();
        }
       
        private void cbNotNull_CheckedChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;                        
            MakeSQL();               
        }

        private void cbPrimaryKey_CheckedChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;            
            MakeSQL();               
        }
        
        private void hsSelectDefault_Click(object sender, EventArgs e)
        {
            var sd = new SelectDefaultForm(this.MdiParent,_localTableNotify);
            sd.Show();
        }

        private void txtDefault_TextChanged(object sender, EventArgs e)
        {
            if(!_dataFilled) return;            
            MakeSQL();               
        }
       
        private void fctDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (!_dataFilled) return;            
            MakeSQL();               
        }
        
        private void cbDOMAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;            
            var domain = cbDOMAIN.SelectedItem as DomainClass;
            DomainDataToEdit(domain);                                            
            SetVisible();
            MakeSQL();               
        }

        private void hsNewDomain_Click(object sender, EventArgs e)
        {
            var df = new DomainForm(this.MdiParent, _dbReg, _fieldObject.Domain);
            df.SetNew();
            df.Show();
        }

        private void cbUSEAlwaysDomain_CheckedChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;             
            SetVisible();
            MakeSQL();               
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((tabControlFld.SelectedTab == tabPageDomain)&&(cbDOMAIN.Text.Length <= 0)&&(cbDOMAIN.Items.Count > 0))
            {                
                cbDOMAIN.SelectedIndex = 0;               
            }            
            MakeSQLNew();
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;    
            _tableObject.Name = txtTableName.Text;
            MakeSQLNew();
        }

        private void hsCraete_Click(object sender, EventArgs e)
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
    }
}
