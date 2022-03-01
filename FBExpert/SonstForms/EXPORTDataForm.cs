using BasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpertLib;
using FormInterfaces;
using MessageFormLibrary;
using SEListBox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class EXPORTDataForm : INormalForm
    {                      
        TableClass TableObject = null;
        
        DBRegistrationClass DBReg = null;        
        NotifiesList Notifies=new NotifiesList();                
        NotifiesClass localNotify = null;
        string PkColumnName = string.Empty;
        string cmd = string.Empty;
        bool firsttab = false;

        public void SetMDIParent(Form parent)
        {
            this.MdiParent = parent;
        }

        public void SetRegistration(DBRegistrationClass drc)
        {
            DBReg = drc;
        }
       
        public EXPORTDataForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;

            localNotify = new NotifiesClass()
            {
                //NotifyType = eNotifyType.ErrorWithoutMessage,
                ErrorGranularity = eMessageGranularity.never
            };
            localNotify.Register4Info(InfoRaised);
            localNotify.Register4Error(ErrorRaised);
                             
            DBReg = drc;
            
            var viewobjects = StaticDatabaseObjects.Instance().GetViewObjects(DBReg);
            var tableObjects = StaticDatabaseObjects.Instance().GetAllNonSystemTableObjectsComplete(DBReg);
            var domainObjects = StaticDatabaseObjects.Instance().GetDomainObjects(DBReg);
            var generatorObjects = StaticDatabaseObjects.Instance().GetGeneratorObjects(DBReg);
            var indecesObjects = StaticDatabaseObjects.Instance().GetIndecesObjects(DBReg);
            var triggerObjects = StaticDatabaseObjects.Instance().GetTriggerObjects(DBReg);
            //var procedureObjects = StaticDatabaseObjects.Instance().GetAllProcedureObjects(DBReg);
            var procedureObjects = StaticDatabaseObjects.Instance().GetProcedureObjects(DBReg);
            var functionObjects = StaticDatabaseObjects.Instance().GetInternalFunctionObjects(DBReg);
            if (tableObjects.Count <= 0) return;
           
            foreach (var tc in tableObjects.Values)
            {
               selTables.Add(tc.ToString(), CheckState.Unchecked, tc);
            }

            selTables.CheckChecks();

            foreach (var tc in tableObjects.Values)
            {
                selStructureTables.Add(tc.ToString(), CheckState.Unchecked, tc);
            }

            selStructureTables.CheckChecks();

            SelectAllTableFields();

            foreach (var tc in viewobjects.Values)
            {
                selStructureViews.Add(tc.ToString(), CheckState.Unchecked, tc);
            }

            selStructureViews.CheckChecks();

            foreach (var tc in domainObjects.Values)
            {
                if ((tc.ToString().StartsWith("RDB$"))|| (tc.ToString().StartsWith("SEC$")) || (tc.ToString().StartsWith("MON$"))) continue;                
                selDomains.Add(tc.ToString(), CheckState.Unchecked, tc);                   
            }

            selDomains.CheckChecks();

            foreach (var tc in generatorObjects.Values)
            {
                if ((tc.ToString().StartsWith("RDB$")) || (tc.ToString().StartsWith("SEC$")) || (tc.ToString().StartsWith("MON$"))) continue;                
                selGenerators.Add(tc.ToString(), CheckState.Unchecked, tc);                   
            }
            selGenerators.CheckChecks();


            foreach (var tc in triggerObjects.Values)
            {                
                selTriggerStructure.Add(tc.ToString(), CheckState.Unchecked, tc);                
            }

            selTriggerStructure.CheckChecks();
            

            foreach (var tc in indecesObjects.Values)
            {                
                selIndeces.Add(tc.ToString(), CheckState.Unchecked, tc);                
            }

            selIndeces.CheckChecks();

            foreach (var tc in procedureObjects.Values)
            {                
                selProceduresStructure.Add(tc.ToString(), CheckState.Unchecked, tc);                
            }
            selProceduresStructure.CheckChecks();

            foreach (var tc in functionObjects.Values)
            {                
                selFunctionsStructure.Add(tc.ToString(), CheckState.Unchecked, tc);                
            }
            selFunctionsStructure.CheckChecks();
            
            var itm = selTables.ItemDatas[0] as ItemDataClass;
            TableObject = itm.Object as TableClass;

            selExportStructureList.AllowMultipleChecks = true;

            selExportStructureList.Add("Domains", CheckState.Checked,new DomainClass());
            selExportStructureList.Add("UDFs", CheckState.Checked, new UserDefinedFunctionClass());
            selExportStructureList.Add("Generators", CheckState.Checked, new GeneratorClass());
            selExportStructureList.Add("Procedures", CheckState.Checked, new ProcedureClass());
            selExportStructureList.Add("Functions", CheckState.Checked, new FunctionClass());
            selExportStructureList.Add("Tables", CheckState.Checked, new TableClass());
            selExportStructureList.Add("Views", CheckState.Checked, new ViewClass());
            selExportStructureList.Add("Check constraints", CheckState.Checked, new ChecksClass());
            selExportStructureList.Add("Unique constraints", CheckState.Checked, new UniquesClass());
            selExportStructureList.Add("Primary keys", CheckState.Checked, new PrimaryKeyClass());
            selExportStructureList.Add("Foreign keys", CheckState.Checked, new ForeignKeyClass());
            selExportStructureList.Add("Indices", CheckState.Checked, new IndexClass());
            selExportStructureList.Add("Triggers", CheckState.Checked, new TriggerClass());

            selExportStructureList.Add("UDF descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("Generator descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("Procedure descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("Table descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("Table field descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("View descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("View field descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("Index descriptions", CheckState.Checked, new object());
            selExportStructureList.Add("Trigger descriptions", CheckState.Checked, new object());                                                
            selExportStructureList.Add("Procedure parameter descriptions", CheckState.Checked, new object());
        }

        private void ErrorRaised(object sender, MessageEventArgs k)
        {
            throw new NotImplementedException();
        }

        private void InfoRaised(object sender, MessageEventArgs k)
        {
            throw new NotImplementedException();
        }
        
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public void ShowCaptions()
        {
            lblTableName.Text = (TableObject != null) ? $@"Export Table: {TableObject.Name}" : "Export Table";
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Database Export Table");
        }

        public void SetControlSizes()
        {
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlTableUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlUpperExportStructureObjects.Height = AppSizeConstants.UpperFormBandHeight+44;
            pnlStructureObjectsUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlTableFieldsUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }
        private void EXPORTDataForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            ShowCaptions();
            if (DbExplorerForm.Instance().Visible)
            {
                this.Left = DbExplorerForm.Instance().Width + 16;
            }

            cbCharSet.Items.Clear();
            cbCharSet.Items.Add(new EncodingClass(Encoding.UTF8));
            cbCharSet.Items.Add(new EncodingClass(Encoding.ASCII));
            cbCharSet.Items.Add(new EncodingClass(Encoding.Default));
            cbCharSet.Items.Add(new EncodingClass(Encoding.Unicode));
            
            cbCharSet.SelectedIndex = 0;
            gbCharset.Enabled = cbExportToFile.Checked;
            gbFileName.Enabled = cbExportToFile.Checked;
            gbFolder.Enabled = cbExportToFile.Checked;

            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);
            
        }
                            
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            firsttab = StaticPaintClass.TabControl_DrawItem(this, e, sender, firsttab);
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            firsttab = false;
            if(tabControl.SelectedTab == tabTableExports)
            {
                hsExportTable.Text = "Export Tables";
            }
            else if(tabControl.SelectedTab == tabExtExports)
            {
                hsExportTable.Text = "Export Extented";
            }
        }
       
        private void hsExport_Click(object sender, EventArgs e)
        {
            var ew = new ExportWorkers(NotifiesClass.Instance)
            {
                alltables = new List<TableClass>()
            };
            ew.alltables.Clear();
            ew.AktDBReg = DBReg;
            ew.ShowScripting = cbViewInScript.Checked;
            if(ckWriteFileForEVeryObject.Checked)
            {
              ew.WriteToFile = eSQLFileWriteMode.seperated;
            }
            else if(cbObjectExportToFile.Checked)
            {
              ew.WriteToFile = eSQLFileWriteMode.all;
            }
            
            if (ew.WriteToFile != eSQLFileWriteMode.none)
            {
                if ((txtFileName.Text.IndexOf(".", StringComparison.Ordinal)) < 0) txtFileName.Text += ".sql";
                
                ew.SQLDirectoryName = txtExportDirectory.Text;
                ew.SQLFileName = txtFileName.Text;
                ew.CharSet = cbCharSet.SelectedItem as EncodingClass;
            }            
            else
            {
                ew.SQLDirectoryName = string.Empty;
                ew.SQLFileName = string.Empty;
            }

          
            for(int i = 0; i <  selTables.ItemDatas.Count; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                tc.State = selTables.GetItemCheckState(i);
                if (tc.State != CheckState.Checked) continue;                                 
                ew.alltables.Add(tc);                                    
            }
          
            ew.StartworkerGetTableData(ew.alltables, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
        }
        
        private void EXPORTDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (localNotify == null) return;
            
            localNotify.Notify.OnRaiseInfoHandler -= new NotifyInfos.RaiseNotifyHandler(InfoRaised);
            localNotify.Notify.OnRaiseErrorHandler -= new NotifyInfos.RaiseNotifyHandler(ErrorRaised);
            localNotify = null;               
        }
                                            
        public TableFieldClass FindField(string fname)
        {
            foreach (TableFieldClass str in TableObject.Fields.Values)
            {
                if(str.Name == fname) return str;                   
            }
            return null;
        }
        
        
        private void hsCheckAllTables_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
           
            selTables.CheckChecks();            
            for (int i = 0; i < selTables.ItemDatas.Count; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                selFields.ClearItems();
                foreach (var fld in tc.Fields.Values)
                {
                    selFields.Add(fld.ToString(),fld.State,fld);
                }
                selFields.CheckChecks();               
            }                       
                    
        }

        private void hsUncheckAlltables_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            //int pos = selTables.SelectedIndex;
            selTables.ClearChecks();
            for (int i = 0; i < selTables.ItemDatas.Count; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                selFields.ClearItems();
                foreach (var fld in tc.Fields.Values)
                {
                    selFields.Add(fld.ToString(), fld.State, fld);
                }
                selFields.ClearChecks();
            }
            //selTables.SelectedIndex = pos;            
        }

        private void hsCheckAllTableFields_Click(object sender, EventArgs e)
        {
            selFields.CheckChecks();            
        }

        private void hsUncheckAllTableFields_Click(object sender, EventArgs e)
        {
            selFields.ClearChecks();
        }

        private void cbExportToFile_CheckedChanged_1(object sender, EventArgs e)
        {
            gbFolder.Enabled = cbExportToFile.Checked;
            gbFileName.Enabled = cbExportToFile.Checked;
            gbCharset.Enabled = cbExportToFile.Checked;
            /*
            if(cbExportToFile.Checked)
            {
                ListDirectory(treeView1, "D:\\");

                treeView1.ExpandAll();
            }
            */
        }
        
        private void hsFileSelect_Click(object sender, EventArgs e)
        {
           
           // sfdFile.InitialDirectory = di.FullName;
            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = sfdFile.FileName;
            }
        }
        /*
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);

            var tn = (CreateDirectoryNode(rootDirectoryInfo, 1));
            tn.Tag = rootDirectoryInfo;
            ActFolder = tn;
            LastFolder = tn;
            treeView.ImageList = imageList1;
            treeView.Nodes.Add(tn);
        }
        */
        /*
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo, int deep)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            try
            {
                foreach (var directory in directoryInfo.GetDirectories())
                {

                    if (deep >  1) continue;
                    
                    try
                    {
                        var tn = (CreateDirectoryNode(directory, deep + 1));
                        tn.ImageIndex = 0;
                        tn.SelectedImageIndex = 0;
                        tn.Tag = directory;
                        directoryNode.Nodes.Add(tn);
                    }
                    catch { }                       
                }
            }
            catch
            {
            }

            if (deep <= 1)
            {
                foreach (var file in directoryInfo.GetFiles())
                {
                    var tn = new TreeNode(file.Name)
                    {
                        ImageIndex = 1,
                        SelectedImageIndex = 1
                    };

                    directoryNode.Nodes.Add(tn);
                }
            }
            return directoryNode;
        }
        */
        /*
        TreeNode LastFolder = null;
        TreeNode ActFolder = null;
        */
        /*
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;            
            LastFolder = ActFolder;
            ActFolder = treeView1.SelectedNode;
            var di = treeView1.SelectedNode.Tag as DirectoryInfo;
            if (LastFolder == null) LastFolder = ActFolder;                
            ListDirectory(treeView1, di.FullName);
            treeView1.ExpandAll();               
        }

        private void hsLastFolder_Click(object sender, EventArgs e)
        {
            if (LastFolder == null) return;            
            var di = LastFolder.Tag as DirectoryInfo;
            ListDirectory(treeView1, di.FullName);
            treeView1.ExpandAll();
            ActFolder = LastFolder;
            LastFolder = LastFolder.Parent;                
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            ListDirectory(treeView1, "D:\\");
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.ImageIndex == 1)
            {
                txtFileName.Text = treeView1.SelectedNode.Text;
            }
            else if (treeView1.SelectedNode.ImageIndex == 0)
            {
                ActFolder = treeView1.SelectedNode;
            }
        }
        */
        private void hsSelectStructureObjects_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            selStructureTables.CheckChecks();            
        }

        private void hsUnselectStructureObjects_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            selStructureTables.ClearChecks();            
        }
        
        private void hsExportStructure_Click(object sender, EventArgs e)
        {
            var ew = new ExportWorkers(NotifiesClass.Instance)
            {
                allviews = new List<ViewClass>()
            };
            ew.allviews.Clear();

            ew.alltables = new List<TableClass>();
            ew.alltables.Clear();

            ew.allPKConstraints = new Dictionary<string, PrimaryKeyClass>();
            ew.allPKConstraints.Clear();

            ew.allFKConstraints = new Dictionary<string, ForeignKeyClass>();
            ew.allFKConstraints.Clear();

            ew.allDomains = new Dictionary<string, DomainClass>();
            ew.allDomains.Clear();

            ew.allGenerator = new Dictionary<string,GeneratorClass>();
            ew.allGenerator.Clear();

            ew.allTrigger = new Dictionary<string,TriggerClass>();
            ew.allTrigger.Clear();

            ew.allIndeces = new Dictionary<string,IndexClass>();
            ew.allIndeces.Clear();

            ew.allProcedures = new Dictionary<string, ProcedureClass>();
            ew.allProcedures.Clear();

            ew.allFunctions = new Dictionary<string, FunctionClass>();
            ew.allFunctions.Clear();

            ew.AktDBReg             = DBReg;
            ew.ShowScripting        = cbViewObjectScript.Checked;
            ew.WriteToFile          = eSQLFileWriteMode.none;
            ew.SQLDirectoryName     = string.Empty;
            ew.SQLFileName          = string.Empty;

            if(ckWriteFileForEVeryObject.Checked)
            {
              ew.WriteToFile = eSQLFileWriteMode.seperated;
            }
            else if(cbObjectExportToFile.Checked)
            {
              ew.WriteToFile = eSQLFileWriteMode.all;
            }

            ew.CommitAfterStatement         = cbStructureCommit.Checked;
            ew.CreateConnectionStatement    = cbStructureConnectiionStatement.Checked;
            ew.CreateDatabaseStatement      = cbStructureCreateDatabaseStatement.Checked;
            ew.CreateMode                   = (rbCREATEObject.Checked) ? eCreateMode.create : eCreateMode.recreate;
                                         
            if (ew.WriteToFile != eSQLFileWriteMode.none)
            {
                if ((txtFileName.Text.IndexOf(".")) < 0) txtFileName.Text += ".sql";
                
                ew.SQLDirectoryName = txtExportDirectory.Text;
                ew.SQLFileName = txtFileName.Text;
                ew.CharSet = cbCharSet.SelectedItem as EncodingClass;
            }                        
            
            
            ew.StartworkerGetDatabaseStructure(DBReg, ew.SQLDirectoryName, ew.SQLFileName);

            foreach (var itm in selExportStructureList.CheckedItemDatasNotNulls)
            {                
                if (itm.Object.GetType() == typeof(TableClass))
                {                    
                    ew.alltables.AddRange(ExportTableStructure(ew));
                    ew.StartworkerGetTableStructure(ew.alltables, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(ViewClass))
                {
                    ew.allviews.AddRange(ExportViewStructure(ew));
                    ew.StartworkerGetViewStructure(ew.allviews, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(PrimaryKeyClass))
                {
                    ExportPKTableStructure(ew);
                    ew.StartworkerGetPKTableStructure(ew.allPKConstraints, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(ForeignKeyClass))
                {
                    ExportFKTableStructure(ew);
                    ew.StartworkerGetFKTableStructure(ew.allFKConstraints, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(DomainClass))
                {
                    ExportDomainStructure(ew);
                    ew.StartworkerGetDomainStructure(ew.allDomains, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(GeneratorClass))
                {
                    ExportGeneratorStructure(ew);
                    ew.StartworkerGetGeneratorStructure(ew.allGenerator, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(IndexClass))
                {
                    ExportIndecesStructure(ew);
                    ew.StartworkerGetIndecesStructure(ew.allIndeces, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
                else if (itm.Object.GetType() == typeof(TriggerClass))
                {
                    ExportTriggerStructure(ew);
                    ew.StartworkerGetTriggerStructure(ew.allTrigger, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }                                
                else if (itm.Object.GetType() == typeof(ProcedureClass))
                {
                    ExportProcedureStructure(ew);
                    ew.StartworkerGetProcedureDefinitionStructure(ew.allProcedures, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                   
                    ew.StartworkerGetProcedureStructure(ew.allProcedures, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                } 
                else if (itm.Object.GetType() == typeof(FunctionClass))
                {
                    ExportFunctionStructure(ew);
                    ew.StartworkerGetFunctionDefinitionStructure(ew.allFunctions, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                   
                    ew.StartworkerGetFunctionStructure(ew.allFunctions, DBReg, ew.SQLDirectoryName, ew.SQLFileName);
                }
            }

            ew.WaitForWorker();

            if(ew.ShowScripting)
            {
              ew.MakeScript();
            }
            NotificationsForm.Instance().Close();
            
        }

        private List<TableClass> ExportTableStructure(ExportWorkers ew)
        {
            var allt = new List<TableClass>();
            for (int i = 0; i < selStructureTables.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selStructureTables.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;                
                if (tc?.GetType() != typeof(TableClass)) continue;                
                var ttc = (TableClass) tc;                
                ttc.State = selStructureTables.GetItemCheckState(i);                
                if (ttc.State != CheckState.Checked) continue;                                                                                                                                                                
                allt.Add(ttc);             
            }
            return allt;
        }

        private List<ViewClass> ExportViewStructure(ExportWorkers ew)
        {
            var allv = new List<ViewClass>();
            for (var i = 0; i < selStructureViews.ItemDatas.Count; i++)
            {
                var itm = (ItemDataClass) selStructureViews.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;
                if (tc?.GetType() != typeof(ViewClass)) continue;                                                                
                var tvc = (ViewClass) tc;
                tvc.State = selStructureViews.GetItemCheckState(i);                
                if (tvc.State != CheckState.Checked)  continue;                
                allv.Add(tvc);                                                                                        
            }
            return allv;
        }

        private void ExportDomainStructure(ExportWorkers ew)
        {
            for (var i = 0; i < selDomains.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selDomains.ItemDatas[i];
                if (itm == null) continue;                
                var tc = itm.Object as DataObjectClass;                
                if (tc?.GetType() != typeof(DomainClass)) continue;                
                var tdc = tc as DomainClass;                
                tdc.State = selDomains.GetItemCheckState(i);                
                if (tdc.State != CheckState.Checked) continue;                                                     
                ew.allDomains.Add(tdc.Name,tdc);                                                                                              
            }
        }

        private void ExportGeneratorStructure(ExportWorkers ew)
        {
            for (var i = 0; i < selGenerators.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selGenerators.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;                
                if (tc?.GetType() != typeof(GeneratorClass)) continue;
                var tgc = (GeneratorClass) tc;                
                tgc.State = selGenerators.GetItemCheckState(i);
                if (tgc.State != CheckState.Checked) continue;               
                ew.allGenerator.Add(tgc.Name,tgc);                                                                  
            }
        }

        private void ExportTriggerStructure(ExportWorkers ew)
        {
            for (int i = 0; i < selTriggerStructure.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selTriggerStructure.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;               
                if (tc?.GetType() != typeof(TriggerClass)) continue;
                var ttc = (TriggerClass) tc;                
                ttc.State = selTriggerStructure.GetItemCheckState(i);              
                if (ttc.State != CheckState.Checked) continue;                                
                ew.allTrigger.Add(ttc.Name,ttc);                                
            }
        }

        private void ExportProcedureStructure(ExportWorkers ew)
        {
            for (int i = 0; i < selProceduresStructure.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selProceduresStructure.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;               
                if (tc?.GetType() != typeof(ProcedureClass)) continue;
                var ttc = (ProcedureClass) tc;                
                ttc.State = selProceduresStructure.GetItemCheckState(i);              
                if (ttc.State != CheckState.Checked) continue;                                
                ew.allProcedures.Add(ttc.Name,ttc);                                
            }
        }

        private void ExportFunctionStructure(ExportWorkers ew)
        {
            for (int i = 0; i < selFunctionsStructure.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selFunctionsStructure.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;               
                if (tc?.GetType() != typeof(FunctionClass)) continue;
                var ttc = (FunctionClass) tc;                
                ttc.State = selFunctionsStructure.GetItemCheckState(i);              
                if (ttc.State != CheckState.Checked) continue;                                
                ew.allFunctions.Add(ttc.Name,ttc);                                
            }
        }



        private void ExportIndecesStructure(ExportWorkers ew)
        {
            for (var i = 0; i < selIndeces.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selIndeces.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;                
                if (tc?.GetType() != typeof(IndexClass)) continue;
                var tci = (IndexClass) tc;                
                tci.State = selIndeces.GetItemCheckState(i);
                if (tci.State != CheckState.Checked) continue;                                 
                ew.allIndeces.Add(tci.Name,tci);                             
            }
        }

        private void ExportPKTableStructure(ExportWorkers ew)
        {
            for (var i = 0; i < selStructureTables.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selStructureTables.ItemDatas[i];
                if (itm == null) continue;
                var tc = (DataObjectClass) itm.Object;                
                if (tc?.GetType() != typeof(TableClass)) continue;
                var ttc = (TableClass) tc;               
                ttc.State = selStructureTables.GetItemCheckState(i);
                if ((ttc.State != CheckState.Checked) || (ttc.primary_constraint == null)) continue;                    
                ew.allPKConstraints.Add(ttc.Name,ttc.primary_constraint);                                                       
            }
        }

        private void ExportFKTableStructure(ExportWorkers ew)
        {
            for (var i = 0; i < selStructureTables.ItemDatasNotNulls.Count; i++)
            {
                var itm = (ItemDataClass) selStructureTables.ItemDatas[i];
                if (itm == null) continue;
                var tc = itm.Object as DataObjectClass;                
                if (tc?.GetType() != typeof(TableClass)) continue;
                var tcc = (TableClass) tc;                
                tcc.State = selStructureTables.GetItemCheckState(i);
                if ((tcc.State != CheckState.Checked)|| (tcc.ForeignKeys == null)) continue;
                foreach (var fk in tcc.ForeignKeys.Values)
                {
                    if (fk == null) continue;                        
                    ew.allFKConstraints.Add(fk.Name,fk);                                                                                                   
                }                             
            }
        }
        
        private void hsSelectAllViews_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            selStructureViews.CheckChecks();            
        }

        private void hsUnselectAllViews_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            selStructureViews.ClearChecks();            
        }
        
        private void selStructureTables_SelectItem(object sender, SEListBox.SelectItemEventArgs e)
        {
            int i = e.RowIndex;            
        }

        private void SelectAllTableFields()
        {
            int n = selTables.ItemDatas.Count;
            for (int i = 0; i < n; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                selFields.ClearItems();
                foreach (var fld in tc.Fields.Values)
                {
                    selFields.Add(fld.ToString(), fld.State, fld);
                }
                selFields.CheckChecks();
            }
        }
        private void selTables_SelectItem(object sender, SEListBox.SelectItemEventArgs e)
        {
            var itm = selTables.ItemDatas[e.RowIndex] as ItemDataClass;
            var tc = itm.Object as TableClass;
            selFields.ClearItems();
            foreach (var fld in tc.Fields.Values)
            {
                selFields.Add(fld.ToString(), fld.State, fld);
            }
        }

        private void selFields_SelectItem(object sender, SEListBox.SelectItemEventArgs e)
        {
            int ri = e.RowIndex;
            var itm = selFields.ItemDatas[e.RowIndex] as ItemDataClass;
            var ob = itm.Object as TableFieldClass;

            if (itm.Check == CheckState.Checked) ob.State = CheckState.Unchecked;
            else ob.State = CheckState.Checked;
        }
        
        private void selTables_ItemCheckChanged(object sender, SEListBox.CheckItemEventArgs e)
        {            
            var itm = selTables.ItemDatas[e.RowIndex] as ItemDataClass;
            var tc = itm.Object as TableClass;
            selFields.ClearItems();
            foreach (var fld in tc.Fields.Values)
            {
                selFields.Add(fld.ToString(), itm.Check, fld);
            }           
        }

        private void selFields_ItemCheckChanged(object sender, CheckItemEventArgs e)
        {            
            var itm = selFields.ItemDatas[e.RowIndex] as ItemDataClass;
            var tc = itm.Object as TableFieldClass;
            tc.State = itm.Check;            
        }

        private void hotSpot4_Click_1(object sender, EventArgs e)
        {
            selDomains.CheckChecks();
        }

        private void hotSpot3_Click(object sender, EventArgs e)
        {
            selDomains.ClearChecks();
        }

        private void hotSpot5_Click(object sender, EventArgs e)
        {
            selIndeces.CheckChecks();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            selIndeces.ClearChecks();
        }

        private void hotSpot7_Click(object sender, EventArgs e)
        {
            selGenerators.CheckChecks();
        }

        private void hotSpot6_Click(object sender, EventArgs e)
        {
            selGenerators.ClearChecks();
        }

        private void hotSpot14_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            selExportStructureList.CheckChecks();      
        }

        private void hotSpot15_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            selExportStructureList.ClearChecks();      
        }

        private void hsExportFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtExportDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}

