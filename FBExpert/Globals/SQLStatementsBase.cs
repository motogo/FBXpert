using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpertLib.Globals;

namespace FBXpert.SQLStatements
{
    public class SQLStatementsBase
    {
    
        public  eDBVersion Version = eDBVersion.FB3_32;
        
        

        public SQLStatementsBase()
        {
           
        }

        
        public SQLCommandsReturnInfoClass ExecSql( string cmd, DBRegistrationClass DBReg, NotifiesClass localNotify)
        {
            var SQLcommand = new SQLCommandsClass(DBReg);
            SQLcommand.SetEncoding("NONE");
            var ri = SQLcommand.ExecuteCommand(cmd,true);
            if (!ri.commandDone)
            {
                string errorStr  = AppStaticFunctionsClass.GetErrorCodeString(ri.lastError,DBReg);                
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
