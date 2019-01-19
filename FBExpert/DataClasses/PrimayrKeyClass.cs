using FBExpert.DataClasses;

namespace FBXpert.DataClasses
{

    public class PrimaryKeyClass : ConstraintsClass
    {        
        public PrimaryKeyClass()
        {
            ConstraintType = eConstraintType.PRIMARYKEY;
        }
    }


    public class PrimaryKeyGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
            
        }
    }
}
