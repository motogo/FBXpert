using DBBasicClassLibrary;
using FBXpert.DataClasses;
using Initialization;
using System;
using System.Windows.Forms;

namespace FBXpert.Globals
{
    [Serializable]

    
    public class DBRegistrationClass : ConnectionAttributes
    {        
        public int Position;
        public string Alias;                
        public string Collation = StaticVariablesClass.Collation;                
        public bool Active;
        public string Role;

        //public string InitialSQLExportPath      = StaticVariablesClass.SQLExportPath;
       // public string InitialInfoPath = StaticVariablesClass.ExperienceInfoPath;
       //public string InitialScriptingPath      = StaticVariablesClass.ScriptPath;
       // public string InitialReportPath         = StaticVariablesClass.ReportPath;
       // public string InitialExportPath         = StaticVariablesClass.ExportPath;
       /*
        public string InitialTerminator         = StaticVariablesClass.InitialTerminator;
        public string AlternativeTerminator     = StaticVariablesClass.AlternativeTerminator;
        public string SingleLineComment         = StaticVariablesClass.SingleLineComment;
        public string CommentStart              = StaticVariablesClass.CommentStart;
        public string CommentEnd                = StaticVariablesClass.CommentEnd;
        public string NewLine                   = Environment.NewLine;
        public long SkipForSelect    = 1000;
        public long MaxRowsForSelect = 0;
       */ 
        public eRegState State = eRegState.none;
        public eDBVersion Version = eDBVersion.FB3_32;
        private string _firebirdBinaryPath = $@"{ApplicationPathClass.Instance.ApplicationPath}\FB302\Firebird\";
        
        public CodeSettingsClass CodeSettings;        
        private ErrorCodes ErrorCodes = null;
        private TreeNode _treeNode;


        public DBRegistrationClass()
        {
            long tks =  DateTime.Now.Ticks / 10000000;
            this.Alias = $@"new_database_{tks.ToString()}";
            this.DatabasePath = $@"{this.Alias}.fdb";
            this.Server = "localhost";
            this.ConnectionType = eConnectionType.server;
            this.CodeSettings = new CodeSettingsClass();
            this.ErrorCodes = new ErrorCodes();
            
            string pf = $@"{AppSettingsClass.Instance.PathSettings.DatabasesConfigPath}\ErrorCodes{this.Version}.txt";
            this.ErrorCodes.Load(pf);
           
        }

        private bool isOpen = false;
        public bool IsOpen()
        {
            return isOpen;
        }

        public string AliasAsFileName
        {
            get
            {
                return Alias.Replace(" ", "_").Trim();
            }
        }

        public ErrorCodes GetErrorCodes()
        {
            return ErrorCodes;
        }

        public new DBRegistrationClass Clone()
        {
            return this.MemberwiseClone() as DBRegistrationClass;            
        }
        
        public override string ToString()
        {            
            return String.Format("{0,-30} ({1}) V{2}",  Alias, GetFullDatabasePath() , Version);
        }

        public string GetCaption(int cnt)
        {
            
            return (ConnectionType == eConnectionType.embedded) ? $@"{Alias} open:{cnt - 1}, embedded" : $@"{Alias} open:{cnt - 1}";
        }
        public string GetCaption()
        {
            return (ConnectionType == eConnectionType.embedded) ? $@"{Alias} , embedded" : $@"{Alias}";
        }

        public void SetNode(TreeNode tn)
        {
            _treeNode = tn;
        }

        public TreeNode GetNode()
        {
            return _treeNode;
        }

        public string GetFirebirdBinaryPath()
        {
            return _firebirdBinaryPath;
            
        }
        public void SetFirebirdBinaryPath(string value)
        {
            _firebirdBinaryPath = value;
        }

        public string MakeServerFromText(string txtDatabase)
        {
            // Servers
            //   //192.168.11.11:D:\test\test.fdb
            //   192.168.11.11:D:\test\test.fdb

            // Embedded
            //   D:\test\test.fdb
            //   \\192.168.11.99\test\test.fdb
            if (ConnectionType == eConnectionType.server)
            {
                string txt = txtDatabase.Trim();
                if (txt.StartsWith("//")) txt = txt.Substring(2);
                string server = string.Empty;


                int inxf = txt.IndexOf(":");
                int inxl = txt.LastIndexOf(":");
                if (inxf == inxl)
                {
                    // normaler dateipfad und kein embedded -> localhost
                    server = $@"localhost";
                }
                else
                {
                    // ip:dateipfad
                    server = txt.Substring(0, inxf);
                }
                return server;
            }

            //embedded
            return string.Empty;
        }
        public string MakeDatabasepathFromText(string txtDatabase)
        {
            string txt = txtDatabase.Trim();
            int inxf = txt.IndexOf(":");
            int inxl = txt.LastIndexOf(":");
            string path = string.Empty;
            if (inxf == inxl)
            {
                // normaler dateipfad und kein embedded -> localhost
                path = txt;
            }
            else
            {
                // ip:dateipfad
                path = txt.Substring(inxf + 1);
            }
            return path;
        }

    
    }
}
