using FBXpertLib.DataClasses;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FBExpertLib.DataClasses
{
    public class IndexClass : DataObjectClass
    {
        public bool Unique = false;
        public bool HasPrimaryConstraint = false;
        public bool IsActive = false;
        public string ConstraintName = string.Empty;
        public string RelationName = string.Empty;
        public CheckState State = CheckState.Unchecked;
        public eSort SortDirection = eSort.NONE;
        public Dictionary<string,FieldClass> RelationFields = new Dictionary<string,FieldClass>();
    }
    public class IndexGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
