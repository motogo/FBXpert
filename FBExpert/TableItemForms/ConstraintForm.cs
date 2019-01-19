using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.MiscClasses;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FBXpert.Globals;

namespace FBXpert
{
    public partial class ConstraintForm : IEditForm
    {
        
        DBRegistrationClass _dbReg = null;
        string IndexName = string.Empty;
        string TableName = string.Empty;
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        TableClass TableObject;
        
        
           

        public ConstraintForm(Form parent, string indexName,  DBRegistrationClass dbReg)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
            _dbReg = dbReg;
                      
            IndexName = indexName;
            NewIndexName = indexName;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;
            TableName = RefreshIndicesAndGetTablename();
            TableObject = StaticTreeClass.GetTableObjectForConstraintForm(_dbReg, TableName);
            
        }
        public ConstraintForm(Form parent, TableClass tableObject,  DBRegistrationClass dbReg)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
            _dbReg = dbReg;
                      
            IndexName = $@"{tableObject.Name}_inx1";
            NewIndexName = $@"{tableObject.Name}_inx1";
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;
            TableName = tableObject.Name;
            TableObject = tableObject;
            DataFilled = true;
         //   TableName = RefreshIndicesAndGetTablename();
         //   TableObject = StaticTreeClass.GetTableObjectForConstraintForm(_dbReg, TableName);
            lvFields.Items.Clear();
            txtIndexName.Text = IndexName.Trim();
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
            ShowCaptions();
            Application.DoEvents();
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
                sb.Append($@"ALTER TABLE {TableName} ADD PRIMARY KEY ");
                bool firstdone = false;
                string fieldStr = string.Empty;
                fieldStr+="(";
                foreach (ListViewItem lvi in lvFields.Items)
                {
                    if (firstdone)
                    {
                        fieldStr += ",";
                    }

                    string st = lvi.Text;

                    fieldStr += st;
                    firstdone = true;
                }
                fieldStr+=")";
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
                sb.Append("INDEX ");
                sb.Append(txtIndexName.Text.Trim());
                sb.Append(" ON ");
                sb.Append(TableName);
                sb.Append("(");

                bool firstdone = false;
                foreach (ListViewItem lvi in lvFields.Items)
                {
                    if (firstdone)
                    {
                        sb.Append(",");
                    }

                    string st = lvi.Text;

                    sb.Append(st);
                    firstdone = true;
                }
                sb.Append(");");
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add("COMMIT;");
            SQLToUI();

        }

        bool DataFilled = false;

        public string RefreshIndicesAndGetTablename()
        {
            string cmd_index = SQLStatements.Instance().GetIndiciesByName(_dbReg.Version, IndexName.Trim());
            DataFilled = false;
            txtIndexName.Text = IndexName.Trim();
            string TableName = string.Empty;
            try
            {
                lvFields.Items.Clear();
               
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                con.Open();
                string PkColumn = string.Empty;
                string IndexName = string.Empty;
                string IndexColumnName = string.Empty;
                int Unique = 0;

                FbCommand fcmd = new FbCommand(cmd_index, con);
                var dread = fcmd.ExecuteReader();
                
                if (dread.HasRows)
                {
                    while (dread.Read())
                    {
                        TableName = dread.GetValue(0).ToString().Trim();
                        IndexColumnName = dread.GetValue(2).ToString().Trim();
                        Unique = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);
                        cbUnique.Checked = Unique > 0;
                        string[] lv = new string[1];
                        lv[0] = IndexColumnName;
                        
                        ListViewItem lvi = new ListViewItem(lv);
                        lvFields.Items.Add(lvi);
                                            
                    }
                    DataFilled = true;
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
              _localNotify?.AddToERROR(StaticFunctionsClass.DateTimeNowStr() + "->ConstraintForm->RefreshIndices()->" + ex.Message);
            }

            return TableName;
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
          //  ckPrimary.Checked = false;
          //  ckPrimary.Visible = false;
            SQLScript.Clear();
            StringBuilder sb = new StringBuilder();
            /*
            CREATE UNIQUE INDEX TLAGERDEF_IDX1
            ON TLAGERDEF(TLAGER_ID, POSX, POSY, POSZ)
            */
            sb.Append("DROP INDEX ");
            sb.Append(oldIndexName+";"+Environment.NewLine);
            sb.Append("COMMIT;" + Environment.NewLine);

            if (ckPrimary.Checked)
            {
                sb.Append($@"ALTER TABLE {TableName} ADD PRIMARY KEY ");
                bool firstdone = false;
                string fieldStr = string.Empty;
                fieldStr+="(";
                foreach (ListViewItem lvi in lvFields.Items)
                {
                    if (firstdone)
                    {
                        fieldStr += ",";
                    }

                    string st = lvi.Text;

                    fieldStr += st;
                    firstdone = true;
                }
                fieldStr+=")";
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
                sb.Append("INDEX ");
                sb.Append(NewIndexName);
                sb.Append(" ON ");
                sb.Append(TableName);
                sb.Append("(");

                bool firstdone = false;
                foreach(ListViewItem lvi in lvFields.Items)
                {
                    if(firstdone)
                    {
                        sb.Append(",");
                    }

                    string st = lvi.Text;

                    sb.Append(st);
                    firstdone = true;
                }
                sb.Append(");");            
            }
            SQLScript.Add(sb.ToString());
            SQLScript.Add("COMMIT;");
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void DataToEdit()
        {
           cbFields.Items.Clear();
           
           foreach (TableFieldClass field in  TableObject.Fields.Values)
           {
                cbFields.Items.Add(field);
           }
           
            cbFields.SelectedIndex = 0;
        }

        string oldIndexName = string.Empty;
        
        private void ConstraintForm_Load(object sender, EventArgs e)
        {            
            DataToEdit();
            oldIndexName = txtIndexName.Text.Trim();
            //RefreshDependenciesTo();
            MakeSQL();
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForDatabase();
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
            if (lvFields.SelectedItems != null)
            {
                if (lvFields.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = lvFields.SelectedItems[0];
                    int inx = cbFields.FindString(lvi.Text);
                    cbFields.SelectedIndex = inx;
                }
            }
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
           
        }

        public void RegisterNotify(NotifyInfos.RaiseNotifyHandler infoN)
        {
           _localNotify.Notify.OnRaiseInfoHandler += infoN;
        }

        private void Create()
        {
           
                                  
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines); 
            
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
            oldIndexName = NewIndexName;
            if (DataFilled) MakeSQL();
           
            string info = (riFailure==null) 
                ? $@"Index {_dbReg.Alias}->{NewIndexName} updated." 
                : $@"Index {_dbReg.Alias}->{NewIndexName} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,Constants.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info,Constants.ReloadIndex,$@"->Proc:{Name}->Create");  
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


        string NewIndexName = string.Empty;
        string OldIndexName = string.Empty;
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
    }
}
