using System.Windows.Forms;

namespace FBExpertLib.DataClasses
{
    public class DomainClass : DataObjectClass
    {        
        public int Length;
        public int TypeNumber;
        public int SubTypeNumber;
        public int SegmentLength;
        public string RawType;
        public int Precision;
        public int Scale;
        public string FieldType;
        public string Description;
        public string Collate;
        public string CharSet;
        public string Check;
        public bool NotNull;
        public string _defaultValue;
        public string DefaultValue
        {
            set
            {
                 _defaultValue = value;
            }
            get
            {
                return _defaultValue;
            }
        }
        public CheckState State = CheckState.Unchecked;
        public override string ToString()
        {
            return Name;
        }
    }
    public class DomainGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
