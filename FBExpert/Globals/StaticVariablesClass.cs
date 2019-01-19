using System;
using System.Text;
using System.Windows.Forms;
using FBXpert.DataClasses;
using MessageLibrary;

namespace FBXpert.Globals
{
    static class StaticVariablesClass
    {
        public static object FbRelationTypeIndex { get; internal set; }

        public static string ToMark(bool ft)
        {
            return ft ? "*" : "";
        }
                       
        public static string GetConstraintTypeStr(eConstraintType ct)
        {
            switch (ct)
            {
                case eConstraintType.NOTNULL:
                    return ("NOT NULL");
                case eConstraintType.PRIMARYKEY:
                    return "PRIMARY KEY";
                case eConstraintType.UNIQUE:
                    return "UNIQUE";
            }
            return string.Empty;
        }

        public static string GetTriggerTypeStr(eTriggerType ct)
        {
            switch (ct)
            {
                case eTriggerType.afterInsert:
                    return ("AFTER INSERT");
                case eTriggerType.beforeInsert:
                    return ("BEFORE INSERT");
                case eTriggerType.afterUpdate:
                    return ("AFTER UPDATE");
                case eTriggerType.beforeUpdate:
                    return ("BEFORE UPDATE");
                case eTriggerType.afterDelete:
                    return ("AFTER DELETE");
                case eTriggerType.beforeDelete:
                    return ("BEFORE DELETE");

                case eTriggerType.afterInsertOrUpdate:
                    return ("AFTER INSERT OR UPDATE");
                case eTriggerType.beforeInsertOrUpdate:
                    return ("BEFORE INSERT OR UPDATE");

                case eTriggerType.afterInsertOrDelete:
                    return ("AFTER INSERT OR DELETE");
                case eTriggerType.beforeInsertOrDelete:
                    return ("BEFORE INSERT OR DELETE");

                case eTriggerType.afterInsertOrUpdateOrDelete:
                    return ("AFTER INSERT OR UPDATE OR DELETE");
                case eTriggerType.beforeInsertOrUpdateOrDelete:
                    return ("BEFORE INSERT OR UPDATE OR DELETE");
                                
            }
            return string.Empty;
        }

        public static eConstraintType GetConstraintType(string ct)
        {
            switch (ct.ToUpper())
            {
                case "NOT NULL":
                    return eConstraintType.NOTNULL;
                case "PRIMARY KEY":
                    return eConstraintType.PRIMARYKEY;
                case "UNIQUE":
                    return eConstraintType.UNIQUE;
            }

            return eConstraintType.NONE;
        }

        public static string CompleteRawType(string name, int length)
        {
            if(name.ToUpper().StartsWith("VARCHAR"))
            {
                return ("VARCHAR(" + length.ToString() + ")");
            }
            return name.ToUpper();
        }

        public static string ConvertINTERNALType_TO_SQLType(string name, int length)
        {
            switch (name)
            {
                case "LONG":
                    return "INTEGER"; //HE
                    switch (length)
                    {
                        case 4: return "INTEGER";
                    }

                    break;
                case "INT64":
                    return "BIGINT"; //HE
                    switch (length)
                    {
                        case 8: return "BIGINT";
                    }

                    break;
                case "TIMESTAMP":
                    return "TIMESTAMP"; //HE
                    switch (length)
                    {
                        case 8: return "TIMESTAMP";
                    }

                    break;
                case "TIME":
                    return "TIME";
                default:
                    if ((name == "VARYING")||(name.StartsWith("ISO"))||(name.StartsWith("UTF")) || (name.StartsWith("ASCII")) || (name.StartsWith("TEXT")))
                    {
                        return "VARCHAR(" + length + ")";
                    }
                    else if (name == "DOUBLE")
                    {
                        return "DOUBLE PRECISION"; //HE
                        switch (length)
                        {
                            case 8: return "DOUBLE PRECISION";
                        }
                    }
                    else if (name == "DATE")
                    {
                        return "DATE";
                    }
                    else if (name == "SHORT")
                    {
                        return "NUMERIC";
                    }
                    else if (name == "FLOAT")
                    {
                        return "FLOAT";
                    }
                    else if (name == "BOOLEAN")
                    {
                        return "BOOLEAN";
                    }
                    else if (name == "BLOB")
                    {
                        return "BLOB";
                    }

                    break;
            }
            NotifiesClass.Instance().AddToERROR("Datatype:"+name+" not defined !!! (StaticVariables->ConvertType)");
            return "UNDEFINED";
        }

        public static string ConvertDesignType(string name, int length)
        {
            if (name == "LONG")
            {
                switch (length)
                {
                    case 4: return "NUMBER";
                }
            }
            else if (name == "TIMESTAMP")
            {
                switch (length)
                {
                    case 8: return "TIMESTAMP";
                }
            }
            else if (name == "VARYING")
            {
                return "VARCHAR2";

            }
            else if (name == "DOUBLE")
            {
                switch (length)
                {
                    case 8: return "DOUBLE PRECISION";
                }

            }
            else if (name == "DATE")
            {
                return "DATE";
            }
            else if (name == "TIME")
            {
                return "TIME";
            }
            else if (name == "SHORT")
            {
                return "NUMBER";
            }
            else if (name == "BOOLEAN")
            {
                return "BOOLEAN";
            }
            else if (name == "BLOB")
            {
                return "BLOB";
            }
            NotifiesClass.Instance().AddToERROR("Datatype:" + name + " not defined !!! (StaticVariables->ConvertDiesignType)");
            return "UNDEFINED";
        }

        public static string ConvertRawTypeToRawName(string name)
        {            
            if (name.StartsWith("VARCHAR")|| name.StartsWith("TEXT"))
            {
                return ("VARCHAR");                
            }
            else if (name.StartsWith("INT64"))
            {
                return ("BIGINT");
            }
            else if (name.StartsWith("BOOLEAN"))
            {
                return ("BOOLEAN");
            }
            else if (name.StartsWith("BLOB"))
            {
                return ("BLOB");
            }
            else if (name.StartsWith("VARYING"))
            {
                return ("VARCHAR");
            }
            else if (name.StartsWith("NUMERIC"))
            {
                return ("NUMERIC");
            }
            else if (name.StartsWith("INTEGER")|| name.StartsWith("LONG"))
            {
                return ("INTEGER");
            }
            else if (name.StartsWith("SMALLINT"))
            {
                return ("SMALLINT");
            }
            else if (name.StartsWith("SHORT"))
            {
                return ("SMALLINT");
            }
            else if (name.StartsWith("TIMESTAMP"))
            {
                return ("TIMESTAMP");
            }
            else if (name.StartsWith("DATE"))
            {
                return ("DATE");
            }
            else if (name.StartsWith("TIME"))
            {
                return ("TIME");
            }
            else if (name.StartsWith("DOUBLE"))
            {
                return ("DOUBLE PRECISION");
            }
            return "";
        }
       
        public static string ConvertRawNameToRawType(string name)
        {            
            if (name.StartsWith("VARCHAR")|| name.StartsWith("TEXT"))
            {
                return ("VARYING");                
            }
            else if (name.StartsWith("BIGINT"))
            {
                return ("INT64");
            }
            else if (name.StartsWith("LONG"))
            {
                return ("INT64");
            }
            else if (name.StartsWith("BOOLEAN"))
            {
                return ("BOOLEAN");
            }
            else if (name.StartsWith("BLOB"))
            {
                return ("BLOB");
            }
            else if (name.StartsWith("VARCHAR"))
            {
                return ("VARYING");
            }
            else if (name.StartsWith("NUMERIC"))
            {
                return ("NUMERIC");
            }
            else if (name.StartsWith("INTEGER"))
            {
                return ("INTEGER");
            }
            else if (name.StartsWith("SMALLINT"))
            {
                return ("SMALLINT");
            }
            else if (name.StartsWith("SHORT"))
            {
                return ("SMALLINT");
            }
            else if (name.StartsWith("TIMESTAMP"))
            {
                return ("TIMESTAMP");
            }
            else if (name.StartsWith("DATE"))
            {
                return ("DATE");
            }
            else if (name.StartsWith("TIME"))
            {
                return ("TIME");
            }
            else if (name.StartsWith("DOUBLE"))
            {
                return ("DOUBLE PRECISION");
            }
            return "";
        }

        public static int GetRawTypeLength(string name)
        {
            if (!name.StartsWith("VARCHAR")) return 0;
            int pos1 = name.IndexOf('(');
            int pos2 = name.IndexOf(')');
            if (pos2 <= pos1) return 0;
            string nstr = name.Substring(pos1, pos2 - pos1);
            return int.Parse(nstr);
        }

        public static bool HasRawLength(string name)
        {
            return name.StartsWith("VARCHAR");
        }

        public static int ConvertRawTypeToPrecision(string name)
        {
            if (!name.StartsWith("NUMERIC")) return 0;
            int pos1 = name.IndexOf('(');
            int pos2 = name.IndexOf(')');
            if (pos2 <= pos1) return 0;
            string nstr = name.Substring(pos1, pos2 - pos1);
            return int.Parse(nstr);

        }

        public static Encoding ConvertTextToEncoding(string enc)
        {
            if (enc.ToUpper() == "NONE")
            {
                return Encoding.Default;
            }
            else
            {
                if (enc.ToUpper() == "UTF8")
                {
                    return Encoding.UTF8;
                }
            }

            return Encoding.Default;
        }
        
        public const string TablesKeyStr = "TABLES";
        public const string SystemTablesKeyStr = "SYSTEM_TABLES";
        public const string ViewsKeyGroupStr = "VIEWS_GROUP";
        public const string ViewsKeyStr = "VIEWS";
        public const string ConstraintsViewsKeyGroupStr = "CONSTRAINTS_VIEWS_GROUP";
        public const string ConstraintsViewsKeyStr = "CONSTRAINTS_VIEWS";
        public const string CommonTablesKeyGroupStr = "TABLES_GROUP";
        public const string SystemTablesKeyGroupStr = "SYSTEM_TABLES_GROUP";
        public const string FieldsKeyStr = "FIELDS";
        public const string FieldsKeyGroupStr = "FIELDS_GROUP";
        public const string ViewFieldsKeyStr = "VIEWFIELDS";
        public const string ViewFieldsKeyGroupStr = "VIEWFIELDS_GROUP";
        public const string ForeignKeyStr = "FOREIGNKEYS";
        public const string ForeignKeyGroupStr = "FOREIGNKEYS_GROUP";
        public const string ConstraintsKeyStr = "CONSTRAINTS";
        public const string UniqueConstraintsKeyStr = "UNIQUE_CONSTRAINTS";
        public const string ConstraintsKeyGroupStr = "CONSTRAINTS_GROUP";
        public const string ChecksKeyStr = "CHECKS";
        public const string ChecksKeyGroupStr = "CHECKS_GROUP";
        public const string RolesKeyStr = "ROLES";
        public const string RolesKeyGroupStr = "ROLES_GROUP";
        public const string GeneratorsKeyStr = "GENERATORS";
        public const string GeneratorsKeyGroupStr = "GENERATORS_GROUP";
        public const string ProceduresKeyStr = "PROCEDURES";
        public const string ProceduresKeyGroupStr = "PROCEDURES_GROUP";
        
        public const string FunctionsKeyStr = "FUNCTIONS";        
        public const string FunctionsKeyGroupStr = "FUNCTIONS_GROUP";
        public const string UserDefinedFunctionsKeyStr = "USER_DEFINED_FUNCTIONS";        
        public const string UserDefinedFunctionsKeyGroupStr = "USER_DEFINED_FUNCTIONS_GROUP";

        public const string TriggersKeyStr = "TRIGGERS";
        public const string TriggersKeyGroupStr = "TRIGGERS_GROUP";
        public const string IndicesKeyStr = "INDICES";
        public const string IndicesKeyGroupStr = "INDICES_GROUP";
        public const string PrimaryKeyStr = "PRIMARYKEYS";
        public const string PrimaryKeyGroupStr = "PRIMARYKEYS_GROUP";
        public const string UniquesKeyStr = "UNIQUESS";
        public const string UniquesKeyGroupStr = "UNIQUESS_GROUP";
        public const string NotNullKeyStr = "NOTNULL";
        public const string NotNullKeyGroupStr = "NOTNULL_GROUP";
        public const string DatabaseKeyStr = "DATABASE";
        public const string DomainsKeyStr = "DOMAINS";
        public const string DomainsKeyGroupStr = "DOMAINS_GROUP";
        public const string DependenciesKeyStr = "DEPENDENCY";
        public const string DependenciesKeyGroupStr = "DEPENDENCY_GROUP";
        public const string DependenciesTablesKeyStr = "DEPENDENCYTABLES";
        public const string DependenciesTablesKeyGroupStr = "DEPENDENCYTABLES_GROUP";
        public const string DependenciesToTablesKeyStr = "DEPENDENCYTOTABLES";
        public const string DependenciesToTablesKeyGroupStr = "DEPENDENCYTOTABLES_GROUP";
        public const string DependenciesFromTablesKeyStr = "DEPENDENCYFROMTABLES";
        public const string DependenciesFromTablesKeyGroupStr = "DEPENDENCYFROMTABLES_GROUP";
        public const string DependenciesToKeyStr = "DEPENDENCYTO";
        public const string DependenciesToKeyGroupStr = "DEPENDENCYTO_GROUP";
        public const string DependenciesFromKeyStr = "DEPENDENCYFROM";
        public const string DependenciesFromKeyGroupStr = "DEPENDENCYFROM_GROUP";
        public const string DependenciesTriggersKeyStr = "DEPENDENCYTRIGGERS";
        public const string DependenciesTriggersKeyGroupStr = "DEPENDENCYTRIGGERS_GROUP";
        public const string DependenciesToTriggersKeyStr = "DEPENDENCYTOTRIGGERS";
        public const string DependenciesToTriggersKeyGroupStr = "DEPENDENCYTOTRIGGERS_GROUP";
        public const string DependenciesFromTriggersKeyStr = "DEPENDENCYFROMTRIGGERS";
        public const string DependenciesFromTriggersKeyGroupStr = "DEPENDENCYFROMTRIGGERS_GROUP";
        public const string DependenciesViewsKeyStr = "DEPENDENCYVIEWS";
        public const string DependenciesViewsKeyGroupStr = "DEPENDENCYVIEWS_GROUP";
        public const string DependenciesToViewsKeyStr = "DEPENDENCYTOVIEWS";
        public const string DependenciesToViewsKeyGroupStr = "DEPENDENCYTOVIEWS_GROUP";
        public const string DependenciesFromViewsKeyStr = "DEPENDENCYFROMVIEWS";
        public const string DependenciesFromViewsKeyGroupStr = "DEPENDENCYFROMVIEWS_GROUP";

        public const string DependenciesProceduresKeyStr = "DEPENDENCYPROCEDURES";
        public const string DependenciesProceduresKeyGroupStr = "DEPENDENCYPROCEDURES_GROUP";
        public const string DependenciesToProceduresKeyStr = "DEPENDENCYTOPROCEDURES";
        public const string DependenciesToProceduresKeyGroupStr = "DEPENDENCYTOPROCEDURES_GROUP";
        public const string DependenciesFromProceduresKeyStr = "DEPENDENCYFROMPROCEDURES";
        public const string DependenciesFromProceduresKeyGroupStr = "DEPENDENCYFROMPROCEDURES_GROUP";


        public static readonly string ScriptPath = Application.StartupPath + "\\scripts";
        public static readonly string ReportPath = Application.StartupPath + "\\reports";
        public static readonly string InitialTerminator = ";";
        public static readonly string AlternativeTerminator = "~";
        public static readonly string SingleLineComment = "--";
        public static readonly string CommentStart = "/*";
        public static readonly string CommentEnd = "*/";
        public static readonly string Collation = "NONE";
        public static readonly string NullStr = "null";
        public static readonly string ASCStr = "ASCENDING";
        public static readonly string DECStr = "DESCENDING";
        public static readonly string UNIQUEStr = "UNIQUE";
        public static readonly string CREATEStr = "CREATE";

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
