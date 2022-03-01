using System;

namespace FBXpertLib
{
    public static class SQLPatterns
    {
        public const string ColumnKey            = "%COLUMN%";
        public const string ReferenceColumnKey   = "%REFERENCECOLUMN%";
        public const string ColumnKey2           = "%COLUMN2%";
        public const string TableKey             = "%TABLE%";
        public const string FieldKey             = "%FIELD%";
        public const string ReferenceTableKey    = "%REFERENCETABLE%";
        public const string DefaultKey           = "%DEFAULT%";
        public const string PositionKey          = "%POSITION%";
        public const string DescriptionKey       = "%DESCRIPTION%";
        public const string PrimaryKey           = "%PRIMARYKEY%";
        public const string ConstraintKey        = "%CONSTRAINT%";
        public const string TriggerKey           = "%TRIGGER%";
        public const string RelationKey          = "%RELATION%";
        public const string SourceKey            = "%SOURCE%";
        public const string SequenceKey          = "%SEQUENCE%";
        public const string GeneratorKey         = "%GENERATOR%";
        public const string DomainKey            = "%DOMAIN%";
        public const string ValueKey             = "%VALUE%";
        public const string DataTypeKey          = "%DATATYPE%";
        public const string UpdateTypeKey        = "%UPDATETYPE%";
        public const string IndexKey             = "%INDEX%";
        public const string ActiveKey            = "%ACTIVE%";
        public const string TriggerType          = "%TRIGGERTYPE%";
        

        public static string PositionSchablone          = $@"ALTER TABLE {TableKey} ALTER {ColumnKey} POSITION {PositionKey};";
        public static string AlterTableSetDefault       = $@"ALTER TABLE {TableKey} ALTER {ColumnKey} SET DEFAULT '{DefaultKey}';";
        public static string AlterTableDropDefault      = $@"ALTER TABLE {TableKey} ALTER {ColumnKey} DROP DEFAULT;";
        public static string AlterTableAddPK            = $@"ALTER TABLE {TableKey} ADD CONSTRAINT {PrimaryKey} PRIMARY KEY ({ColumnKey});";
        public static string AlterTableColumnComment    = $@"COMMENT ON COLUMN {TableKey}.{ColumnKey} IS '{DescriptionKey}';";
        public static string AlterTableDropPK           = $@"ALTER TABLE {TableKey} DROP CONSTRAINT {PrimaryKey};"; 
        public static string AlterTableFieldSetNotNull  = $@"ALTER TABLE {TableKey} ALTER {ColumnKey} SET NOT NULL;";
        public static string UpdateFieldData            = $@"UPDATE {TableKey} SET {ColumnKey} = '{ValueKey}' WHERE {ColumnKey} IS NULL;";
        public static string AlterTableFieldSetNull     = $@"ALTER TABLE {TableKey} ALTER {ColumnKey} DROP NOT NULL;";
        public static string AlterTableRenameField      = $@"ALTER TABLE {TableKey} ALTER {ColumnKey} TO {ColumnKey2};";
        public static string AddIndexPattern            = $@"CREATE INDEX {IndexKey} ON {TableKey}({ColumnKey});";  
        public static string AddTriggerPattern          = $@"SET TERM ^ ;{Environment.NewLine}CREATE TRIGGER {TriggerKey} FOR {RelationKey} {ActiveKey} {TriggerType} POSITION {SequenceKey} {SourceKey}^{Environment.NewLine}SET TERM ; ^{Environment.NewLine}";         
        public static string DropTriggerPattern         = $@"DROP TRIGGER {TriggerKey};";
        public static string AddGeneratorPattern        = $@"CREATE GENERATOR {GeneratorKey};{Environment.NewLine}SET GENERATOR {GeneratorKey} TO {ValueKey};";                    
        public static string DropGeneratorPattern       = $@"DROP GENERATOR {GeneratorKey};";
        public static string AddDomainPattern           = $@"CREATE DOMAIN {DomainKey} AS {DataTypeKey};";            
        public static string DropDomainPattern          = $@"DROP DOMAIN {DomainKey};";                    
        public static string InsertPattern              = $@"INSERT INTO {TableKey}({ColumnKey})VALUES({ValueKey})";
        public static string UpdateInsertPattern        = $@"UPDATE OR INSERT INTO {TableKey}({ColumnKey})VALUES({ValueKey})";            
        public static string UpdatePattern              = $@"UPDATE {TableKey} SET {ValueKey} WHERE ({PrimaryKey})";                              
        public static string DropIndexPattern           = $@"DROP INDEX {IndexKey};";                    
        public static string ActivateIndexPattern       = $@"ALTER INDEX {IndexKey} ACTIVE;";
        public static string ActivateFKPattern          = ActivateIndexPattern;
        public static string DeactivateIndexPattern     = $@"ALTER INDEX {IndexKey} INACTIVE;";
        public static string DeactivateFKPattern        = DeactivateIndexPattern;
        public static string DropConstraintPattern      = $@"DROP CONSTRAINT {ConstraintKey};";
        public static string DropNotNullConstraintPattern = $@"ALTER TABLE {TableKey} ALTER {FieldKey} DROP NOT NULL;";
        public static string DropPrimaryKeyConstraintPattern = $@" ALTER TABLE {TableKey} DROP CONSTRAINT {ConstraintKey};";
        public static string DropColumnPattern          = $@"ALTER TABLE {TableKey} DROP {ColumnKey};";
        public static string DropTableConstraintPattern = $@"ALTER TABLE {TableKey} DROP CONSTRAINT {ConstraintKey};";
        

        public static string AddForeignKeyConstraintPattern = $@"ALTER TABLE {TableKey} ADD CONSTRAINT {ConstraintKey} FOREIGN KEY({ColumnKey}) REFERENCES {ReferenceTableKey} ({ReferenceColumnKey}) ON UPDATE {UpdateTypeKey};";
        public static string Commit = "COMMIT;";
        public static string SetTermStart = "SET TERM ^ ;";
        public static string SetTermEnd   = "SET TERM ; ^";
        public static string ScriptTerminator   = "^";
    }
}
