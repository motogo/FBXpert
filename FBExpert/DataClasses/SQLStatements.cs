using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace FBXpert.DataClasses
{

    public class SQLStatementsClass : SQLStatementsBase
    {
       
        private static readonly object _lock_this = new object();
        
        private static volatile SQLStatementsClass instance = null;

        public static SQLStatementsClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new SQLStatementsClass();
                }
            }
            return (instance);
        }

        public SQLStatementsClass()
        {
           
        }
       
        public SQLCommandsReturnInfoClass DropConstraint(string name, DBRegistrationClass dbReg, NotifiesClass notify)
        {
              string cmd =  SQLPatterns.DropConstraintPattern.Replace(SQLPatterns.ConstraintKey, name);
            
              return ExecSql(cmd, dbReg,notify);  
        }

        public string RefreshTablesCmd(eDBVersion version)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.FROM} RDB$RELATIONS ");
            if (version >= eDBVersion.FB3_32)
            {                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.Table}) ");
                sb.Append($@"AND (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%RDB$%') ");                               
            }
            else
            {                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%RDB$%') ");            
            }
            sb.Append($@"AND (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%IBE$%') ");
            sb.Append($@"AND (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%MON$%') "); 
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NA RIGHT OUTER JOIN ME;");                
            return sb.ToString();
        }

        public string RefreshTablesCmd()
        {
            return RefreshTablesCmd(Version);
        }

        public string FormatSQL(string sql)
        {
            string s = sql.ToUpper().Replace($@" {SQLConstants.FROM} ", $@"{Environment.NewLine} {SQLConstants.FROM} ");
            s = s.ToUpper().Replace($@" {SQLConstants.LEFT_OUTER_JOIN} ", $@"{Environment.NewLine} {SQLConstants.LEFT_OUTER_JOIN} ");
            s = s.ToUpper().Replace($@" {SQLConstants.LEFT_JOIN} ", $@"{Environment.NewLine} {SQLConstants.LEFT_JOIN} ");

            s = s.ToUpper().Replace($@" {SQLConstants.RIGHT_OUTER_JOIN} ", $@"{Environment.NewLine} {SQLConstants.RIGHT_OUTER_JOIN} ");
            s = s.ToUpper().Replace($@" {SQLConstants.RIGHT_JOIN} ", $@"{Environment.NewLine} {SQLConstants.RIGHT_JOIN} ");

            s = s.ToUpper().Replace($@" {SQLConstants.WHERE} ", $@"{Environment.NewLine} {SQLConstants.WHERE} ");

            return s;
        }

        public string GetTablesByNameCmd(eDBVersion version, string TableName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.FROM} RDB$RELATIONS ");
            if (version >= eDBVersion.FB3_32)
            {                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.Table}) {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME = '{TableName}');");                               
            }
            else
            {             
                sb.Append($@"{SQLConstants.WHERE} RDB$RELATIONS.RDB$RELATION_NAME = '{TableName}';");                                
            }
            return sb.ToString();
        }

        public string GetTablesByNameCmd(string TableName)
        {
            return GetTablesByNameCmd(Version,TableName);
        }

        public TableClass RefreshTableFields(TableClass tableObject, DBRegistrationClass dbReg, NotifiesClass notify )
        {            
            if (string.IsNullOrEmpty(tableObject.Name)) return tableObject;
                                    
            tableObject.Fields = new Dictionary<string, TableFieldClass>();                
            try
            {    
                using(TransactionScope c = new TransactionScope())
                {
                    using(var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(dbReg)))
                    {                
                        con.Open();
                        string cmd = SQLStatementsClass.Instance().GetTableFields(dbReg.Version, tableObject.Name);
                        var fcmd = new FbCommand(cmd, con);
                        var dread = fcmd.ExecuteReader();
                        if (dread.HasRows)
                        {
                            while (dread.Read())
                            {
                                var tfc = new TableFieldClass();
                                string TabName = dread.GetValue(0).ToString().Trim();
                                tfc.Name = dread.GetValue(1).ToString().Trim();
                                
                                tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                                tfc.Domain.FieldType = dread.GetValue(4).ToString().Trim();
                                tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                                tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                                tfc.Domain.Name = dread.GetValue(6).ToString().Trim();
                        
                                tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                                tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                                tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                                tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();
                                tfc.Domain.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;
                        
                                tfc.Domain.DefaultValue = dread.GetValue(13).ToString().Trim();
                                if(tfc.Domain.DefaultValue.Length > 0 )
                                {
                                    if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                                    {
                                        tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                                    }
                                    if(tfc.Domain.DefaultValue.Length > 1)
                                    {
                                        Console.WriteLine();
                                    }
                                }

                                tfc.Description = dread.GetValue(14).ToString().Trim();
                                tfc.Domain.Description = dread.GetValue(15).ToString().Trim();
                                if((tfc.Domain.Description.Length > 0)||(tfc.Description.Length > 0))
                                {
                                    Console.WriteLine();
                                }

                                bool PK = tableObject.IsPrimary(tfc.Name);
                                bool UQ = tableObject.IsUnique(tfc.Name);
                                bool NN = tableObject.IsNotNull(tfc.Name);

                                string[] obarr = { tfc.Position.ToString(), tfc.Name, tfc.Domain.FieldType, tfc.Domain.Length.ToString(), tfc.Domain.RawType, StaticVariablesClass.ToMark(NN), tfc.DefaultValue, tfc.Domain.Scale.ToString(), StaticVariablesClass.ToMark(PK), StaticVariablesClass.ToMark(UQ), tfc.Domain.CharSet, tfc.Domain.Collate, "1", tfc.Domain.Name, StaticVariablesClass.ToMark(NN), tfc.Domain.DefaultValue };
                                object[] obarr_export = { tfc.Position.ToString(), tfc.Name, !PK, PK };
                       
                                tableObject.Fields.Add(tfc.Name,tfc);
                            }
                        }                    
                        con.Close();
                    }
                    c.Complete();
                }
            }
            catch (Exception ex)
            {
              notify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"TypesClass->RefreshTypes({tableObject.Name})->{dbReg.Alias}", ex));                               
            }
               
            return tableObject;
        }

        public string RefreshViews()
        {
            return RefreshViews(Version);
        }

        public string RefreshViews(eDBVersion version)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME,");
            sb.Append($@"RDB$RELATIONS.RDB$VIEW_SOURCE,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_POSITION,");
            sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
            sb.Append($@"RDB$FIELDS.RDB$CHARACTER_LENGTH ");
            sb.Append($@"{SQLConstants.FROM} RDB$RELATIONS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.RDB$RELATION_NAME = RDB$RELATIONS.RDB$RELATION_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$FIELDS ON RDB$FIELDS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.RDB$FIELD_SOURCE ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
            if (version >= eDBVersion.FB3_32)
            {                                                                                                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.View}) {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%RDB$%') {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");                                
            }
            else
            {                                                                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$VIEW_SOURCE {SQLConstants.IS} NOT null) {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%RDB$%')  {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");                
            }
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            return sb.ToString();            
        }

        public string RefreshView(eDBVersion version, string viewname)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME,");
            sb.Append($@"RDB$RELATIONS.RDB$VIEW_SOURCE,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME ");
            sb.Append($@"{SQLConstants.FROM} RDB$RELATIONS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.RDB$RELATION_NAME = RDB$RELATIONS.RDB$RELATION_NAME ");
            if (version >= eDBVersion.FB3_32)
            {                                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.View}) {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME = '{viewname}') ");                            
            }
            else
            {                        
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$VIEW_SOURCE {SQLConstants.IS} NOT null) {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME = '{viewname}') ");                                
            }
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            return sb.ToString();
        }

        public string GetViewCmd(eDBVersion version, string vname)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME,");
            sb.Append($@"RDB$RELATIONS.RDB$VIEW_SOURCE,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME ");
            sb.Append($@"{SQLConstants.FROM} RDB$RELATIONS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.RDB$RELATION_NAME = RDB$RELATIONS.RDB$RELATION_NAME ");
            if (version >= eDBVersion.FB3_32)
            {                                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.View}) ");                
            }
            else
            {                                
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$VIEW_SOURCE {SQLConstants.IS} NOT null) ");                
            }
            sb.Append($@"AND (RDB$RELATIONS.RDB$RELATION_NAME =  '{vname}') ");                                
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            return sb.ToString();
        }
        
        public string RefreshNnonSystemGeneratorsItems()
        {
            return RefreshNonSystemGeneratorsItems(Version);
        }

        public string RefreshNonSystemGeneratorsItems(eDBVersion version)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$GENERATORS.RDB$GENERATOR_NAME,");
            if (version >= eDBVersion.FB3_32)
            {                
                sb.Append($@"RDB$GENERATORS.RDB$INITIAL_VALUE,");
                sb.Append($@"RDB$GENERATORS.RDB$GENERATOR_INCREMENT,");
                sb.Append($@"RDB$GENERATORS.RDB$DESCRIPTION ");
            }
            else
            {
                sb.Append($@"0,");
                sb.Append($@"1,");
                sb.Append($@"'' ");
            }
            sb.Append($@"{SQLConstants.FROM} RDB$GENERATORS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$GENERATORS.RDB$GENERATOR_NAME {SQLConstants.NOT_LIKE} '%$%';");
            return sb.ToString();
        }

        public string RefreshSystemGeneratorsItems()
        {
            return RefreshSystemGeneratorsItems(Version);
        }

        public string RefreshSystemGeneratorsItems(eDBVersion version)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$GENERATORS.RDB$GENERATOR_NAME,");
            if (version >= eDBVersion.FB3_32)
            {                                
                sb.Append($@"RDB$GENERATORS.RDB$INITIAL_VALUE,");
                sb.Append($@"RDB$GENERATORS.RDB$GENERATOR_INCREMENT,");
                sb.Append($@"RDB$GENERATORS.RDB$DESCRIPTION ");
            }
            else
            {
                sb.Append($@"0,");
                sb.Append($@"1,");
                sb.Append($@"'' ");
            }
            sb.Append($@"{SQLConstants.FROM} RDB$GENERATORS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$GENERATORS.RDB$GENERATOR_NAME {SQLConstants.LIKE} '%$%';");
            return sb.ToString();
        }

        public string RefreshRoles()
        {
            return RefreshRoles(Version);
        }

        public string RefreshRoles(eDBVersion version)
        {
            var sb = new StringBuilder();            
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$ROLES.RDB$ROLE_NAME ");
            sb.Append($@"{SQLConstants.FROM} RDB$ROLES;");
            return sb.ToString();
        }
               
        public string RefreshNonSystemTriggers()
        {
            return RefreshNonSystemTriggers(Version);
        }

        public string RefreshNonSystemTriggers(eDBVersion version)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$SYSTEM_FLAG,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_INACTIVE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_TYPE ");
            sb.Append($@"{SQLConstants.FROM} RDB$TRIGGERS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$TRIGGERS.RDB$SYSTEM_FLAG = 0 {SQLConstants.AND} RDB$TRIGGERS.RDB$TRIGGER_NAME {SQLConstants.NOT_LIKE} '%$%';");            
            return sb.ToString();
        }
        
        public string RefreshSystemTriggers()
        {
            return RefreshSystemTriggers(Version);
        }

        public string RefreshSystemTriggers(eDBVersion version)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$SYSTEM_FLAG,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_INACTIVE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_TYPE {SQLConstants.FROM} RDB$TRIGGERS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$TRIGGERS.RDB$SYSTEM_FLAG = 0 {SQLConstants.AND} RDB$TRIGGERS.RDB$TRIGGER_NAME {SQLConstants.LIKE} '%$%';");
            return sb.ToString();
        }

        public string RefreshInternalFunctionsItems()
        {
            return RefreshInternalFunctionsItems(Version);
        }
        
        public string RefreshInternalFunctionsItems(eDBVersion version)
        {            
            var sb = new StringBuilder();
            if (version >= eDBVersion.FB3_32)
            {
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_NAME,");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_TYPE,");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_SOURCE,");
                sb.Append($@"RDB$FUNCTIONS.RDB$MODULE_NAME,");
                sb.Append($@"RDB$FUNCTIONS.RDB$ENTRYPOINT ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTIONS WHERE RDB$FUNCTIONS.RDB$ENTRYPOINT {SQLConstants.IS} NULL;");
            }
            else
            {
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$PROCEDURES.RDB$PROCEDURE_NAME,");
                sb.Append($@"RDB$PROCEDURES.RDB$SYSTEM_FLAG,");
                sb.Append($@"RDB$PROCEDURES.RDB$PROCEDURE_SOURCE ");
                sb.Append($@"{SQLConstants.FROM} RDB$PROCEDURES;");
            }            
            return sb.ToString();
        }

        public string RefreshUserDefinedFunctionsItems(eDBVersion version)
        {
            var sb = new StringBuilder();
            if (version >= eDBVersion.FB3_32)
            {
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_NAME,");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_TYPE,");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_SOURCE,");
                sb.Append($@"RDB$FUNCTIONS.RDB$MODULE_NAME,");
                sb.Append($@"RDB$FUNCTIONS.RDB$ENTRYPOINT ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTIONS WHERE RDB$FUNCTIONS.RDB$ENTRYPOINT {SQLConstants.IS} NOT null;");
            }
            else
            {                
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_NAME,");
                sb.Append($@"RDB$FUNCTIONS.RDB$FUNCTION_TYPE,");
                sb.Append($@"RDB$FUNCTIONS.RDB$DESCRIPTION,");
                sb.Append($@"RDB$FUNCTIONS.RDB$MODULE_NAME,");
                sb.Append($@"RDB$FUNCTIONS.RDB$ENTRYPOINT ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTIONS WHERE RDB$FUNCTIONS.RDB$ENTRYPOINT {SQLConstants.IS} {SQLConstants.NOT_NULL} {SQLConstants.AND} RDB$FUNCTIONS.RDB$SYSTEM_FLAG = 0;");
            }
            return sb.ToString();
        }

        public string RefreshProcedureItems()
        {
            return RefreshProcedureItems(Version);
        }

        public string RefreshProcedureItems(eDBVersion version)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} RDB$PROCEDURES.RDB$PROCEDURE_NAME,RDB$PROCEDURES.RDB$PROCEDURE_SOURCE {SQLConstants.FROM} RDB$PROCEDURES;");            
            return sb.ToString();
        }

        public string RefreshTablePrimaryKeys(string tableName)
        {
            return RefreshTablePrimaryKeys(Version,tableName);
        }

        public string RefreshTablePrimaryKeys(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();

            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATION_CONSTRAINTS.rdb$constraint_name {SQLConstants.AS} Constraint_Name,");
            sb.Append($@"RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE {SQLConstants.AS} Constraint_Type,");
            sb.Append($@"RDB$INDEX_SEGMENTS.RDB$FIELD_NAME {SQLConstants.AS} FieldName,");
            sb.Append($@"RDB$INDICES.RDB$DESCRIPTION {SQLConstants.AS} Index_Description,");
            sb.Append($@"(RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) {SQLConstants.AS} Field_Position ");

            sb.Append($@"{SQLConstants.FROM} RDB$INDEX_SEGMENTS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$INDICES.RDB$RELATION_NAME) = '{tableName}' {SQLConstants.AND} RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE = 'PRIMARY KEY' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION;");
            
            return sb.ToString();
        }

        public string GetTabePrimaryKeys(string tableName)
        {
            return GetTablePrimaryKeys(Version, tableName);
        }

        public string GetTablePrimaryKeys(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();

            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATION_CONSTRAINTS.rdb$constraint_name {SQLConstants.AS} Constraint_Name,");
            sb.Append($@"RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE {SQLConstants.AS} Constraint_Type,");
            sb.Append($@"RDB$INDEX_SEGMENTS.RDB$FIELD_NAME {SQLConstants.AS} FieldName,");
            sb.Append($@"RDB$INDICES.RDB$DESCRIPTION {SQLConstants.AS} Index_Description,");
            sb.Append($@"(RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) {SQLConstants.AS} Field_Position ");

            sb.Append($@"{SQLConstants.FROM} RDB$INDEX_SEGMENTS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$INDICES.RDB$RELATION_NAME) = '{tableName}' {SQLConstants.AND} RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE = 'PRIMARY KEY' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION;");
            
            return sb.ToString();
        }

        public string GetAllTablePrimaryKeys()
        {
            return GetAllTablePrimaryKeys(Version);
        }

        public string GetAllTablePrimaryKeys(eDBVersion version)
        {            
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} RDB$INDICES.RDB$RELATION_NAME,RDB$RELATION_CONSTRAINTS.rdb$constraint_name {SQLConstants.AS} Constraint_Name,RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE {SQLConstants.AS} Constraint_Type,");
            sb.Append($@"RDB$INDEX_SEGMENTS.RDB$FIELD_NAME {SQLConstants.AS} FieldName,RDB$INDICES.RDB$DESCRIPTION {SQLConstants.AS} Index_Description,(RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) {SQLConstants.AS} Field_Position");
            sb.Append($@"{SQLConstants.FROM} RDB$INDEX_SEGMENTS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.WHERE} RDB$INDICES.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%$%' {SQLConstants.AND} RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE = 'PRIMARY KEY') ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION;");            
            return sb.ToString();
        }
        
        public string GetAllTableForeignKeys(eDBVersion version, eTableType tableType, string tableName = "")
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            
            sb.Append($@"RDB$INDICES.RDB$RELATION_NAME,");
            sb.Append($@"RDB$INDICES.RDB$INDEX_INACTIVE,");
            sb.Append($@"fkc.rdb$constraint_name {SQLConstants.AS} Constraint_Name,");
            sb.Append($@"fkc.RDB$CONSTRAINT_TYPE {SQLConstants.AS} Constraint_Type,");
            sb.Append($@"ISF.rdb$field_name {SQLConstants.AS} FieldName,");
            sb.Append($@"RDB$INDICES.RDB$DESCRIPTION {SQLConstants.AS} Index_Description,");
            sb.Append($@"(RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) {SQLConstants.AS} Field_Position,");
            sb.Append($@"RDB$INDICES.RDB$FOREIGN_KEY {SQLConstants.AS} ForeignKey,");
            sb.Append($@"RDB$REF_CONSTRAINTS.RDB$MATCH_OPTION,");
            sb.Append($@"RDB$REF_CONSTRAINTS.RDB$UPDATE_RULE,RDB$REF_CONSTRAINTS.RDB$DELETE_RULE,");
            sb.Append($@"pkc.rdb$relation_name {SQLConstants.AS} dest_TableName,");
            sb.Append($@"pkc.rdb$constraint_name {SQLConstants.AS} dest_Constraint_Name,");
            sb.Append($@"pkc.RDB$CONSTRAINT_TYPE {SQLConstants.AS} dest_Constraint_Type,");
            sb.Append($@"ISP.rdb$field_name {SQLConstants.AS} dest_fieldname ");

            sb.Append($@"{SQLConstants.FROM} RDB$INDEX_SEGMENTS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS fkc ON fkc.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$REF_CONSTRAINTS ON RDB$REF_CONSTRAINTS.RDB$CONSTRAINT_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS pkc ON pkc.RDB$INDEX_NAME = RDB$INDICES.RDB$FOREIGN_KEY ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDEX_SEGMENTS ISF ON fkc.rdb$index_name = ISF.rdb$index_name ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDEX_SEGMENTS ISP ON pkc.rdb$index_name = ISP.rdb$index_name ");
            string cmd = string.Empty;
            if(tableName.Length > 0)
            {
                cmd = $@"{SQLConstants.WHERE} UPPER(RDB$INDICES.RDB$RELATION_NAME) = '{tableName.ToUpper()}' {SQLConstants.AND} RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY' ";
            }
            else
            {
                cmd = (tableType == eTableType.withoutsystem) 
                    ? $@"{SQLConstants.WHERE} RDB$INDICES.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%$%' {SQLConstants.AND} fkc.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY' " 
                    : $@"{SQLConstants.WHERE} RDB$INDICES.RDB$RELATION_NAME like '%$%' {SQLConstants.AND} fkc.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY' "; 
            }
            sb.Append(cmd);
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION;");
         
            return sb.ToString();
        }

        public string GetForeignKey(eDBVersion version, string foreignKey)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            
            sb.Append($@"RDB$INDICES.RDB$RELATION_NAME,");
            sb.Append($@"RDB$INDICES.RDB$INDEX_INACTIVE,");
            sb.Append($@"fkc.rdb$constraint_name {SQLConstants.AS} Constraint_Name,");
            sb.Append($@"fkc.RDB$CONSTRAINT_TYPE {SQLConstants.AS} Constraint_Type,");
            sb.Append($@"ISF.rdb$field_name {SQLConstants.AS} FieldName,");
            sb.Append($@"RDB$INDICES.RDB$DESCRIPTION {SQLConstants.AS} Index_Description,");
            sb.Append($@"(RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1) {SQLConstants.AS} Field_Position,");
            sb.Append($@"RDB$INDICES.RDB$FOREIGN_KEY {SQLConstants.AS} ForeignKey,");
            sb.Append($@"RDB$REF_CONSTRAINTS.RDB$MATCH_OPTION,");
            sb.Append($@"RDB$REF_CONSTRAINTS.RDB$UPDATE_RULE,RDB$REF_CONSTRAINTS.RDB$DELETE_RULE,");
            sb.Append($@"pkc.rdb$relation_name {SQLConstants.AS} dest_TableName,");
            sb.Append($@"pkc.rdb$constraint_name {SQLConstants.AS} dest_Constraint_Name,");
            sb.Append($@"pkc.RDB$CONSTRAINT_TYPE {SQLConstants.AS} dest_Constraint_Type,");
            sb.Append($@"ISP.rdb$field_name {SQLConstants.AS} dest_fieldname ");

            sb.Append($@"{SQLConstants.FROM} RDB$INDEX_SEGMENTS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS fkc ON fkc.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$REF_CONSTRAINTS ON RDB$REF_CONSTRAINTS.RDB$CONSTRAINT_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS pkc ON pkc.RDB$INDEX_NAME = RDB$INDICES.RDB$FOREIGN_KEY ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDEX_SEGMENTS ISF ON fkc.rdb$index_name = ISF.rdb$index_name ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$INDEX_SEGMENTS ISP ON pkc.rdb$index_name = ISP.rdb$index_name ");
           
             string  cmd = $@"{SQLConstants.WHERE} UPPER(fkc.rdb$constraint_name) = '{foreignKey.ToUpper()}' {SQLConstants.AND} RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY' ";
            
            sb.Append(cmd);
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION;");
         
            return sb.ToString();
        }
       
        public string GetTableTriggers(string tableName)
        {
            return GetTableTriggers(Version, tableName);
        }

        public string GetTableTriggers(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();

            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$SYSTEM_FLAG,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_INACTIVE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_TYPE ");
            sb.Append($@"{SQLConstants.FROM} RDB$TRIGGERS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$TRIGGERS.RDB$RELATION_NAME = '{tableName}' {SQLConstants.AND} RDB$TRIGGERS.RDB$SYSTEM_FLAG = 0 {SQLConstants.AND} RDB$TRIGGERS.RDB$TRIGGER_NAME {SQLConstants.NOT_LIKE} '%$%';");
            
            return sb.ToString();
        }

        public string GetAllTableTriggers()
        {
            return GetAllTableTriggersNonSystemTables(Version);
        }

        public string GetAllTableTriggersNonSystemTables(eDBVersion version)
        {           
            var sb = new StringBuilder();

            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$TRIGGERS.RDB$RELATION_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$SYSTEM_FLAG,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_INACTIVE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_TYPE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_SEQUENCE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_SOURCE {SQLConstants.FROM} RDB$TRIGGERS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$TRIGGERS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%$%' {SQLConstants.AND} RDB$TRIGGERS.RDB$SYSTEM_FLAG = 0 {SQLConstants.AND} RDB$TRIGGERS.RDB$TRIGGER_NAME {SQLConstants.NOT_LIKE} '%$%' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$TRIGGERS.RDB$RELATION_NAME;");

            return sb.ToString();
        }

        public string GetAllTableTriggersSystemTables(eDBVersion version)
        {
            var sb = new StringBuilder();

            sb.Append($@"{SQLConstants.SELECT} RDB$TRIGGERS.RDB$RELATION_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_NAME,");
            sb.Append($@"RDB$TRIGGERS.RDB$SYSTEM_FLAG,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_INACTIVE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_TYPE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_SEQUENCE,");
            sb.Append($@"RDB$TRIGGERS.RDB$TRIGGER_SOURCE {SQLConstants.FROM} RDB$TRIGGERS ");
            sb.Append($@"{SQLConstants.WHERE} RDB$TRIGGERS.RDB$RELATION_NAME {SQLConstants.LIKE} '%$%' {SQLConstants.AND} RDB$TRIGGERS.RDB$SYSTEM_FLAG = 0 {SQLConstants.AND} RDB$TRIGGERS.RDB$TRIGGER_NAME {SQLConstants.LIKE} '%$%' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$TRIGGERS.RDB$RELATION_NAME;");

            return sb.ToString();
        }
                       
        public string GetFieldDependencies(string tableName, string fieldName)
        {
            return GetFieldDependencies(Version, tableName, fieldName);
        }

        public string GetFieldDependencies(eDBVersion version, string tableName, string fieldName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_NAME {SQLConstants.AS} DepentTo,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE {SQLConstants.AS} DependentType ");
            sb.Append($@"{SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '{tableName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME = '{fieldName}' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");
            
            return sb.ToString();
        }

        #region All Table Depend            
              
        public string GetAllDependenciesON(eDBVersion version, eDependencies onTYPE)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$FIELD_NAME,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDED_ON_TYPE ");
            sb.Append($@"{SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} RDB$DEPENDENCIES.RDB$DEPENDED_ON_TYPE = {(int)onTYPE} {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME,RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");
            
            return sb.ToString();
        }        
        
        public string GetAllDependenciesFROM(eDBVersion version, eDependencies onTYPE)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$FIELD_NAME,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDED_ON_TYPE ");
            sb.Append($@"{SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} RDB$DEPENDENCIES.RDB$DEPENDED_ON_TYPE = {(int)onTYPE} {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE,RDB$DEPENDENCIES.RDB$FIELD_NAME,RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME,RDB$DEPENDENCIES.RDB$DEPENDENT_NAME;");
            
            return sb.ToString();
        }
              
        #endregion


        public string GetTableManagerDependenciesTO(string tableName)
        {
            return GetTableManagerDependenciesTO(Version, tableName);
        }

        public string GetTableManagerDependenciesTO(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_NAME {SQLConstants.AS} DepentTo,");
            sb.Append($@"CASE RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE ");
            sb.Append($@"{EnumClass.Instance().GetDependenciesTypeSQLCase()} {SQLConstants.AS}  DependentType, RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE {SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '{tableName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");
            
            return sb.ToString();
        }

        public string GetTableManagerDependenciesFROM(string tableName)
        {
            return GetTableManagerDependenciesFROM(Version, tableName);
        }

        public string GetTableManagerDependenciesFROM(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME {SQLConstants.AS} DepentFrom,CASE RDB$DEPENDENCIES.RDB$DEPENDED_ON_TYPE ");
            sb.Append($@"{EnumClass.Instance().GetDependenciesTypeSQLCase()} {SQLConstants.AS}  DependentType, RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE {SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDENT_NAME) = '{tableName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");
            
            return sb.ToString();
        }

        public string GetViewManagerDependenciesTO(string viewName)
        {
            return GetViewManagerDependenciesTO(Version, viewName);
        }

        public string GetViewManagerDependenciesTO(eDBVersion version, string viewName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_NAME {SQLConstants.AS} DepentTo,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE {SQLConstants.AS} DependentType ");
            sb.Append($@"{SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '{viewName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");
            
            return sb.ToString();
        }

        public string GetViewManagerDependenciesFROM(string viewName)
        {
            return GetViewManagerDependenciesFROM(Version, viewName);
        }

        public string GetViewManagerDependenciesFROM(eDBVersion version, string viewName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_NAME {SQLConstants.AS} DepentTo,");
            sb.Append($@"RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE {SQLConstants.AS} DependentType ");
            sb.Append($@"{SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '{viewName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");
            
            return sb.ToString();
        }


        public string GetViewFields(string viewName)
        {
            return GetViewFields(Version, viewName);
        }

        public string GetViewFields(eDBVersion version, string viewName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_POSITION,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_SOURCE,");
            sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
            sb.Append($@"RDB$FIELDS.RDB$CHARACTER_LENGTH ");
            sb.Append($@"{SQLConstants.FROM} RDB$RELATION_FIELDS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$FIELDS ON RDB$FIELDS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.RDB$FIELD_SOURCE ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
            sb.Append($@"{SQLConstants.WHERE} RDB$RELATION_NAME = '{viewName}' {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");            
            return sb.ToString();
        }                

        public string GetTableUniques(string tableName)
        {
            return GetTableUniques(Version, tableName);
        }

        public string GetTableUniques(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$INDICES.RDB$INDEX_NAME {SQLConstants.AS} Index_Name,");
            sb.Append($@"RDB$INDEX_SEGMENTS.RDB$FIELD_NAME {SQLConstants.AS} Field_Name,");
            sb.Append($@"RDB$INDICES.rdb$unique_flag {SQLConstants.AS} Unique_Flag,");
            sb.Append($@"RDB$INDICES.rdb$index_inactive {SQLConstants.AS} Inactive_Flag ");
            sb.Append($@"{SQLConstants.FROM} RDB$INDEX_SEGMENTS ");
            sb.Append($@"JOIN RDB$INDICES ON RDB$INDICES.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.rdb$field_position = (RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION + 1)  {SQLConstants.AND} RDB$INDEX_SEGMENTS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.rdb$field_name ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDEX_SEGMENTS.RDB$INDEX_NAME ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$INDICES.RDB$RELATION_NAME) = '{tableName}' {SQLConstants.AND}  RDB$INDICES.RDB$UNIQUE_FLAG > 0 {SQLConstants.AND} RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE = 'UNIQUE' ");
            sb.Append($@"{SQLConstants.GROUP_BY} RDB$INDICES.RDB$INDEX_NAME,RDB$INDEX_SEGMENTS.RDB$FIELD_NAME,RDB$INDICES.rdb$index_type,RDB$INDICES.rdb$unique_flag,RDB$INDICES.rdb$index_inactive;");            
            return sb.ToString();
        }
        
        public string GetTableForeignKeysFosDataset(string tableName)
        {
            return GetTableForeignKeysForDataset(Version, tableName);
        }

        public string GetTableForeignKeysForDataset(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"inx.rdb$index_name  {SQLConstants.AS} Foreign_key_name,");
            sb.Append($@"inx.rdb$relation_name {SQLConstants.AS} Relation_name,");
            sb.Append($@"iseg.rdb$field_name {SQLConstants.AS} field_name,");
            sb.Append($@"inx2.rdb$relation_name {SQLConstants.AS} To_relation_name,");
            sb.Append($@"iseg2.rdb$field_name {SQLConstants.AS} To_field_name,");
            sb.Append($@"refc.rdb$update_rule {SQLConstants.AS} update_rule,");
            sb.Append($@"refc.rdb$delete_rule {SQLConstants.AS} delete_rule,");
            sb.Append($@"inx.rdb$unique_flag {SQLConstants.AS} Is_Unique,");
            sb.Append($@"inx.rdb$index_inactive {SQLConstants.AS} Is_Inactive,");
            sb.Append($@"inx.rdb$foreign_key,inx.rdb$statistics {SQLConstants.AS} fk_stats,");
            sb.Append($@"refc.rdb$const_name_uq,");
            sb.Append($@"refc.rdb$match_option {SQLConstants.AS} match_option,");
            sb.Append($@"relc.rdb$deferrable {SQLConstants.AS} deferrable,");
            sb.Append($@"relc.rdb$initially_deferred {SQLConstants.AS} initially_deferred,");
            sb.Append($@"inx2.rdb$unique_flag {SQLConstants.AS} To_Unique,");
            sb.Append($@"inx2.rdb$index_inactive {SQLConstants.AS} To_inactive,");
            sb.Append($@"inx2.rdb$statistics {SQLConstants.AS} To_stats ");
            sb.Append($@"{SQLConstants.FROM} rdb$indices inx ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$index_segments iseg ON iseg.rdb$index_name = inx.rdb$index_name ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$ref_constraints refc ON refc.rdb$constraint_name = inx.rdb$index_name ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$relation_constraints relc  ON relc.rdb$constraint_name = refc.rdb$constraint_name ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$indices inx2 ON inx2.rdb$index_name = inx.rdb$foreign_key ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$index_segments iseg2 ON iseg2.rdb$index_name = inx2.rdb$index_name ");
            sb.Append($@"where inx.rdb$index_type = 0 and inx.rdb$foreign_key {SQLConstants.IS} {SQLConstants.NOT_NULL} and inx.rdb$relation_name = '{tableName}';");                        
            return sb.ToString();
        }
        
        public string GetTableFields(string tableName)
        {
            return GetTableFields(Version, tableName);
        }

        public string GetTableFieldsCmd(eDBVersion version)
        {
            var sb = new StringBuilder();
            if (version >= eDBVersion.FB3_32)
            {           
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_POSITION,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_SOURCE,");
                sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
                sb.Append($@"RDB$FIELDS.RDB$CHARACTER_LENGTH,");
                sb.Append($@"RDB$FIELDS.RDB$FIELD_NAME,");
                sb.Append($@"RDB$FIELDS.RDB$FIELD_SCALE,");
                sb.Append($@"RDB$FIELDS.RDB$DEFAULT_SOURCE,");
                sb.Append($@"RDB$COLLATIONS.RDB$COLLATION_NAME,");
                sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$NULL_FLAG,");
                sb.Append($@"RDB$FIELDS.RDB$NULL_FLAG,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$DEFAULT_SOURCE,");
                sb.Append($@"RDB$RELATION_FIELDS.rdb$description {SQLConstants.AS} FIeldDescription,");
                sb.Append($@"RDB$FIELDS.rdb$description {SQLConstants.AS} DomainDescription ");
                sb.Append($@"{SQLConstants.FROM} RDB$RELATIONS ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.RDB$RELATION_NAME = RDB$RELATIONS.RDB$RELATION_NAME ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$FIELDS ON RDB$FIELDS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.RDB$FIELD_SOURCE ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$CHARACTER_SETS ON RDB$FIELDS.RDB$CHARACTER_SET_ID = RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$COLLATIONS ON RDB$FIELDS.RDB$COLLATION_ID = RDB$COLLATIONS.RDB$COLLATION_ID  {SQLConstants.AND} RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$COLLATIONS.RDB$CHARACTER_SET_ID ");
            }
            else
            {
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_POSITION,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_SOURCE,");
                sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
                sb.Append($@"RDB$FIELDS.RDB$CHARACTER_LENGTH,");
                sb.Append($@"RDB$FIELDS.RDB$FIELD_NAME,");
                sb.Append($@"RDB$FIELDS.RDB$FIELD_SCALE,");
                sb.Append($@"RDB$FIELDS.RDB$DEFAULT_SOURCE,");
                sb.Append($@"RDB$COLLATIONS.RDB$COLLATION_NAME,");
                sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$NULL_FLAG,");
                sb.Append($@"RDB$FIELDS.RDB$NULL_FLAG,");
                sb.Append($@"RDB$RELATION_FIELDS.RDB$DEFAULT_SOURCE,");
                sb.Append($@"RDB$RELATION_FIELDS.rdb$description {SQLConstants.AS} FieldDescription,");
                sb.Append($@"RDB$FIELDS.rdb$description {SQLConstants.AS} DomainDescription ");
                sb.Append($@"{SQLConstants.FROM} RDB$RELATIONS ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.RDB$RELATION_NAME = RDB$RELATIONS.RDB$RELATION_NAME ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$FIELDS ON RDB$FIELDS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.RDB$FIELD_SOURCE ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$CHARACTER_SETS ON RDB$FIELDS.RDB$CHARACTER_SET_ID = RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$COLLATIONS ON RDB$FIELDS.RDB$COLLATION_ID = RDB$COLLATIONS.RDB$COLLATION_ID  {SQLConstants.AND} RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$COLLATIONS.RDB$CHARACTER_SET_ID ");
            }
            return sb.ToString();
        }

        public string GetTableFields(eDBVersion version, string tableName)
        {
            var sb = new StringBuilder(GetTableFieldsCmd(version));            
            sb.Append($@"{SQLConstants.WHERE} RDB$RELATIONS.RDB$RELATION_NAME = '{tableName}' {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            
            return sb.ToString();
        }

        public string GetAllTableFields()
        {
            return GetAllNonSystemTableFields(Version);
        }

        public string GetAllNonSystemTableFields(eDBVersion version)
        {
            var sb = new StringBuilder(GetTableFieldsCmd(version));
            if (version >= eDBVersion.FB3_32)
            {
                sb.Append($@"{SQLConstants.WHERE} (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.Table}) {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' {SQLConstants.AND}  RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%$%' ");
                sb.Append($@"{SQLConstants.ORDER_BY}  RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            }
            else
            {
                sb.Append($@"{SQLConstants.WHERE} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' {SQLConstants.AND}  RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%$%' ");
                sb.Append($@"{SQLConstants.ORDER_BY}  RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            }
            return sb.ToString();
        }

        public string GetSystemTableFields()
        {
            return GetAllSystemTableFields(Version);
        }

        public string GetAllSystemTableFields(eDBVersion version)
        {      
            var sb = new StringBuilder(GetTableFieldsCmd(version));
            if (version >= eDBVersion.FB3_32)
            {
                sb.Append($@"{SQLConstants.WHERE} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' {SQLConstants.AND}  RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.LIKE} '%$%' ");
                sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            }
            else
            {
                sb.Append($@"{SQLConstants.WHERE} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' {SQLConstants.AND}  RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.LIKE} '%$%' ");
                sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");
            }
            return  sb.ToString();               
        }

        public string GetProcedureAttributes(string tableName)
        {
            return GetProcedureAttributes(Version, tableName);
        }

        public string GetProcedureAttributes(eDBVersion version, string procName)
        {            
            var sb = new StringBuilder();
            sb.Append($@"{SQLConstants.SELECT} RDB$PROCEDURE_PARAMETERS.RDB$PARAMETER_NAME,RDB$PROCEDURE_PARAMETERS.RDB$PARAMETER_TYPE,RDB$PROCEDURE_PARAMETERS.RDB$PARAMETER_NUMBER,");
            sb.Append($@"RDB$FIELDS.rdb$field_type,RDB$FIELDS.RDB$CHARACTER_LENGTH,RDB$FIELDS.rdb$field_precision,RDB$FIELDS.rdb$field_scale,RDB$TYPES.RDB$TYPE_NAME ");
            sb.Append($@"{SQLConstants.FROM} RDB$PROCEDURE_PARAMETERS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$fields ON RDB$FIELDS.rdb$field_name = RDB$PROCEDURE_PARAMETERS.rdb$field_source ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
            sb.Append($@"{SQLConstants.WHERE} RDB$PROCEDURE_PARAMETERS.RDB$PROCEDURE_NAME = '{procName}' {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE'"); 
            return sb.ToString();
        }

        public string GetFunctionsArguments(string tableName)
        {
            return GetFunctionsArguments(Version, tableName);
        }

        public string GetFunctionsArguments(eDBVersion version, string procName)
        {            
            var sb = new StringBuilder();
            if (version >= eDBVersion.FB3_32)
            {
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$ARGUMENT_NAME,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$ARGUMENT_POSITION,");
                sb.Append($@"RDB$FIELDS.rdb$field_type,");
                sb.Append($@"RDB$FIELDS.RDB$CHARACTER_LENGTH,");
                sb.Append($@"RDB$FIELDS.rdb$field_precision,");
                sb.Append($@"RDB$FIELDS.rdb$field_scale,");
                sb.Append($@"RDB$TYPES.RDB$TYPE_NAME ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTION_ARGUMENTS ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} rdb$fields ON RDB$FIELDS.rdb$field_name = RDB$FUNCTION_ARGUMENTS.rdb$field_source ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
                sb.Append($@"{SQLConstants.WHERE} RDB$FUNCTION_ARGUMENTS.RDB$FUNCTION_NAME = '{procName}' {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE'");
            }
            else
            {                
                sb.Append($@"{SQLConstants.SELECT} ");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FUNCTION_NAME,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$ARGUMENT_POSITION,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.rdb$field_type,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$CHARACTER_LENGTH,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.rdb$field_precision,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.rdb$field_scale,");
                sb.Append($@"RDB$TYPES.RDB$TYPE_NAME ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTION_ARGUMENTS "); 
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FUNCTION_ARGUMENTS.rdb$field_type ");
                sb.Append($@"{SQLConstants.WHERE} RDB$FUNCTION_ARGUMENTS.RDB$FUNCTION_NAME = 'GET_RECHPOSCOUNT' {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE'");

            }
            return sb.ToString();
        }

        public string GetUserDefinedFunctionsAttributes(string tableName)
        {
            return GetUserDefinedFunctionsAttributes(Version, tableName);
        }

        public string GetUserDefinedFunctionsAttributes(eDBVersion version, string procName)
        {            
            var sb = new StringBuilder();      
            if (version >= eDBVersion.FB3_32)
            {
                sb.Append($@"{SQLConstants.SELECT} ");               
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$ARGUMENT_POSITION,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$MECHANISM,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_TYPE,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_LENGTH,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_SCALE,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_TYPE,");
                sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
                sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID,");
                sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTION_ARGUMENTS ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FUNCTION_ARGUMENTS.RDB$FIELD_TYPE {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$CHARACTER_SETS ON RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$FUNCTION_ARGUMENTS.RDB$CHARACTER_SET_ID ");
                sb.Append($@"{SQLConstants.WHERE} RDB$FUNCTION_ARGUMENTS.RDB$FUNCTION_NAME = '{procName}' ");
            }
            else
            {
                sb.Append($@"{SQLConstants.SELECT} ");            
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$ARGUMENT_POSITION,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$MECHANISM,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_TYPE,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_LENGTH,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_SCALE,");
                sb.Append($@"RDB$FUNCTION_ARGUMENTS.RDB$FIELD_TYPE,");
                sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
                sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID,");
                sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME ");
                sb.Append($@"{SQLConstants.FROM} RDB$FUNCTION_ARGUMENTS ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FUNCTION_ARGUMENTS.RDB$FIELD_TYPE {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");
                sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$CHARACTER_SETS ON RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$FUNCTION_ARGUMENTS.RDB$CHARACTER_SET_ID ");
                sb.Append($@"{SQLConstants.WHERE} RDB$FUNCTION_ARGUMENTS.RDB$FUNCTION_NAME = '{procName}' ");
            }
            return sb.ToString();
        }

        public string GetDepentenciesGenerators(string generatorName)
        {
            return GetDepentenciesGenerators(Version, generatorName);
        }
        
        public string GetDepentenciesGenerators(eDBVersion version, string generatorName)
        {            
            var sb = new StringBuilder();   
            sb.Append($@"{SQLConstants.SELECT} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field ,RDB$DEPENDENCIES.RDB$DEPENDENT_NAME {SQLConstants.AS} DepentTo,CASE RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE ");
            sb.Append($@"{EnumClass.Instance().GetDependenciesTypeSQLCase()} {SQLConstants.AS}  DependentType {SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '{generatorName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");            
            return sb.ToString();
        }

        public string GetDepentenciesProcedures(string generatorName)
        {
            return GetDepentenciesProcedures(Version, generatorName);
        }

        public string GetDepentenciesProcedures(eDBVersion version, string procedureName)
        {
            var sb = new StringBuilder();   
            sb.Append($@"{SQLConstants.SELECT} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.AS} Field ,RDB$DEPENDENCIES.RDB$DEPENDENT_NAME {SQLConstants.AS} DepentTo,CASE RDB$DEPENDENCIES.RDB$DEPENDENT_TYPE ");
            sb.Append($@"{EnumClass.Instance().GetDependenciesTypeSQLCase()} {SQLConstants.AS}  DependentType {SQLConstants.FROM} RDB$DEPENDENCIES ");
            sb.Append($@"{SQLConstants.WHERE} UPPER(RDB$DEPENDENCIES.RDB$DEPENDED_ON_NAME) = '{procedureName}' {SQLConstants.AND} RDB$DEPENDENCIES.RDB$FIELD_NAME {SQLConstants.IS} {SQLConstants.NOT_NULL} ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$DEPENDENCIES.RDB$DEPENDENT_NAME,RDB$DEPENDENCIES.RDB$FIELD_NAME;");            
            return sb.ToString();
        }

        public string GetMonitorConnections(eDBVersion Version)
        {
            return GetMonitorConnections(Version, true);
        }

        public string GetMonitorConnections(eDBVersion version,bool allConnections)
        {            
            var sb = new StringBuilder();             
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"MON$TRANSACTIONS.MON$STAT_ID {SQLConstants.AS} StatID,");
            sb.Append($@"MON$ATTACHMENTS.MON$REMOTE_PID {SQLConstants.AS} PID,");
            sb.Append($@"MON$ATTACHMENTS.MON$ATTACHMENT_NAME {SQLConstants.AS} AttachmentName,");
            sb.Append($@"MON$ATTACHMENTS.MON$REMOTE_PROCESS {SQLConstants.AS} ProcessName,");
            sb.Append($@"MON$ATTACHMENTS.MON$USER {SQLConstants.AS} AttachedUser,");
            sb.Append($@"MON$ATTACHMENTS.MON$REMOTE_PROTOCOL {SQLConstants.AS} Protocol,");
            sb.Append($@"MON$ATTACHMENTS.MON$REMOTE_ADDRESS {SQLConstants.AS} Address,");
            sb.Append($@"MON$TRANSACTIONS.MON$TIMESTAMP {SQLConstants.AS} TransactionTimestamp,");
            sb.Append($@"MON$TRANSACTIONS.MON$STATE {SQLConstants.AS} TransactionState,");
            sb.Append($@"MON$TRANSACTIONS.MON$TOP_TRANSACTION {SQLConstants.AS} TopTransaction,");
            sb.Append($@"MON$TRANSACTIONS.MON$ISOLATION_MODE {SQLConstants.AS} IsolationMode,");
            sb.Append($@"MON$IO_STATS.MON$PAGE_WRITES {SQLConstants.AS} PagesWrite,");
            sb.Append($@"MON$IO_STATS.MON$PAGE_READS {SQLConstants.AS} PagesReads,");
            sb.Append($@"MON$IO_STATS.MON$PAGE_FETCHES {SQLConstants.AS} PagesFetches,");
            sb.Append($@"MON$IO_STATS.MON$PAGE_MARKS {SQLConstants.AS} PagesMarks,");
            sb.Append($@"MON$MEMORY_USAGE.*,");
            sb.Append($@"MON$TABLE_STATS.* ");
            sb.Append($@"{SQLConstants.FROM} MON$ATTACHMENTS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} MON$TRANSACTIONS ON MON$TRANSACTIONS.MON$ATTACHMENT_ID = MON$ATTACHMENTS.MON$ATTACHMENT_ID ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} MON$IO_STATS ON MON$IO_STATS.MON$STAT_ID = MON$TRANSACTIONS.MON$STAT_ID ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} MON$MEMORY_USAGE ON MON$MEMORY_USAGE.MON$STAT_ID = MON$TRANSACTIONS.MON$STAT_ID ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} MON$TABLE_STATS ON MON$TABLE_STATS.MON$STAT_ID = MON$TRANSACTIONS.MON$STAT_ID");
            if (allConnections)
            {
                sb.Append($@" WHERE MON$TRANSACTIONS.MON$ATTACHMENT_ID = CURRENT_CONNECTION");
            }
            sb.Append($@" ORDER BY MON$ATTACHMENTS.MON$ATTACHMENT_ID;");            
            return sb.ToString();
        }
        
        public string GetForRefreshXML(eDBVersion version)
        {            
            var sb = new StringBuilder();    
            sb.Append($@"{SQLConstants.SELECT} RDB$RELATIONS.RDB$RELATION_NAME,RDB$RELATIONS.RDB$RELATION_TYPE {SQLConstants.FROM} RDB$RELATIONS ");
            sb.Append($@"{SQLConstants.WHERE} ((RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.Table}) OR (RDB$RELATIONS.RDB$RELATION_TYPE = {(int)FBRelationTypeIndex.View})) {SQLConstants.AND} ");
            sb.Append($@"(RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%RDB$%') {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%MON$%') {SQLConstants.AND} (RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.NOT_LIKE} '%IBE$%') ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATIONS.RDB$RELATION_NAME;");            
            return sb.ToString();
        }

        public string GetFieldsForRefreshXML(string viewName)
        {
            return GetFieldsForRefreshXML(Version, viewName);
        }

        public string GetFieldsForRefreshXML(eDBVersion version, string viewName)
        {            
            var sb = new StringBuilder();    
            sb.Append($@"{SQLConstants.SELECT} ");
            sb.Append($@"RDB$RELATIONS.RDB$RELATION_NAME {SQLConstants.AS} FieldName,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_NAME,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_POSITION,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$FIELD_SOURCE,");
            sb.Append($@"RDB$TYPES.RDB$TYPE_NAME,");
            sb.Append($@"RDB$FIELDS.RDB$CHARACTER_LENGTH,");
            sb.Append($@"RDB$FIELDS.RDB$FIELD_NAME,");
            sb.Append($@"RDB$FIELDS.RDB$FIELD_SCALE,");
            sb.Append($@"RDB$FIELDS.RDB$DEFAULT_SOURCE,");
            sb.Append($@"RDB$COLLATIONS.RDB$COLLATION_NAME,");
            sb.Append($@"RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME,");
            sb.Append($@"RDB$RELATION_FIELDS.RDB$NULL_FLAG,");
            sb.Append($@"RDB$FIELDS.RDB$NULL_FLAG,RDB$RELATION_FIELDS.RDB$DEFAULT_SOURCE ");
            sb.Append($@"{SQLConstants.FROM} RDB$RELATIONS ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$RELATION_FIELDS ON RDB$RELATION_FIELDS.RDB$RELATION_NAME = RDB$RELATIONS.RDB$RELATION_NAME ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$FIELDS ON RDB$FIELDS.RDB$FIELD_NAME = RDB$RELATION_FIELDS.RDB$FIELD_SOURCE ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$CHARACTER_SETS ON RDB$FIELDS.RDB$CHARACTER_SET_ID = RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID ");
            sb.Append($@"{SQLConstants.LEFT_JOIN} RDB$COLLATIONS ON RDB$FIELDS.RDB$COLLATION_ID = RDB$COLLATIONS.RDB$COLLATION_ID  {SQLConstants.AND} RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$COLLATIONS.RDB$CHARACTER_SET_ID ");
            sb.Append($@"{SQLConstants.WHERE} RDB$RELATIONS.RDB$RELATION_NAME = '{viewName}' {SQLConstants.AND} RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' ");
            sb.Append($@"{SQLConstants.ORDER_BY} RDB$RELATION_FIELDS.RDB$FIELD_POSITION;");            
            return sb.ToString();
        }                               
    }
}
