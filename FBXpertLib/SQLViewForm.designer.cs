using BasicForms;
using System.ComponentModel;
using System.Windows.Forms;

namespace SQLView
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    public partial class SQLViewForm2 : BasicNormalFormClass
    {
        private System.Windows.Forms.Panel pnlFormUpper;
        private System.Windows.Forms.Panel pnl_center;


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer erzeugter Code
        /// <summary>
        /// Erforderliche Methode zur Unterstützung des Designers -
        /// ändern Sie die Methode nicht mit dem Quelltext-Editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLViewForm2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormUpper = new System.Windows.Forms.Panel();
            this.hsLifeTime = new SeControlsLib.HotSpot();
            this.bnConnection = new System.Windows.Forms.GroupBox();
            this.cbConnection = new System.Windows.Forms.ComboBox();
            this.hsPageRefresh = new SeControlsLib.HotSpot();
            this.gnUsedTime = new System.Windows.Forms.GroupBox();
            this.txtUsedTime = new System.Windows.Forms.TextBox();
            this.hsClose = new SeControlsLib.HotSpot();
            this.cbTestlauf = new System.Windows.Forms.CheckBox();
            this.cbHistory = new System.Windows.Forms.CheckBox();
            this.cbErrors = new System.Windows.Forms.CheckBox();
            this.cbMeldungen = new System.Windows.Forms.CheckBox();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.tcSQLCONTROL = new System.Windows.Forms.TabControl();
            this.tabSQLTEXT = new System.Windows.Forms.TabPage();
            this.pnlSQLCenter = new System.Windows.Forms.Panel();
            this.txtSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsSQLText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDDLCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDDLPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLastCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertLastSuccessfullCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExecuteLastSucessfullCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertPK = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.ckShowResults = new System.Windows.Forms.CheckBox();
            this.hsBreak = new SeControlsLib.HotSpot();
            this.hsReplaceText = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsRunSQLfromFile = new SeControlsLib.HotSpot();
            this.hsClearText = new SeControlsLib.HotSpot();
            this.hsRunSQL = new SeControlsLib.HotSpot();
            this.gbEncoding = new System.Windows.Forms.GroupBox();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.pbRunSQL = new System.Windows.Forms.ProgressBar();
            this.tabRESULT = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cmdDATA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSpaltenEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertNow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiInsertGUID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertGUIDHEX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetToNULL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReadBLOB = new System.Windows.Forms.ToolStripMenuItem();
            this.bsResults = new System.Windows.Forms.BindingSource(this.components);
            this.dsResults = new System.Data.DataSet();
            this.Table = new System.Data.DataTable();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlResultUpper = new System.Windows.Forms.Panel();
            this.gbRowHeight = new System.Windows.Forms.GroupBox();
            this.txtRowHeight = new System.Windows.Forms.TextBox();
            this.cbRowManually = new System.Windows.Forms.CheckBox();
            this.hsUpdateDataset = new SeControlsLib.HotSpot();
            this.gbEditMode = new System.Windows.Forms.GroupBox();
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            this.gbNavigator = new System.Windows.Forms.GroupBox();
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
            this.gbUsedMilliseconds = new System.Windows.Forms.GroupBox();
            this.lblUsedMs = new System.Windows.Forms.Label();
            this.pnlWatch = new System.Windows.Forms.Panel();
            this.tabMELDUNG = new System.Windows.Forms.TabPage();
            this.pnlInfoCenter = new System.Windows.Forms.Panel();
            this.rtfMELDUNG = new System.Windows.Forms.RichTextBox();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hsClearInfo = new SeControlsLib.HotSpot();
            this.cbAutoScroll = new System.Windows.Forms.CheckBox();
            this.tabERRORS = new System.Windows.Forms.TabPage();
            this.pnlErrorUpper = new System.Windows.Forms.Panel();
            this.rtfERRORS = new System.Windows.Forms.RichTextBox();
            this.pnlErrorsUpper = new System.Windows.Forms.Panel();
            this.cbAutoSrcollErr = new System.Windows.Forms.CheckBox();
            this.hsClearErrorAll = new SeControlsLib.HotSpot();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.pnlHistoryCenter = new System.Windows.Forms.Panel();
            this.dgvSQLHistory = new System.Windows.Forms.DataGridView();
            this.cmsHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiHistoryCopyToSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistoryExecuteSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteHistoryEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHistoryUpper = new System.Windows.Forms.Panel();
            this.hsClearHistory = new SeControlsLib.HotSpot();
            this.cbSQLfailed = new System.Windows.Forms.CheckBox();
            this.cbSQLsucceded = new System.Windows.Forms.CheckBox();
            this.cbAllHistory = new System.Windows.Forms.CheckBox();
            this.hsRefreshHistory = new SeControlsLib.HotSpot();
            this.hsExecuteHistorySelected = new SeControlsLib.HotSpot();
            this.tabRelpacelist = new System.Windows.Forms.TabPage();
            this.pnlReplacesCenter = new System.Windows.Forms.Panel();
            this.rtbReplace = new System.Windows.Forms.RichTextBox();
            this.pnlRelpacesUpper = new System.Windows.Forms.Panel();
            this.hsLoadListReplaces = new SeControlsLib.HotSpot();
            this.tabOptionen = new System.Windows.Forms.TabPage();
            this.cbClearListBeforeExcecute = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbKonfig = new System.Windows.Forms.GroupBox();
            this.txtErrIntervall = new SEFormsControlLibrary.SECaptionEditBox();
            this.txtLogFile = new SEFormsControlLibrary.SECaptionEditBox();
            this.secSERVERNAME = new SEFormsControlLibrary.SECaptionEditBox();
            this.hsRefreshConfig = new SeControlsLib.HotSpot();
            this.txtMeldIntervall = new SEFormsControlLibrary.SECaptionEditBox();
            this.txtMeldLogFilePath = new SEFormsControlLibrary.SECaptionEditBox();
            this.secDATABASEPATH = new SEFormsControlLibrary.SECaptionEditBox();
            this.gpErrorausgabe = new System.Windows.Forms.GroupBox();
            this.rbErrInsert = new System.Windows.Forms.RadioButton();
            this.rbErrAppend = new System.Windows.Forms.RadioButton();
            this.gbMeldungDirection = new System.Windows.Forms.GroupBox();
            this.btnLoadMeld = new System.Windows.Forms.Button();
            this.rbMeldInsert = new System.Windows.Forms.RadioButton();
            this.rbMeldAppend = new System.Windows.Forms.RadioButton();
            this.tabPagePlan = new System.Windows.Forms.TabPage();
            this.pnlPlanCenter = new System.Windows.Forms.Panel();
            this.fctPlan = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlPlanLower = new System.Windows.Forms.Panel();
            this.pnlPlanUpper = new System.Windows.Forms.Panel();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.tabControlExport = new System.Windows.Forms.TabControl();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.fctXMLData = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlXMLDataUpper = new System.Windows.Forms.Panel();
            this.cbShowExportProgress = new System.Windows.Forms.CheckBox();
            this.hsExportBreak = new SeControlsLib.HotSpot();
            this.gbExportCosts = new System.Windows.Forms.GroupBox();
            this.lblExportCosts = new System.Windows.Forms.Label();
            this.ckClearExportListBeforeExecute = new System.Windows.Forms.CheckBox();
            this.ckMaskData = new System.Windows.Forms.CheckBox();
            this.gbExportLinesCount = new System.Windows.Forms.GroupBox();
            this.lblExportLinesCount = new System.Windows.Forms.Label();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.ckExportToScreen = new System.Windows.Forms.CheckBox();
            this.ckExportToFile = new System.Windows.Forms.CheckBox();
            this.hsExportHTML = new SeControlsLib.HotSpot();
            this.gbCSVSeperator = new System.Windows.Forms.GroupBox();
            this.cbCSVSeperator = new System.Windows.Forms.ComboBox();
            this.hsExportCSV = new SeControlsLib.HotSpot();
            this.hsSaveXML = new SeControlsLib.HotSpot();
            this.hsRefreshXMLData = new SeControlsLib.HotSpot();
            this.gbExportProgress = new System.Windows.Forms.GroupBox();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.tabPageXMLScheme = new System.Windows.Forms.TabPage();
            this.fctXMLScheme = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlXMLSchemeUpper = new System.Windows.Forms.Panel();
            this.hsSaveXMLScheme = new SeControlsLib.HotSpot();
            this.hsRefreshXMLScheme = new SeControlsLib.HotSpot();
            this.tabPagePerformance = new System.Windows.Forms.TabPage();
            this.gbPerformance = new System.Windows.Forms.GroupBox();
            this.lvPerformance = new System.Windows.Forms.ListView();
            this.colSQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMEMUSAGE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSEQ_READS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colINX_READS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colINSERTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUPDATES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDELETES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCONFLICTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPerformanceUpper = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hsRefreshPerformance = new SeControlsLib.HotSpot();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.dgvExperienceInfo = new System.Windows.Forms.DataGridView();
            this.cmdExperienceInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExperienceInfoToSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteExperienceInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtExperienceInfo = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbExperienceInfoKey = new System.Windows.Forms.GroupBox();
            this.hsUpdateExperienceInfo = new SeControlsLib.HotSpot();
            this.hsDeleteExperienceInfo = new SeControlsLib.HotSpot();
            this.txtExperienceKeyCode = new System.Windows.Forms.TextBox();
            this.hsClearExperienceInfoFields = new SeControlsLib.HotSpot();
            this.hsRefreshExperienceInfo = new SeControlsLib.HotSpot();
            this.hsInsertExperienceInfo = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.sfdSQL = new System.Windows.Forms.SaveFileDialog();
            this.helpMain = new System.Windows.Forms.HelpProvider();
            this.ofdLog = new System.Windows.Forms.OpenFileDialog();
            this.fbdLog = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.pnlFormUpper.SuspendLayout();
            this.bnConnection.SuspendLayout();
            this.gnUsedTime.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.tcSQLCONTROL.SuspendLayout();
            this.tabSQLTEXT.SuspendLayout();
            this.pnlSQLCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSQL)).BeginInit();
            this.cmsSQLText.SuspendLayout();
            this.pnlSQLUpper.SuspendLayout();
            this.gbEncoding.SuspendLayout();
            this.tabRESULT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.cmdDATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.pnlResultUpper.SuspendLayout();
            this.gbRowHeight.SuspendLayout();
            this.gbEditMode.SuspendLayout();
            this.gbNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTableContent)).BeginInit();
            this.bnTableContent.SuspendLayout();
            this.gbUsedMilliseconds.SuspendLayout();
            this.tabMELDUNG.SuspendLayout();
            this.pnlInfoCenter.SuspendLayout();
            this.pnlMessagesUpper.SuspendLayout();
            this.tabERRORS.SuspendLayout();
            this.pnlErrorUpper.SuspendLayout();
            this.pnlErrorsUpper.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.pnlHistoryCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLHistory)).BeginInit();
            this.cmsHistory.SuspendLayout();
            this.pnlHistoryUpper.SuspendLayout();
            this.tabRelpacelist.SuspendLayout();
            this.pnlReplacesCenter.SuspendLayout();
            this.pnlRelpacesUpper.SuspendLayout();
            this.tabOptionen.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbKonfig.SuspendLayout();
            this.gpErrorausgabe.SuspendLayout();
            this.gbMeldungDirection.SuspendLayout();
            this.tabPagePlan.SuspendLayout();
            this.pnlPlanCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctPlan)).BeginInit();
            this.tabPageExport.SuspendLayout();
            this.tabControlExport.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctXMLData)).BeginInit();
            this.pnlXMLDataUpper.SuspendLayout();
            this.gbExportCosts.SuspendLayout();
            this.gbExportLinesCount.SuspendLayout();
            this.gbCSVSeperator.SuspendLayout();
            this.gbExportProgress.SuspendLayout();
            this.tabPageXMLScheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctXMLScheme)).BeginInit();
            this.pnlXMLSchemeUpper.SuspendLayout();
            this.tabPagePerformance.SuspendLayout();
            this.gbPerformance.SuspendLayout();
            this.pnlPerformanceUpper.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienceInfo)).BeginInit();
            this.cmdExperienceInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExperienceInfo)).BeginInit();
            this.gbExperienceInfoKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormUpper
            // 
            this.pnlFormUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFormUpper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormUpper.Controls.Add(this.hsLifeTime);
            this.pnlFormUpper.Controls.Add(this.bnConnection);
            this.pnlFormUpper.Controls.Add(this.hsPageRefresh);
            this.pnlFormUpper.Controls.Add(this.gnUsedTime);
            this.pnlFormUpper.Controls.Add(this.hsClose);
            this.pnlFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUpper.Name = "pnlFormUpper";
            this.pnlFormUpper.Size = new System.Drawing.Size(1604, 49);
            this.pnlFormUpper.TabIndex = 0;
            // 
            // hsLifeTime
            // 
            this.hsLifeTime.BackColor = System.Drawing.Color.OrangeRed;
            this.hsLifeTime.BackColorHover = System.Drawing.Color.OrangeRed;
            this.hsLifeTime.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLifeTime.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLifeTime.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLifeTime.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLifeTime.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLifeTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLifeTime.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hsLifeTime.FlatAppearance.BorderSize = 2;
            this.hsLifeTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLifeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLifeTime.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLifeTime.Image = null;
            this.hsLifeTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLifeTime.ImageHover = null;
            this.hsLifeTime.ImageToggleOnSelect = true;
            this.hsLifeTime.Location = new System.Drawing.Point(893, 0);
            this.hsLifeTime.Marked = true;
            this.hsLifeTime.MarkedColor = System.Drawing.Color.Lime;
            this.hsLifeTime.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLifeTime.MarkedText = "";
            this.hsLifeTime.MarkMode = true;
            this.hsLifeTime.Name = "hsLifeTime";
            this.hsLifeTime.NonMarkedText = "";
            this.hsLifeTime.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLifeTime.ShortcutNewline = false;
            this.hsLifeTime.ShowShortcut = false;
            this.hsLifeTime.Size = new System.Drawing.Size(87, 47);
            this.hsLifeTime.TabIndex = 34;
            this.hsLifeTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLifeTime.ToolTipActive = false;
            this.hsLifeTime.ToolTipAutomaticDelay = 500;
            this.hsLifeTime.ToolTipAutoPopDelay = 5000;
            this.hsLifeTime.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLifeTime.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLifeTime.ToolTipFor4ContextMenu = true;
            this.hsLifeTime.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLifeTime.ToolTipInitialDelay = 500;
            this.hsLifeTime.ToolTipIsBallon = false;
            this.hsLifeTime.ToolTipOwnerDraw = false;
            this.hsLifeTime.ToolTipReshowDelay = 100;
            this.hsLifeTime.ToolTipShowAlways = false;
            this.hsLifeTime.ToolTipText = "";
            this.hsLifeTime.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLifeTime.ToolTipTitle = "";
            this.hsLifeTime.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLifeTime.UseVisualStyleBackColor = false;
            this.hsLifeTime.Click += new System.EventHandler(this.hsLifeTime_Click);
            // 
            // bnConnection
            // 
            this.bnConnection.Controls.Add(this.cbConnection);
            this.bnConnection.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnConnection.Location = new System.Drawing.Point(45, 0);
            this.bnConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnConnection.Name = "bnConnection";
            this.bnConnection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnConnection.Size = new System.Drawing.Size(848, 47);
            this.bnConnection.TabIndex = 35;
            this.bnConnection.TabStop = false;
            this.bnConnection.Text = "Use connection";
            // 
            // cbConnection
            // 
            this.cbConnection.BackColor = System.Drawing.SystemColors.Info;
            this.cbConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbConnection.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConnection.FormattingEnabled = true;
            this.cbConnection.Location = new System.Drawing.Point(3, 19);
            this.cbConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbConnection.Name = "cbConnection";
            this.cbConnection.Size = new System.Drawing.Size(842, 21);
            this.cbConnection.TabIndex = 0;
            this.cbConnection.SelectedIndexChanged += new System.EventHandler(this.cbConnection_SelectedIndexChanged);
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
            this.hsPageRefresh.Image = global::FBXpertLib.Properties.Resources.view_refresh22x;
            this.hsPageRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsPageRefresh.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_22x;
            this.hsPageRefresh.ImageToggleOnSelect = false;
            this.hsPageRefresh.Location = new System.Drawing.Point(1370, 0);
            this.hsPageRefresh.Marked = false;
            this.hsPageRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsPageRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPageRefresh.MarkedText = "";
            this.hsPageRefresh.MarkMode = false;
            this.hsPageRefresh.Name = "hsPageRefresh";
            this.hsPageRefresh.NonMarkedText = "Refresh";
            this.hsPageRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsPageRefresh.ShortcutNewline = false;
            this.hsPageRefresh.ShowShortcut = false;
            this.hsPageRefresh.Size = new System.Drawing.Size(116, 47);
            this.hsPageRefresh.TabIndex = 28;
            this.hsPageRefresh.Text = "Refresh";
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
            this.hsPageRefresh.Click += new System.EventHandler(this.hsPageRefresh_Click);
            // 
            // gnUsedTime
            // 
            this.gnUsedTime.Controls.Add(this.txtUsedTime);
            this.gnUsedTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.gnUsedTime.Location = new System.Drawing.Point(1486, 0);
            this.gnUsedTime.Name = "gnUsedTime";
            this.gnUsedTime.Size = new System.Drawing.Size(116, 47);
            this.gnUsedTime.TabIndex = 27;
            this.gnUsedTime.TabStop = false;
            this.gnUsedTime.Text = "Used time";
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsedTime.Location = new System.Drawing.Point(3, 18);
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.ReadOnly = true;
            this.txtUsedTime.Size = new System.Drawing.Size(110, 22);
            this.txtUsedTime.TabIndex = 0;
            this.txtUsedTime.Text = "0";
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
            this.hsClose.Image = global::FBXpertLib.Properties.Resources.go_previous32x;
            this.hsClose.ImageHover = global::FBXpertLib.Properties.Resources.go_left_blue32x;
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
            this.hsClose.ShortcutNewline = false;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(45, 47);
            this.hsClose.TabIndex = 26;
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
            // cbTestlauf
            // 
            this.cbTestlauf.BackColor = System.Drawing.Color.Transparent;
            this.cbTestlauf.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTestlauf.Checked = true;
            this.cbTestlauf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTestlauf.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbTestlauf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbTestlauf.Location = new System.Drawing.Point(1388, 0);
            this.cbTestlauf.Name = "cbTestlauf";
            this.cbTestlauf.Size = new System.Drawing.Size(74, 41);
            this.cbTestlauf.TabIndex = 24;
            this.cbTestlauf.Text = "Testlauf";
            this.cbTestlauf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbTestlauf.UseVisualStyleBackColor = false;
            this.cbTestlauf.CheckedChanged += new System.EventHandler(this.cbTestlauf_CheckedChanged);
            // 
            // cbHistory
            // 
            this.cbHistory.AutoSize = true;
            this.cbHistory.BackColor = System.Drawing.Color.Transparent;
            this.cbHistory.Checked = true;
            this.cbHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHistory.Location = new System.Drawing.Point(17, 70);
            this.cbHistory.Name = "cbHistory";
            this.cbHistory.Size = new System.Drawing.Size(64, 18);
            this.cbHistory.TabIndex = 27;
            this.cbHistory.Text = "History";
            this.cbHistory.UseVisualStyleBackColor = false;
            this.cbHistory.CheckedChanged += new System.EventHandler(this.cbHistory_CheckedChanged);
            // 
            // cbErrors
            // 
            this.cbErrors.AutoSize = true;
            this.cbErrors.BackColor = System.Drawing.Color.Transparent;
            this.cbErrors.Checked = true;
            this.cbErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbErrors.Location = new System.Drawing.Point(17, 19);
            this.cbErrors.Name = "cbErrors";
            this.cbErrors.Size = new System.Drawing.Size(57, 18);
            this.cbErrors.TabIndex = 26;
            this.cbErrors.Text = "Errors";
            this.cbErrors.UseVisualStyleBackColor = false;
            this.cbErrors.CheckedChanged += new System.EventHandler(this.cbErrors_CheckedChanged);
            // 
            // cbMeldungen
            // 
            this.cbMeldungen.AutoSize = true;
            this.cbMeldungen.BackColor = System.Drawing.Color.Transparent;
            this.cbMeldungen.Checked = true;
            this.cbMeldungen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMeldungen.Location = new System.Drawing.Point(17, 46);
            this.cbMeldungen.Name = "cbMeldungen";
            this.cbMeldungen.Size = new System.Drawing.Size(58, 18);
            this.cbMeldungen.TabIndex = 25;
            this.cbMeldungen.Text = "Alerts";
            this.cbMeldungen.UseVisualStyleBackColor = false;
            this.cbMeldungen.CheckedChanged += new System.EventHandler(this.cbMeldungen_CheckedChanged);
            // 
            // pnl_center
            // 
            this.pnl_center.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_center.Controls.Add(this.tcSQLCONTROL);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(0, 49);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(1604, 650);
            this.pnl_center.TabIndex = 2;
            // 
            // tcSQLCONTROL
            // 
            this.tcSQLCONTROL.Controls.Add(this.tabSQLTEXT);
            this.tcSQLCONTROL.Controls.Add(this.tabRESULT);
            this.tcSQLCONTROL.Controls.Add(this.tabMELDUNG);
            this.tcSQLCONTROL.Controls.Add(this.tabERRORS);
            this.tcSQLCONTROL.Controls.Add(this.tabHistory);
            this.tcSQLCONTROL.Controls.Add(this.tabRelpacelist);
            this.tcSQLCONTROL.Controls.Add(this.tabOptionen);
            this.tcSQLCONTROL.Controls.Add(this.tabPagePlan);
            this.tcSQLCONTROL.Controls.Add(this.tabPageExport);
            this.tcSQLCONTROL.Controls.Add(this.tabPagePerformance);
            this.tcSQLCONTROL.Controls.Add(this.tabPageInfo);
            this.tcSQLCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSQLCONTROL.ImageList = this.ilTabControl;
            this.tcSQLCONTROL.Location = new System.Drawing.Point(0, 0);
            this.tcSQLCONTROL.Name = "tcSQLCONTROL";
            this.tcSQLCONTROL.SelectedIndex = 0;
            this.tcSQLCONTROL.Size = new System.Drawing.Size(1602, 648);
            this.tcSQLCONTROL.TabIndex = 0;
            // 
            // tabSQLTEXT
            // 
            this.tabSQLTEXT.BackColor = System.Drawing.SystemColors.Control;
            this.tabSQLTEXT.Controls.Add(this.pnlSQLCenter);
            this.tabSQLTEXT.Controls.Add(this.pnlSQLUpper);
            this.tabSQLTEXT.Controls.Add(this.pbRunSQL);
            this.tabSQLTEXT.ImageKey = "SQL_blue_x24.png";
            this.tabSQLTEXT.Location = new System.Drawing.Point(4, 23);
            this.tabSQLTEXT.Name = "tabSQLTEXT";
            this.tabSQLTEXT.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQLTEXT.Size = new System.Drawing.Size(1594, 621);
            this.tabSQLTEXT.TabIndex = 0;
            this.tabSQLTEXT.Text = "SQL commands";
            // 
            // pnlSQLCenter
            // 
            this.pnlSQLCenter.Controls.Add(this.txtSQL);
            this.pnlSQLCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSQLCenter.Location = new System.Drawing.Point(3, 48);
            this.pnlSQLCenter.Name = "pnlSQLCenter";
            this.pnlSQLCenter.Size = new System.Drawing.Size(1588, 560);
            this.pnlSQLCenter.TabIndex = 28;
            // 
            // txtSQL
            // 
            this.txtSQL.AutoCompleteBracketsList = new char[] {
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
            this.txtSQL.AutoIndentCharsPatterns = "";
            this.txtSQL.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtSQL.BackBrush = null;
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSQL.CharHeight = 14;
            this.txtSQL.CharWidth = 8;
            this.txtSQL.CommentPrefix = "--";
            this.txtSQL.ContextMenuStrip = this.cmsSQLText;
            this.txtSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtSQL.IsReplaceMode = false;
            this.txtSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtSQL.LeftBracket = '(';
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.txtSQL.RightBracket = ')';
            this.txtSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtSQL.ServiceColors")));
            this.txtSQL.Size = new System.Drawing.Size(1588, 560);
            this.txtSQL.TabIndex = 24;
            this.txtSQL.Zoom = 100;
            this.txtSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSQL_KeyDown_1);
            // 
            // cmsSQLText
            // 
            this.cmsSQLText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDDLCopyToClipboard,
            this.tsmiDDLPaste,
            this.toolStripSeparator1,
            this.tsmiLastCommand,
            this.tsmiInsertLastSuccessfullCommand,
            this.tsmiExecuteLastSucessfullCommand,
            this.tsmiInsertPK});
            this.cmsSQLText.Name = "cmsText";
            this.cmsSQLText.Size = new System.Drawing.Size(249, 142);
            this.cmsSQLText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSQLText_ItemClicked);
            // 
            // tsmiDDLCopyToClipboard
            // 
            this.tsmiDDLCopyToClipboard.Image = global::FBXpertLib.Properties.Resources.format_indent_less32x;
            this.tsmiDDLCopyToClipboard.Name = "tsmiDDLCopyToClipboard";
            this.tsmiDDLCopyToClipboard.Size = new System.Drawing.Size(248, 22);
            this.tsmiDDLCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiDDLPaste
            // 
            this.tsmiDDLPaste.Image = global::FBXpertLib.Properties.Resources.format_indent_more_2_32x;
            this.tsmiDDLPaste.Name = "tsmiDDLPaste";
            this.tsmiDDLPaste.Size = new System.Drawing.Size(248, 22);
            this.tsmiDDLPaste.Text = "Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmiLastCommand
            // 
            this.tsmiLastCommand.Image = global::FBXpertLib.Properties.Resources.SQL_blue_x24;
            this.tsmiLastCommand.Name = "tsmiLastCommand";
            this.tsmiLastCommand.Size = new System.Drawing.Size(248, 22);
            this.tsmiLastCommand.Text = "Insert last command";
            // 
            // tsmiInsertLastSuccessfullCommand
            // 
            this.tsmiInsertLastSuccessfullCommand.Image = global::FBXpertLib.Properties.Resources.SQL_blue_x24;
            this.tsmiInsertLastSuccessfullCommand.Name = "tsmiInsertLastSuccessfullCommand";
            this.tsmiInsertLastSuccessfullCommand.Size = new System.Drawing.Size(248, 22);
            this.tsmiInsertLastSuccessfullCommand.Text = "Insert last successful command";
            // 
            // tsmiExecuteLastSucessfullCommand
            // 
            this.tsmiExecuteLastSucessfullCommand.AutoToolTip = true;
            this.tsmiExecuteLastSucessfullCommand.Image = global::FBXpertLib.Properties.Resources.SQL_blue_x24;
            this.tsmiExecuteLastSucessfullCommand.Name = "tsmiExecuteLastSucessfullCommand";
            this.tsmiExecuteLastSucessfullCommand.Size = new System.Drawing.Size(248, 22);
            this.tsmiExecuteLastSucessfullCommand.Text = "Execute last sucessfull command";
            // 
            // tsmiInsertPK
            // 
            this.tsmiInsertPK.Name = "tsmiInsertPK";
            this.tsmiInsertPK.Size = new System.Drawing.Size(248, 22);
            this.tsmiInsertPK.Text = "Insert PRIMARY KEY NOT NULL";
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLUpper.Controls.Add(this.ckShowResults);
            this.pnlSQLUpper.Controls.Add(this.hsBreak);
            this.pnlSQLUpper.Controls.Add(this.hsReplaceText);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsRunSQLfromFile);
            this.pnlSQLUpper.Controls.Add(this.hsClearText);
            this.pnlSQLUpper.Controls.Add(this.hsRunSQL);
            this.pnlSQLUpper.Controls.Add(this.cbTestlauf);
            this.pnlSQLUpper.Controls.Add(this.gbEncoding);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(1588, 45);
            this.pnlSQLUpper.TabIndex = 27;
            // 
            // ckShowResults
            // 
            this.ckShowResults.BackColor = System.Drawing.Color.Transparent;
            this.ckShowResults.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckShowResults.Checked = true;
            this.ckShowResults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckShowResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckShowResults.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ckShowResults.Location = new System.Drawing.Point(1282, 0);
            this.ckShowResults.Name = "ckShowResults";
            this.ckShowResults.Size = new System.Drawing.Size(106, 41);
            this.ckShowResults.TabIndex = 34;
            this.ckShowResults.Text = "Show Results";
            this.ckShowResults.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckShowResults.UseVisualStyleBackColor = false;
            this.ckShowResults.CheckedChanged += new System.EventHandler(this.ckShowResults_CheckedChanged);
            // 
            // hsBreak
            // 
            this.hsBreak.BackColor = System.Drawing.Color.Transparent;
            this.hsBreak.BackColorHover = System.Drawing.Color.Transparent;
            this.hsBreak.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsBreak.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsBreak.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsBreak.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsBreak.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsBreak.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsBreak.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsBreak.FlatAppearance.BorderSize = 0;
            this.hsBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsBreak.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsBreak.Image = global::FBXpertLib.Properties.Resources.cross_red_x22;
            this.hsBreak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsBreak.ImageHover = global::FBXpertLib.Properties.Resources.cross_blue_x22;
            this.hsBreak.ImageToggleOnSelect = true;
            this.hsBreak.Location = new System.Drawing.Point(591, 0);
            this.hsBreak.Marked = false;
            this.hsBreak.MarkedColor = System.Drawing.Color.Teal;
            this.hsBreak.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsBreak.MarkedText = "";
            this.hsBreak.MarkMode = false;
            this.hsBreak.Name = "hsBreak";
            this.hsBreak.NonMarkedText = "Break";
            this.hsBreak.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsBreak.ShortcutNewline = false;
            this.hsBreak.ShowShortcut = false;
            this.hsBreak.Size = new System.Drawing.Size(68, 41);
            this.hsBreak.TabIndex = 33;
            this.hsBreak.Text = "Break";
            this.hsBreak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsBreak.ToolTipActive = false;
            this.hsBreak.ToolTipAutomaticDelay = 500;
            this.hsBreak.ToolTipAutoPopDelay = 5000;
            this.hsBreak.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsBreak.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsBreak.ToolTipFor4ContextMenu = true;
            this.hsBreak.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsBreak.ToolTipInitialDelay = 500;
            this.hsBreak.ToolTipIsBallon = false;
            this.hsBreak.ToolTipOwnerDraw = false;
            this.hsBreak.ToolTipReshowDelay = 100;
            this.hsBreak.ToolTipShowAlways = false;
            this.hsBreak.ToolTipText = "";
            this.hsBreak.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsBreak.ToolTipTitle = "";
            this.hsBreak.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsBreak.UseVisualStyleBackColor = false;
            this.hsBreak.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // hsReplaceText
            // 
            this.hsReplaceText.BackColor = System.Drawing.Color.Transparent;
            this.hsReplaceText.BackColorHover = System.Drawing.Color.Transparent;
            this.hsReplaceText.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsReplaceText.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsReplaceText.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsReplaceText.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsReplaceText.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsReplaceText.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsReplaceText.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsReplaceText.FlatAppearance.BorderSize = 0;
            this.hsReplaceText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsReplaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsReplaceText.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsReplaceText.Image = global::FBXpertLib.Properties.Resources.applications_system_22x;
            this.hsReplaceText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsReplaceText.ImageHover = global::FBXpertLib.Properties.Resources.applications_system_blue_22x;
            this.hsReplaceText.ImageToggleOnSelect = true;
            this.hsReplaceText.Location = new System.Drawing.Point(495, 0);
            this.hsReplaceText.Marked = false;
            this.hsReplaceText.MarkedColor = System.Drawing.Color.Teal;
            this.hsReplaceText.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsReplaceText.MarkedText = "";
            this.hsReplaceText.MarkMode = false;
            this.hsReplaceText.Name = "hsReplaceText";
            this.hsReplaceText.NonMarkedText = "Replace Text";
            this.hsReplaceText.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsReplaceText.ShortcutNewline = false;
            this.hsReplaceText.ShowShortcut = false;
            this.hsReplaceText.Size = new System.Drawing.Size(96, 41);
            this.hsReplaceText.TabIndex = 32;
            this.hsReplaceText.Text = "Replace Text";
            this.hsReplaceText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsReplaceText.ToolTipActive = false;
            this.hsReplaceText.ToolTipAutomaticDelay = 500;
            this.hsReplaceText.ToolTipAutoPopDelay = 5000;
            this.hsReplaceText.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsReplaceText.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsReplaceText.ToolTipFor4ContextMenu = true;
            this.hsReplaceText.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsReplaceText.ToolTipInitialDelay = 500;
            this.hsReplaceText.ToolTipIsBallon = false;
            this.hsReplaceText.ToolTipOwnerDraw = false;
            this.hsReplaceText.ToolTipReshowDelay = 100;
            this.hsReplaceText.ToolTipShowAlways = false;
            this.hsReplaceText.ToolTipText = "";
            this.hsReplaceText.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsReplaceText.ToolTipTitle = "";
            this.hsReplaceText.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsReplaceText.UseVisualStyleBackColor = false;
            this.hsReplaceText.Click += new System.EventHandler(this.hsReplaceText_Click);
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
            this.hsSaveSQL.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hsSaveSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveSQL.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hsSaveSQL.ImageToggleOnSelect = true;
            this.hsSaveSQL.Location = new System.Drawing.Point(418, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveSQL.ShortcutNewline = false;
            this.hsSaveSQL.ShowShortcut = false;
            this.hsSaveSQL.Size = new System.Drawing.Size(77, 41);
            this.hsSaveSQL.TabIndex = 31;
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
            this.hsSaveSQL.Click += new System.EventHandler(this.hsSaveSQL_Click);
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
            this.hsLoadSQL.Image = global::FBXpertLib.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpertLib.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(341, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadSQL.ShortcutNewline = false;
            this.hsLoadSQL.ShowShortcut = false;
            this.hsLoadSQL.Size = new System.Drawing.Size(77, 41);
            this.hsLoadSQL.TabIndex = 30;
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
            // hsRunSQLfromFile
            // 
            this.hsRunSQLfromFile.BackColor = System.Drawing.Color.Transparent;
            this.hsRunSQLfromFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunSQLfromFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunSQLfromFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunSQLfromFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunSQLfromFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunSQLfromFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunSQLfromFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRunSQLfromFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunSQLfromFile.FlatAppearance.BorderSize = 0;
            this.hsRunSQLfromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunSQLfromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRunSQLfromFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunSQLfromFile.Image = global::FBXpertLib.Properties.Resources.applications_execute_script_blue_22x;
            this.hsRunSQLfromFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunSQLfromFile.ImageHover = global::FBXpertLib.Properties.Resources.applications_execute_script_blue_22x;
            this.hsRunSQLfromFile.ImageToggleOnSelect = true;
            this.hsRunSQLfromFile.Location = new System.Drawing.Point(214, 0);
            this.hsRunSQLfromFile.Marked = false;
            this.hsRunSQLfromFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunSQLfromFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunSQLfromFile.MarkedText = "";
            this.hsRunSQLfromFile.MarkMode = false;
            this.hsRunSQLfromFile.Name = "hsRunSQLfromFile";
            this.hsRunSQLfromFile.NonMarkedText = "Run SQL from File";
            this.hsRunSQLfromFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRunSQLfromFile.ShortcutNewline = false;
            this.hsRunSQLfromFile.ShowShortcut = false;
            this.hsRunSQLfromFile.Size = new System.Drawing.Size(127, 41);
            this.hsRunSQLfromFile.TabIndex = 29;
            this.hsRunSQLfromFile.Text = "Run SQL from File";
            this.hsRunSQLfromFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunSQLfromFile.ToolTipActive = false;
            this.hsRunSQLfromFile.ToolTipAutomaticDelay = 500;
            this.hsRunSQLfromFile.ToolTipAutoPopDelay = 5000;
            this.hsRunSQLfromFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunSQLfromFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunSQLfromFile.ToolTipFor4ContextMenu = true;
            this.hsRunSQLfromFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunSQLfromFile.ToolTipInitialDelay = 500;
            this.hsRunSQLfromFile.ToolTipIsBallon = false;
            this.hsRunSQLfromFile.ToolTipOwnerDraw = false;
            this.hsRunSQLfromFile.ToolTipReshowDelay = 100;
            this.hsRunSQLfromFile.ToolTipShowAlways = false;
            this.hsRunSQLfromFile.ToolTipText = "";
            this.hsRunSQLfromFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunSQLfromFile.ToolTipTitle = "";
            this.hsRunSQLfromFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunSQLfromFile.UseVisualStyleBackColor = false;
            this.hsRunSQLfromFile.Click += new System.EventHandler(this.hsRunSQLfromFile_Click);
            // 
            // hsClearText
            // 
            this.hsClearText.BackColor = System.Drawing.Color.Transparent;
            this.hsClearText.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearText.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearText.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearText.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearText.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearText.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearText.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearText.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearText.FlatAppearance.BorderSize = 0;
            this.hsClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearText.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearText.Image = global::FBXpertLib.Properties.Resources.documents_32x;
            this.hsClearText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearText.ImageHover = global::FBXpertLib.Properties.Resources.document_blue_x32;
            this.hsClearText.ImageToggleOnSelect = true;
            this.hsClearText.Location = new System.Drawing.Point(130, 0);
            this.hsClearText.Marked = false;
            this.hsClearText.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearText.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearText.MarkedText = "";
            this.hsClearText.MarkMode = false;
            this.hsClearText.Name = "hsClearText";
            this.hsClearText.NonMarkedText = "Clear Text";
            this.hsClearText.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearText.ShortcutNewline = false;
            this.hsClearText.ShowShortcut = false;
            this.hsClearText.Size = new System.Drawing.Size(84, 41);
            this.hsClearText.TabIndex = 28;
            this.hsClearText.Text = "Clear Text";
            this.hsClearText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearText.ToolTipActive = false;
            this.hsClearText.ToolTipAutomaticDelay = 500;
            this.hsClearText.ToolTipAutoPopDelay = 5000;
            this.hsClearText.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearText.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearText.ToolTipFor4ContextMenu = true;
            this.hsClearText.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearText.ToolTipInitialDelay = 500;
            this.hsClearText.ToolTipIsBallon = false;
            this.hsClearText.ToolTipOwnerDraw = false;
            this.hsClearText.ToolTipReshowDelay = 100;
            this.hsClearText.ToolTipShowAlways = false;
            this.hsClearText.ToolTipText = "";
            this.hsClearText.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearText.ToolTipTitle = "";
            this.hsClearText.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearText.UseVisualStyleBackColor = false;
            this.hsClearText.Click += new System.EventHandler(this.hsClearText_Click);
            // 
            // hsRunSQL
            // 
            this.hsRunSQL.BackColor = System.Drawing.Color.Transparent;
            this.hsRunSQL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunSQL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunSQL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunSQL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunSQL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunSQL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRunSQL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunSQL.FlatAppearance.BorderSize = 0;
            this.hsRunSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRunSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunSQL.Image = global::FBXpertLib.Properties.Resources.applications_system_22x;
            this.hsRunSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunSQL.ImageHover = global::FBXpertLib.Properties.Resources.applications_system_blue_22x;
            this.hsRunSQL.ImageToggleOnSelect = true;
            this.hsRunSQL.Location = new System.Drawing.Point(0, 0);
            this.hsRunSQL.Marked = false;
            this.hsRunSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunSQL.MarkedText = "";
            this.hsRunSQL.MarkMode = false;
            this.hsRunSQL.Name = "hsRunSQL";
            this.hsRunSQL.NonMarkedText = "Run SQL";
            this.hsRunSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRunSQL.ShortcutNewline = false;
            this.hsRunSQL.ShowShortcut = false;
            this.hsRunSQL.Size = new System.Drawing.Size(130, 41);
            this.hsRunSQL.TabIndex = 27;
            this.hsRunSQL.Text = "Run SQL";
            this.hsRunSQL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunSQL.ToolTipActive = false;
            this.hsRunSQL.ToolTipAutomaticDelay = 500;
            this.hsRunSQL.ToolTipAutoPopDelay = 5000;
            this.hsRunSQL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunSQL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunSQL.ToolTipFor4ContextMenu = true;
            this.hsRunSQL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunSQL.ToolTipInitialDelay = 500;
            this.hsRunSQL.ToolTipIsBallon = false;
            this.hsRunSQL.ToolTipOwnerDraw = false;
            this.hsRunSQL.ToolTipReshowDelay = 100;
            this.hsRunSQL.ToolTipShowAlways = false;
            this.hsRunSQL.ToolTipText = "";
            this.hsRunSQL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunSQL.ToolTipTitle = "";
            this.hsRunSQL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunSQL.UseVisualStyleBackColor = false;
            this.hsRunSQL.Click += new System.EventHandler(this.hsRunSQL_Click);
            // 
            // gbEncoding
            // 
            this.gbEncoding.BackColor = System.Drawing.SystemColors.Control;
            this.gbEncoding.Controls.Add(this.cbEncoding);
            this.gbEncoding.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbEncoding.Location = new System.Drawing.Point(1462, 0);
            this.gbEncoding.Name = "gbEncoding";
            this.gbEncoding.Size = new System.Drawing.Size(122, 41);
            this.gbEncoding.TabIndex = 25;
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
            this.cbEncoding.Location = new System.Drawing.Point(3, 18);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(116, 22);
            this.cbEncoding.TabIndex = 34;
            this.cbEncoding.Text = "UTF8";
            // 
            // pbRunSQL
            // 
            this.pbRunSQL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbRunSQL.Location = new System.Drawing.Point(3, 608);
            this.pbRunSQL.Name = "pbRunSQL";
            this.pbRunSQL.Size = new System.Drawing.Size(1588, 10);
            this.pbRunSQL.TabIndex = 24;
            // 
            // tabRESULT
            // 
            this.tabRESULT.Controls.Add(this.dgvResults);
            this.tabRESULT.Controls.Add(this.bindingNavigator1);
            this.tabRESULT.Controls.Add(this.pnlResultUpper);
            this.tabRESULT.Controls.Add(this.pnlWatch);
            this.tabRESULT.ImageIndex = 14;
            this.tabRESULT.Location = new System.Drawing.Point(4, 23);
            this.tabRESULT.Name = "tabRESULT";
            this.tabRESULT.Padding = new System.Windows.Forms.Padding(3);
            this.tabRESULT.Size = new System.Drawing.Size(1594, 621);
            this.tabRESULT.TabIndex = 1;
            this.tabRESULT.Text = "Results grid";
            this.tabRESULT.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ContextMenuStrip = this.cmdDATA;
            this.dgvResults.DataSource = this.bsResults;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Location = new System.Drawing.Point(3, 56);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.ShowCellErrors = false;
            this.dgvResults.ShowRowErrors = false;
            this.dgvResults.Size = new System.Drawing.Size(1588, 537);
            this.dgvResults.TabIndex = 16;
            this.dgvResults.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvResults_CellPainting);
            this.dgvResults.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvResults_DataError);
            // 
            // cmdDATA
            // 
            this.cmdDATA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmdDATA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpaltenEdit,
            this.toolStripSeparator4,
            this.tsmiDate,
            this.tsmiInsertNow,
            this.toolStripSeparator5,
            this.tsmiInsertGUID,
            this.tsmiInsertGUIDHEX,
            this.toolStripSeparator6,
            this.tsmiSetToNULL,
            this.tsmiInsert0,
            this.tsmiInsert1,
            this.toolStripSeparator7,
            this.tsmiReadBLOB});
            this.cmdDATA.Name = "cmsText";
            this.cmdDATA.Size = new System.Drawing.Size(189, 262);
            this.cmdDATA.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdDATA_ItemClicked);
            // 
            // tsmiSpaltenEdit
            // 
            this.tsmiSpaltenEdit.Image = global::FBXpertLib.Properties.Resources.Table_x24;
            this.tsmiSpaltenEdit.Name = "tsmiSpaltenEdit";
            this.tsmiSpaltenEdit.Size = new System.Drawing.Size(188, 26);
            this.tsmiSpaltenEdit.Text = "Spaltendeditor";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiDate
            // 
            this.tsmiDate.Image = global::FBXpertLib.Properties.Resources.calendar01_22x;
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.Size = new System.Drawing.Size(188, 26);
            this.tsmiDate.Text = "DateTime";
            // 
            // tsmiInsertNow
            // 
            this.tsmiInsertNow.Image = global::FBXpertLib.Properties.Resources.appointment_new_24;
            this.tsmiInsertNow.Name = "tsmiInsertNow";
            this.tsmiInsertNow.Size = new System.Drawing.Size(188, 26);
            this.tsmiInsertNow.Text = "Insert DateTime Now";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiInsertGUID
            // 
            this.tsmiInsertGUID.Image = global::FBXpertLib.Properties.Resources.font2_x241;
            this.tsmiInsertGUID.Name = "tsmiInsertGUID";
            this.tsmiInsertGUID.Size = new System.Drawing.Size(188, 26);
            this.tsmiInsertGUID.Text = "Insert GUID";
            // 
            // tsmiInsertGUIDHEX
            // 
            this.tsmiInsertGUIDHEX.Image = global::FBXpertLib.Properties.Resources.font_x24;
            this.tsmiInsertGUIDHEX.Name = "tsmiInsertGUIDHEX";
            this.tsmiInsertGUIDHEX.Size = new System.Drawing.Size(188, 26);
            this.tsmiInsertGUIDHEX.Text = "Insert GUID-HEX";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiSetToNULL
            // 
            this.tsmiSetToNULL.Image = global::FBXpertLib.Properties.Resources.NULL_blue_x24;
            this.tsmiSetToNULL.Name = "tsmiSetToNULL";
            this.tsmiSetToNULL.Size = new System.Drawing.Size(188, 26);
            this.tsmiSetToNULL.Text = "Set to NULL";
            // 
            // tsmiInsert0
            // 
            this.tsmiInsert0.Image = global::FBXpertLib.Properties.Resources.N0_blue_x24;
            this.tsmiInsert0.Name = "tsmiInsert0";
            this.tsmiInsert0.Size = new System.Drawing.Size(188, 26);
            this.tsmiInsert0.Text = "Set to 0";
            // 
            // tsmiInsert1
            // 
            this.tsmiInsert1.Image = global::FBXpertLib.Properties.Resources.N1_blue_x24;
            this.tsmiInsert1.Name = "tsmiInsert1";
            this.tsmiInsert1.Size = new System.Drawing.Size(188, 26);
            this.tsmiInsert1.Text = "Set to 1";
            this.tsmiInsert1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiReadBLOB
            // 
            this.tsmiReadBLOB.Image = global::FBXpertLib.Properties.Resources.bin_x24;
            this.tsmiReadBLOB.Name = "tsmiReadBLOB";
            this.tsmiReadBLOB.Size = new System.Drawing.Size(188, 26);
            this.tsmiReadBLOB.Text = "Read as BLOB";
            // 
            // bsResults
            // 
            this.bsResults.DataSource = this.dsResults;
            this.bsResults.Position = 0;
            // 
            // dsResults
            // 
            this.dsResults.DataSetName = "NewDataSet";
            this.dsResults.Tables.AddRange(new System.Data.DataTable[] {
            this.Table});
            // 
            // Table
            // 
            this.Table.TableName = "Table";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsResults;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 593);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1588, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "1";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlResultUpper
            // 
            this.pnlResultUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultUpper.Controls.Add(this.gbRowHeight);
            this.pnlResultUpper.Controls.Add(this.hsUpdateDataset);
            this.pnlResultUpper.Controls.Add(this.gbEditMode);
            this.pnlResultUpper.Controls.Add(this.gbNavigator);
            this.pnlResultUpper.Controls.Add(this.gbUsedMilliseconds);
            this.pnlResultUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlResultUpper.Name = "pnlResultUpper";
            this.pnlResultUpper.Size = new System.Drawing.Size(1588, 53);
            this.pnlResultUpper.TabIndex = 25;
            // 
            // gbRowHeight
            // 
            this.gbRowHeight.Controls.Add(this.txtRowHeight);
            this.gbRowHeight.Controls.Add(this.cbRowManually);
            this.gbRowHeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbRowHeight.Location = new System.Drawing.Point(649, 0);
            this.gbRowHeight.Name = "gbRowHeight";
            this.gbRowHeight.Size = new System.Drawing.Size(112, 49);
            this.gbRowHeight.TabIndex = 35;
            this.gbRowHeight.TabStop = false;
            this.gbRowHeight.Text = "Row height";
            // 
            // txtRowHeight
            // 
            this.txtRowHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRowHeight.Location = new System.Drawing.Point(29, 18);
            this.txtRowHeight.Name = "txtRowHeight";
            this.txtRowHeight.Size = new System.Drawing.Size(80, 22);
            this.txtRowHeight.TabIndex = 30;
            this.txtRowHeight.TextChanged += new System.EventHandler(this.txtRowHeight_TextChanged);
            this.txtRowHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRowHeight_KeyDown);
            // 
            // cbRowManually
            // 
            this.cbRowManually.Checked = true;
            this.cbRowManually.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRowManually.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbRowManually.Location = new System.Drawing.Point(3, 18);
            this.cbRowManually.Name = "cbRowManually";
            this.cbRowManually.Size = new System.Drawing.Size(26, 28);
            this.cbRowManually.TabIndex = 29;
            this.cbRowManually.UseVisualStyleBackColor = true;
            this.cbRowManually.CheckedChanged += new System.EventHandler(this.cbRowManually_CheckedChanged);
            // 
            // hsUpdateDataset
            // 
            this.hsUpdateDataset.BackColor = System.Drawing.Color.Transparent;
            this.hsUpdateDataset.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateDataset.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateDataset.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUpdateDataset.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUpdateDataset.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUpdateDataset.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUpdateDataset.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsUpdateDataset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUpdateDataset.FlatAppearance.BorderSize = 0;
            this.hsUpdateDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUpdateDataset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsUpdateDataset.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUpdateDataset.Image = global::FBXpertLib.Properties.Resources.ok_gn22x;
            this.hsUpdateDataset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsUpdateDataset.ImageHover = global::FBXpertLib.Properties.Resources.ok_blue22x;
            this.hsUpdateDataset.ImageToggleOnSelect = false;
            this.hsUpdateDataset.Location = new System.Drawing.Point(492, 0);
            this.hsUpdateDataset.Marked = false;
            this.hsUpdateDataset.MarkedColor = System.Drawing.Color.Teal;
            this.hsUpdateDataset.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUpdateDataset.MarkedText = "";
            this.hsUpdateDataset.MarkMode = false;
            this.hsUpdateDataset.Name = "hsUpdateDataset";
            this.hsUpdateDataset.NonMarkedText = "Update";
            this.hsUpdateDataset.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUpdateDataset.ShortcutNewline = false;
            this.hsUpdateDataset.ShowShortcut = false;
            this.hsUpdateDataset.Size = new System.Drawing.Size(157, 49);
            this.hsUpdateDataset.TabIndex = 30;
            this.hsUpdateDataset.Text = "Update dataset";
            this.hsUpdateDataset.ToolTipActive = false;
            this.hsUpdateDataset.ToolTipAutomaticDelay = 500;
            this.hsUpdateDataset.ToolTipAutoPopDelay = 5000;
            this.hsUpdateDataset.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUpdateDataset.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUpdateDataset.ToolTipFor4ContextMenu = true;
            this.hsUpdateDataset.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUpdateDataset.ToolTipInitialDelay = 500;
            this.hsUpdateDataset.ToolTipIsBallon = false;
            this.hsUpdateDataset.ToolTipOwnerDraw = false;
            this.hsUpdateDataset.ToolTipReshowDelay = 100;
            this.hsUpdateDataset.ToolTipShowAlways = false;
            this.hsUpdateDataset.ToolTipText = "";
            this.hsUpdateDataset.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUpdateDataset.ToolTipTitle = "";
            this.hsUpdateDataset.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUpdateDataset.UseVisualStyleBackColor = false;
            this.hsUpdateDataset.Click += new System.EventHandler(this.hsSaveDataset_Click);
            // 
            // gbEditMode
            // 
            this.gbEditMode.Controls.Add(this.cbEditMode);
            this.gbEditMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbEditMode.Location = new System.Drawing.Point(416, 0);
            this.gbEditMode.Name = "gbEditMode";
            this.gbEditMode.Size = new System.Drawing.Size(76, 49);
            this.gbEditMode.TabIndex = 34;
            this.gbEditMode.TabStop = false;
            this.gbEditMode.Text = "Edit mode";
            // 
            // cbEditMode
            // 
            this.cbEditMode.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEditMode.Checked = true;
            this.cbEditMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEditMode.Location = new System.Drawing.Point(3, 18);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(70, 28);
            this.cbEditMode.TabIndex = 29;
            this.cbEditMode.UseVisualStyleBackColor = true;
            this.cbEditMode.CheckedChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // gbNavigator
            // 
            this.gbNavigator.Controls.Add(this.bnTableContent);
            this.gbNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbNavigator.Location = new System.Drawing.Point(94, 0);
            this.gbNavigator.Name = "gbNavigator";
            this.gbNavigator.Size = new System.Drawing.Size(322, 49);
            this.gbNavigator.TabIndex = 33;
            this.gbNavigator.TabStop = false;
            this.gbNavigator.Text = "Navigator";
            // 
            // bnTableContent
            // 
            this.bnTableContent.AddNewItem = null;
            this.bnTableContent.BindingSource = this.bsResults;
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
            this.bnTableContent.Location = new System.Drawing.Point(3, 18);
            this.bnTableContent.MoveFirstItem = this.bnTableContentMoveFirstItem;
            this.bnTableContent.MoveLastItem = this.bnTableContentMoveLastItem;
            this.bnTableContent.MoveNextItem = this.bnTableContentMoveNextItem;
            this.bnTableContent.MovePreviousItem = this.bnTableContentMovePreviousItem;
            this.bnTableContent.Name = "bnTableContent";
            this.bnTableContent.PositionItem = this.bnTableContentPositionItem;
            this.bnTableContent.Size = new System.Drawing.Size(316, 28);
            this.bnTableContent.TabIndex = 26;
            this.bnTableContent.Text = "bindingNavigator1";
            // 
            // bnTableContentCountItem
            // 
            this.bnTableContentCountItem.Name = "bnTableContentCountItem";
            this.bnTableContentCountItem.Size = new System.Drawing.Size(44, 25);
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
            this.bnTableContentMoveFirstItem.Size = new System.Drawing.Size(24, 25);
            this.bnTableContentMoveFirstItem.Text = "Move first";
            // 
            // bnTableContentMovePreviousItem
            // 
            this.bnTableContentMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMovePreviousItem.Image")));
            this.bnTableContentMovePreviousItem.Name = "bnTableContentMovePreviousItem";
            this.bnTableContentMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMovePreviousItem.Size = new System.Drawing.Size(24, 25);
            this.bnTableContentMovePreviousItem.Text = "Move previous";
            // 
            // bnTableContentSeparator
            // 
            this.bnTableContentSeparator.Name = "bnTableContentSeparator";
            this.bnTableContentSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bnTableContentPositionItem
            // 
            this.bnTableContentPositionItem.AccessibleName = "Position";
            this.bnTableContentPositionItem.AutoSize = false;
            this.bnTableContentPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bnTableContentPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnTableContentPositionItem.Name = "bnTableContentPositionItem";
            this.bnTableContentPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bnTableContentPositionItem.Text = "1";
            this.bnTableContentPositionItem.ToolTipText = "Current position";
            // 
            // bnTableContentSeparator1
            // 
            this.bnTableContentSeparator1.Name = "bnTableContentSeparator1";
            this.bnTableContentSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bnTableContentMoveNextItem
            // 
            this.bnTableContentMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveNextItem.Image")));
            this.bnTableContentMoveNextItem.Name = "bnTableContentMoveNextItem";
            this.bnTableContentMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveNextItem.Size = new System.Drawing.Size(24, 25);
            this.bnTableContentMoveNextItem.Text = "Move next";
            // 
            // bnTableContentMoveLastItem
            // 
            this.bnTableContentMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveLastItem.Image")));
            this.bnTableContentMoveLastItem.Name = "bnTableContentMoveLastItem";
            this.bnTableContentMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveLastItem.Size = new System.Drawing.Size(24, 25);
            this.bnTableContentMoveLastItem.Text = "Move last";
            // 
            // bnTableContentSeparator2
            // 
            this.bnTableContentSeparator2.Name = "bnTableContentSeparator2";
            this.bnTableContentSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // gbUsedMilliseconds
            // 
            this.gbUsedMilliseconds.Controls.Add(this.lblUsedMs);
            this.gbUsedMilliseconds.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbUsedMilliseconds.Location = new System.Drawing.Point(0, 0);
            this.gbUsedMilliseconds.Name = "gbUsedMilliseconds";
            this.gbUsedMilliseconds.Size = new System.Drawing.Size(94, 49);
            this.gbUsedMilliseconds.TabIndex = 31;
            this.gbUsedMilliseconds.TabStop = false;
            this.gbUsedMilliseconds.Text = "DB costs (ms)";
            // 
            // lblUsedMs
            // 
            this.lblUsedMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsedMs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedMs.Location = new System.Drawing.Point(3, 18);
            this.lblUsedMs.Name = "lblUsedMs";
            this.lblUsedMs.Size = new System.Drawing.Size(88, 28);
            this.lblUsedMs.TabIndex = 0;
            this.lblUsedMs.Text = "0";
            this.lblUsedMs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlWatch
            // 
            this.pnlWatch.BackgroundImage = global::FBXpertLib.Properties.Resources.waiting2;
            this.pnlWatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWatch.Location = new System.Drawing.Point(611, 202);
            this.pnlWatch.Name = "pnlWatch";
            this.pnlWatch.Size = new System.Drawing.Size(230, 220);
            this.pnlWatch.TabIndex = 26;
            // 
            // tabMELDUNG
            // 
            this.tabMELDUNG.BackColor = System.Drawing.SystemColors.Control;
            this.tabMELDUNG.Controls.Add(this.pnlInfoCenter);
            this.tabMELDUNG.Controls.Add(this.pnlMessagesUpper);
            this.tabMELDUNG.ImageKey = "info_blue_22x.png";
            this.tabMELDUNG.Location = new System.Drawing.Point(4, 23);
            this.tabMELDUNG.Name = "tabMELDUNG";
            this.tabMELDUNG.Padding = new System.Windows.Forms.Padding(3);
            this.tabMELDUNG.Size = new System.Drawing.Size(1594, 621);
            this.tabMELDUNG.TabIndex = 2;
            this.tabMELDUNG.Text = "Messagens";
            // 
            // pnlInfoCenter
            // 
            this.pnlInfoCenter.Controls.Add(this.rtfMELDUNG);
            this.pnlInfoCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoCenter.Location = new System.Drawing.Point(3, 50);
            this.pnlInfoCenter.Name = "pnlInfoCenter";
            this.pnlInfoCenter.Size = new System.Drawing.Size(1588, 568);
            this.pnlInfoCenter.TabIndex = 25;
            // 
            // rtfMELDUNG
            // 
            this.rtfMELDUNG.BackColor = System.Drawing.SystemColors.Info;
            this.rtfMELDUNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfMELDUNG.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfMELDUNG.Location = new System.Drawing.Point(0, 0);
            this.rtfMELDUNG.Name = "rtfMELDUNG";
            this.rtfMELDUNG.Size = new System.Drawing.Size(1588, 568);
            this.rtfMELDUNG.TabIndex = 0;
            this.rtfMELDUNG.Text = "";
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsClearInfo);
            this.pnlMessagesUpper.Controls.Add(this.cbAutoScroll);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1588, 47);
            this.pnlMessagesUpper.TabIndex = 24;
            // 
            // hsClearInfo
            // 
            this.hsClearInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsClearInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearInfo.FlatAppearance.BorderSize = 0;
            this.hsClearInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearInfo.Image = global::FBXpertLib.Properties.Resources.documents_32x;
            this.hsClearInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearInfo.ImageHover = global::FBXpertLib.Properties.Resources.document_blue_x32;
            this.hsClearInfo.ImageToggleOnSelect = true;
            this.hsClearInfo.Location = new System.Drawing.Point(0, 0);
            this.hsClearInfo.Marked = false;
            this.hsClearInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearInfo.MarkedText = "";
            this.hsClearInfo.MarkMode = false;
            this.hsClearInfo.Name = "hsClearInfo";
            this.hsClearInfo.NonMarkedText = "Clear";
            this.hsClearInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearInfo.ShortcutNewline = false;
            this.hsClearInfo.ShowShortcut = false;
            this.hsClearInfo.Size = new System.Drawing.Size(69, 43);
            this.hsClearInfo.TabIndex = 27;
            this.hsClearInfo.Text = "Clear";
            this.hsClearInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearInfo.ToolTipActive = false;
            this.hsClearInfo.ToolTipAutomaticDelay = 500;
            this.hsClearInfo.ToolTipAutoPopDelay = 5000;
            this.hsClearInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearInfo.ToolTipFor4ContextMenu = true;
            this.hsClearInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearInfo.ToolTipInitialDelay = 500;
            this.hsClearInfo.ToolTipIsBallon = false;
            this.hsClearInfo.ToolTipOwnerDraw = false;
            this.hsClearInfo.ToolTipReshowDelay = 100;
            this.hsClearInfo.ToolTipShowAlways = false;
            this.hsClearInfo.ToolTipText = "";
            this.hsClearInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearInfo.ToolTipTitle = "";
            this.hsClearInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearInfo.UseVisualStyleBackColor = false;
            this.hsClearInfo.Click += new System.EventHandler(this.hsClearInfo_Click);
            // 
            // cbAutoScroll
            // 
            this.cbAutoScroll.AutoSize = true;
            this.cbAutoScroll.Checked = true;
            this.cbAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoScroll.Location = new System.Drawing.Point(98, 22);
            this.cbAutoScroll.Name = "cbAutoScroll";
            this.cbAutoScroll.Size = new System.Drawing.Size(81, 18);
            this.cbAutoScroll.TabIndex = 19;
            this.cbAutoScroll.Text = "Autoscroll";
            this.cbAutoScroll.UseVisualStyleBackColor = true;
            // 
            // tabERRORS
            // 
            this.tabERRORS.BackColor = System.Drawing.SystemColors.Control;
            this.tabERRORS.Controls.Add(this.pnlErrorUpper);
            this.tabERRORS.Controls.Add(this.pnlErrorsUpper);
            this.tabERRORS.ImageIndex = 11;
            this.tabERRORS.Location = new System.Drawing.Point(4, 23);
            this.tabERRORS.Name = "tabERRORS";
            this.tabERRORS.Padding = new System.Windows.Forms.Padding(3);
            this.tabERRORS.Size = new System.Drawing.Size(1594, 621);
            this.tabERRORS.TabIndex = 4;
            this.tabERRORS.Text = "Errors";
            // 
            // pnlErrorUpper
            // 
            this.pnlErrorUpper.Controls.Add(this.rtfERRORS);
            this.pnlErrorUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlErrorUpper.Location = new System.Drawing.Point(3, 50);
            this.pnlErrorUpper.Name = "pnlErrorUpper";
            this.pnlErrorUpper.Size = new System.Drawing.Size(1588, 568);
            this.pnlErrorUpper.TabIndex = 24;
            // 
            // rtfERRORS
            // 
            this.rtfERRORS.BackColor = System.Drawing.SystemColors.Info;
            this.rtfERRORS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfERRORS.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfERRORS.Location = new System.Drawing.Point(0, 0);
            this.rtfERRORS.Name = "rtfERRORS";
            this.rtfERRORS.Size = new System.Drawing.Size(1588, 568);
            this.rtfERRORS.TabIndex = 1;
            this.rtfERRORS.Text = "";
            // 
            // pnlErrorsUpper
            // 
            this.pnlErrorsUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlErrorsUpper.Controls.Add(this.cbAutoSrcollErr);
            this.pnlErrorsUpper.Controls.Add(this.hsClearErrorAll);
            this.pnlErrorsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlErrorsUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlErrorsUpper.Name = "pnlErrorsUpper";
            this.pnlErrorsUpper.Size = new System.Drawing.Size(1588, 47);
            this.pnlErrorsUpper.TabIndex = 23;
            // 
            // cbAutoSrcollErr
            // 
            this.cbAutoSrcollErr.AutoSize = true;
            this.cbAutoSrcollErr.Checked = true;
            this.cbAutoSrcollErr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoSrcollErr.Location = new System.Drawing.Point(100, 22);
            this.cbAutoSrcollErr.Name = "cbAutoSrcollErr";
            this.cbAutoSrcollErr.Size = new System.Drawing.Size(81, 18);
            this.cbAutoSrcollErr.TabIndex = 20;
            this.cbAutoSrcollErr.Text = "Autoscroll";
            this.cbAutoSrcollErr.UseVisualStyleBackColor = true;
            // 
            // hsClearErrorAll
            // 
            this.hsClearErrorAll.BackColor = System.Drawing.Color.Transparent;
            this.hsClearErrorAll.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearErrorAll.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearErrorAll.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearErrorAll.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearErrorAll.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearErrorAll.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearErrorAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearErrorAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearErrorAll.FlatAppearance.BorderSize = 0;
            this.hsClearErrorAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearErrorAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearErrorAll.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearErrorAll.Image = global::FBXpertLib.Properties.Resources.documents_32x;
            this.hsClearErrorAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearErrorAll.ImageHover = global::FBXpertLib.Properties.Resources.document_blue_x32;
            this.hsClearErrorAll.ImageToggleOnSelect = true;
            this.hsClearErrorAll.Location = new System.Drawing.Point(0, 0);
            this.hsClearErrorAll.Marked = false;
            this.hsClearErrorAll.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearErrorAll.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearErrorAll.MarkedText = "";
            this.hsClearErrorAll.MarkMode = false;
            this.hsClearErrorAll.Name = "hsClearErrorAll";
            this.hsClearErrorAll.NonMarkedText = "Clear All";
            this.hsClearErrorAll.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearErrorAll.ShortcutNewline = false;
            this.hsClearErrorAll.ShowShortcut = false;
            this.hsClearErrorAll.Size = new System.Drawing.Size(78, 43);
            this.hsClearErrorAll.TabIndex = 30;
            this.hsClearErrorAll.Text = "Clear All";
            this.hsClearErrorAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearErrorAll.ToolTipActive = false;
            this.hsClearErrorAll.ToolTipAutomaticDelay = 500;
            this.hsClearErrorAll.ToolTipAutoPopDelay = 5000;
            this.hsClearErrorAll.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearErrorAll.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearErrorAll.ToolTipFor4ContextMenu = true;
            this.hsClearErrorAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearErrorAll.ToolTipInitialDelay = 500;
            this.hsClearErrorAll.ToolTipIsBallon = false;
            this.hsClearErrorAll.ToolTipOwnerDraw = false;
            this.hsClearErrorAll.ToolTipReshowDelay = 100;
            this.hsClearErrorAll.ToolTipShowAlways = false;
            this.hsClearErrorAll.ToolTipText = "";
            this.hsClearErrorAll.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearErrorAll.ToolTipTitle = "";
            this.hsClearErrorAll.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearErrorAll.UseVisualStyleBackColor = false;
            this.hsClearErrorAll.Click += new System.EventHandler(this.hsClearErrorAll_Click);
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.SystemColors.Control;
            this.tabHistory.Controls.Add(this.pnlHistoryCenter);
            this.tabHistory.Controls.Add(this.pnlHistoryUpper);
            this.tabHistory.ImageIndex = 13;
            this.tabHistory.Location = new System.Drawing.Point(4, 23);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(1594, 621);
            this.tabHistory.TabIndex = 3;
            this.tabHistory.Text = "History";
            // 
            // pnlHistoryCenter
            // 
            this.pnlHistoryCenter.Controls.Add(this.dgvSQLHistory);
            this.pnlHistoryCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistoryCenter.Location = new System.Drawing.Point(3, 52);
            this.pnlHistoryCenter.Name = "pnlHistoryCenter";
            this.pnlHistoryCenter.Size = new System.Drawing.Size(1588, 566);
            this.pnlHistoryCenter.TabIndex = 24;
            // 
            // dgvSQLHistory
            // 
            this.dgvSQLHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSQLHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSQLHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLHistory.ContextMenuStrip = this.cmsHistory;
            this.dgvSQLHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSQLHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvSQLHistory.Name = "dgvSQLHistory";
            this.dgvSQLHistory.RowHeadersVisible = false;
            this.dgvSQLHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSQLHistory.Size = new System.Drawing.Size(1588, 566);
            this.dgvSQLHistory.TabIndex = 0;
            this.dgvSQLHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            this.dgvSQLHistory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSQLHistory_ColumnHeaderMouseClick);
            // 
            // cmsHistory
            // 
            this.cmsHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHistoryCopyToSQL,
            this.tsmiHistoryExecuteSQL,
            this.toolStripSeparator2,
            this.tsmiDeleteHistoryEntry});
            this.cmsHistory.Name = "cmsHistory";
            this.cmsHistory.Size = new System.Drawing.Size(141, 76);
            this.cmsHistory.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CmsHistory_ItemClicked);
            // 
            // tsmiHistoryCopyToSQL
            // 
            this.tsmiHistoryCopyToSQL.Image = global::FBXpertLib.Properties.Resources.SQL_blue_x24;
            this.tsmiHistoryCopyToSQL.Name = "tsmiHistoryCopyToSQL";
            this.tsmiHistoryCopyToSQL.Size = new System.Drawing.Size(140, 22);
            this.tsmiHistoryCopyToSQL.Text = "Copy to SQL";
            // 
            // tsmiHistoryExecuteSQL
            // 
            this.tsmiHistoryExecuteSQL.Image = global::FBXpertLib.Properties.Resources.applications_system_blue_22x;
            this.tsmiHistoryExecuteSQL.Name = "tsmiHistoryExecuteSQL";
            this.tsmiHistoryExecuteSQL.Size = new System.Drawing.Size(140, 22);
            this.tsmiHistoryExecuteSQL.Text = "Execute SQL";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiDeleteHistoryEntry
            // 
            this.tsmiDeleteHistoryEntry.Image = global::FBXpertLib.Properties.Resources.cross_red_x22;
            this.tsmiDeleteHistoryEntry.Name = "tsmiDeleteHistoryEntry";
            this.tsmiDeleteHistoryEntry.Size = new System.Drawing.Size(140, 22);
            this.tsmiDeleteHistoryEntry.Text = "Delete entry";
            // 
            // pnlHistoryUpper
            // 
            this.pnlHistoryUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHistoryUpper.Controls.Add(this.hsClearHistory);
            this.pnlHistoryUpper.Controls.Add(this.cbSQLfailed);
            this.pnlHistoryUpper.Controls.Add(this.cbSQLsucceded);
            this.pnlHistoryUpper.Controls.Add(this.cbAllHistory);
            this.pnlHistoryUpper.Controls.Add(this.hsRefreshHistory);
            this.pnlHistoryUpper.Controls.Add(this.hsExecuteHistorySelected);
            this.pnlHistoryUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlHistoryUpper.Name = "pnlHistoryUpper";
            this.pnlHistoryUpper.Size = new System.Drawing.Size(1588, 49);
            this.pnlHistoryUpper.TabIndex = 23;
            // 
            // hsClearHistory
            // 
            this.hsClearHistory.BackColor = System.Drawing.Color.Transparent;
            this.hsClearHistory.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearHistory.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearHistory.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearHistory.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearHistory.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearHistory.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearHistory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearHistory.FlatAppearance.BorderSize = 0;
            this.hsClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearHistory.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearHistory.Image = global::FBXpertLib.Properties.Resources.sweep_ge24x;
            this.hsClearHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearHistory.ImageHover = global::FBXpertLib.Properties.Resources.seewp_bl24x;
            this.hsClearHistory.ImageToggleOnSelect = true;
            this.hsClearHistory.Location = new System.Drawing.Point(90, 0);
            this.hsClearHistory.Marked = false;
            this.hsClearHistory.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearHistory.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearHistory.MarkedText = "";
            this.hsClearHistory.MarkMode = false;
            this.hsClearHistory.Name = "hsClearHistory";
            this.hsClearHistory.NonMarkedText = "Clear History";
            this.hsClearHistory.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearHistory.ShortcutNewline = false;
            this.hsClearHistory.ShowShortcut = false;
            this.hsClearHistory.Size = new System.Drawing.Size(90, 45);
            this.hsClearHistory.TabIndex = 37;
            this.hsClearHistory.Text = "Clear History";
            this.hsClearHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearHistory.ToolTipActive = false;
            this.hsClearHistory.ToolTipAutomaticDelay = 500;
            this.hsClearHistory.ToolTipAutoPopDelay = 5000;
            this.hsClearHistory.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearHistory.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearHistory.ToolTipFor4ContextMenu = true;
            this.hsClearHistory.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearHistory.ToolTipInitialDelay = 500;
            this.hsClearHistory.ToolTipIsBallon = false;
            this.hsClearHistory.ToolTipOwnerDraw = false;
            this.hsClearHistory.ToolTipReshowDelay = 100;
            this.hsClearHistory.ToolTipShowAlways = false;
            this.hsClearHistory.ToolTipText = "";
            this.hsClearHistory.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearHistory.ToolTipTitle = "";
            this.hsClearHistory.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearHistory.UseVisualStyleBackColor = false;
            this.hsClearHistory.Click += new System.EventHandler(this.hsClearHistory_Click);
            // 
            // cbSQLfailed
            // 
            this.cbSQLfailed.AutoSize = true;
            this.cbSQLfailed.Checked = true;
            this.cbSQLfailed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSQLfailed.Location = new System.Drawing.Point(550, 15);
            this.cbSQLfailed.Name = "cbSQLfailed";
            this.cbSQLfailed.Size = new System.Drawing.Size(81, 18);
            this.cbSQLfailed.TabIndex = 36;
            this.cbSQLfailed.Text = "SQL failed";
            this.cbSQLfailed.UseVisualStyleBackColor = true;
            this.cbSQLfailed.CheckedChanged += new System.EventHandler(this.CbAllHistory_CheckedChanged);
            // 
            // cbSQLsucceded
            // 
            this.cbSQLsucceded.AutoSize = true;
            this.cbSQLsucceded.Checked = true;
            this.cbSQLsucceded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSQLsucceded.Location = new System.Drawing.Point(405, 15);
            this.cbSQLsucceded.Name = "cbSQLsucceded";
            this.cbSQLsucceded.Size = new System.Drawing.Size(105, 18);
            this.cbSQLsucceded.TabIndex = 35;
            this.cbSQLsucceded.Text = "SQL successful";
            this.cbSQLsucceded.UseVisualStyleBackColor = true;
            this.cbSQLsucceded.CheckedChanged += new System.EventHandler(this.CbAllHistory_CheckedChanged);
            // 
            // cbAllHistory
            // 
            this.cbAllHistory.AutoSize = true;
            this.cbAllHistory.Location = new System.Drawing.Point(226, 15);
            this.cbAllHistory.Name = "cbAllHistory";
            this.cbAllHistory.Size = new System.Drawing.Size(166, 18);
            this.cbAllHistory.TabIndex = 34;
            this.cbAllHistory.Text = "Alle History Datenbanken";
            this.cbAllHistory.UseVisualStyleBackColor = true;
            this.cbAllHistory.CheckedChanged += new System.EventHandler(this.CbAllHistory_CheckedChanged);
            // 
            // hsRefreshHistory
            // 
            this.hsRefreshHistory.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshHistory.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshHistory.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshHistory.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshHistory.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshHistory.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshHistory.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshHistory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshHistory.FlatAppearance.BorderSize = 0;
            this.hsRefreshHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshHistory.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshHistory.Image = global::FBXpertLib.Properties.Resources.view_refresh22x;
            this.hsRefreshHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshHistory.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshHistory.ImageToggleOnSelect = true;
            this.hsRefreshHistory.Location = new System.Drawing.Point(1495, 0);
            this.hsRefreshHistory.Marked = false;
            this.hsRefreshHistory.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshHistory.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshHistory.MarkedText = "";
            this.hsRefreshHistory.MarkMode = false;
            this.hsRefreshHistory.Name = "hsRefreshHistory";
            this.hsRefreshHistory.NonMarkedText = "Refresh";
            this.hsRefreshHistory.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshHistory.ShortcutNewline = false;
            this.hsRefreshHistory.ShowShortcut = false;
            this.hsRefreshHistory.Size = new System.Drawing.Size(89, 45);
            this.hsRefreshHistory.TabIndex = 33;
            this.hsRefreshHistory.Text = "Refresh";
            this.hsRefreshHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshHistory.ToolTipActive = false;
            this.hsRefreshHistory.ToolTipAutomaticDelay = 500;
            this.hsRefreshHistory.ToolTipAutoPopDelay = 5000;
            this.hsRefreshHistory.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshHistory.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshHistory.ToolTipFor4ContextMenu = true;
            this.hsRefreshHistory.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshHistory.ToolTipInitialDelay = 500;
            this.hsRefreshHistory.ToolTipIsBallon = false;
            this.hsRefreshHistory.ToolTipOwnerDraw = false;
            this.hsRefreshHistory.ToolTipReshowDelay = 100;
            this.hsRefreshHistory.ToolTipShowAlways = false;
            this.hsRefreshHistory.ToolTipText = "";
            this.hsRefreshHistory.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshHistory.ToolTipTitle = "";
            this.hsRefreshHistory.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshHistory.UseVisualStyleBackColor = false;
            this.hsRefreshHistory.Click += new System.EventHandler(this.HsRefreshHistory_Click);
            // 
            // hsExecuteHistorySelected
            // 
            this.hsExecuteHistorySelected.BackColor = System.Drawing.Color.Transparent;
            this.hsExecuteHistorySelected.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExecuteHistorySelected.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExecuteHistorySelected.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExecuteHistorySelected.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExecuteHistorySelected.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExecuteHistorySelected.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExecuteHistorySelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsExecuteHistorySelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExecuteHistorySelected.FlatAppearance.BorderSize = 0;
            this.hsExecuteHistorySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExecuteHistorySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExecuteHistorySelected.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExecuteHistorySelected.Image = global::FBXpertLib.Properties.Resources.applications_system_22x;
            this.hsExecuteHistorySelected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExecuteHistorySelected.ImageHover = global::FBXpertLib.Properties.Resources.applications_system_blue_22x;
            this.hsExecuteHistorySelected.ImageToggleOnSelect = true;
            this.hsExecuteHistorySelected.Location = new System.Drawing.Point(0, 0);
            this.hsExecuteHistorySelected.Marked = false;
            this.hsExecuteHistorySelected.MarkedColor = System.Drawing.Color.Teal;
            this.hsExecuteHistorySelected.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExecuteHistorySelected.MarkedText = "";
            this.hsExecuteHistorySelected.MarkMode = false;
            this.hsExecuteHistorySelected.Name = "hsExecuteHistorySelected";
            this.hsExecuteHistorySelected.NonMarkedText = "Execute";
            this.hsExecuteHistorySelected.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExecuteHistorySelected.ShortcutNewline = false;
            this.hsExecuteHistorySelected.ShowShortcut = false;
            this.hsExecuteHistorySelected.Size = new System.Drawing.Size(90, 45);
            this.hsExecuteHistorySelected.TabIndex = 28;
            this.hsExecuteHistorySelected.Text = "Execute";
            this.hsExecuteHistorySelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExecuteHistorySelected.ToolTipActive = false;
            this.hsExecuteHistorySelected.ToolTipAutomaticDelay = 500;
            this.hsExecuteHistorySelected.ToolTipAutoPopDelay = 5000;
            this.hsExecuteHistorySelected.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExecuteHistorySelected.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExecuteHistorySelected.ToolTipFor4ContextMenu = true;
            this.hsExecuteHistorySelected.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExecuteHistorySelected.ToolTipInitialDelay = 500;
            this.hsExecuteHistorySelected.ToolTipIsBallon = false;
            this.hsExecuteHistorySelected.ToolTipOwnerDraw = false;
            this.hsExecuteHistorySelected.ToolTipReshowDelay = 100;
            this.hsExecuteHistorySelected.ToolTipShowAlways = false;
            this.hsExecuteHistorySelected.ToolTipText = "";
            this.hsExecuteHistorySelected.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExecuteHistorySelected.ToolTipTitle = "";
            this.hsExecuteHistorySelected.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExecuteHistorySelected.UseVisualStyleBackColor = false;
            this.hsExecuteHistorySelected.Click += new System.EventHandler(this.hsExecuteHistorySelected_Click);
            // 
            // tabRelpacelist
            // 
            this.tabRelpacelist.BackColor = System.Drawing.SystemColors.Control;
            this.tabRelpacelist.Controls.Add(this.pnlReplacesCenter);
            this.tabRelpacelist.Controls.Add(this.pnlRelpacesUpper);
            this.tabRelpacelist.ImageIndex = 12;
            this.tabRelpacelist.Location = new System.Drawing.Point(4, 23);
            this.tabRelpacelist.Name = "tabRelpacelist";
            this.tabRelpacelist.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelpacelist.Size = new System.Drawing.Size(1594, 621);
            this.tabRelpacelist.TabIndex = 5;
            this.tabRelpacelist.Text = "Replaces";
            // 
            // pnlReplacesCenter
            // 
            this.pnlReplacesCenter.Controls.Add(this.rtbReplace);
            this.pnlReplacesCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReplacesCenter.Location = new System.Drawing.Point(3, 51);
            this.pnlReplacesCenter.Name = "pnlReplacesCenter";
            this.pnlReplacesCenter.Size = new System.Drawing.Size(1588, 567);
            this.pnlReplacesCenter.TabIndex = 5;
            // 
            // rtbReplace
            // 
            this.rtbReplace.AcceptsTab = true;
            this.rtbReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReplace.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReplace.Location = new System.Drawing.Point(0, 0);
            this.rtbReplace.Name = "rtbReplace";
            this.rtbReplace.Size = new System.Drawing.Size(1588, 567);
            this.rtbReplace.TabIndex = 2;
            this.rtbReplace.Text = "";
            // 
            // pnlRelpacesUpper
            // 
            this.pnlRelpacesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRelpacesUpper.Controls.Add(this.hsLoadListReplaces);
            this.pnlRelpacesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRelpacesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlRelpacesUpper.Name = "pnlRelpacesUpper";
            this.pnlRelpacesUpper.Size = new System.Drawing.Size(1588, 48);
            this.pnlRelpacesUpper.TabIndex = 4;
            // 
            // hsLoadListReplaces
            // 
            this.hsLoadListReplaces.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadListReplaces.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadListReplaces.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadListReplaces.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadListReplaces.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadListReplaces.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadListReplaces.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadListReplaces.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadListReplaces.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadListReplaces.FlatAppearance.BorderSize = 0;
            this.hsLoadListReplaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadListReplaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadListReplaces.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadListReplaces.Image = global::FBXpertLib.Properties.Resources.folder_closed_22x;
            this.hsLoadListReplaces.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadListReplaces.ImageHover = global::FBXpertLib.Properties.Resources.folder_closed_22x;
            this.hsLoadListReplaces.ImageToggleOnSelect = true;
            this.hsLoadListReplaces.Location = new System.Drawing.Point(0, 0);
            this.hsLoadListReplaces.Marked = false;
            this.hsLoadListReplaces.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadListReplaces.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadListReplaces.MarkedText = "";
            this.hsLoadListReplaces.MarkMode = false;
            this.hsLoadListReplaces.Name = "hsLoadListReplaces";
            this.hsLoadListReplaces.NonMarkedText = "Load List";
            this.hsLoadListReplaces.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadListReplaces.ShortcutNewline = false;
            this.hsLoadListReplaces.ShowShortcut = false;
            this.hsLoadListReplaces.Size = new System.Drawing.Size(68, 44);
            this.hsLoadListReplaces.TabIndex = 31;
            this.hsLoadListReplaces.Text = "Load List";
            this.hsLoadListReplaces.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadListReplaces.ToolTipActive = false;
            this.hsLoadListReplaces.ToolTipAutomaticDelay = 500;
            this.hsLoadListReplaces.ToolTipAutoPopDelay = 5000;
            this.hsLoadListReplaces.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadListReplaces.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadListReplaces.ToolTipFor4ContextMenu = true;
            this.hsLoadListReplaces.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadListReplaces.ToolTipInitialDelay = 500;
            this.hsLoadListReplaces.ToolTipIsBallon = false;
            this.hsLoadListReplaces.ToolTipOwnerDraw = false;
            this.hsLoadListReplaces.ToolTipReshowDelay = 100;
            this.hsLoadListReplaces.ToolTipShowAlways = false;
            this.hsLoadListReplaces.ToolTipText = "";
            this.hsLoadListReplaces.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadListReplaces.ToolTipTitle = "";
            this.hsLoadListReplaces.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadListReplaces.UseVisualStyleBackColor = false;
            this.hsLoadListReplaces.Click += new System.EventHandler(this.hsLoadListReplaces_Click);
            // 
            // tabOptionen
            // 
            this.tabOptionen.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptionen.Controls.Add(this.cbClearListBeforeExcecute);
            this.tabOptionen.Controls.Add(this.groupBox3);
            this.tabOptionen.Controls.Add(this.gbKonfig);
            this.tabOptionen.Controls.Add(this.gpErrorausgabe);
            this.tabOptionen.Controls.Add(this.gbMeldungDirection);
            this.tabOptionen.ImageIndex = 3;
            this.tabOptionen.Location = new System.Drawing.Point(4, 23);
            this.tabOptionen.Name = "tabOptionen";
            this.tabOptionen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptionen.Size = new System.Drawing.Size(1594, 621);
            this.tabOptionen.TabIndex = 6;
            this.tabOptionen.Text = "Options";
            // 
            // cbClearListBeforeExcecute
            // 
            this.cbClearListBeforeExcecute.AutoSize = true;
            this.cbClearListBeforeExcecute.BackColor = System.Drawing.Color.Transparent;
            this.cbClearListBeforeExcecute.Checked = true;
            this.cbClearListBeforeExcecute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClearListBeforeExcecute.Location = new System.Drawing.Point(170, 250);
            this.cbClearListBeforeExcecute.Name = "cbClearListBeforeExcecute";
            this.cbClearListBeforeExcecute.Size = new System.Drawing.Size(165, 18);
            this.cbClearListBeforeExcecute.TabIndex = 28;
            this.cbClearListBeforeExcecute.Text = "Clear lists before execute";
            this.cbClearListBeforeExcecute.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbHistory);
            this.groupBox3.Controls.Add(this.cbErrors);
            this.groupBox3.Controls.Add(this.cbMeldungen);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listenausgaben";
            // 
            // gbKonfig
            // 
            this.gbKonfig.Controls.Add(this.txtErrIntervall);
            this.gbKonfig.Controls.Add(this.txtLogFile);
            this.gbKonfig.Controls.Add(this.secSERVERNAME);
            this.gbKonfig.Controls.Add(this.hsRefreshConfig);
            this.gbKonfig.Controls.Add(this.txtMeldIntervall);
            this.gbKonfig.Controls.Add(this.txtMeldLogFilePath);
            this.gbKonfig.Controls.Add(this.secDATABASEPATH);
            this.gbKonfig.Location = new System.Drawing.Point(600, 6);
            this.gbKonfig.Name = "gbKonfig";
            this.gbKonfig.Size = new System.Drawing.Size(405, 219);
            this.gbKonfig.TabIndex = 2;
            this.gbKonfig.TabStop = false;
            this.gbKonfig.Text = "Konfiguration";
            // 
            // txtErrIntervall
            // 
            this.txtErrIntervall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtErrIntervall.Caption = "Clear Intervall Errors";
            this.helpMain.SetHelpString(this.txtErrIntervall, "100");
            this.txtErrIntervall.Inhalt = "100";
            this.txtErrIntervall.Location = new System.Drawing.Point(18, 190);
            this.txtErrIntervall.Name = "txtErrIntervall";
            this.helpMain.SetShowHelp(this.txtErrIntervall, true);
            this.txtErrIntervall.Size = new System.Drawing.Size(235, 25);
            this.txtErrIntervall.TabIndex = 3;
            // 
            // txtLogFile
            // 
            this.txtLogFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogFile.Caption = "Logfile Name Alerts";
            this.txtLogFile.Inhalt = "FertProcApp.txt";
            this.txtLogFile.Location = new System.Drawing.Point(18, 128);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(235, 25);
            this.txtLogFile.TabIndex = 19;
            // 
            // secSERVERNAME
            // 
            this.secSERVERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secSERVERNAME.Caption = "Servername";
            this.secSERVERNAME.Inhalt = "";
            this.secSERVERNAME.Location = new System.Drawing.Point(18, 69);
            this.secSERVERNAME.Name = "secSERVERNAME";
            this.secSERVERNAME.Size = new System.Drawing.Size(263, 22);
            this.secSERVERNAME.TabIndex = 2;
            // 
            // hsRefreshConfig
            // 
            this.hsRefreshConfig.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshConfig.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshConfig.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshConfig.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshConfig.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshConfig.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshConfig.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshConfig.FlatAppearance.BorderSize = 0;
            this.hsRefreshConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshConfig.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshConfig.Image = global::FBXpertLib.Properties.Resources.view_refresh32x;
            this.hsRefreshConfig.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_32x;
            this.hsRefreshConfig.ImageToggleOnSelect = true;
            this.hsRefreshConfig.Location = new System.Drawing.Point(287, 19);
            this.hsRefreshConfig.Marked = false;
            this.hsRefreshConfig.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshConfig.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshConfig.MarkedText = "";
            this.hsRefreshConfig.MarkMode = false;
            this.hsRefreshConfig.Name = "hsRefreshConfig";
            this.hsRefreshConfig.NonMarkedText = "";
            this.hsRefreshConfig.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshConfig.ShortcutNewline = false;
            this.hsRefreshConfig.ShowShortcut = false;
            this.hsRefreshConfig.Size = new System.Drawing.Size(45, 45);
            this.hsRefreshConfig.TabIndex = 1;
            this.hsRefreshConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshConfig.ToolTipActive = false;
            this.hsRefreshConfig.ToolTipAutomaticDelay = 500;
            this.hsRefreshConfig.ToolTipAutoPopDelay = 5000;
            this.hsRefreshConfig.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshConfig.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshConfig.ToolTipFor4ContextMenu = true;
            this.hsRefreshConfig.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshConfig.ToolTipInitialDelay = 500;
            this.hsRefreshConfig.ToolTipIsBallon = false;
            this.hsRefreshConfig.ToolTipOwnerDraw = false;
            this.hsRefreshConfig.ToolTipReshowDelay = 100;
            this.hsRefreshConfig.ToolTipShowAlways = false;
            this.hsRefreshConfig.ToolTipText = "";
            this.hsRefreshConfig.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsRefreshConfig.ToolTipTitle = "";
            this.hsRefreshConfig.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshConfig.UseVisualStyleBackColor = true;
            this.hsRefreshConfig.Click += new System.EventHandler(this.hsRefreshConfig_Click);
            // 
            // txtMeldIntervall
            // 
            this.txtMeldIntervall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeldIntervall.Caption = "Clear Intervall Alerts";
            this.txtMeldIntervall.Inhalt = "100";
            this.txtMeldIntervall.Location = new System.Drawing.Point(18, 159);
            this.txtMeldIntervall.Name = "txtMeldIntervall";
            this.txtMeldIntervall.Size = new System.Drawing.Size(235, 25);
            this.txtMeldIntervall.TabIndex = 2;
            // 
            // txtMeldLogFilePath
            // 
            this.txtMeldLogFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeldLogFilePath.Caption = "Logfile Path Alerts";
            this.txtMeldLogFilePath.Inhalt = "E:\\Temp";
            this.txtMeldLogFilePath.Location = new System.Drawing.Point(18, 97);
            this.txtMeldLogFilePath.Name = "txtMeldLogFilePath";
            this.txtMeldLogFilePath.Size = new System.Drawing.Size(372, 25);
            this.txtMeldLogFilePath.TabIndex = 3;
            // 
            // secDATABASEPATH
            // 
            this.secDATABASEPATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secDATABASEPATH.Caption = "Database";
            this.secDATABASEPATH.Inhalt = "";
            this.secDATABASEPATH.Location = new System.Drawing.Point(18, 45);
            this.secDATABASEPATH.Name = "secDATABASEPATH";
            this.secDATABASEPATH.Size = new System.Drawing.Size(263, 22);
            this.secDATABASEPATH.TabIndex = 0;
            // 
            // gpErrorausgabe
            // 
            this.gpErrorausgabe.Controls.Add(this.rbErrInsert);
            this.gpErrorausgabe.Controls.Add(this.rbErrAppend);
            this.gpErrorausgabe.Location = new System.Drawing.Point(164, 144);
            this.gpErrorausgabe.Name = "gpErrorausgabe";
            this.gpErrorausgabe.Size = new System.Drawing.Size(430, 81);
            this.gpErrorausgabe.TabIndex = 1;
            this.gpErrorausgabe.TabStop = false;
            this.gpErrorausgabe.Text = "List of errors";
            // 
            // rbErrInsert
            // 
            this.rbErrInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbErrInsert.AutoSize = true;
            this.rbErrInsert.Location = new System.Drawing.Point(6, 19);
            this.rbErrInsert.Name = "rbErrInsert";
            this.rbErrInsert.Size = new System.Drawing.Size(96, 18);
            this.rbErrInsert.TabIndex = 1;
            this.rbErrInsert.Text = "On top of list";
            this.rbErrInsert.UseVisualStyleBackColor = true;
            // 
            // rbErrAppend
            // 
            this.rbErrAppend.AutoSize = true;
            this.rbErrAppend.Checked = true;
            this.rbErrAppend.Location = new System.Drawing.Point(6, 42);
            this.rbErrAppend.Name = "rbErrAppend";
            this.rbErrAppend.Size = new System.Drawing.Size(117, 18);
            this.rbErrAppend.TabIndex = 0;
            this.rbErrAppend.TabStop = true;
            this.rbErrAppend.Text = "On bottom of list";
            this.rbErrAppend.UseVisualStyleBackColor = true;
            // 
            // gbMeldungDirection
            // 
            this.gbMeldungDirection.Controls.Add(this.btnLoadMeld);
            this.gbMeldungDirection.Controls.Add(this.rbMeldInsert);
            this.gbMeldungDirection.Controls.Add(this.rbMeldAppend);
            this.gbMeldungDirection.Location = new System.Drawing.Point(164, 6);
            this.gbMeldungDirection.Name = "gbMeldungDirection";
            this.gbMeldungDirection.Size = new System.Drawing.Size(430, 132);
            this.gbMeldungDirection.TabIndex = 0;
            this.gbMeldungDirection.TabStop = false;
            this.gbMeldungDirection.Text = "List of alerts";
            // 
            // btnLoadMeld
            // 
            this.btnLoadMeld.FlatAppearance.BorderSize = 0;
            this.btnLoadMeld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMeld.Image = global::FBXpertLib.Properties.Resources.documents_plus_32x;
            this.btnLoadMeld.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadMeld.Location = new System.Drawing.Point(384, 80);
            this.btnLoadMeld.Name = "btnLoadMeld";
            this.btnLoadMeld.Size = new System.Drawing.Size(40, 42);
            this.btnLoadMeld.TabIndex = 18;
            this.btnLoadMeld.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadMeld.Click += new System.EventHandler(this.btnLoadMeld_Click);
            // 
            // rbMeldInsert
            // 
            this.rbMeldInsert.AutoSize = true;
            this.rbMeldInsert.Location = new System.Drawing.Point(6, 19);
            this.rbMeldInsert.Name = "rbMeldInsert";
            this.rbMeldInsert.Size = new System.Drawing.Size(96, 18);
            this.rbMeldInsert.TabIndex = 1;
            this.rbMeldInsert.Text = "On top of list";
            this.rbMeldInsert.UseVisualStyleBackColor = true;
            // 
            // rbMeldAppend
            // 
            this.rbMeldAppend.AutoSize = true;
            this.rbMeldAppend.Checked = true;
            this.rbMeldAppend.Location = new System.Drawing.Point(6, 42);
            this.rbMeldAppend.Name = "rbMeldAppend";
            this.rbMeldAppend.Size = new System.Drawing.Size(117, 18);
            this.rbMeldAppend.TabIndex = 0;
            this.rbMeldAppend.TabStop = true;
            this.rbMeldAppend.Text = "On bottom of list";
            this.rbMeldAppend.UseVisualStyleBackColor = true;
            // 
            // tabPagePlan
            // 
            this.tabPagePlan.Controls.Add(this.pnlPlanCenter);
            this.tabPagePlan.Controls.Add(this.pnlPlanLower);
            this.tabPagePlan.Controls.Add(this.pnlPlanUpper);
            this.tabPagePlan.ImageIndex = 16;
            this.tabPagePlan.Location = new System.Drawing.Point(4, 23);
            this.tabPagePlan.Name = "tabPagePlan";
            this.tabPagePlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlan.Size = new System.Drawing.Size(1594, 621);
            this.tabPagePlan.TabIndex = 7;
            this.tabPagePlan.Text = "Plan";
            this.tabPagePlan.UseVisualStyleBackColor = true;
            // 
            // pnlPlanCenter
            // 
            this.pnlPlanCenter.Controls.Add(this.fctPlan);
            this.pnlPlanCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlanCenter.Location = new System.Drawing.Point(3, 51);
            this.pnlPlanCenter.Name = "pnlPlanCenter";
            this.pnlPlanCenter.Size = new System.Drawing.Size(1588, 519);
            this.pnlPlanCenter.TabIndex = 7;
            // 
            // fctPlan
            // 
            this.fctPlan.AutoCompleteBracketsList = new char[] {
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
            this.fctPlan.AutoIndentCharsPatterns = "";
            this.fctPlan.AutoScrollMinSize = new System.Drawing.Size(154, 14);
            this.fctPlan.BackBrush = null;
            this.fctPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctPlan.CharHeight = 14;
            this.fctPlan.CharWidth = 8;
            this.fctPlan.CommentPrefix = "--";
            this.fctPlan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctPlan.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctPlan.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctPlan.IsReplaceMode = false;
            this.fctPlan.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctPlan.LeftBracket = '(';
            this.fctPlan.Location = new System.Drawing.Point(0, 0);
            this.fctPlan.Name = "fctPlan";
            this.fctPlan.Paddings = new System.Windows.Forms.Padding(0);
            this.fctPlan.RightBracket = ')';
            this.fctPlan.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctPlan.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctPlan.ServiceColors")));
            this.fctPlan.Size = new System.Drawing.Size(1588, 519);
            this.fctPlan.TabIndex = 0;
            this.fctPlan.Text = "fastColoredTextBox1";
            this.fctPlan.Zoom = 100;
            // 
            // pnlPlanLower
            // 
            this.pnlPlanLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlanLower.Location = new System.Drawing.Point(3, 570);
            this.pnlPlanLower.Name = "pnlPlanLower";
            this.pnlPlanLower.Size = new System.Drawing.Size(1588, 48);
            this.pnlPlanLower.TabIndex = 6;
            // 
            // pnlPlanUpper
            // 
            this.pnlPlanUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPlanUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlanUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlanUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlPlanUpper.Name = "pnlPlanUpper";
            this.pnlPlanUpper.Size = new System.Drawing.Size(1588, 48);
            this.pnlPlanUpper.TabIndex = 5;
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.tabControlExport);
            this.tabPageExport.ImageIndex = 15;
            this.tabPageExport.Location = new System.Drawing.Point(4, 23);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(1594, 621);
            this.tabPageExport.TabIndex = 8;
            this.tabPageExport.Text = "Export";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // tabControlExport
            // 
            this.tabControlExport.Controls.Add(this.tabPageXML);
            this.tabControlExport.Controls.Add(this.tabPageXMLScheme);
            this.tabControlExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExport.Location = new System.Drawing.Point(3, 3);
            this.tabControlExport.Name = "tabControlExport";
            this.tabControlExport.SelectedIndex = 0;
            this.tabControlExport.Size = new System.Drawing.Size(1588, 615);
            this.tabControlExport.TabIndex = 0;
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.fctXMLData);
            this.tabPageXML.Controls.Add(this.pnlXMLDataUpper);
            this.tabPageXML.Controls.Add(this.gbExportProgress);
            this.tabPageXML.Location = new System.Drawing.Point(4, 23);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXML.Size = new System.Drawing.Size(1580, 588);
            this.tabPageXML.TabIndex = 0;
            this.tabPageXML.Text = "XML-Data";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // fctXMLData
            // 
            this.fctXMLData.AutoCompleteBracketsList = new char[] {
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
            this.fctXMLData.AutoIndentCharsPatterns = "";
            this.fctXMLData.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctXMLData.BackBrush = null;
            this.fctXMLData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctXMLData.CharHeight = 14;
            this.fctXMLData.CharWidth = 8;
            this.fctXMLData.CommentPrefix = "--";
            this.fctXMLData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctXMLData.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctXMLData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctXMLData.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctXMLData.IsReplaceMode = false;
            this.fctXMLData.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctXMLData.LeftBracket = '(';
            this.fctXMLData.Location = new System.Drawing.Point(3, 51);
            this.fctXMLData.Name = "fctXMLData";
            this.fctXMLData.Paddings = new System.Windows.Forms.Padding(0);
            this.fctXMLData.RightBracket = ')';
            this.fctXMLData.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctXMLData.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctXMLData.ServiceColors")));
            this.fctXMLData.Size = new System.Drawing.Size(1574, 503);
            this.fctXMLData.TabIndex = 7;
            this.fctXMLData.Zoom = 100;
            // 
            // pnlXMLDataUpper
            // 
            this.pnlXMLDataUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlXMLDataUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlXMLDataUpper.Controls.Add(this.cbShowExportProgress);
            this.pnlXMLDataUpper.Controls.Add(this.hsExportBreak);
            this.pnlXMLDataUpper.Controls.Add(this.gbExportCosts);
            this.pnlXMLDataUpper.Controls.Add(this.ckClearExportListBeforeExecute);
            this.pnlXMLDataUpper.Controls.Add(this.ckMaskData);
            this.pnlXMLDataUpper.Controls.Add(this.gbExportLinesCount);
            this.pnlXMLDataUpper.Controls.Add(this.hotSpot2);
            this.pnlXMLDataUpper.Controls.Add(this.ckExportToScreen);
            this.pnlXMLDataUpper.Controls.Add(this.ckExportToFile);
            this.pnlXMLDataUpper.Controls.Add(this.hsExportHTML);
            this.pnlXMLDataUpper.Controls.Add(this.gbCSVSeperator);
            this.pnlXMLDataUpper.Controls.Add(this.hsExportCSV);
            this.pnlXMLDataUpper.Controls.Add(this.hsSaveXML);
            this.pnlXMLDataUpper.Controls.Add(this.hsRefreshXMLData);
            this.pnlXMLDataUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLDataUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlXMLDataUpper.Name = "pnlXMLDataUpper";
            this.pnlXMLDataUpper.Size = new System.Drawing.Size(1574, 48);
            this.pnlXMLDataUpper.TabIndex = 6;
            // 
            // cbShowExportProgress
            // 
            this.cbShowExportProgress.AutoSize = true;
            this.cbShowExportProgress.Checked = true;
            this.cbShowExportProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowExportProgress.Location = new System.Drawing.Point(1312, 5);
            this.cbShowExportProgress.Name = "cbShowExportProgress";
            this.cbShowExportProgress.Size = new System.Drawing.Size(105, 18);
            this.cbShowExportProgress.TabIndex = 45;
            this.cbShowExportProgress.Text = "Show progress";
            this.cbShowExportProgress.UseVisualStyleBackColor = true;
            // 
            // hsExportBreak
            // 
            this.hsExportBreak.BackColor = System.Drawing.Color.Transparent;
            this.hsExportBreak.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportBreak.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportBreak.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportBreak.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportBreak.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportBreak.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportBreak.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsExportBreak.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportBreak.FlatAppearance.BorderSize = 0;
            this.hsExportBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportBreak.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportBreak.Image = global::FBXpertLib.Properties.Resources.cross_red_x22;
            this.hsExportBreak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportBreak.ImageHover = global::FBXpertLib.Properties.Resources.cross_blue_x22;
            this.hsExportBreak.ImageToggleOnSelect = true;
            this.hsExportBreak.Location = new System.Drawing.Point(546, 0);
            this.hsExportBreak.Marked = false;
            this.hsExportBreak.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportBreak.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportBreak.MarkedText = "";
            this.hsExportBreak.MarkMode = false;
            this.hsExportBreak.Name = "hsExportBreak";
            this.hsExportBreak.NonMarkedText = "Break";
            this.hsExportBreak.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExportBreak.ShortcutNewline = false;
            this.hsExportBreak.ShowShortcut = false;
            this.hsExportBreak.Size = new System.Drawing.Size(68, 44);
            this.hsExportBreak.TabIndex = 44;
            this.hsExportBreak.Text = "Break";
            this.hsExportBreak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportBreak.ToolTipActive = false;
            this.hsExportBreak.ToolTipAutomaticDelay = 500;
            this.hsExportBreak.ToolTipAutoPopDelay = 5000;
            this.hsExportBreak.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportBreak.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportBreak.ToolTipFor4ContextMenu = true;
            this.hsExportBreak.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportBreak.ToolTipInitialDelay = 500;
            this.hsExportBreak.ToolTipIsBallon = false;
            this.hsExportBreak.ToolTipOwnerDraw = false;
            this.hsExportBreak.ToolTipReshowDelay = 100;
            this.hsExportBreak.ToolTipShowAlways = false;
            this.hsExportBreak.ToolTipText = "";
            this.hsExportBreak.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportBreak.ToolTipTitle = "";
            this.hsExportBreak.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportBreak.UseVisualStyleBackColor = false;
            this.hsExportBreak.Click += new System.EventHandler(this.HsExportBreak_Click);
            // 
            // gbExportCosts
            // 
            this.gbExportCosts.Controls.Add(this.lblExportCosts);
            this.gbExportCosts.Location = new System.Drawing.Point(763, 4);
            this.gbExportCosts.Name = "gbExportCosts";
            this.gbExportCosts.Size = new System.Drawing.Size(121, 43);
            this.gbExportCosts.TabIndex = 43;
            this.gbExportCosts.TabStop = false;
            this.gbExportCosts.Text = "Export costs (ms)";
            // 
            // lblExportCosts
            // 
            this.lblExportCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExportCosts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportCosts.Location = new System.Drawing.Point(3, 18);
            this.lblExportCosts.Name = "lblExportCosts";
            this.lblExportCosts.Size = new System.Drawing.Size(115, 22);
            this.lblExportCosts.TabIndex = 0;
            this.lblExportCosts.Text = "0";
            this.lblExportCosts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckClearExportListBeforeExecute
            // 
            this.ckClearExportListBeforeExecute.AutoSize = true;
            this.ckClearExportListBeforeExecute.BackColor = System.Drawing.Color.Transparent;
            this.ckClearExportListBeforeExecute.Checked = true;
            this.ckClearExportListBeforeExecute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearExportListBeforeExecute.Location = new System.Drawing.Point(1147, 4);
            this.ckClearExportListBeforeExecute.Name = "ckClearExportListBeforeExecute";
            this.ckClearExportListBeforeExecute.Size = new System.Drawing.Size(165, 18);
            this.ckClearExportListBeforeExecute.TabIndex = 42;
            this.ckClearExportListBeforeExecute.Text = "Clear lists before execute";
            this.ckClearExportListBeforeExecute.UseVisualStyleBackColor = false;
            // 
            // ckMaskData
            // 
            this.ckMaskData.AutoSize = true;
            this.ckMaskData.Location = new System.Drawing.Point(1147, 25);
            this.ckMaskData.Name = "ckMaskData";
            this.ckMaskData.Size = new System.Drawing.Size(108, 18);
            this.ckMaskData.TabIndex = 41;
            this.ckMaskData.Text = "Mask Datas \"x\"";
            this.ckMaskData.UseVisualStyleBackColor = true;
            // 
            // gbExportLinesCount
            // 
            this.gbExportLinesCount.Controls.Add(this.lblExportLinesCount);
            this.gbExportLinesCount.Location = new System.Drawing.Point(656, 3);
            this.gbExportLinesCount.Name = "gbExportLinesCount";
            this.gbExportLinesCount.Size = new System.Drawing.Size(101, 40);
            this.gbExportLinesCount.TabIndex = 40;
            this.gbExportLinesCount.TabStop = false;
            this.gbExportLinesCount.Text = "Anzahl";
            // 
            // lblExportLinesCount
            // 
            this.lblExportLinesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExportLinesCount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportLinesCount.Location = new System.Drawing.Point(3, 18);
            this.lblExportLinesCount.Name = "lblExportLinesCount";
            this.lblExportLinesCount.Size = new System.Drawing.Size(95, 19);
            this.lblExportLinesCount.TabIndex = 0;
            this.lblExportLinesCount.Text = "0";
            this.lblExportLinesCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.hotSpot2.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hotSpot2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot2.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hotSpot2.ImageToggleOnSelect = true;
            this.hotSpot2.Location = new System.Drawing.Point(374, 0);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "Run SQL and Export as CSV";
            this.hotSpot2.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot2.ShortcutNewline = false;
            this.hotSpot2.ShowShortcut = false;
            this.hotSpot2.Size = new System.Drawing.Size(172, 44);
            this.hotSpot2.TabIndex = 39;
            this.hotSpot2.Text = "Run SQL and Export as CSV";
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
            this.hotSpot2.Click += new System.EventHandler(this.HotSpot2_Click);
            // 
            // ckExportToScreen
            // 
            this.ckExportToScreen.AutoSize = true;
            this.ckExportToScreen.Location = new System.Drawing.Point(1018, 5);
            this.ckExportToScreen.Name = "ckExportToScreen";
            this.ckExportToScreen.Size = new System.Drawing.Size(112, 18);
            this.ckExportToScreen.TabIndex = 38;
            this.ckExportToScreen.Text = "Export to screen";
            this.ckExportToScreen.UseVisualStyleBackColor = true;
            // 
            // ckExportToFile
            // 
            this.ckExportToFile.AutoSize = true;
            this.ckExportToFile.Checked = true;
            this.ckExportToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckExportToFile.Location = new System.Drawing.Point(1018, 25);
            this.ckExportToFile.Name = "ckExportToFile";
            this.ckExportToFile.Size = new System.Drawing.Size(93, 18);
            this.ckExportToFile.TabIndex = 37;
            this.ckExportToFile.Text = "Export to file";
            this.ckExportToFile.UseVisualStyleBackColor = true;
            // 
            // hsExportHTML
            // 
            this.hsExportHTML.BackColor = System.Drawing.Color.Transparent;
            this.hsExportHTML.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportHTML.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportHTML.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportHTML.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportHTML.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportHTML.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportHTML.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsExportHTML.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportHTML.FlatAppearance.BorderSize = 0;
            this.hsExportHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportHTML.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportHTML.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hsExportHTML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportHTML.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hsExportHTML.ImageToggleOnSelect = true;
            this.hsExportHTML.Location = new System.Drawing.Point(263, 0);
            this.hsExportHTML.Marked = false;
            this.hsExportHTML.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportHTML.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportHTML.MarkedText = "";
            this.hsExportHTML.MarkMode = false;
            this.hsExportHTML.Name = "hsExportHTML";
            this.hsExportHTML.NonMarkedText = "Export as HTML";
            this.hsExportHTML.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExportHTML.ShortcutNewline = false;
            this.hsExportHTML.ShowShortcut = false;
            this.hsExportHTML.Size = new System.Drawing.Size(111, 44);
            this.hsExportHTML.TabIndex = 36;
            this.hsExportHTML.Text = "Export as HTML";
            this.hsExportHTML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportHTML.ToolTipActive = false;
            this.hsExportHTML.ToolTipAutomaticDelay = 500;
            this.hsExportHTML.ToolTipAutoPopDelay = 5000;
            this.hsExportHTML.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportHTML.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportHTML.ToolTipFor4ContextMenu = true;
            this.hsExportHTML.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportHTML.ToolTipInitialDelay = 500;
            this.hsExportHTML.ToolTipIsBallon = false;
            this.hsExportHTML.ToolTipOwnerDraw = false;
            this.hsExportHTML.ToolTipReshowDelay = 100;
            this.hsExportHTML.ToolTipShowAlways = false;
            this.hsExportHTML.ToolTipText = "";
            this.hsExportHTML.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportHTML.ToolTipTitle = "";
            this.hsExportHTML.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportHTML.UseVisualStyleBackColor = false;
            this.hsExportHTML.Click += new System.EventHandler(this.hsExportHTML_Click);
            // 
            // gbCSVSeperator
            // 
            this.gbCSVSeperator.Controls.Add(this.cbCSVSeperator);
            this.gbCSVSeperator.Location = new System.Drawing.Point(891, 3);
            this.gbCSVSeperator.Name = "gbCSVSeperator";
            this.gbCSVSeperator.Size = new System.Drawing.Size(94, 44);
            this.gbCSVSeperator.TabIndex = 35;
            this.gbCSVSeperator.TabStop = false;
            this.gbCSVSeperator.Text = "CSV Seperator";
            // 
            // cbCSVSeperator
            // 
            this.cbCSVSeperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCSVSeperator.FormattingEnabled = true;
            this.cbCSVSeperator.Items.AddRange(new object[] {
            ";",
            ",",
            "#"});
            this.cbCSVSeperator.Location = new System.Drawing.Point(3, 18);
            this.cbCSVSeperator.Name = "cbCSVSeperator";
            this.cbCSVSeperator.Size = new System.Drawing.Size(32, 22);
            this.cbCSVSeperator.TabIndex = 34;
            this.cbCSVSeperator.Text = ";";
            // 
            // hsExportCSV
            // 
            this.hsExportCSV.BackColor = System.Drawing.Color.Transparent;
            this.hsExportCSV.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportCSV.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportCSV.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportCSV.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportCSV.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportCSV.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportCSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsExportCSV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportCSV.FlatAppearance.BorderSize = 0;
            this.hsExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportCSV.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportCSV.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hsExportCSV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportCSV.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hsExportCSV.ImageToggleOnSelect = true;
            this.hsExportCSV.Location = new System.Drawing.Point(111, 0);
            this.hsExportCSV.Marked = false;
            this.hsExportCSV.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportCSV.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportCSV.MarkedText = "";
            this.hsExportCSV.MarkMode = false;
            this.hsExportCSV.Name = "hsExportCSV";
            this.hsExportCSV.NonMarkedText = "Export results as CSV";
            this.hsExportCSV.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExportCSV.ShortcutNewline = false;
            this.hsExportCSV.ShowShortcut = false;
            this.hsExportCSV.Size = new System.Drawing.Size(152, 44);
            this.hsExportCSV.TabIndex = 33;
            this.hsExportCSV.Text = "Export results as CSV";
            this.hsExportCSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportCSV.ToolTipActive = false;
            this.hsExportCSV.ToolTipAutomaticDelay = 500;
            this.hsExportCSV.ToolTipAutoPopDelay = 5000;
            this.hsExportCSV.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportCSV.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportCSV.ToolTipFor4ContextMenu = true;
            this.hsExportCSV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportCSV.ToolTipInitialDelay = 500;
            this.hsExportCSV.ToolTipIsBallon = false;
            this.hsExportCSV.ToolTipOwnerDraw = false;
            this.hsExportCSV.ToolTipReshowDelay = 100;
            this.hsExportCSV.ToolTipShowAlways = false;
            this.hsExportCSV.ToolTipText = "";
            this.hsExportCSV.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportCSV.ToolTipTitle = "";
            this.hsExportCSV.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportCSV.UseVisualStyleBackColor = false;
            this.hsExportCSV.Click += new System.EventHandler(this.hsExportCSV_Click);
            // 
            // hsSaveXML
            // 
            this.hsSaveXML.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveXML.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveXML.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveXML.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveXML.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveXML.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveXML.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveXML.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveXML.FlatAppearance.BorderSize = 0;
            this.hsSaveXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveXML.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveXML.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hsSaveXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveXML.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hsSaveXML.ImageToggleOnSelect = true;
            this.hsSaveXML.Location = new System.Drawing.Point(0, 0);
            this.hsSaveXML.Marked = false;
            this.hsSaveXML.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveXML.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveXML.MarkedText = "";
            this.hsSaveXML.MarkMode = false;
            this.hsSaveXML.Name = "hsSaveXML";
            this.hsSaveXML.NonMarkedText = "Save XML-Data";
            this.hsSaveXML.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveXML.ShortcutNewline = false;
            this.hsSaveXML.ShowShortcut = false;
            this.hsSaveXML.Size = new System.Drawing.Size(111, 44);
            this.hsSaveXML.TabIndex = 32;
            this.hsSaveXML.Text = "Save XML-Data";
            this.hsSaveXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveXML.ToolTipActive = false;
            this.hsSaveXML.ToolTipAutomaticDelay = 500;
            this.hsSaveXML.ToolTipAutoPopDelay = 5000;
            this.hsSaveXML.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveXML.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveXML.ToolTipFor4ContextMenu = true;
            this.hsSaveXML.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveXML.ToolTipInitialDelay = 500;
            this.hsSaveXML.ToolTipIsBallon = false;
            this.hsSaveXML.ToolTipOwnerDraw = false;
            this.hsSaveXML.ToolTipReshowDelay = 100;
            this.hsSaveXML.ToolTipShowAlways = false;
            this.hsSaveXML.ToolTipText = "";
            this.hsSaveXML.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveXML.ToolTipTitle = "";
            this.hsSaveXML.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveXML.UseVisualStyleBackColor = false;
            this.hsSaveXML.Click += new System.EventHandler(this.hsSaveXML_Click);
            // 
            // hsRefreshXMLData
            // 
            this.hsRefreshXMLData.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshXMLData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshXMLData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshXMLData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshXMLData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshXMLData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshXMLData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshXMLData.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshXMLData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshXMLData.FlatAppearance.BorderSize = 0;
            this.hsRefreshXMLData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshXMLData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshXMLData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshXMLData.Image = global::FBXpertLib.Properties.Resources.view_refresh22x;
            this.hsRefreshXMLData.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshXMLData.ImageToggleOnSelect = true;
            this.hsRefreshXMLData.Location = new System.Drawing.Point(1525, 0);
            this.hsRefreshXMLData.Marked = false;
            this.hsRefreshXMLData.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshXMLData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshXMLData.MarkedText = "";
            this.hsRefreshXMLData.MarkMode = false;
            this.hsRefreshXMLData.Name = "hsRefreshXMLData";
            this.hsRefreshXMLData.NonMarkedText = "";
            this.hsRefreshXMLData.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshXMLData.ShortcutNewline = false;
            this.hsRefreshXMLData.ShowShortcut = false;
            this.hsRefreshXMLData.Size = new System.Drawing.Size(45, 44);
            this.hsRefreshXMLData.TabIndex = 3;
            this.hsRefreshXMLData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshXMLData.ToolTipActive = false;
            this.hsRefreshXMLData.ToolTipAutomaticDelay = 500;
            this.hsRefreshXMLData.ToolTipAutoPopDelay = 5000;
            this.hsRefreshXMLData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshXMLData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshXMLData.ToolTipFor4ContextMenu = true;
            this.hsRefreshXMLData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshXMLData.ToolTipInitialDelay = 500;
            this.hsRefreshXMLData.ToolTipIsBallon = false;
            this.hsRefreshXMLData.ToolTipOwnerDraw = false;
            this.hsRefreshXMLData.ToolTipReshowDelay = 100;
            this.hsRefreshXMLData.ToolTipShowAlways = false;
            this.hsRefreshXMLData.ToolTipText = "";
            this.hsRefreshXMLData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshXMLData.ToolTipTitle = "";
            this.hsRefreshXMLData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshXMLData.UseVisualStyleBackColor = false;
            this.hsRefreshXMLData.Click += new System.EventHandler(this.hsRefreshXMLData_Click);
            // 
            // gbExportProgress
            // 
            this.gbExportProgress.Controls.Add(this.pbExport);
            this.gbExportProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbExportProgress.Location = new System.Drawing.Point(3, 554);
            this.gbExportProgress.Name = "gbExportProgress";
            this.gbExportProgress.Size = new System.Drawing.Size(1574, 31);
            this.gbExportProgress.TabIndex = 8;
            this.gbExportProgress.TabStop = false;
            this.gbExportProgress.Text = "Progress";
            // 
            // pbExport
            // 
            this.pbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbExport.Location = new System.Drawing.Point(3, 18);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(1568, 10);
            this.pbExport.TabIndex = 0;
            // 
            // tabPageXMLScheme
            // 
            this.tabPageXMLScheme.Controls.Add(this.fctXMLScheme);
            this.tabPageXMLScheme.Controls.Add(this.pnlXMLSchemeUpper);
            this.tabPageXMLScheme.Location = new System.Drawing.Point(4, 23);
            this.tabPageXMLScheme.Name = "tabPageXMLScheme";
            this.tabPageXMLScheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXMLScheme.Size = new System.Drawing.Size(1580, 588);
            this.tabPageXMLScheme.TabIndex = 1;
            this.tabPageXMLScheme.Text = "XML-Schema";
            this.tabPageXMLScheme.UseVisualStyleBackColor = true;
            // 
            // fctXMLScheme
            // 
            this.fctXMLScheme.AutoCompleteBracketsList = new char[] {
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
            this.fctXMLScheme.AutoIndentCharsPatterns = "";
            this.fctXMLScheme.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctXMLScheme.BackBrush = null;
            this.fctXMLScheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctXMLScheme.CharHeight = 14;
            this.fctXMLScheme.CharWidth = 8;
            this.fctXMLScheme.CommentPrefix = "--";
            this.fctXMLScheme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctXMLScheme.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctXMLScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctXMLScheme.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctXMLScheme.IsReplaceMode = false;
            this.fctXMLScheme.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctXMLScheme.LeftBracket = '(';
            this.fctXMLScheme.Location = new System.Drawing.Point(3, 51);
            this.fctXMLScheme.Name = "fctXMLScheme";
            this.fctXMLScheme.Paddings = new System.Windows.Forms.Padding(0);
            this.fctXMLScheme.RightBracket = ')';
            this.fctXMLScheme.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctXMLScheme.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctXMLScheme.ServiceColors")));
            this.fctXMLScheme.Size = new System.Drawing.Size(1574, 534);
            this.fctXMLScheme.TabIndex = 9;
            this.fctXMLScheme.Zoom = 100;
            // 
            // pnlXMLSchemeUpper
            // 
            this.pnlXMLSchemeUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlXMLSchemeUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlXMLSchemeUpper.Controls.Add(this.hsSaveXMLScheme);
            this.pnlXMLSchemeUpper.Controls.Add(this.hsRefreshXMLScheme);
            this.pnlXMLSchemeUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLSchemeUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlXMLSchemeUpper.Name = "pnlXMLSchemeUpper";
            this.pnlXMLSchemeUpper.Size = new System.Drawing.Size(1574, 48);
            this.pnlXMLSchemeUpper.TabIndex = 8;
            // 
            // hsSaveXMLScheme
            // 
            this.hsSaveXMLScheme.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveXMLScheme.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveXMLScheme.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveXMLScheme.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveXMLScheme.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveXMLScheme.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveXMLScheme.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveXMLScheme.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveXMLScheme.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveXMLScheme.FlatAppearance.BorderSize = 0;
            this.hsSaveXMLScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveXMLScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveXMLScheme.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveXMLScheme.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hsSaveXMLScheme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveXMLScheme.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hsSaveXMLScheme.ImageToggleOnSelect = true;
            this.hsSaveXMLScheme.Location = new System.Drawing.Point(0, 0);
            this.hsSaveXMLScheme.Marked = false;
            this.hsSaveXMLScheme.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveXMLScheme.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveXMLScheme.MarkedText = "";
            this.hsSaveXMLScheme.MarkMode = false;
            this.hsSaveXMLScheme.Name = "hsSaveXMLScheme";
            this.hsSaveXMLScheme.NonMarkedText = "Save XML-Scheme";
            this.hsSaveXMLScheme.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveXMLScheme.ShortcutNewline = false;
            this.hsSaveXMLScheme.ShowShortcut = false;
            this.hsSaveXMLScheme.Size = new System.Drawing.Size(111, 44);
            this.hsSaveXMLScheme.TabIndex = 33;
            this.hsSaveXMLScheme.Text = "Save XML-Scheme";
            this.hsSaveXMLScheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveXMLScheme.ToolTipActive = false;
            this.hsSaveXMLScheme.ToolTipAutomaticDelay = 500;
            this.hsSaveXMLScheme.ToolTipAutoPopDelay = 5000;
            this.hsSaveXMLScheme.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveXMLScheme.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveXMLScheme.ToolTipFor4ContextMenu = true;
            this.hsSaveXMLScheme.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveXMLScheme.ToolTipInitialDelay = 500;
            this.hsSaveXMLScheme.ToolTipIsBallon = false;
            this.hsSaveXMLScheme.ToolTipOwnerDraw = false;
            this.hsSaveXMLScheme.ToolTipReshowDelay = 100;
            this.hsSaveXMLScheme.ToolTipShowAlways = false;
            this.hsSaveXMLScheme.ToolTipText = "";
            this.hsSaveXMLScheme.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveXMLScheme.ToolTipTitle = "";
            this.hsSaveXMLScheme.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveXMLScheme.UseVisualStyleBackColor = false;
            this.hsSaveXMLScheme.Click += new System.EventHandler(this.hsSaveXMLScheme_Click);
            // 
            // hsRefreshXMLScheme
            // 
            this.hsRefreshXMLScheme.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshXMLScheme.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshXMLScheme.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshXMLScheme.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshXMLScheme.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshXMLScheme.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshXMLScheme.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshXMLScheme.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshXMLScheme.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshXMLScheme.FlatAppearance.BorderSize = 0;
            this.hsRefreshXMLScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshXMLScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshXMLScheme.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshXMLScheme.Image = global::FBXpertLib.Properties.Resources.view_refresh22x;
            this.hsRefreshXMLScheme.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshXMLScheme.ImageToggleOnSelect = true;
            this.hsRefreshXMLScheme.Location = new System.Drawing.Point(1525, 0);
            this.hsRefreshXMLScheme.Marked = false;
            this.hsRefreshXMLScheme.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshXMLScheme.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshXMLScheme.MarkedText = "";
            this.hsRefreshXMLScheme.MarkMode = false;
            this.hsRefreshXMLScheme.Name = "hsRefreshXMLScheme";
            this.hsRefreshXMLScheme.NonMarkedText = "";
            this.hsRefreshXMLScheme.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshXMLScheme.ShortcutNewline = false;
            this.hsRefreshXMLScheme.ShowShortcut = false;
            this.hsRefreshXMLScheme.Size = new System.Drawing.Size(45, 44);
            this.hsRefreshXMLScheme.TabIndex = 3;
            this.hsRefreshXMLScheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshXMLScheme.ToolTipActive = false;
            this.hsRefreshXMLScheme.ToolTipAutomaticDelay = 500;
            this.hsRefreshXMLScheme.ToolTipAutoPopDelay = 5000;
            this.hsRefreshXMLScheme.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshXMLScheme.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshXMLScheme.ToolTipFor4ContextMenu = true;
            this.hsRefreshXMLScheme.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshXMLScheme.ToolTipInitialDelay = 500;
            this.hsRefreshXMLScheme.ToolTipIsBallon = false;
            this.hsRefreshXMLScheme.ToolTipOwnerDraw = false;
            this.hsRefreshXMLScheme.ToolTipReshowDelay = 100;
            this.hsRefreshXMLScheme.ToolTipShowAlways = false;
            this.hsRefreshXMLScheme.ToolTipText = "";
            this.hsRefreshXMLScheme.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshXMLScheme.ToolTipTitle = "";
            this.hsRefreshXMLScheme.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshXMLScheme.UseVisualStyleBackColor = false;
            this.hsRefreshXMLScheme.Click += new System.EventHandler(this.hsRefreshXMLScheme_Click);
            // 
            // tabPagePerformance
            // 
            this.tabPagePerformance.Controls.Add(this.gbPerformance);
            this.tabPagePerformance.Controls.Add(this.pnlPerformanceUpper);
            this.tabPagePerformance.ImageIndex = 16;
            this.tabPagePerformance.Location = new System.Drawing.Point(4, 23);
            this.tabPagePerformance.Name = "tabPagePerformance";
            this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerformance.Size = new System.Drawing.Size(1594, 621);
            this.tabPagePerformance.TabIndex = 9;
            this.tabPagePerformance.Text = "Performance";
            this.tabPagePerformance.UseVisualStyleBackColor = true;
            // 
            // gbPerformance
            // 
            this.gbPerformance.Controls.Add(this.lvPerformance);
            this.gbPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPerformance.Location = new System.Drawing.Point(3, 51);
            this.gbPerformance.Name = "gbPerformance";
            this.gbPerformance.Size = new System.Drawing.Size(1588, 567);
            this.gbPerformance.TabIndex = 8;
            this.gbPerformance.TabStop = false;
            // 
            // lvPerformance
            // 
            this.lvPerformance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSQL,
            this.colMEMUSAGE,
            this.colSEQ_READS,
            this.colINX_READS,
            this.colINSERTS,
            this.colUPDATES,
            this.colDELETES,
            this.colCONFLICTS});
            this.lvPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPerformance.GridLines = true;
            this.lvPerformance.HideSelection = false;
            this.lvPerformance.Location = new System.Drawing.Point(3, 18);
            this.lvPerformance.Name = "lvPerformance";
            this.lvPerformance.Size = new System.Drawing.Size(1582, 546);
            this.lvPerformance.TabIndex = 0;
            this.lvPerformance.UseCompatibleStateImageBehavior = false;
            this.lvPerformance.View = System.Windows.Forms.View.Details;
            // 
            // colSQL
            // 
            this.colSQL.Text = "SQL Text";
            this.colSQL.Width = 500;
            // 
            // colMEMUSAGE
            // 
            this.colMEMUSAGE.Text = "Mem usage";
            this.colMEMUSAGE.Width = 100;
            // 
            // colSEQ_READS
            // 
            this.colSEQ_READS.Text = "seq reads";
            this.colSEQ_READS.Width = 100;
            // 
            // colINX_READS
            // 
            this.colINX_READS.Text = "index reads";
            this.colINX_READS.Width = 100;
            // 
            // colINSERTS
            // 
            this.colINSERTS.Text = "inserts";
            // 
            // colUPDATES
            // 
            this.colUPDATES.Text = "updates";
            // 
            // colDELETES
            // 
            this.colDELETES.Text = "deletes";
            // 
            // colCONFLICTS
            // 
            this.colCONFLICTS.Text = "write conflicts";
            // 
            // pnlPerformanceUpper
            // 
            this.pnlPerformanceUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPerformanceUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPerformanceUpper.Controls.Add(this.hotSpot1);
            this.pnlPerformanceUpper.Controls.Add(this.hsRefreshPerformance);
            this.pnlPerformanceUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerformanceUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlPerformanceUpper.Name = "pnlPerformanceUpper";
            this.pnlPerformanceUpper.Size = new System.Drawing.Size(1588, 48);
            this.pnlPerformanceUpper.TabIndex = 7;
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
            this.hotSpot1.Image = global::FBXpertLib.Properties.Resources.data_export_blue_x24;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpertLib.Properties.Resources.data_export_gn_x24;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(0, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Save XML-Data";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShortcutNewline = false;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(111, 44);
            this.hotSpot1.TabIndex = 32;
            this.hotSpot1.Text = "Save XML-Data";
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
            // 
            // hsRefreshPerformance
            // 
            this.hsRefreshPerformance.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshPerformance.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshPerformance.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshPerformance.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshPerformance.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshPerformance.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshPerformance.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshPerformance.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshPerformance.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshPerformance.FlatAppearance.BorderSize = 0;
            this.hsRefreshPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshPerformance.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshPerformance.Image = global::FBXpertLib.Properties.Resources.view_refresh22x;
            this.hsRefreshPerformance.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshPerformance.ImageToggleOnSelect = true;
            this.hsRefreshPerformance.Location = new System.Drawing.Point(1539, 0);
            this.hsRefreshPerformance.Marked = false;
            this.hsRefreshPerformance.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshPerformance.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshPerformance.MarkedText = "";
            this.hsRefreshPerformance.MarkMode = false;
            this.hsRefreshPerformance.Name = "hsRefreshPerformance";
            this.hsRefreshPerformance.NonMarkedText = "";
            this.hsRefreshPerformance.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshPerformance.ShortcutNewline = false;
            this.hsRefreshPerformance.ShowShortcut = false;
            this.hsRefreshPerformance.Size = new System.Drawing.Size(45, 44);
            this.hsRefreshPerformance.TabIndex = 3;
            this.hsRefreshPerformance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshPerformance.ToolTipActive = false;
            this.hsRefreshPerformance.ToolTipAutomaticDelay = 500;
            this.hsRefreshPerformance.ToolTipAutoPopDelay = 5000;
            this.hsRefreshPerformance.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshPerformance.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshPerformance.ToolTipFor4ContextMenu = true;
            this.hsRefreshPerformance.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshPerformance.ToolTipInitialDelay = 500;
            this.hsRefreshPerformance.ToolTipIsBallon = false;
            this.hsRefreshPerformance.ToolTipOwnerDraw = false;
            this.hsRefreshPerformance.ToolTipReshowDelay = 100;
            this.hsRefreshPerformance.ToolTipShowAlways = false;
            this.hsRefreshPerformance.ToolTipText = "";
            this.hsRefreshPerformance.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshPerformance.ToolTipTitle = "";
            this.hsRefreshPerformance.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshPerformance.UseVisualStyleBackColor = false;
            this.hsRefreshPerformance.Click += new System.EventHandler(this.hsRefreshPerformance_Click);
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.dgvExperienceInfo);
            this.tabPageInfo.Controls.Add(this.panel1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 23);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(1594, 621);
            this.tabPageInfo.TabIndex = 10;
            this.tabPageInfo.Text = "ExperienceInfo";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // dgvExperienceInfo
            // 
            this.dgvExperienceInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExperienceInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExperienceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExperienceInfo.ContextMenuStrip = this.cmdExperienceInfo;
            this.dgvExperienceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExperienceInfo.Location = new System.Drawing.Point(3, 110);
            this.dgvExperienceInfo.Name = "dgvExperienceInfo";
            this.dgvExperienceInfo.RowHeadersVisible = false;
            this.dgvExperienceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExperienceInfo.Size = new System.Drawing.Size(1588, 508);
            this.dgvExperienceInfo.TabIndex = 24;
            this.dgvExperienceInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExperienceInfo_CellMouseClick);
            this.dgvExperienceInfo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExperienceInfo_ColumnHeaderMouseClick);
            // 
            // cmdExperienceInfo
            // 
            this.cmdExperienceInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExperienceInfoToSQL,
            this.toolStripSeparator3,
            this.tsmiDeleteExperienceInfo});
            this.cmdExperienceInfo.Name = "cmsHistory";
            this.cmdExperienceInfo.Size = new System.Drawing.Size(141, 54);
            this.cmdExperienceInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdExperienceInfo_ItemClicked);
            // 
            // tsmiExperienceInfoToSQL
            // 
            this.tsmiExperienceInfoToSQL.Image = global::FBXpertLib.Properties.Resources.SQL_blue_x24;
            this.tsmiExperienceInfoToSQL.Name = "tsmiExperienceInfoToSQL";
            this.tsmiExperienceInfoToSQL.Size = new System.Drawing.Size(140, 22);
            this.tsmiExperienceInfoToSQL.Text = "Copy to SQL";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiDeleteExperienceInfo
            // 
            this.tsmiDeleteExperienceInfo.Image = global::FBXpertLib.Properties.Resources.cross_red_x22;
            this.tsmiDeleteExperienceInfo.Name = "tsmiDeleteExperienceInfo";
            this.tsmiDeleteExperienceInfo.Size = new System.Drawing.Size(140, 22);
            this.tsmiDeleteExperienceInfo.Text = "Delete entry";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtExperienceInfo);
            this.panel1.Controls.Add(this.gbExperienceInfoKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1588, 107);
            this.panel1.TabIndex = 25;
            // 
            // txtExperienceInfo
            // 
            this.txtExperienceInfo.AutoCompleteBracketsList = new char[] {
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
            this.txtExperienceInfo.AutoIndentCharsPatterns = "";
            this.txtExperienceInfo.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtExperienceInfo.BackBrush = null;
            this.txtExperienceInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtExperienceInfo.CharHeight = 14;
            this.txtExperienceInfo.CharWidth = 8;
            this.txtExperienceInfo.CommentPrefix = "--";
            this.txtExperienceInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExperienceInfo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtExperienceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExperienceInfo.IsReplaceMode = false;
            this.txtExperienceInfo.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtExperienceInfo.LeftBracket = '(';
            this.txtExperienceInfo.Location = new System.Drawing.Point(427, 0);
            this.txtExperienceInfo.Name = "txtExperienceInfo";
            this.txtExperienceInfo.Paddings = new System.Windows.Forms.Padding(0);
            this.txtExperienceInfo.RightBracket = ')';
            this.txtExperienceInfo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtExperienceInfo.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtExperienceInfo.ServiceColors")));
            this.txtExperienceInfo.Size = new System.Drawing.Size(1157, 103);
            this.txtExperienceInfo.TabIndex = 42;
            this.txtExperienceInfo.Zoom = 100;
            this.txtExperienceInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExperienceInfo_KeyDown);
            // 
            // gbExperienceInfoKey
            // 
            this.gbExperienceInfoKey.Controls.Add(this.hsUpdateExperienceInfo);
            this.gbExperienceInfoKey.Controls.Add(this.hsDeleteExperienceInfo);
            this.gbExperienceInfoKey.Controls.Add(this.txtExperienceKeyCode);
            this.gbExperienceInfoKey.Controls.Add(this.hsClearExperienceInfoFields);
            this.gbExperienceInfoKey.Controls.Add(this.hsRefreshExperienceInfo);
            this.gbExperienceInfoKey.Controls.Add(this.hsInsertExperienceInfo);
            this.gbExperienceInfoKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbExperienceInfoKey.Location = new System.Drawing.Point(0, 0);
            this.gbExperienceInfoKey.Name = "gbExperienceInfoKey";
            this.gbExperienceInfoKey.Size = new System.Drawing.Size(427, 103);
            this.gbExperienceInfoKey.TabIndex = 40;
            this.gbExperienceInfoKey.TabStop = false;
            this.gbExperienceInfoKey.Text = "Info";
            // 
            // hsUpdateExperienceInfo
            // 
            this.hsUpdateExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsUpdateExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUpdateExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUpdateExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUpdateExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUpdateExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUpdateExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsUpdateExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUpdateExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsUpdateExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUpdateExperienceInfo.Image = global::FBXpertLib.Properties.Resources.ok_gn22x;
            this.hsUpdateExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUpdateExperienceInfo.ImageHover = global::FBXpertLib.Properties.Resources.ok_blue22x;
            this.hsUpdateExperienceInfo.ImageToggleOnSelect = true;
            this.hsUpdateExperienceInfo.Location = new System.Drawing.Point(340, 19);
            this.hsUpdateExperienceInfo.Marked = false;
            this.hsUpdateExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsUpdateExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUpdateExperienceInfo.MarkedText = "";
            this.hsUpdateExperienceInfo.MarkMode = false;
            this.hsUpdateExperienceInfo.Name = "hsUpdateExperienceInfo";
            this.hsUpdateExperienceInfo.NonMarkedText = "Execute";
            this.hsUpdateExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUpdateExperienceInfo.ShortcutNewline = false;
            this.hsUpdateExperienceInfo.ShowShortcut = false;
            this.hsUpdateExperienceInfo.Size = new System.Drawing.Size(79, 45);
            this.hsUpdateExperienceInfo.TabIndex = 41;
            this.hsUpdateExperienceInfo.Text = "Update";
            this.hsUpdateExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUpdateExperienceInfo.ToolTipActive = false;
            this.hsUpdateExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsUpdateExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsUpdateExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUpdateExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUpdateExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsUpdateExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUpdateExperienceInfo.ToolTipInitialDelay = 500;
            this.hsUpdateExperienceInfo.ToolTipIsBallon = false;
            this.hsUpdateExperienceInfo.ToolTipOwnerDraw = false;
            this.hsUpdateExperienceInfo.ToolTipReshowDelay = 100;
            this.hsUpdateExperienceInfo.ToolTipShowAlways = false;
            this.hsUpdateExperienceInfo.ToolTipText = "";
            this.hsUpdateExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUpdateExperienceInfo.ToolTipTitle = "";
            this.hsUpdateExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUpdateExperienceInfo.UseVisualStyleBackColor = false;
            this.hsUpdateExperienceInfo.Click += new System.EventHandler(this.hsUpdateExperienceInfo_Click);
            // 
            // hsDeleteExperienceInfo
            // 
            this.hsDeleteExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDeleteExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsDeleteExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteExperienceInfo.Image = global::FBXpertLib.Properties.Resources.minus_gn24x;
            this.hsDeleteExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDeleteExperienceInfo.ImageHover = global::FBXpertLib.Properties.Resources.minus_blue24x;
            this.hsDeleteExperienceInfo.ImageToggleOnSelect = true;
            this.hsDeleteExperienceInfo.Location = new System.Drawing.Point(255, 19);
            this.hsDeleteExperienceInfo.Marked = false;
            this.hsDeleteExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteExperienceInfo.MarkedText = "";
            this.hsDeleteExperienceInfo.MarkMode = false;
            this.hsDeleteExperienceInfo.Name = "hsDeleteExperienceInfo";
            this.hsDeleteExperienceInfo.NonMarkedText = "Execute";
            this.hsDeleteExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteExperienceInfo.ShortcutNewline = false;
            this.hsDeleteExperienceInfo.ShowShortcut = false;
            this.hsDeleteExperienceInfo.Size = new System.Drawing.Size(79, 45);
            this.hsDeleteExperienceInfo.TabIndex = 40;
            this.hsDeleteExperienceInfo.Text = "Delete";
            this.hsDeleteExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDeleteExperienceInfo.ToolTipActive = false;
            this.hsDeleteExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsDeleteExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsDeleteExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsDeleteExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteExperienceInfo.ToolTipInitialDelay = 500;
            this.hsDeleteExperienceInfo.ToolTipIsBallon = false;
            this.hsDeleteExperienceInfo.ToolTipOwnerDraw = false;
            this.hsDeleteExperienceInfo.ToolTipReshowDelay = 100;
            this.hsDeleteExperienceInfo.ToolTipShowAlways = false;
            this.hsDeleteExperienceInfo.ToolTipText = "";
            this.hsDeleteExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteExperienceInfo.ToolTipTitle = "";
            this.hsDeleteExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteExperienceInfo.UseVisualStyleBackColor = false;
            this.hsDeleteExperienceInfo.Click += new System.EventHandler(this.hsDeleteExpierenceInfo_Click);
            // 
            // txtExperienceKeyCode
            // 
            this.txtExperienceKeyCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtExperienceKeyCode.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExperienceKeyCode.Location = new System.Drawing.Point(3, 78);
            this.txtExperienceKeyCode.Name = "txtExperienceKeyCode";
            this.txtExperienceKeyCode.Size = new System.Drawing.Size(421, 22);
            this.txtExperienceKeyCode.TabIndex = 39;
            // 
            // hsClearExperienceInfoFields
            // 
            this.hsClearExperienceInfoFields.BackColor = System.Drawing.Color.Transparent;
            this.hsClearExperienceInfoFields.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearExperienceInfoFields.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearExperienceInfoFields.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearExperienceInfoFields.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearExperienceInfoFields.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearExperienceInfoFields.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearExperienceInfoFields.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearExperienceInfoFields.FlatAppearance.BorderSize = 0;
            this.hsClearExperienceInfoFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearExperienceInfoFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearExperienceInfoFields.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearExperienceInfoFields.Image = global::FBXpertLib.Properties.Resources.sweep_ge24x;
            this.hsClearExperienceInfoFields.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearExperienceInfoFields.ImageHover = global::FBXpertLib.Properties.Resources.seewp_bl24x;
            this.hsClearExperienceInfoFields.ImageToggleOnSelect = true;
            this.hsClearExperienceInfoFields.Location = new System.Drawing.Point(90, 19);
            this.hsClearExperienceInfoFields.Marked = false;
            this.hsClearExperienceInfoFields.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearExperienceInfoFields.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearExperienceInfoFields.MarkedText = "";
            this.hsClearExperienceInfoFields.MarkMode = false;
            this.hsClearExperienceInfoFields.Name = "hsClearExperienceInfoFields";
            this.hsClearExperienceInfoFields.NonMarkedText = "Clear Fields";
            this.hsClearExperienceInfoFields.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearExperienceInfoFields.ShortcutNewline = false;
            this.hsClearExperienceInfoFields.ShowShortcut = false;
            this.hsClearExperienceInfoFields.Size = new System.Drawing.Size(75, 45);
            this.hsClearExperienceInfoFields.TabIndex = 37;
            this.hsClearExperienceInfoFields.Text = "Clear";
            this.hsClearExperienceInfoFields.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearExperienceInfoFields.ToolTipActive = false;
            this.hsClearExperienceInfoFields.ToolTipAutomaticDelay = 500;
            this.hsClearExperienceInfoFields.ToolTipAutoPopDelay = 5000;
            this.hsClearExperienceInfoFields.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearExperienceInfoFields.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearExperienceInfoFields.ToolTipFor4ContextMenu = true;
            this.hsClearExperienceInfoFields.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearExperienceInfoFields.ToolTipInitialDelay = 500;
            this.hsClearExperienceInfoFields.ToolTipIsBallon = false;
            this.hsClearExperienceInfoFields.ToolTipOwnerDraw = false;
            this.hsClearExperienceInfoFields.ToolTipReshowDelay = 100;
            this.hsClearExperienceInfoFields.ToolTipShowAlways = false;
            this.hsClearExperienceInfoFields.ToolTipText = "";
            this.hsClearExperienceInfoFields.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearExperienceInfoFields.ToolTipTitle = "";
            this.hsClearExperienceInfoFields.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearExperienceInfoFields.UseVisualStyleBackColor = false;
            this.hsClearExperienceInfoFields.Click += new System.EventHandler(this.hsClearExperienceInfoFields_Click);
            // 
            // hsRefreshExperienceInfo
            // 
            this.hsRefreshExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsRefreshExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshExperienceInfo.Image = global::FBXpertLib.Properties.Resources.view_refresh22x;
            this.hsRefreshExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshExperienceInfo.ImageHover = global::FBXpertLib.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshExperienceInfo.ImageToggleOnSelect = true;
            this.hsRefreshExperienceInfo.Location = new System.Drawing.Point(171, 19);
            this.hsRefreshExperienceInfo.Marked = false;
            this.hsRefreshExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshExperienceInfo.MarkedText = "";
            this.hsRefreshExperienceInfo.MarkMode = false;
            this.hsRefreshExperienceInfo.Name = "hsRefreshExperienceInfo";
            this.hsRefreshExperienceInfo.NonMarkedText = "Refresh";
            this.hsRefreshExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshExperienceInfo.ShortcutNewline = false;
            this.hsRefreshExperienceInfo.ShowShortcut = false;
            this.hsRefreshExperienceInfo.Size = new System.Drawing.Size(89, 45);
            this.hsRefreshExperienceInfo.TabIndex = 33;
            this.hsRefreshExperienceInfo.Text = "Refresh";
            this.hsRefreshExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshExperienceInfo.ToolTipActive = false;
            this.hsRefreshExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsRefreshExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsRefreshExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsRefreshExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshExperienceInfo.ToolTipInitialDelay = 500;
            this.hsRefreshExperienceInfo.ToolTipIsBallon = false;
            this.hsRefreshExperienceInfo.ToolTipOwnerDraw = false;
            this.hsRefreshExperienceInfo.ToolTipReshowDelay = 100;
            this.hsRefreshExperienceInfo.ToolTipShowAlways = false;
            this.hsRefreshExperienceInfo.ToolTipText = "";
            this.hsRefreshExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshExperienceInfo.ToolTipTitle = "";
            this.hsRefreshExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshExperienceInfo.UseVisualStyleBackColor = false;
            this.hsRefreshExperienceInfo.Click += new System.EventHandler(this.hsRefreshExpierenceInfo_Click);
            // 
            // hsInsertExperienceInfo
            // 
            this.hsInsertExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsInsertExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInsertExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInsertExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInsertExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInsertExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInsertExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInsertExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsInsertExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsInsertExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInsertExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInsertExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInsertExperienceInfo.Image = global::FBXpertLib.Properties.Resources.plus_gn22x;
            this.hsInsertExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsInsertExperienceInfo.ImageHover = global::FBXpertLib.Properties.Resources.plus_blue22x;
            this.hsInsertExperienceInfo.ImageToggleOnSelect = true;
            this.hsInsertExperienceInfo.Location = new System.Drawing.Point(6, 19);
            this.hsInsertExperienceInfo.Marked = false;
            this.hsInsertExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsInsertExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInsertExperienceInfo.MarkedText = "";
            this.hsInsertExperienceInfo.MarkMode = false;
            this.hsInsertExperienceInfo.Name = "hsInsertExperienceInfo";
            this.hsInsertExperienceInfo.NonMarkedText = "Execute";
            this.hsInsertExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInsertExperienceInfo.ShortcutNewline = false;
            this.hsInsertExperienceInfo.ShowShortcut = false;
            this.hsInsertExperienceInfo.Size = new System.Drawing.Size(79, 45);
            this.hsInsertExperienceInfo.TabIndex = 28;
            this.hsInsertExperienceInfo.Text = "Add";
            this.hsInsertExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsInsertExperienceInfo.ToolTipActive = false;
            this.hsInsertExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsInsertExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsInsertExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInsertExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInsertExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsInsertExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInsertExperienceInfo.ToolTipInitialDelay = 500;
            this.hsInsertExperienceInfo.ToolTipIsBallon = false;
            this.hsInsertExperienceInfo.ToolTipOwnerDraw = false;
            this.hsInsertExperienceInfo.ToolTipReshowDelay = 100;
            this.hsInsertExperienceInfo.ToolTipShowAlways = false;
            this.hsInsertExperienceInfo.ToolTipText = "";
            this.hsInsertExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInsertExperienceInfo.ToolTipTitle = "";
            this.hsInsertExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInsertExperienceInfo.UseVisualStyleBackColor = false;
            this.hsInsertExperienceInfo.Click += new System.EventHandler(this.hotSpot5_Click);
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
            this.ilTabControl.Images.SetKeyName(10, "edit_XML_blue_x24.png");
            this.ilTabControl.Images.SetKeyName(11, "info_red22x.png");
            this.ilTabControl.Images.SetKeyName(12, "media_playlist_repeat_blue_x22.png");
            this.ilTabControl.Images.SetKeyName(13, "dictionary_blue_32X.png");
            this.ilTabControl.Images.SetKeyName(14, "Table_x24.png");
            this.ilTabControl.Images.SetKeyName(15, "format_indent_more_24x.png");
            this.ilTabControl.Images.SetKeyName(16, "graph_32x.png");
            // 
            // sfdSQL
            // 
            this.sfdSQL.DefaultExt = "*.sql";
            this.sfdSQL.Filter = "SQL-Dateien|*.sql|Alle Dateien|*.*";
            this.sfdSQL.Title = "Save SQL Script";
            // 
            // helpMain
            // 
            this.helpMain.HelpNamespace = "C:\\Projekte\\HerzogApp\\Help\\HerzogApp.chm";
            // 
            // ofdLog
            // 
            this.ofdLog.FileName = "openFileDialog1";
            // 
            // ofdSQL
            // 
            this.ofdSQL.DefaultExt = "*.sql";
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
            this.ofdSQL.Title = "Load SQL Script";
            // 
            // saveFileDialogXML
            // 
            this.saveFileDialogXML.DefaultExt = "*.xml";
            this.saveFileDialogXML.Filter = "XML|*.xml|XLS|*.xls|All|*.*";
            this.saveFileDialogXML.Title = "Save XML";
            // 
            // saveFileDialogCSV
            // 
            this.saveFileDialogCSV.DefaultExt = "*.xml";
            this.saveFileDialogCSV.Filter = "CSV|*.csv|XLS|*.xls|All|*.*";
            this.saveFileDialogCSV.Title = "Save CSV";
            // 
            // SQLViewForm1
            // 
            this.ClientSize = new System.Drawing.Size(1604, 699);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnlFormUpper);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMain.SetHelpKeyword(this, "Workflow Bestellung");
            this.helpMain.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpMain.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQLViewForm1";
            this.helpMain.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLViewForm_FormClosing);
            this.Load += new System.EventHandler(this.SQLViewForm_Load);
            this.Enter += new System.EventHandler(this.SQLViewForm1_Enter);
            this.pnlFormUpper.ResumeLayout(false);
            this.bnConnection.ResumeLayout(false);
            this.gnUsedTime.ResumeLayout(false);
            this.gnUsedTime.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.tcSQLCONTROL.ResumeLayout(false);
            this.tabSQLTEXT.ResumeLayout(false);
            this.pnlSQLCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSQL)).EndInit();
            this.cmsSQLText.ResumeLayout(false);
            this.pnlSQLUpper.ResumeLayout(false);
            this.gbEncoding.ResumeLayout(false);
            this.tabRESULT.ResumeLayout(false);
            this.tabRESULT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.cmdDATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.pnlResultUpper.ResumeLayout(false);
            this.gbRowHeight.ResumeLayout(false);
            this.gbRowHeight.PerformLayout();
            this.gbEditMode.ResumeLayout(false);
            this.gbNavigator.ResumeLayout(false);
            this.gbNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTableContent)).EndInit();
            this.bnTableContent.ResumeLayout(false);
            this.bnTableContent.PerformLayout();
            this.gbUsedMilliseconds.ResumeLayout(false);
            this.tabMELDUNG.ResumeLayout(false);
            this.pnlInfoCenter.ResumeLayout(false);
            this.pnlMessagesUpper.ResumeLayout(false);
            this.pnlMessagesUpper.PerformLayout();
            this.tabERRORS.ResumeLayout(false);
            this.pnlErrorUpper.ResumeLayout(false);
            this.pnlErrorsUpper.ResumeLayout(false);
            this.pnlErrorsUpper.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.pnlHistoryCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLHistory)).EndInit();
            this.cmsHistory.ResumeLayout(false);
            this.pnlHistoryUpper.ResumeLayout(false);
            this.pnlHistoryUpper.PerformLayout();
            this.tabRelpacelist.ResumeLayout(false);
            this.pnlReplacesCenter.ResumeLayout(false);
            this.pnlRelpacesUpper.ResumeLayout(false);
            this.tabOptionen.ResumeLayout(false);
            this.tabOptionen.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbKonfig.ResumeLayout(false);
            this.gpErrorausgabe.ResumeLayout(false);
            this.gpErrorausgabe.PerformLayout();
            this.gbMeldungDirection.ResumeLayout(false);
            this.gbMeldungDirection.PerformLayout();
            this.tabPagePlan.ResumeLayout(false);
            this.pnlPlanCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctPlan)).EndInit();
            this.tabPageExport.ResumeLayout(false);
            this.tabControlExport.ResumeLayout(false);
            this.tabPageXML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctXMLData)).EndInit();
            this.pnlXMLDataUpper.ResumeLayout(false);
            this.pnlXMLDataUpper.PerformLayout();
            this.gbExportCosts.ResumeLayout(false);
            this.gbExportLinesCount.ResumeLayout(false);
            this.gbCSVSeperator.ResumeLayout(false);
            this.gbExportProgress.ResumeLayout(false);
            this.tabPageXMLScheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctXMLScheme)).EndInit();
            this.pnlXMLSchemeUpper.ResumeLayout(false);
            this.tabPagePerformance.ResumeLayout(false);
            this.gbPerformance.ResumeLayout(false);
            this.pnlPerformanceUpper.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienceInfo)).EndInit();
            this.cmdExperienceInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtExperienceInfo)).EndInit();
            this.gbExperienceInfoKey.ResumeLayout(false);
            this.gbExperienceInfoKey.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BindingSource bsResults;
        private System.Data.DataSet dsResults;
        private TabControl tcSQLCONTROL;
        private TabPage tabSQLTEXT;
        private TabPage tabRESULT;
        private DataGridView dgvResults;
        private TabPage tabMELDUNG;
        private RichTextBox rtfMELDUNG;
        private TabPage tabHistory;
        private SaveFileDialog sfdSQL;
        private HelpProvider helpMain;
        private TabPage tabERRORS;
        private RichTextBox rtfERRORS;
        private System.Data.DataTable Table;
        private ProgressBar pbRunSQL;
        private GroupBox gbEncoding;
        private CheckBox cbTestlauf;
        private CheckBox cbMeldungen;
        private CheckBox cbErrors;
        private CheckBox cbHistory;
        private TabPage tabRelpacelist;
        private RichTextBox rtbReplace;
        private TabPage tabOptionen;
        private GroupBox gbMeldungDirection;
        private RadioButton rbMeldInsert;
        private RadioButton rbMeldAppend;
        private GroupBox gpErrorausgabe;
        private RadioButton rbErrInsert;
        private RadioButton rbErrAppend;
        private CheckBox cbAutoScroll;
        private CheckBox cbAutoSrcollErr;
        private SEFormsControlLibrary.SECaptionEditBox txtMeldIntervall;
        private SEFormsControlLibrary.SECaptionEditBox txtErrIntervall;
        private SEFormsControlLibrary.SECaptionEditBox txtMeldLogFilePath;
        private Button btnLoadMeld;
        private OpenFileDialog ofdLog;
        private FolderBrowserDialog fbdLog;
        private SEFormsControlLibrary.SECaptionEditBox txtLogFile;
        private GroupBox gbKonfig;
        private SeControlsLib.HotSpot hsRefreshConfig;
        private SEFormsControlLibrary.SECaptionEditBox secDATABASEPATH;
        private SEFormsControlLibrary.SECaptionEditBox secSERVERNAME;
        private GroupBox groupBox3;
        private Panel pnlSQLUpper;
        private Panel pnlSQLCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRunSQL;
        private SeControlsLib.HotSpot hsRunSQLfromFile;
        private SeControlsLib.HotSpot hsClearText;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private SeControlsLib.HotSpot hsReplaceText;
        private SeControlsLib.HotSpot hsBreak;
        private ComboBox cbEncoding;
        private Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsClearInfo;
        private Panel pnlInfoCenter;
        private Panel pnlHistoryUpper;
        private SeControlsLib.HotSpot hsExecuteHistorySelected;
        private Panel pnlHistoryCenter;
        private Panel pnlErrorsUpper;
        private SeControlsLib.HotSpot hsClearErrorAll;
        private Panel pnlErrorUpper;
        private Panel pnlRelpacesUpper;
        private SeControlsLib.HotSpot hsLoadListReplaces;
        private Panel pnlReplacesCenter;
        private FastColoredTextBoxNS.FastColoredTextBox txtSQL;
        private OpenFileDialog ofdSQL;
        private TabPage tabPagePlan;
        private Panel pnlPlanCenter;
        private FastColoredTextBoxNS.FastColoredTextBox fctPlan;
        private Panel pnlPlanLower;
        private Panel pnlPlanUpper;
        private ImageList ilTabControl;
        private Panel pnlResultUpper;
        private SeControlsLib.HotSpot hsUpdateDataset;
        private ContextMenuStrip cmsSQLText;
        private ToolStripMenuItem tsmiDDLCopyToClipboard;
        private ToolStripMenuItem tsmiDDLPaste;
        private TabPage tabPageExport;
        private TabControl tabControlExport;
        private TabPage tabPageXML;
        private FastColoredTextBoxNS.FastColoredTextBox fctXMLData;
        private Panel pnlXMLDataUpper;
        private TabPage tabPageXMLScheme;
        private FastColoredTextBoxNS.FastColoredTextBox fctXMLScheme;
        private Panel pnlXMLSchemeUpper;
        private SeControlsLib.HotSpot hsRefreshXMLData;
        private SeControlsLib.HotSpot hsRefreshXMLScheme;
        private SeControlsLib.HotSpot hsSaveXML;
        private SeControlsLib.HotSpot hsSaveXMLScheme;
        private SaveFileDialog saveFileDialogXML;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private TabPage tabPagePerformance;
        private GroupBox gbPerformance;
        private ListView lvPerformance;
        private ColumnHeader colSQL;
        private ColumnHeader colMEMUSAGE;
        private Panel pnlPerformanceUpper;
        private SeControlsLib.HotSpot hotSpot1;
        private SeControlsLib.HotSpot hsRefreshPerformance;
        private ColumnHeader colSEQ_READS;
        private ColumnHeader colINX_READS;
        private ColumnHeader colINSERTS;
        private ColumnHeader colUPDATES;
        private ColumnHeader colDELETES;
        private ColumnHeader colCONFLICTS;
        private GroupBox gbUsedMilliseconds;
        private Label lblUsedMs;
        private BindingNavigator bnTableContent;
        private ToolStripLabel bnTableContentCountItem;
        private ToolStripButton bnTableContentDeleteItem;
        private ToolStripButton bnTableContentMoveFirstItem;
        private ToolStripButton bnTableContentMovePreviousItem;
        private ToolStripSeparator bnTableContentSeparator;
        private ToolStripTextBox bnTableContentPositionItem;
        private ToolStripSeparator bnTableContentSeparator1;
        private ToolStripButton bnTableContentMoveNextItem;
        private ToolStripButton bnTableContentMoveLastItem;
        private ToolStripSeparator bnTableContentSeparator2;
        private GroupBox gbNavigator;
        private GroupBox gbEditMode;
        private CheckBox cbEditMode;
        private CheckBox cbClearListBeforeExcecute;
        private GroupBox gbRowHeight;
        private TextBox txtRowHeight;
        private CheckBox cbRowManually;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiLastCommand;
        private ToolStripMenuItem tsmiExecuteLastSucessfullCommand;
        private ToolStripMenuItem tsmiInsertLastSuccessfullCommand;
        private GroupBox gnUsedTime;
        private TextBox txtUsedTime;
        private SeControlsLib.HotSpot hsPageRefresh;
        private Panel pnlWatch;
        private FolderBrowserDialog fbdPath;
        private SeControlsLib.HotSpot hsLifeTime;
        private SeControlsLib.HotSpot hsExportCSV;
        private SaveFileDialog saveFileDialogCSV;
        private GroupBox gbCSVSeperator;
        private ComboBox cbCSVSeperator;
        private SeControlsLib.HotSpot hsExportHTML;
        private CheckBox ckExportToScreen;
        private CheckBox ckExportToFile;
        private CheckBox ckShowResults;
        private SeControlsLib.HotSpot hotSpot2;
        private GroupBox gbExportLinesCount;
        private Label lblExportLinesCount;
        private CheckBox ckMaskData;
        private CheckBox ckClearExportListBeforeExecute;
        private GroupBox gbExportCosts;
        private Label lblExportCosts;
        private GroupBox gbExportProgress;
        private ProgressBar pbExport;
        private SeControlsLib.HotSpot hsExportBreak;
        private CheckBox cbShowExportProgress;
        private DataGridView dgvSQLHistory;
        private SeControlsLib.HotSpot hsRefreshHistory;
        private CheckBox cbAllHistory;
        private CheckBox cbSQLfailed;
        private CheckBox cbSQLsucceded;
        private ContextMenuStrip cmsHistory;
        private ToolStripMenuItem tsmiDeleteHistoryEntry;
        private ToolStripMenuItem tsmiHistoryCopyToSQL;
        private ToolStripMenuItem tsmiHistoryExecuteSQL;
        private ToolStripSeparator toolStripSeparator2;
        private SeControlsLib.HotSpot hsClearHistory;
        private ToolStripMenuItem tsmiInsertPK;
        private TabPage tabPageInfo;
        private Panel panel1;
        private SeControlsLib.HotSpot hsClearExperienceInfoFields;
        private SeControlsLib.HotSpot hsRefreshExperienceInfo;
        private SeControlsLib.HotSpot hsInsertExperienceInfo;
        private DataGridView dgvExperienceInfo;
        private TextBox txtExperienceKeyCode;
        private GroupBox gbExperienceInfoKey;
        private SeControlsLib.HotSpot hsDeleteExperienceInfo;
        private ContextMenuStrip cmdExperienceInfo;
        private ToolStripMenuItem tsmiExperienceInfoToSQL;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmiDeleteExperienceInfo;
        private SeControlsLib.HotSpot hsUpdateExperienceInfo;
        private FastColoredTextBoxNS.FastColoredTextBox txtExperienceInfo;
        private ContextMenuStrip cmdDATA;
        private ToolStripMenuItem tsmiSpaltenEdit;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmiDate;
        private ToolStripMenuItem tsmiInsertNow;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem tsmiInsertGUID;
        private ToolStripMenuItem tsmiInsertGUIDHEX;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem tsmiSetToNULL;
        private ToolStripMenuItem tsmiInsert0;
        private ToolStripMenuItem tsmiInsert1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem tsmiReadBLOB;
        private GroupBox bnConnection;
        private ComboBox cbConnection;
    }
}
