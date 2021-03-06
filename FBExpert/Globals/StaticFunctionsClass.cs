﻿using BasicClassLibrary;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.IO;
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

        public static string GetFormattedError(string info, Exception ex)
        {
            return GetFormattedError(info, ex.Message);
        }

        public static string GetFormattedError(string info, string message)
        {
            /*
            if(string.IsNullOrEmpty(message)) return $@"{StaticFunctionsClass.DateTimeNowStr()}  {info}";
            return $@"{StaticFunctionsClass.DateTimeNowStr()}  {info}{Environment.NewLine}    ->msg:{message}";
            */
             if(string.IsNullOrEmpty(message)) return $@"{info}";
            return $@"{info}{Environment.NewLine}    ->msg:{message}";
        }
        
        public static string GetFormattedInfo(string info, string message)
        {
            /*
            if(string.IsNullOrEmpty(message)) return $@"{StaticFunctionsClass.DateTimeNowStr()}  {info}";
            return $@"{StaticFunctionsClass.DateTimeNowStr()}  {info}{Environment.NewLine}    ->msg:{message}";
            */
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
                int inxnot = -1;
                for (int i = 0; i < notcmd.Length; i++)
                {
                    string nstr = notcmd[i];
                    inxnot = sql.ToUpper().IndexOf(nstr,inx-nstr.Length-1, StringComparison.Ordinal);
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
                int inxnot = -1;
                for (int i = 0; i < notcmd.Length; i++)
                {
                    string nstr = notcmd[i];
                    inxnot = sql.ToUpper().IndexOf(nstr,inx, StringComparison.Ordinal);
                    if ((inxnot ) == inx+cmd.Length+2)
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
            int inx = sql.ToUpper().IndexOf(cmd + " ", StringComparison.Ordinal);
            
            if (inx >= 0)
            {
                sql = sql.Insert(inx, Environment.NewLine);
                inx = sql.ToUpper().IndexOf(cmd + " ", StringComparison.Ordinal)-3;
            }
            return sql;
        }

        static string Spaces(int depth)
        {
            StringBuilder sb = new StringBuilder();
                
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
            StringBuilder sb = new StringBuilder();
            int depth = 0;
            foreach(string st in strList)
            {
                if (st.Length > 0)
                {
                    
                    if (st.StartsWith(")")) depth--;
                    sb.AppendLine(Spaces(depth) + st);
                    if (st.StartsWith("(")) depth++;
                }
            }
            return sb.ToString();
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
                                               
            string cmd = string.Empty;
            int istart = 0;
            int iend = 0;
            int level = 0;
            List<string> strList = new List<string>();
           
            for(int i = 0; i < sql.Length; i++)
            {
                if(sql[i] == '(')
                {
                    if(level == 0)
                    {
                        cmd = sql.Substring(istart,i-istart);
                        
                        cmd = Replace(cmd, "CASE");
                        cmd = Replace(cmd, "IIF");
                        strList.Add(cmd);
                        istart = i;                        
                    }
                    level ++;
                }
                else if(sql[i] == ')')
                {                  
                   level--;
                   if(level == 0)
                   {
                        iend = i;
                        cmd = sql.Substring(istart,i-istart+1);
                        cmd = ReplaceL(cmd, "(SELECT");
                        cmd = ReplaceL(cmd, " IIF");
                        strList.Add(cmd);
                        istart = i+1;
                   }
                }                
            }
            cmd = sql.Substring(istart);
            cmd = Replace(cmd, "FROM");
            strList.Add(cmd);
           
            // sql = MakeSpaced(sql);
            /*
            StringBuilder sb = new StringBuilder();
            foreach(string sl in strList)
            {
                string s = sl;
                int n = 80;
                int nl = 2;
                while(s.Length > 80 && (s.IndexOf(",")>=0))
                {
                    if(s.Length <= n) break;
                    if(s.Length <= nl) break;
                    nl = s.IndexOf($@"{Environment.NewLine}",nl);
                    n = s.IndexOf(",",n);
                    if(nl > n)
                    {
                        n++;
                        s = s.Insert(n,Environment.NewLine);
                        nl = n+1;
                        n+=80;                       
                    }
                    else
                    {
                        break;
                    }
                }                
                sb.Append(s);
            }
            
            sql = sb.ToString();
            */
            return sql;
           
        }
    }
}

