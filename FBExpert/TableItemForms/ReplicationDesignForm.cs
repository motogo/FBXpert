﻿using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class ReplicationDesignForm : IEditForm
    {
        
        DBRegistrationClass _dbReg = null;
        string IndexName = string.Empty;
        string TableName = string.Empty;
        int messages_count = 0;
        int error_count = 0;
        NotifiesClass _localNotify = new NotifiesClass();
        AutocompleteClass ac = null;
        
        
        
           

        public ReplicationDesignForm(Form parent, DBRegistrationClass dbReg)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
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
          
        }

        bool DataFilled = false;       
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
         
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void DataToEdit()
        {
           
        }

        string oldIndexName = string.Empty;
        
        private void ReplicationDesignForm_Load(object sender, EventArgs e)
        {            
            DataToEdit();
         
            //RefreshDependenciesTo();
            MakeSQL();
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.RefreshAutocompleteForDatabase();
        }
       
        public void ShowCaptions()
        {
            lblTableName.Text = "Index: " + IndexName;
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Index");
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (DataFilled)
                MakeSQL();
        }

        

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {                      
            var _sql = new SQLScriptingClass(_dbReg,"SCRIPT",_localNotify);
            var riList =_sql.ExecuteCommands(fctSQL.Lines); 
            
            var riFailure = riList.Find(x=>x.commandDone = false);                                    
            oldIndexName = IndexName;
                       
            string info = (riFailure==null) 
                ? $@"Replication {_dbReg.Alias} updated." 
                : $@"Replication {_dbReg.Alias} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";
                                            
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadIndex,$@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);  


            if (DataFilled) MakeSQL();
        }

        


        string NewIndexName = string.Empty;
       
    }
}
