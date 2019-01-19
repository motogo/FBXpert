using BasicForms;

namespace FBXpert.SQLView
{
    partial class ScriptingForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptingForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.bnConnection = new System.Windows.Forms.GroupBox();
            this.cbConnection = new System.Windows.Forms.ComboBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.fcbNotify = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlGauge = new System.Windows.Forms.Panel();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblGauge = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.splitScript = new System.Windows.Forms.SplitContainer();
            this.tabScripting = new System.Windows.Forms.TabControl();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.gbSQLText = new System.Windows.Forms.GroupBox();
            this.fcbSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsSQLText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDDLCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDDLPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.gbScriptRightPanel = new System.Windows.Forms.GroupBox();
            this.hsExecuteSQL = new SeControlsLib.HotSpot();
            this.hsRunSQLDirect = new SeControlsLib.HotSpot();
            this.pnlUpperSQL = new System.Windows.Forms.Panel();
            this.hsClearSQL = new SeControlsLib.HotSpot();
            this.hsSave = new SeControlsLib.HotSpot();
            this.hsLoadScript = new SeControlsLib.HotSpot();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.pnlOptionsCenter = new System.Windows.Forms.Panel();
            this.gbSQLFiles = new System.Windows.Forms.GroupBox();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSQLFilesRight = new System.Windows.Forms.GroupBox();
            this.hsPrepareSQLFromFiles = new SeControlsLib.HotSpot();
            this.hsRunFilesDirect = new SeControlsLib.HotSpot();
            this.gbAddFile = new System.Windows.Forms.GroupBox();
            this.pnlSQLFileLower = new System.Windows.Forms.Panel();
            this.gbSQLLocation = new System.Windows.Forms.GroupBox();
            this.txtSQLLocation = new System.Windows.Forms.TextBox();
            this.hsLoad = new SeControlsLib.HotSpot();
            this.gbOptionsFilesize = new System.Windows.Forms.GroupBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.hsAddBackupFile = new SeControlsLib.HotSpot();
            this.hsRemoveBackupFile = new SeControlsLib.HotSpot();
            this.tabPagePreparedCommands = new System.Windows.Forms.TabPage();
            this.lvCommands = new System.Windows.Forms.ListView();
            this.colNR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMDTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPreparedCommands = new System.Windows.Forms.GroupBox();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.gbCommandsDone = new System.Windows.Forms.GroupBox();
            this.fcbCommands = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlCommandsUpper = new System.Windows.Forms.Panel();
            this.hsRunAllCommands = new SeControlsLib.HotSpot();
            this.hsRunActualCommand = new SeControlsLib.HotSpot();
            this.label1 = new System.Windows.Forms.Label();
            this.hsClearCmds = new SeControlsLib.HotSpot();
            this.txtClear = new System.Windows.Forms.TextBox();
            this.pnlLeftCommands = new System.Windows.Forms.Panel();
            this.cbClearBeforePreparing = new System.Windows.Forms.CheckBox();
            this.cbReopenConnectionEachCommand = new System.Windows.Forms.CheckBox();
            this.cbCommitEachCmd = new System.Windows.Forms.CheckBox();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.sfSQL = new System.Windows.Forms.SaveFileDialog();
            this.pnlUpper.SuspendLayout();
            this.bnConnection.SuspendLayout();
            this.pnlLower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbNotify)).BeginInit();
            this.pnlGauge.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitScript)).BeginInit();
            this.splitScript.Panel1.SuspendLayout();
            this.splitScript.Panel2.SuspendLayout();
            this.splitScript.SuspendLayout();
            this.tabScripting.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            this.gbSQL.SuspendLayout();
            this.gbSQLText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbSQL)).BeginInit();
            this.cmsSQLText.SuspendLayout();
            this.gbScriptRightPanel.SuspendLayout();
            this.pnlUpperSQL.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.pnlOptionsCenter.SuspendLayout();
            this.gbSQLFiles.SuspendLayout();
            this.gbSQLFilesRight.SuspendLayout();
            this.gbAddFile.SuspendLayout();
            this.pnlSQLFileLower.SuspendLayout();
            this.gbSQLLocation.SuspendLayout();
            this.gbOptionsFilesize.SuspendLayout();
            this.tabPagePreparedCommands.SuspendLayout();
            this.gbPreparedCommands.SuspendLayout();
            this.gbCommandsDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbCommands)).BeginInit();
            this.pnlCommandsUpper.SuspendLayout();
            this.pnlLeftCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpper.Controls.Add(this.bnConnection);
            this.pnlUpper.Controls.Add(this.lblCaption);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1924, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // bnConnection
            // 
            this.bnConnection.Controls.Add(this.cbConnection);
            this.bnConnection.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnConnection.Location = new System.Drawing.Point(1193, 0);
            this.bnConnection.Name = "bnConnection";
            this.bnConnection.Size = new System.Drawing.Size(727, 38);
            this.bnConnection.TabIndex = 4;
            this.bnConnection.TabStop = false;
            this.bnConnection.Text = "Use connection";
            // 
            // cbConnection
            // 
            this.cbConnection.BackColor = System.Drawing.SystemColors.Info;
            this.cbConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbConnection.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConnection.FormattingEnabled = true;
            this.cbConnection.Location = new System.Drawing.Point(3, 16);
            this.cbConnection.Name = "cbConnection";
            this.cbConnection.Size = new System.Drawing.Size(721, 21);
            this.cbConnection.TabIndex = 0;
            this.cbConnection.SelectedIndexChanged += new System.EventHandler(this.cbConnection_SelectedIndexChanged);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(77, 8);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(80, 20);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "Scripting";
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
            this.hsClose.ImageToggleOnSelect = false;
            this.hsClose.Location = new System.Drawing.Point(0, 0);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Size = new System.Drawing.Size(45, 38);
            this.hsClose.TabIndex = 1;
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
            this.pnlLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLower.Controls.Add(this.fcbNotify);
            this.pnlLower.Controls.Add(this.pnlGauge);
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 582);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(1924, 213);
            this.pnlLower.TabIndex = 1;
            // 
            // fcbNotify
            // 
            this.fcbNotify.AutoCompleteBracketsList = new char[] {
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
            this.fcbNotify.AutoScrollMinSize = new System.Drawing.Size(25, 12);
            this.fcbNotify.BackBrush = null;
            this.fcbNotify.CharHeight = 12;
            this.fcbNotify.CharWidth = 7;
            this.fcbNotify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbNotify.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbNotify.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fcbNotify.IsReplaceMode = false;
            this.fcbNotify.Location = new System.Drawing.Point(0, 0);
            this.fcbNotify.Name = "fcbNotify";
            this.fcbNotify.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbNotify.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbNotify.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbNotify.ServiceColors")));
            this.fcbNotify.Size = new System.Drawing.Size(1920, 191);
            this.fcbNotify.TabIndex = 2;
            this.fcbNotify.Zoom = 100;
            // 
            // pnlGauge
            // 
            this.pnlGauge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGauge.Controls.Add(this.pbProgress);
            this.pnlGauge.Controls.Add(this.lblGauge);
            this.pnlGauge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGauge.Location = new System.Drawing.Point(0, 191);
            this.pnlGauge.Name = "pnlGauge";
            this.pnlGauge.Size = new System.Drawing.Size(1920, 18);
            this.pnlGauge.TabIndex = 3;
            // 
            // pbProgress
            // 
            this.pbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProgress.Location = new System.Drawing.Point(281, 0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(1637, 16);
            this.pbProgress.TabIndex = 0;
            // 
            // lblGauge
            // 
            this.lblGauge.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGauge.Location = new System.Drawing.Point(0, 0);
            this.lblGauge.Name = "lblGauge";
            this.lblGauge.Size = new System.Drawing.Size(281, 16);
            this.lblGauge.TabIndex = 1;
            this.lblGauge.Text = "progress 1 (100)";
            // 
            // pnlCenter
            // 
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCenter.Controls.Add(this.splitScript);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1924, 540);
            this.pnlCenter.TabIndex = 2;
            // 
            // splitScript
            // 
            this.splitScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitScript.Location = new System.Drawing.Point(0, 0);
            this.splitScript.Name = "splitScript";
            // 
            // splitScript.Panel1
            // 
            this.splitScript.Panel1.Controls.Add(this.tabScripting);
            // 
            // splitScript.Panel2
            // 
            this.splitScript.Panel2.Controls.Add(this.gbCommandsDone);
            this.splitScript.Panel2.Controls.Add(this.pnlLeftCommands);
            this.splitScript.Size = new System.Drawing.Size(1920, 536);
            this.splitScript.SplitterDistance = 1007;
            this.splitScript.TabIndex = 2;
            // 
            // tabScripting
            // 
            this.tabScripting.Controls.Add(this.tabSQL);
            this.tabScripting.Controls.Add(this.tabPageFiles);
            this.tabScripting.Controls.Add(this.tabPagePreparedCommands);
            this.tabScripting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabScripting.Location = new System.Drawing.Point(0, 0);
            this.tabScripting.Name = "tabScripting";
            this.tabScripting.SelectedIndex = 0;
            this.tabScripting.Size = new System.Drawing.Size(1007, 536);
            this.tabScripting.TabIndex = 18;
            this.tabScripting.SelectedIndexChanged += new System.EventHandler(this.tabScripting_SelectedIndexChanged);
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.pnlFieldsCenter);
            this.tabSQL.Location = new System.Drawing.Point(4, 22);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(999, 510);
            this.tabSQL.TabIndex = 0;
            this.tabSQL.Text = "Script";
            this.tabSQL.UseVisualStyleBackColor = true;
            this.tabSQL.Click += new System.EventHandler(this.tabSQL_Click);
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.gbSQL);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(993, 504);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.gbSQLText);
            this.gbSQL.Controls.Add(this.pnlUpperSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(0, 0);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(993, 504);
            this.gbSQL.TabIndex = 2;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "SQL Commands";
            // 
            // gbSQLText
            // 
            this.gbSQLText.Controls.Add(this.fcbSQL);
            this.gbSQLText.Controls.Add(this.gbScriptRightPanel);
            this.gbSQLText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQLText.Location = new System.Drawing.Point(3, 50);
            this.gbSQLText.Name = "gbSQLText";
            this.gbSQLText.Size = new System.Drawing.Size(987, 451);
            this.gbSQLText.TabIndex = 2;
            this.gbSQLText.TabStop = false;
            this.gbSQLText.Text = "SQL";
            // 
            // fcbSQL
            // 
            this.fcbSQL.AutoCompleteBracketsList = new char[] {
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
            this.fcbSQL.AutoIndentCharsPatterns = "";
            this.fcbSQL.AutoScrollMinSize = new System.Drawing.Size(0, 12);
            this.fcbSQL.BackBrush = null;
            this.fcbSQL.BackColor = System.Drawing.SystemColors.Window;
            this.fcbSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fcbSQL.CharHeight = 12;
            this.fcbSQL.CharWidth = 6;
            this.fcbSQL.CommentPrefix = "--";
            this.fcbSQL.ContextMenuStrip = this.cmsSQLText;
            this.fcbSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbSQL.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.fcbSQL.IsReplaceMode = false;
            this.fcbSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbSQL.LeftBracket = '(';
            this.fcbSQL.Location = new System.Drawing.Point(3, 16);
            this.fcbSQL.Name = "fcbSQL";
            this.fcbSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbSQL.RightBracket = ')';
            this.fcbSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbSQL.ServiceColors")));
            this.fcbSQL.Size = new System.Drawing.Size(874, 432);
            this.fcbSQL.TabIndex = 2;
            this.fcbSQL.Text = "INSERT into";
            this.fcbSQL.WordWrap = true;
            this.fcbSQL.Zoom = 100;
            this.fcbSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fcbSQL_KeyDown_1);
            // 
            // cmsSQLText
            // 
            this.cmsSQLText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDDLCopyToClipboard,
            this.tsmiDDLPaste});
            this.cmsSQLText.Name = "cmsText";
            this.cmsSQLText.Size = new System.Drawing.Size(172, 48);
            this.cmsSQLText.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSQLText_ItemClicked);
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
            // gbScriptRightPanel
            // 
            this.gbScriptRightPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.gbScriptRightPanel.Controls.Add(this.hsExecuteSQL);
            this.gbScriptRightPanel.Controls.Add(this.hsRunSQLDirect);
            this.gbScriptRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbScriptRightPanel.Location = new System.Drawing.Point(877, 16);
            this.gbScriptRightPanel.Name = "gbScriptRightPanel";
            this.gbScriptRightPanel.Size = new System.Drawing.Size(107, 432);
            this.gbScriptRightPanel.TabIndex = 12;
            this.gbScriptRightPanel.TabStop = false;
            this.gbScriptRightPanel.Text = "Run";
            // 
            // hsExecuteSQL
            // 
            this.hsExecuteSQL.BackColor = System.Drawing.Color.Transparent;
            this.hsExecuteSQL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExecuteSQL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExecuteSQL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExecuteSQL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExecuteSQL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExecuteSQL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExecuteSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsExecuteSQL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExecuteSQL.FlatAppearance.BorderSize = 0;
            this.hsExecuteSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExecuteSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExecuteSQL.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsExecuteSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExecuteSQL.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsExecuteSQL.ImageToggleOnSelect = false;
            this.hsExecuteSQL.Location = new System.Drawing.Point(3, 68);
            this.hsExecuteSQL.Marked = false;
            this.hsExecuteSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsExecuteSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExecuteSQL.MarkedText = "";
            this.hsExecuteSQL.MarkMode = false;
            this.hsExecuteSQL.Name = "hsExecuteSQL";
            this.hsExecuteSQL.NonMarkedText = "Prepare SQL";
            this.hsExecuteSQL.Size = new System.Drawing.Size(101, 54);
            this.hsExecuteSQL.TabIndex = 6;
            this.hsExecuteSQL.Text = "Prepare SQL";
            this.hsExecuteSQL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExecuteSQL.ToolTipActive = false;
            this.hsExecuteSQL.ToolTipAutomaticDelay = 500;
            this.hsExecuteSQL.ToolTipAutoPopDelay = 5000;
            this.hsExecuteSQL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExecuteSQL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExecuteSQL.ToolTipFor4ContextMenu = true;
            this.hsExecuteSQL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExecuteSQL.ToolTipInitialDelay = 500;
            this.hsExecuteSQL.ToolTipIsBallon = false;
            this.hsExecuteSQL.ToolTipOwnerDraw = false;
            this.hsExecuteSQL.ToolTipReshowDelay = 100;
            this.hsExecuteSQL.ToolTipShowAlways = false;
            this.hsExecuteSQL.ToolTipText = "";
            this.hsExecuteSQL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExecuteSQL.ToolTipTitle = "";
            this.hsExecuteSQL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExecuteSQL.UseVisualStyleBackColor = false;
            this.hsExecuteSQL.Click += new System.EventHandler(this.hsExecuteSQL_Click);
            // 
            // hsRunSQLDirect
            // 
            this.hsRunSQLDirect.BackColor = System.Drawing.Color.Transparent;
            this.hsRunSQLDirect.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunSQLDirect.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunSQLDirect.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunSQLDirect.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunSQLDirect.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunSQLDirect.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunSQLDirect.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsRunSQLDirect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunSQLDirect.FlatAppearance.BorderSize = 0;
            this.hsRunSQLDirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunSQLDirect.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunSQLDirect.Image = global::FBXpert.Properties.Resources.applications_execute_script_22x1;
            this.hsRunSQLDirect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunSQLDirect.ImageHover = global::FBXpert.Properties.Resources.applications_execute_script_blue_22x;
            this.hsRunSQLDirect.ImageToggleOnSelect = false;
            this.hsRunSQLDirect.Location = new System.Drawing.Point(3, 16);
            this.hsRunSQLDirect.Marked = false;
            this.hsRunSQLDirect.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunSQLDirect.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunSQLDirect.MarkedText = "";
            this.hsRunSQLDirect.MarkMode = false;
            this.hsRunSQLDirect.Name = "hsRunSQLDirect";
            this.hsRunSQLDirect.NonMarkedText = "Run direct";
            this.hsRunSQLDirect.Size = new System.Drawing.Size(101, 52);
            this.hsRunSQLDirect.TabIndex = 5;
            this.hsRunSQLDirect.Text = "Run direct";
            this.hsRunSQLDirect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunSQLDirect.ToolTipActive = false;
            this.hsRunSQLDirect.ToolTipAutomaticDelay = 500;
            this.hsRunSQLDirect.ToolTipAutoPopDelay = 5000;
            this.hsRunSQLDirect.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunSQLDirect.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunSQLDirect.ToolTipFor4ContextMenu = true;
            this.hsRunSQLDirect.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunSQLDirect.ToolTipInitialDelay = 500;
            this.hsRunSQLDirect.ToolTipIsBallon = false;
            this.hsRunSQLDirect.ToolTipOwnerDraw = false;
            this.hsRunSQLDirect.ToolTipReshowDelay = 100;
            this.hsRunSQLDirect.ToolTipShowAlways = false;
            this.hsRunSQLDirect.ToolTipText = "";
            this.hsRunSQLDirect.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunSQLDirect.ToolTipTitle = "";
            this.hsRunSQLDirect.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunSQLDirect.UseVisualStyleBackColor = false;
            this.hsRunSQLDirect.Click += new System.EventHandler(this.hsRunSQLDirect_Click);
            // 
            // pnlUpperSQL
            // 
            this.pnlUpperSQL.Controls.Add(this.hsClearSQL);
            this.pnlUpperSQL.Controls.Add(this.hsSave);
            this.pnlUpperSQL.Controls.Add(this.hsLoadScript);
            this.pnlUpperSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperSQL.Location = new System.Drawing.Point(3, 16);
            this.pnlUpperSQL.Name = "pnlUpperSQL";
            this.pnlUpperSQL.Size = new System.Drawing.Size(987, 34);
            this.pnlUpperSQL.TabIndex = 1;
            // 
            // hsClearSQL
            // 
            this.hsClearSQL.BackColor = System.Drawing.Color.Transparent;
            this.hsClearSQL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearSQL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearSQL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearSQL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearSQL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearSQL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearSQL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearSQL.FlatAppearance.BorderSize = 0;
            this.hsClearSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearSQL.Image = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hsClearSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsClearSQL.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearSQL.ImageToggleOnSelect = true;
            this.hsClearSQL.Location = new System.Drawing.Point(207, 0);
            this.hsClearSQL.Marked = false;
            this.hsClearSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearSQL.MarkedText = "";
            this.hsClearSQL.MarkMode = false;
            this.hsClearSQL.Name = "hsClearSQL";
            this.hsClearSQL.NonMarkedText = "Clear";
            this.hsClearSQL.Size = new System.Drawing.Size(65, 34);
            this.hsClearSQL.TabIndex = 35;
            this.hsClearSQL.Text = "Clear";
            this.hsClearSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsClearSQL.ToolTipActive = false;
            this.hsClearSQL.ToolTipAutomaticDelay = 500;
            this.hsClearSQL.ToolTipAutoPopDelay = 5000;
            this.hsClearSQL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearSQL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearSQL.ToolTipFor4ContextMenu = true;
            this.hsClearSQL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearSQL.ToolTipInitialDelay = 500;
            this.hsClearSQL.ToolTipIsBallon = false;
            this.hsClearSQL.ToolTipOwnerDraw = false;
            this.hsClearSQL.ToolTipReshowDelay = 100;
            this.hsClearSQL.ToolTipShowAlways = false;
            this.hsClearSQL.ToolTipText = "";
            this.hsClearSQL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearSQL.ToolTipTitle = "";
            this.hsClearSQL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearSQL.UseVisualStyleBackColor = false;
            this.hsClearSQL.Click += new System.EventHandler(this.hsClearSQL_Click);
            // 
            // hsSave
            // 
            this.hsSave.BackColor = System.Drawing.Color.Transparent;
            this.hsSave.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSave.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSave.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSave.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSave.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSave.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSave.FlatAppearance.BorderSize = 0;
            this.hsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSave.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSave.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsSave.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSave.ImageToggleOnSelect = false;
            this.hsSave.Location = new System.Drawing.Point(112, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "Save to file";
            this.hsSave.Size = new System.Drawing.Size(95, 34);
            this.hsSave.TabIndex = 1;
            this.hsSave.Text = "Save to file";
            this.hsSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSave.ToolTipActive = false;
            this.hsSave.ToolTipAutomaticDelay = 500;
            this.hsSave.ToolTipAutoPopDelay = 5000;
            this.hsSave.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSave.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSave.ToolTipFor4ContextMenu = true;
            this.hsSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSave.ToolTipInitialDelay = 500;
            this.hsSave.ToolTipIsBallon = false;
            this.hsSave.ToolTipOwnerDraw = false;
            this.hsSave.ToolTipReshowDelay = 100;
            this.hsSave.ToolTipShowAlways = false;
            this.hsSave.ToolTipText = "";
            this.hsSave.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSave.ToolTipTitle = "";
            this.hsSave.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSave.UseVisualStyleBackColor = false;
            this.hsSave.Click += new System.EventHandler(this.hsSave_Click);
            // 
            // hsLoadScript
            // 
            this.hsLoadScript.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadScript.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadScript.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadScript.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadScript.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadScript.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadScript.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadScript.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadScript.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadScript.FlatAppearance.BorderSize = 0;
            this.hsLoadScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadScript.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadScript.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoadScript.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadScript.ImageToggleOnSelect = false;
            this.hsLoadScript.Location = new System.Drawing.Point(0, 0);
            this.hsLoadScript.Marked = false;
            this.hsLoadScript.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadScript.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadScript.MarkedText = "";
            this.hsLoadScript.MarkMode = false;
            this.hsLoadScript.Name = "hsLoadScript";
            this.hsLoadScript.NonMarkedText = "Load from File";
            this.hsLoadScript.Size = new System.Drawing.Size(112, 34);
            this.hsLoadScript.TabIndex = 4;
            this.hsLoadScript.Text = "Load from File";
            this.hsLoadScript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsLoadScript.ToolTipActive = false;
            this.hsLoadScript.ToolTipAutomaticDelay = 500;
            this.hsLoadScript.ToolTipAutoPopDelay = 5000;
            this.hsLoadScript.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadScript.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadScript.ToolTipFor4ContextMenu = true;
            this.hsLoadScript.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadScript.ToolTipInitialDelay = 500;
            this.hsLoadScript.ToolTipIsBallon = false;
            this.hsLoadScript.ToolTipOwnerDraw = false;
            this.hsLoadScript.ToolTipReshowDelay = 100;
            this.hsLoadScript.ToolTipShowAlways = false;
            this.hsLoadScript.ToolTipText = "";
            this.hsLoadScript.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadScript.ToolTipTitle = "";
            this.hsLoadScript.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadScript.UseVisualStyleBackColor = false;
            this.hsLoadScript.Click += new System.EventHandler(this.hsLoadScript_Click);
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.pnlOptionsCenter);
            this.tabPageFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(999, 510);
            this.tabPageFiles.TabIndex = 1;
            this.tabPageFiles.Text = "Files";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // pnlOptionsCenter
            // 
            this.pnlOptionsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOptionsCenter.Controls.Add(this.gbSQLFiles);
            this.pnlOptionsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionsCenter.Location = new System.Drawing.Point(3, 3);
            this.pnlOptionsCenter.Name = "pnlOptionsCenter";
            this.pnlOptionsCenter.Size = new System.Drawing.Size(993, 504);
            this.pnlOptionsCenter.TabIndex = 22;
            // 
            // gbSQLFiles
            // 
            this.gbSQLFiles.Controls.Add(this.lvFiles);
            this.gbSQLFiles.Controls.Add(this.gbSQLFilesRight);
            this.gbSQLFiles.Controls.Add(this.gbAddFile);
            this.gbSQLFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQLFiles.Location = new System.Drawing.Point(0, 0);
            this.gbSQLFiles.Name = "gbSQLFiles";
            this.gbSQLFiles.Size = new System.Drawing.Size(993, 504);
            this.gbSQLFiles.TabIndex = 11;
            this.gbSQLFiles.TabStop = false;
            this.gbSQLFiles.Text = "SQL Files";
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colSize});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.Location = new System.Drawing.Point(3, 16);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(880, 399);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.lvFiles_SelectedIndexChanged);
            // 
            // colFile
            // 
            this.colFile.Text = "SQL file";
            this.colFile.Width = 800;
            // 
            // colSize
            // 
            this.colSize.Text = "Size (kB)";
            this.colSize.Width = 100;
            // 
            // gbSQLFilesRight
            // 
            this.gbSQLFilesRight.BackColor = System.Drawing.Color.Gainsboro;
            this.gbSQLFilesRight.Controls.Add(this.hsPrepareSQLFromFiles);
            this.gbSQLFilesRight.Controls.Add(this.hsRunFilesDirect);
            this.gbSQLFilesRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbSQLFilesRight.Location = new System.Drawing.Point(883, 16);
            this.gbSQLFilesRight.Name = "gbSQLFilesRight";
            this.gbSQLFilesRight.Size = new System.Drawing.Size(107, 399);
            this.gbSQLFilesRight.TabIndex = 14;
            this.gbSQLFilesRight.TabStop = false;
            // 
            // hsPrepareSQLFromFiles
            // 
            this.hsPrepareSQLFromFiles.BackColor = System.Drawing.Color.Transparent;
            this.hsPrepareSQLFromFiles.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPrepareSQLFromFiles.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPrepareSQLFromFiles.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPrepareSQLFromFiles.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPrepareSQLFromFiles.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPrepareSQLFromFiles.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPrepareSQLFromFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsPrepareSQLFromFiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsPrepareSQLFromFiles.FlatAppearance.BorderSize = 0;
            this.hsPrepareSQLFromFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPrepareSQLFromFiles.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPrepareSQLFromFiles.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsPrepareSQLFromFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPrepareSQLFromFiles.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsPrepareSQLFromFiles.ImageToggleOnSelect = false;
            this.hsPrepareSQLFromFiles.Location = new System.Drawing.Point(3, 67);
            this.hsPrepareSQLFromFiles.Marked = false;
            this.hsPrepareSQLFromFiles.MarkedColor = System.Drawing.Color.Teal;
            this.hsPrepareSQLFromFiles.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPrepareSQLFromFiles.MarkedText = "";
            this.hsPrepareSQLFromFiles.MarkMode = false;
            this.hsPrepareSQLFromFiles.Name = "hsPrepareSQLFromFiles";
            this.hsPrepareSQLFromFiles.NonMarkedText = "Prepare SQL";
            this.hsPrepareSQLFromFiles.Size = new System.Drawing.Size(101, 48);
            this.hsPrepareSQLFromFiles.TabIndex = 6;
            this.hsPrepareSQLFromFiles.Text = "Prepare SQL";
            this.hsPrepareSQLFromFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPrepareSQLFromFiles.ToolTipActive = false;
            this.hsPrepareSQLFromFiles.ToolTipAutomaticDelay = 500;
            this.hsPrepareSQLFromFiles.ToolTipAutoPopDelay = 5000;
            this.hsPrepareSQLFromFiles.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPrepareSQLFromFiles.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPrepareSQLFromFiles.ToolTipFor4ContextMenu = true;
            this.hsPrepareSQLFromFiles.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPrepareSQLFromFiles.ToolTipInitialDelay = 500;
            this.hsPrepareSQLFromFiles.ToolTipIsBallon = false;
            this.hsPrepareSQLFromFiles.ToolTipOwnerDraw = false;
            this.hsPrepareSQLFromFiles.ToolTipReshowDelay = 100;
            this.hsPrepareSQLFromFiles.ToolTipShowAlways = false;
            this.hsPrepareSQLFromFiles.ToolTipText = "";
            this.hsPrepareSQLFromFiles.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPrepareSQLFromFiles.ToolTipTitle = "";
            this.hsPrepareSQLFromFiles.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPrepareSQLFromFiles.UseVisualStyleBackColor = false;
            // 
            // hsRunFilesDirect
            // 
            this.hsRunFilesDirect.BackColor = System.Drawing.Color.Transparent;
            this.hsRunFilesDirect.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunFilesDirect.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunFilesDirect.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunFilesDirect.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunFilesDirect.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunFilesDirect.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunFilesDirect.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsRunFilesDirect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunFilesDirect.FlatAppearance.BorderSize = 0;
            this.hsRunFilesDirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunFilesDirect.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunFilesDirect.Image = global::FBXpert.Properties.Resources.applications_execute_script_22x1;
            this.hsRunFilesDirect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunFilesDirect.ImageHover = global::FBXpert.Properties.Resources.applications_execute_script_blue_22x;
            this.hsRunFilesDirect.ImageToggleOnSelect = false;
            this.hsRunFilesDirect.Location = new System.Drawing.Point(3, 16);
            this.hsRunFilesDirect.Marked = false;
            this.hsRunFilesDirect.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunFilesDirect.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunFilesDirect.MarkedText = "";
            this.hsRunFilesDirect.MarkMode = false;
            this.hsRunFilesDirect.Name = "hsRunFilesDirect";
            this.hsRunFilesDirect.NonMarkedText = "Run file(s)";
            this.hsRunFilesDirect.Size = new System.Drawing.Size(101, 51);
            this.hsRunFilesDirect.TabIndex = 5;
            this.hsRunFilesDirect.Text = "Run file(s) direct";
            this.hsRunFilesDirect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunFilesDirect.ToolTipActive = false;
            this.hsRunFilesDirect.ToolTipAutomaticDelay = 500;
            this.hsRunFilesDirect.ToolTipAutoPopDelay = 5000;
            this.hsRunFilesDirect.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunFilesDirect.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunFilesDirect.ToolTipFor4ContextMenu = true;
            this.hsRunFilesDirect.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunFilesDirect.ToolTipInitialDelay = 500;
            this.hsRunFilesDirect.ToolTipIsBallon = false;
            this.hsRunFilesDirect.ToolTipOwnerDraw = false;
            this.hsRunFilesDirect.ToolTipReshowDelay = 100;
            this.hsRunFilesDirect.ToolTipShowAlways = false;
            this.hsRunFilesDirect.ToolTipText = "";
            this.hsRunFilesDirect.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunFilesDirect.ToolTipTitle = "";
            this.hsRunFilesDirect.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunFilesDirect.UseVisualStyleBackColor = false;
            this.hsRunFilesDirect.Click += new System.EventHandler(this.hotSpot4_Click);
            // 
            // gbAddFile
            // 
            this.gbAddFile.Controls.Add(this.pnlSQLFileLower);
            this.gbAddFile.Controls.Add(this.hsAddBackupFile);
            this.gbAddFile.Controls.Add(this.hsRemoveBackupFile);
            this.gbAddFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbAddFile.Location = new System.Drawing.Point(3, 415);
            this.gbAddFile.Name = "gbAddFile";
            this.gbAddFile.Size = new System.Drawing.Size(987, 86);
            this.gbAddFile.TabIndex = 13;
            this.gbAddFile.TabStop = false;
            // 
            // pnlSQLFileLower
            // 
            this.pnlSQLFileLower.Controls.Add(this.gbSQLLocation);
            this.pnlSQLFileLower.Controls.Add(this.gbOptionsFilesize);
            this.pnlSQLFileLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSQLFileLower.Location = new System.Drawing.Point(3, 40);
            this.pnlSQLFileLower.Name = "pnlSQLFileLower";
            this.pnlSQLFileLower.Size = new System.Drawing.Size(981, 43);
            this.pnlSQLFileLower.TabIndex = 14;
            // 
            // gbSQLLocation
            // 
            this.gbSQLLocation.Controls.Add(this.txtSQLLocation);
            this.gbSQLLocation.Controls.Add(this.hsLoad);
            this.gbSQLLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQLLocation.Location = new System.Drawing.Point(0, 0);
            this.gbSQLLocation.Name = "gbSQLLocation";
            this.gbSQLLocation.Size = new System.Drawing.Size(877, 43);
            this.gbSQLLocation.TabIndex = 2;
            this.gbSQLLocation.TabStop = false;
            this.gbSQLLocation.Text = "SQLFile";
            // 
            // txtSQLLocation
            // 
            this.txtSQLLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLLocation.Location = new System.Drawing.Point(3, 16);
            this.txtSQLLocation.Name = "txtSQLLocation";
            this.txtSQLLocation.Size = new System.Drawing.Size(842, 20);
            this.txtSQLLocation.TabIndex = 0;
            this.txtSQLLocation.TextChanged += new System.EventHandler(this.txtSQLLocation_TextChanged);
            // 
            // hsLoad
            // 
            this.hsLoad.BackColor = System.Drawing.Color.Transparent;
            this.hsLoad.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoad.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoad.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoad.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoad.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoad.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoad.FlatAppearance.BorderSize = 0;
            this.hsLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoad.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoad.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoad.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoad.ImageToggleOnSelect = false;
            this.hsLoad.Location = new System.Drawing.Point(845, 16);
            this.hsLoad.Marked = false;
            this.hsLoad.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoad.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoad.MarkedText = "";
            this.hsLoad.MarkMode = false;
            this.hsLoad.Name = "hsLoad";
            this.hsLoad.NonMarkedText = "";
            this.hsLoad.Size = new System.Drawing.Size(29, 24);
            this.hsLoad.TabIndex = 3;
            this.hsLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoad.ToolTipActive = false;
            this.hsLoad.ToolTipAutomaticDelay = 500;
            this.hsLoad.ToolTipAutoPopDelay = 5000;
            this.hsLoad.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoad.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoad.ToolTipFor4ContextMenu = true;
            this.hsLoad.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoad.ToolTipInitialDelay = 500;
            this.hsLoad.ToolTipIsBallon = false;
            this.hsLoad.ToolTipOwnerDraw = false;
            this.hsLoad.ToolTipReshowDelay = 100;
            this.hsLoad.ToolTipShowAlways = false;
            this.hsLoad.ToolTipText = "";
            this.hsLoad.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoad.ToolTipTitle = "";
            this.hsLoad.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoad.UseVisualStyleBackColor = false;
            this.hsLoad.Click += new System.EventHandler(this.hsLoad_Click);
            // 
            // gbOptionsFilesize
            // 
            this.gbOptionsFilesize.Controls.Add(this.txtFileSize);
            this.gbOptionsFilesize.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbOptionsFilesize.Location = new System.Drawing.Point(877, 0);
            this.gbOptionsFilesize.Name = "gbOptionsFilesize";
            this.gbOptionsFilesize.Size = new System.Drawing.Size(104, 43);
            this.gbOptionsFilesize.TabIndex = 13;
            this.gbOptionsFilesize.TabStop = false;
            this.gbOptionsFilesize.Text = "Filesize (kb)";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileSize.Location = new System.Drawing.Point(3, 16);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(98, 20);
            this.txtFileSize.TabIndex = 1;
            this.txtFileSize.Text = "4096";
            // 
            // hsAddBackupFile
            // 
            this.hsAddBackupFile.BackColor = System.Drawing.Color.Transparent;
            this.hsAddBackupFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddBackupFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddBackupFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddBackupFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddBackupFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddBackupFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddBackupFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddBackupFile.FlatAppearance.BorderSize = 0;
            this.hsAddBackupFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddBackupFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddBackupFile.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddBackupFile.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddBackupFile.ImageToggleOnSelect = true;
            this.hsAddBackupFile.Location = new System.Drawing.Point(6, 6);
            this.hsAddBackupFile.Marked = false;
            this.hsAddBackupFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddBackupFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddBackupFile.MarkedText = "";
            this.hsAddBackupFile.MarkMode = false;
            this.hsAddBackupFile.Name = "hsAddBackupFile";
            this.hsAddBackupFile.NonMarkedText = "";
            this.hsAddBackupFile.Size = new System.Drawing.Size(45, 32);
            this.hsAddBackupFile.TabIndex = 11;
            this.hsAddBackupFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddBackupFile.ToolTipActive = false;
            this.hsAddBackupFile.ToolTipAutomaticDelay = 500;
            this.hsAddBackupFile.ToolTipAutoPopDelay = 5000;
            this.hsAddBackupFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddBackupFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddBackupFile.ToolTipFor4ContextMenu = true;
            this.hsAddBackupFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddBackupFile.ToolTipInitialDelay = 500;
            this.hsAddBackupFile.ToolTipIsBallon = false;
            this.hsAddBackupFile.ToolTipOwnerDraw = false;
            this.hsAddBackupFile.ToolTipReshowDelay = 100;
            this.hsAddBackupFile.ToolTipShowAlways = false;
            this.hsAddBackupFile.ToolTipText = "";
            this.hsAddBackupFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddBackupFile.ToolTipTitle = "";
            this.hsAddBackupFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddBackupFile.UseVisualStyleBackColor = false;
            this.hsAddBackupFile.Click += new System.EventHandler(this.hsAddBackupFile_Click);
            // 
            // hsRemoveBackupFile
            // 
            this.hsRemoveBackupFile.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveBackupFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveBackupFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveBackupFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveBackupFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveBackupFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveBackupFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveBackupFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveBackupFile.FlatAppearance.BorderSize = 0;
            this.hsRemoveBackupFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveBackupFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveBackupFile.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsRemoveBackupFile.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsRemoveBackupFile.ImageToggleOnSelect = true;
            this.hsRemoveBackupFile.Location = new System.Drawing.Point(62, 6);
            this.hsRemoveBackupFile.Marked = false;
            this.hsRemoveBackupFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveBackupFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveBackupFile.MarkedText = "";
            this.hsRemoveBackupFile.MarkMode = false;
            this.hsRemoveBackupFile.Name = "hsRemoveBackupFile";
            this.hsRemoveBackupFile.NonMarkedText = "";
            this.hsRemoveBackupFile.Size = new System.Drawing.Size(45, 32);
            this.hsRemoveBackupFile.TabIndex = 12;
            this.hsRemoveBackupFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveBackupFile.ToolTipActive = false;
            this.hsRemoveBackupFile.ToolTipAutomaticDelay = 500;
            this.hsRemoveBackupFile.ToolTipAutoPopDelay = 5000;
            this.hsRemoveBackupFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveBackupFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveBackupFile.ToolTipFor4ContextMenu = true;
            this.hsRemoveBackupFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveBackupFile.ToolTipInitialDelay = 500;
            this.hsRemoveBackupFile.ToolTipIsBallon = false;
            this.hsRemoveBackupFile.ToolTipOwnerDraw = false;
            this.hsRemoveBackupFile.ToolTipReshowDelay = 100;
            this.hsRemoveBackupFile.ToolTipShowAlways = false;
            this.hsRemoveBackupFile.ToolTipText = "";
            this.hsRemoveBackupFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveBackupFile.ToolTipTitle = "";
            this.hsRemoveBackupFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveBackupFile.UseVisualStyleBackColor = false;
            this.hsRemoveBackupFile.Click += new System.EventHandler(this.hsRemoveBackupFile_Click);
            // 
            // tabPagePreparedCommands
            // 
            this.tabPagePreparedCommands.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPagePreparedCommands.Controls.Add(this.lvCommands);
            this.tabPagePreparedCommands.Controls.Add(this.gbPreparedCommands);
            this.tabPagePreparedCommands.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreparedCommands.Name = "tabPagePreparedCommands";
            this.tabPagePreparedCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreparedCommands.Size = new System.Drawing.Size(999, 510);
            this.tabPagePreparedCommands.TabIndex = 2;
            this.tabPagePreparedCommands.Text = "Prepared commands";
            // 
            // lvCommands
            // 
            this.lvCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNR,
            this.colCMD,
            this.colCMDTYPE,
            this.colUsedTime});
            this.lvCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCommands.FullRowSelect = true;
            this.lvCommands.Location = new System.Drawing.Point(3, 3);
            this.lvCommands.Name = "lvCommands";
            this.lvCommands.Size = new System.Drawing.Size(875, 504);
            this.lvCommands.TabIndex = 4;
            this.lvCommands.UseCompatibleStateImageBehavior = false;
            this.lvCommands.View = System.Windows.Forms.View.Details;
            this.lvCommands.SelectedIndexChanged += new System.EventHandler(this.lvCommands_SelectedIndexChanged);
            // 
            // colNR
            // 
            this.colNR.Text = "NR";
            this.colNR.Width = 125;
            // 
            // colCMD
            // 
            this.colCMD.Text = "Command";
            this.colCMD.Width = 573;
            // 
            // colCMDTYPE
            // 
            this.colCMDTYPE.Text = "Commandtype";
            this.colCMDTYPE.Width = 93;
            // 
            // colUsedTime
            // 
            this.colUsedTime.Text = "Time";
            this.colUsedTime.Width = 70;
            // 
            // gbPreparedCommands
            // 
            this.gbPreparedCommands.Controls.Add(this.hotSpot1);
            this.gbPreparedCommands.Controls.Add(this.hotSpot2);
            this.gbPreparedCommands.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPreparedCommands.Location = new System.Drawing.Point(878, 3);
            this.gbPreparedCommands.Name = "gbPreparedCommands";
            this.gbPreparedCommands.Size = new System.Drawing.Size(118, 504);
            this.gbPreparedCommands.TabIndex = 12;
            this.gbPreparedCommands.TabStop = false;
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
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hotSpot1.ImageToggleOnSelect = false;
            this.hotSpot1.Location = new System.Drawing.Point(3, 62);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Prepare SQL";
            this.hotSpot1.Size = new System.Drawing.Size(112, 50);
            this.hotSpot1.TabIndex = 6;
            this.hotSpot1.Text = "Prepare SQL";
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
            // hotSpot2
            // 
            this.hotSpot2.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot2.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot2.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot2.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot2.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.applications_execute_script_22x1;
            this.hotSpot2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.applications_execute_script_blue_22x;
            this.hotSpot2.ImageToggleOnSelect = false;
            this.hotSpot2.Location = new System.Drawing.Point(3, 16);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "Run file(s)";
            this.hotSpot2.Size = new System.Drawing.Size(112, 46);
            this.hotSpot2.TabIndex = 5;
            this.hotSpot2.Text = "Run file(s)";
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
            // gbCommandsDone
            // 
            this.gbCommandsDone.Controls.Add(this.fcbCommands);
            this.gbCommandsDone.Controls.Add(this.pnlCommandsUpper);
            this.gbCommandsDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCommandsDone.Location = new System.Drawing.Point(158, 0);
            this.gbCommandsDone.Name = "gbCommandsDone";
            this.gbCommandsDone.Size = new System.Drawing.Size(751, 536);
            this.gbCommandsDone.TabIndex = 2;
            this.gbCommandsDone.TabStop = false;
            this.gbCommandsDone.Text = "Commands ";
            // 
            // fcbCommands
            // 
            this.fcbCommands.AutoCompleteBracketsList = new char[] {
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
            this.fcbCommands.AutoIndentCharsPatterns = "";
            this.fcbCommands.AutoScrollMinSize = new System.Drawing.Size(0, 12);
            this.fcbCommands.BackBrush = null;
            this.fcbCommands.BackColor = System.Drawing.SystemColors.Info;
            this.fcbCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fcbCommands.CharHeight = 12;
            this.fcbCommands.CharWidth = 6;
            this.fcbCommands.CommentPrefix = "--";
            this.fcbCommands.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbCommands.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbCommands.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.fcbCommands.IsReplaceMode = false;
            this.fcbCommands.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbCommands.LeftBracket = '(';
            this.fcbCommands.Location = new System.Drawing.Point(3, 50);
            this.fcbCommands.Name = "fcbCommands";
            this.fcbCommands.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbCommands.ReadOnly = true;
            this.fcbCommands.RightBracket = ')';
            this.fcbCommands.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbCommands.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbCommands.ServiceColors")));
            this.fcbCommands.Size = new System.Drawing.Size(745, 483);
            this.fcbCommands.TabIndex = 1;
            this.fcbCommands.Text = "INSERT into";
            this.fcbCommands.WordWrap = true;
            this.fcbCommands.Zoom = 100;
            this.fcbCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fcbCommands_KeyDown);
            // 
            // pnlCommandsUpper
            // 
            this.pnlCommandsUpper.Controls.Add(this.hsRunAllCommands);
            this.pnlCommandsUpper.Controls.Add(this.hsRunActualCommand);
            this.pnlCommandsUpper.Controls.Add(this.label1);
            this.pnlCommandsUpper.Controls.Add(this.hsClearCmds);
            this.pnlCommandsUpper.Controls.Add(this.txtClear);
            this.pnlCommandsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommandsUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlCommandsUpper.Name = "pnlCommandsUpper";
            this.pnlCommandsUpper.Size = new System.Drawing.Size(745, 34);
            this.pnlCommandsUpper.TabIndex = 2;
            // 
            // hsRunAllCommands
            // 
            this.hsRunAllCommands.BackColor = System.Drawing.Color.Transparent;
            this.hsRunAllCommands.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunAllCommands.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunAllCommands.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunAllCommands.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunAllCommands.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunAllCommands.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunAllCommands.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRunAllCommands.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunAllCommands.FlatAppearance.BorderSize = 0;
            this.hsRunAllCommands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunAllCommands.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunAllCommands.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsRunAllCommands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRunAllCommands.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsRunAllCommands.ImageToggleOnSelect = true;
            this.hsRunAllCommands.Location = new System.Drawing.Point(386, 0);
            this.hsRunAllCommands.Marked = false;
            this.hsRunAllCommands.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunAllCommands.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunAllCommands.MarkedText = "";
            this.hsRunAllCommands.MarkMode = false;
            this.hsRunAllCommands.Name = "hsRunAllCommands";
            this.hsRunAllCommands.NonMarkedText = "Run all commands";
            this.hsRunAllCommands.Size = new System.Drawing.Size(146, 34);
            this.hsRunAllCommands.TabIndex = 37;
            this.hsRunAllCommands.Text = "Run all commands";
            this.hsRunAllCommands.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRunAllCommands.ToolTipActive = false;
            this.hsRunAllCommands.ToolTipAutomaticDelay = 500;
            this.hsRunAllCommands.ToolTipAutoPopDelay = 5000;
            this.hsRunAllCommands.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunAllCommands.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunAllCommands.ToolTipFor4ContextMenu = true;
            this.hsRunAllCommands.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunAllCommands.ToolTipInitialDelay = 500;
            this.hsRunAllCommands.ToolTipIsBallon = false;
            this.hsRunAllCommands.ToolTipOwnerDraw = false;
            this.hsRunAllCommands.ToolTipReshowDelay = 100;
            this.hsRunAllCommands.ToolTipShowAlways = false;
            this.hsRunAllCommands.ToolTipText = "";
            this.hsRunAllCommands.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunAllCommands.ToolTipTitle = "";
            this.hsRunAllCommands.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunAllCommands.UseVisualStyleBackColor = false;
            this.hsRunAllCommands.Click += new System.EventHandler(this.hsRunAllCommands_Click);
            // 
            // hsRunActualCommand
            // 
            this.hsRunActualCommand.BackColor = System.Drawing.Color.Transparent;
            this.hsRunActualCommand.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunActualCommand.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunActualCommand.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunActualCommand.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunActualCommand.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunActualCommand.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunActualCommand.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRunActualCommand.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunActualCommand.FlatAppearance.BorderSize = 0;
            this.hsRunActualCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunActualCommand.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunActualCommand.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsRunActualCommand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRunActualCommand.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsRunActualCommand.ImageToggleOnSelect = true;
            this.hsRunActualCommand.Location = new System.Drawing.Point(532, 0);
            this.hsRunActualCommand.Marked = false;
            this.hsRunActualCommand.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunActualCommand.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunActualCommand.MarkedText = "";
            this.hsRunActualCommand.MarkMode = false;
            this.hsRunActualCommand.Name = "hsRunActualCommand";
            this.hsRunActualCommand.NonMarkedText = "Run actual command";
            this.hsRunActualCommand.Size = new System.Drawing.Size(146, 34);
            this.hsRunActualCommand.TabIndex = 36;
            this.hsRunActualCommand.Text = "Run actual command";
            this.hsRunActualCommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRunActualCommand.ToolTipActive = false;
            this.hsRunActualCommand.ToolTipAutomaticDelay = 500;
            this.hsRunActualCommand.ToolTipAutoPopDelay = 5000;
            this.hsRunActualCommand.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunActualCommand.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunActualCommand.ToolTipFor4ContextMenu = true;
            this.hsRunActualCommand.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunActualCommand.ToolTipInitialDelay = 500;
            this.hsRunActualCommand.ToolTipIsBallon = false;
            this.hsRunActualCommand.ToolTipOwnerDraw = false;
            this.hsRunActualCommand.ToolTipReshowDelay = 100;
            this.hsRunActualCommand.ToolTipShowAlways = false;
            this.hsRunActualCommand.ToolTipText = "";
            this.hsRunActualCommand.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunActualCommand.ToolTipTitle = "";
            this.hsRunActualCommand.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunActualCommand.UseVisualStyleBackColor = false;
            this.hsRunActualCommand.Click += new System.EventHandler(this.hsRunActualCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Clear after (n) lines:";
            // 
            // hsClearCmds
            // 
            this.hsClearCmds.BackColor = System.Drawing.Color.Transparent;
            this.hsClearCmds.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearCmds.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearCmds.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearCmds.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearCmds.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearCmds.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearCmds.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsClearCmds.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearCmds.FlatAppearance.BorderSize = 0;
            this.hsClearCmds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearCmds.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearCmds.Image = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hsClearCmds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsClearCmds.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearCmds.ImageToggleOnSelect = true;
            this.hsClearCmds.Location = new System.Drawing.Point(678, 0);
            this.hsClearCmds.Marked = false;
            this.hsClearCmds.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearCmds.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearCmds.MarkedText = "";
            this.hsClearCmds.MarkMode = false;
            this.hsClearCmds.Name = "hsClearCmds";
            this.hsClearCmds.NonMarkedText = "Clear";
            this.hsClearCmds.Size = new System.Drawing.Size(67, 34);
            this.hsClearCmds.TabIndex = 34;
            this.hsClearCmds.Text = "Clear";
            this.hsClearCmds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsClearCmds.ToolTipActive = false;
            this.hsClearCmds.ToolTipAutomaticDelay = 500;
            this.hsClearCmds.ToolTipAutoPopDelay = 5000;
            this.hsClearCmds.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearCmds.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearCmds.ToolTipFor4ContextMenu = true;
            this.hsClearCmds.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearCmds.ToolTipInitialDelay = 500;
            this.hsClearCmds.ToolTipIsBallon = false;
            this.hsClearCmds.ToolTipOwnerDraw = false;
            this.hsClearCmds.ToolTipReshowDelay = 100;
            this.hsClearCmds.ToolTipShowAlways = false;
            this.hsClearCmds.ToolTipText = "";
            this.hsClearCmds.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearCmds.ToolTipTitle = "";
            this.hsClearCmds.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearCmds.UseVisualStyleBackColor = false;
            this.hsClearCmds.Click += new System.EventHandler(this.hsClearCmds_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(122, 9);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(77, 20);
            this.txtClear.TabIndex = 10;
            this.txtClear.Text = "10000";
            // 
            // pnlLeftCommands
            // 
            this.pnlLeftCommands.Controls.Add(this.cbClearBeforePreparing);
            this.pnlLeftCommands.Controls.Add(this.cbReopenConnectionEachCommand);
            this.pnlLeftCommands.Controls.Add(this.cbCommitEachCmd);
            this.pnlLeftCommands.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftCommands.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftCommands.Name = "pnlLeftCommands";
            this.pnlLeftCommands.Size = new System.Drawing.Size(158, 536);
            this.pnlLeftCommands.TabIndex = 3;
            // 
            // cbClearBeforePreparing
            // 
            this.cbClearBeforePreparing.AutoSize = true;
            this.cbClearBeforePreparing.Checked = true;
            this.cbClearBeforePreparing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClearBeforePreparing.Location = new System.Drawing.Point(5, 45);
            this.cbClearBeforePreparing.Name = "cbClearBeforePreparing";
            this.cbClearBeforePreparing.Size = new System.Drawing.Size(130, 17);
            this.cbClearBeforePreparing.TabIndex = 13;
            this.cbClearBeforePreparing.Text = "Clear before preparing";
            this.cbClearBeforePreparing.UseVisualStyleBackColor = true;
            // 
            // cbReopenConnectionEachCommand
            // 
            this.cbReopenConnectionEachCommand.AutoSize = true;
            this.cbReopenConnectionEachCommand.Checked = true;
            this.cbReopenConnectionEachCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReopenConnectionEachCommand.Location = new System.Drawing.Point(6, 68);
            this.cbReopenConnectionEachCommand.Name = "cbReopenConnectionEachCommand";
            this.cbReopenConnectionEachCommand.Size = new System.Drawing.Size(127, 17);
            this.cbReopenConnectionEachCommand.TabIndex = 12;
            this.cbReopenConnectionEachCommand.Text = "Repopen Connection";
            this.cbReopenConnectionEachCommand.UseVisualStyleBackColor = true;
            // 
            // cbCommitEachCmd
            // 
            this.cbCommitEachCmd.AutoSize = true;
            this.cbCommitEachCmd.Checked = true;
            this.cbCommitEachCmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCommitEachCmd.Location = new System.Drawing.Point(6, 91);
            this.cbCommitEachCmd.Name = "cbCommitEachCmd";
            this.cbCommitEachCmd.Size = new System.Drawing.Size(136, 17);
            this.cbCommitEachCmd.TabIndex = 3;
            this.cbCommitEachCmd.Text = "Commit each command";
            this.cbCommitEachCmd.UseVisualStyleBackColor = true;
            // 
            // ofdSQL
            // 
            this.ofdSQL.DefaultExt = "*.sql";
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
            this.ofdSQL.Title = "Load script";
            // 
            // sfSQL
            // 
            this.sfSQL.Filter = "SQL|*.SQL|All|*.*";
            // 
            // ScriptingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 795);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptingForm";
            this.Text = "Scripts";
            this.Load += new System.EventHandler(this.DefaultForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.bnConnection.ResumeLayout(false);
            this.pnlLower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbNotify)).EndInit();
            this.pnlGauge.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.splitScript.Panel1.ResumeLayout(false);
            this.splitScript.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitScript)).EndInit();
            this.splitScript.ResumeLayout(false);
            this.tabScripting.ResumeLayout(false);
            this.tabSQL.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            this.gbSQLText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbSQL)).EndInit();
            this.cmsSQLText.ResumeLayout(false);
            this.gbScriptRightPanel.ResumeLayout(false);
            this.pnlUpperSQL.ResumeLayout(false);
            this.tabPageFiles.ResumeLayout(false);
            this.pnlOptionsCenter.ResumeLayout(false);
            this.gbSQLFiles.ResumeLayout(false);
            this.gbSQLFilesRight.ResumeLayout(false);
            this.gbAddFile.ResumeLayout(false);
            this.pnlSQLFileLower.ResumeLayout(false);
            this.gbSQLLocation.ResumeLayout(false);
            this.gbSQLLocation.PerformLayout();
            this.gbOptionsFilesize.ResumeLayout(false);
            this.gbOptionsFilesize.PerformLayout();
            this.tabPagePreparedCommands.ResumeLayout(false);
            this.gbPreparedCommands.ResumeLayout(false);
            this.gbCommandsDone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbCommands)).EndInit();
            this.pnlCommandsUpper.ResumeLayout(false);
            this.pnlCommandsUpper.PerformLayout();
            this.pnlLeftCommands.ResumeLayout(false);
            this.pnlLeftCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabScripting;
        private System.Windows.Forms.TabPage tabSQL;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabPageFiles;
        
        private System.Windows.Forms.Panel pnlOptionsCenter;
        private SeControlsLib.HotSpot hsLoadScript;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private FastColoredTextBoxNS.FastColoredTextBox fcbCommands;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.CheckBox cbCommitEachCmd;
        private System.Windows.Forms.Panel pnlGauge;
        private FastColoredTextBoxNS.FastColoredTextBox fcbNotify;
        private System.Windows.Forms.Label lblGauge;
        private System.Windows.Forms.ContextMenuStrip cmsSQLText;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiDDLPaste;
        private System.Windows.Forms.TextBox txtClear;
        private System.Windows.Forms.SplitContainer splitScript;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.GroupBox gbCommandsDone;
        private System.Windows.Forms.GroupBox gbSQLFiles;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.GroupBox gbAddFile;
        private SeControlsLib.HotSpot hsAddBackupFile;
        private System.Windows.Forms.GroupBox gbOptionsFilesize;
        private System.Windows.Forms.TextBox txtFileSize;
        private SeControlsLib.HotSpot hsRemoveBackupFile;
        private System.Windows.Forms.GroupBox gbSQLLocation;
        private System.Windows.Forms.TextBox txtSQLLocation;
        private SeControlsLib.HotSpot hsLoad;
        private SeControlsLib.HotSpot hsClearCmds;
        private SeControlsLib.HotSpot hsClearSQL;
        private System.Windows.Forms.SaveFileDialog sfSQL;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel pnlUpperSQL;
        private System.Windows.Forms.Panel pnlLeftCommands;
        private System.Windows.Forms.Panel pnlCommandsUpper;
        private System.Windows.Forms.GroupBox gbSQLText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bnConnection;
        private System.Windows.Forms.ComboBox cbConnection;
        private System.Windows.Forms.Panel pnlSQLFileLower;
        private FastColoredTextBoxNS.FastColoredTextBox fcbSQL;
        private SeControlsLib.HotSpot hsRunActualCommand;
        private SeControlsLib.HotSpot hsRunAllCommands;
        private System.Windows.Forms.CheckBox cbReopenConnectionEachCommand;
        private System.Windows.Forms.CheckBox cbClearBeforePreparing;
        private System.Windows.Forms.TabPage tabPagePreparedCommands;
        private System.Windows.Forms.GroupBox gbPreparedCommands;
        private SeControlsLib.HotSpot hotSpot1;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.ListView lvCommands;
        private System.Windows.Forms.ColumnHeader colNR;
        private System.Windows.Forms.ColumnHeader colCMD;
        private System.Windows.Forms.ColumnHeader colCMDTYPE;
        private System.Windows.Forms.ColumnHeader colUsedTime;
        private System.Windows.Forms.GroupBox gbScriptRightPanel;
        private SeControlsLib.HotSpot hsExecuteSQL;
        private SeControlsLib.HotSpot hsRunSQLDirect;
        private System.Windows.Forms.GroupBox gbSQLFilesRight;
        private SeControlsLib.HotSpot hsPrepareSQLFromFiles;
        private SeControlsLib.HotSpot hsRunFilesDirect;
    }
}