using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBBasicClassLibrary;
using FastColoredTextBoxNS;
using FBExpert.DataClasses;
using FBXpert.DataClasses;

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
        
        public string InitialScriptingPath      = StaticVariablesClass.ScriptPath;
        public string InitialReportPath         = StaticVariablesClass.ReportPath;
        public string InitialTerminator         = StaticVariablesClass.InitialTerminator;
        public string AlternativeTerminator     = StaticVariablesClass.AlternativeTerminator;
        public string SingleLineComment         = StaticVariablesClass.SingleLineComment;
        public string CommentStart              = StaticVariablesClass.CommentStart;
        public string CommentEnd                = StaticVariablesClass.CommentEnd;
        public string NewLine                   = Environment.NewLine;
        public long SkipForSelect    = 1000;
        public long MaxRowsForSelect = 0;
        
        public eRegState State = eRegState.none;
        public eDBVersion Version = eDBVersion.FB3_32;
        public string FirebirdBinaryPath = $@"{Application.StartupPath}\FB302\Firebird\";
        public CodeSettingsClass CodeSettings;        
        private ErrorCodes ErrorCodes = null;
        private TreeNode _treeNode;

       
        

        

        public DBRegistrationClass()
        {
            long tks =  DateTime.Now.Ticks / 10000000;
            this.Alias = $@"new_database_{tks.ToString()}";
            this.DatabasePath = $@"{this.Alias}.fdb";
            this.Server = "localhost";
            this.ConnectionType = eConnectionType.localhost;
            this.CodeSettings = new CodeSettingsClass();
            this.ErrorCodes = new ErrorCodes();
            string pf = $@"{AppSettingsClass.Instance().PathSettings.DatabasesConfigPath}\ErrorCodes{this.Version}.txt";
            this.ErrorCodes.Load(pf);
           
        }

        private bool isOpen = false;
        public bool IsOpen()
        {
            return isOpen;
        }

        public ErrorCodes GetErrorCodes()
        {
            return ErrorCodes;
        }

        public new DBRegistrationClass Clone()
        {
            return this.MemberwiseClone() as DBRegistrationClass;            
        }

        public string GetDatabasepfad()
        {
            string srvstr = string.Empty;
            if(ConnectionType == eConnectionType.server)
            {
                srvstr =  $@"//{Server}:{DatabasePath}";
            }
            else if(ConnectionType == eConnectionType.localhost)
            {
                srvstr =  $@"//{Server}:{DatabasePath}";
            }
            if(ConnectionType == eConnectionType.embedded)
            {
                srvstr =  $@"{DatabasePath}";
            }
            return srvstr;
        }

        public override string ToString()
        {            
            return String.Format("{0,-30} ({1}) V{2}",  Alias, GetDatabasepfad() , Version);
        }
        
        public void SetNode(TreeNode tn)
        {
            _treeNode = tn;
        }

        public TreeNode GetNode()
        {
            return _treeNode;
        }        
    }
}
