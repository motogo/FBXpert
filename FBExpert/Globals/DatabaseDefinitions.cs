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
        public EditStateClass.eDataState DataState = EditStateClass.eDataState.UnSaved;

        public List<DBRegistrationClass> Databases = new List<DBRegistrationClass>();  

        //		public Image Pic;

        public DatabaseDefinitions()
        {
            //
            // TODO: Hier die Konstruktorlogik einfügen
            //



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
        public void TestParams()
        {
            string error_str = "";



            if (error_str.Length > 0)
                MessageBox.Show(error_str, "Configuration structure error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


        public void MoveUp(TreeNode tnReg)
        {
            if (tnReg == null) return;
            if (tnReg.PrevNode == null) return;

            int inx1  = Databases.FindIndex(x => x.Alias == tnReg.Text);
            int inx2  = Databases.FindIndex(x => x.Alias == tnReg.PrevNode.Text);
            DBRegistrationClass dbr1 = (DBRegistrationClass) Databases[inx1].Clone();
            DBRegistrationClass dbr2 = (DBRegistrationClass) Databases[inx2].Clone();

            int pos = dbr1.Position;
            dbr1.Position = dbr2.Position;
            dbr2.Position = pos;
            Databases[inx1] = dbr2;
            Databases[inx2] = dbr1;
            DataState = EditStateClass.eDataState.UnSaved;
        }

        public void MoveDown(TreeNode tnReg)
        {               
            if (tnReg == null) return;
            if (tnReg.NextNode == null) return;
            int inx1  = Databases.FindIndex(x => x.Alias == tnReg.NextNode.Text);
            int inx2  = Databases.FindIndex(x => x.Alias == tnReg.Text);
            DBRegistrationClass dbr1 = (DBRegistrationClass) Databases[inx1].Clone();
            DBRegistrationClass dbr2 = (DBRegistrationClass) Databases[inx2].Clone();

            int pos = dbr1.Position;
            dbr1.Position = dbr2.Position;
            dbr2.Position = pos;
            Databases[inx1] = dbr2;
            Databases[inx2] = dbr1;
            DataState = EditStateClass.eDataState.UnSaved;
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
                
                foreach (DBRegistrationClass dbr in this.Databases)
                {
                    if (string.IsNullOrEmpty(dbr.InitialScriptingPath)) dbr.InitialScriptingPath = StaticVariablesClass.ScriptPath;
                    if (string.IsNullOrEmpty(dbr.InitialReportPath))    dbr.InitialReportPath = StaticVariablesClass.ReportPath;
                    if (string.IsNullOrEmpty(dbr.Collation)) dbr.Collation = StaticVariablesClass.Collation;
                    if (string.IsNullOrEmpty(dbr.CommentEnd)) dbr.CommentEnd = StaticVariablesClass.CommentEnd;
                    if (string.IsNullOrEmpty(dbr.CommentStart)) dbr.CommentStart = StaticVariablesClass.CommentStart;
                    if (string.IsNullOrEmpty(dbr.InitialTerminator)) dbr.InitialTerminator = StaticVariablesClass.InitialTerminator;
                    if (string.IsNullOrEmpty(dbr.AlternativeTerminator)) dbr.AlternativeTerminator = StaticVariablesClass.AlternativeTerminator;
                    if (string.IsNullOrEmpty(dbr.SingleLineComment)) dbr.SingleLineComment = StaticVariablesClass.SingleLineComment;
                }
                
                if (PF.Reason == null) PF.Reason = "none";
                this.Reason = PF.Reason;
                DataState = EditStateClass.eDataState.Saved;
               
                TestParams();                
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

        public void SerializeDefault(string path)
        {
            this.Reason = "Default";
            this.Databases = new List<DBRegistrationClass>();
            var dbr = new DBRegistrationClass
            {
                Position = 1,
                CharSet = "NONE",
                DatabasePath = "D:\\temp\\test.fdb",
                Alias = "D:\\temp\\test.fdb",
                Password = "'masterkey'",
                User = "SYSDBA",
                Active = true
            };

            this.Databases.Add(dbr);

            var dbr2 = new DBRegistrationClass
            {
                Position = 2,
                CharSet = "NONE",
                DatabasePath = "D:\\temp\\test3.fdb",
                Alias = "D:\\temp\\test3.fdb",
                Password = "'masterkey'",
                User = "SYSDBA",
                Active = false
            };
            this.Databases.Add(dbr2);

            this.XMLName = path;
            this.SerializeCurrent("default");
            DataState = EditStateClass.eDataState.Saved;
        }
    
        public void SerializeCurrent(string reason)
        {            
            Stream writer = new FileStream(this.XMLName, FileMode.Create);                        
            var serializer = new XmlSerializer(typeof(DatabaseDefinitions));
            var q1 = new XmlQualifiedName("", "");
            XmlQualifiedName[] names = { q1 };
            var test = new XmlSerializerNamespaces(names);
            this.Reason = reason;
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

        public bool DeleteDB(string AliasName)
        {
            int n = -1;
            for(int i = 0; i < Databases.Count; i++)
            {
                var dbr = Databases[i];
                if(dbr.Alias == AliasName)
                {
                    n = i;
                    break;
                }
            }
            if(n >= 0)
            {
                Databases.RemoveAt(n);
                return true;
            }
            return false;
        }
    }
}
