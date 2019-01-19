using FBExpert.DataClasses;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FBXpert.DataClasses
{
    /*
    public class FunctionClass : DataObjectClass
    {
        public string ModulName = string.Empty;
    }
    */
    /*
    public class ParameterClass : DomainClass
    {
        public int Position = 0;
        public int InOutTyp = 0;
    }
    */
    public enum eFunctionType {intern=1, userdefined=0 };
    public class FunctionClass : DataObjectClass
    {
        public List<string> Source = new List<string>();
        public List<ParameterClass> ParameterIn = new List<ParameterClass>();
        public List<ParameterClass> ParameterOut = new List<ParameterClass>();
        public string Description;
        public CheckState State = CheckState.Unchecked;
        public eFunctionType Type = eFunctionType.intern;
        public string ModuleType = string.Empty;
        public string EntryPoint = string.Empty;
    }

    public class UserDefinedFunctionClass : DataObjectClass
    {
        public List<string> Source = new List<string>();
        public List<ParameterClass> ParameterIn = new List<ParameterClass>();
        public List<ParameterClass> ParameterOut = new List<ParameterClass>();
        public string Description;
        public CheckState State = CheckState.Unchecked;
        public eFunctionType Type = eFunctionType.intern;
        public string ModuleType = string.Empty;
        public string EntryPoint = string.Empty;
    }
    

    public class FunctionGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public class UserDefinedFunctionGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
