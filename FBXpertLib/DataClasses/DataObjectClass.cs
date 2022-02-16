using System;
using System.Collections;

namespace FBExpertLib.DataClasses
{
    public class DataObjectClass : ICloneable, IEnumerable
    {
        private string _name;
        public DataObjectClass()
        {
        
        }
        public DataObjectClass(string name)
        {
            Name = name;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override string ToString()
        {
            return Name;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
