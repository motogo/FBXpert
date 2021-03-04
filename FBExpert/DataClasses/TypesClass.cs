using FBExpert.DataClasses;
using System;
using System.Numerics;

namespace FBXpert.DataClasses
{

    public static class TypeConvert
    {
        public static string GetRawType(string DBType, int length)
        {
            /*
            LONG        4   INTEGER
            INT64       8   BIGINT            
            DOUBLE      8   DOUBLE PRECISION
            SHORT       2   NUMERIC
            VARYING     X   VARCHAR(X)
            TEXT        X   VARCHAR(X)   CHAR(X)
            BLOB        8   BLOB            
            QUAD
            BOOLEAN
            TIMESTAMP   8   TIMESTAMP
            TIME            TIME
            DATE            DATE
            BLOB_ID
            CSTRING     X   VARCHAR(X)
            FLOAT FLOAT
            */

            if ((DBType == "LONG")&& (length == 4))
            {                 
                return "INTEGER";                
            }
            else if ((DBType == "SHORT") && (length == 2))
            {
                return "INTEGER";
            }
            else if ((DBType == "INT64") && (length == 8))
            {
                return "BIGINT";
            }
            else if (DBType.StartsWith("VARYING"))
            {
                return "VARCHAR("+length.ToString()+")";
            }
            else if (DBType.StartsWith("TEXT"))
            {
                return "VARCHAR(" + length.ToString() + ")";
            }
            else if (DBType.StartsWith("CSTRING"))
            {
                return "VARCHAR(" + length.ToString() + ")";
            }
            else if ((DBType =="TIMESTAMP")&&(length == 8))
            {
                return "TIMESTAMP";
            }
            else if (DBType == "TIME") 
            {
                return "TIME";
            }
            else if (DBType == "DATE") 
            {
                return "DATE";
            }
            else if (DBType == "DOUBLE")
            {
                return "DOUBLE PRECISION";
            }
            else if (DBType == "FLOAT")
            {
                return "FLOAT";
            }
            
            return "";
        }

        public static string GetUDFType(string DBType, int length)
        {
            /*
            LONG        4   INTEGER
            INT64       8   BIGINT            
            DOUBLE      8   DOUBLE PRECISION
            SHORT       2   NUMERIC
            VARYING     X   VARCHAR(X)
            TEXT        X   VARCHAR(X)   CHAR(X)
            BLOB        8   BLOB            
            QUAD
            BOOLEAN
            TIMESTAMP   8   TIMESTAMP
            TIME            TIME
            DATE            DATE
            BLOB_ID
            CSTRING     X   VARCHAR(X)
            FLOAT FLOAT
            */

            if ((DBType == "LONG")&& (length == 4))
            {                 
                return "INTEGER";                
            }
            else if ((DBType == "SHORT") && (length == 2))
            {
                return "SMALLINT";
            }
            else if ((DBType == "INT64") && (length == 8))
            {
                return "BIGINT";
            }
            else if (DBType.StartsWith("VARYING"))
            {
                return "VARCHAR("+length.ToString()+")";
            }
            else if (DBType.StartsWith("TEXT"))
            {
                return "VARCHAR(" + length.ToString() + ")";
            }
            else if (DBType.StartsWith("CSTRING"))
            {
                return "CSTRING(" + length.ToString() + ")";
            }
            else if ((DBType =="TIMESTAMP")&&(length == 8))
            {
                return "TIMESTAMP";
            }
            else if (DBType == "TIME") 
            {
                return "TIME";
            }
            else if (DBType == "DATE") 
            {
                return "DATE";
            }
            else if (DBType == "DOUBLE")
            {
                return "DOUBLE PRECISION";
            }
            else if (DBType == "FLOAT")
            {
                return "FLOAT";
            }
            
            return "";
        }


        public static string DatabaseTOcsharpTypeAsString(DomainClass domain)
        {
            string stype = "RawType_ToCSharpType_Error->" + domain.RawType;
            if (domain.FieldType == "LONG")
            {
                stype = "int";
                if (!domain.NotNull) stype = stype + "?";
                return stype;
            }
            else if (domain.RawType == "BIGINT")
            {                
                stype = "BigInteger";
                if (!domain.NotNull) stype = stype + "?";
                return stype;
            }
            else if (domain.FieldType == "INT64")
            {
                stype = "long";
                if (!domain.NotNull) stype = stype + "?";
                return stype;
            }
            
            else if (domain.FieldType == "FLOAT")
            {                
                stype = "float";
                if (!domain.NotNull) stype = stype + "?";
                return stype;
            }
            else if (domain.FieldType == "SHORT")
            {
                stype = "int";
                if (!domain.NotNull) stype = stype + "?";
                return stype;
            }
            else if (domain.FieldType == "VARYING")
            {
                return "string";
            }
            else if (domain.FieldType == "TEXT")
            {
                return "string";
            }
            else if (domain.FieldType == "CSTRING")
            {
                return "string";
            }
            else if (domain.FieldType.StartsWith("TIME"))
            {
                return "DateTime";
            }
            else if (domain.FieldType.StartsWith("DATE"))
            {
                return "DateTime";
            }
            else if (domain.FieldType.StartsWith("BOOLEAN"))
            {
                return "bool";
            }
            else if (domain.FieldType.StartsWith("BLOB"))
            {
                return "byte[]";
            }
            else if (domain.FieldType.StartsWith("DOUBLE"))
            {
                stype = "double";
                if (!domain.NotNull) stype = stype + "?";
                return stype;
            }

            return stype;
        }

        public static string DatabaseTOcsharpValueTypeAsString(DomainClass domain)
        {
            string stype = "RawType_ToCSharpType_Error->" + domain.RawType;
            if (domain.FieldType == "LONG")
            {
                stype = "int";
                
                return stype;
            }
            else if (domain.FieldType == "INT64")
            {
                stype = "int";
                
                return stype;
            }
            else if (domain.FieldType == "FLOAT")
            {                
                stype = "float";
                
                return stype;
            }
            else if (domain.FieldType == "SHORT")
            {
                stype = "int";
                
                return stype;
            }
            else if (domain.FieldType == "VARYING")
            {
                return "string";
            }
            else if (domain.FieldType == "TEXT")
            {
                return "string";
            }
            else if (domain.FieldType == "CSTRING")
            {
                return "string";
            }
            else if (domain.FieldType.StartsWith("TIME"))
            {
                return "DateTime";
            }
            else if (domain.FieldType.StartsWith("DATE"))
            {
                return "DateTime";
            }
            else if (domain.FieldType.StartsWith("BOOLEAN"))
            {
                return "bool";
            }
            else if (domain.FieldType.StartsWith("BLOB"))
            {
                return "byte[]";
            }
            else if (domain.FieldType.StartsWith("DOUBLE"))
            {
                stype = "double";                
                return stype;
            }
            
            return stype;
        }

        public static Type DatabaseTOcsharpType(DomainClass domain)
        {
            string stype = "RawType_ToCSharpType_Error->" + domain.RawType;
            if (domain.FieldType == "LONG")
            {
                if (!domain.NotNull) return typeof(int?);
                return typeof(int);
            }
            else if (domain.FieldType == "INT64")
            {
                if (!domain.NotNull) return typeof(long?);
                return typeof(long);
            }
            else if (domain.FieldType == "SHORT")
            {
                if (!domain.NotNull) return typeof(int?);
                return typeof(int);
            }
            else if (domain.FieldType == "VARYING")
            {
                return typeof(string);
            }
            else if (domain.FieldType == "CSTRING")
            {
                return typeof(string);
            }
            else if (domain.FieldType == "TEXT")
            {
                return typeof(string);
            }
            else if (domain.FieldType.StartsWith("TIME"))
            {
                return typeof(DateTime);
            }
            else if (domain.FieldType.StartsWith("DATE"))
            {
                return typeof(DateTime);
            }
            else if (domain.FieldType.StartsWith("BOOLEAN"))
            {
                return typeof(bool);
            }
            else if (domain.FieldType.StartsWith("BLOB"))
            {
                return typeof(byte[]);
            }
            else if (domain.FieldType.StartsWith("DOUBLE"))
            {
                if (!domain.NotNull) return typeof(double?);
                return typeof(double);
            }
            else if (domain.FieldType.StartsWith("FLOAT"))
            {
                if (!domain.NotNull) return typeof(float?);
                return typeof(float);
            }
           
            return null;
        }

        

        public static eLogicalType ToLogicalType(DomainClass domain)
        {
            if (domain.FieldType == "LONG")
            {
                return eLogicalType.NUMBER;
            }
            else if (domain.FieldType == "INT64")
            {
                return eLogicalType.NUMBER;
            }
            else if (domain.FieldType == "SHORT")
            {
                return eLogicalType.NUMBER;
            }
            else if (domain.FieldType == "FLOAT")
            {
                return eLogicalType.POINTNUMBER;
            }
            else if (domain.FieldType == "VARYING")
            {
                return eLogicalType.TEXT;
            }
            else if (domain.FieldType == "CSTRING")
            {
                return eLogicalType.TEXT;
            }
            else if (domain.FieldType == "TEXT")
            {
                return eLogicalType.TEXT;
            }
            else if (domain.FieldType.StartsWith("TIME"))
            {
                return eLogicalType.TIMESTAMP;
            }
            else if (domain.FieldType.StartsWith("DATE"))
            {
                return eLogicalType.DATE;
            }
            else if (domain.FieldType.StartsWith("DOUBLE"))
            {
                return eLogicalType.POINTNUMBER;
            }
            else if (domain.FieldType.StartsWith("BOOLEAN"))
            {
                return eLogicalType.BOOL;
            }
            else if (domain.FieldType.StartsWith("BLOB"))
            {
                return eLogicalType.BINARY;
            }
            
            return eLogicalType.NONE;
        }

        public static string ToDefaultEmpty(DomainClass domain)
        {
            eLogicalType ltyp = ToLogicalType(domain);

            if ((ltyp == eLogicalType.TIMESTAMP) || (ltyp == eLogicalType.DATE))
            {
                return "DateTimePicker.MinimumDateTime";
            }
            else if (ltyp == eLogicalType.NUMBER)
            {
                if (!domain.NotNull) return "null";
                return "0";
            }
            else if (ltyp == eLogicalType.TEXT)
            {
                return "\"\"";
            }
            else if (ltyp == eLogicalType.POINTNUMBER)
            {
                if (!domain.NotNull) return "null";
                return "0.0";
            }
            else if (ltyp == eLogicalType.BOOL)
            {               
                return "false";
            }
            else if (ltyp == eLogicalType.BINARY)
            {
                return "null";
            }
            
            return "ToDefaultEmpty_TypeError_" + domain.FieldType;
        }

        public static string ToDefaultDBNull(DomainClass domain)
        {

            eLogicalType ltyp = ToLogicalType(domain);
            if ((ltyp == eLogicalType.TIMESTAMP) || (ltyp == eLogicalType.DATE))
            {
                return "new DateTime(1, 1, 1)";
            }
            else if (ltyp == eLogicalType.NUMBER)
            {
                if (!domain.NotNull) return "null";
                return "DBNULLasINT";
            }
            else if (ltyp == eLogicalType.TEXT)
            {
                return "\"\"";
            }
            else if (ltyp == eLogicalType.BOOL)
            {
                return "false";
            }
            else if (ltyp == eLogicalType.BINARY)
            {
                return "null";
            }
            else if (ltyp == eLogicalType.POINTNUMBER)
            {
                if (!domain.NotNull) return "null";
                return "0.0";
            }
            return "TypeDBNullError_" + domain.FieldType;
        }
    }

 
}
