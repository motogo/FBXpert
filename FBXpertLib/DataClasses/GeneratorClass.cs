using System.Windows.Forms;

namespace FBExpertLib.DataClasses
{
    public class GeneratorClass : DataObjectClass
    {
        public long Value;
        public long InitValue;
        
        public string Description;
        public CheckState State = CheckState.Unchecked;
    }
    public class GeneratorGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
