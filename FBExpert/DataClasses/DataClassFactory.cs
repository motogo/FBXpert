using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using System;
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
        public static TreeNode GetNewNode(string name, string text, object obj)
        {
            TreeNode node = GetNewNode(name);
            if (node != null)
            {
                node.Tag = obj;
                node.Text = text;
              
                if (obj != null)
                    node.ToolTipText = obj.GetType().ToString();
                else
                    node.ToolTipText = "object -> null";
            }
            return node;
        }
        public static TreeNode GetNewNode(string name, object obj)
        {
            TreeNode node = GetNewNode(name);
            if (node != null)
            {
                node.Tag = obj;
               

                if (obj != null)
                    node.ToolTipText = obj.GetType().ToString();
                else
                    node.ToolTipText = "object -> null";
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
            ContextMenuStrip cmnull = new ContextMenuStrip();
            switch (name.ToUpper())
            {
                case StaticVariablesClass.DatabaseKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Database",
                        Tag = new DBRegistrationClass(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsDatabase,
                        ImageIndex = (int)eImageIndex.DATABASE_INACTIVE
                    };
                    return node;
                case StaticVariablesClass.ProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Procedures",
                        Tag = new ProceduresGroupClass(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsProcedureGroup,
                        ImageIndex = (int)eImageIndex.PROCEDURE
                    };
                    return node;
               case StaticVariablesClass.ProceduresKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Procedures",
                        Tag = new ProcedureClass(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsProcedure,
                        ImageIndex = (int)eImageIndex.PROCEDURE
                    };
                    return node;

                case StaticVariablesClass.FunctionsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "User defined functions",
                        Tag = new FunctionGroupClass(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsFunctionGroup,
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;

                case StaticVariablesClass.UserDefinedFunctionsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "User defined functions",
                        Tag = new UserDefinedFunctionGroupClass(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsUserDefinedFunctionGroup,
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;
                case StaticVariablesClass.ForeignKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsForeignKeyGroup,
                        Text = "Foreign Keys",
                        Tag = new ForeignKeyGroupClass(),
                        ImageIndex = (int)eImageIndex.KEYS
                    };
                    return node;
                case StaticVariablesClass.PrimaryKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsPrimaryKeyGroup,
                        Text = "Primary Keys",                        
                        Tag = new PrimaryKeyGroupClass(),
                        ImageIndex = (int)eImageIndex.PRIMARYKEY
                    };
                    return node;

                case StaticVariablesClass.PrimaryKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsPrimaryKey,
                        Text = "Primary Key",
                        Tag = new PrimaryKeyClass(),
                        ImageIndex = (int)eImageIndex.PRIMARYKEY
                    };
                    return node;
                case StaticVariablesClass.ConstraintsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsContraintsGroup,
                        Text = "Constraints",
                        Tag = new ConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.KEYS
                    };
                    return node;
                case StaticVariablesClass.ConstraintsKeyStr:
                    node = new TreeNode()
                    {
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsContraints,
                        Text = "Constraint",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.KEYS
                    };
                    return node;
                case StaticVariablesClass.FunctionsKeyStr:
                    node = new TreeNode()
                    {
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsFunction,
                        Text = "Function",
                        Name = name.ToUpper(),
                        Tag = new FunctionClass(),
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;
                case StaticVariablesClass.UserDefinedFunctionsKeyStr:
                    node = new TreeNode()
                    {
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsUserDefinedFunction,
                        Text = "User defined function",
                        Name = name.ToUpper(),
                        Tag = new UserDefinedFunctionClass(),
                        ImageIndex = (int)eImageIndex.FUNCTION
                    };
                    return node;
                case StaticVariablesClass.ForeignKeyStr:
                    node = new TreeNode()
                    {
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsForeignKey,
                        Text = "Foreign Key",
                        Tag = new ForeignKeyClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.FOREIGNKEY
                    };
                    return node;
                case StaticVariablesClass.FieldsKeyStr:

                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Field",
                        Tag = new TableFieldClass(),
                        Name = name.ToUpper(),                        
                        ImageIndex = (int)eImageIndex.FIELDS
                    };
                    
                    return node;
                case StaticVariablesClass.FieldsKeyGroupStr:

                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Fields",
                        Name = name.ToUpper(),
                        Tag = new TableFieldGroupClass(),
                        ImageIndex = (int)eImageIndex.FIELDS
                    };

                    return node;
                case StaticVariablesClass.ViewFieldsKeyStr:

                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Field",
                        Tag = new ViewFieldClass(),
                        Name = name.ToUpper(),
                        ImageIndex = (int)eImageIndex.FIELDS
                    };

                    return node;
                case StaticVariablesClass.ViewFieldsKeyGroupStr:

                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Fields",
                        Name = name.ToUpper(),
                        Tag = new  ViewFieldGroupClass(),
                        ImageIndex = (int)eImageIndex.FIELDS
                    };

                    return node;
                case StaticVariablesClass.UniquesKeyGroupStr:
                    node = new TreeNode()
                    {
                        ContextMenuStrip = cmnull,
                        Text = "Uniques",
                    //    Name = StaticVariablesClass.UniquesKeyGroupStr,
                        Tag = new  UniqueConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.UNIQUE
                    };
                    return node;
                case StaticVariablesClass.UniquesKeyStr:

                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Unique",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.UNIQUE
                    };

                    return node;
                case StaticVariablesClass.NotNullKeyGroupStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Not Nulls",
                        Name = name.ToUpper(),
                        Tag = new NotNullConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.NOTNULL
                    };
                    return node;
                case StaticVariablesClass.NotNullKeyStr:

                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Not Null",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.NOTNULL
                    };
                    return node;
                case StaticVariablesClass.ChecksKeyGroupStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Checks",
                        Name = name.ToUpper(),
                        Tag = new ChecksKeyConstraintsGroupClass(),
                        ImageIndex = (int)eImageIndex.CHECK
                    };
                    return node;
                case StaticVariablesClass.ChecksKeyStr:

                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Check",
                        Name = name.ToUpper(),
                        Tag = new ConstraintsClass(),
                        ImageIndex = (int)eImageIndex.CHECK
                    };
                    return node;

                case StaticVariablesClass.DependenciesKeyGroupStr:

                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Dependencies",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesTablesKeyGroupStr:

                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Tables",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Dependencies To",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Dependencies From",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Triggers",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = cmnull,
                        Text = "Dependencies To",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromTriggersKeyGroupStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Dependencies From",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesToTriggersKeyStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Dependency to",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromTriggersKeyStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Dependency from",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Views",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Depends on Views",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesToViewsKeyStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Depends to View",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                       // ContextMenuStrip = cmnull,
                        Text = "Dependencies from Views",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromViewsKeyStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Depends from View",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;


                case StaticVariablesClass.DependenciesFromKeyGroupStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Dependencies from ",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromKeyStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Depends from ",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;

                case StaticVariablesClass.DependenciesToKeyGroupStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Dependencies to ",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesToKeyStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Depends to ",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;


                case StaticVariablesClass.DependenciesProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Procedures",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCY
                    };
                    return node;

                case StaticVariablesClass.DependenciesToProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Depends on Procedures",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;
                case StaticVariablesClass.DependenciesToProceduresKeyStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Depends on procedure",
                        Name = name.ToUpper(),
                        Tag = new DependencyClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYTO
                    };
                    return node;

                case StaticVariablesClass.DependenciesFromProceduresKeyGroupStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
                        Text = "Dependencies From",
                        Name = name.ToUpper(),
                        Tag = new DependencyGroupClass(),
                        ImageIndex = (int)eImageIndex.DEPENDENCYFROM
                    };
                    return node;
                case StaticVariablesClass.DependenciesFromProceduresKeyStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = cmnull,
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
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsTriggerGroup,
                        ImageIndex = (int)eImageIndex.TRIGGERS
                    };
                    
                    return node;
                case StaticVariablesClass.TriggersKeyStr:
                    node = new TreeNode()
                    {
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsTrigger,
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
                        //   ContextMenuStrip = ContextMenusClass.Instance().cmsTriggerGroup,
                        ImageIndex = (int)eImageIndex.TRIGGERS
                    };

                    return node;
                case StaticVariablesClass.SystemTriggersKeyStr:
                    node = new TreeNode()
                    {
                        //ContextMenuStrip = ContextMenusClass.Instance().cmsTrigger,
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
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsIndicesGroup,
                        ImageIndex = (int)eImageIndex.INDEX
                    };
                    return node;

                case StaticVariablesClass.SystemIndicesKeyStr:
                    node = new TreeNode()
                    {
                      //  ContextMenuStrip = ContextMenusClass.Instance().cmsIndices,
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
                        //   ContextMenuStrip = ContextMenusClass.Instance().cmsIndicesGroup,
                        ImageIndex = (int)eImageIndex.INDEX
                    };
                    return node;

                case StaticVariablesClass.IndicesKeyStr:
                    node = new TreeNode()
                    {
                        //  ContextMenuStrip = ContextMenusClass.Instance().cmsIndices,
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
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsRolesGroup,
                        ImageIndex = (int)eImageIndex.ROLES
                    };
                    return node;
                case StaticVariablesClass.RolesKeyStr:
                    node = new TreeNode()
                    {
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsRoles,
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
                       // ContextMenuStrip = ContextMenusClass.Instance().cmsGeneratorGroup,
                        ImageIndex = (int)eImageIndex.GENERATORS
                    };
                    return node;
                case StaticVariablesClass.GeneratorsKeyStr:
                    node = new TreeNode()
                    {
                        Text = "Generators",
                        Name = name.ToUpper(),
                        Tag = new GeneratorClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsGenerator,
                        ImageIndex = (int)eImageIndex.GENERATORS
                    };
                    return node;

                case StaticVariablesClass.CommonTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Tables",
                        Tag = new TableGroupClass(),
                      //  ContextMenuStrip = ContextMenusClass.Instance().cmsTableGroup,
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;

                case StaticVariablesClass.TablesKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Table",
                        Tag = new TableClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsTable,
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;
                case StaticVariablesClass.SystemTablesKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "System Tables",
                        Tag = new SystemTableGroupClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsSystemTableGroup,
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;

                case StaticVariablesClass.SystemTablesKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Systemtable",
                        Tag = new SystemTableClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsSystemTable,
                        ImageIndex = (int)eImageIndex.TABLES
                    };
                    return node;
                case StaticVariablesClass.ViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Views",
                        Tag = new ViewGroupClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsViewGroup,
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;

                case StaticVariablesClass.ViewsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "View",
                        Tag = new ViewClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsView,
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;


                case StaticVariablesClass.ConstraintsViewsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Constraints Views",
                        Tag = new ViewGroupClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsViewGroup,
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;

                case StaticVariablesClass.ConstraintsViewsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Constraints for View",
                        Tag = new ViewClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsView,
                        ImageIndex = (int)eImageIndex.VIEW
                    };
                    return node;

                case StaticVariablesClass.DomainsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Domains",
                        Tag = new DomainGroupClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsDomainGroup,
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;

                case StaticVariablesClass.DomainsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "Domain",
                        Tag = new DomainClass(),
                     //   ContextMenuStrip = ContextMenusClass.Instance().cmsDomain,
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;

                case StaticVariablesClass.SystemDomainsKeyGroupStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "System Domains",
                        Tag = new DomainGroupClass(),
                        //   ContextMenuStrip = ContextMenusClass.Instance().cmsDomainGroup,
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;

                case StaticVariablesClass.SystemDomainsKeyStr:
                    node = new TreeNode()
                    {
                        Name = name.ToUpper(),
                        Text = "System Domain",
                        Tag = new DomainClass(),
                        //   ContextMenuStrip = ContextMenusClass.Instance().cmsDomain,
                        ImageIndex = (int)eImageIndex.DOMAIN
                    };
                    return node;


            }
            NotifiesClass.Instance.AddToERROR("DataCLassFactory->GetNode->" + name + " not created", "GetNode");
            return null;
        }
    }
}
