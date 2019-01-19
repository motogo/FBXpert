using System.Collections.Generic;
using System.IO;

namespace FBXpert.Globals
{
    public  class ErrorCodes
    {
        public  Dictionary<long,string> Errors = new Dictionary<long,string>();
        public  int Load(string fn)
        {
            Errors.Clear();
            if(!File.Exists(fn)) return 0;
            string[] lines = File.ReadAllLines(fn);
            foreach(string line in lines )
            {
                if(string.IsNullOrEmpty(line)) continue;
                int inx = line.IndexOf("=");
                if(inx > 0)
                {
                   string ec = line.Substring(0,inx);
                   long ecc = 0;
                   string err = line.Substring(inx+1);
                   long.TryParse(ec,out ecc);
                   if(ecc > 0)
                   {
                       Errors.Add(ecc,err);
                   }
                }
            }
            return Errors.Count;
        }
    }
}
