﻿using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class FunctionForm : IEditForm
    {
        FunctionClass FunctionObject = null;
        FunctionClass OldFunctionObject = null;
        DBRegistrationClass _dbReg = null;
        AutocompleteClass ac = null;
        TreeNode Tn = null;
        ContextMenuStrip Cm = null;
        NotifiesClass _localNotify = new NotifiesClass();
        int messages_count = 0;
        int error_count = 0;
        bool DoEvents = false;
        public FunctionForm(Form parent, DBRegistrationClass dbReg, TreeNode tn, ContextMenuStrip cm,StateClasses.EditStateClass.eBearbeiten mode)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Cm = cm;
            Tn = tn;
            
            try
            {
                BearbeitenMode = mode;
               
                if(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert)
                {                    
                    FunctionObject = new FunctionClass();
                    FunctionObject.Name = "NEW_FUNCTION";
                }
                else
                {
                    FunctionObject = (FunctionClass)tn.Tag;
                }
            }
            catch
            {
                Console.WriteLine(" ");
            }
            OldFunctionObject = (FunctionClass) FunctionObject.Clone();
                                   
            _dbReg = dbReg;
            _localNotify.Notify.OnRaiseErrorHandler += Notify_OnRaiseErrorHandler;
            _localNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler;
           
            cbDatatype.Items.Clear();
                        
            DBTypeList dbList = new DBTypeList();
            foreach(DBDataTypes dt in dbList.Values)
            {
                cbDatatype.Items.Add(dt);
            }

            DoEvents = true;
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
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0) sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        public void MakeSQL()
        {            
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                SQLScript = StaticTreeClass.MakeSQLAlterFunction(FunctionObject,OldFunctionObject,true);
            }
            else
            {
                SQLScript = StaticTreeClass.MakeSQLCreateFunction(FunctionObject,true);
            }
            SQLToUI(SQLScript);
            ShowCaptions();
            hsCreate.Enabled = (txtFuncName.Text.Length > 0);
        }

        

        public List<string> SQLScript = new List<string>();

        public void SQLToUI(List<string> SQLScript)
        {
            fctSQL.Clear();
            foreach (string str in SQLScript)
            {
               fctSQL.AppendText(str + Environment.NewLine);
            }
        }

        

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
           txtFuncName.Enabled = true;      
        }

        public override void DataToEdit()
        {
            DoEvents = false;
            txtFuncName.Text = FunctionObject.Name;                       
            fctGenDescription.Text = FunctionObject.Description;            
            lvFields.Items.Clear();
            for (int i = 0; i < FunctionObject.ParameterIn.Count; i++)
            {                
                var pc = FunctionObject.ParameterIn[i];
                string[] columns = { "IN",pc.Name,pc.RawType };
                var lvi = new ListViewItem(columns);               
                var pci = new ParameterListItem();
                pci.direction = eParameterTypDirection.din;
                pci.pc = pc;
                lvi.Tag = pci;
                lvFields.Items.Add(lvi);
            }

            for (int i = 0; i < FunctionObject.ParameterOut.Count; i++)
            {                
                var pc = FunctionObject.ParameterOut[i];
                string[] columns = {"OUT",pc.Name,pc.RawType };
                var lvi = new ListViewItem(columns);
                var pci = new ParameterListItem();
                pci.direction = eParameterTypDirection.dout;
                pci.pc = pc;
                lvi.Tag = pci;               
                lvFields.Items.Add(lvi);
            }

            for (int i = 0; i < FunctionObject.Source.Count; i++)
            {
               fcbFunctionDefinitionSQL.AppendText($@"{FunctionObject.Source[i]}{Environment.NewLine}");
            }
            DoEvents = true;
        }
        public void EditToData()
        {
            
        }
               
        private void FunctionForm_Load(object sender, EventArgs e)
        {                        
            DataToEdit();
            SetEnables();            
            MakeSQL();
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForFunction();
        }

        public void ShowCaptions()
        {
            lblCaption.Text = (FunctionObject != null) ? $@"Function:{FunctionObject.Name}" : "Function";            
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Function");
        }

        private void txtGenName_TextChanged(object sender, EventArgs e)
        {
            if (!DoEvents) return;
            
            FunctionObject.Name = txtFuncName.Text.Trim();
            if(BearbeitenMode != StateClasses.EditStateClass.eBearbeiten.eInsert) BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;
            MakeSQL();               
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (!DoEvents) return;
            FunctionObject.Description = fctGenDescription.Text;
            MakeSQL();
        }

        private void Create()
        {                                    
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines);                   
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
           
            
            string info = (riFailure==null) 
                ? $@"Foreign key for {_dbReg.Alias}->{FunctionObject.Name} updated." 
                : $@"Foreign key for {_dbReg.Alias}->{FunctionObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadFunctions,$@"->Proc:{Name}->Create");
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

        private void cmsParameters_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiAddInputParameter)
            {

            }
            else if(e.ClickedItem == tsmiAddOutputParameter)
            {

            }
            else if(e.ClickedItem == tsmiDropParameter)
            {

            }
        }
      
        private void lvFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFields.SelectedItems.Count <= 0) return;
            
            var lvi = lvFields.SelectedItems[0];
            if (lvi == null) return;
            
            var pc = lvi.Tag as ParameterListItem;
            txtDatatypeLength.Text = pc.pc.Length.ToString();
            txtParameter.Text = pc.pc.Name;
            if (pc.direction == eParameterTypDirection.din)
            {
                rbIN.Checked = true;
            }
            else if (pc.direction == eParameterTypDirection.dout)
            {
                rbOUT.Checked = true;
            }
            else
            {
                rbVAR.Checked = true;
            }
            txtParameter.Enabled = !rbOUT.Checked;                                  
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if (saveSQLFile.ShowDialog() != DialogResult.OK) return;            
            fctSQL.SaveToFile(saveSQLFile.FileName, Encoding.UTF8);              
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;            
            fctSQL.OpenFile(ofdSQL.FileName);               
        }

        private void hsNew_Click(object sender, EventArgs e)
        {
            FunctionObject = new FunctionClass();
            FunctionObject.Name = "NEW_FUNCTION";
            var pc = new ParameterClass();
            pc.Name = "";
            pc.RawType = "INTEGER";
            pc.FieldType = "LONG";
            pc.TypeNumber = 8;
            pc.Length = 4;
            pc.Precision = 0;

            FunctionObject.ParameterOut.Add(pc);
            pc = new ParameterClass();
            
            pc.Name = "XX";
            pc.RawType = "INTEGER";
            pc.FieldType = "LONG";
            pc.TypeNumber = 8;
            pc.Length = 4;
            pc.Precision = 0;
            FunctionObject.ParameterIn.Add(pc);
            FunctionObject.Description = "";
            OldFunctionObject = (FunctionClass) FunctionObject.Clone();
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            DataToEdit();
            MakeSQL();
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
