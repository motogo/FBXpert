﻿namespace FBXpert
{
    sealed partial class DbExplorerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbExplorerForm));
            this.gbDatabases = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imlTree = new System.Windows.Forms.ImageList(this.components);
            this.cmsDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tstDatabase = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.tstConfiguration = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSQL = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstDesigners = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstStatistics = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tstDatas = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsGeneratorsGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsGenerator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsProcedure = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsProcedureGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsRoles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIndices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsTriggers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDomains = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFunctionGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsTriggerGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTableGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsDomainsGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIndicedGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsRolesGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsForeignKeysGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsForeignKeys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsConstraints = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsConstrainsGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPrimaryKeyGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPrimaryKeys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ofdLoadDefinition = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDefinition = new System.Windows.Forms.SaveFileDialog();
            this.cmsSystemTableGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSystemTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSystemTablesSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsUserDefinedFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUserDefinedFunctionGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hsRefreshDB = new SeControlsLib.HotSpot();
            this.hsDatabaseDefinitionSave = new SeControlsLib.HotSpot();
            this.hsLoadDefinition = new SeControlsLib.HotSpot();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDatabaseConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloneDatabaseConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewDatabaseConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteDatabaseRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQLScriptExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQLExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateXMLDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabaseDesigner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportDesigner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReplicationDesigner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompareDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEventsTracker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActiveConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIDBBinaries = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGeneratorInGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllGenerators = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshGenerators = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewProcedureGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllProcedures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshProcedures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditIndices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivateIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeactivateIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewFunctionGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllTriggers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllTables = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshAllTables = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllViews = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshViews = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlterCreateViewSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllDomains = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewIndices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllIndices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivateAllIndeces = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeactivateAllIndeces = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshIndeces = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForeignKeyNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllForeignKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshForeignKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditForeignKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropForeignKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditConstraint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropConstraint = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiRefreshConstraint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewConstraint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDroppAllConstraints = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshConstraints = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewPrimaryKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropAllPrimaryKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshPrimaryKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPrimaryKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDropPrimaryKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshSystemTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenSystemTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUserDefinedFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDatabases.SuspendLayout();
            this.cmsDatabase.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlLower.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsGeneratorsGroup.SuspendLayout();
            this.cmsGenerator.SuspendLayout();
            this.cmsProcedure.SuspendLayout();
            this.cmsProcedureGroup.SuspendLayout();
            this.cmsTable.SuspendLayout();
            this.cmsView.SuspendLayout();
            this.cmsRoles.SuspendLayout();
            this.cmsIndices.SuspendLayout();
            this.cmsFunctions.SuspendLayout();
            this.cmsTriggers.SuspendLayout();
            this.cmsDomains.SuspendLayout();
            this.cmsFunctionGroup.SuspendLayout();
            this.cmsTriggerGroup.SuspendLayout();
            this.cmsTableGroup.SuspendLayout();
            this.cmsViewGroup.SuspendLayout();
            this.cmsDomainsGroup.SuspendLayout();
            this.cmsIndicedGroup.SuspendLayout();
            this.cmsRolesGroup.SuspendLayout();
            this.cmsForeignKeysGroup.SuspendLayout();
            this.cmsForeignKeys.SuspendLayout();
            this.cmsConstraints.SuspendLayout();
            this.cmsConstrainsGroup.SuspendLayout();
            this.cmsPrimaryKeyGroup.SuspendLayout();
            this.cmsPrimaryKeys.SuspendLayout();
            this.cmsSystemTableGroup.SuspendLayout();
            this.cmsSystemTable.SuspendLayout();
            this.cmsUserDefinedFunctions.SuspendLayout();
            this.cmsUserDefinedFunctionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatabases
            // 
            this.gbDatabases.Controls.Add(this.treeView1);
            this.gbDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatabases.Location = new System.Drawing.Point(0, 0);
            this.gbDatabases.Name = "gbDatabases";
            this.gbDatabases.Size = new System.Drawing.Size(260, 437);
            this.gbDatabases.TabIndex = 0;
            this.gbDatabases.TabStop = false;
            this.gbDatabases.Text = "Databases";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imlTree;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(254, 418);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // imlTree
            // 
            this.imlTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTree.ImageStream")));
            this.imlTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTree.Images.SetKeyName(0, "ok_gn22x.png");
            this.imlTree.Images.SetKeyName(1, "database_gr_24x.png");
            this.imlTree.Images.SetKeyName(2, "database_check_gr_24x.png");
            this.imlTree.Images.SetKeyName(3, "table_blue_x24.png");
            this.imlTree.Images.SetKeyName(4, "view_green_24x.png");
            this.imlTree.Images.SetKeyName(5, "help_about_blue_x22.png");
            this.imlTree.Images.SetKeyName(6, "help_about_gn_x22.png");
            this.imlTree.Images.SetKeyName(7, "applications_system_22x.png");
            this.imlTree.Images.SetKeyName(8, "package_x24.png");
            this.imlTree.Images.SetKeyName(9, "applications_system_x22.png");
            this.imlTree.Images.SetKeyName(10, "view_sort_descending_x22.png");
            this.imlTree.Images.SetKeyName(11, "person_x32.png");
            this.imlTree.Images.SetKeyName(12, "keys_x22.png");
            this.imlTree.Images.SetKeyName(13, "rule_blue22x.png");
            this.imlTree.Images.SetKeyName(14, "field_22x.png");
            this.imlTree.Images.SetKeyName(15, "foreign_keys_x22.png");
            this.imlTree.Images.SetKeyName(16, "primary_keys_x22.png");
            this.imlTree.Images.SetKeyName(17, "unique_constraint_x22.png");
            this.imlTree.Images.SetKeyName(18, "notnull_constraint_x22.png");
            this.imlTree.Images.SetKeyName(19, "triggers_x22.png");
            this.imlTree.Images.SetKeyName(20, "check_constraint_x22.png");
            this.imlTree.Images.SetKeyName(21, "dependencyTO_22x.png");
            this.imlTree.Images.SetKeyName(22, "dependencyFROM_22x.png");
            // 
            // cmsDatabase
            // 
            this.cmsDatabase.AllowMerge = false;
            this.cmsDatabase.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstDatabase,
            this.tsmiOpen,
            this.tsmiClose,
            this.toolStripSeparator3,
            this.tsmiMoveUp,
            this.tsmiMoveDown,
            this.toolStripSeparator20,
            this.tstConfiguration,
            this.tsmiEditDatabaseConfig,
            this.tsmiCloneDatabaseConfiguration,
            this.tsmiNewDatabaseConfig,
            this.tsmiDeleteDatabaseRegistration,
            this.toolStripSeparator2,
            this.tstSQL,
            this.tsmiSQLScriptExplorer,
            this.tsmiSQLExplorer,
            this.toolStripSeparator1,
            this.tstDesigners,
            this.tsmiCreateXMLDesign,
            this.tsmiDatabaseDesigner,
            this.tsmiReportDesigner,
            this.tsmiReplicationDesigner,
            this.tsmiCompareDatabase,
            this.toolStripSeparator4,
            this.tstStatistics,
            this.tsmiStatistics,
            this.tsmiEventsTracker,
            this.tsmiActiveConnections,
            this.toolStripSeparator5,
            this.tstDatas,
            this.tsmiBackUp,
            this.tsmiExportData,
            this.toolStripSeparator21,
            this.tsmiIDBBinaries});
            this.cmsDatabase.Name = "cmsDatabase";
            this.cmsDatabase.Size = new System.Drawing.Size(253, 700);
            this.cmsDatabase.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMainGroupItems_Clicked);
            // 
            // tstDatabase
            // 
            this.tstDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tstDatabase.AutoSize = false;
            this.tstDatabase.BackColor = System.Drawing.SystemColors.Window;
            this.tstDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstDatabase.CausesValidation = false;
            this.tstDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstDatabase.Name = "tstDatabase";
            this.tstDatabase.ReadOnly = true;
            this.tstDatabase.ShortcutsEnabled = false;
            this.tstDatabase.Size = new System.Drawing.Size(100, 16);
            this.tstDatabase.Text = "Database";
            this.tstDatabase.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstDatabase.MouseEnter += new System.EventHandler(this.ToolStripTextBox_MouseEnter);
            this.tstDatabase.MouseLeave += new System.EventHandler(this.ToolStripTextBox_MouseLeave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(249, 6);
            // 
            // tstConfiguration
            // 
            this.tstConfiguration.AutoSize = false;
            this.tstConfiguration.BackColor = System.Drawing.SystemColors.Window;
            this.tstConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstConfiguration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstConfiguration.Name = "tstConfiguration";
            this.tstConfiguration.ReadOnly = true;
            this.tstConfiguration.ShortcutsEnabled = false;
            this.tstConfiguration.Size = new System.Drawing.Size(100, 16);
            this.tstConfiguration.Text = "Configuration";
            this.tstConfiguration.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstConfiguration.MouseEnter += new System.EventHandler(this.ToolStripTextBox_MouseEnter);
            this.tstConfiguration.MouseLeave += new System.EventHandler(this.ToolStripTextBox_MouseLeave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // tstSQL
            // 
            this.tstSQL.AutoSize = false;
            this.tstSQL.BackColor = System.Drawing.SystemColors.Window;
            this.tstSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstSQL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstSQL.Name = "tstSQL";
            this.tstSQL.ReadOnly = true;
            this.tstSQL.ShortcutsEnabled = false;
            this.tstSQL.Size = new System.Drawing.Size(100, 16);
            this.tstSQL.Text = "SQL";
            this.tstSQL.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstSQL.MouseEnter += new System.EventHandler(this.ToolStripTextBox_MouseEnter);
            this.tstSQL.MouseLeave += new System.EventHandler(this.ToolStripTextBox_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // tstDesigners
            // 
            this.tstDesigners.AutoSize = false;
            this.tstDesigners.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tstDesigners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstDesigners.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstDesigners.Name = "tstDesigners";
            this.tstDesigners.ReadOnly = true;
            this.tstDesigners.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tstDesigners.Size = new System.Drawing.Size(100, 16);
            this.tstDesigners.Text = "Designers";
            this.tstDesigners.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstDesigners.MouseEnter += new System.EventHandler(this.ToolStripTextBox_MouseEnter);
            this.tstDesigners.MouseLeave += new System.EventHandler(this.ToolStripTextBox_MouseLeave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(249, 6);
            // 
            // tstStatistics
            // 
            this.tstStatistics.AutoSize = false;
            this.tstStatistics.BackColor = System.Drawing.SystemColors.Window;
            this.tstStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstStatistics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstStatistics.Name = "tstStatistics";
            this.tstStatistics.ReadOnly = true;
            this.tstStatistics.ShortcutsEnabled = false;
            this.tstStatistics.Size = new System.Drawing.Size(100, 16);
            this.tstStatistics.Text = "Statisitcs";
            this.tstStatistics.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstStatistics.MouseEnter += new System.EventHandler(this.ToolStripTextBox_MouseEnter);
            this.tstStatistics.MouseLeave += new System.EventHandler(this.ToolStripTextBox_MouseLeave);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(249, 6);
            // 
            // tstDatas
            // 
            this.tstDatas.AutoSize = false;
            this.tstDatas.BackColor = System.Drawing.SystemColors.Window;
            this.tstDatas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstDatas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstDatas.Name = "tstDatas";
            this.tstDatas.ReadOnly = true;
            this.tstDatas.ShortcutsEnabled = false;
            this.tstDatas.Size = new System.Drawing.Size(100, 16);
            this.tstDatas.Text = "Datas";
            this.tstDatas.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstDatas.MouseEnter += new System.EventHandler(this.ToolStripTextBox_MouseEnter);
            this.tstDatas.MouseLeave += new System.EventHandler(this.ToolStripTextBox_MouseLeave);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(249, 6);
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUpper.Controls.Add(this.hsRefreshDB);
            this.pnlUpper.Controls.Add(this.hsDatabaseDefinitionSave);
            this.pnlUpper.Controls.Add(this.hsLoadDefinition);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(260, 42);
            this.pnlUpper.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.gbDatabases);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(260, 437);
            this.pnlCenter.TabIndex = 2;
            // 
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLower.Controls.Add(this.statusStrip1);
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 479);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(260, 21);
            this.pnlLower.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, -1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(260, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // cmsGeneratorsGroup
            // 
            this.cmsGeneratorsGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsGeneratorsGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGeneratorInGroup,
            this.tsmiDropAllGenerators,
            this.toolStripSeparator13,
            this.tsmiRefreshGenerators});
            this.cmsGeneratorsGroup.Name = "contextMenuStrip1";
            this.cmsGeneratorsGroup.Size = new System.Drawing.Size(179, 88);
            this.cmsGeneratorsGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(175, 6);
            // 
            // cmsGenerator
            // 
            this.cmsGenerator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsGenerator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditGenerator,
            this.tsmiDropGenerator,
            this.toolStripSeparator14,
            this.tsmiRefreshGenerator});
            this.cmsGenerator.Name = "contextMenuStrip1";
            this.cmsGenerator.Size = new System.Drawing.Size(172, 88);
            this.cmsGenerator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(168, 6);
            // 
            // cmsProcedure
            // 
            this.cmsProcedure.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProcedure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditProcedure,
            this.tsmiDropProcedure,
            this.toolStripSeparator12,
            this.tsmiRefreshProcedure});
            this.cmsProcedure.Name = "contextMenuStrip1";
            this.cmsProcedure.Size = new System.Drawing.Size(175, 88);
            this.cmsProcedure.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(171, 6);
            // 
            // cmsProcedureGroup
            // 
            this.cmsProcedureGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProcedureGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewProcedureGroup,
            this.tsmiDropAllProcedures,
            this.toolStripSeparator11,
            this.tsmiRefreshProcedures});
            this.cmsProcedureGroup.Name = "contextMenuStrip1";
            this.cmsProcedureGroup.Size = new System.Drawing.Size(182, 88);
            this.cmsProcedureGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(178, 6);
            // 
            // cmsTable
            // 
            this.cmsTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefreshTable,
            this.toolStripSeparator7,
            this.tsmiEditTable,
            this.tsmiDropTable});
            this.cmsTable.Name = "contextMenuStrip1";
            this.cmsTable.Size = new System.Drawing.Size(149, 88);
            this.cmsTable.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(145, 6);
            // 
            // cmsView
            // 
            this.cmsView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditView,
            this.tsmiDropView});
            this.cmsView.Name = "contextMenuStrip1";
            this.cmsView.Size = new System.Drawing.Size(132, 56);
            this.cmsView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // cmsRoles
            // 
            this.cmsRoles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditRole,
            this.tsmiDropRole});
            this.cmsRoles.Name = "contextMenuStrip1";
            this.cmsRoles.Size = new System.Drawing.Size(128, 56);
            this.cmsRoles.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // cmsIndices
            // 
            this.cmsIndices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsIndices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditIndices,
            this.tsmiNewIndex,
            this.tsmiDropIndex,
            this.toolStripSeparator22,
            this.tsmiActivateIndex,
            this.tsmiDeactivateIndex});
            this.cmsIndices.Name = "contextMenuStrip1";
            this.cmsIndices.Size = new System.Drawing.Size(165, 140);
            this.cmsIndices.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(161, 6);
            // 
            // cmsFunctions
            // 
            this.cmsFunctions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditFunction,
            this.tsmiDropFunction,
            this.toolStripSeparator9,
            this.tsmiRefreshFunction});
            this.cmsFunctions.Name = "contextMenuStrip1";
            this.cmsFunctions.Size = new System.Drawing.Size(153, 88);
            this.cmsFunctions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(149, 6);
            // 
            // cmsTriggers
            // 
            this.cmsTriggers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTriggers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditTrigger,
            this.tsmiDropTrigger});
            this.cmsTriggers.Name = "contextMenuStrip1";
            this.cmsTriggers.Size = new System.Drawing.Size(143, 56);
            this.cmsTriggers.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // cmsDomains
            // 
            this.cmsDomains.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDomains.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditDomain,
            this.tsmiDropDomain});
            this.cmsDomains.Name = "contextMenuStrip1";
            this.cmsDomains.Size = new System.Drawing.Size(149, 56);
            this.cmsDomains.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // cmsFunctionGroup
            // 
            this.cmsFunctionGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFunctionGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewFunctionGroup,
            this.tsmiDropAllFunctions,
            this.toolStripSeparator10,
            this.tsmiRefreshFunctions});
            this.cmsFunctionGroup.Name = "contextMenuStrip1";
            this.cmsFunctionGroup.Size = new System.Drawing.Size(173, 88);
            this.cmsFunctionGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(169, 6);
            // 
            // cmsTriggerGroup
            // 
            this.cmsTriggerGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTriggerGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewTrigger,
            this.tsmiDropAllTriggers});
            this.cmsTriggerGroup.Name = "contextMenuStrip1";
            this.cmsTriggerGroup.Size = new System.Drawing.Size(163, 56);
            // 
            // cmsTableGroup
            // 
            this.cmsTableGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTableGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewTable,
            this.tsmiDropAllTables,
            this.tsmiRefreshAllTables,
            this.toolStripSeparator19});
            this.cmsTableGroup.Name = "contextMenuStrip1";
            this.cmsTableGroup.Size = new System.Drawing.Size(167, 88);
            this.cmsTableGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(163, 6);
            // 
            // cmsViewGroup
            // 
            this.cmsViewGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsViewGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewView,
            this.tsmiDropAllViews,
            this.tsmiRefreshViews,
            this.toolStripSeparator18,
            this.tsmiAlterCreateViewSQL});
            this.cmsViewGroup.Name = "contextMenuStrip1";
            this.cmsViewGroup.Size = new System.Drawing.Size(167, 114);
            this.cmsViewGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(163, 6);
            // 
            // cmsDomainsGroup
            // 
            this.cmsDomainsGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDomainsGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewDomain,
            this.tsmiDropAllDomains});
            this.cmsDomainsGroup.Name = "contextMenuStrip1";
            this.cmsDomainsGroup.Size = new System.Drawing.Size(169, 56);
            this.cmsDomainsGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // cmsIndicedGroup
            // 
            this.cmsIndicedGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsIndicedGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewIndices,
            this.tsmiDropAllIndices,
            this.tsmiActivateAllIndeces,
            this.tsmiDeactivateAllIndeces,
            this.toolStripSeparator15,
            this.tsmiRefreshIndeces});
            this.cmsIndicedGroup.Name = "contextMenuStrip1";
            this.cmsIndicedGroup.Size = new System.Drawing.Size(189, 162);
            this.cmsIndicedGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(185, 6);
            // 
            // cmsRolesGroup
            // 
            this.cmsRolesGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRolesGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewRole,
            this.tsmiDropAllRoles});
            this.cmsRolesGroup.Name = "contextMenuStrip1";
            this.cmsRolesGroup.Size = new System.Drawing.Size(148, 56);
            // 
            // cmsForeignKeysGroup
            // 
            this.cmsForeignKeysGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsForeignKeysGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForeignKeyNew,
            this.tsmiDropAllForeignKeys,
            this.toolStripSeparator6,
            this.tsmiRefreshForeignKey});
            this.cmsForeignKeysGroup.Name = "contextMenuStrip1";
            this.cmsForeignKeysGroup.Size = new System.Drawing.Size(187, 88);
            this.cmsForeignKeysGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(183, 6);
            // 
            // cmsForeignKeys
            // 
            this.cmsForeignKeys.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsForeignKeys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditForeignKeys,
            this.tsmiDropForeignKey});
            this.cmsForeignKeys.Name = "contextMenuStrip1";
            this.cmsForeignKeys.Size = new System.Drawing.Size(170, 56);
            this.cmsForeignKeys.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // cmsConstraints
            // 
            this.cmsConstraints.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsConstraints.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditConstraint,
            this.tsmiDropConstraint,
            this.toolStripSeparator17,
            this.tmsiRefreshConstraint});
            this.cmsConstraints.Name = "contextMenuStrip1";
            this.cmsConstraints.Size = new System.Drawing.Size(182, 88);
            this.cmsConstraints.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(178, 6);
            // 
            // cmsConstrainsGroup
            // 
            this.cmsConstrainsGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsConstrainsGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewConstraint,
            this.tsmiDroppAllConstraints,
            this.toolStripSeparator16,
            this.tsmiRefreshConstraints});
            this.cmsConstrainsGroup.Name = "contextMenuStrip1";
            this.cmsConstrainsGroup.Size = new System.Drawing.Size(181, 88);
            this.cmsConstrainsGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(177, 6);
            // 
            // cmsPrimaryKeyGroup
            // 
            this.cmsPrimaryKeyGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPrimaryKeyGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewPrimaryKey,
            this.tsmiDropAllPrimaryKeys,
            this.toolStripSeparator8,
            this.tsmiRefreshPrimaryKeys});
            this.cmsPrimaryKeyGroup.Name = "contextMenuStrip1";
            this.cmsPrimaryKeyGroup.Size = new System.Drawing.Size(190, 88);
            this.cmsPrimaryKeyGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(186, 6);
            // 
            // cmsPrimaryKeys
            // 
            this.cmsPrimaryKeys.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPrimaryKeys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditPrimaryKey,
            this.tsmiDropPrimaryKey});
            this.cmsPrimaryKeys.Name = "contextMenuStrip1";
            this.cmsPrimaryKeys.Size = new System.Drawing.Size(171, 56);
            this.cmsPrimaryKeys.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // ofdLoadDefinition
            // 
            this.ofdLoadDefinition.DefaultExt = "*.XML";
            this.ofdLoadDefinition.Filter = "XML definitions|*.XML|All|*.*";
            // 
            // sfdSaveDefinition
            // 
            this.sfdSaveDefinition.DefaultExt = "*.XML";
            this.sfdSaveDefinition.Filter = "XML definition|*.XML|All|*.*";
            // 
            // cmsSystemTableGroup
            // 
            this.cmsSystemTableGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSystemTableGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.cmsSystemTableGroup.Name = "contextMenuStrip1";
            this.cmsSystemTableGroup.Size = new System.Drawing.Size(207, 30);
            // 
            // cmsSystemTable
            // 
            this.cmsSystemTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSystemTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefreshSystemTable,
            this.tsmiSystemTablesSeparator1,
            this.tsmiOpenSystemTable});
            this.cmsSystemTable.Name = "contextMenuStrip1";
            this.cmsSystemTable.Size = new System.Drawing.Size(187, 62);
            this.cmsSystemTable.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // tsmiSystemTablesSeparator1
            // 
            this.tsmiSystemTablesSeparator1.Name = "tsmiSystemTablesSeparator1";
            this.tsmiSystemTablesSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // cmsUserDefinedFunctions
            // 
            this.cmsUserDefinedFunctions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUserDefinedFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditUserDefinedFunctions});
            this.cmsUserDefinedFunctions.Name = "cmsUserDefinedFunctions";
            this.cmsUserDefinedFunctions.Size = new System.Drawing.Size(124, 30);
            this.cmsUserDefinedFunctions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClickedEditLevel);
            // 
            // cmsUserDefinedFunctionGroup
            // 
            this.cmsUserDefinedFunctionGroup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUserDefinedFunctionGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.cmsUserDefinedFunctionGroup.Name = "cmsUserDefinedFunctionGroup";
            this.cmsUserDefinedFunctionGroup.Size = new System.Drawing.Size(151, 30);
            this.cmsUserDefinedFunctionGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsGroup2Items_Clicked);
            // 
            // hsRefreshDB
            // 
            this.hsRefreshDB.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDB.BackColorHover = System.Drawing.SystemColors.AppWorkspace;
            this.hsRefreshDB.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDB.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshDB.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshDB.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshDB.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRefreshDB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshDB.FlatAppearance.BorderSize = 0;
            this.hsRefreshDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshDB.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDB.Image = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsRefreshDB.ImageHover = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsRefreshDB.ImageToggleOnSelect = true;
            this.hsRefreshDB.Location = new System.Drawing.Point(90, 0);
            this.hsRefreshDB.Marked = false;
            this.hsRefreshDB.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDB.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDB.MarkedText = "";
            this.hsRefreshDB.MarkMode = false;
            this.hsRefreshDB.Name = "hsRefreshDB";
            this.hsRefreshDB.NonMarkedText = "";
            this.hsRefreshDB.Size = new System.Drawing.Size(45, 42);
            this.hsRefreshDB.TabIndex = 8;
            this.hsRefreshDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshDB.ToolTipActive = true;
            this.hsRefreshDB.ToolTipAutomaticDelay = 500;
            this.hsRefreshDB.ToolTipAutoPopDelay = 5000;
            this.hsRefreshDB.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshDB.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshDB.ToolTipFor4ContextMenu = true;
            this.hsRefreshDB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshDB.ToolTipInitialDelay = 500;
            this.hsRefreshDB.ToolTipIsBallon = false;
            this.hsRefreshDB.ToolTipOwnerDraw = false;
            this.hsRefreshDB.ToolTipReshowDelay = 100;
            this.hsRefreshDB.ToolTipShowAlways = false;
            this.hsRefreshDB.ToolTipText = "Load database definitions";
            this.hsRefreshDB.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDB.ToolTipTitle = "";
            this.hsRefreshDB.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDB.UseVisualStyleBackColor = false;
            this.hsRefreshDB.Click += new System.EventHandler(this.hsRefreshDB_Click);
            // 
            // hsDatabaseDefinitionSave
            // 
            this.hsDatabaseDefinitionSave.BackColor = System.Drawing.Color.Transparent;
            this.hsDatabaseDefinitionSave.BackColorHover = System.Drawing.SystemColors.AppWorkspace;
            this.hsDatabaseDefinitionSave.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDatabaseDefinitionSave.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDatabaseDefinitionSave.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDatabaseDefinitionSave.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDatabaseDefinitionSave.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDatabaseDefinitionSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsDatabaseDefinitionSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDatabaseDefinitionSave.FlatAppearance.BorderSize = 0;
            this.hsDatabaseDefinitionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDatabaseDefinitionSave.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDatabaseDefinitionSave.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hsDatabaseDefinitionSave.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hsDatabaseDefinitionSave.ImageToggleOnSelect = true;
            this.hsDatabaseDefinitionSave.Location = new System.Drawing.Point(45, 0);
            this.hsDatabaseDefinitionSave.Marked = false;
            this.hsDatabaseDefinitionSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsDatabaseDefinitionSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDatabaseDefinitionSave.MarkedText = "";
            this.hsDatabaseDefinitionSave.MarkMode = false;
            this.hsDatabaseDefinitionSave.Name = "hsDatabaseDefinitionSave";
            this.hsDatabaseDefinitionSave.NonMarkedText = "";
            this.hsDatabaseDefinitionSave.Size = new System.Drawing.Size(45, 42);
            this.hsDatabaseDefinitionSave.TabIndex = 7;
            this.hsDatabaseDefinitionSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDatabaseDefinitionSave.ToolTipActive = true;
            this.hsDatabaseDefinitionSave.ToolTipAutomaticDelay = 500;
            this.hsDatabaseDefinitionSave.ToolTipAutoPopDelay = 5000;
            this.hsDatabaseDefinitionSave.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDatabaseDefinitionSave.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDatabaseDefinitionSave.ToolTipFor4ContextMenu = true;
            this.hsDatabaseDefinitionSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDatabaseDefinitionSave.ToolTipInitialDelay = 500;
            this.hsDatabaseDefinitionSave.ToolTipIsBallon = false;
            this.hsDatabaseDefinitionSave.ToolTipOwnerDraw = false;
            this.hsDatabaseDefinitionSave.ToolTipReshowDelay = 100;
            this.hsDatabaseDefinitionSave.ToolTipShowAlways = false;
            this.hsDatabaseDefinitionSave.ToolTipText = "Save database definitions";
            this.hsDatabaseDefinitionSave.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDatabaseDefinitionSave.ToolTipTitle = "";
            this.hsDatabaseDefinitionSave.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDatabaseDefinitionSave.UseVisualStyleBackColor = false;
            this.hsDatabaseDefinitionSave.Click += new System.EventHandler(this.hsDatabaseDefinitionSave_Click);
            // 
            // hsLoadDefinition
            // 
            this.hsLoadDefinition.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadDefinition.BackColorHover = System.Drawing.SystemColors.AppWorkspace;
            this.hsLoadDefinition.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefinition.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadDefinition.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadDefinition.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadDefinition.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadDefinition.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadDefinition.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadDefinition.FlatAppearance.BorderSize = 0;
            this.hsLoadDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadDefinition.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadDefinition.Image = global::FBXpert.Properties.Resources.data_import_gn_x24;
            this.hsLoadDefinition.ImageHover = global::FBXpert.Properties.Resources.data_import_blue_x24;
            this.hsLoadDefinition.ImageToggleOnSelect = true;
            this.hsLoadDefinition.Location = new System.Drawing.Point(0, 0);
            this.hsLoadDefinition.Marked = false;
            this.hsLoadDefinition.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadDefinition.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadDefinition.MarkedText = "";
            this.hsLoadDefinition.MarkMode = false;
            this.hsLoadDefinition.Name = "hsLoadDefinition";
            this.hsLoadDefinition.NonMarkedText = "";
            this.hsLoadDefinition.Size = new System.Drawing.Size(45, 42);
            this.hsLoadDefinition.TabIndex = 6;
            this.hsLoadDefinition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadDefinition.ToolTipActive = true;
            this.hsLoadDefinition.ToolTipAutomaticDelay = 500;
            this.hsLoadDefinition.ToolTipAutoPopDelay = 5000;
            this.hsLoadDefinition.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadDefinition.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadDefinition.ToolTipFor4ContextMenu = true;
            this.hsLoadDefinition.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadDefinition.ToolTipInitialDelay = 500;
            this.hsLoadDefinition.ToolTipIsBallon = false;
            this.hsLoadDefinition.ToolTipOwnerDraw = false;
            this.hsLoadDefinition.ToolTipReshowDelay = 100;
            this.hsLoadDefinition.ToolTipShowAlways = false;
            this.hsLoadDefinition.ToolTipText = "Load database definitions";
            this.hsLoadDefinition.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadDefinition.ToolTipTitle = "";
            this.hsLoadDefinition.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadDefinition.UseVisualStyleBackColor = false;
            this.hsLoadDefinition.Click += new System.EventHandler(this.hsLoadDefinition_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Image = global::FBXpert.Properties.Resources.on_gn_24x;
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(252, 26);
            this.tsmiOpen.Text = "Open";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(252, 26);
            this.tsmiClose.Text = "Close";
            // 
            // tsmiMoveUp
            // 
            this.tsmiMoveUp.Image = global::FBXpert.Properties.Resources.go_up_gn22x;
            this.tsmiMoveUp.Name = "tsmiMoveUp";
            this.tsmiMoveUp.Size = new System.Drawing.Size(252, 26);
            this.tsmiMoveUp.Text = "Move up";
            // 
            // tsmiMoveDown
            // 
            this.tsmiMoveDown.Image = global::FBXpert.Properties.Resources.go_down22x;
            this.tsmiMoveDown.Name = "tsmiMoveDown";
            this.tsmiMoveDown.Size = new System.Drawing.Size(252, 26);
            this.tsmiMoveDown.Text = "Move down";
            // 
            // tsmiEditDatabaseConfig
            // 
            this.tsmiEditDatabaseConfig.Image = global::FBXpert.Properties.Resources.database_gr_24x;
            this.tsmiEditDatabaseConfig.Name = "tsmiEditDatabaseConfig";
            this.tsmiEditDatabaseConfig.Size = new System.Drawing.Size(252, 26);
            this.tsmiEditDatabaseConfig.Text = "Edit Database Configuration";
            // 
            // tsmiCloneDatabaseConfiguration
            // 
            this.tsmiCloneDatabaseConfiguration.Image = global::FBXpert.Properties.Resources.database_add;
            this.tsmiCloneDatabaseConfiguration.Name = "tsmiCloneDatabaseConfiguration";
            this.tsmiCloneDatabaseConfiguration.Size = new System.Drawing.Size(252, 26);
            this.tsmiCloneDatabaseConfiguration.Text = "Clone Database Configuration";
            // 
            // tsmiNewDatabaseConfig
            // 
            this.tsmiNewDatabaseConfig.Image = global::FBXpert.Properties.Resources.database_add_24x;
            this.tsmiNewDatabaseConfig.Name = "tsmiNewDatabaseConfig";
            this.tsmiNewDatabaseConfig.Size = new System.Drawing.Size(252, 26);
            this.tsmiNewDatabaseConfig.Text = "New Database Configuration";
            // 
            // tsmiDeleteDatabaseRegistration
            // 
            this.tsmiDeleteDatabaseRegistration.Image = global::FBXpert.Properties.Resources.database_erase_24;
            this.tsmiDeleteDatabaseRegistration.Name = "tsmiDeleteDatabaseRegistration";
            this.tsmiDeleteDatabaseRegistration.Size = new System.Drawing.Size(252, 26);
            this.tsmiDeleteDatabaseRegistration.Text = "Delete Database Configuration";
            // 
            // tsmiSQLScriptExplorer
            // 
            this.tsmiSQLScriptExplorer.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiSQLScriptExplorer.Name = "tsmiSQLScriptExplorer";
            this.tsmiSQLScriptExplorer.Size = new System.Drawing.Size(252, 26);
            this.tsmiSQLScriptExplorer.Text = "Script-Explorer";
            // 
            // tsmiSQLExplorer
            // 
            this.tsmiSQLExplorer.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiSQLExplorer.Name = "tsmiSQLExplorer";
            this.tsmiSQLExplorer.Size = new System.Drawing.Size(252, 26);
            this.tsmiSQLExplorer.Text = "SQL-Explorer";
            // 
            // tsmiCreateXMLDesign
            // 
            this.tsmiCreateXMLDesign.Image = global::FBXpert.Properties.Resources.document_blue_x32;
            this.tsmiCreateXMLDesign.Name = "tsmiCreateXMLDesign";
            this.tsmiCreateXMLDesign.Size = new System.Drawing.Size(252, 26);
            this.tsmiCreateXMLDesign.Text = "XML and Sourcecode designer";
            // 
            // tsmiDatabaseDesigner
            // 
            this.tsmiDatabaseDesigner.Image = global::FBXpert.Properties.Resources.applications_system_blue_x22;
            this.tsmiDatabaseDesigner.Name = "tsmiDatabaseDesigner";
            this.tsmiDatabaseDesigner.Size = new System.Drawing.Size(252, 26);
            this.tsmiDatabaseDesigner.Text = "Database designer";
            // 
            // tsmiReportDesigner
            // 
            this.tsmiReportDesigner.Image = global::FBXpert.Properties.Resources.applications_execute_script_blue_22x;
            this.tsmiReportDesigner.Name = "tsmiReportDesigner";
            this.tsmiReportDesigner.Size = new System.Drawing.Size(252, 26);
            this.tsmiReportDesigner.Text = "Report designer";
            // 
            // tsmiReplicationDesigner
            // 
            this.tsmiReplicationDesigner.Image = global::FBXpert.Properties.Resources.database_replication_x24;
            this.tsmiReplicationDesigner.Name = "tsmiReplicationDesigner";
            this.tsmiReplicationDesigner.Size = new System.Drawing.Size(252, 26);
            this.tsmiReplicationDesigner.Text = "Replication designer";
            // 
            // tsmiCompareDatabase
            // 
            this.tsmiCompareDatabase.Image = global::FBXpert.Properties.Resources.view_blue_x32;
            this.tsmiCompareDatabase.Name = "tsmiCompareDatabase";
            this.tsmiCompareDatabase.Size = new System.Drawing.Size(252, 26);
            this.tsmiCompareDatabase.Text = "Compare database";
            // 
            // tsmiStatistics
            // 
            this.tsmiStatistics.Image = global::FBXpert.Properties.Resources.graph_24x;
            this.tsmiStatistics.Name = "tsmiStatistics";
            this.tsmiStatistics.Size = new System.Drawing.Size(252, 26);
            this.tsmiStatistics.Text = "Statistics";
            // 
            // tsmiEventsTracker
            // 
            this.tsmiEventsTracker.Image = global::FBXpert.Properties.Resources.graph_24x;
            this.tsmiEventsTracker.Name = "tsmiEventsTracker";
            this.tsmiEventsTracker.Size = new System.Drawing.Size(252, 26);
            this.tsmiEventsTracker.Text = "Eventstracker";
            // 
            // tsmiActiveConnections
            // 
            this.tsmiActiveConnections.Image = global::FBXpert.Properties.Resources.system_search_blue_22x;
            this.tsmiActiveConnections.Name = "tsmiActiveConnections";
            this.tsmiActiveConnections.Size = new System.Drawing.Size(252, 26);
            this.tsmiActiveConnections.Text = "Active Connections / Monitoring";
            // 
            // tsmiBackUp
            // 
            this.tsmiBackUp.Image = global::FBXpert.Properties.Resources.database_arrow_r_x24;
            this.tsmiBackUp.Name = "tsmiBackUp";
            this.tsmiBackUp.Size = new System.Drawing.Size(252, 26);
            this.tsmiBackUp.Text = "Backup/Restore";
            // 
            // tsmiExportData
            // 
            this.tsmiExportData.Image = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.tsmiExportData.Name = "tsmiExportData";
            this.tsmiExportData.Size = new System.Drawing.Size(252, 26);
            this.tsmiExportData.Text = "Export data";
            // 
            // tsmiIDBBinaries
            // 
            this.tsmiIDBBinaries.Image = global::FBXpert.Properties.Resources.console_x24;
            this.tsmiIDBBinaries.Name = "tsmiIDBBinaries";
            this.tsmiIDBBinaries.Size = new System.Drawing.Size(252, 26);
            this.tsmiIDBBinaries.Text = "FB Binaries";
            // 
            // tsmiNewGeneratorInGroup
            // 
            this.tsmiNewGeneratorInGroup.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewGeneratorInGroup.Name = "tsmiNewGeneratorInGroup";
            this.tsmiNewGeneratorInGroup.Size = new System.Drawing.Size(178, 26);
            this.tsmiNewGeneratorInGroup.Text = "New generator";
            // 
            // tsmiDropAllGenerators
            // 
            this.tsmiDropAllGenerators.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllGenerators.Name = "tsmiDropAllGenerators";
            this.tsmiDropAllGenerators.Size = new System.Drawing.Size(178, 26);
            this.tsmiDropAllGenerators.Text = "Drop all generators";
            // 
            // tsmiRefreshGenerators
            // 
            this.tsmiRefreshGenerators.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshGenerators.Name = "tsmiRefreshGenerators";
            this.tsmiRefreshGenerators.Size = new System.Drawing.Size(178, 26);
            this.tsmiRefreshGenerators.Text = "Refresh generator";
            // 
            // tsmiEditGenerator
            // 
            this.tsmiEditGenerator.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditGenerator.Name = "tsmiEditGenerator";
            this.tsmiEditGenerator.Size = new System.Drawing.Size(171, 26);
            this.tsmiEditGenerator.Text = "Edit generator";
            // 
            // tsmiDropGenerator
            // 
            this.tsmiDropGenerator.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropGenerator.Name = "tsmiDropGenerator";
            this.tsmiDropGenerator.Size = new System.Drawing.Size(171, 26);
            this.tsmiDropGenerator.Text = "Drop generator";
            // 
            // tsmiRefreshGenerator
            // 
            this.tsmiRefreshGenerator.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshGenerator.Name = "tsmiRefreshGenerator";
            this.tsmiRefreshGenerator.Size = new System.Drawing.Size(171, 26);
            this.tsmiRefreshGenerator.Text = "Refresh generator";
            // 
            // tsmiEditProcedure
            // 
            this.tsmiEditProcedure.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditProcedure.Name = "tsmiEditProcedure";
            this.tsmiEditProcedure.Size = new System.Drawing.Size(174, 26);
            this.tsmiEditProcedure.Text = "Edit procedure";
            // 
            // tsmiDropProcedure
            // 
            this.tsmiDropProcedure.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropProcedure.Name = "tsmiDropProcedure";
            this.tsmiDropProcedure.Size = new System.Drawing.Size(174, 26);
            this.tsmiDropProcedure.Text = "Drop procedure";
            // 
            // tsmiRefreshProcedure
            // 
            this.tsmiRefreshProcedure.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshProcedure.Name = "tsmiRefreshProcedure";
            this.tsmiRefreshProcedure.Size = new System.Drawing.Size(174, 26);
            this.tsmiRefreshProcedure.Text = "Refresh procedure";
            // 
            // tsmiNewProcedureGroup
            // 
            this.tsmiNewProcedureGroup.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewProcedureGroup.Name = "tsmiNewProcedureGroup";
            this.tsmiNewProcedureGroup.Size = new System.Drawing.Size(181, 26);
            this.tsmiNewProcedureGroup.Text = "New procedure";
            // 
            // tsmiDropAllProcedures
            // 
            this.tsmiDropAllProcedures.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllProcedures.Name = "tsmiDropAllProcedures";
            this.tsmiDropAllProcedures.Size = new System.Drawing.Size(181, 26);
            this.tsmiDropAllProcedures.Text = "Drop all procedures";
            // 
            // tsmiRefreshProcedures
            // 
            this.tsmiRefreshProcedures.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshProcedures.Name = "tsmiRefreshProcedures";
            this.tsmiRefreshProcedures.Size = new System.Drawing.Size(181, 26);
            this.tsmiRefreshProcedures.Text = "Refresh procedures";
            // 
            // tsmiRefreshTable
            // 
            this.tsmiRefreshTable.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshTable.Name = "tsmiRefreshTable";
            this.tsmiRefreshTable.Size = new System.Drawing.Size(148, 26);
            this.tsmiRefreshTable.Text = "Refresh Table";
            // 
            // tsmiEditTable
            // 
            this.tsmiEditTable.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditTable.Name = "tsmiEditTable";
            this.tsmiEditTable.Size = new System.Drawing.Size(148, 26);
            this.tsmiEditTable.Text = "Edit table";
            // 
            // tsmiDropTable
            // 
            this.tsmiDropTable.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropTable.Name = "tsmiDropTable";
            this.tsmiDropTable.Size = new System.Drawing.Size(148, 26);
            this.tsmiDropTable.Text = "Drop table";
            // 
            // tsmiEditView
            // 
            this.tsmiEditView.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditView.Name = "tsmiEditView";
            this.tsmiEditView.Size = new System.Drawing.Size(131, 26);
            this.tsmiEditView.Text = "Edit view";
            // 
            // tsmiDropView
            // 
            this.tsmiDropView.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropView.Name = "tsmiDropView";
            this.tsmiDropView.Size = new System.Drawing.Size(131, 26);
            this.tsmiDropView.Text = "Drop view";
            // 
            // tsmiEditRole
            // 
            this.tsmiEditRole.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditRole.Name = "tsmiEditRole";
            this.tsmiEditRole.Size = new System.Drawing.Size(127, 26);
            this.tsmiEditRole.Text = "Edit role";
            // 
            // tsmiDropRole
            // 
            this.tsmiDropRole.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropRole.Name = "tsmiDropRole";
            this.tsmiDropRole.Size = new System.Drawing.Size(127, 26);
            this.tsmiDropRole.Text = "Drop role";
            // 
            // tsmiEditIndices
            // 
            this.tsmiEditIndices.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditIndices.Name = "tsmiEditIndices";
            this.tsmiEditIndices.Size = new System.Drawing.Size(164, 26);
            this.tsmiEditIndices.Text = "Edit index";
            // 
            // tsmiNewIndex
            // 
            this.tsmiNewIndex.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.tsmiNewIndex.Name = "tsmiNewIndex";
            this.tsmiNewIndex.Size = new System.Drawing.Size(164, 26);
            this.tsmiNewIndex.Text = "New Index";
            // 
            // tsmiDropIndex
            // 
            this.tsmiDropIndex.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropIndex.Name = "tsmiDropIndex";
            this.tsmiDropIndex.Size = new System.Drawing.Size(164, 26);
            this.tsmiDropIndex.Text = "Drop index";
            // 
            // tsmiActivateIndex
            // 
            this.tsmiActivateIndex.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.tsmiActivateIndex.Name = "tsmiActivateIndex";
            this.tsmiActivateIndex.Size = new System.Drawing.Size(164, 26);
            this.tsmiActivateIndex.Text = "Activate index";
            // 
            // tsmiDeactivateIndex
            // 
            this.tsmiDeactivateIndex.Image = global::FBXpert.Properties.Resources.NoGo_22;
            this.tsmiDeactivateIndex.Name = "tsmiDeactivateIndex";
            this.tsmiDeactivateIndex.Size = new System.Drawing.Size(164, 26);
            this.tsmiDeactivateIndex.Text = "Deactivate index";
            // 
            // tsmiEditFunction
            // 
            this.tsmiEditFunction.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditFunction.Name = "tsmiEditFunction";
            this.tsmiEditFunction.Size = new System.Drawing.Size(152, 26);
            this.tsmiEditFunction.Text = "Edit function";
            // 
            // tsmiDropFunction
            // 
            this.tsmiDropFunction.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropFunction.Name = "tsmiDropFunction";
            this.tsmiDropFunction.Size = new System.Drawing.Size(152, 26);
            this.tsmiDropFunction.Text = "Drop function";
            // 
            // tsmiRefreshFunction
            // 
            this.tsmiRefreshFunction.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshFunction.Name = "tsmiRefreshFunction";
            this.tsmiRefreshFunction.Size = new System.Drawing.Size(152, 26);
            this.tsmiRefreshFunction.Text = "Refresh";
            // 
            // tsmiEditTrigger
            // 
            this.tsmiEditTrigger.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditTrigger.Name = "tsmiEditTrigger";
            this.tsmiEditTrigger.Size = new System.Drawing.Size(142, 26);
            this.tsmiEditTrigger.Text = "Edit trigger";
            // 
            // tsmiDropTrigger
            // 
            this.tsmiDropTrigger.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropTrigger.Name = "tsmiDropTrigger";
            this.tsmiDropTrigger.Size = new System.Drawing.Size(142, 26);
            this.tsmiDropTrigger.Text = "Drop trigger";
            // 
            // tsmiEditDomain
            // 
            this.tsmiEditDomain.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditDomain.Name = "tsmiEditDomain";
            this.tsmiEditDomain.Size = new System.Drawing.Size(148, 26);
            this.tsmiEditDomain.Text = "Edit domain";
            // 
            // tsmiDropDomain
            // 
            this.tsmiDropDomain.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropDomain.Name = "tsmiDropDomain";
            this.tsmiDropDomain.Size = new System.Drawing.Size(148, 26);
            this.tsmiDropDomain.Text = "Drop domain";
            // 
            // tsmiNewFunctionGroup
            // 
            this.tsmiNewFunctionGroup.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewFunctionGroup.Name = "tsmiNewFunctionGroup";
            this.tsmiNewFunctionGroup.Size = new System.Drawing.Size(172, 26);
            this.tsmiNewFunctionGroup.Text = "New function";
            // 
            // tsmiDropAllFunctions
            // 
            this.tsmiDropAllFunctions.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllFunctions.Name = "tsmiDropAllFunctions";
            this.tsmiDropAllFunctions.Size = new System.Drawing.Size(172, 26);
            this.tsmiDropAllFunctions.Text = "Drop all functions";
            // 
            // tsmiRefreshFunctions
            // 
            this.tsmiRefreshFunctions.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshFunctions.Name = "tsmiRefreshFunctions";
            this.tsmiRefreshFunctions.Size = new System.Drawing.Size(172, 26);
            this.tsmiRefreshFunctions.Text = "Refresh functions";
            // 
            // tsmiNewTrigger
            // 
            this.tsmiNewTrigger.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewTrigger.Name = "tsmiNewTrigger";
            this.tsmiNewTrigger.Size = new System.Drawing.Size(162, 26);
            this.tsmiNewTrigger.Text = "New trigger";
            // 
            // tsmiDropAllTriggers
            // 
            this.tsmiDropAllTriggers.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllTriggers.Name = "tsmiDropAllTriggers";
            this.tsmiDropAllTriggers.Size = new System.Drawing.Size(162, 26);
            this.tsmiDropAllTriggers.Text = "Drop all triggers";
            // 
            // tsmiNewTable
            // 
            this.tsmiNewTable.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewTable.Name = "tsmiNewTable";
            this.tsmiNewTable.Size = new System.Drawing.Size(166, 26);
            this.tsmiNewTable.Text = "New table";
            // 
            // tsmiDropAllTables
            // 
            this.tsmiDropAllTables.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllTables.Name = "tsmiDropAllTables";
            this.tsmiDropAllTables.Size = new System.Drawing.Size(166, 26);
            this.tsmiDropAllTables.Text = "Drop all tables";
            // 
            // tsmiRefreshAllTables
            // 
            this.tsmiRefreshAllTables.Image = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.tsmiRefreshAllTables.Name = "tsmiRefreshAllTables";
            this.tsmiRefreshAllTables.Size = new System.Drawing.Size(166, 26);
            this.tsmiRefreshAllTables.Text = "Refresh all tables";
            // 
            // tsmiNewView
            // 
            this.tsmiNewView.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewView.Name = "tsmiNewView";
            this.tsmiNewView.Size = new System.Drawing.Size(166, 26);
            this.tsmiNewView.Text = "New view";
            // 
            // tsmiDropAllViews
            // 
            this.tsmiDropAllViews.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllViews.Name = "tsmiDropAllViews";
            this.tsmiDropAllViews.Size = new System.Drawing.Size(166, 26);
            this.tsmiDropAllViews.Text = "Drop all views";
            // 
            // tsmiRefreshViews
            // 
            this.tsmiRefreshViews.Image = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.tsmiRefreshViews.Name = "tsmiRefreshViews";
            this.tsmiRefreshViews.Size = new System.Drawing.Size(166, 26);
            this.tsmiRefreshViews.Text = "Refresh views";
            // 
            // tsmiAlterCreateViewSQL
            // 
            this.tsmiAlterCreateViewSQL.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiAlterCreateViewSQL.Name = "tsmiAlterCreateViewSQL";
            this.tsmiAlterCreateViewSQL.Size = new System.Drawing.Size(166, 26);
            this.tsmiAlterCreateViewSQL.Text = "Alter-Create SQL";
            // 
            // tsmiNewDomain
            // 
            this.tsmiNewDomain.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewDomain.Name = "tsmiNewDomain";
            this.tsmiNewDomain.Size = new System.Drawing.Size(168, 26);
            this.tsmiNewDomain.Text = "New domain";
            // 
            // tsmiDropAllDomains
            // 
            this.tsmiDropAllDomains.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllDomains.Name = "tsmiDropAllDomains";
            this.tsmiDropAllDomains.Size = new System.Drawing.Size(168, 26);
            this.tsmiDropAllDomains.Text = "Drop all domains";
            // 
            // tsmiNewIndices
            // 
            this.tsmiNewIndices.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewIndices.Name = "tsmiNewIndices";
            this.tsmiNewIndices.Size = new System.Drawing.Size(188, 26);
            this.tsmiNewIndices.Text = "New indices";
            // 
            // tsmiDropAllIndices
            // 
            this.tsmiDropAllIndices.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllIndices.Name = "tsmiDropAllIndices";
            this.tsmiDropAllIndices.Size = new System.Drawing.Size(188, 26);
            this.tsmiDropAllIndices.Text = "Drop all indices";
            // 
            // tsmiActivateAllIndeces
            // 
            this.tsmiActivateAllIndeces.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.tsmiActivateAllIndeces.Name = "tsmiActivateAllIndeces";
            this.tsmiActivateAllIndeces.Size = new System.Drawing.Size(188, 26);
            this.tsmiActivateAllIndeces.Text = "Activate all indices";
            // 
            // tsmiDeactivateAllIndeces
            // 
            this.tsmiDeactivateAllIndeces.Image = global::FBXpert.Properties.Resources.NoGo_22;
            this.tsmiDeactivateAllIndeces.Name = "tsmiDeactivateAllIndeces";
            this.tsmiDeactivateAllIndeces.Size = new System.Drawing.Size(188, 26);
            this.tsmiDeactivateAllIndeces.Text = "Deactivate all indices";
            // 
            // tsmiRefreshIndeces
            // 
            this.tsmiRefreshIndeces.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshIndeces.Name = "tsmiRefreshIndeces";
            this.tsmiRefreshIndeces.Size = new System.Drawing.Size(188, 26);
            this.tsmiRefreshIndeces.Text = "Refresh indices";
            // 
            // tsmiNewRole
            // 
            this.tsmiNewRole.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewRole.Name = "tsmiNewRole";
            this.tsmiNewRole.Size = new System.Drawing.Size(147, 26);
            this.tsmiNewRole.Text = "New role";
            // 
            // tsmiDropAllRoles
            // 
            this.tsmiDropAllRoles.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllRoles.Name = "tsmiDropAllRoles";
            this.tsmiDropAllRoles.Size = new System.Drawing.Size(147, 26);
            this.tsmiDropAllRoles.Text = "Drop all roles";
            // 
            // tsmiForeignKeyNew
            // 
            this.tsmiForeignKeyNew.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiForeignKeyNew.Name = "tsmiForeignKeyNew";
            this.tsmiForeignKeyNew.Size = new System.Drawing.Size(186, 26);
            this.tsmiForeignKeyNew.Text = "New foreign key";
            // 
            // tsmiDropAllForeignKeys
            // 
            this.tsmiDropAllForeignKeys.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllForeignKeys.Name = "tsmiDropAllForeignKeys";
            this.tsmiDropAllForeignKeys.Size = new System.Drawing.Size(186, 26);
            this.tsmiDropAllForeignKeys.Text = "Drop all foreign keys";
            // 
            // tsmiRefreshForeignKey
            // 
            this.tsmiRefreshForeignKey.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshForeignKey.Name = "tsmiRefreshForeignKey";
            this.tsmiRefreshForeignKey.Size = new System.Drawing.Size(186, 26);
            this.tsmiRefreshForeignKey.Text = "Refresh foreign keys";
            // 
            // tsmiEditForeignKeys
            // 
            this.tsmiEditForeignKeys.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditForeignKeys.Name = "tsmiEditForeignKeys";
            this.tsmiEditForeignKeys.Size = new System.Drawing.Size(169, 26);
            this.tsmiEditForeignKeys.Text = "Edit Foreign Key";
            // 
            // tsmiDropForeignKey
            // 
            this.tsmiDropForeignKey.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropForeignKey.Name = "tsmiDropForeignKey";
            this.tsmiDropForeignKey.Size = new System.Drawing.Size(169, 26);
            this.tsmiDropForeignKey.Text = "Drop Foreign Key";
            // 
            // tsmiEditConstraint
            // 
            this.tsmiEditConstraint.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditConstraint.Name = "tsmiEditConstraint";
            this.tsmiEditConstraint.Size = new System.Drawing.Size(181, 26);
            this.tsmiEditConstraint.Text = "Edit constraint";
            // 
            // tsmiDropConstraint
            // 
            this.tsmiDropConstraint.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropConstraint.Name = "tsmiDropConstraint";
            this.tsmiDropConstraint.Size = new System.Drawing.Size(181, 26);
            this.tsmiDropConstraint.Text = "Drop constraint";
            // 
            // tmsiRefreshConstraint
            // 
            this.tmsiRefreshConstraint.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tmsiRefreshConstraint.Name = "tmsiRefreshConstraint";
            this.tmsiRefreshConstraint.Size = new System.Drawing.Size(181, 26);
            this.tmsiRefreshConstraint.Text = "Refresh constraint x";
            // 
            // tsmiNewConstraint
            // 
            this.tsmiNewConstraint.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewConstraint.Name = "tsmiNewConstraint";
            this.tsmiNewConstraint.Size = new System.Drawing.Size(180, 26);
            this.tsmiNewConstraint.Text = "New constraint";
            // 
            // tsmiDroppAllConstraints
            // 
            this.tsmiDroppAllConstraints.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDroppAllConstraints.Name = "tsmiDroppAllConstraints";
            this.tsmiDroppAllConstraints.Size = new System.Drawing.Size(180, 26);
            this.tsmiDroppAllConstraints.Text = "Drop all constraints";
            // 
            // tsmiRefreshConstraints
            // 
            this.tsmiRefreshConstraints.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshConstraints.Name = "tsmiRefreshConstraints";
            this.tsmiRefreshConstraints.Size = new System.Drawing.Size(180, 26);
            this.tsmiRefreshConstraints.Text = "Refresh contraints";
            // 
            // tsmiNewPrimaryKey
            // 
            this.tsmiNewPrimaryKey.Image = global::FBXpert.Properties.Resources.help_about_blue_x22;
            this.tsmiNewPrimaryKey.Name = "tsmiNewPrimaryKey";
            this.tsmiNewPrimaryKey.Size = new System.Drawing.Size(189, 26);
            this.tsmiNewPrimaryKey.Text = "New primary key";
            // 
            // tsmiDropAllPrimaryKeys
            // 
            this.tsmiDropAllPrimaryKeys.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropAllPrimaryKeys.Name = "tsmiDropAllPrimaryKeys";
            this.tsmiDropAllPrimaryKeys.Size = new System.Drawing.Size(189, 26);
            this.tsmiDropAllPrimaryKeys.Text = "Drop all primary keys";
            // 
            // tsmiRefreshPrimaryKeys
            // 
            this.tsmiRefreshPrimaryKeys.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshPrimaryKeys.Name = "tsmiRefreshPrimaryKeys";
            this.tsmiRefreshPrimaryKeys.Size = new System.Drawing.Size(189, 26);
            this.tsmiRefreshPrimaryKeys.Text = "Refresh";
            // 
            // tsmiEditPrimaryKey
            // 
            this.tsmiEditPrimaryKey.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditPrimaryKey.Name = "tsmiEditPrimaryKey";
            this.tsmiEditPrimaryKey.Size = new System.Drawing.Size(170, 26);
            this.tsmiEditPrimaryKey.Text = "Edit Primary Key";
            // 
            // tsmiDropPrimaryKey
            // 
            this.tsmiDropPrimaryKey.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropPrimaryKey.Name = "tsmiDropPrimaryKey";
            this.tsmiDropPrimaryKey.Size = new System.Drawing.Size(170, 26);
            this.tsmiDropPrimaryKey.Text = "Drop Primary Key";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem3.Text = "Refresh all system tables";
            // 
            // tsmiRefreshSystemTable
            // 
            this.tsmiRefreshSystemTable.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.tsmiRefreshSystemTable.Name = "tsmiRefreshSystemTable";
            this.tsmiRefreshSystemTable.Size = new System.Drawing.Size(186, 26);
            this.tsmiRefreshSystemTable.Text = "Refresh system table";
            // 
            // tsmiOpenSystemTable
            // 
            this.tsmiOpenSystemTable.Image = global::FBXpert.Properties.Resources.table_blue_x24;
            this.tsmiOpenSystemTable.Name = "tsmiOpenSystemTable";
            this.tsmiOpenSystemTable.Size = new System.Drawing.Size(186, 26);
            this.tsmiOpenSystemTable.Text = "Open system table";
            // 
            // tsmiEditUserDefinedFunctions
            // 
            this.tsmiEditUserDefinedFunctions.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditUserDefinedFunctions.Name = "tsmiEditUserDefinedFunctions";
            this.tsmiEditUserDefinedFunctions.Size = new System.Drawing.Size(123, 26);
            this.tsmiEditUserDefinedFunctions.Text = "Edit UDF";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(150, 26);
            this.toolStripMenuItem5.Text = "Refresh UDF\'s";
            // 
            // DbExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 500);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbExplorerForm";
            this.Text = "DBExplorer";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBExplorer_FormClosed);
            this.Load += new System.EventHandler(this.DBExplorer_Load);
            this.SizeChanged += new System.EventHandler(this.DbExplorerForm_SizeChanged);
            this.gbDatabases.ResumeLayout(false);
            this.cmsDatabase.ResumeLayout(false);
            this.cmsDatabase.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlLower.ResumeLayout(false);
            this.pnlLower.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsGeneratorsGroup.ResumeLayout(false);
            this.cmsGenerator.ResumeLayout(false);
            this.cmsProcedure.ResumeLayout(false);
            this.cmsProcedureGroup.ResumeLayout(false);
            this.cmsTable.ResumeLayout(false);
            this.cmsView.ResumeLayout(false);
            this.cmsRoles.ResumeLayout(false);
            this.cmsIndices.ResumeLayout(false);
            this.cmsFunctions.ResumeLayout(false);
            this.cmsTriggers.ResumeLayout(false);
            this.cmsDomains.ResumeLayout(false);
            this.cmsFunctionGroup.ResumeLayout(false);
            this.cmsTriggerGroup.ResumeLayout(false);
            this.cmsTableGroup.ResumeLayout(false);
            this.cmsViewGroup.ResumeLayout(false);
            this.cmsDomainsGroup.ResumeLayout(false);
            this.cmsIndicedGroup.ResumeLayout(false);
            this.cmsRolesGroup.ResumeLayout(false);
            this.cmsForeignKeysGroup.ResumeLayout(false);
            this.cmsForeignKeys.ResumeLayout(false);
            this.cmsConstraints.ResumeLayout(false);
            this.cmsConstrainsGroup.ResumeLayout(false);
            this.cmsPrimaryKeyGroup.ResumeLayout(false);
            this.cmsPrimaryKeys.ResumeLayout(false);
            this.cmsSystemTableGroup.ResumeLayout(false);
            this.cmsSystemTable.ResumeLayout(false);
            this.cmsUserDefinedFunctions.ResumeLayout(false);
            this.cmsUserDefinedFunctionGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatabases;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.ContextMenuStrip cmsDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ImageList imlTree;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateXMLDesign;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDatabaseConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQLScriptExplorer;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewDatabaseConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiActiveConnections;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackUp;
        private System.Windows.Forms.ContextMenuStrip cmsGeneratorsGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGeneratorInGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllGenerators;
        private System.Windows.Forms.ContextMenuStrip cmsGenerator;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditGenerator;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropGenerator;
        private System.Windows.Forms.ContextMenuStrip cmsProcedure;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditProcedure;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropProcedure;
        private System.Windows.Forms.ContextMenuStrip cmsProcedureGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewProcedureGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllProcedures;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQLExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteDatabaseRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloneDatabaseConfiguration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropTable;
        private System.Windows.Forms.ContextMenuStrip cmsView;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropView;
        private System.Windows.Forms.ContextMenuStrip cmsRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditRole;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropRole;
        private System.Windows.Forms.ContextMenuStrip cmsIndices;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditIndices;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropIndex;
        private System.Windows.Forms.ContextMenuStrip cmsFunctions;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropFunction;
        private System.Windows.Forms.ContextMenuStrip cmsTriggers;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditTrigger;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropTrigger;
        private System.Windows.Forms.ContextMenuStrip cmsDomains;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDomain;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropDomain;
        private System.Windows.Forms.ContextMenuStrip cmsFunctionGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewFunctionGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllFunctions;
        private System.Windows.Forms.ContextMenuStrip cmsTriggerGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTrigger;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllTriggers;
        private System.Windows.Forms.ContextMenuStrip cmsTableGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllTables;
        private System.Windows.Forms.ContextMenuStrip cmsViewGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllViews;
        private System.Windows.Forms.ContextMenuStrip cmsDomainsGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewDomain;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllDomains;
        private System.Windows.Forms.ContextMenuStrip cmsIndicedGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewIndices;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllIndices;
        private System.Windows.Forms.ContextMenuStrip cmsRolesGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewRole;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabaseDesigner;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportData;
        private System.Windows.Forms.ContextMenuStrip cmsForeignKeysGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiForeignKeyNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllForeignKeys;
        private System.Windows.Forms.ContextMenuStrip cmsForeignKeys;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditForeignKeys;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropForeignKey;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportDesigner;
        private System.Windows.Forms.ContextMenuStrip cmsConstraints;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditConstraint;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropConstraint;
        private System.Windows.Forms.ContextMenuStrip cmsConstrainsGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewConstraint;
        private System.Windows.Forms.ToolStripMenuItem tsmiDroppAllConstraints;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshViews;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshAllTables;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshForeignKey;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshTable;
        private System.Windows.Forms.ContextMenuStrip cmsPrimaryKeyGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewPrimaryKey;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropAllPrimaryKeys;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshPrimaryKeys;
        private System.Windows.Forms.ContextMenuStrip cmsPrimaryKeys;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPrimaryKey;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropPrimaryKey;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshFunction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshFunctions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshProcedure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshProcedures;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshGenerators;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshGenerator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshIndeces;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem tmsiRefreshConstraint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshConstraints;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlterCreateViewSQL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatistics;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripTextBox tstDesigners;
        private System.Windows.Forms.ToolStripTextBox tstConfiguration;
        private System.Windows.Forms.ToolStripTextBox tstSQL;
        private System.Windows.Forms.ToolStripTextBox tstStatistics;
        private System.Windows.Forms.ToolStripTextBox tstDatas;
        private System.Windows.Forms.ToolStripTextBox tstDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private SeControlsLib.HotSpot hsLoadDefinition;
        private System.Windows.Forms.OpenFileDialog ofdLoadDefinition;
        private SeControlsLib.HotSpot hsDatabaseDefinitionSave;
        private System.Windows.Forms.SaveFileDialog sfdSaveDefinition;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompareDatabase;
        private System.Windows.Forms.ContextMenuStrip cmsSystemTableGroup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip cmsSystemTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshSystemTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplicationDesigner;
        private SeControlsLib.HotSpot hsRefreshDB;
        private System.Windows.Forms.ContextMenuStrip cmsUserDefinedFunctions;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUserDefinedFunctions;
        private System.Windows.Forms.ContextMenuStrip cmsUserDefinedFunctionGroup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiIDBBinaries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripSeparator tsmiSystemTablesSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenSystemTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivateAllIndeces;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeactivateAllIndeces;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivateIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeactivateIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem tsmiEventsTracker;
    }
}