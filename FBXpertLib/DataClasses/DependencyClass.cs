

namespace FBXpertLib
{ 
    public class DependencyClass : DataObjectClass
    {
        public string DependOnName { get; set; }
        public string FieldName { get; set; }
        public eDependencies Type { get; set; }
        public eDependencies TypeOn { get; set; }
    }
    
    public class DependencyGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
