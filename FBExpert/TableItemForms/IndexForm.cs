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
        
       
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        TableClass _orgTableObject;
        TableClass _tableObject;
        IndexClass _orgIndexObject = null;
        IndexClass _indexObject = null;
        bool _indexActiveChanged = false;
        
        
        List<TableClass> _tables = null;
        public IndexForm(Form parent, string indexName,  DBRegistrationClass dbReg, List<TableClass> tables, eBearbeiten mode)
        {
            InitializeComponent();
            this.MdiParent = parent;
            BearbeitenMode = mode;
            _dbReg = dbReg;
            cbFields.Items.Clear();
            lvFields.Items.Clear();
            
            string TableName = string.Empty;
            if(mode == eBearbeiten.eInsert)
            {
                
                
                TableName = tables[0].Name;
                
                _orgIndexObject = new IndexClass();
                _orgIndexObject.Name = "NEW_INDEX_INX1";
                _orgIndexObject.IsActive = true;
            }
            else
            {                                
                TableName = RefreshIndicesAndGetTablename(indexName);
                _tableObject = tables.Find(X=>X.Name == TableName);
                _tableObject.Indices.TryGetValue(indexName,out _orgIndexObject);

            }
            _indexObject    = _orgIndexObject;
            _indexActiveChanged = false;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler  += Notify_OnRaiseInfoHandler;
            
            _tables = tables;
            
            _tableObject = StaticTreeClass.Instance().GetTableObjectForIndexForm(_dbReg, TableName);              
            _orgTableObject = _tableObject;
            
            FillSortingToCombo();
            _dataFilled = true;
        }

        public IndexForm(Form parent, IndexClass indexObject,  DBRegistrationClass dbReg, List<TableClass> tables)
        {
            InitializeComponent();
            this.MdiParent = parent;
            BearbeitenMode = eBearbeiten.eEdit;
            _dbReg = dbReg;
            cbFields.Items.Clear();
            lvFields.Items.Clear();
            _indexObject     = indexObject;
            _orgIndexObject  = indexObject;
            
                                                
            var TableName = RefreshIndicesAndGetTablename(_orgIndexObject.Name);

            _tableObject = tables.Find(X=>X.Name == TableName);

           // _tableObject.Indices.TryGetValue(_orgIndexObject.Name,out _orgIndexObject);
                       
            _indexActiveChanged = false;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler  += Notify_OnRaiseInfoHandler;
            
            _tables = tables;
            
           // _tableObject = StaticTreeClass.Instance().GetTableObjectForIndexForm(_dbReg, TableName);              
            _orgTableObject = _tableObject;
            
            FillSortingToCombo();
            _dataFilled = true;
        }

        private void cbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;
            var es = (eSort)cbSorting.Items[cbSorting.SelectedIndex];
            _tableObject.primary_constraint.Sorting = es;
            MakeSQL();
        }
        
        public IndexForm(Form parent, TableClass tableObject,  DBRegistrationClass dbReg, List<TableClass> tables)
        {
            InitializeComponent();
            this.MdiParent = parent;
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            _dbReg = dbReg;
                                  
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler  += Notify_OnRaiseInfoHandler;
            _orgTableObject = tableObject;
            _tableObject = tableObject;
                                                                           
            _orgIndexObject = new IndexClass();
            _orgIndexObject.Name = $@"{tableObject.Name}_INX";
            _orgIndexObject.IsActive = true;
            _indexObject = _orgIndexObject;
            
            _tables = tables;
            _indexActiveChanged = false;
        
            lvFields.Items.Clear();
            
            txtIndexName.Text = MakeNewIndexName();
            FillSortingToCombo();
            _dataFilled = true;
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
            string errStr = AppStaticFunctionsClass.GetErrorCodeString(k.Meldung,_dbReg);
            fctMessages.AppendText($@"ERROR {errStr}");
            
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }
        public void EnableButtons()
        {
            bool sqlok = (lvFields.Items.Count > 0) &&
                         (!string.IsNullOrEmpty(cbTables.Text)) &&
                         (!string.IsNullOrEmpty(txtIndexName.Text));
            
            hsCreate.Enabled = sqlok;
           
        }

        public void MakeSQL()
        {
            EnableButtons();
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
                sb.Append($@"ALTER TABLE {_tableObject.Name} ADD PRIMARY KEY");                
                string fieldStr = GetFields();
                if(((eSort)cbSorting.SelectedItem) != eSort.NONE)                
                    fieldStr+= $@" {EnumHelper.GetDescription((eSort)cbSorting.SelectedItem)}";
                
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
                if(((eSort)cbSorting.SelectedItem) != eSort.NONE)
                    sb.Append($@"{EnumHelper.GetDescription((eSort)cbSorting.SelectedItem)} ");
                
                sb.Append("INDEX ");
                sb.Append(txtIndexName.Text.Trim());
                sb.Append(" ON ");
                sb.Append(_tableObject.Name);
                                
                string fieldStr = GetFields();                
                sb.Append(fieldStr);
                sb.Append(";");
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            SQLToUI();
        }

        bool _dataFilled = false;
        
        public void FillSortingToCombo()
        {
            cbSorting.Items.Clear();
            cbSorting.Items.Add(eSort.ASC);
            cbSorting.Items.Add(eSort.DESC);
            cbSorting.SelectedIndex = 0;
        }

        public string RefreshIndicesAndGetTablename(string _indexObjectName)
        {
            string cmd_index = IndexSQLStatementsClass.Instance.GetIndiciesByName(_dbReg.Version, _indexObjectName.Trim());
            _dataFilled = false;
            txtIndexName.Text = _indexObjectName.Trim();
            string TableName = string.Empty;
            try
            {
                lvFields.Items.Clear();               
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(_dbReg));
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

                        if(IndexType < 0)   cbSorting.SelectedItem = eSort.NONE;
                        else if(IndexType == 0) cbSorting.SelectedItem = eSort.ASC;
                        else if(IndexType == 1) cbSorting.SelectedItem = eSort.DESC;
                        
                        string[] lv = new string[1];
                        lv[0] = indexColumnName;
                        if(this.oldIndexColumnName != indexColumnName)
                        {                            
                            ListViewItem lvi = new ListViewItem(indexColumnName);
                            lvFields.Items.Add(lvi);
                            this.oldIndexColumnName = indexColumnName;
                        }                                            
                    }
                    _dataFilled = true;
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
                sb.Append($@"ALTER TABLE {_tableObject.Name} ADD PRIMARY KEY ");
                
                string fieldStr = GetFields();       
                
                if(((eSort)cbSorting.SelectedItem) != eSort.NONE)                
                    fieldStr+= $@" {EnumHelper.GetDescription((eSort)cbSorting.SelectedItem)}";

                
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
                
                if(((eSort)cbSorting.SelectedItem) != eSort.NONE)                
                    sb.Append($@"{EnumHelper.GetDescription((eSort)cbSorting.SelectedItem)} ");

                
                sb.Append("INDEX ");
                sb.Append(_indexObject.Name);
                sb.Append(" ON ");
                sb.Append(_tableObject.Name);  
                
                string fieldStr = GetFields();                
                sb.Append(fieldStr);                   
                sb.Append(";");
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add($@"{SQLPatterns.Commit}");
            if(_indexActiveChanged)
            {
                SQLScript.Add($@"{SQLPatterns.ActivateIndexPattern.Replace(SQLPatterns.IndexKey,_indexObject.Name)}");
                SQLScript.Add($@"{SQLPatterns.Commit}");
            }
            SQLToUI();
        }


        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public override void DataToEdit()
        {
            DataToCBFields();
        }
        public void DataToCBFields()
        {
           cbFields.Items.Clear();
           if(_tableObject== null) return;
           foreach (TableFieldClass field in  _tableObject.Fields.Values)
           {
                cbFields.Items.Add(field);
           }
           
           cbFields.SelectedIndex = (cbFields.Items.Count > 0) ? 0 : -1;
        }

        string oldIndexColumnName = string.Empty;
        
        private void IndexForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            _dataFilled = false;
            cbTables.Items.Clear();
            cbTables.Items.AddRange(_tables.ToArray());
            cbTables.Text = _tableObject.Name;
            DataToEdit();
            oldIndexColumnName = txtIndexName.Text.Trim();
            _dataFilled = true;
            MakeSQL();
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
       
        public void ShowCaptions()
        {
            lblIndexName.Text = $@"Index:{_indexObject.Name}";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Index");
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (_dataFilled)
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

        public string MakeNewIndexName()
        {
            string inxStr = _indexObject.Name.Trim();
            int lastn = 1;
            int i = 0;
            for(i = inxStr.Length-1; i >= 0; i--)
            {
                string s = inxStr.Substring(i);
                int n = StaticFunctionsClass.ToIntDef(s, -1);
                if(n < 0) break;
                lastn = n+1;
            }
            string newStr = inxStr.Substring(0,i+1)+lastn.ToString();
            return newStr;
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            ckActive.Checked = true;
            _indexActiveChanged = false;
            lvFields.Items.Clear();
            _indexObject = _orgIndexObject;
            txtIndexName.Text = MakeNewIndexName();
            MakeSQL();
        }

        public void RegisterNotify(NotifyInfos.RaiseNotifyHandler infoN)
        {
            _localNotify.Register4Info(infoN);
        }

        private void Create()
        {                                             
            //var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, _dbReg.NewLine, _dbReg.CommentStart, _dbReg.CommentEnd, _dbReg.SingleLineComment, "SCRIPT");
            var riList      = _sql.ExecuteCommands(fctSQL.Lines);             
            var riFailure   = riList.Find(x=>x.commandDone == false);                                    
            oldIndexColumnName = _indexObject.Name;
            
            if (_dataFilled) MakeSQL();

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);

            
            string info = (riFailure==null) 
                ? $@"Index {_dbReg.Alias}->{_indexObject.Name} updated." 
                : $@"Index {_dbReg.Alias}->{_indexObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");  
        }

        private void hsAddField_Click(object sender, EventArgs e)
        {
            if (!_dataFilled) return;
            String fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind != null) return;            
            lvFields.Items.Add(lvi);                
            MakeSQL();               
        }

        private void hsRemoveField_Click(object sender, EventArgs e)
        {
            if (!_dataFilled) return;
            String fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind == null) return;            
            lvFields.Items.Remove(lvifind);            
            MakeSQL();               
        }
        
        private void txtIndexName_TextChanged(object sender, EventArgs e)
        {
            if (!_dataFilled) return;
            _indexObject.Name = txtIndexName.Text.Trim();            
            MakeSQL();
        }

        private void cbUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (_dataFilled)
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
             if (_dataFilled)
                MakeSQL();
        }

        private void rbSort_CheckedChanged(object sender, EventArgs e)
        {
             if (_dataFilled)
                MakeSQL();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_dataFilled)
            {
                _tableObject = (TableClass) cbTables.SelectedItem;
                DataToCBFields();
                lvFields.Items.Clear();
                MakeSQL();
            }
        }

        private void ckActive_CheckedChanged(object sender, EventArgs e)
        {
            if (_dataFilled)
                MakeSQL();
        }

        private void cbSorting_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             if (_dataFilled)
                MakeSQL();
        }
    }
}
