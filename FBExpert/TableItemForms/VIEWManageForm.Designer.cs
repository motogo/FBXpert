using BasicForms;

namespace FBExpert
{
    partial class VIEWManageForm : BasicNormalFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEWManageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlViews = new System.Windows.Forms.TabControl();
            this.tabPageFIELDS = new System.Windows.Forms.TabPage();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.cmsUpdateInsertText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdateInsertCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateInsertPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDATA = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cmdDATA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSpaltenEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.bsViewContent = new System.Windows.Forms.BindingSource(this.components);
            this.dsViewContent = new System.Data.DataSet();
            this.Table = new System.Data.DataTable();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.pnlDataUpper = new System.Windows.Forms.Panel();
            this.gbBnView = new System.Windows.Forms.GroupBox();
            this.bnView = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbCAuto = new System.Windows.Forms.CheckBox();
            this.sfbViewData = new SeControlsLib.SpezialfilterBox();
            this.hsCancelGettingData = new SeControlsLib.HotSpot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDDL = new System.Windows.Forms.TabPage();
            this.pnlDDL_CENTER = new System.Windows.Forms.Panel();
            this.fctDLL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsDDLText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDDLCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDDLPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDDL_UPPER = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.tabUpdateInsert = new System.Windows.Forms.TabPage();
            this.fctCREATEINSERTSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlUpdateInsertSQLUpper = new System.Windows.Forms.Panel();
            this.cbPretty = new System.Windows.Forms.CheckBox();
            this.cbAlterView = new System.Windows.Forms.CheckBox();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsRunStatement = new SeControlsLib.HotSpot();
            this.tabPageDependenciesTo = new System.Windows.Forms.TabPage();
            this.dgvDependencies = new System.Windows.Forms.DataGridView();
            this.bsDependencies = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependencies = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.pnlUpperDependenciesTo = new System.Windows.Forms.Panel();
            this.hsRefreshDependenciesTo = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.pnlMessagesCenter = new System.Windows.Forms.Panel();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsMessagesText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMessageCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMessagePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.fcbExport = new FastColoredTextBoxNS.FastColoredTextBox();
            this.dgExportGrid = new System.Windows.Forms.DataGridView();
            this.colPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExportFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExportActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colExportWhere = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.pnlExportDataUpper = new System.Windows.Forms.Panel();
            this.gbExportFile = new System.Windows.Forms.GroupBox();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.cbExportToFile = new System.Windows.Forms.CheckBox();
            this.cbExportToScreen = new System.Windows.Forms.CheckBox();
            this.gbInsertUpdate = new System.Windows.Forms.GroupBox();
            this.rbUPDATE = new System.Windows.Forms.RadioButton();
            this.rbINSERTUPDATE = new System.Windows.Forms.RadioButton();
            this.rbINSERT = new System.Windows.Forms.RadioButton();
            this.hsCancelExport = new SeControlsLib.HotSpot();
            this.hsExportData = new SeControlsLib.HotSpot();
            this.hsRefreshExportData = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.ckGetDatas = new System.Windows.Forms.CheckBox();
            this.gnUsedTime = new System.Windows.Forms.GroupBox();
            this.txtUsedTime = new System.Windows.Forms.TextBox();
            this.gbMaxAllowedErrors = new System.Windows.Forms.GroupBox();
            this.txtMaxAllowedErrors = new System.Windows.Forms.TextBox();
            this.gbMaxRows = new System.Windows.Forms.GroupBox();
            this.rbSQLDesc = new System.Windows.Forms.RadioButton();
            this.rbSQLAsc = new System.Windows.Forms.RadioButton();
            this.txtMaxRows = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsPageRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.bwExport = new System.ComponentModel.BackgroundWorker();
            this.tabControlViews.SuspendLayout();
            this.tabPageFIELDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            this.cmsUpdateInsertText.SuspendLayout();
            this.tabPageDATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.cmdDATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsViewContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.gbSQL.SuspendLayout();
            this.pnlDataUpper.SuspendLayout();
            this.gbBnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnView)).BeginInit();
            this.bnView.SuspendLayout();
            this.tabDDL.SuspendLayout();
            this.pnlDDL_CENTER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctDLL)).BeginInit();
            this.cmsDDLText.SuspendLayout();
            this.pnlDDL_UPPER.SuspendLayout();
            this.tabUpdateInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctCREATEINSERTSQL)).BeginInit();
            this.pnlUpdateInsertSQLUpper.SuspendLayout();
            this.tabPageDependenciesTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.pnlUpperDependenciesTo.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.pnlMessagesCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.cmsMessagesText.SuspendLayout();
            this.pnlMessagesUpper.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExportGrid)).BeginInit();
            this.pnlExportDataUpper.SuspendLayout();
            this.gbExportFile.SuspendLayout();
            this.gbInsertUpdate.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.gnUsedTime.SuspendLayout();
            this.gbMaxAllowedErrors.SuspendLayout();
            this.gbMaxRows.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlViews
            // 
            this.tabControlViews.Controls.Add(this.tabPageFIELDS);
            this.tabControlViews.Controls.Add(this.tabPageDATA);
            this.tabControlViews.Controls.Add(this.tabDDL);
            this.tabControlViews.Controls.Add(this.tabUpdateInsert);
            this.tabControlViews.Controls.Add(this.tabPageDependenciesTo);
            this.tabControlViews.Controls.Add(this.tabPageMessages);
            this.tabControlViews.Controls.Add(this.tabPageExport);
            this.tabControlViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlViews.ImageList = this.ilTabControl;
            this.tabControlViews.Location = new System.Drawing.Point(0, 0);
            this.tabControlViews.Name = "tabControlViews";
            this.tabControlViews.SelectedIndex = 0;
            this.tabControlViews.Size = new System.Drawing.Size(1275, 558);
            this.tabControlViews.TabIndex = 0;
            this.tabControlViews.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlViews.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageFIELDS
            // 
            this.tabPageFIELDS.Controls.Add(this.fastObjectListView1);
            this.tabPageFIELDS.ImageIndex = 8;
            this.tabPageFIELDS.Location = new System.Drawing.Point(4, 23);
            this.tabPageFIELDS.Name = "tabPageFIELDS";
            this.tabPageFIELDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFIELDS.Size = new System.Drawing.Size(1267, 531);
            this.tabPageFIELDS.TabIndex = 0;
            this.tabPageFIELDS.Text = "Fields";
            this.tabPageFIELDS.UseVisualStyleBackColor = true;
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllowColumnReorder = true;
            this.fastObjectListView1.AlternateRowBackColor = System.Drawing.Color.LightGray;
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListView1.FullRowSelect = true;
            this.fastObjectListView1.GridLines = true;
            this.fastObjectListView1.HeaderWordWrap = true;
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Location = new System.Drawing.Point(3, 3);
            this.fastObjectListView1.MultiSelect = false;
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.PersistentCheckBoxes = false;
            this.fastObjectListView1.SelectAllOnControlA = false;
            this.fastObjectListView1.SelectColumnsMenuStaysOpen = false;
            this.fastObjectListView1.SelectColumnsOnRightClick = false;
            this.fastObjectListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.fastObjectListView1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fastObjectListView1.SelectedForeColor = System.Drawing.SystemColors.Info;
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(1261, 525);
            this.fastObjectListView1.TabIndex = 1;
            this.fastObjectListView1.UseAlternatingBackColors = true;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.UseHotControls = false;
            this.fastObjectListView1.UseOverlays = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            // 
            // cmsUpdateInsertText
            // 
            this.cmsUpdateInsertText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateInsertCopyToClipboard,
            this.tsmiUpdateInsertPaste});
            this.cmsUpdateInsertText.Name = "cmsText";
            this.cmsUpdateInsertText.Size = new System.Drawing.Size(172, 48);
            this.cmsUpdateInsertText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsText_ItemClicked);
            // 
            // tsmiUpdateInsertCopyToClipboard
            // 
            this.tsmiUpdateInsertCopyToClipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiUpdateInsertCopyToClipboard.Name = "tsmiUpdateInsertCopyToClipboard";
            this.tsmiUpdateInsertCopyToClipboard.Size = new System.Drawing.Size(171, 22);
            this.tsmiUpdateInsertCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiUpdateInsertPaste
            // 
            this.tsmiUpdateInsertPaste.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiUpdateInsertPaste.Name = "tsmiUpdateInsertPaste";
            this.tsmiUpdateInsertPaste.Size = new System.Drawing.Size(171, 22);
            this.tsmiUpdateInsertPaste.Text = "Paste";
            // 
            // tabPageDATA
            // 
            this.tabPageDATA.Controls.Add(this.dgvResults);
            this.tabPageDATA.Controls.Add(this.gbSQL);
            this.tabPageDATA.Controls.Add(this.pnlDataUpper);
            this.tabPageDATA.Controls.Add(this.panel1);
            this.tabPageDATA.ImageIndex = 6;
            this.tabPageDATA.Location = new System.Drawing.Point(4, 23);
            this.tabPageDATA.Name = "tabPageDATA";
            this.tabPageDATA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDATA.Size = new System.Drawing.Size(1267, 531);
            this.tabPageDATA.TabIndex = 1;
            this.tabPageDATA.Text = "Data";
            this.tabPageDATA.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ContextMenuStrip = this.cmdDATA;
            this.dgvResults.DataSource = this.bsViewContent;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Location = new System.Drawing.Point(3, 89);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1261, 439);
            this.dgvResults.TabIndex = 17;
            this.dgvResults.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // cmdDATA
            // 
            this.cmdDATA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmdDATA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpaltenEdit});
            this.cmdDATA.Name = "cmsText";
            this.cmdDATA.Size = new System.Drawing.Size(156, 30);
            this.cmdDATA.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdDATA_ItemClicked);
            // 
            // tsmiSpaltenEdit
            // 
            this.tsmiSpaltenEdit.Image = global::FBXpert.Properties.Resources.Table_x24;
            this.tsmiSpaltenEdit.Name = "tsmiSpaltenEdit";
            this.tsmiSpaltenEdit.Size = new System.Drawing.Size(155, 26);
            this.tsmiSpaltenEdit.Text = "Spaltendeditor";
            // 
            // bsViewContent
            // 
            this.bsViewContent.DataSource = this.dsViewContent;
            this.bsViewContent.Position = 0;
            // 
            // dsViewContent
            // 
            this.dsViewContent.DataSetName = "NewDataSet";
            this.dsViewContent.Tables.AddRange(new System.Data.DataTable[] {
            this.Table});
            // 
            // Table
            // 
            this.Table.TableName = "Table";
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.txtSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSQL.Location = new System.Drawing.Point(3, 43);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(1261, 46);
            this.gbSQL.TabIndex = 21;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "Select command";
            // 
            // txtSQL
            // 
            this.txtSQL.BackColor = System.Drawing.SystemColors.Info;
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(3, 16);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(1255, 20);
            this.txtSQL.TabIndex = 0;
            // 
            // pnlDataUpper
            // 
            this.pnlDataUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDataUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDataUpper.Controls.Add(this.gbBnView);
            this.pnlDataUpper.Controls.Add(this.cbCAuto);
            this.pnlDataUpper.Controls.Add(this.sfbViewData);
            this.pnlDataUpper.Controls.Add(this.hsCancelGettingData);
            this.pnlDataUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDataUpper.Name = "pnlDataUpper";
            this.pnlDataUpper.Size = new System.Drawing.Size(1261, 40);
            this.pnlDataUpper.TabIndex = 18;
            // 
            // gbBnView
            // 
            this.gbBnView.Controls.Add(this.bnView);
            this.gbBnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBnView.Location = new System.Drawing.Point(351, 0);
            this.gbBnView.Name = "gbBnView";
            this.gbBnView.Size = new System.Drawing.Size(256, 36);
            this.gbBnView.TabIndex = 30;
            this.gbBnView.TabStop = false;
            // 
            // bnView
            // 
            this.bnView.AddNewItem = null;
            this.bnView.AutoSize = false;
            this.bnView.BindingSource = this.bsViewContent;
            this.bnView.CountItem = this.bindingNavigatorCountItem;
            this.bnView.DeleteItem = null;
            this.bnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnView.Location = new System.Drawing.Point(3, 16);
            this.bnView.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnView.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnView.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnView.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnView.Name = "bnView";
            this.bnView.PositionItem = this.bindingNavigatorPositionItem;
            this.bnView.Size = new System.Drawing.Size(250, 17);
            this.bnView.TabIndex = 0;
            this.bnView.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 14);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 14);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 14);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 17);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "1";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 17);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 14);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 14);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 17);
            // 
            // cbCAuto
            // 
            this.cbCAuto.AutoSize = true;
            this.cbCAuto.Checked = true;
            this.cbCAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCAuto.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCAuto.Location = new System.Drawing.Point(1154, 0);
            this.cbCAuto.Name = "cbCAuto";
            this.cbCAuto.Size = new System.Drawing.Size(103, 36);
            this.cbCAuto.TabIndex = 29;
            this.cbCAuto.Text = "Columnsize auto";
            this.cbCAuto.UseVisualStyleBackColor = true;
            this.cbCAuto.CheckedChanged += new System.EventHandler(this.cbCAuto_CheckedChanged);
            // 
            // sfbViewData
            // 
            this.sfbViewData.AutocompleteList = new string[0];
            this.sfbViewData.Caption = "Spezialfilter";
            this.sfbViewData.cbChecked = false;
            this.sfbViewData.ClearFilterCaption = "Clear Filter";
            this.sfbViewData.dcFilter = null;
            this.sfbViewData.dcOuterFilter = null;
            this.sfbViewData.Dock = System.Windows.Forms.DockStyle.Left;
            this.sfbViewData.EditCaption = "Edit filter";
            this.sfbViewData.EnableEdit = true;
            this.sfbViewData.FilterText = "";
            this.sfbViewData.LoadCaption = "Load filter";
            this.sfbViewData.Location = new System.Drawing.Point(115, 0);
            this.sfbViewData.Name = "sfbViewData";
            this.sfbViewData.PasteCaption = "Paste filter from clipboard";
            this.sfbViewData.Pattern = "";
            this.sfbViewData.SaveFilterCaption = "Save Filter";
            this.sfbViewData.SearchMode = SeControlsLib.eSearchMode.NotCaseSensitive;
            this.sfbViewData.ShowCheckbox = false;
            this.sfbViewData.Size = new System.Drawing.Size(236, 36);
            this.sfbViewData.SQLKonjunktion = "WHERE";
            this.sfbViewData.SQLVorfilterCmd = "";
            this.sfbViewData.TabIndex = 6;
            this.sfbViewData.UseAutocomplete = false;
            this.sfbViewData.UseTranslation = false;
            this.sfbViewData.CheckedChanged += new SeControlsLib.CheckedChangedHandler(this.spezialfilterBox1_CheckedChanged);
            // 
            // hsCancelGettingData
            // 
            this.hsCancelGettingData.BackColor = System.Drawing.Color.Transparent;
            this.hsCancelGettingData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCancelGettingData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCancelGettingData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCancelGettingData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCancelGettingData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCancelGettingData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCancelGettingData.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCancelGettingData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCancelGettingData.FlatAppearance.BorderSize = 0;
            this.hsCancelGettingData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCancelGettingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCancelGettingData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancelGettingData.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsCancelGettingData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCancelGettingData.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsCancelGettingData.ImageToggleOnSelect = false;
            this.hsCancelGettingData.Location = new System.Drawing.Point(0, 0);
            this.hsCancelGettingData.Marked = false;
            this.hsCancelGettingData.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancelGettingData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancelGettingData.MarkedText = "";
            this.hsCancelGettingData.MarkMode = false;
            this.hsCancelGettingData.Name = "hsCancelGettingData";
            this.hsCancelGettingData.NonMarkedText = "Cancel reading";
            this.hsCancelGettingData.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCancelGettingData.ShowShortcut = false;
            this.hsCancelGettingData.Size = new System.Drawing.Size(115, 36);
            this.hsCancelGettingData.TabIndex = 7;
            this.hsCancelGettingData.Text = "Cancel reading";
            this.hsCancelGettingData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCancelGettingData.ToolTipActive = false;
            this.hsCancelGettingData.ToolTipAutomaticDelay = 500;
            this.hsCancelGettingData.ToolTipAutoPopDelay = 5000;
            this.hsCancelGettingData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCancelGettingData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCancelGettingData.ToolTipFor4ContextMenu = true;
            this.hsCancelGettingData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCancelGettingData.ToolTipInitialDelay = 500;
            this.hsCancelGettingData.ToolTipIsBallon = false;
            this.hsCancelGettingData.ToolTipOwnerDraw = false;
            this.hsCancelGettingData.ToolTipReshowDelay = 100;
            this.hsCancelGettingData.ToolTipShowAlways = false;
            this.hsCancelGettingData.ToolTipText = "";
            this.hsCancelGettingData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCancelGettingData.ToolTipTitle = "";
            this.hsCancelGettingData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCancelGettingData.UseVisualStyleBackColor = false;
            this.hsCancelGettingData.Click += new System.EventHandler(this.hsCancelGettingData_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FBXpert.Properties.Resources.waiting2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(474, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 220);
            this.panel1.TabIndex = 20;
            // 
            // tabDDL
            // 
            this.tabDDL.Controls.Add(this.pnlDDL_CENTER);
            this.tabDDL.Controls.Add(this.pnlDDL_UPPER);
            this.tabDDL.ImageIndex = 5;
            this.tabDDL.Location = new System.Drawing.Point(4, 23);
            this.tabDDL.Name = "tabDDL";
            this.tabDDL.Padding = new System.Windows.Forms.Padding(3);
            this.tabDDL.Size = new System.Drawing.Size(1267, 531);
            this.tabDDL.TabIndex = 2;
            this.tabDDL.Text = "DDL";
            this.tabDDL.UseVisualStyleBackColor = true;
            // 
            // pnlDDL_CENTER
            // 
            this.pnlDDL_CENTER.Controls.Add(this.fctDLL);
            this.pnlDDL_CENTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDDL_CENTER.Location = new System.Drawing.Point(3, 50);
            this.pnlDDL_CENTER.Name = "pnlDDL_CENTER";
            this.pnlDDL_CENTER.Size = new System.Drawing.Size(1261, 478);
            this.pnlDDL_CENTER.TabIndex = 1;
            // 
            // fctDLL
            // 
            this.fctDLL.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctDLL.AutoIndentCharsPatterns = "";
            this.fctDLL.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctDLL.BackBrush = null;
            this.fctDLL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctDLL.CharHeight = 14;
            this.fctDLL.CharWidth = 8;
            this.fctDLL.CommentPrefix = "--";
            this.fctDLL.ContextMenuStrip = this.cmsDDLText;
            this.fctDLL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctDLL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctDLL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctDLL.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctDLL.IsReplaceMode = false;
            this.fctDLL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctDLL.LeftBracket = '(';
            this.fctDLL.Location = new System.Drawing.Point(0, 0);
            this.fctDLL.Name = "fctDLL";
            this.fctDLL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctDLL.RightBracket = ')';
            this.fctDLL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctDLL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctDLL.ServiceColors")));
            this.fctDLL.Size = new System.Drawing.Size(1261, 478);
            this.fctDLL.TabIndex = 1;
            this.fctDLL.WordWrap = true;
            this.fctDLL.Zoom = 100;
            // 
            // cmsDDLText
            // 
            this.cmsDDLText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDDLCopyToClipboard,
            this.tsmiDDLPaste});
            this.cmsDDLText.Name = "cmsText";
            this.cmsDDLText.Size = new System.Drawing.Size(172, 48);
            this.cmsDDLText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsText_ItemClicked);
            // 
            // tsmiDDLCopyToClipboard
            // 
            this.tsmiDDLCopyToClipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiDDLCopyToClipboard.Name = "tsmiDDLCopyToClipboard";
            this.tsmiDDLCopyToClipboard.Size = new System.Drawing.Size(171, 22);
            this.tsmiDDLCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiDDLPaste
            // 
            this.tsmiDDLPaste.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiDDLPaste.Name = "tsmiDDLPaste";
            this.tsmiDDLPaste.Size = new System.Drawing.Size(171, 22);
            this.tsmiDDLPaste.Text = "Paste";
            // 
            // pnlDDL_UPPER
            // 
            this.pnlDDL_UPPER.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDDL_UPPER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDDL_UPPER.Controls.Add(this.hotSpot1);
            this.pnlDDL_UPPER.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDDL_UPPER.Location = new System.Drawing.Point(3, 3);
            this.pnlDDL_UPPER.Name = "pnlDDL_UPPER";
            this.pnlDDL_UPPER.Size = new System.Drawing.Size(1261, 47);
            this.pnlDDL_UPPER.TabIndex = 0;
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
            this.hotSpot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(0, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Clear";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(45, 43);
            this.hotSpot1.TabIndex = 2;
            this.hotSpot1.Text = "Clear";
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
            // tabUpdateInsert
            // 
            this.tabUpdateInsert.Controls.Add(this.fctCREATEINSERTSQL);
            this.tabUpdateInsert.Controls.Add(this.pnlUpdateInsertSQLUpper);
            this.tabUpdateInsert.ImageIndex = 5;
            this.tabUpdateInsert.Location = new System.Drawing.Point(4, 23);
            this.tabUpdateInsert.Name = "tabUpdateInsert";
            this.tabUpdateInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateInsert.Size = new System.Drawing.Size(1267, 531);
            this.tabUpdateInsert.TabIndex = 3;
            this.tabUpdateInsert.Text = "CREATE/ALTER";
            this.tabUpdateInsert.UseVisualStyleBackColor = true;
            // 
            // fctCREATEINSERTSQL
            // 
            this.fctCREATEINSERTSQL.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctCREATEINSERTSQL.AutoIndentCharsPatterns = "";
            this.fctCREATEINSERTSQL.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctCREATEINSERTSQL.BackBrush = null;
            this.fctCREATEINSERTSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctCREATEINSERTSQL.CharHeight = 14;
            this.fctCREATEINSERTSQL.CharWidth = 8;
            this.fctCREATEINSERTSQL.CommentPrefix = "--";
            this.fctCREATEINSERTSQL.ContextMenuStrip = this.cmsUpdateInsertText;
            this.fctCREATEINSERTSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctCREATEINSERTSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctCREATEINSERTSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctCREATEINSERTSQL.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctCREATEINSERTSQL.IsReplaceMode = false;
            this.fctCREATEINSERTSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctCREATEINSERTSQL.LeftBracket = '(';
            this.fctCREATEINSERTSQL.Location = new System.Drawing.Point(3, 48);
            this.fctCREATEINSERTSQL.Name = "fctCREATEINSERTSQL";
            this.fctCREATEINSERTSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctCREATEINSERTSQL.RightBracket = ')';
            this.fctCREATEINSERTSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctCREATEINSERTSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctCREATEINSERTSQL.ServiceColors")));
            this.fctCREATEINSERTSQL.Size = new System.Drawing.Size(1261, 480);
            this.fctCREATEINSERTSQL.TabIndex = 3;
            this.fctCREATEINSERTSQL.WordWrap = true;
            this.fctCREATEINSERTSQL.Zoom = 100;
            this.fctCREATEINSERTSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctCREATEINSERTSQL_KeyDown);
            // 
            // pnlUpdateInsertSQLUpper
            // 
            this.pnlUpdateInsertSQLUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpdateInsertSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpdateInsertSQLUpper.Controls.Add(this.cbPretty);
            this.pnlUpdateInsertSQLUpper.Controls.Add(this.cbAlterView);
            this.pnlUpdateInsertSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlUpdateInsertSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlUpdateInsertSQLUpper.Controls.Add(this.hsRunStatement);
            this.pnlUpdateInsertSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpdateInsertSQLUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlUpdateInsertSQLUpper.Name = "pnlUpdateInsertSQLUpper";
            this.pnlUpdateInsertSQLUpper.Size = new System.Drawing.Size(1261, 45);
            this.pnlUpdateInsertSQLUpper.TabIndex = 2;
            // 
            // cbPretty
            // 
            this.cbPretty.AutoSize = true;
            this.cbPretty.Checked = true;
            this.cbPretty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPretty.Location = new System.Drawing.Point(440, 22);
            this.cbPretty.Name = "cbPretty";
            this.cbPretty.Size = new System.Drawing.Size(53, 17);
            this.cbPretty.TabIndex = 7;
            this.cbPretty.Text = "Pretty";
            this.cbPretty.UseVisualStyleBackColor = true;
            this.cbPretty.CheckedChanged += new System.EventHandler(this.cbPretty_CheckedChanged);
            // 
            // cbAlterView
            // 
            this.cbAlterView.AutoSize = true;
            this.cbAlterView.Checked = true;
            this.cbAlterView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlterView.Location = new System.Drawing.Point(342, 21);
            this.cbAlterView.Name = "cbAlterView";
            this.cbAlterView.Size = new System.Drawing.Size(73, 17);
            this.cbAlterView.TabIndex = 6;
            this.cbAlterView.Text = "Alter View";
            this.cbAlterView.UseVisualStyleBackColor = true;
            this.cbAlterView.CheckedChanged += new System.EventHandler(this.cbAlterView_CheckedChanged);
            // 
            // hsLoadSQL
            // 
            this.hsLoadSQL.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadSQL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadSQL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadSQL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadSQL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadSQL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadSQL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadSQL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadSQL.FlatAppearance.BorderSize = 0;
            this.hsLoadSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQL.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(212, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadSQL.ShowShortcut = false;
            this.hsLoadSQL.Size = new System.Drawing.Size(112, 41);
            this.hsLoadSQL.TabIndex = 5;
            this.hsLoadSQL.Text = "Load SQL";
            this.hsLoadSQL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadSQL.ToolTipActive = false;
            this.hsLoadSQL.ToolTipAutomaticDelay = 500;
            this.hsLoadSQL.ToolTipAutoPopDelay = 5000;
            this.hsLoadSQL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadSQL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadSQL.ToolTipFor4ContextMenu = true;
            this.hsLoadSQL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadSQL.ToolTipInitialDelay = 500;
            this.hsLoadSQL.ToolTipIsBallon = false;
            this.hsLoadSQL.ToolTipOwnerDraw = false;
            this.hsLoadSQL.ToolTipReshowDelay = 100;
            this.hsLoadSQL.ToolTipShowAlways = false;
            this.hsLoadSQL.ToolTipText = "";
            this.hsLoadSQL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadSQL.ToolTipTitle = "";
            this.hsLoadSQL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadSQL.UseVisualStyleBackColor = false;
            this.hsLoadSQL.Click += new System.EventHandler(this.hsLoadSQL_Click);
            // 
            // hsSaveSQL
            // 
            this.hsSaveSQL.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveSQL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveSQL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveSQL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveSQL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveSQL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveSQL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveSQL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveSQL.FlatAppearance.BorderSize = 0;
            this.hsSaveSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveSQL.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSaveSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveSQL.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSaveSQL.ImageToggleOnSelect = true;
            this.hsSaveSQL.Location = new System.Drawing.Point(90, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveSQL.ShowShortcut = false;
            this.hsSaveSQL.Size = new System.Drawing.Size(122, 41);
            this.hsSaveSQL.TabIndex = 3;
            this.hsSaveSQL.Text = "Save SQL";
            this.hsSaveSQL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveSQL.ToolTipActive = false;
            this.hsSaveSQL.ToolTipAutomaticDelay = 500;
            this.hsSaveSQL.ToolTipAutoPopDelay = 5000;
            this.hsSaveSQL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveSQL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveSQL.ToolTipFor4ContextMenu = true;
            this.hsSaveSQL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveSQL.ToolTipInitialDelay = 500;
            this.hsSaveSQL.ToolTipIsBallon = false;
            this.hsSaveSQL.ToolTipOwnerDraw = false;
            this.hsSaveSQL.ToolTipReshowDelay = 100;
            this.hsSaveSQL.ToolTipShowAlways = false;
            this.hsSaveSQL.ToolTipText = "";
            this.hsSaveSQL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveSQL.ToolTipTitle = "";
            this.hsSaveSQL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveSQL.UseVisualStyleBackColor = false;
            this.hsSaveSQL.Click += new System.EventHandler(this.hsSave_Click);
            // 
            // hsRunStatement
            // 
            this.hsRunStatement.BackColor = System.Drawing.Color.Transparent;
            this.hsRunStatement.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunStatement.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunStatement.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunStatement.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunStatement.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunStatement.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunStatement.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRunStatement.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunStatement.FlatAppearance.BorderSize = 0;
            this.hsRunStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRunStatement.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunStatement.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsRunStatement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunStatement.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsRunStatement.ImageToggleOnSelect = true;
            this.hsRunStatement.Location = new System.Drawing.Point(0, 0);
            this.hsRunStatement.Marked = false;
            this.hsRunStatement.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunStatement.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunStatement.MarkedText = "";
            this.hsRunStatement.MarkMode = false;
            this.hsRunStatement.Name = "hsRunStatement";
            this.hsRunStatement.NonMarkedText = "Execute";
            this.hsRunStatement.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRunStatement.ShowShortcut = false;
            this.hsRunStatement.Size = new System.Drawing.Size(90, 41);
            this.hsRunStatement.TabIndex = 2;
            this.hsRunStatement.Text = "Execute";
            this.hsRunStatement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunStatement.ToolTipActive = false;
            this.hsRunStatement.ToolTipAutomaticDelay = 500;
            this.hsRunStatement.ToolTipAutoPopDelay = 5000;
            this.hsRunStatement.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunStatement.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunStatement.ToolTipFor4ContextMenu = true;
            this.hsRunStatement.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunStatement.ToolTipInitialDelay = 500;
            this.hsRunStatement.ToolTipIsBallon = false;
            this.hsRunStatement.ToolTipOwnerDraw = false;
            this.hsRunStatement.ToolTipReshowDelay = 100;
            this.hsRunStatement.ToolTipShowAlways = false;
            this.hsRunStatement.ToolTipText = "";
            this.hsRunStatement.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunStatement.ToolTipTitle = "";
            this.hsRunStatement.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunStatement.UseVisualStyleBackColor = false;
            this.hsRunStatement.Click += new System.EventHandler(this.hsRunStatement_ClickAsync);
            // 
            // tabPageDependenciesTo
            // 
            this.tabPageDependenciesTo.Controls.Add(this.dgvDependencies);
            this.tabPageDependenciesTo.Controls.Add(this.pnlUpperDependenciesTo);
            this.tabPageDependenciesTo.ImageIndex = 11;
            this.tabPageDependenciesTo.Location = new System.Drawing.Point(4, 23);
            this.tabPageDependenciesTo.Name = "tabPageDependenciesTo";
            this.tabPageDependenciesTo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependenciesTo.Size = new System.Drawing.Size(1267, 531);
            this.tabPageDependenciesTo.TabIndex = 5;
            this.tabPageDependenciesTo.Text = "Dependencies";
            this.tabPageDependenciesTo.UseVisualStyleBackColor = true;
            // 
            // dgvDependencies
            // 
            this.dgvDependencies.AllowUserToAddRows = false;
            this.dgvDependencies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            this.dgvDependencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDependencies.AutoGenerateColumns = false;
            this.dgvDependencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependencies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependencies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDependencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependencies.DataSource = this.bsDependencies;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependencies.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependencies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDependencies.EnableHeadersVisualStyles = false;
            this.dgvDependencies.Location = new System.Drawing.Point(3, 49);
            this.dgvDependencies.MultiSelect = false;
            this.dgvDependencies.Name = "dgvDependencies";
            this.dgvDependencies.ReadOnly = true;
            this.dgvDependencies.RowHeadersVisible = false;
            this.dgvDependencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependencies.Size = new System.Drawing.Size(1261, 479);
            this.dgvDependencies.TabIndex = 22;
            // 
            // bsDependencies
            // 
            this.bsDependencies.DataSource = this.dsDependencies;
            this.bsDependencies.Position = 0;
            // 
            // dsDependencies
            // 
            this.dsDependencies.DataSetName = "NewDataSet";
            this.dsDependencies.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable5});
            // 
            // dataTable5
            // 
            this.dataTable5.TableName = "Table";
            // 
            // pnlUpperDependenciesTo
            // 
            this.pnlUpperDependenciesTo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpperDependenciesTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpperDependenciesTo.Controls.Add(this.hsRefreshDependenciesTo);
            this.pnlUpperDependenciesTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperDependenciesTo.Location = new System.Drawing.Point(3, 3);
            this.pnlUpperDependenciesTo.Name = "pnlUpperDependenciesTo";
            this.pnlUpperDependenciesTo.Size = new System.Drawing.Size(1261, 46);
            this.pnlUpperDependenciesTo.TabIndex = 21;
            // 
            // hsRefreshDependenciesTo
            // 
            this.hsRefreshDependenciesTo.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesTo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesTo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesTo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshDependenciesTo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshDependenciesTo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshDependenciesTo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshDependenciesTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshDependenciesTo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshDependenciesTo.FlatAppearance.BorderSize = 0;
            this.hsRefreshDependenciesTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshDependenciesTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshDependenciesTo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependenciesTo.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependenciesTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshDependenciesTo.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependenciesTo.ImageToggleOnSelect = true;
            this.hsRefreshDependenciesTo.Location = new System.Drawing.Point(1127, 0);
            this.hsRefreshDependenciesTo.Marked = false;
            this.hsRefreshDependenciesTo.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependenciesTo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependenciesTo.MarkedText = "";
            this.hsRefreshDependenciesTo.MarkMode = false;
            this.hsRefreshDependenciesTo.Name = "hsRefreshDependenciesTo";
            this.hsRefreshDependenciesTo.NonMarkedText = "Refresh dependencies";
            this.hsRefreshDependenciesTo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshDependenciesTo.ShowShortcut = false;
            this.hsRefreshDependenciesTo.Size = new System.Drawing.Size(130, 42);
            this.hsRefreshDependenciesTo.TabIndex = 2;
            this.hsRefreshDependenciesTo.Text = "Refresh dependencies";
            this.hsRefreshDependenciesTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshDependenciesTo.ToolTipActive = false;
            this.hsRefreshDependenciesTo.ToolTipAutomaticDelay = 500;
            this.hsRefreshDependenciesTo.ToolTipAutoPopDelay = 5000;
            this.hsRefreshDependenciesTo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshDependenciesTo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshDependenciesTo.ToolTipFor4ContextMenu = true;
            this.hsRefreshDependenciesTo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshDependenciesTo.ToolTipInitialDelay = 500;
            this.hsRefreshDependenciesTo.ToolTipIsBallon = false;
            this.hsRefreshDependenciesTo.ToolTipOwnerDraw = false;
            this.hsRefreshDependenciesTo.ToolTipReshowDelay = 100;
            this.hsRefreshDependenciesTo.ToolTipShowAlways = false;
            this.hsRefreshDependenciesTo.ToolTipText = "";
            this.hsRefreshDependenciesTo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDependenciesTo.ToolTipTitle = "";
            this.hsRefreshDependenciesTo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDependenciesTo.UseVisualStyleBackColor = false;
            this.hsRefreshDependenciesTo.Click += new System.EventHandler(this.hsRefreshDependenciesTo_Click);
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.pnlMessagesCenter);
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1267, 531);
            this.tabPageMessages.TabIndex = 4;
            this.tabPageMessages.Text = "Messages (0) / Errors (0)";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // pnlMessagesCenter
            // 
            this.pnlMessagesCenter.Controls.Add(this.fctMessages);
            this.pnlMessagesCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessagesCenter.Location = new System.Drawing.Point(3, 49);
            this.pnlMessagesCenter.Name = "pnlMessagesCenter";
            this.pnlMessagesCenter.Size = new System.Drawing.Size(1261, 479);
            this.pnlMessagesCenter.TabIndex = 3;
            // 
            // fctMessages
            // 
            this.fctMessages.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctMessages.AutoIndentCharsPatterns = "";
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 14;
            this.fctMessages.CharWidth = 8;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.ContextMenuStrip = this.cmsMessagesText;
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(0, 0);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.ReadOnly = true;
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1261, 479);
            this.fctMessages.TabIndex = 1;
            this.fctMessages.WordWrap = true;
            this.fctMessages.Zoom = 100;
            // 
            // cmsMessagesText
            // 
            this.cmsMessagesText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMessageCopyToClipboard,
            this.tsmiMessagePaste});
            this.cmsMessagesText.Name = "cmsText";
            this.cmsMessagesText.Size = new System.Drawing.Size(172, 48);
            this.cmsMessagesText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsText_ItemClicked);
            // 
            // tsmiMessageCopyToClipboard
            // 
            this.tsmiMessageCopyToClipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiMessageCopyToClipboard.Name = "tsmiMessageCopyToClipboard";
            this.tsmiMessageCopyToClipboard.Size = new System.Drawing.Size(171, 22);
            this.tsmiMessageCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiMessagePaste
            // 
            this.tsmiMessagePaste.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiMessagePaste.Name = "tsmiMessagePaste";
            this.tsmiMessagePaste.Size = new System.Drawing.Size(171, 22);
            this.tsmiMessagePaste.Text = "Paste";
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1261, 46);
            this.pnlMessagesUpper.TabIndex = 2;
            // 
            // hsClearMessages
            // 
            this.hsClearMessages.BackColor = System.Drawing.Color.Transparent;
            this.hsClearMessages.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearMessages.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearMessages.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearMessages.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearMessages.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearMessages.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearMessages.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearMessages.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearMessages.FlatAppearance.BorderSize = 0;
            this.hsClearMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearMessages.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearMessages.Image = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearMessages.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearMessages.ImageHover = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hsClearMessages.ImageToggleOnSelect = true;
            this.hsClearMessages.Location = new System.Drawing.Point(0, 0);
            this.hsClearMessages.Marked = false;
            this.hsClearMessages.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearMessages.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearMessages.MarkedText = "";
            this.hsClearMessages.MarkMode = false;
            this.hsClearMessages.Name = "hsClearMessages";
            this.hsClearMessages.NonMarkedText = "Clear";
            this.hsClearMessages.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearMessages.ShowShortcut = false;
            this.hsClearMessages.Size = new System.Drawing.Size(45, 42);
            this.hsClearMessages.TabIndex = 1;
            this.hsClearMessages.Text = "Clear";
            this.hsClearMessages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearMessages.ToolTipActive = false;
            this.hsClearMessages.ToolTipAutomaticDelay = 500;
            this.hsClearMessages.ToolTipAutoPopDelay = 5000;
            this.hsClearMessages.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearMessages.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearMessages.ToolTipFor4ContextMenu = true;
            this.hsClearMessages.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearMessages.ToolTipInitialDelay = 500;
            this.hsClearMessages.ToolTipIsBallon = false;
            this.hsClearMessages.ToolTipOwnerDraw = false;
            this.hsClearMessages.ToolTipReshowDelay = 100;
            this.hsClearMessages.ToolTipShowAlways = false;
            this.hsClearMessages.ToolTipText = "";
            this.hsClearMessages.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearMessages.ToolTipTitle = "";
            this.hsClearMessages.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearMessages.UseVisualStyleBackColor = false;
            this.hsClearMessages.Click += new System.EventHandler(this.hsClearMessages_Click);
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.fcbExport);
            this.tabPageExport.Controls.Add(this.dgExportGrid);
            this.tabPageExport.Controls.Add(this.pbExport);
            this.tabPageExport.Controls.Add(this.pnlExportDataUpper);
            this.tabPageExport.ImageIndex = 10;
            this.tabPageExport.Location = new System.Drawing.Point(4, 23);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(1267, 531);
            this.tabPageExport.TabIndex = 6;
            this.tabPageExport.Text = "Export data";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // fcbExport
            // 
            this.fcbExport.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fcbExport.AutoIndentCharsPatterns = "";
            this.fcbExport.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fcbExport.BackBrush = null;
            this.fcbExport.CharHeight = 14;
            this.fcbExport.CharWidth = 8;
            this.fcbExport.CommentPrefix = "--";
            this.fcbExport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbExport.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbExport.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fcbExport.IsReplaceMode = false;
            this.fcbExport.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbExport.LeftBracket = '(';
            this.fcbExport.Location = new System.Drawing.Point(272, 45);
            this.fcbExport.Name = "fcbExport";
            this.fcbExport.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbExport.RightBracket = ')';
            this.fcbExport.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbExport.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbExport.ServiceColors")));
            this.fcbExport.Size = new System.Drawing.Size(992, 465);
            this.fcbExport.TabIndex = 4;
            this.fcbExport.Zoom = 100;
            // 
            // dgExportGrid
            // 
            this.dgExportGrid.AllowUserToAddRows = false;
            this.dgExportGrid.AllowUserToDeleteRows = false;
            this.dgExportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOS,
            this.ColExportFieldName,
            this.colExportActive,
            this.colExportWhere});
            this.dgExportGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgExportGrid.Location = new System.Drawing.Point(3, 45);
            this.dgExportGrid.Name = "dgExportGrid";
            this.dgExportGrid.RowHeadersVisible = false;
            this.dgExportGrid.Size = new System.Drawing.Size(269, 465);
            this.dgExportGrid.TabIndex = 6;
            // 
            // colPOS
            // 
            this.colPOS.HeaderText = "Pos";
            this.colPOS.Name = "colPOS";
            this.colPOS.Width = 40;
            // 
            // ColExportFieldName
            // 
            this.ColExportFieldName.HeaderText = "Field";
            this.ColExportFieldName.Name = "ColExportFieldName";
            this.ColExportFieldName.Width = 160;
            // 
            // colExportActive
            // 
            this.colExportActive.HeaderText = "E";
            this.colExportActive.Name = "colExportActive";
            this.colExportActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExportActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colExportActive.Width = 24;
            // 
            // colExportWhere
            // 
            this.colExportWhere.HeaderText = "W";
            this.colExportWhere.Name = "colExportWhere";
            this.colExportWhere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExportWhere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colExportWhere.Width = 24;
            // 
            // pbExport
            // 
            this.pbExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbExport.Location = new System.Drawing.Point(3, 510);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(1261, 18);
            this.pbExport.TabIndex = 7;
            // 
            // pnlExportDataUpper
            // 
            this.pnlExportDataUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlExportDataUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExportDataUpper.Controls.Add(this.gbExportFile);
            this.pnlExportDataUpper.Controls.Add(this.cbExportToScreen);
            this.pnlExportDataUpper.Controls.Add(this.gbInsertUpdate);
            this.pnlExportDataUpper.Controls.Add(this.hsCancelExport);
            this.pnlExportDataUpper.Controls.Add(this.hsExportData);
            this.pnlExportDataUpper.Controls.Add(this.hsRefreshExportData);
            this.pnlExportDataUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExportDataUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlExportDataUpper.Name = "pnlExportDataUpper";
            this.pnlExportDataUpper.Size = new System.Drawing.Size(1261, 42);
            this.pnlExportDataUpper.TabIndex = 5;
            // 
            // gbExportFile
            // 
            this.gbExportFile.Controls.Add(this.cbCharSet);
            this.gbExportFile.Controls.Add(this.cbExportToFile);
            this.gbExportFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbExportFile.Location = new System.Drawing.Point(389, 0);
            this.gbExportFile.Name = "gbExportFile";
            this.gbExportFile.Size = new System.Drawing.Size(326, 38);
            this.gbExportFile.TabIndex = 22;
            this.gbExportFile.TabStop = false;
            this.gbExportFile.Text = "File";
            // 
            // cbCharSet
            // 
            this.cbCharSet.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCharSet.FormattingEnabled = true;
            this.cbCharSet.Location = new System.Drawing.Point(148, 16);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(175, 21);
            this.cbCharSet.TabIndex = 12;
            // 
            // cbExportToFile
            // 
            this.cbExportToFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbExportToFile.Location = new System.Drawing.Point(3, 16);
            this.cbExportToFile.Name = "cbExportToFile";
            this.cbExportToFile.Size = new System.Drawing.Size(133, 19);
            this.cbExportToFile.TabIndex = 11;
            this.cbExportToFile.Text = "Export to file";
            this.cbExportToFile.UseVisualStyleBackColor = true;
            // 
            // cbExportToScreen
            // 
            this.cbExportToScreen.Checked = true;
            this.cbExportToScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportToScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbExportToScreen.Location = new System.Drawing.Point(240, 0);
            this.cbExportToScreen.Name = "cbExportToScreen";
            this.cbExportToScreen.Size = new System.Drawing.Size(149, 38);
            this.cbExportToScreen.TabIndex = 12;
            this.cbExportToScreen.Text = "Export to screen";
            this.cbExportToScreen.UseVisualStyleBackColor = true;
            // 
            // gbInsertUpdate
            // 
            this.gbInsertUpdate.Controls.Add(this.rbUPDATE);
            this.gbInsertUpdate.Controls.Add(this.rbINSERTUPDATE);
            this.gbInsertUpdate.Controls.Add(this.rbINSERT);
            this.gbInsertUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbInsertUpdate.Location = new System.Drawing.Point(794, 0);
            this.gbInsertUpdate.Name = "gbInsertUpdate";
            this.gbInsertUpdate.Size = new System.Drawing.Size(330, 38);
            this.gbInsertUpdate.TabIndex = 10;
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
            // hsCancelExport
            // 
            this.hsCancelExport.BackColor = System.Drawing.Color.Transparent;
            this.hsCancelExport.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCancelExport.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCancelExport.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCancelExport.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCancelExport.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCancelExport.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCancelExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCancelExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCancelExport.FlatAppearance.BorderSize = 0;
            this.hsCancelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCancelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCancelExport.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancelExport.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsCancelExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCancelExport.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsCancelExport.ImageToggleOnSelect = false;
            this.hsCancelExport.Location = new System.Drawing.Point(100, 0);
            this.hsCancelExport.Marked = false;
            this.hsCancelExport.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancelExport.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancelExport.MarkedText = "";
            this.hsCancelExport.MarkMode = false;
            this.hsCancelExport.Name = "hsCancelExport";
            this.hsCancelExport.NonMarkedText = "Cancel reading";
            this.hsCancelExport.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCancelExport.ShowShortcut = false;
            this.hsCancelExport.Size = new System.Drawing.Size(140, 38);
            this.hsCancelExport.TabIndex = 21;
            this.hsCancelExport.Text = "Cancel reading";
            this.hsCancelExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCancelExport.ToolTipActive = false;
            this.hsCancelExport.ToolTipAutomaticDelay = 500;
            this.hsCancelExport.ToolTipAutoPopDelay = 5000;
            this.hsCancelExport.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCancelExport.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCancelExport.ToolTipFor4ContextMenu = true;
            this.hsCancelExport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCancelExport.ToolTipInitialDelay = 500;
            this.hsCancelExport.ToolTipIsBallon = false;
            this.hsCancelExport.ToolTipOwnerDraw = false;
            this.hsCancelExport.ToolTipReshowDelay = 100;
            this.hsCancelExport.ToolTipShowAlways = false;
            this.hsCancelExport.ToolTipText = "";
            this.hsCancelExport.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCancelExport.ToolTipTitle = "";
            this.hsCancelExport.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCancelExport.UseVisualStyleBackColor = false;
            // 
            // hsExportData
            // 
            this.hsExportData.BackColor = System.Drawing.Color.Transparent;
            this.hsExportData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportData.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsExportData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportData.FlatAppearance.BorderSize = 0;
            this.hsExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportData.Image = global::FBXpert.Properties.Resources.format_indent_more_2_22x;
            this.hsExportData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportData.ImageHover = global::FBXpert.Properties.Resources.format_indent_more22x;
            this.hsExportData.ImageToggleOnSelect = false;
            this.hsExportData.Location = new System.Drawing.Point(0, 0);
            this.hsExportData.Marked = false;
            this.hsExportData.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportData.MarkedText = "";
            this.hsExportData.MarkMode = false;
            this.hsExportData.Name = "hsExportData";
            this.hsExportData.NonMarkedText = "Export";
            this.hsExportData.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExportData.ShowShortcut = false;
            this.hsExportData.Size = new System.Drawing.Size(100, 38);
            this.hsExportData.TabIndex = 9;
            this.hsExportData.Text = "Export";
            this.hsExportData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportData.ToolTipActive = false;
            this.hsExportData.ToolTipAutomaticDelay = 500;
            this.hsExportData.ToolTipAutoPopDelay = 5000;
            this.hsExportData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportData.ToolTipFor4ContextMenu = true;
            this.hsExportData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportData.ToolTipInitialDelay = 500;
            this.hsExportData.ToolTipIsBallon = false;
            this.hsExportData.ToolTipOwnerDraw = false;
            this.hsExportData.ToolTipReshowDelay = 100;
            this.hsExportData.ToolTipShowAlways = false;
            this.hsExportData.ToolTipText = "";
            this.hsExportData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportData.ToolTipTitle = "";
            this.hsExportData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportData.UseVisualStyleBackColor = false;
            this.hsExportData.Click += new System.EventHandler(this.hsExport_Click);
            // 
            // hsRefreshExportData
            // 
            this.hsRefreshExportData.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshExportData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshExportData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshExportData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshExportData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshExportData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshExportData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshExportData.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshExportData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshExportData.FlatAppearance.BorderSize = 0;
            this.hsRefreshExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshExportData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshExportData.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshExportData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshExportData.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshExportData.ImageToggleOnSelect = false;
            this.hsRefreshExportData.Location = new System.Drawing.Point(1124, 0);
            this.hsRefreshExportData.Marked = false;
            this.hsRefreshExportData.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshExportData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshExportData.MarkedText = "";
            this.hsRefreshExportData.MarkMode = false;
            this.hsRefreshExportData.Name = "hsRefreshExportData";
            this.hsRefreshExportData.NonMarkedText = "Refresh Data";
            this.hsRefreshExportData.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshExportData.ShowShortcut = false;
            this.hsRefreshExportData.Size = new System.Drawing.Size(133, 38);
            this.hsRefreshExportData.TabIndex = 3;
            this.hsRefreshExportData.Text = "Refresh Data";
            this.hsRefreshExportData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshExportData.ToolTipActive = false;
            this.hsRefreshExportData.ToolTipAutomaticDelay = 500;
            this.hsRefreshExportData.ToolTipAutoPopDelay = 5000;
            this.hsRefreshExportData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshExportData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshExportData.ToolTipFor4ContextMenu = true;
            this.hsRefreshExportData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshExportData.ToolTipInitialDelay = 500;
            this.hsRefreshExportData.ToolTipIsBallon = false;
            this.hsRefreshExportData.ToolTipOwnerDraw = false;
            this.hsRefreshExportData.ToolTipReshowDelay = 100;
            this.hsRefreshExportData.ToolTipShowAlways = false;
            this.hsRefreshExportData.ToolTipText = "";
            this.hsRefreshExportData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshExportData.ToolTipTitle = "";
            this.hsRefreshExportData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshExportData.UseVisualStyleBackColor = false;
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
            this.ilTabControl.Images.SetKeyName(11, "media_playlist_shuffle_x32.png");
            this.ilTabControl.Images.SetKeyName(12, "format_indent_more_2_22x.png");
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.ckGetDatas);
            this.pnlUpper.Controls.Add(this.gnUsedTime);
            this.pnlUpper.Controls.Add(this.gbMaxAllowedErrors);
            this.pnlUpper.Controls.Add(this.gbMaxRows);
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsPageRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1275, 40);
            this.pnlUpper.TabIndex = 1;
            // 
            // ckGetDatas
            // 
            this.ckGetDatas.AutoSize = true;
            this.ckGetDatas.Location = new System.Drawing.Point(1086, 11);
            this.ckGetDatas.Name = "ckGetDatas";
            this.ckGetDatas.Size = new System.Drawing.Size(83, 17);
            this.ckGetDatas.TabIndex = 9;
            this.ckGetDatas.Text = "Read Datas";
            this.ckGetDatas.UseVisualStyleBackColor = true;
            this.ckGetDatas.CheckedChanged += new System.EventHandler(this.ckGetDatas_CheckedChanged);
            // 
            // gnUsedTime
            // 
            this.gnUsedTime.Controls.Add(this.txtUsedTime);
            this.gnUsedTime.Location = new System.Drawing.Point(339, -1);
            this.gnUsedTime.Name = "gnUsedTime";
            this.gnUsedTime.Size = new System.Drawing.Size(116, 41);
            this.gnUsedTime.TabIndex = 6;
            this.gnUsedTime.TabStop = false;
            this.gnUsedTime.Text = "Used time (ms)";
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.BackColor = System.Drawing.SystemColors.Info;
            this.txtUsedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsedTime.Location = new System.Drawing.Point(3, 16);
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.ReadOnly = true;
            this.txtUsedTime.Size = new System.Drawing.Size(110, 20);
            this.txtUsedTime.TabIndex = 0;
            this.txtUsedTime.Text = "0";
            // 
            // gbMaxAllowedErrors
            // 
            this.gbMaxAllowedErrors.Controls.Add(this.txtMaxAllowedErrors);
            this.gbMaxAllowedErrors.Location = new System.Drawing.Point(462, 0);
            this.gbMaxAllowedErrors.Name = "gbMaxAllowedErrors";
            this.gbMaxAllowedErrors.Size = new System.Drawing.Size(116, 41);
            this.gbMaxAllowedErrors.TabIndex = 5;
            this.gbMaxAllowedErrors.TabStop = false;
            this.gbMaxAllowedErrors.Text = "Max allowed errors";
            // 
            // txtMaxAllowedErrors
            // 
            this.txtMaxAllowedErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxAllowedErrors.Location = new System.Drawing.Point(3, 16);
            this.txtMaxAllowedErrors.Name = "txtMaxAllowedErrors";
            this.txtMaxAllowedErrors.Size = new System.Drawing.Size(110, 20);
            this.txtMaxAllowedErrors.TabIndex = 0;
            this.txtMaxAllowedErrors.Text = "100";
            // 
            // gbMaxRows
            // 
            this.gbMaxRows.Controls.Add(this.rbSQLDesc);
            this.gbMaxRows.Controls.Add(this.rbSQLAsc);
            this.gbMaxRows.Controls.Add(this.txtMaxRows);
            this.gbMaxRows.Location = new System.Drawing.Point(585, 0);
            this.gbMaxRows.Name = "gbMaxRows";
            this.gbMaxRows.Size = new System.Drawing.Size(218, 41);
            this.gbMaxRows.TabIndex = 4;
            this.gbMaxRows.TabStop = false;
            this.gbMaxRows.Text = "Max Rows";
            // 
            // rbSQLDesc
            // 
            this.rbSQLDesc.AutoSize = true;
            this.rbSQLDesc.Checked = true;
            this.rbSQLDesc.Location = new System.Drawing.Point(149, 19);
            this.rbSQLDesc.Name = "rbSQLDesc";
            this.rbSQLDesc.Size = new System.Drawing.Size(54, 17);
            this.rbSQLDesc.TabIndex = 4;
            this.rbSQLDesc.TabStop = true;
            this.rbSQLDesc.Text = "DESC";
            this.rbSQLDesc.UseVisualStyleBackColor = true;
            // 
            // rbSQLAsc
            // 
            this.rbSQLAsc.AutoSize = true;
            this.rbSQLAsc.Location = new System.Drawing.Point(97, 18);
            this.rbSQLAsc.Name = "rbSQLAsc";
            this.rbSQLAsc.Size = new System.Drawing.Size(46, 17);
            this.rbSQLAsc.TabIndex = 3;
            this.rbSQLAsc.Text = "ASC";
            this.rbSQLAsc.UseVisualStyleBackColor = true;
            // 
            // txtMaxRows
            // 
            this.txtMaxRows.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMaxRows.Location = new System.Drawing.Point(3, 16);
            this.txtMaxRows.Name = "txtMaxRows";
            this.txtMaxRows.Size = new System.Drawing.Size(88, 20);
            this.txtMaxRows.TabIndex = 0;
            this.txtMaxRows.Text = "2000";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(76, 11);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 3;
            this.lblTableName.Text = "Tablename";
            // 
            // hsPageRefresh
            // 
            this.hsPageRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsPageRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPageRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPageRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPageRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPageRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPageRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPageRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsPageRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsPageRefresh.FlatAppearance.BorderSize = 0;
            this.hsPageRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPageRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPageRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPageRefresh.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsPageRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPageRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsPageRefresh.ImageToggleOnSelect = true;
            this.hsPageRefresh.Location = new System.Drawing.Point(1175, 0);
            this.hsPageRefresh.Marked = false;
            this.hsPageRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsPageRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPageRefresh.MarkedText = "";
            this.hsPageRefresh.MarkMode = false;
            this.hsPageRefresh.Name = "hsPageRefresh";
            this.hsPageRefresh.NonMarkedText = "";
            this.hsPageRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsPageRefresh.ShowShortcut = false;
            this.hsPageRefresh.Size = new System.Drawing.Size(100, 40);
            this.hsPageRefresh.TabIndex = 1;
            this.hsPageRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPageRefresh.ToolTipActive = false;
            this.hsPageRefresh.ToolTipAutomaticDelay = 500;
            this.hsPageRefresh.ToolTipAutoPopDelay = 5000;
            this.hsPageRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPageRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPageRefresh.ToolTipFor4ContextMenu = true;
            this.hsPageRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPageRefresh.ToolTipInitialDelay = 500;
            this.hsPageRefresh.ToolTipIsBallon = false;
            this.hsPageRefresh.ToolTipOwnerDraw = false;
            this.hsPageRefresh.ToolTipReshowDelay = 100;
            this.hsPageRefresh.ToolTipShowAlways = false;
            this.hsPageRefresh.ToolTipText = "";
            this.hsPageRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPageRefresh.ToolTipTitle = "";
            this.hsPageRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPageRefresh.UseVisualStyleBackColor = false;
            this.hsPageRefresh.Click += new System.EventHandler(this.hsRefresh_Click);
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
            this.hsClose.Size = new System.Drawing.Size(45, 40);
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
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlViews);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 40);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1275, 558);
            this.pnlCenter.TabIndex = 3;
            // 
            // saveSQLFile
            // 
            this.saveSQLFile.DefaultExt = "*.sql";
            this.saveSQLFile.Filter = "SQL|*.sql|All|*.*";
            this.saveSQLFile.Title = "Save SQL ";
            // 
            // ofdSQL
            // 
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
            // 
            // bwExport
            // 
            this.bwExport.WorkerReportsProgress = true;
            this.bwExport.WorkerSupportsCancellation = true;
            this.bwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExport_DoWork);
            this.bwExport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwExport_ProgressChanged);
            this.bwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExport_RunWorkerCompleted);
            // 
            // VIEWManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 598);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VIEWManageForm";
            this.Text = "VIEWManageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIEWManageForm_FormClosing);
            this.Load += new System.EventHandler(this.VIEWManageForm_Load);
            this.tabControlViews.ResumeLayout(false);
            this.tabPageFIELDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.cmsUpdateInsertText.ResumeLayout(false);
            this.tabPageDATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.cmdDATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsViewContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsViewContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.gbSQL.ResumeLayout(false);
            this.gbSQL.PerformLayout();
            this.pnlDataUpper.ResumeLayout(false);
            this.pnlDataUpper.PerformLayout();
            this.gbBnView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnView)).EndInit();
            this.bnView.ResumeLayout(false);
            this.bnView.PerformLayout();
            this.tabDDL.ResumeLayout(false);
            this.pnlDDL_CENTER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctDLL)).EndInit();
            this.cmsDDLText.ResumeLayout(false);
            this.pnlDDL_UPPER.ResumeLayout(false);
            this.tabUpdateInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctCREATEINSERTSQL)).EndInit();
            this.pnlUpdateInsertSQLUpper.ResumeLayout(false);
            this.pnlUpdateInsertSQLUpper.PerformLayout();
            this.tabPageDependenciesTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.pnlUpperDependenciesTo.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            this.pnlMessagesCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.cmsMessagesText.ResumeLayout(false);
            this.pnlMessagesUpper.ResumeLayout(false);
            this.tabPageExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExportGrid)).EndInit();
            this.pnlExportDataUpper.ResumeLayout(false);
            this.gbExportFile.ResumeLayout(false);
            this.gbInsertUpdate.ResumeLayout(false);
            this.gbInsertUpdate.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.gnUsedTime.ResumeLayout(false);
            this.gnUsedTime.PerformLayout();
            this.gbMaxAllowedErrors.ResumeLayout(false);
            this.gbMaxAllowedErrors.PerformLayout();
            this.gbMaxRows.ResumeLayout(false);
            this.gbMaxRows.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlViews;
        private System.Windows.Forms.TabPage tabPageFIELDS;
        private System.Windows.Forms.TabPage tabPageDATA;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsPageRefresh;
        private System.Windows.Forms.BindingSource bsViewContent;
        private System.Data.DataSet dsViewContent;
        private System.Data.DataTable Table;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel pnlDataUpper;
        private System.Windows.Forms.TabPage tabDDL;
        private System.Windows.Forms.Panel pnlDDL_CENTER;
        private System.Windows.Forms.Panel pnlDDL_UPPER;
        private FastColoredTextBoxNS.FastColoredTextBox fctDLL;
        private System.Windows.Forms.TabPage tabUpdateInsert;
        private System.Windows.Forms.Panel pnlUpdateInsertSQLUpper;
        private FastColoredTextBoxNS.FastColoredTextBox fctCREATEINSERTSQL;
        private SeControlsLib.HotSpot hsRunStatement;
        private System.Windows.Forms.BindingNavigator bnView;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private SeControlsLib.SpezialfilterBox sfbViewData;
        private System.Windows.Forms.Label lblTableName;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.Panel pnlMessagesCenter;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsClearMessages;
        private System.Windows.Forms.ContextMenuStrip cmsUpdateInsertText;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateInsertCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateInsertPaste;
        private System.Windows.Forms.ContextMenuStrip cmsDDLText;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLPaste;
        private System.Windows.Forms.ContextMenuStrip cmsMessagesText;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessageCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessagePaste;
        private System.Windows.Forms.TabPage tabPageDependenciesTo;
        private System.Windows.Forms.DataGridView dgvDependencies;
        private System.Windows.Forms.BindingSource bsDependencies;
        private System.Data.DataSet dsDependencies;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Panel pnlUpperDependenciesTo;
        private SeControlsLib.HotSpot hsRefreshDependenciesTo;
        private SeControlsLib.HotSpot hsLoadSQL;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private SeControlsLib.HotSpot hsCancelGettingData;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.CheckBox cbAlterView;
        private System.Windows.Forms.CheckBox cbCAuto;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.GroupBox gbMaxRows;
        private System.Windows.Forms.TextBox txtMaxRows;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.Panel pnlExportDataUpper;
        private System.Windows.Forms.GroupBox gbExportFile;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.CheckBox cbExportToFile;
        private System.Windows.Forms.CheckBox cbExportToScreen;
        private System.Windows.Forms.GroupBox gbInsertUpdate;
        private System.Windows.Forms.RadioButton rbUPDATE;
        private System.Windows.Forms.RadioButton rbINSERTUPDATE;
        private System.Windows.Forms.RadioButton rbINSERT;
        private SeControlsLib.HotSpot hsCancelExport;
        private SeControlsLib.HotSpot hsExportData;
        private SeControlsLib.HotSpot hsRefreshExportData;
        private System.Windows.Forms.DataGridView dgExportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExportFieldName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExportActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExportWhere;
        private FastColoredTextBoxNS.FastColoredTextBox fcbExport;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.ComponentModel.BackgroundWorker bwExport;
        private System.Windows.Forms.GroupBox gbBnView;
        private System.Windows.Forms.GroupBox gbMaxAllowedErrors;
        private System.Windows.Forms.TextBox txtMaxAllowedErrors;
        private System.Windows.Forms.CheckBox cbPretty;
        private System.Windows.Forms.GroupBox gnUsedTime;
        private System.Windows.Forms.TextBox txtUsedTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmdDATA;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpaltenEdit;
        private System.Windows.Forms.CheckBox ckGetDatas;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.RadioButton rbSQLDesc;
        private System.Windows.Forms.RadioButton rbSQLAsc;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
    }
}