using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using System.Text;

namespace FBXpert.SQLStatements
{
    public class IndexSQLStatementsClass : SQLStatementsBase
    {       
        private static readonly object _lock_this = new object();
        private static volatile IndexSQLStatementsClass instance = null;

        public static IndexSQLStatementsClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new IndexSQLStatementsClass();
                }
            }
            return (instance);
        }

        public IndexSQLStatementsClass()
        {
           
        }
        
        public SQLCommandsReturnInfoClass ActivateIndex(string name, DBRegistrationClass dbReg, NotifiesClass notify)
        {
              string cmd = SQLPatterns.ActivateIndexPattern.Replace(SQLPatterns.IndexKey, name);
              
              return ExecSql(cmd, dbReg,notify);  
        }

        public SQLCommandsReturnInfoClass DeactivateIndex(string name, DBRegistrationClass dbReg, NotifiesClass notify)
        {
              string cmd = SQLPatterns.DeactivateIndexPattern.Replace(SQLPatterns.IndexKey, name);                                       
              return ExecSql(cmd, dbReg,notify);  
        }

        public SQLCommandsReturnInfoClass DropIndex(string name, DBRegistrationClass dbReg, NotifiesClass notify)
        {
              string cmd = SQLPatterns.DropIndexPattern.Replace(SQLPatterns.IndexKey, name);                                 
              return ExecSql(cmd, dbReg,notify);  
        }
        
        public string GetIndiciesByName(string indexName)
        {
            return GetTableFieldIndicies(Version, indexName);
        }

        public string GetIndiciesByName(eDBVersion version, string indexName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT RDB$INDICES.RDB$RELATION_NAME,RDB$INDICES.RDB$INDEX_NAME AS Index_Name,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME AS Field_Name,");
            sb.Append("RDB$INDICES.rdb$unique_flag AS Unique_Flag,RDB$INDICES.rdb$index_inactive AS Inactive_Flag,RDB$INDICES.RDB$INDEX_TYPE ");
            sb.Append("FROM RDB$INDEX_SEGMENTS ");
            sb.Append("JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("LEFT JOIN RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.rdb$field_position = (RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) AND RDB$INDEX_SEGMENTS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.rdb$field_name ");
            sb.Append("LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"WHERE UPPER(RDB$INDICES.RDB$INDEX_NAME) = '{indexName}';");                        
            return sb.ToString();
        }

        public string GetTableFieldIndicies(string tableName)
        {
            return GetTableFieldIndicies(Version, tableName);
        }

        public string GetTableFieldIndicies(eDBVersion version, string tableName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT RDB$INDICES.RDB$INDEX_NAME AS Index_Name,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME AS Field_Name ,RDB$INDICES.rdb$unique_flag AS Unique_Flag,RDB$INDICES.rdb$index_inactive AS Inactive_Flag ");
            sb.Append("FROM RDB$INDEX_SEGMENTS ");
            sb.Append("JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("LEFT JOIN RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.rdb$field_position = (RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) AND RDB$INDEX_SEGMENTS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.rdb$field_name ");
            sb.Append("LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"WHERE UPPER(RDB$INDICES.RDB$RELATION_NAME) = '{tableName}' ");
            sb.Append("GROUP BY RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$index_type,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive;");            
            return sb.ToString();
        }

        public string GetTableIndicies(string tableName)
        {
            return GetTableIndicies(Version, tableName);
        }

        public string GetTableIndicies(eDBVersion version, string tableName)
        {                   
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT RDB$INDICES.RDB$INDEX_NAME AS Index_Name ,RDB$INDICES.rdb$unique_flag AS Unique_Flag,RDB$INDICES.rdb$index_inactive AS Inactive_Flag ");
            sb.Append("FROM RDB$INDEX_SEGMENTS ");
            sb.Append("JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"WHERE UPPER(RDB$INDICES.RDB$RELATION_NAME) = '{tableName}' ");
            sb.Append("GROUP BY RDB$INDICES.RDB$INDEX_NAME,RDB$INDICES.rdb$index_type,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive;");            
            return sb.ToString();                        
        }

        public string GetAllIndicies(eTableType tableType)
        {
            return GetAllIndicies(Version,tableType);
        }

        public string GetAllIndicies(eDBVersion version, eTableType tableType)
        {
            var sb = new StringBuilder();
            sb.Append("SELECT RDB$INDICES.RDB$RELATION_NAME, RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive,RDB$INDICES.rdb$index_type,RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE ");
            sb.Append("FROM RDB$INDEX_SEGMENTS JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("LEFT JOIN RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.rdb$field_position = (RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) AND RDB$INDEX_SEGMENTS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.rdb$field_name ");
            sb.Append("LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            string str = (tableType == eTableType.system) 
                ? "WHERE RDB$INDICES.RDB$SYSTEM_FLAG > 0 AND RDB$INDICES.RDB$FOREIGN_KEY IS NULL "
                : "WHERE RDB$INDICES.RDB$SYSTEM_FLAG = 0 AND RDB$INDICES.RDB$FOREIGN_KEY IS NULL ";
            sb.Append(str);            
            sb.Append("GROUP BY RDB$INDICES.RDB$RELATION_NAME,RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$index_type,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive,RDB$INDICES.rdb$index_type,RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE ");
            sb.Append("ORDER BY RDB$INDICES.RDB$RELATION_NAME, RDB$INDICES.RDB$INDEX_NAME;");
            return sb.ToString();           
        }

        public string GetAllIndiciesWithoutRefConstraints(eDBVersion version, eTableType tableType)
        {
            var sb = new StringBuilder();
            sb.Append("SELECT RDB$INDICES.RDB$RELATION_NAME, RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive,RDB$INDICES.rdb$index_type,RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE ");
            sb.Append("FROM RDB$INDEX_SEGMENTS JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("LEFT JOIN RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.rdb$field_position = (RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) AND RDB$INDEX_SEGMENTS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.rdb$field_name ");
            sb.Append("LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            string str = (tableType == eTableType.system) 
                ? "WHERE RDB$INDICES.RDB$SYSTEM_FLAG > 0 AND RDB$INDICES.RDB$FOREIGN_KEY IS NULL AND RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE IS NULL "
                : "WHERE RDB$INDICES.RDB$SYSTEM_FLAG = 0 AND RDB$INDICES.RDB$FOREIGN_KEY IS NULL AND RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE IS NULL ";
            sb.Append(str);            
            sb.Append("GROUP BY RDB$INDICES.RDB$RELATION_NAME,RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$index_type,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive,RDB$INDICES.rdb$index_type,RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE ");
            sb.Append("ORDER BY RDB$INDICES.RDB$RELATION_NAME, RDB$INDICES.RDB$INDEX_NAME;");
            return sb.ToString();           
        }
        
        /*
        public string GetAllSystemIndicies()
        {
            return GetAllSystemIndicies(Version);
        }

        public string GetAllSystemIndicies(int version)
        {

            var sb = new StringBuilder();
            sb.Append("SELECT RDB$INDICES.RDB$RELATION_NAME, RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive ");
            sb.Append("FROM RDB$INDEX_SEGMENTS JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("LEFT JOIN RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.rdb$field_position = (RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) AND RDB$INDEX_SEGMENTS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.rdb$field_name ");
            sb.Append("LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append("WHERE RDB$INDICES.RDB$SYSTEM_FLAG > 0 ");            
            sb.Append("GROUP BY RDB$INDICES.RDB$RELATION_NAME,RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$index_type,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive ");
            sb.Append("ORDER BY RDB$INDICES.RDB$RELATION_NAME, RDB$INDICES.RDB$INDEX_NAME;");
            return sb.ToString();
        }
        */
    }
}
