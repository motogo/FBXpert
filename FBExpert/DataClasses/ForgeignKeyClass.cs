using FBExpert.DataClasses;
using System.Collections.Generic;

namespace FBXpert.DataClasses
{
    public class ForeignKeyClass : ConstraintsClass // DataObjectClass
    {
        public string SourceTableName;
       // public TableClass Table;
       // public string FieldName;
        public string DestTableName;
        public bool IsActive;
        public Dictionary<string,FieldClass> SourceFields = new Dictionary<string, FieldClass>();
        public Dictionary<string,FieldClass> DestFields = new Dictionary<string, FieldClass>();
    }
    public class ForeignKeyGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
