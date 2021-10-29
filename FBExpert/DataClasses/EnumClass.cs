using Enums;
using System;

namespace FBXpert.DataClasses
{
    public enum eAppType { Konfiguration = 0, Anwendung = 1 }
    public enum HistoryMode { NoHistory, AddToHistory };
    public enum FBRelationTypeIndex { Table = 0, View = 1 };
    
    public enum eRegState { none = 0, create = 1, update = 2, delete = 3 };
    public enum eTableType { withoutsystem = 0, system = 1 };
    public enum eObjectState { none = 0, is_checked = 1 };
    public enum eCreateMode { create = 0, recreate = 1, drop = 2 };
    public enum eSQLFileWriteMode { none = 0, all = 1, seperated = 2 };
    public enum eSourceCodePrimaryKeyType{GeneratorInteger=0, UUID=1, GUID=2, HEXGUID=3, none=4 };

    public enum eSQLHistoryType {failed=0, succeeded=1 }
      
    public enum eDependencies
    {
        [EnumDescription("Table")]
        TABLE =0,
        [EnumDescription("View")]
        VIEW =1,
        [EnumDescription("Trigger")]
        TRIGGER =2,
        [EnumDescription("Computed")]
        COMPUTED =3,
        [EnumDescription("Validation")]
        VALIDATION =4,
        [EnumDescription("Procedure")]
        PROCEDURE =5,
        [EnumDescription("Expression")]
        EXPRESSION =6,
        [EnumDescription("Exception Index")]
        EXCEPTIONINDEX =7,
        [EnumDescription("User")]
        USER =8,
        [EnumDescription("Field")]
        FIELD =9,
        [EnumDescription("Index")]
        INDEX =10,
        [EnumDescription("Generator")]
        GENERATOR =14,
        [EnumDescription("UDF")]
        UDF =15,
        [EnumDescription("NONE")]
        NONE =16
    };

    public enum eSort
    {
        [EnumDescription("ASC")]
        ASC = 0,
        [EnumDescription("DESC")]
        DESC = 1,
        [EnumDescription("NONE")]
        NONE = 2
    };
    public enum eBlobSubType
    {
        [EnumDescription("BINARY")]
        BINARY = 0,
        [EnumDescription("TEXT")]
        TEXT = 1,
        [EnumDescription("BLR")]
        BLR = 2
    }
    public enum eConstraintType
    {
        [EnumDescription("NONE")]
        NONE = 0,
        [EnumDescription("UNIQUE")]
        UNIQUE = 1,
        [EnumDescription("NOT NULL")]
        NOTNULL = 2,
        [EnumDescription("PRIMARY KEY")]
        PRIMARYKEY = 3,
        [EnumDescription("FOREIGN KEY")]
        FOREIGNKEY = 4,
        [EnumDescription("CHECK")]
        CHECK = 5
    };

    public enum eDBVersion
    {
        [EnumDescription("FB25_32")]
        FB25_32 =250,
        [EnumDescription("FB3_32")]
        FB3_32 = 300,
        [EnumDescription("FB4_32")]
        FB4_32 = 400,        
        [EnumDescription("FB25_64")]
        FB25_64 =251,
        [EnumDescription("FB3_64")]
        FB3_64 = 301,        
        [EnumDescription("FB4_64")]
        FB4_64 = 401
    };

    public enum eTriggerType
    {
        [EnumDescription("NONE")]
        none = 0,
        [EnumDescription("BEFORE INSERT")]
        beforeInsert = 1,
        [EnumDescription("AFTER INSERT")]
        afterInsert = 2,
        [EnumDescription("BEFORE UPDATE")]
        beforeUpdate = 3,
        [EnumDescription("AFTER UPDATE")]
        afterUpdate = 4,
        [EnumDescription("BEFORE DELETE")]
        beforeDelete = 5,
        [EnumDescription("AFTER DELETE")]
        afterDelete = 6,
        [EnumDescription("BEFORE INSERT OR UPDATE")]
        beforeInsertOrUpdate = 17,
        [EnumDescription("AFTER INSERT OR UPDATE")]
        afterInsertOrUpdate = 18,
        [EnumDescription("BEFORE INSERT OR DELETE")]
        beforeInsertOrDelete = 25,
        [EnumDescription("AFTER INSERT OR DELETE")]
        afterInsertOrDelete = 26,
        [EnumDescription("BEFORE UPDATE OR DELETE")]
        beforeUpdateOrDelete = 27,
        [EnumDescription("AFTER UPDATE OR DELETE")]
        afterUpdateOrDelete = 28,
        [EnumDescription("BEFORE INSERT OR UPDATE OR DELETE")]
        beforeInsertOrUpdateOrDelete = 113,
        [EnumDescription("AFTER INSERT OR UPDATE OR DELETE")]
        afterInsertOrUpdateOrDelete = 114,
        [EnumDescription("ON CONNECT")]
        onConnect = 8192,
        [EnumDescription("ON DISCONNECT")]
        onDisconnect = 8193,
        [EnumDescription("ON TRANSACTION START")]
        onTransactionStart = 8194,
        [EnumDescription("ON TRANSACTION COMMIT")]
        onTransactionCommit = 8195,
        [EnumDescription("ON TRANSACTION ROLLBACK")]
        onTransactionRollback = 8196
    };


    public enum eImageIndex
    {
        [EnumDescription("NONE")]
        NONE = 0,
        [EnumDescription("UNIQUE")]
        UNIQUE = 17,
        [EnumDescription("NOT NULL")]
        NOTNULL = 18,
        [EnumDescription("PRIMARY KEY")]
        PRIMARYKEY = 16,
        [EnumDescription("FOREIGN KEY")]
        FOREIGNKEY = 15,
        ROLES = 11,
        KEYS = 12,
        RULES = 13,
        GENERATORS =9,
        TABLES=3,
        FIELDS=14,
        INDEX=10,
        VIEW=4,
        DOMAIN=8,
        PROCEDURE=9,
        FUNCTION=7,
        TRIGGERS=19,
        CHECK=20,
        DEPENDENCYTO=21,
        DEPENDENCYFROM=22,
        DEPENDENCY = 5,
        DATABASE_INACTIVE = 1,
        DATABASE_ACTIVE = 2

    };



    public class EnumClass
    {

        private static readonly Lazy<EnumClass> lazy = new Lazy<EnumClass>(() => new EnumClass());
        public static EnumClass Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public string GetDependenciesTypeSQLCase()
        {
            string case0 = "WHEN 0 THEN 'TABLE' WHEN 1 THEN 'VIEW' WHEN 2 THEN 'Trigger' WHEN 3 THEN 'Computed' WHEN 4 THEN 'Validation' WHEN 5 THEN 'Procedure' WHEN 6 THEN 'Expression' WHEN 7 THEN 'ExceptionIndex' WHEN 8 THEN 'User' WHEN 9 THEN 'Field' WHEN 10 THEN 'Index' WHEN 14 THEN 'Generator' WHEN 15 THEN 'UDF' ELSE 'UNKNOWN' END";
            return case0;
        }
    }
}
