using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FBExpert;
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
using static StateClasses.EditStateClass;

namespace FBXpert
{
    public partial class IndexForm : IEditForm
    {
        
        DBRegistrationClass _dbReg = null;
        string IndexName = string.Empty;
        string TableName = string.Empty;
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        TableClass TableObject;
        string NewIndexName = string.Empty;
        string OldIndexName = string.Empty;
        List<TableClass> _tables = null;
        public IndexForm(Form parent, string indexName,  DBRegistrationClass dbReg, List<TableClass> tables, eBearbeiten mode)
        {
            InitializeComponent();
            this.MdiParent = parent;
            BearbeitenMode = mode;
            _dbReg = dbReg;
            cbFields.Items.Clear();
            lvFields.Items.Clear();
            if(mode == eBearbeiten.eInsert)
            {
                IndexName = "NEW_INDEX_INX1";
                NewIndexName = "NEW_INDEX_INX1";
                TableName = tables[0].Name;
            }
            else
            {
                IndexName = indexName;
                NewIndexName = indexName;
                TableName = RefreshIndicesAndGetTablename();
            }
            
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler  += Notify_OnRaiseInfoHandler;
            
            _tables = tables;
            
            TableObject = StaticTreeClass.GetTableObjectForIndexForm(_dbReg, TableName);   
            
            DataFilled = true;
        }
        
        public IndexForm(Form parent, TableClass tableObject,  DBRegistrationClass dbReg, List<TableClass> tables, eBearbeiten mode )
        {
            InitializeComponent();
            this.MdiParent = parent;
            BearbeitenMode = mode;
            _dbReg = dbReg;
                      
            IndexName = $@"{tableObject.Name}_inx1";
            NewIndexName = $@"{tableObject.Name}_inx1";
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler  += Notify_OnRaiseInfoHandler;
            TableName = tableObject.Name;
            TableObject = tableObject;
            DataFilled = true;
            _tables = tables;
        
            lvFields.Items.Clear();
            
            txtIndexName.Text = IndexName.Trim();
            DataFilled = true;
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
            if (error_count > 0) sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }


        public void MakeSQL()
        {
            ShowCaptions();
            Application.DoEvents();
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                MakeSQLAlter();
            }
            else
            {
                MakeSQLNew();
            }
            ShowCaptions();
        }

        public string GetFields()
        {
            string fieldStr = string.Empty;                
            foreach (ListViewItem lvi in lvFields.Items)
            {                    
                fieldStr += string.IsNullOrEmpty(fieldStr) ? $@"({lvi.Text}" : $@",{lvi.Text}";                    
            }
            fieldStr+= string.IsNullOrEmpty(fieldStr) ? "()": ")" ;
            return fieldStr;
        }

        public void MakeSQLNew()
        {
            SQLScript.Clear();
            //ckPrimary.Visible = true;
            StringBuilder sb = new StringBuilder();
            /*
            CREATE UNIQUE INDEX TLAGERDEF_IDX1
            ON TLAGERDEF(TLAGER_ID, POSX, POSY, POSZ)
            */
           
            
            if (ckPrimary.Checked)
            {
                sb.Append($@"ALTER TABLE {TableName} ADD PRIMARY KEY");                
                string fieldStr = GetFields();
                                
                if(rbSortAscending.Checked)  fieldStr+= $@" {EnumHelper.GetDescription(eSort.ASC)}";
                if(rbSortDescending.Checked) fieldStr+= $@" {EnumHelper.GetDescription(eSort.DESC)}";
                fieldStr+=";";
                sb.Append(fieldStr);
            }
            else 
            {
                sb.Append($@"{StaticVariablesClass.CREATEStr} ");
                if (cbUnique.Checked)
                {
                    sb.Append($@"{StaticVariablesClass.UNIQUEStr} ");
                }
                if(rbSortAscending.Checked) sb.Append($@"{EnumHelper.GetDescription(eSort.ASC)} ");
                else if(rbSortDescending.Checked) sb.Append($@"{EnumHelper.GetDescription(eSort.DESC)} ");

                sb.Append("INDEX ");
                sb.Append(txtIndexName.Text.Trim());
                sb.Append(" ON ");
                sb.Append(TableName);
                                
                string fieldStr = GetFields();                
                sb.Append(fieldStr);                                
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            SQLToUI();
        }

        bool DataFilled = false;

        public string RefreshIndicesAndGetTablename()
        {
            string cmd_index = IndexSQLStatementsClass.Instance().GetIndiciesByName(_dbReg.Version, IndexName.Trim());
            DataFilled = false;
            txtIndexName.Text = IndexName.Trim();
            string TableName = string.Empty;
            try
            {
                lvFields.Items.Clear();               
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                con.Open();
                string pkColumn             = string.Empty;
                string indexName            = string.Empty;
                string indexColumnName      = string.Empty;
                string oldIndexColumnName   = string.Empty;
                int Unique = 0;
                int IndexType = -1;
                bool Active = false;
                FbCommand fcmd = new FbCommand(cmd_index, con);
                var dread = fcmd.ExecuteReader();
                
                if (dread.HasRows)
                {
                    while (dread.Read())
                    {
                        TableName       = dread.GetValue(0).ToString().Trim();
                        indexColumnName = dread.GetValue(2).ToString().Trim();
                        Unique          = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);
                        Active          = StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0)!=1;
                        IndexType       = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                        cbUnique.Checked = Unique > 0;
                        ckActive.Checked = Active;
                        if(IndexType < 0) rbSortNothing.Checked= true;
                        else if(IndexType == 0) rbSortAscending.Checked= true;
                        else if(IndexType == 1) rbSortDescending.Checked= true;
                        string[] lv = new string[1];
                        lv[0] = indexColumnName;
                        if(this.oldIndexColumnName != indexColumnName)
                        {                            
                            ListViewItem lvi = new ListViewItem(indexColumnName);
                            lvFields.Items.Add(lvi);
                            this.oldIndexColumnName = indexColumnName;
                        }                                            
                    }
                    DataFilled = true;
                }
                con.Close();                
            }
            catch (Exception ex)
            {
              _localNotify?.AddToERROR($@"{StaticFunctionsClass.DateTimeNowStr()}->IndexForm->RefreshIndicesAndGetTablename()->{ex.Message}");
            }
            return TableName;
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

        public void MakeSQLAlter()
        {                  
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            
            sb.Append("DROP INDEX ");
            sb.Append($@"{oldIndexColumnName};{Environment.NewLine}");
            sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");

            if (ckPrimary.Checked)
            {
                sb.Append($@"ALTER TABLE {TableName} ADD PRIMARY KEY ");
                
                string fieldStr = GetFields();                
                if(rbSortAscending.Checked) fieldStr  += $@" {EnumHelper.GetDescription(eSort.ASC)}";
                if(rbSortDescending.Checked) fieldStr += $@" {EnumHelper.GetDescription(eSort.DESC)}";
                fieldStr+=";";
                sb.Append(fieldStr);
            }
            else
            {            
                sb.Append("CREATE ");
                if (cbUnique.Checked)
                {
                    sb.Append("UNIQUE ");
                }
                if(rbSortAscending.Checked) sb.Append("ASCENDIG ");
                else if(rbSortDescending.Checked) sb.Append("DESCENDING ");
                sb.Append("INDEX ");
                sb.Append(NewIndexName);
                sb.Append(" ON ");
                sb.Append(TableName);  
                
                string fieldStr = GetFields();                
                sb.Append(fieldStr);                   
                sb.Append(";");
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void DataToEdit()
        {
           cbFields.Items.Clear();
           if(TableObject== null) return;
           foreach (TableFieldClass field in  TableObject.Fields.Values)
           {
                cbFields.Items.Add(field);
           }
           
           cbFields.SelectedIndex = (cbFields.Items.Count > 0) ? 0 : -1;
        }

        string oldIndexColumnName = string.Empty;
        
        private void IndexForm_Load(object sender, EventArgs e)
        {    
            DataFilled = false;
            cbTables.Items.Clear();
            cbTables.Items.AddRange(_tables.ToArray());
            cbTables.Text = TableObject.Name;
            DataToEdit();
            oldIndexColumnName = txtIndexName.Text.Trim();
            DataFilled = true;
            MakeSQL();
            SetAutocompeteObjects(_tables);
        }

        
        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);            
        }
       
        public void ShowCaptions()
        {
            lblIndexName.Text = $@"Index:{NewIndexName}";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Index");
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (DataFilled)
                MakeSQL();
        }

        private void lvFields_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (lvFields.SelectedItems?.Count > 0)
            {
                ListViewItem lvi = lvFields.SelectedItems[0];
                int inx = cbFields.FindString(lvi.Text);
                cbFields.SelectedIndex = inx;
            }            
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            MakeSQL();
        }

        public void RegisterNotify(NotifyInfos.RaiseNotifyHandler infoN)
        {
           _localNotify.Notify.OnRaiseInfoHandler += infoN;
        }

        private void Create()
        {                                             
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList      = _sql.ExecuteCommands(fctSQL.Lines);             
            var riFailure   = riList.Find(x=>x.commandDone = false);                                    
            oldIndexColumnName = NewIndexName;
            if (DataFilled) MakeSQL();
           
            string info = (riFailure==null) 
                ? $@"Index {_dbReg.Alias}->{NewIndexName} updated." 
                : $@"Index {_dbReg.Alias}->{NewIndexName} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");  
        }

        private void hsAddField_Click(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            String fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind != null) return;            
            lvFields.Items.Add(lvi);                
            MakeSQL();               
        }

        private void hsRemoveField_Click(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            String fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind == null) return;            
            lvFields.Items.Remove(lvifind);            
            MakeSQL();               
        }
        
        private void txtIndexName_TextChanged(object sender, EventArgs e)
        {
            NewIndexName = txtIndexName.Text.Trim();
            if (DataFilled)
                MakeSQL();
        }

        private void cbUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (DataFilled)
                MakeSQL();
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

        private void cbPrimary_CheckedChanged(object sender, EventArgs e)
        {
             if (DataFilled)
                MakeSQL();
        }

        private void rbSort_CheckedChanged(object sender, EventArgs e)
        {
             if (DataFilled)
                MakeSQL();
        }
    }
}
