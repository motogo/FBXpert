using BasicClassLibrary;
using DBBasicClassLibrary;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FBXpert.Globals
{
    public class SqlStack
    {
        public int inxStart;
        public int inxEnd;
        public int level;
        public string str;
        public SqlStack(int istart, int iend, int ilevel, string s)
        {
            inxStart = istart;
            inxEnd   = iend;
            level = ilevel;
        }
    };

    public static class AppStaticFunctionsClass
    {
        public static string getErrorPosText(string errorstring)
        {
            string result = string.Empty;
            if (errorstring.Contains("Token unknown - line "))
            {
                // Token unknown -line 1, column 202
                int inx = errorstring.IndexOf("Token unknown - line");
                string mld = errorstring.Substring(inx + 20);
                mld = mld.Replace("column", "").Replace("\r\n", "").Replace(".", "");
                string[] mldarr = mld.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (mldarr.Length > 1)
                {                    
                    int n2 = BasicClassLibrary.StaticFunctionsClass.ToIntDef(mldarr[1], -1);
                    result = (n2 > 10) ? $@"5->{errorstring.Substring(n2 - 5, 10)}" : $@"{n2}->{errorstring.Substring(0, n2)}";
                }
            }
            return result;
        }

        static public long SendResultNotify(List<SQLCommandsReturnInfoClass> riList, NotifiesClass notify)
        {
            long costs = 0;
            foreach (var ri in riList)
            {
                costs += ri.costs;
                if (ri.commandDone)
                {
                    notify.Notify.RaiseInfo($@"Done: {ri.lastSQL}{Environment.NewLine}", StaticVariablesClass.ReloadFields);
                }
                else
                {
                    notify.Notify.RaiseError($@"ERROR: {ri.lastSQL}->{ri.lastError}{Environment.NewLine}", StaticVariablesClass.ReloadFields);
                }
            }
            return costs;
        }

        public static string GetErrorCodeString(string errorString,DBRegistrationClass DBReg)
        {
            if(DBReg.GetErrorCodes().Errors.Count <= 0) return errorString;
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
        public static string GetFormattedError(string info)
        {
            return GetFormattedError(info, string.Empty);
        }

        public static string GetFormattedError(string info, Exception ex)
        {
            return GetFormattedError(info, ex.Message);
        }

        public static string GetFormattedError(string info, string message)
        {            
            if(string.IsNullOrEmpty(message)) return $@"{info}";
            return $@"{info}{Environment.NewLine}    ->msg:{message}";
        }

        public static string GetLifetime(string cnString, bool withMon)
        {
            string _funcStr = "GetLifetime";
            var con = new FbConnection(cnString);            
            string lifetimeText = string.Empty;
            try
            {     
                con.Open();
                if(withMon)
                { 
                    string cmd = "select mon$next_transaction livetime from mon$database;";
                    var fcmd = new FbCommand(cmd, con);
                    fcmd.CommandTimeout = 10;
                    var dread = fcmd.ExecuteReader();
                    if (dread.HasRows)
                    {
                        while (dread.Read())
                        {
                            lifetimeText = dread.GetValue(0).ToString().Trim();
                        }
                    }
                }
                else
                {
                    lifetimeText = "old version < V3";
                }

            }
            catch (Exception ex)
            {
                lifetimeText = "-1";
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{ex.Message}->{_funcStr}", ex),_funcStr);
            }
            finally
            { 
              con.Close();
            }
            return lifetimeText;
        }
        
        public static string GetFormattedInfo(string info, string message)
        {            
            if(string.IsNullOrEmpty(message)) return $@"{info}";
            return $@"{info}{Environment.NewLine}    ->msg:{message}";
        }

        static string ReplaceButNotBefore(string sql, string cmd, string[] notcmd)
        {
            int n = 0;
            int inx = sql.ToUpper().IndexOf($@" {cmd} ",n, StringComparison.Ordinal);

            while (inx >= 0)
            {
                bool donot = false;
                for (int i = 0; i < notcmd.Length; i++)
                {
                    string nstr = notcmd[i];
                    int inxnot = sql.ToUpper().IndexOf(nstr,inx-nstr.Length-1, StringComparison.Ordinal);
                    if ((inxnot + nstr.Length) == inx)
                    {
                        donot = true;
                        break;
                    }
                }

                if ((inx >= 0) && (!donot))
                {
                    sql = sql.Insert(inx + 1, Environment.NewLine);
                }
                
                inx = sql.ToUpper().IndexOf($@" {cmd} ",inx+1, StringComparison.Ordinal);
            }
            return sql;
        }

        static string ReplaceButNotAfter(string sql, string cmd, string[] notcmd)
        {
            int n = 0;
            int inx = sql.ToUpper().IndexOf($@" {cmd} ",n, StringComparison.Ordinal);

            while (inx >= 0)
            {
                bool donot = false;
                for (int i = 0; i < notcmd.Length; i++)
                {
                    string nstr = notcmd[i];
                    int inxnot = sql.ToUpper().IndexOf(nstr,inx, StringComparison.Ordinal);
                    if (inxnot == inx+cmd.Length+2)
                    {
                        donot = true;
                        break;
                    }
                }

                if ((inx >= 0) && (!donot))
                {
                    sql = sql.Insert(inx + 1, Environment.NewLine);
                }
                inx = sql.ToUpper().IndexOf($@" {cmd} ",inx+1, StringComparison.Ordinal);
            }
            return sql;
        }

        static string Replace(string sql, string cmd)
        {
            int inx = sql.ToUpper().IndexOf($@" {cmd} ", StringComparison.Ordinal);
            
            while (inx >= 0)
            {
                sql = sql.Insert(inx + 1, Environment.NewLine);
                inx = sql.ToUpper().IndexOf($@" {cmd} ", StringComparison.Ordinal);
            }
            return sql;
        }
        static string ReplaceL(string sql, string cmd)
        {
            int inx = sql.ToUpper().IndexOf($@"{cmd} ", StringComparison.Ordinal);
            
            if (inx >= 0)
            {
                sql = sql.Insert(inx, Environment.NewLine);
            }
            return sql;
        }

        static string Spaces(int depth)
        {
            var sb = new StringBuilder();
            for(int i = 0; i < depth; i++)
            {
                sb.Append("    ");
            }
            return sb.ToString();
        }

        static string MakeSpaced(string sql)
        {
            char[] sts = new char[2];

            sts[0] = Environment.NewLine[0];
            sts[1] = Environment.NewLine[1];

            string[] strList = sql.Split(sts);
            var sb = new StringBuilder();
            int depth = 0;
            foreach(string st in strList)
            {
                if (st.Length <= 0) continue;
                if (st.StartsWith(")")) depth--;
                sb.AppendLine(Spaces(depth) + st);
                if (st.StartsWith("(")) depth++;
            }
            return sb.ToString();
        }

        public static string CreateComment()
        {
            var sbcomment = new StringBuilder();
            sbcomment.AppendLine($@"/* ############################### */");
            sbcomment.AppendLine($@"/* # Create: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} # */");
            sbcomment.AppendLine($@"/* ############################### */");
            sbcomment.AppendLine("");
            return sbcomment.ToString();
        }

        public static string MakeSqlPretty(string sqlCmd)
        {
            string sql = sqlCmd;
            
            while(sql.IndexOf("  ", StringComparison.Ordinal) >= 0)
            {
                sql = sql.Replace("  ", " ");
            }

            while(sql.IndexOf(" , ", StringComparison.Ordinal) >= 0)
            {
                sql = sql.Replace(" , ", ", ");
            }
           
            string[] dnot = { "LEFT", "RIGHT","CROSS","NATURAL","FULL","OUTER" };
            string[] dnotfrom = { "CAST"};

            sql = Replace(sql, "GROUP BY");
            sql = Replace(sql, "ORDER BY");
            sql = Replace(sql, "SELECT AS");
            sql = Replace(sql, "LEFT JOIN");
            sql = Replace(sql, "LEFT OUTER JOIN");
            sql = Replace(sql, "RIGHT JOIN");
            sql = Replace(sql, "RIGHT OUTER JOIN");
            sql = Replace(sql, "FULL JOIN");
            sql = ReplaceButNotBefore(sql, "OUTER JOIN", dnot);
            sql = ReplaceButNotBefore(sql, "JOIN", dnot);
            sql = ReplaceButNotAfter(sql, "FROM", dnotfrom);
                                               
            //string cmd = string.Empty;
            int istart = 0;
            int level = 0;
            var strList = new List<string>();
           
            for(int i = 0; i < sql.Length; i++)
            {
                if(sql[i] == '(')
                {
                    if(level == 0)
                    {
                        string cmd1 = sql.Substring(istart, i - istart);
                        cmd1 = Replace(cmd1, "CASE");
                        cmd1 = Replace(cmd1, "IIF");
                        strList.Add(cmd1);
                        istart = i;
                    }
                    level ++;
                }
                else if(sql[i] == ')')
                {
                   level--;
                   if(level == 0)
                   {
                        string cmd2 = sql.Substring(istart,i-istart+1);
                        cmd2 = ReplaceL(cmd2, "(SELECT");
                        cmd2 = ReplaceL(cmd2, " IIF");
                        strList.Add(cmd2);
                        istart = i+1;
                   }
                }
            }
            string cmd = sql.Substring(istart);
            cmd = Replace(cmd, "FROM");
            strList.Add(cmd);
            return sql;
        }
    }
}

