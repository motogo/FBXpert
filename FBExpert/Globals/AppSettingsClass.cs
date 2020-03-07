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
        public string AlternativeTerm = "~";
        public eSourceCodePrimaryKeyType SourceCodePrimaryKeyType= eSourceCodePrimaryKeyType.GeneratorInteger;
        public string SourceCodeNamespace = "ProjectDatas";  
        public string SourceCodeOutputPath= "";
        public CodeSettingsClass()
        {

        }
    }
    public class DatabaseSettingsClass
    {
        public int DefaultPacketSize = 8192;
        public string DefaultUser = "SYSDBA";
        public string DefaultPassword = "masterkey";
    }
    public class PathSettingsClass
    {
      //  public string DesignClassesOutputPath=string.Empty;
        public string ScriptingPath=string.Empty;
        public string TempPath=string.Empty;
        public string DatabasesConfigPath = string.Empty;
        public string DatabaseConfigFile = "DatabaseDefinitions.xml";
    }

    [Serializable]
    public class AppSettingsClass
    {
        public string Path = string.Empty;
        private static readonly object _lock_this = new object();
        private static volatile AppSettingsClass instance = null;
        public static AppSettingsClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new AppSettingsClass();
                }
            }
            return (instance);
        }
        public AppSettingsClass()
        {
            CodeSettings = new CodeSettingsClass();
            DatabaseSettings = new DatabaseSettingsClass();
            PathSettings = new PathSettingsClass();
            BehavierSettings = new BehavierSettingsClass();
            Stamp = DateTime.Now;
        }

        

        public void Load(AppSettingsClass appSettings)
        {
            instance = appSettings.MemberwiseClone() as AppSettingsClass;
            instance.Path = appSettings.Path;
            instance.PathSettings.ScriptingPath = ApplicationPathClass.GetFullPath(appSettings.PathSettings.ScriptingPath);
            instance.PathSettings.TempPath = ApplicationPathClass.GetFullPath(appSettings.PathSettings.TempPath);
            instance.PathSettings.DatabasesConfigPath = ApplicationPathClass.GetFullPath(appSettings.PathSettings.DatabasesConfigPath);

            
        }

        public void SaveSettings()
        {
            fastJSON.JSON.Parameters.UseExtensions = true;

            AppSettingsClass appsetting = instance.MemberwiseClone() as AppSettingsClass;            
            appsetting.PathSettings.DatabasesConfigPath = ApplicationPathClass.GetPathCode(instance.PathSettings.DatabasesConfigPath);
            appsetting.PathSettings.TempPath = ApplicationPathClass.GetPathCode(instance.PathSettings.TempPath);
            appsetting.PathSettings.ScriptingPath = ApplicationPathClass.GetPathCode(instance.PathSettings.ScriptingPath);

            string jsonText = fastJSON.JSON.ToNiceJSON(appsetting);

            //  File.WriteAllText(Application.StartupPath + "\\config\\AppSettings.json", jsonText);
            File.WriteAllText(appsetting.Path, jsonText);
        }

        public DateTime Stamp;
        public CodeSettingsClass CodeSettings;
        public DatabaseSettingsClass DatabaseSettings;
        public PathSettingsClass PathSettings;
        public BehavierSettingsClass BehavierSettings;
    }
}
