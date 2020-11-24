using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FBXpert.SQLStatements;
using FormInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class ConstraintsForm : IEditForm
    {
        
        DBRegistrationClass _dbReg = null;
        string ConstraintName = string.Empty;
        string TableName = string.Empty;
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        ConstraintsClass _constraintObject = null;
       
        string NewConstraintName = string.Empty;
        string OldConstraintName = string.Empty;
       
        string _newTableName = String.Empty;
        TableClass _tableObject;
        List<TableClass> _tables = null;
        bool DataFilled = false;        
        public List<string> SQLScript = new List<string>();
      
        public ConstraintsForm(Form parent, TableClass tableObject,List<TableClass> tables, DBRegistrationClass dbReg, ConstraintsClass constraintObject)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
            _dbReg = dbReg;
            _tables = tables;
            _constraintObject = constraintObject;
            OldConstraintName = _constraintObject.Name;
            _tableObject = tableObject;
            _constraintObject.TableName = _tableObject.Name;            
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;                               
        }

        public void RegisterNotify(NotifyInfos.RaiseNotifyHandler infoN)
        {
           _localNotify.Notify.OnRaiseInfoHandler += infoN;
        }

        public void ShowCaptions()
        {
            if (_constraintObject != null)
            { 
                lblTableName.Text = $@"Constraints: {_constraintObject.Name}";
            }
            else
            {
                lblTableName.Text = "Constraints";
            }
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Manage Constraints");
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            StringBuilder sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");
           
            fctMessages.AppendText($@"INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            StringBuilder sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }


        public void ShowUI()
        {
            gbUsingIndex.Visible = !rbPrimaryKey.Checked;
            if(rbChecks.Checked)
            {
                gbChecksCode.Visible = true;
                gbUsingIndex.Visible = false;
            }
            else
            {
                gbChecksCode.Visible = false;
            }
        }

        public void MakeSQL()
        {
            ShowUI();
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

        public void MakeSQLNew()
        {
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            /*
            CREATE UNIQUE INDEX TLAGERDEF_IDX1
            ON TLAGERDEF(TLAGER_ID, POSX, POSY, POSZ)
            */
            /*
            ALTER TABLE TEMP
            ADD CONSTRAINT PK_TEMP
            PRIMARY KEY()
            */

            sb.Append($@"ALTER TABLE {_tableObject.Name} ADD CONSTRAINT {NewConstraintName}");
            if (rbUnique.Checked)
            {
                sb.Append(" UNIQUE(");
            }
            else if (rbPrimaryKey.Checked)
            {
                sb.Append(" PRIMARY KEY(");
            }
            else if (rbForeignkey.Checked)
            {
                sb.Append(" FOREIGN KEY(");
            }
            else if (rbChecks.Checked)
            {
                sb.Append(" CHECK(");
            }


            if (rbChecks.Checked)
            {
                sb.Append(fcbChecksCode.Text + ");");
            }
            else
            {
                bool first = true;
                foreach (ListViewItem lvi in lvFields.Items)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        sb.Append(",");
                    }
                    sb.Append(lvi.Text);
                }

                if (rbUnique.Checked)
                {                    
                    sb.Append(") USING INDEX " + txtINDEXName.Text);
                }
                else if ((rbPrimaryKey.Checked)||(rbForeignkey.Checked))
                {
                    StringBuilder sbfk = new StringBuilder();
                    sbfk.Append($@") REFERENCES {_tableObject.Name}");
                    if(!string.IsNullOrEmpty(_tableObject.primary_constraint.FieldNamesString()))
                    {
                        sbfk.Append($@"({_tableObject.primary_constraint.FieldNamesString()}");
                    }
                    if(!string.IsNullOrEmpty(txtINDEXName.Text))
                    {
                        sbfk.Append($@") USING INDEX {txtINDEXName.Text}");
                    }

                    sb.Append(sbfk);   
                    sb.Append(");");
                }
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add(SQLPatterns.Commit);
            SQLToUI();

        }

        public void MakeSQOAlter()
        {           
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            /*
            CREATE UNIQUE INDEX TLAGERDEF_IDX1
            ON TLAGERDEF(TLAGER_ID, POSX, POSY, POSZ)
            */
            /*
            ALTER TABLE TEINSATZORT
            ADD CONSTRAINT FK_TEINSATZORT_1
            FOREIGN KEY(ID)
            REFERENCES TARTIKEL(ID)
            USING INDEX XXX
            */
            /*
            ALTER TABLE TEMP
            ADD CONSTRAINT CHK1_TEMP
            CHECK(ID = 123hh)
            */
            sb.Append($@"DROP CONSTRAINT {OldConstraintName};{Environment.NewLine}");
            
            sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");

            sb.Append($@"ALTER TABLE {_tableObject.Name} ADD CONSTRAINT {NewConstraintName}");
            if (rbUnique.Checked)
            {
                sb.Append(" UNIQUE (");
            }
            else if(rbPrimaryKey.Checked)
            {
                sb.Append(" PRIMARY KEY (");
            }
            else if (rbForeignkey.Checked)
            {
                sb.Append(" FOREIGN KEY (");
            }
            else if(rbChecks.Checked)
            {
                sb.Append(" CHECK(");
            }


            if (rbChecks.Checked)
            {
                sb.Append($@"{fcbChecksCode.Text});");
            }
            else
            {
                bool first = true;
                foreach (ListViewItem lvi in lvFields.Items)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        sb.Append(",");
                    }
                    sb.Append(lvi.Text.Trim());
                }


                if (rbUnique.Checked)
                {
                    sb.Append($@") USING INDEX {txtINDEXName.Text}");                    
                }
                else if (rbForeignkey.Checked)
                {
                    StringBuilder sbfk = new StringBuilder();
                    sbfk.Append($@") REFERENCES {_tableObject.Name}");
                    if(!string.IsNullOrEmpty(_tableObject.primary_constraint.FieldNamesString()))
                    {
                        sbfk.Append($@"({_tableObject.primary_constraint.FieldNamesString()}");
                    }
                    if(!string.IsNullOrEmpty(txtINDEXName.Text))
                    {
                        sbfk.Append($@") USING INDEX {txtINDEXName.Text}");
                    }

                    sb.Append(sbfk);   
                    sb.Append(");");
                }
                else if ((rbPrimaryKey.Checked)||(rbForeignkey.Checked))
                {
                    sb.Append(");");
                }
            }

            SQLScript.Add(sb.ToString());
            SQLScript.Add(SQLPatterns.Commit);
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void DataToEdit()
        {           
            cbFields.Items.Clear();
            cbFields.Items.AddRange(_tableObject.Fields.Values.ToArray());
            lvFields.Items.Clear();
            foreach (string fn in _constraintObject.FieldNames.Values)
            {
                string[] st = new string[1];
                st[0] = fn;
                ListViewItem lvi = new ListViewItem(st);
                lvFields.Items.Add(lvi);
            }
            
            txtConstraintName.Text = _constraintObject.Name;
            rbUnique.Checked = (_constraintObject.ConstraintType == eConstraintType.UNIQUE);
            rbForeignkey.Checked = (_constraintObject.ConstraintType == eConstraintType.FOREIGNKEY);
            rbPrimaryKey.Checked = (_constraintObject.ConstraintType == eConstraintType.PRIMARYKEY);
            txtINDEXName.Text = _constraintObject.IndexName;
            DataFilled = true;
        }


        public void SetUIControls()
        {
            if(rbUnique.Checked)
            {

            }
            else if(rbPrimaryKey.Checked)
            {

            }
            else
            {
                //NotNull
            }
        }
        
        private void ConstraintsForm_Load(object sender, EventArgs e)
        {
            DataToEdit();
            OldConstraintName = txtConstraintName.Text.Trim();
            NewConstraintName = OldConstraintName;            
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
        
        private void Create()
        {                                   
            string _connstr = ConnectionStrings.Instance().MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _dbReg.NewLine, _dbReg.CommentStart, _dbReg.CommentEnd, _dbReg.SingleLineComment, "SCRIPT");
            var riList =_sql.ExecuteCommands(fctSQL.Lines); 
            
            var riFailure = riList.Find(x=>x.commandDone == false);                                    
            OldConstraintName = NewConstraintName;
            if (DataFilled) MakeSQL();

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);

            string info = (riFailure==null) 
                ? $@"Constraint {_dbReg.Alias}->{_constraintObject.TableName}->{_constraintObject.Name} updated." 
                : $@"Constraint {_dbReg.Alias}->{_constraintObject.TableName}->{_constraintObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);                              
        }
       
        private void ConstraintNameChanged(object sender, EventArgs e)
        {
            NewConstraintName = txtConstraintName.Text.Trim();
            ConstraintEditChanged();            
        }
        private void ConstraintEditChanged(object sender, EventArgs e)
        {
            ConstraintEditChanged();
        }

        private void ConstraintEditChanged()
        {            
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
                cbFields.Text = lvi.Text;
            }
        }

        private void hsAddField_Click_1(object sender, EventArgs e)
        {
            string fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind == null)
            {
                lvFields.Items.Add(lvi);
                ConstraintEditChanged();
            }
        }

        private void hsRemoveField_Click_1(object sender, EventArgs e)
        {
            string fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind != null)
            {
                lvFields.Items.Remove(lvifind);
                ConstraintEditChanged();
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

        private void ConstraintsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _localNotify.Notify.RaiseInfo("", StaticVariablesClass.ReloadConstraintsKeysForTable, $@"->Proc:{Name}->Close");
        }
    }    
}
