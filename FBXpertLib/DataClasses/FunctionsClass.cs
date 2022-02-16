using FBExpertLib.DataClasses;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBXpertLib.DataClasses
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
        public string GetSourceText()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<STARTPARAMS>");
            foreach (var pi in ParameterIn)
            {
                sb.AppendLine($@"ParameterIN :{pi.Name}->{ pi.RawType})");
            }
            foreach (var pi in ParameterOut)
            {
                sb.AppendLine($@"ParameterOUT:RETURNS->{ pi.RawType})");
            }
            sb.AppendLine("<ENDPARAMS>");
            sb.AppendLine("<STARTTEXT>");
            sb.AppendLine($@"CREATE OR ALTER FUNCTION {this.Name}");
            sb.AppendLine($@"(");
            foreach (var pi in ParameterIn)
            {
                sb.AppendLine($@"    {pi.Name} {pi.RawType}");
            }
            sb.AppendLine($@")");
            sb.AppendLine($@"RETURNS");
            foreach (var pi in ParameterIn)
            {
                sb.AppendLine($@"    {pi.RawType}");
            }
            sb.AppendLine($@"AS"); 

            foreach (string str in Source)
            {
                sb.AppendLine(str);
            }
            sb.AppendLine("<ENDTEXT>");
            return sb.ToString();
        }
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
