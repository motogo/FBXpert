using FBXpert.DataClasses;
using System.Windows.Forms;

namespace FBExpert.DataClasses
{
    public class TriggerClass : DataObjectClass
    {
        public bool Active = false;
        public eTriggerType Type = eTriggerType.none;
        public string Description = string.Empty;
        public string Source = string.Empty;
        public int Sequence = 0;
        public string RelationName = string.Empty;
        public CheckState State = CheckState.Unchecked;
    }

    public class TriggerGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
