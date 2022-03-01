namespace FBXpertLib
{
    public class UniquesClass : ConstraintsClass
    {
        public UniquesClass()
        {
            ConstraintType = eConstraintType.PRIMARYKEY;
        }
    }


    public class UniquesGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;

        }
    }
}
