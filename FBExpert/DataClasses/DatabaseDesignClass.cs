﻿using BasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.Globals;
using SEListBox;
using System;
using System.Collections.Generic;
using System.Text;
using static System.String;

namespace FBXpert.DataClasses
{
    public enum eLogicalType {TEXT=0,NUMBER=1,POINTNUMBER=2,DATE=3,TIMESTAMP=4,NULLABLEPOINTER=5,BOOL=6,BINARY=7,NONE=8};


    [Serializable]
    public class DatabaseDesignClass
    {
        public DBRegistrationClass Database;
        public Dictionary<string, TableClass> Tables;
        public Dictionary<string, ViewClass> Views;
    }

    [Serializable]
    public class DesDatabaseDesignClass
    {
        public DBRegistrationClass Database;
        public Dictionary<string,DesTableClass> Tables;
        public Dictionary<string,DesViewClass> Views;
    }

    public class ObjectDesignClass
    {
        public ObjectDesignClass(int x, int y)
        {
            posx = x;
            posy = y;
        }
        public int posx;
        public int posy;
    }
    
    
    public class DesTableClass
    {
        public TableClass Table;
        public ObjectDesignClass Design;
        public override string ToString()
        {
            return Table.Name;
        }
    }
    public class DesViewClass
    {
        public ViewClass View; 
        public ObjectDesignClass Design;
        public override string ToString()
        {
            return View.Name;
        }
    }

    public enum eCodePrimaryFieldType {GenID=0, GenGUID=1, GenGUIDHEX=2, GenOID=3, GenUUID=4};

    public class CodeCreateAttributes
    {
        public eCodePrimaryFieldType PrimaryFieldType = eCodePrimaryFieldType.GenID;
        public string CodeNamespace = "ProjectDatas";
    }

    public class CodeFactory
    {
        private NotifiesClass _localNotifies = null;

        private static readonly object LockThis = new object();
        private static volatile CodeFactory _instance = null;

        const string a = "\"";
        const string bb = "{";
        const string be = "}";
        public string Nl => Environment.NewLine;

        public static CodeFactory Instance()
        {
            if (_instance != null) return (_instance);
            lock (LockThis)
            {
                _instance = new CodeFactory();
            }
            return (_instance);
        }

        public CodeCreateAttributes CodeCreateAttribute { set; get; } = new CodeCreateAttributes();

        public void SetNotifies(NotifiesClass nf)
        {
            _localNotifies = nf;
        }
        
        public string ToStringMethod(FieldClass field)
        {
            string fvar = $@"{field.Name}.ToString()";
            var ltype = TypeConvert.ToLogicalType(field.Domain);
            if (ltype == eLogicalType.TIMESTAMP)
            {
                string fv1 = $@"{field.Name}.ToShortDateString()";
                string fv2 = $@"{field.Name}.ToLongTimeString()";
                fvar = $@"$@{a}{{{fv1}}} {{{fv2}}}{a}";
                
            }
            else if (ltype == eLogicalType.DATE)
            {
                fvar = $@"{field.Name}.ToShortDateString()";
            }
            return fvar;
        }

        public string ToStringMethod2(FieldClass field)
        {
            string fvar = $@"{{{field.Name}}}";
            var ltype = TypeConvert.ToLogicalType(field.Domain);
            if (ltype == eLogicalType.TIMESTAMP)
            {
                fvar = $@"{{{field.Name}.ToShortDateString()}} {{{field.Name}.ToLongTimeString()}}";
            }
            else if (ltype == eLogicalType.DATE)
            {
                fvar = $@"{{{field.Name}.ToShortDateString()}}";
            }
            return fvar;
        }

        public string CreateToKeyStringMethod(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(AppStrings.Format(lvl,"public string ToKeyString()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"var txt = string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"eTDataClass DP = (eTDataClass)DisplayMemberData.KeyIndex;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"switch (DP)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl+2,"case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(AppStrings.Format(lvl+3,"txt = string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl+3,"break;" + Nl));
                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod(field);

                    sb.Append(AppStrings.Format(lvl+2,"case eTDataClass." + field.Name + ":" + Nl));
                    sb.Append(AppStrings.Format(lvl+3,"txt = " + fvar + ";" + Nl));
                    sb.Append(AppStrings.Format(lvl+3,"break;" + Nl));
                }
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.Format(lvl+1,"return txt;" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl)); 
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(AppStrings.Format(lvl,"public string ToKeyString()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"var txt = string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"eTDataClass DP = (eTDataClass)DisplayMemberData.KeyIndex;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"switch (DP)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl+2,"case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(AppStrings.Format(lvl+3,"txt = string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl+3,"break;" + Nl));
                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod(field);
                    sb.Append(AppStrings.Format(lvl+2,"case eTDataClass." + field.Name + ":" + Nl));
                    sb.Append(AppStrings.Format(lvl+3,"txt = " + fvar + ";" + Nl));
                    sb.Append(AppStrings.Format(lvl+3,"break;" + Nl));
                }
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.Format(lvl+1,"return txt;" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl)); 
            }
            return sb.ToString();
        }

        public string CreateToStringMethod(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(AppStrings.Format(lvl,"public override string ToString()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"eTDataClass DP;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"StringBuilder txt = new StringBuilder();" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"for (int i = 0; i < (int)DisplayMemberData.DataLength; i++)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl + 3, "string first = (DisplayMemberData.BorderStart[i].Length > 0) ? DisplayMemberData.BorderStart[i] : string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl + 3, "string last = (DisplayMemberData.BorderEnd[i].Length > 0) ? DisplayMemberData.BorderEnd[i] : string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"DP = (eTDataClass)DisplayMemberData.Data[i];" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"switch (DP)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+2));
                sb.Append(AppStrings.Format(lvl+3,"case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(AppStrings.Format(lvl+4,"i = (int)DisplayMemberData.DataLength;" + Nl));
                sb.Append(AppStrings.Format(lvl+4,"break;" + Nl));

                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod2(field);

                    sb.Append(AppStrings.Format(lvl+3,"case eTDataClass." + field.Name + ":" + Nl));                    
                    sb.Append(AppStrings.Format(lvl+4,"txt.Append(DisplayMemberData.FormatMember($@\"{first}" + fvar + "{last}\", DisplayMemberData.Format[i]));" + Nl));
                    sb.Append(AppStrings.Format(lvl+4,"break;" + Nl));
                }
                sb.Append(AppStrings.BlockEnd(lvl+2));
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(Nl);                
                sb.Append(AppStrings.Format(lvl+1,"if(_translateToString) return LanguageClass.Instance.GetString(txt.ToString());" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"return (txt.ToString());" + Nl));
                sb.Append(AppStrings.Format(lvl,"} //method ToString" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;

                sb.Append(AppStrings.Format(lvl,"public override string ToString()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"eTDataClass DP;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"StringBuilder txt = new StringBuilder();" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"for (int i = 0; i < (int)DisplayMemberData.DataLength; i++)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl + 3, "string first = (DisplayMemberData.BorderStart[i].Length > 0) ? DisplayMemberData.BorderStart[i] : string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl + 3, "string last = (DisplayMemberData.BorderEnd[i].Length > 0) ? DisplayMemberData.BorderEnd[i] : string.Empty;" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"DP = (eTDataClass)DisplayMemberData.Data[i];" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"switch (DP)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+2));
                sb.Append(AppStrings.Format(lvl+3,"case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(AppStrings.Format(lvl+4,"i = (int)DisplayMemberData.DataLength;" + Nl));
                sb.Append(AppStrings.Format(lvl+4,"break;" + Nl));

                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod2(field);

                    sb.Append(AppStrings.Format(lvl+3,"case eTDataClass." + field.Name + ":" + Nl));                    
                    sb.Append(AppStrings.Format(lvl+4,"txt.Append(DisplayMemberData.FormatMember($@\"{first}" + fvar + "{last}\", DisplayMemberData.Format[i]));" + Nl));
                    sb.Append(AppStrings.Format(lvl+4,"break;" + Nl));
                }
                sb.Append(AppStrings.BlockEnd(lvl+2));
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl+1,"if(_translateToString) return LanguageClass.Instance.GetString(txt.ToString());" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"return (txt.ToString());" + Nl));
                sb.Append(AppStrings.Format(lvl,"} //method ToString" + Nl));
            }
            return (sb.ToString());
        }

        public string CreateMethodCloneIt(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            
            sb.Append(AppStrings.Format(lvl,"public void DeepCloneFrom(TColumns clm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));               
            if (tc.GetType() == typeof(TableClass))
            {
                var tb = tc as TableClass;                
                foreach (var tfc in tb.Fields.Values)
                {
                    sb.Append(AppStrings.Format(lvl+1, $@"this.{tfc.Name}=clm.{tfc.Name};" + Nl));
                }
            }
                      
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl); 
            sb.Append(AppStrings.Format(lvl,"public void DeepCloneTo(TColumns clm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));               
            if (tc.GetType() == typeof(TableClass))
            {
                var tb = tc as TableClass;                
                foreach (var tfc in tb.Fields.Values)
                {
                    sb.Append(AppStrings.Format(lvl+1, $@"clm.{tfc.Name}=this.{tfc.Name};" + Nl));
                }
            }
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl); 

            return sb.ToString();
        }

        public static string DatabaseTOcsharpCast(DomainClass domain)
        {
            //  returns a pattern like
            //  (int?) #data#
            //  TointDef(#data#)

            var str = TypeConvert.DatabaseTOcsharpTypeAsString(domain);
            str = str.Replace("byte[]","byte");
            if (!str.EndsWith("?")) return ($@"To{str}Def(#data#);");
            
            // nullable type
            return $@"({str}) #data#;";                        
        }

        public string CreateGetSetFieldAttributes(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var tc = obj as TableClass;
                sb.Append(AppStrings.Format(lvl, $@"public object[] DataList = new object[(int)eTDataClass.NO_FIELD];{Nl}"));
                foreach (var tfc in tc.Fields.Values)
                {
                    string cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain); 
                    string cstypecast = DatabaseTOcsharpCast(tfc.Domain);

                    cstypecast = cstypecast.Replace("#data#", $@"DataList[(int)eTDataClass.{tfc.Name}]");
                    sb.Append(AppStrings.Format(lvl, $@"public {cstype} {tfc.Name} {{ get => {cstypecast} set => DataList[(int)eTDataClass.{tfc.Name}] = value; }}{Nl}"));                    
                }
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var tc = obj as ViewClass;
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl + 1, $@"public object[] DataList = new object[(int)eTDataClass.NO_FIELD];{Nl}"));
                foreach (var tfc in tc.Fields.Values)
                {                    
                    string cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    string cstypecast = DatabaseTOcsharpCast(tfc.Domain);
                    cstypecast = cstypecast.Replace("#data#", $@"DataList[(int)eTDataClass.{tfc.Name}]");
                    sb.Append(AppStrings.Format(lvl, $@"public {cstype} {tfc.Name} {{ get => {cstypecast} set => DataList[(int)eTDataClass.{tfc.Name}] = value; }}{Nl}"));                    
                }
            }
            return sb.ToString();
        }

        

        public string CreateTColumnsClass(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl,"#region class TColumns" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// <inheritdoc />" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Inner class represents table datas" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"[Serializable]" + Nl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"public class TColumns : TMainColumns" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"public TColumns(DisplayMembers dmp)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,"DisplayMemberData = dmp;" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, "public TColumns()" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, "public void SetDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2, "DisplayMemberData = dpm;" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, "public TColumns Clone(DisplayMembers dpm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2, "var cloned = new TColumns(dpm);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "DeepCloneTo(cloned);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "return (cloned);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, "public TColumns Clone()" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));            
            sb.Append(AppStrings.Format(lvl+2, "return (MemberwiseClone() as "+obj.Name+ "Class.TDataClass.TColumns);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(CreateMethodCloneIt(lvl + 1, obj));
            sb.Append(Nl);

            sb.Append(CreateGetSetFieldAttributes(lvl + 1, obj));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, "#region ToStringMethods" + Nl));

            sb.Append(CreateToStringMethod(lvl+1,obj));
            sb.Append(Nl);
            sb.Append(CreateToKeyStringMethod(lvl+1,obj));
            sb.Append(AppStrings.Format(lvl+1, "#endregion ToStringMethods" + Nl));
            sb.Append(Nl);
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(AppStrings.Format(lvl, "#endregion class TColumns" + Nl));
            return sb.ToString();
        }

        public string CreateTableClassConstructor(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;

            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// First constructor" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj;
                sb.Append(AppStrings.Format(lvl, "public " + table.Name + "Class(ConnectionClass con, bool usetrans) : base(con, usetrans)" + Nl));
                sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
                sb.Append(AppStrings.Format(lvl+1, "TableName = \"" + table.Name + "\";" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(AppStrings.Format(lvl, "public " + table.Name + "Class(ConnectionClass con, bool usetrans) : base(con, usetrans)" + Nl));
                sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
                sb.Append(AppStrings.Format(lvl+1, "TableName = \"" + table.Name + "\";" + Nl));
            }
            sb.Append(AppStrings.Format(lvl + 1, "DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);

            sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// Second constructor" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj;
                sb.Append(AppStrings.Format(lvl, "public " + table.Name + "Class(ConnectionClass con) : base(con, DefaultUseTransactions)" + Nl));
                sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
                sb.Append(AppStrings.Format(lvl + 1, "TableName = \"" + table.Name + "\";" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(AppStrings.Format(lvl, "public " + table.Name + "Class(ConnectionClass con) : base(con, DefaultUseTransactions)" + Nl));
                sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
                sb.Append(AppStrings.Format(lvl + 1, "TableName = \"" + table.Name + "\";" + Nl));
            }
            sb.Append(AppStrings.Format(lvl + 1, "DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateGetCSVHeader(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();

            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                bool first = true;
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// Gets a string represents the cvs header of data." + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public string GetCsvHeader()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1, "string aps = \"" + "\\\"" + "\";" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "var sbcsv = new StringBuilder();" + Nl));
                foreach (var tfc in table.Fields.Values)
                {
                    if (!first)
                    {
                        sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvSeperator}\");" + Nl)); 
                    }
                    first = false;
                    sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{aps}" + tfc.Name + "{aps}\");"+ Nl)); 
                }
                sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvEndLineSeperator}\");" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "return sbcsv.ToString();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var view = obj as ViewClass;
                bool first = true;
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "///  Gets a string represents the cvs header of data.       " + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public string GetCsvData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl + 1, "string aps = \"" + "\\\"" + "\";" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "var sbcsv = new StringBuilder();" + Nl));
                foreach (var tfc in view.Fields.Values)
                {
                    if (!first)
                    {
                        sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvSeperator}\");" + Nl));
                    }
                    first = false;
                    sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{aps}" + tfc.Name + "{aps}\");" + Nl));
                }
                sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvEndLineSeperator}\");" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "return sbcsv.ToString();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateGetXMLHeader(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();

            sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// Gets a string represents the cvs header of data." + Nl));
            sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "public string GetXMLHeader()" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl + 1, "XmlDeclaration xmldecl;" + Nl));
            sb.Append(AppStrings.Format(lvl + 1, "XmlDocument xmlDocument = new XmlDocument();" + Nl));
            sb.Append(AppStrings.Format(lvl + 1, "xmldecl = xmlDocument.CreateXmlDeclaration(\"1.0\", \"UTF - 8\", null);" + Nl));
            sb.Append(AppStrings.Format(lvl + 1, "return xmldecl.OuterXml;" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));

            return sb.ToString();
        }

        public string CreateGetCSVValues(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();
           
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                bool first = true;
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// Get's a string represents cvs data." + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public string GetCsvData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1, "string aps = \""+"\\\""+"\";" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "var sbcsv = new StringBuilder();" + Nl));
                foreach (var tfc in table.Fields.Values)
                {
                    if (!first)
                    {
                        sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvSeperator}\");" + Nl));
                    }
                    first = false;
                    sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{aps}{Item." + tfc.Name + "}{aps}\");" + Nl));
                }
                sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvEndLineSeperator}\");" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "return sbcsv.ToString();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var view = obj as ViewClass;
                bool first = true;
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "///  Get's a string represents cvs data. " + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public string GetCsvData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl + 1, "string aps = \"" + "\\\"" + "\";" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "var sbcsv = new StringBuilder();" + Nl));
                foreach (var tfc in view.Fields.Values)
                {
                    if (!first)
                    {
                        sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvSeperator}\");" + Nl));
                    }
                    first = false;
                    sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{aps}{Item." + tfc.Name + "}{aps}\");" + Nl));
                }
                sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{CsvEndLineSeperator}\");" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "return sbcsv.ToString();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }
        public string CreateGetXMLValues(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();

            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// Get's a string represents cvs data." + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public string GetXMLData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl + 1, "string aps = \"" + "\\\"" + "\";" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "var sbcsv = new StringBuilder();" + Nl));
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{Environment.NewLine}<"+tfc.Name+">{aps}{Item." + tfc.Name + "}{aps}</"+tfc.Name+">\");" + Nl));
                }
                sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{Environment.NewLine}\");" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "return sbcsv.ToString();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var view = obj as ViewClass;
                
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "///  Get's a string represents cvs data. " + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public string GetXMLData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl + 1, "string aps = \"" + "\\\"" + "\";" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "var sbcsv = new StringBuilder();" + Nl));
                foreach (var tfc in view.Fields.Values)
                {
                    sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{Environment.NewLine}<" + tfc.Name + ">{aps}{Item." + tfc.Name + "}{aps}</" + tfc.Name + ">\");" + Nl));
                }
                sb.Append(AppStrings.Format(lvl + 1, "sbcsv.Append($@\"{Environment.NewLine}\");" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "return sbcsv.ToString();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }
        public string CreateDataClassConstructor(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();

            if (obj.GetType() == typeof(TableClass))
            {
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Constructor of data class" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public TDataClass()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"if (DisplayMemberDef == null)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl+2,"DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"DisplayMemberDef.Data[0] = 1;" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"for (int i = 1; i < ((int)eTDataClass.NO_FIELD) - 1; i++)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+2));
                sb.Append(AppStrings.Format(lvl+3,"DisplayMemberDef.Data[i] = (int)eTDataClass.NO_FIELD;" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl+2));
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.Format(lvl+1,"Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl,"public TDataClass(DisplayMembers dpm)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"DisplayMemberDef = dpm;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Destructor of data class" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"~TDataClass()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"// Destructor" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Constructor of data class" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public TDataClass()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"if (DisplayMemberDef == null)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl+2,"DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"DisplayMemberDef.Data[0] = 1;" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"for (int i = 1; i < ((int)eTDataClass.NO_FIELD) - 1; i++)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+2));
                sb.Append(AppStrings.Format(lvl+3,"DisplayMemberDef.Data[i] = (int)eTDataClass.NO_FIELD;" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl+2));
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.Format(lvl+1,"Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl,"public TDataClass(DisplayMembers dpm)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"DisplayMemberDef = dpm;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Destructor of data class" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"~TDataClass()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"// Destructor" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateTableClearMethod(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;

                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Empty an data object" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public override void Clear()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                foreach (var tfc in table.Fields.Values)
                {                    
                    sb.Append(AppStrings.Format(lvl+1,"Item." + tfc.Name + " = " + TypeConvert.ToDefaultEmpty(tfc.Domain) + ";" + Nl));                    
                }
                sb.Append(AppStrings.Format(lvl+1,"DataState = eDataState.EMPTY;" + Nl));
                sb.Append(AppStrings.Format(lvl,"}"+ Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var view = obj as ViewClass;

                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Setzt den Dateninhalt eines Objectes auf leer." + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public override void Clear()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                foreach (var tfc in  view.Fields.Values)
                {
                    sb.Append(AppStrings.Format(lvl+1,"Item." + tfc.Name + " = " + TypeConvert.ToDefaultEmpty(tfc.Domain) + ";" + Nl));                    
                }
                sb.Append(AppStrings.Format(lvl+1,"DataState = eDataState.EMPTY;" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateSerializeMethods(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Serializing an object to XML" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"public void Serialize(string fileName)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"var serializer = new XmlSerializer(typeof(TDataClass.TColumns));" + Nl));           
            sb.Append(AppStrings.Format(lvl+1,"var q1 = new XmlQualifiedName(\"\", \"\");" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"XmlQualifiedName[] names = { q1 };" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"var test = new XmlSerializerNamespaces(names);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"using (var writer = new FileStream(fileName, FileMode.Create))" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));                       
            sb.Append(AppStrings.Format(lvl+2,"foreach (var aktData in Datas)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));            
            sb.Append(AppStrings.Format(lvl+3,"serializer.Serialize(writer, ((TDataClass)aktData).Item, test);" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"writer.WriteByte(13);" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"writer.WriteByte(10);" + Nl));            
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"writer.Close();" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));            
            sb.Append(AppStrings.BlockEnd(lvl));
            return sb.ToString();
        }

        public string CreateColumsSerializingMethods(int lvl)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Getting Item object from XML" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"public void DeserializeCurrent(string fileName)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"var serializer = new XmlSerializer(typeof(TColumns));" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"var fs = new FileStream(fileName, FileMode.Open);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"using (var reader = new XmlTextReader(fs))" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,"try" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"Item = (TColumns)serializer.Deserialize(reader);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"catch" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"finally" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"reader.Close();" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(AppStrings.BlockEnd(lvl));

            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Serialize Item object to XML" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"public void SerializeCurrent(string fileName)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"var serializer = new XmlSerializer(typeof(TColumns));" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"var q1 = new XmlQualifiedName(\"\", \"\");" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"XmlQualifiedName[] names = { q1 };" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"var test = new XmlSerializerNamespaces(names);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"using (var writer = new FileStream(fileName, FileMode.Create))" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));             
            sb.Append(AppStrings.Format(lvl+2,"try" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"serializer.Serialize(writer, Item, test);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"catch" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"finally" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"writer.Close();" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(AppStrings.BlockEnd(lvl));

            return sb.ToString();
        }

        public string MakeGlobalCode(List<ItemDataClass> items, int lvl)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl,"using DBBasicClassLibrary;" + Nl));
            sb.Append(AppStrings.Format(lvl,"using System.Collections.Generic;" + Nl));
            sb.Append(AppStrings.Format(lvl,"namespace " + CodeCreateAttribute.CodeNamespace + Nl));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+1,"public class DBGlobalFunctionClass" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,"public string[] DeleteDatabaseAllDatas(string cname)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"List<string> lst = new List<string>();" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"DBProviderSet DB = new DBProviderSet(cname);" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"string cmd = string.Empty;" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"int n;" + Nl));
            sb.Append(AppStrings.Format(lvl,Nl));
            int i = 0;
            foreach(var itm in items)
            {
                if(itm.Text.StartsWith("Cb")) continue;
                if (itm.Object.GetType() == typeof(TableClass))
                {                    
                    var tc = (TableClass) itm.Object;
                    if(tc.Name.Contains("_"))
                    {
                        i++;
                        sb.Append(AppStrings.Format(lvl, Nl));
                        sb.Append(AppStrings.Format(lvl+3, $@"// {i}.Table" + Nl));
                        sb.Append(AppStrings.Format(lvl+3, "cmd = \"DELETE FROM " +tc.Name+ "\";" + Nl));
                        sb.Append(AppStrings.Format(lvl+3, "n = DB.ExecuteCommand(cmd).RecordsAffected;" + Nl));
                        sb.Append(AppStrings.Format(lvl+3, "lst.Add($@\"{cmd}->{n}\");" + Nl));
                    }
                }
            }

            foreach(var itm in items)
            {
                if(itm.Text.StartsWith("Cb")) continue;
                if (itm.Object.GetType() == typeof(TableClass))
                {                    
                    var tc = (TableClass) itm.Object;
                    if(!tc.Name.Contains("_"))
                    {
                        i++;
                        sb.Append(AppStrings.Format(lvl, Nl));
                        sb.Append(AppStrings.Format(lvl+3, $@"//{i}.Table" + Nl));
                        sb.Append(AppStrings.Format(lvl+3, "cmd = \"DELETE FROM " +tc.Name+"\";" + Nl));
                        sb.Append(AppStrings.Format(lvl+3, "n = DB.ExecuteCommand(cmd).RecordsAffected;" + Nl));
                        sb.Append(AppStrings.Format(lvl+3, "lst.Add($@\"{cmd}->{n}\");" + Nl));
                    }
                }
            }  

            sb.Append(AppStrings.Format(lvl+3, "return lst.ToArray();" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+1, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }
        public string CreateDesignForTable(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(CreateTableUsings(lvl));
            return CreateDesignForViewTable(lvl, tc, sb);
        }
        public string CreateDesignForView(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(CreateViewUsings(lvl));
            return CreateDesignForViewTable(lvl, tc, sb);
        }
        public string CreateDesignForViewTable(int lvl, DataObjectClass tc, StringBuilder sb)
        {
            sb.Append(CreateCopyright(lvl,tc.Name));
            sb.Append(AppStrings.Format(lvl, "namespace " + CodeCreateAttribute.CodeNamespace + Nl));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
            sb.Append(Nl);
           
            sb.Append(AppStrings.Format(lvl+1, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "/// Object data class for relational database datas " + tc.Name + Nl));            
            sb.Append(AppStrings.Format(lvl+1, "/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "///" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "[Serializable]" + Nl));
            sb.Append(AppStrings.Format(lvl+1, $@"public class {tc.Name}Class : TDataBasis{Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(Nl);

            sb.Append(CreateFieldEnum(lvl+2, tc));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "private static bool _translateToString = false;"+Nl));
            sb.Append(AppStrings.Format(lvl+2, "public static bool TranslateToStringResult{get => _translateToString; set =>  _translateToString = value; }"+Nl));
            sb.Append(AppStrings.Format(lvl+2, "public static int ColCount = (int)eTDataClass.NO_FIELD;" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "public static string CsvSeperator = \",\";" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "public static string CsvEndLineSeperator = \";\";" + Nl));
            sb.Append(Nl);

            sb.Append(AppStrings.Format(lvl+2, "#region class TDataClass" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "[Serializable]" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "public class TDataClass : TMainData" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3, "public DisplayMembers DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+3, "public void SetDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+3));            
            sb.Append(AppStrings.Format(lvl+4, "DisplayMemberDef = dpm;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "Item.SetDisplayMembers(DisplayMemberDef);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+3));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+3, "public override string ToString()" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "if (Item != null) return (Item.ToString());" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "return (\"Object not available (null)\");" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            
            sb.Append(CreateTColumnsClass(lvl+3,tc));
            sb.Append(Nl);

            sb.Append(AppStrings.Format(lvl+3, "public TColumns Item;" + Nl));
            sb.Append(Nl);

            sb.Append(CreateDataClassConstructor(lvl + 3, tc));
            sb.Append(Nl);


            sb.Append(CreateGetCSVValues(lvl+3,tc));
            sb.Append(Nl);

            sb.Append(CreateGetXMLValues(lvl + 3, tc));
            sb.Append(Nl);

            sb.Append(CreateTableClearMethod(lvl+3,tc));
            sb.Append(Nl);

            sb.Append(CreateColumsSerializingMethods(lvl+3));
            sb.Append(Nl);

            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"#endregion class TDataClass" + Nl));
            sb.Append(Nl);
            
            sb.Append(CreateNewMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateGetCSVHeader(lvl + 2, tc));
            sb.Append(Nl);

            sb.Append(CreateGetXMLHeader(lvl + 2, tc));
            sb.Append(Nl);

            sb.Append(CreateSerializeMethods(lvl+2));
            sb.Append(Nl);

            sb.Append(CreateTableClassConstructor(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateFieldGetMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateGetDataMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(AppStrings.Format(lvl+2, "#region class update/insert/delete methods" + Nl));
            sb.Append(CreateUpdateDataMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateInsertDataMethods(lvl+2,tc));

            sb.Append(CreateDeleteDataMethods(lvl+2, tc));
            sb.Append(Nl);

            sb.Append(AppStrings.Format(lvl+2, "#endregion class update/insert/delete methods" + Nl));
            sb.Append(Nl);

            sb.Append(CreateMiscMethods(lvl+2,tc));
            sb.Append(Nl);
                        
            sb.Append(AppStrings.Format(lvl+1,"}  //class" + Nl));
            sb.Append(AppStrings.Format(lvl,"}      //namespace" + Nl));
            return sb.ToString();
        }

        public string CreateSearchSchluessel(int lvl,DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl+2, "public override object Search_SCHLUESSEL(SELibraries.WindowsForms.SEComboBox cb)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "" + tc.Name + "Class.TDataClass.TColumns data;" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "string ky;" + Nl));           
            sb.Append(AppStrings.Format(lvl+3, "if (!cb.Text.EndsWith(\"*\"))" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+4, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+5, "data = (" + tc.Name + "Class.TDataClass.TColumns)cb.Items[i];" + Nl));
            sb.Append(AppStrings.Format(lvl+5, "ky = data.ToKeyString();" + Nl));
            sb.Append(AppStrings.Format(lvl+5, "if (ky != cb.Text) continue;" + Nl));           
            sb.Append(AppStrings.Format(lvl+5, "cb.SelectedIndex = i;" + Nl));
            sb.Append(AppStrings.Format(lvl+5, "break;" + Nl));           
            sb.Append(AppStrings.Format(lvl+4, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "else" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "cb.Text = cb.Text.Substring(0, cb.Text.Length - 1);" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);           
            sb.Append(AppStrings.Format(lvl+3, "for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "data = (" + tc.Name + "Class.TDataClass.TColumns)cb.Items[i];" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "ky = data.ToKeyString();" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "if (!ky.StartsWith(cb.Text)) continue;" + Nl));           
            sb.Append(AppStrings.Format(lvl+4, "cb.SelectedIndex = i;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "return data;" + Nl));           
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));           
            sb.Append(Nl);           
            sb.Append(AppStrings.Format(lvl+3, "for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "data = (" + tc.Name + "Class.TDataClass.TColumns)cb.Items[i];" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "ky = data.ToKeyString();" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "if (ky.IndexOf(cb.Text, StringComparison.Ordinal) < 0) continue;" + Nl));            
            sb.Append(AppStrings.Format(lvl+4, "cb.SelectedIndex = i;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "return data;" + Nl));            
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return null;" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateSearchCbDefaultClasses(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl+2, "public override object Search(string sql, bool check)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "if (DATA.ReadNewTableData(sql) > 0)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "if (DATA.SetFirstData())" + Nl));
            sb.Append(AppStrings.Format(lvl+4, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+5, "var defData = ("+tc.Name+"Class.TDataClass)DATA.CurrentData;" + Nl));
            sb.Append(AppStrings.Format(lvl+5, "if (check)" + Nl));
            sb.Append(AppStrings.Format(lvl+5, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+6, "return SearchAndCheck_ID(defData.Item.ID);" + Nl));
            sb.Append(AppStrings.Format(lvl+5, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+5, "else" + Nl));
            sb.Append(AppStrings.Format(lvl+5, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+6, "return Search_ID(defData.Item.ID);" + Nl));
            sb.Append(AppStrings.Format(lvl+5, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+4, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "else" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "ComboBoxObject.SelectedIndex = -1;" + Nl));           
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return null;" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateCbRefreshDisplayMembers(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl+2, "public override void RefreshDisplayMembers()" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "DATA.SetDisplayMembers(DisplayMemberDef);" + Nl));            
            sb.Append(AppStrings.Format(lvl+3, "for (int i = 0; i < ComboBoxObject.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "var columnData = (" + tc.Name + "Class.TDataClass.TColumns)ComboBoxObject.Items[i];" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "columnData.SetDisplayMembers(DisplayMemberDef);" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "ComboBoxObject.Items[i] = columnData;" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override void RefreshDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "DisplayMemberDef = dpm;" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "RefreshDisplayMembers();" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateCbSetComboDataMembers(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl+2, "public override void SetComboData(string cmd)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "int[] x = { };" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "this.SetComboData(cmd, x);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override void SetComboData(string cmd, int[] duplicates)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "base.SetComboData();" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "AktCmd = cmd;" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "DATA.LeseComboData(ComboBoxObject, AktCmd, duplicates);" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "cbSelectedIndexChanged();" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override void SetComboData(string cmd, object id)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetComboData(cmd);" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "Search_ID(id);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override void SetComboData(string cmd, int? id)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetComboData(cmd);" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "Search_ID(id);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override void SetComboData(string cmd, int id)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetComboData(cmd);" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "Search_ID(id);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override void SetComboData(string cmd, string id)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetComboData(cmd);" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "Search_ID(id);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateSearchCbDataClasses(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl+2, "public object Search_DATA(string pattern, int colinx, bool checkWhenDataFound)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));                       
            sb.Append(AppStrings.Format(lvl+3, "for (int i = 0; i < ComboBoxObject.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "var data = (" + tc.Name + "Class.TDataClass.TColumns)ComboBoxObject.Items[i];" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "if (data.DataList[colinx].ToString() != pattern) continue;" + Nl));       
            sb.Append(AppStrings.Format(lvl+4, "if ((CheckBoxObject != null) && (checkWhenDataFound)) CheckBoxObject.Checked = true;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "if (ComboBoxObject != null) ComboBoxObject.Enabled = true;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "ComboBoxObject.SelectedIndex = i;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "cbSelectedIndexChanged();" + Nl));            
            sb.Append(AppStrings.Format(lvl+4, "return data;" + Nl));            
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return null;" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public object Search_ID(object id, bool checkWhenDataFound)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));         
            sb.Append(AppStrings.Format(lvl+3, "if (id == null)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "CheckBoxObject.Checked = false;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "return null;" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "if (id.ToString().Length <= 0) return null;" + Nl));           
            sb.Append(AppStrings.Format(lvl+3, "for (int i = 0; i < ComboBoxObject.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4, "var data = (" + tc.Name + "Class.TDataClass.TColumns)ComboBoxObject.Items[i];" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "if (data.ID.ToString() != id.ToString()) continue;" + Nl));            
            sb.Append(AppStrings.Format(lvl+4, "if ((CheckBoxObject != null) && (checkWhenDataFound)) CheckBoxObject.Checked = true;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "if (ComboBoxObject != null) ComboBoxObject.Enabled = true;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "ComboBoxObject.SelectedIndex = i;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "cbSelectedIndexChanged();" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "return data;" + Nl));            
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return null;" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override object SearchAndCheck_ID(object id)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return Search_ID(id, true);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override object Search_ID(object id)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return Search_ID(id, false);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public override object Search_DATA(string pattern, int colinx)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "return Search_DATA(pattern, colinx, false);" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            return sb.ToString();
        }

        public string CreateCbConstructors(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl+2, "public Cb" + tc.Name + "Class(SELibraries.WindowsForms.SEComboBox cb, CheckBox cbUk, Button btnEdit) : base(cb, cbUk, btnEdit)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetDefaultAttributes();" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public Cb" + tc.Name + "Class(SELibraries.WindowsForms.SEComboBox cb, CheckBox cbUk) : base(cb, cbUk)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetDefaultAttributes();" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public Cb" + tc.Name + "Class(SELibraries.WindowsForms.SEComboBox cb) : base(cb)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+3, "SetDefaultAttributes();" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, "public Cb" + tc.Name + "Class() : base()" + Nl));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateDesignForCbTable(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(CreateCbTableUsings(lvl));
            sb.Append(CreateCopyright(lvl,tc.Name));
            sb.Append(AppStrings.Format(lvl,$@"namespace {CodeCreateAttribute.CodeNamespace}{Nl}"));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+1, $@"/// <summary>{Nl}"));
            sb.Append(AppStrings.Format(lvl+1, $@"/// Klasse die Daten der relationalen Datenbanktabelle {tc.Name}{Nl}"));
            sb.Append(AppStrings.Format(lvl+1, $@"/// als Objekte darstellt und verwaltet.{Nl}"));
            sb.Append(AppStrings.Format(lvl+1, $@"/// </summary>{Nl}"));
            sb.Append(AppStrings.Format(lvl+1, $@"///{Nl}"));
            sb.Append(AppStrings.Format(lvl+1,$@"public class Cb{tc.Name}Class : SELibraries.WindowsForms.cbMainClass{Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,$@"private {tc.Name}Class DATA = new {tc.Name}Class(ConnectionPoolClass.Instance.GetConnection(GlobalsCon.MainCon));{Nl}"));
            sb.Append(Nl);
            sb.Append(CreateCbConstructors(lvl+2,tc));
            sb.Append(Nl);
            sb.Append(CreateCbRefreshDisplayMembers(lvl+2, tc));
            sb.Append(Nl);
            sb.Append(CreateCbSetComboDataMembers(lvl+2));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, $@"public sealed override void SetDefaultAttributes(){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3, $@"base.SetDefaultAttributes();{Nl}"));
            sb.Append(AppStrings.Format(lvl+3, $@"base.AktCmd = ""SELECT * FROM {tc.Name} ORDER BY ID"";{Nl}"));
            sb.Append(AppStrings.Format(lvl+3, $@"DATA.SetDisplayMembers(DisplayMemberDef);{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, $@"public override void SetDATA_ID(object id, bool refreshCombo){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3, $@"if (!refreshCombo) return;{Nl}"));
            sb.Append(AppStrings.Format(lvl+3, $@"AktData = DATA.LeseComboData(ComboBoxObject, AktCmd, id);{Nl}"));
            sb.Append(AppStrings.Format(lvl+3, $@"if (CheckBoxObject != null){Nl}"));
            sb.Append(AppStrings.Format(lvl+4, $@"CheckBoxObject.Checked = (AktData != null);{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2,$@"public override void SetKeyIndex(int kn){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,$@"DisplayMemberDef.KeyIndex = kn;{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(Nl);
            sb.Append(CreateSearchSchluessel(lvl+2,tc));
            sb.Append(Nl);
            sb.Append(CreateSearchCbDefaultClasses(lvl+2,tc));
            sb.Append(Nl);
            sb.Append(CreateSearchCbDataClasses(lvl+2, tc));
            
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, $@"protected override object AktID(){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+2));            
            sb.Append(AppStrings.Format(lvl+3, $@"return (({tc.Name}Class.TDataClass.TColumns) AktData)?.ID;{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, $@"#region Events{Nl}"));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, $@"public override void cbSelectedIndexChanged(){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3, $@"if (ComboBoxObject.SelectedIndex >= 0){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+3));
            sb.Append(AppStrings.Format(lvl+4, $@"AktData = ({tc.Name}Class.TDataClass.TColumns)ComboBoxObject.SelectedItem;{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+3));
            sb.Append(AppStrings.Format(lvl+3, $@"else{Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+3));
            sb.Append(AppStrings.Format(lvl+4, $@"AktData = null;{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+3));
            sb.Append(AppStrings.Format(lvl+3, $@"ComboBoxObject.Enabled = AktData != null;{Nl}"));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+2, $@"public override void cbMouseClick(){Nl}"));
            sb.Append(AppStrings.BlockStart(lvl+2));            
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+1,$@"#endregion{Nl}"));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl+1, $@"}} //class{Nl}"));
            sb.Append(AppStrings.Format(lvl, $@"}} //namespace{Nl}"));
            return sb.ToString();
        }
        private string _basename = string.Empty;
        public void Init(NotifiesClass notifies, string basename)
        {
            this._basename = basename;
            this.SetNotifies(notifies);
        }
        
        public string CreateSelectComboIndex(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            PrimaryKeyClass pk = null;
            if (obj.GetType() == typeof(TableClass))
            {
                pk = ((TableClass) obj).primary_constraint;
            }

            sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "        /// Selects the entry of ComboBox for the ID columns of dataset." + Nl));            
            sb.Append(AppStrings.Format(lvl, "        /// </summary>" + Nl));

            if((CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUID)||(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUIDHEX))
            {
                sb.Append(AppStrings.Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, string id)" + Nl));
                sb.Append(AppStrings.Format(lvl, "        {" + Nl));            
                sb.Append(AppStrings.Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));
                if (obj.GetType() == typeof(ViewClass))
                {
                    string fld = GetFirstViewField(((ViewClass)obj).Fields);
                    sb.Append(AppStrings.Format(lvl + 2, $@"        if (KS.{fld} == id)" + Nl));
                }
                else if (pk == null)
                {
                    string fld = GetFirstTableField(((TableClass)obj).Fields);
                    _localNotifies?.AddToERROR($@"No PrimaryKey in Table {obj.Name}, using field {fld} instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)");
                    sb.Append(AppStrings.Format(lvl+2, $@"        if (KS.{fld} == id)" + Nl));
                }
                else
                {                    
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                    if(!string.IsNullOrEmpty(fn))
                    {
                      sb.Append(AppStrings.Format(lvl+2, "        if (KS." + fn + " == id)" + Nl));
                    }
                }
                sb.Append(AppStrings.Format(lvl+2, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "            cb.SelectedIndex = i;" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "            KD = KS;" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "            break;  // for schleife verlassen" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        return (KD);" + Nl));
                sb.Append(AppStrings.Format(lvl, "        }" + Nl));
                sb.Append(Nl);
            }
            else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenOID)
            {
                sb.Append(AppStrings.Format(lvl, "public TDataClass.TColumns SelectComboIndex(ComboBox cb, long id)" + Nl));
                sb.Append(AppStrings.Format(lvl, "        {" + Nl));            
                sb.Append(AppStrings.Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));
                if (obj.GetType() == typeof(ViewClass))
                {
                    string fld = GetFirstViewField(((ViewClass)obj).Fields);
                    sb.Append(AppStrings.Format(lvl + 2, $@"        if (KS.{fld} == id)" + Nl));
                }
                else if (pk == null)
                {
                    string fld = GetFirstTableField(((TableClass)obj).Fields);
                    _localNotifies?.AddToERROR($@"No PrimaryKey in Table {obj.Name}, using field {fld} instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)");
                    sb.Append(AppStrings.Format(lvl+2, $@"        if (KS.{fld} == id)" + Nl));
                }
                else
                {                    
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                    if(!string.IsNullOrEmpty(fn))
                    {
                      sb.Append(AppStrings.Format(lvl+2, "        if (KS." + fn + " == id)" + Nl));
                    }
                }
                sb.Append(AppStrings.Format(lvl+2, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "        cb.SelectedIndex = i;" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "        KD = KS;" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "        break;  // for schleife verlassen" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        return (KD);" + Nl));
                sb.Append(AppStrings.Format(lvl, "        }" + Nl));                
                sb.Append(Nl);
            }
            else
            {

                sb.Append(AppStrings.Format(lvl, "public TDataClass.TColumns SelectComboIndex(ComboBox cb, int? id)" + Nl));
                sb.Append(AppStrings.Format(lvl, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        TDataClass.TColumns si = null;" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        if (id != null)" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        si = SelectComboIndex(cb, id.Value);" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        return (si);" + Nl));
                sb.Append(AppStrings.Format(lvl, "        }" + Nl));
                sb.Append(Nl);
                sb.Append(AppStrings.Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)" + Nl));
                sb.Append(AppStrings.Format(lvl, "        {" + Nl));            
                sb.Append(AppStrings.Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));
                if (obj.GetType() == typeof(ViewClass))
                {
                    string fld = GetFirstViewField(((ViewClass)obj).Fields);
                    sb.Append(AppStrings.Format(lvl + 2, $@"        if (KS.{fld} == id)" + Nl));
                }
                else if (pk == null)
                {
                    string fld = GetFirstTableField(((TableClass)obj).Fields);
                    _localNotifies?.AddToERROR($@"No PrimaryKey in Table {obj.Name}, using field {fld} instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)");
                    sb.Append(AppStrings.Format(lvl+2, $@"        if (KS.{fld} == id)" + Nl));
                }
                else
                {                    
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                    if(!string.IsNullOrEmpty(fn))
                    {
                      sb.Append(AppStrings.Format(lvl+2, "        if (KS." + fn + " == id)" + Nl));
                    }
                }
                sb.Append(AppStrings.Format(lvl+2, "        {" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "        cb.SelectedIndex = i;" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "        KD = KS;" + Nl));
                sb.Append(AppStrings.Format(lvl+3, "        break;  // for schleife verlassen" + Nl));
                sb.Append(AppStrings.Format(lvl+2, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        }" + Nl));
                sb.Append(AppStrings.Format(lvl+1, "        return (KD);" + Nl));
                sb.Append(AppStrings.Format(lvl, "        }" + Nl));
            }

            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, object id)" + Nl));
            sb.Append(AppStrings.Format(lvl, "        {" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "        if ((id != null) && (id.ToString().Length > 0))" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "        {" + Nl));            
            sb.Append(AppStrings.Format(lvl+2, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "        {" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));

            if (obj.GetType() == typeof(ViewClass))
            {
                string fld = GetFirstViewField(((ViewClass)obj).Fields);
                sb.Append(AppStrings.Format(lvl + 3, $@"        if (KS.{fld}.ToString() == id.ToString())" + Nl));
            }
            else if (pk == null)
            {
                string fld = GetFirstTableField(((TableClass)obj).Fields);
                _localNotifies?.AddToERROR($@"No PrimaryKey in Table {obj.Name}, using field {fld} instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, object id)");
                sb.Append(AppStrings.Format(lvl + 3, $@"        if (KS.{fld}.ToString() == id.ToString())" + Nl));
            }
            else
            {
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                if (!string.IsNullOrEmpty(fn))
                {
                    sb.Append(AppStrings.Format(lvl + 3, "        if (KS." + fn + ".ToString() == id.ToString())" + Nl));
                }
            }

            sb.Append(AppStrings.Format(lvl+3, "        {" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "        cb.SelectedIndex = i;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "        KD = KS;" + Nl));
            sb.Append(AppStrings.Format(lvl+4, "        break;  // for schleife verlassen" + Nl));
            sb.Append(AppStrings.Format(lvl+3, "        }" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "        }" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "        }" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "        return (KD);" + Nl));
            sb.Append(AppStrings.Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl, "        public " + obj.Name + "Class.TDataClass.TColumns GetSelectedItem(ComboBox cb)" + Nl));
            sb.Append(AppStrings.Format(lvl, "        {" + Nl));            
            sb.Append(AppStrings.Format(lvl+1, "        var KD = (" + obj.Name + "Class.TDataClass.TColumns)cb.Items[cb.SelectedIndex];" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "        return (KD);" + Nl));
            sb.Append(AppStrings.Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public static string GetFirstViewField(Dictionary<string, ViewFieldClass> Names)
        {
            string[] arr = new string[Names.Count];
            Names.Keys.CopyTo(arr, 0);            
            if (arr.Length > 0) return arr[0];
            return string.Empty;
        }
        public static string GetFirstTableField(Dictionary<string, TableFieldClass> Names)
        {
            string[] arr = new string[Names.Count];
            Names.Keys.CopyTo(arr, 0);
            if (arr.Length > 0) return arr[0];
            return string.Empty;
        }

        public string CreateDeleteDataMethods(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            PrimaryKeyClass pk = null;

            if (obj.GetType() == typeof(TableClass))
            {
                pk = ((TableClass) obj).primary_constraint;
            }
            
            sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// Erases datas of actual object from database" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "public override ReturnInfo DeleteData(eDataDeleteMode dataMode)" + Nl));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+1, $@"{obj.Name}Class.TDataClass dc = ({obj.Name}Class.TDataClass)CurrentData;" + Nl));

            if(obj.GetType() == typeof(ViewClass))
            {
                string fld = GetFirstViewField(((ViewClass)obj).Fields);
                sb.Append(AppStrings.Format(lvl + 1, $@"ReturnInfo rt = DeleteData(dc.Item.{fld},dataMode);{Nl}"));
            }
            else if (pk == null)
            {
                string fld = GetFirstTableField(((TableClass)obj).Fields);
                _localNotifies?.AddToERROR($@"No PrimaryKey in table {obj.Name}, using field {fld} instead in method:  public override ReturnInfo DeleteData(eDataDeleteMode dataMode)");
                sb.Append(AppStrings.Format(lvl+1, $@"ReturnInfo rt = DeleteData(dc.Item.{fld},dataMode);{Nl}"));
            }
            else
            {
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                if(!string.IsNullOrEmpty(fn))
                {
                    sb.Append(AppStrings.Format(lvl+1, $@"ReturnInfo rt = DeleteData(dc.Item.{fn},dataMode);{Nl}"));
                }
            }
            sb.Append(AppStrings.Format(lvl+1, "if (rt.Done)" + Nl));
            sb.Append(AppStrings.Format(lvl+2, "CurrentData.Clear();" + Nl));
            sb.Append(AppStrings.Format(lvl+1, "return (rt);" + Nl));
            sb.Append(AppStrings.Format(lvl, AppStrings.BlockEnd(lvl)));
            return sb.ToString();
        }

        public string CreateMiscMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl,"#region list and combobox methods" + Nl));
            sb.Append(AppStrings.Format(lvl,"public void SetDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"DisplayMemberDef = dpm;" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"//Actual object becomes display definition" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"TDataClass AktData = (TDataClass)this.CurrentData;" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"if (AktData != null)" + Nl));
            sb.Append(AppStrings.Format(lvl+2,"AktData.SetDisplayMembers(dpm);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Returns object selected by SQL statement to array of objects" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// dpm = DisplayMember determines content of list for ComboBox, ect." + Nl));            
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"public Object[] LeseListData(string SQL)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"ArrayList cb = null;" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"this.ReadNewData(SQL);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"TDataClass KD;" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"if (this.SetFirstData())" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,"cb = new ArrayList(this.Count);" + Nl));
            sb.Append(AppStrings.Format(lvl+2,"while (this.GetData())" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"KD = (TDataClass)this.CurrentData;" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"cb.Add(KD.Item);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(AppStrings.Format(lvl+1,"if (cb == null) return (null);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"return (cb.ToArray());" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Fills ComboBox with objectlist selected by SQL statement." + Nl));            
            sb.Append(AppStrings.Format(lvl,"/// Select's first entry of ComboBox." + Nl));            
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"public void LeseComboData(ComboBox cb, string SQL)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"int[] x = { };" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"this.LeseComboData(cb, SQL, x);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"public void LeseComboData(ComboBox cb, string sql, int[] duplicates)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"this.ReadNewData(sql);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"TDataClass kd;" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"cb.BeginUpdate();" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"cb.Items.Clear();" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"if (this.SetFirstData())" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,"while (this.GetData())" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+2));
            sb.Append(AppStrings.Format(lvl+3,"kd = (TDataClass)this.CurrentData;" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"bool dup = false;" + Nl));
            sb.Append(AppStrings.Format(lvl+3,"if ((duplicates != null) && (duplicates.Length > 0))" + Nl));
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+4,"object x = kd.Item.DataList[duplicates[0]];" + Nl));
            sb.Append(AppStrings.Format(lvl+4,"foreach (TDataClass.TColumns ki in cb.Items)" + Nl));
            sb.Append(AppStrings.Format(lvl+4, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+5, "object y = ki.DataList[duplicates[0]];" + Nl));
            sb.Append(AppStrings.Format(lvl+5,"if (y.ToString() == x.ToString())" + Nl));
            sb.Append(AppStrings.Format(lvl+5, AppStrings.BlockStart(lvl)));
            sb.Append(AppStrings.Format(lvl+6,"dup = true;" + Nl));
            sb.Append(AppStrings.Format(lvl+5, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+4, AppStrings.BlockEnd(lvl))); 
            sb.Append(AppStrings.Format(lvl+3, AppStrings.BlockEnd(lvl)));
            sb.Append(AppStrings.Format(lvl+3,"if (!dup) cb.Items.Add(kd.Item);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+2));
            sb.Append(AppStrings.Format(lvl+2,"cb.SelectedIndex = cb.Items.Count > 0 ? 0 : -1;" + Nl));                   
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(AppStrings.Format(lvl+1,"cb.EndUpdate();" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Fills ComboBox with objectlist selected by SQL statement." + Nl));         
            sb.Append(AppStrings.Format(lvl,"/// Selects entry with specific ID of data column." + Nl));                        
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));            
            sb.Append(AppStrings.Format(lvl,"public TDataClass.TColumns LeseComboData(ComboBox cb, string sql, object id)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"LeseComboData(cb, sql);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"return (id != null) && (id.ToString().Length > 0) ? SelectComboIndex(cb, id) : null;" + Nl));            
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Fills ComboBox with objectlist selected by SQL statement." + Nl));         
            sb.Append(AppStrings.Format(lvl,"/// Selects first entry of ComboBox." + Nl));                        
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));  
            sb.Append(AppStrings.Format(lvl,"public void LeseComboData(ComboBox cb, string sql, DisplayMembers dpm)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"SetDisplayMembers(dpm);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"LeseComboData(cb, sql);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);
            sb.Append(CreateSelectComboIndex(lvl, obj));
            sb.Append(Nl);
            sb.Append(AppStrings.Format(lvl,"#endregion list and combobox methods" + Nl));

            return sb.ToString();
        }

        public string CreateFieldGetMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();            
            sb.Append(AppStrings.Format(lvl, "#region class getFieldsAttributes methods" + Nl));
            if (obj.GetType() == typeof(TableClass))
            {
                var tc = obj as TableClass;
                foreach (var tfc in tc.Fields.Values)
                {
                    var cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);

                    //Wenn ein Blob feld vom typ TEXT ist wird es wie ein string behandelt
                    if ((cstype == "byte[]") || (cstype == "blob"))
                    {
                        if (tfc.Domain.SubTypeNumber == (int)eBlobSubType.TEXT) cstype = "string";
                    }
                
                    var csValueType = TypeConvert.DatabaseTOcsharpValueTypeAsString(tfc.Domain);
                    
                    sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                    sb.Append(AppStrings.Format(lvl,"/// Return's type and value of database column " + tfc.Name + Nl));
                    sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                    sb.Append(AppStrings.Format(lvl,"/// <returns>value of database column " + tfc.Name + "</returns>" + Nl));
                    sb.Append(AppStrings.Format(lvl,"public " + cstype + " get" + tfc.Name + "()" + Nl));
                    sb.Append(AppStrings.BlockStart(lvl));                   
                    sb.Append(AppStrings.Format(lvl+1,$@"{cstype} data = {TypeConvert.ToDefaultEmpty(tfc.Domain)};{Nl}"));                                       
                    sb.Append(AppStrings.Format(lvl+1,"try" + Nl));
                    sb.Append(AppStrings.BlockStart(lvl+1));
                    sb.Append(AppStrings.Format(lvl+2,"var ob = ConnectionData.GetValue((int)eTDataClass." + tfc.Name + ");" + Nl));
                    sb.Append(AppStrings.Format(lvl+2,"var dataTypeStr = ob.GetType();" + Nl));
                    sb.Append(AppStrings.Format(lvl+2,"if (dataTypeStr != typeof(System.DBNull))" + Nl));
                    sb.Append(AppStrings.BlockStart(lvl+2));
                    if ((cstype == "string")||(cstype == "DateTime"))
                    {
                        sb.Append(AppStrings.Format(lvl+3,"data = (" + cstype + ")ob;" + Nl));
                    }
                    else if ((cstype == "byte[]")||(cstype == "blob"))
                    {
                        if(tfc.Domain.SubTypeNumber == (int) eBlobSubType.TEXT)
                        {
                            sb.Append(AppStrings.Format(lvl + 3, "data = (string)ob;" + Nl));
                        }
                        else if (tfc.Domain.SubTypeNumber == (int)eBlobSubType.BINARY)
                        {
                            sb.Append(AppStrings.Format(lvl + 3, $@"data = dataTypeStr == typeof({csValueType}) ? ({csValueType}) ob : null;{Nl}"));
                        }
                    }
                    else
                    {
                        sb.Append(AppStrings.Format(lvl+3,$@"data = dataTypeStr == typeof({csValueType}) ? ({csValueType}) ob : {csValueType}.Parse(ob.ToString());{Nl}"));                        
                    }
                    sb.Append(AppStrings.BlockEnd(lvl+2));
                    sb.Append(AppStrings.BlockEnd(lvl+1));
                    sb.Append(AppStrings.Format(lvl+1,"catch (Exception ex)" + Nl));
                    sb.Append(AppStrings.BlockStart(lvl+1));
                    sb.Append(AppStrings.Format(lvl+2,$@"TMessages.Instance.HandleKonvertException(ex.Message, ""{tc.Name}Class->get{tfc.Name}()"");{Nl}"));
                    sb.Append(AppStrings.BlockEnd(lvl+1));
                    sb.Append(AppStrings.Format(lvl+1,"return (data);" + Nl));
                    sb.Append(AppStrings.BlockEnd(lvl));
                }
            }
            else if(obj.GetType() == typeof(ViewClass))
            {
                var vc = obj as ViewClass;

                foreach (var tfc in vc.Fields.Values)
                {
                    var cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    var csValueType = TypeConvert.DatabaseTOcsharpValueTypeAsString(tfc.Domain);
                    sb.Append(AppStrings.Format(lvl, $@"/// <summary>{Nl}"));
                    sb.Append(AppStrings.Format(lvl, $@"/// Return's type and value of database column {tfc.Name}{Nl}"));
                    sb.Append(AppStrings.Format(lvl, $@"/// </summary>{Nl}"));
                    sb.Append(AppStrings.Format(lvl, $@"/// <returns>value of database column {tfc.Name}</returns>{Nl}"));
                    sb.Append(AppStrings.Format(lvl, $@"public {cstype} get{tfc.Name}(){Nl}"));
                    sb.Append(AppStrings.BlockStart(lvl));                                        
                    sb.Append(AppStrings.Format(lvl+1, $@"{cstype} data = {TypeConvert.ToDefaultDBNull(tfc.Domain)};{Nl}"));                   
                    sb.Append(AppStrings.Format(lvl+1, $@"try{Nl}"));
                    sb.Append(AppStrings.BlockStart(lvl+1));
                    sb.Append(AppStrings.Format(lvl+2, $@"var ob = ConnectionData.GetValue((int)eTDataClass.{tfc.Name});{Nl}"));
                    sb.Append(AppStrings.Format(lvl+2, $@"var dataTypeStr = ob.GetType();{Nl}"));
                    sb.Append(AppStrings.Format(lvl+2, $@"if (dataTypeStr != typeof(System.DBNull)){Nl}"));
                    sb.Append(AppStrings.BlockStart(lvl+2));
                    if ((cstype == "string") || (cstype == "DateTime"))
                    {
                        sb.Append(AppStrings.Format(lvl+3, $@"data = ({cstype})ob;{Nl}"));
                    }
                    else
                    {
                        sb.Append(AppStrings.Format(lvl+3,$@"data = dataTypeStr == typeof({csValueType}) ? ({csValueType}) ob : {csValueType}.Parse(ob.ToString());{Nl}"));                        
                    }
                    sb.Append(AppStrings.Format(lvl+2, AppStrings.BlockEnd(lvl)));
                    sb.Append(AppStrings.Format(lvl+1, AppStrings.BlockEnd(lvl)));
                    sb.Append(AppStrings.Format(lvl+1, $@"catch (Exception ex){Nl}"));
                    sb.Append(AppStrings.Format(lvl+1, AppStrings.BlockStart(lvl)));
                    sb.Append(AppStrings.Format(lvl+2,$@"TMessages.Instance.HandleKonvertException(ex.Message, {a}{vc.Name}Class->get{tfc.Name}(){a});{Nl}"));
                    sb.Append(AppStrings.Format(lvl+1, AppStrings.BlockEnd(lvl)));
                    sb.Append(AppStrings.Format(lvl+1, $@"return (data);{Nl}"));
                    sb.Append(AppStrings.Format(lvl, AppStrings.BlockEnd(lvl)));
                }
            }
            sb.Append(AppStrings.Format(lvl, $@"#endregion class getFieldsAttributes methods{Nl}"));
            return sb.ToString();
        }

        public string AppendFieldParam(string dataTypeStr,string fieldName, int lvl)
        {
            var sb = new StringBuilder();
            if (dataTypeStr.StartsWith("double"))
            {
                sb.Append(AppStrings.Format(lvl, $@"ConnectionData.AddParam(@{a}@{fieldName}{a}, TDataBasis.ToSQLString(dc.Item.{fieldName}));{Nl}"));
            }
            else if (dataTypeStr == "DateTime")
            {
                sb.Append(AppStrings.Format(lvl, $@"ConnectionData.AddParam(@{a}@{fieldName}{a}, GetDatumZeitStr(dc.Item.{fieldName}));{Nl}"));
            }
            else
            {
                sb.Append(AppStrings.Format(lvl, $@"ConnectionData.AddParam(@{a}@{fieldName}{a}, dc.Item.{fieldName});{Nl}"));
            }
            return sb.ToString();
        }

        public string CreateInsertDataMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Inserts object data into database." + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public override ReturnInfo InsertData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"using (var dc = (" + table?.Name + "Class.TDataClass) CurrentData)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl+2,"StringBuilder sql = new StringBuilder();" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"sql.Append(@\"INSERT INTO \");" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"sql.Append(TableName);" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"sql.Append(@\"(\");" + Nl));

                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? AppStrings.Format(lvl + 2, "sql.Append(@\"" + tfc.Name + ",\");" + Nl) : AppStrings.Format(lvl + 2, "sql.Append(@\"" + tfc.Name + ")\");" + Nl));
                }

                sb.Append(AppStrings.Format(lvl + 2, "sql.Append(\" VALUES (\");" + Nl));

                n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? AppStrings.Format(lvl + 2, "sql.Append(@\"@" + tfc.Name + ",\");" + Nl) : AppStrings.Format(lvl + 2, "sql.Append(@\"@" + tfc.Name + ")\");" + Nl));
                }

                sb.Append(AppStrings.Format(lvl+2,"ConnectionData.CreateCommand(sql.ToString());" + Nl));
                
                foreach (var tfc in table.Fields.Values)
                {                      
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl+2));                    
                }
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.Format(lvl+1,"ReturnInfo rt = ExecuteSQL();" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"if (rt.Done)" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"CurrentData.DataState = eDataState.NEUTRAL;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"return (rt);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Inserts object to database" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public override ReturnInfo InsertData()" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,"using (var dc = (" + table?.Name + "Class.TDataClass) CurrentData)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl+1));
                sb.Append(AppStrings.Format(lvl+2,"StringBuilder sql = new StringBuilder();" + Nl));                
                sb.Append(AppStrings.Format(lvl+2,"sql.Append(@\"INSERT INTO \");" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"sql.Append(TableName);" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"sql.Append(@\"(\");" + Nl));

                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? AppStrings.Format(lvl + 2, "sql.Append(@\"" + tfc.Name + ",\");" + Nl) : AppStrings.Format(lvl + 2, "sql.Append(@\"" + tfc.Name + ")\");" + Nl));
                }

                sb.Append(AppStrings.Format(lvl + 2, "sql.Append(@\" VALUES (\");" + Nl));

                n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? AppStrings.Format(lvl + 2, "sql.Append(@\"@" + tfc.Name + ",\");" + Nl) : AppStrings.Format(lvl + 2, "sql.Append(@\"@" + tfc.Name + ")\");" + Nl));
                }
              
                sb.Append(AppStrings.Format(lvl+2,"ConnectionData.CreateCommand(sql.ToString());" + Nl));
              
                foreach (var tfc in table.Fields.Values)
                {
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl+2));
                }
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.Format(lvl+1,"ReturnInfo rt = ExecuteSQL();" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"if (rt.Done)" + Nl));
                sb.Append(AppStrings.Format(lvl+2,"CurrentData.DataState = eDataState.NEUTRAL;" + Nl));
                sb.Append(AppStrings.Format(lvl+1,"return (rt);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateUpdateDataMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;

                sb.Append(AppStrings.Format(lvl,$@"/// <summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// Updates database with actual object{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// </summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"public override ReturnInfo UpdateData(){Nl}"));
                sb.Append(AppStrings.BlockStart(lvl));                
                sb.Append(AppStrings.Format(lvl+1,$@"using (var dc = ({table.Name}Class.TDataClass) CurrentData){Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"{bb}{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"var sql = new StringBuilder();{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append(@{a}UPDATE {a});{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append(TableName);{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append(@{a} SET {a});{Nl}"));
                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    string s1 = $@"sql.Append(@{a}{tfc.Name} = @{tfc.Name},{a});{Nl}";
                    string s2 = $@"sql.Append(@{a}{tfc.Name} = @{tfc.Name}{a});{Nl}";
                    sb.Append(++n < table.Fields.Count ? AppStrings.Format(lvl + 2, s1) : AppStrings.Format(lvl + 2, s2));
                }
                if((CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUID)||(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUIDHEX))
                {
                    if (table.primary_constraint != null)
                    {                        
                        string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                        if(!string.IsNullOrEmpty(fn))
                        {                             
                           sb.Append(AppStrings.Format(lvl+2,$@"sql.Append($@{a} WHERE {fn} = '{{dc.Item.{fn}}}'; {a});{Nl}"));
                        }
                    }
                    else
                    {
                        string fld = GetFirstTableField(((TableClass)obj).Fields);
                        _localNotifies?.AddToERROR($@"No PrimaryKey in Table {table.Name}, using field {fld} instead in method:  public override ReturnInfo UpdateData()");
                        sb.Append(AppStrings.Format(lvl + 2, $@"sql.Append($@{a} WHERE {fld} = '{{dc.Item.{fld}}}'; {a});{Nl}"));
                    }
                }
                else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenOID)
                {
                    if (table.primary_constraint != null)
                    {                        
                        string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                        if(!string.IsNullOrEmpty(fn))
                        {
                           sb.Append(AppStrings.Format(lvl+2,$@"sql.Append($@{a} WHERE {fn} = {{dc.Item.{fn}}}; {a});{Nl}"));
                        }
                    }
                    else
                    {
                        string fld = GetFirstTableField(((TableClass)obj).Fields);
                        _localNotifies?.AddToERROR($@"No PrimaryKey in Table {table.Name}, using field {fld} instead in method:  public override ReturnInfo UpdateData()");
                        sb.Append(AppStrings.Format(lvl+2,$@"sql.Append($@{a} WHERE {fld} = {{dc.Item.{fld}}}; {a});{Nl}"));
                    }
                }
                else
                {
                    if (table.primary_constraint != null)
                    {                       
                        string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                        if(!string.IsNullOrEmpty(fn))
                        { 
                            sb.Append(AppStrings.Format(lvl+2,$@"sql.Append($@{a} WHERE {fn} = {{dc.Item.{fn}}}; {a});{Nl}"));
                        }
                    }
                    else
                    {
                        string fld = GetFirstTableField(((TableClass)obj).Fields);
                        _localNotifies?.AddToERROR($@"No PrimaryKey in Table {table.Name}, using field {fld} instead in method:  public override ReturnInfo UpdateData()");
                        sb.Append(AppStrings.Format(lvl+2,$@"sql.Append($@{a} WHERE {fld} = {{dc.Item.{fld}}}; {a});{Nl}"));
                    }
                }
                sb.Append(AppStrings.Format(lvl+2,$@"ConnectionData.CreateCommand(sql.ToString());{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"//Fill parameters{Nl}"));
               
                foreach (var tfc in table.Fields.Values)
                {
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl+2));                    
                }

                sb.Append(AppStrings.Format(lvl+1,$@"{be}{Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"var rt = ExecuteSQL();{Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"if (rt.Done){Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"CurrentData.DataState = eDataState.NEUTRAL;{Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"return (rt);{Nl}"));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if(obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;

                sb.Append(AppStrings.Format(lvl,$@"/// <summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// Updates database with actual object{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// </summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"public override ReturnInfo UpdateData(){Nl}"));
                sb.Append(AppStrings.BlockStart(lvl));                
                sb.Append(AppStrings.Format(lvl+1,$@"using (var dc = ({table.Name}Class.TDataClass) CurrentData){Nl}"));
                sb.Append(AppStrings.Format(lvl+1, $@"{bb}{Nl}"));
                
                sb.Append(AppStrings.Format(lvl+2,$@"var sql = new StringBuilder();{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append(@{a}UPDATE {a});{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append(TableName);{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append(@{a} SET {a});{Nl}"));

                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    string s1 = $@"sql.Append(@{a}{tfc.Name} = @{tfc.Name},{a});{Nl}";
                    string s2 = $@"sql.Append(@{a}{tfc.Name} = @{tfc.Name}{a});{Nl}";
                    sb.Append(++n < table.Fields.Count ? AppStrings.Format(lvl + 2, s1) : AppStrings.Format(lvl + 2, s2));
                }                
                sb.Append(AppStrings.Format(lvl+2,$@"sql.Append($@{a} WHERE ID = {{dc.Item.ID}}; {a});{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"ConnectionData.CreateCommand(sql.ToString());{Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"//Fill parameters{Nl}"));
                foreach (var tfc in table.Fields.Values)
                {
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl+2));
                }
                sb.Append(AppStrings.Format(lvl+1,$@"{be}{Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"var rt = ExecuteSQL();{Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"if (rt.Done){Nl}"));
                sb.Append(AppStrings.Format(lvl+2,$@"CurrentData.DataState = eDataState.NEUTRAL;{Nl}"));
                sb.Append(AppStrings.Format(lvl+1,$@"return (rt);{Nl}"));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateGetDataMethods(int lvl,DataObjectClass obj )
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();

            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(AppStrings.Format(lvl, $@"/// <summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl, $@"/// Get's datas from database and fills and returns as object{Nl}"));
                sb.Append(AppStrings.Format(lvl, $@"/// </summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl, $@"/// <returns>object of TMainData</returns>{Nl}"));
                sb.Append(AppStrings.Format(lvl, $@"/// {Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"public override TMainData getDatas(){Nl}"));
                sb.Append(AppStrings.BlockStart(lvl));                
                sb.Append(AppStrings.Format(lvl+1,$@"using (TDataClass aktData = new TDataClass(DisplayMemberDef)){Nl}"));
                sb.Append(AppStrings.BlockStart(lvl+1));
                
                foreach (var tfc in table.Fields.Values)
                {                   
                    sb.Append(AppStrings.Format(lvl+2,$@"aktData.Item.{tfc.Name} = get{tfc.Name}();{Nl}"));
                }
                sb.Append(AppStrings.Format(lvl+2,$@"return ((TMainData)aktData);{Nl}"));
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(AppStrings.Format(lvl,$@"/// <summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// gets datas from database and fills and returns data object{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// </summary>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// <returns>Object of TMainData</returns>{Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"/// {Nl}"));
                sb.Append(AppStrings.Format(lvl,$@"public override TMainData getDatas(){Nl}"));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl+1,$@"using (var aktData = new TDataClass(DisplayMemberDef)){Nl}"));
                sb.Append(AppStrings.BlockStart(lvl+1));

                foreach (var tfc in table.Fields.Values)
                {                   
                    sb.Append(AppStrings.Format(lvl + 2, $@"aktData.Item.{tfc.Name} = get{tfc.Name}();{Nl}"));
                }
                sb.Append(AppStrings.Format(lvl+2,"return ((TMainData)aktData);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl+1));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateNewMethods(int lvl,DataObjectClass obj)
        {
            if(obj == null) return Empty;

            var sb = new StringBuilder();
            var newIdMethod = "GetNewID()";
            
            if (CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUID)
            {
                newIdMethod = "GetNewGUID()";
            }
            else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenUUID)
            {
                newIdMethod = "GetNewUUID()";
            }
            else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenOID)
            {
                newIdMethod = "GetNewOID()";
            }
            else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUIDHEX)
            {
                newIdMethod = "GetNewGUIDHEX()";
            }

            if (obj.GetType() != typeof(TableClass)) return sb.ToString();

            var table = obj as TableClass;
            
            sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// Creates new object with unique ID." + Nl));
            sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl,"/// <returns>Object of TDataClass</returns>" + Nl));
            sb.Append(AppStrings.Format(lvl,"public TDataClass GetNewData()" + Nl));
            sb.Append(AppStrings.BlockStart(lvl));
            sb.Append(AppStrings.Format(lvl+1,"var aktData = new TDataClass(DisplayMemberDef);" + Nl));
            sb.Append(AppStrings.Format(lvl+1,"try" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,"aktData.Clear();" + Nl));
            if (table?.primary_constraint == null)
            {
                string fld = GetFirstTableField(((TableClass)obj).Fields);
                _localNotifies?.AddToERROR($@"No PrimaryKey in Table {table.Name}, using field {fld} instead in method:  public TDataClass GetNewData()");
                sb.Append(AppStrings.Format(lvl+2,$@"aktData.Item.{fld} = {newIdMethod};" + Nl));
            }
            else
            {                
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                if(!string.IsNullOrEmpty(fn))
                { 
                    sb.Append(AppStrings.Format(lvl+2,$@"aktData.Item.{fn} = {newIdMethod};" + Nl));
                }
            }
            sb.Append(AppStrings.Format(lvl+2,"aktData.SetInsertMode();" + Nl));
            sb.Append(AppStrings.Format(lvl+2,"Datas.Clear();" + Nl));
            sb.Append(AppStrings.Format(lvl+2,"CurrentData = aktData;" + Nl));
            sb.Append(AppStrings.Format(lvl+2,"Datas.Add(aktData);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(AppStrings.Format(lvl+1,"catch (Exception ex)" + Nl));
            sb.Append(AppStrings.BlockStart(lvl+1));
            sb.Append(AppStrings.Format(lvl+2,$@"TMessages.Instance.HandleAndShowDBException(ex.Message,""{table.Name}Class->GetNewData()"");{Nl}"));
            sb.Append(AppStrings.Format(lvl+2,"Application.Exit();" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl+1));
            sb.Append(AppStrings.Format(lvl+1,"return (aktData);" + Nl));
            sb.Append(AppStrings.BlockEnd(lvl));
            sb.Append(Nl);

            //Gruppenbildung für ID geht nur bei Generierten ID's vom typ integer
            if (CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenID)
            {
                var newGroupIdMethod = "GetNewID(gruppe)";
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// Creates new object with unique ID." + Nl));
                sb.Append(AppStrings.Format(lvl, "/// Preceding an group-prefix to ID." + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// <returns>Object of TDataClass</returns>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public TDataClass GetNewData(int gruppe)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl));
                sb.Append(AppStrings.Format(lvl + 1, "var aktData = new TDataClass(DisplayMemberDef);" + Nl));
                sb.Append(AppStrings.Format(lvl + 1, "try" + Nl));
                sb.Append(AppStrings.BlockStart(lvl + 1));
                sb.Append(AppStrings.Format(lvl + 2, "aktData.Clear();" + Nl));
                if (table?.primary_constraint == null)
                {
                    string fld = GetFirstTableField(((TableClass)obj).Fields);
                    _localNotifies?.AddToERROR($@"No PrimaryKey in Table {table.Name}, using field {fld} instead in method:  public TDataClass GetNewData(int gruppe)");
                    sb.Append(AppStrings.Format(lvl + 2, $@"aktData.Item.{fld} = {newGroupIdMethod};" + Nl));
                }
                else
                {
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                    if (!string.IsNullOrEmpty(fn))
                    {
                        sb.Append(AppStrings.Format(lvl + 2, $@"aktData.Item.{fn} = {newGroupIdMethod};{Nl}"));
                    }
                }
                sb.Append(AppStrings.Format(lvl + 2, "aktData.SetInsertMode();" + Nl));
                sb.Append(AppStrings.Format(lvl + 2, "Datas.Clear();" + Nl));
                sb.Append(AppStrings.Format(lvl + 2, "CurrentData = aktData;" + Nl));
                sb.Append(AppStrings.Format(lvl + 2, "Datas.Add(aktData);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl + 1));
                sb.Append(AppStrings.Format(lvl + 1, "catch (Exception ex)" + Nl));
                sb.Append(AppStrings.BlockStart(lvl + 1));
                sb.Append(AppStrings.Format(lvl + 2, $@"TMessages.Instance.HandleAndShowDBException(ex.Message,""{table.Name}Class->GetNewData(gruppe)"");{Nl}"));
                sb.Append(AppStrings.Format(lvl + 2, "Application.Exit();" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl + 1));
                sb.Append(AppStrings.Format(lvl + 1, "return(aktData);" + Nl));
                sb.Append(AppStrings.BlockEnd(lvl));
            }
            return sb.ToString();
        }

        public string CreateFieldEnum(int lvl,DataObjectClass obj)
        {
            if(obj == null) return Empty;

            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(AppStrings.Format(lvl,"/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// Enum of available dataindexes" + Nl));
                sb.Append(AppStrings.Format(lvl,"/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl,"public enum eTDataClass {"));
                int n = 0;
                
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append($@"{tfc.Name} = {n++},");
                }
                sb.Append($@"NO_FIELD = {n}");
                sb.Append(AppStrings.BlockEnd(0));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// Enum of available dataindexes" + Nl));
                sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
                sb.Append(AppStrings.Format(lvl, "public enum eTDataClass {"));
                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {                    
                    sb.Append($@"{tfc.Name} = {n++},");
                }
                sb.Append($@"NO_FIELD = {n}");
                sb.Append(AppStrings.BlockEnd(0));
            }
            return sb.ToString();
        }

        public string CreateCopyright(int lvl, string tablename)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl, "#pragma warning disable 1587" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// <summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// ###############################################################################################" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// # C# Codegenerator for Tableobjects V6.0.0                                                    #" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// # Copyright (c) by SoftEnd, Horst Ender, Finkenweg 5, 96215 Lichtenfels - All Rights Reserved #" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// #                                                                                             #" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// # Unauthorized copying or manipulating of this file, via any medium is strictly prohibited    #" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// # Proprietary and confidential                                                                #" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// #                                                                                             #" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// # Date    : " + String.Format("{0,-82}#{1}", DateTime.Now.ToString("s"),Nl)));
            sb.Append(AppStrings.Format(lvl, "/// # Class   : " + String.Format("{0,-82}#{1}", tablename+ "Class", Nl)));
            sb.Append(AppStrings.Format(lvl, "/// # Base    : " + String.Format("{0,-82}#{1}",_basename, Nl)));
            sb.Append(AppStrings.Format(lvl, "/// # PK type : " + String.Format("{0,-82}#{1}",CodeCreateAttribute.PrimaryFieldType.ToString(),Nl)));
            sb.Append(AppStrings.Format(lvl, "/// ###############################################################################################" + Nl));
            sb.Append(AppStrings.Format(lvl, "/// </summary>" + Nl));
            sb.Append(AppStrings.Format(lvl, "#pragma warning restore 1587" + Nl));
            return sb.ToString();
        }

        public string CreateTableUsings(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl, "#region Using directives" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Collections;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.IO;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Text;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Xml.Serialization;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Xml;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Windows.Forms;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using DBBasicClassLibrary;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using MessageLibrary.Messages;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using BasicClassLibrary;" + Nl));
            sb.Append(AppStrings.Format(lvl, "#endregion" + Nl));
            return sb.ToString();
        }

        public string CreateViewUsings(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl, "#region Using directives" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Collections;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.IO;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Text;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Xml.Serialization;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Xml;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using System.Windows.Forms;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using DBBasicClassLibrary;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using MessageLibrary.Messages;" + Nl));
            sb.Append(AppStrings.Format(lvl, "using BasicClassLibrary;" + Nl));
            sb.Append(AppStrings.Format(lvl, "#endregion" + Nl));
            return sb.ToString();
        }

        public string CreateCbTableUsings(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(AppStrings.Format(lvl,"#region Using directives" + Nl));
            sb.Append(AppStrings.Format(lvl,"using System;" + Nl));
            sb.Append(AppStrings.Format(lvl,"using System.Windows.Forms;" + Nl));
            sb.Append(AppStrings.Format(lvl,"using DBBasicClassLibrary;" + Nl));
            sb.Append(AppStrings.Format(lvl,"#endregion" + Nl));
            return sb.ToString();
        }
    }
}
