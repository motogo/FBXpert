using BasicClassLibrary;
using DBBasicClassLibrary;
using Enums;
using FBXpertLib;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FBExpert
{

    public class StaticTreeNodesClass : object
    {
        enum eTableTypes { SystemTables, UserdefinedTables, AllTables };
        public string TypeName = "StaticDatabaseObjects";
        public Color Active = Color.Blue;
        public Color Inactive = Color.Red;
        public Color ActiveHasConstraint = Color.DarkCyan;
        public Color InactiveHasConstraint = Color.OrangeRed;


        private static StaticTreeNodesClass _instance;
        private static readonly object _lock_this = new object();
        public static StaticTreeNodesClass Instance()
        {
            if (_instance != null) return (_instance);
            lock (_lock_this)
            {
                _instance = new StaticTreeNodesClass();
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

            if (nd.Name == name) return nd;
            foreach (TreeNode n in nd.Nodes)
            {
                if (n.Name == name)
                {
                    return n;
                }
            }
            return null;
        }

        public TreeNode FindPrevDBNode(TreeNode nd)
        {
            TreeNode n = nd;
            while (n != null)
            {
                object obj = n.Tag;
                if (obj != null)
                {
                    string str = obj.GetType().Name;
                    if (str == "DBRegistrationClass")
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
                if ((str == "TableClass") && (nd.Tag != n.Tag))
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
            if (nd == null) return null;
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

        public void MakeTODependenciesNodesForAll(Dictionary<string, DependencyClass> DependenciesTO, List<TreeNode> dependencyTO_list_Node)
        {
            if (DependenciesTO != null)
            {
                string oldInxName = string.Empty;
                TreeNode node = null;
                string oldDependName = string.Empty;
                TreeNode inx_node = null;
                foreach (var inx in DependenciesTO.Values)
                {
                    if (oldDependName != inx.Name)
                    {
                        oldInxName = string.Empty;
                        node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToKeyStr, inx.Name, inx);
                        dependencyTO_list_Node.Add(node);
                        oldDependName = inx.Name;
                    }

                    if (oldInxName != inx.DependOnName)
                    {
                        inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToKeyStr, inx.DependOnName, inx);
                        node.Nodes.Add(inx_node);
                        oldInxName = inx.DependOnName;
                    }
                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromKeyStr, inx.DependOnName + " -> " + inx.FieldName, inx);
                    inx_node.Nodes.Add(tablen);
                }
            }
        }

        public static void MakeFROMDependenciesNodesForAll(Dictionary<string, DependencyClass> DependenciesTO, List<TreeNode> dependencyTO_list_Node)
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

        public void RefreshPrimaryKeysFromTableNodes(TreeNode nd, TreeNode group_node)
        {
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var ViewNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.ViewsKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);
            TreeNode akt_group_node;

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
                if (tc.primary_constraint == null) continue;  //HE                                    
                var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                pk_list.Add(tablen);
            }

            pk_list.Sort(CompareString);
            akt_group_node.Text = $@"Primary Keys ({pk_list.Count})";
            akt_group_node.Nodes.AddRange(pk_list.ToArray());

            nd.Nodes.Add(akt_group_node);
        }

        public void RefreshPrimaryKeysFromSystemTableNodes(TreeNode regNode, TreeNode group_node)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.SystemTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);
            TreeNode akt_group_node;
            //bool newnode = false;
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
                if (tc.primary_constraint == null) continue;
                var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint);
                pk_list.Add(tablen);
            }

            pk_list.Sort(CompareString);
            akt_group_node.Text = $@"Primary System Keys ({pk_list.Count})";
            akt_group_node.Nodes.AddRange(pk_list.ToArray());

            regNode.Nodes.Add(akt_group_node);
        }

        public void RefreshForeignKeysFromTableNodes(TreeNode nd, TreeNode _tnSelected)
        {

            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);
            TreeNode akt_group_node;
            bool newnode = false;
            if (_tnSelected != null)
            {
                var group_node = StaticTreeNodesClass.Instance().FindPrevFKGroupNode(_tnSelected);
                if (group_node != null)
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
                    TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, fc.Name, fc);

                    fk_list.Add(tablen);
                }
            }
            fk_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(fk_list.ToArray());
            akt_group_node.Text = "Foreign Keys (" + fk_list.Count.ToString() + ")";
            if (newnode) nd.Nodes.Add(akt_group_node);
        }

        public void RefreshConstraintsFromTableNodes(TreeNode regNode, TreeNode group_node)
        {
            /*
            constaraints
               ------------primary
               ------------unique
               ------------not nulls
               ------------checks
            */
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);

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
            pk_constrainr_group_node.Text = $@"Primary Keys ({cpk_list.Count})";

            cnn_list.Sort(CompareString);
            nn_group_node.Nodes.AddRange(cnn_list.ToArray());
            nn_group_node.Text = $@"Not Nulls ({cnn_list.Count})";

            cck_list.Sort(CompareString);
            ck_group_node.Nodes.AddRange(cck_list.ToArray());
            ck_group_node.Text = $@"Checks ({cck_list.Count})";

            cu_list.Sort(CompareString);
            uniques_group_node.Nodes.AddRange(cu_list.ToArray());
            uniques_group_node.Text = $@"Uniques ({cu_list.Count})";

            if (newnode) regNode.Nodes.Add(akt_group_node);

            akt_group_node.Text = $@"Constraints ({(cpk_list.Count + cnn_list.Count + cu_list.Count)})";
            akt_group_node.Nodes.Add(pk_constrainr_group_node);
            akt_group_node.Nodes.Add(uniques_group_node);
            akt_group_node.Nodes.Add(nn_group_node);
            akt_group_node.Nodes.Add(ck_group_node);
            akt_group_node.Collapse();
        }

        public void RefreshTriggersFromTableNodes(TreeNode regNode, TreeNode group_node)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);

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
                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, fc.Name, fc);
                    trigger_list.Add(tablen);
                }
            }

            trigger_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(trigger_list.ToArray());
            akt_group_node.Text = $@"Triggers ({trigger_list.Count})";

            if (newnode) regNode.Nodes.Add(akt_group_node);
        }

        public void RefreshSystemTriggersFromTableNodes(TreeNode regNode, TreeNode group_node)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.SystemTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);

            TreeNode akt_group_node;
            bool newnode = false;
            if (group_node != null)
            {
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "System Triggers";
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.SystemTriggersKeyGroupStr);
                newnode = true;
            }

            var trigger_list = new List<TreeNode>();

            foreach (var tc in Tables)
            {
                if (tc.Triggers == null) continue;
                foreach (var fc in tc.Triggers.Values)
                {
                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.SystemTriggersKeyStr, fc.Name, fc);
                    trigger_list.Add(tablen);
                }
            }

            trigger_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(trigger_list.ToArray());
            akt_group_node.Text = $@"System Triggers ({trigger_list.Count})";

            if (newnode) regNode.Nodes.Add(akt_group_node);
        }

        public void RefreshDependenciesFromTableNodes(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);

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

            regNode.Nodes.Add(dependencies_group_node);

            dependencies_group_node.Text = "Dependencies (" + (dependencyTOTables_list.Count + dependencyFROMTables_list.Count + dependencyTOTriggers_list.Count + dependencyFROMTriggers_list.Count + dependencyTOViews_list.Count + dependencyFROMViews_list.Count + dependencyTOProcedures_list.Count + dependencyFROMProcedures_list.Count).ToString() + ")";
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



        //Holt alle Indeces für die dem Knoten nd übergeordneten Table
        public void RefreshTableIndicesFromOneTable(TreeNode regNode, TreeNode nd)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var tnn = FindPrevTableNode(nd);
            if (tnn == null) return;

            var tcc = tnn.Tag as TableClass;
            string fields_cmd = IndexSQLStatementsClass.Instance.GetTableIndicies(tcc.Name);

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshTableIndicesFromOneTable({DBReg},node:{nd.Name})", ex));
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
                            var node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, tc.Name, tc);

                            node.BackColor = tc.IsActive ? Color.Green : Color.Red;
                            tn.Nodes.Add(node);
                            n++;
                        }
                        tn.Text = $@"Indices ({n})";

                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndices->dread==null"));
                }

                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->RefreshIndices->ConnectionName not open"));
            }
        }

        //Liest alle Indicies únd erzeugt den TreeGroupNode Indeces und Restauriert die indeces der TableNodes
        public void RefreshAllIndicies(TreeNode regNode, TreeNode group_node)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.CommonTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);

            Dictionary<string, IndexClass> indecies = StaticDatabaseObjects.Instance().GetIndecesObjects(DBReg);

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
                var node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, fc.Name, fc);

                inx_list.Add(node);
                TableClass tc = Tables.Find(X => X.Name == fc.RelationName);

                if (tc != null)
                {
                    if (tc.Indices == null)
                    {
                        tc.Indices = new Dictionary<string, IndexClass>();
                    }
                    tc.Indices.Remove(fc.Name);
                    tc.Indices.Add(fc.Name, fc);
                }
            }

            inx_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(inx_list.ToArray());
            akt_group_node.Text = $@"Indices all ({inx_list.Count})";
            if (newnode) regNode.Nodes.Add(akt_group_node);
        }

        public void RefreshAllSystemIndicies(TreeNode regNode, TreeNode group_node)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var TableNode = StaticTreeNodesClass.Instance().FindFirstNodeInAllNodes(regNode, StaticVariablesClass.SystemTablesKeyGroupStr);
            var Tables = StaticTreeNodesClass.Instance().GetTableObjectsFromNode(TableNode);

            Dictionary<string, IndexClass> indecies = StaticDatabaseObjects.Instance().GetSystemIndecesObjects(DBReg);

            TreeNode akt_group_node;
            bool newnode = false;

            if (group_node != null)
            {
                RemoveNodes(group_node);
                akt_group_node = group_node;
                akt_group_node.Text = "System Indices";
            }
            else
            {
                akt_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.SystemIndicesKeyGroupStr);
                newnode = true;
            }
            var inx_list = new List<TreeNode>();

            foreach (var fc in indecies.Values)
            {
                Type tp = fc.GetType();

                var node = DataClassFactory.GetNewNode(StaticVariablesClass.SystemIndicesKeyStr, fc.Name, fc);

                inx_list.Add(node);
                TableClass tc = Tables.Find(X => X.Name == fc.RelationName);

                if (tc != null)
                {
                    if (tc.Indices == null)
                    {
                        tc.Indices = new Dictionary<string, IndexClass>();
                    }
                    tc.Indices.Remove(fc.Name);
                    tc.Indices.Add(fc.Name, fc);
                }
            }

            inx_list.Sort(CompareString);
            akt_group_node.Nodes.AddRange(inx_list.ToArray());
            akt_group_node.Text = $@"System Indices all ({inx_list.Count})";
            if (newnode) regNode.Nodes.Add(akt_group_node);
        }


        #endregion


        public void RefreshDomains(TreeNode nd)
        {
            var DBReg = (DBRegistrationClass)nd.Tag;
            string _funcStr = $@"RefreshDomains(DBReg={DBReg})";
            string cmd = DomainSQLStatementsClass.Instance.RefreshNonSystemDomains(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
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

                            if (tc.DefaultValue.Length > 0)
                            {
                                if (tc.DefaultValue.StartsWith("DEFAULT "))
                                {
                                    tc.DefaultValue = tc.DefaultValue.Substring(8).Trim();
                                }
                            }
                            tc.Description = dread.GetValue(7).ToString().Trim();
                            TreeNode node = DataClassFactory.GetNewNode(StaticVariablesClass.DomainsKeyStr, tc.Name, tc);
                            tn.Nodes.Add(node);
                            n++;
                        }
                        tn.Text = $@"Domains ({n})";
                        //Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");

                        NotifiesClass.Instance.AddToINFO($@"RefreshDomains->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void RefreshSystemDomains(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            string _funcStr = $@"RefreshDomains(DBReg={DBReg})";
            string cmd = DomainSQLStatementsClass.Instance.RefreshSystemDomains(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();

                if (dread != null)
                {
                    var tn = FindNode(regNode, StaticVariablesClass.SystemDomainsKeyGroupStr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.SystemDomainsKeyGroupStr);
                        regNode.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "System Domains";
                        tn.Nodes.Clear();
                    }

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
                            tc.DefaultValue = string.Empty; // dread.GetValue(6).ToString().Trim();
                            tc.Description = string.Empty;

                            TreeNode node = DataClassFactory.GetNewNode(StaticVariablesClass.SystemDomainsKeyStr, tc.Name, tc);
                            tn.Nodes.Add(node);
                            n++;
                        }
                        tn.Text = $@"System Domains ({n})";
                        //Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");

                        NotifiesClass.Instance.AddToINFO($@"RefreshDomains->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dreade==null"));
                }
                con.Close();
                regNode.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void RefreshForeignKeys4OneTable(TreeNode regNode, TreeNode tablenode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            string _funcStr = $@"RefreshForeignKeys(DBReg={DBReg})";
            var table = (TableClass)tablenode.Tag;
            var nodeForeignKeyGroup = FindNode(tablenode, StaticVariablesClass.ForeignKeyGroupStr);
            //var tablenode = FindPrevTableNode(tableGroupNode);            

            string cmd = SQLStatementsClass.Instance.GetAllTableForeignKeys(DBReg.Version, eTableType.withoutsystem, table.Name);

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {
                    if (nodeForeignKeyGroup == null)
                    {
                        nodeForeignKeyGroup = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr);
                        tablenode.Nodes.Add(nodeForeignKeyGroup);
                    }
                    else
                    {
                        nodeForeignKeyGroup.Text = "Foreign Keys";
                        nodeForeignKeyGroup.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.ForeignKeyStr) as ForeignKeyClass;
                            tc.Name = dread.GetValue(2).ToString().Trim(); //ForeignKeyName
                            int inactive = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 1);
                            tc.IsActive = inactive == 0;
                            TreeNode node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, tc.Name, tc);
                            nodeForeignKeyGroup.Nodes.Add(node);
                            n++;
                        }
                        //Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"RefreshForeignKeys->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        nodeForeignKeyGroup.Text = $@"Foreign Keys ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
                tablenode.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public int RefreshConstraintItems(eConstraintType ctyp, DBRegistrationClass DBReg, TreeNode nd, string tableName)
        {
            string _funcStr = $@"RefreshConstraintItems(DBReg={DBReg})";
            string cmd = string.Empty;

            if (ctyp == eConstraintType.NOTNULL)
            {
                cmd = ConstraintsSQLStatementsClass.Instance.GetTableConstraintsByType(DBReg.Version, "NOT NULL", tableName);
            }
            else if (ctyp == eConstraintType.PRIMARYKEY)
            {
                cmd = ConstraintsSQLStatementsClass.Instance.GetTableConstraintsByType(DBReg.Version, "PRIMARY KEY", tableName);
            }
            else if (ctyp == eConstraintType.UNIQUE)
            {
                cmd = ConstraintsSQLStatementsClass.Instance.GetTableConstraintsByType(DBReg.Version, "UNIQUE", tableName);
            }

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
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

                        string tnameold = string.Empty;

                        ConstraintsClass tc = null;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        while (dread.Read())
                        {
                            string fieldname = dread.GetValue(6).ToString().Trim();
                            string tname = dread.GetValue(0).ToString().Trim();
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
                                tc.FieldNames.Add(fieldname, fieldname);
                                tc.TableName = dread.GetValue(2).ToString().Trim();

                                tnameold = tname;
                                n++;
                            }
                            else
                            {
                                //Bereits angelegter const                                                                                                        
                                tc.FieldNames.Add(fieldname, fieldname);
                            }
                        }
                        //Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"RefreshConstraintItems->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        if (tc != null)
                        {
                            TreeNode node = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyStr, tc.Name, tc);

                            tn.Nodes.Add(node);
                        }
                        tn.Text = $@"{ctyp} ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
            return n;
        }

        public void RefreshConstraints(TreeNode regNode, TreeNode nconstr)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var tablenode = FindPrevTableNode(nconstr);
            var tc = (TableClass)tablenode.Tag;
            var tn = FindNode(tablenode, StaticVariablesClass.ConstraintsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr);
            }
            else
            {
                tn.Nodes.Clear();
            }

            int n = RefreshConstraintItems(eConstraintType.UNIQUE, DBReg, tn, tc.Name);
            n = RefreshConstraintItems(eConstraintType.NOTNULL, DBReg, tn, tc.Name);
            n += RefreshConstraintItems(eConstraintType.PRIMARYKEY, DBReg, tn, tc.Name);
            tn.Text = $@"Constraints ({n})";
            tn.Collapse();
        }

        public void RefreshProcedures(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            TreeNode tn = FindNode(regNode, StaticVariablesClass.ProceduresKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.ProceduresKeyGroupStr);
                regNode.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "Procedures";
                tn.Nodes.Clear();
            }
            RefreshProceduresItems(DBReg, tn);
            regNode.Expand();
        }

        public void RefreshProceduresItems(DBRegistrationClass DBReg, TreeNode nd)
        {
            NotifiesClass.Instance.AddToINFO($@"Refresh Procedures for {DBReg.Alias}", eMessageGranularity.few, true);
            var allprocedures = StaticDatabaseObjects.Instance().GetProcedureObjects(DBReg);
            foreach (var procedure in allprocedures.Values)
            {
                TreeNode node = DataClassFactory.GetNewNode(StaticVariablesClass.ProceduresKeyStr, procedure.Name, procedure);

                nd.Nodes.Add(node);
            }
            nd.Text = $@"Procedures ({allprocedures.Count})";
        }

        public void RefreshProceduresItemsOld(DBRegistrationClass DBReg, TreeNode nd)
        {
            string _funcStr = $@"RefreshProceduresItemsOld(DBReg={DBReg})";
            String cmd = SQLStatementsClass.Instance.RefreshProcedureItems(DBReg.Version);

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
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
                                                Name = dread2.GetValue(0).ToString().Trim(),
                                                Position = StaticFunctionsClass.ToIntDef(dread2.GetValue(2).ToString().Trim(), 0),
                                                TypeNumber = StaticFunctionsClass.ToIntDef(dread2.GetValue(3).ToString().Trim(), 0),
                                                Length = StaticFunctionsClass.ToIntDef(dread2.GetValue(4).ToString().Trim(), 0),
                                                Precision = StaticFunctionsClass.ToIntDef(dread2.GetValue(5).ToString().Trim(), 0),
                                                Scale = StaticFunctionsClass.ToIntDef(dread2.GetValue(6).ToString().Trim(), 0),
                                                FieldType = dread2.GetValue(7).ToString().Trim()
                                            };

                                            pc.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(pc.FieldType, pc.Length);
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
                                TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.ProceduresKeyStr, tc.Name, tc);
                                nd.Nodes.Add(tablen);
                                n++;
                            }
                            else
                            {
                                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread2==null"));
                            }
                        }
                        nd.Text = $@"Procedures ({n})";
                    }
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }

                dread.Close();
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connections not open"));
            }
        }

        public void RefreshInternalFunctions(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            TreeNode tn = FindNode(regNode, StaticVariablesClass.FunctionsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.FunctionsKeyGroupStr);
                regNode.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "Functions";
                tn.Nodes.Clear();
            }

            RefreshInternalFunctionsItems(DBReg, tn);
            regNode.Expand();
        }

        public void RefreshInternalFunctionsItems(DBRegistrationClass DBReg, TreeNode nd)
        {
            NotifiesClass.Instance.AddToINFO($@"Refresh Functions for {DBReg.Alias}", eMessageGranularity.few, true);
            var allObjects = StaticDatabaseObjects.Instance().GetInternalFunctionObjects(DBReg);
            foreach (var procedure in allObjects.Values)
            {
                TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.FunctionsKeyStr, procedure.Name, procedure);
                nd.Nodes.Add(tablen);
            }
            nd.Text = $@"Functions ({allObjects.Count})";
        }

        public void RefreshUserDefinedFunctions(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            TreeNode tn = FindNode(regNode, StaticVariablesClass.UserDefinedFunctionsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.UserDefinedFunctionsKeyGroupStr);
                regNode.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "User defined functions";
                tn.Nodes.Clear();
            }
            RefreshUserDefinedFunctionsItems(DBReg, tn);
            regNode.Expand();
        }

        public void RefreshUserDefinedFunctionsItems(DBRegistrationClass DBReg, TreeNode nd)
        {
            NotifiesClass.Instance.AddToINFO($@"Refresh user defined functions for {DBReg.Alias}", eMessageGranularity.few, true);
            var allObjects = StaticDatabaseObjects.Instance().GetUserDefinedFunctionObjects(DBReg);
            foreach (var procedure in allObjects.Values)
            {
                TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.UserDefinedFunctionsKeyStr, procedure.Name, procedure);
                nd.Nodes.Add(tablen);
            }
            nd.Text = $@"User defined functions ({allObjects.Count})";
        }

        public void RefreshTriggers(DBRegistrationClass DBReg, TreeNode nd)
        {
            //Systemflag = 0 für TableTriggers
            //Systemflag = 4 für Systemtable Triggers
            string _funcStr = $@"RefreshTriggers(DBReg={DBReg})";
            string cmd = SQLStatementsClass.Instance.RefreshNonSystemTriggers(DBReg.Version);
            NotifiesClass.Instance.AddToINFO($@"Refresh Triggers for {DBReg.Alias}", eMessageGranularity.few, true);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
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
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.TriggersKeyStr) as TriggerClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            int inactive = StaticFunctionsClass.ToIntDef(dread.GetValue(2).ToString().Trim(), 1);
                            int tp = StaticFunctionsClass.ToIntDef(dread.GetValue(3).ToString().Trim(), 0);

                            tc.Active = (inactive == 0);
                            tc.Type = (eTriggerType)tp;
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, tc.Name, tc);

                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"{_funcStr}->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        tn.Text = $@"Trigger ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }

                con.Close();
                nd.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void RefreshRoles(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            string _funcStr = $@"RefreshRoles(DBReg={DBReg})";
            NotifiesClass.Instance.AddToINFO($@"Refresh Roles for {DBReg.Alias}", eMessageGranularity.few, true);
            string cmd = SQLStatementsClass.Instance.RefreshRoles(DBReg.Version);

            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                if (dread != null)
                {
                    var tn = FindNode(regNode, StaticVariablesClass.RolesKeyGroupStr);
                    if (tn == null)
                    {
                        tn = DataClassFactory.GetNewNode(StaticVariablesClass.RolesKeyGroupStr);
                        regNode.Nodes.Add(tn);
                    }
                    else
                    {
                        tn.Text = "Roles";
                        tn.Nodes.Clear();
                    }

                    if (dread.HasRows)
                    {
                        int n = 0;
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        while (dread.Read())
                        {

                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.RolesKeyStr) as RoleClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            TreeNode tablen = DataClassFactory.GetNewNode(StaticVariablesClass.RolesKeyStr);

                            tn.Nodes.Add(tablen);
                            n++;
                        }
                        Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"RefreshRoles->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        tn.Text = $@"Roles ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->dread==null"));
                }
                con.Close();
                regNode.Expand();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }

        public void RefreshGenerators(TreeNode regNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var tn = FindNode(regNode, StaticVariablesClass.GeneratorsKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.GeneratorsKeyGroupStr);
                regNode.Nodes.Add(tn);
            }
            else
            {
                tn.Text = "Generators";
                tn.Nodes.Clear();
            }

            RefreshGeneratorsItems(DBReg, tn);
            regNode.Expand();
        }

        public void RefreshGeneratorsItems(DBRegistrationClass DBReg, TreeNode nd)
        {
            string _funcStr = $@"RefreshGeneratorsItems(DBReg={DBReg})";
            NotifiesClass.Instance.AddToINFO($@"Refresh Generators for {DBReg.Alias}", eMessageGranularity.few, true);
            string cmd = SQLStatementsClass.Instance.RefreshNonSystemGeneratorsItems(DBReg.Version);
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", ex));
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
                        Stopwatch sw = new Stopwatch();
                        sw.Start();

                        while (dread.Read())
                        {
                            var tc = DataClassFactory.GetDataClass(StaticVariablesClass.GeneratorsKeyStr) as GeneratorClass;
                            tc.Name = dread.GetValue(0).ToString().Trim();
                            tc.InitValue = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), 0);
                            tc.Description = dread.GetValue(3).ToString().Trim();

                            string cmd2 = $@"SELECT GEN_ID({tc.Name}, 0) FROM RDB$DATABASE;";

                            var con2 = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
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

                                    var tablen = DataClassFactory.GetNewNode(StaticVariablesClass.GeneratorsKeyStr, tc.Name, tc);
                                    nd.Nodes.Add(tablen);
                                    n++;
                                    dread2.Close();
                                }
                                con2.Close();
                            }
                        }
                        //Console.WriteLine($@"{_funcStr} used Time {n}:{sw.ElapsedMilliseconds}");
                        NotifiesClass.Instance.AddToINFO($@"RefreshGeneratorsItems->Rows {n} -> used time {sw.ElapsedMilliseconds} ms", eMessageGranularity.few, true);
                        sw.Stop();
                        nd.Text = $@"Generators ({n})";
                    }
                    dread.Close();
                }
                else
                {
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}", "dread==null"));

                }
                con.Close();
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->connection not open"));
            }
        }


        public TreeNode RefreshTable(TreeNode regNode, TreeNode tableNode)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            var fieldgroup_node = FindNode(tableNode, StaticVariablesClass.FieldsKeyGroupStr);
            var tc = tableNode.Tag as TableClass;
            NotifiesClass.Instance.AddToINFO($@"Refresh Table {DBReg.Alias}->{tc.Name}");
            var tcc = StaticDatabaseObjects.Instance().GetTableObject(DBReg, tc);
            tableNode.Tag = tcc;
            if (tableNode.Parent != null)
            {
                fieldgroup_node.Nodes.Clear();
                foreach (var fld in tc.Fields.Values)
                {
                    var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr, fld.Name, fld);
                    fieldgroup_node.Text = $@"Fields ({tc.Fields.Count})";
                    fieldgroup_node.Nodes.Add(field_node);
                }
            }

            RefreshForeignKeys4OneTable(regNode, tableNode);
            return fieldgroup_node;
        }

        /// <summary>
        /// Liest alle nicht sytsem tables ein
        /// Erzeugt alle Tree nodes
        /// Bastelt Tree zusammen
        /// </summary>
        /// <param name="DBRegx"></param>
        /// <param name="ndx"></param>
        /// <returns></returns>
        public TreeNode RefreshNonSystemTables(TreeNode ndx)
        {
            var nd = StaticTreeNodesClass.Instance().FindPrevDBNode(ndx);
            var DBReg = (DBRegistrationClass)nd.Tag;


            NotifiesClass.Instance.AddToINFO($@"Reading common tables for {DBReg.Alias}", eMessageGranularity.more, true);

            var tableList = StaticDatabaseObjects.Instance().GetAllNonSystemTableObjectsComplete(DBReg);
            if (tableList == null) return null;
            if (tableList.Count <= 0) return null;


            //Lege TableGroup Knoten an
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


            int n = 0;

            foreach (var tc in tableList.Values)
            {
                NotifiesClass.Instance.AddToINFO($@"Reading done {tc.Name}", eMessageGranularity.less, true);

                var table_node = DataClassFactory.GetNewNode(StaticVariablesClass.TablesKeyStr, tc.Name, tc);

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
                if (tc.primary_constraint != null) pk_cnt = 1;
                if (tc.ForeignKeys != null) fk_cnt = tc.ForeignKeys.Count;
                if (tc.uniques_constraints != null) uc_cnt = tc.uniques_constraints.Count;
                if (tc.notnulls_constraints != null) nn_cnt = tc.notnulls_constraints.Count;
                if (tc.primary_constraint != null) constraints_pk_cnt = 1;
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


                var table_field_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyGroupStr, $@"Fields ({fields_cnt})");
                var table_pk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr, $@"Primary Keys ({pk_cnt})");
                var table_fk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr, $@"Foreign Keys ({fk_cnt})");
                var constraint_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr, $@"Constraints ({(uc_cnt + nn_cnt + constraints_pk_cnt)})");
                var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr, $@"Dependencies ({(dependenciesTOTables_cnt + dependenciesFROMTables_cnt + dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt + dependenciesTOViews_cnt + dependenciesFROMViews_cnt + dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt)})");
                var dependencies_group_node_Tables = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr, $@"Dep Tables ({(dependenciesTOTables_cnt + dependenciesFROMTables_cnt)})");
                var dependencies_group_node_Triggers = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr, $@"Triggers ({(dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt)})");
                var dependencies_group_node_Views = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr, $@"Dep Views ({(dependenciesTOViews_cnt + dependenciesFROMViews_cnt)})");
                var dependencies_group_node_Procedures = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, $@"Procedures ({(dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt)})");
                var constraint_uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr, $@"Uniques ({uc_cnt})");
                var constraint_notnull_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr, $@"Not Nulls ({nn_cnt})");
                var constraint_check_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr, $@"Checks ({ck_cnt})");
                var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr, $@"Dependencies To ({dependenciesTOTables_cnt})");
                var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr, $@"Dependencies From ({dependenciesFROMTables_cnt})");
                var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr, $@"Dependencies To ({dependenciesTOTriggers_cnt})");
                var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr, $@"Dependencies From ({dependenciesFROMTriggers_cnt})");
                var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr, $@"Dependencies To ({dependenciesTOViews_cnt})");
                var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr, $@"Dependencies From ({dependenciesFROMViews_cnt})");
                var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr, $@"Dependencies To ({dependenciesTOProcedures_cnt})");
                var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, $@"Dependencies From ({dependenciesFROMProcedures_cnt})");
                var table_indices_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr, $@"Indices ({indices_cnt})");


                #endregion

                var constraint_pk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr, $@"Primary Keys ({constraints_pk_cnt})");
                var table_triggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr, $@"Triggers ({triggers_cnt})");

                foreach (var fld in tc.Fields.Values)
                {
                    TreeNode field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr, fld.Name, fld);

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
                    var pk_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint, tc);
                    table_pk_group_node.Text = $@"Primary Key (1,{tc.primary_constraint.FieldNames.Count})";
                    table_pk_group_node.Nodes.Add(pk_node);
                }
                if (tc.Indices != null)
                {
                    foreach (var inx in tc.Indices.Values)
                    {
                        var inx_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyStr, inx.Name, inx, tc);
                        table_indices_group_node.Nodes.Add(inx_node);
                    }
                }
                if (tc.uniques_constraints != null)
                {
                    foreach (var inx in tc.uniques_constraints.Values)
                    {
                        var u_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyStr, inx.Name, inx, tc);
                        constraint_uniques_group_node.Nodes.Add(u_node);
                    }
                }

                if (tc.notnulls_constraints != null)
                {
                    foreach (var inx in tc.notnulls_constraints.Values)
                    {
                        var nn_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyStr, inx.Name, inx, tc);
                        constraint_notnull_group_node.Nodes.Add(nn_node);
                    }
                }

                if (tc.check_constraints != null)
                {
                    foreach (var inx in tc.check_constraints.Values)
                    {
                        var nn_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyStr, inx.Name, inx, tc);
                        constraint_check_group_node.Nodes.Add(nn_node);
                    }
                }

                if (tc.primary_constraint != null)
                {
                    var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyStr, tc.primary_constraint.Name, tc.primary_constraint, tc);
                    constraint_pk_group_node.Nodes.Add(p_node);
                }

                if (tc.Triggers != null)
                {
                    foreach (var inx in tc.Triggers.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyStr, inx.Name, inx, tc);
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
                        p_node.ToolTipText = $@"{inx.Name} depent on procedure {inx.DependOnName}";
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

        public TreeNode RefreshSystemTables(TreeNode regNode)
        {
            var nd = StaticTreeNodesClass.Instance().FindPrevDBNode(regNode);
            var DBReg = (DBRegistrationClass)nd.Tag;

            TreeNode tn = FindNode(nd, StaticVariablesClass.SystemTablesKeyGroupStr);
            if (tn == null)
            {
                tn = DataClassFactory.GetNewNode(StaticVariablesClass.SystemTablesKeyGroupStr);
                nd.Nodes.Add(tn);
            }
            tn.Nodes.Clear();
            var vgc = new SystemTableGroupClass
            {
                Name = $@"TableGroup_{DBReg.Alias}"
            };
            tn.Tag = vgc;

            NotifiesClass.Instance.AddToINFO($@"Reading system tables for {DBReg.Alias}", eMessageGranularity.more, true);

            var tableList = StaticDatabaseObjects.Instance().GetAllSystemTableObjectsComplete(DBReg);

            if (tableList == null) return null;
            if (tableList.Count <= 0) return null;

            int n = 0;

            foreach (var tc in tableList.Values)
            {
                NotifiesClass.Instance.AddToINFO($@"Reading done {tc.Name}", eMessageGranularity.less, true);

                var table_node = DataClassFactory.GetNewNode(StaticVariablesClass.SystemTablesKeyStr, tc.Name, tc);

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


                var table_field_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyGroupStr, $@"Fields ({fields_cnt})");
                var table_pk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr, $@"Primary Keys ({pk_cnt})");
                var table_fk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyGroupStr, $@"Foreign Keys ({fk_cnt})");
                var constraint_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ConstraintsKeyGroupStr, $@"Constraints ({(uc_cnt + nn_cnt + constraints_pk_cnt)})");
                var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr, $@"Dependencies ({(dependenciesTOTables_cnt + dependenciesFROMTables_cnt + dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt + dependenciesTOViews_cnt + dependenciesFROMViews_cnt + dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt)})");
                var dependencies_group_node_Tables = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr, $@"Dep Tables ({(dependenciesTOTables_cnt + dependenciesFROMTables_cnt)})");
                var dependencies_group_node_Triggers = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr, $@"Triggers ({(dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt)})");
                var dependencies_group_node_Views = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr, $@"Dep Views ({(dependenciesTOViews_cnt + dependenciesFROMViews_cnt)})");
                var dependencies_group_node_Procedures = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, $@"Procedures ({(dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt)})");
                var constraint_uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr, $@"Uniques ({uc_cnt})");
                var constraint_notnull_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr, $@"Not Nulls ({nn_cnt})");
                var constraint_check_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr, $@"Checks ({ck_cnt})");
                var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr, $@"Dependencies To ({dependenciesTOTables_cnt})");
                var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr, $@"Dependencies From ({dependenciesFROMTables_cnt})");
                var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr, $@"Dependencies To ({dependenciesTOTriggers_cnt})");
                var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr, $@"Dependencies From ({dependenciesFROMTriggers_cnt})");
                var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr, $@"Dependencies To ({dependenciesTOViews_cnt})");
                var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromViewsKeyGroupStr, $@"Dependencies From ({dependenciesFROMViews_cnt})");
                var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr, $@"Dependencies To ({dependenciesTOProcedures_cnt})");
                var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, $@"Dependencies From ({dependenciesFROMProcedures_cnt})");
                var table_indices_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.IndicesKeyGroupStr, $@"Indices ({indices_cnt})");


                #endregion

                var constraint_pk_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.PrimaryKeyGroupStr, $@"Primary Keys ({constraints_pk_cnt})");
                var table_triggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.TriggersKeyGroupStr, $@"Triggers ({triggers_cnt})");

                foreach (var fld in tc.Fields.Values)
                {
                    TreeNode field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr, fld.Name, fld);

                    //OPT
                    table_field_group_node.Text = $@"Fields ({tc.Fields.Count})";
                    table_field_group_node.Name = StaticVariablesClass.FieldsKeyGroupStr;
                    table_field_group_node.Nodes.Add(field_node);
                }
                if (tc.ForeignKeys != null)
                {
                    foreach (var fk in tc.ForeignKeys.Values)
                    {
                        var fk_node = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, fk.Name, fk);

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
            tn.Text = $@"System Tables ({n})";
            return tn;
        }

        public TreeNode RefreshView(TreeNode regNode, TreeNode ndx)
        {
            var DBReg = (DBRegistrationClass)regNode.Tag;
            string _funcStr = $@"RefreshView(DBReg={DBReg})";
            TreeNode fieldgroup_node = FindNode(ndx, StaticVariablesClass.FieldsKeyGroupStr);
            if (ndx.Tag != null)
            {
                if (ndx.Tag.GetType().Name == "ViewClass")
                {

                    var tc = ndx.Tag as ViewClass;

                    NotifiesClass.Instance.AddToINFO($@"Refresh  view {DBReg.Alias}->{tc.Name}");

                    //Neuew View wird erzeugt und in Node geschrieben 
                    var vw = StaticDatabaseObjects.Instance().GetViewObject(DBReg, tc.Name);
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
                    NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->wrong object->{ndx.Tag.GetType().Name}"));
                }
            }
            else
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{this.GetType()}->{_funcStr}->wrong object->null"));
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
        public Dictionary<string, ViewClass> RefreshAllViews(TreeNode ndx)
        {
            TreeNode nd = StaticTreeNodesClass.Instance().FindPrevDBNode(ndx);
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


            NotifiesClass.Instance.AddToINFO($@"Reading views for {DBReg.Alias}", eMessageGranularity.more, true);


            var allviews = StaticDatabaseObjects.Instance().GetViewObjects(DBReg);
            if (allviews == null) return null;
            if (allviews.Count <= 0) return null;

            int n = 0;

            StaticDatabaseObjects.Instance().GetAllDependenciesOn(DBReg, allviews, eDependencies.VIEW);
            StaticDatabaseObjects.Instance().GetAllDepednenciesFROM(DBReg, allviews, eDependencies.VIEW);

            foreach (var tc in allviews.Values)
            {

                NotifiesClass.Instance.AddToINFO($@"Reading done {tc.Name}", eMessageGranularity.few, true);

                var view_node = DataClassFactory.GetNewNode(StaticVariablesClass.ViewsKeyStr, tc.Name, tc);

                #region fields

                int uc_cnt = 0;
                int nn_cnt = 0;
                int ck_cnt = 0;

                int dependenciesTOTables_cnt = (tc.DependenciesTO_Tables == null) ? 0 : tc.DependenciesTO_Tables.Count;
                int dependenciesFROMTables_cnt = (tc.DependenciesFROM_Tables == null) ? 0 : tc.DependenciesFROM_Tables.Count;
                int dependenciesTOTriggers_cnt = (tc.DependenciesTO_Triggers == null) ? 0 : tc.DependenciesTO_Triggers.Count;
                int dependenciesFROMTriggers_cnt = (tc.DependenciesFROM_Triggers == null) ? 0 : tc.DependenciesFROM_Triggers.Count;
                int dependenciesTOViews_cnt = (tc.DependenciesTO_Views == null) ? 0 : tc.DependenciesTO_Views.Count;
                int dependenciesFROMViews_cnt = (tc.DependenciesFROM_Views == null) ? 0 : tc.DependenciesFROM_Views.Count;
                int dependenciesTOProcedures_cnt = (tc.DependenciesTO_Procedures == null) ? 0 : tc.DependenciesTO_Procedures.Count;
                int dependenciesFROMProcedures_cnt = (tc.DependenciesFROM_Procedures == null) ? 0 : tc.DependenciesFROM_Procedures.Count;

                int fields_cnt = (tc.Fields == null) ? 0 : tc.Fields.Count;


                var fieldgroup_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyGroupStr, $@"Fields ({fields_cnt})");

                var dependencies_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesKeyGroupStr, $@"Dependencies ({dependenciesTOTables_cnt + dependenciesFROMTables_cnt + dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt + dependenciesTOViews_cnt + dependenciesFROMViews_cnt + dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt})");
                var dependencies_group_node_Tables = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTablesKeyGroupStr, $@"Tables ({dependenciesTOTables_cnt + dependenciesFROMTables_cnt})");
                var dependencies_group_node_Triggers = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesTriggersKeyGroupStr, $@"Triggers ({dependenciesTOTriggers_cnt + dependenciesFROMTriggers_cnt})");
                var dependencies_group_node_Views = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesViewsKeyGroupStr, $@"Views ({dependenciesTOViews_cnt + dependenciesFROMViews_cnt})");
                var dependencies_group_node_Procedures = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesProceduresKeyGroupStr, $@"Procedures ({dependenciesTOProcedures_cnt + dependenciesFROMProcedures_cnt})");
                var uniques_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.UniquesKeyGroupStr, $@"Uniques ({uc_cnt})");
                var nn_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.NotNullKeyGroupStr, $@"Not Null ({nn_cnt})");
                var ck_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.ChecksKeyGroupStr, $@"Checks ({ck_cnt})");
                var dependenciesTOTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyGroupStr, $@"Dependencies to tables({dependenciesTOTables_cnt})");
                var dependenciesFROMTables_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyGroupStr, $@"Dependencies from tables({dependenciesFROMTables_cnt})");
                var dependenciesTOTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyGroupStr, $@"Dependencies to triggers({dependenciesTOTriggers_cnt})");
                var dependenciesFROMTriggers_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyGroupStr, $@"Dependencies from triggers({dependenciesFROMTriggers_cnt})");
                var dependenciesTOViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr, $@"Dependencies to views({dependenciesTOViews_cnt})");
                var dependenciesFROMViews_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToViewsKeyGroupStr, $@"Dependencies from views({dependenciesFROMViews_cnt})");
                var dependenciesTOProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToProceduresKeyGroupStr, $@"Dependencies to procedures({dependenciesTOProcedures_cnt})");
                var dependenciesFROMProcedures_group_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromProceduresKeyGroupStr, $@"Dependencies from procedures({dependenciesFROMProcedures_cnt})");

                #endregion


                foreach (var fld in tc.Fields.Values)
                {
                    var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.ViewFieldsKeyStr, fld.Name, fld);

                    fieldgroup_node.Text = $@"Fields ({tc.Fields.Count})";

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
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTablesKeyStr, $@"{inx.Name} -> {inx.FieldName}", inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Tables != null)
                {
                    foreach (var inx in tc.DependenciesFROM_Tables.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTablesKeyStr, $@"{inx.Name} -> {inx.FieldName}", inx);
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

                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesToTriggersKeyStr, $@"{inx.Name} -> {inx.FieldName}", inx);
                        inx_node.Nodes.Add(p_node);
                    }
                }

                if (tc.DependenciesFROM_Triggers != null)
                {
                    foreach (var inx in tc.DependenciesFROM_Triggers.Values)
                    {
                        var p_node = DataClassFactory.GetNewNode(StaticVariablesClass.DependenciesFromTriggersKeyStr, $@"{inx.Name} -> {inx.FieldName}", inx);
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
                var field_node = DataClassFactory.GetNewNode(StaticVariablesClass.FieldsKeyStr, fld.Name, fld);
                nd.Text = $@"{name} ({obj.Count})";
                nd.Nodes.Add(field_node);
            }
        }

        public void UpdateTableNodes(TreeNode tableNode, TableClass TableObject, DBRegistrationClass dbReg)
        {
            UpdateTableFieldNodes(tableNode, TableObject, dbReg);
            UpdateTableForeignKeyNodes(tableNode, TableObject, dbReg);
            UpdateTableIndeciesNodes(tableNode, TableObject, dbReg);
            UpdateTableTriggerNodes(tableNode, TableObject, dbReg);
            UpdateNotNullConstraintNodes(tableNode, TableObject, dbReg);
        }

        public TreeNode UpdateTableFieldNodes(TreeNode tableNode, TableClass tcc, DBRegistrationClass dbReg)
        {
            var group_node = FindNode(tableNode, StaticVariablesClass.FieldsKeyGroupStr);
            if ((group_node != null) && (tcc.Fields != null))
            {
                tableNode.ForeColor = Color.Green;
                group_node.ForeColor = Color.Green;
                group_node.Text = $@"Fields ({tcc.Fields.Count})";

                NotifiesClass.Instance.AddToINFO($@"Reading field from table object {dbReg.Alias}->{tcc.Name}");


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
            if ((group_node != null) && (tcc.ForeignKeys != null))
            {
                tableNode.ForeColor = Color.Green;
                group_node.ForeColor = Color.Green;
                group_node.Text = $@"Foreign keys ({tcc.ForeignKeys.Count})";

                NotifiesClass.Instance.AddToINFO($@"Reading foreign keys from table object {dbReg.Alias}->{tcc.Name}");

                tableNode.Tag = tcc;
                if (tableNode.Parent != null)
                {
                    group_node.Nodes.Clear();
                    foreach (var nodesObject in tcc.ForeignKeys.Values)
                    {
                        var subnode = DataClassFactory.GetNewNode(StaticVariablesClass.ForeignKeyStr, nodesObject.Name, nodesObject);

                        subnode.ForeColor = nodesObject.IsActive ? StaticTreeNodesClass.Instance().Active : StaticTreeNodesClass.Instance().Inactive;
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

                NotifiesClass.Instance.AddToINFO($@"Reading indecies from table object {dbReg.Alias}->{tcc.Name}");

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

                NotifiesClass.Instance.AddToINFO($@"Reading triggers from table object {dbReg.Alias}->{tcc.Name}");

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
            for (int i = 0; i < tableNode.Nodes.Count; i++)
            {
                if (tableNode.Nodes[i].Name == StaticVariablesClass.ConstraintsKeyGroupStr)
                {
                    nd = tableNode.Nodes[i];
                    break;
                }
            }

            if (nd == null) return tableNode;

            var group_node = FindNode(nd, StaticVariablesClass.NotNullKeyGroupStr);
            if ((group_node == null) || (tcc.notnulls_constraints == null)) return tableNode;

            nd.ForeColor = Color.Green;
            tableNode.ForeColor = Color.Green;
            group_node.ForeColor = Color.Green;
            group_node.Text = $@"NotNulls ({tcc.notnulls_constraints.Count})";

            NotifiesClass.Instance.AddToINFO($@"Reading not null constraints from table object {dbReg.Alias}->{tcc.Name}");

            tableNode.Tag = tcc;
            if (tableNode.Parent != null) return tableNode;

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

        public List<ViewClass> GetViewObjectsFromNode(TreeNode nd)
        {
            List<ViewClass> table = new List<ViewClass>();
            if (nd != null)
            {
                foreach (TreeNode tc in nd.Nodes)
                {
                    table.Add((ViewClass)tc.Tag);
                }
            }
            return table;
        }


        public List<SystemTableClass> GetSystemTableObjectsFromNode(TreeNode nd)
        {
            List<SystemTableClass> table = new List<SystemTableClass>();
            if (nd != null)
            {
                foreach (TreeNode tc in nd.Nodes)
                {
                    table.Add((SystemTableClass)tc.Tag);
                }
            }
            return table;
        }

        public Dictionary<string, TableClass> GetDictionaryOfTableObjectsFromNode(TreeNode nd)
        {
            Dictionary<string, TableClass> table = new Dictionary<string, TableClass>();
            if (nd != null)
            {
                foreach (TreeNode tc in nd.Nodes)
                {
                    table.Add(((TableClass)tc.Tag).Name, (TableClass)tc.Tag);
                }
            }
            return table;
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


    }
}
