

namespace FBXpertLib
{
    public class ChecksClass : ConstraintsClass
    {
        // public List<string> FieldNames = new List<string>();
        public ChecksClass()
        {
            ConstraintType = eConstraintType.PRIMARYKEY;
        }
    }


    public class ChecksGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;

        }
    }
}
