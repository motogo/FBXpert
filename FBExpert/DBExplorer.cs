using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert;
using FBExpert.DataClasses;
using FBXDesigns;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SonstForms;
using FBXpert.SQLStatements;
using FBXpert.SQLView;
using MessageFormLibrary;
using SEMessageBoxLibrary;
using SQLView;
using StateClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FBXpert
{
    public sealed partial class DbExplorerForm : Form
    {
        public NotifiesClass DbExlorerNotify = new NotifiesClass();               
        private List<TableClass> _actTables = new List<TableClass>();
        private Dictionary<string,ViewClass> _actViews = new Dictionary<string,ViewClass>();
        private List<SystemTableClass> _actSystemTables = new List<SystemTableClass>();
        
        
        private TreeNode _actRegNode;
        private TreeNode _tnSelected;
        private TreeNode _actTableNode;        
        private static DbExplorerForm _instance;
        
        public static DbExplorerForm Instance(Form parent)
        {
            if (_instance != null) return (_instance);
            _instance = new DbExplorerForm
            {
                MdiParent = parent
            };
            LanguageClass.Instance.RegisterChangeNotifiy(_instance.DBExplorer_OnRaiseLanguageChangedHandler);
            _instance.Show();
            return (_instance);
        }

        private void DBExplorer_OnRaiseLanguageChangedHandler(object sender, LanguageChangedEventArgs k)
        {
            LanguageChanged();
        }

        private void LanguageChanged()
        {
            gbDatabases.Text                        = LanguageClass.Instance.GetString("DATABASES");                        
            hsLoadDefinition.ToolTipText            = LanguageClass.Instance.GetString("LoadDatabaseDefinitions");        
            hsDatabaseDefinitionSave.ToolTipText    = LanguageClass.Instance.GetString("SaveDatabaseDefinitions");         
            
        }
        
        public static DbExplorerForm Instance()
        {            
            return (_instance);
        }

        private DbExplorerForm()
        {
            InitializeComponent();
            Dock = DockStyle.Left;
          
            DbExlorerNotify.ErrorGranularity = eMessageGranularity.never;
            DbExlorerNotify.Register4Info(NotifyInf_DBExplorer);           
            NotificationsForm.Instance().Show(Left + Width + 16, 64);            
        }
        
        public void GetOpenConnections()
        { 
            int cnt = 0;
            foreach(TreeNode tn in treeView1.Nodes)
            {
                DBRegistrationClass dbreg = (DBRegistrationClass) tn.Tag;
                if (dbreg.Active)
                {
                    string connectionString = ConnectionStrings.Instance.MakeConnectionString(dbreg);
                    ConnectionClass cc = new ConnectionClass(connectionString);
                    
                    cc.OpenConnection();
                    var reader = cc.ExecuteQuery("select count(*) from MON$ATTACHMENTS WHERE MON$SYSTEM_FLAG < 1",false);
                    if (reader != null)
                    {
                        if (reader.Read())
                        {
                            cnt += reader.GetInt32(0);
                        }
                        cc.Close();

                        tn.Text = dbreg.GetCaption(cnt);
                    }
                    else
                    {
                        tn.Text = dbreg.GetCaption();
                    }
                }
                else
                {

                    tn.Text = dbreg.GetCaption();
                }
            }
        }
        
        public string GetOpenConnections(DBRegistrationClass dbreg)
        {            
            if (dbreg.Active)
            {
                string connectionString = ConnectionStrings.Instance.MakeConnectionString(dbreg);
                ConnectionClass cc = new ConnectionClass(connectionString);

                cc.OpenConnection();
                var reader = cc.ExecuteQuery("select count(*) from MON$ATTACHMENTS WHERE MON$SYSTEM_FLAG < 1", false);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        int cnt = reader.GetInt32(0);
                        cc.Close();
                        return dbreg.GetCaption(cnt);
                    }
                }
            }
            return (dbreg.GetCaption());
        }

        public void SetCaption()
        {            
            Text = @"DBExplorer";
            toolStripStatusLabel1.Text = $@"{AppSettingsClass.Instance.PathSettings.DatabasesConfigPath}\{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}";
        }

        private void SetCmsForDatabase(bool open)
        {
            tsmiStatistics.Enabled          = open;
            tsmiCreateXMLDesign.Enabled     = open;
            tsmiDatabaseDesigner.Enabled    = open;
            tsmiReportDesigner.Enabled      = open;
        }

        private void NotifyInf_DBExplorer(object sender, MessageEventArgs k)
        {                   
            var typ = k.Key.GetType();
            if (typ == typeof(DBRegistrationClass))
            {
                RemakeDatabaseTree(k.Key as DBRegistrationClass);
            }
            else if (k.Key.ToString() == StaticVariablesClass.DatabaseConfigDataSaved)
            {
                if (!(k.Data is DBRegistrationClass dbReg)) return;
                if (dbReg.State == eRegState.create)
                {
                    ReloadAllDatabases();
                    return;
                }
                if(_actRegNode == null) return;
                _actRegNode.Text = dbReg.GetCaption();
                _actRegNode.Tag = dbReg;
                if(dbReg.Active) ReadDatabaseMetadata(_actRegNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ShowDatabaseStatistics)
            {
                if (!(k.Data is DBRegistrationClass dbReg)) return;
                var hif = new DatabaseStatisticsForm(FbXpertMainForm.Instance(), dbReg);
                hif.Show();
            }
            else if (k.Key.ToString() == NotifyInfoCodes.DataSaved)
            {
                MakeDatabaseTree(true);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadIndex)
            {
                StaticTreeClass.Instance().RefreshTableIndicesFromOneTable(_actRegNode, treeView1.SelectedNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadAllIndex)
            {
                StaticTreeClass.Instance().RefreshAllIndicies(_actRegNode, treeView1.SelectedNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadConstraits)
            {
                StaticTreeClass.Instance().RefreshConstraints(_actRegNode, treeView1.SelectedNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadAllConstraits)
            {
                StaticTreeClass.Instance().RefreshConstraintsFromTableNodes(_actRegNode, treeView1.SelectedNode);
            }
            else if (k.Key.ToString() ==  StaticVariablesClass.ReloadGenerators)
            {
                StaticTreeClass.Instance().RefreshGenerators(_actRegNode);
            }            
            else if (k.Key.ToString() == StaticVariablesClass.ReloadProcedures)
            {
                StaticTreeClass.Instance().RefreshProcedures(_actRegNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadFunctions)
            {
                StaticTreeClass.Instance().RefreshInternalFunctions(_actRegNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadDomains)
            {
                StaticTreeClass.Instance().RefreshDomains(_actRegNode);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadViews)
            {
                var regNode = StaticTreeClass.Instance().FindPrevDBNode(_tnSelected);
                if (regNode != null)
                {
                    var tn = k.Data as TreeNode;
                    StaticTreeClass.Instance().RefreshView(regNode, tn);
                }
                else if(_actRegNode != null)
                {
                    StaticTreeClass.Instance().RefreshAllViews(_actRegNode);
                }
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadAllViews)
            {
                var nd = StaticTreeClass.Instance().FindPrevDBNode(_tnSelected);
                if (nd != null)
                {
                    
                    NotificationsForm.Instance().Show(Width + 4, 40);
                    StaticTreeClass.Instance().RefreshAllViews(nd);
                }
                NotificationsForm.Instance().Hide();
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadTable)
            {                
                var nd = StaticTreeClass.Instance().FindPrevTableNode(_tnSelected);
                if(nd != null)
                {
                    StaticTreeClass.Instance().RefreshTable(_actRegNode, nd);
                }
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadAllTables)
            {
                var nd = StaticTreeClass.Instance().FindPrevTableGroupNode(_tnSelected);
                if (nd != null)
                {
                    NotificationsForm.Instance().Show();
                    StaticTreeClass.Instance().RefreshNonSystemTables(nd);
                }
                NotificationsForm.Instance().Hide();
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadForeignKeys)
            {                
                StaticTreeClass.Instance().RefreshForeignKeys4OneTable(_actRegNode, _tnSelected);
            }
            else if (k.Key.ToString() == StaticVariablesClass.ReloadAllForeignKeys)
            {
                StaticTreeClass.Instance().RefreshForeignKeysFromTableNodes(_actRegNode, _tnSelected);
            }
        }

        public bool ReadDatabaseMetadata(TreeNode regNode)
        {
            regNode.ToolTipText = "test";
            Application.DoEvents();
            var dbReg = (DBRegistrationClass)regNode.Tag;

            try
            {
                regNode.ToolTipText = dbReg.GetFullDatabasePath();

                NotificationsForm.Instance().SetTitle(DevelopmentClass.Instance().GetDBInfo(dbReg, "Notifications "));
                NotificationsForm.Instance().SetMDIForm(MdiParent);
                NotificationsForm.Instance().Show(Left + Width + 16, 64);
            
                _actRegNode = regNode;
                _actTables.Clear();
                _actSystemTables.Clear();
                NotifiesClass.Instance.AddToINFO($@"Open Database {dbReg.Alias}");
                           
                var tb = StaticTreeClass.Instance().RefreshNonSystemTables(regNode);
                _actViews = StaticTreeClass.Instance().RefreshAllViews(regNode);

                if (tb != null)
                {
                    _actTables = StaticTreeClass.Instance().GetTableObjectsFromNode(tb);
                    if (_actTables != null)
                    {
                        StaticTreeClass.Instance().RefreshDomains(regNode);
                        StaticTreeClass.Instance().RefreshPrimaryKeysFromTableNodes(regNode, null);
                        StaticTreeClass.Instance().RefreshForeignKeysFromTableNodes(regNode, null);
                        StaticTreeClass.Instance().RefreshConstraintsFromTableNodes(regNode, null);
                        StaticTreeClass.Instance().RefreshTriggersFromTableNodes(regNode, null);
                        StaticTreeClass.Instance().RefreshAllIndicies(regNode, null);
                        StaticTreeClass.Instance().RefreshDependenciesFromTableNodes(regNode);
                        StaticTreeClass.Instance().RefreshProcedures(regNode);
                        StaticTreeClass.Instance().RefreshInternalFunctions(regNode);
                        StaticTreeClass.Instance().RefreshUserDefinedFunctions(regNode);
                        StaticTreeClass.Instance().RefreshGenerators(regNode);
                        StaticTreeClass.Instance().RefreshRoles(regNode);
                    }
                }

                var tbs = StaticTreeClass.Instance().RefreshSystemTables(regNode);
                if (tbs != null)
                {
                    _actSystemTables = StaticTreeClass.Instance().GetSystemTableObjectsFromNode(tbs);
                    if (_actSystemTables != null)
                    {
                        StaticTreeClass.Instance().RefreshSystemDomains(regNode);
                        StaticTreeClass.Instance().RefreshPrimaryKeysFromSystemTableNodes(regNode, null);
                        StaticTreeClass.Instance().RefreshSystemTriggersFromTableNodes(regNode, null);
                        StaticTreeClass.Instance().RefreshAllSystemIndicies(regNode, null);
                    }
                }

                NotifiesClass.Instance.AddToINFO($@"Database {dbReg.Alias} opend !!!");

                dbReg.Active = true;
                regNode.Tag = dbReg;              
                SetCmsForDatabase(true);
                regNode.Text = GetOpenConnections(dbReg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            return true;                           
        }
                        
        public void MakeDatabaseTree(bool openactive)
        {
            NotifiesClass.Instance.AddToINFO("Load database configurations...", "KEY");
            SetTreeLanguageDefaults();

            treeView1.Nodes.Clear();
            tsmiCreateXMLDesign.Enabled = false;           
            treeView1.BeginUpdate();
            foreach (var dbr in DatabaseDefinitions.Instance.Databases)
            {
                var nd = DataClassFactory.GetNewNode(StaticVariablesClass.DatabaseKeyStr, dbr.Alias,dbr);
                dbr.SetNode(nd);             

                if ((dbr.Active)&&(openactive))
                {
                    nd.ImageIndex = (int)eImageIndex.DATABASE_ACTIVE;
                    ReadDatabaseMetadata(nd);
                }
                else
                {
                    nd.ImageIndex = (int)eImageIndex.DATABASE_INACTIVE;
                }
                nd.ToolTipText = dbr.GetFullDatabasePath();
                treeView1.Nodes.Add(nd);                
            }
            NotifiesClass.Instance.AddToINFO("Database configurations loaded", "KEY");
            
            treeView1.EndUpdate();
            treeView1.Refresh();
            Application.DoEvents();
        }

        public void OpenActiveDatabases()
        {
            try
            {
                DbExlorerNotify.Notify.RaiseInfo(Name+"->OpenActiveDatabases", StaticVariablesClass.StartLoadDatabases);
                tsmiCreateXMLDesign.Enabled = false;
                SetCmsForDatabase(false);
                treeView1.BeginUpdate();
                foreach (TreeNode nd in treeView1.Nodes)
                {
                    var dbr = (DBRegistrationClass) nd.Tag;
                    if (dbr == null || !dbr.Active) continue;
                    ReadDatabaseMetadata(nd);
                }
                treeView1.EndUpdate();
                DbExlorerNotify.Notify.RaiseInfo(Name+"->OpenActiveDatabases", StaticVariablesClass.EndLoadDatabases);
            }
            catch
            {
                return;
            }
        }

        public void RemakeDatabaseTree(DBRegistrationClass dbr)
        {
            SetCmsForDatabase(false);
            if (dbr.State == eRegState.create)
            {                
                var nd = DataClassFactory.GetNewNode(StaticVariablesClass.DatabaseKeyStr,dbr.Alias,dbr);        
                dbr.SetNode(nd);
                nd.ImageIndex = (dbr.Active) ?  (int) eImageIndex.DATABASE_ACTIVE :  (int) eImageIndex.DATABASE_INACTIVE;
                
                treeView1.Nodes.Add(nd);
                if (dbr.Active)
                {
                    ReadDatabaseMetadata(nd);
                }
            }
            else
            {
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    var tn = treeView1.Nodes[i];
                    if ((tn == null) || (tn.Level != 0) || (tn.Tag == null)) continue;

                    var drc = (DBRegistrationClass)tn.Tag;
                    if (drc.Position != dbr.Position) continue;
                    tn.Text = dbr.Alias;
                    tn.Tag = dbr;
                    if (dbr.Active)
                    {
                        ReadDatabaseMetadata(tn);
                    }
                    else
                    {
                        CloseDatabase(tn);
                    }
                }
            }
        }
      
        private void DBExplorer_Load(object sender, EventArgs e)
        {        
            Dock = DockStyle.Left;
            Application.DoEvents();
            NotificationsForm.Instance().SetLeft = Width + 16;
            pnlUpper.Select();
            ExtensionMethods.DoubleBuffered(treeView1,true);
        }

        private void ToolStripTextBox_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripTextBox) sender).Enabled = true;            
        }

        private void ToolStripTextBox_MouseEnter(object sender, EventArgs e)
        {
           ((ToolStripTextBox) sender).Enabled = false;            
        }
        
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (_tnSelected == null) return;
            if(e.Button != MouseButtons.Left) return;
            
            switch (_tnSelected.Level)
            {
                case 0:
                    ebene0dblClick(_tnSelected);
                    break;
                case 1:
                    //Console.WriteLine();
                    break;
                case 2:
                    ebene2dblClick(_tnSelected);
                    break;
                case 3:
                    ebene3dblClick(_tnSelected);
                    break;                   
                case 4:
                    ebene4dblClick(_tnSelected);
                    break;                
                case 5:
                    ebene5dblClick(_tnSelected);
                    break;
            }
        }

        private void ebene0dblClick(TreeNode tn)
        {
            if (tn?.Tag == null) return;
                    
            var drctag = (DBRegistrationClass) tn.Tag;
            FbXpertMainForm.Instance().ActRegistrationObject = drctag;
            if (drctag.Active)
            {
                CloseDatabase(tn);
            }
            else
            {
                ReadDatabaseMetadata(tn);
            }
        }

        private void ebene2dblClick(TreeNode tn)
        {
             if(tn?.Parent?.Parent?.Tag == null) return;

             var drc = (DBRegistrationClass)tn.Parent.Parent.Tag;
             FbXpertMainForm.Instance().ActRegistrationObject = drc;                    
             if ((drc == null) || (tn.Tag == null) || (string.IsNullOrEmpty(tn.Text))) return;
             this.Cursor = Cursors.WaitCursor;

             var tnn = tn.Tag.GetType();
             if (tnn == typeof(ViewClass))
             {
                
                var tmf = new VIEWManageForm(MdiParent, drc, tn);
                    tmf.GetData = true;
                    tmf.SetAutocompeteObjects(_actTables);
                    tmf.Show();
                
            }
             else if (tnn == typeof(TableClass))
             {                        
                 Cursor = Cursors.WaitCursor;
                 Application.DoEvents();
                 var tmf = new TABLEManageForm(MdiParent, drc, tn, _actTables);
                 tmf.SetMaxRows(0);
                 tmf.SetOrder(eSort.DESC);
                 tmf.GetData = true;
                 tmf.SetAutocompeteObjects(_actTables,null);
                 tmf.Show();
                 Cursor = Cursors.Default;
             }
             else if (tnn == typeof(SystemTableClass))
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new TABLEManageForm(MdiParent, drc, tn, _actTables);
                
                tmf.GetData = true;
                tmf.SetMaxRows(0);
                tmf.SetOrder(eSort.ASC);
                tmf.SetAutocompeteObjects(null, _actSystemTables);
                tmf.Show();
                
                Cursor = Cursors.Default;
            }
            else if (tnn == typeof(GeneratorClass))
             {
                 var tmf = new GeneratorForm(MdiParent, drc, tn, cmsGenerator)
                 {
                     BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                 };
                 tmf.Show();
             }
            else if (tnn == typeof(ForeignKeyClass))
            {  
                ForeignKeyClass fkc = (ForeignKeyClass)_tnSelected.Tag;  
                var tmf = new ForeignKeyForm(MdiParent, drc, _actTables, fkc.SourceTableName, fkc, -1)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();
            }
            else if (tnn == typeof(PrimaryKeyClass))
            {
                PrimaryKeyClass fkc = (PrimaryKeyClass)_tnSelected.Tag;
                var fktable = _actTables.Find(fc => fc.primary_constraint?.Name == _tnSelected.Text);
                var tmf = new PrimaryKeyForm(MdiParent, _actTables, fktable, drc)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();
            }
            else if (tnn == typeof(ProcedureClass))
             {
                 var tmf = new ProcedureForm(MdiParent, drc,_actTables, tn, cmsProcedure,EditStateClass.eBearbeiten.eEdit);
                 
                 tmf.Show();
             }
             else if (tnn == typeof(FunctionClass))
             {
                 var tmf = new FunctionForm(MdiParent, drc,_actTables, tn, cmsFunctions,EditStateClass.eBearbeiten.eEdit);
                 
                 tmf.Show();
             }
             else if (tnn == typeof(UserDefinedFunctionClass))
             {
                 var tmf = new UserDefinedFunctionForm(MdiParent, drc, tn, cmsUserDefinedFunctions,EditStateClass.eBearbeiten.eEdit);

                 tmf.Show();
             }
             else if (tnn == typeof(TriggerClass))
             {                        
                 var tmf = new TriggerForm(MdiParent, drc, tn, cmsTriggers, _actTables)
                 {
                     BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                 };
                 tmf.Show();
             }
             else if (tnn == typeof(DomainClass))
             {                        
                 var tmf = new DomainForm(MdiParent, drc, _actTables, tn, cmsDomains)
                 {
                     BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                 };
                 tmf.Show();
             }
             else if (tnn == typeof(IndexClass))
             {
                 var tff = new IndexForm(MdiParent,(IndexClass) tn.Tag, drc, _actTables);
                 tff.Show(); 
             }
             this.Cursor = Cursors.Default;
        }

        private void ebene3dblClick(TreeNode tn)
        {
            if(tn?.Parent?.Parent?.Parent?.Tag == null) return;
            var drc = (DBRegistrationClass)tn.Parent.Parent.Parent.Tag;
            FbXpertMainForm.Instance().ActRegistrationObject = drc;                    
            if ((drc == null) || (tn.Tag == null) || (string.IsNullOrEmpty(tn.Text))) return;

            var tnn = tn.Tag.GetType();
            if (tnn == typeof(PrimaryKeyClass))
            {                
                var fktable = _actTables.Find(fc => fc.primary_constraint?.Name == tn.Text);            
                var cf = new PrimaryKeyForm(MdiParent, _actTables, fktable,  drc)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                cf.Show();                            
            }
            else if (tnn == typeof(NotNullsClass))
            {    
                var obj = _tnSelected.Tag as NotNullsClass;               
                var cf = new NotNullForm(MdiParent, drc, _actTables, obj, cmsConstrainsGroup,cmsConstraints)              
                {
                   BearbeitenMode = EditStateClass.eBearbeiten.eEdit 
                };
                cf.Show();  
            }            
        }
        
        private void ebene4dblClick(TreeNode tn)
        {
            if(tn?.Parent?.Parent?.Parent?.Parent?.Tag == null) return;
            var drc = (DBRegistrationClass)tn.Parent.Parent.Parent.Parent.Tag;
            FbXpertMainForm.Instance().ActRegistrationObject = drc;                    
            if ((drc == null) || (tn.Tag == null) || (string.IsNullOrEmpty(tn.Text))) return;

            var tnn4 = tn.Tag.GetType();
            if (tnn4 == typeof(TriggerClass))
            {                        
                var tmf = new TriggerForm(MdiParent, drc, tn, cmsTriggers, _actTables)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();
            }
            else if (tnn4 == typeof(DomainClass))
            {                        
                var tmf = new DomainForm(MdiParent, drc, _actTables, tn, cmsDomains)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();
            }
            else if (tnn4 == typeof(IndexClass))
            {
                var tff = new IndexForm(MdiParent, (IndexClass) tn.Tag, drc,_actTables);
                
                tff.Show(); 
            }
            else if (tnn4 == typeof(PrimaryKeyClass))
            {                        
                var fktable = _actTables.Find(fc => fc.primary_constraint?.Name == tn.Text);                    
                var cf = new PrimaryKeyForm(MdiParent, _actTables, fktable,  drc)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                cf.Show();                            
            }
            else if (tnn4 == typeof(TableFieldClass))
            {
               var table = _actTables.Find(fc => fc.Name == tn.Parent.Parent.Text);  
               if(table != null)
               {
                   table.Fields.TryGetValue(tn.Text,out TableFieldClass field);
                   if (field == null) return;            
                   var tff = new FieldForm(drc,FbXpertMainForm.Instance(), _tnSelected.Parent.Parent, field, null,EditStateClass.eBearbeiten.eEdit);
                   tff.SetDataBearbeitenMode(StateClasses.EditStateClass.eBearbeiten.eEdit);
                   tff.Show();
               }
            }
        }
        
        private void ebene5dblClick(TreeNode tn)
        {
            if(tn?.Parent?.Parent?.Parent?.Parent?.Parent?.Tag == null) return;
            var drc = (DBRegistrationClass)tn.Parent.Parent.Parent.Parent.Parent.Tag;
            FbXpertMainForm.Instance().ActRegistrationObject = drc;                    
            if ((drc == null) || (tn.Tag == null) || (string.IsNullOrEmpty(tn.Text))) return;

            var tnn = tn.Tag.GetType();
            if (tnn == typeof(TriggerClass))
            {                        
                var tmf = new TriggerForm(MdiParent, drc, tn, cmsTriggers, _actTables)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();
            }
            else if (tnn == typeof(DomainClass))
            {                        
                var tmf = new DomainForm(MdiParent, drc,  _actTables,tn, cmsDomains)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();
            }
            else if (tnn == typeof(IndexClass))
            {
                var tff = new IndexForm(MdiParent, (IndexClass) tn.Tag, drc, _actTables);                
                tff.Show(); 
            }
            else if (tnn == typeof(PrimaryKeyClass))
            {                        
                var fktable = _actTables.Find(fc => fc.primary_constraint?.Name == tn.Text);                    
                var cf = new PrimaryKeyForm(MdiParent, _actTables, fktable,  drc)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                cf.Show();                            
            }
            else if (tnn == typeof(NotNullsClass))
            {     
                var obj = _tnSelected.Tag as NotNullsClass;                
                var cf = new NotNullForm(MdiParent, drc, _actTables, obj, cmsConstrainsGroup,cmsConstraints)               
                {
                   BearbeitenMode = EditStateClass.eBearbeiten.eEdit 
                };
                cf.Show();  
            }
        }

        private void DBExplorer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!FbXpertMainForm.FormOnClosing)
            {
                FbXpertMainForm.Instance().Close();
            }
        }
               
        public void SetUiDatabaseClosed()
        {
            tsmiCreateXMLDesign.Enabled = false;
            tsmiClose.Enabled = false;
            tsmiOpen.Enabled = true;
        }

        public void SetUiDatabaseOpend()
        {
            tsmiCreateXMLDesign.Enabled = true;
            tsmiClose.Enabled = true;
            tsmiOpen.Enabled = false;
        }

        public void CloseDatabase(TreeNode tn)
        {
            tn.Nodes.Clear();
            SetCmsForDatabase(false);
            var drc = (DBRegistrationClass)tn.Tag;
            drc.Active = false;
            tn.Tag = drc;
            tn.Text = drc.GetCaption();
            ConnectionPoolClass.Instance.CloseAllConnections();
        }
       
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _tnSelected = e.Node;
            if (e.Node?.Tag == null) return;
            int cmsLeft = this.Left+this.Width+4;
            int cmsTop  = Cursor.Position.Y;
            var tnn = e.Node.Tag.GetType();
            var t = StaticTreeClass.Instance().FindPrevDBNode(e.Node);

            if (tnn == typeof(DBRegistrationClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var drc = (DBRegistrationClass)e.Node.Tag;
                FbXpertMainForm.Instance().ActRegistrationObject = drc;
                
                if (drc.Active)
                {
                    SetUiDatabaseOpend();
                }
                else
                {
                    SetUiDatabaseClosed();
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsDatabase.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ViewGroupClass))
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsViewGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(TriggerClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (TriggerClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActTriggerObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    cmsTriggers.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(TriggerGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsTriggerGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(GeneratorClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (GeneratorClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActGeneratorObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsGenerator.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(GeneratorGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsGeneratorsGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(FunctionClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (FunctionClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActFunctionObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsFunctions.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(FunctionGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsFunctionGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(UserDefinedFunctionClass))
            {                                
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsUserDefinedFunctions.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(UserDefinedFunctionGroupClass))
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    cmsUserDefinedFunctionGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ForeignKeyClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (ForeignKeyClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActForeignkeyObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsForeignKeys.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ForeignKeyGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr); 
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsForeignKeysGroup.Show(cmsLeft,cmsTop);
                }
            }                    
            else if (tnn == typeof(ProcedureClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (ProcedureClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActProcedureObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsProcedure.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ProceduresGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsProcedureGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(IndexClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (IndexClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActIndexObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsIndices.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(IndexGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsIndicedGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(DomainClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (DomainClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActDomainObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsDomains.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(DomainGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);   
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsDomainsGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ConstraintsClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (ConstraintsClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActConstraintsObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsConstraints.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ConstraintsGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsConstrainsGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(RoleClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                var vc = (RoleClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActRoleObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsRoles.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(RoleGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsRolesGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ViewGroupClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);      
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsViewGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(ViewClass))
            {    
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);      
                var vc = (ViewClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActViewObject = vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsView.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(TableClass))
            {                
                SetActTableNode(t, StaticVariablesClass.CommonTablesKeyGroupStr);         
                var tc = (TableClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActTableObject = tc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsTable.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(TableFieldClass))
            {
                SetActTableNode(t, StaticVariablesClass.FieldsKeyStr);
                var vc = (TableFieldClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActTableFieldObject = vc;
                FbXpertMainForm.Instance().ActFieldObject = (FieldClass) vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsFields.Show(cmsLeft, cmsTop);
                }
            }
            else if (tnn == typeof(ViewFieldClass))
            {
                SetActTableNode(t, StaticVariablesClass.FieldsKeyStr);
                var vc = (ViewFieldClass)_tnSelected.Tag;
                FbXpertMainForm.Instance().ActViewFieldObject = vc;
                FbXpertMainForm.Instance().ActFieldObject = (FieldClass)vc;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    cmsFields.Show(cmsLeft, cmsTop);
                }
            }
            else if (tnn == typeof(TableGroupClass))
            {                                
                SetActTableNode(_tnSelected.Parent, StaticVariablesClass.CommonTablesKeyGroupStr);    
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsTableGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(PrimaryKeyClass))
            {                            
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsPrimaryKeys.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(PrimaryKeyGroupClass))
            {                            
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsPrimaryKeyGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(SystemTableClass))
            {                                                 
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsSystemTable.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(SystemTableGroupClass))
            {                                                
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsSystemTableGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(UniquesClass))
            {                                
                
            }
            else if (tnn == typeof(UniquesGroupClass))
            {                                
                
            }
            else if (tnn == typeof(ChecksClass))
            {                                
                
            }
            else if (tnn == typeof(ChecksGroupClass))
            {                                
                
            }
            else if (tnn == typeof(NotNullsClass))
            {                                
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsNotNulls.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(NotNullsGroupClass))
            {                                
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                  cmsNotNullsGroup.Show(cmsLeft,cmsTop);
                }
            }
            else if (tnn == typeof(SystemTableGroupClass))
            {                                                
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                   cmsSystemTableGroup.Show(cmsLeft,cmsTop);
                }
            }
            
            if (!DatabaseDefinitions.Instance.IsRegistration(e.Node))
            {
               _actRegNode = StaticTreeClass.Instance().FindPrevDBNode(_tnSelected);
            }
        }

        public List<TableClass> GetActTableNode(TreeNode parent, string keyStr)
        {            
            var newActTableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(parent, keyStr);
            return StaticTreeClass.Instance().GetTableObjectsFromNode(newActTableNode);
        }
        public List<ViewClass> GetActViewNode(TreeNode parent, string keyStr)
        {
            var newActTableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(parent, keyStr);
            return StaticTreeClass.Instance().GetViewObjectsFromNode(newActTableNode);
        }

        public void SetActTableNode(TreeNode parent, string keyStr)
        {
            var newActTableNode = StaticTreeClass.Instance().FindFirstNodeInAllNodes(parent, keyStr);
            if (_actTableNode == newActTableNode) return;
            _actTables = StaticTreeClass.Instance().GetTableObjectsFromNode(newActTableNode);
            _actTableNode = newActTableNode;
        }

        private void SqlExplorer(DBRegistrationClass drc, List<TableClass> actTables)
        {                                   
            var sf = new SQLViewForm1(drc, actTables, FbXpertMainForm.Instance(), FbXpertMainForm.Instance().AppDesign, FbXpertMainForm.Instance().DevelopDesign);                      
            sf.Show();            
        }

        private void ExperienceInfos(DBRegistrationClass drc, List<TableClass> actTables)
        {
            var ex = new ExperienceInfoForm(drc,actTables, FbXpertMainForm.Instance(), FbXpertMainForm.Instance().AppDesign, FbXpertMainForm.Instance().DevelopDesign);
            ex.Show();
        }

        private void cmsMainGroupItems_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {            
            var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1.SelectedNode);
            if (tnReg == null) return;
            if (!(tnReg.Tag is DBRegistrationClass dbReg)) return;
            
            if (e.ClickedItem == tsmiClose)
            {
                cmsDatabase.Close();
                if (treeView1.SelectedNode == null) return;
                CloseDatabase(tnReg);
                DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
            }
            else if (e.ClickedItem == tsmiCloseAll)
            {
                cmsDatabase.Close();
                foreach (TreeNode nd in treeView1.Nodes)
                {
                    if (DatabaseDefinitions.Instance.IsRegistration(nd))
                    {
                        CloseDatabase(nd);
                    }
                }
                DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
            }
            else if (e.ClickedItem == tsmiReopenDatabase)
            {
                cmsDatabase.Close();
                if (treeView1.SelectedNode == null) return;

                CloseDatabase(tnReg);
                Thread.Sleep(1000);
                Application.DoEvents();
                ReadDatabaseMetadata(tnReg);
                DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
            }
            else if (e.ClickedItem == tsmiOpenAll)
            {
                cmsDatabase.Close();
                foreach (TreeNode nd in treeView1.Nodes)
                {
                    if (DatabaseDefinitions.Instance.IsRegistration(nd))
                    {
                        Application.DoEvents();
                        ReadDatabaseMetadata(nd);
                    }
                }
                DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
            }
            else if (e.ClickedItem == tsmiOpen)
            {
                cmsDatabase.Close();
                Application.DoEvents();
                ReadDatabaseMetadata(tnReg);
                DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
                
            }
            else if (e.ClickedItem == tsmiStatistics)
            {
                DbExlorerNotify.Notify.RaiseInfo("DBExplorer", "SHOW_DATABASE_STATISTICS", dbReg);
            }
            else if (e.ClickedItem == tsmiCreateXMLDesign)
            {
                cmsDatabase.Close();
                var xml = new XmlDesignForm(FbXpertMainForm.Instance(), dbReg);
                xml.Show();
            }
            else if (e.ClickedItem == tsmiReplicationDesigner)
            {
                cmsDatabase.Close();
                var frm = new ReplicationDesignForm(FbXpertMainForm.Instance(), _actTables, dbReg);
                frm.Show();
            }
            else if (e.ClickedItem == tsmiCompareDatabase)
            {
                cmsDatabase.Close();
                var cd = new DatabaseCompareFrom(FbXpertMainForm.Instance(), dbReg);
                cd.Show();
            }
            else if (e.ClickedItem == tsmiEditDatabaseConfig)
            {
                cmsDatabase.Close();
                var cfg = new DatabaseConfigForm(FbXpertMainForm.Instance(), dbReg, treeView1, dbReg.Position, EditStateClass.eBearbeiten.eEdit);
                cfg.Show();
            }
            else if (e.ClickedItem == tsmiNewDatabaseConfig)
            {
                cmsDatabase.Close();
                var cfg = new DatabaseConfigForm(FbXpertMainForm.Instance(), null, treeView1, dbReg.Position, EditStateClass.eBearbeiten.eInsert);
                cfg.Show();
            }
            else if (e.ClickedItem == tsmiCloneDatabaseConfiguration)
            {
                cmsDatabase.Close();
                var drc = dbReg.Clone();
                drc.Alias = $@"{drc.Alias}_clone{(DateTime.Now.Ticks / 10000)}";

                var cfg = new DatabaseConfigForm(FbXpertMainForm.Instance(), drc, treeView1, drc.Position, EditStateClass.eBearbeiten.eInsert);
                cfg.Show();
            }
            else if (e.ClickedItem == tsmiSQLScriptExplorer)
            {
                cmsDatabase.Close();
                var dbm = new ScriptingForm(dbReg);
                cmsDatabase.Close();
                dbm.Show();
            }
            else if (e.ClickedItem == tsmiSQLExplorer)
            {
                cmsDatabase.Close();
                SqlExplorer(dbReg, _actTables);
            }
            else if (e.ClickedItem == tsmiExperienceInfos)
            {
                cmsDatabase.Close();
                ExperienceInfos(dbReg, _actTables);
            }
            else if (e.ClickedItem == tsmiActiveConnections)
            {
                cmsDatabase.Close();
                var dbm = new DBMonitoringForm(FbXpertMainForm.Instance(), dbReg);
                dbm.Show();
            }
            else if (e.ClickedItem == tsminUserManagement)
            {
                cmsDatabase.Close();
                var dbm = new DBUserManagementForm(FbXpertMainForm.Instance(), dbReg);
                dbm.Show();
            }
            else if (e.ClickedItem == tsmiBackUp)
            {
                cmsDatabase.Close();
                var bf = new BackupForm(FbXpertMainForm.Instance(), dbReg);
                bf.Show();
            }
            else if (e.ClickedItem == tsmiDeleteDatabaseRegistration)
            {
                cmsDatabase.Close();
                CloseContextMenuString(sender);

                object[] p = { dbReg.Alias, dbReg.Server, dbReg.DatabasePath, Environment.NewLine };
                if (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DeleteDatabaseRegistration", "DoYouWantDeleteDatabaseRegistration", FormStartPosition.CenterScreen,
                        SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation, null, p) != SEDialogResult.Yes) return;

                CloseDatabase(treeView1.SelectedNode);
                treeView1.SelectedNode.Tag = null;
                treeView1.SelectedNode.Remove();
                DatabaseDefinitions.Instance.Rebuild(treeView1);
                DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
            }
            else if (e.ClickedItem == tsmiDatabaseDesigner)
            {
                cmsDatabase.Close();
                _actTables =  GetActTableNode(tnReg, StaticVariablesClass.CommonTablesKeyGroupStr);
                var actViews =  GetActViewNode(tnReg, StaticVariablesClass.ViewsKeyGroupStr);

                Dictionary<string, TableClass> tab = new System.Collections.Generic.Dictionary<string, TableClass>();
                foreach (var table in _actTables)
                {
                    tab.Add(table.Name, table);
                }
                _actViews.Clear();
                foreach (var table in actViews)
                {
                    _actViews.Add(table.Name, table);
                }

                var dbd = new DatabaseDesignForm();
                dbd.SetDatas(dbReg, tab, _actViews);
                dbd.SetParent(MdiParent);
                dbd.Show();
            }
            else if (e.ClickedItem == tsmiReportDesigner)
            {
                cmsDatabase.Close();
                var rdf = new ReportDesignForm(FbXpertMainForm.Instance(), dbReg, NotifiesClass.Instance);
                rdf.Show();
            }
            else if (e.ClickedItem == tsmiExportData)
            {
                cmsDatabase.Close();
                if (string.IsNullOrEmpty(_tnSelected.Text)) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new EXPORTDataForm(MdiParent, dbReg);
                tmf.Show();
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiImportData)
            {
                cmsDatabase.Close();
                if (string.IsNullOrEmpty(_tnSelected.Text)) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new IMPORTDataForm(MdiParent, dbReg);
                tmf.Show();
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiMoveUp)
            {
                DatabaseDefinitions.Instance.MoveUp(treeView1);
            }
            else if (e.ClickedItem == tsmiMoveDown)
            {
                DatabaseDefinitions.Instance.MoveDown(treeView1);
            }
            else if (e.ClickedItem == tsmiIDBBinaries)
            {
                cmsDatabase.Close();
                BinariesForm bf = new BinariesForm(MdiParent, dbReg);
                bf.Show();
            }
            else if (e.ClickedItem == tsmiEventsTracker)
            {
                cmsDatabase.Close();
                EventsForm ev = new EventsForm(MdiParent, dbReg);
                ev.SetAutocompeteObjects(_actTables, _actSystemTables, _actViews);
                ev.Show();
            }
            else if(e.ClickedItem == tsmiOpenDBFilePath)
            {
                string fdb = dbReg.DatabasePath;
                FileInfo fi = new FileInfo(fdb);
                if (fi.Exists)
                {
                    Process.Start("explorer.exe", fi.DirectoryName);
                }
            }
        }

        public TreeView GetTree()
        {
            return treeView1;
        }
       
        private void CloseContextMenuString(object sender)
        {
            if (sender.GetType() != typeof(ContextMenuStrip)) return;
            (sender as ContextMenuStrip)?.Close();
        }

        private void ItemClickedEditLevel(object sender, ToolStripItemClickedEventArgs e)
        {
            if ((_tnSelected.Tag == null) || (string.IsNullOrEmpty(_tnSelected.Text))) return;

            var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1.SelectedNode);
                
            if ((tnReg == null) || (!(tnReg.Tag is DBRegistrationClass dbReg))) return;

            #region edit item
            if (e.ClickedItem == tsmiEditFullTable)
            {
                var tc = (TableClass)_tnSelected.Tag;
                if (tc == null) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new TABLEManageForm(MdiParent, dbReg, _tnSelected, _actTables);
                
                tmf.GetData = true;
                tmf.SetMaxRows(0);
                tmf.SetOrder(eSort.DESC);
                tmf.SetAutocompeteObjects(_actTables, null);
                tmf.Show();
                
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiEditFirst100OfTable)
            {
                var tc = (TableClass)_tnSelected.Tag;
                if (tc == null) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new TABLEManageForm(MdiParent, dbReg, _tnSelected, _actTables);
                
                tmf.GetData = true;
                tmf.SetMaxRows(100);
                tmf.SetOrder(eSort.ASC);
                tmf.SetAutocompeteObjects(_actTables, null);
                tmf.Show();
                
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiEditLast100OfTable)
            {
                var tc = (TableClass)_tnSelected.Tag;
                if (tc == null) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new TABLEManageForm(MdiParent, dbReg, _tnSelected, _actTables);
                
                tmf.GetData = true;
                tmf.SetMaxRows(100);
                tmf.SetOrder(eSort.DESC);
                tmf.SetAutocompeteObjects(_actTables, null);
                tmf.Show();
                
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiEditTableStruct)
            {
                var tc = (TableClass)_tnSelected.Tag;
                if (tc == null) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new TABLEManageForm(MdiParent, dbReg, _tnSelected, _actTables);
                
                tmf.GetData = false;
                tmf.SetAutocompeteObjects(_actTables, null);
                tmf.Show();
                
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiOpenSystemTable)
            {
                var tc = (SystemTableClass)_tnSelected.Tag;
                if (tc == null) return;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                var tmf = new TABLEManageForm(MdiParent, dbReg, _tnSelected, _actTables);
                
                tmf.GetData = true;
                tmf.SetMaxRows(0);
                tmf.SetOrder(eSort.ASC);
                tmf.SetAutocompeteObjects(null, _actSystemTables);
                tmf.Show();
                
                Cursor = Cursors.Default;
            }
            else if (e.ClickedItem == tsmiEditGenerator)
            {
                var tmf = new GeneratorForm(MdiParent, dbReg, _tnSelected, cmsGenerator)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();                            
            }
            else if (e.ClickedItem == tsmiEditIndices)
            {                            
                var tff = new IndexForm(MdiParent, (IndexClass) _tnSelected.Tag, dbReg, _actTables);                
                tff.Show();                            
            }
            else if(e.ClickedItem == tsmiNewIndex)
            {
                var tff = new IndexForm(MdiParent, string.Empty, dbReg, _actTables,EditStateClass.eBearbeiten.eInsert);                
                tff.Show();                            
            }            
            else if (e.ClickedItem == tsmiEditProcedure)
            {                            
                var tmf = new ProcedureForm(MdiParent, dbReg,_actTables, _tnSelected, cmsProcedure,EditStateClass.eBearbeiten.eEdit);                
                tmf.Show();                            
            }
            else if (e.ClickedItem == tsmiEditFunction)
            {                            
                var tmf = new FunctionForm(MdiParent, dbReg,_actTables, _tnSelected, cmsFunctions,EditStateClass.eBearbeiten.eEdit);                
                tmf.Show();                         
            }
            else if (e.ClickedItem == tsmiEditUserDefinedFunctions)
            {                            
                var tmf = new UserDefinedFunctionForm(MdiParent, dbReg, _tnSelected, cmsUserDefinedFunctions,EditStateClass.eBearbeiten.eEdit);                
                tmf.Show();                         
            }
            else if (e.ClickedItem == tsmiEditDomain)
            {                            
                var tmf = new DomainForm(MdiParent, dbReg, _actTables, _tnSelected, cmsDomains)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();                          
            }
            else if (e.ClickedItem == tsmiEditTrigger)
            {                            
                var tmf = new TriggerForm(MdiParent, dbReg, _tnSelected, cmsTriggers, _actTables)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();                          
            }
            else if (e.ClickedItem == tsmiEditConstraint)
            {                           
                var constraintObject = _tnSelected.Tag as ConstraintsClass;
                TableClass tableObject = (TableClass) StaticTreeClass.Instance().FindPrevTableNode(_tnSelected).Tag;
                var cf = new ConstraintsForm(MdiParent, tableObject, _actTables,dbReg, constraintObject)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                cf.Show();                            
            }
            else if (e.ClickedItem ==  tsmiEditNotNull)
            {                           
               var obj = _tnSelected.Tag as NotNullsClass;
               var cf = new NotNullForm(MdiParent, dbReg, _actTables,obj, cmsConstrainsGroup,cmsConstraints)
               {
                   BearbeitenMode = EditStateClass.eBearbeiten.eEdit 
               };
               cf.Show();  
            }
            else if (e.ClickedItem == tsmiEditPrimaryKey)
            {                                                
                var fktable = _actTables.Find(fc => fc.primary_constraint?.Name == _tnSelected.Text);
                    
                var cf = new PrimaryKeyForm(MdiParent, _actTables, fktable, dbReg)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                cf.Show();                            
            }
            else if (e.ClickedItem == tsmiEditViewAllRows)
            {
                var tmf = new VIEWManageForm(MdiParent, dbReg, _tnSelected);
                
                tmf.GetData = true;
                tmf.SetMaxRows(0);
                tmf.SetOrder(eSort.DESC);
                tmf.SetAutocompeteObjects(_actTables);
                tmf.Show();
                
            }
            else if (e.ClickedItem == tsmiEditFirst100OfView)
            {
                var tmf = new VIEWManageForm(MdiParent, dbReg, _tnSelected);
                
                tmf.GetData = true;
                tmf.SetMaxRows(100);
                tmf.SetOrder(eSort.ASC);
                tmf.SetAutocompeteObjects(_actTables);
                tmf.Show();
                
            }
            else if (e.ClickedItem == tsmiEditLast100OfView)
            {
                var tmf = new VIEWManageForm(MdiParent, dbReg, _tnSelected);
                
                tmf.GetData = true;
                tmf.SetMaxRows(100);
                tmf.SetOrder(eSort.DESC);
                tmf.SetAutocompeteObjects(_actTables);
                tmf.Show();
                
            }
            else if (e.ClickedItem == tsmiEditStructView)
            {
                var tmf = new VIEWManageForm(MdiParent, dbReg, _tnSelected);
                
                tmf.GetData = false;
                tmf.Show();
                
            }
            else if (e.ClickedItem == tsmiEditForeignKeys)
            {                            
                TableClass fktable = null;
                foreach (var tc in _actTables)
                {
                    if (tc.ForeignKeys == null) continue;
                    if (tc.ForeignKeys.Values.Any(fc => fc.Name == _tnSelected.Text))
                    {
                        fktable = tc;
                    }
                    if (fktable != null) break;
                }

                var fkc = (ForeignKeyClass)_tnSelected.Tag;
                var tmf = new ForeignKeyForm(MdiParent, dbReg,_actTables, fktable?.Name, fkc,-1)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eEdit
                };
                tmf.Show();                          
            }
            else if(e.ClickedItem == tsmiActivateFK)
            {
                TableClass fktable = null;
                foreach (var tc in _actTables)
                {
                    if (tc.ForeignKeys == null) continue;
                    if (tc.ForeignKeys.Values.Any(fc => fc.Name == _tnSelected.Text))
                    {
                        fktable = tc;
                    }
                    if (fktable != null) break;
                }

                var fkc = (ForeignKeyClass)_tnSelected.Tag;
                if (fkc != null)
                {
                    Application.DoEvents();
                    var ri = IndexSQLStatementsClass.Instance.ActivateIndex(fkc.Name, dbReg, NotifiesClass.Instance);
                    if (ri.commandDone)
                    {
                        fkc.IsActive = true;
                        _tnSelected.ForeColor = StaticTreeClass.Instance().Active;
                    }
                    Application.DoEvents();
                }                                
            }
            
            #endregion edit item
            #region drop item
            else if (e.ClickedItem == tsmiDropView)
            {
                var vc = (ViewClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop view {vc.Name}", @"Drop View",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri =  SQLStatementsClass.Instance.ExecSql($@"DROP VIEW {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping view {ri.lastError}", @"Drop View", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDropTable)
            {
                var vc = (TableClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop table {vc.Name}", @"Drop Table",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri =  SQLStatementsClass.Instance.ExecSql($@"DROP TABLE {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error dropping table {ri.lastError}", @"Drop Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDropFunction)
            {
                var vc = (FunctionClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop function {vc.Name}", @"Drop Function",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                SQLStatementsClass.Instance.ExecSql($@"DROP EXTERNAL FUNCTION {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                DbExlorerNotify.Notify.RaiseInfo("DBExplorerForm", StaticVariablesClass.ReloadFunctions);
            }
            else if (e.ClickedItem == tsmiDropProcedure)
            {
                var vc = (ProcedureClass)_tnSelected.Tag;

                if (MessageBox.Show($@"Do you really want to drop procedure {vc.Name}", @"Drop Procedure",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri = SQLStatementsClass.Instance.ExecSql($@"DROP PROCEDURE {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping procedure {ri.lastError}", @"Drop Procedure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadProcedures);
            }
            else if (e.ClickedItem == tsmiDropDomain) 
            {
                var vc = (DomainClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop domain {vc.Name}", @"Drop Domain",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri = SQLStatementsClass.Instance.ExecSql($@"DROP DOMAIN {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping domain {ri.lastError}", @"Drop Domain", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDropGenerator)
            {
                var vc = (GeneratorClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop generator {vc.Name}", @"Drop Generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri = SQLStatementsClass.Instance.ExecSql($@"DROP GENERATOR {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping generator {ri.lastError}", @"Drop Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDropIndex)
            {
                var vc = (IndexClass)_tnSelected.Tag;               
                if (MessageBox.Show($@"Do you really want to drop index {vc.Name}", $@"Drop Index", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri = IndexSQLStatementsClass.Instance.DropIndex(vc.Name, dbReg, NotifiesClass.Instance);                
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping index {ri.lastError}", @"Drop Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDeleteNotNull)
            {
                var vc = (NotNullsClass)_tnSelected.Tag;
                //var ctable = _actTables.Find(fc => fc.notnulls_constraints?.Name == _tnSelected.Text);
                string[] vals = vc.FieldNames.Values.ToArray(); //.TryGetValue("ID", out string val);
                if (MessageBox.Show($@"Do you really want to drop constraint {vc.Name}", $@"Drop Constraint", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri = ConstraintsSQLStatementsClass.Instance.DropNotNullConstraint(vc.Name,vc.TableName, vals[0], dbReg, NotifiesClass.Instance);
                if (!ri.commandDone)
                {
                    MessageBox.Show($@"Error droping NotNull constraint {ri.lastError}", @"NotNull constraint", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDropPrimaryKey)
            {
                // ALTER TABLE TSTAND_TPROC DROP CONSTRAINT PK_TSTAND_TPROC;
                
                var vc = (PrimaryKeyClass)_tnSelected.Tag;
                //var ctable = _actTables.Find(fc => fc.notnulls_constraints?.Name == _tnSelected.Text);
                
                string[] vals = vc.FieldNames.Values.ToArray();
                if (MessageBox.Show($@"Do you really want to drop PK constraint {vc.Name}", $@"Drop PK Constraint", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri = ConstraintsSQLStatementsClass.Instance.DropPrimaryKeyConstraint(vc.Name, vc.TableName, vals[0], dbReg, NotifiesClass.Instance);
                if (!ri.commandDone)
                {
                    MessageBox.Show($@"Error droping PK constraint {ri.lastError}", @"Drop PK constraint", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if(e.ClickedItem == tsmiActivateIndex)
            {
                 var tc = (IndexClass)_tnSelected.Tag;
                 if (tc == null) return;
                 Cursor = Cursors.WaitCursor;
                 Application.DoEvents();
                 var ri = IndexSQLStatementsClass.Instance.ActivateIndex(tc.Name,dbReg, NotifiesClass.Instance);
                 if (!ri.commandDone) 
                 {
                    MessageBox.Show($@"Error activating index {ri.lastError}", @"Activate Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                 }
                 else
                 {
                    tc.IsActive = true;
                    _tnSelected.ForeColor = StaticTreeClass.Instance().Active;
                 }
                 Cursor = Cursors.Default;
                 Application.DoEvents();
            }
            else if (e.ClickedItem == tsmiDeactivateIndex)
            {
                 var tc = (IndexClass)_tnSelected.Tag;
                 if (tc == null) return;
                 Cursor = Cursors.WaitCursor;
                 Application.DoEvents();
                 var ri = IndexSQLStatementsClass.Instance.DeactivateIndex(tc.Name,dbReg, NotifiesClass.Instance);
                 if (!ri.commandDone) 
                 {
                    MessageBox.Show($@"Error deactivating index {ri.lastError}", @"Deactivate Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                 }
                 else
                 {
                    tc.IsActive = false;
                    _tnSelected.ForeColor = StaticTreeClass.Instance().Inactive;
                 }
                 Cursor = Cursors.Default;
                 Application.DoEvents();
            }
            else if(e.ClickedItem == tsmiRecreateIndex)
            {
                var tc = (IndexClass)_tnSelected.Tag;
                 if (tc == null) return;
                 Cursor = Cursors.WaitCursor;
                 Application.DoEvents();
                 var ri = IndexSQLStatementsClass.Instance.DeactivateIndex(tc.Name,dbReg, NotifiesClass.Instance);
                 if (ri.commandDone) 
                 {                   
                    tc.IsActive = false;
                    _tnSelected.ForeColor = StaticTreeClass.Instance().Inactive;
                 }
                 var ria = IndexSQLStatementsClass.Instance.ActivateIndex(tc.Name,dbReg, NotifiesClass.Instance);
                 if (ria.commandDone) 
                 {                   
                    tc.IsActive = true;
                    _tnSelected.ForeColor = StaticTreeClass.Instance().Active;
                 }
                 Cursor = Cursors.Default;
                 Application.DoEvents();                               
            }
            else if (e.ClickedItem == tsmiDropTrigger)
            {
                var vc = (TriggerClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop trigger {vc.Name}", @"Drop Trigger",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri =  SQLStatementsClass.Instance.ExecSql($@"DROP TRIGGER {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping trigger {ri.lastError}", @"Drop Trigger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
            }
            else if (e.ClickedItem == tsmiDropForeignKey) 
            {
                var vc = (ForeignKeyClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop foreign key {vc.Name}",$@"Drop Foreignkey", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var ri =  SQLStatementsClass.Instance.ExecSql($@"ALTER TABLE {vc.SourceTableName} DROP CONSTRAINT  {vc.Name.ToUpper()};", dbReg, NotifiesClass.Instance);
                if (!ri.commandDone) 
                {
                    MessageBox.Show($@"Error droping foreign key {ri.lastError}", @"Drop Foreign Key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _tnSelected.Remove();
                NotifiesClass.Instance.Notify.RaiseInfo(Name, "RELOAD_FOREIGNKEYS", vc.SourceTableName);
            }
            #endregion drop item
            #region refresh item
            else if (e.ClickedItem == tsmiRefreshTable)
            {                            
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadTable, _tnSelected);
            }
            else if (e.ClickedItem == tsmiRefreshFunction)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadFunctions);
            }
            else if (e.ClickedItem == tsmiRefreshProcedure)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadProcedures);
            }
            else if (e.ClickedItem == tsmiRefreshGenerator)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadGenerators);
            }
            #endregion refresh item
        }

        public void SearchInViews(TreeNode tnviews)
        {
            var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1.SelectedNode);
            if (tnReg == null) return;
            if (!(tnReg.Tag is DBRegistrationClass dbReg)) return;

            StringBuilder sb = new StringBuilder();
            int cnt = 0;
            foreach (TreeNode tn in tnviews.Nodes)
            {
                ViewClass viewObject = (ViewClass)tn.Tag;
                sb.Append(viewObject.CREATE_SQL);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                cnt++;
            }
            var hif = new TextInfoForm(MdiParent);
            hif.SetTitle($@"Database:{dbReg.Alias}, Found {cnt} Views");
            hif.Append(sb.ToString());
            hif.SearchPattern = String.Empty;
            hif.Show();
        }
        public void SearchInTables(TreeNode tntables)
        {
            var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1.SelectedNode);
            if (tnReg == null) return;
            if (!(tnReg.Tag is DBRegistrationClass dbReg)) return;

            StringBuilder sb = new StringBuilder();
            int cnt = 0;
            foreach (TreeNode tn in tntables.Nodes)
            {
                TableClass tableObject = (TableClass)tn.Tag;
                string sqltxt = CreateDLLClass.CreateTabelDLL(tableObject, eCreateMode.create);
                sb.Append(sqltxt);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                cnt++;
            }
            var hif = new TextInfoForm(MdiParent);
            hif.SetTitle($@"Database:{dbReg.Alias}, Found {cnt} Tables");
            hif.Append(sb.ToString());
            hif.SearchPattern = String.Empty;
            hif.Show();
        }

        public bool FindInString(string key, string content)
        {
            return content.ToLower().Contains(key.ToLower());
        }

        private void cmsGroup2Items_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {            
            var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1.SelectedNode);
            if (tnReg == null) return;
            if (!(tnReg.Tag is DBRegistrationClass dbReg)) return;

            #region clickedItems
            if (e.ClickedItem == tsmiNewGeneratorInGroup)
            {
                var gc = new GeneratorClass();
                _tnSelected.Tag = gc;
                var tmf = new GeneratorForm(MdiParent, dbReg, _tnSelected, cmsGenerator)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                tmf.Show();
            }
            else if (e.ClickedItem == tsmiNewTable)
            {                
                var newtableform = new CreateNewTableForm(dbReg, MdiParent,  DbExlorerNotify)
                {
                     BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                newtableform.Show();
            }
            else if (e.ClickedItem == tsmiNewProcedureGroup)
            {
                var gc = new ProcedureClass();
                _tnSelected.Tag = gc;
                var tmf = new ProcedureForm(MdiParent, dbReg,_actTables, _tnSelected, cmsProcedure,EditStateClass.eBearbeiten.eInsert);
                
                tmf.Show();
            }
            else if (e.ClickedItem == tsmiNewFunctionGroup)
            {
                var gc = new FunctionClass();
                _tnSelected.Tag = gc;
                var tmf = new FunctionForm(MdiParent, dbReg, _actTables,_tnSelected, cmsProcedure,EditStateClass.eBearbeiten.eInsert);
                
                tmf.Show();
            }
            else if (e.ClickedItem == tsmiNewConstraint)
            {     
                TableClass tableObject = (TableClass) StaticTreeClass.Instance().FindPrevTableNode(_tnSelected).Tag;
                var tmf = new ConstraintsForm(MdiParent,tableObject,_actTables, dbReg, null)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                tmf.Show();
            }
            else if (e.ClickedItem == tsmiNewPrimaryKey)
            {
                var cf = new PrimaryKeyForm(MdiParent, _actTables, null, dbReg)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                cf.Show();
            }
            else if (e.ClickedItem == tsmiNewDomain)
            {
                 _tnSelected.Tag = null;
                var tmf = new DomainForm(MdiParent, dbReg, _actTables, _tnSelected, cmsDomains)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                tmf.Show();  
            }
            else if (e.ClickedItem == tsmiNewIndices)
            {
                var tff = new IndexForm(MdiParent, string.Empty, dbReg, _actTables,EditStateClass.eBearbeiten.eInsert);
                
                tff.Show();                            
            }
            else if (e.ClickedItem == tsmiForeignKeyNew)
            {
                _tnSelected.Tag = null;
                var tmf = new ForeignKeyForm(MdiParent, dbReg, _actTables, string.Empty, null,0)
                {
                    BearbeitenMode = EditStateClass.eBearbeiten.eInsert
                };
                tmf.Show();
            }           
            else if (e.ClickedItem == tsmiRefreshForeignKey)
            {                
                string str = (treeView1.SelectedNode.Level == 1) ? StaticVariablesClass.ReloadAllForeignKeys : StaticVariablesClass.ReloadForeignKeys;                                
                DbExlorerNotify.Notify.RaiseInfo(Name, str , null);                
            }
            else if (e.ClickedItem == tsmiRefreshConstraints)
            {
                string str = (treeView1.SelectedNode.Level == 1) ? StaticVariablesClass.ReloadAllConstraits : StaticVariablesClass.ReloadConstraits;                
                DbExlorerNotify.Notify.RaiseInfo(Name, str, null);                
            }
            else if (e.ClickedItem == tsmiRefreshViews) 
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllViews);
            }
            else if (e.ClickedItem == tsmiExportAllViewsSQL)
            {
                ExportViewsSQLForm evs = new ExportViewsSQLForm(MdiParent);
                
                evs.dbReg = dbReg;
                evs.views = _actViews;
                evs.Show();
                
            }
            else if (e.ClickedItem == tsmiRefreshAllTables)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllTables);
            }
            else if (e.ClickedItem == tsmiRefreshFunctions)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadFunctions);
            }
            else if (e.ClickedItem == tsmiRefreshProcedures)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadProcedures);
            }
            else if (e.ClickedItem == tsmiRefreshGenerators)
            {
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadGenerators);
            }
            else if (e.ClickedItem == tsmiRefreshIndeces)
            {
                string str = (treeView1.SelectedNode.Level == 1) ? StaticVariablesClass.ReloadAllIndex : StaticVariablesClass.ReloadIndex;                
                DbExlorerNotify.Notify.RaiseInfo(Name, str);                
            }
            else if (e.ClickedItem == tsmiActivateAllIndeces)
            {
                TreeNode nd = treeView1.SelectedNode;
                var Index = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.IndicesKeyStr);
                int i = 0;
                Cursor = Cursors.WaitCursor;
                while(Index != null)
                {
                    i++;
                    var inxObject = (IndexClass) Index.Tag;
                    if(inxObject != null)
                    {                        
                         Application.DoEvents();
                         var ri = IndexSQLStatementsClass.Instance.ActivateIndex(inxObject.Name,dbReg, NotifiesClass.Instance);
                         if (ri.commandDone) 
                         {
                            inxObject.IsActive = true;
                            _tnSelected.ForeColor = StaticTreeClass.Instance().Active;
                         }                         
                         Application.DoEvents();
                    }
                    Index = Index.NextNode;                    
                }                
                Cursor = Cursors.Default;
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllIndex);
            }
            else if (e.ClickedItem == tsmiRecreateAllIndex)
            {
                TreeNode nd = treeView1.SelectedNode;
                var Index = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.IndicesKeyStr);
                int i = 0;
                Cursor = Cursors.WaitCursor;
                while(Index != null)
                {
                    i++;
                    var inxObject = (IndexClass) Index.Tag;
                    if(inxObject != null)
                    {                        
                         Application.DoEvents();
                         var ris = IndexSQLStatementsClass.Instance.DeactivateIndex(inxObject.Name,dbReg, NotifiesClass.Instance);
                         if (ris.commandDone) 
                         {
                            inxObject.IsActive = false;
                            _tnSelected.ForeColor = StaticTreeClass.Instance().Inactive;
                         }
                         var ria = IndexSQLStatementsClass.Instance.ActivateIndex(inxObject.Name,dbReg, NotifiesClass.Instance);
                         if (ria.commandDone) 
                         {
                            inxObject.IsActive = true;
                            _tnSelected.ForeColor = StaticTreeClass.Instance().Active;
                         }                         
                         Application.DoEvents();
                    }
                    Index = Index.NextNode;                    
                }                
                Cursor = Cursors.Default;
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllIndex);
            }
            else if (e.ClickedItem == tsmiDeactivateAllIndeces)
            {
                TreeNode nd = treeView1.SelectedNode;
                var Index = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.IndicesKeyStr);
                int i = 0;
                Cursor = Cursors.WaitCursor;
                while(Index != null)
                {
                    i++;
                    var inxObject = (IndexClass) Index.Tag;
                    if(inxObject != null)
                    {                
                         Application.DoEvents();
                         var ri = IndexSQLStatementsClass.Instance.DeactivateIndex(inxObject.Name,dbReg, NotifiesClass.Instance);
                         if (ri.commandDone) 
                         {
                            inxObject.IsActive = false;
                            _tnSelected.ForeColor = StaticTreeClass.Instance().Inactive;
                         }                       
                         Application.DoEvents();
                    }
                    Index = Index.NextNode;                    
                }                
                Cursor = Cursors.Default;
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllIndex);
            }
            else if (e.ClickedItem == tsmiActivcateAllFK)
            {
                TreeNode nd = treeView1.SelectedNode;
                var FK = StaticTreeClass.Instance().FindFirstNodeInAllNodes(nd, StaticVariablesClass.ForeignKeyStr);
                int i = 0;
                Cursor = Cursors.WaitCursor;
                while (FK != null)
                {
                    i++;
                    var fkObject = (ForeignKeyClass)FK.Tag;
                    if (fkObject != null)
                    {
                        Application.DoEvents();
                        var ri = IndexSQLStatementsClass.Instance.ActivateIndex(fkObject.Name, dbReg, NotifiesClass.Instance);
                        if (ri.commandDone)
                        {
                            fkObject.IsActive = true;
                            _tnSelected.ForeColor = StaticTreeClass.Instance().Active;
                        }
                        Application.DoEvents();
                    }
                    FK = FK.NextNode;
                }
                Cursor = Cursors.Default;
                DbExlorerNotify.Notify.RaiseInfo(Name, StaticVariablesClass.ReloadAllForeignKeys);
            }
            else if (e.ClickedItem == tsmiExportTablesDLL)
            {
                var evs = new ExportTablesDLLForm(MdiParent);
                
                evs.dbReg = dbReg;
                evs.Tables = _actTables;
                evs.Show();
                
            }
            else if (e.ClickedItem == tsmiExportAllProceduresScript)
            {
                var allprocedures = StaticTreeClass.Instance().GetProcedureObjects(dbReg);
                var evs = new ExportProceduresScriptForm(MdiParent);
                
                evs.dbReg = dbReg;
                evs.procedures = allprocedures;
                evs.Show();
                
            }
            else if (e.ClickedItem == tsmiExportAllFunctionsScript)
            {
                var allprocedures = StaticTreeClass.Instance().GetFunctionObjects(dbReg);
                var evs = new ExportFunctionsScriptForm(MdiParent);
                
                evs.dbReg = dbReg;
                evs.Functions = allprocedures;
                evs.Show();
                
            }
            else if(e.ClickedItem == tsmiExpandTablesNodes)
            {
                ColapseExpandNodes(treeView1.SelectedNode);
            }
            else if (e.ClickedItem == tsmiExpandViewNodes)
            {
                ColapseExpandNodes(treeView1.SelectedNode);
            }
            else if (e.ClickedItem == tsmiDropAllViews)
            {
                var vc = (ViewGroupClass)_tnSelected.Tag;
                if (MessageBox.Show($@"Do you really want to drop view {vc.Name}", @"Drop View",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

                foreach(TreeNode sel in _tnSelected.Nodes)
                {
                    TreeNode vco = sel;
                    SQLStatementsClass.Instance.ExecSql($@"DROP VIEW {vco.Text.ToUpper()};", dbReg, NotifiesClass.Instance);
                }
                
                _tnSelected.Remove();
            }
            else if(e.ClickedItem == tsmiSearchView)
            {
                SearchInViews(_tnSelected);
            }
            else if (e.ClickedItem == tsmiSearchInTables)
            {
                SearchInTables(_tnSelected);
            }

            #endregion refresh group
        }

        public void ColapseExpandNodes(TreeNode nd)
        {
            if (nd.IsExpanded)
            {
                nd.Collapse();

                tsmiExpandTablesNodes.Text = LanguageClass.Instance.GetString("EXPAND_NODE");
            }
            else
            {
                nd.Expand();
                foreach (TreeNode n in nd.Nodes)
                {
                   // var tp = n.Tag.GetType();
                    n.Expand();
                }

                tsmiExpandTablesNodes.Text = LanguageClass.Instance.GetString("COLAPSE_NODE");
            }
        }

        public void SetTreeLanguageDefaults()
        {
            tsmiExpandTablesNodes.Text = LanguageClass.Instance.GetString("EXPAND_NODE");
            tsmiExpandViewNodes.Text = LanguageClass.Instance.GetString("EXPAND_NODE");
        }
       
        public void ReloadAllDatabases()
        {
            string pf = $@"{AppSettingsClass.Instance.PathSettings.DatabasesConfigPath}\{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}";
            bool dz = DatabaseDefinitions.Instance.Deserialize(pf);
            
            FbXpertMainForm.Instance().SetLastLoadedDefinition(pf);
            if (!dz) return;
            
            NotifiesClass.Instance.InfoGranularity = eMessageGranularity.normal;
            MakeDatabaseTree(false);
            int n = DatabaseDefinitions.Instance.CountToOpen();
            if(n > AppSettingsClass.Instance.DatabaseSettings.OpenDatabaseCount)
            { 
                object[] p = {n, Environment.NewLine };
                if (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "OpenDatabases", "DoYouWantOpenDatabases", FormStartPosition.CenterScreen,
                        SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation, null, p) != SEDialogResult.Yes)
                { 
                    OpenActiveDatabases();
                }
                else
                {
                    DatabaseDefinitions.Instance.MarkDatabasesActiv(false);
                    DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
                }
            }
            else
            {
                OpenActiveDatabases();
            }
            if (NotificationsForm.Instance().Visible)  NotificationsForm.Instance().Close();
            NotifiesClass.Instance.InfoGranularity = eMessageGranularity.few; //Alleinfos bis few angezeigt
        }
        
        public void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt) return;
            if (e.Control && e.Shift)
            {
                switch (e.KeyCode)
                {                    
                    case Keys.C:
                    {
                        cmsDatabase.Close();
                        foreach (TreeNode nd in treeView1.Nodes)
                        {
                            if (DatabaseDefinitions.Instance.IsRegistration(nd))
                            {
                                CloseDatabase(nd);
                            }
                        }
                        DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
                        break;
                    }
                    case Keys.O:
                    {
                        cmsDatabase.Close();
                        foreach (TreeNode nd in treeView1.Nodes)
                        {
                            if (DatabaseDefinitions.Instance.IsRegistration(nd))
                            {
                                Application.DoEvents();
                                ReadDatabaseMetadata(nd);
                            }
                        }
                        DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
                        break;
                    }
                }
            }
            else if (e.Control)
            { 
                switch (e.KeyCode)
                {
                    case Keys.Up:
                    {
                        var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1?.SelectedNode);                                        
                        if (DatabaseDefinitions.Instance.IsRegistration(tnReg))
                            DatabaseDefinitions.Instance.MoveUp(treeView1);                    
                        break;
                    }
                    case Keys.Down:
                    {
                        var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1?.SelectedNode);                                        
                        if (DatabaseDefinitions.Instance.IsRegistration(tnReg))
                            DatabaseDefinitions.Instance.MoveDown(treeView1);                    
                        break;
                    }
                    case Keys.O:
                    {                    
                        var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1?.SelectedNode);                    
                        if (DatabaseDefinitions.Instance.IsRegistration(tnReg))
                        { 
                            cmsDatabase.Close();
                            Application.DoEvents();
                            ReadDatabaseMetadata(tnReg);
                            DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;                        
                        }
                        break;
                    }
                    case Keys.C:
                    {
                        var tnReg = StaticTreeClass.Instance().GetRegNode(treeView1?.SelectedNode);                   
                        if (DatabaseDefinitions.Instance.IsRegistration(tnReg))
                        {
                            CloseDatabase(tnReg);
                            DatabaseDefinitions.Instance.DataState = EditStateClass.eDataState.UnSaved;
                        }
                        break;
                    }               
                }
            }            
        }

        private void hsLoadDefinition_Click(object sender, EventArgs e)
        {
            var fi = new FileInfo($@"{AppSettingsClass.Instance.PathSettings.DatabasesConfigPath}\{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}");
            ofdLoadDefinition.InitialDirectory = fi.DirectoryName;
            ofdLoadDefinition.FileName = fi.Name;
            
            if (ofdLoadDefinition.ShowDialog() != DialogResult.OK) return;

            var fi2 = new FileInfo(ofdLoadDefinition.FileName);
            AppSettingsClass.Instance.PathSettings.DatabasesConfigPath = fi2.DirectoryName;
            AppSettingsClass.Instance.PathSettings.DatabaseConfigFile = fi2.Name;
            ReloadAllDatabases();
        }


        /// <summary>
        /// Speichert die aktuelle Datenbankdefiniton unter angegeben Namen und Speicher dies als
        /// Application Configuration für den nächsten parameterlosen Neustart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hsDatabaseDefinitionSave_Click(object sender, EventArgs e)
        {         
            var fi = new FileInfo($@"{AppSettingsClass.Instance.PathSettings.DatabasesConfigPath}\{AppSettingsClass.Instance.PathSettings.DatabaseConfigFile}");
            sfdSaveDefinition.InitialDirectory  = fi.DirectoryName;
            sfdSaveDefinition.FileName          = fi.Name;
            if (sfdSaveDefinition.ShowDialog() != DialogResult.OK) return;
            var fi2 = new FileInfo(sfdSaveDefinition.FileName);

            DatabaseDefinitions.Instance.Rebuild(treeView1);
            DatabaseDefinitions.Instance.Serialize(sfdSaveDefinition.FileName, "SAVE_DATABASE_DEFINITION");
            if(fi2.FullName == fi.FullName) return;
             
            object[] p = { sfdSaveDefinition.FileName, Environment.NewLine };

            if (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "StartDefinitionChangeCaption", "StartDefinitionChange", FormStartPosition.CenterScreen, SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Question, null, p) != SEDialogResult.Yes) return;            
            AppSettingsClass.Instance.PathSettings.DatabasesConfigPath = fi2.DirectoryName;
            AppSettingsClass.Instance.PathSettings.DatabaseConfigFile = fi2.Name;
            AppSettingsClass.Instance.SaveSettings();
        }
       
        private void DbExplorerForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
        }

        private void hsRefreshDB_Click(object sender, EventArgs e)
        {
            ReloadAllDatabases(); 
        }

        private void hsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DbExplorerForm_Enter(object sender, EventArgs e)
        {
            //SEHotSpot.Controller.Instance().SetHookForm(this);
        }

        private void DbExplorerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppSettingsClass.Instance.SaveSettings();
        }

        private void hsGetOpenConnections_Click(object sender, EventArgs e)
        {
            GetOpenConnections();
        }

        private void cmsFields_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiCopyFieldClipboard)
            {
                Clipboard.SetText(FbXpertMainForm.Instance().ActFieldObject.Name);
            }
        }
    }
}
