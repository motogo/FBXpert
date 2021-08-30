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
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class PrimaryKeyForm : IEditForm
    {        
        private readonly DBRegistrationClass _dbReg = null;
        private int _messagesCount = 0;
        private int _errorCount = 0;
        private readonly NotifiesClass _localNotify = new NotifiesClass();
      //  private AutocompleteClass _ac = null;
        private TableClass _tableObject = null;
        private readonly List<TableClass> _tables;
        private string _oldIndexName = string.Empty;
        private bool _dataFilled = false;        
        private string _newIndexName = string.Empty;

        public List<string> SQLScript = new List<string>();
        

        public PrimaryKeyForm(Form parent, List<TableClass> tables, TableClass tableObject, DBRegistrationClass dbReg)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _dataFilled = false;
            _dbReg = dbReg;

            if (tableObject == null)
            {
                tableObject = new TableClass
                {
                    primary_constraint = new PrimaryKeyClass
                    {
                        Name = "NEW_PK",
                        FieldNames = new Dictionary<string,string> {{"ID","ID"}},
                        Sorting = eSort.ASC
                    }
                };
                BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            }
            else if(tableObject.primary_constraint == null)
            {
                //Tabelle hatte noch keine PK
                tableObject.primary_constraint = new PrimaryKeyClass
                {
                    Name = "NEW_PK",
                    FieldNames = new Dictionary<string,string> {{"ID","ID"}},
                    Sorting = eSort.ASC
                };
                BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            }
            else
            {                
                BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;
            }
            _tableObject = tableObject;
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
            
            _tables = tables;


           
            FillTablesToCombo();                        
            FillSortingToCombo();
            FillTableFieldsToCombo();
            
            if (tableObject == null)
            {
                _tableObject = cbSourceTable.SelectedItem as TableClass;
                if (_tableObject.primary_constraint == null)
                {                 
                    _tableObject.primary_constraint = new PrimaryKeyClass();
                    _tableObject.primary_constraint.Name = "NEW_PK";
                    _tableObject.primary_constraint.FieldNames = new Dictionary<string,string>();
                    _tableObject.primary_constraint.FieldNames.Add(cbFields.Items[0].ToString(),cbFields.Items[0].ToString());
                    _tableObject.primary_constraint.Sorting = eSort.ASC;                    
                }
            }           
            DataToEdit();            
        }
               
        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            StringBuilder sb = new StringBuilder();
            _messagesCount++;
            if (_messagesCount > 0) sb.Append($@"Messages ({_messagesCount}) ");
            if (_errorCount > 0)    sb.Append($@"Errors ({_errorCount})");

            fctMessages.AppendText($@"INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            _errorCount++;
            if (_messagesCount > 0) sb.Append($@"Messages ({_messagesCount}) ");
            if (_errorCount > 0)    sb.Append($@"Errors ({_errorCount})");

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        public void MakeSQL()
        {            
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

        public void EditToData()
        {
            if(_tableObject.primary_constraint == null)
            {
                _tableObject.primary_constraint = new PrimaryKeyClass();
            }
            _tableObject.primary_constraint.Name = txtPKName.Text;
            _tableObject.primary_constraint.IndexName = txtPKName.Text;
            _tableObject.primary_constraint.FieldNames.Clear();
            eSort es = (eSort)cbSorting.Items[cbSorting.SelectedIndex];
            _tableObject.primary_constraint.Sorting = es;
            foreach (ListViewItem lvi in lvFields.Items)
            {                
                _tableObject.primary_constraint.FieldNames.Add(lvi.Text,lvi.Text);
            }
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
            ALTER TABLE TABTEILUNG
            ADD CONSTRAINT PK_TABTEILUNG
            PRIMARY KEY (ID,STATUS,STAMP)
            USING INDEX PK_TABTEILUNG
            */

            sb.Append($@"ALTER TABLE {_tableObject.Name} ADD CONSTRAINT {_tableObject.primary_constraint.Name} PRIMARY KEY (");

            bool firstdone = false;
            foreach (string st in _tableObject.primary_constraint.FieldNames.Values)
            {
                if (firstdone)
                {
                    sb.Append(",");
                }
                sb.Append(st);
                firstdone = true;
            }
            if(!string.IsNullOrEmpty(_tableObject.primary_constraint.IndexName))
            {
                if(!(_tableObject.primary_constraint.Sorting == eSort.ASC))
                {
                    sb.Append($@"){Environment.NewLine}USING {_tableObject.primary_constraint.Sorting} INDEX {_tableObject.primary_constraint.IndexName};{Environment.NewLine}");
                }
                else
                {
                    sb.Append($@"){Environment.NewLine}USING INDEX {_tableObject.primary_constraint.IndexName};{Environment.NewLine}");
                }
            }
            if (!string.IsNullOrEmpty(_tableObject.primary_constraint.Description))
            {
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
                sb.Append($@"COMMENT ON INDEX {_tableObject.primary_constraint.IndexName} IS '{_tableObject.primary_constraint.Description}'");
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            SQLToUI();
        }

        public void MakeSQOAlter()
        {           
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            /*
            ALTER TABLE TABTEILUNG DROP CONSTRAINT PK_TABTEILUNG
             
            ALTER TABLE TABTEILUNG
            ADD CONSTRAINT PK_TABTEILUNG
            PRIMARY KEY (ID,STATUS,STAMP)
            USING INDEX PK_TABTEILUNG
            USING DESCENDING INDEX PK_TACTION
            */

            sb.Append($@"ALTER TABLE {_tableObject.Name} DROP CONSTRAINT {_tableObject.primary_constraint.Name};{Environment.NewLine}");
            sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");

            sb.Append($@"ALTER TABLE {_tableObject.Name} ADD CONSTRAINT {_tableObject.primary_constraint.Name} PRIMARY KEY (");
            
            bool firstdone = false;
            foreach(string  st in _tableObject.primary_constraint.FieldNames.Values)
            {
                if(firstdone)
                {
                    sb.Append(",");
                }                
                sb.Append(st);
                firstdone = true;
            }
            
            if(!string.IsNullOrEmpty(_tableObject.primary_constraint.IndexName))
            {
                if(!(_tableObject.primary_constraint.Sorting == eSort.ASC))
                {
                    sb.Append($@"){Environment.NewLine}USING {_tableObject.primary_constraint.Sorting} INDEX {_tableObject.primary_constraint.IndexName};{Environment.NewLine}");
                }
                else
                {
                    sb.Append($@"){Environment.NewLine}USING INDEX {_tableObject.primary_constraint.IndexName};{Environment.NewLine}");
                }
            }
            if (!string.IsNullOrEmpty(_tableObject.primary_constraint.Description))
            {
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
                sb.Append($@"COMMENT ON INDEX {_tableObject.primary_constraint.IndexName} IS '{_tableObject.primary_constraint.Description}'");
            }

            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FillObjectToConstraintFields()
        {
            lvFields.Items.Clear();
            foreach (string fieldName in _tableObject.primary_constraint.FieldNames.Values)
            {
                var lvi = new ListViewItem(fieldName);
                var lvifind = lvFields.FindItemWithText(fieldName);
                if (lvifind == null)
                {
                    lvFields.Items.Add(lvi);
                }
            }
        }

        public void FillSortingToCombo()
        {
            cbSorting.Items.Clear();
            cbSorting.Items.Add(eSort.ASC);
            cbSorting.Items.Add(eSort.DESC);
        }

        
        public void FillTablesToCombo()
        {
            cbSourceTable.Items.Clear();
            foreach (TableClass tb in _tables)
            {
                cbSourceTable.Items.Add(tb);
            }

            if (cbSourceTable.Items.Count <= 0) return;
            if (!string.IsNullOrEmpty(_tableObject.Name))
            {
                int inx = cbSourceTable.FindStringExact(_tableObject.Name);
                cbSourceTable.SelectedIndex = inx; 
            }
            else
            {
                cbSourceTable.SelectedIndex = 0;
            }
        }

        public void FillTableFieldsToCombo()
        {
            string TableName = _tableObject.Name;
            cbFields.Items.Clear();
            if (string.IsNullOrEmpty(TableName)) return;
            var tab = _tables.Find(x => x.Name == TableName);//  StaticTreeClass.Instance().GetTableObjectFromName(DRC, DestTableName);
            var fields = tab.Fields;
            foreach (var dstr in fields.Values)
            {
                cbFields.Items.Add(dstr.Name);  
            }
        }

        public void DataToEdit()
        {
           txtPKName.Text   = _tableObject.primary_constraint.Name;
           txtUsingIndex.Text = _tableObject.primary_constraint.IndexName;
                                                      
           if(cbFields.Items.Count > 0) cbFields.SelectedIndex = 0;           
           cbSorting.SelectedItem  = _tableObject.primary_constraint.Sorting;
                       
           FillObjectToConstraintFields();
        }    
                
        
        private void PrimaryKeyForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            _dataFilled = false;
            DataToEdit();
            _oldIndexName = txtPKName.Text.Trim();
            MakeSQL();
            SetAutocompeteObjects(_tables);
            _dataFilled = true;
        }

        AutocompleteClass ac = null;
        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddProcedureCommands();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);                        
            ac.Activate();
        }

        public void ShowCaptions()
        {
            lblTableName.Text = (_tableObject.primary_constraint != null) ? $@"Primary Index: {_tableObject.primary_constraint.Name}" : "Primary Index";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Primary Index");
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (!_dataFilled) return;
            _tableObject.primary_constraint.Description = fctGenDescription.Text;
            MakeSQL();
        }

        private void lvFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFields.SelectedItems == null) return;
            if (lvFields.SelectedItems.Count <= 0) return;
            var lvi = lvFields.SelectedItems[0];
            int inx = cbFields.FindString(lvi.Text);
            cbFields.SelectedIndex = inx;
        }
        
        private void Create()
        {
            var dataSet1 = new DataSet();
            dataSet1.Clear();
                        
            // var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _dbReg.NewLine, _dbReg.CommentStart, _dbReg.CommentEnd, _dbReg.SingleLineComment, "SCRIPT");
            var riList =_sql.ExecuteCommands(fctSQL.Lines);             
            var riFailure = riList.Find(x=>x.commandDone == false);                                    

            _oldIndexName = _newIndexName;

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);

            
            string info = (riFailure==null) 
                ? $@"PrimaryKey {_dbReg.Alias}->{_newIndexName} updated." 
                : $@"PrimaryKey {_dbReg.Alias}->{_newIndexName} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);  
        }

        private void hsAddField_Click(object sender, EventArgs e)
        {
            string fieldName = cbFields.SelectedItem.ToString();            
            _tableObject.primary_constraint.FieldNames.Add(fieldName,fieldName);
            FillObjectToConstraintFields();
            MakeSQL();
        }
        
        private void hsRemoveField_Click(object sender, EventArgs e)
        {
            string fieldName = cbFields.SelectedItem.ToString();

            if(_tableObject.primary_constraint.FieldNames.ContainsKey(fieldName)) _tableObject.primary_constraint.FieldNames.Remove(fieldName);

            FillObjectToConstraintFields();            
            if (_dataFilled) MakeSQL();
        }
        
        private void cbSourceTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled || (cbSourceTable.SelectedItem == null)) return;
            var tc = (TableClass)cbSourceTable.SelectedItem;
            _tableObject = tc;
               
            FillTableFieldsToCombo();
            DataToEdit();
            if (!_dataFilled) return;
            MakeSQL();
        }

        private void hsMakeSQL_Click(object sender, EventArgs e)
        {
            EditToData();
            MakeSQL();
        }

        private void cbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;
            var es = (eSort)cbSorting.Items[cbSorting.SelectedIndex];
            _tableObject.primary_constraint.Sorting = es;
            MakeSQL();
        }

        private void txtPKName_TextChanged(object sender, EventArgs e)
        {
            _newIndexName = txtPKName.Text.Trim();
            if (!_dataFilled) return;
            _tableObject.primary_constraint.Name = txtPKName.Text;
            MakeSQL();
        }
                    
        private void hsCreate_Click(object sender, EventArgs e)
        {
             Create();
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if (ofdSQL.ShowDialog() == DialogResult.OK)
            {
                fctSQL.OpenFile(ofdSQL.FileName);
            }
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if (saveSQLFile.ShowDialog() == DialogResult.OK)
            {
               fctSQL.SaveToFile(saveSQLFile.FileName, Encoding.UTF8);
            }
        }
        
        private void txtUsingIndex_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;
            _tableObject.primary_constraint.IndexName = txtUsingIndex.Text;
            MakeSQL();
        }
    }
}
