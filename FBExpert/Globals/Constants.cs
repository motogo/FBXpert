using System.Windows.Forms;

namespace FBXpert.Globals
{
    public static class Constants
    {
        public static readonly string ScriptPath = Application.StartupPath + "\\scripts";
        public static readonly string ReportPath = Application.StartupPath + "\\reports";
        public static readonly string InitialTerminator = ";";
        public static readonly string AlternativeTerminator = "~";
        public static readonly string SingleLineComment = "--";
        public static readonly string CommentStart = "/*";
        public static readonly string CommentEnd = "*/";
        public static readonly string Collation = "NONE";

        public static readonly string DatabaseConfigDataSaved = "CONFIG_DATA_SAVED";
        public static readonly string ReloadIndex = "RELOAD_INDEX";
        public static readonly string ReloadAllIndex = "RELOAD_ALL_INDEX";
        public static readonly string ReloadConstraits = "RELOAD_CONSTRAINTS";
        public static readonly string ReloadAllConstraits = "RELOAD_ALL_CONSTRAINTS";
        public static readonly string ReloadForeignKeys = "RELOAD_FOREIGNKEYS";
        public static readonly string ReloadAllForeignKeys = "RELOAD_ALL_FOREIGNKEYS";
        public static readonly string ReloadAllViews = "RELOAD_ALL_VIEWS";
        public static readonly string ReloadViews = "RELOAD_VIEWS";
        public static readonly string ReloadDomains = "RELOAD_DOMAINS";
        public static readonly string ReloadFunctions = "RELOAD_FUNCTIONS";
        public static readonly string ReloadUserDefinedFunctions = "RELOAD_USER_DEFINED_FUNCTIONS";
        public static readonly string ReloadGenerators = "RELOAD_GENERATORS";
        public static readonly string ReloadProcedures = "RELOAD_PROCEDURES";
        public static readonly string ReloadAllTables = "RELOAD_ALL_TABLES";
        public static readonly string ReloadTable = "RELOAD_TABLE";
        public static readonly string ReloadFields = "RELOAD_FIELDS";
        public static readonly string ReloadTriggers = "RELOAD_TRIGGERS";
        public static readonly string StartLoadDatabases = "START_LOAD_DATABASES";
        public static readonly string EndLoadDatabases = "END_LOAD_DATABASES";
        public static readonly string CommandDone = "COMMAND_DONE";
        public static readonly string CommandPrepared = "COMMAND_PREPARED";
        public static readonly string AddCommandLine = "ADD_COMMAND_LINE";


    }
}
