using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FBExpert
{
    public class StaticTreeClass : object
    {
        enum eTableTypes { SystemTables, UserdefinedTables, AllTables };
        public  string TypeName = "Stat0icTreeClass";
        public  Color Active   = Color.Blue;        
        public  Color Inactive = Color.Red;
        public  Color ActiveHasConstraint = Color.DarkCyan;
        public  Color InactiveHasConstraint = Color.OrangeRed;

        static ContextMenuStrip cmnull = new ContextMenuStrip();
        private static StaticTreeClass _instance;       
        private static readonly object _lock_this = new object();
        public static StaticTreeClass Instance()
        {
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {
               _instance = new StaticTreeClass();                        
            }
            return (_instance);
        }

        public IEnumerable<TreeNode> GetNodeBranch(TreeNode node)
        {
            yield return node;
            foreach (TreeNode child in node.Nodes)
                foreach (var childChild in GetNodeBranch(child))
                    yield return childChild;
        }
        
        public TreeNode FindNode(TreeNode nd, string name)
        {            
            foreach(TreeNode n in nd.Nodes)
            {               
                if (n.Name == name )
                {
                    return n;
                }                
            }            
            return null;
        }

        public TreeNode FindPrevDBNode(TreeNode nd)
        {
            TreeNode n = nd;
            while(n != null)
            {
                object obj = n.Tag;
                if(obj != null)
                {
                    string str = obj.GetType().Name;
                    if(str == "DBRegistrationClass")
                    {
                        return n;
                    }
                }
                n = n.Parent;
            }
            return null;
        }

        public TreeNode FindPrevTableNode(TreeNode nd)
        {
            TreeNode n = nd;
            while (n != null)
            {
                object obj = n.Tag;
                if (obj != null)
                {
                    string str = obj.GetType().Name;
                    if (str == "TableClass")
                    {
                        return n;
                    }
                }
                n = n.Parent;
            }
            return null;
        }

        public TreeNode FindPrevTableGroupNode(TreeNode nd)
        {
            TreeNode n = nd;
            while (n != null)
            {
                object obj = n.Tag;                                    
                if (obj?.GetType().Name == "TableGroupClass") return n;                                    
                n = n.Parent;
            }
            return null;
        }
        public TreeNode FindPrevFKGroupNode(TreeNode nd)
        {
            TreeNode n = nd;
            while (n != null)
            {
                object obj = n.Tag;                                    
                if (obj?.GetType().Name == "ForeignKeyGroupClass") return n;                                    
                n = n.Parent;
            }
            return null;
        }

        public TreeNode FindNextTableNode(TreeNode nd)
        {
            TreeNode n = nd;
            while (n != null)
            {
                object obj = n.Tag;
                if (obj == null) continue;
                
                string str = obj.GetType().Name;
                if ((str == "TableClass")&&(nd.Tag != n.Tag))
                {
                    return n;
                }

                if (n.Nodes == null) return null;
                n = ((str == "TableClass") && (n.Tag == nd.Tag)) ? n.NextNode : n.Nodes[0];                
            }
            return null;
        }


        //Durchsucht alle Knoten von nd und gibt den Erstgefundenen mit dem Namen 'name' zurück.
        public TreeNode FindFirstNodeInAllNodes(TreeNode nd, string name)
        {
            if(nd == null) return null;
            var allNodes = nd.Nodes.Cast<TreeNode>().SelectMany(GetNodeBranch);
            foreach (TreeNode n in allNodes)
            {
                if (n.Name == name)
                {
                    return n;
                }
            }
            return null;
        }

        //Entfernt den entsprechenden Gruppenknoten wenn vorhanden und baut ihn neu auf, aus den Informationen der bereits vorhandenen Tablenodes
        private void RemoveNodes(TreeNode node)
        {
            for (int i = node.Nodes.Count - 1; i >= 0; i--)
            {
                node.Nodes[i].Remove();
            }
        }
       
        public object Enviroment { get; private set; }
                
        private int CompareString(TreeNode x, TreeNode y)
        {
            return x.Text.CompareTo(y.Text);            
        }

        public void MakeTODependenciesNodesForAll(Dictionary<string,DependencyClass> DependenciesTO, List<TreeNode> dependencyTO_list_Node)
        {
            if (DependenciesTO != null)
            {
                string oldInxName = string.Empty;
                TreeNode depend_node = null;
                string oldDependName = string.Empty;
                TreeNode inx_node = null;
                foreach (var inx in DependenciesTO.Values)
                {
                    if (oldDependName != inx.Name)
                    {
                        oldInxName = string.Empty;
                        depend_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToKeyStr, inx.Name, inx);                        
                        dependencyTO_list_Node.Add(depend_node);
                        oldDependName = inx.Name;
                    }

                    if (oldInxName != inx.DependOnName)
                    {
                        inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToKeyStr, inx.DependOnName, inx);                        
                        depend_node.Nodes.Add(inx_node);
                        oldInxName = inx.DependOnName;
                    }                   
                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromKeyStr, inx.DependOnName + " -> " + inx.FieldName, inx);                        
                    inx_node.Nodes.Add(tablen);                        
                }
            }
        }

        public static void MakeFROMDependenciesNodesForAll(Dictionary<string,DependencyClass> DependenciesTO, List<TreeNode> dependencyTO_list_Node)
        {
            if (DependenciesTO == null) return;            
            string oldInxName = string.Empty;
            TreeNode depend_node = null;
            string oldDependName = string.Empty;
            TreeNode inx_node = null;
            foreach (var inx in DependenciesTO.Values)
            {
                if (oldDependName != inx.DependOnName)
                {
                    oldInxName = string.Empty;
                    depend_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToKeyStr, inx.DependOnName, inx);                        
                    dependencyTO_list_Node.Add(depend_node);
                    oldDependName = inx.DependOnName;
                }

                if (oldInxName != inx.Name)
                {
                    inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToKeyStr, inx.Name, inx);
                    depend_node.Nodes.Add(inx_node);
                    oldInxName = inx.Name;
                }                    
                var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromKeyStr, $@"{inx.DependOnName} -> {inx.FieldName}", inx);                    
                inx_node.Nodes.Add(tablen);                    
            }               
        }

    #region REFRESH_NODES_FROM_TABLES
        

        public void RefreshPrimaryKeysFromTableNodes(DBRegistrationClass DBReg, TreeNode nd, TreeNode group_node)
        {
            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);
            TreeNode akt_group_node;
            bool newnode = false;
            if (group_node != null)
            {                
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "Primary Keys";
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr);                
            }

            var pk_list = new List<TreeNode>();
            foreach (var tc in Tables)
            {
                if (tc.primary_constraint == null) return;                                    
                var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                pk_list.Add(tablen);                
            }
            
            pk_list.Sort(CompareString);
            akt_group_node.Text = "Primary Keys (" + pk_list.Count.ToString() + ")";
            akt_group_node.Nodes.AddRange(pk_list.ToArray());
            if(newnode) nd.Nodes.Add(akt_group_node);
        }
  
        public void RefreshForeignKeysFromTableNodes(DBRegistrationClass DBReg, TreeNode nd, TreeNode _tnSelected)
        {

            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);
            TreeNode akt_group_node;
            bool newnode = false;
            if (_tnSelected != null)
            {      
                var group_node = StaticTreeClass.Instance().FindPrevFKGroupNode(_tnSelected);  
                if(group_node != null)
                {
                    RemoveNodes(group_node);
                    akt_group_node = group_node;
                    akt_group_node.Text = "Foreign Keys";
                }
                else
                {
                    newnode = true;
                    akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr);     
                }
            }
            else
            {
                newnode = true;
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr);     
                
            }

            var fk_list = new List<TreeNode>();
            foreach (var tc in Tables)
            {
                if (tc.ForeignKeys == null) continue;                
                foreach (var fc in tc.ForeignKeys.Values)
                {
                    TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr,fc.Name,fc);     
                    tablen.ForeColor = fc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;
                    tablen.ToolTipText = $@"This index has key to {fc.SourceTableName}";
                    fk_list.Add(tablen);
                }                   
            }
            fk_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(fk_list.ToArray());
            akt_group_node.Text = "Foreign Keys (" + fk_list.Count.ToString() + ")";
            if(newnode)  nd.Nodes.Add(akt_group_node);
        }
        
        public void RefreshConstraintsFromTableNodes(DBRegistrationClass DBReg, TreeNode nd, TreeNode group_node)
        {
            /*
            constaraints
               ------------primary
               ------------unique
               ------------not nulls
               ------------checks
            */

            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);

            TreeNode akt_group_node;
            bool newnode = false;
            if (group_node != null)
            {
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "Constraints";
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr);                
                newnode = true;
            }


            TreeNode pk_constrainr_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr);
            TreeNode uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr);
            TreeNode nn_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr);
            TreeNode ck_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr);
            TreeNode pc_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr);
            
            List<TreeNode> cu_list = new List<TreeNode>();
            List<TreeNode> cnn_list = new List<TreeNode>();
            List<TreeNode> cck_list = new List<TreeNode>();
            List<TreeNode> cpk_list = new List<TreeNode>();
           
            foreach (var tc in Tables)
            {
                if (tc.primary_constraint != null)
                {                    
                    TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                    cpk_list.Add(tablen);
                }

                if (tc.uniques_constraints != null)
                {
                    foreach (var fc in tc.uniques_constraints.Values)
                    {
                        var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyStr, fc.Name, fc);                        
                        cu_list.Add(tablen);
                    }
                }

                if (tc.notnulls_constraints != null)
                {
                    foreach (var fc in tc.notnulls_constraints.Values)
                    {
                        var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyStr, fc.Name, fc);                       
                        cnn_list.Add(tablen);
                    }
                }

                if (tc.check_constraints != null)
                {
                    foreach (var fc in tc.check_constraints.Values)
                    {
                        var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyStr, fc.Name, fc);                        
                        cck_list.Add(tablen);
                    }
                }
            }

            cpk_list.Sort(CompareString);
            pk_constrainr_group_node.Nodes.AddRange(cpk_list.ToArray());
            pk_constrainr_group_node.Text = "Primary Keys (" + cpk_list.Count.ToString() + ")";

            cnn_list.Sort(CompareString);
            nn_group_node.Nodes.AddRange(cnn_list.ToArray());
            nn_group_node.Text = "Not Nulls (" + cnn_list.Count.ToString() + ")";

            cck_list.Sort(CompareString);
            ck_group_node.Nodes.AddRange(cck_list.ToArray());
            ck_group_node.Text = "Checks (" + cck_list.Count.ToString() + ")";

            cu_list.Sort(CompareString);
            uniques_group_node.Nodes.AddRange(cu_list.ToArray());
            uniques_group_node.Text = "Uniques (" + cu_list.Count.ToString() + ")";
 
            if(newnode)  nd.Nodes.Add(akt_group_node);

            akt_group_node.Text = "Constraints (" + (cpk_list.Count + cnn_list.Count + cu_list.Count).ToString() + ")";
            akt_group_node.Nodes.Add(pk_constrainr_group_node);
            akt_group_node.Nodes.Add(uniques_group_node);
            akt_group_node.Nodes.Add(nn_group_node);
            akt_group_node.Nodes.Add(ck_group_node);
            akt_group_node.Collapse();
        }

        public void RefreshTriggersFromTableNodes(DBRegistrationClass DBReg, TreeNode nd, TreeNode group_node)
        {
            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);

            TreeNode akt_group_node;
            bool newnode = false;
            if (group_node != null)
            {
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "Triggers";                
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr);               
                newnode = true;
            }

            var trigger_list = new List<TreeNode>();

            foreach (var tc in Tables)
            {               
                if (tc.Triggers == null) continue;                
                foreach (var fc in tc.Triggers.Values)
                {
                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr,fc.Name,fc);                        
                    trigger_list.Add(tablen);
                }                   
            }
          
            trigger_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(trigger_list.ToArray());
            akt_group_node.Text = "Triggers (" + trigger_list.Count.ToString() + ")";
            
            if(newnode) nd.Nodes.Add(akt_group_node);                   
        }

        public void RefreshDependenciesFromTableNodes(DBRegistrationClass DBReg, TreeNode nd)
        {           
                
            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);
            
            var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr);
            var dependencies_Tables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr);
            var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr);
            var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr);
            var dependencies_Triggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTriggersKeyGroupStr);
            var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr);
            var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr);
            var dependencies_Views_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesViewsKeyGroupStr);
            var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr);
            var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr);

            var dependencies_Procedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesProceduresKeyGroupStr);
            var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr);
            var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr);
                                            
            var dependencyTOTables_list = new List<TreeNode>();
            var dependencyFROMTables_list = new List<TreeNode>();
            var dependencyTOTriggers_list = new List<TreeNode>();
            var dependencyFROMTriggers_list = new List<TreeNode>();
            var dependencyTOViews_list = new List<TreeNode>();
            var dependencyFROMViews_list = new List<TreeNode>();
            var dependencyTOProcedures_list = new List<TreeNode>();
            var dependencyFROMProcedures_list = new List<TreeNode>();

            foreach (var tc in Tables)
            {                
                MakeTODependenciesNodesForAll(tc.DependenciesTO_Views, dependencyTOViews_list);
                MakeTODependenciesNodesForAll(tc.DependenciesTO_Procedures, dependencyTOProcedures_list);
                MakeTODependenciesNodesForAll(tc.DependenciesTO_Triggers, dependencyTOTriggers_list);
                MakeTODependenciesNodesForAll(tc.DependenciesTO_Tables, dependencyTOTables_list);

                MakeFROMDependenciesNodesForAll(tc.DependenciesFROM_Views, dependencyFROMViews_list);
                MakeFROMDependenciesNodesForAll(tc.DependenciesFROM_Procedures, dependencyFROMProcedures_list);
                MakeFROMDependenciesNodesForAll(tc.DependenciesFROM_Triggers, dependencyFROMTriggers_list);
                MakeFROMDependenciesNodesForAll(tc.DependenciesFROM_Tables, dependencyFROMTables_list);                
            }
                                   
            dependencyTOTables_list.Sort(CompareString);
            dependenciesTOTables_group_node.Nodes.AddRange(dependencyTOTables_list.ToArray());
            dependenciesTOTables_group_node.Text = "Objects depends on Tables (" + dependencyTOTables_list.Count.ToString() + ")";

            dependencyFROMTables_list.Sort(CompareString);
            dependenciesFROMTables_group_node.Nodes.AddRange(dependencyFROMTables_list.ToArray());
            dependenciesFROMTables_group_node.Text = "Dependencies From (" + dependencyFROMTables_list.Count.ToString() + ")";

            dependencyTOTriggers_list.Sort(CompareString);           
            dependenciesTOTriggers_group_node.Nodes.AddRange(dependencyTOTriggers_list.ToArray());
            dependenciesTOTriggers_group_node.Text = "Objects depends Triggers (" + dependencyTOTriggers_list.Count.ToString() + ")";

            dependencyFROMTriggers_list.Sort(CompareString);
            dependenciesFROMTriggers_group_node.Nodes.AddRange(dependencyFROMTriggers_list.ToArray());
            dependenciesFROMTriggers_group_node.Text = "Dependencies From (" + dependencyFROMTriggers_list.Count.ToString() + ")";

            dependencyTOViews_list.Sort(CompareString);
            dependenciesTOViews_group_node.Nodes.AddRange(dependencyTOViews_list.ToArray());
            dependenciesTOViews_group_node.Text = "Objects depends on Views (" + dependencyTOViews_list.Count.ToString() + ")";

            dependencyFROMViews_list.Sort(CompareString);
            dependenciesFROMViews_group_node.Nodes.AddRange(dependencyFROMViews_list.ToArray());
            dependenciesFROMViews_group_node.Text = "Dependencies From (" + dependencyFROMViews_list.Count.ToString() + ")";

            dependencyTOProcedures_list.Sort(CompareString);
            dependenciesTOProcedures_group_node.Nodes.AddRange(dependencyTOProcedures_list.ToArray());
            dependenciesTOProcedures_group_node.Text = "Objects depends Procedures (" + dependencyTOProcedures_list.Count.ToString() + ")";

            dependencyFROMProcedures_list.Sort(CompareString);
            dependenciesFROMProcedures_group_node.Nodes.AddRange(dependencyFROMProcedures_list.ToArray());
            dependenciesFROMProcedures_group_node.Text = "Dependencies From (" + dependencyFROMProcedures_list.Count.ToString() + ")";
                                   
            nd.Nodes.Add(dependencies_group_node);
            
            dependencies_group_node.Text = "Dependencies (" + (dependencyTOTables_list.Count + dependencyFROMTables_list.Count+ dependencyTOTriggers_list.Count + dependencyFROMTriggers_list.Count+ dependencyTOViews_list.Count + dependencyFROMViews_list.Count+ dependencyTOProcedures_list.Count + dependencyFROMProcedures_list.Count).ToString() + ")";
            dependencies_group_node.Nodes.Add(dependencies_Tables_group_node);
            dependencies_group_node.Nodes.Add(dependencies_Views_group_node);
            dependencies_group_node.Nodes.Add(dependencies_Triggers_group_node);
            dependencies_group_node.Nodes.Add(dependencies_Procedures_group_node);


            dependencies_Tables_group_node.Text = "Tables (" + (dependencyTOTables_list.Count + dependencyFROMTables_list.Count).ToString() + ")";
            dependencies_Tables_group_node.Nodes.Add(dependenciesTOTables_group_node);
            dependencies_Tables_group_node.Nodes.Add(dependenciesFROMTables_group_node);

            dependencies_Views_group_node.Text = "Views (" + (dependencyTOViews_list.Count + dependencyFROMViews_list.Count).ToString() + ")";
            dependencies_Views_group_node.Nodes.Add(dependenciesTOViews_group_node);
            dependencies_Views_group_node.Nodes.Add(dependenciesFROMViews_group_node);

            dependencies_Triggers_group_node.Text = "Triggers (" + (dependencyTOTriggers_list.Count + dependencyFROMTriggers_list.Count).ToString() + ")";
            dependencies_Triggers_group_node.Nodes.Add(dependenciesTOTriggers_group_node);
            dependencies_Triggers_group_node.Nodes.Add(dependenciesFROMTriggers_group_node);

            dependencies_Procedures_group_node.Text = "Procedures (" + (dependencyTOProcedures_list.Count + dependencyFROMProcedures_list.Count).ToString() + ")";
            dependencies_Procedures_group_node.Nodes.Add(dependenciesTOProcedures_group_node);
            dependencies_Procedures_group_node.Nodes.Add(dependenciesFROMProcedures_group_node);

            dependencies_group_node.Collapse();

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

            string cmd = IndexSQLStatementsClass.Instance().GetAllIndicies(DBReg.Version,eTableType.withoutsystem); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllIndeces->{DBReg}", ex));                 
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndeces->dread==null"));
                }                
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndeces->Connection not open"));
            }
            return indeces;
        }

        public Dictionary<string,IndexClass> GetIndecesObjectsWithoutRefConstraints(DBRegistrationClass DBReg)
        {
            var indeces = new Dictionary<string,IndexClass>();

            string cmd = IndexSQLStatementsClass.Instance().GetAllIndiciesWithoutRefConstraints(DBReg.Version,eTableType.withoutsystem); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllIndeces->{DBReg}", ex));                 
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndeces->dread==null"));
                }                
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndeces->Connection not open"));
            }
            return indeces;
        }

        
        //Holt alle Indecies der Datenbank und fügt diese in einen Tree-Konten an        
        public Dictionary<string,IndexClass> AddIndexObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {                           
            string fields_cmd = IndexSQLStatementsClass.Instance().GetAllIndicies(DBReg.Version,eTableType.withoutsystem);                        
            TableClass tableObject = null;
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                    while (dread.Read())
                    {
                        n++;
                        newTableKey = dread.GetValue(0).ToString().Trim();
                        newIndexKey = dread.GetValue(1).ToString().Trim();   
                        newFieldKey = dread.GetValue(2).ToString().Trim();  
                          
                        if(newIndexKey.ToUpper().Contains("TESTT"))
                        {
                            Console.WriteLine();
                        }
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
                            NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.withoutsystem.ToString()}) -> Indices.Add", ex));                                                                                         
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.withoutsystem.ToString()})", ex));                                                                                         
            }
            finally
            {
                con.Close();
            }
            return tableObject.Indices;
        }
        
        public void AddIndexObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc)
        {
            string fields_cmd = string.Empty;
           
            fields_cmd = IndexSQLStatementsClass.Instance().GetAllIndicies(DBReg.Version, eTableType.system);
                    
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                            NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.system.ToString()}) -> Indices.Add", ex));                                                                                         
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddIndexObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{eTableType.system.ToString()})", ex));                                                                                         
            }
            finally
            {
                con.Close();
            }
        }
        
        //Holt alle Indeces für die dem Knoten nd übergeordneten Table
        public void RefreshTableIndicesFromOneTable(DBRegistrationClass DBReg, TreeNode nd)
        {
            var tnn = FindPrevTableNode(nd);
            if(tnn == null) return;

            var tcc = tnn.Tag as TableClass;
            string fields_cmd = IndexSQLStatementsClass.Instance().GetTableIndicies(tcc.Name);
                                   
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshTableIndicesFromOneTable({DBReg},node:{nd.Name})", ex));                                                                                         
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {
                    var tn = FindNode(nd, StaticVariablesClass.IndicesKeyGroupStr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr);
                        nd.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "Indices";
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.IndicesKeyStr) as IndexClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, tc.Name, tc);
                            tablen.BackColor = tc.IsActive ? Color.Green : Color.Red;
                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        tn.Text = $@"Indices ({n})";
                        
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndices->dread==null"));
                }

                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndices->ConnectionName not open"));
            }
        }

        //Liest alle Indicies únd erzeugt den TreeGroupNode Indeces und Restauriert die indeces der TableNodes
        public void RefreshAllIndicies(DBRegistrationClass DBReg, TreeNode nd, TreeNode group_node)
        {
            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);
           
            Dictionary<string,IndexClass> indecies = GetIndecesObjects(DBReg);

            TreeNode akt_group_node;
            bool newnode = false;

            if (group_node != null)
            {
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "Indices";
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr);
                newnode = true;
            }
            var inx_list = new List<TreeNode>();
                        
            foreach (var fc in indecies.Values)
            {           
               
                Type tp = fc.GetType();
                
                var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, fc.Name, fc);
                tablen.ToolTipText = string.Empty;
                tablen.ForeColor = fc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;
                if(fc.ConstraintName.Length > 0) 
                {
                    tablen.ForeColor = fc.IsActive ? StaticTreeClass.Instance().ActiveHasConstraint : StaticTreeClass.Instance().InactiveHasConstraint;
                    
                    tablen.ToolTipText = $@"This index has {fc.ConstraintName} to {fc.RelationName}";
                }
                inx_list.Add(tablen);
                TableClass tc = Tables.Find(X=>X.Name == fc.RelationName);
                if(tc != null)
                {
                    tc.Indices.Remove(fc.Name);
                    tc.Indices.Add(fc.Name,fc);
                }                
            }
            
            inx_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(inx_list.ToArray());
            akt_group_node.Text = $@"Indices all ({inx_list.Count})";
            if (newnode) nd.Nodes.Add(akt_group_node);
        }

        /*
        public static void RefreshAllIndiciesFromAllTableNodes(DBRegistrationClass DBReg, TreeNode nd, TreeNode group_node)
        {
            var TableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeClass.Instance().GetTableObjectsFromNode(TableNode);
            TreeNode akt_group_node;
            bool newnode = false;
            if (group_node != null)
            {
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "Indices";
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr);
                newnode = true;
            }
            var inx_list = new List<TreeNode>();
            foreach (var tc in Tables)
            {
                if (tc.Indices == null) continue;
                foreach (var fc in tc.Indices.Values)
                {
                    if(fc.Name.StartsWith("FK_"))
                    {
                        Console.WriteLine("");
                    }
                    Type tp = fc.GetType();
                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, fc.Name, fc);
                    tablen.ForeColor = fc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;
                    inx_list.Add(tablen);
                }
            }
            inx_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(inx_list.ToArray());
            akt_group_node.Text = "Indices all (" + inx_list.Count.ToString() + ")";

            if (newnode) nd.Nodes.Add(akt_group_node);
        }
        */
    #endregion        

 


        public void RefreshDomains(DBRegistrationClass DBReg,  TreeNode nd)
        {            
            string cmd = DomainSQLStatementsClass.Instance().RefreshNonSystemDomains(DBReg.Version);          
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            { 
                con.Open();
            }
            catch(Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->{DBReg}", ex));                                            
                return;
            }

            if (con.State== System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {                    
                    var tn = FindNode(nd, StaticVariablesClass.DomainsKeyGroupStr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.DomainsKeyGroupStr);                        
                        nd.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "Domains";
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.DomainsKeyStr) as DomainClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            tc.TypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                            tc.FieldType = dread.GetValue(3).ToString().Trim();
                            tc.CharSet = dread.GetValue(4).ToString().Trim();
                            tc.Collate = dread.GetValue(5).ToString().Trim();
                            tc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tc.FieldType, tc.Length);
                            tc.DefaultValue = dread.GetValue(6).ToString().Trim();
                            
                            if(tc.DefaultValue.Length > 0 )
                            {
                                if(tc.DefaultValue.StartsWith("DEFAULT "))
                                {
                                    tc.DefaultValue = tc.DefaultValue.Substring(8).Trim();
                                }
                                if(tc.DefaultValue.Length > 1)
                                {
                                    Console.WriteLine();
                                }
                            }
                            tc.Description = dread.GetValue(7).ToString().Trim();
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.DomainsKeyStr,tc.Name,tc);
                            
                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        tn.Text = "Domains (" + n.ToString() + ")";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->dreade==null"));
                }
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->Connection not open"));
            }
        }

        public void RefreshForeignKeys(DBRegistrationClass DBReg, TreeNode nd)
        {            
            var tn = FindNode(nd, StaticVariablesClass.ForeignKeyGroupStr);
            var tablenode = FindPrevTableNode(nd);

            

            var table = (TableClass)tablenode.Tag;
            
            //string cmd = SQLStatementsClass.Instance().GetTableForeignKeys(DBReg.Version, table.Name);
            string cmd = SQLStatementsClass.Instance().GetAllTableForeignKeys(DBReg.Version, eTableType.withoutsystem, table.Name);
            
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshForeignKeys->{DBReg}", ex));                 
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {                                       
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr);                        
                        nd.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "Foreign Keys";
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.ForeignKeyStr) as ForeignKeyClass;
                            tc.Name = dread.GetValue(2).ToString().Trim(); //ForeignKeyName
                             
                            int inactive = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 1);                            
                            tc.IsActive = inactive == 0;
                            
                            
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr,tc.Name,tc);
                            tablen.ForeColor = tc.IsActive ? StaticTreeClass.Instance().Active : StaticTreeClass.Instance().Inactive;


                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        tn.Text = $@"Foreign Keys ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshForeignKeys->dread==null"));
                }
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshForeignKeys->Connection not open"));
            }
        }

        public int RefreshConstraintItems(eConstraintType ctyp, DBRegistrationClass DBReg, TreeNode nd, string tableName)
        {
            string cmd = string.Empty;
                       
            if (ctyp == eConstraintType.NOTNULL)
            {
              cmd = ConstraintsSQLStatementsClass.Instance().GetTableConstraintsByType(DBReg.Version, "NOT NULL", tableName);
            }
            else if(ctyp == eConstraintType.PRIMARYKEY)
            {
                cmd = ConstraintsSQLStatementsClass.Instance().GetTableConstraintsByType(DBReg.Version, "PRIMARY KEY", tableName);
            }
            else if(ctyp == eConstraintType.UNIQUE)
            {
                cmd = ConstraintsSQLStatementsClass.Instance().GetTableConstraintsByType(DBReg.Version, "UNIQUE", tableName);
            }
            
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshConstraintItems->{DBReg}", ex));                 
                return 0;
            }
            int n = 0;
            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);          
                var dread = fcmd.ExecuteReader();

          //     nd.ContextMenuStrip = ContextMenusClass.Instance().cmsContraintsGroup;

                if (dread != null)
                {
                    string ctypstr = EnumHelper.GetDescription(ctyp);

                    var tn = FindNode(nd, ctypstr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr, ctypstr);                        
                        nd.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = ctypstr;
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        string fieldname = string.Empty;
                        string tname = string.Empty;
                        string tnameold = string.Empty;
                       
                        ConstraintsClass tc = null;
                        while (dread.Read())
                        {
                            fieldname = dread.GetValue(6).ToString().Trim();
                            tname = dread.GetValue(0).ToString().Trim();
                            if (tname != tnameold)
                            {
                                //neuer constr

                                if (tc != null)
                                {
                                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyStr, tc.Name, tc);
                                    tn.Nodes.Add(tablen);
                                }

                                tc = DataClassFactory.GetDataClass(StaticVariablesClass.ConstraintsKeyStr) as ConstraintsClass;
                                tc.Name = tname; // dread.GetValue(0).ToString().Trim();
                                tc.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tc.IndexName = dread.GetValue(5).ToString().Trim();
                                tc.FieldNames.Add(fieldname,fieldname);
                                tc.TableName = dread.GetValue(2).ToString().Trim();
                                    
                                tnameold = tname;                                
                                n++;
                            }
                            else
                            {
                                //Bereits angelegter const                                                                                                        
                                tc.FieldNames.Add(fieldname,fieldname);                                                                
                            }
                        }

                        if (tc != null)
                        {
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyStr, tc.Name,tc);                            
                            tn.Nodes.Add(tablen);
                        }
                        tn.Text = $@"{ctyp} ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshConstraintItems->dread==null"));
                }
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshConstraintItems->Connection not open"));
            }
            return n;
        }

        public void RefreshConstraints(DBRegistrationClass DBReg, TreeNode nconstr)
        {
            var tablenode = FindPrevTableNode(nconstr);
            var tc = (TableClass)tablenode.Tag;
            var tn = FindNode(nconstr, StaticVariablesClass.ConstraintsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr);
            }
            else
            {
                tn.Nodes.Clear();
            }
          
            int n = RefreshConstraintItems(eConstraintType.UNIQUE, DBReg, tn,tc.Name);           
            n+= RefreshConstraintItems(eConstraintType.NOTNULL, DBReg, tn, tc.Name);           
            n+= RefreshConstraintItems(eConstraintType.PRIMARYKEY, DBReg, tn, tc.Name);
            tn.Text = $@"Constraints ({n})";
            tn.Collapse();
        }

        public void RefreshProcedures(DBRegistrationClass DBReg,  TreeNode nd)
        {            
            TreeNode tn = FindNode(nd, StaticVariablesClass.ProceduresKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.ProceduresKeyGroupStr);                
                nd.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "Procedures";
                tn.Nodes.Clear();
            }
            RefreshProceduresItems(DBReg,tn);
            nd.Expand();           
        }

        public void RefreshProceduresItems(DBRegistrationClass DBReg,  TreeNode nd)
        {
            NotifiesClass.Instance().AddToINFO($@"Refresh Procedures for {DBReg.Alias}",eInfoLevel.few);
            var allprocedures = GetProcedureObjects(DBReg);
            foreach(var procedure in allprocedures.Values)
            {
                 TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ProceduresKeyStr,procedure.Name,procedure);  
                 nd.Nodes.Add(tablen);
            }
            nd.Text = $@"Procedures ({allprocedures.Count})";
        }
        
        public void RefreshProceduresItemsOld(DBRegistrationClass DBReg,  TreeNode nd)
        {
            String cmd = SQLStatementsClass.Instance().RefreshProcedureItems(DBReg.Version);     

            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->{DBReg}->Connection not open"));
                return;
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
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.ProceduresKeyStr) as ProcedureClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            string src = dread.GetValue(1).ToString().Trim();
                            string[] srcarr = src.Split('\n');
                            foreach (string st in srcarr)
                            {
                                tc.Source.Add(st.Trim());
                            }
                                                           
                            var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                            con2.Open();
                            
                            if (con2.State == System.Data.ConnectionState.Open)
                            {
                                string cmd1 = SQLStatementsClass.Instance().GetProcedureAttributes(DBReg.Version, tc.Name);
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
                                                Name         = dread2.GetValue(0).ToString().Trim(),                                                
                                                Position     = StaticFunctionsClass.ToIntDef(dread2.GetValue(2).ToString().Trim(), 0),
                                                TypeNumber   = StaticFunctionsClass.ToIntDef(dread2.GetValue(3).ToString().Trim(), 0),                                               
                                                Length       = StaticFunctionsClass.ToIntDef(dread2.GetValue(4).ToString().Trim(), 0),
                                                Precision    = StaticFunctionsClass.ToIntDef(dread2.GetValue(5).ToString().Trim(), 0),
                                                Scale        = StaticFunctionsClass.ToIntDef(dread2.GetValue(6).ToString().Trim(), 0),
                                                FieldType    = dread2.GetValue(7).ToString().Trim()                                                
                                            };

                                            pc.RawType   = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(pc.FieldType, pc.Length);
                                            int InOutTyp = StaticFunctionsClass.ToIntDef(dread2.GetValue(1).ToString().Trim(), 0);                                                                                                                                                                                        
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
                                TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ProceduresKeyStr,tc.Name,tc);                                    
                                nd.Nodes.Add(tablen);
                                n++;
                            }
                            else
                            {
                                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread2==null"));
                            }
                        }
                        nd.Text = $@"Procedures ({n})";
                    }
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread==null"));
                }
                
                dread.Close();
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->Connections not open"));
            }         
        }

        public void RefreshInternalFunctions(DBRegistrationClass DBReg, TreeNode nd)
        {
            TreeNode tn = FindNode(nd, StaticVariablesClass.FunctionsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.FunctionsKeyGroupStr);
                nd.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "Functions";
                tn.Nodes.Clear();
            }

            RefreshInternalFunctionsItems(DBReg, tn);
            nd.Expand();
        }

        public void RefreshInternalFunctionsItems(DBRegistrationClass DBReg, TreeNode nd)
        {
            NotifiesClass.Instance().AddToINFO($@"Refresh Functions for {DBReg.Alias}",eInfoLevel.few);
            var allObjects = GetInternalFunctionObjects(DBReg);
            foreach(var procedure in allObjects.Values)
            {
                 TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.FunctionsKeyStr,procedure.Name,procedure);  
                 nd.Nodes.Add(tablen);
            }
            nd.Text = $@"Functions ({allObjects.Count})";            
        }

        public void RefreshUserDefinedFunctions(DBRegistrationClass DBReg, TreeNode nd)
        {
            TreeNode tn = FindNode(nd, StaticVariablesClass.UserDefinedFunctionsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.UserDefinedFunctionsKeyGroupStr);
                nd.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "User defined functions";
                tn.Nodes.Clear();
            }
            RefreshUserDefinedFunctionsItems(DBReg, tn);
            nd.Expand();
        }

        public void RefreshUserDefinedFunctionsItems(DBRegistrationClass DBReg, TreeNode nd)
        {
            NotifiesClass.Instance().AddToINFO($@"Refresh user defined functions for {DBReg.Alias}",eInfoLevel.few);
            var allObjects = GetUserDefinedFunctionObjects(DBReg);
            foreach(var procedure in allObjects.Values)
            {
                 TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.UserDefinedFunctionsKeyStr,procedure.Name,procedure);  
                 nd.Nodes.Add(tablen);
            }
            nd.Text = $@"User defined functions ({allObjects.Count})";            
        }

        public void RefreshTriggers(DBRegistrationClass DBReg,  TreeNode nd)
        {
            //Systemflag = 0 für TableTriggers
            //Systemflag = 4 für Systemtable Triggers

            string cmd = SQLStatementsClass.Instance().RefreshNonSystemTriggers(DBReg.Version);
            NotifiesClass.Instance().AddToINFO($@"Refresh Triggers for {DBReg.Alias}",eInfoLevel.few);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshTriggers->{DBReg}", ex));                 
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);          
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {                    
                    var tn = FindNode(nd, StaticVariablesClass.TriggersKeyGroupStr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr);                       
                        nd.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "Triggers";
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;                        
                        while (dread.Read())
                        {                            
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.TriggersKeyStr) as TriggerClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            int inactive = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 1);
                            int tp = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);

                            tc.Active = (inactive == 0);
                            tc.Type = (eTriggerType) tp;
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, tc.Name,tc);
                            
                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        tn.Text = $@"Trigger ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshTriggers->dread==null"));
                }
                
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshTriggers->Connection not open"));
            }
        }
        
        public void RefreshRoles(DBRegistrationClass DBReg,  TreeNode nd)
        {       
            NotifiesClass.Instance().AddToINFO($@"Refresh Roles for {DBReg.Alias}",eInfoLevel.few);
            string cmd = SQLStatementsClass.Instance().RefreshRoles(DBReg.Version);

            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshRoles->{DBReg}", ex));                 
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);          
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {                   
                    var tn = FindNode(nd, StaticVariablesClass.RolesKeyGroupStr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.RolesKeyGroupStr);                       
                        nd.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "Roles";
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.RolesKeyStr) as RoleClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.RolesKeyStr);
                            
                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        tn.Text = $@"Roles ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshRoles->dread==null"));
                }
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshRoles->ConnectionName not open {DBReg}"));
            }
        }

        public void RefreshGenerators(DBRegistrationClass DBReg,  TreeNode nd)
        {           
            var tn = FindNode(nd, StaticVariablesClass.GeneratorsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.GeneratorsKeyGroupStr);
                
                nd.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "Generators";
                tn.Nodes.Clear();
            }

            RefreshGeneratorsItems(DBReg,tn);            
            nd.Expand();
        }

        public void RefreshGeneratorsItems(DBRegistrationClass DBReg, TreeNode nd)
        {            
            NotifiesClass.Instance().AddToINFO($@"Refresh Generators for {DBReg.Alias}",eInfoLevel.few);
            string cmd = SQLStatementsClass.Instance().RefreshNonSystemGeneratorsItems(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGeneratorsItems->{DBReg}", ex));                 
                return;
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
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.GeneratorsKeyStr) as GeneratorClass;
                            tc.Name         = dread.GetValue(0).ToString().Trim();
                            tc.InitValue    = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);                            
                            tc.Description  = dread.GetValue(3).ToString().Trim();

                            string cmd2 = $@"SELECT GEN_ID({tc.Name}, 0) FROM RDB$DATABASE;";

                            var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                            con2.Open();
                            if (con2.State == System.Data.ConnectionState.Open)
                            {
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

                                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.GeneratorsKeyStr,tc.Name,tc);                                    
                                    nd.Nodes.Add(tablen);
                                    n++;
                                    dread2.Close();
                                }
                                con2.Close();
                            }                            
                        }                        
                        nd.Text = $@"Generators ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGegeratorsItems->{DBReg}", "dread==null")); 
                    
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGenertorsItems->Connection not open"));
            }            
        }
                
        public TreeNode RefreshTable(DBRegistrationClass DBReg, TreeNode TableGroupNode, string TableName)
        {
            var tablenode = FindNode(TableGroupNode, TableName);
            return RefreshTable(DBReg, tablenode);
        }

        public TreeNode RefreshTable(DBRegistrationClass DBReg, TreeNode tableNode)
        {          
            
            var fieldgroup_node = FindNode(tableNode, StaticVariablesClass.FieldsKeyGroupStr);
            var tc = tableNode.Tag as TableClass;            
            if (NotifiesClass.Instance().AllowInfos)
            {
                NotifiesClass.Instance().AddToINFO($@"Refresh Table {DBReg.Alias}->{tc.Name}");
            }
            var tcc = GetTableObject(DBReg,tc);
            tableNode.Tag = tcc;
            if (tableNode.Parent != null)
            {                
                fieldgroup_node.Nodes.Clear();
                foreach (var fld in tc.Fields.Values)
                {
                    var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr,fld.Name, fld);                    
                    fieldgroup_node.Text = $@"Fields ({tc.Fields.Count})";
                    fieldgroup_node.Nodes.Add(field_node);
                }
            }

            RefreshForeignKeys(DBReg, tableNode);
            return fieldgroup_node;
        }
        
        public TreeNode RefreshNonSystemTables(DBRegistrationClass DBRegx, TreeNode ndx)
        {
            TreeNode tables = null;                      
            var nd = StaticTreeClass.Instance().FindPrevDBNode(ndx);
            
            var DBReg = (DBRegistrationClass)nd.Tag;

            TreeNode tn = FindNode(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.CommonTablesKeyGroupStr);                
                nd.Nodes.Add(tn);
            }
            tn.Nodes.Clear();
            var vgc = new TableGroupClass
            {
                Name = $@"TableGroup_{DBReg.Alias}"
            };
            tn.Tag = vgc;

            tables = tn;

            if (NotifiesClass.Instance().AllowInfos)
            {
                NotifiesClass.Instance().AddToINFO($@"Reading common tables for {DBReg.Alias}",eInfoLevel.more);
            }
            var tableList = GetAllTableObjectsComplete(DBReg);
            
      
            if (tableList.Count <= 0) return null;
            string oldTableName = string.Empty;
            int n = 0;
            
            foreach (var tc in tableList.Values)
            {                
                 if (NotifiesClass.Instance().AllowInfos)
                 {
                    NotifiesClass.Instance().AddToINFO($@"Reading done {tc.Name}",eInfoLevel.less);
                 }

                 var table_node = DataClassFactory.GetNewNode(StaticVariablesClass.TablesKeyStr,tc.Name,tc);
                
                 #region fields

                 int fields_cnt = 0;
                 int pk_cnt = 0;
                 int fk_cnt = 0;
                 int uc_cnt = 0;
                 int nn_cnt = 0;
                 int ck_cnt = 0;
                 int constraints_pk_cnt = 0;
                 int indices_cnt = 0;
                 int triggers_cnt = 0;
                 int dependenciesTOTables_cnt = 0;
                 int dependenciesFROMTables_cnt = 0;
                 int dependenciesTOTriggers_cnt = 0;
                 int dependenciesFROMTriggers_cnt = 0;
                 int dependenciesTOViews_cnt = 0;
                 int dependenciesFROMViews_cnt = 0;
                 int dependenciesTOProcedures_cnt = 0;
                 int dependenciesFROMProcedures_cnt = 0;

                 if (tc.Fields != null) fields_cnt = tc.Fields.Count;
                 if (tc.primary_constraint != null) pk_cnt = 1; // tc.primary_constraint.Count;
                 if (tc.ForeignKeys != null) fk_cnt = tc.ForeignKeys.Count;
                 if (tc.uniques_constraints != null) uc_cnt = tc.uniques_constraints.Count;
                 if (tc.notnulls_constraints != null) nn_cnt = tc.notnulls_constraints.Count;
                 if (tc.primary_constraint != null) constraints_pk_cnt = 1; // tc.primary_constraint.Count;
                 if (tc.check_constraints != null) ck_cnt = tc.check_constraints.Count;
                 if (tc.Indices != null) indices_cnt = tc.Indices.Count;
                 if (tc.Triggers != null) triggers_cnt = tc.Triggers.Count;

                 if (tc.DependenciesTO_Tables != null) dependenciesTOTables_cnt = tc.DependenciesTO_Tables.Count;
                 if (tc.DependenciesFROM_Tables != null) dependenciesFROMTables_cnt = tc.DependenciesFROM_Tables.Count;
                 if (tc.DependenciesTO_Triggers != null) dependenciesTOTriggers_cnt = tc.DependenciesTO_Triggers.Count;
                 if (tc.DependenciesFROM_Triggers != null) dependenciesFROMTriggers_cnt = tc.DependenciesFROM_Triggers.Count;
                 if (tc.DependenciesTO_Views != null) dependenciesTOViews_cnt = tc.DependenciesTO_Views.Count;
                 if (tc.DependenciesFROM_Views != null) dependenciesFROMViews_cnt = tc.DependenciesFROM_Views.Count;
                 if (tc.DependenciesTO_Procedures != null) dependenciesTOProcedures_cnt = tc.DependenciesTO_Procedures.Count;
                 if (tc.DependenciesFROM_Procedures != null) dependenciesFROMProcedures_cnt = tc.DependenciesFROM_Procedures.Count;


                var table_field_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyGroupStr, "Fields (" + fields_cnt.ToString() + ")");               
                var table_pk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr,"Primary Keys (" + pk_cnt.ToString() + ")");
                var table_fk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr,"Foreign Keys (" + fk_cnt.ToString() + ")");
                var constraint_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr,"Constraints (" + (uc_cnt + nn_cnt + constraints_pk_cnt).ToString() + ")");
                var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr,"Dependencies (" + (dependenciesTOTables_cnt + dependenciesFROMTables_cnt + dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt + dependenciesTOViews_cnt + dependenciesFROMViews_cnt + dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt).ToString() + ")");
                var dependencies_group_node_Tables = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr,"Dep Tables (" + (dependenciesTOTables_cnt + dependenciesFROMTables_cnt).ToString() + ")");
                var dependencies_group_node_Triggers = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr,"Triggers (" + (dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt).ToString() + ")");
                var dependencies_group_node_Views = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr,"Dep Views (" + (dependenciesTOViews_cnt + dependenciesFROMViews_cnt).ToString() + ")");
                var dependencies_group_node_Procedures = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr,"Procedures (" + (dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt).ToString() + ")");
                var constraint_uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr,"Uniques (" + uc_cnt.ToString() + ")");
                var constraint_notnull_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr,"Not Nulls (" + nn_cnt.ToString() + ")");
                var constraint_check_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr,"Checks (" + ck_cnt.ToString() + ")");
                var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr,"Dependencies To (" + dependenciesTOTables_cnt.ToString() + ")");
                var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr,"Dependencies From (" + dependenciesFROMTables_cnt.ToString() + ")");
                var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr,"Dependencies To (" + dependenciesTOTriggers_cnt.ToString() + ")");
                var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr,"Dependencies From (" + dependenciesFROMTriggers_cnt.ToString()+ ")");
                var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr,"Dependencies To (" + dependenciesTOViews_cnt.ToString() + ")");
                var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr,"Dependencies From (" + dependenciesFROMViews_cnt.ToString() + ")");
                var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr,"Dependencies To (" + dependenciesTOProcedures_cnt.ToString() + ")");
                var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr,"Dependencies From (" + dependenciesFROMProcedures_cnt.ToString() + ")");                           
                var table_indices_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr,"Indices (" + indices_cnt.ToString() + ")");


                #endregion
                
                var constraint_pk_group_node  = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr,$@"Primary Keys ({constraints_pk_cnt})");
                var table_triggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr,$@"Triggers ({triggers_cnt})");

                foreach (var fld in tc.Fields.Values)
                {
                    TreeNode field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr,fld.Name,fld);
                    
                    //OPT
                     table_field_group_node.Text = $@"Fields ({tc.Fields.Count})";
                     table_field_group_node.Name = StaticVariablesClass.FieldsKeyGroupStr;
                     table_field_group_node.Nodes.Add(field_node);
                 }
                 if (tc.ForeignKeys != null)
                 {
                     foreach (var inx in tc.ForeignKeys.Values)
                     {
                        var fk_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, inx.Name, inx);                        
                        table_fk_group_node.Nodes.Add(fk_node);                       
                     }
                 }
                 if (tc.primary_constraint != null)
                 {                    
                    var pk_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                    table_pk_group_node.Text = $@"Primary Key (1,{tc.primary_constraint.FieldNames.Count})";
                    table_pk_group_node.Nodes.Add(pk_node);
                 }
                 if (tc.Indices != null)
                 {
                     foreach (var inx in tc.Indices.Values)
                     {
                        var inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, inx.Name, inx);                        
                        table_indices_group_node.Nodes.Add(inx_node);
                     }
                 }
                 if (tc.uniques_constraints != null)
                 {
                     foreach (var inx in tc.uniques_constraints.Values)
                     {
                        var u_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyStr, inx.Name, inx);                        
                        constraint_uniques_group_node.Nodes.Add(u_node);
                     }
                 }

                 if (tc.notnulls_constraints != null)
                 {
                     foreach (var inx in tc.notnulls_constraints.Values)
                     {
                        var nn_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyStr, inx.Name, inx);                        
                        constraint_notnull_group_node.Nodes.Add(nn_node);
                     }
                 }

                 if (tc.check_constraints != null)
                 {
                     foreach (var inx in tc.check_constraints.Values)
                     {
                        var nn_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyStr, inx.Name, inx);                        
                        constraint_check_group_node.Nodes.Add(nn_node);
                     }
                 }

                 if (tc.primary_constraint != null)
                 {                   
                    var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                    constraint_pk_group_node.Nodes.Add(p_node);
                }

                 if (tc.Triggers != null)
                 {
                     foreach (var inx in tc.Triggers.Values)
                     {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, inx.Name, inx);                        
                        table_triggers_group_node.Nodes.Add(p_node);
                     }
                 }

                #region Dependencies
                //Abhängigkeit von Tables zu Tables
                if (tc.DependenciesTO_Tables != null)
                 {
                     string oldInxName = string.Empty;
                     TreeNode inx_node = null;
                     foreach (var inx in tc.DependenciesTO_Tables.Values)
                     {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, inx.Name, inx);                            
                            dependenciesTOTables_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);
                        
                        inx_node.Nodes.Add(p_node);
                     }
                 }

                 if (tc.DependenciesFROM_Tables != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Tables.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyStr, inx.Name, inx);
                            
                            dependenciesFROMTables_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);                      
                        inx_node.Nodes.Add(p_node);
                    }
                 }

                 if (tc.DependenciesTO_Triggers != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Triggers.Values)
                     {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, inx.Name, inx);
                            
                            dependenciesTOTriggers_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);                                                     
                        inx_node.Nodes.Add(p_node);
                     }
                 }

                 if (tc.DependenciesFROM_Triggers != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Triggers.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyStr, inx.FieldName, inx);                            
                            dependenciesFROMTriggers_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyStr, inx.DependOnName, inx);                                                    
                        inx_node.Nodes.Add(p_node);
                    }
                 }

                 if (tc.DependenciesTO_Views != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Views.Values)
                     {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyStr, inx.DependOnName, inx);
                            
                            dependenciesTOViews_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyStr, inx.Name + "->" + inx.FieldName, inx);                        
                        inx_node.Nodes.Add(p_node);
                     }
                 }

                 if (tc.DependenciesFROM_Views != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Views.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyStr, inx.FieldName, inx);
                            
                            dependenciesFROMViews_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyStr, inx.DependOnName, inx);                        
                        inx_node.Nodes.Add(p_node);
                    }
                }

                 if (tc.DependenciesTO_Procedures != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Procedures.Values)
                     {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyStr, inx.DependOnName, inx);
                            
                            dependenciesTOProcedures_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);                        
                        inx_node.Nodes.Add(p_node);
                     }
                 }

                 if (tc.DependenciesFROM_Procedures != null)
                 {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Procedures.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, inx.FieldName, inx);
                            
                            dependenciesFROMProcedures_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, inx.DependOnName, inx);                        
                        inx_node.Nodes.Add(p_node);
                    }
                }

                 #endregion

                 constraint_group_node.Nodes.Add(constraint_uniques_group_node);
                 constraint_group_node.Nodes.Add(constraint_notnull_group_node);
                 constraint_group_node.Nodes.Add(constraint_pk_group_node);
                 constraint_group_node.Nodes.Add(constraint_check_group_node);

                 dependencies_group_node_Tables.Nodes.Add(dependenciesTOTables_group_node);
                 dependencies_group_node_Tables.Nodes.Add(dependenciesFROMTables_group_node);
                 dependencies_group_node_Triggers.Nodes.Add(dependenciesTOTriggers_group_node);
                 dependencies_group_node_Triggers.Nodes.Add(dependenciesFROMTriggers_group_node);
                 dependencies_group_node_Views.Nodes.Add(dependenciesTOViews_group_node);
                 dependencies_group_node_Views.Nodes.Add(dependenciesFROMViews_group_node);
                 dependencies_group_node_Procedures.Nodes.Add(dependenciesTOProcedures_group_node);
                 dependencies_group_node_Procedures.Nodes.Add(dependenciesFROMProcedures_group_node);

                 dependencies_group_node.Nodes.Add(dependencies_group_node_Tables);
                 dependencies_group_node.Nodes.Add(dependencies_group_node_Views);
                 dependencies_group_node.Nodes.Add(dependencies_group_node_Triggers);
                 dependencies_group_node.Nodes.Add(dependencies_group_node_Procedures);

                 table_node.Nodes.Add(table_field_group_node);
                 table_node.Nodes.Add(table_pk_group_node);
                 table_node.Nodes.Add(table_fk_group_node);
                 table_node.Nodes.Add(table_indices_group_node);
                 table_node.Nodes.Add(table_triggers_group_node);
                 table_node.Nodes.Add(constraint_group_node);
                 table_node.Nodes.Add(dependencies_group_node);

                 tn.Nodes.Add(table_node);
                 n++;                
            }
            tn.Text = $@"Tables ({n})";
            return tn;
        }

        public Dictionary<string,SystemTableClass> RefreshSystemTables(DBRegistrationClass DBRegx, TreeNode ndx)
        {
            TreeNode tables = null;
            var nd = StaticTreeClass.Instance().FindPrevDBNode(ndx);
            var tn = FindNode(nd, StaticVariablesClass.SystemTablesKeyGroupStr);

            var DBReg = (DBRegistrationClass)nd.Tag;

            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.SystemTablesKeyGroupStr);
                nd.Nodes.Add(tn);
            }
            tn.Nodes.Clear();
            var vgc = new SystemTableGroupClass
            {
                Name = $@"SystemTableGroup_{DBReg.Alias}"
            };
            tn.Tag = vgc;

            tables = tn;

            if (NotifiesClass.Instance().AllowInfos)
            {                
                NotifiesClass.Instance().AddToINFO($@"Reading system tables for {DBReg.Alias}",eInfoLevel.more);
            }
            
            

            var tableList = GetSystemTableObjects(DBReg);


            if (tableList.Count <= 0) return null;
            string oldTableName = string.Empty;
            int n = 0;

            AddIndexObjects_To_ListOfSystemTableObjects(DBReg, tableList);
            
            AddForeignKeyObjects_To_ListOfTableObjects(DBReg, tableList);
            AddTriggerObjects_To_ListOfSystemTableObjects(DBReg, tableList);
            GetSystemTableConstraintsObjects(eConstraintType.UNIQUE, tableList, DBReg);
            GetSystemTableConstraintsObjects(eConstraintType.PRIMARYKEY, tableList, DBReg);
            GetSystemTableConstraintsObjects(eConstraintType.NOTNULL, tableList, DBReg);
            AddCheckConstraintsObjects_To_ListOfSystemTableObjects(tableList, DBReg, eTableType.system);
            AddDependenciesTOObjects_To_ListOfSystemTableObjects(DBReg, tableList, eDependencies.TABLE);
            AddDepednenciesFROMObjects_To_ListOfSystemTableObjects(DBReg, tableList, eDependencies.TABLE);


            foreach (var tc in tableList.Values)
            {
                
                if (NotifiesClass.Instance().AllowInfos)
                {
                    NotifiesClass.Instance().AddToINFO($@"Reading done {tc.Name}", eInfoLevel.few);
                }

                var table_node = DataClassFactory.GetNewNode(StaticVariablesClass.SystemTablesKeyStr, tc.Name, tc);

                

                int fields_cnt = 0;
                int pk_cnt = 0;
                int fk_cnt = 0;
                int uc_cnt = 0;
                int nn_cnt = 0;
                int ck_cnt = 0;
                int constraints_pk_cnt = 0;
                int indices_cnt = 0;
                int triggers_cnt = 0;
                int dependenciesTOTables_cnt = 0;
                int dependenciesFROMTables_cnt = 0;
                int dependenciesTOTriggers_cnt = 0;
                int dependenciesFROMTriggers_cnt = 0;
                int dependenciesTOViews_cnt = 0;
                int dependenciesFROMViews_cnt = 0;
                int dependenciesTOProcedures_cnt = 0;
                int dependenciesFROMProcedures_cnt = 0;

                if (tc.Fields != null) fields_cnt = tc.Fields.Count;
                if (tc.primary_constraint != null) pk_cnt = 1; // tc.primary_constraint.Count;
                if (tc.ForeignKeys != null) fk_cnt = tc.ForeignKeys.Count;
                if (tc.uniques_constraints != null) uc_cnt = tc.uniques_constraints.Count;
                if (tc.notnulls_constraints != null) nn_cnt = tc.notnulls_constraints.Count;
                if (tc.primary_constraint != null) constraints_pk_cnt = 1; // tc.primary_constraint.Count;
                if (tc.check_constraints != null) ck_cnt = tc.check_constraints.Count;
                if (tc.Indices != null) indices_cnt = tc.Indices.Count;
                if (tc.Triggers != null) triggers_cnt = tc.Triggers.Count;

                if (tc.DependenciesTO_Tables != null) dependenciesTOTables_cnt = tc.DependenciesTO_Tables.Count;
                if (tc.DependenciesFROM_Tables != null) dependenciesFROMTables_cnt = tc.DependenciesFROM_Tables.Count;
                if (tc.DependenciesTO_Triggers != null) dependenciesTOTriggers_cnt = tc.DependenciesTO_Triggers.Count;
                if (tc.DependenciesFROM_Triggers != null) dependenciesFROMTriggers_cnt = tc.DependenciesFROM_Triggers.Count;
                if (tc.DependenciesTO_Views != null) dependenciesTOViews_cnt = tc.DependenciesTO_Views.Count;
                if (tc.DependenciesFROM_Views != null) dependenciesFROMViews_cnt = tc.DependenciesFROM_Views.Count;
                if (tc.DependenciesTO_Procedures != null) dependenciesTOProcedures_cnt = tc.DependenciesTO_Procedures.Count;
                if (tc.DependenciesFROM_Procedures != null) dependenciesFROMProcedures_cnt = tc.DependenciesFROM_Procedures.Count;


                var table_field_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyGroupStr,                                    $@"Fields ({fields_cnt})");
                var table_pk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr,                                      $@"Primary Keys ({pk_cnt})");
                var table_fk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr,                                      @"Foreign Keys ({fk_cnt})");
                var constraint_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr,                                    $@"Constraints ({(uc_cnt + nn_cnt + constraints_pk_cnt)})");
                var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr,                             $@"Dependencies ({(dependenciesTOTables_cnt + dependenciesFROMTables_cnt + dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt + dependenciesTOViews_cnt + dependenciesFROMViews_cnt + dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt)})");
                var dependencies_group_node_Tables = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr,                $@"Tables ({(dependenciesTOTables_cnt + dependenciesFROMTables_cnt)})");
                var dependencies_group_node_Triggers = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr,          $@"Triggers ({(dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt)})");
                var dependencies_group_node_Views = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr,              $@"Views ({(dependenciesTOViews_cnt + dependenciesFROMViews_cnt)})");
                var dependencies_group_node_Procedures = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr,    $@"Procedures ({(dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt)})");
                var constraint_uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr,                            $@"Uniques ({uc_cnt})");
                var constraint_notnull_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr,                            $@"Not Nulls ({nn_cnt})");
                var constraint_check_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr,                               $@"Checks ({ck_cnt})");
                var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr,             $@"Dependencies To ({dependenciesTOTables_cnt})");
                var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr,         $@"Dependencies From ({dependenciesFROMTables_cnt})");
                var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr,         $@"Dependencies To ({dependenciesTOTriggers_cnt})");
                var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr,     $@"Dependencies From ({dependenciesFROMTriggers_cnt})");
                var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr,               $@"Dependencies To ({dependenciesTOViews_cnt})");
                var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr,           $@"Dependencies From ({dependenciesFROMViews_cnt})");
                var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr,     $@"Dependencies To ({dependenciesTOProcedures_cnt})");
                var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, $@"Dependencies From ({dependenciesFROMProcedures_cnt})");
                var table_indices_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr,                                 $@"Indices ({indices_cnt})");                
                var constraint_pk_group_node  = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr,                                $@"Primary Keys ({constraints_pk_cnt})");
                var table_triggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr,                               $@"Triggers ({triggers_cnt})");

                foreach (var fld in tc.Fields.Values)
                {
                    var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr, fld.Name, fld);

                    //OPT
                    table_field_group_node.Text = $@"Fields ({tc.Fields.Count})";
                    table_field_group_node.Name = StaticVariablesClass.FieldsKeyGroupStr;
                    table_field_group_node.Nodes.Add(field_node);
                }
                if (tc.ForeignKeys != null)
                {
                    foreach (var inx in tc.ForeignKeys.Values)
                    {
                        var fk_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, inx.Name, inx);
                        table_fk_group_node.Nodes.Add(fk_node);
                    }
                }
                if (tc.primary_constraint != null)
                {                    
                    var pk_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                    table_pk_group_node.Text = $@"Primary Keys (1)";
                    table_pk_group_node.Nodes.Add(pk_node);
                }
                if (tc.Indices != null)
                {
                    foreach (var inx in tc.Indices.Values)
                    {
                        var inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, inx.Name, inx);
                        table_indices_group_node.Nodes.Add(inx_node);
                    }
                }
                if (tc.uniques_constraints != null)
                {
                    foreach (var inx in tc.uniques_constraints.Values)
                    {
                        var u_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyStr, inx.Name, inx);
                        constraint_uniques_group_node.Nodes.Add(u_node);
                    }
                }

                if (tc.notnulls_constraints != null)
                {
                    foreach (var inx in tc.notnulls_constraints.Values)
                    {
                        var nn_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyStr, inx.Name, inx);
                        constraint_notnull_group_node.Nodes.Add(nn_node);
                    }
                }

                if (tc.check_constraints != null)
                {
                    foreach (var inx in tc.check_constraints.Values)
                    {
                        var nn_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyStr, inx.Name, inx);
                        constraint_check_group_node.Nodes.Add(nn_node);
                    }
                }

                if (tc.primary_constraint != null)
                {                    
                    var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                    constraint_pk_group_node.Nodes.Add(p_node);
                }

                if (tc.Triggers != null)
                {
                    foreach (var inx in tc.Triggers.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, inx.Name, inx);
                        table_triggers_group_node.Nodes.Add(p_node);
                    }
                }

                #region Dependencies
                //Abhängigkeit von Tables zu Tables
                if (tc.DependenciesTO_Tables != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Tables.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, inx.Name, inx);
                            dependenciesTOTables_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);

                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Tables != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Tables.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyStr, inx.Name, inx);

                            dependenciesFROMTables_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyStr, inx.Name, inx);
                        p_node.Text = $@"{inx.Name}->{inx.FieldName}";
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesTO_Triggers != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Triggers.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, inx.Name, inx);

                            dependenciesTOTriggers_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Triggers != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Triggers.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyStr, inx.FieldName, inx);
                            dependenciesFROMTriggers_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyStr, inx.DependOnName, inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesTO_Views != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Views.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyStr, inx.DependOnName, inx);

                            dependenciesTOViews_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Views != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Views.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyStr, inx.FieldName, inx);

                            dependenciesFROMViews_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.Name + "->" + inx.FieldName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyStr, inx.DependOnName, inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesTO_Procedures != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Procedures.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyStr, inx.DependOnName, inx);

                            dependenciesTOProcedures_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, $@"{inx.Name}->{inx.FieldName}", inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Procedures != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Procedures.Values)
                    {
                        if (oldInxName != $@"{inx.Name}->{inx.FieldName}")
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, inx.FieldName, inx);

                            dependenciesFROMProcedures_group_node.Nodes.Add(inx_node);
                            oldInxName = $@"{inx.Name}->{inx.FieldName}";
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, inx.DependOnName, inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                #endregion

                constraint_group_node.Nodes.Add(constraint_uniques_group_node);
                constraint_group_node.Nodes.Add(constraint_notnull_group_node);
                constraint_group_node.Nodes.Add(constraint_pk_group_node);
                constraint_group_node.Nodes.Add(constraint_check_group_node);

                dependencies_group_node_Tables.Nodes.Add(dependenciesTOTables_group_node);
                dependencies_group_node_Tables.Nodes.Add(dependenciesFROMTables_group_node);
                dependencies_group_node_Triggers.Nodes.Add(dependenciesTOTriggers_group_node);
                dependencies_group_node_Triggers.Nodes.Add(dependenciesFROMTriggers_group_node);
                dependencies_group_node_Views.Nodes.Add(dependenciesTOViews_group_node);
                dependencies_group_node_Views.Nodes.Add(dependenciesFROMViews_group_node);
                dependencies_group_node_Procedures.Nodes.Add(dependenciesTOProcedures_group_node);
                dependencies_group_node_Procedures.Nodes.Add(dependenciesFROMProcedures_group_node);

                dependencies_group_node.Nodes.Add(dependencies_group_node_Tables);
                dependencies_group_node.Nodes.Add(dependencies_group_node_Views);
                dependencies_group_node.Nodes.Add(dependencies_group_node_Triggers);
                dependencies_group_node.Nodes.Add(dependencies_group_node_Procedures);

                table_node.Nodes.Add(table_field_group_node);
                table_node.Nodes.Add(table_pk_group_node);
                table_node.Nodes.Add(table_fk_group_node);
                table_node.Nodes.Add(table_indices_group_node);
                table_node.Nodes.Add(table_triggers_group_node);
                table_node.Nodes.Add(constraint_group_node);
                table_node.Nodes.Add(dependencies_group_node);

                tn.Nodes.Add(table_node);
                n++;
            }
            tn.Text = $@"System Tables ({n})";
            return tableList; //tn;
        }

        public TreeNode RefreshView(DBRegistrationClass DBReg, TreeNode ndx)
        {
           // TreeNode nd = StaticTreeClass.Instance().FindPrevDBNode(ndx);
            TreeNode fieldgroup_node = FindNode(ndx,StaticVariablesClass.FieldsKeyGroupStr);
            if (ndx.Tag != null)
            {
                if (ndx.Tag.GetType().Name == "ViewClass")
                {
                    
                    var tc = ndx.Tag as ViewClass;
                    if (NotifiesClass.Instance().AllowInfos)
                    {
                        NotifiesClass.Instance().AddToINFO($@"Refresh  view {DBReg.Alias}->{tc.Name}");
                    }
                    //Neuew View wird erzeugt und in Node geschrieben 
                    var vw = GetViewObject(DBReg, tc.Name);
                    ndx.Tag = vw;
                    if (ndx.Parent != null)
                    {
                        fieldgroup_node.Nodes.Clear();
                        foreach (var fld in vw.Fields.Values)
                        {
                            var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.ViewFieldsKeyStr, fld.Name, fld);
                            
                            fieldgroup_node.Text = $@"Fields ({tc.Fields.Count})";
                            fieldgroup_node.Nodes.Add(field_node);
                        }
                    }
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshView->wrong object->{ndx.Tag.GetType().Name}"));
                }
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshView->wrong object->null"));
            }
            return fieldgroup_node;
        }

        /// <summary>
        /// Sucht den in DBReg enthaltenen ViewGroup Knoten und ersetzt diesen durch die aktuelle Struktur der Datebank
        /// Ist der Knoten nicht vorhanden dann wird dieser angelegt und aufgebaut
        /// </summary>
        /// <param name="DBRegx"></param>
        /// <param name="ndx"></param>
        /// <returns></returns>
        public Dictionary<string,ViewClass> RefreshAllViews(DBRegistrationClass DBRegx, TreeNode ndx)
        {
            TreeNode tables = null;
            
            TreeNode nd = StaticTreeClass.Instance().FindPrevDBNode(ndx);            
            DBRegistrationClass DBReg = (DBRegistrationClass)nd.Tag;

            TreeNode tn = FindNode(nd, StaticVariablesClass.ViewsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.ViewsKeyGroupStr);
                nd.Nodes.Add(tn);
            }
            else
            {
                tn.Nodes.Clear();
            }


            ViewGroupClass vgc = new ViewGroupClass
            {
                Name = "ViewGroup_" + DBReg.Alias
            };
            tn.Tag = vgc;

            tables = tn;

            if (NotifiesClass.Instance().AllowInfos)
            {
                NotifiesClass.Instance().AddToINFO($@"Reading views for {DBReg.Alias}",eInfoLevel.more);
            }
            var allviews = GetViewObjects(DBReg);
            if (allviews == null) return null;
            if (allviews.Count <= 0) return null;
            string oldTableName = string.Empty;
            int n = 0;
                      
            GetAllDependenciesOn(DBReg, allviews, eDependencies.VIEW);
            GetAllDepednenciesFROM(DBReg, allviews, eDependencies.VIEW);
            
            foreach (var tc in allviews.Values)
            {
                if (NotifiesClass.Instance().AllowInfos)
                {
                    NotifiesClass.Instance().AddToINFO($@"Reading done {tc.Name}",eInfoLevel.few);
                }
                var view_node = DataClassFactory.GetNewNode(StaticVariablesClass.ViewsKeyStr, tc.Name,tc);
                
                #region fields

                int fields_cnt = 0;
               // int pk_cnt = 0;
               // int fk_cnt = 0;
                int uc_cnt = 0;
                int nn_cnt = 0;
                int ck_cnt = 0;
               // int pkc_cnt = 0;
               // int i_cnt = 0;
               // int triggers_cnt = 0;
                int dependenciesTOTables_cnt = 0;
                int dependenciesFROMTables_cnt = 0;
                int dependenciesTOTriggers_cnt = 0;
                int dependenciesFROMTriggers_cnt = 0;
                int dependenciesTOViews_cnt = 0;
                int dependenciesFROMViews_cnt = 0;
                int dependenciesTOProcedures_cnt = 0;
                int dependenciesFROMProcedures_cnt = 0;

                if (tc.Fields != null) fields_cnt = tc.Fields.Count;
                
                if (tc.DependenciesTO_Tables != null) dependenciesTOTables_cnt = tc.DependenciesTO_Tables.Count;
                if (tc.DependenciesFROM_Tables != null) dependenciesFROMTables_cnt = tc.DependenciesFROM_Tables.Count;
                if (tc.DependenciesTO_Triggers != null) dependenciesTOTriggers_cnt = tc.DependenciesTO_Triggers.Count;
                if (tc.DependenciesFROM_Triggers != null) dependenciesFROMTriggers_cnt = tc.DependenciesFROM_Triggers.Count;
                if (tc.DependenciesTO_Views != null) dependenciesTOViews_cnt = tc.DependenciesTO_Views.Count;
                if (tc.DependenciesFROM_Views != null) dependenciesFROMViews_cnt = tc.DependenciesFROM_Views.Count;
                if (tc.DependenciesTO_Procedures != null) dependenciesTOProcedures_cnt = tc.DependenciesTO_Procedures.Count;
                if (tc.DependenciesFROM_Procedures != null) dependenciesFROMProcedures_cnt = tc.DependenciesFROM_Procedures.Count;

                var fieldgroup_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyGroupStr, "Fields (" + fields_cnt.ToString() + ")");
               // TreeNode pkgroup_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr, "Primary Keys (" + pk_cnt.ToString() + ")");                
               // TreeNode fkgroup_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr, "Foreign Keys (" + fk_cnt.ToString() + ")");                
               // TreeNode constraint_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr, "Constraints (" + (uc_cnt + nn_cnt + pkc_cnt).ToString() + ")");                
                var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr, "Dependencies (" + (dependenciesTOTables_cnt + dependenciesFROMTables_cnt + dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt + dependenciesTOViews_cnt + dependenciesFROMViews_cnt + dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt).ToString() + ")");                
                var dependencies_group_node_Tables = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr, "Tables (" + (dependenciesTOTables_cnt + dependenciesFROMTables_cnt).ToString() + ")");                
                var dependencies_group_node_Triggers = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTriggersKeyGroupStr, "Triggers (" + (dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt).ToString() + ")");                
                var dependencies_group_node_Views = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesViewsKeyGroupStr, "Views (" + (dependenciesTOViews_cnt + dependenciesFROMViews_cnt).ToString() + ")");                
                var dependencies_group_node_Procedures = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesProceduresKeyGroupStr, "Procedures (" + (dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt).ToString() + ")");                
                var uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr, "Uniques (" + uc_cnt.ToString() + ")");                
                var nn_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr, "Not Null (" + nn_cnt.ToString() + ")");                
                var ck_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr, "Checks (" + ck_cnt.ToString() + ")");                
                var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr, "Dependencies to tables(" + dependenciesTOTables_cnt.ToString() + ")");                
                var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr, "Dependencies from tables(" + dependenciesFROMTables_cnt.ToString() + ")");                
                var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr, "Dependencies to triggers(" + dependenciesTOTriggers_cnt.ToString() + ")");                
                var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr, "Dependencies from triggers(" + dependenciesFROMTriggers_cnt.ToString() + ")");                
                var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr, "Dependencies to views(" + dependenciesTOViews_cnt.ToString() + ")");                
                var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr, "Dependencies from views(" + dependenciesFROMViews_cnt.ToString() + ")");                
                var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr, "Dependencies to procedures(" + dependenciesTOProcedures_cnt.ToString() + ")");                
                var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, "Dependencies from procedures(" + dependenciesFROMProcedures_cnt.ToString() + ")");
                
                #endregion
              
               // TreeNode inxgroup_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr, "Indices (" + i_cnt.ToString() + ")");                             
               // TreeNode pc_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr, "Primary Keys (" + pkc_cnt.ToString() + ")");                
               // TreeNode triggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr, "Triggers (" + triggers_cnt.ToString() + ")");
                


                foreach (var fld in tc.Fields.Values)
                {
                    var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.ViewFieldsKeyStr, fld.Name,fld);                    
                    fieldgroup_node.Text = "Fields (" + tc.Fields.Count.ToString() + ")";
                    fieldgroup_node.Nodes.Add(field_node);
                }
                
                if (tc.DependenciesTO_Tables != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Tables.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, inx.DependOnName, inx);                            
                            dependenciesTOTables_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, inx.Name + " -> " + inx.FieldName, inx);                       
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Tables != null)
                {
                    foreach (var inx in tc.DependenciesFROM_Tables.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyStr, inx.Name + " -> " + inx.FieldName, inx);                        
                        dependenciesFROMTables_group_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesTO_Triggers != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Triggers.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, inx.DependOnName, inx);                            
                            dependenciesTOTriggers_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, inx.Name + " -> " + inx.FieldName, inx);                        
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Triggers != null)
                {
                    foreach (var inx in tc.DependenciesFROM_Triggers.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyStr, inx.Name + "->" + inx.FieldName, inx);                        
                        dependenciesFROMTriggers_group_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesTO_Views != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Views.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyStr, inx.DependOnName, inx);
                            
                            dependenciesTOViews_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyStr, inx.Name + "->" + inx.FieldName, inx);                        
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Views != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesFROM_Views.Values)
                    {
                        if (oldInxName != inx.Name + "->" + inx.FieldName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyStr, inx.FieldName, inx);
                            
                            dependenciesFROMViews_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.Name + "->" + inx.FieldName;
                        }
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyStr, inx.DependOnName, inx);
                        
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesTO_Procedures != null)
                {
                    string oldInxName = string.Empty;
                    TreeNode inx_node = null;
                    foreach (var inx in tc.DependenciesTO_Procedures.Values)
                    {
                        if (oldInxName != inx.DependOnName)
                        {
                            inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyStr, inx.DependOnName, inx);
                            
                            dependenciesTOProcedures_group_node.Nodes.Add(inx_node);
                            oldInxName = inx.DependOnName;
                        }

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyStr, inx.Name + "->" + inx.FieldName, inx);                        
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Procedures != null)
                {
                    foreach (var inx in tc.DependenciesFROM_Procedures.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyStr, inx.Name + "->" + inx.FieldName, inx);                        
                        dependenciesFROMProcedures_group_node.Nodes.Add(p_node);
                    }
                }
                
                dependencies_group_node_Tables.Nodes.Add(dependenciesTOTables_group_node);
                dependencies_group_node_Tables.Nodes.Add(dependenciesFROMTables_group_node);
                dependencies_group_node_Triggers.Nodes.Add(dependenciesTOTriggers_group_node);
                dependencies_group_node_Triggers.Nodes.Add(dependenciesFROMTriggers_group_node);
                dependencies_group_node_Views.Nodes.Add(dependenciesTOViews_group_node);
                dependencies_group_node_Views.Nodes.Add(dependenciesFROMViews_group_node);
                dependencies_group_node_Procedures.Nodes.Add(dependenciesTOProcedures_group_node);
                dependencies_group_node_Procedures.Nodes.Add(dependenciesFROMProcedures_group_node);

                dependencies_group_node.Nodes.Add(dependencies_group_node_Tables);
                dependencies_group_node.Nodes.Add(dependencies_group_node_Views);
                dependencies_group_node.Nodes.Add(dependencies_group_node_Triggers);
                dependencies_group_node.Nodes.Add(dependencies_group_node_Procedures);

                view_node.Nodes.Add(fieldgroup_node);
                
                view_node.Nodes.Add(dependencies_group_node);
                
                tn.Nodes.Add(view_node);
                n++;
            }
            tn.Text = "Views (" + n.ToString() + ")";
            return allviews;
        }


        public void MakeNode(TreeNode nd, List<DataObjectClass> obj, string name)
        {
            foreach (var fld in obj)
            {
                var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr,  fld.Name, fld);                
                nd.Text = name+ " (" + obj.Count.ToString() + ")";
                nd.Nodes.Add(field_node);
            }
        }

        public void UpdateTableNodes(TreeNode tableNode, TableClass TableObject, DBRegistrationClass dbReg)
        {
            UpdateTableFieldNodes(tableNode, TableObject,dbReg);
            UpdateTableForeignKeyNodes(tableNode, TableObject,dbReg);
            UpdateTableIndeciesNodes(tableNode, TableObject,dbReg);
            UpdateTableTriggerNodes(tableNode, TableObject,dbReg);
            UpdateNotNullConstraintNodes(tableNode, TableObject,dbReg);
        }

        public TreeNode UpdateTableFieldNodes(TreeNode tableNode, TableClass tcc, DBRegistrationClass dbReg)
        {
            var group_node = FindNode(tableNode, StaticVariablesClass.FieldsKeyGroupStr);
            if ((group_node != null)&&(tcc.Fields != null))
            {
                tableNode.ForeColor = Color.Green;
                group_node.ForeColor = Color.Green;
                group_node.Text = $@"Fields ({tcc.Fields.Count})";
                if (NotifiesClass.Instance().AllowInfos)
                {
                    NotifiesClass.Instance().AddToINFO($@"Reading field from table object {dbReg.Alias}->{tcc.Name}");
                }

                tableNode.Tag = tcc;

                if (tableNode.Parent != null)
                {
                    group_node.Nodes.Clear();                    
                    foreach (var nodesObject in tcc.Fields.Values)
                    {
                        var subnode = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr, nodesObject.Name, nodesObject);
                        group_node.Nodes.Add(subnode);
                    }
                }
            }
            return tableNode;
        }

        public TreeNode UpdateTableForeignKeyNodes(TreeNode tableNode, TableClass tcc, DBRegistrationClass dbReg)
        {
            var group_node = FindNode(tableNode, StaticVariablesClass.ForeignKeyGroupStr);
            if ((group_node != null)&&(tcc.ForeignKeys!=null))
            {
                tableNode.ForeColor = Color.Green;
                group_node.ForeColor = Color.Green;
                group_node.Text = $@"Foreign keys ({tcc.ForeignKeys.Count})";
                if (NotifiesClass.Instance().AllowInfos)
                {
                    NotifiesClass.Instance().AddToINFO($@"Reading foreign keys from table object {dbReg.Alias}->{tcc.Name}");
                }
                tableNode.Tag = tcc;
                if (tableNode.Parent != null)
                {
                    group_node.Nodes.Clear();                   
                    foreach (var nodesObject in tcc.ForeignKeys.Values)
                    {
                        var subnode = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, nodesObject.Name, nodesObject);
                        group_node.Nodes.Add(subnode);
                    }
                }                
            }
            return tableNode;
        }

        public TreeNode UpdateTableIndeciesNodes(TreeNode tableNode, TableClass tcc, DBRegistrationClass dbReg)
        {
            var group_node = FindNode(tableNode, StaticVariablesClass.IndicesKeyGroupStr);
            if ((group_node != null) && (tcc.Indices != null))
            {
                tableNode.ForeColor = Color.Green;
                group_node.ForeColor = Color.Green;
                group_node.Text = $@"Indecies ({tcc.Indices.Count})";
                if (NotifiesClass.Instance().AllowInfos)
                {
                    NotifiesClass.Instance().AddToINFO($@"Reading indecies from table object {dbReg.Alias}->{tcc.Name}");
                }
                tableNode.Tag = tcc;
                if (tableNode.Parent != null)
                {
                    group_node.Nodes.Clear();
                    foreach (var nodesObject in tcc.Indices.Values)
                    {
                        var subnode = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, nodesObject.Name, nodesObject);
                        group_node.Nodes.Add(subnode);
                    }
                }
            }
            return tableNode;
        }

        public TreeNode UpdateTableTriggerNodes(TreeNode tableNode, TableClass tcc, DBRegistrationClass dbReg)
        {
            var group_node = FindNode(tableNode, StaticVariablesClass.TriggersKeyGroupStr);
            if ((group_node != null) && (tcc.Triggers != null))
            {
                tableNode.ForeColor = Color.Green;
                group_node.ForeColor = Color.Green;
                group_node.Text = $@"Triggers ({tcc.Triggers.Count})";
                if (NotifiesClass.Instance().AllowInfos)
                {
                    NotifiesClass.Instance().AddToINFO($@"Reading triggers from table object {dbReg.Alias}->{tcc.Name}");
                }
                tableNode.Tag = tcc;
                if (tableNode.Parent != null)
                {
                    group_node.Nodes.Clear();
                    foreach (var nodesObject in tcc.Triggers.Values)
                    {
                        var subnode = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, nodesObject.Name, nodesObject);
                        group_node.Nodes.Add(subnode);
                    }
                }
            }
            return tableNode;
        }

        public TreeNode UpdateNotNullConstraintNodes(TreeNode tableNode, TableClass tcc, DBRegistrationClass dbReg)
        {
            TreeNode nd = null;
            for(int i = 0; i < tableNode.Nodes.Count; i++)               
            {
                if(tableNode.Nodes[i].Name == StaticVariablesClass.ConstraintsKeyGroupStr)
                {
                    nd = tableNode.Nodes[i];
                    break;
                }
            }

            if (nd == null)  return tableNode;
            
            var group_node = FindNode(nd, StaticVariablesClass.NotNullKeyGroupStr);
            if ((group_node == null) || (tcc.notnulls_constraints == null))  return tableNode;
                        
            nd.ForeColor = Color.Green;
            tableNode.ForeColor = Color.Green;
            group_node.ForeColor = Color.Green;
            group_node.Text = $@"NotNulls ({tcc.notnulls_constraints.Count})";
            if (NotifiesClass.Instance().AllowInfos)
            {
                NotifiesClass.Instance().AddToINFO($@"Reading not null constraints from table object {dbReg.Alias}->{tcc.Name}");
            }
            tableNode.Tag = tcc;
            if (tableNode.Parent != null)  return tableNode;
            
            group_node.Nodes.Clear();
            foreach (var nodesObject in tcc.notnulls_constraints.Values)
            {
                var subnode = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyStr, nodesObject.Name, nodesObject);
                group_node.Nodes.Add(subnode);
            }
                                 
            return tableNode;
        }

        public bool CancelReading = false;

        /// <summary>
        /// Sucht und ersetzt einen vorhandenen Knoten der TableGroup aus der aktuellen Struktur der Datenbank
        /// Ist dieser nicht vorhanden, dann wird er angelegt und aufgebaut.
        /// </summary>
        /// <param name="DBRegx"></param>
        /// <param name="ndx"></param>
        /// <returns></returns>
        

        #region Make SQL for Objects

        public string GetInfoHeader(int len)
        {
            string istr = "*******************************************************************************************************************************************************************************************************************";
            return $@"/{istr.Substring(0,len-2)}/";
        }
        /*
        public static List<string> GetAllTablesContentAlterInsertSQL(DBRegistrationClass DBReg)
        {
            var allcontent = new List<string>();
            var ec = new ExportClass();
            ec.Init(DBReg,NotifiesClass.Instance());
            var alltables = StaticTreeClass.Instance().GetAllTableObjects(DBReg);
            foreach (var tableObject in alltables.Values)
            {
                if (tableObject.State != CheckState.Checked) continue;
                
                allcontent.Add($@"/* {tableObject.Name} *-/");
                allcontent.Add(Environment.NewLine);
                allcontent.Add(Environment.NewLine);
                string cols = ec.GetTableColumns(tableObject);
                if (!string.IsNullOrEmpty(cols))
                {
                    ec.RefreshDatas(tableObject, cols);
                    ec.RefreshFields(tableObject);
                    var lst = ec.ExportForInsertUpdate(eCreateMode.recreate,tableObject, cols);                        
                    allcontent.AddRange(lst.Values);                        
                    allcontent.Add(Environment.NewLine);
                }                
            }
            return allcontent;
        }
      */
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

                    
                    string sql = FBXpert.CreateDLLClass.CreateTabelDLL(tableObject, cmode);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql + ";"));
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
            }
            SQLAll.Add(Environment.NewLine);
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
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

                    string sql = FBXpert.CreateDLLClass.CreateAlterTabelPrimaryKeyConstraintDLL(constraintObject, eCreateMode.drop);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                    }
                    

                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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

                    string sql = FBXpert.CreateDLLClass.CreateAlterTabelPrimaryKeyConstraintDLL(constraintObject, eCreateMode.create);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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
                SQLAll.Add(Environment.NewLine);
            }

            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
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


                        string sql = FBXpert.CreateDLLClass.CreateAlterTabelForeignKeyConstraintDLL(constraintObject, eCreateMode.drop);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                        }


                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }

                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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

                    string sql = FBXpert.CreateDLLClass.CreateAlterTabelForeignKeyConstraintDLL(constraintObject, eCreateMode.create);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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
            }
            SQLAll.Add(Environment.NewLine);   
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
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


                        string sql = FBXpert.CreateDLLClass.CreateAlterDomainDLL(constraintObject, eCreateMode.drop);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                        }


                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }

                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                        }

                        if (commit)
                        {
                            SQLSep.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                    
                        }
                    }   
                    SQLAll.AddRange(SQLSep);
                    if(fileWrite == eSQLFileWriteMode.seperated)
                    {
                        WriteFile(directoryName+"\\"+dataObject.Name+".sql",SQLSep,enc);
                    }
                }
                SQLAll.Add(Environment.NewLine);
            }
            if(fileWrite == eSQLFileWriteMode.all)
            {
                WriteFile(directoryName+"\\"+ fileName,SQLAll,enc);            
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

                    string sql = FBXpert.CreateDLLClass.CreateAlterGeneratorDLL(constraintObject, eCreateMode.drop);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                    }

                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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

                    string sql = FBXpert.CreateDLLClass.CreateAlterGeneratorDLL(constraintObject, eCreateMode.create);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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

                        string sql = FBXpert.CreateDLLClass.CreateAlterIndecesDLL(indexObject, eCreateMode.drop);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                        }


                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }

                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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

                        string sql = FBXpert.CreateDLLClass.CreateAlterIndecesDLL(indexObject, eCreateMode.create);
                        if (sql.EndsWith(Environment.NewLine))
                        {
                            sql = sql.Remove(sql.Length - 2);
                        }
                        if (!string.IsNullOrEmpty(sql))
                        {
                            if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                            else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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
                   
                    string sql = FBXpert.CreateDLLClass.CreateAlterTriggerDLL(constraintObject, eCreateMode.drop);
                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
                    }

                    if (sql.EndsWith(Environment.NewLine))
                    {
                        sql = sql.Remove(sql.Length - 2);
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                        else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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

                string sql = FBXpert.CreateDLLClass.CreateAlterTriggerDLL(indexObject, eCreateMode.create);
                if (sql.EndsWith(Environment.NewLine))
                {
                    sql = sql.Remove(sql.Length - 2);
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    if (sql.EndsWith(";")) SQLSep.Add(SQLStatementsClass.Instance().FormatSQL(sql));
                    else SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{sql};"));
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
                
                SQLSep.Add(SQLStatementsClass.Instance().FormatSQL($@"{vc.CREATEINSERT_SQL};"));
               

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
            catch(Exception ex)
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
                    ? $@"GRANT SELECT ON {gstr.Trim()} TO PROCEDURE {FunctionObject.Name};{Environment.NewLine}" 
                    : $@"GRANT EXECUTE ON PROCEDURE {gstr.Substring(0, inx)} TO PROCEDURE {FunctionObject.Name};{Environment.NewLine}";
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

        
        public List<TableClass> GetTableObjectsFromNode(TreeNode nd)
        {
            List<TableClass> table = new List<TableClass>();
            if (nd != null)
            {
                foreach (TreeNode tc in nd.Nodes)
                {
                    table.Add((TableClass)tc.Tag);
                }
            }
            return table;
        }

        public Dictionary<string,TableClass> GetDictionaryOfTableObjectsFromNode(TreeNode nd)
        {
            Dictionary<string,TableClass> table = new Dictionary<string,TableClass>();
            if (nd != null)
            {
                foreach (TreeNode tc in nd.Nodes)
                {
                    table.Add(((TableClass)tc.Tag).Name,(TableClass)tc.Tag);
                }
            }
            return table;
        }
        

        public TableClass GetTableObjectForIndexForm(DBRegistrationClass DBReg, string TableName)
        {
            if (string.IsNullOrEmpty(TableName)) return null;
            
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
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetTableObjectForIndexForm->{DBReg}", ex));                         
            }
               
            return null;
        }

        public TableClass GetTableObjectFromName(DBRegistrationClass DBReg, string TableName)
        {
            string fieldsCmd = SQLStatementsClass.Instance().GetTableFields(DBReg.Version, TableName);
            var tableObject = new TableClass
            {
                Fields = new Dictionary<string, TableFieldClass>()
            };
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                            TableName = TableName,
                            Name = dread.GetValue(1).ToString().Trim(),
                            Domain =
                            {
                                Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0),
                                FieldType = dread.GetValue(4).ToString().Trim()
                            }
                        };
                        // string TableName = dread.GetValue(0).ToString().Trim();

                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                        tfc.Domain.Name = dread.GetValue(6).ToString().Trim();

                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();
                        tfc.Domain.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;
                  //      tfc.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(12).ToString().Trim(), 0) > 0;
                        tfc.Domain.DefaultValue = dread.GetValue(13).ToString().Trim();
                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            if(tfc.Domain.DefaultValue.Length > 1)
                            {
                                Console.WriteLine();
                            }
                        }
                        tfc.Description = dread.GetValue(14).ToString().Trim(); //tfc.Domain.DefaultValue.Substring(14);
                        tfc.Domain.Description = dread.GetValue(14).ToString().Trim(); //tfc.Domain.DefaultValue.Substring(15);
                        if((tfc.Description.Length > 0)||(tfc.Domain.Description.Length > 0))
                        {
                            Console.WriteLine();
                        }
                        tableObject.Fields.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetTableObjectFromName->{DBReg}", ex));                     
            }
            finally
            {
                con.Close();
            }
            return tableObject;
        }

        public TableClass GetTableObject(DBRegistrationClass DBReg, TableClass tc)
        {
            var fields = new List<TableFieldClass>();
            
            var TableObject = (TableClass) tc.Clone();
            
            string fields_cmd = SQLStatementsClass.Instance().GetTableFields(DBReg.Version, TableObject.Name);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread.HasRows)
                {                   
                    TableObject.Fields = new Dictionary<string, TableFieldClass>();
                
                    while (dread.Read())
                    {
                        var tfc = new TableFieldClass();
                        string TableName = dread.GetValue(0).ToString().Trim();
                    
                        tfc.TableName = TableName;
                        tfc.Name = dread.GetValue(1).ToString().Trim();
                        tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                        tfc.Domain.FieldType = dread.GetValue(4).ToString().Trim();
                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                        tfc.Domain.Name = dread.GetValue(6).ToString().Trim();
                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();
                        tfc.Domain.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;                    
                        tfc.Domain.DefaultValue = dread.GetValue(13).ToString().Trim();
                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            if(tfc.Domain.DefaultValue.Length > 1)
                            {
                                Console.WriteLine();
                            }
                        }
                        tfc.Description = dread.GetValue(14).ToString().Trim();
                        tfc.Domain.Description = dread.GetValue(15).ToString().Trim();
                        if((tfc.Domain.Description.Length > 0)||(tfc.Description.Length > 0))
                        {
                            Console.WriteLine();
                        }
                        TableObject.Fields.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetTableObject({DBReg},{tc.Name})", ex));                     
            }
            finally
            {
                con.Close();
            }
                
            return TableObject;
        }

        public List<string> GetDatabaseStatistics(DBRegistrationClass DBReg)
        {
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                       int ps = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                       long pg = StaticFunctionsClass.ToLongDef(dread.GetValue(4).ToString().Trim(), 0);
                       string speewintervall = dread.GetValue(5).ToString().Trim();
                       int read_only = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(),0);
                       int forced_writes = StaticFunctionsClass.ToIntDef(dread.GetValue(6).ToString().Trim(),0);
                       int backup_stae = StaticFunctionsClass.ToIntDef(dread.GetValue(8).ToString().Trim(),0);
                       string rdstr = "read/write";
                       string fwrite = "OFF";
                       string bstate = "normal";
                       if (read_only > 0)
                       {
                           rdstr = "read-only";
                       }

                       if (forced_writes > 0)
                       {
                           fwrite  = "ON";
                       }

                       switch (backup_stae)
                       {
                           case 1: bstate = "stalled"; break;
                           case 2: bstate = "merge"; break;
                       }
                       data.Add($@"Database lifetime       :{dread.GetValue(0).ToString().Trim(),-40}");
                       data.Add($@"Database creation date  :{dread.GetValue(3).ToString().Trim(),-40}");
                       data.Add($@"Database SQL dialect    :{dread.GetValue(1).ToString().Trim(),-40}");
                       data.Add($@"Database page size      :{ps.ToString()} bytes, number of pages:{pg.ToString()} toal size:{((ps*pg)/1024).ToString()} kbyte");
                       data.Add($@"Database sweep intervall:{speewintervall.ToString(),-40}");
                       data.Add($@"Database read-write mode:{rdstr,-40}");
                       data.Add($@"Database forced-writes  :{fwrite,-40}");
                       data.Add($@"Database backup-state   :{bstate,-40}");
                    }
                }

                data.Add(" ");
                data.Add(" ");
                cmd = "select r.rdb$relation_name, (select max(i.rdb$statistics)||(count(rf.rdb$relation_name) * 0) from rdb$relation_fields rf where rf.rdb$relation_name = r.rdb$relation_name ) , (select count(rfx.rdb$relation_name) from rdb$relation_fields rfx where rfx.rdb$relation_name = r.rdb$relation_name ) from rdb$relations r join rdb$indices i on (i.rdb$relation_name = r.rdb$relation_name) group by r.rdb$relation_name order by 2";
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
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetDatabaseStatistics({DBReg})", ex));                     
            }
            finally
            {
                con.Close();
            }
            return data;
        }


        public Dictionary<string,TableClass> GetAllTableObjectsComplete(DBRegistrationClass DBReg)
        {
            var tableList = GetAllTableObjects(DBReg);
      
            if (tableList.Count <= 0) return null;
            string oldTableName = string.Empty;
            
            AddIndexObjects_To_ListOfTableObjects(DBReg, tableList);    
                        
            AddForeignKeyObjects_To_ListOfTableObjects(DBReg, tableList);
            AddTriggerObjects_To_ListOfTableObjects(DBReg, tableList);
            AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.UNIQUE, tableList, DBReg, eTableType.withoutsystem);
            AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.PRIMARYKEY, tableList, DBReg, eTableType.withoutsystem);
            AddConstraintsObjects_To_ListOfTableObjects(eConstraintType.NOTNULL, tableList, DBReg, eTableType.withoutsystem);
            AddCheckConstraintsObjects_To_ListOfTableObjects(tableList, DBReg, eTableType.withoutsystem);
            AddDependenciesTOObjects_To_ListOfTableObjects(DBReg, tableList, eDependencies.TABLE);
            AddDependenciesFROMObjects_To_ListOfTableObjects(DBReg, tableList, eDependencies.TABLE);
            return tableList;
        }


        public Dictionary<string,TableClass> GetAllTableObjects(DBRegistrationClass DBReg)
        {
            var fields = new List<TableFieldClass>();
            var TableObject = new TableClass();
            string fields_cmd = SQLStatementsClass.Instance().GetAllNonSystemTableFields(DBReg.Version);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            var tables = new Dictionary<string,TableClass>();
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    string oldTableName = string.Empty;
                    TableClass table = null;
                    while (dread.Read())
                    {
                        var tfc = new TableFieldClass();
                        var tableName = dread.GetValue(0).ToString().Trim();
                        
                        if (tableName != oldTableName)
                        {
                            table = new TableClass
                            {
                                Name = tableName,
                                Fields = new Dictionary<string,TableFieldClass>()
                            };
                            oldTableName = tableName;
                            tables.Add(table.Name,table);
                        }
                        tfc.TableName = tableName;

                        tfc.Name = dread.GetValue(1).ToString().Trim();

                        tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                        tfc.Domain.FieldType = dread.GetValue(4).ToString().Trim();
                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                        tfc.Domain.Name = dread.GetValue(6).ToString().Trim();

                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();
                        tfc.Domain.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;                        
                        tfc.Domain.DefaultValue = dread.GetValue(13).ToString().Trim();
                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            if(tfc.Domain.DefaultValue.Length > 1)
                            {
                                Console.WriteLine();
                            }
                        }

                        tfc.Description = dread.GetValue(14).ToString().Trim();
                        tfc.Domain.Description = dread.GetValue(15).ToString().Trim();
                        if((tfc.Domain.Description.Length > 0)||(tfc.Description.Length > 0))
                        {
                            Console.WriteLine();
                        }
                        table.Fields.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableObjects({DBReg})", ex));                     
            }
            finally
            {
                con.Close();
            }
            return tables;
        }

        public Dictionary<string,SystemTableClass> GetSystemTableObjects(DBRegistrationClass DBReg)
        {
            var fields = new Dictionary<string, TableFieldClass>();
            var tables = new Dictionary<string,SystemTableClass>();
            var TableObject = new TableClass();
            
            string fields_cmd = SQLStatementsClass.Instance().GetAllSystemTableFields(DBReg.Version);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    string oldTableName = string.Empty;
                    SystemTableClass table = null;
                    while (dread.Read())
                    {
                        var tfc = new TableFieldClass();
                        var tableName = dread.GetValue(0).ToString().Trim();
                        if (tableName != oldTableName)
                        {
                            table = new SystemTableClass
                            {
                                Name = tableName,
                                Fields = new Dictionary<string, TableFieldClass>()
                            };
                            oldTableName = tableName;
                            tables.Add(table.Name, table);
                        }
                        tfc.TableName = tableName;

                        tfc.Name = dread.GetValue(1).ToString().Trim();

                        tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                        tfc.Domain.FieldType = dread.GetValue(4).ToString().Trim();
                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                        tfc.Domain.Name = dread.GetValue(6).ToString().Trim();

                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();
                        tfc.Domain.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;                        
                        tfc.Domain.DefaultValue = dread.GetValue(13).ToString().Trim();
                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            if(tfc.Domain.DefaultValue.Length > 1)
                            {
                                Console.WriteLine();
                            }
                        }
                        tfc.Description = dread.GetValue(14).ToString().Trim();
                        tfc.Domain.Description = dread.GetValue(15).ToString().Trim();
                        if((tfc.Domain.Description.Length > 0)||(tfc.Description.Length > 0))
                        {
                            Console.WriteLine();
                        }
                        table.Fields.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetSystemTableObjects({DBReg})", ex));                     
            }
            finally
            {
                con.Close();
            }
            
            return tables;
        }

        
        public Dictionary<string,FunctionClass> GetInternalFunctionObjects(DBRegistrationClass DBReg)
        {
            String cmd = SQLStatementsClass.Instance().RefreshInternalFunctionsItems(DBReg.Version);     
            var allfunctions = new Dictionary<string,FunctionClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetInternalFunctionObjects->{DBReg}->Connection not open"));
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
                            while (dread.Read())
                            {
                                var tc = DataClassFactory.GetDataClass(StaticVariablesClass.FunctionsKeyStr) as FunctionClass;
                                tc.Name = dread.GetValue(0).ToString().Trim();
                                string ftype = dread.GetValue(1).ToString().Trim();
                                string src = dread.GetValue(2).ToString().Trim();
                                string[] srcarr = src.Split('\n');
                                foreach (string st in srcarr)
                                {
                                    tc.Source.Add(st.Trim());
                                }
                                                           
                                var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                                con2.Open();
                            
                                if (con2.State == System.Data.ConnectionState.Open)
                                {
                                    string cmd1 = SQLStatementsClass.Instance().GetFunctionsArguments(DBReg.Version, tc.Name);
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
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetInternalFunctionObjects->dread2==null"));
                                }
                            }            
                        }
                    }
                    else
                    {
                        NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetInternalFunctionObjects->dread==null"));
                    }
                    dread.Close();
                }
                catch(Exception ex)
                {
                      NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetInternalFunctionObjects->msg:{ex.Message}"));
                }                                
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetInternalFunctionObjects->Connections not open"));
            }
            return allfunctions;
        }

        public Dictionary<string,UserDefinedFunctionClass> GetUserDefinedFunctionObjects(DBRegistrationClass DBReg)
        {
            String cmd = SQLStatementsClass.Instance().RefreshUserDefinedFunctionsItems(DBReg.Version);     
            var allfunctions = new  Dictionary<string,UserDefinedFunctionClass>();
            if(string.IsNullOrEmpty(cmd)) return allfunctions;

            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshUserDefinedFunctionsItems->{DBReg}->Connection not open"));
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
                                                           
                                var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                                con2.Open();                            
                                if (con2.State == System.Data.ConnectionState.Open)
                                {
                                    string cmd1 = SQLStatementsClass.Instance().GetUserDefinedFunctionsAttributes(DBReg.Version, tc.Name);
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
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->dread2==null"));
                                }
                            }                        
                        }
                    }
                    else
                    {
                        NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->dread==null"));
                    }                
                    dread.Close();
                }
                catch(Exception ex)
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->msg:{ex.Message}"));
                }
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshFunctionsItems->Connections not open"));
            }
            return allfunctions;
        }

        public Dictionary<string,TriggerClass> GetTriggerObjects(DBRegistrationClass DBReg, string TableName)
        {
            var triggers = new Dictionary<string,TriggerClass>();
           
            if (!string.IsNullOrEmpty(TableName))
            {
                string fields_cmd = SQLStatementsClass.Instance().GetTableTriggers(DBReg.Version, TableName);
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetTriggerObjects({DBReg},{TableName})", ex));                         
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
            string cmd = ConstraintsSQLStatementsClass.Instance().GetTableCheckConstraints(DBReg.Version,  TableName);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetCheckConstraintsObjects({TableName},{DBReg})", ex));                     
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetCheckConstraintsObjects->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetCheckConstraintsObjects->Connection not open"));
            }
            return constraints;
        }

        public Dictionary<string,TableFieldClass> GetFieldObjects(DBRegistrationClass DBReg, string TableName)
        {
            var fields = new Dictionary<string, TableFieldClass>();

            var TableObject = new TableClass();
            if (string.IsNullOrEmpty(TableName)) return fields;
            
            string fields_cmd = SQLStatementsClass.Instance().GetTableFields(DBReg.Version, TableName);
            TableObject.Fields = new Dictionary<string, TableFieldClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();

                var fcmd = new FbCommand(fields_cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread.HasRows)
                {
                    while (dread.Read())
                    {
                        var tfc = new TableFieldClass();
                        string TabName = dread.GetValue(0).ToString().Trim();
                        tfc.Name = dread.GetValue(1).ToString().Trim();

                        tfc.Domain.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0);
                        tfc.Domain.FieldType = dread.GetValue(4).ToString().Trim();
                        tfc.Domain.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tfc.Domain.FieldType, tfc.Domain.Length);
                        tfc.Position = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0)+1;
                        tfc.Domain.Name = dread.GetValue(6).ToString().Trim();

                        tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(dread.GetValue(7).ToString().Trim(), 0) * -1;
                        tfc.DefaultValue = dread.GetValue(8).ToString().Trim();
                        tfc.Domain.Collate = dread.GetValue(9).ToString().Trim();
                        tfc.Domain.CharSet = dread.GetValue(10).ToString().Trim();
                        tfc.Domain.NotNull = StaticFunctionsClass.ToIntDef(dread.GetValue(11).ToString().Trim(), 0) > 0;
                   
                        tfc.Domain.DefaultValue = dread.GetValue(13).ToString().Trim();
                        if(tfc.Domain.DefaultValue.Length > 0 )
                        {
                            if(tfc.Domain.DefaultValue.StartsWith("DEFAULT "))
                            {
                                tfc.Domain.DefaultValue = tfc.Domain.DefaultValue.Substring(8).Trim();
                            }
                            if(tfc.Domain.DefaultValue.Length > 1)
                            {
                                Console.WriteLine();
                            }
                        }

                        tfc.Description = dread.GetValue(14).ToString().Trim();
                        tfc.Domain.Description = dread.GetValue(15).ToString().Trim();
                        if((tfc.Domain.Description.Length > 0)||(tfc.Description.Length > 0))
                        {
                            Console.WriteLine();
                        }
                        
                        fields.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetTableFieldObjects({DBReg},{TableName}", ex));                         
            }
            finally
            {
                con.Close();
            }
                            
            return fields;
        }


        public TreeNode GetRegNode(TreeNode tn)
        {
            if (tn == null) return null;
            while (tn.Level > 0)
            {
                tn = tn.Parent;
            }
            var typ = tn.Tag.GetType();
            return typ == typeof(DBRegistrationClass) ? tn : null;
        }
        
        public Dictionary<string,ViewClass> GetViewObjects(DBRegistrationClass DBReg)
        {
            var allviews = new Dictionary<string,ViewClass>();

            string cmd = SQLStatementsClass.Instance().RefreshViews(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObjects({DBReg})", ex));                                                                                         
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
                        string view_name = "";
                        string view_name_old = "";
                        string voldsql = "";

                        var strl = new StringBuilder();
                        var strli = new StringBuilder();

                        object ob_viewname = null;
                        object ob_sql = null;
                        object ob_fieldname = null;
                        object ob_fieldpos = null;
                        object ob_fieldtype = null;
                        object ob_fieldlength = null;

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

                            ob_viewname = dread.GetValue(0);
                            ob_sql = dread.GetValue(1);
                            ob_fieldname = dread.GetValue(2);
                            ob_fieldpos = dread.GetValue(3);
                            ob_fieldtype = dread.GetValue(4);
                            ob_fieldlength = dread.GetValue(5);

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

                                if (strl.Length > 0)
                                {
                                    //Alter View existiert und muß weggeschrieen werden

                                    vc.Name = view_name_old;
                                    strl.AppendLine("");
                                    strl.AppendLine(") ");
                                    strl.Append("AS ");
                                    strl.AppendLine(voldsql);

                                    vc.SQL = voldsql;
                                    vc.CREATEINSERT_SQL = strl.ToString();
                                    
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
                            System.Text.Encoding enc = System.Text.Encoding.Default;
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
                            //Alter View existiert und muß weggeschrieen werden

                            vcl.Name = view_name_old;
                            strl.AppendLine("");
                            strl.AppendLine(") ");
                            strl.Append("AS ");
                            strl.AppendLine(voldsql);

                            vcl.SQL = voldsql;
                            vcl.CREATEINSERT_SQL = strl.ToString();

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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObjects->dread==null"));
                }
                con.Close();               
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObjects->Connection not open"));
            }
            return allviews;
        }
        
        public Dictionary<string,DomainClass> GetDomainObjects(DBRegistrationClass DBReg)
        {
            var domains = new Dictionary<string,DomainClass>();
           
            string cmd = DomainSQLStatementsClass.Instance().RefreshNonSystemDomains(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {                
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDomains->{DBReg}", ex)); 
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
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.DomainsKeyStr) as DomainClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            tc.TypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                            tc.FieldType = dread.GetValue(3).ToString().Trim();
                            tc.CharSet = dread.GetValue(4).ToString().Trim();
                            tc.Collate = dread.GetValue(5).ToString().Trim();
                            tc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tc.FieldType, tc.Length);
                            tc.DefaultValue = dread.GetValue(6).ToString().Trim();
                            if(tc.DefaultValue.Length > 0 )
                            {
                                if(tc.DefaultValue.StartsWith("DEFAULT "))
                                {
                                    tc.DefaultValue = tc.DefaultValue.Substring(8).Trim();
                                }
                                if(tc.DefaultValue.Length > 1)
                                {
                                    Console.WriteLine();
                                }
                            }
                            tc.Description = dread.GetValue(7).ToString().Trim();
                            domains.Add(tc.Name,tc);
                            
                            n++;
                        }
                        
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->dreade==null"));
                }

                cmd = DomainSQLStatementsClass.Instance().RefreshSystemDomains(DBReg.Version);
                fcmd = new FbCommand(cmd, con);
                dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    if (dread.HasRows)
                    {
                        int n = 0;
                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.DomainsKeyStr) as DomainClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.Length = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            tc.TypeNumber = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 0);
                            tc.FieldType = dread.GetValue(3).ToString().Trim();
                            tc.CharSet = dread.GetValue(4).ToString().Trim();
                            tc.Collate = dread.GetValue(5).ToString().Trim();
                            tc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(tc.FieldType, tc.Length);
                            domains.Add(tc.Name,tc);

                            n++;
                        }

                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->dread==null"));
                }
                con.Close();                
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshDomains->Connection not open"));
            }
            return domains;
        }
        
  
        
        public Dictionary<string,TriggerClass> GetTriggerObjects(DBRegistrationClass DBReg)
        {
            var trigger = new Dictionary<string,TriggerClass>();

            string cmd = SQLStatementsClass.Instance().GetAllTableTriggersNonSystemTables(DBReg.Version); //  .RefreshNonSystemIndicies(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggers->{DBReg}", ex));                 
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggers({DBReg})->dread==null"));
                }
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggers({DBReg})->Connection not open"));
            }
            return trigger;
        }
        
        public Dictionary<string,GeneratorClass> GetGeneratorObjects(DBRegistrationClass DBReg)
        {
            var generator = new Dictionary<string,GeneratorClass>();
            string cmd = SQLStatementsClass.Instance().RefreshNonSystemGeneratorsItems(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllGenerators->{DBReg}", ex));                 
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
                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.GeneratorsKeyStr) as GeneratorClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.InitValue = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            // tc.Increment = StaticFunctionsClass.ToIntDef(cc.GetValue(2).ToString().Trim(), 0);
                            tc.Description = dread.GetValue(3).ToString().Trim();

                            string cmd2 = "SELECT GEN_ID(" + tc.Name + ", 0) FROM RDB$DATABASE;";

                            var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGenertorsItems->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshGenertorsItems->Connection not open"));
            }
            return generator;
        }
        
        public Dictionary<string,ProcedureClass> GetProcedureObjects(DBRegistrationClass DBReg)
        {
            string cmd = SQLStatementsClass.Instance().RefreshProcedureItems(DBReg.Version);
            var procedures = new Dictionary<string,ProcedureClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->{DBReg}->Connection not open"));
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
                                                           
                            var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                            con2.Open();
                            
                            if (con2.State == System.Data.ConnectionState.Open)
                            {
                                string cmd1 = SQLStatementsClass.Instance().GetProcedureAttributes(DBReg.Version, tc.Name);
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
                                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread2==null"));
                            }
                        }                        
                    }
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->dread==null"));
                }
                
                dread.Close();
                con.Close();
            }            
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshProceduresItems->Connections not open"));
            }

            return procedures;
        }


        public string GetBLOBData(DBRegistrationClass DBReg, string cmd)
        {                        
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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


        public void ReadPKFields(FbDataReader dread, Dictionary<string,string> FieldNames, string tableName, string pkName, string pkField)
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
                    TableName = dread.GetValue(0).ToString().Trim();
                    PKField = dread.GetValue(3).ToString().Trim();
                    PKName = dread.GetValue(1).ToString().Trim();
                }
                else
                {
                    break;
                }
            }
        }
        
        public void GetAllTablePrimaryKeyObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {           
                string fields_cmd = SQLStatementsClass.Instance().GetAllTablePrimaryKeys(DBReg.Version);
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                            NewTableName = dread.GetValue(0).ToString().Trim();
                            PKField = dread.GetValue(3).ToString().Trim();
                            PKName = dread.GetValue(1).ToString().Trim();
                            
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

                                ReadPKFields(dread, tfc.FieldNames, TableName, PKName, PKField);
                                
                                tcc.primary_constraint = tfc;
                               
                                NewTableName = dread.GetValue(0).ToString().Trim();
                                PKField = dread.GetValue(3).ToString().Trim();
                                PKName = dread.GetValue(1).ToString().Trim();
                            }
                        }                        
                    }                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTablePrimaryObjects({DBReg},List<TableClass>", ex));                         
                }
                finally
                {
                    con.Close();
                }                        
        }
           
        public void AddForeignKeyObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {             
            string fields_cmd = SQLStatementsClass.Instance().GetAllTableForeignKeys(DBReg.Version,eTableType.withoutsystem);            
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableForeignKeyObjects({DBReg},List<TableClass>,{eTableType.withoutsystem.ToString()})", ex));                     
            }
            finally
            {
                con.Close();
            }
        }

        public void AddForeignKeyObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc)
        {             
            string fields_cmd = SQLStatementsClass.Instance().GetAllTableForeignKeys(DBReg.Version,eTableType.system);            
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableForeignKeyObjects({DBReg},List<TableClass>,{eTableType.system.ToString()})", ex));                     
            }
            finally
            {
                con.Close();
            }
        }
                              
        public void AddTriggerObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc)
        {            
            string fields_cmd = SQLStatementsClass.Instance().GetAllTableTriggersNonSystemTables(DBReg.Version);                   
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                                Active = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 1) == 0,
                                Type = (eTriggerType) StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0),
                                Sequence = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0),
                                Source = dread.GetValue(6).ToString().Trim()
                            };
                            tcc?.Triggers.Add(tfc.Name,tfc);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddTriggerObjectsToListOfTabelObjects({DBReg},List<TableClass>,{eTableType.withoutsystem.ToString()})", ex));                         
                }
                finally
                {
                    con.Close();
                }
        }
        public Dictionary<string,TriggerClass> GetAllTriggerObjects(DBRegistrationClass DBReg)
        {            
            string fields_cmd = SQLStatementsClass.Instance().GetAllTableTriggersNonSystemTables(DBReg.Version);                   
            var triggers = new Dictionary<string, TriggerClass>();
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                            RelationName = dread.GetValue(0).ToString().Trim(),
                            Name = dread.GetValue(1).ToString().Trim(),
                            Active = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 1) == 0,
                            Type = (eTriggerType) StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), 0),
                            Sequence = StaticFunctionsClass.ToIntDef(dread.GetValue(5).ToString().Trim(), 0),
                            Source = dread.GetValue(6).ToString().Trim()
                        };
                        triggers.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTriggerObjects({DBReg})", ex));                         
            }
            finally
            {
                con.Close();
            }
            return triggers;
        }
        
        
        
        public void AddTriggerObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc)
        {           
            string fields_cmd = SQLStatementsClass.Instance().GetAllTableTriggersSystemTables(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                        tcc?.Triggers.Add(tfc.Name,tfc);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddTriggerObjectsToListOfTabelObjects({DBReg},List<TableClass>,{eTableType.system.ToString()})", ex));                         
            }
            finally
            {
                con.Close();
            }
        }
        
        public void AddConstraintsObjects_To_ListOfTableObjects(eConstraintType ctyp, Dictionary<string,TableClass> tc, DBRegistrationClass DBReg, eTableType tabletype)
        {

            string cmd = string.Empty; 

            switch (tabletype)
            {
                case eTableType.withoutsystem:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance().GetAllTableConstraintsByTypeNonSystemTables(DBReg.Version, ctyp);
                    break;
                }
                case eTableType.system:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance().GetAllTableConstraintsByTypeSystemTables(DBReg.Version, ctyp);
                    break;
                }
            }

            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddContraintsObjectsToListOfTyableObjects({ctyp.ToString()},List<TableClass>,{DBReg},{tabletype.ToString()})", ex));                     
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
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddConstraintsObjects_To_ListOfTableObjects->TableNotFound->{TableName},{DBReg},{tabletype.ToString()})",TableName));                     
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
                               
                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(11).ToString().Trim();
                                string fieldpos = dread.GetValue(12).ToString().Trim();
                                tcs.FieldNames.Add(fieldname,fieldname);
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                               
                                if (ctyp == eConstraintType.PRIMARYKEY)
                                {
                                    // tcc.primary_constraints.Add(tcs);
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
                                string fieldpos = dread.GetValue(12).ToString().Trim();
                                tcs.FieldNames.Add(fieldname,fieldname);
                                tcs.TableName = dread.GetValue(2).ToString().Trim();

                                if ((ctyp == eConstraintType.UNIQUE)&&(!tcc.uniques_constraints.ContainsKey(tcs.Name)))
                                {
                                    try
                                    {
                                        tcc.uniques_constraints.Add(tcs.Name,tcs);
                                    }
                                    catch (Exception ex)
                                    {
                                        NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddConstraintsObjects_To_ListOfTableObjects->uniques_constraints.Add,{DBReg},{tabletype.ToString()})", ex));                     
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
                                tcs.FieldNames.Add(fieldname,fieldname);
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                                
                                if ((ctyp == eConstraintType.NOTNULL)&&(!tcc.notnulls_constraints.ContainsKey(tcs.Name)))
                                {
                                    try
                                    {
                                      tcc.notnulls_constraints.Add(tcs.Name,tcs);
                                    }
                                    catch (Exception ex)
                                    {
                                        NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddConstraintsObjects_To_ListOfTableObjects->notnulls_constraints.Add,{DBReg},{tabletype.ToString()})", ex));                     
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableConstraintsObjects->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableConstraintsObjects->Connection not open"));
            }            
        }
       
        public void GetSystemTableConstraintsObjects(eConstraintType ctyp, Dictionary<string,SystemTableClass> tc, DBRegistrationClass DBReg)
        {

            string cmd = ConstraintsSQLStatementsClass.Instance().GetSystemTableConstraintsByType(DBReg.Version, ctyp);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetSystemTableCOnstraintsObjects({ctyp.ToString()},List<tableClass>,{DBReg})", ex));                     
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
                                
                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(11).ToString().Trim();
                                string fieldpos = dread.GetValue(12).ToString().Trim();
                                tcs.FieldNames.Add(fieldname,fieldname);
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                               
                                if (ctyp == eConstraintType.PRIMARYKEY)
                                {
                                    // tcc.primary_constraints.Add(tcs);
                                    tcc.primary_constraint = tcs;
                                }
                              
                            }
                            else if (ctyp == eConstraintType.NOTNULL)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.NotNullKeyStr) as NotNullsClass;
                                
                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(11).ToString().Trim();
                                string fieldpos = dread.GetValue(12).ToString().Trim();
                                tcs.FieldNames.Add(fieldname,fieldname);
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                                if(!tcc.notnulls_constraints.ContainsKey(tcs.Name)) tcc.notnulls_constraints.Add(tcs.Name,tcs);                                
                            }
                            else if (ctyp == eConstraintType.UNIQUE)
                            {
                                var tcs = DataClassFactory.GetDataClass(StaticVariablesClass.UniquesKeyStr) as UniquesClass;
                                
                                tcs.Name = dread.GetValue(0).ToString().Trim();
                                tcs.ConstraintType = StaticVariablesClass.GetConstraintType(dread.GetValue(1).ToString().Trim());
                                tcs.IndexName = dread.GetValue(5).ToString().Trim();
                                string fieldname = dread.GetValue(11).ToString().Trim();
                                string fieldpos = dread.GetValue(12).ToString().Trim();
                                tcs.FieldNames.Add(fieldname,fieldname);
                                tcs.TableName = dread.GetValue(2).ToString().Trim();
                                if (!tcc.uniques_constraints.ContainsKey(tcs.Name)) tcc.uniques_constraints.Add(tcs.Name,tcs);                                
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetSystemTableConstraintsObjects->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetSystemTableConstraintsObjects->Connection not open"));
            }
        }
        
        public void AddCheckConstraintsObjects_To_ListOfTableObjects(Dictionary<string,TableClass> tc,DBRegistrationClass DBReg, eTableType tabletype)
        {
            string cmd = string.Empty;
            switch (tabletype)
            {
                case eTableType.withoutsystem:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance().GetAllTableCheckConstraintsNonSystem(DBReg.Version);
                    break;
                }
                case eTableType.system:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance().GetAllTableCheckConstraintsSystem(DBReg.Version);
                    break;
                }
            }
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddCheckConstraintsObjects_To_ListOfTableObjects(List<TableClass>,{DBReg},{tabletype.ToString()})", ex));                     
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
                            tcs.Name = dread.GetValue(0).ToString().Trim();
                            tcs.ConstraintType = eConstraintType.CHECK;                            
                            tcs.TriggerName = dread.GetValue(6).ToString().Trim();                            
                            tcs.TableName = TableName;
                            tcs.Source = dread.GetValue(7).ToString().Trim();
                            try
                            {
                                if(tcc.check_constraints.ContainsKey(tcs.Name)) tcc.check_constraints.Add(tcs.Name,tcs);
                            }
                            catch(Exception ex)
                            {
                                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddCheckConstraintsObjects_To_ListOfTableObjects({TableName},{DBReg})->check_constraints.Add", ex));         
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableCheckConstraintsObjects->dreade==null"));
                }
                con.Close();

            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableCheckConstraintsObjects->Connection not open"));
            }
            
        }
        public void AddCheckConstraintsObjects_To_ListOfSystemTableObjects(Dictionary<string,SystemTableClass> tc,DBRegistrationClass DBReg, eTableType tabletype)
        {
            string cmd = string.Empty;
            switch (tabletype)
            {
                case eTableType.withoutsystem:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance().GetAllTableCheckConstraintsNonSystem(DBReg.Version);
                    break;
                }
                case eTableType.system:
                {
                    cmd = ConstraintsSQLStatementsClass.Instance().GetAllTableCheckConstraintsSystem(DBReg.Version);
                    break;
                }
            }
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddCheckConstraintsObjects_To_ListOfTableObjects(List<TableClass>,{DBReg},{tabletype.ToString()})", ex));                     
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
                            tcs.Name = dread.GetValue(0).ToString().Trim();
                            tcs.ConstraintType = eConstraintType.CHECK;                            
                            tcs.TriggerName = dread.GetValue(6).ToString().Trim();                            
                            tcs.TableName = TableName;
                            tcs.Source = dread.GetValue(7).ToString().Trim();
                            try
                            {
                                if(tcc.check_constraints.ContainsKey(tcs.Name)) tcc.check_constraints.Add(tcs.Name,tcs);
                            }
                            catch(Exception ex)
                            {
                                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddCheckConstraintsObjects_To_ListOfTableObjects({TableName},{DBReg})->check_constraints.Add", ex));         
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableCheckConstraintsObjects->dreade==null"));
                }
                con.Close();

            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllTableCheckConstraintsObjects->Connection not open"));
            }
            
        }

               
        public void AddDependenciesTOObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc, eDependencies typ)
        {
            
            string cmd = SQLStatementsClass.Instance().GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDependenciesTOObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{typ.ToString()})->con.Open()", ex));     
                
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
                                        tcc.DependenciesTO_Tables.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name)))
                                    {
                                        tcc.DependenciesTO_Triggers.Add(tcs.Name,tcs);
                                    }

                                    if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesTO_Views.ContainsKey(tcs.Name)))
                                    {
                                        tcc.DependenciesTO_Views.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesTO_Procedures.ContainsKey(tcs.Name)))
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                            tcc.DependenciesTO_Procedures.Add(key,tcs);
                                        else
                                            NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDependenciesTOObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}"));  
                                    }
                                }
                                catch(Exception ex)
                                {
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDependenciesTOObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}", ex));  
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesOn->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesOn->Connection not open"));
            }
        }

        public void AddDependenciesTOObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc, eDependencies typ)
        {
            
            string cmd = SQLStatementsClass.Instance().GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDependenciesTOObjects_To_ListOfSystemTableObjects({DBReg},List<TableClass>,{typ.ToString()})->con.Open()", ex));     
                
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
                            TableName = dread.GetValue(1).ToString().Trim();
                            DependObjectName = dread.GetValue(0).ToString().Trim();
                            FieldName = dread.GetValue(2).ToString().Trim();
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
                                        tcc.DependenciesTO_Tables.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesTO_Triggers.ContainsKey(tcs.Name)))
                                    {
                                        tcc.DependenciesTO_Triggers.Add(tcs.Name,tcs);
                                    }

                                    if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesTO_Views.ContainsKey(tcs.Name)))
                                    {
                                        tcc.DependenciesTO_Views.Add(tcs.Name,tcs);
                                    }
                                    if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesTO_Procedures.ContainsKey(tcs.Name)))
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                          tcc.DependenciesTO_Procedures.Add(key,tcs);
                                       else NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDependenciesTOObjects_To_ListOfSystemTableObjects({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}", ""));  
                                    }
                                }
                                catch(Exception ex)
                                {
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDependenciesTOObjects_To_ListOfSystemTableObjects({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}", ex));  
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesOn->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesOn->Connection not open"));
            }
        }

        public void GetAllDependenciesOn(DBRegistrationClass DBReg, Dictionary<string,ViewClass> tc, eDependencies typ)
        {
            string cmd = SQLStatementsClass.Instance().GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDependenciesOn({DBReg},List<TableClass>,{typ.ToString()})->con.Open()", ex));                     
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
                                //tcc = tc.Values.Find(X => X.Name == TableName);

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
                                        tcc.DependenciesTO_Tables.Add(tcs.Name,tcs);
                                    }

                                    if (deptyp == eDependencies.TRIGGER)
                                    {
                                        tcc.DependenciesTO_Triggers.Add(tcs.Name,tcs);
                                    }

                                    if (deptyp == eDependencies.VIEW)
                                    {
                                        tcc.DependenciesTO_Views.Add(tcs.Name,tcs);
                                    }

                                    if (deptyp == eDependencies.PROCEDURE)
                                    {
                                        string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                        
                                        if (!tcc.DependenciesTO_Procedures.ContainsKey(key))
                                          tcc.DependenciesTO_Procedures.Add(key, tcs);
                                        else
                                          NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDependenciesOn({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}->{key} already exists",""));  
                                    }
                                }
                                catch(Exception ex)
                                {
                                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDependenciesOn({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}", ex));  
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesOn->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesOn->Connection not open"));
            }
        }
        
        public void AddDependenciesFROMObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, Dictionary<string,TableClass> tc, eDependencies typ)
        {           
            string cmd = SQLStatementsClass.Instance().GetAllDependenciesFROM(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{typ.ToString()})", ex));                                     
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

                                tcs.Type = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), (int)eDependencies.NONE);
                                tcs.TypeOn = (eDependencies)StaticFunctionsClass.ToIntDef(dread.GetValue(4).ToString().Trim(), (int)eDependencies.NONE);

                                if ((deptyp == eDependencies.TABLE)&&(!tcc.DependenciesFROM_Tables.ContainsKey(tcs.Name)))
                                {
                                    tcc.DependenciesFROM_Tables.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name)))
                                {
                                    tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }

                                if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name)))
                                {
                                    tcc.DependenciesFROM_Views.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesFROM_Procedures.ContainsKey(tcs.Name)))
                                {
                                    string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                    if (!tcc.DependenciesFROM_Procedures.ContainsKey(key))
                                       tcc.DependenciesFROM_Procedures.Add(key,tcs);
                                     else
                                        NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg}, List<TableClass> tc, eDependencies typ)->dread==null"));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg}, List<TableClass> tc, eDependencies typ)->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg}, List<TableClass> tc, eDependencies typ)->Connection not open"));
            }
        }

        public void AddDepednenciesFROMObjects_To_ListOfSystemTableObjects(DBRegistrationClass DBReg, Dictionary<string,SystemTableClass> tc, eDependencies typ)
        {           
            string cmd = SQLStatementsClass.Instance().GetAllDependenciesFROM(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg},List<TableClass>,{typ.ToString()})", ex));                                     
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
                                    tcc.DependenciesFROM_Tables.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.TRIGGER)&&(!tcc.DependenciesFROM_Triggers.ContainsKey(tcs.Name)))
                                {
                                    tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }

                                if ((deptyp == eDependencies.VIEW)&&(!tcc.DependenciesFROM_Views.ContainsKey(tcs.Name)))
                                {
                                    tcc.DependenciesFROM_Views.Add(tcs.Name,tcs);
                                }
                                if ((deptyp == eDependencies.PROCEDURE)&&(!tcc.DependenciesFROM_Procedures.ContainsKey(tcs.Name)))
                                {
                                    string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                    if (!tcc.DependenciesFROM_Procedures.ContainsKey(key))
                                    tcc.DependenciesFROM_Procedures.Add(key,tcs);
                                     else
                                     NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects(DBRegistrationClass DBReg, List<TableClass> tc, eDependencies typ)->dread==null"));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg}, List<TableClass> tc, eDependencies typ)->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->AddDepednenciesFROMObjects_To_ListOfTableObjects({DBReg}, List<TableClass> tc, eDependencies typ)->Connection not open"));
            }
        }

        public void GetAllDepednenciesFROM(DBRegistrationClass DBReg, Dictionary<string,ViewClass> tc, eDependencies typ)
        {
            string cmd = SQLStatementsClass.Instance().GetAllDependenciesON(DBReg.Version, typ);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesFROM({DBReg},List<TableClass>,{typ.ToString()})->con.Open()", ex));                                                     
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
                                //tcc = tc.Find(X => X.Name == TableName);
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
                                    tcc.DependenciesFROM_Tables.Add(tcs.Name,tcs);
                                }

                                if (deptyp == eDependencies.TRIGGER)
                                {
                                    tcc.DependenciesFROM_Triggers.Add(tcs.Name,tcs);
                                }

                                if (deptyp == eDependencies.VIEW)
                                {
                                    tcc.DependenciesFROM_Views.Add(tcs.Name,tcs);
                                }

                                if (deptyp == eDependencies.PROCEDURE)
                                {
                                    string key = $@"{DependObjectName}->{tcs.Name}->{tcs.FieldName}";
                                    if (!tcc.DependenciesFROM_Procedures.ContainsKey(key))
                                        tcc.DependenciesFROM_Procedures.Add(key, tcs);
                                    else
                                        NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDependenciesFROM({DBReg},List<TableClass>,{typ.ToString()})->Dependencies.Add->{deptyp}->{key} already exists", ""));
                                }
                            }
                            n++;
                        }
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesFROM->dreade==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetAllDepednenciesFROM->Connection not open"));
            }
        }

        public Dictionary<string,ViewFieldClass> GetViewFieldObjects(DBRegistrationClass DBReg, string ViewName)
        {
            var fields = new Dictionary<string,ViewFieldClass>();
            if (!string.IsNullOrEmpty(ViewName))
            {
                string cmd = SQLStatementsClass.Instance().GetViewFields(DBReg.Version, ViewName);                
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewFieldObjects({DBReg},{ViewName})", ex));                                                                         
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
            var fields = new List<ViewFieldClass>();
            View.Fields.Clear();
            if (!string.IsNullOrEmpty(View.Name))
            {
                string cmd = SQLStatementsClass.Instance().GetViewFields(DBReg.Version,View.Name);
               
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
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
                            object ob = dread.GetValue(0);
                            object ob_field_position = dread.GetValue(1);

                            string fieldstr = ob.ToString().Trim();
                            string posstr = ob_field_position.ToString().Trim();
                            int pos = StaticFunctionsClass.ToIntDef(posstr, -1);
                            string typename = dread.GetValue(3).ToString().Trim();
                            string typelength = dread.GetValue(4).ToString().Trim();
                            int length = StaticFunctionsClass.ToIntDef(typelength, 0);

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
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->FillViewObject({DBReg},{View?.Name})", ex));                                                                         
                }
                finally
                {
                    con.Close();
                }
            }            
        }
        
        public ViewClass GetViewObject(DBRegistrationClass DBReg, string viewname)
        {
            var new_view = new ViewClass();

            string cmd = SQLStatementsClass.Instance().RefreshView(DBReg.Version,viewname);
            var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObject({DBReg},{viewname})", ex));                                                                                         
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
                        string view_name = "";
                        string view_name_old = "";
                        string voldsql = "";

                        var strl = new StringBuilder();
                        var strli = new StringBuilder();

                        object ob_viewname = null;
                        object ob_sql = null;
                        object ob_fieldname = null;

                        while (dread.Read())
                        {
                            ob_viewname = dread.GetValue(0);
                            ob_sql = dread.GetValue(1);
                            ob_fieldname = dread.GetValue(2);
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
                                
                                strl.AppendLine("CREATE OR ALTER VIEW " + view_name);
                                strl.AppendLine("(");
                                strl.Append("    " + ob_fieldname.ToString().Trim());
                                strli.AppendLine("CREATE VIEW " + view_name);
                                strli.AppendLine("(");
                                strli.Append("    " + ob_fieldname.ToString().Trim());
                                view_name_old = view_name;
                            }
                            else
                            {
                                //Bestehender View wird niedergeschrieben
                                strl.AppendLine(",");
                                strl.Append("    " + ob_fieldname.ToString().Trim());
                                strli.AppendLine(",");
                                strli.Append("    " + ob_fieldname.ToString().Trim());
                            }
                            voldsql = ob_sql.ToString().Trim();
                            System.Text.Encoding enc = System.Text.Encoding.Default;
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

                            n++;
                            view_name_old = "";
                            strl.Clear();
                            new_view = vcl;
                        }

                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObject->{viewname}->dread==null"));
                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->GetViewObject->{viewname}->Connection not open"));
            }
            return new_view;
        }
        
        #region indecies

                       
        #endregion
    }
}
