using FBXpert.Globals;
using Initialization;
using System;
using System.IO;

namespace FBXpert.DataClasses
{

    public class BehavierSettingsClass
    {
        public int DebugThreshold = 2;
    }
    [Serializable]
    public class CodeSettingsClass
    {
        
        public eSourceCodePrimaryKeyType SourceCodePrimaryKeyType= eSourceCodePrimaryKeyType.GeneratorInteger;
        public string SourceCodeNamespace = "ProjectDatas";  
        public string SourceCodeOutputPath= "";       

        public CodeSettingsClass()
        {

        }
    }


    [Serializable]
    public class SQLVariablesClass
    {

        
        public string InitialTerminator = StaticVariablesClass.InitialTerminator;
        public string AlternativeTerminator = StaticVariablesClass.AlternativeTerminator;
        public string SingleLineComment = StaticVariablesClass.SingleLineComment;
        public string CommentStart = StaticVariablesClass.CommentStart;
        public string CommentEnd = StaticVariablesClass.CommentEnd;
        public string NewLine = Environment.NewLine;
        public long SkipForSelect = 1000;
        public long MaxRowsForSelect = 0;

        public string GetNewLine()
        {
            return NewLine; //.Replace("<NewLine>", Environment.NewLine);
        }
        public string GetNewLineString()
        {
            return NewLine.Replace(Environment.NewLine, "<NewLine>" );
        }
        
        public void SetNewLine(string nline)
        {
            NewLine = nline.Replace("<NewLine>",Environment.NewLine);
        }
        
        public SQLVariablesClass()
        {

        }
    }


    public class DatabaseSettingsClass
    {
        public int DefaultPacketSize = 8192;
        public string DefaultUser = "SYSDBA";
        public string DefaultPassword = "masterkey";
        public int DefaultPort = 3050;
        public int OpenDatabaseCount = 1;

    }
    public class PathSettingsClass
    {
        public string ScriptingPath=string.Empty;
        public string TempPath=string.Empty;
        public string InfoPath = $@"{ApplicationPathClass.Instance.ApplicationPath}\Info";
        public string ExportPath = string.Empty;
        public string SQLExportPath = string.Empty;
        public string SQLHistoryPath = string.Empty;
        public string DatabasesConfigPath = string.Empty;
        public string DatabaseConfigFile = "DatabaseDefinitions.xml";
    }

    [Serializable]
    public sealed class AppSettingsClass
    {
        public string Path = string.Empty;
        //private static readonly object _lock_this = new object();
       // private static volatile AppSettingsClass instance = null;

        

        private static readonly Lazy<AppSettingsClass> lazy = new Lazy<AppSettingsClass>(() => new AppSettingsClass());
        public static AppSettingsClass Instance
        {
            get
            {
                return lazy.Value;
            }
            
        }
        public AppSettingsClass()
        {
            //CodeSettings = new CodeSettingsClass();
            SQLVariables = new SQLVariablesClass();
            DatabaseSettings = new DatabaseSettingsClass();
            PathSettings = new PathSettingsClass();
            BehavierSettings = new BehavierSettingsClass();
            Stamp = DateTime.Now;
        }

        

        public void Load(AppSettingsClass appSettings)
        {
            
            

            this.Stamp = appSettings.Stamp;
            //this.CodeSettings = appSettings.CodeSettings;
            this.SQLVariables = appSettings.SQLVariables;   
            this.DatabaseSettings = appSettings.DatabaseSettings;
            this.PathSettings = appSettings.PathSettings;
            this.BehavierSettings = appSettings.BehavierSettings;

            this.Path = appSettings.Path;
            this.PathSettings.ScriptingPath         = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.ScriptingPath);
            this.PathSettings.TempPath              = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.TempPath);
            this.PathSettings.DatabasesConfigPath   = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.DatabasesConfigPath);
            this.PathSettings.SQLExportPath         = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.SQLExportPath);
            this.PathSettings.InfoPath              = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.InfoPath);
            this.PathSettings.SQLHistoryPath        = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.SQLHistoryPath);
            this.PathSettings.ExportPath            = ApplicationPathClass.Instance.GetFullPath(appSettings.PathSettings.ExportPath);



            /*
            instance = appSettings.MemberwiseClone() as AppSettingsClass;
            instance.Path = appSettings.Path;
            instance.PathSettings.ScriptingPath = ApplicationPathClass.GetFullPath(appSettings.PathSettings.ScriptingPath);
            instance.PathSettings.TempPath = ApplicationPathClass.GetFullPath(appSettings.PathSettings.TempPath);
            instance.PathSettings.DatabasesConfigPath = ApplicationPathClass.GetFullPath(appSettings.PathSettings.DatabasesConfigPath);
            */
        }

        public void SaveSettings()
        {
            fastJSON.JSON.Parameters.UseExtensions = true;
            AppSettingsClass appsetting = new AppSettingsClass();

            appsetting.PathSettings = this.PathSettings;
            //appsetting.CodeSettings = this.CodeSettings;
            appsetting.DatabaseSettings = this.DatabaseSettings;
            appsetting.BehavierSettings = this.BehavierSettings;

            appsetting.PathSettings.DatabasesConfigPath = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.DatabasesConfigPath);
            appsetting.PathSettings.TempPath            = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.TempPath);
            appsetting.PathSettings.ScriptingPath       = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.ScriptingPath);
            appsetting.PathSettings.SQLHistoryPath      = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.SQLHistoryPath);
            appsetting.PathSettings.InfoPath            = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.InfoPath);
            appsetting.PathSettings.SQLExportPath       = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.SQLExportPath);
            appsetting.PathSettings.ExportPath          = ApplicationPathClass.Instance.GetAppBegriff(this.PathSettings.ExportPath);
            appsetting.Path = this.Path;
            appsetting.Stamp = DateTime.Now;
            
            string jsonText = fastJSON.JSON.ToNiceJSON(appsetting);
            File.WriteAllText(appsetting.Path, jsonText);
        }
        

        public DateTime Stamp;
        //public CodeSettingsClass CodeSettings;
        public SQLVariablesClass SQLVariables;
        public DatabaseSettingsClass DatabaseSettings;
        public PathSettingsClass PathSettings;
        public BehavierSettingsClass BehavierSettings;
    }
}
