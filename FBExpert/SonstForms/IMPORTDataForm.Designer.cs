using BasicForms;
using SEListBox;

namespace FBExpert
{
    partial class IMPORTDataForm : BasicNormalFormClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMPORTDataForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTableImports = new System.Windows.Forms.TabPage();
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
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.cmsColDefData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEXPORTDataCopyToCLipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEXPORTDataPasteFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDateTimeNow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateTimeToday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiINT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDOUBLE = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMessagesText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMessageCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMessagePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDATA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSetToNULL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDDLText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDDLCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDDLPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.gbFileExport = new System.Windows.Forms.GroupBox();
            this.gbImport = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbColDef = new System.Windows.Forms.GroupBox();
            this.rtbColDef = new System.Windows.Forms.RichTextBox();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQLAll = new System.Windows.Forms.TabPage();
            this.txtSQLAll = new System.Windows.Forms.TextBox();
            this.pnlSQLAllUpper = new System.Windows.Forms.Panel();
            this.hsCalcel = new SeControlsLib.HotSpot();
            this.gbEncoding = new System.Windows.Forms.GroupBox();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.hsDoSQL = new SeControlsLib.HotSpot();
            this.tabPageSQLdone = new System.Windows.Forms.TabPage();
            this.txtSQLdone = new System.Windows.Forms.TextBox();
            this.tabPageSQLfail = new System.Windows.Forms.TabPage();
            this.txtSQLfail = new System.Windows.Forms.TextBox();
            this.gbProcessBar = new System.Windows.Forms.GroupBox();
            this.pbSQL = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSQLMode = new System.Windows.Forms.GroupBox();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.ckEmptyLists = new System.Windows.Forms.CheckBox();
            this.ckTestmode = new System.Windows.Forms.CheckBox();
            this.hsImport = new SeControlsLib.HotSpot();
            this.hsSaveDefinitions = new SeControlsLib.HotSpot();
            this.hsLoadDefinition = new SeControlsLib.HotSpot();
            this.tabControlImport = new System.Windows.Forms.TabControl();
            this.tabPageImportfile = new System.Windows.Forms.TabPage();
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.pnlUpperIports = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEncodingCSV = new System.Windows.Forms.ComboBox();
            this.hsImportCSV = new SeControlsLib.HotSpot();
            this.hsImportXML = new SeControlsLib.HotSpot();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabTableImports.SuspendLayout();
            this.gbTableFields.SuspendLayout();
            this.pnlTableFieldsUpper.SuspendLayout();
            this.gbTablesDataExport.SuspendLayout();
            this.pnlTableUpper.SuspendLayout();
            this.cmsColDefData.SuspendLayout();
            this.cmsMessagesText.SuspendLayout();
            this.cmdDATA.SuspendLayout();
            this.cmsDDLText.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.gbFileExport.SuspendLayout();
            this.gbImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbColDef.SuspendLayout();
            this.gbSQL.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSQLAll.SuspendLayout();
            this.pnlSQLAllUpper.SuspendLayout();
            this.gbEncoding.SuspendLayout();
            this.tabPageSQLdone.SuspendLayout();
            this.tabPageSQLfail.SuspendLayout();
            this.gbProcessBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSQLMode.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.tabControlImport.SuspendLayout();
            this.tabPageImportfile.SuspendLayout();
            this.pnlUpperIports.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTableImports);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.ImageList = this.ilTabControl;
            this.tabControl.Location = new System.Drawing.Point(3, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(471, 583);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTableImports
            // 
            this.tabTableImports.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabTableImports.Controls.Add(this.gbTableFields);
            this.tabTableImports.Controls.Add(this.gbTablesDataExport);
            this.tabTableImports.ImageKey = "table_blue_x24.png";
            this.tabTableImports.Location = new System.Drawing.Point(4, 23);
            this.tabTableImports.Name = "tabTableImports";
            this.tabTableImports.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableImports.Size = new System.Drawing.Size(463, 556);
            this.tabTableImports.TabIndex = 0;
            this.tabTableImports.Text = "Table data import";
            // 
            // gbTableFields
            // 
            this.gbTableFields.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTableFields.Controls.Add(this.selFields);
            this.gbTableFields.Controls.Add(this.pnlTableFieldsUpper);
            this.gbTableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTableFields.Location = new System.Drawing.Point(245, 3);
            this.gbTableFields.Name = "gbTableFields";
            this.gbTableFields.Size = new System.Drawing.Size(215, 550);
            this.gbTableFields.TabIndex = 4;
            this.gbTableFields.TabStop = false;
            this.gbTableFields.Text = "Fields";
            // 
            // selFields
            // 
            this.selFields.AllowMultipleChecks = true;
            this.selFields.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle9;
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
            this.selFields.ListEntriesDefaultCellStyle = dataGridViewCellStyle10;
            this.selFields.Location = new System.Drawing.Point(3, 58);
            this.selFields.Name = "selFields";
            this.selFields.SelectedIndex = -1;
            this.selFields.ShowCaptions = false;
            this.selFields.ShowCellToolTips = true;
            this.selFields.ShowCountInTitle = true;
            this.selFields.ShowSelection = false;
            this.selFields.Size = new System.Drawing.Size(209, 489);
            this.selFields.TabIndex = 19;
            this.selFields.Text = "selFields";
            this.selFields.TextCaption = "text";
            this.selFields.TextWith = 100;
            this.selFields.Title = "gbMain";
            this.selFields.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.selFields.ItemCheckChanged += new SEListBox.SEListBox.CheckItemEventHandler(this.selFields_ItemCheckChanged);
            this.selFields.ItemSelect += new SEListBox.SEListBox.SelectItemEventHandler(this.selFields_SelectItem);
            // 
            // pnlTableFieldsUpper
            // 
            this.pnlTableFieldsUpper.Controls.Add(this.hsUncheckAllTableFields);
            this.pnlTableFieldsUpper.Controls.Add(this.hsCheckAllTableFields);
            this.pnlTableFieldsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableFieldsUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlTableFieldsUpper.Name = "pnlTableFieldsUpper";
            this.pnlTableFieldsUpper.Size = new System.Drawing.Size(209, 42);
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
            this.hsUncheckAllTableFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsUncheckAllTableFields.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUncheckAllTableFields.ShowShortcut = false;
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
            this.hsCheckAllTableFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsCheckAllTableFields.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCheckAllTableFields.ShowShortcut = false;
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
            this.gbTablesDataExport.Size = new System.Drawing.Size(242, 550);
            this.gbTablesDataExport.TabIndex = 3;
            this.gbTablesDataExport.TabStop = false;
            this.gbTablesDataExport.Text = "Tables";
            // 
            // selTables
            // 
            this.selTables.AllowMultipleChecks = true;
            this.selTables.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle11;
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
            this.selTables.ListEntriesDefaultCellStyle = dataGridViewCellStyle12;
            this.selTables.Location = new System.Drawing.Point(3, 58);
            this.selTables.Name = "selTables";
            this.selTables.SelectedIndex = -1;
            this.selTables.ShowCaptions = false;
            this.selTables.ShowCellToolTips = true;
            this.selTables.ShowCountInTitle = true;
            this.selTables.ShowSelection = true;
            this.selTables.Size = new System.Drawing.Size(236, 489);
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
            this.pnlTableUpper.Size = new System.Drawing.Size(236, 42);
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
            this.hsUncheckAlltables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsUncheckAlltables.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUncheckAlltables.ShowShortcut = false;
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
            this.hsCheckAllTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsCheckAllTables.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCheckAllTables.ShowShortcut = false;
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
            // cmsColDefData
            // 
            this.cmsColDefData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsColDefData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEXPORTDataCopyToCLipboard,
            this.tsmiEXPORTDataPasteFromClipboard,
            this.toolStripSeparator1,
            this.tsmiDateTimeNow,
            this.tsmiDateTimeToday,
            this.tsmiINT,
            this.tsmiDOUBLE});
            this.cmsColDefData.Name = "cmsText";
            this.cmsColDefData.Size = new System.Drawing.Size(176, 166);
            this.cmsColDefData.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsColDefData_ItemClicked);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // tsmiDateTimeNow
            // 
            this.tsmiDateTimeNow.Name = "tsmiDateTimeNow";
            this.tsmiDateTimeNow.Size = new System.Drawing.Size(175, 26);
            this.tsmiDateTimeNow.Text = "DateTime.Now";
            // 
            // tsmiDateTimeToday
            // 
            this.tsmiDateTimeToday.Name = "tsmiDateTimeToday";
            this.tsmiDateTimeToday.Size = new System.Drawing.Size(175, 26);
            this.tsmiDateTimeToday.Text = "DateTime.Today";
            // 
            // tsmiINT
            // 
            this.tsmiINT.Name = "tsmiINT";
            this.tsmiINT.Size = new System.Drawing.Size(175, 26);
            this.tsmiINT.Text = "INT(0)";
            // 
            // tsmiDOUBLE
            // 
            this.tsmiDOUBLE.Name = "tsmiDOUBLE";
            this.tsmiDOUBLE.Size = new System.Drawing.Size(175, 26);
            this.tsmiDOUBLE.Text = "DOUBLE(0)";
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
            this.cmdDATA.Size = new System.Drawing.Size(142, 56);
            // 
            // tsmiSetToNULL
            // 
            this.tsmiSetToNULL.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiSetToNULL.Name = "tsmiSetToNULL";
            this.tsmiSetToNULL.Size = new System.Drawing.Size(141, 26);
            this.tsmiSetToNULL.Text = "Set To NULL";
            // 
            // tsmiDate
            // 
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.Size = new System.Drawing.Size(141, 26);
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
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1391, 44);
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
            this.hsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(1346, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefresh.ShowShortcut = false;
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
            this.hsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsClose.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClose.ShowShortcut = false;
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
            this.pnlLower.Size = new System.Drawing.Size(1391, 16);
            this.pnlLower.TabIndex = 2;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.gbFileExport);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 44);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1391, 602);
            this.pnlCenter.TabIndex = 3;
            // 
            // gbFileExport
            // 
            this.gbFileExport.Controls.Add(this.gbImport);
            this.gbFileExport.Controls.Add(this.tabControlImport);
            this.gbFileExport.Controls.Add(this.tabControl);
            this.gbFileExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileExport.Location = new System.Drawing.Point(0, 0);
            this.gbFileExport.Name = "gbFileExport";
            this.gbFileExport.Size = new System.Drawing.Size(1391, 602);
            this.gbFileExport.TabIndex = 15;
            this.gbFileExport.TabStop = false;
            // 
            // gbImport
            // 
            this.gbImport.Controls.Add(this.splitContainer1);
            this.gbImport.Controls.Add(this.panel1);
            this.gbImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbImport.Location = new System.Drawing.Point(867, 16);
            this.gbImport.Name = "gbImport";
            this.gbImport.Size = new System.Drawing.Size(521, 583);
            this.gbImport.TabIndex = 17;
            this.gbImport.TabStop = false;
            this.gbImport.Text = "Import";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 69);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.gbColDef);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.gbSQL);
            this.splitContainer1.Size = new System.Drawing.Size(515, 511);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 7;
            // 
            // gbColDef
            // 
            this.gbColDef.Controls.Add(this.rtbColDef);
            this.gbColDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbColDef.Location = new System.Drawing.Point(0, 0);
            this.gbColDef.Name = "gbColDef";
            this.gbColDef.Size = new System.Drawing.Size(200, 511);
            this.gbColDef.TabIndex = 6;
            this.gbColDef.TabStop = false;
            this.gbColDef.Text = "Col Definitions";
            // 
            // rtbColDef
            // 
            this.rtbColDef.ContextMenuStrip = this.cmsColDefData;
            this.rtbColDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbColDef.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbColDef.Location = new System.Drawing.Point(3, 16);
            this.rtbColDef.Name = "rtbColDef";
            this.rtbColDef.Size = new System.Drawing.Size(194, 492);
            this.rtbColDef.TabIndex = 4;
            this.rtbColDef.Text = "#SQL>UPDATE TKUNDBEWIMPORT SET TKUNDBEWIMPORT.LIEFERANZAHL = |SourceValue#anz| WH" +
    "ERE TKUNDBEWIMPORT.KDNR = |SourceValue#debnr|";
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.tabControl1);
            this.gbSQL.Controls.Add(this.gbProcessBar);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(0, 0);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(309, 511);
            this.gbSQL.TabIndex = 5;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "SQL";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQLAll);
            this.tabControl1.Controls.Add(this.tabPageSQLdone);
            this.tabControl1.Controls.Add(this.tabPageSQLfail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 458);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageSQLAll
            // 
            this.tabPageSQLAll.Controls.Add(this.txtSQLAll);
            this.tabPageSQLAll.Controls.Add(this.pnlSQLAllUpper);
            this.tabPageSQLAll.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQLAll.Name = "tabPageSQLAll";
            this.tabPageSQLAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQLAll.Size = new System.Drawing.Size(295, 432);
            this.tabPageSQLAll.TabIndex = 2;
            this.tabPageSQLAll.Text = "SQL all";
            this.tabPageSQLAll.UseVisualStyleBackColor = true;
            // 
            // txtSQLAll
            // 
            this.txtSQLAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLAll.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLAll.Location = new System.Drawing.Point(3, 50);
            this.txtSQLAll.Multiline = true;
            this.txtSQLAll.Name = "txtSQLAll";
            this.txtSQLAll.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLAll.Size = new System.Drawing.Size(289, 379);
            this.txtSQLAll.TabIndex = 5;
            this.txtSQLAll.WordWrap = false;
            // 
            // pnlSQLAllUpper
            // 
            this.pnlSQLAllUpper.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSQLAllUpper.Controls.Add(this.hsCalcel);
            this.pnlSQLAllUpper.Controls.Add(this.gbEncoding);
            this.pnlSQLAllUpper.Controls.Add(this.hsDoSQL);
            this.pnlSQLAllUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLAllUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLAllUpper.Name = "pnlSQLAllUpper";
            this.pnlSQLAllUpper.Size = new System.Drawing.Size(289, 47);
            this.pnlSQLAllUpper.TabIndex = 6;
            // 
            // hsCalcel
            // 
            this.hsCalcel.BackColor = System.Drawing.Color.Transparent;
            this.hsCalcel.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCalcel.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCalcel.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCalcel.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCalcel.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCalcel.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCalcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCalcel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCalcel.FlatAppearance.BorderSize = 0;
            this.hsCalcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCalcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCalcel.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCalcel.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.hsCalcel.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsCalcel.ImageToggleOnSelect = true;
            this.hsCalcel.Location = new System.Drawing.Point(194, 0);
            this.hsCalcel.Marked = false;
            this.hsCalcel.MarkedColor = System.Drawing.Color.Teal;
            this.hsCalcel.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCalcel.MarkedText = "";
            this.hsCalcel.MarkMode = false;
            this.hsCalcel.Name = "hsCalcel";
            this.hsCalcel.NonMarkedText = "";
            this.hsCalcel.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCalcel.ShowShortcut = false;
            this.hsCalcel.Size = new System.Drawing.Size(64, 47);
            this.hsCalcel.TabIndex = 7;
            this.hsCalcel.Text = "Cancel";
            this.hsCalcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCalcel.ToolTipActive = false;
            this.hsCalcel.ToolTipAutomaticDelay = 500;
            this.hsCalcel.ToolTipAutoPopDelay = 5000;
            this.hsCalcel.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCalcel.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCalcel.ToolTipFor4ContextMenu = true;
            this.hsCalcel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCalcel.ToolTipInitialDelay = 500;
            this.hsCalcel.ToolTipIsBallon = false;
            this.hsCalcel.ToolTipOwnerDraw = false;
            this.hsCalcel.ToolTipReshowDelay = 100;
            this.hsCalcel.ToolTipShowAlways = false;
            this.hsCalcel.ToolTipText = "";
            this.hsCalcel.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCalcel.ToolTipTitle = "";
            this.hsCalcel.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCalcel.UseVisualStyleBackColor = false;
            this.hsCalcel.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // gbEncoding
            // 
            this.gbEncoding.BackColor = System.Drawing.Color.Gainsboro;
            this.gbEncoding.Controls.Add(this.cbEncoding);
            this.gbEncoding.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbEncoding.Location = new System.Drawing.Point(72, 0);
            this.gbEncoding.Name = "gbEncoding";
            this.gbEncoding.Size = new System.Drawing.Size(122, 47);
            this.gbEncoding.TabIndex = 26;
            this.gbEncoding.TabStop = false;
            this.gbEncoding.Text = "Encoding DB";
            // 
            // cbEncoding
            // 
            this.cbEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "NONE",
            "UTF8",
            "ASCII",
            "ISO8859_1"});
            this.cbEncoding.Location = new System.Drawing.Point(3, 16);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(116, 21);
            this.cbEncoding.TabIndex = 34;
            this.cbEncoding.Text = "UTF8";
            // 
            // hsDoSQL
            // 
            this.hsDoSQL.BackColor = System.Drawing.Color.Transparent;
            this.hsDoSQL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDoSQL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDoSQL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDoSQL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDoSQL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDoSQL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDoSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsDoSQL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDoSQL.FlatAppearance.BorderSize = 0;
            this.hsDoSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDoSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDoSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDoSQL.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsDoSQL.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsDoSQL.ImageToggleOnSelect = true;
            this.hsDoSQL.Location = new System.Drawing.Point(0, 0);
            this.hsDoSQL.Marked = false;
            this.hsDoSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsDoSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDoSQL.MarkedText = "";
            this.hsDoSQL.MarkMode = false;
            this.hsDoSQL.Name = "hsDoSQL";
            this.hsDoSQL.NonMarkedText = "";
            this.hsDoSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDoSQL.ShowShortcut = false;
            this.hsDoSQL.Size = new System.Drawing.Size(72, 47);
            this.hsDoSQL.TabIndex = 8;
            this.hsDoSQL.Text = "Do SQL";
            this.hsDoSQL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDoSQL.ToolTipActive = false;
            this.hsDoSQL.ToolTipAutomaticDelay = 500;
            this.hsDoSQL.ToolTipAutoPopDelay = 5000;
            this.hsDoSQL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDoSQL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDoSQL.ToolTipFor4ContextMenu = true;
            this.hsDoSQL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDoSQL.ToolTipInitialDelay = 500;
            this.hsDoSQL.ToolTipIsBallon = false;
            this.hsDoSQL.ToolTipOwnerDraw = false;
            this.hsDoSQL.ToolTipReshowDelay = 100;
            this.hsDoSQL.ToolTipShowAlways = false;
            this.hsDoSQL.ToolTipText = "";
            this.hsDoSQL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDoSQL.ToolTipTitle = "";
            this.hsDoSQL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDoSQL.UseVisualStyleBackColor = false;
            this.hsDoSQL.Click += new System.EventHandler(this.hsDoSQL_Click);
            // 
            // tabPageSQLdone
            // 
            this.tabPageSQLdone.Controls.Add(this.txtSQLdone);
            this.tabPageSQLdone.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQLdone.Name = "tabPageSQLdone";
            this.tabPageSQLdone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQLdone.Size = new System.Drawing.Size(368, 432);
            this.tabPageSQLdone.TabIndex = 0;
            this.tabPageSQLdone.Text = "SQL done";
            this.tabPageSQLdone.UseVisualStyleBackColor = true;
            // 
            // txtSQLdone
            // 
            this.txtSQLdone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLdone.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLdone.Location = new System.Drawing.Point(3, 3);
            this.txtSQLdone.Multiline = true;
            this.txtSQLdone.Name = "txtSQLdone";
            this.txtSQLdone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLdone.Size = new System.Drawing.Size(362, 426);
            this.txtSQLdone.TabIndex = 3;
            this.txtSQLdone.WordWrap = false;
            // 
            // tabPageSQLfail
            // 
            this.tabPageSQLfail.Controls.Add(this.txtSQLfail);
            this.tabPageSQLfail.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQLfail.Name = "tabPageSQLfail";
            this.tabPageSQLfail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQLfail.Size = new System.Drawing.Size(368, 432);
            this.tabPageSQLfail.TabIndex = 1;
            this.tabPageSQLfail.Text = "SQL fail";
            this.tabPageSQLfail.UseVisualStyleBackColor = true;
            // 
            // txtSQLfail
            // 
            this.txtSQLfail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLfail.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLfail.Location = new System.Drawing.Point(3, 3);
            this.txtSQLfail.Multiline = true;
            this.txtSQLfail.Name = "txtSQLfail";
            this.txtSQLfail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLfail.Size = new System.Drawing.Size(362, 426);
            this.txtSQLfail.TabIndex = 4;
            this.txtSQLfail.WordWrap = false;
            // 
            // gbProcessBar
            // 
            this.gbProcessBar.Controls.Add(this.pbSQL);
            this.gbProcessBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbProcessBar.Location = new System.Drawing.Point(3, 474);
            this.gbProcessBar.Name = "gbProcessBar";
            this.gbProcessBar.Size = new System.Drawing.Size(303, 34);
            this.gbProcessBar.TabIndex = 4;
            this.gbProcessBar.TabStop = false;
            this.gbProcessBar.Text = "Process";
            // 
            // pbSQL
            // 
            this.pbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSQL.Location = new System.Drawing.Point(3, 16);
            this.pbSQL.Name = "pbSQL";
            this.pbSQL.Size = new System.Drawing.Size(297, 15);
            this.pbSQL.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbSQLMode);
            this.panel1.Controls.Add(this.gbAttributes);
            this.panel1.Controls.Add(this.hsImport);
            this.panel1.Controls.Add(this.hsSaveDefinitions);
            this.panel1.Controls.Add(this.hsLoadDefinition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 53);
            this.panel1.TabIndex = 2;
            // 
            // gbSQLMode
            // 
            this.gbSQLMode.Controls.Add(this.rbUpdate);
            this.gbSQLMode.Controls.Add(this.rbInsert);
            this.gbSQLMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSQLMode.Location = new System.Drawing.Point(376, 0);
            this.gbSQLMode.Name = "gbSQLMode";
            this.gbSQLMode.Size = new System.Drawing.Size(82, 53);
            this.gbSQLMode.TabIndex = 6;
            this.gbSQLMode.TabStop = false;
            this.gbSQLMode.Text = "SQL mode";
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(12, 33);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbUpdate.TabIndex = 1;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Checked = true;
            this.rbInsert.Location = new System.Drawing.Point(12, 16);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(51, 17);
            this.rbInsert.TabIndex = 0;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "Insert";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.ckEmptyLists);
            this.gbAttributes.Controls.Add(this.ckTestmode);
            this.gbAttributes.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbAttributes.Location = new System.Drawing.Point(285, 0);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(91, 53);
            this.gbAttributes.TabIndex = 5;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Attributes";
            // 
            // ckEmptyLists
            // 
            this.ckEmptyLists.AutoSize = true;
            this.ckEmptyLists.Checked = true;
            this.ckEmptyLists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEmptyLists.Location = new System.Drawing.Point(6, 31);
            this.ckEmptyLists.Name = "ckEmptyLists";
            this.ckEmptyLists.Size = new System.Drawing.Size(79, 17);
            this.ckEmptyLists.TabIndex = 3;
            this.ckEmptyLists.Text = "Empty Lists";
            this.ckEmptyLists.UseVisualStyleBackColor = true;
            // 
            // ckTestmode
            // 
            this.ckTestmode.AutoSize = true;
            this.ckTestmode.Checked = true;
            this.ckTestmode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTestmode.Location = new System.Drawing.Point(6, 13);
            this.ckTestmode.Name = "ckTestmode";
            this.ckTestmode.Size = new System.Drawing.Size(73, 17);
            this.ckTestmode.TabIndex = 2;
            this.ckTestmode.Text = "Testmode";
            this.ckTestmode.UseVisualStyleBackColor = true;
            // 
            // hsImport
            // 
            this.hsImport.BackColor = System.Drawing.Color.Transparent;
            this.hsImport.BackColorHover = System.Drawing.Color.Transparent;
            this.hsImport.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsImport.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsImport.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsImport.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsImport.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsImport.FlatAppearance.BorderSize = 0;
            this.hsImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsImport.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsImport.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsImport.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsImport.ImageToggleOnSelect = true;
            this.hsImport.Location = new System.Drawing.Point(198, 0);
            this.hsImport.Marked = false;
            this.hsImport.MarkedColor = System.Drawing.Color.Teal;
            this.hsImport.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsImport.MarkedText = "";
            this.hsImport.MarkMode = false;
            this.hsImport.Name = "hsImport";
            this.hsImport.NonMarkedText = "";
            this.hsImport.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsImport.ShowShortcut = false;
            this.hsImport.Size = new System.Drawing.Size(87, 53);
            this.hsImport.TabIndex = 1;
            this.hsImport.Text = "Import";
            this.hsImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsImport.ToolTipActive = false;
            this.hsImport.ToolTipAutomaticDelay = 500;
            this.hsImport.ToolTipAutoPopDelay = 5000;
            this.hsImport.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsImport.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsImport.ToolTipFor4ContextMenu = true;
            this.hsImport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsImport.ToolTipInitialDelay = 500;
            this.hsImport.ToolTipIsBallon = false;
            this.hsImport.ToolTipOwnerDraw = false;
            this.hsImport.ToolTipReshowDelay = 100;
            this.hsImport.ToolTipShowAlways = false;
            this.hsImport.ToolTipText = "";
            this.hsImport.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsImport.ToolTipTitle = "";
            this.hsImport.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsImport.UseVisualStyleBackColor = false;
            this.hsImport.Click += new System.EventHandler(this.hsImport_Click);
            // 
            // hsSaveDefinitions
            // 
            this.hsSaveDefinitions.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveDefinitions.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveDefinitions.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveDefinitions.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveDefinitions.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveDefinitions.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveDefinitions.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveDefinitions.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveDefinitions.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveDefinitions.FlatAppearance.BorderSize = 0;
            this.hsSaveDefinitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveDefinitions.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveDefinitions.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hsSaveDefinitions.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hsSaveDefinitions.ImageToggleOnSelect = true;
            this.hsSaveDefinitions.Location = new System.Drawing.Point(99, 0);
            this.hsSaveDefinitions.Marked = false;
            this.hsSaveDefinitions.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveDefinitions.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveDefinitions.MarkedText = "";
            this.hsSaveDefinitions.MarkMode = false;
            this.hsSaveDefinitions.Name = "hsSaveDefinitions";
            this.hsSaveDefinitions.NonMarkedText = "";
            this.hsSaveDefinitions.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveDefinitions.ShowShortcut = false;
            this.hsSaveDefinitions.Size = new System.Drawing.Size(99, 53);
            this.hsSaveDefinitions.TabIndex = 4;
            this.hsSaveDefinitions.Text = "Save Definitions";
            this.hsSaveDefinitions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveDefinitions.ToolTipActive = false;
            this.hsSaveDefinitions.ToolTipAutomaticDelay = 500;
            this.hsSaveDefinitions.ToolTipAutoPopDelay = 5000;
            this.hsSaveDefinitions.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveDefinitions.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveDefinitions.ToolTipFor4ContextMenu = true;
            this.hsSaveDefinitions.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveDefinitions.ToolTipInitialDelay = 500;
            this.hsSaveDefinitions.ToolTipIsBallon = false;
            this.hsSaveDefinitions.ToolTipOwnerDraw = false;
            this.hsSaveDefinitions.ToolTipReshowDelay = 100;
            this.hsSaveDefinitions.ToolTipShowAlways = false;
            this.hsSaveDefinitions.ToolTipText = "";
            this.hsSaveDefinitions.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveDefinitions.ToolTipTitle = "";
            this.hsSaveDefinitions.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveDefinitions.UseVisualStyleBackColor = false;
            this.hsSaveDefinitions.Click += new System.EventHandler(this.hsSaveDefinition_Click);
            // 
            // hsLoadDefinition
            // 
            this.hsLoadDefinition.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadDefinition.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefinition.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefinition.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadDefinition.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadDefinition.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadDefinition.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadDefinition.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadDefinition.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadDefinition.FlatAppearance.BorderSize = 0;
            this.hsLoadDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadDefinition.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadDefinition.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadDefinition.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadDefinition.ImageToggleOnSelect = true;
            this.hsLoadDefinition.Location = new System.Drawing.Point(0, 0);
            this.hsLoadDefinition.Marked = false;
            this.hsLoadDefinition.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadDefinition.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadDefinition.MarkedText = "";
            this.hsLoadDefinition.MarkMode = false;
            this.hsLoadDefinition.Name = "hsLoadDefinition";
            this.hsLoadDefinition.NonMarkedText = "";
            this.hsLoadDefinition.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadDefinition.ShowShortcut = false;
            this.hsLoadDefinition.Size = new System.Drawing.Size(99, 53);
            this.hsLoadDefinition.TabIndex = 3;
            this.hsLoadDefinition.Text = "Load Definitions";
            this.hsLoadDefinition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadDefinition.ToolTipActive = false;
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
            this.hsLoadDefinition.ToolTipText = "";
            this.hsLoadDefinition.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadDefinition.ToolTipTitle = "";
            this.hsLoadDefinition.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadDefinition.UseVisualStyleBackColor = false;
            this.hsLoadDefinition.Click += new System.EventHandler(this.hsLoadDefinition_Click);
            // 
            // tabControlImport
            // 
            this.tabControlImport.Controls.Add(this.tabPageImportfile);
            this.tabControlImport.Controls.Add(this.tabPageTable);
            this.tabControlImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlImport.Location = new System.Drawing.Point(474, 16);
            this.tabControlImport.Name = "tabControlImport";
            this.tabControlImport.SelectedIndex = 0;
            this.tabControlImport.Size = new System.Drawing.Size(393, 583);
            this.tabControlImport.TabIndex = 19;
            // 
            // tabPageImportfile
            // 
            this.tabPageImportfile.Controls.Add(this.rtbSource);
            this.tabPageImportfile.Controls.Add(this.pnlUpperIports);
            this.tabPageImportfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageImportfile.Name = "tabPageImportfile";
            this.tabPageImportfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImportfile.Size = new System.Drawing.Size(385, 557);
            this.tabPageImportfile.TabIndex = 0;
            this.tabPageImportfile.Text = "Importfiles";
            this.tabPageImportfile.UseVisualStyleBackColor = true;
            // 
            // rtbSource
            // 
            this.rtbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSource.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSource.Location = new System.Drawing.Point(3, 56);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(379, 498);
            this.rtbSource.TabIndex = 6;
            this.rtbSource.Text = "";
            // 
            // pnlUpperIports
            // 
            this.pnlUpperIports.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlUpperIports.Controls.Add(this.groupBox1);
            this.pnlUpperIports.Controls.Add(this.hsImportCSV);
            this.pnlUpperIports.Controls.Add(this.hsImportXML);
            this.pnlUpperIports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperIports.Location = new System.Drawing.Point(3, 3);
            this.pnlUpperIports.Name = "pnlUpperIports";
            this.pnlUpperIports.Size = new System.Drawing.Size(379, 53);
            this.pnlUpperIports.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cbEncodingCSV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(188, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 53);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Encoding";
            // 
            // cbEncodingCSV
            // 
            this.cbEncodingCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEncodingCSV.FormattingEnabled = true;
            this.cbEncodingCSV.Items.AddRange(new object[] {
            "NONE",
            "UTF8",
            "ASCII",
            "ISO8859_1"});
            this.cbEncodingCSV.Location = new System.Drawing.Point(3, 16);
            this.cbEncodingCSV.Name = "cbEncodingCSV";
            this.cbEncodingCSV.Size = new System.Drawing.Size(127, 21);
            this.cbEncodingCSV.TabIndex = 34;
            this.cbEncodingCSV.Text = "UTF8";
            // 
            // hsImportCSV
            // 
            this.hsImportCSV.BackColor = System.Drawing.Color.Transparent;
            this.hsImportCSV.BackColorHover = System.Drawing.Color.Transparent;
            this.hsImportCSV.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsImportCSV.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsImportCSV.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsImportCSV.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsImportCSV.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsImportCSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsImportCSV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsImportCSV.FlatAppearance.BorderSize = 0;
            this.hsImportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsImportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsImportCSV.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsImportCSV.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsImportCSV.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsImportCSV.ImageToggleOnSelect = true;
            this.hsImportCSV.Location = new System.Drawing.Point(99, 0);
            this.hsImportCSV.Marked = false;
            this.hsImportCSV.MarkedColor = System.Drawing.Color.Teal;
            this.hsImportCSV.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsImportCSV.MarkedText = "";
            this.hsImportCSV.MarkMode = false;
            this.hsImportCSV.Name = "hsImportCSV";
            this.hsImportCSV.NonMarkedText = "";
            this.hsImportCSV.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsImportCSV.ShowShortcut = false;
            this.hsImportCSV.Size = new System.Drawing.Size(89, 53);
            this.hsImportCSV.TabIndex = 2;
            this.hsImportCSV.Text = "Import CSV";
            this.hsImportCSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsImportCSV.ToolTipActive = false;
            this.hsImportCSV.ToolTipAutomaticDelay = 500;
            this.hsImportCSV.ToolTipAutoPopDelay = 5000;
            this.hsImportCSV.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsImportCSV.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsImportCSV.ToolTipFor4ContextMenu = true;
            this.hsImportCSV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsImportCSV.ToolTipInitialDelay = 500;
            this.hsImportCSV.ToolTipIsBallon = false;
            this.hsImportCSV.ToolTipOwnerDraw = false;
            this.hsImportCSV.ToolTipReshowDelay = 100;
            this.hsImportCSV.ToolTipShowAlways = false;
            this.hsImportCSV.ToolTipText = "";
            this.hsImportCSV.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsImportCSV.ToolTipTitle = "";
            this.hsImportCSV.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsImportCSV.UseVisualStyleBackColor = false;
            this.hsImportCSV.Click += new System.EventHandler(this.hsImportCSV_Click);
            // 
            // hsImportXML
            // 
            this.hsImportXML.BackColor = System.Drawing.Color.Transparent;
            this.hsImportXML.BackColorHover = System.Drawing.Color.Transparent;
            this.hsImportXML.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsImportXML.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsImportXML.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsImportXML.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsImportXML.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsImportXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsImportXML.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsImportXML.FlatAppearance.BorderSize = 0;
            this.hsImportXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsImportXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsImportXML.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsImportXML.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsImportXML.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsImportXML.ImageToggleOnSelect = true;
            this.hsImportXML.Location = new System.Drawing.Point(0, 0);
            this.hsImportXML.Marked = false;
            this.hsImportXML.MarkedColor = System.Drawing.Color.Teal;
            this.hsImportXML.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsImportXML.MarkedText = "";
            this.hsImportXML.MarkMode = false;
            this.hsImportXML.Name = "hsImportXML";
            this.hsImportXML.NonMarkedText = "";
            this.hsImportXML.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsImportXML.ShowShortcut = false;
            this.hsImportXML.Size = new System.Drawing.Size(99, 53);
            this.hsImportXML.TabIndex = 1;
            this.hsImportXML.Text = "Import XML";
            this.hsImportXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsImportXML.ToolTipActive = false;
            this.hsImportXML.ToolTipAutomaticDelay = 500;
            this.hsImportXML.ToolTipAutoPopDelay = 5000;
            this.hsImportXML.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsImportXML.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsImportXML.ToolTipFor4ContextMenu = true;
            this.hsImportXML.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsImportXML.ToolTipInitialDelay = 500;
            this.hsImportXML.ToolTipIsBallon = false;
            this.hsImportXML.ToolTipOwnerDraw = false;
            this.hsImportXML.ToolTipReshowDelay = 100;
            this.hsImportXML.ToolTipShowAlways = false;
            this.hsImportXML.ToolTipText = "";
            this.hsImportXML.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsImportXML.ToolTipTitle = "";
            this.hsImportXML.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsImportXML.UseVisualStyleBackColor = false;
            this.hsImportXML.Click += new System.EventHandler(this.hsImportXML_Click);
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.dataGridView1);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(385, 557);
            this.tabPageTable.TabIndex = 1;
            this.tabPageTable.Text = "Table";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataMember = "Table";
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // ofdSQL
            // 
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IMPORTDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 662);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IMPORTDataForm";
            this.Text = "IMPORTDataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IMPORTDataForm_FormClosing);
            this.Load += new System.EventHandler(this.IMPORTDataForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTableImports.ResumeLayout(false);
            this.gbTableFields.ResumeLayout(false);
            this.pnlTableFieldsUpper.ResumeLayout(false);
            this.gbTablesDataExport.ResumeLayout(false);
            this.pnlTableUpper.ResumeLayout(false);
            this.cmsColDefData.ResumeLayout(false);
            this.cmsMessagesText.ResumeLayout(false);
            this.cmdDATA.ResumeLayout(false);
            this.cmsDDLText.ResumeLayout(false);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.gbFileExport.ResumeLayout(false);
            this.gbImport.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbColDef.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQLAll.ResumeLayout(false);
            this.tabPageSQLAll.PerformLayout();
            this.pnlSQLAllUpper.ResumeLayout(false);
            this.gbEncoding.ResumeLayout(false);
            this.tabPageSQLdone.ResumeLayout(false);
            this.tabPageSQLdone.PerformLayout();
            this.tabPageSQLfail.ResumeLayout(false);
            this.tabPageSQLfail.PerformLayout();
            this.gbProcessBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbSQLMode.ResumeLayout(false);
            this.gbSQLMode.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.tabControlImport.ResumeLayout(false);
            this.tabPageImportfile.ResumeLayout(false);
            this.pnlUpperIports.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTableImports;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.Label lblTableName;
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
        private System.Windows.Forms.ContextMenuStrip cmsColDefData;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXPORTDataCopyToCLipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXPORTDataPasteFromClipboard;
        private System.Windows.Forms.GroupBox gbTablesDataExport;
        private System.Windows.Forms.Panel pnlTableUpper;
        private SeControlsLib.HotSpot hsUncheckAlltables;
        private SeControlsLib.HotSpot hsCheckAllTables;
        private System.Windows.Forms.GroupBox gbFileExport;
       
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbTableFields;
        private SEListBox.SEListBox selFields;
        private System.Windows.Forms.Panel pnlTableFieldsUpper;
        private SeControlsLib.HotSpot hsUncheckAllTableFields;
        private SeControlsLib.HotSpot hsCheckAllTableFields;
        private SEListBox.SEListBox selTables;
        private System.Windows.Forms.GroupBox gbImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSQLdone;
        private System.Windows.Forms.CheckBox ckTestmode;
        private System.Windows.Forms.Panel pnlUpperIports;
        private SeControlsLib.HotSpot hsImportXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtbSource;
        private SeControlsLib.HotSpot hsImportCSV;
        private SeControlsLib.HotSpot hsLoadDefinition;
        private System.Windows.Forms.RichTextBox rtbColDef;
        private SeControlsLib.HotSpot hsSaveDefinitions;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.GroupBox gbSQLMode;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.GroupBox gbProcessBar;
        private System.Windows.Forms.ProgressBar pbSQL;
        private System.Windows.Forms.GroupBox gbColDef;
        private SeControlsLib.HotSpot hsCalcel;
        private SeControlsLib.HotSpot hsImport;
        private SeControlsLib.HotSpot hsDoSQL;
        private System.Windows.Forms.TabControl tabControlImport;
        private System.Windows.Forms.TabPage tabPageImportfile;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSQLdone;
        private System.Windows.Forms.TabPage tabPageSQLfail;
        private System.Windows.Forms.TextBox txtSQLfail;
        private System.Windows.Forms.TabPage tabPageSQLAll;
        private System.Windows.Forms.TextBox txtSQLAll;
        private System.Windows.Forms.CheckBox ckEmptyLists;
        private System.Windows.Forms.GroupBox gbEncoding;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateTimeNow;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateTimeToday;
        private System.Windows.Forms.ToolStripMenuItem tsmiINT;
        private System.Windows.Forms.ToolStripMenuItem tsmiDOUBLE;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlSQLAllUpper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEncodingCSV;
    }
}