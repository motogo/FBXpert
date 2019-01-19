using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FBXpert.Globals;
using FirebirdSql.Data.FirebirdClient;
using System.Diagnostics;

namespace FBXpert.DataClasses
{

    class CommandsDataClass
    {
        public string Command=string.Empty;
        public int BlockCount=0;
        public CommandsDataClass(string txt, int blockNr)
        {
            Command = txt;
            BlockCount = blockNr;
        }
        public override string ToString()
        {
            return $@"({BlockCount.ToString()}) {Command}";
        }
    }

    class SCRIPTCommandClass
    {
        public SCRIPTCommandClass()
        {

        }
        public SCRIPTCommandClass(string cmdText)
        {
            CommandText = cmdText;
        }
        public void Add(string partialText)
        {
            CommandText+=partialText;
        }
        public void Clear()
        {
           CommandText = string.Empty; 
        }
        public string CommandText = string.Empty;
        public SQLCommandType CommandType = SQLCommandType.none;
        public long Costs = 0;
        public string GUID = "";
    }

    class SQLScriptingClass
    {
        private List<string> _script = new List<string>();
        private SCRIPTCommandClass _aktCommand = null;
        private DBRegistrationClass _drc = null;
        private NotifiesClass _parentNotifies = null;
        private NotifiesClass _eventNotifies = null;
        private string _connectionName = "SCRIPT";
        private string _connstr;
        private bool _inBlock = false;
        private bool _inComments = false;
        private bool _inTerminator = false;
        private string _terminator = ";";
        private string _oldTerminator = ";";
        private FbConnection _actFbcon = null;       

        public bool CommitEachCommand = false;

        public SQLScriptingClass(DBRegistrationClass drc, string connectionName= "SCRIPT", NotifiesClass pNotifies=null, NotifiesClass eventNotifies=null)
        {
            _parentNotifies = pNotifies;
            _eventNotifies = eventNotifies;
            _connectionName = connectionName;
            _drc = drc;                    
            _connstr = ConnectionStrings.Instance().MakeConnectionString(_drc);
            _aktCommand = new SCRIPTCommandClass();
        }
                
        public void ClearCommands()
        {
            Commands.Clear();            
        }

        public int CommandsCount => Commands.Count;

        public Dictionary<string, SCRIPTCommandClass> Commands { get; } = new Dictionary<string, SCRIPTCommandClass>();

        public string RemoveComments(string txt)
        {
            //Remove Singleline Comments
            _parentNotifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " Remove comments");
            Application.DoEvents();
            int remstart = txt.IndexOf(_drc.SingleLineComment);
            int remend = -1;
            if (remstart >= 0)
            {
                remend = txt.Substring(remstart).IndexOf(_drc.NewLine) + remstart;

                while ((remstart >= 0) && (remend > remstart))
                {
                    txt = txt.Remove(remstart, remend - remstart + _drc.NewLine.Length);
                    remstart = txt.IndexOf(_drc.SingleLineComment);
                    remend = txt.IndexOf(_drc.NewLine);
                }
            }

            //Remore Comments
            remstart = txt.IndexOf(_drc.CommentStart);
            if (remstart >= 0)
            {
                remend = txt.IndexOf(_drc.CommentEnd);
                while ((remstart >= 0) && (remend > remstart))
                {
                    txt = txt.Remove(remstart, remend - remstart + _drc.CommentEnd.Length);
                    remstart = txt.IndexOf(_drc.CommentStart);
                    remend = txt.IndexOf(_drc.CommentEnd);
                }
            }
            return txt;
        }

        public string RemoveDoubleSpaces(string txt)
        {
            //Remove double spaces
            _parentNotifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " Remove double spaces");
            Application.DoEvents();
            while (txt.IndexOf("  ") >= 0)
            {
                txt = txt.Replace("  ", " ");
            }
            return txt;
        }
        
        public void AddText(string text)
        {
            AddCommandLine(text);
        }

        public bool AddCommandLine(string txt)
        {
            //Wenn erkannt wird das es sich um eine Infozeile handelt dann wird das InComments flag gesetzt.
            //Es wird nichts zum auführbaren Script _commands hinzugefügt.
            _eventNotifies?.Notify.RaiseInfo($@"SQLScriptingClass.AddCommandLine()", Constants.AddCommandLine, 1); 
            if(string.IsNullOrEmpty(txt) || txt.Equals("\r\n")) return false;
            if(IsCommentStart(txt))
            {
                _inComments = true;                
            }
            
            if(IsCommentEnd(txt))
            {
                _inComments = false;
                return false;
            }

            if(_inComments)
            {
                return false;
            }
            
            //SET TERM
            if (SetTerminator(txt))
            {         
                if(!_inTerminator)
                {
                    // Terminatorbereich wurd zum 2.Male erkannt -> Kommandoende;
                    // Das Kommando wird angefügt. Standardwerte für neues Komamnd werden gesetzt;
                    _aktCommand.CommandType = SQLCommand.GetStaticCommandType(_aktCommand.CommandText);
                                       
                    if((!CommitEachCommand)||(_aktCommand.CommandType != SQLCommandType.commit))
                    {
                        _aktCommand.GUID = Guid.NewGuid().ToString();
                        
                       Commands.Add(_aktCommand.GUID,_aktCommand);
                        _eventNotifies?.Notify.RaiseInfo($@"SQLScriptingClass.AddCommandLine()", Constants.CommandPrepared, _aktCommand); 
                    }
                    if((CommitEachCommand)&&(_aktCommand.CommandType != SQLCommandType.commit))
                    {
                        //Wenn das aktelle Kommando kein COMMIT; ist und nach jedem Kommando aber ein COMMIT; geschrieben werden soll.
                        _aktCommand = new SCRIPTCommandClass($@"COMMIT{_terminator}");
                        _aktCommand.CommandType = SQLCommandType.commit;
                        _aktCommand.GUID = Guid.NewGuid().ToString();
                         
                        Commands.Add(_aktCommand.GUID,_aktCommand);
                        _eventNotifies?.Notify.RaiseInfo($@"SQLScriptingClass.AddCommandLine()", Constants.CommandPrepared, _aktCommand); 
                    }

                    _aktCommand = new SCRIPTCommandClass();
                    _inBlock = false;   
                    _inTerminator = false;
                    return true;
                }
                return false;
            }
                        
            //Wenn die Scriptzeile mit den Terminator endet, dann ist das Kommando fertig
            //Das Kommando wird ohne den Terminator angelegt.
            if (IsTermiatorOrBlockEnd(txt))
            {                
                if (txt.Trim().Length > 1)
                {                                           
                    _aktCommand.Add(txt.Trim().Substring(0,txt.Trim().Length-1));
                    _aktCommand.CommandType = SQLCommand.GetStaticCommandType(_aktCommand.CommandText);
                    if((!CommitEachCommand)||(_aktCommand.CommandType != SQLCommandType.commit))
                    {
                        _aktCommand.GUID = Guid.NewGuid().ToString();
                            
                        Commands.Add(_aktCommand.GUID,_aktCommand);
                        _eventNotifies?.Notify.RaiseInfo($@"SQLScriptingClass.AddCommandLine()", Constants.CommandPrepared, _aktCommand); 
                    }
                    if((CommitEachCommand)&&(_aktCommand.CommandType != SQLCommandType.commit))
                    {
                        //Wenn das aktelle Kommando kein COMMIT; ist und nach jedem Kommando aber ein COMMIT; geschrieben werden soll.
                        _aktCommand = new SCRIPTCommandClass($@"COMMIT{_terminator}");
                        _aktCommand.CommandType = SQLCommandType.commit;
                        _aktCommand.GUID = Guid.NewGuid().ToString();;
                         
                        Commands.Add(_aktCommand.GUID,_aktCommand);
                        _eventNotifies?.Notify.RaiseInfo($@"SQLScriptingClass.AddCommandLine()", Constants.CommandPrepared, _aktCommand); 
                    }

                    _aktCommand = new SCRIPTCommandClass();
                    _inTerminator = false;
                    _inBlock = false;                    
                }                              
                return true;
            }
                                                            
            if (!_inBlock)
            {
                if (!BlockStart(txt)) return false;
                                                     
                txt = TestForValidation(txt);                    
                _aktCommand.Add(txt);                                       
                return(IsTermiatorOrBlockEnd(txt));                                                 
            }
                        
            if(_aktCommand.CommandText.Length <= 0) return false;
                         
            _aktCommand.Add(txt);                                         
            return (IsTermiatorOrBlockEnd(txt));                                                                         
        }

        public string TestForValidation(string txt)
        {
            string cmd = txt.Replace(" ,",",");
            
            int indv = cmd.IndexOf("VALUES(");
            if(indv >= 0)
            {
                int changed = 0;
                string cmd2 = cmd.Substring(indv+7);
                if (cmd2.Trim().EndsWith(");"))
                {
                    cmd2 = cmd2.Trim().Substring(0, cmd2.Trim().Length - 2);
                }
                string[] arr = cmd2.Split(',');
                for(int i = 0; i < arr.Length; i++)
                {
                    string arrcmd = arr[i].Trim();
                    int n = arrcmd.IndexOf("'", 1);
                    if ((n > -1)&&(n < arrcmd.Length-1))
                    {
                        arrcmd =  arrcmd.Insert(n, "'");
                        
                        _parentNotifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} ...Executing script, Apostroph quotet:{arr[i]}->{arrcmd}");
                        
                        arr[i] = arrcmd;
                        changed++;                                                                        
                    }
                }
                if (changed > 0)
                {
                    var sb = new StringBuilder();
                    sb.Append(cmd.Substring(0, indv + 7));
                    bool first = true;
                    foreach (string str in arr)
                    {
                        if (!first)
                        {
                            sb.Append(",");
                        }
                        sb.Append(str);
                        first = false;
                    }
                    sb.Append($@");{Environment.NewLine}");
                    return sb.ToString();
                }
            }
            return cmd;
        }

        public bool IsSetTerminator(string line)
        {
            return line.Trim().ToUpper().StartsWith("SET TERM");            
        }

        public bool IsCommentStart(string line)
        {
            string ln = line.Trim().ToUpper();
            if (ln.StartsWith("/*")) return true;
            if (ln.StartsWith("//")) return true;
            return false;
        }
        
        public bool IsCommentEnd(string line)
        {
            string ln = line.Trim().ToUpper();
            if (ln.EndsWith("*/")) return true;
            if (ln.StartsWith("//")) return true;
            return false;
        }

        public bool BlockStart(string line)
        {
            string ln = line.Trim().ToUpper();            
            if (ln.StartsWith("CREATE ")) _inBlock = true;
            if (ln.StartsWith("ALTER ")) _inBlock = true;
            if (ln.StartsWith("UPDATE ")) _inBlock = true;
            if (ln.StartsWith("INSERT ")) _inBlock = true;
            if (ln.StartsWith("COMMIT ")) _inBlock = true;
            if (ln.StartsWith("DROP ")) _inBlock = true;
            if (ln.StartsWith("SET ")) _inBlock = true;
            if (ln.StartsWith("DECLARE ")) _inBlock = true;
            if (ln.StartsWith("DEFAULT CHARACTER SET ")) _inBlock = true;
            if (ln.StartsWith("PAGE_SIZE ")) _inBlock = true;
            if (ln.StartsWith("USER ")) _inBlock = true;
            if (ln.StartsWith("SET NAMES ")) _inBlock = true;
            if (ln.StartsWith("SET SQL ")) _inBlock = true;
            if (ln.StartsWith("CONNECT ")) _inBlock = true;
            if (ln.StartsWith("COMMENT ")) _inBlock = true;
            if (ln.StartsWith("GRANT ")) _inBlock = true;            
            return _inBlock;
        }
        
        public bool IsTermiatorOrBlockEnd(string line)
        {
            string ln = line.Trim().ToUpper();
            if (ln.EndsWith(_terminator)) 
            {
                _inBlock = false;            
                return true;
            }
            return false;;
        }

        public bool SetTerminator(string line)
        {
            //   SET TERM; ^
            string ln = line.Trim().ToUpper();
            if (ln.StartsWith("SET TERM"))
            {                
                while (ln.IndexOf(" ") >= 0)
                {
                    ln = ln.Replace(" ", "");
                }
                _terminator = ln.Substring(ln.Length - 2,1);
                _oldTerminator = ln.Substring(ln.Length - 1,1);
                _inTerminator = !_inTerminator;
                return true;
            }            
            return false;
        }

        private bool CreateDatabaseOLD(string sqlCmd)
        {
            /*
                CREATE DATABASE 'localhost:D:\Data\kj\KJFERT59.FDB'
                USER 'SYSDBA' PASSWORD 'masterkey'
                PAGE_SIZE 8192
                DEFAULT CHARACTER SET NONE;
                */
            string sql = sqlCmd.ToUpper();
            string location = "D:\\Data\\test111.FDB";
            string server = "localhost";
            string user = "SYSDBA";
            string password = "masterkey";
            string packetsize = "8192";
            
            int inx = sql.IndexOf("CREATE DATABASE ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 16);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);

                int inx3 = arg.IndexOf(":\\", StringComparison.Ordinal);
                int inx4 = arg.IndexOf(":", StringComparison.Ordinal);
                if (inx4 < inx3)
                {
                    //server
                    server = arg.Substring(0, inx4).Replace("'", "");
                    location = arg.Substring(inx4 + 1);
                    location = location.Replace("'", "");
                }
                else
                {
                    //nur dateipfad
                    server = "localhost";
                    location = arg.Replace("'", ""); 
                }
            }

            inx = sql.IndexOf("USER ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 5);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                user = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PASSWORD ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 9);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                password = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PAGE_SIZE ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 10);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                packetsize = arg;
            }

            try
            {
                _parentNotifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " ...Creating new database via script " + server+":"+location);
                DBProviderSet.CreateDatabase(location, server, user, password, StaticFunctionsClass.ToIntDef(packetsize, AppSettingsClass.Instance().DatabaseSettings.DefaultPacketSize));
            }
            catch (Exception ex)
            {               
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{_drc.ToString()}-> CreateDatabase()", ex));                      
            }

            return true;
        }

        private FbConnection CreateConnectionOLD(string sqlCmd, FbConnection fbConn)
        {
            /*
            CONNECT 'LOCALHOST:D:\Data\test.fdb' USER 'SYSDBA' PASSWORD 'masterkey';
            */
            string sql = sqlCmd.ToUpper();
            string location = "D:\\Data\\test111.FDB";
           
            string user = "SYSDBA";
            string password = "masterkey";
                        
            int inx = sql.IndexOf("CONNECT ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 8);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg  = cmd3.Substring(0, inx2);

                int inx3 = arg.IndexOf(":\\", StringComparison.Ordinal);
                int inx4 = arg.IndexOf(":", StringComparison.Ordinal);
                if (inx4 < inx3)
                {
                    //server
                  
                    location = arg.Substring(inx4 + 1);
                    location = location.Replace("'", "");
                }
                else
                {
                    //nur dateipfad
                  
                    location = arg.Replace("'", ""); 
                }
            }

            inx = sql.IndexOf("USER ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                var cmd3 = sqlCmd.Substring(inx + 5);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                var arg = cmd3.Substring(0, inx2);
                user = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PASSWORD ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                var cmd3 = sqlCmd.Substring(inx + 9);
                
                var arg = cmd3.Substring(0);
                password = arg.Replace("'", ""); 
            }

            var drc = new DBRegistrationClass
            {
                DatabasePath = location,
                Dialect = 3,
                Password = password,
                User = user,
                Alias = "ConScript",
                CharSet = "UTF8",
                ConnectionType = eConnectionType.localhost
            };


            string connstr = ConnectionStrings.Instance().MakeConnectionString(drc);
            if (fbConn?.State == System.Data.ConnectionState.Open)
            {
                fbConn.Close();
            }
            fbConn = new FbConnection(connstr);
            fbConn.Open();
            _parentNotifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} ...Opening database via script {drc}");
            _parentNotifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} ...Database state:{fbConn.State.ToString()}");
            return fbConn;

        }
       
        bool TestApiFunctions(string cmd, FbConnection fbcon)
        {
            FbConnection fbcon2 = fbcon;
            string cmd1 = cmd.Trim();

            while (cmd1.IndexOf("\r\n", StringComparison.Ordinal) >= 0)
            {
                cmd1 = cmd1.Replace("\r\n", " ");
            }

            while (cmd1.IndexOf("  ", StringComparison.Ordinal) >= 0)
            {
                cmd1 = cmd1.Replace("  ", " ");
            }

            string cmd2 = cmd1.ToUpper();
            if (cmd2.StartsWith("CREATE DATABASE"))
            {
                CreateDatabase(cmd1);
                _actFbcon = fbcon2;
                return true;
            }
            else if(cmd2.StartsWith("CONNECT"))
            {
                fbcon2 = CreateConnection(cmd1,fbcon);
                _actFbcon = fbcon2;
                return true;
            }
            _actFbcon = fbcon2;
            return false;
        }
        
        private FbConnection CreateConnection(string sqlCmd, FbConnection fbConn)
       {
            /*
            CONNECT 'LOCALHOST:D:\Data\test.fdb' USER 'SYSDBA' PASSWORD 'masterkey';
            */
            string sql = sqlCmd.ToUpper();
            string location = "D:\\Data\\test111.FDB";
           
            string user = "SYSDBA";
            string password = "masterkey";
                        
            int inx = sql.IndexOf("CONNECT ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 8);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg  = cmd3.Substring(0, inx2);

                int inx3 = arg.IndexOf(":\\", StringComparison.Ordinal);
                int inx4 = arg.IndexOf(":", StringComparison.Ordinal);
                if (inx4 < inx3)
                {
                    //server
                  
                    location = arg.Substring(inx4 + 1);
                    location = location.Replace("'", "");
                }
                else
                {
                    //nur dateipfad
                  
                    location = arg.Replace("'", ""); 
                }
            }

            inx = sql.IndexOf("USER ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                var cmd3 = sqlCmd.Substring(inx + 5);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                var arg = cmd3.Substring(0, inx2);
                user = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PASSWORD ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                var cmd3 = sqlCmd.Substring(inx + 9);
                
                var arg = cmd3.Substring(0);
                password = arg.Replace("'", ""); 
            }

            var drc = new DBRegistrationClass
            {
                DatabasePath = location,
                Dialect = 3,
                Password = password,
                User = user,
                Alias = "ConScript",
                CharSet = "UTF8",
                ConnectionType = eConnectionType.localhost
            };


            string connstr = ConnectionStrings.Instance().MakeConnectionString(drc);
            if (fbConn?.State == System.Data.ConnectionState.Open)
            {
                fbConn.Close();
            }
            fbConn = new FbConnection(connstr);
            fbConn.Open();
            _parentNotifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " ...Opening database via script" + drc);
            _parentNotifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " ...Database state:"+fbConn.State.ToString());
            return fbConn;

        }

        private bool CreateDatabase(string sqlCmd)
        {
            /*
                CREATE DATABASE 'localhost:D:\Data\kj\KJFERT59.FDB'
                USER 'SYSDBA' PASSWORD 'masterkey'
                PAGE_SIZE 8192
                DEFAULT CHARACTER SET NONE;
                */
            string sql = sqlCmd.ToUpper();
            string location = "D:\\Data\\test111.FDB";
            string server = "localhost";
            string user = "SYSDBA";
            string password = "masterkey";
            string packetsize = "8192";
            
            int inx = sql.IndexOf("CREATE DATABASE ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 16);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);

                int inx3 = arg.IndexOf(":\\", StringComparison.Ordinal);
                int inx4 = arg.IndexOf(":", StringComparison.Ordinal);
                if (inx4 < inx3)
                {
                    //server
                    server = arg.Substring(0, inx4).Replace("'", "");
                    location = arg.Substring(inx4 + 1);
                    location = location.Replace("'", "");
                }
                else
                {
                    //nur dateipfad
                    server = "localhost";
                    location = arg.Replace("'", ""); 
                }
            }

            inx = sql.IndexOf("USER ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 5);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                user = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PASSWORD ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 9);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                password = arg.Replace("'", ""); 
            }

            inx = sql.IndexOf("PAGE_SIZE ", StringComparison.Ordinal);
            if (inx >= 0)
            {
                string cmd3 = sqlCmd.Substring(inx + 10);
                int inx2 = cmd3.IndexOf(" ", StringComparison.Ordinal);
                string arg = cmd3.Substring(0, inx2);
                packetsize = arg;
            }

            try
            {
                _parentNotifies?.AddToINFO(StaticFunctionsClass.DateTimeNowStr() + " ...Creating new database via script " + server+":"+location);
                DBProviderSet.CreateDatabase(location, server, user, password, StaticFunctionsClass.ToIntDef(packetsize, AppSettingsClass.Instance().DatabaseSettings.DefaultPacketSize));
            }
            catch (Exception ex)
            {               
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{sqlCmd}-> CreateDatabase()", ex));                      
            }

            return true;
        }

        private FbConnection IsCreateDatabaseOrConnect(string cmd, FbConnection fbcon)
        {
            
            FbConnection useCon = fbcon;
            string cmd1 = cmd.Trim();

            while (cmd1.IndexOf("\r\n", StringComparison.Ordinal) >= 0)
            {
                cmd1 = cmd1.Replace("\r\n", " ");
            }

            while (cmd1.IndexOf("  ", StringComparison.Ordinal) >= 0)
            {
                cmd1 = cmd1.Replace("  ", " ");
            }

            string cmd2 = cmd1.ToUpper();
            if (cmd2.StartsWith("CREATE DATABASE"))
            {
                CreateDatabase(cmd1);                
                return useCon;
            }
            else if(cmd2.StartsWith("CONNECT"))
            {
                useCon = CreateConnection(cmd1,fbcon);                
                return useCon;
            }           
            return null;
        }

        public int PrepareCommands(IList<string> Lines, bool clearCommands)
        {                    
            var content = new StringBuilder();            
            Application.DoEvents();          
            if(clearCommands) this.Commands.Clear();
            this.CommitEachCommand = true;                                                                                                                       
            content.Clear();           
            int absoluteNr = 0;
            
            foreach(string str in Lines)
            {                                                                                      
                bool cmdeady = this.AddCommandLine($@"{str}{Environment.NewLine}");
                if (!cmdeady) continue;     
                absoluteNr++;
                
            }    
            return absoluteNr;
        }

        public List<SQLCommandsReturnInfoClass> RunPreparedCommands()
        {
            //var sb = new StringBuilder();
            var riList = new List<SQLCommandsReturnInfoClass>();
            _parentNotifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} Executing script");
            Application.DoEvents();
         
          
           
            int i = 0;
            int nr = 0;

           
            FbConnection fbConn = null;
            FbCommand fbCmd = null;
            
           
            if (_drc.DatabasePath.Length > 0)
            {
                var connstr = ConnectionStrings.Instance().MakeConnectionString(_drc);
                try
                {
                    fbConn = new FbConnection(connstr);
                    fbConn.Open();                    
                }
                catch(Exception ex)
                {                                           
                    object[] param = {ex.Message};
                    SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DatabaseExceptionCaption","ErrorWhileOpeningDatabase",  SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation,null,param);                                        
                }
            }                
            
            if (fbConn.State == System.Data.ConnectionState.Open)
            {                
                var startDt = DateTime.Now;                
                bool DBRepoend = false;
                bool ReopenConnectionEachCommand = true;
                foreach(SCRIPTCommandClass command in this.Commands.Values)
                {
                    var ri = new SQLCommandsReturnInfoClass();
                    if(ReopenConnectionEachCommand)
                    {
                        if(fbCmd!=null&&fbCmd.Transaction != null)
                        {
                            ri.lastSQL = "ReopenDatabase";
                            try
                            {                                                                                                                       
                                fbCmd.Transaction.Commit();                                
                                fbCmd.Transaction = null; 
                                ri.commandDone = true;
                            }
                            catch (Exception ex)
                            {
                                ri.commandDone = false;                                
                                 _parentNotifies?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"Command error {fbCmd.CommandText}", ex));   
                                if(fbCmd.Transaction != null)
                                {
                                   fbCmd.Transaction.Rollback();                                   
                                   fbCmd.Transaction = null;                    
                                }                                                                            
                            }
                        }
                        fbConn.Close();
                        fbConn.Open();
                        DBRepoend = fbConn.State == System.Data.ConnectionState.Open;
                    }
                                      
                    var actDt = DateTime.Now;
                    if ((actDt.Ticks - startDt.Ticks) > 30000000000)
                    {
                        _parentNotifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} ...Executing script{nr.ToString()} commands done of {Commands.Count}.");
                    }
                                                           

                    FbConnection usedCon = IsCreateDatabaseOrConnect(command.CommandText,fbConn);
                    if(usedCon != null)
                    {
                        //Create Databes oder connect
                        if(fbConn != null)  if(fbConn.State != System.Data.ConnectionState.Closed) fbConn.Close();
                        fbConn = usedCon;
                        if(fbConn.State != System.Data.ConnectionState.Open) fbConn.Open();
                        continue;
                    }
                                           
                    if(fbCmd==null||fbCmd.Transaction==null||DBRepoend) 
                    {    
                        fbCmd = new FbCommand(command.CommandText, fbConn);
                        fbCmd.Transaction = fbConn.BeginTransaction(); 
                        DBRepoend = false;
                    }
                    else
                    {
                        fbCmd.CommandText = command.CommandText;
                    }

                    var sw = new Stopwatch();
                    sw.Start();
                    ri.lastCommandType = command.CommandType;
                    ri.lastSQL = command.CommandText;
                    try
                    {                                                                
                        if(command.CommandType == SQLCommandType.commit)
                        {                                
                            fbCmd.Transaction.Commit();
                            
                            fbCmd.Transaction = null;                    
                        }
                        else
                        {
                            fbCmd.ExecuteNonQuery(); 
                        } 
                        ri.commandDone = true;
                        
                    }
                    catch (Exception ex)
                    {
                        ri.nErrors++;
                        ri.lastError = ex.Message;
                        ri.commandDone = false;
                         _parentNotifies?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"Command error {fbCmd.CommandText}", ex));   
                        if(fbCmd.Transaction != null)
                        {
                           fbCmd.Transaction.Rollback();                           
                           fbCmd.Transaction = null;                    
                        }                                                                            
                    }
                    sw.Stop();
                    command.Costs = sw.ElapsedMilliseconds;
                    _eventNotifies?.Notify.RaiseInfo($@"SQLScriptingClass.RunPreparedCommands()", Constants.CommandDone, command);   
                    ri.costs = sw.ElapsedMilliseconds;
                    riList.Add(ri);                                                                                        
                    nr++;                
                }

                if(fbCmd != null && fbCmd.Transaction != null)
                {
                    fbCmd.Transaction.Commit();
                    
                    fbCmd.Transaction = null;
                }
                                    
                if (fbConn.State == System.Data.ConnectionState.Open) fbConn.Close();
            }
                      
            _parentNotifies?.AddToINFO($@"{StaticFunctionsClass.DateTimeNowStr()} Executing done {nr.ToString()} Commands");
            Application.DoEvents();
            return riList;
        }

        public List<SQLCommandsReturnInfoClass>  ExecuteCommands(IList<string> Lines)
        {                    
            PrepareCommands(Lines,true);          
            var riList = RunPreparedCommands();
            this.Commands.Clear();
            Application.DoEvents();
            return riList;
        }
        
    }
}
