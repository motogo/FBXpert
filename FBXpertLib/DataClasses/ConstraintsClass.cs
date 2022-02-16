using FBExpertLib.DataClasses;
using System.Collections.Generic;

namespace FBXpertLib.DataClasses
{
    public class ConstraintsClass : DataObjectClass
    {
        public string TableName { get; set; }
        public Dictionary<string,string> FieldNames { get; set; }
        public string IndexName { get; set; }
        public string TriggerName { get; set; }
        public string Source { get; set; }
        public eSort Sorting { get; set; }
        public string Description { get; set; }
        public eConstraintType ConstraintType { get; set; }
        public ConstraintsClass()
        {
            FieldNames = new Dictionary<string,string>();
        }
        public string FieldNamesString(string seperatetBy=",")
        {
            string str = string.Empty;
            foreach(string fn in FieldNames.Values)
            {
                str += string.IsNullOrEmpty(str) ? fn : $@",{fn}"; 
            }
            return str;
        }
    }


    /*
    public class UniquesConstraintsClass : ConstraintsClass
    {
    }
    public class CheckConstraintsClass : ConstraintsClass
    {
    }
    */

    public class ConstraintsGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class UniqueConstraintsGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class NotNullConstraintsGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class PrimaryKeyConstraintsGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class ChecksKeyConstraintsGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
