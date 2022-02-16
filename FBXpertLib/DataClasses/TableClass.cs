using FBXpertLib.DataClasses;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FBExpertLib.DataClasses
{
    public class TableClass : DataObjectClass
    {
        public Dictionary<string,TableFieldClass> Fields;
        public Dictionary<string,IndexClass> Indices;    
        public Dictionary<string,ForeignKeyClass> ForeignKeys;
        public Dictionary<string,TriggerClass> Triggers;
        public Dictionary<string,DependencyClass> DependenciesTO_Tables;
        public Dictionary<string,DependencyClass> DependenciesFROM_Tables;
        public Dictionary<string,DependencyClass> DependenciesTO_Triggers;
        public Dictionary<string,DependencyClass> DependenciesFROM_Triggers;
        public Dictionary<string,DependencyClass> DependenciesTO_Views;
        public Dictionary<string,DependencyClass> DependenciesFROM_Views;
        public Dictionary<string,DependencyClass> DependenciesTO_Procedures;
        public Dictionary<string,DependencyClass> DependenciesFROM_Procedures;

        public Dictionary<string,UniquesClass> uniques_constraints;
        public Dictionary<string,NotNullsClass> notnulls_constraints;
        public Dictionary<string,ConstraintsClass> check_constraints;

        public PrimaryKeyClass primary_constraint;
        

        public CheckState State = CheckState.Unchecked;

        public new object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool IsPrimary(string FieldName)
        {
            if (primary_constraint == null) return false;                       
            return primary_constraint.FieldNames.ContainsKey(FieldName);                                        
        }

        public bool IsNotNull(string FieldName)
        {
            if (notnulls_constraints == null) return false;           
            foreach (ConstraintsClass pk in notnulls_constraints.Values)
            {
                if(pk.FieldNames.ContainsKey(FieldName)) return true;                    
            }               
            return false;
        }

        public bool IsCheck(string FieldName)
        {
            if (check_constraints == null) return false;            
            foreach (ConstraintsClass pk in check_constraints.Values)
            {
                if(pk.FieldNames.ContainsKey(FieldName)) return true;                      
            }               
            return false;
        }
       
        public bool IsUnique(string FieldName)
        {           
            if (uniques_constraints == null) return false;            
            foreach (ConstraintsClass pk in uniques_constraints.Values)
            {
                 if(pk.FieldNames.ContainsKey(FieldName)) return true;                        
            }               
            return false;
        }
    }
    public class TableGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class SystemTableClass : TableClass
    {

    }
    public class SystemTableGroupClass : TableGroupClass
    {

    }
}
