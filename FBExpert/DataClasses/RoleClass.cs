using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBExpert.DataClasses
{
    public class RoleClass : DataObjectClass
    {
    }
    public class RoleGroupClass : DataObjectClass
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
