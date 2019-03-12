using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.MiscClasses;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FBXpert.Globals;
using System.Linq;
using FBXpert.SQLStatements;

namespace FBXpert
{
    public partial class ForeignKeyForm : IEditForm
    {
        ForeignKeyClass ForeignKeyObject = null;
        DBRegistrationClass _dbReg = null;
        
        List<TableClass> _tables = null;
        
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        int messages_count = 0;
        int error_count = 0;
        bool DataFilled = false;
        string TableName = string.Empty;    
        string FKName = string.Empty;
        public ForeignKeyForm(Form parent, DBRegistrationClass dbReg, List<TableClass> tables, string tableName,ForeignKeyClass foreignKeys)
        {
            InitializeComponent();
            this.MdiParent = parent;       
            _tables = tables;
            
            if (foreignKeys == null)
            {
                FKName = "";
            }
            else
            {
                FKName = foreignKeys.Name;
            }
            TableName = tableName;
            DataFilled = false;
            _dbReg = dbReg;
           
                
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;           
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            StringBuilder sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append("Messages (" + (messages_count).ToString() + ") ");
            if (error_count > 0) sb.Append("Errors (" + (error_count).ToString() + ")");

            fctMessages.AppendText("INFO  " + k.Meldung);
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            StringBuilder sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append("Messages (" + (messages_count).ToString() + ") ");
            if (error_count > 0) sb.Append("Errors (" + (error_count).ToString() + ")");

            fctMessages.AppendText("ERROR " + k.Meldung);
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        public void MakeSQL()
        {
            
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                MakeSQLAlter();
            }
            else
            {
                MakeSQLNew();
            }
            ShowCaptions();
            hsSave.Enabled = (txtConstraintName.Text.Length > 0);
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

        public void MakeSQLDrop()
        {
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("ALTER TABLE " + ForeignKeyObject.SourceTableName.Trim() + " DROP CONSTRAINT " + ForeignKeyObject.Name);
            sb.Append(";");
            StringBuilder sbs = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(SQLPatterns.Commit);
            SQLScript.Add(sb.ToString());
            SQLToUI();
        }

        public void MakeSQLNew()
        {
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();

            /*
            ALTER TABLE TDOK_TART ADD CONSTRAINT FK_TDOK_TART_1 FOREIGN KEY(TDOKUMENT_ID) REFERENCES TDOKUMENT(ID)
            */

            sb.Append("ALTER TABLE " + ForeignKeyObject.SourceTableName.Trim() + " ADD CONSTRAINT " + ForeignKeyObject.Name + " FOREIGN KEY(");
            int ix = 0;
            foreach (FieldClass rstr in ForeignKeyObject.SourceFields.Values)
            {                
                sb.Append(rstr.Name);
                if (ix < ForeignKeyObject.SourceFields.Count - 1)
                {
                    sb.Append(",");
                }
                ix++;
            }



            //+ ForeignKeyObject.FieldName +

            sb.Append(") REFERENCES " + ForeignKeyObject.DestTableName + "(");
            for (int i = 0; i < ForeignKeyObject.DestFields.Count; i++)
            {
                string rstr = ForeignKeyObject.DestFields.ElementAt(i).Value.Name;
                sb.Append(rstr);
                if ((ForeignKeyObject.DestFields.Count > 1) && (i < ForeignKeyObject.DestFields.Count - 1))
                {
                    sb.Append(",");
                }
            }
            sb.Append(")");
            /*
            if (txtIndexName.Text.Trim().Length > 0)
            {
                sb.Append(" USING INDEX " + txtIndexName.Text.Trim());
            }
            */
            sb.Append(";");
            StringBuilder sbs = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(SQLPatterns.Commit);
            SQLScript.Add(sb.ToString());
            SQLToUI();
        }


        public void MakeSQLAlter()
        {           
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            /*
            ALTER TABLE TACTION DROP CONSTRAINT FK_TACTION_1
            
            ALTER TABLE TDOK_TART ADD CONSTRAINT FK_TDOK_TART_1 FOREIGN KEY(TDOKUMENT_ID) REFERENCES TDOKUMENT(ID)

            
            USING INDEX PK_TACTION


            */
            sb.Append(Environment.NewLine);
            sb.Append("ALTER TABLE " + ForeignKeyObject.SourceTableName.Trim() + " DROP CONSTRAINT " + old_constraint_name+";");
            sb.Append($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");            
            sb.Append("ALTER TABLE " + ForeignKeyObject.SourceTableName.Trim() + " ADD CONSTRAINT " + ForeignKeyObject.Name + " FOREIGN KEY(");

            for (int i = 0; i < ForeignKeyObject.SourceFields.Count; i++)
            {
                string rstr = ForeignKeyObject.SourceFields.ElementAt(i).Value.Name;
                sb.Append(rstr);
                if ((ForeignKeyObject.SourceFields.Count > 1) && (i < ForeignKeyObject.SourceFields.Count - 1))
                {
                    sb.Append(",");
                }
            }

            // + ForeignKeyObject.FieldName +

            sb.Append(")"); sb.Append(Environment.NewLine); sb.Append("REFERENCES " + ForeignKeyObject.DestTableName + "(");
            for (int i = 0; i < ForeignKeyObject.DestFields.Count; i++)
            {
                string rstr = ForeignKeyObject.DestFields.ElementAt(i).Value.Name;
                sb.Append(rstr);
                if ((ForeignKeyObject.DestFields.Count > 1) && (i < ForeignKeyObject.DestFields.Count - 1))
                {
                    sb.Append(",");
                }
            }
            sb.Append(")");     
            /*
            if(txtIndexName.Text.Trim().Length > 0)
            {
                sb.Append(Environment.NewLine);
                sb.Append("USING INDEX "+  txtIndexName.Text.Trim());
            }
            */
            sb.Append(";");

            StringBuilder sbs = new StringBuilder();           
            sb.Append(Environment.NewLine);
            sb.Append($@"{SQLPatterns.Commit}");
            SQLScript.Add(sb.ToString());           
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
            if(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                txtConstraintName.Enabled = true;               
            }
            else
            {
                txtConstraintName.Enabled = true;               
            }
        }

        public void FillPrimaryKey()
        {
            cbPrimaryKey.Items.Clear();
            TableClass tb = (TableClass)cbDestinationTable.SelectedItem;
            
            if (tb?.primary_constraint != null)
            {
                /*
                foreach (ConstraintsClass pk in tb.primary_constraints)
                {
                    cbPrimaryKey.Items.Add(pk);
                }
                if (cbPrimaryKey.Items.Count > 0)
                {
                    cbPrimaryKey.SelectedIndex = 0;
                }
                */
                cbPrimaryKey.Items.Add(tb.primary_constraint);
                if(cbPrimaryKey.Items.Count > 0) cbPrimaryKey.SelectedIndex = 0;
                else cbPrimaryKey.SelectedIndex = -1;
            }
        }

        public void UpdateDestFieldList()
        {            
            int n = 0;
            lvDestFields.Items.Clear();
            foreach (FieldClass str in ForeignKeyObject.DestFields.Values)
            {
                string[] s = new string[2];
                s[0] = (++n).ToString();
                s[1] = str.Name;
                ListViewItem lvi = new ListViewItem(s);
                lvi.Tag = s[1];
                lvDestFields.Items.Add(lvi);
            }

            if (lvDestFields.Items.Count > 0)
            {
                ListViewItem lvi = lvDestFields.Items[0];
                cbDestinationTableFields.Text = lvi.Tag as string;
            }
        }
        public void UpdateSourceFieldList()
        {
            int n = 0;
            lvSourceFields.Items.Clear();
            foreach (FieldClass str in ForeignKeyObject.SourceFields.Values)
            {
                string[] s = new string[2];
                s[0] = (++n).ToString();
                s[1] = str.Name;
                ListViewItem lvi = new ListViewItem(s);
                lvi.Tag = s[1];
                lvSourceFields.Items.Add(lvi);
            }

            if (lvSourceFields.Items.Count > 0)
            {
                ListViewItem lvi = lvSourceFields.Items[0];
               cbSourceTableFields.Text = lvi.Tag as string;
            }
        }


        public override void DataToEdit()
        {            
            TableClass destTable = _tables.Find(x => x.Name == ForeignKeyObject.DestTableName);
            TableClass sourceTable = _tables.Find(x => x.Name == ForeignKeyObject.SourceTableName);
            FillDestFields(ForeignKeyObject.DestTableName);
            FillSourceFields(ForeignKeyObject.SourceTableName);
            //GetSourceFieldsFromTableObject(ForeignKeyObject.SourceTableName);

            txtConstraintName.Text  = ForeignKeyObject.Name;
            cbSourceTable.Text      = ForeignKeyObject.SourceTableName;
            cbDestinationTable.Text = ForeignKeyObject.DestTableName;

            UpdateDestFieldList();
            UpdateSourceFieldList();
            FillPrimaryKey();                        
        }
        
        public void EditToData()
        {                      
            //Foreign key existiert
            //ForeignKeyObject.FieldName = cbSourceTableFieldNames.Text.Trim();

            ForeignKeyObject.DestTableName = cbDestinationTable.Text.Trim();
            ForeignKeyObject.SourceTableName = cbSourceTable.Text.Trim();

            ForeignKeyObject.SourceFields.Clear();
            foreach (ListViewItem lvi in lvSourceFields.Items)
            {
                string str = lvi.Tag as string;
                ForeignKeyObject.SourceFields.Add(str,new FieldClass(str));
            }

            ForeignKeyObject.DestFields.Clear();
            foreach (ListViewItem lvi in lvDestFields.Items)
            {
                string str = lvi.Tag as string;
                ForeignKeyObject.DestFields.Add(str,new FieldClass(str));
            }
            //    ForeignKeyObject.FieldName = cbSourceTableFieldNames.Text;            
        }

        public string old_constraint_name = string.Empty;

        public void FillDestFields(string DestTableName)
        {
            cbDestinationTableFields.Items.Clear();
            if (DestTableName.Length > 0)
            {
                TableClass DestTab = _tables.Find(x=>x.Name == DestTableName);//  StaticTreeClass.Instance().GetTableObjectFromName(DRC, DestTableName);
                Dictionary<string,TableFieldClass> DestFds = DestTab.Fields;                                
                foreach (TableFieldClass dstr in  DestFds.Values)
                {                  
                    if (DestTab.IsPrimary(dstr.Name))
                    {
                        cbDestinationTableFields.Items.Add(dstr.Name);
                    }
                }
            }            
        }

        public void FillSourceFields(string TableName)
        {
            cbSourceTableFields.Items.Clear();
            if (TableName.Length > 0)
            {
                TableClass Tab = _tables.Find(x => x.Name == TableName);//  StaticTreeClass.Instance().GetTableObjectFromName(DRC, DestTableName);
                var Fds = Tab.Fields;
                foreach (TableFieldClass dstr in Fds.Values)
                {                  
                    cbSourceTableFields.Items.Add(dstr.Name);                    
                }
            }
        }

        public void GetSourceFieldsFromTableObject(string SourceTableName)
        {
            cbSourceTableFields.Items.Clear();
            if (SourceTableName.Length > 0)
            {
                var DestFds = StaticTreeClass.Instance().GetTableObjectFromName(_dbReg, SourceTableName).Fields;
                foreach (TableFieldClass dstr in DestFds.Values)
                {                    
                    cbSourceTableFields.Items.Add(dstr.Name);                    
                }
            }
          //  cbSourceTableFieldNames.Text = ForeignKeyObject.FieldName;
        }
        public void FillCombo()
        {
            cbDestinationTable.Items.Clear();
            cbSourceTable.Items.Clear();
            cbDestinationTable.SelectedIndex = -1;
            cbSourceTable.SelectedIndex = -1;
            if (_tables != null)
            {
                foreach (TableClass table in _tables)
                {
                    cbDestinationTable.Items.Add(table);
                    cbSourceTable.Items.Add(table);
                }
            }
        }

        private void UpdateForeignKeyObject()
        {
            if (ForeignKeyObject != null)
            {
                //Existierenter FK
                cbSourceTable.Text = ForeignKeyObject.SourceTableName;
                cbDestinationTable.Text = ForeignKeyObject.DestTableName;
                txtConstraintName.Text =  "FK_NEW";
            }
            else
            {
                //Neuer FK
                ForeignKeyObject = new ForeignKeyClass();
                ForeignKeyObject.Name               = txtConstraintName.Text;
                ForeignKeyObject.DestTableName      = cbDestinationTable.Text.Trim();
                ForeignKeyObject.SourceTableName    = cbSourceTable.Text.Trim();

                //GetSourceFieldsFromTableObject(ForeignKeyObject.SourceTableName);

                FillDestFields(ForeignKeyObject.DestTableName);
                FillSourceFields(ForeignKeyObject.SourceTableName);
                
                if (cbSourceTable.Items.Count > 0)              cbSourceTable.SelectedIndex = 0;
                if (cbDestinationTable.Items.Count > 0)         cbDestinationTable.SelectedIndex = 0;
                if (cbSourceTableFields.Items.Count > 0)        cbSourceTableFields.SelectedIndex = 0;
                if (cbDestinationTableFields.Items.Count > 0)   cbDestinationTableFields.SelectedIndex = 0;
            }
        }

        private void ForeignKeyForm_Load(object sender, EventArgs e)
        {
            DataFilled = false;

            FillCombo();
            
            ForeignKeyObject = GetFK(FKName);
            txtConstraintName.Text = $@"FK_{TableName}_NEW";
            UpdateForeignKeyObject();            
            old_constraint_name = ForeignKeyObject.Name;                      
            SetEnables();
            DataToEdit();                        

            SetAutocompeteObjects(_tables);

            DataFilled = true;
            if(!string.IsNullOrEmpty(TableName)) 
            {
                cbSourceTable.Text = TableName;
            }
            MakeSQL();
            splitContainer1.SplitterDistance = 500;
            txtConstraintName.Enabled = !(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit);            
        }

        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.Activate();
        }

        public void ShowCaptions()
        {
            if (ForeignKeyObject != null)
            {
                lblProcedureName.Text = "Foreign Key: " + ForeignKeyObject.Name;
            }
            else
            {
                lblProcedureName.Text = "Foreign Key";
            }
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Foreign Key");
        }


        private void edit_TextChanged(object sender, EventArgs e)
        {
            //EditChanged();
        }

        public override void EditChanged()
        {
            if (DataFilled)
            {
                EditToData();
                MakeSQL();
            }
        }
        
        private void Create()
        {               
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone = false);      
            
            if(riFailure==null) 
            {                
                old_constraint_name = txtConstraintName.Name;
               
            }            
            

            string info = (riFailure==null) 
                ? $@"Foreign key for {_dbReg.Alias}->{ForeignKeyObject.SourceTableName} updated." 
                : $@"Foreign key for {_dbReg.Alias}->{ForeignKeyObject.SourceTableName} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadForeignKeys,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);


            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;
            
        }
        private void hsSave_Click(object sender, EventArgs e)
        {            
            Create();
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
        }
            
        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if (saveSQLFile.ShowDialog() == DialogResult.OK)
            {
               fctSQL.SaveToFile(saveSQLFile.FileName, Encoding.UTF8);
            }
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if (ofdSQL.ShowDialog() == DialogResult.OK)
            {
                fctSQL.OpenFile(ofdSQL.FileName);
            }
        }

        private void hsAddField_Click(object sender, EventArgs e)
        {
            string[] s = new string[2];
            
            s[0] = (lvDestFields.Items.Count + 1).ToString();
            s[1] = cbDestinationTableFields.Text.Trim();
            ListViewItem lvi = new ListViewItem(s);
            lvi.Tag = s[1];
            ListViewItem lvi2 = lvDestFields.FindItemWithText(s[1]);
            if(lvi2 == null)
            {
                lvDestFields.Items.Add(lvi);
                EditChanged();
            }
            
        }

        public ForeignKeyClass GetFK(string fkname)
        {
            if (fkname.Length <= 0) return null;
            foreach(TableClass tb in _tables)
            {
                if (tb.ForeignKeys == null) continue;                
                if(!tb.ForeignKeys.ContainsKey(fkname)) continue;                
                if (tb.ForeignKeys.TryGetValue(fkname, out ForeignKeyClass fkc))
                {
                    return fkc;
                }                                 
            }
            return null;
        }

        private void hsRemoveField_Click(object sender, EventArgs e)
        {
            if (lvDestFields.SelectedItems == null) return;            
            lvDestFields.SelectedItems[0].Remove();
            EditChanged();               
        }

        private void cbSourceTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataFilled && (cbSourceTable.SelectedItem != null))
            {
                TableClass tc = (TableClass)cbSourceTable.SelectedItem;
                ForeignKeyObject.SourceTableName = tc.Name;
                DataToEdit();                
            }
        }

        private void cbDestinationTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataFilled && (cbDestinationTable.SelectedItem != null))
            {
                TableClass tb = (TableClass)cbDestinationTable.SelectedItem;
                ForeignKeyObject.DestTableName = tb.Name;
                //EditToData();
                DataToEdit();
            }
        }

        private void txtConstraintName_TextChanged(object sender, EventArgs e)
        {
             
            if (!DataFilled) return;
            
            // ForeignKeyObject = GetFK(txtConstraintName.Text.Trim());                
            // UpdateForeignKeyObject();
            // DataToEdit();
            MakeSQL();                        
        }
        

        private void cbPrimaryKey_TextChanged(object sender, EventArgs e)
        {
            EditChanged();
        }

        private void hsDropFK_Click(object sender, EventArgs e)
        {
            MakeSQLDrop();
        }

        private void hsRemoveSourceField_Click(object sender, EventArgs e)
        {
            if (lvSourceFields.SelectedItems != null)
            {
                lvSourceFields.SelectedItems[0].Remove();
                EditChanged();
            }
        }

        private void hsAddSourceField_Click(object sender, EventArgs e)
        {
            string[] s = new string[2];

            s[0] = (lvSourceFields.Items.Count + 1).ToString();
            s[1] = cbSourceTableFields.Text.Trim(); 
            ListViewItem lvi = new ListViewItem(s);
            lvi.Tag = s[1];
            ListViewItem lvi2 = lvSourceFields.FindItemWithText(s[1]);
            if (lvi2 == null)
            {
                lvSourceFields.Items.Add(lvi);
                EditChanged();
            }
        }

        private void cbPrimaryKey_SelectedIndexChanged(object sender, EventArgs e)
        {
           ConstraintsClass pk = cbPrimaryKey.SelectedItem as ConstraintsClass;
           txtIndexName.Text = pk.IndexName;
        }

        private void txtIndexName_TextChanged(object sender, EventArgs e)
        {
            EditChanged();
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
    }
}
