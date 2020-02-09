using FBXpert;
using FBXpert.Globals;
using Initialization;
using MessageLibrary;
using StateClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace FBExpert
{
    [Serializable]
    public class DatabaseDefinitions : ApplicationPathClass
    {
        public string Reason;
        public int OpenDatabaseCount = 0;
        private EditStateClass.eDataState _dataState = EditStateClass.eDataState.UnSaved;
        public EditStateClass.eDataState DataState
        {
            get
            { 
                return _dataState;
            }
            set
            {
                _dataState = value;
            }            
        } 

        public List<DBRegistrationClass> Databases = new List<DBRegistrationClass>();  
      
        public DatabaseDefinitions()
        {
           
        }
        private static readonly object _lock_this = new object();
        private static volatile DatabaseDefinitions instance = null;
        public static DatabaseDefinitions Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new DatabaseDefinitions();
                }
            }
            return (instance);
        }

        public void MarkDatabasesActiv(bool active)
        {                        
            foreach (var datab in Databases)
            {                   
                datab.Active = active;
            }                                                            
        }



        public bool IsRegistration(TreeNode nd)
        {
            if(nd?.Tag == null) return false;
            return (nd.Tag.GetType() == typeof(DBRegistrationClass));
        }

        public void Rebuild(TreeView tv)
        {
            Databases.Clear();
            foreach (TreeNode tn in tv.Nodes)
            {
                if (tn == null) continue;
                if (!(tn.Tag is DBRegistrationClass dbReg)) continue;                 
                DBRegistrationClass dbreg = (DBRegistrationClass) tn.Tag;
                Databases.Add(dbreg);               
            }
        }        

        public void MoveUp(TreeView treeView)
        {
            TreeNode tn = treeView.SelectedNode.PrevNode;
            int idx = tn.NextNode.Index;
            if (tn.Level != 0)
            {
                int pidx = tn.Parent.Index;
                treeView.Nodes.Remove(tn);
                treeView.Nodes[pidx].Nodes.Insert(idx, tn);
                treeView.Focus();
            }
            else
            {
                treeView.Nodes.Remove(tn);
                treeView.Nodes.Insert(idx, tn);
            }
            Rebuild(treeView);
            DataState = EditStateClass.eDataState.UnSaved;
        }

        public void MoveDown(TreeView treeView)
        {
            TreeNode tn = treeView.SelectedNode;
            int idx = tn.NextNode.Index;

            if (tn.Level != 0)
            {
                int pidx = tn.Parent.Index;
                treeView.Nodes.Remove(tn);
                treeView.Nodes[pidx].Nodes.Insert(idx, tn);
                treeView.SelectedNode = tn;
                treeView.Focus();
            }
            else
            {
                treeView.Nodes.Remove(tn);
                treeView.Nodes.Insert(idx, tn);
                treeView.SelectedNode = tn;
            }
            Rebuild(treeView);
            DataState = EditStateClass.eDataState.UnSaved;
        }

        public int CountToOpen()
        {
            int n = 0;
            foreach(var db in Databases)
            {
                if(db.Active) n++;
            }
            return n;
        }
        
        public bool Deserialize(string FileName)
        {            
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DatabaseDefinitions));
                Stream fs = new FileStream(FileName, FileMode.Open);
                var reader = new XmlTextReader(fs);
                var PF = (DatabaseDefinitions)serializer.Deserialize(reader);
                reader.Close();
                this.XMLName = FileName;             
                this.Databases = PF.Databases;
                this.OpenDatabaseCount = PF.OpenDatabaseCount;
                
                foreach (DBRegistrationClass dbr in this.Databases)
                {
                    if (string.IsNullOrEmpty(dbr.InitialScriptingPath))     dbr.InitialScriptingPath = StaticVariablesClass.ScriptPath;
                    if (string.IsNullOrEmpty(dbr.InitialReportPath))        dbr.InitialReportPath = StaticVariablesClass.ReportPath;
                    if (string.IsNullOrEmpty(dbr.Collation))                dbr.Collation = StaticVariablesClass.Collation;
                    if (string.IsNullOrEmpty(dbr.CommentEnd))               dbr.CommentEnd = StaticVariablesClass.CommentEnd;
                    if (string.IsNullOrEmpty(dbr.CommentStart))             dbr.CommentStart = StaticVariablesClass.CommentStart;
                    if (string.IsNullOrEmpty(dbr.InitialTerminator))        dbr.InitialTerminator = StaticVariablesClass.InitialTerminator;
                    if (string.IsNullOrEmpty(dbr.AlternativeTerminator))    dbr.AlternativeTerminator = StaticVariablesClass.AlternativeTerminator;
                    if (string.IsNullOrEmpty(dbr.SingleLineComment))        dbr.SingleLineComment = StaticVariablesClass.SingleLineComment;                  
                }
                
                if (PF.Reason == null) PF.Reason = "none";
                this.Reason = PF.Reason;
                DataState = EditStateClass.eDataState.Saved;
                                               
            }
            catch(Exception ex)
            {                
                Debug.WriteLine(ex.Message);
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseConfigurationCaption","CannotLoadDatabaseConfiguration",SEMessageBoxButtons.OK,SEMessageBoxIcon.Exclamation,null,new object[]{ Environment.NewLine, FileName });                  
                return false;
            }
            finally
            {

            }
            return true;
        }
            
        public void SerializeCurrent(string reason)
        {            
            Stream writer = new FileStream(this.XMLName, FileMode.Create);                        
            var serializer = new XmlSerializer(typeof(DatabaseDefinitions));
            var q1 = new XmlQualifiedName("", "");
            XmlQualifiedName[] names = { q1 };
            var test = new XmlSerializerNamespaces(names);
            this.Reason = reason;
            this.OpenDatabaseCount = instance.OpenDatabaseCount;
            this.Databases = instance.Databases;
            serializer.Serialize(writer, instance, test);
            writer.Close();
            DataState = EditStateClass.eDataState.Saved;
        }

        public void Serialize(string fn, string reason)
        {
            this.XMLName = fn;
            SerializeCurrent(reason);            
        }
        
    }
}
