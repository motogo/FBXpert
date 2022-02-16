using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpertLib.Globals;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FBExpert.DataClasses
{

    public class DefaultConnectionClass : ConnectionAttributes
    {
        public string Collation = "NONE";
        public string Role = string.Empty;
        
        public DefaultConnectionClass()
        {

        }
        
    }   
    public static class DataClassFactory
    {
        public static DataObjectClass GetDataClass(string name)
        {
            switch (name.ToUpper())
            {
                case StaticVariablesClass.TablesKeyStr: return new TableClass();
                case StaticVariablesClass.ViewsKeyStr: return new ViewClass();
                case StaticVariablesClass.GeneratorsKeyStr: return new GeneratorClass();
                case StaticVariablesClass.ProceduresKeyStr: return new ProcedureClass();
                case StaticVariablesClass.TriggersKeyStr: return new TriggerClass();
                case StaticVariablesClass.FieldsKeyStr: return new TableFieldClass();
                case StaticVariablesClass.RolesKeyStr: return new RoleClass();
                case StaticVariablesClass.IndicesKeyStr: return new IndexClass();
                
                case StaticVariablesClass.DomainsKeyStr: return new DomainClass();
                case "TYPE": return new TypeClass();
                case StaticVariablesClass.FunctionsKeyStr: return new FunctionClass();
                case StaticVariablesClass.UserDefinedFunctionsKeyStr: return new UserDefinedFunctionClass();
                case StaticVariablesClass.ForeignKeyStr : return new ForeignKeyClass();
                case StaticVariablesClass.PrimaryKeyStr: return new PrimaryKeyClass();
                case StaticVariablesClass.UniquesKeyStr: return new UniquesClass();
                case StaticVariablesClass.NotNullKeyStr: return new NotNullsClass();
                case StaticVariablesClass.ChecksKeyStr: return new ChecksClass();
                case StaticVariablesClass.ConstraintsKeyStr: return new ConstraintsClass();
                case StaticVariablesClass.DependenciesKeyStr: return new DependencyClass();
            }
            
            return null;
        }
        public static string GetTooltip(string name, object obj)
        {
            if(obj == null) return "Object -> NULL";
            if (name == StaticVariablesClass.FieldsKeyStr)
            {
                TableFieldClass fld = (TableFieldClass)obj;
                return fld.Domain.RawType;
            }
            else if (name == StaticVariablesClass.ProceduresKeyStr)
            {
                return String.Empty;
            }
            else if (name == StaticVariablesClass.TablesKeyStr)
            {
                return String.Empty;
            }
            else if (name == StaticVariablesClass.ViewsKeyStr)
            {
                return String.Empty;
            }
            else if (name == StaticVariablesClass.ViewFieldsKeyStr)
            {
                ViewFieldClass fld = (ViewFieldClass)obj;
                return fld.Domain.RawType;
            }
            else if (name == StaticVariablesClass.IndicesKeyStr)
            {
                IndexClass fc = (IndexClass)obj;
                return (fc.ConstraintName.Length > 0) ? $@"This index has {fc.ConstraintName} to {fc.RelationName}" : $@"This index has relation to {fc.RelationName}";
            }
            else if (name == StaticVariablesClass.DependenciesToKeyStr)
            {
                DependencyClass fc = (DependencyClass)obj;
                return $@"{fc.Name}->{fc.FieldName} depend on {fc.DependOnName}";
            }
            else if (name == StaticVariablesClass.DependenciesFromProceduresKeyStr)
            {
                DependencyClass fc = (DependencyClass)obj;
                return $@"{fc.Name} depent on procedure {fc.DependOnName}";
            }
            else if (name == StaticVariablesClass.DependenciesFromViewsKeyStr)
            {
                DependencyClass fc = (DependencyClass)obj;
                return $@"{fc.Name} depent on view {fc.DependOnName}";
            }
            else if (name == StaticVariablesClass.ForeignKeyStr)
            {
                ForeignKeyClass fc = (ForeignKeyClass)obj;
                return $@"This foreign key has relation to {fc.Name}";
            }
            return obj.GetType().ToString();
        }
        public static string GetTooltipParent(string name, object obj)
        {
            if (obj == null) return "Object -> NULL";
 
            if (name == StaticVariablesClass.ForeignKeyStr)
            {
                return $@"This foreign key has relation to {((DataObjectClass)obj).Name}";
            }
            if (name == StaticVariablesClass.PrimaryKeyStr)
            {
                TableClass tc = (TableClass)obj;
                return $@"This (primary key) constraint has relation to {tc.Name}";
            }
            if (name == StaticVariablesClass.IndicesKeyStr)
            {
                TableClass tc = (TableClass)obj;
                return $@"This index has relation to {tc.Name}";
            }
            if (name == StaticVariablesClass.IndicesKeyStr)
            {
                TableClass tc = (TableClass)obj;
                return $@"This unique constraint has relation to {tc.Name}";
            }
            if (name == StaticVariablesClass.NotNullKeyStr)
            {
                TableClass tc = (TableClass)obj;
                return $@"This not null constraint has relation to {tc.Name}";
            }
            if (name == StaticVariablesClass.ChecksKeyStr)
            {
                TableClass tc = (TableClass)obj;
                return $@"This not check constraint has relation to {tc.Name}";
            }
            if (name == StaticVariablesClass.TriggersKeyStr)
            {
                TableClass tc = (TableClass)obj;
                return $@"This not trigger has relation to {tc.Name}";
            }
            return obj.GetType().ToString();
        }

        public static Color GetColor(string name, object obj)
        {
            if ((name == StaticVariablesClass.IndicesKeyStr)|| (name == StaticVariablesClass.SystemIndicesKeyStr))
            {
                IndexClass fc = (IndexClass)obj;
                Color ForeColor = fc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;

                if (fc.ConstraintName.Length > 0)
                {
                    ForeColor = fc.IsActive ? StaticTreeClass.Instance().ActiveHasConstraint : StaticTreeClass.Instance().InactiveHasConstraint;
                }
                else
                {
                    ForeColor = fc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;
                }
                return ForeColor;
            }
            if (name == StaticVariablesClass.ForeignKeyStr)
            {
                ForeignKeyClass tc = (ForeignKeyClass)obj;
                return tc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;
            }
            return Color.Black;
        }
        public static TreeNode GetNewNode(string name, string text, object obj, object parent)
        {
            TreeNode node = GetNewNode1(name, text, obj);
            if (node != null)
            {
                node.ToolTipText = GetTooltipParent(name, parent);
                node.ForeColor = GetColor(name, obj);
            }
            return node;
        }
        private static TreeNode GetNewNode1(string name, string text, object obj)
        {
            TreeNode node = GetNewNode(name);
            if (node != null)
            {
                node.Tag = obj;
                node.Text =  (obj != null) 
                    ? (obj.GetType() == typeof(DBRegistrationClass)) ? ((DBRegistrationClass)obj).GetCaption() : text 
                    : "object -> null";

            }
            
            return node;
        }
        public static TreeNode GetNewNode(string name, string text, object obj)
        {
            TreeNode node = GetNewNode1(name, text, obj);
            if (node != null)
            {
                node.ToolTipText = GetTooltip(name, obj);
                node.ForeColor = GetColor(name, obj);
            }
            return node;
        }
        
        public static TreeNode GetNewNode(string name, string text)
        {
            TreeNode node = GetNewNode(name);
            if (node != null)
            {
                node.Text= text;
            }
            return node;
        }
        public static TreeNode GetNewNode(string name)
        {
            TreeNode node;
            switch (name.ToUpper())
            {
                case StaticVariablesClass.DatabaseKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Database",
                        Tag = new DBRegistrationClass(),
                        ImageIndex = (int)eImageIndex.DATABASE_INACTIVE
                    };
                    return node;
                case StaticVariablesClass.ProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Procedures",
                        Tag = new ProceduresGroupClass(),
                        ImageIndex = (int)eImageIndex.PROCEDURE
                    };
                    return node;
               case StaticVariablesClass.ProceduresKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Procedures",
                        Tag = new ProcedureClass(),
                        ImageIndex = (int)eImageIndex.PROCEDURE
                    };
                    return node;

                case StaticVariablesClass.FunctionsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "User defined functions",
                        Tag = new FunctionGroupClass(),
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;

                case StaticVariablesClass.UserDefinedFunctionsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "User defined functions",
                        Tag = new UserDefinedFunctionGroupClass(),
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;
                case StaticVariablesClass.ForeignKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
            
                        Text = "Foreign Keys",
                        Tag = new ForeignKeyGroupClass(),
                        ImageIndex = (int)eImageIndex.KEYS
                    };
                    return node;
                case StaticVariablesClass.PrimaryKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Primary Keys",                        
                        Tag = new PrimaryKeyGroupClass(),
                        ImageIndex = (int)eImageIndex.PRIMARYKEY
                    };
                    return node;

                case StaticVariablesClass.PrimaryKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Primary Key",
                        Tag = new PrimaryKeyClass(),
                        ImageIndex = (int)eImageIndex.PRIMARYKEY
                    };
                    return node;
                case StaticVariablesClass.ConstraintsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Constraints",
                        Tag = new ConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.KEYS
                    };
                    return node;
                case StaticVariablesClass.ConstraintsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Constraint",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.KEYS
                    };
                    return node;
                case StaticVariablesClass.FunctionsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Function",
                        Name = name.ToUpper(),
                        Tag = new FunctionClass(),
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;
                case StaticVariablesClass.UserDefinedFunctionsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "User defined function",
                        Name = name.ToUpper(),
                        Tag = new UserDefinedFunctionClass(),
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;
                case StaticVariablesClass.ForeignKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Foreign Key",
                        Tag = new ForeignKeyClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.FOREIGNKEY
                    };
                    return node;
                case StaticVariablesClass.FieldsKeyStr:

                    node = new TreeNode()
                    {
                        Text = "Field",
                        Tag = new TableFieldClass(),
                        Name = name.ToUpper(),                        
                        ImageIndex = (int)eImageIndex.FIELDS
                    };
                    
                    return node;
                case StaticVariablesClass.FieldsKeyGroupStr:

                    node = new TreeNode()
                    {
                        Text = "Fields",
                        Name = name.ToUpper(),
                        Tag = new TableFieldGroupClass(),
                        ImageIndex = (int)eImageIndex.FIELDS
                    };

                    return node;
                case StaticVariablesClass.ViewFieldsKeyStr:

                    node = new TreeNode()
                    {
                        Text = "Field",
                        Tag = new ViewFieldClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.FIELDS
                    };

                    return node;
                case StaticVariablesClass.ViewFieldsKeyGroupStr:

                    node = new TreeNode()
                    {
                        Text = "Fields",
                        Name = name.ToUpper(),
                        Tag = new  ViewFieldGroupClass(),
                        ImageIndex = (int)eImageIndex.FIELDS
                    };

                    return node;
                case StaticVariablesClass.UniquesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Uniques",
                        Name = name.ToUpper(),
                        Tag = new  UniqueConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.UNIQUE
                    };
                    return node;
                case StaticVariablesClass.UniquesKeyStr:

                    node = new TreeNode()
                    {
                        Text = "Unique",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.UNIQUE
                    };

                    return node;
                case StaticVariablesClass.NotNullKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Not Nulls",
                        Name = name.ToUpper(),
                        Tag = new NotNullConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.NOTNULL
                    };
                    return node;
                case StaticVariablesClass.NotNullKeyStr:

                    node = new TreeNode()
                    {
                        Text = "Not Null",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.NOTNULL
                    };
                    return node;
                case StaticVariablesClass.ChecksKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Checks",
                        Name = name.ToUpper(),
                        Tag = new ChecksKeyConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.CHECK
                    };
                    return node;
                case StaticVariablesClass.ChecksKeyStr:

                    node = new TreeNode()
                    {
                        Text = "Check",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.CHECK
                    };
                    return node;

                case StaticVariablesClass.DependenciesKeyGroupStr:

                    node = new TreeNode()
                    {
                        Text = "Dependencies",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesTablesKeyGroupStr:

                    node = new TreeNode()
                    {
                        Text = "Tables",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies To",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies From",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Triggers",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies To",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies From",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesToTriggersKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Dependency to",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromTriggersKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Dependency from",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Views",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Depends on Views",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesToViewsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Depends to View",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies from Views",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromViewsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Depends from View",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;


                case StaticVariablesClass.DependenciesFromKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies from ",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Depends from ",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesToKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies to ",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesToKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Depends to ",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;


                case StaticVariablesClass.DependenciesProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Procedures",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Depends on Procedures",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesToProceduresKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Depends on procedure",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Dependencies From",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromProceduresKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Depends from procedure",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.TriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Triggers",
                        Name = name.ToUpper(),
                        Tag = new TriggerGroupClass(),
                        ImageIndex = (int)eImageIndex.TRIGGERS
                    };
                    
                    return node;
                case StaticVariablesClass.TriggersKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Trigger",
                        Tag = new TriggerClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.TRIGGERS
                    };
                    return node;

                case StaticVariablesClass.SystemTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "System Triggers",
                        Name = name.ToUpper(),
                        Tag = new TriggerGroupClass(),
                        
                        ImageIndex = (int)eImageIndex.TRIGGERS
                    };

                    return node;
                case StaticVariablesClass.SystemTriggersKeyStr:
                    node = new TreeNode()
                    {
                        Text = "System Trigger",
                        Tag = new TriggerClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.TRIGGERS
                    };
                    return node;


                case StaticVariablesClass.IndicesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Indices",
                        Name = name.ToUpper(),
                        Tag = new IndexGroupClass(),
                        ImageIndex = (int)eImageIndex.INDEX
                    };
                    return node;

                case StaticVariablesClass.SystemIndicesKeyStr:
                    node = new TreeNode()
                    {
                        Text = "System-Index",
                        Tag = new IndexClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.INDEX
                    };
                    return node;

                case StaticVariablesClass.SystemIndicesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "System-Indices",
                        Name = name.ToUpper(),
                        Tag = new IndexGroupClass(),
                        ImageIndex = (int)eImageIndex.INDEX
                    };
                    return node;

                case StaticVariablesClass.IndicesKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Index",
                        Tag = new IndexClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.INDEX
                    };
                    return node;

                case StaticVariablesClass.RolesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Roles",
                        Tag = new RoleGroupClass(),
                        ImageIndex = (int)eImageIndex.ROLES
                    };
                    return node;
                case StaticVariablesClass.RolesKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Role",
                        Tag = new RoleClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.ROLES
                    };
                    return node;

                case StaticVariablesClass.GeneratorsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Text = "Generators",
                        Name = name.ToUpper(),
                        Tag = new GeneratorGroupClass(),
                        ImageIndex = (int)eImageIndex.GENERATORS
                    };
                    return node;
                case StaticVariablesClass.GeneratorsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Generators",
                        Name = name.ToUpper(),
                        Tag = new GeneratorClass(),
                        ImageIndex = (int)eImageIndex.GENERATORS
                    };
                    return node;

                case StaticVariablesClass.CommonTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Tables",
                        Tag = new TableGroupClass(),
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;

                case StaticVariablesClass.TablesKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Table",
                        Tag = new TableClass(),
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;
                case StaticVariablesClass.SystemTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "System Tables",
                        Tag = new SystemTableGroupClass(),
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;

                case StaticVariablesClass.SystemTablesKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Systemtable",
                        Tag = new SystemTableClass(),
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;
                case StaticVariablesClass.ViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Views",
                        Tag = new ViewGroupClass(),
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;

                case StaticVariablesClass.ViewsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "View",
                        Tag = new ViewClass(),
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;


                case StaticVariablesClass.ConstraintsViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Constraints Views",
                        Tag = new ViewGroupClass(),
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;

                case StaticVariablesClass.ConstraintsViewsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Constraints for View",
                        Tag = new ViewClass(),
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;

                case StaticVariablesClass.DomainsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Domains",
                        Tag = new DomainGroupClass(),
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;

                case StaticVariablesClass.DomainsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Domain",
                        Tag = new DomainClass(),
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;

                case StaticVariablesClass.SystemDomainsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "System Domains",
                        Tag = new DomainGroupClass(),
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;

                case StaticVariablesClass.SystemDomainsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "System Domain",
                        Tag = new DomainClass(),
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;


            }
            NotifiesClass.Instance.AddToERROR($@"DataCLassFactory->GetNode->{name} not created", "GetNode");
            return null;
        }
    }
}
