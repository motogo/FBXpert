using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using BasicForms;

namespace SQLView
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    partial class SQLViewForm1 : BasicNormalFormClass
    {
        private System.Windows.Forms.Panel pnl_upper;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLViewForm1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_upper = new System.Windows.Forms.Panel();
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
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsBreak = new SeControlsLib.HotSpot();
            this.hsReplaceText = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsRunSQLfromFile = new SeControlsLib.HotSpot();
            this.hsClearText = new SeControlsLib.HotSpot();
            this.hsRunSQL = new SeControlsLib.HotSpot();
            this.gbEncoding = new System.Windows.Forms.GroupBox();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabRESULT = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
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
            this.hsSaveDataset = new SeControlsLib.HotSpot();
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
            this.tabMELDUNG = new System.Windows.Forms.TabPage();
            this.pnlInfoCenter = new System.Windows.Forms.Panel();
            this.rtfMELDUNG = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMeldAutoclear = new System.Windows.Forms.CheckBox();
            this.hsClearInfo = new SeControlsLib.HotSpot();
            this.cbAutoScroll = new System.Windows.Forms.CheckBox();
            this.tabERRORS = new System.Windows.Forms.TabPage();
            this.pnlErrorUpper = new System.Windows.Forms.Panel();
            this.rtfERRORS = new System.Windows.Forms.RichTextBox();
            this.pnlErrorsUpper = new System.Windows.Forms.Panel();
            this.cbAutoSrcollErr = new System.Windows.Forms.CheckBox();
            this.hsClearErrorAll = new SeControlsLib.HotSpot();
            this.cbErrAutoclear = new System.Windows.Forms.CheckBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.pnlHistoryCenter = new System.Windows.Forms.Panel();
            this.tabControlHistory = new System.Windows.Forms.TabControl();
            this.tabPageSucceeded = new System.Windows.Forms.TabPage();
            this.clbHISTORY = new System.Windows.Forms.CheckedListBox();
            this.tabPageFailedHistory = new System.Windows.Forms.TabPage();
            this.clbFAILED_HISTORY = new System.Windows.Forms.CheckedListBox();
            this.pnlHistoryUpper = new System.Windows.Forms.Panel();
            this.hsCrearAllFailed = new SeControlsLib.HotSpot();
            this.hsClearHistoryAll = new SeControlsLib.HotSpot();
            this.hsClearHistorySelected = new SeControlsLib.HotSpot();
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
            this.hsSaveXML = new SeControlsLib.HotSpot();
            this.hsRefreshXMLData = new SeControlsLib.HotSpot();
            this.tabPageXMLScheme = new System.Windows.Forms.TabPage();
            this.fctXMLScheme = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlXMLScheme = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hsRefreshPerformance = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.sfdSQL = new System.Windows.Forms.SaveFileDialog();
            this.helpMain = new System.Windows.Forms.HelpProvider();
            this.ofdLog = new System.Windows.Forms.OpenFileDialog();
            this.fbdLog = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.cmsHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSortASC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_upper.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.panel1.SuspendLayout();
            this.tabERRORS.SuspendLayout();
            this.pnlErrorUpper.SuspendLayout();
            this.pnlErrorsUpper.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.pnlHistoryCenter.SuspendLayout();
            this.tabControlHistory.SuspendLayout();
            this.tabPageSucceeded.SuspendLayout();
            this.tabPageFailedHistory.SuspendLayout();
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
            this.tabPageXMLScheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctXMLScheme)).BeginInit();
            this.pnlXMLScheme.SuspendLayout();
            this.tabPagePerformance.SuspendLayout();
            this.gbPerformance.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_upper
            // 
            this.pnl_upper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_upper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_upper.Controls.Add(this.hsClose);
            this.pnl_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_upper.Location = new System.Drawing.Point(0, 0);
            this.pnl_upper.Name = "pnl_upper";
            this.pnl_upper.Size = new System.Drawing.Size(908, 40);
            this.pnl_upper.TabIndex = 0;
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
            this.hsClose.Size = new System.Drawing.Size(45, 38);
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
            this.cbTestlauf.Location = new System.Drawing.Point(705, 0);
            this.cbTestlauf.Name = "cbTestlauf";
            this.cbTestlauf.Size = new System.Drawing.Size(61, 41);
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
            this.cbHistory.Size = new System.Drawing.Size(58, 17);
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
            this.cbErrors.Size = new System.Drawing.Size(53, 17);
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
            this.cbMeldungen.Size = new System.Drawing.Size(52, 17);
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
            this.pnl_center.Location = new System.Drawing.Point(0, 40);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(908, 659);
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
            this.tcSQLCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSQLCONTROL.ImageList = this.ilTabControl;
            this.tcSQLCONTROL.Location = new System.Drawing.Point(0, 0);
            this.tcSQLCONTROL.Name = "tcSQLCONTROL";
            this.tcSQLCONTROL.SelectedIndex = 0;
            this.tcSQLCONTROL.Size = new System.Drawing.Size(906, 657);
            this.tcSQLCONTROL.TabIndex = 0;
            // 
            // tabSQLTEXT
            // 
            this.tabSQLTEXT.BackColor = System.Drawing.SystemColors.Control;
            this.tabSQLTEXT.Controls.Add(this.pnlSQLCenter);
            this.tabSQLTEXT.Controls.Add(this.pnlSQLUpper);
            this.tabSQLTEXT.Controls.Add(this.progressBar1);
            this.tabSQLTEXT.ImageKey = "SQL_blue_x24.png";
            this.tabSQLTEXT.Location = new System.Drawing.Point(4, 23);
            this.tabSQLTEXT.Name = "tabSQLTEXT";
            this.tabSQLTEXT.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQLTEXT.Size = new System.Drawing.Size(898, 630);
            this.tabSQLTEXT.TabIndex = 0;
            this.tabSQLTEXT.Text = "SQL commands";
            // 
            // pnlSQLCenter
            // 
            this.pnlSQLCenter.Controls.Add(this.txtSQL);
            this.pnlSQLCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSQLCenter.Location = new System.Drawing.Point(3, 48);
            this.pnlSQLCenter.Name = "pnlSQLCenter";
            this.pnlSQLCenter.Size = new System.Drawing.Size(892, 569);
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
            this.txtSQL.IsReplaceMode = false;
            this.txtSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtSQL.LeftBracket = '(';
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.txtSQL.RightBracket = ')';
            this.txtSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtSQL.ServiceColors")));
            this.txtSQL.Size = new System.Drawing.Size(892, 569);
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
            this.tsmiExecuteLastSucessfullCommand});
            this.cmsSQLText.Name = "cmsText";
            this.cmsSQLText.Size = new System.Drawing.Size(248, 120);
            this.cmsSQLText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSQLText_ItemClicked);
            // 
            // tsmiDDLCopyToClipboard
            // 
            this.tsmiDDLCopyToClipboard.Image = global::FBXpert.Properties.Resources.format_indent_less32x;
            this.tsmiDDLCopyToClipboard.Name = "tsmiDDLCopyToClipboard";
            this.tsmiDDLCopyToClipboard.Size = new System.Drawing.Size(247, 22);
            this.tsmiDDLCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // tsmiDDLPaste
            // 
            this.tsmiDDLPaste.Image = global::FBXpert.Properties.Resources.format_indent_more_2_32x;
            this.tsmiDDLPaste.Name = "tsmiDDLPaste";
            this.tsmiDDLPaste.Size = new System.Drawing.Size(247, 22);
            this.tsmiDDLPaste.Text = "Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // tsmiLastCommand
            // 
            this.tsmiLastCommand.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiLastCommand.Name = "tsmiLastCommand";
            this.tsmiLastCommand.Size = new System.Drawing.Size(247, 22);
            this.tsmiLastCommand.Text = "Insert last command";
            // 
            // tsmiInsertLastSuccessfullCommand
            // 
            this.tsmiInsertLastSuccessfullCommand.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiInsertLastSuccessfullCommand.Name = "tsmiInsertLastSuccessfullCommand";
            this.tsmiInsertLastSuccessfullCommand.Size = new System.Drawing.Size(247, 22);
            this.tsmiInsertLastSuccessfullCommand.Text = "Insert last successful command";
            // 
            // tsmiExecuteLastSucessfullCommand
            // 
            this.tsmiExecuteLastSucessfullCommand.AutoToolTip = true;
            this.tsmiExecuteLastSucessfullCommand.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiExecuteLastSucessfullCommand.Name = "tsmiExecuteLastSucessfullCommand";
            this.tsmiExecuteLastSucessfullCommand.Size = new System.Drawing.Size(247, 22);
            this.tsmiExecuteLastSucessfullCommand.Text = "Execute last sucessfull command";
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.pnlSQLUpper.Size = new System.Drawing.Size(892, 45);
            this.pnlSQLUpper.TabIndex = 27;
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
            this.hsBreak.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsBreak.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.hsBreak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsBreak.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsBreak.ImageToggleOnSelect = true;
            this.hsBreak.Location = new System.Drawing.Point(469, 0);
            this.hsBreak.Marked = false;
            this.hsBreak.MarkedColor = System.Drawing.Color.Teal;
            this.hsBreak.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsBreak.MarkedText = "";
            this.hsBreak.MarkMode = false;
            this.hsBreak.Name = "hsBreak";
            this.hsBreak.NonMarkedText = "Break";
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
            this.hsReplaceText.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsReplaceText.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsReplaceText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsReplaceText.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsReplaceText.ImageToggleOnSelect = true;
            this.hsReplaceText.Location = new System.Drawing.Point(373, 0);
            this.hsReplaceText.Marked = false;
            this.hsReplaceText.MarkedColor = System.Drawing.Color.Teal;
            this.hsReplaceText.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsReplaceText.MarkedText = "";
            this.hsReplaceText.MarkMode = false;
            this.hsReplaceText.Name = "hsReplaceText";
            this.hsReplaceText.NonMarkedText = "Replace Text";
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
            this.hsSaveSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveSQL.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSaveSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveSQL.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSaveSQL.ImageToggleOnSelect = true;
            this.hsSaveSQL.Location = new System.Drawing.Point(305, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Size = new System.Drawing.Size(68, 41);
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
            this.hsLoadSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQL.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(237, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(68, 41);
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
            this.hsRunSQLfromFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunSQLfromFile.Image = global::FBXpert.Properties.Resources.applications_execute_script_blue_22x;
            this.hsRunSQLfromFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunSQLfromFile.ImageHover = global::FBXpert.Properties.Resources.applications_execute_script_blue_22x;
            this.hsRunSQLfromFile.ImageToggleOnSelect = true;
            this.hsRunSQLfromFile.Location = new System.Drawing.Point(136, 0);
            this.hsRunSQLfromFile.Marked = false;
            this.hsRunSQLfromFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunSQLfromFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunSQLfromFile.MarkedText = "";
            this.hsRunSQLfromFile.MarkMode = false;
            this.hsRunSQLfromFile.Name = "hsRunSQLfromFile";
            this.hsRunSQLfromFile.NonMarkedText = "Run SQL from File";
            this.hsRunSQLfromFile.Size = new System.Drawing.Size(101, 41);
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
            this.hsClearText.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearText.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsClearText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearText.ImageHover = global::FBXpert.Properties.Resources.document_blue_x32;
            this.hsClearText.ImageToggleOnSelect = true;
            this.hsClearText.Location = new System.Drawing.Point(68, 0);
            this.hsClearText.Marked = false;
            this.hsClearText.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearText.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearText.MarkedText = "";
            this.hsClearText.MarkMode = false;
            this.hsClearText.Name = "hsClearText";
            this.hsClearText.NonMarkedText = "Clear Text";
            this.hsClearText.Size = new System.Drawing.Size(68, 41);
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
            this.hsRunSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunSQL.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsRunSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunSQL.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsRunSQL.ImageToggleOnSelect = true;
            this.hsRunSQL.Location = new System.Drawing.Point(0, 0);
            this.hsRunSQL.Marked = false;
            this.hsRunSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunSQL.MarkedText = "";
            this.hsRunSQL.MarkMode = false;
            this.hsRunSQL.Name = "hsRunSQL";
            this.hsRunSQL.NonMarkedText = "Run SQL";
            this.hsRunSQL.Size = new System.Drawing.Size(68, 41);
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
            this.gbEncoding.Location = new System.Drawing.Point(766, 0);
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
            "UTF8"});
            this.cbEncoding.Location = new System.Drawing.Point(3, 16);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(116, 21);
            this.cbEncoding.TabIndex = 34;
            this.cbEncoding.Text = "UTF8";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 617);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(892, 10);
            this.progressBar1.TabIndex = 24;
            // 
            // tabRESULT
            // 
            this.tabRESULT.Controls.Add(this.dgvResults);
            this.tabRESULT.Controls.Add(this.bindingNavigator1);
            this.tabRESULT.Controls.Add(this.pnlResultUpper);
            this.tabRESULT.ImageIndex = 14;
            this.tabRESULT.Location = new System.Drawing.Point(4, 23);
            this.tabRESULT.Name = "tabRESULT";
            this.tabRESULT.Padding = new System.Windows.Forms.Padding(3);
            this.tabRESULT.Size = new System.Drawing.Size(898, 630);
            this.tabRESULT.TabIndex = 1;
            this.tabRESULT.Text = "Results grid";
            this.tabRESULT.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.DataSource = this.bindingSource1;
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
            this.dgvResults.Location = new System.Drawing.Point(3, 50);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.ShowCellErrors = false;
            this.dgvResults.ShowRowErrors = false;
            this.dgvResults.Size = new System.Drawing.Size(892, 552);
            this.dgvResults.TabIndex = 16;
            this.dgvResults.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvResults_CellPainting);
            this.dgvResults.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvResults_DataError);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dataSet1;
            this.bindingSource1.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.Table});
            // 
            // Table
            // 
            this.Table.TableName = "Table";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 602);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(892, 25);
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
            this.pnlResultUpper.Controls.Add(this.hsSaveDataset);
            this.pnlResultUpper.Controls.Add(this.gbEditMode);
            this.pnlResultUpper.Controls.Add(this.gbNavigator);
            this.pnlResultUpper.Controls.Add(this.gbUsedMilliseconds);
            this.pnlResultUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlResultUpper.Name = "pnlResultUpper";
            this.pnlResultUpper.Size = new System.Drawing.Size(892, 47);
            this.pnlResultUpper.TabIndex = 25;
            // 
            // gbRowHeight
            // 
            this.gbRowHeight.Controls.Add(this.txtRowHeight);
            this.gbRowHeight.Controls.Add(this.cbRowManually);
            this.gbRowHeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbRowHeight.Location = new System.Drawing.Point(612, 0);
            this.gbRowHeight.Name = "gbRowHeight";
            this.gbRowHeight.Size = new System.Drawing.Size(79, 43);
            this.gbRowHeight.TabIndex = 35;
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
            this.cbRowManually.Size = new System.Drawing.Size(26, 24);
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
            this.hsSaveDataset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsSaveDataset.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsSaveDataset.ImageToggleOnSelect = false;
            this.hsSaveDataset.Location = new System.Drawing.Point(524, 0);
            this.hsSaveDataset.Marked = false;
            this.hsSaveDataset.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveDataset.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveDataset.MarkedText = "";
            this.hsSaveDataset.MarkMode = false;
            this.hsSaveDataset.Name = "hsSaveDataset";
            this.hsSaveDataset.NonMarkedText = "Update";
            this.hsSaveDataset.Size = new System.Drawing.Size(88, 43);
            this.hsSaveDataset.TabIndex = 30;
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
            this.hsSaveDataset.Click += new System.EventHandler(this.hsSaveDataset_Click);
            // 
            // gbEditMode
            // 
            this.gbEditMode.Controls.Add(this.cbEditMode);
            this.gbEditMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbEditMode.Location = new System.Drawing.Point(448, 0);
            this.gbEditMode.Name = "gbEditMode";
            this.gbEditMode.Size = new System.Drawing.Size(76, 43);
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
            this.cbEditMode.Location = new System.Drawing.Point(3, 16);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(70, 24);
            this.cbEditMode.TabIndex = 29;
            this.cbEditMode.UseVisualStyleBackColor = true;
            this.cbEditMode.CheckedChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // gbNavigator
            // 
            this.gbNavigator.Controls.Add(this.bnTableContent);
            this.gbNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbNavigator.Location = new System.Drawing.Point(126, 0);
            this.gbNavigator.Name = "gbNavigator";
            this.gbNavigator.Size = new System.Drawing.Size(322, 43);
            this.gbNavigator.TabIndex = 33;
            this.gbNavigator.TabStop = false;
            this.gbNavigator.Text = "Navigator";
            // 
            // bnTableContent
            // 
            this.bnTableContent.AddNewItem = null;
            this.bnTableContent.BindingSource = this.bindingSource1;
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
            this.bnTableContent.Size = new System.Drawing.Size(316, 24);
            this.bnTableContent.TabIndex = 26;
            this.bnTableContent.Text = "bindingNavigator1";
            // 
            // bnTableContentCountItem
            // 
            this.bnTableContentCountItem.Name = "bnTableContentCountItem";
            this.bnTableContentCountItem.Size = new System.Drawing.Size(44, 21);
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
            this.bnTableContentMoveFirstItem.Size = new System.Drawing.Size(24, 21);
            this.bnTableContentMoveFirstItem.Text = "Move first";
            // 
            // bnTableContentMovePreviousItem
            // 
            this.bnTableContentMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMovePreviousItem.Image")));
            this.bnTableContentMovePreviousItem.Name = "bnTableContentMovePreviousItem";
            this.bnTableContentMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMovePreviousItem.Size = new System.Drawing.Size(24, 21);
            this.bnTableContentMovePreviousItem.Text = "Move previous";
            // 
            // bnTableContentSeparator
            // 
            this.bnTableContentSeparator.Name = "bnTableContentSeparator";
            this.bnTableContentSeparator.Size = new System.Drawing.Size(6, 24);
            // 
            // bnTableContentPositionItem
            // 
            this.bnTableContentPositionItem.AccessibleName = "Position";
            this.bnTableContentPositionItem.AutoSize = false;
            this.bnTableContentPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bnTableContentPositionItem.Name = "bnTableContentPositionItem";
            this.bnTableContentPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bnTableContentPositionItem.Text = "1";
            this.bnTableContentPositionItem.ToolTipText = "Current position";
            // 
            // bnTableContentSeparator1
            // 
            this.bnTableContentSeparator1.Name = "bnTableContentSeparator1";
            this.bnTableContentSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // bnTableContentMoveNextItem
            // 
            this.bnTableContentMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveNextItem.Image")));
            this.bnTableContentMoveNextItem.Name = "bnTableContentMoveNextItem";
            this.bnTableContentMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveNextItem.Size = new System.Drawing.Size(24, 21);
            this.bnTableContentMoveNextItem.Text = "Move next";
            // 
            // bnTableContentMoveLastItem
            // 
            this.bnTableContentMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnTableContentMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bnTableContentMoveLastItem.Image")));
            this.bnTableContentMoveLastItem.Name = "bnTableContentMoveLastItem";
            this.bnTableContentMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bnTableContentMoveLastItem.Size = new System.Drawing.Size(24, 21);
            this.bnTableContentMoveLastItem.Text = "Move last";
            // 
            // bnTableContentSeparator2
            // 
            this.bnTableContentSeparator2.Name = "bnTableContentSeparator2";
            this.bnTableContentSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // gbUsedMilliseconds
            // 
            this.gbUsedMilliseconds.Controls.Add(this.lblUsedMs);
            this.gbUsedMilliseconds.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbUsedMilliseconds.Location = new System.Drawing.Point(0, 0);
            this.gbUsedMilliseconds.Name = "gbUsedMilliseconds";
            this.gbUsedMilliseconds.Size = new System.Drawing.Size(126, 43);
            this.gbUsedMilliseconds.TabIndex = 31;
            this.gbUsedMilliseconds.TabStop = false;
            this.gbUsedMilliseconds.Text = "Costs in milliseconds";
            // 
            // lblUsedMs
            // 
            this.lblUsedMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsedMs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedMs.Location = new System.Drawing.Point(3, 16);
            this.lblUsedMs.Name = "lblUsedMs";
            this.lblUsedMs.Size = new System.Drawing.Size(120, 24);
            this.lblUsedMs.TabIndex = 0;
            this.lblUsedMs.Text = "0";
            this.lblUsedMs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabMELDUNG
            // 
            this.tabMELDUNG.BackColor = System.Drawing.SystemColors.Control;
            this.tabMELDUNG.Controls.Add(this.pnlInfoCenter);
            this.tabMELDUNG.Controls.Add(this.panel1);
            this.tabMELDUNG.ImageKey = "info_blue_22x.png";
            this.tabMELDUNG.Location = new System.Drawing.Point(4, 23);
            this.tabMELDUNG.Name = "tabMELDUNG";
            this.tabMELDUNG.Padding = new System.Windows.Forms.Padding(3);
            this.tabMELDUNG.Size = new System.Drawing.Size(898, 630);
            this.tabMELDUNG.TabIndex = 2;
            this.tabMELDUNG.Text = "Messagens";
            // 
            // pnlInfoCenter
            // 
            this.pnlInfoCenter.Controls.Add(this.rtfMELDUNG);
            this.pnlInfoCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoCenter.Location = new System.Drawing.Point(3, 50);
            this.pnlInfoCenter.Name = "pnlInfoCenter";
            this.pnlInfoCenter.Size = new System.Drawing.Size(892, 577);
            this.pnlInfoCenter.TabIndex = 25;
            // 
            // rtfMELDUNG
            // 
            this.rtfMELDUNG.BackColor = System.Drawing.SystemColors.Info;
            this.rtfMELDUNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfMELDUNG.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfMELDUNG.Location = new System.Drawing.Point(0, 0);
            this.rtfMELDUNG.Name = "rtfMELDUNG";
            this.rtfMELDUNG.Size = new System.Drawing.Size(892, 577);
            this.rtfMELDUNG.TabIndex = 0;
            this.rtfMELDUNG.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbMeldAutoclear);
            this.panel1.Controls.Add(this.hsClearInfo);
            this.panel1.Controls.Add(this.cbAutoScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 47);
            this.panel1.TabIndex = 24;
            // 
            // cbMeldAutoclear
            // 
            this.cbMeldAutoclear.AutoSize = true;
            this.cbMeldAutoclear.Checked = true;
            this.cbMeldAutoclear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMeldAutoclear.Location = new System.Drawing.Point(178, 16);
            this.cbMeldAutoclear.Name = "cbMeldAutoclear";
            this.cbMeldAutoclear.Size = new System.Drawing.Size(71, 17);
            this.cbMeldAutoclear.TabIndex = 22;
            this.cbMeldAutoclear.Text = "Autoclear";
            this.cbMeldAutoclear.UseVisualStyleBackColor = true;
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
            this.hsClearInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearInfo.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsClearInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearInfo.ImageHover = global::FBXpert.Properties.Resources.document_blue_x32;
            this.hsClearInfo.ImageToggleOnSelect = true;
            this.hsClearInfo.Location = new System.Drawing.Point(0, 0);
            this.hsClearInfo.Marked = false;
            this.hsClearInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearInfo.MarkedText = "";
            this.hsClearInfo.MarkMode = false;
            this.hsClearInfo.Name = "hsClearInfo";
            this.hsClearInfo.NonMarkedText = "Clear";
            this.hsClearInfo.Size = new System.Drawing.Size(45, 43);
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
            this.cbAutoScroll.Location = new System.Drawing.Point(100, 16);
            this.cbAutoScroll.Name = "cbAutoScroll";
            this.cbAutoScroll.Size = new System.Drawing.Size(72, 17);
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
            this.tabERRORS.Size = new System.Drawing.Size(898, 630);
            this.tabERRORS.TabIndex = 4;
            this.tabERRORS.Text = "Errors";
            // 
            // pnlErrorUpper
            // 
            this.pnlErrorUpper.Controls.Add(this.rtfERRORS);
            this.pnlErrorUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlErrorUpper.Location = new System.Drawing.Point(3, 50);
            this.pnlErrorUpper.Name = "pnlErrorUpper";
            this.pnlErrorUpper.Size = new System.Drawing.Size(892, 577);
            this.pnlErrorUpper.TabIndex = 24;
            // 
            // rtfERRORS
            // 
            this.rtfERRORS.BackColor = System.Drawing.SystemColors.Info;
            this.rtfERRORS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfERRORS.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfERRORS.Location = new System.Drawing.Point(0, 0);
            this.rtfERRORS.Name = "rtfERRORS";
            this.rtfERRORS.Size = new System.Drawing.Size(892, 577);
            this.rtfERRORS.TabIndex = 1;
            this.rtfERRORS.Text = "";
            // 
            // pnlErrorsUpper
            // 
            this.pnlErrorsUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlErrorsUpper.Controls.Add(this.cbAutoSrcollErr);
            this.pnlErrorsUpper.Controls.Add(this.hsClearErrorAll);
            this.pnlErrorsUpper.Controls.Add(this.cbErrAutoclear);
            this.pnlErrorsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlErrorsUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlErrorsUpper.Name = "pnlErrorsUpper";
            this.pnlErrorsUpper.Size = new System.Drawing.Size(892, 47);
            this.pnlErrorsUpper.TabIndex = 23;
            // 
            // cbAutoSrcollErr
            // 
            this.cbAutoSrcollErr.AutoSize = true;
            this.cbAutoSrcollErr.Checked = true;
            this.cbAutoSrcollErr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoSrcollErr.Location = new System.Drawing.Point(202, 24);
            this.cbAutoSrcollErr.Name = "cbAutoSrcollErr";
            this.cbAutoSrcollErr.Size = new System.Drawing.Size(72, 17);
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
            this.hsClearErrorAll.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearErrorAll.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsClearErrorAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearErrorAll.ImageHover = global::FBXpert.Properties.Resources.document_blue_x32;
            this.hsClearErrorAll.ImageToggleOnSelect = true;
            this.hsClearErrorAll.Location = new System.Drawing.Point(0, 0);
            this.hsClearErrorAll.Marked = false;
            this.hsClearErrorAll.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearErrorAll.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearErrorAll.MarkedText = "";
            this.hsClearErrorAll.MarkMode = false;
            this.hsClearErrorAll.Name = "hsClearErrorAll";
            this.hsClearErrorAll.NonMarkedText = "Clear All";
            this.hsClearErrorAll.Size = new System.Drawing.Size(88, 43);
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
            // cbErrAutoclear
            // 
            this.cbErrAutoclear.AutoSize = true;
            this.cbErrAutoclear.Checked = true;
            this.cbErrAutoclear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbErrAutoclear.Location = new System.Drawing.Point(125, 24);
            this.cbErrAutoclear.Name = "cbErrAutoclear";
            this.cbErrAutoclear.Size = new System.Drawing.Size(71, 17);
            this.cbErrAutoclear.TabIndex = 21;
            this.cbErrAutoclear.Text = "Autoclear";
            this.cbErrAutoclear.UseVisualStyleBackColor = true;
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
            this.tabHistory.Size = new System.Drawing.Size(898, 630);
            this.tabHistory.TabIndex = 3;
            this.tabHistory.Text = "History";
            // 
            // pnlHistoryCenter
            // 
            this.pnlHistoryCenter.Controls.Add(this.tabControlHistory);
            this.pnlHistoryCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistoryCenter.Location = new System.Drawing.Point(3, 52);
            this.pnlHistoryCenter.Name = "pnlHistoryCenter";
            this.pnlHistoryCenter.Size = new System.Drawing.Size(892, 575);
            this.pnlHistoryCenter.TabIndex = 24;
            // 
            // tabControlHistory
            // 
            this.tabControlHistory.Controls.Add(this.tabPageSucceeded);
            this.tabControlHistory.Controls.Add(this.tabPageFailedHistory);
            this.tabControlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHistory.Location = new System.Drawing.Point(0, 0);
            this.tabControlHistory.Name = "tabControlHistory";
            this.tabControlHistory.SelectedIndex = 0;
            this.tabControlHistory.Size = new System.Drawing.Size(892, 575);
            this.tabControlHistory.TabIndex = 1;
            // 
            // tabPageSucceeded
            // 
            this.tabPageSucceeded.Controls.Add(this.clbHISTORY);
            this.tabPageSucceeded.Location = new System.Drawing.Point(4, 22);
            this.tabPageSucceeded.Name = "tabPageSucceeded";
            this.tabPageSucceeded.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSucceeded.Size = new System.Drawing.Size(884, 549);
            this.tabPageSucceeded.TabIndex = 0;
            this.tabPageSucceeded.Text = "commands succeded";
            this.tabPageSucceeded.UseVisualStyleBackColor = true;
            // 
            // clbHISTORY
            // 
            this.clbHISTORY.CheckOnClick = true;
            this.clbHISTORY.ContextMenuStrip = this.cmsHistory;
            this.clbHISTORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbHISTORY.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbHISTORY.FormattingEnabled = true;
            this.clbHISTORY.HorizontalScrollbar = true;
            this.clbHISTORY.Location = new System.Drawing.Point(3, 3);
            this.clbHISTORY.Name = "clbHISTORY";
            this.clbHISTORY.ScrollAlwaysVisible = true;
            this.clbHISTORY.Size = new System.Drawing.Size(878, 543);
            this.clbHISTORY.TabIndex = 0;
            this.clbHISTORY.DoubleClick += new System.EventHandler(this.clbHISTORY_DoubleClick);
            // 
            // tabPageFailedHistory
            // 
            this.tabPageFailedHistory.Controls.Add(this.clbFAILED_HISTORY);
            this.tabPageFailedHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageFailedHistory.Name = "tabPageFailedHistory";
            this.tabPageFailedHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFailedHistory.Size = new System.Drawing.Size(884, 549);
            this.tabPageFailedHistory.TabIndex = 1;
            this.tabPageFailedHistory.Text = "failed commands";
            this.tabPageFailedHistory.UseVisualStyleBackColor = true;
            // 
            // clbFAILED_HISTORY
            // 
            this.clbFAILED_HISTORY.CheckOnClick = true;
            this.clbFAILED_HISTORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbFAILED_HISTORY.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbFAILED_HISTORY.FormattingEnabled = true;
            this.clbFAILED_HISTORY.HorizontalScrollbar = true;
            this.clbFAILED_HISTORY.Location = new System.Drawing.Point(3, 3);
            this.clbFAILED_HISTORY.Name = "clbFAILED_HISTORY";
            this.clbFAILED_HISTORY.ScrollAlwaysVisible = true;
            this.clbFAILED_HISTORY.Size = new System.Drawing.Size(878, 543);
            this.clbFAILED_HISTORY.TabIndex = 1;
            this.clbFAILED_HISTORY.DoubleClick += new System.EventHandler(this.clbFAILED_HISTORY_DoubleClick);
            // 
            // pnlHistoryUpper
            // 
            this.pnlHistoryUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHistoryUpper.Controls.Add(this.hsCrearAllFailed);
            this.pnlHistoryUpper.Controls.Add(this.hsClearHistoryAll);
            this.pnlHistoryUpper.Controls.Add(this.hsClearHistorySelected);
            this.pnlHistoryUpper.Controls.Add(this.hsExecuteHistorySelected);
            this.pnlHistoryUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlHistoryUpper.Name = "pnlHistoryUpper";
            this.pnlHistoryUpper.Size = new System.Drawing.Size(892, 49);
            this.pnlHistoryUpper.TabIndex = 23;
            // 
            // hsCrearAllFailed
            // 
            this.hsCrearAllFailed.BackColor = System.Drawing.Color.Transparent;
            this.hsCrearAllFailed.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCrearAllFailed.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCrearAllFailed.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCrearAllFailed.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCrearAllFailed.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCrearAllFailed.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCrearAllFailed.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCrearAllFailed.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCrearAllFailed.FlatAppearance.BorderSize = 0;
            this.hsCrearAllFailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCrearAllFailed.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCrearAllFailed.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsCrearAllFailed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCrearAllFailed.ImageHover = global::FBXpert.Properties.Resources.document_blue_x32;
            this.hsCrearAllFailed.ImageToggleOnSelect = true;
            this.hsCrearAllFailed.Location = new System.Drawing.Point(334, 0);
            this.hsCrearAllFailed.Marked = false;
            this.hsCrearAllFailed.MarkedColor = System.Drawing.Color.Teal;
            this.hsCrearAllFailed.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCrearAllFailed.MarkedText = "";
            this.hsCrearAllFailed.MarkMode = false;
            this.hsCrearAllFailed.Name = "hsCrearAllFailed";
            this.hsCrearAllFailed.NonMarkedText = "Clear failed";
            this.hsCrearAllFailed.Size = new System.Drawing.Size(119, 45);
            this.hsCrearAllFailed.TabIndex = 31;
            this.hsCrearAllFailed.Text = "Clear failed";
            this.hsCrearAllFailed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCrearAllFailed.ToolTipActive = false;
            this.hsCrearAllFailed.ToolTipAutomaticDelay = 500;
            this.hsCrearAllFailed.ToolTipAutoPopDelay = 5000;
            this.hsCrearAllFailed.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCrearAllFailed.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCrearAllFailed.ToolTipFor4ContextMenu = true;
            this.hsCrearAllFailed.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCrearAllFailed.ToolTipInitialDelay = 500;
            this.hsCrearAllFailed.ToolTipIsBallon = false;
            this.hsCrearAllFailed.ToolTipOwnerDraw = false;
            this.hsCrearAllFailed.ToolTipReshowDelay = 100;
            this.hsCrearAllFailed.ToolTipShowAlways = false;
            this.hsCrearAllFailed.ToolTipText = "";
            this.hsCrearAllFailed.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCrearAllFailed.ToolTipTitle = "";
            this.hsCrearAllFailed.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCrearAllFailed.UseVisualStyleBackColor = false;
            this.hsCrearAllFailed.Click += new System.EventHandler(this.hsCrearAllFailed_Click);
            // 
            // hsClearHistoryAll
            // 
            this.hsClearHistoryAll.BackColor = System.Drawing.Color.Transparent;
            this.hsClearHistoryAll.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearHistoryAll.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearHistoryAll.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearHistoryAll.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearHistoryAll.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearHistoryAll.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearHistoryAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearHistoryAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearHistoryAll.FlatAppearance.BorderSize = 0;
            this.hsClearHistoryAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearHistoryAll.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearHistoryAll.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsClearHistoryAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearHistoryAll.ImageHover = global::FBXpert.Properties.Resources.document_blue_x32;
            this.hsClearHistoryAll.ImageToggleOnSelect = true;
            this.hsClearHistoryAll.Location = new System.Drawing.Point(215, 0);
            this.hsClearHistoryAll.Marked = false;
            this.hsClearHistoryAll.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearHistoryAll.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearHistoryAll.MarkedText = "";
            this.hsClearHistoryAll.MarkMode = false;
            this.hsClearHistoryAll.Name = "hsClearHistoryAll";
            this.hsClearHistoryAll.NonMarkedText = "Clear scucceeded";
            this.hsClearHistoryAll.Size = new System.Drawing.Size(119, 45);
            this.hsClearHistoryAll.TabIndex = 30;
            this.hsClearHistoryAll.Text = "Clear scucceeded";
            this.hsClearHistoryAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearHistoryAll.ToolTipActive = false;
            this.hsClearHistoryAll.ToolTipAutomaticDelay = 500;
            this.hsClearHistoryAll.ToolTipAutoPopDelay = 5000;
            this.hsClearHistoryAll.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearHistoryAll.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearHistoryAll.ToolTipFor4ContextMenu = true;
            this.hsClearHistoryAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearHistoryAll.ToolTipInitialDelay = 500;
            this.hsClearHistoryAll.ToolTipIsBallon = false;
            this.hsClearHistoryAll.ToolTipOwnerDraw = false;
            this.hsClearHistoryAll.ToolTipReshowDelay = 100;
            this.hsClearHistoryAll.ToolTipShowAlways = false;
            this.hsClearHistoryAll.ToolTipText = "";
            this.hsClearHistoryAll.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearHistoryAll.ToolTipTitle = "";
            this.hsClearHistoryAll.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearHistoryAll.UseVisualStyleBackColor = false;
            this.hsClearHistoryAll.Click += new System.EventHandler(this.hsClearHistoryAll_Click);
            // 
            // hsClearHistorySelected
            // 
            this.hsClearHistorySelected.BackColor = System.Drawing.Color.Transparent;
            this.hsClearHistorySelected.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearHistorySelected.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearHistorySelected.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearHistorySelected.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearHistorySelected.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearHistorySelected.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearHistorySelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearHistorySelected.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearHistorySelected.FlatAppearance.BorderSize = 0;
            this.hsClearHistorySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearHistorySelected.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearHistorySelected.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsClearHistorySelected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearHistorySelected.ImageHover = global::FBXpert.Properties.Resources.document_blue_x32;
            this.hsClearHistorySelected.ImageToggleOnSelect = true;
            this.hsClearHistorySelected.Location = new System.Drawing.Point(90, 0);
            this.hsClearHistorySelected.Marked = false;
            this.hsClearHistorySelected.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearHistorySelected.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearHistorySelected.MarkedText = "";
            this.hsClearHistorySelected.MarkMode = false;
            this.hsClearHistorySelected.Name = "hsClearHistorySelected";
            this.hsClearHistorySelected.NonMarkedText = "Clear all checked";
            this.hsClearHistorySelected.Size = new System.Drawing.Size(125, 45);
            this.hsClearHistorySelected.TabIndex = 29;
            this.hsClearHistorySelected.Text = "Clear all checked";
            this.hsClearHistorySelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearHistorySelected.ToolTipActive = false;
            this.hsClearHistorySelected.ToolTipAutomaticDelay = 500;
            this.hsClearHistorySelected.ToolTipAutoPopDelay = 5000;
            this.hsClearHistorySelected.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearHistorySelected.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearHistorySelected.ToolTipFor4ContextMenu = true;
            this.hsClearHistorySelected.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearHistorySelected.ToolTipInitialDelay = 500;
            this.hsClearHistorySelected.ToolTipIsBallon = false;
            this.hsClearHistorySelected.ToolTipOwnerDraw = false;
            this.hsClearHistorySelected.ToolTipReshowDelay = 100;
            this.hsClearHistorySelected.ToolTipShowAlways = false;
            this.hsClearHistorySelected.ToolTipText = "";
            this.hsClearHistorySelected.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearHistorySelected.ToolTipTitle = "";
            this.hsClearHistorySelected.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearHistorySelected.UseVisualStyleBackColor = false;
            this.hsClearHistorySelected.Click += new System.EventHandler(this.hsClearHistorySelected_Click);
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
            this.hsExecuteHistorySelected.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExecuteHistorySelected.Image = global::FBXpert.Properties.Resources.applications_system;
            this.hsExecuteHistorySelected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExecuteHistorySelected.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsExecuteHistorySelected.ImageToggleOnSelect = true;
            this.hsExecuteHistorySelected.Location = new System.Drawing.Point(0, 0);
            this.hsExecuteHistorySelected.Marked = false;
            this.hsExecuteHistorySelected.MarkedColor = System.Drawing.Color.Teal;
            this.hsExecuteHistorySelected.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExecuteHistorySelected.MarkedText = "";
            this.hsExecuteHistorySelected.MarkMode = false;
            this.hsExecuteHistorySelected.Name = "hsExecuteHistorySelected";
            this.hsExecuteHistorySelected.NonMarkedText = "Execute";
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
            this.tabRelpacelist.Size = new System.Drawing.Size(898, 630);
            this.tabRelpacelist.TabIndex = 5;
            this.tabRelpacelist.Text = "Replaces";
            // 
            // pnlReplacesCenter
            // 
            this.pnlReplacesCenter.Controls.Add(this.rtbReplace);
            this.pnlReplacesCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReplacesCenter.Location = new System.Drawing.Point(3, 51);
            this.pnlReplacesCenter.Name = "pnlReplacesCenter";
            this.pnlReplacesCenter.Size = new System.Drawing.Size(892, 576);
            this.pnlReplacesCenter.TabIndex = 5;
            // 
            // rtbReplace
            // 
            this.rtbReplace.AcceptsTab = true;
            this.rtbReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReplace.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReplace.Location = new System.Drawing.Point(0, 0);
            this.rtbReplace.Name = "rtbReplace";
            this.rtbReplace.Size = new System.Drawing.Size(892, 576);
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
            this.pnlRelpacesUpper.Size = new System.Drawing.Size(892, 48);
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
            this.hsLoadListReplaces.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadListReplaces.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadListReplaces.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadListReplaces.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadListReplaces.ImageToggleOnSelect = true;
            this.hsLoadListReplaces.Location = new System.Drawing.Point(0, 0);
            this.hsLoadListReplaces.Marked = false;
            this.hsLoadListReplaces.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadListReplaces.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadListReplaces.MarkedText = "";
            this.hsLoadListReplaces.MarkMode = false;
            this.hsLoadListReplaces.Name = "hsLoadListReplaces";
            this.hsLoadListReplaces.NonMarkedText = "Load List";
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
            this.tabOptionen.Size = new System.Drawing.Size(898, 630);
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
            this.cbClearListBeforeExcecute.Size = new System.Drawing.Size(144, 17);
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
            this.hsRefreshConfig.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshConfig.Image = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsRefreshConfig.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsRefreshConfig.ImageToggleOnSelect = true;
            this.hsRefreshConfig.Location = new System.Drawing.Point(287, 19);
            this.hsRefreshConfig.Marked = false;
            this.hsRefreshConfig.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshConfig.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshConfig.MarkedText = "";
            this.hsRefreshConfig.MarkMode = false;
            this.hsRefreshConfig.Name = "hsRefreshConfig";
            this.hsRefreshConfig.NonMarkedText = "";
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
            this.rbErrInsert.Size = new System.Drawing.Size(84, 17);
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
            this.rbErrAppend.Size = new System.Drawing.Size(101, 17);
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
            this.btnLoadMeld.Image = global::FBXpert.Properties.Resources.documents_plus_32x;
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
            this.rbMeldInsert.Size = new System.Drawing.Size(84, 17);
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
            this.rbMeldAppend.Size = new System.Drawing.Size(101, 17);
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
            this.tabPagePlan.Size = new System.Drawing.Size(898, 630);
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
            this.pnlPlanCenter.Size = new System.Drawing.Size(892, 528);
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
            this.fctPlan.Size = new System.Drawing.Size(892, 528);
            this.fctPlan.TabIndex = 0;
            this.fctPlan.Text = "fastColoredTextBox1";
            this.fctPlan.Zoom = 100;
            // 
            // pnlPlanLower
            // 
            this.pnlPlanLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlanLower.Location = new System.Drawing.Point(3, 579);
            this.pnlPlanLower.Name = "pnlPlanLower";
            this.pnlPlanLower.Size = new System.Drawing.Size(892, 48);
            this.pnlPlanLower.TabIndex = 6;
            // 
            // pnlPlanUpper
            // 
            this.pnlPlanUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPlanUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlanUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlanUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlPlanUpper.Name = "pnlPlanUpper";
            this.pnlPlanUpper.Size = new System.Drawing.Size(892, 48);
            this.pnlPlanUpper.TabIndex = 5;
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.tabControlExport);
            this.tabPageExport.ImageIndex = 15;
            this.tabPageExport.Location = new System.Drawing.Point(4, 23);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(898, 630);
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
            this.tabControlExport.Size = new System.Drawing.Size(892, 624);
            this.tabControlExport.TabIndex = 0;
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.fctXMLData);
            this.tabPageXML.Controls.Add(this.pnlXMLDataUpper);
            this.tabPageXML.Location = new System.Drawing.Point(4, 22);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXML.Size = new System.Drawing.Size(884, 598);
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
            this.fctXMLData.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctXMLData.BackBrush = null;
            this.fctXMLData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctXMLData.CharHeight = 14;
            this.fctXMLData.CharWidth = 8;
            this.fctXMLData.CommentPrefix = "--";
            this.fctXMLData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctXMLData.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctXMLData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctXMLData.IsReplaceMode = false;
            this.fctXMLData.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctXMLData.LeftBracket = '(';
            this.fctXMLData.Location = new System.Drawing.Point(3, 51);
            this.fctXMLData.Name = "fctXMLData";
            this.fctXMLData.Paddings = new System.Windows.Forms.Padding(0);
            this.fctXMLData.RightBracket = ')';
            this.fctXMLData.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctXMLData.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctXMLData.ServiceColors")));
            this.fctXMLData.Size = new System.Drawing.Size(878, 544);
            this.fctXMLData.TabIndex = 7;
            this.fctXMLData.Zoom = 100;
            // 
            // pnlXMLDataUpper
            // 
            this.pnlXMLDataUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlXMLDataUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlXMLDataUpper.Controls.Add(this.hsSaveXML);
            this.pnlXMLDataUpper.Controls.Add(this.hsRefreshXMLData);
            this.pnlXMLDataUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLDataUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlXMLDataUpper.Name = "pnlXMLDataUpper";
            this.pnlXMLDataUpper.Size = new System.Drawing.Size(878, 48);
            this.pnlXMLDataUpper.TabIndex = 6;
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
            this.hsSaveXML.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveXML.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSaveXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveXML.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSaveXML.ImageToggleOnSelect = true;
            this.hsSaveXML.Location = new System.Drawing.Point(0, 0);
            this.hsSaveXML.Marked = false;
            this.hsSaveXML.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveXML.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveXML.MarkedText = "";
            this.hsSaveXML.MarkMode = false;
            this.hsSaveXML.Name = "hsSaveXML";
            this.hsSaveXML.NonMarkedText = "Save XML-Data";
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
            this.hsRefreshXMLData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshXMLData.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshXMLData.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshXMLData.ImageToggleOnSelect = true;
            this.hsRefreshXMLData.Location = new System.Drawing.Point(829, 0);
            this.hsRefreshXMLData.Marked = false;
            this.hsRefreshXMLData.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshXMLData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshXMLData.MarkedText = "";
            this.hsRefreshXMLData.MarkMode = false;
            this.hsRefreshXMLData.Name = "hsRefreshXMLData";
            this.hsRefreshXMLData.NonMarkedText = "";
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
            // tabPageXMLScheme
            // 
            this.tabPageXMLScheme.Controls.Add(this.fctXMLScheme);
            this.tabPageXMLScheme.Controls.Add(this.pnlXMLScheme);
            this.tabPageXMLScheme.Location = new System.Drawing.Point(4, 22);
            this.tabPageXMLScheme.Name = "tabPageXMLScheme";
            this.tabPageXMLScheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXMLScheme.Size = new System.Drawing.Size(884, 598);
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
            this.fctXMLScheme.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctXMLScheme.BackBrush = null;
            this.fctXMLScheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctXMLScheme.CharHeight = 14;
            this.fctXMLScheme.CharWidth = 8;
            this.fctXMLScheme.CommentPrefix = "--";
            this.fctXMLScheme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctXMLScheme.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctXMLScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctXMLScheme.IsReplaceMode = false;
            this.fctXMLScheme.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctXMLScheme.LeftBracket = '(';
            this.fctXMLScheme.Location = new System.Drawing.Point(3, 51);
            this.fctXMLScheme.Name = "fctXMLScheme";
            this.fctXMLScheme.Paddings = new System.Windows.Forms.Padding(0);
            this.fctXMLScheme.RightBracket = ')';
            this.fctXMLScheme.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctXMLScheme.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctXMLScheme.ServiceColors")));
            this.fctXMLScheme.Size = new System.Drawing.Size(878, 544);
            this.fctXMLScheme.TabIndex = 9;
            this.fctXMLScheme.Zoom = 100;
            // 
            // pnlXMLScheme
            // 
            this.pnlXMLScheme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlXMLScheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlXMLScheme.Controls.Add(this.hsSaveXMLScheme);
            this.pnlXMLScheme.Controls.Add(this.hsRefreshXMLScheme);
            this.pnlXMLScheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLScheme.Location = new System.Drawing.Point(3, 3);
            this.pnlXMLScheme.Name = "pnlXMLScheme";
            this.pnlXMLScheme.Size = new System.Drawing.Size(878, 48);
            this.pnlXMLScheme.TabIndex = 8;
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
            this.hsSaveXMLScheme.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveXMLScheme.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSaveXMLScheme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveXMLScheme.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSaveXMLScheme.ImageToggleOnSelect = true;
            this.hsSaveXMLScheme.Location = new System.Drawing.Point(0, 0);
            this.hsSaveXMLScheme.Marked = false;
            this.hsSaveXMLScheme.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveXMLScheme.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveXMLScheme.MarkedText = "";
            this.hsSaveXMLScheme.MarkMode = false;
            this.hsSaveXMLScheme.Name = "hsSaveXMLScheme";
            this.hsSaveXMLScheme.NonMarkedText = "Save XML-Scheme";
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
            this.hsRefreshXMLScheme.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshXMLScheme.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshXMLScheme.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshXMLScheme.ImageToggleOnSelect = true;
            this.hsRefreshXMLScheme.Location = new System.Drawing.Point(829, 0);
            this.hsRefreshXMLScheme.Marked = false;
            this.hsRefreshXMLScheme.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshXMLScheme.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshXMLScheme.MarkedText = "";
            this.hsRefreshXMLScheme.MarkMode = false;
            this.hsRefreshXMLScheme.Name = "hsRefreshXMLScheme";
            this.hsRefreshXMLScheme.NonMarkedText = "";
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
            this.tabPagePerformance.Controls.Add(this.panel2);
            this.tabPagePerformance.ImageIndex = 16;
            this.tabPagePerformance.Location = new System.Drawing.Point(4, 23);
            this.tabPagePerformance.Name = "tabPagePerformance";
            this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerformance.Size = new System.Drawing.Size(898, 630);
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
            this.gbPerformance.Size = new System.Drawing.Size(892, 576);
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
            this.lvPerformance.Location = new System.Drawing.Point(3, 16);
            this.lvPerformance.Name = "lvPerformance";
            this.lvPerformance.Size = new System.Drawing.Size(886, 557);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.hotSpot1);
            this.panel2.Controls.Add(this.hsRefreshPerformance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 48);
            this.panel2.TabIndex = 7;
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
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(0, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Save XML-Data";
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
            this.hsRefreshPerformance.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshPerformance.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshPerformance.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshPerformance.ImageToggleOnSelect = true;
            this.hsRefreshPerformance.Location = new System.Drawing.Point(843, 0);
            this.hsRefreshPerformance.Marked = false;
            this.hsRefreshPerformance.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshPerformance.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshPerformance.MarkedText = "";
            this.hsRefreshPerformance.MarkMode = false;
            this.hsRefreshPerformance.Name = "hsRefreshPerformance";
            this.hsRefreshPerformance.NonMarkedText = "";
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
            // cmsHistory
            // 
            this.cmsHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSortASC,
            this.tsmiSortDESC});
            this.cmsHistory.Name = "cmsHistory";
            this.cmsHistory.Size = new System.Drawing.Size(181, 70);
            this.cmsHistory.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsHistory_ItemClicked);
            // 
            // tsmiSortASC
            // 
            this.tsmiSortASC.Image = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.tsmiSortASC.Name = "tsmiSortASC";
            this.tsmiSortASC.Size = new System.Drawing.Size(180, 22);
            this.tsmiSortASC.Text = "Sort ascending";
            // 
            // tsmiSortDESC
            // 
            this.tsmiSortDESC.Image = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.tsmiSortDESC.Name = "tsmiSortDESC";
            this.tsmiSortDESC.Size = new System.Drawing.Size(180, 22);
            this.tsmiSortDESC.Text = "Sort descending";
            // 
            // SQLViewForm1
            // 
            this.ClientSize = new System.Drawing.Size(908, 699);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_upper);
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
            this.pnl_upper.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabERRORS.ResumeLayout(false);
            this.pnlErrorUpper.ResumeLayout(false);
            this.pnlErrorsUpper.ResumeLayout(false);
            this.pnlErrorsUpper.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.pnlHistoryCenter.ResumeLayout(false);
            this.tabControlHistory.ResumeLayout(false);
            this.tabPageSucceeded.ResumeLayout(false);
            this.tabPageFailedHistory.ResumeLayout(false);
            this.pnlHistoryUpper.ResumeLayout(false);
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
            this.tabPageXMLScheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctXMLScheme)).EndInit();
            this.pnlXMLScheme.ResumeLayout(false);
            this.tabPagePerformance.ResumeLayout(false);
            this.gbPerformance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.cmsHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private TabControl tcSQLCONTROL;
        private TabPage tabSQLTEXT;
        private TabPage tabRESULT;
        private DataGridView dgvResults;
        private TabPage tabMELDUNG;
        private RichTextBox rtfMELDUNG;
        private TabPage tabHistory;
        private CheckedListBox clbHISTORY;
        private SaveFileDialog sfdSQL;
        private HelpProvider helpMain;
        private TabPage tabERRORS;
        private RichTextBox rtfERRORS;
        private System.Data.DataTable Table;
        private ProgressBar progressBar1;
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
        private CheckBox cbMeldAutoclear;
        private CheckBox cbErrAutoclear;
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
        private Panel panel1;
        private SeControlsLib.HotSpot hsClearInfo;
        private Panel pnlInfoCenter;
        private Panel pnlHistoryUpper;
        private SeControlsLib.HotSpot hsClearHistorySelected;
        private SeControlsLib.HotSpot hsExecuteHistorySelected;
        private SeControlsLib.HotSpot hsClearHistoryAll;
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
        private SeControlsLib.HotSpot hsSaveDataset;
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
        private Panel pnlXMLScheme;
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
        private Panel panel2;
        private SeControlsLib.HotSpot hotSpot1;
        private SeControlsLib.HotSpot hsRefreshPerformance;
        private ColumnHeader colSEQ_READS;
        private ColumnHeader colINX_READS;
        private ColumnHeader colINSERTS;
        private ColumnHeader colUPDATES;
        private ColumnHeader colDELETES;
        private ColumnHeader colCONFLICTS;
        private TabControl tabControlHistory;
        private TabPage tabPageSucceeded;
        private TabPage tabPageFailedHistory;
        private CheckedListBox clbFAILED_HISTORY;
        private SeControlsLib.HotSpot hsCrearAllFailed;
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
        private ContextMenuStrip cmsHistory;
        private ToolStripMenuItem tsmiSortASC;
        private ToolStripMenuItem tsmiSortDESC;
    }
}
