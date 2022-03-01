using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace FBXpertLib
{



    public class StaticDatabaseObjects : object
    {
        enum eTableTypes { SystemTables, UserdefinedTables, AllTables };
        public  string TypeName = "StaticTreeClass";
        public  Color Active   = Color.Blue;        
        public  Color Inactive = Color.Red;
        public  Color ActiveHasConstraint = Color.DarkCyan;
        public  Color InactiveHasConstraint = Color.OrangeRed;

        
        private static StaticDatabaseObjects _instance;       
        private static readonly object _lock_this = new object();
        public static StaticDatabaseObjects Instance()
        {
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {
               _instance = new StaticDatabaseObjects();                        
            }
            return (_instance);
        }
       

        private IndexClass GetIndexObject(FbDataReader dread)
        {
             var tfc = DataClassFactory.GetDataClass(StaticVariablesClass.IndicesKeyStr) as IndexClass;
            
             tfc.RelationName    = dread.GetValue(0).ToString().Trim();
             tfc.Name            = dread.GetValue(1).ToString().Trim();            
             string fld          = dread.GetValue(2).ToString().Trim();    
             string constraintName = dread.GetValue(6).ToString().Trim();    
             int un              = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);
             int inactive        = StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 1);
             int index_type      = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), -1);
             if(index_type == 0) tfc.SortDirection = eSort.ASC;
             else if(index_type == 1) tfc.SortDirection = eSort.DESC;
             else tfc.SortDirection = eSort.NONE;
             tfc.Unique          = un == 1;
             tfc.IsActive        = inactive == 0;
             tfc.ConstraintName = constraintName;
             tfc.HasPrimaryConstraint = constraintName.ToUpper().Contains("PRIMARY KEY");
             if(fld != null)  tfc.RelationFields.Add(fld,new FieldClass(fld));
             return tfc;
        }


        public Dictionary<string,IndexClass> GetIndecesObjects(DBRegistrationClass DBReg)
        {
            var indeces = new Dictionary<string,IndexClass>();
            string _funcStr = $@"GetIndecesObjects(DBReg={DBReg})";
            string cmd = IndexSQLStatementsClass.Instance.GetAllIndicies(DBReg.Version,eTableType.withoutsystem); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllIndeces->{DBReg}", ex));                 
                return indeces;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        
                        string oldKey = string.Empty;
                        string newKey = string.Empty;
                        IndexClass tc = null;

                        while (dread.Read())
                        {        
                            
                            newKey = dread.GetValue(1).ToString().Trim();                           
                            string FieldName = dread.GetValue(2).ToString().Trim();                           
                           
                            if(oldKey != newKey)
                            { 
                                //Neuer Index oder erster Index (first loop)
                                if(tc != null)
                                {
                                    indeces.Add(tc.Name,tc);
                                }
                                
                                tc = GetIndexObject(dread);
                                
                                oldKey = newKey;
                            }
                            else
                            {
                                tc.RelationFields.Add(FieldName, new FieldClass(FieldName));
                            }
                                                                                                                                           
                            n++;
                        }
                        
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetIndecesObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        if ((oldKey == newKey)&&(!string.IsNullOrEmpty(oldKey)))
                        {                                 
                            if(tc != null)
                            {
                                indeces.Add(tc.Name,tc);
                            }                            
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetIndecesObjects->dread==null"));
                }                
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetIndecesObjects->Connection not open"));
            }
            return indeces;
        }

        public Dictionary<string, IndexClass> GetSystemIndecesObjects(DBRegistrationClass DBReg)
        {
            var indeces = new Dictionary<string, IndexClass>();
            string _funcStr = $@"GetIndecesObjects(DBReg={DBReg})";
            string cmd = IndexSQLStatementsClass.Instance.GetAllIndicies(DBReg.Version, eTableType.system); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllIndeces->{DBReg}", ex));
                return indeces;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        string oldKey = string.Empty;
                        string newKey = string.Empty;
                        IndexClass tc = null;

                        while (dread.Read())
                        {

                            newKey = dread.GetValue(1).ToString().Trim();
                            string FieldName = dread.GetValue(2).ToString().Trim();

                            if (oldKey != newKey)
                            {
                                //Neuer Index oder erster Index (first loop)
                                if (tc != null)
                                {
                                    indeces.Add(tc.Name, tc);
                                }

                                tc = GetIndexObject(dread);

                                oldKey = newKey;
                            }
                            else
                            {
                                tc.RelationFields.Add(FieldName, new FieldClass(FieldName));
                            }

                            n++;
                        }

                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetIndecesObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        if ((oldKey == newKey) && (!string.IsNullOrEmpty(oldKey)))
                        {
                            if (tc != null)
                            {
                                indeces.Add(tc.Name, tc);
                            }
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetSystemIndecesObjects->dread==null"));
                }
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetSystemIndecesObjects->Connection not open"));
            }
            return indeces;
        }

        public Dictionary<string,IndexClass> GetIndecesObjectsWithoutRefConstraints(DBRegistrationClass DBReg)
        {
            var indeces = new Dictionary<string,IndexClass>();

            string cmd = IndexSQLStatementsClass.Instance.GetAllIndiciesWithoutRefConstraints(DBReg.Version,eTableType.withoutsystem); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllIndeces->{DBReg}", ex));                 
                return indeces;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        string oldKey = string.Empty;
                        string newKey = string.Empty;                                                                 
                        IndexClass tc = null;

                        while (dread.Read())
                        {        
                            
                            newKey = dread.GetValue(1).ToString().Trim();                           
                            string FieldName = dread.GetValue(2).ToString().Trim();                           
                           
                            if(oldKey != newKey)
                            { 
                                //Neuer Index oder erster Index (first loop)
                                if(tc != null)
                                {
                                    indeces.Add(tc.Name,tc);
                                }
                                
                                tc = GetIndexObject(dread);
                                
                                oldKey = newKey;
                            }
                            else
                            {
                                tc.RelationFields.Add(FieldName, new FieldClass(FieldName));
                            }
                                                                                                                                           
                            n++;
                        }
                        
                        if((oldKey == newKey)&&(!string.IsNullOrEmpty(oldKey)))
                        {                                 
                            if(tc != null)
                            {
                                indeces.Add(tc.Name,tc);
                            }                            
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndeces->dread==null"));
                }                
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndeces->Connection not open"));
            }
            return indeces;
        }

        
        //Holt alle Indecies der Datenbank und fügt diese in einen Tree-Konten an        
        public Dictionary<string,IndexClass> AddIndexObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {
            string _funcStr = $@"AddIndexObjects_To_ListOfTableObjects(DBReg={DBReg})";
            string fields_cmd = IndexSQLStatementsClass.Instance.GetAllIndicies(DBReg.Version,eTableType.withoutsystem);                        
            TableClass tableObject = null;
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                string newTableKey = string.Empty;
                string oldTableKey = string.Empty;
                int n = 0;
              
                
                if (dread.HasRows)
                {
                    string oldIndexKey = string.Empty;
                    string newIndexKey = string.Empty; 
                    string oldFieldKey = string.Empty; 
                    string newFieldKey = string.Empty; 
                    IndexClass tfc = null;
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    
                    while (dread.Read())
                    {
                        n++;
                        newTableKey = dread.GetValue(0).ToString().Trim();
                        newIndexKey = dread.GetValue(1).ToString().Trim();   
                        newFieldKey = dread.GetValue(2).ToString().Trim();  

                        if (oldTableKey != newTableKey)
                        {
                            tableObject = tc.FirstOrDefault(X => X.Value.Name == newTableKey).Value as TableClass;
                            if (tableObject == null)
                            {
                                //Tabelle nicht in Liste
                                continue;
                            }
                            if (tableObject.Indices == null)
                            {
                                tableObject.Indices = new Dictionary<string, IndexClass>();
                            }
                            oldTableKey = newTableKey;
                            oldIndexKey = string.Empty;
                            oldFieldKey = string.Empty;                            
                        }

                        if(oldIndexKey != newIndexKey)
                        { 
                           tfc = GetIndexObject(dread);

                           oldIndexKey = newIndexKey;
                           oldFieldKey = newFieldKey;
                        }

                        if(oldFieldKey != newFieldKey)
                        {
                            string FieldName = dread.GetValue(2).ToString().Trim();   
                            tfc.RelationFields.Add(FieldName, new FieldClass(FieldName));
                        }

                        try
                        {
                          
                           if(!tableObject.Indices.ContainsKey(tfc.Name))
                           {
                              tableObject.Indices.Add(tfc.Name,tfc);
                           }
                        }
                        catch (Exception ex)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.withoutsystem}) -> Indices.Add", ex));                                                                                         
                        }
                    }
                    Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                    NotifiesClass.Instance.AddToINFO($@"AddIndexObjects_To_ListOfTableObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                    sw.Stop();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.withoutsystem})", ex));                                                                                         
            }
            finally
            {
                con.Close();
            }
            return tableObject?.Indices;
        }

        public Dictionary<string, IndexClass> AddSystemIndexObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string, SystemTableClass> tc)
        {
            string _funcStr = $@"AddIndexObjects_To_ListOfTableObjects(DBReg={DBReg})";
            string fields_cmd = IndexSQLStatementsClass.Instance.GetAllIndicies(DBReg.Version, eTableType.system);
            TableClass tableObject = null;
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                string newTableKey = string.Empty;
                string oldTableKey = string.Empty;
                int n = 0;


                if (dread.HasRows)
                {
                    string oldIndexKey = string.Empty;
                    string newIndexKey = string.Empty;
                    string oldFieldKey = string.Empty;
                    string newFieldKey = string.Empty;
                    IndexClass tfc = null;
                    Stopwatch sw = new Stopwatch();
                    sw.Start();

                    while (dread.Read())
                    {
                        n++;
                        newTableKey = dread.GetValue(0).ToString().Trim();
                        newIndexKey = dread.GetValue(1).ToString().Trim();
                        newFieldKey = dread.GetValue(2).ToString().Trim();

                        if (oldTableKey != newTableKey)
                        {
                            tableObject = tc.FirstOrDefault(X => X.Value.Name == newTableKey).Value as TableClass;
                            if (tableObject == null)
                            {
                                //Tabelle nicht in Liste
                                continue;
                            }
                            if (tableObject.Indices == null)
                            {
                                tableObject.Indices = new Dictionary<string, IndexClass>();
                            }
                            oldTableKey = newTableKey;
                            oldIndexKey = string.Empty;
                            oldFieldKey = string.Empty;
                        }

                        if (oldIndexKey != newIndexKey)
                        {
                            tfc = GetIndexObject(dread);

                            oldIndexKey = newIndexKey;
                            oldFieldKey = newFieldKey;
                        }

                        if (oldFieldKey != newFieldKey)
                        {
                            string FieldName = dread.GetValue(2).ToString().Trim();
                            tfc.RelationFields.Add(FieldName, new FieldClass(FieldName));
                        }

                        try
                        {

                            if (!tableObject.Indices.ContainsKey(tfc.Name))
                            {
                                tableObject.Indices.Add(tfc.Name, tfc);
                            }
                        }
                        catch (Exception ex)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.withoutsystem}) -> Indices.Add", ex));
                        }
                    }
                    Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                    NotifiesClass.Instance.AddToINFO($@"AddIndexObjects_To_ListOfTableObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                    sw.Stop();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.withoutsystem})", ex));
            }
            finally
            {
                con.Close();
            }
            return tableObject?.Indices;
        }

        public void AddIndexObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc)
        {
            string fields_cmd = string.Empty;
            string _funcStr = $@"AddIndexObjects_To_ListOfSystemTableObjects(DBReg={DBReg})";
            fields_cmd = IndexSQLStatementsClass.Instance.GetAllIndicies(DBReg.Version, eTableType.system);
                    
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                string TableName = string.Empty;
                string oldTableName = string.Empty;
                int n = 0;
                SystemTableClass tableObject = null;
                if (dread.HasRows)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    
                    while (dread.Read())
                    {
                        n++;
                        TableName = dread.GetValue(0).ToString().Trim();
                        
                        if (oldTableName != TableName)
                        {
                           
                            tableObject = tc.FirstOrDefault(X => X.Value.Name == TableName).Value as SystemTableClass;
                            if (tableObject == null)
                            {
                                //Tabelle nicht in Liste
                                continue;
                            }
                            if (tableObject.Indices == null)
                            {
                                tableObject.Indices = new Dictionary<string, IndexClass>();
                            }
                            oldTableName = TableName;
                        }

                                           
                        var tfc = DataClassFactory.GetDataClass(StaticVariablesClass.IndicesKeyStr) as IndexClass;
                        tfc.Name = dread.GetValue(1).ToString().Trim();
                        tfc.RelationName = dread.GetValue(0).ToString().Trim();
                        string fld = dread.GetValue(2).ToString().Trim();
                        if(fld != null)  tfc.RelationFields.Add(fld,new FieldClass(fld));
                        int un = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);
                        int inactive = StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 1);
                        tfc.Unique = un == 1;
                        tfc.IsActive = inactive == 0;

                        try
                        {                           
                           if(!tableObject.Indices.ContainsKey(tfc.Name))
                           {
                              tableObject.Indices.Add(tfc.Name,tfc);
                           }
                        }
                        catch (Exception ex)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.system}) -> Indices.Add", ex));                                                                                         
                        }
                    }
                    Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                    NotifiesClass.Instance.AddToINFO($@"AddIndexObjects_To_ListOfSystemTableObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                    sw.Stop();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.system})", ex));                                                                                         
            }
            finally
            {
                con.Close();
            }
        }

        //public bool CancelReading = false;

        #region Make SQL for Objects

        public string GetInfoHeader(int len)
        {
            string istr = "*******************************************************************************************************************************************************************************************************************";
            return $@"/{istr.Substring(0,len-2)}/";
        }
        public List<string> GetAllTablesAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,TableClass> alltables, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {
            var SQLSep = new List<string>();
            var SQLAll = new List<string>();
                   
            string infoStr =  $@"/* ********* Tables structures for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                
            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));

            if((alltables==null)||(alltables.Count <= 0)) return SQLAll;
                      
            foreach (var dataObject in alltables.Values)
            {
                if (dataObject.GetType() != typeof(TableClass)) continue;
                
                var tableObject = dataObject as TableClass;
                SQLSep.Clear();
                if (tableObject.State == CheckState.Checked)
                {
                    infoStr = $@"/* ********* Table {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                    SQLSep.Add(Environment.NewLine);                
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(infoStr);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));            
                    SQLSep.Add(Environment.NewLine);

                    
                    string sql = CreateDLLClass.CreateTabelDLL(tableObject, cmode);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql + ";"));
                    }
                                                            
                    if (commit)
                    {
                        SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                        
                    }
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile($@"{directoryName}\{dataObject.Name}.sql",SQLSep,enc);
                    }
                }                
            }
            SQLAll.Add(Environment.NewLine);
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile($@"{directoryName}\{fileName}",SQLAll,enc);
            }
            return SQLAll;
        }

        public List<string> GetAllPKTablesAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,PrimaryKeyClass> primarykeys, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {            
            var SQLSep = new List<string>();
            var SQLAll = new List<string>();
            
            string infoStr = $@"/* ********* Primary keys structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(Environment.NewLine);
            if((primarykeys == null)||(primarykeys.Count <= 0)) return SQLSep;

            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                foreach (var dataObject in primarykeys.Values)
                {
                    if (dataObject.GetType() != typeof(PrimaryKeyClass)) continue;
                    SQLSep.Clear();
                    var constraintObject = dataObject as PrimaryKeyClass;
                    
                    infoStr = $@"/* ********* Primary key {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                    SQLSep.Add(Environment.NewLine);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(infoStr);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(Environment.NewLine);

                    string sql = CreateDLLClass.CreateAlterTabelPrimaryKeyConstraintDLL(constraintObject, eCreateMode.drop);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }
                    

                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (commit)
                    {
                        SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                        
                    }
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                    }
                }
                SQLSep.Add(Environment.NewLine);
            }

            if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
            {
                foreach (var dataObject in primarykeys.Values)
                {
                    if (dataObject.GetType() != typeof(PrimaryKeyClass)) continue;   
                    SQLSep.Clear();
                    var constraintObject = dataObject;
                    
                    infoStr = $@"/* ********* Primary key {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                    SQLSep.Add(Environment.NewLine);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(infoStr);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(Environment.NewLine);

                    string sql = CreateDLLClass.CreateAlterTabelPrimaryKeyConstraintDLL(constraintObject, eCreateMode.create);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (commit)
                    {
                        SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                    }  
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile($@"{directoryName}\{dataObject.Name}.sql",SQLSep,enc);
                    }
                }
                SQLAll.Add(Environment.NewLine);
            }

            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile($@"{directoryName}\{fileName}",SQLAll,enc);
            }
            return SQLAll;
        }

        public List<string> GetAllFKTablesAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,ForeignKeyClass> allForeignKeys, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {            
            var SQLSep = new List<string>();
            var SQLAll = new List<string>();
            
            string infoStr = $@"/* ********* Foreign keys structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);
            if((allForeignKeys == null)||(allForeignKeys.Count<=0)) return SQLSep;

            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                foreach (var dataObject in allForeignKeys.Values)
                {
                    if (dataObject.GetType() != typeof(ForeignKeyClass)) continue;
                    SQLSep.Clear();
                    var constraintObject = dataObject as ForeignKeyClass;                    
                    {
                        infoStr = $@"/* ********* Foreign key {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                        SQLSep.Add(Environment.NewLine);                
                        SQLSep.Add(GetInfoHeader(infoStr.Length));
                        SQLSep.Add(infoStr);
                        SQLSep.Add(GetInfoHeader(infoStr.Length));            
                        SQLSep.Add(Environment.NewLine);


                        string sql = CreateDLLClass.CreateAlterTabelForeignKeyConstraintDLL(constraintObject, eCreateMode.drop);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }


                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }

                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }

                        if (commit) 
                        {
                            SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");         
                        }

                        SQLAll.AddRange(SQLSep);
                        if(fileWrite == eSQLFileWriteMode.seperated)
                        {
                            WriteFile($@"{directoryName}\{dataObject.Name}.sql",SQLSep,enc);
                        }
                    }                       
                }
                SQLSep.Add(Environment.NewLine);
            }

            if ((cmode != eCreateMode.create) && (cmode != eCreateMode.recreate))  return SQLSep;
            
            foreach (var dataObject in allForeignKeys.Values)
            {
                if (dataObject.GetType() != typeof(ForeignKeyClass)) continue;
                SQLSep.Clear();
                var constraintObject = dataObject as ForeignKeyClass;                      
                {
                    SQLSep.Add(Environment.NewLine);
                    //sqllist.Add(Environment.NewLine);
                    //sqllist.Add("/* ********* " + constraintObject.Name + " ********** */");
                    //sqllist.Add(Environment.NewLine);

                    string sql = CreateDLLClass.CreateAlterTabelForeignKeyConstraintDLL(constraintObject, eCreateMode.create);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (commit)
                    {
                        SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}"); 
                    }
                    
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile($@"{directoryName}\{dataObject.Name}.sql",SQLSep,enc);
                    }
                }                   
            }
            SQLAll.Add(Environment.NewLine);   
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile($@"{directoryName}\{fileName}",SQLAll,enc);
            }
            return SQLAll;
        }

        public List<string> GetAllDomainAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,DomainClass> alldomains, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {
            var SQLSep = new List<string>();
            var SQLAll = new List<string>();
           
            string infoStr = $@"/* ********* Domains structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);
            if((alldomains==null)||(alldomains.Count <= 0)) return SQLAll;

            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                foreach (DomainClass dataObject in alldomains.Values)
                {
                    SQLSep.Clear();
                    if (dataObject.GetType() == typeof(DomainClass))
                    {
                        var constraintObject = dataObject as DomainClass;
                        infoStr = $@"/* ********* Domain {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                        SQLSep.Add(Environment.NewLine);                
                        SQLSep.Add(GetInfoHeader(infoStr.Length));
                        SQLSep.Add(infoStr);
                        SQLSep.Add(GetInfoHeader(infoStr.Length));            
                        SQLSep.Add(Environment.NewLine);


                        string sql = CreateDLLClass.CreateAlterDomainDLL(constraintObject, eCreateMode.drop);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }


                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }

                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }

                        if (commit)
                        {
                            SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                        }
                    }   
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile($@"{directoryName}\{dataObject.Name}.sql",SQLSep,enc);
                    }
                }
                SQLAll.Add(Environment.NewLine);
            }
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile($@"{directoryName}\{fileName}",SQLAll,enc);
            }
            return SQLAll;
        }

        public List<string> GetAllGeneratorAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,GeneratorClass> allgenerators, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {
            var SQLSep = new List<string>();
            var SQLAll = new List<string>();
           
            string infoStr = $@"/* ********* Generators structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);

            if((allgenerators==null)||(allgenerators.Count <= 0)) return SQLSep;

            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                foreach (GeneratorClass dataObject in allgenerators.Values)
                {
                    if (dataObject.GetType() != typeof(GeneratorClass)) continue;
                    SQLSep.Clear();
                    var constraintObject = dataObject as GeneratorClass;
                    
                    infoStr = $@"/* ********* Generator {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                    SQLSep.Add(Environment.NewLine);                
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(infoStr);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));            
                    SQLSep.Add(Environment.NewLine);

                    string sql = CreateDLLClass.CreateAlterGeneratorDLL(constraintObject, eCreateMode.drop);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (commit)
                    {
                        SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                    
                    }   
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                    }
                    SQLAll.AddRange(SQLSep); 
                }
                SQLAll.Add(Environment.NewLine);
            }

            if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
            {
                foreach (GeneratorClass dataObject in allgenerators.Values)
                {
                    if (dataObject.GetType() != typeof(GeneratorClass)) continue;
                    SQLSep.Clear();
                    var constraintObject = dataObject as GeneratorClass;
                    
                    infoStr = $@"/* ********* Generator {dataObject.Name} structure for {DBReg.Alias} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                    SQLSep.Add(Environment.NewLine);                
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(infoStr);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));            
                    SQLSep.Add(Environment.NewLine);

                    string sql = CreateDLLClass.CreateAlterGeneratorDLL(constraintObject, eCreateMode.create);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (commit)
                    {
                        SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                    
                    }                        
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                    }
                    SQLAll.AddRange(SQLSep); 
                }
                SQLAll.Add(Environment.NewLine);
            }
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
            }
            return SQLAll;
        }

        public List<string> GetAllIndecesAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,IndexClass> allindeces, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {
            var SQLSep = new List<string>();            
            var SQLAll = new List<string>();            
            string infoStr = $@"/* ********* Indecies structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);
            if((allindeces==null)||(allindeces.Count <= 0)) return SQLAll;

            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                foreach (IndexClass dataObject in allindeces.Values)
                {
                    SQLSep.Clear();
                    if (dataObject.GetType() == typeof(DomainClass))
                    {
                        IndexClass indexObject = dataObject as IndexClass;
                        
                        infoStr = $@"/* ********* Index {dataObject.Name} structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                        SQLSep.Add(Environment.NewLine);                
                        SQLSep.Add(GetInfoHeader(infoStr.Length));
                        SQLSep.Add(infoStr);
                        SQLSep.Add(GetInfoHeader(infoStr.Length));            
                        SQLSep.Add(Environment.NewLine);

                        string sql = CreateDLLClass.CreateAlterIndecesDLL(indexObject, eCreateMode.drop);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }


                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }

                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }

                        if (commit)
                        {
                            SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                    
                        }      
                        if(fileWrite == eSQLFileWriteMode.seperated)
                        {
                            WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                        }
                        SQLAll.AddRange(SQLSep); 
                    }
                }
                SQLAll.Add(Environment.NewLine);
            }

            if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
            {
                foreach (IndexClass dataObject in allindeces.Values)
                {
                    SQLSep.Clear();
                    if (dataObject.GetType() == typeof(IndexClass))
                    {
                        IndexClass indexObject = dataObject as IndexClass;
                        
                        infoStr = $@"/* ********* Index {dataObject.Name} structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                        SQLSep.Add(Environment.NewLine);                
                        SQLSep.Add(GetInfoHeader(infoStr.Length));
                        SQLSep.Add(infoStr);
                        SQLSep.Add(GetInfoHeader(infoStr.Length));            
                        SQLSep.Add(Environment.NewLine);

                        string sql = CreateDLLClass.CreateAlterIndecesDLL(indexObject, eCreateMode.create);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                        }

                        if (commit)
                        {
                            SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                    
                        }                        
                    }
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                    }
                    SQLAll.AddRange(SQLSep); 
                }
                SQLAll.Add(Environment.NewLine);
            }
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
            }
            return SQLAll;
        }

        public List<string> GetAllTriggersAlterInsertSQL(DBRegistrationClass DBReg, Dictionary<string,TriggerClass> alltriggers, eCreateMode cmode, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {
            //Systemflag = 0 für TableTriggers
            //Systemflag = 4 für Systemtable Triggers
            
            var SQLSep = new List<string>();
            var SQLAll = new List<string>();
            
            string infoStr = $@"/* ********* Triggers structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);
            if((alltriggers == null)||(alltriggers.Count <= 0)) return SQLSep;
            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                foreach (TriggerClass dataObject in alltriggers.Values)
                {
                    if (dataObject.GetType() != typeof(TriggerClass)) continue;
                    
                    var constraintObject = dataObject as TriggerClass;
                    SQLSep.Clear();
                    infoStr = $@"/* ********* Trigger {dataObject.Name} structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                    SQLSep.Add(Environment.NewLine);                
                    SQLSep.Add(GetInfoHeader(infoStr.Length));
                    SQLSep.Add(infoStr);
                    SQLSep.Add(GetInfoHeader(infoStr.Length));            
                    SQLSep.Add(Environment.NewLine);
                   
                    string sql = CreateDLLClass.CreateAlterTriggerDLL(constraintObject, eCreateMode.drop);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                    }

                    if (commit) SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");  
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.all)
                    {
                        WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
                    }
                }
                SQLAll.Add(Environment.NewLine);
            }

            if ((cmode != eCreateMode.create) && (cmode != eCreateMode.recreate)) return SQLSep;
            
            foreach (TriggerClass dataObject in alltriggers.Values)
            {
                if (dataObject.GetType() != typeof(TriggerClass)) continue;
                
                TriggerClass indexObject = dataObject as TriggerClass;
                SQLSep.Clear();
                infoStr = $@"/* ********* Trigger {dataObject.Name} structure for {DBReg.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                SQLSep.Add(Environment.NewLine);                
                SQLSep.Add(GetInfoHeader(infoStr.Length));
                SQLSep.Add(infoStr);
                SQLSep.Add(GetInfoHeader(infoStr.Length));            
                SQLSep.Add(Environment.NewLine);

                string sql = CreateDLLClass.CreateAlterTriggerDLL(indexObject, eCreateMode.create);
                if (sql.EndsWith(Environment.NewLine))
                {
                    sql = sql.Remove(sql.Length - 2);
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance.FormatSQL(sql));
                    else SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{sql};"));
                }

                if (commit) SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                                                                                     
                SQLAll.AddRange(SQLSep);
                
                if(fileWrite == eSQLFileWriteMode.seperated)
                {
                    WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                }
            }
            SQLAll.Add(Environment.NewLine);  
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
            }
            return SQLAll;
        }
        
        public List<string> GetAllViewsAlterInsertSQL(DBRegistrationClass DBRegx, List<ViewClass> alltables, bool commit, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {
            var SQLAll = new List<string>();                    
            var SQLSep = new List<string>();   
                    
            string infoStr = $@"/* ********* Views structures for {DBRegx.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);
            
            if((alltables == null)||(alltables.Count <= 0)) return SQLAll;
            
            foreach (ViewClass dataObject in alltables)
            {
                if (dataObject.GetType() != typeof(ViewClass)) continue;                   
                SQLSep.Clear();   
                
                var vc = dataObject as ViewClass;              
                if (vc.State != CheckState.Checked) continue;
                
                infoStr = $@"/* ********* View {vc.Name} structure for {DBRegx.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
                SQLSep.Add(Environment.NewLine);                
                SQLSep.Add(GetInfoHeader(infoStr.Length));
                SQLSep.Add(infoStr);
                SQLSep.Add(GetInfoHeader(infoStr.Length));            
                SQLSep.Add(Environment.NewLine);
                               
                if (vc.CREATEINSERT_SQL.EndsWith(Environment.NewLine))
                {
                    vc.CREATEINSERT_SQL = vc.CREATEINSERT_SQL.Remove(vc.CREATEINSERT_SQL.Length - 2);
                }
                
                SQLSep.Add(SQLStatementsClass.Instance.FormatSQL($@"{vc.CREATEINSERT_SQL};"));
               

                if(commit) SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");    
                if(fileWrite == eSQLFileWriteMode.seperated)
                {
                    WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                }
                SQLAll.AddRange(SQLSep);                
            }    

            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
            }
            return SQLAll;
        }

        public void WriteFile(string fn, List<string> lines, Encoding enc)
        {
            try
            {
                File.WriteAllLines(fn,lines,enc);            
            }
            catch //(Exception ex)
            {

            }
        }

        public List<string> GetAllFunctionAlterInsertSQL(DBRegistrationClass DBRegx, Dictionary<string,FunctionClass> allfunctions, eCreateMode createMode, bool commit, bool complete, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {     
            /*            
            DECLARE EXTERNAL FUNCTION SUBSTR
                CSTRING(255),
                SMALLINT,
                SMALLINT
                RETURNS CSTRING(255) FREE_IT
                ENTRY_POINT 'IB_UDF_substr' MODULE_NAME 'ib_udf';
            */
            
            var SQLSep = new List<string>();                    
            var SQLAll = new List<string>();  
                    
            string infoStr = complete 
                ? $@"/* ********* Functions structures for {DBRegx.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */" 
                : $@"/* ********* Functionss definitions for {DBRegx.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(Environment.NewLine);

            if (allfunctions.Count <= 0) return SQLAll;                                    
            
            foreach (var dataObject in allfunctions.Values)
            {
                if (dataObject.GetType() != typeof(FunctionClass)) continue;   
                SQLSep.Clear();
                SQLSep.AddRange(MakeSQLAlterFunction(dataObject,dataObject,complete));
                SQLAll.AddRange(SQLSep);
                if(fileWrite == eSQLFileWriteMode.seperated)
                {
                    WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                }
            }
            SQLAll.Add(Environment.NewLine);
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
            }
            return SQLAll;
        }

        public List<string> GetAllProcedureAlterInsertSQL(DBRegistrationClass DBRegx, Dictionary<string,ProcedureClass> allprocedures, eCreateMode createMode, bool commit, bool complete, string directoryName, string fileName,eSQLFileWriteMode fileWrite, Encoding enc)
        {           
            var SQLSep = new List<string>();                                                    
            var SQLAll = new List<string>();            
            string infoStr = complete 
                ? $@"/* ********* Procedures structure for {DBRegx.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */" 
                : $@"/* ********* Procedures definition for {DBRegx.Alias} Date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";
            
            SQLAll.Add(GetInfoHeader(infoStr.Length));
            SQLAll.Add(infoStr);
            SQLAll.Add(GetInfoHeader(infoStr.Length));            
            SQLAll.Add(Environment.NewLine);
            if (allprocedures.Count <= 0) return SQLAll;
            foreach (var dataObject in allprocedures.Values)
            {
                if (dataObject.GetType() != typeof(ProcedureClass)) continue;  
                SQLSep.Clear();
                SQLSep.AddRange(MakeSQLAlterProcedure(dataObject,dataObject,complete));
                SQLAll.AddRange(SQLSep);
                if(fileWrite == eSQLFileWriteMode.seperated)
                {
                    WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                }
            }
            SQLAll.Add(Environment.NewLine);
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
            }
            return SQLAll;
        }


        private List<string> AddSQLProcedureGrants(List<string> SQLScript, StringBuilder sbs,ProcedureClass ProcedureObject)
        {
            //Grants

            string[] words = sbs.ToString().Split(' ');
            var grand_select = new List<string>();
            for(int i = 0; i < words.Length; i++)
            {
                string str = words[i];
                if( (str.ToUpper() == "FROM") || (str.ToUpper() == "JOIN") )
                {                    
                    grand_select.Add(words[i + 1]);
                }
            }

            SQLScript.Add(Environment.NewLine);
            SQLScript.Add("/* GRANT statetements */" + Environment.NewLine);

            foreach (string gstr in grand_select)
            {
                int inx = gstr.IndexOf("(");                 
                string cms1 = (inx < 0) 
                    ? $@"GRANT SELECT ON {gstr.Trim()} TO PROCEDURE {ProcedureObject.Name};{Environment.NewLine}" 
                    : $@"GRANT EXECUTE ON PROCEDURE {gstr.Substring(0, inx)} TO PROCEDURE {ProcedureObject.Name};{Environment.NewLine}";
                SQLScript.Add(cms1);                
            }            
            string cms = $@"GRANT EXECUTE ON PROCEDURE {ProcedureObject.Name} TO SYSDBA;{Environment.NewLine}";
            SQLScript.Add(cms);
            return SQLScript;
        }

        private List<string> AddSQLFunctionGrants(List<string> SQLScript, StringBuilder sbs,FunctionClass FunctionObject)
        {
            //Grants

            string[] words = sbs.ToString().Split(' ');
            List<string> grand_select = new List<string>();
            for(int i = 0; i < words.Length; i++)
            {
                string str = words[i];
                if( (str.ToUpper() == "FROM") || (str.ToUpper() == "JOIN") )
                {
                    
                    grand_select.Add(words[i + 1]);
                }

            }

            SQLScript.Add(Environment.NewLine);
            SQLScript.Add($@"/* GRANT statetements */{Environment.NewLine}");

            foreach (string gstr in grand_select)
            {
                int inx = gstr.IndexOf("(");                 
                string cms1 = (inx < 0) 
                    ? $@"GRANT SELECT ON {gstr.Trim()} TO FUNCTION {FunctionObject.Name};{Environment.NewLine}" 
                    : $@"GRANT EXECUTE ON FUNCTION {gstr.Substring(0, inx)} TO FUNCTION {FunctionObject.Name};{Environment.NewLine}";
                SQLScript.Add(cms1);                
            }            
            string cms = $@"GRANT EXECUTE ON FUNCTION {FunctionObject.Name} TO SYSDBA;{Environment.NewLine}";
            SQLScript.Add(cms);
            return SQLScript;
        }

        public List<string> MakeSQLCreateProcedure(ProcedureClass ProcedureObject, bool complete)
        {            
            var SQLScript = new List<string>();
            var SQL = new StringBuilder();
            string infoStr =  $@"/* ********* Create for procedure {ProcedureObject.Name.Trim()} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                            
            SQL.Append(Environment.NewLine);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.AppendLine(infoStr);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.Append(Environment.NewLine);

            SQL.Append($@"SET TERM ^ ;{Environment.NewLine}{Environment.NewLine}");            
            SQL.Append($@"CREATE PROCEDURE {ProcedureObject.Name.Trim()}{Environment.NewLine}");
            SQL.Append($@"({Environment.NewLine}");

            //In Variables

            for (int i = 0; i < ProcedureObject.ParameterIn.Count; i++)
            {                
                var pc  = ProcedureObject.ParameterIn[i];
                SQL.Append($@"    {pc.Name} ");
                SQL.Append(pc.RawType);
                if((ProcedureObject.ParameterIn.Count > 1)&&(i < ProcedureObject.ParameterIn.Count-1))
                {
                    SQL.Append($@",{Environment.NewLine}");
                }              
            }
            SQL.Append(Environment.NewLine);
            SQL.Append($@"){Environment.NewLine}");

            if (ProcedureObject.ParameterOut.Count > 0)
            {
                SQL.Append($@"RETURNS{Environment.NewLine}({Environment.NewLine}");
                for (int i = 0; i < ProcedureObject.ParameterOut.Count; i++)
                {                    
                    var pc = ProcedureObject.ParameterOut[i];
                    SQL.Append($@"    {pc.Name} ");
                    SQL.Append(pc.RawType);
                    if ((ProcedureObject.ParameterOut.Count > 1) && (i < ProcedureObject.ParameterOut.Count - 1))
                    {
                        SQL.Append($@",{Environment.NewLine}");
                    }
                }
                SQL.Append(Environment.NewLine);
                SQL.Append($@"){Environment.NewLine}");
            }

            SQL.Append($@"AS{Environment.NewLine}");
            if(!complete)
            {
                SQL.Append($@"BEGIN{Environment.NewLine}");
                SQL.Append($@"    SUSPEND;{Environment.NewLine}");
                SQL.Append($@"END{Environment.NewLine}");            
            }
            var sbs = new StringBuilder();
            if(complete)
            {               
                for (int i = 0; i < ProcedureObject.Source.Count; i++)
                {
                    SQL.Append($@"{ProcedureObject.Source[i]}{Environment.NewLine}");
                    if(ProcedureObject.Source[i].Trim().StartsWith("/*")) continue;
                    sbs.Append(ProcedureObject.Source[i] + " ").Replace(Environment.NewLine," ");
                }
            }

            SQL.Append($@"^{Environment.NewLine}");            
            SQL.Append($@"SET TERM ; ^{Environment.NewLine}");   
            SQL.Append(Environment.NewLine);
            SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");     
            if(complete)
            {
                SQL.Append($@"COMMENT ON Procedure {ProcedureObject.Name} IS '{ProcedureObject.Description}';{Environment.NewLine}{Environment.NewLine}");           
                SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }
            SQLScript.Add(SQL.ToString());
            if(complete)  SQLScript = AddSQLProcedureGrants(SQLScript, sbs, ProcedureObject);

            return SQLScript;
        }

        public List<string> MakeSQLAlterProcedure(ProcedureClass ProcedureObject,ProcedureClass OldProcedureObject, bool complete)
        {           
            var SQLScript = new List<string>();
            string infoStr =  $@"/* ********* Create/alter for procedure {ProcedureObject.Name.Trim()} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                
            var SQL = new StringBuilder();
            SQL.Append(Environment.NewLine);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.AppendLine(infoStr);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.Append(Environment.NewLine);
            
            if (OldProcedureObject.Name != ProcedureObject.Name)
            {
                SQL.Append($@"DROP PROCEDURE {OldProcedureObject.Name};{Environment.NewLine}{Environment.NewLine}");                
                SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");                
            }

            SQL.Append($@"SET TERM ^ ;{Environment.NewLine}{Environment.NewLine}");            
            SQL.Append($@"CREATE OR ALTER PROCEDURE {ProcedureObject.Name.Trim()}{Environment.NewLine}");
            SQL.Append($@"({Environment.NewLine}");

            //In Variables

            for (int i = 0; i < ProcedureObject.ParameterIn.Count; i++)
            {                
                var pc  = ProcedureObject.ParameterIn[i];
                SQL.Append($@"    {pc.Name} ");
                SQL.Append(pc.RawType);
                if((ProcedureObject.ParameterIn.Count > 1)&&(i < ProcedureObject.ParameterIn.Count-1))
                {
                    SQL.Append($@",{Environment.NewLine}");
                }              
            }
            SQL.Append(Environment.NewLine);
            SQL.Append($@"){Environment.NewLine}");

            if (ProcedureObject.ParameterOut.Count > 0)
            {
                SQL.Append($@"RETURNS{Environment.NewLine}({Environment.NewLine}");
                for (int i = 0; i < ProcedureObject.ParameterOut.Count; i++)
                {                    
                    var pc = ProcedureObject.ParameterOut[i];
                    SQL.Append($@"    {pc.Name} ");
                    SQL.Append(pc.RawType);
                    if ((ProcedureObject.ParameterOut.Count > 1) && (i < ProcedureObject.ParameterOut.Count - 1))
                    {
                        SQL.Append($@",{Environment.NewLine}");
                    }
                }
                SQL.Append(Environment.NewLine);
                SQL.Append($@"){Environment.NewLine}");
            }

            SQL.Append($@"AS{Environment.NewLine}");
            if(!complete)
            {
                SQL.Append($@"BEGIN{Environment.NewLine}");
                SQL.Append($@"    SUSPEND;{Environment.NewLine}");
                SQL.Append($@"END{Environment.NewLine}");            
            }
            var sbs = new StringBuilder();
            if(complete)
            {          
                
                for (int i = 0; i < ProcedureObject.Source.Count; i++)
                {
                    SQL.Append($@"{ProcedureObject.Source[i]}{Environment.NewLine}");
                    if(ProcedureObject.Source[i].Trim().StartsWith("/*")) continue;
                    sbs.Append($@"{ProcedureObject.Source[i]} ").Replace(Environment.NewLine," ");
                }
            }

            SQL.Append($@"^{Environment.NewLine}");            
            SQL.Append($@"SET TERM ; ^{Environment.NewLine}");   
            SQL.Append(Environment.NewLine);
            SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");     
            if(complete)
            {
                SQL.Append($@"COMMENT ON Procedure {ProcedureObject.Name} IS '{ProcedureObject.Description}';{Environment.NewLine}{Environment.NewLine}");           
                SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }
            SQLScript.Add(SQL.ToString());
            if(complete)  SQLScript = AddSQLProcedureGrants(SQLScript, sbs, ProcedureObject);

            return SQLScript;
        }

        public List<string> MakeSQLCreateFunction(FunctionClass FunctionObject, bool complete)
        {            
            var SQLScript = new List<string>();
            var SQL = new StringBuilder();
            SQL.Append(Environment.NewLine);
            string infoStr =  $@"/* ********* Create for function {FunctionObject.Name.Trim()} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                
           
            SQL.Append(Environment.NewLine);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.AppendLine(infoStr);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.Append(Environment.NewLine);


            SQL.Append($@"SET TERM^  ;{Environment.NewLine}");
            SQL.Append($@"CREATE FUNCTION {FunctionObject.Name}{Environment.NewLine}({Environment.NewLine}");
           
            //In Variables

            for (int i = 0; i < FunctionObject.ParameterIn.Count; i++)
            {               
                var pc = FunctionObject.ParameterIn[i];
                SQL.Append($@"    {pc.Name} ");
                SQL.Append(pc.RawType);
                if ((FunctionObject.ParameterIn.Count <= 1) || (i >= FunctionObject.ParameterIn.Count - 1)) continue;                
                SQL.Append($@",{Environment.NewLine}");                   
            }
           
            SQL.Append($@"{Environment.NewLine}){Environment.NewLine}");

            if (FunctionObject.ParameterOut.Count > 0)
            {
                SQL.Append($@"RETURNS{Environment.NewLine}({Environment.NewLine}");
                for (int i = 0; i < FunctionObject.ParameterOut.Count; i++)
                {                   
                    var pc = FunctionObject.ParameterOut[i];
                    SQL.Append($@"    {pc.Name} ");
                    SQL.Append(pc.RawType);
                    if ((FunctionObject.ParameterOut.Count <= 1) || (i >= FunctionObject.ParameterOut.Count - 1)) continue;                    
                    SQL.Append($@",{Environment.NewLine}");                       
                }                
                SQL.Append($@"{Environment.NewLine}){Environment.NewLine}");
            }

            SQL.Append(Environment.NewLine);
            SQL.Append($@"AS{Environment.NewLine}");            
            SQL.Append($@"DECLARE VARIABLE X INT;{Environment.NewLine}");            
            SQL.Append($@"BEGIN{Environment.NewLine}");            
            SQL.Append($@"  X = 0;{Environment.NewLine}");            
            SQL.Append($@"  RETURN X+1;{Environment.NewLine}");            
            SQL.Append($@"END^{Environment.NewLine}");            
            SQL.Append($@"SET TERM; ^{Environment.NewLine}{Environment.NewLine}");            
            SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");            
            SQL.Append($@"COMMENT ON FUNCTION {FunctionObject.Name} IS '';{Environment.NewLine}");
            SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");
            SQLScript.Add(SQL.ToString());
            if(complete)
            {
                string cms = $@"GRANT EXECUTE ON PROCEDURE {FunctionObject.Name} TO SYSDBA;{Environment.NewLine}";
                SQLScript.Add(cms);
            }
            return SQLScript;
        }
        
        public List<string> MakeSQLAlterFunction(FunctionClass FunctionObject, FunctionClass OldFunctionObject, bool complete)
        {      
             

            var SQLScript = new List<string>();
            var SQL = new StringBuilder();            
            

            string infoStr =  $@"/* ********* Create/alter for function {FunctionObject.Name.Trim()} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                
           
            SQL.Append(Environment.NewLine);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.AppendLine(infoStr);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.Append(Environment.NewLine);

            if (OldFunctionObject.Name != FunctionObject.Name)
            {
                SQL.Append($@"DROP FUNCTION {OldFunctionObject.Name};{Environment.NewLine}{Environment.NewLine}");                
                SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");                
            }

            SQL.Append($@"SET TERM ^ ;{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");            
            SQL.Append($@"CREATE OR ALTER FUNCTION {FunctionObject.Name}{Environment.NewLine}");
            SQL.Append($@"({Environment.NewLine}");

            //In Variables
            
            for (int i = 0; i < FunctionObject.ParameterIn.Count; i++)
            {                
                ParameterClass pc  = FunctionObject.ParameterIn[i];
                SQL.Append($@"    {pc.Name} {pc.RawType}");                
                if((FunctionObject.ParameterIn.Count <= 1) || (i >= FunctionObject.ParameterIn.Count-1)) continue;                
                SQL.Append($@",{Environment.NewLine}");                           
            }
                        
            SQL.Append($@"{Environment.NewLine}){Environment.NewLine}");

            if (FunctionObject.ParameterOut.Count > 0)
            {
                SQL.Append($@"RETURNS{Environment.NewLine}");

                if (FunctionObject.ParameterOut.Count > 1) SQL.Append($@"({Environment.NewLine}");

                for (int i = 0; i < FunctionObject.ParameterOut.Count; i++)
                {
                    // fctSQL.AppendText("IN: "+ProcedureObject.ParameterIn[i] + Environment.NewLine);
                    ParameterClass pc = FunctionObject.ParameterOut[i];
                    SQL.Append("    "+pc.Name + " ");
                    SQL.Append(pc.RawType);
                    if ((FunctionObject.ParameterOut.Count <= 1) || (i >= FunctionObject.ParameterOut.Count - 1)) continue;
                    
                    SQL.Append($@",{Environment.NewLine}");                       
                }
                SQL.Append(Environment.NewLine);
                if (FunctionObject.ParameterOut.Count > 1) SQL.Append($@"){Environment.NewLine}");
            }
            
            SQL.Append($@"AS{Environment.NewLine}");

            if(!complete)
            {
                SQL.Append($@"BEGIN{Environment.NewLine}");
                SQL.Append($@"    SUSPEND;{Environment.NewLine}");
                SQL.Append($@"END{Environment.NewLine}");            
            }

            var sbs = new StringBuilder();
            if(complete)
            {
                
                for (int i = 0; i < FunctionObject.Source.Count; i++)
                {
                    SQL.Append(FunctionObject.Source[i] + Environment.NewLine);
                    if(!FunctionObject.Source[i].Trim().StartsWith("/*"))
                        sbs.Append($@"{FunctionObject.Source[i]} ").Replace(Environment.NewLine," ");
                }
            }
            
            SQL.Append($@"^{Environment.NewLine}SET TERM ; ^{Environment.NewLine}{Environment.NewLine}");           
            SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");      
            if(complete)
            {
                SQL.Append($@"COMMENT ON FUNCTION {FunctionObject.Name} IS '{FunctionObject.Description}';{Environment.NewLine}");
                SQL.Append($@"{SQLPatterns.Commit}{Environment.NewLine}");
            }

            SQLScript.Add(SQL.ToString());

            //Grants
            
            if(complete)  SQLScript = AddSQLFunctionGrants(SQLScript, sbs, FunctionObject);
            
            return SQLScript;
        }

        public List<string> MakeSQLDeclareUserDefinedFunction(UserDefinedFunctionClass FunctionObject, UserDefinedFunctionClass OldFunctionObject, bool complete)
        {      
            /*
            DECLARE EXTERNAL FUNCTION SUBSTR
            CSTRING(255),
            SMALLINT,
            SMALLINT
            RETURNS CSTRING(255) FREE_IT
            ENTRY_POINT 'IB_UDF_substr' MODULE_NAME 'ib_udf';

            */

            var SQLScript = new List<string>();
            var SQL = new StringBuilder();            
            
            string infoStr =  $@"/* ********* Declaration for user defined function {FunctionObject.Name.Trim()} date:{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ********** */";                       
            SQL.Append(Environment.NewLine);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.AppendLine(infoStr);
            SQL.AppendLine(GetInfoHeader(infoStr.Length));
            SQL.Append(Environment.NewLine);

                                
            SQL.Append($@"DECLARE EXTERNAL FUNCTION {FunctionObject.Name}{Environment.NewLine}");

            for (int i = 0; i < FunctionObject.ParameterIn.Count; i++)
            {                
                var pc  = FunctionObject.ParameterIn[i];
                string RawType = TypeConvert.GetUDFType(pc.FieldType, pc.Length);
                
                SQL.Append($@"    {RawType}");                
                
                if((FunctionObject.ParameterIn.Count <= 1) || (i >= FunctionObject.ParameterIn.Count-1)) continue;                
                SQL.Append($@",{Environment.NewLine}");                           
            }
                        
            SQL.Append($@"{Environment.NewLine}");

            if (FunctionObject.ParameterOut.Count > 0)
            {
                SQL.Append($@"RETURNS{Environment.NewLine}");
                
                for (int i = 0; i < FunctionObject.ParameterOut.Count; i++)
                {
                    // fctSQL.AppendText("IN: "+ProcedureObject.ParameterIn[i] + Environment.NewLine);
                    ParameterClass pc = FunctionObject.ParameterOut[i];
                    string RawType = TypeConvert.GetUDFType(pc.FieldType, pc.Length);
                    if(RawType.StartsWith("CSTRING"))
                    {
                        SQL.Append($@"    {RawType} FREE_IT{Environment.NewLine}");                
                    }
                    else
                    {
                        SQL.Append($@"    {RawType} BY VALUE{Environment.NewLine}");   
                    }

                    
                    if ((FunctionObject.ParameterOut.Count <= 1) || (i >= FunctionObject.ParameterOut.Count - 1)) continue;                                        
                }

                SQL.Append(Environment.NewLine);                
            }
            
            SQL.Append($@"ENTRY_PONT '{FunctionObject.EntryPoint}' MODULE_NAME = '{FunctionObject.ModuleType}';{Environment.NewLine}");           
                                               
            SQLScript.Add(SQL.ToString());

            return SQLScript;
        }
               
        #endregion



        public TableClass GetTableObjectForIndexForm(DBRegistrationClass DBReg, string TableName)
        {
            if (string.IsNullOrEmpty(TableName)) return null;
            string _funcStr = $@"GetTableObjectForIndexForm(DBReg={DBReg})";
            try
            {
                var tc = DataClassFactory.GetDataClass(StaticVariablesClass.TablesKeyStr) as TableClass;
                tc.Name = TableName.Trim();
                var fields = GetFieldObjects(DBReg, tc.Name);               
                tc.Fields = fields;
                return tc;
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                         
            }
               
            return null;
        }

        public TableClass GetTableObjectFromName(DBRegistrationClass DBReg, string TableName)
        {
            string _funcStr = $@"GetTableObjectFromName(DBReg={DBReg})";
            string fieldsCmd = SQLStatementsClass.Instance.GetTableFields(DBReg.Version, TableName);
            var tableObject = new TableClass
            {
                Fields = new Dictionary<string, TableFieldClass>()
            };
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fieldsCmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {                    
                    tableObject.Fields = new Dictionary<string, TableFieldClass>();

                    while (dread.Read())
                    {
                        var tfc = new TableFieldClass
                        {
                            TableName = TableName                            
                        };

                        tfc.Name                = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                        tfc.Domain.RawType      = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position            = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0)+1;                        
                        tfc.Domain.FieldType    = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                        tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                        tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                        tfc.Domain.Length       = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                        tfc.Domain.Name         = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                        tfc.Domain.Scale        = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue        = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                        tfc.Domain.Collate      = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                        tfc.Domain.CharSet      = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                        bool NNConstraint = tableObject.IsNotNull(tfc.Name);
                        bool NNFlag = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                        if (NNConstraint != NNFlag)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                        }
                        tfc.Domain.NotNull = NNConstraint;              
                        tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                        tfc.Description         = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim(); 
                        tfc.Domain.Description  = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim(); 
                        if (tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            
                        }
                                                
                        tableObject.Fields.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
            }
            finally
            {
                con.Close();
            }
            return tableObject;
        }

        public TableClass GetTableObject(DBRegistrationClass DBReg, TableClass tc)
        {
            string _funcStr = $@"GetTableObject(DBReg={DBReg})";

           

            var tableObject = (TableClass) tc.Clone();            
            string fields_cmd = SQLStatementsClass.Instance.GetTableFields(DBReg.Version, tableObject.Name);
            tableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread.HasRows)
                {                   
                    tableObject.Fields = new Dictionary<string, TableFieldClass>();
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int n = 0;
                    while (dread.Read())
                    {
                        n++;
                        var tfc = new TableFieldClass
                        {
                            TableName = dread.GetValue(GetTableFieldsInx.TableNameInx).ToString().Trim(),
                            Name = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim()
                        };
                        tfc.Domain.Length       = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                        tfc.Domain.FieldType    = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                        tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                        tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                        tfc.Domain.RawType      = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position            = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0)+1;
                        tfc.Domain.Name         = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                        tfc.Domain.Scale        = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue        = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                        tfc.Domain.Collate      = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                        tfc.Domain.CharSet      = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                        bool NNConstraint= tableObject.IsNotNull(tfc.Name);
                        bool NNFlag = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                        if (NNConstraint != NNFlag)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                        }
                        tfc.Domain.NotNull = NNConstraint;
                        tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                        tfc.Description         = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                        tfc.Domain.Description  = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();
                        if (tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }                            
                        }
                        tableObject.Fields.Add(tfc.Name,tfc);
                    }
                    Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                    NotifiesClass.Instance.AddToINFO($@"GetTableObject->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                    sw.Stop();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr},{tc.Name})", ex));                     
            }
            finally
            {
                con.Close();
            }
            return tableObject;
        }

        public List<string> GetDatabaseStatistics(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetDatabaseStatistics(DBReg={DBReg})";
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            var data = new List<string>();
            try
            {
                con.Open();
                string cmd = "select current_user from rdb$database;";
                var fcmd = new FbCommand(cmd, con);          
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    while (dread.Read())
                    {
                        string  str = dread.GetValue(0).ToString().Trim();
                        data.Add("Current user:"+str);
                    }
                }
                data.Add(" ");
                data.Add(" ");
                cmd = "select mon$next_transaction,MON$SQL_DIALECT,MON$PAGE_SIZE,MON$CREATION_DATE,MON$PAGES,MON$SWEEP_INTERVAL,MON$FORCED_WRITES,MON$READ_ONLY,MON$BACKUP_STATE from mon$database;";

                fcmd = new FbCommand(cmd, con);
                dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    while (dread.Read())
                    {                       
                       int ps                   = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                       long pg                  = StaticFunctionsClass.ToLongDef(dread.GetValue(4).ToString().Trim(), 0);
                       string speewintervall    = dread.GetValue(5).ToString().Trim();
                       int forced_writes        = StaticFunctionsClass.ToIntDef(dread.GetValue(6).ToString().Trim(), 0);
                       int read_only            = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(),0);                       
                       int backup_stae          = StaticFunctionsClass.ToIntDef(dread.GetValue(8).ToString().Trim(),0);

                       string rdstr  = (read_only > 0) ? "read-only" : "read/write";
                       string fwrite = (forced_writes > 0) ? "ON" : "OFF";
                       string bstate = "normal";
                                             
                       switch (backup_stae)
                       {
                           case 1: bstate = "stalled"; break;
                           case 2: bstate = "merge"; break;
                       }
                       data.Add($@"Database lifetime       :{dread.GetValue(0).ToString().Trim(),-40}");
                       data.Add($@"Database creation date  :{dread.GetValue(3).ToString().Trim(),-40}");
                       data.Add($@"Database SQL dialect    :{dread.GetValue(1).ToString().Trim(),-40}");
                       data.Add($@"Database page size      :{ps} bytes, number of pages:{pg} toal size:{ps*pg/1024} kbyte");
                       data.Add($@"Database sweep intervall:{speewintervall,-40}");
                       data.Add($@"Database read-write mode:{rdstr,-40}");
                       data.Add($@"Database forced-writes  :{fwrite,-40}");
                       data.Add($@"Database backup-state   :{bstate,-40}");
                    }
                }

                data.Add(" ");
                data.Add(" ");
                cmd = $@"SELECT r.rdb$relation_name, (SELECT max(i.rdb$statistics)||(count(rf.rdb$relation_name) * 0) FROM rdb$relation_fields rf WHERE rf.rdb$relation_name = r.rdb$relation_name ) , (SELECT count(rfx.rdb$relation_name) FROM rdb$relation_fields rfx where rfx.rdb$relation_name = r.rdb$relation_name ) FROM rdb$relations r join rdb$indices i ON (i.rdb$relation_name = r.rdb$relation_name) GROUP BY r.rdb$relation_name order by 2";
                fcmd = new FbCommand(cmd, con);
                dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    string str1 = $@"{"Table",-40} {"Maximum index selectivity",-25} {"Fields count"}";
                    data.Add(str1);
                    data.Add("-----------------------------------------------------------------------------------------------------------------");
                    while (dread.Read())
                    {
                        string str = $@"{dread.GetValue(0),-40} {dread.GetValue(1),-25} {dread.GetValue(2)}";
                        data.Add(str);
                    }
                }
                data.Add(" ");
                data.Add(" ");
                cmd = "SELECT MON$PAGE_READS, MON$PAGE_WRITES, MON$PAGE_FETCHES, MON$PAGE_MARKS FROM MON$IO_STATS WHERE MON$STAT_GROUP = 0";
                fcmd = new FbCommand(cmd, con);
                dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    string str1 = $@"{"MON$PAGE_READS",-25} {"MON$PAGE_WRITES",-25} {"MON$PAGE_FETCHES",-25} {"MON$PAGE_MARKS",-25}";
                    data.Add(str1);
                    data.Add("-----------------------------------------------------------------------------------------------------------------");
                    while (dread.Read())
                    {
                        string str = $@"{dread.GetValue(0),-25} {dread.GetValue(1),-25} {dread.GetValue(2),-25} {dread.GetValue(3),-25}";
                        data.Add(str);
                    }
                }
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
            }
            finally
            {
                con.Close();
            }
            return data;
        }

        public Dictionary<string,TableClass> GetAllNonSystemTableObjectsComplete(DBRegistrationClass DBReg)
        {
            var tableList = GetAllNonSystemTableObjects(DBReg);
      
            if (tableList.Count <= 0) return null;
                        
            AddIndexObjects_To_ListOfTableObjects(DBReg, tableList);                            
            AddForeignKeyObjects_To_ListOfTableObjects(DBReg, tableList);
            AddTriggerObjects_To_ListOfTableObjects(DBReg, tableList);
            AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.UNIQUE, tableList, DBReg, eTableType.withoutsystem);
            AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.PRIMARYKEY, tableList, DBReg, eTableType.withoutsystem);
            AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.NOTNULL, tableList, DBReg, eTableType.withoutsystem);
            AddCheckConstraintsObjects_To_ListOfTableObjects(tableList, DBReg, eTableType.withoutsystem);
           // AddDependenciesTOObjects_To_ListOfTableObjects(DBReg, tableList, eDependencies.TABLE);
            AddDependenciesOfTablesToAnyObjects(DBReg, tableList, eDependencies.TABLE);
            AddDependenciesFROMObjects_To_ListOfTableObjects(DBReg, tableList, eDependencies.TABLE);
            return tableList;
        }

        public Dictionary<string, SystemTableClass> GetAllSystemTableObjectsComplete(DBRegistrationClass DBReg)
        {
            var tableList = GetAllSystemTableObjects(DBReg);

            if (tableList.Count <= 0) return null;

             AddSystemIndexObjects_To_ListOfTableObjects(DBReg, tableList);
            // AddForeignKeyObjects_To_ListOfTableObjects(DBReg, tableList);
            AddTriggerObjects_To_ListOfSystemTableObjects(DBReg, tableList);
            // AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.UNIQUE, tableList, DBReg, eTableType.withoutsystem);
            // AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.PRIMARYKEY, tableList, DBReg, eTableType.withoutsystem);
            // AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.NOTNULL, tableList, DBReg, eTableType.withoutsystem);
            // AddCheckConstraintsObjects_To_ListOfTableObjects(tableList, DBReg, eTableType.withoutsystem);
            // AddDependenciesTOObjects_To_ListOfTableObjects(DBReg, tableList, eDependencies.TABLE);
            AddDependenciesOfSystemTablesToAnyObjects(DBReg, tableList, eDependencies.TABLE);
            // AddDependenciesFROMObjects_To_ListOfTableObjects(DBReg, tableList, eDependencies.TABLE);
            return tableList;
        }

        public Dictionary<string,TableClass> GetAllNonSystemTableObjects(DBRegistrationClass DBReg)
        {
          //  Thread.Sleep(1000);
            string _funcStr = $@"GetAllTableObjects(DBReg={DBReg})";
            var TableObject = new TableClass();
            string fields_cmd = SQLStatementsClass.Instance.GetAllNonSystemTableFields(DBReg.Version);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            var tables = new Dictionary<string,TableClass>();

            try
            {
                using (TransactionScope c = new TransactionScope())
                {

                    //con.ConnectionString = $@"User = SYSDBA; Password = masterkey; Database = D:\Projekte2015\Passwords\MainSource\bin\Debug\DATA\PDATA30.FDB; DataSource =; Port = 3050; Dialect = 3; Charset = NONE; Role =; Connection lifetime = 0; Connection timeout = 15; Pooling = True; MaxPoolSize = 15; MinPoolSize = 0; Packet Size = 8192; Server Type = 1; ClientLibrary = D:\Projekte2015\FBXpert\FBExpert\bin\Debug\ClientLibraries\FB3\X64\fbclient.dll";
                    con.Open();

                    var fcmd = new FbCommand(fields_cmd, con);
                    var dread = fcmd.ExecuteReader();
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        TableClass table = null;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        int n = 0;
                        while (dread.Read())
                        {
                         //   Console.WriteLine($@"GetAllTableObjects used Time {n}:{sw.ElapsedMilliseconds}");
                            n++;
                            var tfc = new TableFieldClass();
                            var tableName = dread.GetValue(GetTableFieldsInx.TableNameInx).ToString().Trim();

                            if (tableName != oldTableName)
                            {
                                table = new TableClass
                                {
                                    Name = tableName,
                                    Fields = new Dictionary<string, TableFieldClass>()
                                };
                                oldTableName = tableName;
                                GetConstraintsObjectsForTable(eConstraintType.NOTNULL, table, DBReg);
                                tables.Add(table.Name, table);
                            }
                            tfc.TableName = tableName;
                            
                            tfc.Name                = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                            tfc.Position            = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0) + 1;
                            tfc.Domain.FieldType    = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                            tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                            tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                            tfc.Domain.Length       = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                            tfc.Domain.RawType      = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                            tfc.Domain.Name         = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                            tfc.Domain.Scale        = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                            tfc.DefaultValue        = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                            tfc.Domain.Collate      = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                            tfc.Domain.CharSet      = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                            bool NNConstraint       = table.IsNotNull(tfc.Name);
                            bool NNFlag             = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                            if (NNConstraint != NNFlag)
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}",$@"{table.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                            }
                            tfc.Domain.NotNull      = NNConstraint;
                            tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                            tfc.Description         = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                            tfc.Domain.Description  = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();
                            if (tfc.Domain.DefaultValue.Length > 0)
                            {
                                if (tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                                {
                                    tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                                }
                            }
                            table.Fields.Add(tfc.Name, tfc);
                        }
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetAllTableObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.more, true);
                        sw.Stop();
                    }
                    con.Close();
                    c.Complete();
                }
                
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
            }
            finally
            {
                con.Close();
            }
            return tables;
        }

        public Dictionary<string,SystemTableClass> GetAllSystemTableObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetSystemTableObjects(DBReg={DBReg})";

            var tables = new Dictionary<string,SystemTableClass>();
            var TableObject = new TableClass();
            
            string fields_cmd = SQLStatementsClass.Instance.GetAllSystemTableFields(DBReg.Version);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
               
                if (dread.HasRows)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int n = 0;

                    string oldTableName = string.Empty;
                    SystemTableClass tableObject = null;
                    while (dread.Read())
                    {
                        n++;
                        var tfc = new TableFieldClass();
                        var tableName = dread.GetValue(GetTableFieldsInx.TableNameInx).ToString().Trim();
                        if (tableName != oldTableName)
                        {
                            tableObject = new SystemTableClass
                            {
                                Name = tableName,
                                Fields = new Dictionary<string, TableFieldClass>()
                            };
                            oldTableName = tableName;
                            tables.Add(tableObject.Name, tableObject);
                        }
                        tfc.TableName = tableName;

                        tfc.Name                = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                        tfc.Position            = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0) + 1;
                        tfc.Domain.FieldType    = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                        tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                        tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                        tfc.Domain.Length       = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                        tfc.Domain.Name         = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                        tfc.Domain.Scale        = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue        = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                        tfc.Domain.Collate      = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                        tfc.Domain.CharSet      = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                        bool NNFlag             = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                        tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                        tfc.Description         = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                        tfc.Domain.Description  = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();

                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        bool NNConstraint = tableObject.IsNotNull(tfc.Name);
                        
                        if (NNConstraint != NNFlag)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                        }
                        tfc.Domain.NotNull = NNConstraint;
                        
                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                        }
                        tableObject.Fields.Add(tfc.Name,tfc);
                    }
                    Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                    NotifiesClass.Instance.AddToINFO($@"GetSystemTableObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.more, true);
                    sw.Stop();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
            }
            finally
            {
                con.Close();
            }
            
            return tables;
        }

        public Dictionary<string,FunctionClass> GetInternalFunctionObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetInternalFunctionObjects(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshInternalFunctionsItems(DBReg.Version);     
            var allfunctions = new Dictionary<string,FunctionClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Connection not open"));
                return allfunctions;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {   
                try
                {
                    var fcmd = new FbCommand(cmd, con);          
                    var dread = fcmd.ExecuteReader();
                    if (dread != null)
                    {
                        if (dread.HasRows)
                        {
                            int n = 0;
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            
                            while (dread.Read())
                            {
                                var tc = DataClassFactory.GetDataClass(StaticVariablesClass.FunctionsKeyStr) as FunctionClass;
                                tc.Name         = dread.GetValue(0).ToString().Trim();
                                string ftype    = dread.GetValue(1).ToString().Trim();
                                string src      = dread.GetValue(2).ToString().Trim();
                                string[] srcarr = src.Split('\n');
                                foreach (string st in srcarr)
                                {
                                    tc.Source.Add(st.Trim());
                                }
                                                           
                                var con2 = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                                con2.Open();
                                
                                if (con2.State == System.Data.ConnectionState.Open)
                                {
                                    string cmd1 = SQLStatementsClass.Instance.GetFunctionsArguments(DBReg.Version, tc.Name);
                                    var fcmd2 = new FbCommand(cmd1, con2);
                                    var dread2 = fcmd2.ExecuteReader();

                                    if (dread2 != null)
                                    {
                                        if (dread2.HasRows)
                                        {
                                            while (dread2.Read())
                                            {
                                                ParameterClass pc = new ParameterClass()
                                                {
                                                    Name = dread2.GetValue(0).ToString().Trim()                                                
                                                };
                                            
                                                pc.Position     = StaticFunctionsClass.ToIntDef(dread2.GetValue(1).ToString().Trim(), 0);
                                                pc.TypeNumber   = StaticFunctionsClass.ToIntDef(dread2.GetValue(2).ToString().Trim(), 0);
                                                pc.Length       = StaticFunctionsClass.ToIntDef(dread2.GetValue(3).ToString().Trim(), 0);
                                                pc.Precision    = StaticFunctionsClass.ToIntDef(dread2.GetValue(4).ToString().Trim(), 0);
                                                pc.Scale        = StaticFunctionsClass.ToIntDef(dread2.GetValue(5).ToString().Trim(), 0);
                                                pc.FieldType    = dread2.GetValue(6).ToString().Trim();
                                                pc.RawType      = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(pc.FieldType, pc.Length);

                                                if(pc.Name.Length > 0)
                                                {
                                                    tc.ParameterIn.Add(pc);
                                                }                                            
                                                else
                                                {
                                                    tc.ParameterOut.Add(pc);
                                                }                                            
                                            }
                                        }
                                        dread2.Close();
                                    }
                                
                                    con2.Close();                            
                                    allfunctions.Add(tc.Name,tc);                                
                                    n++;
                                }
                                else
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread2==null"));
                                }
                            }
                            Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                            NotifiesClass.Instance.AddToINFO($@"GetInternalFunctionObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                            sw.Stop();
                        }
                    }
                    else
                    {
                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                    }
                    dread.Close();
                }
                catch(Exception ex)
                {
                      NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->msg:{ex.Message}"));
                }                                
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connections not open"));
            }
            return allfunctions;
        }

        public Dictionary<string,UserDefinedFunctionClass> GetUserDefinedFunctionObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetUserDefinedFunctionObjects(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshUserDefinedFunctionsItems(DBReg.Version);     
            var allfunctions = new  Dictionary<string,UserDefinedFunctionClass>();
            if(string.IsNullOrEmpty(cmd)) return allfunctions;

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshUserDefinedFunctionsItems->{DBReg}->Connection not open"));
                return allfunctions;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {        
                try
                {
                    var fcmd = new FbCommand(cmd, con);          
                    var dread = fcmd.ExecuteReader();
                    if (dread != null)
                    {
                        if (dread.HasRows)
                        {
                            int n = 0;
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            
                            while (dread.Read())
                            {
                                var tc = DataClassFactory.GetDataClass(StaticVariablesClass.UserDefinedFunctionsKeyStr) as UserDefinedFunctionClass;
                                tc.Name = dread.GetValue(0).ToString().Trim();
                                string ftype = dread.GetValue(1).ToString().Trim();
                                string src = dread.GetValue(2).ToString().Trim();
                                tc.ModuleType = dread.GetValue(3).ToString().Trim();
                                tc.EntryPoint = dread.GetValue(4).ToString().Trim();
                                string[] srcarr = src.Split('\n');
                                foreach (string st in srcarr)
                                {
                                    if(st.Trim().Length > 0)  tc.Source.Add(st.Trim());
                                }
                                                           
                                var con2 = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                                con2.Open();                            
                                if (con2.State == System.Data.ConnectionState.Open)
                                {
                                    string cmd1 = SQLStatementsClass.Instance.GetUserDefinedFunctionsAttributes(DBReg.Version, tc.Name);
                                    var fcmd2 = new FbCommand(cmd1, con2);
                                    var dread2 = fcmd2.ExecuteReader();

                                    if (dread2 != null)
                                    {
                                        if (dread2.HasRows)
                                        {
                                            while (dread2.Read())
                                            {
                                                 ParameterClass pc = new ParameterClass()
                                                 {
                                                    Name = "UDF"                                        
                                                 };
                                            
                                              //   string nm = dread2.GetValue(0).ToString().Trim();
                                                 pc.Name = "ArgName";
                                                 pc.Position        = StaticFunctionsClass.ToIntDef(dread2.GetValue(0).ToString().Trim(), 0);
                                                 int mechanism      = StaticFunctionsClass.ToIntDef(dread2.GetValue(1).ToString().Trim(), 0);
                                                 pc.Length          = StaticFunctionsClass.ToIntDef(dread2.GetValue(3).ToString().Trim(), 0);                                                 
                                                 pc.FieldType       = dread2.GetValue(6).ToString().Trim();
                                            
                                                 if(mechanism < 1)
                                                 {
                                                     tc.ParameterOut.Add(pc);
                                                 }                                            
                                                 else
                                                 {
                                                     tc.ParameterIn.Add(pc);
                                                 }                                            
                                            }
                                        }
                                        dread2.Close();
                                    }                                
                                    con2.Close();                            
                                    allfunctions.Add(tc.Name,tc);                                
                                    n++;
                                }
                                else
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->dread2==null"));
                                }
                            }
                            Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                            NotifiesClass.Instance.AddToINFO($@"GetUserDefinedFunctionObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                            sw.Stop();
                        }
                    }
                    else
                    {
                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->dread==null"));
                    }                
                    dread.Close();
                }
                catch(Exception ex)
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->msg:{ex.Message}"));
                }
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->Connections not open"));
            }
            return allfunctions;
        }

        public Dictionary<string,TriggerClass> GetTriggerObjects(DBRegistrationClass DBReg, string TableName)
        {
            var triggers = new Dictionary<string,TriggerClass>();
           
            if (!string.IsNullOrEmpty(TableName))
            {
                string fields_cmd = SQLStatementsClass.Instance.GetTableTriggers(DBReg.Version, TableName);
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                try
                {                    
                    con.Open();
                    var fcmd = new FbCommand(fields_cmd, con);
                    var dread = fcmd.ExecuteReader();
                    if (dread.HasRows)
                    {
                        while (dread.Read())
                        {
                            var tfc = new TriggerClass
                            {
                                Name = dread.GetValue(0).ToString().Trim()
                            };
                            triggers.Add(tfc.Name,tfc);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetTriggerObjects({DBReg},{TableName})", ex));                         
                }
                finally
                {
                    con.Close();
                }
            }
            return triggers;
        }

        public Dictionary<string,ConstraintsClass> GetCheckConstraintsObjects(string TableName, DBRegistrationClass DBReg)
        {
            var constraints = new Dictionary<string,ConstraintsClass>();
            string cmd = ConstraintsSQLStatementsClass.Instance.GetTableCheckConstraints(DBReg.Version,  TableName);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetCheckConstraintsObjects({TableName},{DBReg})", ex));                     
                con.Close();
                return constraints;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.ChecksKeyStr) as ChecksClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.ConstraintType = eConstraintType.CHECK;                            
                            tc.TriggerName = dread.GetValue(6).ToString().Trim();                            
                            tc.TableName = dread.GetValue(2).ToString().Trim();
                            tc.Source = dread.GetValue(7).ToString().Trim();
                            constraints.Add(tc.Name,tc);
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetCheckConstraintsObjects->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetCheckConstraintsObjects->Connection not open"));
            }
            return constraints;
        }

        public Dictionary<string,TableFieldClass> GetFieldObjects(DBRegistrationClass DBReg, string TableName)
        {
            string _funcStr = $@"GetFieldObjects(DBReg={DBReg},TableName={TableName})";
            var fields = new Dictionary<string, TableFieldClass>();

            var tableObject = new TableClass();
            if (string.IsNullOrEmpty(TableName)) return fields;

            string fields_cmd = SQLStatementsClass.Instance.GetTableFields(DBReg.Version, TableName);
            tableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int n = 0;
                    while (dread.Read())
                    {
                        var tfc = new TableFieldClass();
                        string TabName          = dread.GetValue(GetTableFieldsInx.TableNameInx).ToString().Trim();
                        tfc.Name                = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                        tfc.Position            = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0) + 1;
                        tfc.Domain.FieldType    = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                        tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                        tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                        tfc.Domain.Length       = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                        tfc.Domain.Name         = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                        tfc.Domain.Scale        = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue        = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                        tfc.Domain.Collate      = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                        tfc.Domain.CharSet      = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                        bool NNlag              = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                        tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                        tfc.Description         = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                        tfc.Domain.Description  = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();

                        tfc.Domain.RawType      = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        bool NNConstraint       = tableObject.IsNotNull(tfc.Name);
                        
                        if (NNConstraint != NNlag)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNlag})"));
                        }
                        tfc.Domain.NotNull = NNConstraint;

                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            
                        }

                        
                        fields.Add(tfc.Name,tfc);
                    }
                    Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                    NotifiesClass.Instance.AddToINFO($@"GetFieldObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                    sw.Stop();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                         
            }
            finally
            {
                con.Close();
            }
                            
            return fields;
        }

       
        
        public Dictionary<string,ViewClass> GetViewObjects(DBRegistrationClass DBReg)
        {
            var allviews = new Dictionary<string,ViewClass>();
            string _funcStr = $@"GetViewObjects(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshViews(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObjects({DBReg})", ex));                                                                                         
                con.Close();
                return null;
            }
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();                               
                int n = 0;
                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        
                        string view_name_old = "";
                        string voldsql = "";

                        var strl = new StringBuilder();
                        var strli = new StringBuilder();

                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        int nn = 0;
                        while (dread.Read())
                        {

                            /*
                            relation_name, 
                            view_source,
                            field name
                            field position
                            fieldtypename
                            fieldlength
                            */
                            nn++;
                            object ob_viewname = dread.GetValue(0);
                            object ob_sql = dread.GetValue(1);
                            object ob_fieldname = dread.GetValue(2);
                            /*
                            object ob_fieldpos = dread.GetValue(3);
                            object ob_fieldtype = dread.GetValue(4);
                            object ob_fieldlength = dread.GetValue(5);
                            */
                            string view_name = ob_viewname.ToString().Trim();

                            if (view_name != view_name_old)
                            {
                                //Neuer View
                                var vc = DataClassFactory.GetDataClass(StaticVariablesClass.ViewsKeyStr) as ViewClass;
                                
                                if (strli.Length > 0)
                                {
                                    vc.Name = view_name_old;

                                    strli.AppendLine("");
                                    strli.AppendLine(") ");
                                    strli.Append("AS ");
                                    strli.AppendLine($@"{voldsql};");

                                    vc.CREATE_SQL = AppStaticFunctionsClass.CreateComment() + strli.ToString();

                                    strli.Clear();
                                }

                                if (strl.Length > 0)
                                {
                                    //Alter View existiert und muß weggeschrieen werden

                                    vc.Name = view_name_old;
                                    strl.AppendLine("");
                                    strl.AppendLine(") ");
                                    strl.Append("AS ");
                                    strl.AppendLine($@"{voldsql};");
                                    
                                    vc.SQL = voldsql;

                                    
                                    vc.CREATEINSERT_SQL = AppStaticFunctionsClass.CreateComment() + strl.ToString();
                                    
                                    allviews.Add(vc.Name,vc);
                                    var fields = GetViewFieldObjects(DBReg, vc.Name);
                                    
                                    foreach (var f in fields.Values)
                                    {                                        
                                        vc.Fields.Add(f.Name,f);
                                    }

                                    n++;
                                    view_name_old = "";
                                    strl.Clear();
                                }

                                strl.AppendLine($@"CREATE OR ALTER VIEW {view_name}");
                                strl.AppendLine("(");
                                strl.Append($@"    {ob_fieldname.ToString().Trim()}");

                                strli.AppendLine($@"CREATE VIEW {view_name}");
                                strli.AppendLine("(");
                                strli.Append($@"    {ob_fieldname.ToString().Trim()}");
                                view_name_old = view_name;
                            }
                            else
                            {
                                //Bestehender View wird niedergeschrieben
                                strl.AppendLine(",");
                                strl.Append($@"    {ob_fieldname.ToString().Trim()}");

                                strli.AppendLine(",");
                                strli.Append($@"    {ob_fieldname.ToString().Trim()}");
                            }
                            voldsql = ob_sql.ToString().Trim();
                            
                        }
                        Console.WriteLine($@"{_funcStr} used Time {nn}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetViewObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.more, true);
                        sw.Stop();
                        var vcl = DataClassFactory.GetDataClass(StaticVariablesClass.ViewsKeyStr) as ViewClass;

                        if (strli.Length > 0)
                        {
                            vcl.Name = view_name_old;
                            strli.AppendLine("");
                            strli.AppendLine(") ");
                            strli.Append("AS ");
                            strli.AppendLine($@"{voldsql};");
                            vcl.CREATE_SQL = AppStaticFunctionsClass.CreateComment() + strli.ToString();
                            strli.Clear();
                        }

                        if (strl.Length > 0)
                        {
                            //Alter View existiert und muß weggeschrieen werden

                            vcl.Name = view_name_old;
                            strl.AppendLine("");
                            strl.AppendLine(") ");
                            strl.Append("AS ");
                            strl.AppendLine($@"{voldsql};");

                            vcl.SQL = voldsql;
                            vcl.CREATEINSERT_SQL = AppStaticFunctionsClass.CreateComment() + strl.ToString();

                            allviews.Add(vcl.Name,vcl);
                            var fields = GetViewFieldObjects(DBReg, vcl.Name);

                            foreach (var f in fields.Values)
                            {
                                vcl.Fields.Add(f.Name,f);
                            }

                            n++;
                            view_name_old = "";
                            strl.Clear();
                        }

                    }
                    dread.Close();                   
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObjects->dread==null"));
                }
                con.Close();               
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObjects->Connection not open"));
            }
            return allviews;
        }
        
        public Dictionary<string,DomainClass> GetDomainObjects(DBRegistrationClass DBReg)
        {
            var domains = new Dictionary<string,DomainClass>();
            string _funcStr = $@"GetViewObjects(DBReg={DBReg})";
            string cmd = DomainSQLStatementsClass.Instance.RefreshNonSystemDomains(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {                
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDomains->{DBReg}", ex)); 
                return domains;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.DomainsKeyStr) as DomainClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            tc.TypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                            tc.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);
                            tc.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0);
                            tc.FieldType = dread.GetValue(5).ToString().Trim();
                            tc.CharSet = dread.GetValue(6).ToString().Trim();
                            tc.Collate = dread.GetValue(7).ToString().Trim();
                            tc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tc.FieldType, tc.Length);
                            tc.DefaultValue = dread.GetValue(8).ToString().Trim();
                            if(tc.DefaultValue.Length > 0 )
                            {
                                if(tc.DefaultValue.StartsWith("DEFAULT "))
                                {
                                    tc.DefaultValue = tc.DefaultValue.Substring(8).Trim();
                                }
                                
                            }
                            tc.Description = dread.GetValue(9).ToString().Trim();
                            domains.Add(tc.Name,tc);
                            
                            n++;
                        }
                        Console.WriteLine($@"GetDomainObjects->RefreshNonSystemDomainObjects used Time {n}:{sw.ElapsedMilliseconds}");
                        sw.Stop();
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->dreade==null"));
                }

                cmd = DomainSQLStatementsClass.Instance.RefreshSystemDomains(DBReg.Version);
                fcmd = new FbCommand(cmd, con);
                dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.DomainsKeyStr) as DomainClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            tc.TypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                            tc.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);
                            tc.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0);
                            tc.FieldType = dread.GetValue(5).ToString().Trim();
                            tc.CharSet = dread.GetValue(6).ToString().Trim();
                            tc.Collate = dread.GetValue(7).ToString().Trim();
                            tc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tc.FieldType, tc.Length);
                            domains.Add(tc.Name,tc);

                            n++;
                        }
                        Console.WriteLine($@"{_funcStr}->RefreshSystemDomainObjects used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetDomainObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->dread==null"));
                }
                con.Close();                
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->Connection not open"));
            }
            return domains;
        }
                  
        public Dictionary<string,TriggerClass> GetTriggerObjects(DBRegistrationClass DBReg)
        {
            var trigger = new Dictionary<string,TriggerClass>();

            string cmd = SQLStatementsClass.Instance.GetAllTableTriggersNonSystemTables(DBReg.Version); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggers->{DBReg}", ex));                 
                return trigger;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {

                    if (dread.HasRows)
                    {
                        int n = 0;
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.TriggersKeyStr) as TriggerClass;
                            tc.Name = dread.GetValue(1).ToString().Trim();
                            tc.RelationName = dread.GetValue(0).ToString().Trim();
                            tc.Sequence = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(),0);
                            tc.Source = dread.GetValue(6).ToString().Trim();

                            int inactive = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 1);
                            
                            tc.Active = inactive == 0;                         
                            trigger.Add(tc.Name,tc);

                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggers({DBReg})->dread==null"));
                }
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggers({DBReg})->Connection not open"));
            }
            return trigger;
        }
        
        public Dictionary<string,GeneratorClass> GetGeneratorObjects(DBRegistrationClass DBReg)
        {
            var generator = new Dictionary<string,GeneratorClass>();
            string _funcStr = $@"GetGeneratorObjects(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshNonSystemGeneratorsItems(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllGenerators->{DBReg}", ex));                 
                return generator;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.GeneratorsKeyStr) as GeneratorClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.InitValue = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            // tc.Increment = StaticFunctionsClass.ToIntDef(cc.GetValue(2).ToString().Trim(), 0);
                            tc.Description = dread.GetValue(3).ToString().Trim();

                            string cmd2 = $@"SELECT GEN_ID({tc.Name}, 0) FROM RDB$DATABASE;";

                            var con2 = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                            con2.Open();
                            if (con2.State != System.Data.ConnectionState.Open) continue;
                            
                            var fcmd2 = new FbCommand(cmd2, con2);
                            var dread2 = fcmd2.ExecuteReader();
                            if (dread2 != null)
                            {
                                if (dread2.HasRows)
                                {
                                    if (dread2.Read())
                                    {
                                        tc.Value = StaticFunctionsClass.ToIntDef(dread2.GetValue(0).ToString().Trim(), 0);
                                    }
                                }

                                generator.Add(tc.Name,tc);
                                
                                n++;
                                dread2.Close();
                            }
                            con2.Close();                               
                        }
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetGeneratorObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGenertorsItems->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGenertorsItems->Connection not open"));
            }
            return generator;
        }
        
        public Dictionary<string,ProcedureClass> GetProcedureObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetProcedureObjects(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshProcedureItems(DBReg.Version);
            var procedures = new Dictionary<string,ProcedureClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->{DBReg}->Connection not open"));
                return procedures;
            }


            if (con.State == System.Data.ConnectionState.Open)
            {                             
                var fcmd = new FbCommand(cmd, con);          
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.ProceduresKeyStr) as ProcedureClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            string src = dread.GetValue(1).ToString().Trim();
                            string[] srcarr = src.Split('\n');
                            foreach (string st in srcarr)
                            {
                                tc.Source.Add(st.Trim());
                            }
                                                           
                            var con2 = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                            con2.Open();
                            
                            if (con2.State == System.Data.ConnectionState.Open)
                            {
                                string cmd1 = SQLStatementsClass.Instance.GetProcedureAttributes(DBReg.Version, tc.Name);
                                var fcmd2 = new FbCommand(cmd1, con2);
                                var dread2 = fcmd2.ExecuteReader();

                                if (dread2 != null)
                                {
                                    if (dread2.HasRows)
                                    {
                                        while (dread2.Read())
                                        {
                                            ParameterClass pc = new ParameterClass()
                                            {
                                                Name = dread2.GetValue(0).ToString().Trim()                                                    
                                            };
                                            int InOutTyp = StaticFunctionsClass.ToIntDef(dread2.GetValue(1).ToString().Trim(), 0);
                                            pc.Position = StaticFunctionsClass.ToIntDef(dread2.GetValue(2).ToString().Trim(), 0);
                                            pc.TypeNumber = StaticFunctionsClass.ToIntDef(dread2.GetValue(3).ToString().Trim(), 0);                                               
                                            pc.Length = StaticFunctionsClass.ToIntDef(dread2.GetValue(4).ToString().Trim(), 0);
                                            pc.Precision = StaticFunctionsClass.ToIntDef(dread2.GetValue(5).ToString().Trim(), 0);
                                            pc.Scale = StaticFunctionsClass.ToIntDef(dread2.GetValue(6).ToString().Trim(), 0);
                                            pc.FieldType = dread2.GetValue(7).ToString().Trim();

                                            pc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(pc.FieldType, pc.Length);
                                                                                                                                            
                                            if (InOutTyp == 0)
                                            {
                                                tc.ParameterIn.Add(pc);
                                            }
                                            else
                                            {
                                                tc.ParameterOut.Add(pc);
                                            }                                                                                                                                                                                                                                                                                                                                                                
                                        }
                                    }
                                    dread2.Close();
                                }
                                
                                con2.Close();
                                procedures.Add(tc.Name,tc);                                    
                                n++;
                            }
                            else
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread2==null"));
                            }
                        }
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetProcedureObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                    }
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread==null"));
                }
                
                dread.Close();
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->Connections not open"));
            }

            return procedures;
        }

        public Dictionary<string, FunctionClass> GetFunctionObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetFunctionObjects(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshInternalFunctionsItems(DBReg.Version);
            var functions = new Dictionary<string, FunctionClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionItems->{DBReg}->Connection not open"));
                return functions;
            }


            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                    
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.FunctionsKeyStr) as FunctionClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            string src = dread.GetValue(2).ToString().Trim();
                            string[] srcarr = src.Split('\n');
                            foreach (string st in srcarr)
                            {
                                tc.Source.Add(st.Trim());
                            }

                            var con2 = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                            con2.Open();

                            if (con2.State == System.Data.ConnectionState.Open)
                            {
                                string cmd1 = SQLStatementsClass.Instance.GetFunctionsArguments(DBReg.Version, tc.Name);
                                var fcmd2 = new FbCommand(cmd1, con2);
                                var dread2 = fcmd2.ExecuteReader();

                                if (dread2 != null)
                                {
                                    if (dread2.HasRows)
                                    {
                                        while (dread2.Read())
                                        {
                                            ParameterClass pc = new ParameterClass()
                                            {
                                                Name = dread2.GetValue(0).ToString().Trim()
                                            };
                                            int InOutTyp = string.IsNullOrEmpty(dread2.GetValue(0).ToString().Trim()) ? 1 : 0; // 0 == in, 1 == out
                                            pc.Position = StaticFunctionsClass.ToIntDef(dread2.GetValue(1).ToString().Trim(), 0);
                                            pc.TypeNumber = StaticFunctionsClass.ToIntDef(dread2.GetValue(2).ToString().Trim(), 0);                                           
                                            pc.Length = StaticFunctionsClass.ToIntDef(dread2.GetValue(3).ToString().Trim(), 0);
                                            pc.Precision = StaticFunctionsClass.ToIntDef(dread2.GetValue(4).ToString().Trim(), 0);

                                            pc.Scale = StaticFunctionsClass.ToIntDef(dread2.GetValue(5).ToString().Trim(), 0);
                                            pc.FieldType = dread2.GetValue(6).ToString().Trim();

                                            pc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(pc.FieldType, pc.Length);

                                            if (InOutTyp == 0)
                                            {
                                                tc.ParameterIn.Add(pc);
                                            }
                                            else
                                            {
                                                tc.ParameterOut.Add(pc);
                                            }
                                        }
                                    }
                                    dread2.Close();
                                }

                                con2.Close();
                                functions.Add(tc.Name, tc);
                                n++;
                            }
                            else
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread2==null"));
                            }
                        }
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"GetFunctionObjects->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                    }
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread==null"));
                }

                dread.Close();
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->Connections not open"));
            }

            return functions;
        }

        public string GetBLOBData(DBRegistrationClass DBReg, string cmd)
        {                        
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {             
                con.Close();
                return string.Empty;
            }

            if (con.State != System.Data.ConnectionState.Open) return string.Empty;
            
            var fcmd = new FbCommand(cmd, con);
            var dread = fcmd.ExecuteReader();

            if ((dread == null)||(!dread.HasRows)) return string.Empty;
            byte[] data;  
            
            string result = string.Empty;
            while (dread.Read())
            {
                data = Encoding.ASCII.GetBytes(dread.GetString(0));    
                result = System.Text.Encoding.Default.GetString(data);               
            }                                
            return result;
        }

        public bool ReadPKFields(FbDataReader dread, Dictionary<string,string> FieldNames, string tableName, string pkName, string pkField)
        {
            string TableName = tableName;
            string PKField = pkField;
            string PKName = pkName;
            if (FieldNames == null)
            {
                FieldNames = new Dictionary<string, string>();
            }
            
            while ((TableName == tableName) && (PKField == pkField) && (PKName == pkName))
            {
                FieldNames.Add(PKField,PKField);
                if (dread.Read() )
                {                                        
                    TableName   = dread.GetValue(0).ToString().Trim();
                    PKField     = dread.GetValue(3).ToString().Trim();
                    PKName      = dread.GetValue(1).ToString().Trim();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        
        public void GetAllTablePrimaryKeyObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {
            string _funcStr = $@"GetAllTablePrimaryKeyObjects(DBReg={DBReg},TableClass={tc})";
            string fields_cmd = SQLStatementsClass.Instance.GetAllTablePrimaryKeys(DBReg.Version);
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                try
                {
                    con.Open();
                    var fcmd = new FbCommand(fields_cmd, con);
                    var dread = fcmd.ExecuteReader();
                    
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        string NewTableName = string.Empty;

                        string OldPKName = string.Empty;
                        string PKName = string.Empty;
                        string OldPKField = string.Empty;
                        string PKField = string.Empty;
                        TableClass tcc = null;
                        PrimaryKeyClass tfc = null; 

                        if(dread.Read())
                        {
                            NewTableName    = dread.GetValue(0).ToString().Trim();
                            PKField         = dread.GetValue(3).ToString().Trim();
                            PKName          = dread.GetValue(1).ToString().Trim();
                            
                            while(TableName != NewTableName)
                            {
                                TableName = NewTableName;
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }

                                tfc = new PrimaryKeyClass
                                {
                                    Name = PKName.Trim()
                                };

                                if (ReadPKFields(dread, tfc.FieldNames, TableName, PKName, PKField))
                                {

                                    tcc.primary_constraint = tfc;

                                    NewTableName    = dread.GetValue(0).ToString().Trim();
                                    PKField         = dread.GetValue(3).ToString().Trim();
                                    PKName          = dread.GetValue(1).ToString().Trim();
                                }
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                         
                }
                finally
                {
                    con.Close();
                }                        
        }
           
        public void AddForeignKeyObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {
            string _funcStr = $@"AddForeignKeyObjects_To_ListOfTableObjects(DBReg={DBReg},TableClass={tc})";
            string fields_cmd = SQLStatementsClass.Instance.GetAllTableForeignKeys(DBReg.Version,eTableType.withoutsystem);            
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {                    
                    string oldTableName    = string.Empty;                    
                    TableClass tableObject = null;
                    while (dread.Read())
                    {
                        string TableName                   = dread.GetValue(0).ToString().Trim();
                        int inactive                       = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 1);
                        string gFKName                     = dread.GetValue(2).ToString().Trim();
                        string FieldName                   = dread.GetValue(4).ToString().Trim();
                        string Description                 = dread.GetValue(5).ToString().Trim();
                        string ForeignKeyName              = dread.GetValue(7).ToString().Trim();
                        string MatchOption                 = dread.GetValue(8).ToString().Trim();
                        string UpdateRule                  = dread.GetValue(9).ToString().Trim();
                        string DeleteRule                  = dread.GetValue(10).ToString().Trim();
                        string DestTableName               = dread.GetValue(11).ToString().Trim();
                        string DestConstraintName          = dread.GetValue(12).ToString().Trim();
                        string DestConstraintTyp           = dread.GetValue(13).ToString().Trim();
                        string DestConstraintFieldName     = dread.GetValue(14).ToString().Trim();

                        if (oldTableName != TableName)
                        {
                            tableObject = tc.FirstOrDefault(x => x.Value.Name == TableName).Value;
                            if(tableObject == null)  continue;                            
                            if (tableObject.ForeignKeys == null) tableObject.ForeignKeys = new Dictionary<string, ForeignKeyClass>();                            
                            oldTableName = TableName;
                        }

                        var tfc = new ForeignKeyClass
                        {
                            Name = gFKName,
                            SourceTableName = TableName,
                            DestTableName = DestTableName
                        };
                        tfc.IsActive = inactive == 0;
                        tfc.SourceFields.Add(FieldName,new FieldClass(FieldName));
                        tfc.DestFields.Add(DestConstraintFieldName,new FieldClass(DestConstraintFieldName));                        
                        tableObject?.ForeignKeys.Add(tfc.Name,tfc);                        
                    }
                }                
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
            }
            finally
            {
                con.Close();
            }
        }

        public void AddForeignKeyObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc)
        {
            string _funcStr = $@"AddForeignKeyObjects_To_ListOfTableObjects(DBReg={DBReg},TableClass={tc})";
            string fields_cmd = SQLStatementsClass.Instance.GetAllTableForeignKeys(DBReg.Version,eTableType.system);            
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {                    
                    string oldTableName    = string.Empty;                    
                    TableClass tableObject = null;
                    while (dread.Read())
                    {
                        string TableName                   = dread.GetValue(0).ToString().Trim();
                        int inactive                       = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 1);
                        string FKName                      = dread.GetValue(2).ToString().Trim();
                        string FieldName                   = dread.GetValue(4).ToString().Trim();
                        string Description                 = dread.GetValue(5).ToString().Trim();
                        string ForeignKeyName              = dread.GetValue(7).ToString().Trim();
                        string MatchOption                 = dread.GetValue(8).ToString().Trim();
                        string UpdateRule                  = dread.GetValue(9).ToString().Trim();
                        string DeleteRule                  = dread.GetValue(10).ToString().Trim();
                        string DestTableName               = dread.GetValue(11).ToString().Trim();
                        string DestConstraintName          = dread.GetValue(12).ToString().Trim();
                        string DestConstraintTyp           = dread.GetValue(13).ToString().Trim();
                        string DestConstraintFieldName     = dread.GetValue(14).ToString().Trim();

                        if (oldTableName != TableName)
                        {
                            tableObject = tc.FirstOrDefault(x => x.Value.Name == TableName).Value;
                            if(tableObject == null)  continue;                            
                            if (tableObject.ForeignKeys == null) tableObject.ForeignKeys = new Dictionary<string, ForeignKeyClass>();
                            oldTableName = TableName;
                        }

                        var tfc = new ForeignKeyClass
                        {
                            Name = FKName,
                            SourceTableName = TableName,
                            DestTableName = DestTableName
                        };
                        tfc.IsActive = inactive == 0;
                        tfc.SourceFields.Add(FieldName,new FieldClass(FieldName));
                        tfc.DestFields.Add(DestConstraintFieldName,new FieldClass(DestConstraintFieldName));
                        tableObject?.ForeignKeys.Add(tfc.Name,tfc);
                    }
                }                
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
            }
            finally
            {
                con.Close();
            }
        }

        public void AddTriggerObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {
            string _funcStr = $@"AddTriggerObjects_To_ListOfTableObjects(DBReg={DBReg},TableClass={tc})";
            string fields_cmd = SQLStatementsClass.Instance.GetAllTableTriggersNonSystemTables(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    string oldTableName = string.Empty;
                    string TableName = string.Empty;
                    TableClass tcc = null;
                    while (dread.Read())
                    {
                        TableName = dread.GetValue(0).ToString().Trim();

                        if (oldTableName != TableName)
                        {
                            tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                            if (tcc == null)
                            {
                                continue;
                            }
                            if (tcc.Triggers == null)
                            {
                                tcc.Triggers = new Dictionary<string, TriggerClass>();
                            }
                            oldTableName = TableName;
                        }

                        var tfc = new TriggerClass
                        {
                            RelationName    = dread.GetValue(0).ToString().Trim(),
                            Name            = dread.GetValue(1).ToString().Trim(),
                            Active          = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 1) == 0,
                            Type            = (eTriggerType) StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0),
                            Sequence        = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0),
                            Source          = dread.GetValue(6).ToString().Trim()
                        };
                        if(tcc != null)
                        {
                            if (!tcc.Triggers.ContainsKey(tfc.Name))
                               tcc.Triggers.Add(tfc.Name,tfc);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                         
            }
            finally
            {
                con.Close();
            }
        }
        public Dictionary<string,TriggerClass> GetAllTriggerObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetAllTriggerObjects(DBReg={DBReg})";
            string fields_cmd = SQLStatementsClass.Instance.GetAllTableTriggersNonSystemTables(DBReg.Version);                   
            var triggers = new Dictionary<string, TriggerClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {                        
                    while (dread.Read())
                    {                                                        
                        var tfc = new TriggerClass
                        {
                            RelationName    = dread.GetValue(0).ToString().Trim(),
                            Name            = dread.GetValue(1).ToString().Trim(),
                            Active          = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 1) == 0,
                            Type            = (eTriggerType) StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0),
                            Sequence        = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0),
                            Source          = dread.GetValue(6).ToString().Trim()
                        };
                        triggers.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
            }
            finally
            {
                con.Close();
            }
            return triggers;
        }
        
        public void AddTriggerObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc)
        {
            string _funcStr = $@"AddTriggerObjects_To_ListOfSystemTableObjects(DBReg={DBReg},tc={tc})";
            string fields_cmd = SQLStatementsClass.Instance.GetAllTableTriggersSystemTables(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    string oldTableName = string.Empty;
                    string TableName = string.Empty;
                    TableClass tcc = null;
                    while (dread.Read())
                    {
                        TableName = dread.GetValue(0).ToString().Trim();

                        if (oldTableName != TableName)
                        {
                            tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                            if (tcc == null)
                            {
                                continue;
                            }
                            if (tcc.Triggers == null)
                            {
                                tcc.Triggers = new Dictionary<string, TriggerClass>();
                            }
                            oldTableName = TableName;
                        }

                        var tfc = new TriggerClass
                        {
                            RelationName = dread.GetValue(0).ToString().Trim(),
                            Name = dread.GetValue(1).ToString().Trim(),
                            Sequence = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0),
                            Source = dread.GetValue(6).ToString().Trim()
                        };
                        if(tcc != null)
                        { 
                            if (!tcc.Triggers.ContainsKey(tfc.Name))
                                tcc.Triggers.Add(tfc.Name,tfc);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
            }
            finally
            {
                con.Close();
            }
        }
        
        public void AddConstraintsObjects_To_ListOfTableObjects(eConstraintType ctyp, Dictionary<string,TableClass> tc, DBRegistrationClass DBReg, eTableType tabletype)
        {
            string _funcStr = $@"AddConstraintsObjects_To_ListOfTableObjects(ctyp={ctyp},tc={tc},DBReg={DBReg},tabletype={tabletype})";
            string cmd = string.Empty; 

            switch (tabletype)
            {
                case eTableType.withoutsystem:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableConstraintsByTypeNonSystemTables(DBReg.Version, ctyp);
                    break;
                }
                case eTableType.system:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableConstraintsByTypeSystemTables(DBReg.Version, ctyp);
                    break;
                }
            }

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(2).ToString().Trim();

                            if (oldTableName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->TableNotFound->",TableName));
                                    continue;
                                }
                                if ((ctyp == eConstraintType.UNIQUE)&&(tcc.uniques_constraints==null))
                                {
                                    tcc.uniques_constraints = new Dictionary<string, UniquesClass>();
                                }
                                                                
                                if ((ctyp == eConstraintType.NOTNULL)&& (tcc.notnulls_constraints==null))
                                {
                                    tcc.notnulls_constraints = new Dictionary<string, NotNullsClass>();
                                }
                                oldTableName = TableName;
                            }

                            if (tcc == null) continue;
                                                        
                            if (ctyp == eConstraintType.PRIMARYKEY)
                            {                                                                    
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.PrimaryKeyStr) as PrimaryKeyClass;
                               
                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(11).ToString().Trim();
                                string fieldpos     = dread.GetValue(12).ToString().Trim();
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();

                                tcs.FieldNames.Add(fieldname, fieldname);
                                if (ctyp == eConstraintType.PRIMARYKEY)
                                {
                                    tcc.primary_constraint = tcs;
                                }
                            }
                            else if (ctyp == eConstraintType.UNIQUE)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.UniquesKeyStr) as UniquesClass;
                                
                                tcs.Name                = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType      = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName           = dread.GetValue(5).ToString().Trim();
                                string fieldname        = dread.GetValue(11).ToString().Trim();
                                string fieldpos         = dread.GetValue(12).ToString().Trim();
                                tcs.TableName           = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if ((ctyp == eConstraintType.UNIQUE)&&(!tcc.uniques_constraints.ContainsKey(tcs.Name)))
                                {
                                    try
                                    {
                                        tcc.uniques_constraints.Add(tcs.Name,tcs);
                                    }
                                    catch (Exception ex)
                                    {
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->uniques_constraints.Add", ex));
                                    }
                                }
                            }
                            else if (ctyp == eConstraintType.NOTNULL)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.NotNullKeyStr) as NotNullsClass;
 
                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(6).ToString().Trim(); //trigger name
                                string fieldpos     = dread.GetValue(12).ToString().Trim();
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if ((ctyp == eConstraintType.NOTNULL)&&(!tcc.notnulls_constraints.ContainsKey(tcs.Name)))
                                {
                                    try
                                    {
                                      tcc.notnulls_constraints.Add(tcs.Name,tcs);
                                    }
                                    catch (Exception ex)
                                    {
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->notnulls_constraints.Add", ex));
                                    }
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public bool GetConstraintsObjectsForTable(eConstraintType ctyp, TableClass tc, DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetConstraintsObjectsForTable(ctyp={ctyp},TableClass={tc},DBReg={DBReg})";
            string ctyp_string = EnumHelper.GetDescription(ctyp);
            string cmd = ConstraintsSQLStatementsClass.Instance.GetTableConstraintsByType(DBReg.Version, ctyp_string, tc.Name);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            bool ok = false;
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                con.Close();
                return false;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            string TableName = dread.GetValue(2).ToString().Trim();

                            if (oldTableName != TableName)
                            {
                                tcc = tc;
                                if (tcc == null)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->TableNotFound->{TableName}", TableName));
                                    continue;
                                }
                                if ((ctyp == eConstraintType.UNIQUE) && (tcc.uniques_constraints == null))
                                {
                                    tcc.uniques_constraints = new Dictionary<string, UniquesClass>();
                                }

                                if ((ctyp == eConstraintType.NOTNULL) && (tcc.notnulls_constraints == null))
                                {
                                    tcc.notnulls_constraints = new Dictionary<string, NotNullsClass>();
                                }
                                oldTableName = TableName;
                            }

                            if (tcc == null) continue;

                            if (ctyp == eConstraintType.PRIMARYKEY)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.PrimaryKeyStr) as PrimaryKeyClass;

                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(11).ToString().Trim();                                
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if (ctyp == eConstraintType.PRIMARYKEY)
                                {
                                    tcc.primary_constraint = tcs;
                                }
                            }
                            else if (ctyp == eConstraintType.UNIQUE)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.UniquesKeyStr) as UniquesClass;

                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(11).ToString().Trim();
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();

                                tcs.FieldNames.Add(fieldname, fieldname);

                                if ((ctyp == eConstraintType.UNIQUE) && (!tcc.uniques_constraints.ContainsKey(tcs.Name)))
                                {
                                    try
                                    {
                                        tcc.uniques_constraints.Add(tcs.Name, tcs);
                                    }
                                    catch (Exception ex)
                                    {
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->uniques_constraints.Add", ex));
                                    }
                                }
                            }
                            else if (ctyp == eConstraintType.NOTNULL)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.NotNullKeyStr) as NotNullsClass;

                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(6).ToString().Trim(); //trigger name
                                string fieldpos     = dread.GetValue(12).ToString().Trim();
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();

                                tcs.FieldNames.Add(fieldname, fieldname);
                                if ((ctyp == eConstraintType.NOTNULL) && (!tcc.notnulls_constraints.ContainsKey(tcs.Name)))
                                {
                                    try
                                    {
                                        tcc.notnulls_constraints.Add(tcs.Name, tcs);
                                    }
                                    catch (Exception ex)
                                    {
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->notnulls_constraints.Add", ex));
                                    }
                                }
                            }
                            ok = true;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
            return ok;
        }

        public void GetSystemTableConstraintsObjects(eConstraintType ctyp, Dictionary<string,SystemTableClass> tc, DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetSystemTableConstraintsObjects(ctyp={ctyp},tc={tc},DBReg={DBReg})";
            string cmd = ConstraintsSQLStatementsClass.Instance.GetSystemTableConstraintsByType(DBReg.Version, ctyp);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        SystemTableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(2).ToString().Trim();

                            if (oldTableName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                if ((ctyp == eConstraintType.UNIQUE) && (tcc.uniques_constraints == null))
                                {
                                    tcc.uniques_constraints = new Dictionary<string, UniquesClass>();
                                }                                
                                if ((ctyp == eConstraintType.NOTNULL) && (tcc.notnulls_constraints == null))
                                {
                                    tcc.notnulls_constraints = new Dictionary<string, NotNullsClass>();
                                }
                                oldTableName = TableName;
                            }

                            if (ctyp == eConstraintType.PRIMARYKEY)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.PrimaryKeyStr) as PrimaryKeyClass;
                                
                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(11).ToString().Trim();
                                string fieldpos     = dread.GetValue(12).ToString().Trim();                                
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if (ctyp == eConstraintType.PRIMARYKEY)
                                {
                                    tcc.primary_constraint = tcs;
                                }
                              
                            }
                            else if (ctyp == eConstraintType.NOTNULL)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.NotNullKeyStr) as NotNullsClass;
                                
                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(11).ToString().Trim();
                                string fieldpos     = dread.GetValue(12).ToString().Trim();
                                tcs.TableName       = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if (!tcc.notnulls_constraints.ContainsKey(tcs.Name)) tcc.notnulls_constraints.Add(tcs.Name,tcs);        
                            }
                            else if (ctyp == eConstraintType.UNIQUE)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.UniquesKeyStr) as UniquesClass;
                                
                                tcs.Name            = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType  = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName       = dread.GetValue(5).ToString().Trim();
                                string fieldname    = dread.GetValue(11).ToString().Trim();
                                string fieldpos     = dread.GetValue(12).ToString().Trim();                                
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if (!tcc.uniques_constraints.ContainsKey(tcs.Name)) tcc.uniques_constraints.Add(tcs.Name,tcs);                                
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }
        
        public void AddCheckConstraintsObjects_To_ListOfTableObjects(Dictionary<string,TableClass> tc,DBRegistrationClass DBReg, eTableType tabletype)
        {
            string _funcStr = $@"AddCheckConstraintsObjects_To_ListOfTableObjects(tc={tc},DBReg={DBReg},tabletype={tabletype})";
            string cmd = string.Empty;
            switch (tabletype)
            {
                case eTableType.withoutsystem:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableCheckConstraintsNonSystem(DBReg.Version);
                    break;
                }
                case eTableType.system:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableCheckConstraintsSystem(DBReg.Version);
                    break;
                }
            }
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(2).ToString().Trim();

                            if (oldTableName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }

                                if (tcc.check_constraints == null)
                                {
                                    tcc.check_constraints = new Dictionary<string, ConstraintsClass>();
                                }
                                oldTableName = TableName;
                            }
                            var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.ConstraintsKeyStr) as ConstraintsClass;
                            tcs.Name            = dread.GetValue(0).ToString().Trim();
                            tcs.ConstraintType  = eConstraintType.CHECK;
                            tcs.TriggerName     = dread.GetValue(6).ToString().Trim();
                            tcs.TableName       = TableName;
                            tcs.Source          = dread.GetValue(7).ToString().Trim();
                            try
                            {
                                if(tcc.check_constraints.ContainsKey(tcs.Name)) tcc.check_constraints.Add(tcs.Name,tcs);
                            }
                            catch(Exception ex)
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->check_constraints.Add", ex));         
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();

            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
            
        }
        public void AddCheckConstraintsObjects_To_ListOfSystemTableObjects(Dictionary<string,SystemTableClass> tc,DBRegistrationClass DBReg, eTableType tabletype)
        {
            string _funcStr = $@"AddCheckConstraintsObjects_To_ListOfSystemTableObjects(tc={tc},DBReg={DBReg},tabletype={tabletype})";
            string cmd = string.Empty;
            switch (tabletype)
            {
                case eTableType.withoutsystem:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableCheckConstraintsNonSystem(DBReg.Version);
                    break;
                }
                case eTableType.system:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance.GetAllTableCheckConstraintsSystem(DBReg.Version);
                    break;
                }
            }
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                     
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        SystemTableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(2).ToString().Trim();

                            if (oldTableName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }

                                if (tcc.check_constraints == null)
                                {
                                    tcc.check_constraints = new Dictionary<string, ConstraintsClass>();
                                }
                                oldTableName = TableName;
                            }
                            var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.ConstraintsKeyStr) as ConstraintsClass;
                            tcs.Name            = dread.GetValue(0).ToString().Trim();
                            tcs.ConstraintType  = eConstraintType.CHECK;                            
                            tcs.TriggerName     = dread.GetValue(6).ToString().Trim();                            
                            tcs.TableName       = TableName;
                            tcs.Source          = dread.GetValue(7).ToString().Trim();
                            try
                            {
                                if(tcc.check_constraints.ContainsKey(tcs.Name)) tcc.check_constraints.Add(tcs.Name,tcs);
                            }
                            catch(Exception ex)
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->check_constraints.Add", ex));         
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();

            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void AddDependenciesTOObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc, eDependencies typ)
        {
            string _funcStr = $@"AddDependenciesTOObjects_To_ListOfTableObjects(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->con.Open()", ex));     
                
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName           = dread.GetValue(1).ToString().Trim();
                            DependObjectName    = dread.GetValue(0).ToString().Trim();
                            FieldName           = dread.GetValue(2).ToString().Trim();
                            eDependencies deptyp = (eDependencies) StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(),(int) eDependencies.NONE);

                            if (oldName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldName = TableName;
                            }

                            if (tcc != null)
                            {
                                if ((tcc.DependenciesTO_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesTO_Tables = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesTO_Triggers = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesTO_Views = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesTO_Procedures = new Dictionary<string, DependencyClass>();
                                }

                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;

                                tcs.Type   = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);
                                try
                                {
                                    if ((deptyp == eDependencies.TABLE)&&(!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Tables.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Triggers.Add(tcs.Name,tcs);
                                    }

                                    if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesTO_Views.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Views.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Views.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesTO_Procedures.ContainsKey(tcs.Name)))
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                            tcc.DependenciesTO_Procedures.Add(key,tcs);
                                        else
                                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}"));  
                                    }
                                }
                                catch(Exception ex)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}", ex));  
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void AddDependenciesOfTablesToAnyObjects(DBRegistrationClass DBReg, Dictionary<string, TableClass> tc, eDependencies typ)
        {
            string _funcStr = $@"AddDependenciesTOObjects_To_ListOfTableObjects(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesOfAnyObjectTOObjects(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->con.Open()", ex));

                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(1).ToString().Trim();
                            DependObjectName = dread.GetValue(0).ToString().Trim();
                            FieldName = dread.GetValue(2).ToString().Trim();
                            eDependencies deptyp = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);

                            if (oldName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldName = TableName;
                            }

                            if (tcc != null)
                            {
                                if ((tcc.DependenciesTO_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesTO_Tables = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesTO_Triggers = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesTO_Views = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesTO_Procedures = new Dictionary<string, DependencyClass>();
                                }

                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;

                                tcs.Type = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);
                                try
                                {
                                    if ((deptyp == eDependencies.TABLE))// && (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Tables.Add(tcs.Name, tcs);
                                    }
                                    if ((deptyp == eDependencies.TRIGGER))// && (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Triggers.Add(tcs.Name, tcs);
                                    }

                                    if ((deptyp == eDependencies.VIEW)) // && (!tcc.DependenciesTO_Views.ContainsKey(tcs.Name)))
                                    {
                                        string nm = $@"{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Views.ContainsKey(nm))
                                            tcc.DependenciesTO_Views.Add(nm, tcs);
                                    }
                                    if ((deptyp == eDependencies.PROCEDURE))// && (!tcc.DependenciesTO_Procedures.ContainsKey(tcs.Name)))
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                            tcc.DependenciesTO_Procedures.Add(key, tcs);
                                        else
                                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}"));
                                    }
                                }
                                catch (Exception ex)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}", ex));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void AddDependenciesOfSystemTablesToAnyObjects(DBRegistrationClass DBReg, Dictionary<string, SystemTableClass> tc, eDependencies typ)
        {
            string _funcStr = $@"AddDependenciesTOObjects_To_ListOfTableObjects(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesOfAnyObjectTOObjects(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->con.Open()", ex));

                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(1).ToString().Trim();
                            DependObjectName = dread.GetValue(0).ToString().Trim();
                            FieldName = dread.GetValue(2).ToString().Trim();
                            eDependencies deptyp = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);

                            if (oldName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldName = TableName;
                            }

                            if (tcc != null)
                            {
                                if ((tcc.DependenciesTO_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesTO_Tables = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesTO_Triggers = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesTO_Views = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesTO_Procedures = new Dictionary<string, DependencyClass>();
                                }

                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;

                                tcs.Type = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);
                                try
                                {
                                    if ((deptyp == eDependencies.TABLE) && (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Tables.Add(tcs.Name, tcs);
                                    }
                                    if ((deptyp == eDependencies.TRIGGER) && (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Triggers.Add(tcs.Name, tcs);
                                    }

                                    if ((deptyp == eDependencies.VIEW)) // && (!tcc.DependenciesTO_Views.ContainsKey(tcs.Name)))
                                    {
                                        string nm = $@"{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Views.ContainsKey(nm))
                                            tcc.DependenciesTO_Views.Add(nm, tcs);
                                    }
                                    if ((deptyp == eDependencies.PROCEDURE))// && (!tcc.DependenciesTO_Procedures.ContainsKey(tcs.Name)))
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                            tcc.DependenciesTO_Procedures.Add(key, tcs);
                                        else
                                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}"));
                                    }
                                }
                                catch (Exception ex)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}", ex));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void AddDependenciesTOObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc, eDependencies typ)
        {
            string _funcStr = $@"AddDependenciesTOObjects_To_ListOfSystemTableObjects(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->con.Open()", ex));     
                
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        SystemTableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName           = dread.GetValue(1).ToString().Trim();
                            DependObjectName    = dread.GetValue(0).ToString().Trim();
                            FieldName           = dread.GetValue(2).ToString().Trim();
                            eDependencies deptyp = (eDependencies) StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(),(int) eDependencies.NONE);

                            if (oldName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldName = TableName;
                            }

                            if (tcc != null)
                            {
                                if ((tcc.DependenciesTO_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesTO_Tables = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesTO_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesTO_Triggers = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesTO_Views = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesTO_Procedures = new Dictionary<string, DependencyClass>();
                                }

                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;

                                tcs.Type   = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);
                                try
                                {
                                    if ((deptyp == eDependencies.TABLE)&&(!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Tables.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Triggers.Add(tcs.Name,tcs);
                                    }

                                    if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesTO_Views.ContainsKey(tcs.Name)))
                                    {
                                        if (!tcc.DependenciesTO_Views.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Views.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesTO_Procedures.ContainsKey(tcs.Name)))
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                          tcc.DependenciesTO_Procedures.Add(key,tcs);
                                       else NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}", ""));  
                                    }
                                }
                                catch(Exception ex)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}", ex));  
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void GetAllDependenciesOn(DBRegistrationClass DBReg, Dictionary<string,ViewClass> tc, eDependencies typ)
        {
            string _funcStr = $@"GetAllDependenciesOn(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->con.Open()", ex));
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        ViewClass tcc = null;
                        while (dread.Read())
                        {
                            TableName        = dread.GetValue(1).ToString().Trim();
                            DependObjectName = dread.GetValue(0).ToString().Trim();
                            FieldName        = dread.GetValue(2).ToString().Trim();
                           
                            var deptyp = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);

                            if (oldTableName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldTableName = TableName;
                            }

                            if (tcc != null)
                            {
                                if ((tcc.DependenciesTO_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesTO_Tables = new Dictionary<string,DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesTO_Triggers = new Dictionary<string,DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesTO_Views = new Dictionary<string,DependencyClass>();
                                }

                                if ((tcc.DependenciesTO_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesTO_Procedures = new Dictionary<string,DependencyClass>();
                                }

                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name         = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName    = FieldName;
                                tcs.Type   = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);
                                try
                                {
                                    if (deptyp == eDependencies.TABLE)
                                    {
                                        if (!tcc.DependenciesTO_Tables.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Tables.Add(tcs.Name,tcs);
                                    }

                                    if (deptyp == eDependencies.TRIGGER)
                                    {
                                        if (!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Triggers.Add(tcs.Name,tcs);
                                    }

                                    if (deptyp == eDependencies.VIEW)
                                    {
                                        if (!tcc.DependenciesTO_Views.ContainsKey(tcs.Name))
                                            tcc.DependenciesTO_Views.Add(tcs.Name,tcs);
                                    }

                                    if (deptyp == eDependencies.PROCEDURE)
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                          tcc.DependenciesTO_Procedures.Add(key, tcs);
                                        else
                                          NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}->{key} already exists",""));  
                                    }
                                }
                                catch(Exception ex)
                                {
                                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}", ex));  
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Connection not open"));
            }
        }
        
        public void AddDependenciesFROMObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc, eDependencies typ)
        {
            string _funcStr = $@"AddDependenciesFROMObjects_To_ListOfTableObjects(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesFROM(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                                     
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldDependObjectName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        TableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(1).ToString().Trim();
                            DependObjectName = dread.GetValue(0).ToString().Trim();
                            FieldName = dread.GetValue(2).ToString().Trim();
                            var deptyp = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);


                            if (oldDependObjectName != DependObjectName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldDependObjectName = DependObjectName;
                            }
                            if (tcc != null)
                            {
                                if ((tcc.DependenciesFROM_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesFROM_Tables = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesFROM_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesFROM_Triggers = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesFROM_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesFROM_Views = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesFROM_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesFROM_Procedures = new Dictionary<string, DependencyClass>();
                                }


                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;

                                tcs.Type   = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);

                                if ((deptyp == eDependencies.TABLE)&&(!tcc.DependenciesFROM_Tables.ContainsKey(tcs.Name)))
                                {
                                    if (!tcc.DependenciesFROM_Tables.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Tables.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name)))
                                {
                                    if (!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }

                                if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name)))
                                {
                                    if (!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Views.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesFROM_Procedures.ContainsKey(tcs.Name)))
                                {
                                    string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                    if (!tcc.DependenciesFROM_Procedures.ContainsKey(key))
                                       tcc.DependenciesFROM_Procedures.Add(key,tcs);
                                     else
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void AddDepednenciesFROMObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc, eDependencies typ)
        {
            string _funcStr = $@"AddDepednenciesFROMObjects_To_ListOfSystemTableObjects(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesFROM(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                                     
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldDependObjectName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        SystemTableClass tcc = null;
                        while (dread.Read())
                        {
                            TableName           = dread.GetValue(1).ToString().Trim();
                            DependObjectName    = dread.GetValue(0).ToString().Trim();
                            FieldName           = dread.GetValue(2).ToString().Trim();
                            var deptyp          = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);


                            if (oldDependObjectName != DependObjectName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldDependObjectName = DependObjectName;
                            }
                            if (tcc != null)
                            {
                                if ((tcc.DependenciesFROM_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesFROM_Tables = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesFROM_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesFROM_Triggers = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesFROM_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesFROM_Views = new Dictionary<string, DependencyClass>();
                                }


                                if ((tcc.DependenciesFROM_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesFROM_Procedures = new Dictionary<string, DependencyClass>();
                                }


                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;

                                tcs.Type = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);

                                if ((deptyp == eDependencies.TABLE)&&(!tcc.DependenciesFROM_Tables.ContainsKey(tcs.Name)))
                                {
                                    if (!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name)))
                                {
                                    if (!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }

                                if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name)))
                                {
                                    if (!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Views.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesFROM_Procedures.ContainsKey(tcs.Name)))
                                {
                                    string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                    if (!tcc.DependenciesFROM_Procedures.ContainsKey(key))
                                        tcc.DependenciesFROM_Procedures.Add(key,tcs);
                                    else
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void GetAllDepednenciesFROM(DBRegistrationClass DBReg, Dictionary<string,ViewClass> tc, eDependencies typ)
        {
            string _funcStr = $@"GetAllDepednenciesFROM(DBReg={DBReg},tc={tc},typ={typ})";
            string cmd = SQLStatementsClass.Instance.GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->con.Open()", ex));                                                     
                con.Close();
                return;
            }

            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string oldTableName = string.Empty;
                        string TableName = string.Empty;
                        string DependObjectName = string.Empty;
                        string FieldName = string.Empty;
                        ViewClass tcc = null;
                        while (dread.Read())
                        {
                            TableName = dread.GetValue(1).ToString().Trim();
                            DependObjectName = dread.GetValue(0).ToString().Trim();
                            FieldName = dread.GetValue(2).ToString().Trim();

                            var deptyp = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);

                            if (oldTableName != TableName)
                            {
                                tcc = tc.FirstOrDefault(X => X.Value.Name == TableName).Value;
                                if (tcc == null)
                                {
                                    continue;
                                }
                                oldTableName = TableName;
                            }

                            if (tcc != null)
                            {
                                if ((tcc.DependenciesFROM_Tables == null) && (deptyp == eDependencies.TABLE))
                                {
                                    tcc.DependenciesFROM_Tables = new Dictionary<string, DependencyClass>();
                                }

                                if ((tcc.DependenciesFROM_Triggers == null) && (deptyp == eDependencies.TRIGGER))
                                {
                                    tcc.DependenciesFROM_Triggers = new Dictionary<string,DependencyClass>();
                                }

                                if ((tcc.DependenciesFROM_Views == null) && (deptyp == eDependencies.VIEW))
                                {
                                    tcc.DependenciesFROM_Views = new Dictionary<string,DependencyClass>();
                                }

                                if ((tcc.DependenciesFROM_Procedures == null) && (deptyp == eDependencies.PROCEDURE))
                                {
                                    tcc.DependenciesFROM_Procedures = new Dictionary<string,DependencyClass>();
                                }

                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.DependenciesKeyStr) as DependencyClass;
                                tcs.Name = TableName;
                                tcs.DependOnName = DependObjectName;
                                tcs.FieldName = FieldName;
                                tcs.Type = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);

                                if (deptyp == eDependencies.TABLE)
                                {
                                    if (!tcc.DependenciesFROM_Tables.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Tables.Add(tcs.Name,tcs);
                                }

                                if (deptyp == eDependencies.TRIGGER)
                                {
                                    if (!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }

                                if (deptyp == eDependencies.VIEW)
                                {
                                    if (!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name))
                                        tcc.DependenciesFROM_Views.Add(tcs.Name,tcs);
                                }                                
                                if (deptyp == eDependencies.PROCEDURE)
                                {
                                    string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                    if (!tcc.DependenciesFROM_Procedures.ContainsKey(key))
                                        tcc.DependenciesFROM_Procedures.Add(key, tcs);
                                    else
                                        NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->Dependencies.Add->{deptyp}->{key} already exists", ""));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public Dictionary<string,ViewFieldClass> GetViewFieldObjects(DBRegistrationClass DBReg, string ViewName)
        {
            string _funcStr = $@"GetViewFieldObjects(DBReg={DBReg},ViewName={ViewName})";
            var fields = new Dictionary<string,ViewFieldClass>();
            if (!string.IsNullOrEmpty(ViewName))
            {
                string cmd = SQLStatementsClass.Instance.GetViewFields(DBReg.Version, ViewName);                
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                try
                {                    
                    con.Open();
                    var fcmd = new FbCommand(cmd, con);
                    var dread = fcmd.ExecuteReader();
                    if (dread.HasRows)
                    {
                        while (dread.Read())
                        {
                            object ob = dread.GetValue(0);
                            object obFieldPosition = dread.GetValue(1);

                            string fieldstr = ob.ToString().Trim();
                            string posstr = obFieldPosition.ToString();
                            int pos = StaticFunctionsClass.ToIntDef(posstr, -1);
                            string typename = dread.GetValue(3).ToString().Trim();
                            string typelength = dread.GetValue(4).ToString().Trim();
                            int length = StaticFunctionsClass.ToIntDef(typelength, 0);
                            var vf = new ViewFieldClass
                            {
                                Name = fieldstr,
                                Position = pos,
                                Domain = new DomainClass
                                {
                                    Length = length,
                                    FieldType = typename,
                                    RawType = TypeConvert.GetRawType(typename, length)
                                }

                            };                                                           
                            fields.Add(vf.Name,vf);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                }
                finally
                {
                    con.Close();
                }
            }
            return fields;
        }

        public void FillViewObject(DBRegistrationClass DBReg, ViewClass View)
        {
            string _funcStr = $@"FillViewObject(DBReg={DBReg},View={View})";
            var fields = new List<ViewFieldClass>();
            View.Fields.Clear();
            if (!string.IsNullOrEmpty(View.Name))
            {
                string cmd = SQLStatementsClass.Instance.GetViewFields(DBReg.Version,View.Name);
               
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                try
                {
                    con.Open();
                    var fcmd = new FbCommand(cmd, con);
                    var dread = fcmd.ExecuteReader();
                    bool first = true;
                    if (dread.HasRows)
                    {
                        while (dread.Read())
                        {
                            object ob                   = dread.GetValue(0);
                            object ob_field_position    = dread.GetValue(1);
                            string posstr               = ob_field_position.ToString().Trim();
                            string typename             = dread.GetValue(3).ToString().Trim();
                            string typelength           = dread.GetValue(4).ToString().Trim();

                            string fieldstr = ob.ToString().Trim();
                            int length = StaticFunctionsClass.ToIntDef(typelength, 0);
                            int pos = StaticFunctionsClass.ToIntDef(posstr, -1);
                            var vf = new ViewFieldClass()
                            {
                                Name = fieldstr,
                                Position = pos,
                                Domain = new DomainClass
                                {
                                    Length = StaticFunctionsClass.ToIntDef(typelength, 0),
                                    FieldType = typename,
                                    RawType = TypeConvert.GetRawType(typename,length),
                                }
                            };
                                                       
                            fields.Add(vf);

                            if(first)
                            {
                                View.SQL = "";
                            }
                            View.Fields.Add(vf.Name,vf);
                            first = false;
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));                                                                         
                }
                finally
                {
                    con.Close();
                }
            }            
        }
        
        public ViewClass GetViewObject(DBRegistrationClass DBReg, string viewname)
        {
            string _funcStr = $@"GetViewObject(DBReg={DBReg},viewname={viewname})";
            var new_view = new ViewClass();

            string cmd = SQLStatementsClass.Instance.RefreshView(DBReg.Version,viewname);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                con.Close();
                return null;
            }
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        string view_name = "";
                        string view_name_old = "";
                        string voldsql = "";

                        var strl = new StringBuilder();
                        var strli = new StringBuilder();

                        while (dread.Read())
                        {
                            object ob_viewname = dread.GetValue(0);
                            object ob_sql = dread.GetValue(1);
                            object ob_fieldname = dread.GetValue(2);
                            view_name = ob_viewname.ToString().Trim();

                            if (view_name != view_name_old)
                            {
                                //Neuer View
                                var vc = DataClassFactory.GetDataClass(StaticVariablesClass.ViewsKeyStr) as ViewClass;

                                if (strli.Length > 0)
                                {
                                    vc.Name = view_name_old;
                                    strli.AppendLine("");
                                    strli.AppendLine(") ");
                                    strli.Append("AS ");
                                    strli.AppendLine(voldsql);
                                    vc.CREATE_SQL = strli.ToString();
                                    strli.Clear();
                                }
                                
                                strl.AppendLine($@"CREATE OR ALTER VIEW {view_name}");
                                strl.AppendLine("(");
                                strl.Append($@"    {ob_fieldname.ToString().Trim()}");
                                strli.AppendLine($@"CREATE VIEW {view_name}");
                                strli.AppendLine("(");
                                strli.Append($@"    {ob_fieldname.ToString().Trim()}");
                                view_name_old = view_name;
                            }
                            else
                            {
                                //Bestehender View wird niedergeschrieben
                                strl.AppendLine(",");
                                strl.Append($@"    {ob_fieldname.ToString().Trim()}");
                                strli.AppendLine(",");
                                strli.Append($@"    {ob_fieldname.ToString().Trim()}");
                            }
                            voldsql = ob_sql.ToString().Trim();
                        }

                        var vcl = DataClassFactory.GetDataClass(StaticVariablesClass.ViewsKeyStr) as ViewClass;

                        if (strli.Length > 0)
                        {
                            vcl.Name = view_name_old;
                            strli.AppendLine("");
                            strli.AppendLine(") ");
                            strli.Append("AS ");
                            strli.AppendLine(voldsql);
                            vcl.CREATE_SQL = strli.ToString();
                            strli.Clear();
                        }

                        if (strl.Length > 0)
                        {
                            //Rest SQL für view wird geschrieben und view zugewiesen 

                            vcl.Name = view_name_old;
                            strl.AppendLine("");
                            strl.AppendLine(") ");
                            strl.Append("AS ");
                            strl.AppendLine(voldsql);

                            vcl.SQL = voldsql;
                            vcl.CREATEINSERT_SQL = strl.ToString();

                            var fields = GetViewFieldObjects(DBReg, vcl.Name);

                            foreach (var f in fields.Values)
                            {
                                vcl.Fields.Add(f.Name,f);
                            }

                            view_name_old = "";
                            strl.Clear();
                            new_view = vcl;
                        }

                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
            return new_view;
        }
        
        #region indecies

        #endregion
    }
}
