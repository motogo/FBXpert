using FBExpert.DataClasses;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using FBXpert.Globals;
using static System.String;
using BasicClassLibrary;
using SEListBox;

namespace FBXpert.DataClasses
{
    public enum eLogicalType {TEXT=0,NUMBER=1,POINTNUMBER=2,DATE=3,TIMESTAMP=4,NULLABLEPOINTER=5,BOOL=6,BINARY=7,NONE=8};
    [Serializable]
    public class DatabaseDesignClass
    {
        public DBRegistrationClass Database;
        public Dictionary<string,TableClass> Tables;
        public Dictionary<string,ViewClass> Views;
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
            string fvar = field.Name + ".ToString()";
            var ltype = TypeConvert.ToLogicalType(field.Domain);
            if (ltype == eLogicalType.TIMESTAMP)
            {
                fvar = field.Name + ".ToShortDateString() + \"  \" +" + field.Name + ".ToLongTimeString()";
            }
            else if (ltype == eLogicalType.DATE)
            {
                fvar = field.Name + ".ToShortDateString()";
            }
            return fvar;
        }

        public string ToStringMethod2(FieldClass field)
        {
            string fvar = "{"+field.Name+"}";
            var ltype = TypeConvert.ToLogicalType(field.Domain);
            if (ltype == eLogicalType.TIMESTAMP)
            {
                fvar = "{"+field.Name + ".ToShortDateString()} {"+field.Name + ".ToLongTimeString()}";
            }
            else if (ltype == eLogicalType.DATE)
            {
                fvar = "{"+field.Name + ".ToShortDateString()}";
            }
            return fvar;
        }

        public string CreateToKeyStringMethod(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(Format(lvl,"            public string ToKeyString()" + Nl));
                sb.Append(Format(lvl,"            {" + Nl));
                sb.Append(Format(lvl+1,"                var txt = string.Empty;" + Nl));
                sb.Append(Format(lvl+1,"                eTDataClass DP = (eTDataClass)DisplayMemberData.KeyIndex;" + Nl));
                sb.Append(Format(lvl+1,"                switch (DP)" + Nl));
                sb.Append(Format(lvl+1,"                {" + Nl));
                sb.Append(Format(lvl+2,"                    case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(Format(lvl+5,"                        txt = string.Empty;" + Nl));
                sb.Append(Format(lvl+5,"                        break;" + Nl));
                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod(field);

                    sb.Append(Format(lvl+2,"                    case eTDataClass." + field.Name + ":" + Nl));
                    sb.Append(Format(lvl+5,"                        txt = " + fvar + ";" + Nl));
                    sb.Append(Format(lvl+5,"                        break;" + Nl));
                }
                sb.Append(Format(lvl+1,"                }" + Nl));
                sb.Append(Format(lvl+1,"                return txt;" + Nl));
                sb.Append(Format(lvl,"            }" + Nl)); 
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(Format(lvl,"            public string ToKeyString()" + Nl));
                sb.Append(Format(lvl,"            {" + Nl));
                sb.Append(Format(lvl+1,"                var txt = string.Empty;" + Nl));
                sb.Append(Format(lvl+1,"                eTDataClass DP = (eTDataClass)DisplayMemberData.KeyIndex;" + Nl));
                sb.Append(Format(lvl+1,"                switch (DP)" + Nl));
                sb.Append(Format(lvl+1,"                {" + Nl));
                sb.Append(Format(lvl+2,"                    case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(Format(lvl+5,"                        txt = string.Empty;" + Nl));
                sb.Append(Format(lvl+5,"                        break;" + Nl));
                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod(field);                    
                    sb.Append(Format(lvl+2,"                    case eTDataClass." + field.Name + ":" + Nl));
                    sb.Append(Format(lvl+5,"                        txt = " + fvar + ";" + Nl));
                    sb.Append(Format(lvl+5,"                        break;" + Nl));
                }
                sb.Append(Format(lvl+1,"                }" + Nl));
                sb.Append(Format(lvl+1,"                return txt;" + Nl));
                sb.Append(Format(lvl,"            }" + Nl)); 
            }
            return sb.ToString();
        }

        public string CreateToStringMethod(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(Format(lvl,"                    public override string ToString()" + Nl));
                sb.Append(Format(lvl,"                    {" + Nl));
                sb.Append(Format(lvl+1,"                        eTDataClass DP;" + Nl));
                sb.Append(Format(lvl+1,"                        StringBuilder txt = new StringBuilder();" + Nl));
                sb.Append(Format(lvl+1, "                        string first = string.Empty;" + Nl));
                sb.Append(Format(lvl+1, "                        string last = string.Empty;" + Nl));
                sb.Append(Format(lvl+1, "                        for (int i = 0; i < (int)DisplayMemberData.DataLength; i++)" + Nl));
                sb.Append(Format(lvl+1, "                        {" + Nl));
                sb.Append(Format(lvl+2, "                            if (DisplayMemberData.BorderStart[i].Length > 0)" + Nl));
                sb.Append(Format(lvl+3, "                                first = DisplayMemberData.BorderStart[i];" + Nl));
                sb.Append(Format(lvl+2,"                            else" + Nl));
                sb.Append(Format(lvl+3,"                                first = string.Empty;" + Nl));
                sb.Append(Format(lvl+2,"                            if (DisplayMemberData.BorderEnd[i].Length > 0)" + Nl));
                sb.Append(Format(lvl+3,"                                last = DisplayMemberData.BorderEnd[i];" + Nl));
                sb.Append(Format(lvl+2,"                            else" + Nl));
                sb.Append(Format(lvl+3,"                                last = string.Empty;" + Nl));
                sb.Append(Format(lvl+2,"                            DP = (eTDataClass)DisplayMemberData.Data[i];" + Nl));
                sb.Append(Format(lvl+2,"                            switch (DP)" + Nl));
                sb.Append(Format(lvl+2,"                            {" + Nl));
                sb.Append(Format(lvl+3,"                                case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(Format(lvl+6,"                                i = (int)DisplayMemberData.DataLength;" + Nl));
                sb.Append(Format(lvl+6,"                                break;" + Nl));

                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod2(field);

                    sb.Append(Format(lvl+3,"                                case eTDataClass." + field.Name + ":" + Nl));
                    //sb.Append(Format(lvl+6,"                                txt.Append(DisplayMemberData.FormatMember(first + " + fvar + " + last, DisplayMemberData.Format[i]));" + Nl));
                    sb.Append(Format(lvl+6,"                                txt.Append(DisplayMemberData.FormatMember($@\"{first}" + fvar + "{last}\", DisplayMemberData.Format[i]));" + Nl));
                    sb.Append(Format(lvl+6,"                                break;" + Nl));
                }

                sb.Append(Format(lvl+2,"                            }" + Nl));
                sb.Append(Format(lvl+1,"                        }" + Nl));
                sb.Append(Nl);                

                sb.Append(Format(lvl+1,"                        if(_translateToString) return LanguageClass.Instance().GetString(txt.ToString());" + Nl));
                sb.Append(Format(lvl+1,"                        return (txt.ToString());" + Nl));
                sb.Append(Format(lvl,"                    } //method ToString" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;

                sb.Append(Format(lvl,"                    public override string ToString()" + Nl));
                sb.Append(Format(lvl,"                    {" + Nl));
                sb.Append(Format(lvl+1,"                        eTDataClass DP;" + Nl));
                sb.Append(Format(lvl+1, "                        StringBuilder txt = new StringBuilder();" + Nl));
                sb.Append(Format(lvl+1,"                        string first = string.Empty;" + Nl));
                sb.Append(Format(lvl+1,"                        string last = string.Empty;" + Nl));
                sb.Append(Format(lvl+1,"                        for (int i = 0; i < (int)DisplayMemberData.DataLength; i++)" + Nl));
                sb.Append(Format(lvl+1,"                        {" + Nl));
                sb.Append(Format(lvl+2,"                            if (DisplayMemberData.BorderStart[i].Length > 0)" + Nl));
                sb.Append(Format(lvl+3,"                                first = DisplayMemberData.BorderStart[i];" + Nl));
                sb.Append(Format(lvl+2,"                            else" + Nl));
                sb.Append(Format(lvl+3,"                                first = string.Empty;" + Nl));
                sb.Append(Format(lvl+2,"                            if (DisplayMemberData.BorderEnd[i].Length > 0)" + Nl));
                sb.Append(Format(lvl+3,"                                last = DisplayMemberData.BorderEnd[i];" + Nl));
                sb.Append(Format(lvl+2,"                            else" + Nl));
                sb.Append(Format(lvl+3,"                                last = string.Empty;" + Nl));
                sb.Append(Format(lvl+2,"                            DP = (eTDataClass)DisplayMemberData.Data[i];" + Nl));
                sb.Append(Format(lvl+2,"                            switch (DP)" + Nl));
                sb.Append(Format(lvl+2,"                            {" + Nl));
                sb.Append(Format(lvl+3,"                                case eTDataClass.NO_FIELD:" + Nl));
                sb.Append(Format(lvl+6,"                                i = (int)DisplayMemberData.DataLength;" + Nl));
                sb.Append(Format(lvl+6,"                                break;" + Nl));

                foreach (var field in table.Fields.Values)
                {
                    string fvar = ToStringMethod2(field);

                    sb.Append(Format(lvl+3,"                                case eTDataClass." + field.Name + ":" + Nl));
                    //sb.Append(Format(lvl+6,"                                txt.Append(DisplayMemberData.FormatMember(first + " + fvar + " + last, DisplayMemberData.Format[i]));" + Nl));
                    sb.Append(Format(lvl+6,"                                txt.Append(DisplayMemberData.FormatMember($@\"{first}" + fvar + "{last}\", DisplayMemberData.Format[i]));" + Nl));
                    sb.Append(Format(lvl+6,"                                break;" + Nl));
                }
                sb.Append(Format(lvl+2,"                            }" + Nl));
                sb.Append(Format(lvl+1,"                        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl+1,"                        return (txt.ToString());" + Nl));
                sb.Append(Format(lvl,"                    } //method ToString" + Nl));
            }
            return (sb.ToString());
        }
                
        public string Frm(int lvl)
        {            
            return "{0," + lvl * 4 + "}{1}";
        }
                
        public string BlockStart(int i)
        {                        
            return Format(i, "{ " + Nl);            
        }

        public string BlockEnd(int i)
        {                       
             return Format(i, "} " + Nl);
        }

        public string Format(int lvl, string txt)
        {
            return String.Format(Frm(lvl), "", txt.Trim(' '));
        }

        public string CreateMethodCloneIt(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            /*
            sb.Append(Format(lvl,"public object CloneIt(TColumns clm)" + Nl));
            sb.Append(BlockStart(lvl));   
            sb.Append(Nl);
            sb.Append(Format(lvl+1, "clm = this.MemberwiseClone() as " + tc.Name + "Class.TDataClass.TColumns;" + Nl));
            sb.Append(Format(lvl + 1, "return clm;" + Nl));            
            sb.Append(BlockEnd(lvl));
            sb.Append(Nl);            
            */
            sb.Append(Format(lvl,"public void DeepCloneFrom(TColumns clm)" + Nl));
            sb.Append(BlockStart(lvl));   
            sb.Append(Nl);

            if (tc.GetType() == typeof(TableClass))
            {
                var tb = tc as TableClass;                
                foreach (var tfc in tb.Fields.Values)
                {
                    sb.Append(Format(lvl+1, $@"           this.{tfc.Name}=clm.{tfc.Name};" + Nl));
                }
            }
                      
            sb.Append(BlockEnd(lvl));
            sb.Append(Nl); 

            sb.Append(Format(lvl,"public void DeepCloneTo(TColumns clm)" + Nl));
            sb.Append(BlockStart(lvl));   
            sb.Append(Nl);

            if (tc.GetType() == typeof(TableClass))
            {
                var tb = tc as TableClass;                
                foreach (var tfc in tb.Fields.Values)
                {
                    sb.Append(Format(lvl+1, $@"           clm.{tfc.Name}=this.{tfc.Name};" + Nl));
                }
            }
                      
            sb.Append(BlockEnd(lvl));
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

                sb.Append(Format(lvl, $@"public object[] DataList = new object[(int)eTDataClass.NO_FIELD];{Nl}"));
                foreach (var tfc in tc.Fields.Values)
                {
                    string cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    string cstypecast = DatabaseTOcsharpCast(tfc.Domain);
                    cstypecast = cstypecast.Replace("#data#", $@"DataList[(int)eTDataClass.{tfc.Name}]");
                    sb.Append(Format(lvl, $@"public {cstype} {tfc.Name} {{ get => {cstypecast} set => DataList[(int)eTDataClass.{tfc.Name}] = value; }}{Nl}"));                    
                }
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var tc = obj as ViewClass;
                sb.Append(Nl);
                sb.Append(Format(lvl + 1, $@"public object[] DataList = new object[(int)eTDataClass.NO_FIELD];{Nl}"));
                foreach (var tfc in tc.Fields.Values)
                {                    
                    string cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    string cstypecast = DatabaseTOcsharpCast(tfc.Domain);
                    cstypecast = cstypecast.Replace("#data#", $@"DataList[(int)eTDataClass.{tfc.Name}]");
                    sb.Append(Format(lvl, $@"public {cstype} {tfc.Name} {{ get => {cstypecast} set => DataList[(int)eTDataClass.{tfc.Name}] = value; }}{Nl}"));                    
                }
            }
            return sb.ToString();
        }

        public string Nl => Environment.NewLine;

        public string CreateTColumnsClass(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl,                 "#region class TColumns" + Nl));
            sb.Append(Format(lvl,                 "/// <inheritdoc />" + Nl));
            sb.Append(Format(lvl,                 "/// <summary>" + Nl));
            sb.Append(Format(lvl,                 "/// Inner class represents table datas" + Nl));
            sb.Append(Format(lvl,                 "/// </summary>" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,                 "public class TColumns : TMainColumns" + Nl));
            sb.Append(BlockStart(lvl));
            sb.Append(Format(lvl+1,               "public TColumns(DisplayMembers dmp)" + Nl));
            sb.Append(BlockStart(lvl+1));
            sb.Append(Format(lvl+2,               "DisplayMemberData = dmp;" + Nl));
            sb.Append(BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(Format(lvl+1, "                public TColumns()" + Nl));
            sb.Append(BlockStart(lvl+1));
            sb.Append(BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(Format(lvl+1, "                public void SetDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(BlockStart(lvl+1));
            sb.Append(Format(lvl+2, "                DisplayMemberData = dpm;" + Nl));
            sb.Append(BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(Format(lvl+1, "                public TColumns Clone(DisplayMembers dpm)" + Nl));
            sb.Append(BlockStart(lvl+1));
            sb.Append(Format(lvl+2, "                var cloned = new TColumns(dpm);" + Nl));
            sb.Append(Format(lvl+2, "                DeepCloneTo(cloned);" + Nl));
            sb.Append(Format(lvl+2, "                return (cloned);" + Nl));
            sb.Append(BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(Format(lvl+1, "                public TColumns Clone()" + Nl));
            sb.Append(BlockStart(lvl+1));            
            sb.Append(Format(lvl+2, "                return (MemberwiseClone() as "+obj.Name+ "Class.TDataClass.TColumns);" + Nl));
            sb.Append(BlockEnd(lvl+1));
            sb.Append(Nl);
            sb.Append(CreateMethodCloneIt(lvl + 1, obj));
            sb.Append(Nl);

            sb.Append(CreateGetSetFieldAttributes(lvl + 1, obj));
            sb.Append(Nl);
            sb.Append(Format(lvl+1, "#region ToStringMethods" + Nl));

            sb.Append(CreateToStringMethod(lvl+1,obj));
            sb.Append(Nl);
            sb.Append(CreateToKeyStringMethod(lvl+1,obj));
            sb.Append(Format(lvl+1, "#endregion ToStringMethods" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "            }" + Nl));
            sb.Append(Format(lvl, "#endregion class TColumns" + Nl));
            return sb.ToString();
        }

        public string CreateTableClassConstructor(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;

            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {                
                var table = obj;
                sb.Append(Format(lvl, "        /// <summary>" + Nl));
                sb.Append(Format(lvl, "        /// First constructor" + Nl));
                sb.Append(Format(lvl, "        /// </summary>" + Nl));
                sb.Append(Format(lvl, "        public " + table.Name + "Class(ConnectionClass con, bool usetrans) : base(con, usetrans)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));
                sb.Append(Format(lvl+1, "        TableName = \"" + table.Name + "\";" + Nl));
                sb.Append(Format(lvl+1, "        DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl, "        /// <summary>" + Nl));
                sb.Append(Format(lvl, "        /// Second constructor" + Nl));
                sb.Append(Format(lvl, "        /// </summary>" + Nl));
                sb.Append(Format(lvl, "        public " + table.Name + "Class(ConnectionClass con) : base(con, DefaultUseTransactions)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));
                sb.Append(Format(lvl+1, "        TableName = \"" + table.Name + "\";" + Nl));
                sb.Append(Format(lvl+1, "        DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(Format(lvl, "        /// <summary>" + Nl));
                sb.Append(Format(lvl, "        /// First constuctor" + Nl));
                sb.Append(Format(lvl, "        /// </summary>" + Nl));
                sb.Append(Format(lvl, "        public " + table.Name + "Class(ConnectionClass con, bool usetrans) : base(con, usetrans)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));
                sb.Append(Format(lvl+1, "        TableName = \"" + table.Name + "\";" + Nl));
                sb.Append(Format(lvl+1, "        DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl, "        /// <summary>" + Nl));
                sb.Append(Format(lvl, "        /// Second constructor" + Nl));
                sb.Append(Format(lvl, "        /// </summary>" + Nl));
                sb.Append(Format(lvl, "        public " + table.Name + "Class(ConnectionClass con) : base(con, DefaultUseTransactions)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));
                sb.Append(Format(lvl+1, "        TableName = \"" + table.Name + "\";" + Nl));
                sb.Append(Format(lvl+1, "        DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));
            }
            return sb.ToString();
        }

        public string CreateDataClassConstructor(int lvl, DataObjectClass obj)
        {
            if (obj == null) return Empty;
            var sb = new StringBuilder();

            if (obj.GetType() == typeof(TableClass))
            {
                TableClass table = obj as TableClass;
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Constuctor of data class" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public TDataClass()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        if (DisplayMemberDef == null)" + Nl));
                sb.Append(Format(lvl+1,"        {" + Nl));
                sb.Append(Format(lvl+2,"        DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(Format(lvl+2,"        DisplayMemberDef.Data[0] = 1;" + Nl));
                sb.Append(Format(lvl+2,"        for (int i = 1; i < ((int)eTDataClass.NO_FIELD) - 1; i++)" + Nl));
                sb.Append(Format(lvl+2,"        {" + Nl));
                sb.Append(Format(lvl+3,"        DisplayMemberDef.Data[i] = (int)eTDataClass.NO_FIELD;" + Nl));
                sb.Append(Format(lvl+2,"        }" + Nl));
                sb.Append(Format(lvl+1,"        }" + Nl));
                sb.Append(Format(lvl+1,"        Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl,"        public TDataClass(DisplayMembers dpm)" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        DisplayMemberDef = dpm;" + Nl));
                sb.Append(Format(lvl+1,"        Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Destructor of data class" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        ~TDataClass()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        // Destructor" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
                
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Constuctor of data class" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public TDataClass()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        if (DisplayMemberDef == null)" + Nl));
                sb.Append(Format(lvl+1,"        {" + Nl));
                sb.Append(Format(lvl+2,"        DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
                sb.Append(Format(lvl+2,"        DisplayMemberDef.Data[0] = 1;" + Nl));
                sb.Append(Format(lvl+2,"        for (int i = 1; i < ((int)eTDataClass.NO_FIELD) - 1; i++)" + Nl));
                sb.Append(Format(lvl+2,"        {" + Nl));
                sb.Append(Format(lvl+3,"        DisplayMemberDef.Data[i] = (int)eTDataClass.NO_FIELD;" + Nl));
                sb.Append(Format(lvl+2,"        }" + Nl));
                sb.Append(Format(lvl+1,"        }" + Nl));
                sb.Append(Format(lvl+1,"        Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl,"        public TDataClass(DisplayMembers dpm)" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        DisplayMemberDef = dpm;" + Nl));
                sb.Append(Format(lvl+1,"        Item = new TColumns(DisplayMemberDef);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Destructor of data class" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        ~TDataClass()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        // Destructor" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
                
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

                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Empty an data object" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public override void Clear()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                foreach (var tfc in table.Fields.Values)
                {                    
                    sb.Append(Format(lvl+1,"        Item." + tfc.Name + " = " + TypeConvert.ToDefaultEmpty(tfc.Domain) + ";" + Nl));                    
                }
                sb.Append(Format(lvl+1, "        DataState = eDataState.EMPTY;" + Nl));
                sb.Append(Format(lvl,"        }"+ Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var view = obj as ViewClass;

                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Setzt den Dateninhalt eines Objectes auf leer." + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public override void Clear()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                foreach (var tfc in  view.Fields.Values)
                {
                    sb.Append(Format(lvl+1,"        Item." + tfc.Name + " = " + TypeConvert.ToDefaultEmpty(tfc.Domain) + ";" + Nl));                    
                }
                sb.Append(Format(lvl+1, "        DataState = eDataState.EMPTY;" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
            }
            return sb.ToString();
        }

        public string CreateSerializeMethods(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Serializing an object to XML" + Nl));
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        public void Serialize(string fileName)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        var serializer = new XmlSerializer(typeof(TDataClass.TColumns));" + Nl));           
            sb.Append(Format(lvl+1,"        var q1 = new XmlQualifiedName(\"\", \"\");" + Nl));
            sb.Append(Format(lvl+1,"        XmlQualifiedName[] names = { q1 };" + Nl));
            sb.Append(Format(lvl+1,"        var test = new XmlSerializerNamespaces(names);" + Nl));
            sb.Append(Format(lvl+1,"        using (var writer = new FileStream(fileName, FileMode.Create))" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));                       
            sb.Append(Format(lvl+2,"        foreach (var aktData in Datas)" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));            
            sb.Append(Format(lvl+3,"        serializer.Serialize(writer, ((TDataClass)aktData).Item, test);" + Nl));
            sb.Append(Format(lvl+3,"        writer.WriteByte(13);" + Nl));
            sb.Append(Format(lvl+3,"        writer.WriteByte(10);" + Nl));            
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+2,"        writer.Close();" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));            
            sb.Append(Format(lvl,"        }" + Nl));

            return sb.ToString();
        }

        public string CreateColumsSerializingMethods(int lvl)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Getting Item object from XML" + Nl));
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        public void DeserializeCurrent(string fileName)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        var serializer = new XmlSerializer(typeof(TColumns));" + Nl));
            sb.Append(Format(lvl+1,"        var fs = new FileStream(fileName, FileMode.Open);" + Nl));
            sb.Append(Format(lvl+1,"        using (var reader = new XmlTextReader(fs))" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        try" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        Item = (TColumns)serializer.Deserialize(reader);" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+2,"        catch" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+2,"        finally" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        reader.Close();" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));

            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Serialize Item object to XML" + Nl));
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        public void SerializeCurrent(string fileName)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        var serializer = new XmlSerializer(typeof(TColumns));" + Nl));
            sb.Append(Format(lvl+1,"        var q1 = new XmlQualifiedName(\"\", \"\");" + Nl));
            sb.Append(Format(lvl+1,"        XmlQualifiedName[] names = { q1 };" + Nl));
            sb.Append(Format(lvl+1,"        var test = new XmlSerializerNamespaces(names);" + Nl));
            sb.Append(Format(lvl+1,"        using (var writer = new FileStream(fileName, FileMode.Create))" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));             
            sb.Append(Format(lvl+2,"        try" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        serializer.Serialize(writer, Item, test);" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+2,"        catch" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+2,"        finally" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        writer.Close();" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));

            return sb.ToString();
        }

        public string MakeGlobalCode(List<ItemDataClass> items)
        {
           // object items = selDBObjects.CheckedItemDatas;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using DBBasicClassLibrary;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace " + CodeCreateAttribute.CodeNamespace);            
            sb.AppendLine("{");
            sb.AppendLine("    public class DBGlobalFunctionClass");
            sb.AppendLine("    {");
            sb.AppendLine("        public string[] DeleteDatabaseAllDatas(string cname)");
            sb.AppendLine("        {");
            sb.AppendLine("            List<string> lst = new List<string>();");
            sb.AppendLine("            DBProviderSet DB = new DBProviderSet(cname);");
            sb.AppendLine("            string cmd = string.Empty;");
            sb.AppendLine("            int n;");
            sb.AppendLine("  ");
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
                        sb.AppendLine(" ");
                        sb.AppendLine($@"//      {i}.Table");
                        sb.AppendLine("            cmd = \"DELETE FROM "+tc.Name+"\";");
                        sb.AppendLine("            n = DB.ExecuteCommand(cmd);");            
                        sb.AppendLine("            lst.Add($@\"{cmd}->{n}\");");
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
                        sb.AppendLine(" ");
                        sb.AppendLine($@"//      {i}.Table");
                        sb.AppendLine("            cmd = \"DELETE FROM "+tc.Name+"\";");
                        sb.AppendLine("            n = DB.ExecuteCommand(cmd);");            
                        sb.AppendLine("            lst.Add($@\"{cmd}->{n}\");");
                    }
                }
            }  



            sb.AppendLine("            return lst.ToArray();");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        public string CreateDesignForTable(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(CreateTableUsings(lvl));
            sb.Append(CreateCopyright(lvl,tc.Name));
            sb.Append(Format(lvl, "namespace " + CodeCreateAttribute.CodeNamespace + Nl));
            sb.Append(Format(lvl, "{" + Nl));
            sb.Append(Nl);
           
            sb.Append(Format(lvl+1, "    /// <summary>" + Nl));
            sb.Append(Format(lvl+1, "    /// Object data class for relational database datas " + tc.Name + Nl));            
            sb.Append(Format(lvl+1, "    /// </summary>" + Nl));
            sb.Append(Format(lvl+1, "    ///" + Nl));
            sb.Append(Format(lvl+1, "    public class " +tc.Name+"Class : TDataBasis" + Nl));
            sb.Append(Format(lvl+1, "    {" + Nl));
            sb.Append(Nl);

            sb.Append(CreateFieldEnum(lvl + 2, tc));
            sb.Append(Nl);
            sb.Append(Format(lvl+2, "        private static bool _translateToString = false;"+Nl));
            sb.Append(Format(lvl+2, "        public static bool TranslateToStringResult{get => _translateToString; set =>  _translateToString = value; }"+Nl));
            sb.Append(Format(lvl+2, "        public static int ColCount = (int)eTDataClass.NO_FIELD;" + Nl));
            sb.Append(Nl);

            sb.Append(Format(lvl+2, "        #region class TDataClass" + Nl));
            sb.Append(Format(lvl+2, "        public class TDataClass : TMainData" + Nl));
            sb.Append(Format(lvl+2, "        {" + Nl));
            sb.Append(Format(lvl+3, "        public DisplayMembers DisplayMemberDef = new DisplayMembers(((int)eTDataClass.NO_FIELD) - 1);" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+3, "        public void SetDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(Format(lvl+3, "        {" + Nl));            
            sb.Append(Format(lvl+4, "        DisplayMemberDef = dpm;" + Nl));
            sb.Append(Format(lvl+4, "        Item.SetDisplayMembers(DisplayMemberDef);" + Nl));
            sb.Append(Format(lvl+3, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+3, "        public override string ToString()" + Nl));
            sb.Append(Format(lvl+3, "        {" + Nl));
            sb.Append(Format(lvl+4, "        if (Item != null) return (Item.ToString());" + Nl));
            sb.Append(Format(lvl+4, "        return (\"Object not available (null)\");" + Nl));
            sb.Append(Format(lvl+3, "        }" + Nl));
            sb.Append(Nl);
            
            sb.Append(CreateTColumnsClass(lvl+3,tc));
            sb.Append(Nl);

            sb.Append(Format(lvl+3, "        public TColumns Item;" + Nl));
            sb.Append(Nl);

            sb.Append(CreateDataClassConstructor(lvl+3,tc));
            sb.Append(Nl);

            sb.Append(CreateTableClearMethod(lvl+3,tc));
            sb.Append(Nl);

            sb.Append(CreateColumsSerializingMethods(lvl+3));
            sb.Append(Nl);

            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+2,"        #endregion class TDataClass" + Nl));
            sb.Append(Nl);
            
            sb.Append(CreateNewMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateSerializeMethods(lvl+2));
            sb.Append(Nl);

            sb.Append(CreateTableClassConstructor(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateFieldGetMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateGetDataMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(Format(lvl+2, "#region class update/insert/delete methods" + Nl));
            sb.Append(CreateUpdateDataMethods(lvl+2,tc));
            sb.Append(Nl);

            sb.Append(CreateInsertDataMethods(lvl+2,tc));

            sb.Append(CreateDeleteDataMethods(lvl + 2, tc));
            sb.Append(Nl);

            sb.Append(Format(lvl+2, "#endregion class update/insert/delete methods" + Nl));
            sb.Append(Nl);

            sb.Append(CreateMiscMethods(lvl+2,tc));
            sb.Append(Nl);
                        
            sb.Append(Format(lvl+1,"}  //class" + Nl));
            sb.Append(Format(lvl,"}      //namespace" + Nl));
            return sb.ToString();
        }

        public string CreateSearchSchluessel(int lvl,DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "        public override void Search_SCHLUESSEL(SELibraries.WindowsForms.SEComboBox cb)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        " + tc.Name + "Class.TDataClass.TColumns data;" + Nl));
            sb.Append(Format(lvl+1, "        string ky;" + Nl));           
            sb.Append(Format(lvl+1, "        if (!cb.Text.EndsWith(\"*\"))" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+2, "        {" + Nl));
            sb.Append(Format(lvl+3, "        data = (" + tc.Name + "Class.TDataClass.TColumns)cb.Items[i];" + Nl));
            sb.Append(Format(lvl+3, "        ky = data.ToKeyString();" + Nl));
            sb.Append(Format(lvl+3, "        if (ky != cb.Text) continue;" + Nl));           
            sb.Append(Format(lvl+3, "        cb.SelectedIndex = i;" + Nl));
            sb.Append(Format(lvl+3, "        break;" + Nl));           
            sb.Append(Format(lvl+2, "        }" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl+1, "        else" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        cb.Text = cb.Text.Substring(0, cb.Text.Length - 1);" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Nl);           
            sb.Append(Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        data = (" + tc.Name + "Class.TDataClass.TColumns)cb.Items[i];" + Nl));
            sb.Append(Format(lvl+2, "        ky = data.ToKeyString();" + Nl));
            sb.Append(Format(lvl+2, "        if (!ky.StartsWith(cb.Text)) continue;" + Nl));           
            sb.Append(Format(lvl+2, "        cb.SelectedIndex = i;" + Nl));
            sb.Append(Format(lvl+2, "        break;" + Nl));           
            sb.Append(Format(lvl+1, "        }" + Nl));           
            sb.Append(Nl);           
            sb.Append(Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        data = (" + tc.Name + "Class.TDataClass.TColumns)cb.Items[i];" + Nl));
            sb.Append(Format(lvl+2, "        ky = data.ToKeyString();" + Nl));
            sb.Append(Format(lvl+2, "        if (ky.IndexOf(cb.Text, StringComparison.Ordinal) < 0) continue;" + Nl));            
            sb.Append(Format(lvl+2, "        cb.SelectedIndex = i;" + Nl));
            sb.Append(Format(lvl+2, "        break;" + Nl));            
            sb.Append(Format(lvl+1, "        }" + Nl));          
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateSearchCbDefaultClasses(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "        public override void Search_DEFAULT(string defKeyField)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        Search_DEFAULT(defKeyField, false);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SearchAndCheck_DEFAULT(string defKeyField)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        Search_DEFAULT(defKeyField, true);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void Search_DEFAULT(string defKeyField, string Code)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        Search_DEFAULT(defKeyField, Code, false);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SearchAndCheck_DEFAULT(string defKeyField, string code)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        Search_DEFAULT(defKeyField, code, true);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);


           sb.Append(Format(lvl, "        public override void Search(string sql, bool check)" + Nl));
           sb.Append(Format(lvl, "        {" + Nl));
           sb.Append(Format(lvl+1, "            if (DATA.ReadNewTableData(sql) > 0)" + Nl));
           sb.Append(Format(lvl+1, "            {" + Nl));
           sb.Append(Format(lvl+2, "                if (DATA.SetFirstData())" + Nl));
           sb.Append(Format(lvl+2, "                {" + Nl));
           sb.Append(Format(lvl+3, "                    var defData = (TSTATUSClass.TDataClass)DATA.CurrentData;" + Nl));
           sb.Append(Format(lvl+3, "                    if (check)" + Nl));
           sb.Append(Format(lvl+3, "                    {" + Nl));
           sb.Append(Format(lvl+4, "                        SearchAndCheck_ID(defData.Item.ID);" + Nl));
           sb.Append(Format(lvl+3, "                    }" + Nl));
           sb.Append(Format(lvl+3, "                    else" + Nl));
           sb.Append(Format(lvl+3, "                    {" + Nl));
           sb.Append(Format(lvl+4, "                        Search_ID(defData.Item.ID);" + Nl));
           sb.Append(Format(lvl+3, "                    }" + Nl));
           sb.Append(Format(lvl+2, "                }" + Nl));
           sb.Append(Format(lvl+1, "            }" + Nl));
           sb.Append(Format(lvl+1, "            else" + Nl));
           sb.Append(Format(lvl+1, "            {" + Nl));
           sb.Append(Format(lvl+2, "                ComboBoxObject.SelectedIndex = -1;" + Nl));
           sb.Append(Format(lvl+1, "            }" + Nl));
           sb.Append(Format(lvl, "        }" + Nl));

            sb.Append(Format(lvl, "        public void Search_DEFAULT(string defKeyField, bool check)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));            
            sb.Append(Format(lvl+1, "        if (DATA.ReadNewTableData(defKeyField + \" = 1\") > 0)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        if (DATA.SetFirstData())" + Nl));
            sb.Append(Format(lvl+2, "        {" + Nl));
            sb.Append(Format(lvl+3, "        var defData = (" + tc.Name + "Class.TDataClass)DATA.CurrentData;" + Nl));
            sb.Append(Format(lvl+3, "        if (check)" + Nl));
            sb.Append(Format(lvl+3, "        {" + Nl));
            sb.Append(Format(lvl+4, "        SearchAndCheck_ID(defData.Item.ID);" + Nl));
            sb.Append(Format(lvl+3, "        }" + Nl));
            sb.Append(Format(lvl+3, "        else" + Nl));
            sb.Append(Format(lvl+3, "        {" + Nl));
            sb.Append(Format(lvl+4, "        Search_ID(defData.Item.ID);" + Nl));
            sb.Append(Format(lvl+3, "        }" + Nl));
            sb.Append(Format(lvl+2, "        }" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl+1, "        else" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        ComboBoxObject.SelectedIndex = -1;" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public void Search_DEFAULT(string defKeyField, string code, bool check)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));            
            sb.Append(Format(lvl+1, "        if (DATA.ReadNewTableData(defKeyField + \" = '\" + code + \"'\") > 0)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        if (!DATA.SetFirstData()) return;" + Nl));            
            sb.Append(Format(lvl+2, "        var defData = (" + tc.Name + "Class.TDataClass)DATA.CurrentData;" + Nl));
            sb.Append(Format(lvl+2, "        if (check)" + Nl));
            sb.Append(Format(lvl+2, "        {" + Nl));
            sb.Append(Format(lvl+3, "        SearchAndCheck_ID(defData.Item.ID);" + Nl));
            sb.Append(Format(lvl+2, "        }" + Nl));
            sb.Append(Format(lvl+2, "        else" + Nl));
            sb.Append(Format(lvl+2, "        {" + Nl));
            sb.Append(Format(lvl+3, "        Search_ID(defData.Item.ID);" + Nl));
            sb.Append(Format(lvl+2, "        }" + Nl));       
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl+1, "        else" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        ComboBoxObject.SelectedIndex = -1;" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateCbRefreshDisplayMembers(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "        public override void RefreshDisplayMembers()" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        DATA.SetDisplayMembers(DisplayMemberDef);" + Nl));            
            sb.Append(Format(lvl+1, "        for (int i = 0; i < ComboBoxObject.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        var columnData = (" + tc.Name + "Class.TDataClass.TColumns)ComboBoxObject.Items[i];" + Nl));
            sb.Append(Format(lvl+2, "        columnData.SetDisplayMembers(DisplayMemberDef);" + Nl));
            sb.Append(Format(lvl+2, "        ComboBoxObject.Items[i] = columnData;" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void RefreshDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        DisplayMemberDef = dpm;" + Nl));
            sb.Append(Format(lvl+1, "        RefreshDisplayMembers();" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateCbSetComboDataMembers(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "        public override void SetComboData(string cmd)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        int[] x = { };" + Nl));
            sb.Append(Format(lvl+1, "        this.SetComboData(cmd, x);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SetComboData(string cmd, int[] duplicates)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        base.SetComboData();" + Nl));
            sb.Append(Format(lvl+1, "        AktCmd = cmd;" + Nl));
            sb.Append(Format(lvl+1, "        DATA.LeseComboData(ComboBoxObject, AktCmd, duplicates);" + Nl));
            sb.Append(Format(lvl+1, "        cbSelectedIndexChanged();" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SetComboData(string cmd, object id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetComboData(cmd);" + Nl));
            sb.Append(Format(lvl+1, "        Search_ID(id);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SetComboData(string cmd, int? id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetComboData(cmd);" + Nl));
            sb.Append(Format(lvl+1, "        Search_ID(id);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SetComboData(string cmd, int id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetComboData(cmd);" + Nl));
            sb.Append(Format(lvl+1, "        Search_ID(id);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SetComboData(string cmd, string id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetComboData(cmd);" + Nl));
            sb.Append(Format(lvl+1, "        Search_ID(id);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateSearchCbDataClasses(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "        public void Search_DATA(string pattern, int colinx, bool checkWhenDataFound)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));           
         //   sb.Append(Format(lvl+1, "        CheckBoxObject.Checked = false;" + Nl));
            sb.Append(Format(lvl+1, "        for (int i = 0; i < ComboBoxObject.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        var data = (" + tc.Name + "Class.TDataClass.TColumns)ComboBoxObject.Items[i];" + Nl));
            sb.Append(Format(lvl+2, "        if (data.DataList[colinx].ToString() != pattern) continue;" + Nl));       
            sb.Append(Format(lvl+2, "        if ((CheckBoxObject != null) && (checkWhenDataFound)) CheckBoxObject.Checked = true;" + Nl));
            sb.Append(Format(lvl+2, "        if (ComboBoxObject != null) ComboBoxObject.Enabled = true;" + Nl));
            sb.Append(Format(lvl+2, "        ComboBoxObject.SelectedIndex = i;" + Nl));
            sb.Append(Format(lvl+2, "        cbSelectedIndexChanged();" + Nl));
            sb.Append(Format(lvl+2, "        break;" + Nl));            
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public void Search_ID(object id, bool checkWhenDataFound)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
         //   sb.Append(Format(lvl+1, "        CheckBoxObject.Checked = false;" + Nl));
            sb.Append(Format(lvl+1, "        if (id == null)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        CheckBoxObject.Checked = false;" + Nl));
            sb.Append(Format(lvl+2, "        return;" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl+1, "        if (id.ToString().Length <= 0) return;" + Nl));           
            sb.Append(Format(lvl+1, "        for (int i = 0; i < ComboBoxObject.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));
            sb.Append(Format(lvl+2, "        var data = (" + tc.Name + "Class.TDataClass.TColumns)ComboBoxObject.Items[i];" + Nl));
            sb.Append(Format(lvl+2, "        if (data.ID.ToString() != id.ToString()) continue;" + Nl));            
            sb.Append(Format(lvl+2, "        if ((CheckBoxObject != null) && (checkWhenDataFound)) CheckBoxObject.Checked = true;" + Nl));
            sb.Append(Format(lvl+2, "        if (ComboBoxObject != null) ComboBoxObject.Enabled = true;" + Nl));
            sb.Append(Format(lvl+2, "        ComboBoxObject.SelectedIndex = i;" + Nl));
            sb.Append(Format(lvl+2, "        cbSelectedIndexChanged();" + Nl));
            sb.Append(Format(lvl+2, "        break;" + Nl));            
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void SearchAndCheck_ID(object id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        Search_ID(id, true);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void Search_ID(object id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        Search_ID(id, false);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public override void Search_DATA(string pattern, int colinx)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "            Search_DATA(pattern, colinx, false);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            /*
            sb.Append(Format(lvl, "        public override void SearchAndCheck_DATA(string pattern, int colinx)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "            Search_DATA(pattern, colinx, true);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            */
            return sb.ToString();
        }

        public string CreateCbConstructors(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "        public Cb" + tc.Name + "Class(SELibraries.WindowsForms.SEComboBox cb, CheckBox cbUk, Button btnEdit) : base(cb, cbUk, btnEdit)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetDefaultAttributes();" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public Cb" + tc.Name + "Class(SELibraries.WindowsForms.SEComboBox cb, CheckBox cbUk) : base(cb, cbUk)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetDefaultAttributes();" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public Cb" + tc.Name + "Class(SELibraries.WindowsForms.SEComboBox cb) : base(cb)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        SetDefaultAttributes();" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public Cb" + tc.Name + "Class() : base()" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateDesignForCbTable(int lvl, DataObjectClass tc)
        {
            var sb = new StringBuilder();
            sb.Append(CreateCbTableUsings(lvl));
            sb.Append(CreateCopyright(lvl,tc.Name));
            sb.Append(Format(lvl,"namespace "+ CodeCreateAttribute.CodeNamespace + Nl));
            sb.Append(Format(lvl,"{" + Nl));
            sb.Append(Format(lvl+1,"    /// <summary>" + Nl));
            sb.Append(Format(lvl+1,"    /// Klasse die Daten der relationalen Datenbanktabelle " + tc.Name + Nl));
            sb.Append(Format(lvl+1,"    /// als Objekte darstellt und verwaltet." + Nl));
            sb.Append(Format(lvl+1,"    /// </summary>" + Nl));
            sb.Append(Format(lvl+1,"    ///" + Nl));
            sb.Append(Format(lvl+1,"    public class Cb" + tc.Name + "Class : SELibraries.WindowsForms.cbMainClass" + Nl));
            sb.Append(Format(lvl+1,"    {" + Nl));

            sb.Append(Format(lvl+2,"        private "+tc.Name+ "Class DATA = new " + tc.Name + "Class(ConnectionPoolClass.Instance().GetConnection(GlobalsCon.MainCon));" + Nl));

            sb.Append(Nl);
            sb.Append(CreateCbConstructors(lvl+2,tc));
            sb.Append(Nl);
            sb.Append(CreateCbRefreshDisplayMembers(lvl+2, tc));                        
            sb.Append(Nl);
            sb.Append(CreateCbSetComboDataMembers(lvl+2, tc));            
            sb.Append(Nl);

            sb.Append(Format(lvl+2,"        public sealed override void SetDefaultAttributes()" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        base.SetDefaultAttributes();" + Nl));
            sb.Append(Format(lvl+3,"        base.AktCmd = \"SELECT * FROM "+tc.Name+" ORDER BY ID\";" + Nl));
            sb.Append(Format(lvl+3,"        DATA.SetDisplayMembers(DisplayMemberDef);" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+2,"        public override void SetDATA_ID(object id, bool refreshCombo)" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        if (!refreshCombo) return;" + Nl));            
            sb.Append(Format(lvl+3,"        AktData = DATA.LeseComboData(ComboBoxObject, AktCmd, id);" + Nl));
            sb.Append(Format(lvl+3,"        if (CheckBoxObject != null)" + Nl));
            sb.Append(Format(lvl+4,"        CheckBoxObject.Checked = (AktData != null);" + Nl));            
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+2,"        public override void SetKeyIndex(int kn)" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        DisplayMemberDef.KeyIndex = kn;" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));

            sb.Append(Nl);
            sb.Append(CreateSearchSchluessel(lvl+2,tc));
            sb.Append(Nl);
            sb.Append(CreateSearchCbDefaultClasses(lvl+2,tc));            
            sb.Append(Nl);
            sb.Append(CreateSearchCbDataClasses(lvl+2, tc));
            
            sb.Append(Nl);
            sb.Append(Format(lvl+2,"        protected override object AktID()" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));            
            sb.Append(Format(lvl+3,"        return ((" + tc.Name + "Class.TDataClass.TColumns) AktData)?.ID;" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+1,"        #region Events" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+2,"        public override void cbSelectedIndexChanged()" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        if (ComboBoxObject.SelectedIndex >= 0)" + Nl));
            sb.Append(Format(lvl+3,"        {" + Nl));
            sb.Append(Format(lvl+4,"        AktData = ("+tc.Name+"Class.TDataClass.TColumns)ComboBoxObject.SelectedItem;" + Nl));
            sb.Append(Format(lvl+3,"        }" + Nl));
            sb.Append(Format(lvl+3,"        else" + Nl));
            sb.Append(Format(lvl+3,"        {" + Nl));
            sb.Append(Format(lvl+4,"        AktData = null;" + Nl));
            sb.Append(Format(lvl+3,"        }" + Nl));
            sb.Append(Format(lvl+3,"        ComboBoxObject.Enabled = AktData != null;" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));

            sb.Append(Nl);
            sb.Append(Format(lvl+2,"        public override void cbMouseClick()" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));            
            sb.Append(Format(lvl+2,"        }" + Nl));


            sb.Append(Format(lvl+1,"        #endregion" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl+1,"        }  //class" + Nl));
            sb.Append(Format(lvl,  "    }      //namespace" + Nl));
            return sb.ToString();
        }
        private string _basename = string.Empty;
        public void Init(NotifiesClass notifies, string basename)
        {
            /*
            DatabaseDesignClass ddc = null;
            XmlSerializer serializer = new XmlSerializer(typeof(DatabaseDesignClass));
            FileStream fs = new FileStream(filename, FileMode.Open);
            ddc = (DatabaseDesignClass)serializer.Deserialize(fs);
            fs.Close();
            */
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

            sb.Append(Format(lvl, "        /// <summary>" + Nl));
            sb.Append(Format(lvl, "        /// Selects the entry of ComboBox for the ID columns of dataset." + Nl));            
            sb.Append(Format(lvl, "        /// </summary>" + Nl));

            if((CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUID)||(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUIDHEX))
            {
                sb.Append(Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, string id)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));            
                sb.Append(Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
                sb.Append(Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
                sb.Append(Format(lvl+1, "        {" + Nl));
                sb.Append(Format(lvl+2, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));
                if (pk == null)
                {
                    _localNotifies?.AddToERROR("No PrimaryKey in Table " + obj.Name + ", using field ID instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)");
                    sb.Append(Format(lvl+2, "        if (KS.ID == id)" + Nl));
                }
                else
                {                    
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                    if(!string.IsNullOrEmpty(fn))
                    {
                      sb.Append(Format(lvl+2, "        if (KS." + fn + " == id)" + Nl));
                    }
                }
                sb.Append(Format(lvl+2, "        {" + Nl));
                sb.Append(Format(lvl+3, "        cb.SelectedIndex = i;" + Nl));
                sb.Append(Format(lvl+3, "        KD = KS;" + Nl));
                sb.Append(Format(lvl+3, "        break;  // for schleife verlassen" + Nl));
                sb.Append(Format(lvl+2, "        }" + Nl));
                sb.Append(Format(lvl+1, "        }" + Nl));
                sb.Append(Format(lvl+1, "        return (KD);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));                
                sb.Append(Nl);
            }
            else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenOID)
            {
                
                sb.Append(Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, long id)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));            
                sb.Append(Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
                sb.Append(Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
                sb.Append(Format(lvl+1, "        {" + Nl));
                sb.Append(Format(lvl+2, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));
                if (pk == null)
                {
                    _localNotifies?.AddToERROR("No PrimaryKey in Table " + obj.Name + ", using field ID instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)");
                    sb.Append(Format(lvl+2, "        if (KS.ID == id)" + Nl));
                }
                else
                {                    
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                    if(!string.IsNullOrEmpty(fn))
                    {
                      sb.Append(Format(lvl+2, "        if (KS." + fn + " == id)" + Nl));
                    }
                }
                sb.Append(Format(lvl+2, "        {" + Nl));
                sb.Append(Format(lvl+3, "        cb.SelectedIndex = i;" + Nl));
                sb.Append(Format(lvl+3, "        KD = KS;" + Nl));
                sb.Append(Format(lvl+3, "        break;  // for schleife verlassen" + Nl));
                sb.Append(Format(lvl+2, "        }" + Nl));
                sb.Append(Format(lvl+1, "        }" + Nl));
                sb.Append(Format(lvl+1, "        return (KD);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));                
                sb.Append(Nl);
            }
            else
            {

                sb.Append(Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, int? id)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));
                sb.Append(Format(lvl+1, "        TDataClass.TColumns si = null;" + Nl));
                sb.Append(Format(lvl+1, "        if (id != null)" + Nl));
                sb.Append(Format(lvl+1, "        {" + Nl));
                sb.Append(Format(lvl+2, "        si = SelectComboIndex(cb, id.Value);" + Nl));
                sb.Append(Format(lvl+1, "        }" + Nl));
                sb.Append(Format(lvl+1, "        return (si);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));
                sb.Append(Nl);
                sb.Append(Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));            
                sb.Append(Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
                sb.Append(Format(lvl+1, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
                sb.Append(Format(lvl+1, "        {" + Nl));
                sb.Append(Format(lvl+2, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));
                if (pk == null)
                {
                    _localNotifies?.AddToERROR("No PrimaryKey in Table " + obj.Name + ", using field ID instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, int id)");
                    sb.Append(Format(lvl+2, "        if (KS.ID == id)" + Nl));
                }
                else
                {                    
                    string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                    if(!string.IsNullOrEmpty(fn))
                    {
                      sb.Append(Format(lvl+2, "        if (KS." + fn + " == id)" + Nl));
                    }
                }
                sb.Append(Format(lvl+2, "        {" + Nl));
                sb.Append(Format(lvl+3, "        cb.SelectedIndex = i;" + Nl));
                sb.Append(Format(lvl+3, "        KD = KS;" + Nl));
                sb.Append(Format(lvl+3, "        break;  // for schleife verlassen" + Nl));
                sb.Append(Format(lvl+2, "        }" + Nl));
                sb.Append(Format(lvl+1, "        }" + Nl));
                sb.Append(Format(lvl+1, "        return (KD);" + Nl));
                sb.Append(Format(lvl, "        }" + Nl));
            }

            sb.Append(Nl);
            sb.Append(Format(lvl, "        public TDataClass.TColumns SelectComboIndex(ComboBox cb, object id)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        TDataClass.TColumns KD = null;" + Nl));
            sb.Append(Format(lvl+1, "        if ((id != null) && (id.ToString().Length > 0))" + Nl));
            sb.Append(Format(lvl+1, "        {" + Nl));            
            sb.Append(Format(lvl+2, "        for (int i = 0; i < cb.Items.Count; i++)" + Nl));
            sb.Append(Format(lvl+2, "        {" + Nl));
            sb.Append(Format(lvl+3, "        var KS = (TDataClass.TColumns)cb.Items[i];" + Nl));

            if (pk == null)
            {
                _localNotifies?.AddToERROR("No PrimaryKey in Table " + obj.Name + ", using field ID instead in method:  public TDataClass.TColumns SelectComboIndex(ComboBox cb, object id)");
                sb.Append(Format(lvl+3, "        if (KS.ID.ToString() == id.ToString())" + Nl));
            }
            else
            {                
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                if(!string.IsNullOrEmpty(fn))
                {
                    sb.Append(Format(lvl+3, "        if (KS." + fn + ".ToString() == id.ToString())" + Nl));
                }
            }

            sb.Append(Format(lvl+3, "        {" + Nl));
            sb.Append(Format(lvl+4, "        cb.SelectedIndex = i;" + Nl));
            sb.Append(Format(lvl+4, "        KD = KS;" + Nl));
            sb.Append(Format(lvl+4, "        break;  // for schleife verlassen" + Nl));
            sb.Append(Format(lvl+3, "        }" + Nl));
            sb.Append(Format(lvl+2, "        }" + Nl));
            sb.Append(Format(lvl+1, "        }" + Nl));
            sb.Append(Format(lvl+1, "        return (KD);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl, "        public " + obj.Name + "Class.TDataClass.TColumns GetSelectedItem(ComboBox cb)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));            
            sb.Append(Format(lvl+1, "        var KD = (" + obj.Name + "Class.TDataClass.TColumns)cb.Items[cb.SelectedIndex];" + Nl));
            sb.Append(Format(lvl+1, "        return (KD);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateDeleteDataMethods(int lvl, DataObjectClass obj)
        {
            var sb = new StringBuilder();
            PrimaryKeyClass pk = null;
            if (obj.GetType() == typeof(TableClass))
            {
                pk = ((TableClass) obj).primary_constraint;
            }
            sb.Append(Format(lvl, "        /// <summary>" + Nl));
            sb.Append(Format(lvl, "        /// Erases datas of actual object from database" + Nl));
            sb.Append(Format(lvl, "        /// </summary>" + Nl));
            sb.Append(Format(lvl, "        public override ReturnInfo DeleteData(eDataDeleteMode dataMode)" + Nl));
            sb.Append(Format(lvl, "        {" + Nl));
            sb.Append(Format(lvl+1, "        ReturnInfo rt = null;" + Nl));
            sb.Append(Format(lvl+1, "        " + obj.Name + "Class.TDataClass dc = (" + obj.Name + "Class.TDataClass)CurrentData;" + Nl));

            if (pk == null)
            {
                _localNotifies?.AddToERROR($@"No PrimaryKey in table {obj.Name}, using field ID instead in method:  public override ReturnInfo DeleteData(eDataDeleteMode dataMode)");
                sb.Append(Format(lvl+1, $@"        rt = DeleteData(dc.Item.ID,dataMode);{Nl}"));
            }
            else
            {                
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(pk.FieldNames);
                if(!string.IsNullOrEmpty(fn))
                {
                    sb.Append(Format(lvl + 1, $@"        rt = DeleteData(dc.Item.{fn},dataMode);{Nl}"));
                }
            }
            sb.Append(Format(lvl+1, "        if (rt.Done)" + Nl));
            sb.Append(Format(lvl+2, "        CurrentData.Clear();" + Nl));
            sb.Append(Format(lvl+1, "        return (rt);" + Nl));
            sb.Append(Format(lvl, "        }" + Nl));
            return sb.ToString();
        }

        public string CreateMiscMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();

            sb.Append(Format(lvl, "       #region list and combobox methods" + Nl));
            sb.Append(Format(lvl,"        public void SetDisplayMembers(DisplayMembers dpm)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        DisplayMemberDef = dpm;" + Nl));
            sb.Append(Format(lvl+1,"        //Actual object becomes display definition" + Nl));
            sb.Append(Format(lvl+1,"        TDataClass AktData = (TDataClass)this.CurrentData;" + Nl));
            sb.Append(Format(lvl+1,"        if (AktData != null)" + Nl));
            sb.Append(Format(lvl+2,"        AktData.SetDisplayMembers(dpm);" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Returns object selected by SQL statement to array of objects" + Nl));
            sb.Append(Format(lvl,"        /// dpm = DisplayMember determines content of list for ComboBox, ect." + Nl));            
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        public Object[] LeseListData(string SQL)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        ArrayList cb = null;" + Nl));
            sb.Append(Format(lvl+1,"        this.ReadNewData(SQL);" + Nl));
            sb.Append(Format(lvl+1,"        TDataClass KD;" + Nl));
            sb.Append(Format(lvl+1,"        if (this.SetFirstData())" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        cb = new ArrayList(this.Count);" + Nl));
            sb.Append(Format(lvl+2,"        while (this.GetData())" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        KD = (TDataClass)this.CurrentData;" + Nl));
            sb.Append(Format(lvl+3,"        cb.Add(KD.Item);" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl+1,"        if (cb == null) return (null);" + Nl));
            sb.Append(Format(lvl+1,"        return (cb.ToArray());" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Fills ComboBox with objectlist selected by SQL statement." + Nl));            
            sb.Append(Format(lvl,"        /// Select's first entry of ComboBox." + Nl));            
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        public void LeseComboData(ComboBox cb, string SQL)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        int[] x = { };" + Nl));
            sb.Append(Format(lvl+1,"        this.LeseComboData(cb, SQL, x);" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,"        public void LeseComboData(ComboBox cb, string sql, int[] duplicates)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        this.ReadNewData(sql);" + Nl));
            sb.Append(Format(lvl+1,"        TDataClass kd;" + Nl));
            sb.Append(Format(lvl+1,"        cb.BeginUpdate();" + Nl));
            sb.Append(Format(lvl+1,"        cb.Items.Clear();" + Nl));
            sb.Append(Format(lvl+1,"        if (this.SetFirstData())" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        while (this.GetData())" + Nl));
            sb.Append(Format(lvl+2,"        {" + Nl));
            sb.Append(Format(lvl+3,"        kd = (TDataClass)this.CurrentData;" + Nl));
            sb.Append(Format(lvl+3,"        bool dup = false;" + Nl));
            sb.Append(Format(lvl+3,"        if ((duplicates != null) && (duplicates.Length > 0))" + Nl));
            sb.Append(Format(lvl+3,"        {" + Nl));
            sb.Append(Format(lvl+4,"        object x = kd.Item.DataList[duplicates[0]];" + Nl));
            sb.Append(Format(lvl+4,"        object y = null;" + Nl));
            sb.Append(Format(lvl+4,"        foreach (TDataClass.TColumns ki in cb.Items)" + Nl));
            sb.Append(Format(lvl+4,"        {" + Nl));
            sb.Append(Format(lvl+5,"        y = ki.DataList[duplicates[0]];" + Nl));
            sb.Append(Format(lvl+5,"        if (y.ToString() == x.ToString())" + Nl));
            sb.Append(Format(lvl+5,"        {" + Nl));
            sb.Append(Format(lvl+6,"        dup = true;" + Nl));
            sb.Append(Format(lvl+5,"        }" + Nl));
            sb.Append(Format(lvl+4,"        }" + Nl)); 
            sb.Append(Format(lvl+3,"        }" + Nl));
            sb.Append(Format(lvl+3,"        if (!dup) cb.Items.Add(kd.Item);" + Nl));
            sb.Append(Format(lvl+2,"        }" + Nl));

            sb.Append(Format(lvl+2,"        cb.SelectedIndex = cb.Items.Count > 0 ? 0 : -1;" + Nl));
                   
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl+1,"        cb.EndUpdate();" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Fills ComboBox with objectlist selected by SQL statement." + Nl));         
            sb.Append(Format(lvl,"        /// Selects entry with specific ID of data column." + Nl));                        
            sb.Append(Format(lvl,"        /// </summary>" + Nl));            
            sb.Append(Format(lvl,"        public TDataClass.TColumns LeseComboData(ComboBox cb, string sql, object id)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        LeseComboData(cb, sql);" + Nl));

            sb.Append(Format(lvl+1,"        return (id != null) && (id.ToString().Length > 0) ? SelectComboIndex(cb, id) : null;" + Nl));
            /*
            sb.Append(Format(lvl+1,"        if ((id != null) && (id.ToString().Length > 0))" + NL));
            sb.Append(Format(lvl+1,"        {" + NL));
            sb.Append(Format(lvl+2,"        return (SelectComboIndex(cb, id));" + NL));
            sb.Append(Format(lvl+1,"        }" + NL));
            sb.Append(Format(lvl+1,"        return (null);" + NL));
            */
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Fills ComboBox with objectlist selected by SQL statement." + Nl));         
            sb.Append(Format(lvl,"        /// Selects first entry of ComboBox." + Nl));                        
            sb.Append(Format(lvl,"        /// </summary>" + Nl));  
            sb.Append(Format(lvl,"        public void LeseComboData(ComboBox cb, string sql, DisplayMembers dpm)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        SetDisplayMembers(dpm);" + Nl));
            sb.Append(Format(lvl+1,"        LeseComboData(cb, sql);" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(CreateSelectComboIndex(lvl, obj));
            sb.Append(Nl);

            sb.Append(Format(lvl, "       #endregion list and combobox methods" + Nl));

            return sb.ToString();
        }

        public string CreateFieldGetMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            // PrimaryKeyClass pk = null;
            sb.Append(Format(lvl, "        #region class getFieldsAttributes methods" + Nl));
            if (obj.GetType() == typeof(TableClass))
            {
               // pk = (obj as TableClass).primary_constraint;
                var tc = obj as TableClass;
                
                foreach (var tfc in tc.Fields.Values)
                {                    
                    var cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    var csValueType = TypeConvert.DatabaseTOcsharpValueTypeAsString(tfc.Domain);
                    
                    sb.Append(Format(lvl,"        /// <summary>" + Nl));
                    sb.Append(Format(lvl,"        /// Return's type and value of database column " + tfc.Name + Nl));
                    sb.Append(Format(lvl,"        /// </summary>" + Nl));
                    sb.Append(Format(lvl,"        /// <returns>value of database column " + tfc.Name + "</returns>" + Nl));
                    sb.Append(Format(lvl,"        public " + cstype + " get" + tfc.Name + "()" + Nl));
                    sb.Append(Format(lvl,"        {" + Nl));                   
                    sb.Append(Format(lvl+1,"        " + cstype + " data = " + TypeConvert.ToDefaultEmpty(tfc.Domain) + ";" + Nl));                                       
                    sb.Append(Format(lvl+1,"        try" + Nl));
                    sb.Append(Format(lvl+1,"        {" + Nl));
                    sb.Append(Format(lvl+2,"        var ob = ConnectionData.GetValue((int)eTDataClass." + tfc.Name + ");" + Nl));
                    sb.Append(Format(lvl+2,"        var dataTypeStr = ob.GetType();" + Nl));
                    sb.Append(Format(lvl+2,"        if (dataTypeStr != typeof(System.DBNull))" + Nl));
                    sb.Append(Format(lvl+2,"        {" + Nl));
                    if ((cstype == "string")||(cstype == "DateTime"))
                    {
                        sb.Append(Format(lvl+3,"        data = (" + cstype + ")ob;" + Nl));
                    }
                    else if ((cstype == "byte[]")||(cstype == "blob"))
                    {
                        sb.Append(Format(lvl+3,"        data = dataTypeStr == typeof(" + csValueType + ") ? (" + csValueType +") ob : null;" + Nl));    
                    }
                    else
                    {
                        sb.Append(Format(lvl+3,"        data = dataTypeStr == typeof(" + csValueType + ") ? (" + csValueType +") ob : " + csValueType + ".Parse(ob.ToString());" + Nl));                        
                    }
                    sb.Append(Format(lvl+2,"        }" + Nl));
                    sb.Append(Format(lvl+1,"        }" + Nl));
                    sb.Append(Format(lvl+1,"        catch (Exception ex)" + Nl));
                    sb.Append(Format(lvl+1,"        {" + Nl));
                    sb.Append(Format(lvl+2,$"            TMessages.Instance().HandleKonvertException(ex.Message, \"{tc.Name}->get{tfc.Name}()\");{Nl}"));
                    sb.Append(Format(lvl+1,"        }" + Nl));
                    sb.Append(Format(lvl+1,"        return (data);" + Nl));
                    sb.Append(Format(lvl,"        }" + Nl));
                }
            }
            else if(obj.GetType() == typeof(ViewClass))
            {
                var vc = obj as ViewClass;

                foreach (var tfc in vc.Fields.Values)
                {
                    var cstype = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    var csValueType = TypeConvert.DatabaseTOcsharpValueTypeAsString(tfc.Domain);
                    sb.Append(Format(lvl,"        /// <summary>" + Nl));
                    sb.Append(Format(lvl,"        /// Return's type and value of database column " + tfc.Name + Nl));
                    sb.Append(Format(lvl,"        /// </summary>" + Nl));
                    sb.Append(Format(lvl,"        /// <returns>value of database column " + tfc.Name + "</returns>" + Nl));
                    sb.Append(Format(lvl, "        public " + cstype + " get" + tfc.Name + "()" + Nl));
                    sb.Append(Format(lvl, "        {" + Nl));                                        
                    sb.Append(Format(lvl+1, "        " + cstype + " data = " + TypeConvert.ToDefaultDBNull(tfc.Domain) + ";" + Nl));                   
                    sb.Append(Format(lvl+1, "        try" + Nl));
                    sb.Append(Format(lvl+1, "        {" + Nl));
                    sb.Append(Format(lvl+2, "        var ob = ConnectionData.GetValue((int)eTDataClass." + tfc.Name + ");" + Nl));
                    sb.Append(Format(lvl+2, "        var dataTypeStr = ob.GetType();" + Nl));
                    sb.Append(Format(lvl+2, "        if (dataTypeStr != typeof(System.DBNull))" + Nl));
                    sb.Append(Format(lvl+2, "        {" + Nl));
                    if ((cstype == "string") || (cstype == "DateTime"))
                    {
                        sb.Append(Format(lvl+3, "        data = (" + cstype + ")ob;" + Nl));
                    }
                    else
                    {
                        sb.Append(Format(lvl+3,"        data = dataTypeStr == typeof(" + csValueType + ") ? (" + csValueType +") ob : " + csValueType + ".Parse(ob.ToString());" + Nl));                        
                    }
                    sb.Append(Format(lvl+2, "        }" + Nl));
                    sb.Append(Format(lvl+1, "        }" + Nl));
                    sb.Append(Format(lvl+1, "        catch (Exception ex)" + Nl));
                    sb.Append(Format(lvl+1, "        {" + Nl));
                    sb.Append(Format(lvl+2,$"            TMessages.Instance().HandleKonvertException(ex.Message, \"{vc.Name}->get{tfc.Name}()\");{Nl}"));
                    sb.Append(Format(lvl+1, "        }" + Nl));
                    sb.Append(Format(lvl+1, "        return (data);" + Nl));
                    sb.Append(Format(lvl, "        }" + Nl));
                }
            }
            sb.Append(Format(lvl, "        #endregion class getFieldsAttributes methods" + Nl));
            return sb.ToString();
        }

        public string AppendFieldParam(string dataTypeStr,string fieldName, int lvl)
        {
            var sb = new StringBuilder();
            if (dataTypeStr.StartsWith("double"))
            {
                sb.Append(Format(lvl+2,"        ConnectionData.AddParam(@\"@" + fieldName + "\", TDataBasis.ToSQLString(dc.Item." + fieldName + "));" + Nl));
            }
            else if (dataTypeStr == "DateTime")
            {
                sb.Append(Format(lvl+2,"        ConnectionData.AddParam(@\"@" + fieldName + "\", GetDatumZeitStr(dc.Item." + fieldName + "));" + Nl));
            }
            else
            {
                sb.Append(Format(lvl+2,"        ConnectionData.AddParam(@\"@" + fieldName + "\", dc.Item." + fieldName + ");" + Nl));    
            }

            return sb.ToString();
        }

        public string CreateInsertDataMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Inserts object data into database." + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public override ReturnInfo InsertData()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));                
                sb.Append(Format(lvl+1,"        using (var dc = (" + table?.Name + "Class.TDataClass) CurrentData)" + Nl));
                sb.Append(Format(lvl+1,"        {" + Nl));
                sb.Append(Format(lvl+2,"        StringBuilder sql = new StringBuilder();" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\"INSERT INTO \");" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(TableName);" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\"(\");" + Nl));

                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + ",\");" + Nl) : Format(lvl + 2, "         sql.Append(@\"" + tfc.Name + ")\");" + Nl));
                }

                sb.Append(Format(lvl + 2, "        sql.Append(\" VALUES (\");" + Nl));

                n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? Format(lvl + 2, "        sql.Append(@\"@" + tfc.Name + ",\");" + Nl) : Format(lvl + 2, "        sql.Append(@\"@" + tfc.Name + ")\");" + Nl));
                      
                }

                sb.Append(Format(lvl+2,"        ConnectionData.CreateCommand(sql.ToString());" + Nl));
                
                foreach (var tfc in table.Fields.Values)
                {                      
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl));                    
                }
                sb.Append(Format(lvl+1,"        }" + Nl));
                sb.Append(Format(lvl+1,"        ReturnInfo rt = ExecuteSQL();" + Nl));
                sb.Append(Format(lvl+1,"        if (rt.Done)" + Nl));
                sb.Append(Format(lvl+2,"        CurrentData.DataState = eDataState.NEUTRAL;" + Nl));
                sb.Append(Format(lvl+1,"        return (rt);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Inserts object to database" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public override ReturnInfo InsertData()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));
                sb.Append(Format(lvl+1,"        using (var dc = (" + table?.Name + "Class.TDataClass) CurrentData)" + Nl));
                sb.Append(Format(lvl+1,"        {" + Nl));
                sb.Append(Format(lvl+2,"        StringBuilder sql = new StringBuilder();" + Nl));                
                sb.Append(Format(lvl+2,"        sql.Append(@\"INSERT INTO \");" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(TableName);" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\"(\");" + Nl));

                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + ",\");" + Nl) : Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + ")\");" + Nl));
                }

                sb.Append(Format(lvl + 2, "            sql.Append(@\" VALUES (\");" + Nl));

                n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? Format(lvl + 2, "        sql.Append(@\"@" + tfc.Name + ",\");" + Nl) : Format(lvl + 2, "        sql.Append(@\"@" + tfc.Name + ")\");" + Nl));
                }
              
                sb.Append(Format(lvl+2,"        ConnectionData.CreateCommand(sql.ToString());" + Nl));
              
                foreach (var tfc in table.Fields.Values)
                {                                                            
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl));                    
                }
                sb.Append(Format(lvl+1,"        }" + Nl));
                sb.Append(Format(lvl+1,"        ReturnInfo rt = ExecuteSQL();" + Nl));
                sb.Append(Format(lvl+1,"        if (rt.Done)" + Nl));
                sb.Append(Format(lvl+2,"        CurrentData.DataState = eDataState.NEUTRAL;" + Nl));
                sb.Append(Format(lvl+1,"        return (rt);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
            }
            return sb.ToString();
        }
      
        public string CreateUpdateDataMethods(int lvl,DataObjectClass obj)
        {
            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;

                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Updates database with actual object" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public override ReturnInfo UpdateData()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));                
                sb.Append(Format(lvl+1,"        using (var dc = (" + table.Name + "Class.TDataClass) CurrentData)" + Nl));
                sb.Append(Format(lvl+1,"        {"+Nl));
                sb.Append(Format(lvl+2,"        var sql = new StringBuilder();" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\"UPDATE \");" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(TableName);" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\" SET \");" + Nl));
                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + " = @" + tfc.Name + ",\");" + Nl) : Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + " = @" + tfc.Name + "\");" + Nl));
                }
                if((CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUID)||(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUIDHEX))
                {
                    if (table.primary_constraint != null)
                    {                        
                        string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                        if(!string.IsNullOrEmpty(fn))
                        {                             
                           sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE " + fn + " = '\" + dc.Item." + fn + ".ToString() + \"'; \");" + Nl));                             
                        }
                    }
                    else
                    {
                        _localNotifies?.AddToERROR("No PrimaryKey in Table " + table.Name + ", using field ID instead in method:  public override ReturnInfo UpdateData()");
                        sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE ID = '\" + dc.Item.ID.ToString() + \"'; \");" + Nl));
                    }
                }
                else if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenOID)
                {
                    if (table.primary_constraint != null)
                    {                        
                        string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                        if(!string.IsNullOrEmpty(fn))
                        {                             
                           sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE " + fn + " = \" + dc.Item." + fn + ".ToString() + \"; \");" + Nl));                             
                        }
                    }
                    else
                    {
                        _localNotifies?.AddToERROR("No PrimaryKey in Table " + table.Name + ", using field ID instead in method:  public override ReturnInfo UpdateData()");
                        sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE ID = \" + dc.Item.ID.ToString() + \"; \");" + Nl));
                    }
                }
                else
                {
                    if (table.primary_constraint != null)
                    {                       
                        string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                        if(!string.IsNullOrEmpty(fn))
                        { 
                            sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE " + fn + " = \" + dc.Item." + fn + ".ToString() + \"; \");" + Nl));
                        }
                    }
                    else
                    {
                        _localNotifies?.AddToERROR("No PrimaryKey in Table " + table.Name + ", using field ID instead in method:  public override ReturnInfo UpdateData()");
                        sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE ID = \" + dc.Item.ID.ToString() + \"; \");" + Nl));
                    }
                }
                sb.Append(Format(lvl+2,"        ConnectionData.CreateCommand(sql.ToString());" + Nl));
                sb.Append(Format(lvl+2,"        //Fill parameters" + Nl));
               
                foreach (var tfc in table.Fields.Values)
                {
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl));                    
                }

                sb.Append(Format(lvl+1,"        }"+Nl));
                sb.Append(Format(lvl+1,"        var rt = ExecuteSQL();" + Nl));
                sb.Append(Format(lvl+1,"        if (rt.Done)" + Nl));
                sb.Append(Format(lvl+2,"        CurrentData.DataState = eDataState.NEUTRAL;" + Nl));
                sb.Append(Format(lvl+1,"        return (rt);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
            }
            else if(obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;

                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Updates database with actual object" + Nl));
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public override ReturnInfo UpdateData()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));                
                sb.Append(Format(lvl+1,"        using (var dc = (" + table.Name + "Class.TDataClass) CurrentData)" + Nl));
                sb.Append(Format(lvl+1,"        {"+Nl));
                sb.Append(Format(lvl+2,"        var sql = new StringBuilder();" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\"UPDATE \");" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(TableName);" + Nl));
                sb.Append(Format(lvl+2,"        sql.Append(@\" SET \");" + Nl));

                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {
                    sb.Append(++n < table.Fields.Count ? Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + " = @" + tfc.Name + ",\");") : Format(lvl + 2, "        sql.Append(@\"" + tfc.Name + " = @" + tfc.Name + "\");"));
                }                
                sb.Append(Format(lvl+2,"        sql.Append(@\" WHERE ID = \" + dc.Item.ID.ToString() + \"; \");" + Nl));
                sb.Append(Format(lvl+2,"        ConnectionData.CreateCommand(sql.ToString());" + Nl));
                sb.Append(Format(lvl+2,"        //Parameter füllen" + Nl));
                foreach (var tfc in table.Fields.Values)
                {
                    var tp = TypeConvert.DatabaseTOcsharpTypeAsString(tfc.Domain);
                    sb.Append(AppendFieldParam(tp, tfc.Name, lvl));
                }
                sb.Append(Format(lvl+1,"        }"+Nl));
                sb.Append(Format(lvl+1,"        var rt = ExecuteSQL();" + Nl));
                sb.Append(Format(lvl+1,"        if (rt.Done)" + Nl));
                sb.Append(Format(lvl+2,"        CurrentData.DataState = eDataState.NEUTRAL;" + Nl));
                sb.Append(Format(lvl+1,"        return (rt);" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
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
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Get's datas from database and fills and returns as object" + Nl));                
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        /// <returns>object of TMainData</returns>" + Nl));
                sb.Append(Format(lvl,"        /// " + Nl));
                sb.Append(Format(lvl,"        public override TMainData getDatas()" + Nl));
                sb.Append(Format(lvl,"        {" + Nl));                
                sb.Append(Format(lvl+1,"        using (TDataClass aktData = new TDataClass(DisplayMemberDef))" + Nl));
                sb.Append(Format(lvl+1,"        {" + Nl));
                if (table?.primary_constraint == null)
                {
                    _localNotifies?.AddToERROR("No PrimaryKey in Table " + table?.Name + ", using field ID instead in method:  public override TMainData getDatas()");
                }

                foreach (var tfc in table.Fields.Values)
                {                   
                    sb.Append(Format(lvl+2,"        aktData.Item."+tfc.Name + " = get" + tfc.Name + "();" + Nl));                    
                }
                sb.Append(Format(lvl+2,"        return ((TMainData)aktData);" + Nl));
                sb.Append(Format(lvl+1,"        }" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(Format(lvl, "        /// <summary>" + Nl));
                sb.Append(Format(lvl, "        /// gets datas from database and fills and returns data object" + Nl));                
                sb.Append(Format(lvl, "        /// </summary>" + Nl));
                sb.Append(Format(lvl, "        /// <returns>Object of TMainData</returns>" + Nl));
                sb.Append(Format(lvl, "        /// " + Nl));
                sb.Append(Format(lvl, "        public override TMainData getDatas()" + Nl));
                sb.Append(Format(lvl, "        {" + Nl));                
                sb.Append(Format(lvl+1,"         using (var aktData = new TDataClass(DisplayMemberDef))" + Nl));
                sb.Append(Format(lvl+1,"         {" + Nl));

                foreach (var tfc in table.Fields.Values)
                {                   
                    sb.Append(Format(lvl + 2, "        aktData.Item." + tfc.Name + " = get" + tfc.Name + "();" + Nl));                   
                }
                sb.Append(Format(lvl+2,"        return ((TMainData)aktData);" + Nl));
                sb.Append(Format(lvl+1,"        }" + Nl));
                sb.Append(Format(lvl,"        }" + Nl));
            }
            return sb.ToString();
        }

        public string CreateNewMethods(int lvl,DataObjectClass obj)
        {
            if(obj == null) return Empty;

            var sb = new StringBuilder();
            var newIdMethod = "GetNewID()";
            if(CodeCreateAttribute.PrimaryFieldType == eCodePrimaryFieldType.GenGUID)
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
            
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Creates new object with unique ID." + Nl));
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        /// <returns>Object of TDataClass</returns>" + Nl));
            sb.Append(Format(lvl,"        public TDataClass GetNewData()" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        var aktData = new TDataClass(DisplayMemberDef);" + Nl));
            sb.Append(Format(lvl+1,"        try" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        aktData.Clear();" + Nl));
            if (table?.primary_constraint == null)
            {
                _localNotifies?.AddToERROR("No PrimaryKey in Table " + table.Name + ", using field ID instead in method:  public TDataClass GetNewData()");
                sb.Append(Format(lvl+2,"        aktData.Item.ID = "+ newIdMethod + ";" + Nl));
            }
            else
            {                
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                if(!string.IsNullOrEmpty(fn))
                { 
                    sb.Append(Format(lvl+2,"        aktData.Item." + fn + " = "+ newIdMethod + ";" + Nl));
                }
            }
            sb.Append(Format(lvl+2,"        aktData.SetInsertMode();" + Nl));
            sb.Append(Format(lvl+2,"        Datas.Clear();" + Nl));
            sb.Append(Format(lvl+2,"        CurrentData = aktData;" + Nl));
            sb.Append(Format(lvl+2,"        Datas.Add(aktData);" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl+1,"        catch (Exception ex)" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        TMessages.Instance().HandleAndShowDBException(ex.Message,\""+table.Name+"->GetNewData()\");" + Nl));            
            sb.Append(Format(lvl+2,"        Application.Exit();" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl+1,"        return (aktData);" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            sb.Append(Nl);
            sb.Append(Format(lvl,"        /// <summary>" + Nl));
            sb.Append(Format(lvl,"        /// Creates new object with unique ID." + Nl));
            sb.Append(Format(lvl,"        /// Preceding an group-prefix to ID." + Nl));
            sb.Append(Format(lvl,"        /// </summary>" + Nl));
            sb.Append(Format(lvl,"        /// <returns>Object of TDataClass</returns>" + Nl));
            sb.Append(Format(lvl,"        public TDataClass GetNewData(int gruppe)" + Nl));
            sb.Append(Format(lvl,"        {" + Nl));
            sb.Append(Format(lvl+1,"        var aktData = new TDataClass(DisplayMemberDef);" + Nl));
            sb.Append(Format(lvl+1,"        try" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        aktData.Clear();" + Nl));
            if (table?.primary_constraint == null)
            {
                _localNotifies?.AddToERROR("No PrimaryKey in Table " + table.Name + ", using field ID instead in method:  public TDataClass GetNewData(int gruppe)");
                sb.Append(Format(lvl+2,"        aktData.Item.ID = "+ newIdMethod + ";" + Nl));
            }
            else
            {              
                string fn = StaticFunctionsClass.GetFirstDictionaryEntry(table.primary_constraint.FieldNames);
                if(!string.IsNullOrEmpty(fn))                
                { 
                    sb.Append(Format(lvl+2,"        aktData.Item." + fn + " = "+ newIdMethod + ";" + Nl));
                }
            }
            
            sb.Append(Format(lvl+2,"        aktData.SetInsertMode();" + Nl));
            sb.Append(Format(lvl+2,"        Datas.Clear();" + Nl));
            sb.Append(Format(lvl+2,"        CurrentData = aktData;" + Nl));
            sb.Append(Format(lvl+2,"        Datas.Add(aktData);" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl+1,"        catch (Exception ex)" + Nl));
            sb.Append(Format(lvl+1,"        {" + Nl));
            sb.Append(Format(lvl+2,"        TMessages.Instance().HandleAndShowDBException(ex.Message,\""+table.Name+"->GetNewData()\");" + Nl));
            sb.Append(Format(lvl+2,"        Application.Exit();" + Nl));
            sb.Append(Format(lvl+1,"        }" + Nl));
            sb.Append(Format(lvl+1,"        return (aktData);" + Nl));
            sb.Append(Format(lvl,"        }" + Nl));
            return sb.ToString();
        }

        public string CreateFieldEnum(int lvl,DataObjectClass obj)
        {
            if(obj == null) return Empty;

            var sb = new StringBuilder();
            if (obj.GetType() == typeof(TableClass))
            {
                var table = obj as TableClass;
                sb.Append(Format(lvl,"        /// <summary>" + Nl));
                sb.Append(Format(lvl,"        /// Enum of available dataindexes" + Nl));                
                sb.Append(Format(lvl,"        /// </summary>" + Nl));
                sb.Append(Format(lvl,"        public enum eTDataClass {"));
                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {                    
                    sb.Append(tfc.Name + " = " + n++.ToString() + ",");
                }
                sb.Append(Format(lvl," NO_FIELD = " + n.ToString()));
                sb.Append(Format(lvl,"};" + Nl));
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var table = obj as ViewClass;
                sb.Append(Format(lvl, "        /// <summary>" + Nl));
                sb.Append(Format(lvl, "        /// Enum of available dataindexes" + Nl));                
                sb.Append(Format(lvl, "        /// </summary>" + Nl));
                sb.Append(Format(lvl, "        public enum eTDataClass {"));
                int n = 0;
                foreach (var tfc in table.Fields.Values)
                {                    
                    sb.Append(tfc.Name + " = " + n++.ToString() + ",");
                }
                sb.Append(Format(lvl, " NO_FIELD = " + n.ToString()));
                sb.Append(Format(lvl, "};" + Nl));
            }
            return sb.ToString();
        }

        public string CreateCopyright(int lvl, string tablename)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "#pragma warning disable 1587" + Nl));
            sb.Append(Format(lvl, "/// <summary>" + Nl));
            sb.Append(Format(lvl, "/// ###############################################################################################" + Nl));
            sb.Append(Format(lvl, "/// # C# Codegenerator for Tableobjects V6.0.0                                                    #" + Nl));
            sb.Append(Format(lvl, "/// # Copyright (c) by SoftEnd, Horst Ender, Finkenweg 5, 96215 Lichtenfels - All Rights Reserved #" + Nl));
            sb.Append(Format(lvl, "/// #                                                                                             #" + Nl));
            sb.Append(Format(lvl, "/// # Unauthorized copying or manipulating of this file, via any medium is strictly prohibited    #" + Nl));
            sb.Append(Format(lvl, "/// # Proprietary and confidential                                                                #" + Nl));
            sb.Append(Format(lvl, "/// #                                                                                             #" + Nl));
            sb.Append(Format(lvl, "/// # Date    : " + String.Format("{0,-82}#{1}", DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToLongTimeString(),Nl)));
            sb.Append(Format(lvl, "/// # Class   : " + String.Format("{0,-82}#{1}", tablename+ "Class", Nl)));
            sb.Append(Format(lvl, "/// # Base    : " + String.Format("{0,-82}#{1}",_basename, Nl)));
            sb.Append(Format(lvl, "/// # PK type : " + String.Format("{0,-82}#{1}",CodeCreateAttribute.PrimaryFieldType.ToString(),Nl)));
            sb.Append(Format(lvl, "/// ###############################################################################################" + Nl));
            sb.Append(Format(lvl, "/// </summary>" + Nl));
            sb.Append(Format(lvl, "#pragma warning restore 1587" + Nl));
            return sb.ToString();
        }

        public string CreateTableUsings(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl, "#region Using directives" + Nl));
            sb.Append(Format(lvl, "using System;" + Nl));
            sb.Append(Format(lvl, "using System.Collections;" + Nl));            
            sb.Append(Format(lvl, "using System.IO;" + Nl));
            sb.Append(Format(lvl, "using System.Text;" + Nl));
            sb.Append(Format(lvl, "using System.Xml.Serialization;" + Nl));            
            sb.Append(Format(lvl, "using System.Xml;" + Nl));
            sb.Append(Format(lvl, "using System.Windows.Forms;" + Nl));
            sb.Append(Format(lvl, "using System.Numerics;" + Nl));
            sb.Append(Format(lvl, "using DBBasicClassLibrary;" + Nl));            
            sb.Append(Format(lvl, "using MessageLibrary.Messages;" + Nl));
            sb.Append(Format(lvl, "using BasicClassLibrary;" + Nl));
            sb.Append(Format(lvl, "#endregion" + Nl));
            return sb.ToString();
        }

        public string CreateCbTableUsings(int lvl)
        {
            var sb = new StringBuilder();
            sb.Append(Format(lvl,"#region Using directives" + Nl));    
            sb.Append(Format(lvl,"using System;" + Nl));
            sb.Append(Format(lvl,"using System.Windows.Forms;" + Nl));
            sb.Append(Format(lvl,"using System.Numerics;" + Nl));
            sb.Append(Format(lvl,"using DBBasicClassLibrary;" + Nl));           
            sb.Append(Format(lvl,"#endregion" + Nl));
            return sb.ToString();
        }
    }
}
