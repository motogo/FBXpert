using BasicForms;
using SEListBox;

namespace FBExpert
{
    partial class EXPORTDataForm : BasicNormalFormClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXPORTDataForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTableExports = new System.Windows.Forms.TabPage();
            this.gbTableFields = new System.Windows.Forms.GroupBox();
            this.selFields = new SEListBox.SEListBox();
            this.pnlTableFieldsUpper = new System.Windows.Forms.Panel();
            this.hsUncheckAllTableFields = new SeControlsLib.HotSpot();
            this.hsCheckAllTableFields = new SeControlsLib.HotSpot();
            this.gbTablesDataExport = new System.Windows.Forms.GroupBox();
            this.selTables = new SEListBox.SEListBox();
            this.pnlTableUpper = new System.Windows.Forms.Panel();
            this.hsUncheckAlltables = new SeControlsLib.HotSpot();
            this.hsCheckAllTables = new SeControlsLib.HotSpot();
            this.tabExtExports = new System.Windows.Forms.TabPage();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.hsExportTable = new SeControlsLib.HotSpot();
            this.cmsEXPORTData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEXPORTDataCopyToCLipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEXPORTDataPasteFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMessagesText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMessageCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMessagePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDATA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSetToNULL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDDLText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDDLCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDDLPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.bsUniques = new System.Windows.Forms.BindingSource(this.components);
            this.dsUniques = new System.Data.DataSet();
            this.dataTable3 = new System.Data.DataTable();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.gbFileExport = new System.Windows.Forms.GroupBox();
            this.gbFileName = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.gbDirectory = new System.Windows.Forms.GroupBox();
            this.hsExportFolder = new SeControlsLib.HotSpot();
            this.txtExportDirectory = new System.Windows.Forms.TextBox();
            this.gbFolder = new System.Windows.Forms.GroupBox();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.hsLastFolder = new SeControlsLib.HotSpot();
            this.gbCharset = new System.Windows.Forms.GroupBox();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDataExports = new System.Windows.Forms.TabPage();
            this.pnlTableRight = new System.Windows.Forms.Panel();
            this.gbExportAttributes = new System.Windows.Forms.GroupBox();
            this.cbViewInScript = new System.Windows.Forms.CheckBox();
            this.cbExportToFile = new System.Windows.Forms.CheckBox();
            this.gbInsertUpdate = new System.Windows.Forms.GroupBox();
            this.rbUPDATE = new System.Windows.Forms.RadioButton();
            this.rbINSERTUPDATE = new System.Windows.Forms.RadioButton();
            this.rbINSERT = new System.Windows.Forms.RadioButton();
            this.tabStructureExports = new System.Windows.Forms.TabPage();
            this.pnlStructureCenter = new System.Windows.Forms.Panel();
            this.tabControlStructures = new System.Windows.Forms.TabControl();
            this.tabPageStructureTables = new System.Windows.Forms.TabPage();
            this.gbStructureTables = new System.Windows.Forms.GroupBox();
            this.selStructureTables = new SEListBox.SEListBox();
            this.pnlStructureObjectsUpper = new System.Windows.Forms.Panel();
            this.hsUnselectStructureObjects = new SeControlsLib.HotSpot();
            this.hsSelectStructureObjects = new SeControlsLib.HotSpot();
            this.tabPageStructureViews = new System.Windows.Forms.TabPage();
            this.gbStructureViews = new System.Windows.Forms.GroupBox();
            this.selStructureViews = new SEListBox.SEListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hsUnselectAllViews = new SeControlsLib.HotSpot();
            this.hsSelectAllViews = new SeControlsLib.HotSpot();
            this.tabIndecesStructur = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selIndeces = new SEListBox.SEListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hotSpot5 = new SeControlsLib.HotSpot();
            this.gbDomains = new System.Windows.Forms.GroupBox();
            this.selDomains = new SEListBox.SEListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hotSpot3 = new SeControlsLib.HotSpot();
            this.hotSpot4 = new SeControlsLib.HotSpot();
            this.tabGeneratorStructure = new System.Windows.Forms.TabPage();
            this.gbTriggersStructrue = new System.Windows.Forms.GroupBox();
            this.selTriggerStructure = new SEListBox.SEListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hotSpot8 = new SeControlsLib.HotSpot();
            this.hotSpot9 = new SeControlsLib.HotSpot();
            this.gbGenaratorsSturcture = new System.Windows.Forms.GroupBox();
            this.selGenerators = new SEListBox.SEListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.hotSpot6 = new SeControlsLib.HotSpot();
            this.hotSpot7 = new SeControlsLib.HotSpot();
            this.tabPageProcedureStructure = new System.Windows.Forms.TabPage();
            this.gbFunctionsStructure = new System.Windows.Forms.GroupBox();
            this.selFunctionsStructure = new SEListBox.SEListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.hotSpot12 = new SeControlsLib.HotSpot();
            this.hotSpot13 = new SeControlsLib.HotSpot();
            this.gbProcedures = new System.Windows.Forms.GroupBox();
            this.selProceduresStructure = new SEListBox.SEListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.hotSpot10 = new SeControlsLib.HotSpot();
            this.hotSpot11 = new SeControlsLib.HotSpot();
            this.pnlOnjectExportAttributes = new System.Windows.Forms.Panel();
            this.pnlStructureAttributesUpper = new System.Windows.Forms.Panel();
            this.selExportStructureList = new SEListBox.SEListBox();
            this.setExportStructureAttributes = new System.Windows.Forms.GroupBox();
            this.ckWriteFileForEVeryObject = new System.Windows.Forms.CheckBox();
            this.cbStructureCommit = new System.Windows.Forms.CheckBox();
            this.cbStructureConnectiionStatement = new System.Windows.Forms.CheckBox();
            this.hsExportStructure = new SeControlsLib.HotSpot();
            this.cbStructureCreateDatabaseStatement = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCREATEObject = new System.Windows.Forms.RadioButton();
            this.rbRECREATEObject = new System.Windows.Forms.RadioButton();
            this.cbViewObjectScript = new System.Windows.Forms.CheckBox();
            this.cbObjectExportToFile = new System.Windows.Forms.CheckBox();
            this.pnlUpperExportStructureObjects = new System.Windows.Forms.Panel();
            this.hotSpot15 = new SeControlsLib.HotSpot();
            this.hotSpot14 = new SeControlsLib.HotSpot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.bsTableContent = new System.Windows.Forms.BindingSource(this.components);
            this.dsTableContent = new System.Data.DataSet();
            this.Table = new System.Data.DataTable();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabTableExports.SuspendLayout();
            this.gbTableFields.SuspendLayout();
            this.pnlTableFieldsUpper.SuspendLayout();
            this.gbTablesDataExport.SuspendLayout();
            this.pnlTableUpper.SuspendLayout();
            this.cmsEXPORTData.SuspendLayout();
            this.cmsMessagesText.SuspendLayout();
            this.cmdDATA.SuspendLayout();
            this.cmsDDLText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUniques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUniques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.gbFileExport.SuspendLayout();
            this.gbFileName.SuspendLayout();
            this.gbDirectory.SuspendLayout();
            this.gbFolder.SuspendLayout();
            this.gbCharset.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDataExports.SuspendLayout();
            this.pnlTableRight.SuspendLayout();
            this.gbExportAttributes.SuspendLayout();
            this.gbInsertUpdate.SuspendLayout();
            this.tabStructureExports.SuspendLayout();
            this.pnlStructureCenter.SuspendLayout();
            this.tabControlStructures.SuspendLayout();
            this.tabPageStructureTables.SuspendLayout();
            this.gbStructureTables.SuspendLayout();
            this.pnlStructureObjectsUpper.SuspendLayout();
            this.tabPageStructureViews.SuspendLayout();
            this.gbStructureViews.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabIndecesStructur.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbDomains.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabGeneratorStructure.SuspendLayout();
            this.gbTriggersStructrue.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbGenaratorsSturcture.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageProcedureStructure.SuspendLayout();
            this.gbFunctionsStructure.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbProcedures.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlOnjectExportAttributes.SuspendLayout();
            this.pnlStructureAttributesUpper.SuspendLayout();
            this.setExportStructureAttributes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlUpperExportStructureObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTableContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTableContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTableExports);
            this.tabControl.Controls.Add(this.tabExtExports);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.ilTabControl;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(464, 570);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTableExports
            // 
            this.tabTableExports.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabTableExports.Controls.Add(this.gbTableFields);
            this.tabTableExports.Controls.Add(this.gbTablesDataExport);
            this.tabTableExports.ImageKey = "table_blue_x24.png";
            this.tabTableExports.Location = new System.Drawing.Point(4, 23);
            this.tabTableExports.Name = "tabTableExports";
            this.tabTableExports.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableExports.Size = new System.Drawing.Size(456, 543);
            this.tabTableExports.TabIndex = 0;
            this.tabTableExports.Text = "Table data export";
            // 
            // gbTableFields
            // 
            this.gbTableFields.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTableFields.Controls.Add(this.selFields);
            this.gbTableFields.Controls.Add(this.pnlTableFieldsUpper);
            this.gbTableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTableFields.Location = new System.Drawing.Point(208, 3);
            this.gbTableFields.Name = "gbTableFields";
            this.gbTableFields.Size = new System.Drawing.Size(245, 537);
            this.gbTableFields.TabIndex = 4;
            this.gbTableFields.TabStop = false;
            this.gbTableFields.Text = "Fields";
            // 
            // selFields
            // 
            this.selFields.AllowMultipleChecks = true;
            this.selFields.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle1;
            this.selFields.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selFields.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selFields.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selFields.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selFields.CheckCaption = "chk";
            this.selFields.CheckOnDoubleClick = false;
            this.selFields.CheckOnSelect = true;
            this.selFields.CheckVisible = true;
            this.selFields.CheckWith = 32;
            this.selFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selFields.IDVisible = false;
            this.selFields.IDWith = 32;
            this.selFields.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selFields.ListEntriesDefaultCellStyle = dataGridViewCellStyle2;
            this.selFields.Location = new System.Drawing.Point(3, 58);
            this.selFields.Name = "selFields";
            this.selFields.SelectedIndex = -1;
            this.selFields.ShowCaptions = false;
            this.selFields.ShowCellToolTips = true;
            this.selFields.ShowCountInTitle = true;
            this.selFields.ShowSelection = false;
            this.selFields.Size = new System.Drawing.Size(239, 476);
            this.selFields.TabIndex = 19;
            this.selFields.Text = "selFields";
            this.selFields.TextCaption = "text";
            this.selFields.TextWith = 100;
            this.selFields.Title = "gbMain";
            this.selFields.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.selFields.ItemSelect += new SEListBox.SEListBox.SelectItemEventHandler(this.selFields_SelectItem);
            this.selFields.ItemCheckChanged += new SEListBox.SEListBox.CheckItemEventHandler(this.selFields_ItemCheckChanged);
            // 
            // pnlTableFieldsUpper
            // 
            this.pnlTableFieldsUpper.Controls.Add(this.hsUncheckAllTableFields);
            this.pnlTableFieldsUpper.Controls.Add(this.hsCheckAllTableFields);
            this.pnlTableFieldsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableFieldsUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlTableFieldsUpper.Name = "pnlTableFieldsUpper";
            this.pnlTableFieldsUpper.Size = new System.Drawing.Size(239, 42);
            this.pnlTableFieldsUpper.TabIndex = 1;
            // 
            // hsUncheckAllTableFields
            // 
            this.hsUncheckAllTableFields.BackColor = System.Drawing.Color.Transparent;
            this.hsUncheckAllTableFields.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUncheckAllTableFields.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUncheckAllTableFields.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUncheckAllTableFields.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUncheckAllTableFields.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUncheckAllTableFields.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUncheckAllTableFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsUncheckAllTableFields.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUncheckAllTableFields.FlatAppearance.BorderSize = 0;
            this.hsUncheckAllTableFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUncheckAllTableFields.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUncheckAllTableFields.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsUncheckAllTableFields.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUncheckAllTableFields.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsUncheckAllTableFields.ImageToggleOnSelect = true;
            this.hsUncheckAllTableFields.Location = new System.Drawing.Point(96, 0);
            this.hsUncheckAllTableFields.Marked = false;
            this.hsUncheckAllTableFields.MarkedColor = System.Drawing.Color.Teal;
            this.hsUncheckAllTableFields.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUncheckAllTableFields.MarkedText = "";
            this.hsUncheckAllTableFields.MarkMode = false;
            this.hsUncheckAllTableFields.Name = "hsUncheckAllTableFields";
            this.hsUncheckAllTableFields.NonMarkedText = "Uncheck all";
            this.hsUncheckAllTableFields.Size = new System.Drawing.Size(96, 42);
            this.hsUncheckAllTableFields.TabIndex = 3;
            this.hsUncheckAllTableFields.Text = "Uncheck all";
            this.hsUncheckAllTableFields.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUncheckAllTableFields.ToolTipActive = false;
            this.hsUncheckAllTableFields.ToolTipAutomaticDelay = 500;
            this.hsUncheckAllTableFields.ToolTipAutoPopDelay = 5000;
            this.hsUncheckAllTableFields.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUncheckAllTableFields.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUncheckAllTableFields.ToolTipFor4ContextMenu = true;
            this.hsUncheckAllTableFields.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUncheckAllTableFields.ToolTipInitialDelay = 500;
            this.hsUncheckAllTableFields.ToolTipIsBallon = false;
            this.hsUncheckAllTableFields.ToolTipOwnerDraw = false;
            this.hsUncheckAllTableFields.ToolTipReshowDelay = 100;
            this.hsUncheckAllTableFields.ToolTipShowAlways = false;
            this.hsUncheckAllTableFields.ToolTipText = "";
            this.hsUncheckAllTableFields.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUncheckAllTableFields.ToolTipTitle = "";
            this.hsUncheckAllTableFields.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUncheckAllTableFields.UseVisualStyleBackColor = false;
            this.hsUncheckAllTableFields.Click += new System.EventHandler(this.hsUncheckAllTableFields_Click);
            // 
            // hsCheckAllTableFields
            // 
            this.hsCheckAllTableFields.BackColor = System.Drawing.Color.Transparent;
            this.hsCheckAllTableFields.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCheckAllTableFields.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCheckAllTableFields.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCheckAllTableFields.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCheckAllTableFields.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCheckAllTableFields.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCheckAllTableFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCheckAllTableFields.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCheckAllTableFields.FlatAppearance.BorderSize = 0;
            this.hsCheckAllTableFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCheckAllTableFields.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCheckAllTableFields.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsCheckAllTableFields.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCheckAllTableFields.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsCheckAllTableFields.ImageToggleOnSelect = true;
            this.hsCheckAllTableFields.Location = new System.Drawing.Point(0, 0);
            this.hsCheckAllTableFields.Marked = false;
            this.hsCheckAllTableFields.MarkedColor = System.Drawing.Color.Teal;
            this.hsCheckAllTableFields.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCheckAllTableFields.MarkedText = "";
            this.hsCheckAllTableFields.MarkMode = false;
            this.hsCheckAllTableFields.Name = "hsCheckAllTableFields";
            this.hsCheckAllTableFields.NonMarkedText = "Check all";
            this.hsCheckAllTableFields.Size = new System.Drawing.Size(96, 42);
            this.hsCheckAllTableFields.TabIndex = 2;
            this.hsCheckAllTableFields.Text = "Check all";
            this.hsCheckAllTableFields.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCheckAllTableFields.ToolTipActive = false;
            this.hsCheckAllTableFields.ToolTipAutomaticDelay = 500;
            this.hsCheckAllTableFields.ToolTipAutoPopDelay = 5000;
            this.hsCheckAllTableFields.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCheckAllTableFields.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCheckAllTableFields.ToolTipFor4ContextMenu = true;
            this.hsCheckAllTableFields.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCheckAllTableFields.ToolTipInitialDelay = 500;
            this.hsCheckAllTableFields.ToolTipIsBallon = false;
            this.hsCheckAllTableFields.ToolTipOwnerDraw = false;
            this.hsCheckAllTableFields.ToolTipReshowDelay = 100;
            this.hsCheckAllTableFields.ToolTipShowAlways = false;
            this.hsCheckAllTableFields.ToolTipText = "";
            this.hsCheckAllTableFields.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCheckAllTableFields.ToolTipTitle = "";
            this.hsCheckAllTableFields.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCheckAllTableFields.UseVisualStyleBackColor = false;
            this.hsCheckAllTableFields.Click += new System.EventHandler(this.hsCheckAllTableFields_Click);
            // 
            // gbTablesDataExport
            // 
            this.gbTablesDataExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTablesDataExport.Controls.Add(this.selTables);
            this.gbTablesDataExport.Controls.Add(this.pnlTableUpper);
            this.gbTablesDataExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTablesDataExport.Location = new System.Drawing.Point(3, 3);
            this.gbTablesDataExport.Name = "gbTablesDataExport";
            this.gbTablesDataExport.Size = new System.Drawing.Size(205, 537);
            this.gbTablesDataExport.TabIndex = 3;
            this.gbTablesDataExport.TabStop = false;
            this.gbTablesDataExport.Text = "Tables";
            // 
            // selTables
            // 
            this.selTables.AllowMultipleChecks = true;
            this.selTables.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle3;
            this.selTables.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selTables.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selTables.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selTables.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selTables.CheckCaption = "chk";
            this.selTables.CheckOnDoubleClick = true;
            this.selTables.CheckOnSelect = false;
            this.selTables.CheckVisible = true;
            this.selTables.CheckWith = 32;
            this.selTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selTables.IDVisible = false;
            this.selTables.IDWith = 32;
            this.selTables.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selTables.ListEntriesDefaultCellStyle = dataGridViewCellStyle4;
            this.selTables.Location = new System.Drawing.Point(3, 58);
            this.selTables.Name = "selTables";
            this.selTables.SelectedIndex = -1;
            this.selTables.ShowCaptions = false;
            this.selTables.ShowCellToolTips = true;
            this.selTables.ShowCountInTitle = true;
            this.selTables.ShowSelection = true;
            this.selTables.Size = new System.Drawing.Size(199, 476);
            this.selTables.TabIndex = 20;
            this.selTables.Text = "seListBox1";
            this.selTables.TextCaption = "text";
            this.selTables.TextWith = 100;
            this.selTables.Title = "gbMain";
            this.selTables.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.selTables.ItemSelect += new SEListBox.SEListBox.SelectItemEventHandler(this.selTables_SelectItem);
            // 
            // pnlTableUpper
            // 
            this.pnlTableUpper.Controls.Add(this.hsUncheckAlltables);
            this.pnlTableUpper.Controls.Add(this.hsCheckAllTables);
            this.pnlTableUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlTableUpper.Name = "pnlTableUpper";
            this.pnlTableUpper.Size = new System.Drawing.Size(199, 42);
            this.pnlTableUpper.TabIndex = 2;
            // 
            // hsUncheckAlltables
            // 
            this.hsUncheckAlltables.BackColor = System.Drawing.Color.Transparent;
            this.hsUncheckAlltables.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUncheckAlltables.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUncheckAlltables.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUncheckAlltables.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUncheckAlltables.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUncheckAlltables.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUncheckAlltables.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsUncheckAlltables.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUncheckAlltables.FlatAppearance.BorderSize = 0;
            this.hsUncheckAlltables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUncheckAlltables.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUncheckAlltables.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsUncheckAlltables.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUncheckAlltables.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsUncheckAlltables.ImageToggleOnSelect = true;
            this.hsUncheckAlltables.Location = new System.Drawing.Point(96, 0);
            this.hsUncheckAlltables.Marked = false;
            this.hsUncheckAlltables.MarkedColor = System.Drawing.Color.Teal;
            this.hsUncheckAlltables.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUncheckAlltables.MarkedText = "";
            this.hsUncheckAlltables.MarkMode = false;
            this.hsUncheckAlltables.Name = "hsUncheckAlltables";
            this.hsUncheckAlltables.NonMarkedText = "Uncheck all";
            this.hsUncheckAlltables.Size = new System.Drawing.Size(96, 42);
            this.hsUncheckAlltables.TabIndex = 3;
            this.hsUncheckAlltables.Text = "Uncheck all";
            this.hsUncheckAlltables.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUncheckAlltables.ToolTipActive = false;
            this.hsUncheckAlltables.ToolTipAutomaticDelay = 500;
            this.hsUncheckAlltables.ToolTipAutoPopDelay = 5000;
            this.hsUncheckAlltables.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUncheckAlltables.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUncheckAlltables.ToolTipFor4ContextMenu = true;
            this.hsUncheckAlltables.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUncheckAlltables.ToolTipInitialDelay = 500;
            this.hsUncheckAlltables.ToolTipIsBallon = false;
            this.hsUncheckAlltables.ToolTipOwnerDraw = false;
            this.hsUncheckAlltables.ToolTipReshowDelay = 100;
            this.hsUncheckAlltables.ToolTipShowAlways = false;
            this.hsUncheckAlltables.ToolTipText = "";
            this.hsUncheckAlltables.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUncheckAlltables.ToolTipTitle = "";
            this.hsUncheckAlltables.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUncheckAlltables.UseVisualStyleBackColor = false;
            this.hsUncheckAlltables.Click += new System.EventHandler(this.hsUncheckAlltables_Click);
            // 
            // hsCheckAllTables
            // 
            this.hsCheckAllTables.BackColor = System.Drawing.Color.Transparent;
            this.hsCheckAllTables.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCheckAllTables.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCheckAllTables.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCheckAllTables.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCheckAllTables.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCheckAllTables.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCheckAllTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCheckAllTables.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCheckAllTables.FlatAppearance.BorderSize = 0;
            this.hsCheckAllTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCheckAllTables.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCheckAllTables.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsCheckAllTables.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCheckAllTables.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsCheckAllTables.ImageToggleOnSelect = true;
            this.hsCheckAllTables.Location = new System.Drawing.Point(0, 0);
            this.hsCheckAllTables.Marked = false;
            this.hsCheckAllTables.MarkedColor = System.Drawing.Color.Teal;
            this.hsCheckAllTables.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCheckAllTables.MarkedText = "";
            this.hsCheckAllTables.MarkMode = false;
            this.hsCheckAllTables.Name = "hsCheckAllTables";
            this.hsCheckAllTables.NonMarkedText = "Check all";
            this.hsCheckAllTables.Size = new System.Drawing.Size(96, 42);
            this.hsCheckAllTables.TabIndex = 2;
            this.hsCheckAllTables.Text = "Check all";
            this.hsCheckAllTables.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCheckAllTables.ToolTipActive = false;
            this.hsCheckAllTables.ToolTipAutomaticDelay = 500;
            this.hsCheckAllTables.ToolTipAutoPopDelay = 5000;
            this.hsCheckAllTables.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCheckAllTables.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCheckAllTables.ToolTipFor4ContextMenu = true;
            this.hsCheckAllTables.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCheckAllTables.ToolTipInitialDelay = 500;
            this.hsCheckAllTables.ToolTipIsBallon = false;
            this.hsCheckAllTables.ToolTipOwnerDraw = false;
            this.hsCheckAllTables.ToolTipReshowDelay = 100;
            this.hsCheckAllTables.ToolTipShowAlways = false;
            this.hsCheckAllTables.ToolTipText = "";
            this.hsCheckAllTables.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCheckAllTables.ToolTipTitle = "";
            this.hsCheckAllTables.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCheckAllTables.UseVisualStyleBackColor = false;
            this.hsCheckAllTables.Click += new System.EventHandler(this.hsCheckAllTables_Click);
            // 
            // tabExtExports
            // 
            this.tabExtExports.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabExtExports.Location = new System.Drawing.Point(4, 23);
            this.tabExtExports.Name = "tabExtExports";
            this.tabExtExports.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtExports.Size = new System.Drawing.Size(456, 543);
            this.tabExtExports.TabIndex = 1;
            this.tabExtExports.Text = "Extended exports";
            // 
            // ilTabControl
            // 
            this.ilTabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTabControl.ImageStream")));
            this.ilTabControl.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTabControl.Images.SetKeyName(0, "go_previous22x.png");
            this.ilTabControl.Images.SetKeyName(1, "go_next_blue24x.png");
            this.ilTabControl.Images.SetKeyName(2, "document_blue_x32.png");
            this.ilTabControl.Images.SetKeyName(3, "preferences-system.png");
            this.ilTabControl.Images.SetKeyName(4, "view-sort-descending_x24.png");
            this.ilTabControl.Images.SetKeyName(5, "SQL_blue_x24.png");
            this.ilTabControl.Images.SetKeyName(6, "database_gr_24x.png");
            this.ilTabControl.Images.SetKeyName(7, "help_about_blue_x22.png");
            this.ilTabControl.Images.SetKeyName(8, "table_blue_x24.png");
            this.ilTabControl.Images.SetKeyName(9, "info_blue_22x.png");
            this.ilTabControl.Images.SetKeyName(10, "format_indent_more_24x.png");
            // 
            // hsExportTable
            // 
            this.hsExportTable.BackColor = System.Drawing.Color.Transparent;
            this.hsExportTable.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportTable.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportTable.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportTable.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportTable.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportTable.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportTable.FlatAppearance.BorderSize = 0;
            this.hsExportTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportTable.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportTable.Image = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsExportTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportTable.ImageHover = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsExportTable.ImageToggleOnSelect = true;
            this.hsExportTable.Location = new System.Drawing.Point(149, 103);
            this.hsExportTable.Marked = false;
            this.hsExportTable.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportTable.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportTable.MarkedText = "";
            this.hsExportTable.MarkMode = false;
            this.hsExportTable.Name = "hsExportTable";
            this.hsExportTable.NonMarkedText = "Export";
            this.hsExportTable.Size = new System.Drawing.Size(114, 52);
            this.hsExportTable.TabIndex = 1;
            this.hsExportTable.Text = "Export table";
            this.hsExportTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportTable.ToolTipActive = false;
            this.hsExportTable.ToolTipAutomaticDelay = 500;
            this.hsExportTable.ToolTipAutoPopDelay = 5000;
            this.hsExportTable.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportTable.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportTable.ToolTipFor4ContextMenu = true;
            this.hsExportTable.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportTable.ToolTipInitialDelay = 500;
            this.hsExportTable.ToolTipIsBallon = false;
            this.hsExportTable.ToolTipOwnerDraw = false;
            this.hsExportTable.ToolTipReshowDelay = 100;
            this.hsExportTable.ToolTipShowAlways = false;
            this.hsExportTable.ToolTipText = "";
            this.hsExportTable.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportTable.ToolTipTitle = "";
            this.hsExportTable.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportTable.UseVisualStyleBackColor = false;
            this.hsExportTable.Click += new System.EventHandler(this.hsExport_Click);
            // 
            // cmsEXPORTData
            // 
            this.cmsEXPORTData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEXPORTData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEXPORTDataCopyToCLipboard,
            this.tsmiEXPORTDataPasteFromClipboard});
            this.cmsEXPORTData.Name = "cmsText";
            this.cmsEXPORTData.Size = new System.Drawing.Size(176, 56);
            // 
            // tsmiEXPORTDataCopyToCLipboard
            // 
            this.tsmiEXPORTDataCopyToCLipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiEXPORTDataCopyToCLipboard.Name = "tsmiEXPORTDataCopyToCLipboard";
            this.tsmiEXPORTDataCopyToCLipboard.Size = new System.Drawing.Size(175, 26);
            this.tsmiEXPORTDataCopyToCLipboard.Text = "Copy to Clipboard";
            // 
            // tsmiEXPORTDataPasteFromClipboard
            // 
            this.tsmiEXPORTDataPasteFromClipboard.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiEXPORTDataPasteFromClipboard.Name = "tsmiEXPORTDataPasteFromClipboard";
            this.tsmiEXPORTDataPasteFromClipboard.Size = new System.Drawing.Size(175, 26);
            this.tsmiEXPORTDataPasteFromClipboard.Text = "Paste";
            // 
            // cmsMessagesText
            // 
            this.cmsMessagesText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMessagesText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMessageCopyToClipboard,
            this.tsmiMessagePaste});
            this.cmsMessagesText.Name = "cmsText";
            this.cmsMessagesText.Size = new System.Drawing.Size(176, 56);
            // 
            // tsmiMessageCopyToClipboard
            // 
            this.tsmiMessageCopyToClipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiMessageCopyToClipboard.Name = "tsmiMessageCopyToClipboard";
            this.tsmiMessageCopyToClipboard.Size = new System.Drawing.Size(175, 26);
            this.tsmiMessageCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiMessagePaste
            // 
            this.tsmiMessagePaste.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiMessagePaste.Name = "tsmiMessagePaste";
            this.tsmiMessagePaste.Size = new System.Drawing.Size(175, 26);
            this.tsmiMessagePaste.Text = "Paste";
            // 
            // cmdDATA
            // 
            this.cmdDATA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmdDATA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetToNULL,
            this.tsmiDate});
            this.cmdDATA.Name = "cmsText";
            this.cmdDATA.Size = new System.Drawing.Size(143, 56);
            // 
            // tsmiSetToNULL
            // 
            this.tsmiSetToNULL.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiSetToNULL.Name = "tsmiSetToNULL";
            this.tsmiSetToNULL.Size = new System.Drawing.Size(142, 26);
            this.tsmiSetToNULL.Text = "Set To NULL";
            // 
            // tsmiDate
            // 
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.Size = new System.Drawing.Size(142, 26);
            this.tsmiDate.Text = "DateTime";
            // 
            // cmsDDLText
            // 
            this.cmsDDLText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDDLText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDDLCopyToClipboard,
            this.tsmiDDLPaste});
            this.cmsDDLText.Name = "cmsText";
            this.cmsDDLText.Size = new System.Drawing.Size(176, 56);
            // 
            // tsmiDDLCopyToClipboard
            // 
            this.tsmiDDLCopyToClipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiDDLCopyToClipboard.Name = "tsmiDDLCopyToClipboard";
            this.tsmiDDLCopyToClipboard.Size = new System.Drawing.Size(175, 26);
            this.tsmiDDLCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiDDLPaste
            // 
            this.tsmiDDLPaste.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiDDLPaste.Name = "tsmiDDLPaste";
            this.tsmiDDLPaste.Size = new System.Drawing.Size(175, 26);
            this.tsmiDDLPaste.Text = "Paste";
            // 
            // bsUniques
            // 
            this.bsUniques.DataSource = this.dsUniques;
            this.bsUniques.Position = 0;
            // 
            // dsUniques
            // 
            this.dsUniques.DataSetName = "NewDataSet";
            this.dsUniques.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable3});
            // 
            // dataTable3
            // 
            this.dataTable3.TableName = "Table";
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1296, 44);
            this.pnlUpper.TabIndex = 1;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(81, 16);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "Tablename";
            // 
            // hsRefresh
            // 
            this.hsRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefresh.FlatAppearance.BorderSize = 0;
            this.hsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(1251, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Size = new System.Drawing.Size(45, 44);
            this.hsRefresh.TabIndex = 1;
            this.hsRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefresh.ToolTipActive = false;
            this.hsRefresh.ToolTipAutomaticDelay = 500;
            this.hsRefresh.ToolTipAutoPopDelay = 5000;
            this.hsRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefresh.ToolTipFor4ContextMenu = true;
            this.hsRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefresh.ToolTipInitialDelay = 500;
            this.hsRefresh.ToolTipIsBallon = false;
            this.hsRefresh.ToolTipOwnerDraw = false;
            this.hsRefresh.ToolTipReshowDelay = 100;
            this.hsRefresh.ToolTipShowAlways = false;
            this.hsRefresh.ToolTipText = "";
            this.hsRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefresh.ToolTipTitle = "";
            this.hsRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefresh.UseVisualStyleBackColor = false;
            // 
            // hsClose
            // 
            this.hsClose.BackColor = System.Drawing.Color.Transparent;
            this.hsClose.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClose.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClose.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClose.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClose.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClose.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClose.FlatAppearance.BorderSize = 0;
            this.hsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClose.Image = global::FBXpert.Properties.Resources.go_previous32x;
            this.hsClose.ImageHover = global::FBXpert.Properties.Resources.go_left_blue32x;
            this.hsClose.ImageToggleOnSelect = true;
            this.hsClose.Location = new System.Drawing.Point(0, 0);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Size = new System.Drawing.Size(45, 44);
            this.hsClose.TabIndex = 0;
            this.hsClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClose.ToolTipActive = false;
            this.hsClose.ToolTipAutomaticDelay = 500;
            this.hsClose.ToolTipAutoPopDelay = 5000;
            this.hsClose.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClose.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClose.ToolTipFor4ContextMenu = true;
            this.hsClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClose.ToolTipInitialDelay = 500;
            this.hsClose.ToolTipIsBallon = false;
            this.hsClose.ToolTipOwnerDraw = false;
            this.hsClose.ToolTipReshowDelay = 100;
            this.hsClose.ToolTipShowAlways = false;
            this.hsClose.ToolTipText = "";
            this.hsClose.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClose.ToolTipTitle = "";
            this.hsClose.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClose.UseVisualStyleBackColor = false;
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click);
            // 
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 646);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(1296, 16);
            this.pnlLower.TabIndex = 2;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.gbFileExport);
            this.pnlCenter.Controls.Add(this.tabControl1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 44);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1296, 602);
            this.pnlCenter.TabIndex = 3;
            // 
            // gbFileExport
            // 
            this.gbFileExport.Controls.Add(this.gbFileName);
            this.gbFileExport.Controls.Add(this.gbDirectory);
            this.gbFileExport.Controls.Add(this.gbFolder);
            this.gbFileExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileExport.Location = new System.Drawing.Point(822, 0);
            this.gbFileExport.Name = "gbFileExport";
            this.gbFileExport.Size = new System.Drawing.Size(474, 602);
            this.gbFileExport.TabIndex = 15;
            this.gbFileExport.TabStop = false;
            // 
            // gbFileName
            // 
            this.gbFileName.Controls.Add(this.txtFileName);
            this.gbFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFileName.Location = new System.Drawing.Point(3, 116);
            this.gbFileName.Name = "gbFileName";
            this.gbFileName.Size = new System.Drawing.Size(468, 45);
            this.gbFileName.TabIndex = 1;
            this.gbFileName.TabStop = false;
            this.gbFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFileName.Location = new System.Drawing.Point(3, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(462, 20);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.Text = "structure_out.sql";
            // 
            // gbDirectory
            // 
            this.gbDirectory.Controls.Add(this.hsExportFolder);
            this.gbDirectory.Controls.Add(this.txtExportDirectory);
            this.gbDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDirectory.Location = new System.Drawing.Point(3, 70);
            this.gbDirectory.Name = "gbDirectory";
            this.gbDirectory.Size = new System.Drawing.Size(468, 46);
            this.gbDirectory.TabIndex = 14;
            this.gbDirectory.TabStop = false;
            this.gbDirectory.Text = "Directory Name";
            // 
            // hsExportFolder
            // 
            this.hsExportFolder.BackColor = System.Drawing.Color.Transparent;
            this.hsExportFolder.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportFolder.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportFolder.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportFolder.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportFolder.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportFolder.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsExportFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportFolder.FlatAppearance.BorderSize = 0;
            this.hsExportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportFolder.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportFolder.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsExportFolder.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsExportFolder.ImageToggleOnSelect = true;
            this.hsExportFolder.Location = new System.Drawing.Point(420, 16);
            this.hsExportFolder.Marked = false;
            this.hsExportFolder.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportFolder.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportFolder.MarkedText = "";
            this.hsExportFolder.MarkMode = false;
            this.hsExportFolder.Name = "hsExportFolder";
            this.hsExportFolder.NonMarkedText = "";
            this.hsExportFolder.Size = new System.Drawing.Size(45, 27);
            this.hsExportFolder.TabIndex = 7;
            this.hsExportFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportFolder.ToolTipActive = false;
            this.hsExportFolder.ToolTipAutomaticDelay = 500;
            this.hsExportFolder.ToolTipAutoPopDelay = 5000;
            this.hsExportFolder.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportFolder.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportFolder.ToolTipFor4ContextMenu = true;
            this.hsExportFolder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportFolder.ToolTipInitialDelay = 500;
            this.hsExportFolder.ToolTipIsBallon = false;
            this.hsExportFolder.ToolTipOwnerDraw = false;
            this.hsExportFolder.ToolTipReshowDelay = 100;
            this.hsExportFolder.ToolTipShowAlways = false;
            this.hsExportFolder.ToolTipText = "";
            this.hsExportFolder.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportFolder.ToolTipTitle = "";
            this.hsExportFolder.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportFolder.UseVisualStyleBackColor = false;
            this.hsExportFolder.Click += new System.EventHandler(this.hsExportFolder_Click);
            // 
            // txtExportDirectory
            // 
            this.txtExportDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtExportDirectory.Location = new System.Drawing.Point(3, 16);
            this.txtExportDirectory.Name = "txtExportDirectory";
            this.txtExportDirectory.Size = new System.Drawing.Size(411, 20);
            this.txtExportDirectory.TabIndex = 4;
            // 
            // gbFolder
            // 
            this.gbFolder.Controls.Add(this.hotSpot2);
            this.gbFolder.Controls.Add(this.hsLastFolder);
            this.gbFolder.Controls.Add(this.gbCharset);
            this.gbFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFolder.Location = new System.Drawing.Point(3, 16);
            this.gbFolder.Name = "gbFolder";
            this.gbFolder.Size = new System.Drawing.Size(468, 54);
            this.gbFolder.TabIndex = 13;
            this.gbFolder.TabStop = false;
            this.gbFolder.Text = "Location for file export";
            // 
            // hotSpot2
            // 
            this.hotSpot2.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot2.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot2.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot2.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot2.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.go_up_blue22x;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.go_up_gn22x;
            this.hotSpot2.ImageToggleOnSelect = true;
            this.hotSpot2.Location = new System.Drawing.Point(-1, 19);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "";
            this.hotSpot2.Size = new System.Drawing.Size(45, 21);
            this.hotSpot2.TabIndex = 7;
            this.hotSpot2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot2.ToolTipActive = false;
            this.hotSpot2.ToolTipAutomaticDelay = 500;
            this.hotSpot2.ToolTipAutoPopDelay = 5000;
            this.hotSpot2.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot2.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot2.ToolTipFor4ContextMenu = true;
            this.hotSpot2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot2.ToolTipInitialDelay = 500;
            this.hotSpot2.ToolTipIsBallon = false;
            this.hotSpot2.ToolTipOwnerDraw = false;
            this.hotSpot2.ToolTipReshowDelay = 100;
            this.hotSpot2.ToolTipShowAlways = false;
            this.hotSpot2.ToolTipText = "";
            this.hotSpot2.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot2.ToolTipTitle = "";
            this.hotSpot2.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot2.UseVisualStyleBackColor = false;
            // 
            // hsLastFolder
            // 
            this.hsLastFolder.BackColor = System.Drawing.Color.Transparent;
            this.hsLastFolder.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLastFolder.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLastFolder.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLastFolder.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLastFolder.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLastFolder.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLastFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLastFolder.FlatAppearance.BorderSize = 0;
            this.hsLastFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLastFolder.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLastFolder.Image = global::FBXpert.Properties.Resources.go_left_blue22x;
            this.hsLastFolder.ImageHover = global::FBXpert.Properties.Resources.go_previous22x;
            this.hsLastFolder.ImageToggleOnSelect = true;
            this.hsLastFolder.Location = new System.Drawing.Point(46, 19);
            this.hsLastFolder.Marked = false;
            this.hsLastFolder.MarkedColor = System.Drawing.Color.Teal;
            this.hsLastFolder.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLastFolder.MarkedText = "";
            this.hsLastFolder.MarkMode = false;
            this.hsLastFolder.Name = "hsLastFolder";
            this.hsLastFolder.NonMarkedText = "";
            this.hsLastFolder.Size = new System.Drawing.Size(45, 21);
            this.hsLastFolder.TabIndex = 6;
            this.hsLastFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLastFolder.ToolTipActive = false;
            this.hsLastFolder.ToolTipAutomaticDelay = 500;
            this.hsLastFolder.ToolTipAutoPopDelay = 5000;
            this.hsLastFolder.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLastFolder.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLastFolder.ToolTipFor4ContextMenu = true;
            this.hsLastFolder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLastFolder.ToolTipInitialDelay = 500;
            this.hsLastFolder.ToolTipIsBallon = false;
            this.hsLastFolder.ToolTipOwnerDraw = false;
            this.hsLastFolder.ToolTipReshowDelay = 100;
            this.hsLastFolder.ToolTipShowAlways = false;
            this.hsLastFolder.ToolTipText = "";
            this.hsLastFolder.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLastFolder.ToolTipTitle = "";
            this.hsLastFolder.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLastFolder.UseVisualStyleBackColor = false;
            // 
            // gbCharset
            // 
            this.gbCharset.Controls.Add(this.cbCharSet);
            this.gbCharset.Location = new System.Drawing.Point(111, 8);
            this.gbCharset.Name = "gbCharset";
            this.gbCharset.Size = new System.Drawing.Size(200, 43);
            this.gbCharset.TabIndex = 12;
            this.gbCharset.TabStop = false;
            this.gbCharset.Text = "Charset";
            // 
            // cbCharSet
            // 
            this.cbCharSet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbCharSet.FormattingEnabled = true;
            this.cbCharSet.Location = new System.Drawing.Point(3, 19);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(194, 21);
            this.cbCharSet.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDataExports);
            this.tabControl1.Controls.Add(this.tabStructureExports);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 602);
            this.tabControl1.TabIndex = 4;
            // 
            // tabDataExports
            // 
            this.tabDataExports.Controls.Add(this.tabControl);
            this.tabDataExports.Controls.Add(this.pnlTableRight);
            this.tabDataExports.Location = new System.Drawing.Point(4, 22);
            this.tabDataExports.Name = "tabDataExports";
            this.tabDataExports.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataExports.Size = new System.Drawing.Size(814, 576);
            this.tabDataExports.TabIndex = 0;
            this.tabDataExports.Text = "Data exports";
            this.tabDataExports.UseVisualStyleBackColor = true;
            // 
            // pnlTableRight
            // 
            this.pnlTableRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTableRight.Controls.Add(this.gbExportAttributes);
            this.pnlTableRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTableRight.Location = new System.Drawing.Point(467, 3);
            this.pnlTableRight.Name = "pnlTableRight";
            this.pnlTableRight.Size = new System.Drawing.Size(344, 570);
            this.pnlTableRight.TabIndex = 3;
            // 
            // gbExportAttributes
            // 
            this.gbExportAttributes.Controls.Add(this.hsExportTable);
            this.gbExportAttributes.Controls.Add(this.cbViewInScript);
            this.gbExportAttributes.Controls.Add(this.cbExportToFile);
            this.gbExportAttributes.Controls.Add(this.gbInsertUpdate);
            this.gbExportAttributes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbExportAttributes.Location = new System.Drawing.Point(0, 0);
            this.gbExportAttributes.Name = "gbExportAttributes";
            this.gbExportAttributes.Size = new System.Drawing.Size(344, 169);
            this.gbExportAttributes.TabIndex = 16;
            this.gbExportAttributes.TabStop = false;
            this.gbExportAttributes.Text = "Export attributes";
            // 
            // cbViewInScript
            // 
            this.cbViewInScript.AutoSize = true;
            this.cbViewInScript.Checked = true;
            this.cbViewInScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViewInScript.Location = new System.Drawing.Point(13, 113);
            this.cbViewInScript.Name = "cbViewInScript";
            this.cbViewInScript.Size = new System.Drawing.Size(93, 17);
            this.cbViewInScript.TabIndex = 14;
            this.cbViewInScript.Text = "View in scripts";
            this.cbViewInScript.UseVisualStyleBackColor = true;
            // 
            // cbExportToFile
            // 
            this.cbExportToFile.AutoSize = true;
            this.cbExportToFile.Location = new System.Drawing.Point(13, 136);
            this.cbExportToFile.Name = "cbExportToFile";
            this.cbExportToFile.Size = new System.Drawing.Size(84, 17);
            this.cbExportToFile.TabIndex = 13;
            this.cbExportToFile.Text = "Export to file";
            this.cbExportToFile.UseVisualStyleBackColor = true;
            this.cbExportToFile.CheckedChanged += new System.EventHandler(this.cbExportToFile_CheckedChanged_1);
            // 
            // gbInsertUpdate
            // 
            this.gbInsertUpdate.Controls.Add(this.rbUPDATE);
            this.gbInsertUpdate.Controls.Add(this.rbINSERTUPDATE);
            this.gbInsertUpdate.Controls.Add(this.rbINSERT);
            this.gbInsertUpdate.Location = new System.Drawing.Point(13, 28);
            this.gbInsertUpdate.Name = "gbInsertUpdate";
            this.gbInsertUpdate.Size = new System.Drawing.Size(330, 38);
            this.gbInsertUpdate.TabIndex = 11;
            this.gbInsertUpdate.TabStop = false;
            this.gbInsertUpdate.Text = "FieldType of statments";
            // 
            // rbUPDATE
            // 
            this.rbUPDATE.AutoSize = true;
            this.rbUPDATE.Location = new System.Drawing.Point(228, 16);
            this.rbUPDATE.Name = "rbUPDATE";
            this.rbUPDATE.Size = new System.Drawing.Size(69, 17);
            this.rbUPDATE.TabIndex = 2;
            this.rbUPDATE.Text = "UPDATE";
            this.rbUPDATE.UseVisualStyleBackColor = true;
            // 
            // rbINSERTUPDATE
            // 
            this.rbINSERTUPDATE.AutoSize = true;
            this.rbINSERTUPDATE.Location = new System.Drawing.Point(87, 16);
            this.rbINSERTUPDATE.Name = "rbINSERTUPDATE";
            this.rbINSERTUPDATE.Size = new System.Drawing.Size(124, 17);
            this.rbINSERTUPDATE.TabIndex = 1;
            this.rbINSERTUPDATE.Text = "INSERT or UPDATE";
            this.rbINSERTUPDATE.UseVisualStyleBackColor = true;
            // 
            // rbINSERT
            // 
            this.rbINSERT.AutoSize = true;
            this.rbINSERT.Checked = true;
            this.rbINSERT.Location = new System.Drawing.Point(6, 16);
            this.rbINSERT.Name = "rbINSERT";
            this.rbINSERT.Size = new System.Drawing.Size(65, 17);
            this.rbINSERT.TabIndex = 0;
            this.rbINSERT.TabStop = true;
            this.rbINSERT.Text = "INSERT";
            this.rbINSERT.UseVisualStyleBackColor = true;
            // 
            // tabStructureExports
            // 
            this.tabStructureExports.Controls.Add(this.pnlStructureCenter);
            this.tabStructureExports.Controls.Add(this.panel1);
            this.tabStructureExports.Location = new System.Drawing.Point(4, 22);
            this.tabStructureExports.Name = "tabStructureExports";
            this.tabStructureExports.Padding = new System.Windows.Forms.Padding(3);
            this.tabStructureExports.Size = new System.Drawing.Size(814, 576);
            this.tabStructureExports.TabIndex = 1;
            this.tabStructureExports.Text = "Structure exports";
            this.tabStructureExports.UseVisualStyleBackColor = true;
            // 
            // pnlStructureCenter
            // 
            this.pnlStructureCenter.Controls.Add(this.tabControlStructures);
            this.pnlStructureCenter.Controls.Add(this.pnlOnjectExportAttributes);
            this.pnlStructureCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStructureCenter.Location = new System.Drawing.Point(3, 13);
            this.pnlStructureCenter.Name = "pnlStructureCenter";
            this.pnlStructureCenter.Size = new System.Drawing.Size(808, 560);
            this.pnlStructureCenter.TabIndex = 3;
            // 
            // tabControlStructures
            // 
            this.tabControlStructures.Controls.Add(this.tabPageStructureTables);
            this.tabControlStructures.Controls.Add(this.tabPageStructureViews);
            this.tabControlStructures.Controls.Add(this.tabIndecesStructur);
            this.tabControlStructures.Controls.Add(this.tabGeneratorStructure);
            this.tabControlStructures.Controls.Add(this.tabPageProcedureStructure);
            this.tabControlStructures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStructures.Location = new System.Drawing.Point(0, 0);
            this.tabControlStructures.Name = "tabControlStructures";
            this.tabControlStructures.SelectedIndex = 0;
            this.tabControlStructures.Size = new System.Drawing.Size(413, 560);
            this.tabControlStructures.TabIndex = 17;
            // 
            // tabPageStructureTables
            // 
            this.tabPageStructureTables.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageStructureTables.Controls.Add(this.gbStructureTables);
            this.tabPageStructureTables.Location = new System.Drawing.Point(4, 22);
            this.tabPageStructureTables.Name = "tabPageStructureTables";
            this.tabPageStructureTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStructureTables.Size = new System.Drawing.Size(405, 534);
            this.tabPageStructureTables.TabIndex = 0;
            this.tabPageStructureTables.Text = "Tables";
            // 
            // gbStructureTables
            // 
            this.gbStructureTables.Controls.Add(this.selStructureTables);
            this.gbStructureTables.Controls.Add(this.pnlStructureObjectsUpper);
            this.gbStructureTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStructureTables.Location = new System.Drawing.Point(3, 3);
            this.gbStructureTables.Name = "gbStructureTables";
            this.gbStructureTables.Size = new System.Drawing.Size(399, 528);
            this.gbStructureTables.TabIndex = 4;
            this.gbStructureTables.TabStop = false;
            // 
            // selStructureTables
            // 
            this.selStructureTables.AllowMultipleChecks = true;
            this.selStructureTables.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle5;
            this.selStructureTables.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selStructureTables.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selStructureTables.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selStructureTables.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selStructureTables.CheckCaption = "chk";
            this.selStructureTables.CheckOnDoubleClick = true;
            this.selStructureTables.CheckOnSelect = true;
            this.selStructureTables.CheckVisible = true;
            this.selStructureTables.CheckWith = 32;
            this.selStructureTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selStructureTables.IDVisible = false;
            this.selStructureTables.IDWith = 32;
            this.selStructureTables.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selStructureTables.ListEntriesDefaultCellStyle = dataGridViewCellStyle6;
            this.selStructureTables.Location = new System.Drawing.Point(3, 58);
            this.selStructureTables.Name = "selStructureTables";
            this.selStructureTables.SelectedIndex = -1;
            this.selStructureTables.ShowCaptions = false;
            this.selStructureTables.ShowCellToolTips = true;
            this.selStructureTables.ShowCountInTitle = true;
            this.selStructureTables.ShowSelection = false;
            this.selStructureTables.Size = new System.Drawing.Size(393, 467);
            this.selStructureTables.TabIndex = 17;
            this.selStructureTables.Text = "seListBox1";
            this.selStructureTables.TextCaption = "text";
            this.selStructureTables.TextWith = 157;
            this.selStructureTables.Title = "gbMain";
            this.selStructureTables.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.selStructureTables.ItemSelect += new SEListBox.SEListBox.SelectItemEventHandler(this.selStructureTables_SelectItem);
            // 
            // pnlStructureObjectsUpper
            // 
            this.pnlStructureObjectsUpper.Controls.Add(this.hsUnselectStructureObjects);
            this.pnlStructureObjectsUpper.Controls.Add(this.hsSelectStructureObjects);
            this.pnlStructureObjectsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStructureObjectsUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlStructureObjectsUpper.Name = "pnlStructureObjectsUpper";
            this.pnlStructureObjectsUpper.Size = new System.Drawing.Size(393, 42);
            this.pnlStructureObjectsUpper.TabIndex = 2;
            // 
            // hsUnselectStructureObjects
            // 
            this.hsUnselectStructureObjects.BackColor = System.Drawing.Color.Transparent;
            this.hsUnselectStructureObjects.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUnselectStructureObjects.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUnselectStructureObjects.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUnselectStructureObjects.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUnselectStructureObjects.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUnselectStructureObjects.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUnselectStructureObjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsUnselectStructureObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUnselectStructureObjects.FlatAppearance.BorderSize = 0;
            this.hsUnselectStructureObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUnselectStructureObjects.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUnselectStructureObjects.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsUnselectStructureObjects.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUnselectStructureObjects.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsUnselectStructureObjects.ImageToggleOnSelect = true;
            this.hsUnselectStructureObjects.Location = new System.Drawing.Point(96, 0);
            this.hsUnselectStructureObjects.Marked = false;
            this.hsUnselectStructureObjects.MarkedColor = System.Drawing.Color.Teal;
            this.hsUnselectStructureObjects.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUnselectStructureObjects.MarkedText = "";
            this.hsUnselectStructureObjects.MarkMode = false;
            this.hsUnselectStructureObjects.Name = "hsUnselectStructureObjects";
            this.hsUnselectStructureObjects.NonMarkedText = "Uncheck all";
            this.hsUnselectStructureObjects.Size = new System.Drawing.Size(96, 42);
            this.hsUnselectStructureObjects.TabIndex = 3;
            this.hsUnselectStructureObjects.Text = "Uncheck all";
            this.hsUnselectStructureObjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUnselectStructureObjects.ToolTipActive = false;
            this.hsUnselectStructureObjects.ToolTipAutomaticDelay = 500;
            this.hsUnselectStructureObjects.ToolTipAutoPopDelay = 5000;
            this.hsUnselectStructureObjects.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUnselectStructureObjects.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUnselectStructureObjects.ToolTipFor4ContextMenu = true;
            this.hsUnselectStructureObjects.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUnselectStructureObjects.ToolTipInitialDelay = 500;
            this.hsUnselectStructureObjects.ToolTipIsBallon = false;
            this.hsUnselectStructureObjects.ToolTipOwnerDraw = false;
            this.hsUnselectStructureObjects.ToolTipReshowDelay = 100;
            this.hsUnselectStructureObjects.ToolTipShowAlways = false;
            this.hsUnselectStructureObjects.ToolTipText = "";
            this.hsUnselectStructureObjects.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUnselectStructureObjects.ToolTipTitle = "";
            this.hsUnselectStructureObjects.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUnselectStructureObjects.UseVisualStyleBackColor = false;
            this.hsUnselectStructureObjects.Click += new System.EventHandler(this.hsUnselectStructureObjects_Click);
            // 
            // hsSelectStructureObjects
            // 
            this.hsSelectStructureObjects.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectStructureObjects.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectStructureObjects.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectStructureObjects.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectStructureObjects.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectStructureObjects.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectStructureObjects.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectStructureObjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSelectStructureObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectStructureObjects.FlatAppearance.BorderSize = 0;
            this.hsSelectStructureObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectStructureObjects.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectStructureObjects.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsSelectStructureObjects.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSelectStructureObjects.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsSelectStructureObjects.ImageToggleOnSelect = true;
            this.hsSelectStructureObjects.Location = new System.Drawing.Point(0, 0);
            this.hsSelectStructureObjects.Marked = false;
            this.hsSelectStructureObjects.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectStructureObjects.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectStructureObjects.MarkedText = "";
            this.hsSelectStructureObjects.MarkMode = false;
            this.hsSelectStructureObjects.Name = "hsSelectStructureObjects";
            this.hsSelectStructureObjects.NonMarkedText = "Check all";
            this.hsSelectStructureObjects.Size = new System.Drawing.Size(96, 42);
            this.hsSelectStructureObjects.TabIndex = 2;
            this.hsSelectStructureObjects.Text = "Check all";
            this.hsSelectStructureObjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSelectStructureObjects.ToolTipActive = false;
            this.hsSelectStructureObjects.ToolTipAutomaticDelay = 500;
            this.hsSelectStructureObjects.ToolTipAutoPopDelay = 5000;
            this.hsSelectStructureObjects.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectStructureObjects.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectStructureObjects.ToolTipFor4ContextMenu = true;
            this.hsSelectStructureObjects.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectStructureObjects.ToolTipInitialDelay = 500;
            this.hsSelectStructureObjects.ToolTipIsBallon = false;
            this.hsSelectStructureObjects.ToolTipOwnerDraw = false;
            this.hsSelectStructureObjects.ToolTipReshowDelay = 100;
            this.hsSelectStructureObjects.ToolTipShowAlways = false;
            this.hsSelectStructureObjects.ToolTipText = "";
            this.hsSelectStructureObjects.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectStructureObjects.ToolTipTitle = "";
            this.hsSelectStructureObjects.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectStructureObjects.UseVisualStyleBackColor = false;
            this.hsSelectStructureObjects.Click += new System.EventHandler(this.hsSelectStructureObjects_Click);
            // 
            // tabPageStructureViews
            // 
            this.tabPageStructureViews.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageStructureViews.Controls.Add(this.gbStructureViews);
            this.tabPageStructureViews.Location = new System.Drawing.Point(4, 22);
            this.tabPageStructureViews.Name = "tabPageStructureViews";
            this.tabPageStructureViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStructureViews.Size = new System.Drawing.Size(405, 534);
            this.tabPageStructureViews.TabIndex = 1;
            this.tabPageStructureViews.Text = "Views";
            // 
            // gbStructureViews
            // 
            this.gbStructureViews.Controls.Add(this.selStructureViews);
            this.gbStructureViews.Controls.Add(this.panel2);
            this.gbStructureViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStructureViews.Location = new System.Drawing.Point(3, 3);
            this.gbStructureViews.Name = "gbStructureViews";
            this.gbStructureViews.Size = new System.Drawing.Size(399, 528);
            this.gbStructureViews.TabIndex = 6;
            this.gbStructureViews.TabStop = false;
            // 
            // selStructureViews
            // 
            this.selStructureViews.AllowMultipleChecks = true;
            this.selStructureViews.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle7;
            this.selStructureViews.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selStructureViews.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selStructureViews.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selStructureViews.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selStructureViews.CheckCaption = "chk";
            this.selStructureViews.CheckOnDoubleClick = false;
            this.selStructureViews.CheckOnSelect = true;
            this.selStructureViews.CheckVisible = true;
            this.selStructureViews.CheckWith = 32;
            this.selStructureViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selStructureViews.IDVisible = false;
            this.selStructureViews.IDWith = 32;
            this.selStructureViews.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selStructureViews.ListEntriesDefaultCellStyle = dataGridViewCellStyle8;
            this.selStructureViews.Location = new System.Drawing.Point(3, 58);
            this.selStructureViews.Name = "selStructureViews";
            this.selStructureViews.SelectedIndex = -1;
            this.selStructureViews.ShowCaptions = false;
            this.selStructureViews.ShowCellToolTips = true;
            this.selStructureViews.ShowCountInTitle = true;
            this.selStructureViews.ShowSelection = false;
            this.selStructureViews.Size = new System.Drawing.Size(393, 467);
            this.selStructureViews.TabIndex = 18;
            this.selStructureViews.Text = "selStructureViews";
            this.selStructureViews.TextCaption = "text";
            this.selStructureViews.TextWith = 100;
            this.selStructureViews.Title = "gbMain";
            this.selStructureViews.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hsUnselectAllViews);
            this.panel2.Controls.Add(this.hsSelectAllViews);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 42);
            this.panel2.TabIndex = 2;
            // 
            // hsUnselectAllViews
            // 
            this.hsUnselectAllViews.BackColor = System.Drawing.Color.Transparent;
            this.hsUnselectAllViews.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUnselectAllViews.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUnselectAllViews.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUnselectAllViews.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUnselectAllViews.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUnselectAllViews.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUnselectAllViews.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsUnselectAllViews.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUnselectAllViews.FlatAppearance.BorderSize = 0;
            this.hsUnselectAllViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUnselectAllViews.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUnselectAllViews.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsUnselectAllViews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUnselectAllViews.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsUnselectAllViews.ImageToggleOnSelect = true;
            this.hsUnselectAllViews.Location = new System.Drawing.Point(96, 0);
            this.hsUnselectAllViews.Marked = false;
            this.hsUnselectAllViews.MarkedColor = System.Drawing.Color.Teal;
            this.hsUnselectAllViews.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUnselectAllViews.MarkedText = "";
            this.hsUnselectAllViews.MarkMode = false;
            this.hsUnselectAllViews.Name = "hsUnselectAllViews";
            this.hsUnselectAllViews.NonMarkedText = "Uncheck all";
            this.hsUnselectAllViews.Size = new System.Drawing.Size(96, 42);
            this.hsUnselectAllViews.TabIndex = 3;
            this.hsUnselectAllViews.Text = "Uncheck all";
            this.hsUnselectAllViews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUnselectAllViews.ToolTipActive = false;
            this.hsUnselectAllViews.ToolTipAutomaticDelay = 500;
            this.hsUnselectAllViews.ToolTipAutoPopDelay = 5000;
            this.hsUnselectAllViews.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUnselectAllViews.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUnselectAllViews.ToolTipFor4ContextMenu = true;
            this.hsUnselectAllViews.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUnselectAllViews.ToolTipInitialDelay = 500;
            this.hsUnselectAllViews.ToolTipIsBallon = false;
            this.hsUnselectAllViews.ToolTipOwnerDraw = false;
            this.hsUnselectAllViews.ToolTipReshowDelay = 100;
            this.hsUnselectAllViews.ToolTipShowAlways = false;
            this.hsUnselectAllViews.ToolTipText = "";
            this.hsUnselectAllViews.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUnselectAllViews.ToolTipTitle = "";
            this.hsUnselectAllViews.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUnselectAllViews.UseVisualStyleBackColor = false;
            this.hsUnselectAllViews.Click += new System.EventHandler(this.hsUnselectAllViews_Click);
            // 
            // hsSelectAllViews
            // 
            this.hsSelectAllViews.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectAllViews.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectAllViews.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectAllViews.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectAllViews.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectAllViews.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectAllViews.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectAllViews.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSelectAllViews.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectAllViews.FlatAppearance.BorderSize = 0;
            this.hsSelectAllViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectAllViews.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectAllViews.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsSelectAllViews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSelectAllViews.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsSelectAllViews.ImageToggleOnSelect = true;
            this.hsSelectAllViews.Location = new System.Drawing.Point(0, 0);
            this.hsSelectAllViews.Marked = false;
            this.hsSelectAllViews.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectAllViews.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectAllViews.MarkedText = "";
            this.hsSelectAllViews.MarkMode = false;
            this.hsSelectAllViews.Name = "hsSelectAllViews";
            this.hsSelectAllViews.NonMarkedText = "Check all";
            this.hsSelectAllViews.Size = new System.Drawing.Size(96, 42);
            this.hsSelectAllViews.TabIndex = 2;
            this.hsSelectAllViews.Text = "Check all";
            this.hsSelectAllViews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSelectAllViews.ToolTipActive = false;
            this.hsSelectAllViews.ToolTipAutomaticDelay = 500;
            this.hsSelectAllViews.ToolTipAutoPopDelay = 5000;
            this.hsSelectAllViews.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectAllViews.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectAllViews.ToolTipFor4ContextMenu = true;
            this.hsSelectAllViews.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectAllViews.ToolTipInitialDelay = 500;
            this.hsSelectAllViews.ToolTipIsBallon = false;
            this.hsSelectAllViews.ToolTipOwnerDraw = false;
            this.hsSelectAllViews.ToolTipReshowDelay = 100;
            this.hsSelectAllViews.ToolTipShowAlways = false;
            this.hsSelectAllViews.ToolTipText = "";
            this.hsSelectAllViews.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectAllViews.ToolTipTitle = "";
            this.hsSelectAllViews.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectAllViews.UseVisualStyleBackColor = false;
            this.hsSelectAllViews.Click += new System.EventHandler(this.hsSelectAllViews_Click);
            // 
            // tabIndecesStructur
            // 
            this.tabIndecesStructur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabIndecesStructur.Controls.Add(this.groupBox2);
            this.tabIndecesStructur.Controls.Add(this.gbDomains);
            this.tabIndecesStructur.Location = new System.Drawing.Point(4, 22);
            this.tabIndecesStructur.Name = "tabIndecesStructur";
            this.tabIndecesStructur.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndecesStructur.Size = new System.Drawing.Size(405, 534);
            this.tabIndecesStructur.TabIndex = 2;
            this.tabIndecesStructur.Text = "Domains/Indeces";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selIndeces);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(193, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 528);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indeces";
            // 
            // selIndeces
            // 
            this.selIndeces.AllowMultipleChecks = true;
            this.selIndeces.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle9;
            this.selIndeces.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selIndeces.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selIndeces.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selIndeces.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selIndeces.CheckCaption = "chk";
            this.selIndeces.CheckOnDoubleClick = true;
            this.selIndeces.CheckOnSelect = true;
            this.selIndeces.CheckVisible = true;
            this.selIndeces.CheckWith = 32;
            this.selIndeces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selIndeces.IDVisible = false;
            this.selIndeces.IDWith = 32;
            this.selIndeces.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selIndeces.ListEntriesDefaultCellStyle = dataGridViewCellStyle10;
            this.selIndeces.Location = new System.Drawing.Point(3, 58);
            this.selIndeces.Name = "selIndeces";
            this.selIndeces.SelectedIndex = -1;
            this.selIndeces.ShowCaptions = false;
            this.selIndeces.ShowCellToolTips = true;
            this.selIndeces.ShowCountInTitle = true;
            this.selIndeces.ShowSelection = false;
            this.selIndeces.Size = new System.Drawing.Size(203, 467);
            this.selIndeces.TabIndex = 17;
            this.selIndeces.Text = "seListBox1";
            this.selIndeces.TextCaption = "text";
            this.selIndeces.TextWith = 100;
            this.selIndeces.Title = "gbMain";
            this.selIndeces.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.hotSpot1);
            this.panel4.Controls.Add(this.hotSpot5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 42);
            this.panel4.TabIndex = 2;
            // 
            // hotSpot1
            // 
            this.hotSpot1.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot1.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot1.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot1.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot1.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(96, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Uncheck all";
            this.hotSpot1.Size = new System.Drawing.Size(96, 42);
            this.hotSpot1.TabIndex = 3;
            this.hotSpot1.Text = "Uncheck all";
            this.hotSpot1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot1.ToolTipActive = false;
            this.hotSpot1.ToolTipAutomaticDelay = 500;
            this.hotSpot1.ToolTipAutoPopDelay = 5000;
            this.hotSpot1.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot1.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot1.ToolTipFor4ContextMenu = true;
            this.hotSpot1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot1.ToolTipInitialDelay = 500;
            this.hotSpot1.ToolTipIsBallon = false;
            this.hotSpot1.ToolTipOwnerDraw = false;
            this.hotSpot1.ToolTipReshowDelay = 100;
            this.hotSpot1.ToolTipShowAlways = false;
            this.hotSpot1.ToolTipText = "";
            this.hotSpot1.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot1.ToolTipTitle = "";
            this.hotSpot1.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot1.UseVisualStyleBackColor = false;
            this.hotSpot1.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // hotSpot5
            // 
            this.hotSpot5.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot5.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot5.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot5.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot5.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot5.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot5.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot5.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot5.FlatAppearance.BorderSize = 0;
            this.hotSpot5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot5.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot5.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot5.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot5.ImageToggleOnSelect = true;
            this.hotSpot5.Location = new System.Drawing.Point(0, 0);
            this.hotSpot5.Marked = false;
            this.hotSpot5.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot5.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot5.MarkedText = "";
            this.hotSpot5.MarkMode = false;
            this.hotSpot5.Name = "hotSpot5";
            this.hotSpot5.NonMarkedText = "Check all";
            this.hotSpot5.Size = new System.Drawing.Size(96, 42);
            this.hotSpot5.TabIndex = 2;
            this.hotSpot5.Text = "Check all";
            this.hotSpot5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot5.ToolTipActive = false;
            this.hotSpot5.ToolTipAutomaticDelay = 500;
            this.hotSpot5.ToolTipAutoPopDelay = 5000;
            this.hotSpot5.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot5.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot5.ToolTipFor4ContextMenu = true;
            this.hotSpot5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot5.ToolTipInitialDelay = 500;
            this.hotSpot5.ToolTipIsBallon = false;
            this.hotSpot5.ToolTipOwnerDraw = false;
            this.hotSpot5.ToolTipReshowDelay = 100;
            this.hotSpot5.ToolTipShowAlways = false;
            this.hotSpot5.ToolTipText = "";
            this.hotSpot5.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot5.ToolTipTitle = "";
            this.hotSpot5.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot5.UseVisualStyleBackColor = false;
            this.hotSpot5.Click += new System.EventHandler(this.hotSpot5_Click);
            // 
            // gbDomains
            // 
            this.gbDomains.Controls.Add(this.selDomains);
            this.gbDomains.Controls.Add(this.panel3);
            this.gbDomains.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDomains.Location = new System.Drawing.Point(3, 3);
            this.gbDomains.Name = "gbDomains";
            this.gbDomains.Size = new System.Drawing.Size(190, 528);
            this.gbDomains.TabIndex = 5;
            this.gbDomains.TabStop = false;
            this.gbDomains.Text = "Domains";
            // 
            // selDomains
            // 
            this.selDomains.AllowMultipleChecks = true;
            this.selDomains.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle11;
            this.selDomains.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selDomains.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selDomains.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selDomains.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selDomains.CheckCaption = "chk";
            this.selDomains.CheckOnDoubleClick = true;
            this.selDomains.CheckOnSelect = true;
            this.selDomains.CheckVisible = true;
            this.selDomains.CheckWith = 32;
            this.selDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selDomains.IDVisible = false;
            this.selDomains.IDWith = 32;
            this.selDomains.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selDomains.ListEntriesDefaultCellStyle = dataGridViewCellStyle12;
            this.selDomains.Location = new System.Drawing.Point(3, 58);
            this.selDomains.Name = "selDomains";
            this.selDomains.SelectedIndex = -1;
            this.selDomains.ShowCaptions = false;
            this.selDomains.ShowCellToolTips = true;
            this.selDomains.ShowCountInTitle = true;
            this.selDomains.ShowSelection = false;
            this.selDomains.Size = new System.Drawing.Size(184, 467);
            this.selDomains.TabIndex = 17;
            this.selDomains.Text = "seListBox1";
            this.selDomains.TextCaption = "text";
            this.selDomains.TextWith = 100;
            this.selDomains.Title = "gbMain";
            this.selDomains.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hotSpot3);
            this.panel3.Controls.Add(this.hotSpot4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 42);
            this.panel3.TabIndex = 2;
            // 
            // hotSpot3
            // 
            this.hotSpot3.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot3.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot3.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot3.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot3.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot3.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot3.FlatAppearance.BorderSize = 0;
            this.hotSpot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot3.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot3.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot3.ImageToggleOnSelect = true;
            this.hotSpot3.Location = new System.Drawing.Point(96, 0);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "Uncheck all";
            this.hotSpot3.Size = new System.Drawing.Size(96, 42);
            this.hotSpot3.TabIndex = 3;
            this.hotSpot3.Text = "Uncheck all";
            this.hotSpot3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot3.ToolTipActive = false;
            this.hotSpot3.ToolTipAutomaticDelay = 500;
            this.hotSpot3.ToolTipAutoPopDelay = 5000;
            this.hotSpot3.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot3.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot3.ToolTipFor4ContextMenu = true;
            this.hotSpot3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot3.ToolTipInitialDelay = 500;
            this.hotSpot3.ToolTipIsBallon = false;
            this.hotSpot3.ToolTipOwnerDraw = false;
            this.hotSpot3.ToolTipReshowDelay = 100;
            this.hotSpot3.ToolTipShowAlways = false;
            this.hotSpot3.ToolTipText = "";
            this.hotSpot3.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot3.ToolTipTitle = "";
            this.hotSpot3.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot3.UseVisualStyleBackColor = false;
            this.hotSpot3.Click += new System.EventHandler(this.hotSpot3_Click);
            // 
            // hotSpot4
            // 
            this.hotSpot4.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot4.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot4.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot4.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot4.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot4.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot4.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot4.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot4.FlatAppearance.BorderSize = 0;
            this.hotSpot4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot4.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot4.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot4.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot4.ImageToggleOnSelect = true;
            this.hotSpot4.Location = new System.Drawing.Point(0, 0);
            this.hotSpot4.Marked = false;
            this.hotSpot4.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot4.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot4.MarkedText = "";
            this.hotSpot4.MarkMode = false;
            this.hotSpot4.Name = "hotSpot4";
            this.hotSpot4.NonMarkedText = "Check all";
            this.hotSpot4.Size = new System.Drawing.Size(96, 42);
            this.hotSpot4.TabIndex = 2;
            this.hotSpot4.Text = "Check all";
            this.hotSpot4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot4.ToolTipActive = false;
            this.hotSpot4.ToolTipAutomaticDelay = 500;
            this.hotSpot4.ToolTipAutoPopDelay = 5000;
            this.hotSpot4.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot4.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot4.ToolTipFor4ContextMenu = true;
            this.hotSpot4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot4.ToolTipInitialDelay = 500;
            this.hotSpot4.ToolTipIsBallon = false;
            this.hotSpot4.ToolTipOwnerDraw = false;
            this.hotSpot4.ToolTipReshowDelay = 100;
            this.hotSpot4.ToolTipShowAlways = false;
            this.hotSpot4.ToolTipText = "";
            this.hotSpot4.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot4.ToolTipTitle = "";
            this.hotSpot4.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot4.UseVisualStyleBackColor = false;
            this.hotSpot4.Click += new System.EventHandler(this.hotSpot4_Click_1);
            // 
            // tabGeneratorStructure
            // 
            this.tabGeneratorStructure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabGeneratorStructure.Controls.Add(this.gbTriggersStructrue);
            this.tabGeneratorStructure.Controls.Add(this.gbGenaratorsSturcture);
            this.tabGeneratorStructure.Location = new System.Drawing.Point(4, 22);
            this.tabGeneratorStructure.Name = "tabGeneratorStructure";
            this.tabGeneratorStructure.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneratorStructure.Size = new System.Drawing.Size(405, 534);
            this.tabGeneratorStructure.TabIndex = 3;
            this.tabGeneratorStructure.Text = "Generators/Triggers";
            // 
            // gbTriggersStructrue
            // 
            this.gbTriggersStructrue.Controls.Add(this.selTriggerStructure);
            this.gbTriggersStructrue.Controls.Add(this.panel6);
            this.gbTriggersStructrue.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTriggersStructrue.Location = new System.Drawing.Point(202, 3);
            this.gbTriggersStructrue.Name = "gbTriggersStructrue";
            this.gbTriggersStructrue.Size = new System.Drawing.Size(200, 528);
            this.gbTriggersStructrue.TabIndex = 7;
            this.gbTriggersStructrue.TabStop = false;
            this.gbTriggersStructrue.Text = "Triggers";
            // 
            // selTriggerStructure
            // 
            this.selTriggerStructure.AllowMultipleChecks = true;
            this.selTriggerStructure.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle13;
            this.selTriggerStructure.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selTriggerStructure.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selTriggerStructure.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selTriggerStructure.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selTriggerStructure.CheckCaption = "chk";
            this.selTriggerStructure.CheckOnDoubleClick = true;
            this.selTriggerStructure.CheckOnSelect = true;
            this.selTriggerStructure.CheckVisible = true;
            this.selTriggerStructure.CheckWith = 32;
            this.selTriggerStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selTriggerStructure.IDVisible = false;
            this.selTriggerStructure.IDWith = 32;
            this.selTriggerStructure.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selTriggerStructure.ListEntriesDefaultCellStyle = dataGridViewCellStyle14;
            this.selTriggerStructure.Location = new System.Drawing.Point(3, 58);
            this.selTriggerStructure.Name = "selTriggerStructure";
            this.selTriggerStructure.SelectedIndex = -1;
            this.selTriggerStructure.ShowCaptions = false;
            this.selTriggerStructure.ShowCellToolTips = true;
            this.selTriggerStructure.ShowCountInTitle = true;
            this.selTriggerStructure.ShowSelection = false;
            this.selTriggerStructure.Size = new System.Drawing.Size(194, 467);
            this.selTriggerStructure.TabIndex = 17;
            this.selTriggerStructure.Text = "Generators";
            this.selTriggerStructure.TextCaption = "text";
            this.selTriggerStructure.TextWith = 100;
            this.selTriggerStructure.Title = "gbMain";
            this.selTriggerStructure.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.hotSpot8);
            this.panel6.Controls.Add(this.hotSpot9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 42);
            this.panel6.TabIndex = 2;
            // 
            // hotSpot8
            // 
            this.hotSpot8.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot8.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot8.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot8.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot8.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot8.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot8.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot8.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot8.FlatAppearance.BorderSize = 0;
            this.hotSpot8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot8.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot8.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot8.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot8.ImageToggleOnSelect = true;
            this.hotSpot8.Location = new System.Drawing.Point(96, 0);
            this.hotSpot8.Marked = false;
            this.hotSpot8.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot8.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot8.MarkedText = "";
            this.hotSpot8.MarkMode = false;
            this.hotSpot8.Name = "hotSpot8";
            this.hotSpot8.NonMarkedText = "Uncheck all";
            this.hotSpot8.Size = new System.Drawing.Size(96, 42);
            this.hotSpot8.TabIndex = 3;
            this.hotSpot8.Text = "Uncheck all";
            this.hotSpot8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot8.ToolTipActive = false;
            this.hotSpot8.ToolTipAutomaticDelay = 500;
            this.hotSpot8.ToolTipAutoPopDelay = 5000;
            this.hotSpot8.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot8.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot8.ToolTipFor4ContextMenu = true;
            this.hotSpot8.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot8.ToolTipInitialDelay = 500;
            this.hotSpot8.ToolTipIsBallon = false;
            this.hotSpot8.ToolTipOwnerDraw = false;
            this.hotSpot8.ToolTipReshowDelay = 100;
            this.hotSpot8.ToolTipShowAlways = false;
            this.hotSpot8.ToolTipText = "";
            this.hotSpot8.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot8.ToolTipTitle = "";
            this.hotSpot8.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot8.UseVisualStyleBackColor = false;
            // 
            // hotSpot9
            // 
            this.hotSpot9.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot9.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot9.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot9.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot9.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot9.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot9.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot9.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot9.FlatAppearance.BorderSize = 0;
            this.hotSpot9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot9.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot9.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot9.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot9.ImageToggleOnSelect = true;
            this.hotSpot9.Location = new System.Drawing.Point(0, 0);
            this.hotSpot9.Marked = false;
            this.hotSpot9.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot9.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot9.MarkedText = "";
            this.hotSpot9.MarkMode = false;
            this.hotSpot9.Name = "hotSpot9";
            this.hotSpot9.NonMarkedText = "Check all";
            this.hotSpot9.Size = new System.Drawing.Size(96, 42);
            this.hotSpot9.TabIndex = 2;
            this.hotSpot9.Text = "Check all";
            this.hotSpot9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot9.ToolTipActive = false;
            this.hotSpot9.ToolTipAutomaticDelay = 500;
            this.hotSpot9.ToolTipAutoPopDelay = 5000;
            this.hotSpot9.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot9.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot9.ToolTipFor4ContextMenu = true;
            this.hotSpot9.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot9.ToolTipInitialDelay = 500;
            this.hotSpot9.ToolTipIsBallon = false;
            this.hotSpot9.ToolTipOwnerDraw = false;
            this.hotSpot9.ToolTipReshowDelay = 100;
            this.hotSpot9.ToolTipShowAlways = false;
            this.hotSpot9.ToolTipText = "";
            this.hotSpot9.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot9.ToolTipTitle = "";
            this.hotSpot9.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot9.UseVisualStyleBackColor = false;
            // 
            // gbGenaratorsSturcture
            // 
            this.gbGenaratorsSturcture.Controls.Add(this.selGenerators);
            this.gbGenaratorsSturcture.Controls.Add(this.panel5);
            this.gbGenaratorsSturcture.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbGenaratorsSturcture.Location = new System.Drawing.Point(3, 3);
            this.gbGenaratorsSturcture.Name = "gbGenaratorsSturcture";
            this.gbGenaratorsSturcture.Size = new System.Drawing.Size(199, 528);
            this.gbGenaratorsSturcture.TabIndex = 6;
            this.gbGenaratorsSturcture.TabStop = false;
            this.gbGenaratorsSturcture.Text = "Generators";
            // 
            // selGenerators
            // 
            this.selGenerators.AllowMultipleChecks = true;
            this.selGenerators.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle15;
            this.selGenerators.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selGenerators.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selGenerators.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selGenerators.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selGenerators.CheckCaption = "chk";
            this.selGenerators.CheckOnDoubleClick = true;
            this.selGenerators.CheckOnSelect = true;
            this.selGenerators.CheckVisible = true;
            this.selGenerators.CheckWith = 32;
            this.selGenerators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selGenerators.IDVisible = false;
            this.selGenerators.IDWith = 32;
            this.selGenerators.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selGenerators.ListEntriesDefaultCellStyle = dataGridViewCellStyle16;
            this.selGenerators.Location = new System.Drawing.Point(3, 58);
            this.selGenerators.Name = "selGenerators";
            this.selGenerators.SelectedIndex = -1;
            this.selGenerators.ShowCaptions = false;
            this.selGenerators.ShowCellToolTips = true;
            this.selGenerators.ShowCountInTitle = true;
            this.selGenerators.ShowSelection = false;
            this.selGenerators.Size = new System.Drawing.Size(193, 467);
            this.selGenerators.TabIndex = 17;
            this.selGenerators.Text = "Generators";
            this.selGenerators.TextCaption = "text";
            this.selGenerators.TextWith = 100;
            this.selGenerators.Title = "gbMain";
            this.selGenerators.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.hotSpot6);
            this.panel5.Controls.Add(this.hotSpot7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 42);
            this.panel5.TabIndex = 2;
            // 
            // hotSpot6
            // 
            this.hotSpot6.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot6.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot6.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot6.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot6.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot6.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot6.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot6.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot6.FlatAppearance.BorderSize = 0;
            this.hotSpot6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot6.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot6.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot6.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot6.ImageToggleOnSelect = true;
            this.hotSpot6.Location = new System.Drawing.Point(96, 0);
            this.hotSpot6.Marked = false;
            this.hotSpot6.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot6.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot6.MarkedText = "";
            this.hotSpot6.MarkMode = false;
            this.hotSpot6.Name = "hotSpot6";
            this.hotSpot6.NonMarkedText = "Uncheck all";
            this.hotSpot6.Size = new System.Drawing.Size(96, 42);
            this.hotSpot6.TabIndex = 3;
            this.hotSpot6.Text = "Uncheck all";
            this.hotSpot6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot6.ToolTipActive = false;
            this.hotSpot6.ToolTipAutomaticDelay = 500;
            this.hotSpot6.ToolTipAutoPopDelay = 5000;
            this.hotSpot6.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot6.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot6.ToolTipFor4ContextMenu = true;
            this.hotSpot6.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot6.ToolTipInitialDelay = 500;
            this.hotSpot6.ToolTipIsBallon = false;
            this.hotSpot6.ToolTipOwnerDraw = false;
            this.hotSpot6.ToolTipReshowDelay = 100;
            this.hotSpot6.ToolTipShowAlways = false;
            this.hotSpot6.ToolTipText = "";
            this.hotSpot6.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot6.ToolTipTitle = "";
            this.hotSpot6.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot6.UseVisualStyleBackColor = false;
            this.hotSpot6.Click += new System.EventHandler(this.hotSpot6_Click);
            // 
            // hotSpot7
            // 
            this.hotSpot7.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot7.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot7.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot7.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot7.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot7.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot7.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot7.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot7.FlatAppearance.BorderSize = 0;
            this.hotSpot7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot7.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot7.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot7.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot7.ImageToggleOnSelect = true;
            this.hotSpot7.Location = new System.Drawing.Point(0, 0);
            this.hotSpot7.Marked = false;
            this.hotSpot7.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot7.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot7.MarkedText = "";
            this.hotSpot7.MarkMode = false;
            this.hotSpot7.Name = "hotSpot7";
            this.hotSpot7.NonMarkedText = "Check all";
            this.hotSpot7.Size = new System.Drawing.Size(96, 42);
            this.hotSpot7.TabIndex = 2;
            this.hotSpot7.Text = "Check all";
            this.hotSpot7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot7.ToolTipActive = false;
            this.hotSpot7.ToolTipAutomaticDelay = 500;
            this.hotSpot7.ToolTipAutoPopDelay = 5000;
            this.hotSpot7.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot7.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot7.ToolTipFor4ContextMenu = true;
            this.hotSpot7.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot7.ToolTipInitialDelay = 500;
            this.hotSpot7.ToolTipIsBallon = false;
            this.hotSpot7.ToolTipOwnerDraw = false;
            this.hotSpot7.ToolTipReshowDelay = 100;
            this.hotSpot7.ToolTipShowAlways = false;
            this.hotSpot7.ToolTipText = "";
            this.hotSpot7.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot7.ToolTipTitle = "";
            this.hotSpot7.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot7.UseVisualStyleBackColor = false;
            this.hotSpot7.Click += new System.EventHandler(this.hotSpot7_Click);
            // 
            // tabPageProcedureStructure
            // 
            this.tabPageProcedureStructure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageProcedureStructure.Controls.Add(this.gbFunctionsStructure);
            this.tabPageProcedureStructure.Controls.Add(this.gbProcedures);
            this.tabPageProcedureStructure.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcedureStructure.Name = "tabPageProcedureStructure";
            this.tabPageProcedureStructure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcedureStructure.Size = new System.Drawing.Size(405, 534);
            this.tabPageProcedureStructure.TabIndex = 4;
            this.tabPageProcedureStructure.Text = "Procedures/Functions";
            // 
            // gbFunctionsStructure
            // 
            this.gbFunctionsStructure.Controls.Add(this.selFunctionsStructure);
            this.gbFunctionsStructure.Controls.Add(this.panel8);
            this.gbFunctionsStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbFunctionsStructure.Location = new System.Drawing.Point(202, 3);
            this.gbFunctionsStructure.Name = "gbFunctionsStructure";
            this.gbFunctionsStructure.Size = new System.Drawing.Size(199, 528);
            this.gbFunctionsStructure.TabIndex = 8;
            this.gbFunctionsStructure.TabStop = false;
            this.gbFunctionsStructure.Text = "Functions";
            // 
            // selFunctionsStructure
            // 
            this.selFunctionsStructure.AllowMultipleChecks = true;
            this.selFunctionsStructure.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle17;
            this.selFunctionsStructure.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selFunctionsStructure.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selFunctionsStructure.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selFunctionsStructure.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selFunctionsStructure.CheckCaption = "chk";
            this.selFunctionsStructure.CheckOnDoubleClick = true;
            this.selFunctionsStructure.CheckOnSelect = true;
            this.selFunctionsStructure.CheckVisible = true;
            this.selFunctionsStructure.CheckWith = 32;
            this.selFunctionsStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selFunctionsStructure.IDVisible = false;
            this.selFunctionsStructure.IDWith = 32;
            this.selFunctionsStructure.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selFunctionsStructure.ListEntriesDefaultCellStyle = dataGridViewCellStyle18;
            this.selFunctionsStructure.Location = new System.Drawing.Point(3, 58);
            this.selFunctionsStructure.Name = "selFunctionsStructure";
            this.selFunctionsStructure.SelectedIndex = -1;
            this.selFunctionsStructure.ShowCaptions = false;
            this.selFunctionsStructure.ShowCellToolTips = true;
            this.selFunctionsStructure.ShowCountInTitle = true;
            this.selFunctionsStructure.ShowSelection = false;
            this.selFunctionsStructure.Size = new System.Drawing.Size(193, 467);
            this.selFunctionsStructure.TabIndex = 17;
            this.selFunctionsStructure.Text = "Procedures";
            this.selFunctionsStructure.TextCaption = "text";
            this.selFunctionsStructure.TextWith = 100;
            this.selFunctionsStructure.Title = "gbMain";
            this.selFunctionsStructure.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.hotSpot12);
            this.panel8.Controls.Add(this.hotSpot13);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 16);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(193, 42);
            this.panel8.TabIndex = 2;
            // 
            // hotSpot12
            // 
            this.hotSpot12.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot12.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot12.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot12.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot12.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot12.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot12.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot12.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot12.FlatAppearance.BorderSize = 0;
            this.hotSpot12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot12.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot12.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot12.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot12.ImageToggleOnSelect = true;
            this.hotSpot12.Location = new System.Drawing.Point(96, 0);
            this.hotSpot12.Marked = false;
            this.hotSpot12.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot12.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot12.MarkedText = "";
            this.hotSpot12.MarkMode = false;
            this.hotSpot12.Name = "hotSpot12";
            this.hotSpot12.NonMarkedText = "Uncheck all";
            this.hotSpot12.Size = new System.Drawing.Size(96, 42);
            this.hotSpot12.TabIndex = 3;
            this.hotSpot12.Text = "Uncheck all";
            this.hotSpot12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot12.ToolTipActive = false;
            this.hotSpot12.ToolTipAutomaticDelay = 500;
            this.hotSpot12.ToolTipAutoPopDelay = 5000;
            this.hotSpot12.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot12.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot12.ToolTipFor4ContextMenu = true;
            this.hotSpot12.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot12.ToolTipInitialDelay = 500;
            this.hotSpot12.ToolTipIsBallon = false;
            this.hotSpot12.ToolTipOwnerDraw = false;
            this.hotSpot12.ToolTipReshowDelay = 100;
            this.hotSpot12.ToolTipShowAlways = false;
            this.hotSpot12.ToolTipText = "";
            this.hotSpot12.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot12.ToolTipTitle = "";
            this.hotSpot12.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot12.UseVisualStyleBackColor = false;
            // 
            // hotSpot13
            // 
            this.hotSpot13.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot13.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot13.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot13.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot13.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot13.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot13.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot13.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot13.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot13.FlatAppearance.BorderSize = 0;
            this.hotSpot13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot13.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot13.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot13.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot13.ImageToggleOnSelect = true;
            this.hotSpot13.Location = new System.Drawing.Point(0, 0);
            this.hotSpot13.Marked = false;
            this.hotSpot13.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot13.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot13.MarkedText = "";
            this.hotSpot13.MarkMode = false;
            this.hotSpot13.Name = "hotSpot13";
            this.hotSpot13.NonMarkedText = "Check all";
            this.hotSpot13.Size = new System.Drawing.Size(96, 42);
            this.hotSpot13.TabIndex = 2;
            this.hotSpot13.Text = "Check all";
            this.hotSpot13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot13.ToolTipActive = false;
            this.hotSpot13.ToolTipAutomaticDelay = 500;
            this.hotSpot13.ToolTipAutoPopDelay = 5000;
            this.hotSpot13.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot13.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot13.ToolTipFor4ContextMenu = true;
            this.hotSpot13.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot13.ToolTipInitialDelay = 500;
            this.hotSpot13.ToolTipIsBallon = false;
            this.hotSpot13.ToolTipOwnerDraw = false;
            this.hotSpot13.ToolTipReshowDelay = 100;
            this.hotSpot13.ToolTipShowAlways = false;
            this.hotSpot13.ToolTipText = "";
            this.hotSpot13.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot13.ToolTipTitle = "";
            this.hotSpot13.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot13.UseVisualStyleBackColor = false;
            // 
            // gbProcedures
            // 
            this.gbProcedures.Controls.Add(this.selProceduresStructure);
            this.gbProcedures.Controls.Add(this.panel7);
            this.gbProcedures.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbProcedures.Location = new System.Drawing.Point(3, 3);
            this.gbProcedures.Name = "gbProcedures";
            this.gbProcedures.Size = new System.Drawing.Size(199, 528);
            this.gbProcedures.TabIndex = 7;
            this.gbProcedures.TabStop = false;
            this.gbProcedures.Text = "Procedures";
            // 
            // selProceduresStructure
            // 
            this.selProceduresStructure.AllowMultipleChecks = true;
            this.selProceduresStructure.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle19;
            this.selProceduresStructure.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selProceduresStructure.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selProceduresStructure.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selProceduresStructure.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selProceduresStructure.CheckCaption = "chk";
            this.selProceduresStructure.CheckOnDoubleClick = true;
            this.selProceduresStructure.CheckOnSelect = true;
            this.selProceduresStructure.CheckVisible = true;
            this.selProceduresStructure.CheckWith = 32;
            this.selProceduresStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selProceduresStructure.IDVisible = false;
            this.selProceduresStructure.IDWith = 32;
            this.selProceduresStructure.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selProceduresStructure.ListEntriesDefaultCellStyle = dataGridViewCellStyle20;
            this.selProceduresStructure.Location = new System.Drawing.Point(3, 58);
            this.selProceduresStructure.Name = "selProceduresStructure";
            this.selProceduresStructure.SelectedIndex = -1;
            this.selProceduresStructure.ShowCaptions = false;
            this.selProceduresStructure.ShowCellToolTips = true;
            this.selProceduresStructure.ShowCountInTitle = true;
            this.selProceduresStructure.ShowSelection = false;
            this.selProceduresStructure.Size = new System.Drawing.Size(193, 467);
            this.selProceduresStructure.TabIndex = 17;
            this.selProceduresStructure.Text = "Procedures";
            this.selProceduresStructure.TextCaption = "text";
            this.selProceduresStructure.TextWith = 100;
            this.selProceduresStructure.Title = "gbMain";
            this.selProceduresStructure.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.hotSpot10);
            this.panel7.Controls.Add(this.hotSpot11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 42);
            this.panel7.TabIndex = 2;
            // 
            // hotSpot10
            // 
            this.hotSpot10.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot10.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot10.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot10.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot10.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot10.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot10.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot10.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot10.FlatAppearance.BorderSize = 0;
            this.hotSpot10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot10.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot10.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot10.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot10.ImageToggleOnSelect = true;
            this.hotSpot10.Location = new System.Drawing.Point(96, 0);
            this.hotSpot10.Marked = false;
            this.hotSpot10.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot10.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot10.MarkedText = "";
            this.hotSpot10.MarkMode = false;
            this.hotSpot10.Name = "hotSpot10";
            this.hotSpot10.NonMarkedText = "Uncheck all";
            this.hotSpot10.Size = new System.Drawing.Size(96, 42);
            this.hotSpot10.TabIndex = 3;
            this.hotSpot10.Text = "Uncheck all";
            this.hotSpot10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot10.ToolTipActive = false;
            this.hotSpot10.ToolTipAutomaticDelay = 500;
            this.hotSpot10.ToolTipAutoPopDelay = 5000;
            this.hotSpot10.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot10.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot10.ToolTipFor4ContextMenu = true;
            this.hotSpot10.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot10.ToolTipInitialDelay = 500;
            this.hotSpot10.ToolTipIsBallon = false;
            this.hotSpot10.ToolTipOwnerDraw = false;
            this.hotSpot10.ToolTipReshowDelay = 100;
            this.hotSpot10.ToolTipShowAlways = false;
            this.hotSpot10.ToolTipText = "";
            this.hotSpot10.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot10.ToolTipTitle = "";
            this.hotSpot10.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot10.UseVisualStyleBackColor = false;
            // 
            // hotSpot11
            // 
            this.hotSpot11.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot11.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot11.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot11.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot11.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot11.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot11.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot11.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot11.FlatAppearance.BorderSize = 0;
            this.hotSpot11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot11.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot11.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot11.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot11.ImageToggleOnSelect = true;
            this.hotSpot11.Location = new System.Drawing.Point(0, 0);
            this.hotSpot11.Marked = false;
            this.hotSpot11.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot11.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot11.MarkedText = "";
            this.hotSpot11.MarkMode = false;
            this.hotSpot11.Name = "hotSpot11";
            this.hotSpot11.NonMarkedText = "Check all";
            this.hotSpot11.Size = new System.Drawing.Size(96, 42);
            this.hotSpot11.TabIndex = 2;
            this.hotSpot11.Text = "Check all";
            this.hotSpot11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot11.ToolTipActive = false;
            this.hotSpot11.ToolTipAutomaticDelay = 500;
            this.hotSpot11.ToolTipAutoPopDelay = 5000;
            this.hotSpot11.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot11.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot11.ToolTipFor4ContextMenu = true;
            this.hotSpot11.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot11.ToolTipInitialDelay = 500;
            this.hotSpot11.ToolTipIsBallon = false;
            this.hotSpot11.ToolTipOwnerDraw = false;
            this.hotSpot11.ToolTipReshowDelay = 100;
            this.hotSpot11.ToolTipShowAlways = false;
            this.hotSpot11.ToolTipText = "";
            this.hotSpot11.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot11.ToolTipTitle = "";
            this.hotSpot11.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot11.UseVisualStyleBackColor = false;
            // 
            // pnlOnjectExportAttributes
            // 
            this.pnlOnjectExportAttributes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOnjectExportAttributes.Controls.Add(this.pnlStructureAttributesUpper);
            this.pnlOnjectExportAttributes.Controls.Add(this.pnlUpperExportStructureObjects);
            this.pnlOnjectExportAttributes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOnjectExportAttributes.Location = new System.Drawing.Point(413, 0);
            this.pnlOnjectExportAttributes.Name = "pnlOnjectExportAttributes";
            this.pnlOnjectExportAttributes.Size = new System.Drawing.Size(395, 560);
            this.pnlOnjectExportAttributes.TabIndex = 5;
            // 
            // pnlStructureAttributesUpper
            // 
            this.pnlStructureAttributesUpper.Controls.Add(this.selExportStructureList);
            this.pnlStructureAttributesUpper.Controls.Add(this.setExportStructureAttributes);
            this.pnlStructureAttributesUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStructureAttributesUpper.Location = new System.Drawing.Point(0, 83);
            this.pnlStructureAttributesUpper.Name = "pnlStructureAttributesUpper";
            this.pnlStructureAttributesUpper.Size = new System.Drawing.Size(395, 477);
            this.pnlStructureAttributesUpper.TabIndex = 1;
            // 
            // selExportStructureList
            // 
            this.selExportStructureList.AllowMultipleChecks = true;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            this.selExportStructureList.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle21;
            this.selExportStructureList.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selExportStructureList.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selExportStructureList.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selExportStructureList.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selExportStructureList.CheckCaption = "chk";
            this.selExportStructureList.CheckOnDoubleClick = true;
            this.selExportStructureList.CheckOnSelect = true;
            this.selExportStructureList.CheckVisible = true;
            this.selExportStructureList.CheckWith = 32;
            this.selExportStructureList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selExportStructureList.IDVisible = false;
            this.selExportStructureList.IDWith = 32;
            this.selExportStructureList.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selExportStructureList.ListEntriesDefaultCellStyle = dataGridViewCellStyle22;
            this.selExportStructureList.Location = new System.Drawing.Point(0, 0);
            this.selExportStructureList.Name = "selExportStructureList";
            this.selExportStructureList.SelectedIndex = -1;
            this.selExportStructureList.ShowCaptions = false;
            this.selExportStructureList.ShowCellToolTips = true;
            this.selExportStructureList.ShowCountInTitle = true;
            this.selExportStructureList.ShowSelection = false;
            this.selExportStructureList.Size = new System.Drawing.Size(213, 477);
            this.selExportStructureList.TabIndex = 0;
            this.selExportStructureList.Text = "seListBox1";
            this.selExportStructureList.TextCaption = "text";
            this.selExportStructureList.TextWith = 174;
            this.selExportStructureList.Title = "Objects to export";
            this.selExportStructureList.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // setExportStructureAttributes
            // 
            this.setExportStructureAttributes.Controls.Add(this.ckWriteFileForEVeryObject);
            this.setExportStructureAttributes.Controls.Add(this.cbStructureCommit);
            this.setExportStructureAttributes.Controls.Add(this.cbStructureConnectiionStatement);
            this.setExportStructureAttributes.Controls.Add(this.hsExportStructure);
            this.setExportStructureAttributes.Controls.Add(this.cbStructureCreateDatabaseStatement);
            this.setExportStructureAttributes.Controls.Add(this.groupBox3);
            this.setExportStructureAttributes.Controls.Add(this.cbViewObjectScript);
            this.setExportStructureAttributes.Controls.Add(this.cbObjectExportToFile);
            this.setExportStructureAttributes.Dock = System.Windows.Forms.DockStyle.Right;
            this.setExportStructureAttributes.Location = new System.Drawing.Point(213, 0);
            this.setExportStructureAttributes.Name = "setExportStructureAttributes";
            this.setExportStructureAttributes.Size = new System.Drawing.Size(182, 477);
            this.setExportStructureAttributes.TabIndex = 16;
            this.setExportStructureAttributes.TabStop = false;
            this.setExportStructureAttributes.Text = "Export attributes";
            // 
            // ckWriteFileForEVeryObject
            // 
            this.ckWriteFileForEVeryObject.AutoSize = true;
            this.ckWriteFileForEVeryObject.Location = new System.Drawing.Point(11, 230);
            this.ckWriteFileForEVeryObject.Name = "ckWriteFileForEVeryObject";
            this.ckWriteFileForEVeryObject.Size = new System.Drawing.Size(143, 17);
            this.ckWriteFileForEVeryObject.TabIndex = 19;
            this.ckWriteFileForEVeryObject.Text = "Write file for every object";
            this.ckWriteFileForEVeryObject.UseVisualStyleBackColor = true;
            // 
            // cbStructureCommit
            // 
            this.cbStructureCommit.AutoSize = true;
            this.cbStructureCommit.Location = new System.Drawing.Point(12, 205);
            this.cbStructureCommit.Name = "cbStructureCommit";
            this.cbStructureCommit.Size = new System.Drawing.Size(160, 17);
            this.cbStructureCommit.TabIndex = 18;
            this.cbStructureCommit.Text = "Commt after every statement";
            this.cbStructureCommit.UseVisualStyleBackColor = true;
            // 
            // cbStructureConnectiionStatement
            // 
            this.cbStructureConnectiionStatement.AutoSize = true;
            this.cbStructureConnectiionStatement.Location = new System.Drawing.Point(12, 182);
            this.cbStructureConnectiionStatement.Name = "cbStructureConnectiionStatement";
            this.cbStructureConnectiionStatement.Size = new System.Drawing.Size(162, 17);
            this.cbStructureConnectiionStatement.TabIndex = 17;
            this.cbStructureConnectiionStatement.Text = "Create connection statement";
            this.cbStructureConnectiionStatement.UseVisualStyleBackColor = true;
            // 
            // hsExportStructure
            // 
            this.hsExportStructure.BackColor = System.Drawing.Color.Transparent;
            this.hsExportStructure.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportStructure.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportStructure.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportStructure.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportStructure.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportStructure.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportStructure.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportStructure.FlatAppearance.BorderSize = 0;
            this.hsExportStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportStructure.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportStructure.Image = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsExportStructure.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportStructure.ImageHover = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsExportStructure.ImageToggleOnSelect = true;
            this.hsExportStructure.Location = new System.Drawing.Point(8, 254);
            this.hsExportStructure.Marked = false;
            this.hsExportStructure.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportStructure.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportStructure.MarkedText = "";
            this.hsExportStructure.MarkMode = false;
            this.hsExportStructure.Name = "hsExportStructure";
            this.hsExportStructure.NonMarkedText = "Export structure for objects";
            this.hsExportStructure.Size = new System.Drawing.Size(166, 48);
            this.hsExportStructure.TabIndex = 1;
            this.hsExportStructure.Text = "Export structure for objects";
            this.hsExportStructure.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportStructure.ToolTipActive = false;
            this.hsExportStructure.ToolTipAutomaticDelay = 500;
            this.hsExportStructure.ToolTipAutoPopDelay = 5000;
            this.hsExportStructure.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportStructure.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportStructure.ToolTipFor4ContextMenu = true;
            this.hsExportStructure.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportStructure.ToolTipInitialDelay = 500;
            this.hsExportStructure.ToolTipIsBallon = false;
            this.hsExportStructure.ToolTipOwnerDraw = false;
            this.hsExportStructure.ToolTipReshowDelay = 100;
            this.hsExportStructure.ToolTipShowAlways = false;
            this.hsExportStructure.ToolTipText = "";
            this.hsExportStructure.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportStructure.ToolTipTitle = "";
            this.hsExportStructure.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportStructure.UseVisualStyleBackColor = false;
            this.hsExportStructure.Click += new System.EventHandler(this.hsExportStructure_Click);
            // 
            // cbStructureCreateDatabaseStatement
            // 
            this.cbStructureCreateDatabaseStatement.AutoSize = true;
            this.cbStructureCreateDatabaseStatement.Location = new System.Drawing.Point(13, 159);
            this.cbStructureCreateDatabaseStatement.Name = "cbStructureCreateDatabaseStatement";
            this.cbStructureCreateDatabaseStatement.Size = new System.Drawing.Size(153, 17);
            this.cbStructureCreateDatabaseStatement.TabIndex = 16;
            this.cbStructureCreateDatabaseStatement.Text = "Create database statement";
            this.cbStructureCreateDatabaseStatement.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCREATEObject);
            this.groupBox3.Controls.Add(this.rbRECREATEObject);
            this.groupBox3.Location = new System.Drawing.Point(6, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 72);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create mode";
            // 
            // rbCREATEObject
            // 
            this.rbCREATEObject.AutoSize = true;
            this.rbCREATEObject.Checked = true;
            this.rbCREATEObject.Location = new System.Drawing.Point(6, 23);
            this.rbCREATEObject.Name = "rbCREATEObject";
            this.rbCREATEObject.Size = new System.Drawing.Size(68, 17);
            this.rbCREATEObject.TabIndex = 1;
            this.rbCREATEObject.TabStop = true;
            this.rbCREATEObject.Text = "CREATE";
            this.rbCREATEObject.UseVisualStyleBackColor = true;
            // 
            // rbRECREATEObject
            // 
            this.rbRECREATEObject.AutoSize = true;
            this.rbRECREATEObject.Location = new System.Drawing.Point(6, 46);
            this.rbRECREATEObject.Name = "rbRECREATEObject";
            this.rbRECREATEObject.Size = new System.Drawing.Size(123, 17);
            this.rbRECREATEObject.TabIndex = 0;
            this.rbRECREATEObject.Text = "RECREATE/ALTER";
            this.rbRECREATEObject.UseVisualStyleBackColor = true;
            // 
            // cbViewObjectScript
            // 
            this.cbViewObjectScript.AutoSize = true;
            this.cbViewObjectScript.Checked = true;
            this.cbViewObjectScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViewObjectScript.Location = new System.Drawing.Point(13, 113);
            this.cbViewObjectScript.Name = "cbViewObjectScript";
            this.cbViewObjectScript.Size = new System.Drawing.Size(93, 17);
            this.cbViewObjectScript.TabIndex = 14;
            this.cbViewObjectScript.Text = "View in scripts";
            this.cbViewObjectScript.UseVisualStyleBackColor = true;
            // 
            // cbObjectExportToFile
            // 
            this.cbObjectExportToFile.AutoSize = true;
            this.cbObjectExportToFile.Location = new System.Drawing.Point(13, 136);
            this.cbObjectExportToFile.Name = "cbObjectExportToFile";
            this.cbObjectExportToFile.Size = new System.Drawing.Size(84, 17);
            this.cbObjectExportToFile.TabIndex = 13;
            this.cbObjectExportToFile.Text = "Export to file";
            this.cbObjectExportToFile.UseVisualStyleBackColor = true;
            // 
            // pnlUpperExportStructureObjects
            // 
            this.pnlUpperExportStructureObjects.Controls.Add(this.hotSpot15);
            this.pnlUpperExportStructureObjects.Controls.Add(this.hotSpot14);
            this.pnlUpperExportStructureObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperExportStructureObjects.Location = new System.Drawing.Point(0, 0);
            this.pnlUpperExportStructureObjects.Name = "pnlUpperExportStructureObjects";
            this.pnlUpperExportStructureObjects.Size = new System.Drawing.Size(395, 83);
            this.pnlUpperExportStructureObjects.TabIndex = 19;
            // 
            // hotSpot15
            // 
            this.hotSpot15.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot15.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot15.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot15.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot15.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot15.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot15.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot15.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot15.FlatAppearance.BorderSize = 0;
            this.hotSpot15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot15.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot15.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hotSpot15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot15.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hotSpot15.ImageToggleOnSelect = true;
            this.hotSpot15.Location = new System.Drawing.Point(104, 41);
            this.hotSpot15.Marked = false;
            this.hotSpot15.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot15.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot15.MarkedText = "";
            this.hotSpot15.MarkMode = false;
            this.hotSpot15.Name = "hotSpot15";
            this.hotSpot15.NonMarkedText = "Uncheck all";
            this.hotSpot15.Size = new System.Drawing.Size(96, 42);
            this.hotSpot15.TabIndex = 18;
            this.hotSpot15.Text = "Uncheck all";
            this.hotSpot15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot15.ToolTipActive = false;
            this.hotSpot15.ToolTipAutomaticDelay = 500;
            this.hotSpot15.ToolTipAutoPopDelay = 5000;
            this.hotSpot15.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot15.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot15.ToolTipFor4ContextMenu = true;
            this.hotSpot15.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot15.ToolTipInitialDelay = 500;
            this.hotSpot15.ToolTipIsBallon = false;
            this.hotSpot15.ToolTipOwnerDraw = false;
            this.hotSpot15.ToolTipReshowDelay = 100;
            this.hotSpot15.ToolTipShowAlways = false;
            this.hotSpot15.ToolTipText = "";
            this.hotSpot15.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot15.ToolTipTitle = "";
            this.hotSpot15.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot15.UseVisualStyleBackColor = false;
            this.hotSpot15.Click += new System.EventHandler(this.hotSpot15_Click);
            // 
            // hotSpot14
            // 
            this.hotSpot14.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot14.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot14.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot14.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot14.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot14.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot14.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot14.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot14.FlatAppearance.BorderSize = 0;
            this.hotSpot14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot14.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot14.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hotSpot14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot14.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hotSpot14.ImageToggleOnSelect = true;
            this.hotSpot14.Location = new System.Drawing.Point(2, 41);
            this.hotSpot14.Marked = false;
            this.hotSpot14.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot14.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot14.MarkedText = "";
            this.hotSpot14.MarkMode = false;
            this.hotSpot14.Name = "hotSpot14";
            this.hotSpot14.NonMarkedText = "Check all";
            this.hotSpot14.Size = new System.Drawing.Size(96, 42);
            this.hotSpot14.TabIndex = 17;
            this.hotSpot14.Text = "Check all";
            this.hotSpot14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot14.ToolTipActive = false;
            this.hotSpot14.ToolTipAutomaticDelay = 500;
            this.hotSpot14.ToolTipAutoPopDelay = 5000;
            this.hotSpot14.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot14.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot14.ToolTipFor4ContextMenu = true;
            this.hotSpot14.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot14.ToolTipInitialDelay = 500;
            this.hotSpot14.ToolTipIsBallon = false;
            this.hotSpot14.ToolTipOwnerDraw = false;
            this.hotSpot14.ToolTipReshowDelay = 100;
            this.hotSpot14.ToolTipShowAlways = false;
            this.hotSpot14.ToolTipText = "";
            this.hotSpot14.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot14.ToolTipTitle = "";
            this.hotSpot14.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot14.UseVisualStyleBackColor = false;
            this.hotSpot14.Click += new System.EventHandler(this.hotSpot14_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 10);
            this.panel1.TabIndex = 2;
            // 
            // ofdSQL
            // 
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
            // 
            // bsTableContent
            // 
            this.bsTableContent.DataSource = this.dsTableContent;
            this.bsTableContent.Position = 0;
            // 
            // dsTableContent
            // 
            this.dsTableContent.DataSetName = "NewDataSet";
            this.dsTableContent.Tables.AddRange(new System.Data.DataTable[] {
            this.Table});
            // 
            // Table
            // 
            this.Table.TableName = "Table";
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "*.sql";
            this.sfdFile.Filter = "SQL|*.sql|All|*.*";
            this.sfdFile.Title = "SQL File";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_closed_22x.png");
            this.imageList1.Images.SetKeyName(1, "document_blue_x24.png");
            // 
            // EXPORTDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 662);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EXPORTDataForm";
            this.Text = "EXPORTDataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EXPORTDataForm_FormClosing);
            this.Load += new System.EventHandler(this.EXPORTDataForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTableExports.ResumeLayout(false);
            this.gbTableFields.ResumeLayout(false);
            this.pnlTableFieldsUpper.ResumeLayout(false);
            this.gbTablesDataExport.ResumeLayout(false);
            this.pnlTableUpper.ResumeLayout(false);
            this.cmsEXPORTData.ResumeLayout(false);
            this.cmsMessagesText.ResumeLayout(false);
            this.cmdDATA.ResumeLayout(false);
            this.cmsDDLText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUniques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUniques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.gbFileExport.ResumeLayout(false);
            this.gbFileName.ResumeLayout(false);
            this.gbFileName.PerformLayout();
            this.gbDirectory.ResumeLayout(false);
            this.gbDirectory.PerformLayout();
            this.gbFolder.ResumeLayout(false);
            this.gbCharset.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDataExports.ResumeLayout(false);
            this.pnlTableRight.ResumeLayout(false);
            this.gbExportAttributes.ResumeLayout(false);
            this.gbExportAttributes.PerformLayout();
            this.gbInsertUpdate.ResumeLayout(false);
            this.gbInsertUpdate.PerformLayout();
            this.tabStructureExports.ResumeLayout(false);
            this.pnlStructureCenter.ResumeLayout(false);
            this.tabControlStructures.ResumeLayout(false);
            this.tabPageStructureTables.ResumeLayout(false);
            this.gbStructureTables.ResumeLayout(false);
            this.pnlStructureObjectsUpper.ResumeLayout(false);
            this.tabPageStructureViews.ResumeLayout(false);
            this.gbStructureViews.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabIndecesStructur.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbDomains.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabGeneratorStructure.ResumeLayout(false);
            this.gbTriggersStructrue.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.gbGenaratorsSturcture.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPageProcedureStructure.ResumeLayout(false);
            this.gbFunctionsStructure.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.gbProcedures.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlOnjectExportAttributes.ResumeLayout(false);
            this.pnlStructureAttributesUpper.ResumeLayout(false);
            this.setExportStructureAttributes.ResumeLayout(false);
            this.setExportStructureAttributes.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlUpperExportStructureObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTableContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTableContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTableExports;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.Label lblTableName;
        private SeControlsLib.HotSpot hsExportTable;
        private System.Windows.Forms.BindingSource bsUniques;
        private System.Data.DataSet dsUniques;
        private System.Data.DataTable dataTable3;
        private System.Windows.Forms.ContextMenuStrip cmsDDLText;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLPaste;
        private System.Windows.Forms.ContextMenuStrip cmsMessagesText;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessageCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessagePaste;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.ContextMenuStrip cmdDATA;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetToNULL;
        private System.Windows.Forms.ToolStripMenuItem tsmiDate;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.ContextMenuStrip cmsEXPORTData;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXPORTDataCopyToCLipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXPORTDataPasteFromClipboard;
        private System.Windows.Forms.BindingSource bsTableContent;
        private System.Data.DataSet dsTableContent;
        private System.Data.DataTable Table;
        private System.Windows.Forms.GroupBox gbTablesDataExport;
        private System.Windows.Forms.Panel pnlTableUpper;
        private SeControlsLib.HotSpot hsUncheckAlltables;
        private SeControlsLib.HotSpot hsCheckAllTables;
        private System.Windows.Forms.Panel pnlTableRight;
        private System.Windows.Forms.GroupBox gbInsertUpdate;
        private System.Windows.Forms.RadioButton rbUPDATE;
        private System.Windows.Forms.RadioButton rbINSERTUPDATE;
        private System.Windows.Forms.RadioButton rbINSERT;
        private System.Windows.Forms.GroupBox gbCharset;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.CheckBox cbExportToFile;
        private System.Windows.Forms.GroupBox gbFileExport;
        private System.Windows.Forms.CheckBox cbViewInScript;
        private System.Windows.Forms.GroupBox gbFileName;
        private System.Windows.Forms.TextBox txtFileName;
       
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox gbFolder;
        private SeControlsLib.HotSpot hsLastFolder;
        private System.Windows.Forms.ImageList imageList1;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.GroupBox gbExportAttributes;
        private System.Windows.Forms.TabPage tabExtExports;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDataExports;
        private System.Windows.Forms.TabPage tabStructureExports;
        private System.Windows.Forms.Panel pnlStructureCenter;
        private System.Windows.Forms.GroupBox gbStructureTables;
        private System.Windows.Forms.Panel pnlStructureObjectsUpper;
        private SeControlsLib.HotSpot hsUnselectStructureObjects;
        private SeControlsLib.HotSpot hsSelectStructureObjects;
        private System.Windows.Forms.Panel panel1;
        private SeControlsLib.HotSpot hsExportStructure;
        private System.Windows.Forms.Panel pnlOnjectExportAttributes;
        private System.Windows.Forms.GroupBox setExportStructureAttributes;
        private System.Windows.Forms.CheckBox cbViewObjectScript;
        private System.Windows.Forms.CheckBox cbObjectExportToFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCREATEObject;
        private System.Windows.Forms.RadioButton rbRECREATEObject;
        private System.Windows.Forms.GroupBox gbStructureViews;
        private System.Windows.Forms.Panel panel2;
        private SeControlsLib.HotSpot hsUnselectAllViews;
        private SeControlsLib.HotSpot hsSelectAllViews;
        private System.Windows.Forms.TabControl tabControlStructures;
        private System.Windows.Forms.TabPage tabPageStructureTables;
        private System.Windows.Forms.TabPage tabPageStructureViews;
        private SEListBox.SEListBox selExportStructureList;
        private SEListBox.SEListBox selStructureTables;
        private SEListBox.SEListBox selStructureViews;
        private System.Windows.Forms.GroupBox gbTableFields;
        private SEListBox.SEListBox selFields;
        private System.Windows.Forms.Panel pnlTableFieldsUpper;
        private SeControlsLib.HotSpot hsUncheckAllTableFields;
        private SeControlsLib.HotSpot hsCheckAllTableFields;
        private SEListBox.SEListBox selTables;
        private System.Windows.Forms.Panel pnlStructureAttributesUpper;
        private System.Windows.Forms.CheckBox cbStructureConnectiionStatement;
        private System.Windows.Forms.CheckBox cbStructureCreateDatabaseStatement;
        private System.Windows.Forms.CheckBox cbStructureCommit;
        private System.Windows.Forms.GroupBox gbDomains;
        private SEListBox.SEListBox selDomains;
        private System.Windows.Forms.Panel panel3;
        private SeControlsLib.HotSpot hotSpot3;
        private SeControlsLib.HotSpot hotSpot4;
        private System.Windows.Forms.TabPage tabIndecesStructur;
        private System.Windows.Forms.GroupBox groupBox2;
        private SEListBox.SEListBox selIndeces;
        private System.Windows.Forms.Panel panel4;
        private SeControlsLib.HotSpot hotSpot1;
        private SeControlsLib.HotSpot hotSpot5;
        private System.Windows.Forms.TabPage tabGeneratorStructure;
        private System.Windows.Forms.GroupBox gbGenaratorsSturcture;
        private SEListBox.SEListBox selGenerators;
        private System.Windows.Forms.Panel panel5;
        private SeControlsLib.HotSpot hotSpot6;
        private SeControlsLib.HotSpot hotSpot7;
        private System.Windows.Forms.GroupBox gbTriggersStructrue;
        private SEListBox.SEListBox selTriggerStructure;
        private System.Windows.Forms.Panel panel6;
        private SeControlsLib.HotSpot hotSpot8;
        private SeControlsLib.HotSpot hotSpot9;
        private System.Windows.Forms.TabPage tabPageProcedureStructure;
        private System.Windows.Forms.GroupBox gbProcedures;
        private SEListBox.SEListBox selProceduresStructure;
        private System.Windows.Forms.Panel panel7;
        private SeControlsLib.HotSpot hotSpot10;
        private SeControlsLib.HotSpot hotSpot11;
        private System.Windows.Forms.GroupBox gbFunctionsStructure;
        private SEListBox.SEListBox selFunctionsStructure;
        private System.Windows.Forms.Panel panel8;
        private SeControlsLib.HotSpot hotSpot12;
        private SeControlsLib.HotSpot hotSpot13;
        private SeControlsLib.HotSpot hotSpot14;
        private System.Windows.Forms.Panel pnlUpperExportStructureObjects;
        private SeControlsLib.HotSpot hotSpot15;
        private System.Windows.Forms.CheckBox ckWriteFileForEVeryObject;
        private System.Windows.Forms.GroupBox gbDirectory;
        private SeControlsLib.HotSpot hsExportFolder;
        private System.Windows.Forms.TextBox txtExportDirectory;
    }
}