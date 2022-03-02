using FBXpertLib;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FBExpert.DataClasses
{
    public class DevelopmentClass
    {

        protected static readonly object LockThis;
        private static DevelopmentClass _instance = null;
        public static DevelopmentClass Instance()
        {

            if (_instance == null)
            {
                // lock (_lock_this)
                {
                    _instance = new DevelopmentClass();
                }
            }

            return (_instance);
        }

        public string CopyRight()
        {
            return $@"{Application.ProductVersion} Copyright {Application.CompanyName} 2017 {Environment.MachineName}";
        }
        public string CopyRight(string formname)
        {
            return $@"{formname} { Application.ProductVersion} Copyright {Application.CompanyName} 2017 {Environment.MachineName}";
        }
        public string GetComputername()
        {
            return (Environment.MachineName);
        }

        public string GetVersion(string prg)
        {
            var fvi = FileVersionInfo.GetVersionInfo(prg);
            return (fvi.FileVersion);
        }

        public string GetDBInfo(DBRegistrationClass dbReg)
        {
            if (dbReg == null) return CopyRight() + " Database:null";
            return $"{CopyRight()} DB:{dbReg.Alias} ({dbReg.Server}:{dbReg.DatabasePath}";
        }

        public string GetDBInfo(DBRegistrationClass dbReg, string formname)
        {
            if (dbReg == null) return formname + "  Database:null";

            return $"{formname} DB:{dbReg.Alias} ({dbReg.Server}:{dbReg.DatabasePath})";
        }
    }
}
