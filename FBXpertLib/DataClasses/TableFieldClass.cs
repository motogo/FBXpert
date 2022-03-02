using System.Windows.Forms;

namespace FBXpertLib
{
    public class FieldClass : DataObjectClass
    {
        public DomainClass Domain;

        public FieldClass()
        {
        }
        public FieldClass(string name) : base(name)
        {

        }
    }
    public class TableFieldClass : FieldClass
    {

        public TableFieldClass()
        {
            Domain = new DomainClass();

        }
        public override string ToString()
        {
            return Name;
        }

        public TableFieldClass DeepClone()
        {
            return (MemberwiseClone() as TableFieldClass);
        }
        public CheckState State = CheckState.Unchecked;
        public int Position;

        public string DefaultValue;
        public string PK_ConstraintName = string.Empty;
        public string Description;
        public string TableName;
        public bool IsPrimary;
    }
    public class ViewFieldGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class TableFieldGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class ViewFieldClass : FieldClass
    {
        public ViewFieldClass()
        {
            Domain = new DomainClass();
        }

        public int Position;

        public bool NotNull;
        public string DefaultValue;
        public bool IS_PRIMARY;
        public bool IS_UNIQUE;
        public eObjectState State = eObjectState.none;
        public string BaseField;
        public int UpdateFlag;
    }

}
