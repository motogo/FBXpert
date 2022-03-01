using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Transactions;

namespace FBXpertLib
{

    public static class GetTableFieldsInx
    {
        public static int TableNameInx = 0;
        public static int FieldNameInx = 1;
        public static int FieldPositionInx = 2;
        //
        public static int FieldTypeInx = 3;
        public static int FieldSubTypeInx = 4;
        public static int FieldSegmentLength = 5;
        public static int FieldLengthInx = 6;
        public static int FieldDomainNameInx = 7;
        public static int FieldDomainScaleInx = 8;
        public static int FieldDefaultValueInx = 9;
        public static int FieldDomainCollateInx = 10;
        public static int FieldDomainCharSetInx = 11;
        public static int FieldNotNullFlagInx = 12;
        public static int FieldDomainDefaultValueInx = 13;
        public static int FieldDescriptionInx = 14;
        public static int FieldDomainDescriptionInx = 15;

        
    }

    public static class AppColors
    {
        public static Color Active = Color.Blue;
        public static Color Inactive = Color.Red;
        public static Color ActiveHasConstraint = Color.DarkCyan;
        public static Color InactiveHasConstraint = Color.OrangeRed;
    }

    public class GetObjectsClass
    {


        public Dictionary<string, ViewFieldClass> GetViewFieldObjects(DBRegistrationClass DBReg, string ViewName)
        {
            string _funcStr = $@"GetViewFieldObjects(DBReg={DBReg},ViewName={ViewName})";
            var fields = new Dictionary<string, ViewFieldClass>();
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
                            fields.Add(vf.Name, vf);
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

        public Dictionary<string, ViewClass> GetViewObjects(DBRegistrationClass DBReg)
        {
            var allviews = new Dictionary<string, ViewClass>();
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

                                    allviews.Add(vc.Name, vc);
                                    var fields = GetViewFieldObjects(DBReg, vc.Name);

                                    foreach (var f in fields.Values)
                                    {
                                        vc.Fields.Add(f.Name, f);
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

                            allviews.Add(vcl.Name, vcl);
                            var fields = GetViewFieldObjects(DBReg, vcl.Name);

                            foreach (var f in fields.Values)
                            {
                                vcl.Fields.Add(f.Name, f);
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

        public Dictionary<string, TableClass> GetAllNonSystemTableObjects(DBRegistrationClass DBReg)
        {
            //  Thread.Sleep(1000);
            string _funcStr = $@"GetAllTableObjects(DBReg={DBReg})";
            var TableObject = new TableClass();
            string fields_cmd = SQLStatementsClass.Instance.GetAllNonSystemTableFields(DBReg.Version);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            var tables = new Dictionary<string, TableClass>();

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

                            tfc.Name = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                            tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0) + 1;
                            tfc.Domain.FieldType = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                            tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                            tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                            tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                            tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                            tfc.Domain.Name = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                            tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                            tfc.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                            tfc.Domain.Collate = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                            tfc.Domain.CharSet = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                            bool NNConstraint = table.IsNotNull(tfc.Name);
                            bool NNFlag = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                            if (NNConstraint != NNFlag)
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{table.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                            }
                            tfc.Domain.NotNull = NNConstraint;
                            tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                            tfc.Description = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                            tfc.Domain.Description = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();
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

                        tfc.Name = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0) + 1;
                        tfc.Domain.FieldType = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                        tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                        tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                        tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                        tfc.Domain.Name = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                        bool NNConstraint = tableObject.IsNotNull(tfc.Name);
                        bool NNFlag = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                        if (NNConstraint != NNFlag)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                        }
                        tfc.Domain.NotNull = NNConstraint;
                        tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                        tfc.Description = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                        tfc.Domain.Description = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();
                        if (tfc.Domain.DefaultValue.Length > 0)
                        {
                            if (tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }

                        }

                        tableObject.Fields.Add(tfc.Name, tfc);
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

                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(11).ToString().Trim();
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                                tcs.FieldNames.Add(fieldname, fieldname);
                                if (ctyp == eConstraintType.PRIMARYKEY)
                                {
                                    tcc.primary_constraint = tcs;
                                }
                            }
                            else if (ctyp == eConstraintType.UNIQUE)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.UniquesKeyStr) as UniquesClass;

                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(11).ToString().Trim();
                                tcs.TableName = dread.GetValue(2).ToString().Trim();

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

                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(6).ToString().Trim(); //trigger name
                                string fieldpos = dread.GetValue(12).ToString().Trim();
                                tcs.TableName = dread.GetValue(2).ToString().Trim();

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

        public Dictionary<string, SystemTableClass> GetAllSystemTableObjects(DBRegistrationClass DBReg)
        {
            string _funcStr = $@"GetSystemTableObjects(DBReg={DBReg})";

            var tables = new Dictionary<string, SystemTableClass>();
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

                        tfc.Name = dread.GetValue(GetTableFieldsInx.FieldNameInx).ToString().Trim();
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldPositionInx).ToString().Trim(), 0) + 1;
                        tfc.Domain.FieldType = dread.GetValue(GetTableFieldsInx.FieldTypeInx).ToString().Trim();
                        tfc.Domain.SubTypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSubTypeInx).ToString().Trim(), 0);
                        tfc.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldSegmentLength).ToString().Trim(), 0);
                        tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldLengthInx).ToString().Trim(), 0);
                        tfc.Domain.Name = dread.GetValue(GetTableFieldsInx.FieldDomainNameInx).ToString().Trim();
                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldDomainScaleInx).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDefaultValueInx).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(GetTableFieldsInx.FieldDomainCollateInx).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(GetTableFieldsInx.FieldDomainCharSetInx).ToString().Trim();
                        bool NNFlag = StaticFunctionsClass.ToIntDef(dread.GetValue(GetTableFieldsInx.FieldNotNullFlagInx).ToString().Trim(), 0) > 0;
                        tfc.Domain.DefaultValue = dread.GetValue(GetTableFieldsInx.FieldDomainDefaultValueInx).ToString().Trim();
                        tfc.Description = dread.GetValue(GetTableFieldsInx.FieldDescriptionInx).ToString().Trim();
                        tfc.Domain.Description = dread.GetValue(GetTableFieldsInx.FieldDomainDescriptionInx).ToString().Trim();

                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        bool NNConstraint = tableObject.IsNotNull(tfc.Name);

                        if (NNConstraint != NNFlag)
                        {
                            NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", $@"{tableObject.Name}->{tfc.Name}->NotNull constraint differs (Constraint:{NNConstraint},Flag:{NNFlag})"));
                        }
                        tfc.Domain.NotNull = NNConstraint;

                        if (tfc.Domain.DefaultValue.Length > 0)
                        {
                            if (tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                        }
                        tableObject.Fields.Add(tfc.Name, tfc);
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
    }
}
