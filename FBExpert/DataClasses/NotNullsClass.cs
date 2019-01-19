using FBExpert.DataClasses;

namespace FBXpert.DataClasses
{

    public class NotNullsClass : ConstraintsClass
    {        
        public NotNullsClass()
        {
            ConstraintType = eConstraintType.NOTNULL;
        }
    }


    public class NotNullsGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;

        }
    }
}
