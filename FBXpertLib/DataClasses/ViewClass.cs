using FBXpertLib.DataClasses;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FBExpertLib.DataClasses
{
    public class ViewClass : DataObjectClass
    {
        
        public string SQL;
        public string CREATEINSERT_SQL;
        public string CREATE_SQL;
        public Dictionary<string,ViewFieldClass> Fields = new Dictionary<string,ViewFieldClass>();

        public Dictionary<string,DependencyClass> DependenciesTO_Tables;
        public Dictionary<string,DependencyClass> DependenciesFROM_Tables;
        public Dictionary<string,DependencyClass> DependenciesTO_Triggers;
        public Dictionary<string,DependencyClass> DependenciesFROM_Triggers;
        public Dictionary<string,DependencyClass> DependenciesTO_Views;
        public Dictionary<string,DependencyClass> DependenciesFROM_Views;
        public Dictionary<string,DependencyClass> DependenciesTO_Procedures;
        public Dictionary<string,DependencyClass> DependenciesFROM_Procedures;


        public CheckState State = CheckState.Unchecked;
        public override string ToString()
        {
            return Name;
        }

        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class DepentViewClass : DataObjectClass
    {

        public string SQL;
        public string CREATEINSERT_SQL;
        public string CREATE_SQL;
        public Dictionary<string,ViewFieldClass> Fields = new Dictionary<string,ViewFieldClass>();

        public Dictionary<string,DependencyClass> DependenciesTO_Tables;
        public Dictionary<string,DependencyClass> DependenciesFROM_Tables;
        public Dictionary<string,DependencyClass> DependenciesTO_Triggers;
        public Dictionary<string,DependencyClass> DependenciesFROM_Triggers;
        public Dictionary<string,DependencyClass> DependenciesTO_Views;
        public Dictionary<string,DependencyClass> DependenciesFROM_Views;
        public Dictionary<string,DependencyClass> DependenciesTO_Procedures;
        public Dictionary<string,DependencyClass> DependenciesFROM_Procedures;

        public override string ToString()
        {
            return Name;
        }

        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class ViewGroupClass : DataObjectClass
    {       
        public override string ToString()
        {
            return Name;
        }
    }
}
