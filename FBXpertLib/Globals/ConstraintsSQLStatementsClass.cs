using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using System;
using System.Text;

namespace FBXpertLib
{
    public class ConstraintsSQLStatementsClass : SQLStatementsBase
    {
        

        private static readonly Lazy<ConstraintsSQLStatementsClass> lazy = new Lazy<ConstraintsSQLStatementsClass>(() => new ConstraintsSQLStatementsClass());
        public static ConstraintsSQLStatementsClass Instance
        {
            get
            {
                return lazy.Value;
            }
        }


        private ConstraintsSQLStatementsClass()
        {
           
        }

        

        public string GetConstraintsByTypeNotNull()
        {
            return GetConstraintsByTypeNotNull(Version);
        }
        public string GetConstraintsByTypeNotNull(eDBVersion version)
        {                      
            var sb = new StringBuilder();
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,"); 
            sb.Append($@"rc.rdb$constraint_type,"); 
            sb.Append($@"rc.rdb$relation_name,"); 
            sb.Append($@"rc.rdb$deferrable,"); 
            sb.Append($@"rc.rdb$initially_deferred,"); 
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq,"); 
            sb.Append($@"rfc.rdb$match_option,"); 
            sb.Append($@"rfc.rdb$update_rule,"); 
            sb.Append($@"rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"where rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = 'NOT NULL';");
            return sb.ToString();
        }
        public string GetConstraintsByTypeUnique()
        {
            return GetConstraintsByTypeUnique(Version);
        }
        public string GetConstraintsByTypeUnique(eDBVersion version)
        {            
            var sb = new StringBuilder();
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,"); 
            sb.Append($@"rc.rdb$relation_name,"); 
            sb.Append($@"rc.rdb$deferrable,"); 
            sb.Append($@"rc.rdb$initially_deferred,"); 
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"ins.rdb$field_name,");
            sb.Append($@"rfc.rdb$const_name_uq,"); 
            sb.Append($@"rfc.rdb$match_option,"); 
            sb.Append($@"rfc.rdb$update_rule,"); 
            sb.Append($@"rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments ins ON ins.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = 'UNIQUE';");
            return sb.ToString();
        }
        public string GetConstraintsByTypePrimaryKey()
        {
            return GetConstraintsByTypePrimaryKey(Version);
        }
        public string GetConstraintsByTypePrimaryKey(eDBVersion version)
        {            
            var sb = new StringBuilder(); 
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,"); 
            sb.Append($@"rc.rdb$relation_name,"); 
            sb.Append($@"rc.rdb$deferrable,"); 
            sb.Append($@"rc.rdb$initially_deferred,"); 
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"ins.rdb$field_name,");
            sb.Append($@"rfc.rdb$const_name_uq,"); 
            sb.Append($@"rfc.rdb$match_option,"); 
            sb.Append($@"rfc.rdb$update_rule,"); 
            sb.Append($@"rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments ins ON ins.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = 'PRIMARY KEY';");
            return sb.ToString();
        }

        public string GetTableConstraintsByType(string ContraintsType, string TableName)
        {
            return GetTableConstraintsByType(Version, ContraintsType, TableName);
        }
        public string GetTableConstraintsByType(eDBVersion version, string ContraintsType, string TableName)
        {
            
            var sb = new StringBuilder(); 
            /*
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,"); 
            sb.Append($@"rc.rdb$constraint_type,"); 
            sb.Append($@"rc.rdb$relation_name,"); 
            sb.Append($@"rc.rdb$deferrable,"); 
            sb.Append($@"rc.rdb$initially_deferred,"); 
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq,"); 
            sb.Append($@"rfc.rdb$match_option,"); 
            sb.Append($@"rfc.rdb$update_rule,"); 
            sb.Append($@"rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"where  rc.rdb$relation_name = '{TableName}' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = '{ContraintsType}';");
            */
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,");
            sb.Append($@"rc.rdb$relation_name,");
            sb.Append($@"rc.rdb$deferrable,");
            sb.Append($@"rc.rdb$initially_deferred,");
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq, rfc.rdb$match_option, rfc.rdb$update_rule, rfc.rdb$delete_rule,");
            sb.Append($@"inx.rdb$field_name,inx.rdb$field_position ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments inx ON inx.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$relation_name = '{TableName}' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = '{ContraintsType}' ");
            sb.Append($@"order by rc.rdb$constraint_name,rc.rdb$relation_name,  inx.rdb$field_name,inx.rdb$field_position;");

            return sb.ToString();
        }

        public string GetAllTableConstraintsByType(eConstraintType ContraintsType)
        {
            return GetAllTableConstraintsByTypeNonSystemTables(Version, ContraintsType);
        }
        public string GetAllTableConstraintsByTypeNonSystemTables(eDBVersion version, eConstraintType ContraintsType)
        {            
            
            var sb = new StringBuilder(); 
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,"); 
            sb.Append($@"rc.rdb$relation_name,"); 
            sb.Append($@"rc.rdb$deferrable,"); 
            sb.Append($@"rc.rdb$initially_deferred,"); 
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq, rfc.rdb$match_option, rfc.rdb$update_rule, rfc.rdb$delete_rule,");
            sb.Append($@"inx.rdb$field_name,inx.rdb$field_position ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments inx ON inx.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$relation_name NOT LIKE '%$%' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = '{EnumHelper.GetDescription(ContraintsType)}' ");
            sb.Append($@"order by rc.rdb$constraint_name,rc.rdb$relation_name,  inx.rdb$field_name,inx.rdb$field_position;");
            return sb.ToString();
        }

        public string GetAllTableConstraintsByName(eDBVersion version, eConstraintType ContraintsType, string ConstraintName)
        {
            var sb = new StringBuilder();
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,");
            sb.Append($@"rc.rdb$relation_name,");
            sb.Append($@"rc.rdb$deferrable,");
            sb.Append($@"rc.rdb$initially_deferred,");
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq, rfc.rdb$match_option, rfc.rdb$update_rule, rfc.rdb$delete_rule,");
            sb.Append($@"inx.rdb$field_name,inx.rdb$field_position ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments inx ON inx.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$relation_name NOT LIKE '%$%' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = '{EnumHelper.GetDescription(ContraintsType)}' ");
            sb.Append($@"and rc.rdb$constraint_name = '{ConstraintName}' ");
            sb.Append($@"order by rc.rdb$constraint_name,rc.rdb$relation_name,  inx.rdb$field_name,inx.rdb$field_position;");
            return sb.ToString();
        }
        public string GetAllTableConstraintsByTableName(eDBVersion version, eConstraintType ContraintsType, string TableName)
        {
            var sb = new StringBuilder();
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,");
            sb.Append($@"rc.rdb$relation_name,");
            sb.Append($@"rc.rdb$deferrable,");
            sb.Append($@"rc.rdb$initially_deferred,");
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq, rfc.rdb$match_option, rfc.rdb$update_rule, rfc.rdb$delete_rule,");
            sb.Append($@"inx.rdb$field_name,inx.rdb$field_position ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments inx ON inx.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$relation_name = '{TableName}' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = '{EnumHelper.GetDescription(ContraintsType)}' ");
            //sb.Append($@"and cc.rdb$trigger_name = '{FieldName}' ");
            sb.Append($@"order by rc.rdb$constraint_name,rc.rdb$relation_name,  inx.rdb$field_name,inx.rdb$field_position;");
            return sb.ToString();
        }
        public string GetAllTableConstraintsByTypeSystemTables(eDBVersion version, eConstraintType ContraintsType)
        {            
            var sb = new StringBuilder();  
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,"); 
            sb.Append($@"rc.rdb$relation_name,"); 
            sb.Append($@"rc.rdb$deferrable,"); 
            sb.Append($@"rc.rdb$initially_deferred,"); 
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq,");
            sb.Append($@"rfc.rdb$match_option,"); 
            sb.Append($@"rfc.rdb$update_rule,"); 
            sb.Append($@"rfc.rdb$delete_rule,");
            sb.Append($@"inx.rdb$field_name,inx.rdb$field_position ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments inx ON inx.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$relation_name like '%$%' AND rc.rdb$constraint_type = '{EnumHelper.GetDescription(ContraintsType)}' ");
            sb.Append($@"order by rc.rdb$constraint_name,rc.rdb$relation_name,  inx.rdb$field_name,inx.rdb$field_position;");
            return sb.ToString();
        }
        public string GetSystemTableConstraintsByType(eConstraintType ContraintsType)
        {
            return GetSystemTableConstraintsByType(Version, ContraintsType);
        }
        public string GetSystemTableConstraintsByType(eDBVersion version, eConstraintType ContraintsType)
        {            
            var sb = new StringBuilder(); 
            sb.Append($@"select rc.rdb$constraint_name, rc.rdb$constraint_type, rc.rdb$relation_name, rc.rdb$deferrable, rc.rdb$initially_deferred, rc.rdb$index_name,");
            sb.Append($@"cc.rdb$trigger_name,");
            sb.Append($@"rfc.rdb$const_name_uq, rfc.rdb$match_option, rfc.rdb$update_rule, rfc.rdb$delete_rule,");
            sb.Append($@"inx.rdb$field_name,inx.rdb$field_position ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$index_segments inx ON inx.rdb$index_name = rc.rdb$index_name ");
            sb.Append($@"where rc.rdb$relation_name like '%$%' AND rc.rdb$constraint_type = '{EnumHelper.GetDescription(ContraintsType)}' ");
            sb.Append($@"order by rc.rdb$constraint_name,rc.rdb$relation_name,  inx.rdb$field_name,inx.rdb$field_position;");
            return sb.ToString();
        }


        public string GetTableCheckConstraints(string TableName)
        {
            return GetTableCheckConstraints(Version, TableName);
        }

        public string GetTableCheckConstraints(eDBVersion version, string TableName)
        {            
            var sb = new StringBuilder(); 
            sb.Append($@"select rc.rdb$constraint_name, rc.rdb$constraint_type, rc.rdb$relation_name, rc.rdb$deferrable, rc.rdb$initially_deferred, rc.rdb$index_name,");
            sb.Append($@"tr.rdb$trigger_name,tr.rdb$trigger_source,rfc.rdb$const_name_uq, rfc.rdb$match_option, rfc.rdb$update_rule, rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$triggers tr ON tr.rdb$trigger_name = cc.rdb$trigger_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"where  rc.rdb$relation_name = '{TableName}' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = 'CHECK';");
            return sb.ToString();
        }

        public string GetAllTableCheckConstraintsNonSystem()
        {
            return GetAllTableCheckConstraintsNonSystem(Version);
        }
        
        public string GetAllTableCheckConstraintsNonSystem(eDBVersion version)
        {            
            var sb = new StringBuilder(); 
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,");
            sb.Append($@"rc.rdb$relation_name,");
            sb.Append($@"rc.rdb$deferrable,");
            sb.Append($@"rc.rdb$initially_deferred,");
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"tr.rdb$trigger_name,");
            sb.Append($@"tr.rdb$trigger_source,");
            sb.Append($@"rfc.rdb$const_name_uq,");
            sb.Append($@"rfc.rdb$match_option,");
            sb.Append($@"rfc.rdb$update_rule,");
            sb.Append($@"rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$triggers tr ON tr.rdb$trigger_name = cc.rdb$trigger_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"where  rc.rdb$relation_name NOT LIKE '%$%' and rc.rdb$constraint_name NOT LIKE '%$%' AND rc.rdb$constraint_type = 'CHECK';");
            return sb.ToString();
        }

        public string GetAllTableCheckConstraintsSystem(eDBVersion version)
        {           
            var sb = new StringBuilder();
            sb.Append($@"select ");
            sb.Append($@"rc.rdb$constraint_name,");
            sb.Append($@"rc.rdb$constraint_type,");
            sb.Append($@"rc.rdb$relation_name,");
            sb.Append($@"rc.rdb$deferrable,");
            sb.Append($@"rc.rdb$initially_deferred,");
            sb.Append($@"rc.rdb$index_name,");
            sb.Append($@"tr.rdb$trigger_name,");
            sb.Append($@"tr.rdb$trigger_source,");
            sb.Append($@"rfc.rdb$const_name_uq,");
            sb.Append($@"rfc.rdb$match_option,");
            sb.Append($@"rfc.rdb$update_rule,");
            sb.Append($@"rfc.rdb$delete_rule ");
            sb.Append($@"from rdb$relation_constraints rc ");
            sb.Append($@"LEFT JOIN rdb$check_constraints cc ON cc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"LEFT JOIN rdb$triggers tr ON tr.rdb$trigger_name = cc.rdb$trigger_name ");
            sb.Append($@"LEFT JOIN rdb$ref_constraints rfc ON rfc.rdb$constraint_name = rc.rdb$constraint_name ");
            sb.Append($@"where  rc.rdb$relation_name like '%$%' AND rc.rdb$constraint_type = 'CHECK';");
            return sb.ToString();
        }

        public SQLCommandsReturnInfoClass DropNotNullConstraint(string name,string tablename,string fieldname, DBRegistrationClass dbReg, NotifiesClass notify)
        {
            string cmd = SQLPatterns.DropNotNullConstraintPattern.Replace(SQLPatterns.FieldKey, fieldname).Replace(SQLPatterns.TableKey,tablename);
            return ExecSql(cmd, dbReg, notify);
        }
        public SQLCommandsReturnInfoClass DropPrimaryKeyConstraint(string name, string tablename, string fieldname, DBRegistrationClass dbReg, NotifiesClass notify)
        {
            string cmd = SQLPatterns.DropPrimaryKeyConstraintPattern.Replace(SQLPatterns.ConstraintKey, name).Replace(SQLPatterns.TableKey, tablename);
            return ExecSql(cmd, dbReg, notify);
        }
    }
}
