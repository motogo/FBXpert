﻿using BasicClassLibrary;
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
using System.Linq;
using FBXpert.SQLStatements;

namespace FBXpert
{
    public partial class NotNullForm : IEditForm
    {
        
        DBRegistrationClass _dbReg = null;
        string IndexName = string.Empty;
        string TableName = string.Empty;
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;

        ContextMenuStrip Cm=null;
        ContextMenuStrip CmGroup=null;
        TreeNode Tn=null;
        NotNullsClass NotNullObject = null;
        List<TableClass> Tables = new List<TableClass>();
        TableClass OrgTable = null;
        public NotNullForm(Form parent,  DBRegistrationClass dbReg, TreeNode tn, ContextMenuStrip cmGroup, ContextMenuStrip cm)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
            _dbReg = dbReg;
            Cm = cm;
            CmGroup = cmGroup;
            Tn = tn;
            
            TreeNode t = StaticTreeClass.FindPrevDBNode(Tn);
            TreeNode orgTableNode = StaticTreeClass.FindPrevTableNode(Tn);
            TreeNode TableNode = StaticTreeClass.FindFirstNodeInAllNodes(t,StaticVariablesClass.CommonTablesKeyGroupStr);

            //Bei insert 
            if (Tn.Tag == null)
            {
                NotNullObject = new NotNullsClass();
                NotNullObject.Name = "NEW_CNSTR";
                NotNullObject.ConstraintType = eConstraintType.NOTNULL;
            }
            else
            {
                NotNullObject = Tn.Tag as NotNullsClass;
            }

            if (orgTableNode != null)
            {
                OrgTable = orgTableNode.Tag as TableClass;
                NotNullObject.TableName = OrgTable.Name;
            }

            Tables = StaticTreeClass.GetTableObjectsFromNode(TableNode);

            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;
            
                   
        }

        public void ShowCaptions()
        {
            lblTableName.Text = (NotNullObject != null) ? $@"NotNullConstraint: {NotNullObject.Name}" : "NotNullConstraint";            
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Manage Constraints");
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

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }


        public void ShowUI()
        {
           
            
            
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

        

        bool DataFilled = false;

        public void RefreshIndices()
        {
            string cmd_index = IndexSQLStatementsClass.Instance().GetIndiciesByName(_dbReg.Version, IndexName.Trim());
            DataFilled = false;
            txtConstraintName.Text = IndexName.Trim();

            try
            {
               
               
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
                      
                        string[] lv = new string[1];
                        lv[0] = IndexColumnName;
                        
                        
                                            
                    }
                    DataFilled = true;
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
              _localNotify?.AddToERROR(StaticFunctionsClass.DateTimeNowStr() + "->NotNullForm->RefreshIndices()->" + ex.Message);
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

        public void MakeSQLNew()
        {
            SQLScript.Clear();
            
            SQLToUI();

        }

        public void MakeSQOAlter()
        {           
            SQLScript.Clear();
            
            SQLToUI();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void DataToEdit()
        {
           
            cbTable.Items.Clear();
            cbTable.Items.AddRange(Tables.ToArray());

           
            cbTable.Text = NotNullObject.TableName;
            TableClass tc = cbTable.SelectedItem as TableClass;
            cbFields.Items.Clear();
            cbFields.Items.AddRange(tc.Fields.Values.ToArray());
            lvFields.Items.Clear();
            foreach (string fn in NotNullObject.FieldNames.Values)
            {
                string[] st = new string[1];
                st[0] = fn;
                ListViewItem lvi = new ListViewItem(st);
                lvFields.Items.Add(lvi);
            }
            
            txtConstraintName.Text = NotNullObject.Name;
           
            txtINDEXName.Text = NotNullObject.IndexName;
            DataFilled = true;


        }


        public void SetUIControls()
        {
            
        }

        string OldConstraintName = string.Empty;
        
        private void NotNullForm_Load(object sender, EventArgs e)
        {
            DataToEdit();
            OldConstraintName = txtConstraintName.Text.Trim();
            NewConstraintName = OldConstraintName;
            
            //RefreshDependenciesTo();
            MakeSQL();
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForDatabase();
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
            

            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines); 
          
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
             OldConstraintName = NewConstraintName;
            if (DataFilled) MakeSQL();
            

            string info = (riFailure==null) 
                ? $@"NotNull {_dbReg.Alias}->{NewConstraintName} updated." 
                : $@"NotNull {_dbReg.Alias}->{NewConstraintName} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);  


        }

        private void hsAddField_Click(object sender, EventArgs e)
        {
            String fieldName = cbFields.SelectedItem.ToString();
            
        }

        private void hsRemoveField_Click(object sender, EventArgs e)
        {
            String fieldName = cbFields.SelectedItem.ToString();
           
        }


        string NewConstraintName = string.Empty;
        private void txtIndexName_TextChanged(object sender, EventArgs e)
        {
            NewConstraintName = txtConstraintName.Text.Trim();
            if (DataFilled)
            {
                MakeSQL();
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewTableName = cbTable.Text;
            if (DataFilled)
            {                
                MakeSQL();
            }
        }

        string NewFieldName = String.Empty;
        string NewTableName = String.Empty;
        private void cbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewFieldName = cbFields.Text;
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
            String fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind == null)
            {
                lvFields.Items.Add(lvi);
                if (DataFilled)
                {
                    MakeSQL();
                }
            }
        }

        private void hsRemoveField_Click_1(object sender, EventArgs e)
        {
            String fieldName = cbFields.SelectedItem.ToString();
            ListViewItem lvi = new ListViewItem(fieldName);
            ListViewItem lvifind = lvFields.FindItemWithText(fieldName);
            if (lvifind != null)
            {
                lvFields.Items.Remove(lvifind);
                if (DataFilled)
                {
                    MakeSQL();
                }
            }
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {           
            if (DataFilled)
            {
                MakeSQL();
            }
        }

        private void txtINDEXName_TextChanged_1(object sender, EventArgs e)
        {
            if (DataFilled)
            {
                MakeSQL();
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
    }    
}
