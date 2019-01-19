using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBExpert.DataClasses
{
    public enum eParameterTypDirection {din=1, dout=0 };
    public class ParameterClass : DomainClass
    {
        public int Position = 0;
     //   public int InOutTyp = 0;
    }
    public class ProcedureClass : DataObjectClass
    {
        public List<string> Source = new List<string>();
        public List<ParameterClass> ParameterIn = new List<ParameterClass>();
        public List<ParameterClass> ParameterOut = new List<ParameterClass>();
        public string Description;
        public CheckState State = CheckState.Unchecked;

        public string GetSourceText()
        {
            var sb = new StringBuilder();
            foreach (string str in Source)
            {
                sb.AppendLine(str);
            }

            return sb.ToString();
        }

    }

    public class ParameterListItem
    {
        public ParameterClass pc;
        public eParameterTypDirection direction;
    }

    public class ProceduresGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
