using BasicForms;

namespace FBExpert
{
    partial class TABLEManageForm : BasicNormalFormClass
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TABLEManageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageFIELDS = new System.Windows.Forms.TabPage();
            this.pnlTableFieldCenter = new System.Windows.Forms.Panel();
            this.lvFields = new System.Windows.Forms.ListView();
            this.colFIELDPOSITION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFIELDNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLENGTH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRAWTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFIELDNOTNULL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFIELDDEFAULTVALUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSCALE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPRIMARY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUNIQUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCHARSET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCOLLATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOMAINNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOMAINNOTNULL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOMAINDEFAULTVALUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTableFieldUpper = new System.Windows.Forms.Panel();
            this.hsEditField = new SeControlsLib.HotSpot();
            this.hsDropField = new SeControlsLib.HotSpot();
            this.hsFieldRefresh = new SeControlsLib.HotSpot();
            this.hsNewField = new SeControlsLib.HotSpot();
            this.tabPageDATA = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cmdDATA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertNow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiInsertGUID = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetToNULL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReadBLOB = new System.Windows.Forms.ToolStripMenuItem();
            this.bsTableContent = new System.Windows.Forms.BindingSource(this.components);
            this.dsTableContent = new System.Data.DataSet();
            this.Table = new System.Data.DataTable();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.pnlDataUpper = new System.Windows.Forms.Panel();
            this.gbRowHeight = new System.Windows.Forms.GroupBox();
            this.txtRowHeight = new System.Windows.Forms.TextBox();
            this.cbRowManually = new System.Windows.Forms.CheckBox();
            this.hsSaveDataset = new SeControlsLib.HotSpot();
            this.gbEditMode = new System.Windows.Forms.GroupBox();
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            this.gbBnView = new System.Windows.Forms.GroupBox();
            this.bnTableContent = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnTableContentCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnTableContentDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bnTableContentMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bnTableContentMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bnTableContentSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnTableContentPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bnTableContentSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnTableContentMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bnTableContentMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bnTableContentSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sfbTableData = new SeControlsLib.SpezialfilterBox();
            this.hsCancelGettingData = new SeControlsLib.HotSpot();
            this.pnlTableDataAutoRefresh = new System.Windows.Forms.Panel();
            this.cbAutoRefresh = new System.Windows.Forms.CheckBox();
            this.hsRefreshData = new SeControlsLib.HotSpot();
            this.tabDDL = new System.Windows.Forms.TabPage();
            this.pnlDDL_CENTER = new System.Windows.Forms.Panel();
            this.fctTableCreateDLL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsDDLText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDDLCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDDLPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDDL_UPPER = new System.Windows.Forms.Panel();
            this.gbUsedMilliseconds = new System.Windows.Forms.GroupBox();
            this.lblUsedMs = new System.Windows.Forms.Label();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsRunStatement = new SeControlsLib.HotSpot();
            this.tabConstraints = new System.Windows.Forms.TabPage();
            this.pnlCenterConstraints = new System.Windows.Forms.Panel();
            this.hsEditConstraint = new SeControlsLib.HotSpot();
            this.hsDropConstraint = new SeControlsLib.HotSpot();
            this.hsAddConstraint = new SeControlsLib.HotSpot();
            this.tabControlConstraints = new System.Windows.Forms.TabControl();
            this.tabPagePrimaryKeys = new System.Windows.Forms.TabPage();
            this.dgvPrimaryKeys = new System.Windows.Forms.DataGridView();
            this.bsPrimaryKeys = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrimaryKeys = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.pnlUpperConstraints = new System.Windows.Forms.Panel();
            this.tabPageForeignKeys = new System.Windows.Forms.TabPage();
            this.dgvForeignKeys = new System.Windows.Forms.DataGridView();
            this.bsForeignKeys = new System.Windows.Forms.BindingSource(this.components);
            this.dsForeignKeys = new System.Data.DataSet();
            this.dataTable4 = new System.Data.DataTable();
            this.pnlForeignKeysUpper = new System.Windows.Forms.Panel();
            this.tabPageUniques = new System.Windows.Forms.TabPage();
            this.dgvUniques = new System.Windows.Forms.DataGridView();
            this.bsUniques = new System.Windows.Forms.BindingSource(this.components);
            this.dsUniques = new System.Data.DataSet();
            this.dataTable3 = new System.Data.DataTable();
            this.pnlUniquesUpper = new System.Windows.Forms.Panel();
            this.tabPageChecks = new System.Windows.Forms.TabPage();
            this.dgvChecks = new System.Windows.Forms.DataGridView();
            this.bsChecks = new System.Windows.Forms.BindingSource(this.components);
            this.dsChecks = new System.Data.DataSet();
            this.dataTable7 = new System.Data.DataTable();
            this.pnlChecksUpper = new System.Windows.Forms.Panel();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.tabIndicies = new System.Windows.Forms.TabPage();
            this.pnpCenterIndicies = new System.Windows.Forms.Panel();
            this.dgvIndicies = new System.Windows.Forms.DataGridView();
            this.bsIndicies = new System.Windows.Forms.BindingSource(this.components);
            this.dsIndicies = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.pnlUpperIndicies = new System.Windows.Forms.Panel();
            this.hsEditIndex = new SeControlsLib.HotSpot();
            this.hsDropIndex = new SeControlsLib.HotSpot();
            this.hsAddIndex = new SeControlsLib.HotSpot();
            this.tabPageDependenciesTo = new System.Windows.Forms.TabPage();
            this.dgvDependenciesTo = new System.Windows.Forms.DataGridView();
            this.bsDependenciesTo = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependenciesTo = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.pnlDependenciesToUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDependenciesTo = new SeControlsLib.HotSpot();
            this.tabPageDependenciesFrom = new System.Windows.Forms.TabPage();
            this.dgvDependenciesFrom = new System.Windows.Forms.DataGridView();
            this.bsDependenciesFrom = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependenciesFrom = new System.Data.DataSet();
            this.dataTable6 = new System.Data.DataTable();
            this.pnlDependenciesUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDependenciesFrom = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.pnlMessagesCenter = new System.Windows.Forms.Panel();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsMessagesText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMessageCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMessagePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.pnlExportCenter = new System.Windows.Forms.Panel();
            this.fcbExport = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsEXPORTData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEXPORTDataCopyToCLipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEXPORTDataPasteFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.dgExportGrid = new System.Windows.Forms.DataGridView();
            this.colPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExportFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExportActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colExportWhere = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlExportBottom = new System.Windows.Forms.Panel();
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
            this.tabPageTablestatistics = new System.Windows.Forms.TabPage();
            this.fctTableStatistics = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlUpperStatistics = new System.Windows.Forms.Panel();
            this.hsRefreshTableStatistics = new SeControlsLib.HotSpot();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.gbMaxAllowedErrors = new System.Windows.Forms.GroupBox();
            this.txtMaxAllowedErrors = new System.Windows.Forms.TextBox();
            this.gbMaxRows = new System.Windows.Forms.GroupBox();
            this.hsRefreshMaxRows = new SeControlsLib.HotSpot();
            this.txtMaxRows = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsPageRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.bwExport = new System.ComponentModel.BackgroundWorker();
            this.tsmiInsertGUIDHEX = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPageFIELDS.SuspendLayout();
            this.pnlTableFieldCenter.SuspendLayout();
            this.pnlTableFieldUpper.SuspendLayout();
            this.tabPageDATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.cmdDATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTableContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTableContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.gbSQL.SuspendLayout();
            this.pnlDataUpper.SuspendLayout();
            this.gbRowHeight.SuspendLayout();
            this.gbEditMode.SuspendLayout();
            this.gbBnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTableContent)).BeginInit();
            this.bnTableContent.SuspendLayout();
            this.pnlTableDataAutoRefresh.SuspendLayout();
            this.tabDDL.SuspendLayout();
            this.pnlDDL_CENTER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctTableCreateDLL)).BeginInit();
            this.cmsDDLText.SuspendLayout();
            this.pnlDDL_UPPER.SuspendLayout();
            this.gbUsedMilliseconds.SuspendLayout();
            this.tabConstraints.SuspendLayout();
            this.pnlCenterConstraints.SuspendLayout();
            this.tabControlConstraints.SuspendLayout();
            this.tabPagePrimaryKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrimaryKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrimaryKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.tabPageForeignKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForeignKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForeignKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForeignKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).BeginInit();
            this.tabPageUniques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUniques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUniques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.tabPageChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable7)).BeginInit();
            this.tabIndicies.SuspendLayout();
            this.pnpCenterIndicies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIndicies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIndicies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.pnlUpperIndicies.SuspendLayout();
            this.tabPageDependenciesTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.pnlDependenciesToUpper.SuspendLayout();
            this.tabPageDependenciesFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).BeginInit();
            this.pnlDependenciesUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.pnlMessagesCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.cmsMessagesText.SuspendLayout();
            this.pnlMessagesUpper.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.pnlExportCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbExport)).BeginInit();
            this.cmsEXPORTData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExportGrid)).BeginInit();
            this.pnlExportBottom.SuspendLayout();
            this.pnlExportDataUpper.SuspendLayout();
            this.gbExportFile.SuspendLayout();
            this.gbInsertUpdate.SuspendLayout();
            this.tabPageTablestatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctTableStatistics)).BeginInit();
            this.pnlUpperStatistics.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.gbMaxAllowedErrors.SuspendLayout();
            this.gbMaxRows.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageFIELDS);
            this.tabControl.Controls.Add(this.tabPageDATA);
            this.tabControl.Controls.Add(this.tabDDL);
            this.tabControl.Controls.Add(this.tabConstraints);
            this.tabControl.Controls.Add(this.tabIndicies);
            this.tabControl.Controls.Add(this.tabPageDependenciesTo);
            this.tabControl.Controls.Add(this.tabPageDependenciesFrom);
            this.tabControl.Controls.Add(this.tabPageMessages);
            this.tabControl.Controls.Add(this.tabPageExport);
            this.tabControl.Controls.Add(this.tabPageTablestatistics);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.ilTabControl;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1307, 582);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageFIELDS
            // 
            this.tabPageFIELDS.Controls.Add(this.pnlTableFieldCenter);
            this.tabPageFIELDS.Controls.Add(this.pnlTableFieldUpper);
            this.tabPageFIELDS.ImageKey = "table_blue_x24.png";
            this.tabPageFIELDS.Location = new System.Drawing.Point(4, 23);
            this.tabPageFIELDS.Name = "tabPageFIELDS";
            this.tabPageFIELDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFIELDS.Size = new System.Drawing.Size(1299, 555);
            this.tabPageFIELDS.TabIndex = 0;
            this.tabPageFIELDS.Text = "Fields";
            this.tabPageFIELDS.UseVisualStyleBackColor = true;
            // 
            // pnlTableFieldCenter
            // 
            this.pnlTableFieldCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTableFieldCenter.Controls.Add(this.lvFields);
            this.pnlTableFieldCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableFieldCenter.Location = new System.Drawing.Point(3, 43);
            this.pnlTableFieldCenter.Name = "pnlTableFieldCenter";
            this.pnlTableFieldCenter.Size = new System.Drawing.Size(1293, 509);
            this.pnlTableFieldCenter.TabIndex = 2;
            // 
            // lvFields
            // 
            this.lvFields.AllowColumnReorder = true;
            this.lvFields.AutoArrange = false;
            this.lvFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFIELDPOSITION,
            this.colFIELDNAME,
            this.colTYPE,
            this.colLENGTH,
            this.colRAWTYPE,
            this.colFIELDNOTNULL,
            this.colFIELDDEFAULTVALUE,
            this.colSCALE,
            this.colPRIMARY,
            this.colUNIQUE,
            this.colCHARSET,
            this.colCOLLATE,
            this.colFK,
            this.colDOMAINNAME,
            this.colDOMAINNOTNULL,
            this.colDOMAINDEFAULTVALUE});
            this.lvFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFields.FullRowSelect = true;
            this.lvFields.GridLines = true;
            this.lvFields.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvFields.Location = new System.Drawing.Point(0, 0);
            this.lvFields.Name = "lvFields";
            this.lvFields.Size = new System.Drawing.Size(1293, 509);
            this.lvFields.TabIndex = 0;
            this.lvFields.UseCompatibleStateImageBehavior = false;
            this.lvFields.View = System.Windows.Forms.View.Details;
            this.lvFields.SelectedIndexChanged += new System.EventHandler(this.lvFields_SelectedIndexChanged);
            this.lvFields.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFields_MouseDoubleClick);
            // 
            // colFIELDPOSITION
            // 
            this.colFIELDPOSITION.Text = "Pos";
            this.colFIELDPOSITION.Width = 40;
            // 
            // colFIELDNAME
            // 
            this.colFIELDNAME.DisplayIndex = 4;
            this.colFIELDNAME.Text = "Field Name";
            this.colFIELDNAME.Width = 300;
            // 
            // colTYPE
            // 
            this.colTYPE.DisplayIndex = 5;
            this.colTYPE.Text = "FieldType";
            this.colTYPE.Width = 100;
            // 
            // colLENGTH
            // 
            this.colLENGTH.DisplayIndex = 6;
            this.colLENGTH.Text = "Length";
            this.colLENGTH.Width = 50;
            // 
            // colRAWTYPE
            // 
            this.colRAWTYPE.DisplayIndex = 7;
            this.colRAWTYPE.Text = "RAW FieldType";
            this.colRAWTYPE.Width = 120;
            // 
            // colFIELDNOTNULL
            // 
            this.colFIELDNOTNULL.DisplayIndex = 9;
            this.colFIELDNOTNULL.Text = "Field Not Null";
            this.colFIELDNOTNULL.Width = 80;
            // 
            // colFIELDDEFAULTVALUE
            // 
            this.colFIELDDEFAULTVALUE.DisplayIndex = 10;
            this.colFIELDDEFAULTVALUE.Text = "Field Default Value";
            this.colFIELDDEFAULTVALUE.Width = 100;
            // 
            // colSCALE
            // 
            this.colSCALE.DisplayIndex = 11;
            this.colSCALE.Text = "Scale";
            // 
            // colPRIMARY
            // 
            this.colPRIMARY.DisplayIndex = 1;
            this.colPRIMARY.Text = "PK";
            this.colPRIMARY.Width = 30;
            // 
            // colUNIQUE
            // 
            this.colUNIQUE.DisplayIndex = 3;
            this.colUNIQUE.Text = "UQ";
            this.colUNIQUE.Width = 30;
            // 
            // colCHARSET
            // 
            this.colCHARSET.DisplayIndex = 12;
            this.colCHARSET.Text = "Charset";
            // 
            // colCOLLATE
            // 
            this.colCOLLATE.DisplayIndex = 13;
            this.colCOLLATE.Text = "Collate";
            // 
            // colFK
            // 
            this.colFK.DisplayIndex = 2;
            this.colFK.Text = "FK";
            this.colFK.Width = 30;
            // 
            // colDOMAINNAME
            // 
            this.colDOMAINNAME.DisplayIndex = 8;
            this.colDOMAINNAME.Text = "Domain Name";
            this.colDOMAINNAME.Width = 106;
            // 
            // colDOMAINNOTNULL
            // 
            this.colDOMAINNOTNULL.Text = "Domain Not Null";
            // 
            // colDOMAINDEFAULTVALUE
            // 
            this.colDOMAINDEFAULTVALUE.Text = "Domain Default Value";
            this.colDOMAINDEFAULTVALUE.Width = 100;
            // 
            // pnlTableFieldUpper
            // 
            this.pnlTableFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTableFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTableFieldUpper.Controls.Add(this.hsEditField);
            this.pnlTableFieldUpper.Controls.Add(this.hsDropField);
            this.pnlTableFieldUpper.Controls.Add(this.hsFieldRefresh);
            this.pnlTableFieldUpper.Controls.Add(this.hsNewField);
            this.pnlTableFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlTableFieldUpper.Name = "pnlTableFieldUpper";
            this.pnlTableFieldUpper.Size = new System.Drawing.Size(1293, 40);
            this.pnlTableFieldUpper.TabIndex = 1;
            // 
            // hsEditField
            // 
            this.hsEditField.BackColor = System.Drawing.Color.Transparent;
            this.hsEditField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsEditField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsEditField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditField.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsEditField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditField.FlatAppearance.BorderSize = 0;
            this.hsEditField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEditField.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.hsEditField.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsEditField.ImageHover = global::FBXpert.Properties.Resources.format_text_direction_blue_x22;
            this.hsEditField.ImageToggleOnSelect = true;
            this.hsEditField.Location = new System.Drawing.Point(200, 0);
            this.hsEditField.Marked = false;
            this.hsEditField.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditField.MarkedText = "";
            this.hsEditField.MarkMode = false;
            this.hsEditField.Name = "hsEditField";
            this.hsEditField.NonMarkedText = "Edit Field";
            this.hsEditField.Size = new System.Drawing.Size(100, 36);
            this.hsEditField.TabIndex = 5;
            this.hsEditField.Text = "Edit Field";
            this.hsEditField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEditField.ToolTipActive = false;
            this.hsEditField.ToolTipAutomaticDelay = 500;
            this.hsEditField.ToolTipAutoPopDelay = 5000;
            this.hsEditField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEditField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEditField.ToolTipFor4ContextMenu = true;
            this.hsEditField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEditField.ToolTipInitialDelay = 500;
            this.hsEditField.ToolTipIsBallon = false;
            this.hsEditField.ToolTipOwnerDraw = false;
            this.hsEditField.ToolTipReshowDelay = 100;
            this.hsEditField.ToolTipShowAlways = false;
            this.hsEditField.ToolTipText = "";
            this.hsEditField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsEditField.ToolTipTitle = "";
            this.hsEditField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEditField.UseVisualStyleBackColor = false;
            this.hsEditField.Click += new System.EventHandler(this.hsEditField_Click);
            // 
            // hsDropField
            // 
            this.hsDropField.BackColor = System.Drawing.Color.Transparent;
            this.hsDropField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDropField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDropField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDropField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDropField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDropField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDropField.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsDropField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDropField.FlatAppearance.BorderSize = 0;
            this.hsDropField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDropField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDropField.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsDropField.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDropField.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsDropField.ImageToggleOnSelect = true;
            this.hsDropField.Location = new System.Drawing.Point(100, 0);
            this.hsDropField.Marked = false;
            this.hsDropField.MarkedColor = System.Drawing.Color.Teal;
            this.hsDropField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDropField.MarkedText = "";
            this.hsDropField.MarkMode = false;
            this.hsDropField.Name = "hsDropField";
            this.hsDropField.NonMarkedText = "Drop Field";
            this.hsDropField.Size = new System.Drawing.Size(100, 36);
            this.hsDropField.TabIndex = 4;
            this.hsDropField.Text = "Drop Field";
            this.hsDropField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDropField.ToolTipActive = false;
            this.hsDropField.ToolTipAutomaticDelay = 500;
            this.hsDropField.ToolTipAutoPopDelay = 5000;
            this.hsDropField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDropField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDropField.ToolTipFor4ContextMenu = true;
            this.hsDropField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDropField.ToolTipInitialDelay = 500;
            this.hsDropField.ToolTipIsBallon = false;
            this.hsDropField.ToolTipOwnerDraw = false;
            this.hsDropField.ToolTipReshowDelay = 100;
            this.hsDropField.ToolTipShowAlways = false;
            this.hsDropField.ToolTipText = "";
            this.hsDropField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDropField.ToolTipTitle = "";
            this.hsDropField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDropField.UseVisualStyleBackColor = false;
            this.hsDropField.Click += new System.EventHandler(this.hsDropField_Click);
            // 
            // hsFieldRefresh
            // 
            this.hsFieldRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsFieldRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsFieldRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsFieldRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsFieldRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsFieldRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsFieldRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsFieldRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsFieldRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsFieldRefresh.FlatAppearance.BorderSize = 0;
            this.hsFieldRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsFieldRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsFieldRefresh.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsFieldRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsFieldRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsFieldRefresh.ImageToggleOnSelect = false;
            this.hsFieldRefresh.Location = new System.Drawing.Point(1156, 0);
            this.hsFieldRefresh.Marked = false;
            this.hsFieldRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsFieldRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsFieldRefresh.MarkedText = "";
            this.hsFieldRefresh.MarkMode = false;
            this.hsFieldRefresh.Name = "hsFieldRefresh";
            this.hsFieldRefresh.NonMarkedText = "Refresh Data";
            this.hsFieldRefresh.Size = new System.Drawing.Size(133, 36);
            this.hsFieldRefresh.TabIndex = 3;
            this.hsFieldRefresh.Text = "Refresh Data";
            this.hsFieldRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsFieldRefresh.ToolTipActive = false;
            this.hsFieldRefresh.ToolTipAutomaticDelay = 500;
            this.hsFieldRefresh.ToolTipAutoPopDelay = 5000;
            this.hsFieldRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsFieldRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsFieldRefresh.ToolTipFor4ContextMenu = true;
            this.hsFieldRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsFieldRefresh.ToolTipInitialDelay = 500;
            this.hsFieldRefresh.ToolTipIsBallon = false;
            this.hsFieldRefresh.ToolTipOwnerDraw = false;
            this.hsFieldRefresh.ToolTipReshowDelay = 100;
            this.hsFieldRefresh.ToolTipShowAlways = false;
            this.hsFieldRefresh.ToolTipText = "";
            this.hsFieldRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsFieldRefresh.ToolTipTitle = "";
            this.hsFieldRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsFieldRefresh.UseVisualStyleBackColor = false;
            this.hsFieldRefresh.Click += new System.EventHandler(this.hsRefreshAll_Click_1);
            // 
            // hsNewField
            // 
            this.hsNewField.BackColor = System.Drawing.Color.Transparent;
            this.hsNewField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsNewField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsNewField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsNewField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsNewField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsNewField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsNewField.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsNewField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsNewField.FlatAppearance.BorderSize = 0;
            this.hsNewField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsNewField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsNewField.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsNewField.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsNewField.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsNewField.ImageToggleOnSelect = true;
            this.hsNewField.Location = new System.Drawing.Point(0, 0);
            this.hsNewField.Marked = false;
            this.hsNewField.MarkedColor = System.Drawing.Color.Teal;
            this.hsNewField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNewField.MarkedText = "";
            this.hsNewField.MarkMode = false;
            this.hsNewField.Name = "hsNewField";
            this.hsNewField.NonMarkedText = "Add Field";
            this.hsNewField.Size = new System.Drawing.Size(100, 36);
            this.hsNewField.TabIndex = 1;
            this.hsNewField.Text = "Add Field";
            this.hsNewField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsNewField.ToolTipActive = false;
            this.hsNewField.ToolTipAutomaticDelay = 500;
            this.hsNewField.ToolTipAutoPopDelay = 5000;
            this.hsNewField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsNewField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsNewField.ToolTipFor4ContextMenu = true;
            this.hsNewField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsNewField.ToolTipInitialDelay = 500;
            this.hsNewField.ToolTipIsBallon = false;
            this.hsNewField.ToolTipOwnerDraw = false;
            this.hsNewField.ToolTipReshowDelay = 100;
            this.hsNewField.ToolTipShowAlways = false;
            this.hsNewField.ToolTipText = "";
            this.hsNewField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsNewField.ToolTipTitle = "";
            this.hsNewField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsNewField.UseVisualStyleBackColor = false;
            this.hsNewField.Click += new System.EventHandler(this.hsNewField_Click);
            // 
            // tabPageDATA
            // 
            this.tabPageDATA.Controls.Add(this.dgvResults);
            this.tabPageDATA.Controls.Add(this.gbSQL);
            this.tabPageDATA.Controls.Add(this.pnlDataUpper);
            this.tabPageDATA.ImageKey = "database_gr_24x.png";
            this.tabPageDATA.Location = new System.Drawing.Point(4, 23);
            this.tabPageDATA.Name = "tabPageDATA";
            this.tabPageDATA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDATA.Size = new System.Drawing.Size(1299, 555);
            this.tabPageDATA.TabIndex = 1;
            this.tabPageDATA.Text = "Data";
            this.tabPageDATA.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ContextMenuStrip = this.cmdDATA;
            this.dgvResults.DataSource = this.bsTableContent;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "<null>";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Location = new System.Drawing.Point(3, 97);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1293, 455);
            this.dgvResults.TabIndex = 17;
            this.dgvResults.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dgvResults.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dgvResults.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dgvResults.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvResults_DataError);
            // 
            // cmdDATA
            // 
            this.cmdDATA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmdDATA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDate,
            this.tsmiInsertNow,
            this.toolStripSeparator1,
            this.tsmiInsertGUID,
            this.tsmiInsertGUIDHEX,
            this.toolStripSeparator2,
            this.tsmiSetToNULL,
            this.tsmiInsert0,
            this.tsmiInsert1,
            this.toolStripSeparator3,
            this.tsmiReadBLOB});
            this.cmdDATA.Name = "cmsText";
            this.cmdDATA.Size = new System.Drawing.Size(190, 230);
            this.cmdDATA.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdDATA_ItemClicked);
            // 
            // tsmiDate
            // 
            this.tsmiDate.Image = global::FBXpert.Properties.Resources.calendar01_22x;
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.Size = new System.Drawing.Size(189, 26);
            this.tsmiDate.Text = "DateTime";
            // 
            // tsmiInsertNow
            // 
            this.tsmiInsertNow.Image = global::FBXpert.Properties.Resources.appointment_new_24;
            this.tsmiInsertNow.Name = "tsmiInsertNow";
            this.tsmiInsertNow.Size = new System.Drawing.Size(189, 26);
            this.tsmiInsertNow.Text = "Insert DateTime Now";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiInsertGUID
            // 
            this.tsmiInsertGUID.Image = global::FBXpert.Properties.Resources.font2_x241;
            this.tsmiInsertGUID.Name = "tsmiInsertGUID";
            this.tsmiInsertGUID.Size = new System.Drawing.Size(189, 26);
            this.tsmiInsertGUID.Text = "Insert GUID";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiSetToNULL
            // 
            this.tsmiSetToNULL.Image = global::FBXpert.Properties.Resources.NULL_blue_x24;
            this.tsmiSetToNULL.Name = "tsmiSetToNULL";
            this.tsmiSetToNULL.Size = new System.Drawing.Size(189, 26);
            this.tsmiSetToNULL.Text = "Set to NULL";
            // 
            // tsmiInsert0
            // 
            this.tsmiInsert0.Image = global::FBXpert.Properties.Resources.N0_blue_x24;
            this.tsmiInsert0.Name = "tsmiInsert0";
            this.tsmiInsert0.Size = new System.Drawing.Size(189, 26);
            this.tsmiInsert0.Text = "Set to 0";
            // 
            // tsmiInsert1
            // 
            this.tsmiInsert1.Image = global::FBXpert.Properties.Resources.N1_blue_x24;
            this.tsmiInsert1.Name = "tsmiInsert1";
            this.tsmiInsert1.Size = new System.Drawing.Size(189, 26);
            this.tsmiInsert1.Text = "Set to 1";
            this.tsmiInsert1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiReadBLOB
            // 
            this.tsmiReadBLOB.Image = global::FBXpert.Properties.Resources.bin_x24;
            this.tsmiReadBLOB.Name = "tsmiReadBLOB";
            this.tsmiReadBLOB.Size = new System.Drawing.Size(189, 26);
            this.tsmiReadBLOB.Text = "Read as BLOB";
            // 
            // bsTableContent
            // 
            this.bsTableContent.DataSource = this.dsTableContent;
            this.bsTableContent.Position = 0;
            this.bsTableContent.CurrentItemChanged += new System.EventHandler(this.bindingSource1_CurrentItemChanged);
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
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.txtSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSQL.Location = new System.Drawing.Point(3, 51);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(1293, 46);
            this.gbSQL.TabIndex = 0;
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
            this.txtSQL.Size = new System.Drawing.Size(1287, 20);
            this.txtSQL.TabIndex = 0;
            // 
            // pnlDataUpper
            // 
            this.pnlDataUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDataUpper.Controls.Add(this.gbRowHeight);
            this.pnlDataUpper.Controls.Add(this.hsSaveDataset);
            this.pnlDataUpper.Controls.Add(this.gbEditMode);
            this.pnlDataUpper.Controls.Add(this.gbBnView);
            this.pnlDataUpper.Controls.Add(this.sfbTableData);
            this.pnlDataUpper.Controls.Add(this.hsCancelGettingData);
            this.pnlDataUpper.Controls.Add(this.pnlTableDataAutoRefresh);
            this.pnlDataUpper.Controls.Add(this.hsRefreshData);
            this.pnlDataUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDataUpper.Name = "pnlDataUpper";
            this.pnlDataUpper.Size = new System.Drawing.Size(1293, 48);
            this.pnlDataUpper.TabIndex = 18;
            // 
            // gbRowHeight
            // 
            this.gbRowHeight.Controls.Add(this.txtRowHeight);
            this.gbRowHeight.Controls.Add(this.cbRowManually);
            this.gbRowHeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbRowHeight.Location = new System.Drawing.Point(898, 0);
            this.gbRowHeight.Name = "gbRowHeight";
            this.gbRowHeight.Size = new System.Drawing.Size(79, 44);
            this.gbRowHeight.TabIndex = 36;
            this.gbRowHeight.TabStop = false;
            this.gbRowHeight.Text = "Row height";
            // 
            // txtRowHeight
            // 
            this.txtRowHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRowHeight.Location = new System.Drawing.Point(29, 16);
            this.txtRowHeight.Name = "txtRowHeight";
            this.txtRowHeight.Size = new System.Drawing.Size(47, 20);
            this.txtRowHeight.TabIndex = 30;
            this.txtRowHeight.TextChanged += new System.EventHandler(this.txtRowHeight_TextChanged);
            this.txtRowHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRowHeight_KeyDown);
            // 
            // cbRowManually
            // 
            this.cbRowManually.Checked = true;
            this.cbRowManually.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRowManually.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbRowManually.Location = new System.Drawing.Point(3, 16);
            this.cbRowManually.Name = "cbRowManually";
            this.cbRowManually.Size = new System.Drawing.Size(26, 25);
            this.cbRowManually.TabIndex = 29;
            this.cbRowManually.UseVisualStyleBackColor = true;
            this.cbRowManually.CheckedChanged += new System.EventHandler(this.cbRowManually_CheckedChanged);
            // 
            // hsSaveDataset
            // 
            this.hsSaveDataset.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveDataset.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveDataset.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveDataset.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveDataset.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveDataset.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveDataset.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveDataset.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveDataset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveDataset.FlatAppearance.BorderSize = 0;
            this.hsSaveDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveDataset.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveDataset.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsSaveDataset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveDataset.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsSaveDataset.ImageToggleOnSelect = false;
            this.hsSaveDataset.Location = new System.Drawing.Point(810, 0);
            this.hsSaveDataset.Marked = false;
            this.hsSaveDataset.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveDataset.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveDataset.MarkedText = "";
            this.hsSaveDataset.MarkMode = false;
            this.hsSaveDataset.Name = "hsSaveDataset";
            this.hsSaveDataset.NonMarkedText = "Update";
            this.hsSaveDataset.Size = new System.Drawing.Size(88, 44);
            this.hsSaveDataset.TabIndex = 3;
            this.hsSaveDataset.Text = "Update";
            this.hsSaveDataset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveDataset.ToolTipActive = false;
            this.hsSaveDataset.ToolTipAutomaticDelay = 500;
            this.hsSaveDataset.ToolTipAutoPopDelay = 5000;
            this.hsSaveDataset.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveDataset.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveDataset.ToolTipFor4ContextMenu = true;
            this.hsSaveDataset.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveDataset.ToolTipInitialDelay = 500;
            this.hsSaveDataset.ToolTipIsBallon = false;
            this.hsSaveDataset.ToolTipOwnerDraw = false;
            this.hsSaveDataset.ToolTipReshowDelay = 100;
            this.hsSaveDataset.ToolTipShowAlways = false;
            this.hsSaveDataset.ToolTipText = "";
            this.hsSaveDataset.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveDataset.ToolTipTitle = "";
            this.hsSaveDataset.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveDataset.UseVisualStyleBackColor = false;
            this.hsSaveDataset.Click += new System.EventHandler(this.SaveDataset_Click);
            // 
            // gbEditMode
            // 
            this.gbEditMode.Controls.Add(this.cbEditMode);
            this.gbEditMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbEditMode.Location = new System.Drawing.Point(734, 0);
            this.gbEditMode.Name = "gbEditMode";
            this.gbEditMode.Size = new System.Drawing.Size(76, 44);
            this.gbEditMode.TabIndex = 31;
            this.gbEditMode.TabStop = false;
            this.gbEditMode.Text = "Edit mode";
            // 
            // cbEditMode
            // 
            this.cbEditMode.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEditMode.Checked = true;
            this.cbEditMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEditMode.Location = new System.Drawing.Point(3, 16);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(70, 25);
            this.cbEditMode.TabIndex = 29;
            this.cbEditMode.UseVisualStyleBackColor = true;
            this.cbEditMode.CheckedChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // gbBnView
            // 
            this.gbBnView.Controls.Add(this.bnTableContent);
            this.gbBnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBnView.Location = new System.Drawing.Point(400, 0);
            this.gbBnView.Name = "gbBnView";
            this.gbBnView.Size = new System.Drawing.Size(334, 44);
            this.gbBnView.TabIndex = 30;
            this.gbBnView.TabStop = false;
            this.gbBnView.Text = "Navigator";
            // 
            // bnTableContent
            // 
            this.bnTableContent.AddNewItem = null;
            this.bnTableContent.BindingSource = this.bsTableContent;
            this.bnTableContent.CountItem = this.bnTableContentCountItem;
            this.bnTableContent.DeleteItem = this.bnTableContentDeleteItem;
            this.bnTableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnTableContent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnTableContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnTableContentMoveFirstItem,
            this.bnTableContentMovePreviousItem,
            this.bnTableContentSeparator,
            this.bnTableContentPositionItem,
            this.bnTableContentCountItem,
            this.bnTableContentSeparator1,
            this.bnTableContentMoveNextItem,
            this.bnTableContentMoveLastItem,
            this.bnTableContentSeparator2,
            this.bnTableContentDeleteItem});
            this.bnTableContent.Location = new System.Drawing.Point(3, 16);
            this.bnTableContent.MoveFirstItem = this.bnTableContentMoveFirstItem;
            this.bnTableContent.MoveLastItem = this.bnTableContentMoveLastItem;
            this.bnTableContent.MoveNextItem = this.bnTableContentMoveNextItem;
            this.bnTableContent.MovePreviousItem = this.bnTableContentMovePreviousItem;
            this.bnTableContent.Name = "bnTableContent";
            this.bnTableContent.PositionItem = this.bnTableContentPositionItem;
            this.bnTableContent.Size = new System.Drawing.Size(328, 25);
            this.bnTableContent.TabIndex = 0;
            this.bnTableContent.Text = "bindingNavigator1";
            // 
            // bnTableContentCountItem
            // 
            this.bnTableContentCountItem.Name = "bnTableContentCountItem";
            this.bnTableContentCountItem.Size = new System.Drawing.Size(44, 22);
            this.bnTableContentCountItem.Text = "von {0}";
            this.bnTableContentCountItem.ToolTipText = "Total number of items";
            // 
            // bnTableContentDeleteItem
            // 
            this.bnTableContentDeleteItem.AutoSize = false;
            this.bnTableContentDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentDeleteItem.Image")));
            this.bnTableContentDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnTableContentDeleteItem.Name = "bnTableContentDeleteItem";
            this.bnTableContentDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentDeleteItem.Size = new System.Drawing.Size(82, 33);
            this.bnTableContentDeleteItem.Text = "Delete row";
            this.bnTableContentDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bnTableContentMoveFirstItem
            // 
            this.bnTableContentMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveFirstItem.Image")));
            this.bnTableContentMoveFirstItem.Name = "bnTableContentMoveFirstItem";
            this.bnTableContentMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bnTableContentMoveFirstItem.Text = "Move first";
            // 
            // bnTableContentMovePreviousItem
            // 
            this.bnTableContentMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMovePreviousItem.Image")));
            this.bnTableContentMovePreviousItem.Name = "bnTableContentMovePreviousItem";
            this.bnTableContentMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bnTableContentMovePreviousItem.Text = "Move previous";
            // 
            // bnTableContentSeparator
            // 
            this.bnTableContentSeparator.Name = "bnTableContentSeparator";
            this.bnTableContentSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bnTableContentPositionItem
            // 
            this.bnTableContentPositionItem.AccessibleName = "Position";
            this.bnTableContentPositionItem.AutoSize = false;
            this.bnTableContentPositionItem.Name = "bnTableContentPositionItem";
            this.bnTableContentPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bnTableContentPositionItem.Text = "1";
            this.bnTableContentPositionItem.ToolTipText = "Current position";
            // 
            // bnTableContentSeparator1
            // 
            this.bnTableContentSeparator1.Name = "bnTableContentSeparator1";
            this.bnTableContentSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bnTableContentMoveNextItem
            // 
            this.bnTableContentMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveNextItem.Image")));
            this.bnTableContentMoveNextItem.Name = "bnTableContentMoveNextItem";
            this.bnTableContentMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveNextItem.Size = new System.Drawing.Size(24, 22);
            this.bnTableContentMoveNextItem.Text = "Move next";
            // 
            // bnTableContentMoveLastItem
            // 
            this.bnTableContentMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveLastItem.Image")));
            this.bnTableContentMoveLastItem.Name = "bnTableContentMoveLastItem";
            this.bnTableContentMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveLastItem.Size = new System.Drawing.Size(24, 22);
            this.bnTableContentMoveLastItem.Text = "Move last";
            // 
            // bnTableContentSeparator2
            // 
            this.bnTableContentSeparator2.Name = "bnTableContentSeparator2";
            this.bnTableContentSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sfbTableData
            // 
            this.sfbTableData.Caption = "Spezialfilter";
            this.sfbTableData.cbChecked = false;
            this.sfbTableData.dcFilter = null;
            this.sfbTableData.Dock = System.Windows.Forms.DockStyle.Left;
            this.sfbTableData.EditCaption = "Edit filter";
            this.sfbTableData.EnableEdit = true;
            this.sfbTableData.FilterText = "";
            this.sfbTableData.LoadCaption = "Load filter";
            this.sfbTableData.Location = new System.Drawing.Point(117, 0);
            this.sfbTableData.Name = "sfbTableData";
            this.sfbTableData.PasteCaption = "Paste filter from clipboard";
            this.sfbTableData.Pattern = "";
            this.sfbTableData.SearchMode = SeControlsLib.eSearchMode.NotCaseSensitive;
            this.sfbTableData.ShowCheckbox = false;
            this.sfbTableData.Size = new System.Drawing.Size(283, 44);
            this.sfbTableData.SQLKonjunktion = "AND";
            this.sfbTableData.SQLVorfilterCmd = "";
            this.sfbTableData.TabIndex = 5;
            this.sfbTableData.CbCheckedChanged += new SeControlsLib.cbCheckedChangedHandler(this.spezialfilterBox1_CbCheckedChanged);
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
            this.hsCancelGettingData.Size = new System.Drawing.Size(117, 44);
            this.hsCancelGettingData.TabIndex = 20;
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
            // pnlTableDataAutoRefresh
            // 
            this.pnlTableDataAutoRefresh.Controls.Add(this.cbAutoRefresh);
            this.pnlTableDataAutoRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTableDataAutoRefresh.Location = new System.Drawing.Point(1052, 0);
            this.pnlTableDataAutoRefresh.Name = "pnlTableDataAutoRefresh";
            this.pnlTableDataAutoRefresh.Size = new System.Drawing.Size(110, 44);
            this.pnlTableDataAutoRefresh.TabIndex = 19;
            // 
            // cbAutoRefresh
            // 
            this.cbAutoRefresh.AutoSize = true;
            this.cbAutoRefresh.Checked = true;
            this.cbAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoRefresh.Location = new System.Drawing.Point(21, 13);
            this.cbAutoRefresh.Name = "cbAutoRefresh";
            this.cbAutoRefresh.Size = new System.Drawing.Size(80, 17);
            this.cbAutoRefresh.TabIndex = 4;
            this.cbAutoRefresh.Text = "Autorefresh";
            this.cbAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // hsRefreshData
            // 
            this.hsRefreshData.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshData.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshData.FlatAppearance.BorderSize = 0;
            this.hsRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshData.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshData.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshData.ImageToggleOnSelect = false;
            this.hsRefreshData.Location = new System.Drawing.Point(1162, 0);
            this.hsRefreshData.Marked = false;
            this.hsRefreshData.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshData.MarkedText = "";
            this.hsRefreshData.MarkMode = false;
            this.hsRefreshData.Name = "hsRefreshData";
            this.hsRefreshData.NonMarkedText = "Refresh Data";
            this.hsRefreshData.Size = new System.Drawing.Size(127, 44);
            this.hsRefreshData.TabIndex = 2;
            this.hsRefreshData.Text = "Refresh Data";
            this.hsRefreshData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshData.ToolTipActive = false;
            this.hsRefreshData.ToolTipAutomaticDelay = 500;
            this.hsRefreshData.ToolTipAutoPopDelay = 5000;
            this.hsRefreshData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshData.ToolTipFor4ContextMenu = true;
            this.hsRefreshData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshData.ToolTipInitialDelay = 500;
            this.hsRefreshData.ToolTipIsBallon = false;
            this.hsRefreshData.ToolTipOwnerDraw = false;
            this.hsRefreshData.ToolTipReshowDelay = 100;
            this.hsRefreshData.ToolTipShowAlways = false;
            this.hsRefreshData.ToolTipText = "";
            this.hsRefreshData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshData.ToolTipTitle = "";
            this.hsRefreshData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshData.UseVisualStyleBackColor = false;
            this.hsRefreshData.Click += new System.EventHandler(this.hsRefreshData_Click);
            // 
            // tabDDL
            // 
            this.tabDDL.Controls.Add(this.pnlDDL_CENTER);
            this.tabDDL.Controls.Add(this.pnlDDL_UPPER);
            this.tabDDL.ImageKey = "SQL_blue_x24.png";
            this.tabDDL.Location = new System.Drawing.Point(4, 23);
            this.tabDDL.Name = "tabDDL";
            this.tabDDL.Padding = new System.Windows.Forms.Padding(3);
            this.tabDDL.Size = new System.Drawing.Size(1299, 555);
            this.tabDDL.TabIndex = 2;
            this.tabDDL.Text = "DDL";
            this.tabDDL.UseVisualStyleBackColor = true;
            // 
            // pnlDDL_CENTER
            // 
            this.pnlDDL_CENTER.Controls.Add(this.fctTableCreateDLL);
            this.pnlDDL_CENTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDDL_CENTER.Location = new System.Drawing.Point(3, 43);
            this.pnlDDL_CENTER.Name = "pnlDDL_CENTER";
            this.pnlDDL_CENTER.Size = new System.Drawing.Size(1293, 509);
            this.pnlDDL_CENTER.TabIndex = 1;
            // 
            // fctTableCreateDLL
            // 
            this.fctTableCreateDLL.AutoCompleteBracketsList = new char[] {
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
            this.fctTableCreateDLL.AutoIndentCharsPatterns = "";
            this.fctTableCreateDLL.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctTableCreateDLL.BackBrush = null;
            this.fctTableCreateDLL.CharHeight = 14;
            this.fctTableCreateDLL.CharWidth = 8;
            this.fctTableCreateDLL.CommentPrefix = "--";
            this.fctTableCreateDLL.ContextMenuStrip = this.cmsDDLText;
            this.fctTableCreateDLL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctTableCreateDLL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctTableCreateDLL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctTableCreateDLL.IsReplaceMode = false;
            this.fctTableCreateDLL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctTableCreateDLL.LeftBracket = '(';
            this.fctTableCreateDLL.Location = new System.Drawing.Point(0, 0);
            this.fctTableCreateDLL.Name = "fctTableCreateDLL";
            this.fctTableCreateDLL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctTableCreateDLL.RightBracket = ')';
            this.fctTableCreateDLL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctTableCreateDLL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctTableCreateDLL.ServiceColors")));
            this.fctTableCreateDLL.Size = new System.Drawing.Size(1293, 509);
            this.fctTableCreateDLL.TabIndex = 0;
            this.fctTableCreateDLL.Zoom = 100;
            this.fctTableCreateDLL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctTableCreateDLL_KeyDown);
            // 
            // cmsDDLText
            // 
            this.cmsDDLText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDDLText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDDLCopyToClipboard,
            this.tsmiDDLPaste});
            this.cmsDDLText.Name = "cmsText";
            this.cmsDDLText.Size = new System.Drawing.Size(176, 56);
            this.cmsDDLText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsText_ItemClicked);
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
            // pnlDDL_UPPER
            // 
            this.pnlDDL_UPPER.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDDL_UPPER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDDL_UPPER.Controls.Add(this.gbUsedMilliseconds);
            this.pnlDDL_UPPER.Controls.Add(this.hsLoadSQL);
            this.pnlDDL_UPPER.Controls.Add(this.hsSaveSQL);
            this.pnlDDL_UPPER.Controls.Add(this.hsRunStatement);
            this.pnlDDL_UPPER.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDDL_UPPER.Location = new System.Drawing.Point(3, 3);
            this.pnlDDL_UPPER.Name = "pnlDDL_UPPER";
            this.pnlDDL_UPPER.Size = new System.Drawing.Size(1293, 40);
            this.pnlDDL_UPPER.TabIndex = 0;
            // 
            // gbUsedMilliseconds
            // 
            this.gbUsedMilliseconds.Controls.Add(this.lblUsedMs);
            this.gbUsedMilliseconds.Location = new System.Drawing.Point(361, 3);
            this.gbUsedMilliseconds.Name = "gbUsedMilliseconds";
            this.gbUsedMilliseconds.Size = new System.Drawing.Size(126, 31);
            this.gbUsedMilliseconds.TabIndex = 32;
            this.gbUsedMilliseconds.TabStop = false;
            this.gbUsedMilliseconds.Text = "Costs in milliseconds";
            // 
            // lblUsedMs
            // 
            this.lblUsedMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsedMs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedMs.Location = new System.Drawing.Point(3, 16);
            this.lblUsedMs.Name = "lblUsedMs";
            this.lblUsedMs.Size = new System.Drawing.Size(120, 12);
            this.lblUsedMs.TabIndex = 0;
            this.lblUsedMs.Text = "0";
            this.lblUsedMs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.hsLoadSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQL.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(210, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(124, 36);
            this.hsLoadSQL.TabIndex = 8;
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
            this.hsSaveSQL.Size = new System.Drawing.Size(120, 36);
            this.hsSaveSQL.TabIndex = 7;
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
            this.hsRunStatement.Size = new System.Drawing.Size(90, 36);
            this.hsRunStatement.TabIndex = 6;
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
            this.hsRunStatement.Click += new System.EventHandler(this.hsRunStatement_Click);
            // 
            // tabConstraints
            // 
            this.tabConstraints.Controls.Add(this.pnlCenterConstraints);
            this.tabConstraints.ImageIndex = 11;
            this.tabConstraints.Location = new System.Drawing.Point(4, 23);
            this.tabConstraints.Name = "tabConstraints";
            this.tabConstraints.Padding = new System.Windows.Forms.Padding(3);
            this.tabConstraints.Size = new System.Drawing.Size(1299, 555);
            this.tabConstraints.TabIndex = 3;
            this.tabConstraints.Text = "Constraints";
            this.tabConstraints.UseVisualStyleBackColor = true;
            // 
            // pnlCenterConstraints
            // 
            this.pnlCenterConstraints.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCenterConstraints.Controls.Add(this.hsEditConstraint);
            this.pnlCenterConstraints.Controls.Add(this.hsDropConstraint);
            this.pnlCenterConstraints.Controls.Add(this.hsAddConstraint);
            this.pnlCenterConstraints.Controls.Add(this.tabControlConstraints);
            this.pnlCenterConstraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterConstraints.Location = new System.Drawing.Point(3, 3);
            this.pnlCenterConstraints.Name = "pnlCenterConstraints";
            this.pnlCenterConstraints.Size = new System.Drawing.Size(1293, 549);
            this.pnlCenterConstraints.TabIndex = 3;
            // 
            // hsEditConstraint
            // 
            this.hsEditConstraint.BackColor = System.Drawing.Color.Transparent;
            this.hsEditConstraint.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditConstraint.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsEditConstraint.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditConstraint.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsEditConstraint.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditConstraint.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditConstraint.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsEditConstraint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditConstraint.FlatAppearance.BorderSize = 0;
            this.hsEditConstraint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditConstraint.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEditConstraint.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.hsEditConstraint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsEditConstraint.ImageHover = global::FBXpert.Properties.Resources.format_text_direction_blue_x22;
            this.hsEditConstraint.ImageToggleOnSelect = true;
            this.hsEditConstraint.Location = new System.Drawing.Point(0, 84);
            this.hsEditConstraint.Marked = false;
            this.hsEditConstraint.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditConstraint.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditConstraint.MarkedText = "";
            this.hsEditConstraint.MarkMode = false;
            this.hsEditConstraint.Name = "hsEditConstraint";
            this.hsEditConstraint.NonMarkedText = "Edit Constraint";
            this.hsEditConstraint.Size = new System.Drawing.Size(137, 41);
            this.hsEditConstraint.TabIndex = 21;
            this.hsEditConstraint.Text = "Edit Constraint";
            this.hsEditConstraint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEditConstraint.ToolTipActive = false;
            this.hsEditConstraint.ToolTipAutomaticDelay = 500;
            this.hsEditConstraint.ToolTipAutoPopDelay = 5000;
            this.hsEditConstraint.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEditConstraint.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEditConstraint.ToolTipFor4ContextMenu = true;
            this.hsEditConstraint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEditConstraint.ToolTipInitialDelay = 500;
            this.hsEditConstraint.ToolTipIsBallon = false;
            this.hsEditConstraint.ToolTipOwnerDraw = false;
            this.hsEditConstraint.ToolTipReshowDelay = 100;
            this.hsEditConstraint.ToolTipShowAlways = false;
            this.hsEditConstraint.ToolTipText = "";
            this.hsEditConstraint.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsEditConstraint.ToolTipTitle = "";
            this.hsEditConstraint.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEditConstraint.UseVisualStyleBackColor = false;
            this.hsEditConstraint.Click += new System.EventHandler(this.hsEditConstraint_Click);
            // 
            // hsDropConstraint
            // 
            this.hsDropConstraint.BackColor = System.Drawing.Color.Transparent;
            this.hsDropConstraint.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDropConstraint.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDropConstraint.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDropConstraint.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDropConstraint.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDropConstraint.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDropConstraint.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsDropConstraint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDropConstraint.FlatAppearance.BorderSize = 0;
            this.hsDropConstraint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDropConstraint.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDropConstraint.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsDropConstraint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDropConstraint.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsDropConstraint.ImageToggleOnSelect = true;
            this.hsDropConstraint.Location = new System.Drawing.Point(0, 40);
            this.hsDropConstraint.Marked = false;
            this.hsDropConstraint.MarkedColor = System.Drawing.Color.Teal;
            this.hsDropConstraint.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDropConstraint.MarkedText = "";
            this.hsDropConstraint.MarkMode = false;
            this.hsDropConstraint.Name = "hsDropConstraint";
            this.hsDropConstraint.NonMarkedText = "Drop Constraint";
            this.hsDropConstraint.Size = new System.Drawing.Size(137, 44);
            this.hsDropConstraint.TabIndex = 22;
            this.hsDropConstraint.Text = "Drop Constraint";
            this.hsDropConstraint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDropConstraint.ToolTipActive = false;
            this.hsDropConstraint.ToolTipAutomaticDelay = 500;
            this.hsDropConstraint.ToolTipAutoPopDelay = 5000;
            this.hsDropConstraint.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDropConstraint.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDropConstraint.ToolTipFor4ContextMenu = true;
            this.hsDropConstraint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDropConstraint.ToolTipInitialDelay = 500;
            this.hsDropConstraint.ToolTipIsBallon = false;
            this.hsDropConstraint.ToolTipOwnerDraw = false;
            this.hsDropConstraint.ToolTipReshowDelay = 100;
            this.hsDropConstraint.ToolTipShowAlways = false;
            this.hsDropConstraint.ToolTipText = "";
            this.hsDropConstraint.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDropConstraint.ToolTipTitle = "";
            this.hsDropConstraint.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDropConstraint.UseVisualStyleBackColor = false;
            this.hsDropConstraint.Click += new System.EventHandler(this.hsDropConstraint_Click);
            // 
            // hsAddConstraint
            // 
            this.hsAddConstraint.BackColor = System.Drawing.Color.Transparent;
            this.hsAddConstraint.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddConstraint.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddConstraint.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddConstraint.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddConstraint.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddConstraint.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddConstraint.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsAddConstraint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddConstraint.FlatAppearance.BorderSize = 0;
            this.hsAddConstraint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddConstraint.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddConstraint.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddConstraint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsAddConstraint.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddConstraint.ImageToggleOnSelect = true;
            this.hsAddConstraint.Location = new System.Drawing.Point(0, 0);
            this.hsAddConstraint.Marked = false;
            this.hsAddConstraint.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddConstraint.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddConstraint.MarkedText = "";
            this.hsAddConstraint.MarkMode = false;
            this.hsAddConstraint.Name = "hsAddConstraint";
            this.hsAddConstraint.NonMarkedText = "Add Constraint";
            this.hsAddConstraint.Size = new System.Drawing.Size(137, 40);
            this.hsAddConstraint.TabIndex = 20;
            this.hsAddConstraint.Text = "Add Constraint";
            this.hsAddConstraint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddConstraint.ToolTipActive = false;
            this.hsAddConstraint.ToolTipAutomaticDelay = 500;
            this.hsAddConstraint.ToolTipAutoPopDelay = 5000;
            this.hsAddConstraint.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddConstraint.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddConstraint.ToolTipFor4ContextMenu = true;
            this.hsAddConstraint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddConstraint.ToolTipInitialDelay = 500;
            this.hsAddConstraint.ToolTipIsBallon = false;
            this.hsAddConstraint.ToolTipOwnerDraw = false;
            this.hsAddConstraint.ToolTipReshowDelay = 100;
            this.hsAddConstraint.ToolTipShowAlways = false;
            this.hsAddConstraint.ToolTipText = "";
            this.hsAddConstraint.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddConstraint.ToolTipTitle = "";
            this.hsAddConstraint.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddConstraint.UseVisualStyleBackColor = false;
            this.hsAddConstraint.Click += new System.EventHandler(this.hsAddConstraint_Click);
            // 
            // tabControlConstraints
            // 
            this.tabControlConstraints.Controls.Add(this.tabPagePrimaryKeys);
            this.tabControlConstraints.Controls.Add(this.tabPageForeignKeys);
            this.tabControlConstraints.Controls.Add(this.tabPageUniques);
            this.tabControlConstraints.Controls.Add(this.tabPageChecks);
            this.tabControlConstraints.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlConstraints.ImageList = this.ilTabControl;
            this.tabControlConstraints.Location = new System.Drawing.Point(137, 0);
            this.tabControlConstraints.Name = "tabControlConstraints";
            this.tabControlConstraints.SelectedIndex = 0;
            this.tabControlConstraints.Size = new System.Drawing.Size(1156, 549);
            this.tabControlConstraints.TabIndex = 19;
            this.tabControlConstraints.SelectedIndexChanged += new System.EventHandler(this.tabControlConstraints_SelectedIndexChanged);
            // 
            // tabPagePrimaryKeys
            // 
            this.tabPagePrimaryKeys.Controls.Add(this.dgvPrimaryKeys);
            this.tabPagePrimaryKeys.Controls.Add(this.pnlUpperConstraints);
            this.tabPagePrimaryKeys.ImageIndex = 15;
            this.tabPagePrimaryKeys.Location = new System.Drawing.Point(4, 23);
            this.tabPagePrimaryKeys.Name = "tabPagePrimaryKeys";
            this.tabPagePrimaryKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimaryKeys.Size = new System.Drawing.Size(1148, 522);
            this.tabPagePrimaryKeys.TabIndex = 0;
            this.tabPagePrimaryKeys.Text = "Primary Keys";
            this.tabPagePrimaryKeys.UseVisualStyleBackColor = true;
            // 
            // dgvPrimaryKeys
            // 
            this.dgvPrimaryKeys.AllowUserToAddRows = false;
            this.dgvPrimaryKeys.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            this.dgvPrimaryKeys.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrimaryKeys.AutoGenerateColumns = false;
            this.dgvPrimaryKeys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPrimaryKeys.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPrimaryKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimaryKeys.DataSource = this.bsPrimaryKeys;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrimaryKeys.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrimaryKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrimaryKeys.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPrimaryKeys.EnableHeadersVisualStyles = false;
            this.dgvPrimaryKeys.Location = new System.Drawing.Point(3, 41);
            this.dgvPrimaryKeys.MultiSelect = false;
            this.dgvPrimaryKeys.Name = "dgvPrimaryKeys";
            this.dgvPrimaryKeys.ReadOnly = true;
            this.dgvPrimaryKeys.RowHeadersVisible = false;
            this.dgvPrimaryKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPrimaryKeys.Size = new System.Drawing.Size(1142, 478);
            this.dgvPrimaryKeys.TabIndex = 18;
            // 
            // bsPrimaryKeys
            // 
            this.bsPrimaryKeys.DataSource = this.dsPrimaryKeys;
            this.bsPrimaryKeys.Position = 0;
            this.bsPrimaryKeys.CurrentChanged += new System.EventHandler(this.bsPrimaryKeys_CurrentChanged);
            // 
            // dsPrimaryKeys
            // 
            this.dsPrimaryKeys.DataSetName = "NewDataSet";
            this.dsPrimaryKeys.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table";
            // 
            // pnlUpperConstraints
            // 
            this.pnlUpperConstraints.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpperConstraints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpperConstraints.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperConstraints.Location = new System.Drawing.Point(3, 3);
            this.pnlUpperConstraints.Name = "pnlUpperConstraints";
            this.pnlUpperConstraints.Size = new System.Drawing.Size(1142, 38);
            this.pnlUpperConstraints.TabIndex = 2;
            // 
            // tabPageForeignKeys
            // 
            this.tabPageForeignKeys.Controls.Add(this.dgvForeignKeys);
            this.tabPageForeignKeys.Controls.Add(this.pnlForeignKeysUpper);
            this.tabPageForeignKeys.ImageIndex = 11;
            this.tabPageForeignKeys.Location = new System.Drawing.Point(4, 23);
            this.tabPageForeignKeys.Name = "tabPageForeignKeys";
            this.tabPageForeignKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForeignKeys.Size = new System.Drawing.Size(1148, 522);
            this.tabPageForeignKeys.TabIndex = 1;
            this.tabPageForeignKeys.Text = "Foreign Keys";
            this.tabPageForeignKeys.UseVisualStyleBackColor = true;
            // 
            // dgvForeignKeys
            // 
            this.dgvForeignKeys.AllowUserToAddRows = false;
            this.dgvForeignKeys.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            this.dgvForeignKeys.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvForeignKeys.AutoGenerateColumns = false;
            this.dgvForeignKeys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvForeignKeys.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvForeignKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForeignKeys.DataSource = this.bsForeignKeys;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvForeignKeys.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvForeignKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvForeignKeys.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvForeignKeys.EnableHeadersVisualStyles = false;
            this.dgvForeignKeys.Location = new System.Drawing.Point(3, 40);
            this.dgvForeignKeys.MultiSelect = false;
            this.dgvForeignKeys.Name = "dgvForeignKeys";
            this.dgvForeignKeys.ReadOnly = true;
            this.dgvForeignKeys.RowHeadersVisible = false;
            this.dgvForeignKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvForeignKeys.Size = new System.Drawing.Size(1142, 479);
            this.dgvForeignKeys.TabIndex = 20;
            // 
            // bsForeignKeys
            // 
            this.bsForeignKeys.DataSource = this.dsForeignKeys;
            this.bsForeignKeys.Position = 0;
            this.bsForeignKeys.CurrentChanged += new System.EventHandler(this.bsForeignKeys_CurrentChanged);
            // 
            // dsForeignKeys
            // 
            this.dsForeignKeys.DataSetName = "NewDataSet";
            this.dsForeignKeys.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable4});
            // 
            // dataTable4
            // 
            this.dataTable4.TableName = "Table";
            // 
            // pnlForeignKeysUpper
            // 
            this.pnlForeignKeysUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlForeignKeysUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlForeignKeysUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForeignKeysUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlForeignKeysUpper.Name = "pnlForeignKeysUpper";
            this.pnlForeignKeysUpper.Size = new System.Drawing.Size(1142, 37);
            this.pnlForeignKeysUpper.TabIndex = 19;
            // 
            // tabPageUniques
            // 
            this.tabPageUniques.Controls.Add(this.dgvUniques);
            this.tabPageUniques.Controls.Add(this.pnlUniquesUpper);
            this.tabPageUniques.ImageIndex = 14;
            this.tabPageUniques.Location = new System.Drawing.Point(4, 23);
            this.tabPageUniques.Name = "tabPageUniques";
            this.tabPageUniques.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUniques.Size = new System.Drawing.Size(1148, 522);
            this.tabPageUniques.TabIndex = 2;
            this.tabPageUniques.Text = "Unique";
            this.tabPageUniques.UseVisualStyleBackColor = true;
            // 
            // dgvUniques
            // 
            this.dgvUniques.AllowUserToAddRows = false;
            this.dgvUniques.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Khaki;
            this.dgvUniques.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUniques.AutoGenerateColumns = false;
            this.dgvUniques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUniques.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUniques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniques.DataSource = this.bsUniques;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUniques.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUniques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUniques.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvUniques.EnableHeadersVisualStyles = false;
            this.dgvUniques.Location = new System.Drawing.Point(3, 40);
            this.dgvUniques.MultiSelect = false;
            this.dgvUniques.Name = "dgvUniques";
            this.dgvUniques.ReadOnly = true;
            this.dgvUniques.RowHeadersVisible = false;
            this.dgvUniques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUniques.Size = new System.Drawing.Size(1142, 479);
            this.dgvUniques.TabIndex = 20;
            // 
            // bsUniques
            // 
            this.bsUniques.DataSource = this.dsUniques;
            this.bsUniques.Position = 0;
            this.bsUniques.CurrentChanged += new System.EventHandler(this.bsUniques_CurrentChanged);
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
            // pnlUniquesUpper
            // 
            this.pnlUniquesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUniquesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUniquesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUniquesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlUniquesUpper.Name = "pnlUniquesUpper";
            this.pnlUniquesUpper.Size = new System.Drawing.Size(1142, 37);
            this.pnlUniquesUpper.TabIndex = 19;
            // 
            // tabPageChecks
            // 
            this.tabPageChecks.Controls.Add(this.dgvChecks);
            this.tabPageChecks.Controls.Add(this.pnlChecksUpper);
            this.tabPageChecks.ImageIndex = 13;
            this.tabPageChecks.Location = new System.Drawing.Point(4, 23);
            this.tabPageChecks.Name = "tabPageChecks";
            this.tabPageChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChecks.Size = new System.Drawing.Size(1148, 522);
            this.tabPageChecks.TabIndex = 3;
            this.tabPageChecks.Text = "Checks";
            this.tabPageChecks.UseVisualStyleBackColor = true;
            // 
            // dgvChecks
            // 
            this.dgvChecks.AllowUserToAddRows = false;
            this.dgvChecks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Khaki;
            this.dgvChecks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvChecks.AutoGenerateColumns = false;
            this.dgvChecks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvChecks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChecks.DataSource = this.bsChecks;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChecks.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChecks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvChecks.EnableHeadersVisualStyles = false;
            this.dgvChecks.Location = new System.Drawing.Point(3, 40);
            this.dgvChecks.MultiSelect = false;
            this.dgvChecks.Name = "dgvChecks";
            this.dgvChecks.ReadOnly = true;
            this.dgvChecks.RowHeadersVisible = false;
            this.dgvChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvChecks.Size = new System.Drawing.Size(1142, 479);
            this.dgvChecks.TabIndex = 20;
            // 
            // bsChecks
            // 
            this.bsChecks.DataSource = this.dsChecks;
            this.bsChecks.Position = 0;
            this.bsChecks.CurrentChanged += new System.EventHandler(this.bsChecks_CurrentChanged);
            // 
            // dsChecks
            // 
            this.dsChecks.DataSetName = "NewDataSet";
            this.dsChecks.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable7});
            // 
            // dataTable7
            // 
            this.dataTable7.TableName = "Table";
            // 
            // pnlChecksUpper
            // 
            this.pnlChecksUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChecksUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChecksUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChecksUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlChecksUpper.Name = "pnlChecksUpper";
            this.pnlChecksUpper.Size = new System.Drawing.Size(1142, 37);
            this.pnlChecksUpper.TabIndex = 19;
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
            this.ilTabControl.Images.SetKeyName(11, "foreign_keys_x22.png");
            this.ilTabControl.Images.SetKeyName(12, "ok_gn22x.png");
            this.ilTabControl.Images.SetKeyName(13, "check_constraint_x22.png");
            this.ilTabControl.Images.SetKeyName(14, "N1_blue_x24.png");
            this.ilTabControl.Images.SetKeyName(15, "primary_keys_x22.png");
            // 
            // tabIndicies
            // 
            this.tabIndicies.Controls.Add(this.pnpCenterIndicies);
            this.tabIndicies.Controls.Add(this.pnlUpperIndicies);
            this.tabIndicies.ImageKey = "view-sort-descending_x24.png";
            this.tabIndicies.Location = new System.Drawing.Point(4, 23);
            this.tabIndicies.Name = "tabIndicies";
            this.tabIndicies.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndicies.Size = new System.Drawing.Size(1299, 555);
            this.tabIndicies.TabIndex = 4;
            this.tabIndicies.Text = "Indicies";
            this.tabIndicies.UseVisualStyleBackColor = true;
            // 
            // pnpCenterIndicies
            // 
            this.pnpCenterIndicies.BackColor = System.Drawing.SystemColors.Control;
            this.pnpCenterIndicies.Controls.Add(this.dgvIndicies);
            this.pnpCenterIndicies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnpCenterIndicies.Location = new System.Drawing.Point(3, 43);
            this.pnpCenterIndicies.Name = "pnpCenterIndicies";
            this.pnpCenterIndicies.Size = new System.Drawing.Size(1293, 509);
            this.pnpCenterIndicies.TabIndex = 3;
            // 
            // dgvIndicies
            // 
            this.dgvIndicies.AllowUserToAddRows = false;
            this.dgvIndicies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Khaki;
            this.dgvIndicies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvIndicies.AutoGenerateColumns = false;
            this.dgvIndicies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvIndicies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvIndicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicies.DataSource = this.bsIndicies;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIndicies.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvIndicies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIndicies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIndicies.EnableHeadersVisualStyles = false;
            this.dgvIndicies.Location = new System.Drawing.Point(0, 0);
            this.dgvIndicies.MultiSelect = false;
            this.dgvIndicies.Name = "dgvIndicies";
            this.dgvIndicies.ReadOnly = true;
            this.dgvIndicies.RowHeadersVisible = false;
            this.dgvIndicies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIndicies.Size = new System.Drawing.Size(1293, 509);
            this.dgvIndicies.TabIndex = 19;
            // 
            // bsIndicies
            // 
            this.bsIndicies.DataSource = this.dsIndicies;
            this.bsIndicies.Position = 0;
            this.bsIndicies.CurrentChanged += new System.EventHandler(this.bsIndicies_CurrentChanged);
            // 
            // dsIndicies
            // 
            this.dsIndicies.DataSetName = "NewDataSet";
            this.dsIndicies.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.TableName = "Table";
            // 
            // pnlUpperIndicies
            // 
            this.pnlUpperIndicies.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpperIndicies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpperIndicies.Controls.Add(this.hsEditIndex);
            this.pnlUpperIndicies.Controls.Add(this.hsDropIndex);
            this.pnlUpperIndicies.Controls.Add(this.hsAddIndex);
            this.pnlUpperIndicies.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperIndicies.Location = new System.Drawing.Point(3, 3);
            this.pnlUpperIndicies.Name = "pnlUpperIndicies";
            this.pnlUpperIndicies.Size = new System.Drawing.Size(1293, 40);
            this.pnlUpperIndicies.TabIndex = 2;
            // 
            // hsEditIndex
            // 
            this.hsEditIndex.BackColor = System.Drawing.Color.Transparent;
            this.hsEditIndex.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditIndex.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsEditIndex.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditIndex.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsEditIndex.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditIndex.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsEditIndex.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditIndex.FlatAppearance.BorderSize = 0;
            this.hsEditIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditIndex.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEditIndex.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.hsEditIndex.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsEditIndex.ImageHover = global::FBXpert.Properties.Resources.format_text_direction_blue_x22;
            this.hsEditIndex.ImageToggleOnSelect = true;
            this.hsEditIndex.Location = new System.Drawing.Point(200, 0);
            this.hsEditIndex.Marked = false;
            this.hsEditIndex.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditIndex.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditIndex.MarkedText = "";
            this.hsEditIndex.MarkMode = false;
            this.hsEditIndex.Name = "hsEditIndex";
            this.hsEditIndex.NonMarkedText = "Edit Index";
            this.hsEditIndex.Size = new System.Drawing.Size(100, 36);
            this.hsEditIndex.TabIndex = 6;
            this.hsEditIndex.Text = "Edit Index";
            this.hsEditIndex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEditIndex.ToolTipActive = false;
            this.hsEditIndex.ToolTipAutomaticDelay = 500;
            this.hsEditIndex.ToolTipAutoPopDelay = 5000;
            this.hsEditIndex.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEditIndex.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEditIndex.ToolTipFor4ContextMenu = true;
            this.hsEditIndex.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEditIndex.ToolTipInitialDelay = 500;
            this.hsEditIndex.ToolTipIsBallon = false;
            this.hsEditIndex.ToolTipOwnerDraw = false;
            this.hsEditIndex.ToolTipReshowDelay = 100;
            this.hsEditIndex.ToolTipShowAlways = false;
            this.hsEditIndex.ToolTipText = "";
            this.hsEditIndex.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsEditIndex.ToolTipTitle = "";
            this.hsEditIndex.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEditIndex.UseVisualStyleBackColor = false;
            this.hsEditIndex.Click += new System.EventHandler(this.hsEditIndex_Click);
            // 
            // hsDropIndex
            // 
            this.hsDropIndex.BackColor = System.Drawing.Color.Transparent;
            this.hsDropIndex.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDropIndex.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDropIndex.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDropIndex.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDropIndex.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDropIndex.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDropIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsDropIndex.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDropIndex.FlatAppearance.BorderSize = 0;
            this.hsDropIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDropIndex.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDropIndex.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsDropIndex.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDropIndex.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsDropIndex.ImageToggleOnSelect = true;
            this.hsDropIndex.Location = new System.Drawing.Point(100, 0);
            this.hsDropIndex.Marked = false;
            this.hsDropIndex.MarkedColor = System.Drawing.Color.Teal;
            this.hsDropIndex.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDropIndex.MarkedText = "";
            this.hsDropIndex.MarkMode = false;
            this.hsDropIndex.Name = "hsDropIndex";
            this.hsDropIndex.NonMarkedText = "Drop Index";
            this.hsDropIndex.Size = new System.Drawing.Size(100, 36);
            this.hsDropIndex.TabIndex = 7;
            this.hsDropIndex.Text = "Drop Index";
            this.hsDropIndex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDropIndex.ToolTipActive = false;
            this.hsDropIndex.ToolTipAutomaticDelay = 500;
            this.hsDropIndex.ToolTipAutoPopDelay = 5000;
            this.hsDropIndex.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDropIndex.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDropIndex.ToolTipFor4ContextMenu = true;
            this.hsDropIndex.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDropIndex.ToolTipInitialDelay = 500;
            this.hsDropIndex.ToolTipIsBallon = false;
            this.hsDropIndex.ToolTipOwnerDraw = false;
            this.hsDropIndex.ToolTipReshowDelay = 100;
            this.hsDropIndex.ToolTipShowAlways = false;
            this.hsDropIndex.ToolTipText = "";
            this.hsDropIndex.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDropIndex.ToolTipTitle = "";
            this.hsDropIndex.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDropIndex.UseVisualStyleBackColor = false;
            this.hsDropIndex.Click += new System.EventHandler(this.hsDropIndex_Click);
            // 
            // hsAddIndex
            // 
            this.hsAddIndex.BackColor = System.Drawing.Color.Transparent;
            this.hsAddIndex.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddIndex.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddIndex.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddIndex.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddIndex.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddIndex.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsAddIndex.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddIndex.FlatAppearance.BorderSize = 0;
            this.hsAddIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddIndex.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddIndex.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddIndex.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsAddIndex.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddIndex.ImageToggleOnSelect = true;
            this.hsAddIndex.Location = new System.Drawing.Point(0, 0);
            this.hsAddIndex.Marked = false;
            this.hsAddIndex.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddIndex.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddIndex.MarkedText = "";
            this.hsAddIndex.MarkMode = false;
            this.hsAddIndex.Name = "hsAddIndex";
            this.hsAddIndex.NonMarkedText = "Add Index";
            this.hsAddIndex.Size = new System.Drawing.Size(100, 36);
            this.hsAddIndex.TabIndex = 2;
            this.hsAddIndex.Text = "Add Index";
            this.hsAddIndex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddIndex.ToolTipActive = false;
            this.hsAddIndex.ToolTipAutomaticDelay = 500;
            this.hsAddIndex.ToolTipAutoPopDelay = 5000;
            this.hsAddIndex.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddIndex.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddIndex.ToolTipFor4ContextMenu = true;
            this.hsAddIndex.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddIndex.ToolTipInitialDelay = 500;
            this.hsAddIndex.ToolTipIsBallon = false;
            this.hsAddIndex.ToolTipOwnerDraw = false;
            this.hsAddIndex.ToolTipReshowDelay = 100;
            this.hsAddIndex.ToolTipShowAlways = false;
            this.hsAddIndex.ToolTipText = "";
            this.hsAddIndex.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddIndex.ToolTipTitle = "";
            this.hsAddIndex.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddIndex.UseVisualStyleBackColor = false;
            this.hsAddIndex.Click += new System.EventHandler(this.hsAddIndex_Click);
            // 
            // tabPageDependenciesTo
            // 
            this.tabPageDependenciesTo.Controls.Add(this.dgvDependenciesTo);
            this.tabPageDependenciesTo.Controls.Add(this.pnlDependenciesToUpper);
            this.tabPageDependenciesTo.ImageKey = "go_next_blue24x.png";
            this.tabPageDependenciesTo.Location = new System.Drawing.Point(4, 23);
            this.tabPageDependenciesTo.Name = "tabPageDependenciesTo";
            this.tabPageDependenciesTo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependenciesTo.Size = new System.Drawing.Size(1299, 555);
            this.tabPageDependenciesTo.TabIndex = 6;
            this.tabPageDependenciesTo.Text = "Dependencies";
            this.tabPageDependenciesTo.UseVisualStyleBackColor = true;
            // 
            // dgvDependenciesTo
            // 
            this.dgvDependenciesTo.AllowUserToAddRows = false;
            this.dgvDependenciesTo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Khaki;
            this.dgvDependenciesTo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDependenciesTo.AutoGenerateColumns = false;
            this.dgvDependenciesTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependenciesTo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependenciesTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependenciesTo.DataSource = this.bsDependenciesTo;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependenciesTo.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDependenciesTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependenciesTo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDependenciesTo.EnableHeadersVisualStyles = false;
            this.dgvDependenciesTo.Location = new System.Drawing.Point(3, 43);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1293, 509);
            this.dgvDependenciesTo.TabIndex = 20;
            // 
            // bsDependenciesTo
            // 
            this.bsDependenciesTo.DataSource = this.dsDependenciesTo;
            this.bsDependenciesTo.Position = 0;
            // 
            // dsDependenciesTo
            // 
            this.dsDependenciesTo.DataSetName = "NewDataSet";
            this.dsDependenciesTo.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable5});
            // 
            // dataTable5
            // 
            this.dataTable5.TableName = "Table";
            // 
            // pnlDependenciesToUpper
            // 
            this.pnlDependenciesToUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesToUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDependenciesToUpper.Controls.Add(this.hsRefreshDependenciesTo);
            this.pnlDependenciesToUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesToUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDependenciesToUpper.Name = "pnlDependenciesToUpper";
            this.pnlDependenciesToUpper.Size = new System.Drawing.Size(1293, 40);
            this.pnlDependenciesToUpper.TabIndex = 19;
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
            this.hsRefreshDependenciesTo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependenciesTo.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependenciesTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshDependenciesTo.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependenciesTo.ImageToggleOnSelect = true;
            this.hsRefreshDependenciesTo.Location = new System.Drawing.Point(1188, 0);
            this.hsRefreshDependenciesTo.Marked = false;
            this.hsRefreshDependenciesTo.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependenciesTo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependenciesTo.MarkedText = "";
            this.hsRefreshDependenciesTo.MarkMode = false;
            this.hsRefreshDependenciesTo.Name = "hsRefreshDependenciesTo";
            this.hsRefreshDependenciesTo.NonMarkedText = "Refresh";
            this.hsRefreshDependenciesTo.Size = new System.Drawing.Size(101, 36);
            this.hsRefreshDependenciesTo.TabIndex = 3;
            this.hsRefreshDependenciesTo.Text = "Refresh";
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
            // tabPageDependenciesFrom
            // 
            this.tabPageDependenciesFrom.Controls.Add(this.dgvDependenciesFrom);
            this.tabPageDependenciesFrom.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageDependenciesFrom.ImageKey = "go_previous22x.png";
            this.tabPageDependenciesFrom.Location = new System.Drawing.Point(4, 23);
            this.tabPageDependenciesFrom.Name = "tabPageDependenciesFrom";
            this.tabPageDependenciesFrom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependenciesFrom.Size = new System.Drawing.Size(1299, 555);
            this.tabPageDependenciesFrom.TabIndex = 7;
            this.tabPageDependenciesFrom.Text = "Dependencies From";
            this.tabPageDependenciesFrom.UseVisualStyleBackColor = true;
            // 
            // dgvDependenciesFrom
            // 
            this.dgvDependenciesFrom.AllowUserToAddRows = false;
            this.dgvDependenciesFrom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Khaki;
            this.dgvDependenciesFrom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDependenciesFrom.AutoGenerateColumns = false;
            this.dgvDependenciesFrom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependenciesFrom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependenciesFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependenciesFrom.DataSource = this.bsDependenciesFrom;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependenciesFrom.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDependenciesFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependenciesFrom.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDependenciesFrom.EnableHeadersVisualStyles = false;
            this.dgvDependenciesFrom.Location = new System.Drawing.Point(3, 43);
            this.dgvDependenciesFrom.MultiSelect = false;
            this.dgvDependenciesFrom.Name = "dgvDependenciesFrom";
            this.dgvDependenciesFrom.ReadOnly = true;
            this.dgvDependenciesFrom.RowHeadersVisible = false;
            this.dgvDependenciesFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesFrom.Size = new System.Drawing.Size(1293, 509);
            this.dgvDependenciesFrom.TabIndex = 22;
            // 
            // bsDependenciesFrom
            // 
            this.bsDependenciesFrom.DataSource = this.dsDependenciesFrom;
            this.bsDependenciesFrom.Position = 0;
            // 
            // dsDependenciesFrom
            // 
            this.dsDependenciesFrom.DataSetName = "NewDataSet";
            this.dsDependenciesFrom.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable6});
            // 
            // dataTable6
            // 
            this.dataTable6.TableName = "Table";
            // 
            // pnlDependenciesUpper
            // 
            this.pnlDependenciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDependenciesUpper.Controls.Add(this.hsRefreshDependenciesFrom);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1293, 40);
            this.pnlDependenciesUpper.TabIndex = 21;
            // 
            // hsRefreshDependenciesFrom
            // 
            this.hsRefreshDependenciesFrom.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesFrom.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesFrom.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesFrom.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshDependenciesFrom.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshDependenciesFrom.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshDependenciesFrom.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshDependenciesFrom.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshDependenciesFrom.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshDependenciesFrom.FlatAppearance.BorderSize = 0;
            this.hsRefreshDependenciesFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshDependenciesFrom.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependenciesFrom.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependenciesFrom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshDependenciesFrom.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependenciesFrom.ImageToggleOnSelect = true;
            this.hsRefreshDependenciesFrom.Location = new System.Drawing.Point(1189, 0);
            this.hsRefreshDependenciesFrom.Marked = false;
            this.hsRefreshDependenciesFrom.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependenciesFrom.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependenciesFrom.MarkedText = "";
            this.hsRefreshDependenciesFrom.MarkMode = false;
            this.hsRefreshDependenciesFrom.Name = "hsRefreshDependenciesFrom";
            this.hsRefreshDependenciesFrom.NonMarkedText = "Refresh";
            this.hsRefreshDependenciesFrom.Size = new System.Drawing.Size(100, 36);
            this.hsRefreshDependenciesFrom.TabIndex = 3;
            this.hsRefreshDependenciesFrom.Text = "Refresh";
            this.hsRefreshDependenciesFrom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshDependenciesFrom.ToolTipActive = false;
            this.hsRefreshDependenciesFrom.ToolTipAutomaticDelay = 500;
            this.hsRefreshDependenciesFrom.ToolTipAutoPopDelay = 5000;
            this.hsRefreshDependenciesFrom.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshDependenciesFrom.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshDependenciesFrom.ToolTipFor4ContextMenu = true;
            this.hsRefreshDependenciesFrom.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshDependenciesFrom.ToolTipInitialDelay = 500;
            this.hsRefreshDependenciesFrom.ToolTipIsBallon = false;
            this.hsRefreshDependenciesFrom.ToolTipOwnerDraw = false;
            this.hsRefreshDependenciesFrom.ToolTipReshowDelay = 100;
            this.hsRefreshDependenciesFrom.ToolTipShowAlways = false;
            this.hsRefreshDependenciesFrom.ToolTipText = "";
            this.hsRefreshDependenciesFrom.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDependenciesFrom.ToolTipTitle = "";
            this.hsRefreshDependenciesFrom.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDependenciesFrom.UseVisualStyleBackColor = false;
            this.hsRefreshDependenciesFrom.Click += new System.EventHandler(this.hsRefreshDependenciesFrom_Click);
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.pnlMessagesCenter);
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.ImageKey = "info_blue_22x.png";
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1299, 555);
            this.tabPageMessages.TabIndex = 5;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // pnlMessagesCenter
            // 
            this.pnlMessagesCenter.Controls.Add(this.fctMessages);
            this.pnlMessagesCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessagesCenter.Location = new System.Drawing.Point(3, 43);
            this.pnlMessagesCenter.Name = "pnlMessagesCenter";
            this.pnlMessagesCenter.Size = new System.Drawing.Size(1293, 509);
            this.pnlMessagesCenter.TabIndex = 5;
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
            this.fctMessages.Size = new System.Drawing.Size(1293, 509);
            this.fctMessages.TabIndex = 1;
            this.fctMessages.WordWrap = true;
            this.fctMessages.Zoom = 100;
            // 
            // cmsMessagesText
            // 
            this.cmsMessagesText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMessagesText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMessageCopyToClipboard,
            this.tsmiMessagePaste});
            this.cmsMessagesText.Name = "cmsText";
            this.cmsMessagesText.Size = new System.Drawing.Size(176, 56);
            this.cmsMessagesText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsText_ItemClicked);
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
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1293, 40);
            this.pnlMessagesUpper.TabIndex = 4;
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
            this.hsClearMessages.Size = new System.Drawing.Size(100, 36);
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
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.pnlExportCenter);
            this.tabPageExport.Controls.Add(this.pnlExportBottom);
            this.tabPageExport.Controls.Add(this.pnlExportDataUpper);
            this.tabPageExport.ImageIndex = 10;
            this.tabPageExport.Location = new System.Drawing.Point(4, 23);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(1299, 555);
            this.tabPageExport.TabIndex = 8;
            this.tabPageExport.Text = "Export Data";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // pnlExportCenter
            // 
            this.pnlExportCenter.Controls.Add(this.fcbExport);
            this.pnlExportCenter.Controls.Add(this.dgExportGrid);
            this.pnlExportCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExportCenter.Location = new System.Drawing.Point(3, 43);
            this.pnlExportCenter.Name = "pnlExportCenter";
            this.pnlExportCenter.Size = new System.Drawing.Size(1293, 491);
            this.pnlExportCenter.TabIndex = 3;
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
            this.fcbExport.ContextMenuStrip = this.cmsEXPORTData;
            this.fcbExport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbExport.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbExport.IsReplaceMode = false;
            this.fcbExport.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbExport.LeftBracket = '(';
            this.fcbExport.Location = new System.Drawing.Point(269, 0);
            this.fcbExport.Name = "fcbExport";
            this.fcbExport.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbExport.RightBracket = ')';
            this.fcbExport.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbExport.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbExport.ServiceColors")));
            this.fcbExport.Size = new System.Drawing.Size(1024, 491);
            this.fcbExport.TabIndex = 1;
            this.fcbExport.Zoom = 100;
            // 
            // cmsEXPORTData
            // 
            this.cmsEXPORTData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEXPORTData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEXPORTDataCopyToCLipboard,
            this.tsmiEXPORTDataPasteFromClipboard});
            this.cmsEXPORTData.Name = "cmsText";
            this.cmsEXPORTData.Size = new System.Drawing.Size(176, 56);
            this.cmsEXPORTData.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsText_ItemClicked);
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
            this.dgExportGrid.Location = new System.Drawing.Point(0, 0);
            this.dgExportGrid.Name = "dgExportGrid";
            this.dgExportGrid.RowHeadersVisible = false;
            this.dgExportGrid.Size = new System.Drawing.Size(269, 491);
            this.dgExportGrid.TabIndex = 3;
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
            // pnlExportBottom
            // 
            this.pnlExportBottom.Controls.Add(this.pbExport);
            this.pnlExportBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExportBottom.Location = new System.Drawing.Point(3, 534);
            this.pnlExportBottom.Name = "pnlExportBottom";
            this.pnlExportBottom.Size = new System.Drawing.Size(1293, 18);
            this.pnlExportBottom.TabIndex = 4;
            // 
            // pbExport
            // 
            this.pbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbExport.Location = new System.Drawing.Point(0, 0);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(1293, 18);
            this.pbExport.TabIndex = 0;
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
            this.pnlExportDataUpper.Size = new System.Drawing.Size(1293, 40);
            this.pnlExportDataUpper.TabIndex = 2;
            // 
            // gbExportFile
            // 
            this.gbExportFile.Controls.Add(this.cbCharSet);
            this.gbExportFile.Controls.Add(this.cbExportToFile);
            this.gbExportFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbExportFile.Location = new System.Drawing.Point(389, 0);
            this.gbExportFile.Name = "gbExportFile";
            this.gbExportFile.Size = new System.Drawing.Size(326, 36);
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
            this.cbExportToFile.Size = new System.Drawing.Size(133, 17);
            this.cbExportToFile.TabIndex = 11;
            this.cbExportToFile.Text = "Export to file";
            this.cbExportToFile.UseVisualStyleBackColor = true;
            this.cbExportToFile.CheckedChanged += new System.EventHandler(this.cbExportToFile_CheckedChanged);
            // 
            // cbExportToScreen
            // 
            this.cbExportToScreen.Checked = true;
            this.cbExportToScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportToScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbExportToScreen.Location = new System.Drawing.Point(240, 0);
            this.cbExportToScreen.Name = "cbExportToScreen";
            this.cbExportToScreen.Size = new System.Drawing.Size(149, 36);
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
            this.gbInsertUpdate.Location = new System.Drawing.Point(826, 0);
            this.gbInsertUpdate.Name = "gbInsertUpdate";
            this.gbInsertUpdate.Size = new System.Drawing.Size(330, 36);
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
            this.hsCancelExport.Size = new System.Drawing.Size(140, 36);
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
            this.hsCancelExport.Click += new System.EventHandler(this.hsCancelExport_Click);
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
            this.hsExportData.Size = new System.Drawing.Size(100, 36);
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
            this.hsRefreshExportData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshExportData.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshExportData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshExportData.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshExportData.ImageToggleOnSelect = false;
            this.hsRefreshExportData.Location = new System.Drawing.Point(1156, 0);
            this.hsRefreshExportData.Marked = false;
            this.hsRefreshExportData.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshExportData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshExportData.MarkedText = "";
            this.hsRefreshExportData.MarkMode = false;
            this.hsRefreshExportData.Name = "hsRefreshExportData";
            this.hsRefreshExportData.NonMarkedText = "Refresh Data";
            this.hsRefreshExportData.Size = new System.Drawing.Size(133, 36);
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
            // tabPageTablestatistics
            // 
            this.tabPageTablestatistics.Controls.Add(this.fctTableStatistics);
            this.tabPageTablestatistics.Controls.Add(this.pnlUpperStatistics);
            this.tabPageTablestatistics.Location = new System.Drawing.Point(4, 23);
            this.tabPageTablestatistics.Name = "tabPageTablestatistics";
            this.tabPageTablestatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTablestatistics.Size = new System.Drawing.Size(1299, 555);
            this.tabPageTablestatistics.TabIndex = 9;
            this.tabPageTablestatistics.Text = "Table Statistics";
            this.tabPageTablestatistics.UseVisualStyleBackColor = true;
            // 
            // fctTableStatistics
            // 
            this.fctTableStatistics.AutoCompleteBracketsList = new char[] {
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
            this.fctTableStatistics.AutoIndentCharsPatterns = "";
            this.fctTableStatistics.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctTableStatistics.BackBrush = null;
            this.fctTableStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctTableStatistics.CharHeight = 14;
            this.fctTableStatistics.CharWidth = 7;
            this.fctTableStatistics.CommentPrefix = "--";
            this.fctTableStatistics.ContextMenuStrip = this.cmsMessagesText;
            this.fctTableStatistics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctTableStatistics.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctTableStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctTableStatistics.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctTableStatistics.IsReplaceMode = false;
            this.fctTableStatistics.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctTableStatistics.LeftBracket = '(';
            this.fctTableStatistics.Location = new System.Drawing.Point(3, 43);
            this.fctTableStatistics.Name = "fctTableStatistics";
            this.fctTableStatistics.Paddings = new System.Windows.Forms.Padding(0);
            this.fctTableStatistics.ReadOnly = true;
            this.fctTableStatistics.RightBracket = ')';
            this.fctTableStatistics.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctTableStatistics.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctTableStatistics.ServiceColors")));
            this.fctTableStatistics.Size = new System.Drawing.Size(1293, 509);
            this.fctTableStatistics.TabIndex = 21;
            this.fctTableStatistics.WordWrap = true;
            this.fctTableStatistics.Zoom = 100;
            // 
            // pnlUpperStatistics
            // 
            this.pnlUpperStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpperStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpperStatistics.Controls.Add(this.hsRefreshTableStatistics);
            this.pnlUpperStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperStatistics.Location = new System.Drawing.Point(3, 3);
            this.pnlUpperStatistics.Name = "pnlUpperStatistics";
            this.pnlUpperStatistics.Size = new System.Drawing.Size(1293, 40);
            this.pnlUpperStatistics.TabIndex = 20;
            // 
            // hsRefreshTableStatistics
            // 
            this.hsRefreshTableStatistics.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshTableStatistics.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshTableStatistics.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshTableStatistics.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshTableStatistics.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshTableStatistics.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshTableStatistics.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshTableStatistics.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshTableStatistics.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshTableStatistics.FlatAppearance.BorderSize = 0;
            this.hsRefreshTableStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshTableStatistics.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshTableStatistics.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshTableStatistics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshTableStatistics.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshTableStatistics.ImageToggleOnSelect = true;
            this.hsRefreshTableStatistics.Location = new System.Drawing.Point(1188, 0);
            this.hsRefreshTableStatistics.Marked = false;
            this.hsRefreshTableStatistics.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshTableStatistics.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshTableStatistics.MarkedText = "";
            this.hsRefreshTableStatistics.MarkMode = false;
            this.hsRefreshTableStatistics.Name = "hsRefreshTableStatistics";
            this.hsRefreshTableStatistics.NonMarkedText = "Refresh";
            this.hsRefreshTableStatistics.Size = new System.Drawing.Size(101, 36);
            this.hsRefreshTableStatistics.TabIndex = 3;
            this.hsRefreshTableStatistics.Text = "Refresh";
            this.hsRefreshTableStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshTableStatistics.ToolTipActive = false;
            this.hsRefreshTableStatistics.ToolTipAutomaticDelay = 500;
            this.hsRefreshTableStatistics.ToolTipAutoPopDelay = 5000;
            this.hsRefreshTableStatistics.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshTableStatistics.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshTableStatistics.ToolTipFor4ContextMenu = true;
            this.hsRefreshTableStatistics.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshTableStatistics.ToolTipInitialDelay = 500;
            this.hsRefreshTableStatistics.ToolTipIsBallon = false;
            this.hsRefreshTableStatistics.ToolTipOwnerDraw = false;
            this.hsRefreshTableStatistics.ToolTipReshowDelay = 100;
            this.hsRefreshTableStatistics.ToolTipShowAlways = false;
            this.hsRefreshTableStatistics.ToolTipText = "";
            this.hsRefreshTableStatistics.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshTableStatistics.ToolTipTitle = "";
            this.hsRefreshTableStatistics.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshTableStatistics.UseVisualStyleBackColor = false;
            this.hsRefreshTableStatistics.Click += new System.EventHandler(this.hsRefreshTableStatistics_Click);
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.gbMaxAllowedErrors);
            this.pnlUpper.Controls.Add(this.gbMaxRows);
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsPageRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1307, 48);
            this.pnlUpper.TabIndex = 1;
            // 
            // gbMaxAllowedErrors
            // 
            this.gbMaxAllowedErrors.Controls.Add(this.txtMaxAllowedErrors);
            this.gbMaxAllowedErrors.Location = new System.Drawing.Point(539, 4);
            this.gbMaxAllowedErrors.Name = "gbMaxAllowedErrors";
            this.gbMaxAllowedErrors.Size = new System.Drawing.Size(116, 41);
            this.gbMaxAllowedErrors.TabIndex = 6;
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
            this.gbMaxRows.Controls.Add(this.hsRefreshMaxRows);
            this.gbMaxRows.Controls.Add(this.txtMaxRows);
            this.gbMaxRows.Location = new System.Drawing.Point(676, 3);
            this.gbMaxRows.Name = "gbMaxRows";
            this.gbMaxRows.Size = new System.Drawing.Size(146, 41);
            this.gbMaxRows.TabIndex = 3;
            this.gbMaxRows.TabStop = false;
            this.gbMaxRows.Text = "Max Rows";
            // 
            // hsRefreshMaxRows
            // 
            this.hsRefreshMaxRows.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshMaxRows.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshMaxRows.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshMaxRows.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshMaxRows.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshMaxRows.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshMaxRows.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshMaxRows.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshMaxRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshMaxRows.FlatAppearance.BorderSize = 0;
            this.hsRefreshMaxRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshMaxRows.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshMaxRows.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshMaxRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRefreshMaxRows.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshMaxRows.ImageToggleOnSelect = false;
            this.hsRefreshMaxRows.Location = new System.Drawing.Point(112, 16);
            this.hsRefreshMaxRows.Marked = false;
            this.hsRefreshMaxRows.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshMaxRows.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshMaxRows.MarkedText = "";
            this.hsRefreshMaxRows.MarkMode = false;
            this.hsRefreshMaxRows.Name = "hsRefreshMaxRows";
            this.hsRefreshMaxRows.NonMarkedText = "";
            this.hsRefreshMaxRows.Size = new System.Drawing.Size(31, 22);
            this.hsRefreshMaxRows.TabIndex = 4;
            this.hsRefreshMaxRows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshMaxRows.ToolTipActive = false;
            this.hsRefreshMaxRows.ToolTipAutomaticDelay = 500;
            this.hsRefreshMaxRows.ToolTipAutoPopDelay = 5000;
            this.hsRefreshMaxRows.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshMaxRows.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshMaxRows.ToolTipFor4ContextMenu = true;
            this.hsRefreshMaxRows.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshMaxRows.ToolTipInitialDelay = 500;
            this.hsRefreshMaxRows.ToolTipIsBallon = false;
            this.hsRefreshMaxRows.ToolTipOwnerDraw = false;
            this.hsRefreshMaxRows.ToolTipReshowDelay = 100;
            this.hsRefreshMaxRows.ToolTipShowAlways = false;
            this.hsRefreshMaxRows.ToolTipText = "";
            this.hsRefreshMaxRows.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshMaxRows.ToolTipTitle = "";
            this.hsRefreshMaxRows.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshMaxRows.UseVisualStyleBackColor = false;
            this.hsRefreshMaxRows.Click += new System.EventHandler(this.hsRefreshMaxRows_Click);
            // 
            // txtMaxRows
            // 
            this.txtMaxRows.Location = new System.Drawing.Point(10, 16);
            this.txtMaxRows.Name = "txtMaxRows";
            this.txtMaxRows.Size = new System.Drawing.Size(100, 20);
            this.txtMaxRows.TabIndex = 0;
            this.txtMaxRows.Text = "10000";
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
            this.hsPageRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPageRefresh.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsPageRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPageRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsPageRefresh.ImageToggleOnSelect = true;
            this.hsPageRefresh.Location = new System.Drawing.Point(1218, 0);
            this.hsPageRefresh.Marked = false;
            this.hsPageRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsPageRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPageRefresh.MarkedText = "";
            this.hsPageRefresh.MarkMode = false;
            this.hsPageRefresh.Name = "hsPageRefresh";
            this.hsPageRefresh.NonMarkedText = "Refresh";
            this.hsPageRefresh.Size = new System.Drawing.Size(89, 48);
            this.hsPageRefresh.TabIndex = 1;
            this.hsPageRefresh.Text = "Refresh";
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
            this.hsClose.Size = new System.Drawing.Size(45, 48);
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
            this.pnlCenter.Controls.Add(this.tabControl);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 48);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1307, 582);
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
            // tsmiInsertGUIDHEX
            // 
            this.tsmiInsertGUIDHEX.Image = global::FBXpert.Properties.Resources.font_x24;
            this.tsmiInsertGUIDHEX.Name = "tsmiInsertGUIDHEX";
            this.tsmiInsertGUIDHEX.Size = new System.Drawing.Size(189, 26);
            this.tsmiInsertGUIDHEX.Text = "Insert GUID-HEX";
            // 
            // TABLEManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 630);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TABLEManageForm";
            this.Text = "TABLEManageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TABLEManageForm_FormClosing);
            this.Load += new System.EventHandler(this.TABLEManageForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageFIELDS.ResumeLayout(false);
            this.pnlTableFieldCenter.ResumeLayout(false);
            this.pnlTableFieldUpper.ResumeLayout(false);
            this.tabPageDATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.cmdDATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTableContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTableContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.gbSQL.ResumeLayout(false);
            this.gbSQL.PerformLayout();
            this.pnlDataUpper.ResumeLayout(false);
            this.gbRowHeight.ResumeLayout(false);
            this.gbRowHeight.PerformLayout();
            this.gbEditMode.ResumeLayout(false);
            this.gbBnView.ResumeLayout(false);
            this.gbBnView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTableContent)).EndInit();
            this.bnTableContent.ResumeLayout(false);
            this.bnTableContent.PerformLayout();
            this.pnlTableDataAutoRefresh.ResumeLayout(false);
            this.pnlTableDataAutoRefresh.PerformLayout();
            this.tabDDL.ResumeLayout(false);
            this.pnlDDL_CENTER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctTableCreateDLL)).EndInit();
            this.cmsDDLText.ResumeLayout(false);
            this.pnlDDL_UPPER.ResumeLayout(false);
            this.gbUsedMilliseconds.ResumeLayout(false);
            this.tabConstraints.ResumeLayout(false);
            this.pnlCenterConstraints.ResumeLayout(false);
            this.tabControlConstraints.ResumeLayout(false);
            this.tabPagePrimaryKeys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrimaryKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrimaryKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.tabPageForeignKeys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForeignKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForeignKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForeignKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).EndInit();
            this.tabPageUniques.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUniques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUniques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.tabPageChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable7)).EndInit();
            this.tabIndicies.ResumeLayout(false);
            this.pnpCenterIndicies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIndicies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIndicies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.pnlUpperIndicies.ResumeLayout(false);
            this.tabPageDependenciesTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.pnlDependenciesToUpper.ResumeLayout(false);
            this.tabPageDependenciesFrom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).EndInit();
            this.pnlDependenciesUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            this.pnlMessagesCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.cmsMessagesText.ResumeLayout(false);
            this.pnlMessagesUpper.ResumeLayout(false);
            this.tabPageExport.ResumeLayout(false);
            this.pnlExportCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbExport)).EndInit();
            this.cmsEXPORTData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExportGrid)).EndInit();
            this.pnlExportBottom.ResumeLayout(false);
            this.pnlExportDataUpper.ResumeLayout(false);
            this.gbExportFile.ResumeLayout(false);
            this.gbInsertUpdate.ResumeLayout(false);
            this.gbInsertUpdate.PerformLayout();
            this.tabPageTablestatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctTableStatistics)).EndInit();
            this.pnlUpperStatistics.ResumeLayout(false);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.gbMaxAllowedErrors.ResumeLayout(false);
            this.gbMaxAllowedErrors.PerformLayout();
            this.gbMaxRows.ResumeLayout(false);
            this.gbMaxRows.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFIELDS;
        private System.Windows.Forms.ListView lvFields;
        private System.Windows.Forms.ColumnHeader colFIELDNAME;
        private System.Windows.Forms.TabPage tabPageDATA;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsPageRefresh;
        private System.Windows.Forms.ColumnHeader colFIELDPOSITION;
        private System.Windows.Forms.ColumnHeader colTYPE;
        private System.Windows.Forms.ColumnHeader colLENGTH;
        private System.Windows.Forms.ColumnHeader colFIELDNOTNULL;
        private System.Windows.Forms.BindingSource bsTableContent;
        private System.Data.DataSet dsTableContent;
        private System.Data.DataTable Table;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel pnlDataUpper;
        private SeControlsLib.HotSpot hsRefreshData;
        private System.Windows.Forms.TabPage tabDDL;
        private System.Windows.Forms.Panel pnlDDL_CENTER;
        private System.Windows.Forms.Panel pnlDDL_UPPER;
        private System.Windows.Forms.BindingNavigator bnTableContent;
        private System.Windows.Forms.ToolStripLabel bnTableContentCountItem;
        private System.Windows.Forms.ToolStripButton bnTableContentDeleteItem;
        private System.Windows.Forms.ToolStripButton bnTableContentMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bnTableContentMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bnTableContentSeparator;
        private System.Windows.Forms.ToolStripTextBox bnTableContentPositionItem;
        private System.Windows.Forms.ToolStripSeparator bnTableContentSeparator1;
        private System.Windows.Forms.ToolStripButton bnTableContentMoveNextItem;
        private System.Windows.Forms.ToolStripButton bnTableContentMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bnTableContentSeparator2;
        private System.Windows.Forms.ColumnHeader colRAWTYPE;
        private System.Windows.Forms.ColumnHeader colDOMAINDEFAULTVALUE;
        private System.Windows.Forms.ColumnHeader colSCALE;
        private SeControlsLib.HotSpot hsSaveDataset;
        private System.Windows.Forms.CheckBox cbAutoRefresh;
        private System.Windows.Forms.ColumnHeader colPRIMARY;
        private System.Windows.Forms.ColumnHeader colUNIQUE;
        private SeControlsLib.SpezialfilterBox sfbTableData;
        private System.Windows.Forms.Panel pnlTableDataAutoRefresh;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel pnlTableFieldCenter;
        private System.Windows.Forms.Panel pnlTableFieldUpper;
        private SeControlsLib.HotSpot hsNewField;
        private SeControlsLib.HotSpot hsFieldRefresh;
        private FastColoredTextBoxNS.FastColoredTextBox fctTableCreateDLL;
        private System.Windows.Forms.ColumnHeader colCHARSET;
        private System.Windows.Forms.ColumnHeader colCOLLATE;
        private System.Windows.Forms.ColumnHeader colFK;
        private System.Windows.Forms.TabPage tabConstraints;
        private System.Windows.Forms.TabPage tabIndicies;
        private System.Windows.Forms.Panel pnlCenterConstraints;
        private System.Windows.Forms.DataGridView dgvPrimaryKeys;
        private System.Windows.Forms.BindingSource bsPrimaryKeys;
        private System.Data.DataSet dsPrimaryKeys;
        private System.Data.DataTable dataTable1;
        private System.Windows.Forms.Panel pnlUpperConstraints;
        private System.Windows.Forms.Panel pnpCenterIndicies;
        private System.Windows.Forms.DataGridView dgvIndicies;
        private System.Windows.Forms.BindingSource bsIndicies;
        private System.Data.DataSet dsIndicies;
        private System.Data.DataTable dataTable2;
        private System.Windows.Forms.Panel pnlUpperIndicies;
        private SeControlsLib.HotSpot hsDropField;
        private SeControlsLib.HotSpot hsEditField;
        private System.Windows.Forms.TabControl tabControlConstraints;
        private System.Windows.Forms.TabPage tabPagePrimaryKeys;
        private System.Windows.Forms.TabPage tabPageForeignKeys;
        private System.Windows.Forms.DataGridView dgvForeignKeys;
        private System.Windows.Forms.Panel pnlForeignKeysUpper;
        private System.Windows.Forms.TabPage tabPageUniques;
        private System.Windows.Forms.DataGridView dgvUniques;
        private System.Windows.Forms.Panel pnlUniquesUpper;
        private System.Windows.Forms.TabPage tabPageChecks;
        private System.Windows.Forms.DataGridView dgvChecks;
        private System.Windows.Forms.Panel pnlChecksUpper;
        private System.Windows.Forms.ColumnHeader colDOMAINNAME;
        private System.Windows.Forms.ColumnHeader colDOMAINNOTNULL;
        private System.Windows.Forms.ColumnHeader colFIELDDEFAULTVALUE;
        private System.Windows.Forms.BindingSource bsUniques;
        private System.Data.DataSet dsUniques;
        private System.Data.DataTable dataTable3;
        private System.Windows.Forms.BindingSource bsForeignKeys;
        private System.Data.DataSet dsForeignKeys;
        private System.Data.DataTable dataTable4;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.Panel pnlMessagesCenter;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsClearMessages;
        private System.Windows.Forms.ContextMenuStrip cmsDDLText;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLPaste;
        private System.Windows.Forms.ContextMenuStrip cmsMessagesText;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessageCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessagePaste;
        private System.Windows.Forms.TabPage tabPageDependenciesTo;
        private System.Windows.Forms.DataGridView dgvDependenciesTo;
        private System.Windows.Forms.BindingSource bsDependenciesTo;
        private System.Data.DataSet dsDependenciesTo;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Panel pnlDependenciesToUpper;
        private System.Windows.Forms.TabPage tabPageDependenciesFrom;
        private SeControlsLib.HotSpot hsRefreshDependenciesTo;
        private System.Windows.Forms.DataGridView dgvDependenciesFrom;
        private System.Windows.Forms.BindingSource bsDependenciesFrom;
        private System.Data.DataSet dsDependenciesFrom;
        private System.Data.DataTable dataTable6;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hsRefreshDependenciesFrom;
        private System.Windows.Forms.ImageList ilTabControl;
        private SeControlsLib.HotSpot hsAddIndex;
        private SeControlsLib.HotSpot hsCancelGettingData;
        private System.Windows.Forms.ContextMenuStrip cmdDATA;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetToNULL;
        private System.Windows.Forms.ToolStripMenuItem tsmiDate;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private SeControlsLib.HotSpot hsRunStatement;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.Panel pnlExportCenter;
        private System.Windows.Forms.Panel pnlExportDataUpper;
        private SeControlsLib.HotSpot hsRefreshExportData;
        private SeControlsLib.HotSpot hsExportData;
        private FastColoredTextBoxNS.FastColoredTextBox fcbExport;
        private System.Windows.Forms.GroupBox gbInsertUpdate;
        private System.Windows.Forms.RadioButton rbUPDATE;
        private System.Windows.Forms.RadioButton rbINSERTUPDATE;
        private System.Windows.Forms.RadioButton rbINSERT;
        private System.Windows.Forms.DataGridView dgExportGrid;
        private System.Windows.Forms.CheckBox cbExportToScreen;
        private System.Windows.Forms.CheckBox cbExportToFile;
        private System.Windows.Forms.Panel pnlExportBottom;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.ComponentModel.BackgroundWorker bwExport;
        private SeControlsLib.HotSpot hsCancelExport;
        private System.Windows.Forms.GroupBox gbExportFile;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExportFieldName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExportActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExportWhere;
        private System.Windows.Forms.ContextMenuStrip cmsEXPORTData;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXPORTDataCopyToCLipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXPORTDataPasteFromClipboard;
        private System.Windows.Forms.CheckBox cbEditMode;
        private SeControlsLib.HotSpot hsDropIndex;
        private SeControlsLib.HotSpot hsEditIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertGUID;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertNow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsert0;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsert1;
        private System.Windows.Forms.GroupBox gbMaxRows;
        private System.Windows.Forms.TextBox txtMaxRows;
        private SeControlsLib.HotSpot hsRefreshMaxRows;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.GroupBox gbBnView;
        private System.Windows.Forms.GroupBox gbUsedMilliseconds;
        private System.Windows.Forms.Label lblUsedMs;
        private System.Windows.Forms.TabPage tabPageTablestatistics;
        private FastColoredTextBoxNS.FastColoredTextBox fctTableStatistics;
        private System.Windows.Forms.Panel pnlUpperStatistics;
        private SeControlsLib.HotSpot hsRefreshTableStatistics;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadBLOB;
        private System.Windows.Forms.GroupBox gbMaxAllowedErrors;
        private System.Windows.Forms.TextBox txtMaxAllowedErrors;
        private System.Windows.Forms.GroupBox gbEditMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private SeControlsLib.HotSpot hsEditConstraint;
        private SeControlsLib.HotSpot hsDropConstraint;
        private SeControlsLib.HotSpot hsAddConstraint;
        private System.Windows.Forms.BindingSource bsChecks;
        private System.Data.DataSet dsChecks;
        private System.Data.DataTable dataTable7;
        private System.Windows.Forms.GroupBox gbRowHeight;
        private System.Windows.Forms.TextBox txtRowHeight;
        private System.Windows.Forms.CheckBox cbRowManually;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertGUIDHEX;
    }
}