using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace FBXpert.DataClasses
{
    public class DBDataTypes : Type
    {
        public string Caption;

        public override Guid GUID => throw new NotImplementedException();

        public override Module Module => throw new NotImplementedException();

        public override Assembly Assembly => throw new NotImplementedException();

        public override string FullName => throw new NotImplementedException();

        public override string Namespace => throw new NotImplementedException();

        public override string AssemblyQualifiedName => throw new NotImplementedException();

        public override Type BaseType => throw new NotImplementedException();

        public override Type UnderlyingSystemType => throw new NotImplementedException();

        public override string Name
        {
            get
            {
                return Caption;
            }
        }

        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override Type GetElementType()
        {
            throw new NotImplementedException();
        }

        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetInterface(string name, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetInterfaces()
        {
            throw new NotImplementedException();
        }

        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        protected override TypeAttributes GetAttributeFlagsImpl()
        {
            throw new NotImplementedException();
        }

        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override bool HasElementTypeImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsArrayImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsByRefImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsCOMObjectImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPointerImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPrimitiveImpl()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return Caption;
        }
    }
    class DBVarchar : DBDataTypes
    {
        public DBVarchar()
        {
            base.Caption = "VARCHAR";
        }
    }
    class DBBlob : DBDataTypes
    {
        public DBBlob()
        {
            base.Caption = "BLOB";
        }
    }
    class DBInt64 : DBDataTypes
    {
        public DBInt64()
        {
            base.Caption = "BIGINT";
        }
    }
    class DBInteger : DBDataTypes
    {
        public DBInteger()
        {
            base.Caption = "INTEGER";
        }
    }
    class DBSmallInt : DBDataTypes
    {
        public DBSmallInt()
        {
            base.Caption = "SMALLINT";
        }
    }
    class DBTimestamp : DBDataTypes
    {
        public DBTimestamp()
        {
            base.Caption = "TIMESTAMP";
        }
    }

    class DBDate : DBDataTypes
    {
        public DBDate()
        {
            base.Caption = "DATE";
        }
    }

    class DBDoublePrecision : DBDataTypes
    {
        public DBDoublePrecision()
        {
            base.Caption = "DOUBLE PRECISION";
        }
    }

    class DBNumeric : DBDataTypes
    {
        public DBNumeric()
        {
            base.Caption = "NUMERIC";
        }
    }

    class DBTypeList
    {

        public List<DBDataTypes> Values = new List<DBDataTypes>();
        public DBTypeList()
        {

            Values.Add(new DBVarchar());
            Values.Add(new DBInteger());
            Values.Add(new DBSmallInt());
            Values.Add(new DBNumeric());
            Values.Add(new DBTimestamp());
            Values.Add(new DBDate());
            Values.Add(new DBBlob());
            Values.Add(new DBDoublePrecision());
            Values.Add(new DBInt64());
        }

    }

}
