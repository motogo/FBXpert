using System.Text;

namespace FBXpert.DataClasses
{
    public class EncodingClass
    {
        public System.Text.Encoding encoding;
        public string internalName = string.Empty;
        public override string ToString()
        {
            return encoding.EncodingName;
        }
        public EncodingClass(System.Text.Encoding enc)
        {
            encoding = enc;
        }
        
    }
}
