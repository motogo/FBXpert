using DBBasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using MessageLibrary;

namespace FBXpert.SQLStatements
{
    public class SQLStatementsBase
    {
    
        public  eDBVersion Version = eDBVersion.FB3_32;
        
        

        public SQLStatementsBase()
        {
           
        }

        public string GetErrorCodeString(string errorString,DBRegistrationClass DBReg)
        {
            if(!errorString.Contains("No message for error code")) return errorString;
                        
            int inx1 = errorString.IndexOf("error code ");
            int inx2 = errorString.LastIndexOf(" found");
            string estr = errorString.Substring(inx1+11,inx2-inx1-11);
            long.TryParse(estr, out long ecc);
            string err = string.Empty;
            if((ecc > 0)&&(DBReg.GetErrorCodes().Errors.Count > 0))
            {
                if(DBReg.GetErrorCodes().Errors.TryGetValue(ecc,out err))
                return errorString.Replace($@"{ecc} found",$@"Error Code:{err}").Replace("No message for error code","");
            }
            return errorString;            
        }

        public SQLCommandsReturnInfoClass ExecSql( string cmd, DBRegistrationClass DBReg, NotifiesClass localNotify)
        {
            var SQLcommand = new SQLCommandsClass(DBReg, null);
            SQLcommand.SetEncoding("NONE");
            var ri = SQLcommand.ExecuteCommand(cmd,true);
            if (!ri.commandDone)
            {
                string errorStr  = GetErrorCodeString(ri.lastError,DBReg);                
                localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"FieldForm->ExecuteCommand", $@"{cmd}->{errorStr}"));
            }
            else
            {
                localNotify?.AddToINFO(AppStaticFunctionsClass.GetFormattedInfo($@"Command done", cmd));
            }
            return ri;
        }
    }
   
}
