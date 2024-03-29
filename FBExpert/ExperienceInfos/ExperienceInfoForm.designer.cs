using BasicForms;
using System.ComponentModel;
using System.Windows.Forms;

namespace SQLView
{
    /// <summary>
    /// Zusammenfassende Beschreibung f�r WinForm
    /// </summary>
    partial class ExperienceInfoForm : BasicNormalFormClass
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
        /// Erforderliche Methode zur Unterst�tzung des Designers -
        /// �ndern Sie die Methode nicht mit dem Quelltext-Editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperienceInfoForm));
            this.pnl_upper = new System.Windows.Forms.Panel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.hsLoadDatabasePath = new SeControlsLib.HotSpot();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.tcSQLCONTROL = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.dgvExperienceInfo = new System.Windows.Forms.DataGridView();
            this.cmdExperienceInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExperienceInfoToSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteExperienceInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlExyperienceInfoUpper = new System.Windows.Forms.Panel();
            this.fctExperienceInfo = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbExperienceInfoKey = new System.Windows.Forms.GroupBox();
            this.hsUpdateExperienceInfo = new SeControlsLib.HotSpot();
            this.hsDeleteExperienceInfo = new SeControlsLib.HotSpot();
            this.txtExperienceKeyCode = new System.Windows.Forms.TextBox();
            this.hsClearExperienceInfoFields = new SeControlsLib.HotSpot();
            this.hsRefreshExperienceInfo = new SeControlsLib.HotSpot();
            this.hsInsertExperienceInfo = new SeControlsLib.HotSpot();
            this.flpExperienceInfoUpper = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageLocalExperience = new System.Windows.Forms.TabPage();
            this.pnlLocalExperienceInfoUpper = new System.Windows.Forms.Panel();
            this.fctLocalExperienceInfo = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbLocalExperienceInfoKey = new System.Windows.Forms.GroupBox();
            this.hsUpdateLocalExperienceInfo = new SeControlsLib.HotSpot();
            this.hsDeleteLocalData = new SeControlsLib.HotSpot();
            this.txtLocalExperienceKeyCode = new System.Windows.Forms.TextBox();
            this.hsClearLocalExperienceInfo = new SeControlsLib.HotSpot();
            this.hsRefreshLocalExperienceInfo = new SeControlsLib.HotSpot();
            this.hsInsertLoaclExperienceInfo = new SeControlsLib.HotSpot();
            this.flpLocalExperienceInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.gbLocalDatabase = new System.Windows.Forms.GroupBox();
            this.txtLocalDatabase = new System.Windows.Forms.TextBox();
            this.hsLoadLocalDatabasePath = new SeControlsLib.HotSpot();
            this.dgvLocalExperienceInfo = new System.Windows.Forms.DataGridView();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.helpMain = new System.Windows.Forms.HelpProvider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_upper.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.tcSQLCONTROL.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienceInfo)).BeginInit();
            this.cmdExperienceInfo.SuspendLayout();
            this.pnlExyperienceInfoUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctExperienceInfo)).BeginInit();
            this.gbExperienceInfoKey.SuspendLayout();
            this.flpExperienceInfoUpper.SuspendLayout();
            this.tabPageLocalExperience.SuspendLayout();
            this.pnlLocalExperienceInfoUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctLocalExperienceInfo)).BeginInit();
            this.gbLocalExperienceInfoKey.SuspendLayout();
            this.flpLocalExperienceInfo.SuspendLayout();
            this.gbLocalDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalExperienceInfo)).BeginInit();
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
            this.pnl_upper.Size = new System.Drawing.Size(1604, 49);
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
            // gbDatabase
            // 
            this.gbDatabase.Controls.Add(this.txtDatabase);
            this.gbDatabase.Controls.Add(this.hsLoadDatabasePath);
            this.gbDatabase.Location = new System.Drawing.Point(3, 3);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.Size = new System.Drawing.Size(606, 47);
            this.gbDatabase.TabIndex = 29;
            this.gbDatabase.TabStop = false;
            this.gbDatabase.Text = "Info Database File";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabase.Location = new System.Drawing.Point(3, 16);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(555, 20);
            this.txtDatabase.TabIndex = 1;
            // 
            // hsLoadDatabasePath
            // 
            this.hsLoadDatabasePath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadDatabasePath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDatabasePath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDatabasePath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadDatabasePath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadDatabasePath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadDatabasePath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadDatabasePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadDatabasePath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadDatabasePath.FlatAppearance.BorderSize = 0;
            this.hsLoadDatabasePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadDatabasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadDatabasePath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadDatabasePath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadDatabasePath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadDatabasePath.ImageToggleOnSelect = true;
            this.hsLoadDatabasePath.Location = new System.Drawing.Point(558, 16);
            this.hsLoadDatabasePath.Marked = false;
            this.hsLoadDatabasePath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadDatabasePath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadDatabasePath.MarkedText = "";
            this.hsLoadDatabasePath.MarkMode = false;
            this.hsLoadDatabasePath.Name = "hsLoadDatabasePath";
            this.hsLoadDatabasePath.NonMarkedText = "";
            this.hsLoadDatabasePath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadDatabasePath.ShowShortcut = false;
            this.hsLoadDatabasePath.Size = new System.Drawing.Size(45, 28);
            this.hsLoadDatabasePath.TabIndex = 3;
            this.hsLoadDatabasePath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadDatabasePath.ToolTipActive = false;
            this.hsLoadDatabasePath.ToolTipAutomaticDelay = 500;
            this.hsLoadDatabasePath.ToolTipAutoPopDelay = 5000;
            this.hsLoadDatabasePath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadDatabasePath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadDatabasePath.ToolTipFor4ContextMenu = true;
            this.hsLoadDatabasePath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadDatabasePath.ToolTipInitialDelay = 500;
            this.hsLoadDatabasePath.ToolTipIsBallon = false;
            this.hsLoadDatabasePath.ToolTipOwnerDraw = false;
            this.hsLoadDatabasePath.ToolTipReshowDelay = 100;
            this.hsLoadDatabasePath.ToolTipShowAlways = false;
            this.hsLoadDatabasePath.ToolTipText = "";
            this.hsLoadDatabasePath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadDatabasePath.ToolTipTitle = "";
            this.hsLoadDatabasePath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadDatabasePath.UseVisualStyleBackColor = false;
            this.hsLoadDatabasePath.Click += new System.EventHandler(this.hsLoadDatabasePath_Click);
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
            this.tcSQLCONTROL.Controls.Add(this.tabPageInfo);
            this.tcSQLCONTROL.Controls.Add(this.tabPageLocalExperience);
            this.tcSQLCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSQLCONTROL.ImageList = this.ilTabControl;
            this.tcSQLCONTROL.Location = new System.Drawing.Point(0, 0);
            this.tcSQLCONTROL.Name = "tcSQLCONTROL";
            this.tcSQLCONTROL.SelectedIndex = 0;
            this.tcSQLCONTROL.Size = new System.Drawing.Size(1602, 648);
            this.tcSQLCONTROL.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.dgvExperienceInfo);
            this.tabPageInfo.Controls.Add(this.pnlExyperienceInfoUpper);
            this.tabPageInfo.Controls.Add(this.flpExperienceInfoUpper);
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
            this.dgvExperienceInfo.Location = new System.Drawing.Point(3, 164);
            this.dgvExperienceInfo.Name = "dgvExperienceInfo";
            this.dgvExperienceInfo.RowHeadersVisible = false;
            this.dgvExperienceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExperienceInfo.Size = new System.Drawing.Size(1588, 454);
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
            this.tsmiExperienceInfoToSQL.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
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
            this.tsmiDeleteExperienceInfo.Image = global::FBXpert.Properties.Resources.cross_red_x22;
            this.tsmiDeleteExperienceInfo.Name = "tsmiDeleteExperienceInfo";
            this.tsmiDeleteExperienceInfo.Size = new System.Drawing.Size(140, 22);
            this.tsmiDeleteExperienceInfo.Text = "Delete entry";
            // 
            // pnlExyperienceInfoUpper
            // 
            this.pnlExyperienceInfoUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExyperienceInfoUpper.Controls.Add(this.fctExperienceInfo);
            this.pnlExyperienceInfoUpper.Controls.Add(this.gbExperienceInfoKey);
            this.pnlExyperienceInfoUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExyperienceInfoUpper.Location = new System.Drawing.Point(3, 57);
            this.pnlExyperienceInfoUpper.Name = "pnlExyperienceInfoUpper";
            this.pnlExyperienceInfoUpper.Size = new System.Drawing.Size(1588, 107);
            this.pnlExyperienceInfoUpper.TabIndex = 25;
            // 
            // fctExperienceInfo
            // 
            this.fctExperienceInfo.AutoCompleteBracketsList = new char[] {
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
            this.fctExperienceInfo.AutoIndentCharsPatterns = "";
            this.fctExperienceInfo.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctExperienceInfo.BackBrush = null;
            this.fctExperienceInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctExperienceInfo.CharHeight = 14;
            this.fctExperienceInfo.CharWidth = 8;
            this.fctExperienceInfo.CommentPrefix = "--";
            this.fctExperienceInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctExperienceInfo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctExperienceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctExperienceInfo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctExperienceInfo.IsReplaceMode = false;
            this.fctExperienceInfo.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctExperienceInfo.LeftBracket = '(';
            this.fctExperienceInfo.Location = new System.Drawing.Point(427, 0);
            this.fctExperienceInfo.Name = "fctExperienceInfo";
            this.fctExperienceInfo.Paddings = new System.Windows.Forms.Padding(0);
            this.fctExperienceInfo.RightBracket = ')';
            this.fctExperienceInfo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctExperienceInfo.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctExperienceInfo.ServiceColors")));
            this.fctExperienceInfo.Size = new System.Drawing.Size(1157, 103);
            this.fctExperienceInfo.TabIndex = 41;
            this.fctExperienceInfo.Zoom = 100;
            this.fctExperienceInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExperienceInfo_KeyDown);
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
            this.hsUpdateExperienceInfo.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsUpdateExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUpdateExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
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
            this.hsDeleteExperienceInfo.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsDeleteExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDeleteExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
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
            this.hsClearExperienceInfoFields.Image = global::FBXpert.Properties.Resources.sweep_ge24x;
            this.hsClearExperienceInfoFields.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearExperienceInfoFields.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
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
            this.hsRefreshExperienceInfo.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
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
            this.hsInsertExperienceInfo.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsInsertExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsInsertExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
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
            this.hsInsertExperienceInfo.Click += new System.EventHandler(this.hsInserExperienceInfo_Click);
            // 
            // flpExperienceInfoUpper
            // 
            this.flpExperienceInfoUpper.Controls.Add(this.gbDatabase);
            this.flpExperienceInfoUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpExperienceInfoUpper.Location = new System.Drawing.Point(3, 3);
            this.flpExperienceInfoUpper.Name = "flpExperienceInfoUpper";
            this.flpExperienceInfoUpper.Size = new System.Drawing.Size(1588, 54);
            this.flpExperienceInfoUpper.TabIndex = 26;
            // 
            // tabPageLocalExperience
            // 
            this.tabPageLocalExperience.Controls.Add(this.dgvLocalExperienceInfo);
            this.tabPageLocalExperience.Controls.Add(this.pnlLocalExperienceInfoUpper);
            this.tabPageLocalExperience.Controls.Add(this.flpLocalExperienceInfo);
            
            this.tabPageLocalExperience.Location = new System.Drawing.Point(4, 23);
            this.tabPageLocalExperience.Name = "tabPageLocalExperience";
            this.tabPageLocalExperience.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalExperience.Size = new System.Drawing.Size(1594, 621);
            this.tabPageLocalExperience.TabIndex = 11;
            this.tabPageLocalExperience.Text = "Local Experience";
            this.tabPageLocalExperience.UseVisualStyleBackColor = true;
            // 
            // pnlLocalExperienceInfoUpper
            // 
            this.pnlLocalExperienceInfoUpper.Controls.Add(this.fctLocalExperienceInfo);
            this.pnlLocalExperienceInfoUpper.Controls.Add(this.gbLocalExperienceInfoKey);
            this.pnlLocalExperienceInfoUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocalExperienceInfoUpper.Location = new System.Drawing.Point(3, 57);
            this.pnlLocalExperienceInfoUpper.Name = "pnlLocalExperienceInfoUpper";
            this.pnlLocalExperienceInfoUpper.Size = new System.Drawing.Size(1588, 111);
            this.pnlLocalExperienceInfoUpper.TabIndex = 45;
            // 
            // fctLocalExperienceInfo
            // 
            this.fctLocalExperienceInfo.AutoCompleteBracketsList = new char[] {
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
            this.fctLocalExperienceInfo.AutoIndentCharsPatterns = "";
            this.fctLocalExperienceInfo.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctLocalExperienceInfo.BackBrush = null;
            this.fctLocalExperienceInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctLocalExperienceInfo.CharHeight = 14;
            this.fctLocalExperienceInfo.CharWidth = 8;
            this.fctLocalExperienceInfo.CommentPrefix = "--";
            this.fctLocalExperienceInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctLocalExperienceInfo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctLocalExperienceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctLocalExperienceInfo.IsReplaceMode = false;
            this.fctLocalExperienceInfo.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctLocalExperienceInfo.LeftBracket = '(';
            this.fctLocalExperienceInfo.Location = new System.Drawing.Point(427, 0);
            this.fctLocalExperienceInfo.Name = "fctLocalExperienceInfo";
            this.fctLocalExperienceInfo.Paddings = new System.Windows.Forms.Padding(0);
            this.fctLocalExperienceInfo.RightBracket = ')';
            this.fctLocalExperienceInfo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctLocalExperienceInfo.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctLocalExperienceInfo.ServiceColors")));
            this.fctLocalExperienceInfo.Size = new System.Drawing.Size(1161, 111);
            this.fctLocalExperienceInfo.TabIndex = 44;
            this.fctLocalExperienceInfo.Zoom = 100;
            this.fctLocalExperienceInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctLocalExperienceInfo_KeyDown);
            // 
            // gbLocalExperienceInfoKey
            // 
            this.gbLocalExperienceInfoKey.Controls.Add(this.hsUpdateLocalExperienceInfo);
            this.gbLocalExperienceInfoKey.Controls.Add(this.hsDeleteLocalData);
            this.gbLocalExperienceInfoKey.Controls.Add(this.txtLocalExperienceKeyCode);
            this.gbLocalExperienceInfoKey.Controls.Add(this.hsClearLocalExperienceInfo);
            this.gbLocalExperienceInfoKey.Controls.Add(this.hsRefreshLocalExperienceInfo);
            this.gbLocalExperienceInfoKey.Controls.Add(this.hsInsertLoaclExperienceInfo);
            this.gbLocalExperienceInfoKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLocalExperienceInfoKey.Location = new System.Drawing.Point(0, 0);
            this.gbLocalExperienceInfoKey.Name = "gbLocalExperienceInfoKey";
            this.gbLocalExperienceInfoKey.Size = new System.Drawing.Size(427, 111);
            this.gbLocalExperienceInfoKey.TabIndex = 43;
            this.gbLocalExperienceInfoKey.TabStop = false;
            this.gbLocalExperienceInfoKey.Text = "Local Info";
            // 
            // hsUpdateLocalExperienceInfo
            // 
            this.hsUpdateLocalExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsUpdateLocalExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateLocalExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateLocalExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUpdateLocalExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUpdateLocalExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUpdateLocalExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUpdateLocalExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUpdateLocalExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsUpdateLocalExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUpdateLocalExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsUpdateLocalExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUpdateLocalExperienceInfo.Image = global::FBXpert.Properties.Resources.ok_gn22x;
            this.hsUpdateLocalExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUpdateLocalExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.ok_blue22x;
            this.hsUpdateLocalExperienceInfo.ImageToggleOnSelect = true;
            this.hsUpdateLocalExperienceInfo.Location = new System.Drawing.Point(340, 19);
            this.hsUpdateLocalExperienceInfo.Marked = false;
            this.hsUpdateLocalExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsUpdateLocalExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUpdateLocalExperienceInfo.MarkedText = "";
            this.hsUpdateLocalExperienceInfo.MarkMode = false;
            this.hsUpdateLocalExperienceInfo.Name = "hsUpdateLocalExperienceInfo";
            this.hsUpdateLocalExperienceInfo.NonMarkedText = "Execute";
            this.hsUpdateLocalExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUpdateLocalExperienceInfo.ShowShortcut = false;
            this.hsUpdateLocalExperienceInfo.Size = new System.Drawing.Size(79, 45);
            this.hsUpdateLocalExperienceInfo.TabIndex = 41;
            this.hsUpdateLocalExperienceInfo.Text = "Update";
            this.hsUpdateLocalExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUpdateLocalExperienceInfo.ToolTipActive = false;
            this.hsUpdateLocalExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsUpdateLocalExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsUpdateLocalExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUpdateLocalExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUpdateLocalExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsUpdateLocalExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUpdateLocalExperienceInfo.ToolTipInitialDelay = 500;
            this.hsUpdateLocalExperienceInfo.ToolTipIsBallon = false;
            this.hsUpdateLocalExperienceInfo.ToolTipOwnerDraw = false;
            this.hsUpdateLocalExperienceInfo.ToolTipReshowDelay = 100;
            this.hsUpdateLocalExperienceInfo.ToolTipShowAlways = false;
            this.hsUpdateLocalExperienceInfo.ToolTipText = "";
            this.hsUpdateLocalExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUpdateLocalExperienceInfo.ToolTipTitle = "";
            this.hsUpdateLocalExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUpdateLocalExperienceInfo.UseVisualStyleBackColor = false;
            this.hsUpdateLocalExperienceInfo.Click += new System.EventHandler(this.hsUpdateLocalExperienceInfo_Click);
            // 
            // hsDeleteLocalData
            // 
            this.hsDeleteLocalData.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteLocalData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteLocalData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteLocalData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteLocalData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteLocalData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteLocalData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteLocalData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDeleteLocalData.FlatAppearance.BorderSize = 0;
            this.hsDeleteLocalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteLocalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteLocalData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteLocalData.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsDeleteLocalData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDeleteLocalData.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsDeleteLocalData.ImageToggleOnSelect = true;
            this.hsDeleteLocalData.Location = new System.Drawing.Point(255, 19);
            this.hsDeleteLocalData.Marked = false;
            this.hsDeleteLocalData.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteLocalData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteLocalData.MarkedText = "";
            this.hsDeleteLocalData.MarkMode = false;
            this.hsDeleteLocalData.Name = "hsDeleteLocalData";
            this.hsDeleteLocalData.NonMarkedText = "Execute";
            this.hsDeleteLocalData.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteLocalData.ShowShortcut = false;
            this.hsDeleteLocalData.Size = new System.Drawing.Size(79, 45);
            this.hsDeleteLocalData.TabIndex = 40;
            this.hsDeleteLocalData.Text = "Delete";
            this.hsDeleteLocalData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDeleteLocalData.ToolTipActive = false;
            this.hsDeleteLocalData.ToolTipAutomaticDelay = 500;
            this.hsDeleteLocalData.ToolTipAutoPopDelay = 5000;
            this.hsDeleteLocalData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteLocalData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteLocalData.ToolTipFor4ContextMenu = true;
            this.hsDeleteLocalData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteLocalData.ToolTipInitialDelay = 500;
            this.hsDeleteLocalData.ToolTipIsBallon = false;
            this.hsDeleteLocalData.ToolTipOwnerDraw = false;
            this.hsDeleteLocalData.ToolTipReshowDelay = 100;
            this.hsDeleteLocalData.ToolTipShowAlways = false;
            this.hsDeleteLocalData.ToolTipText = "";
            this.hsDeleteLocalData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteLocalData.ToolTipTitle = "";
            this.hsDeleteLocalData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteLocalData.UseVisualStyleBackColor = false;
            this.hsDeleteLocalData.Click += new System.EventHandler(this.hsDeleteLocalData_Click);
            // 
            // txtLocalExperienceKeyCode
            // 
            this.txtLocalExperienceKeyCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLocalExperienceKeyCode.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalExperienceKeyCode.Location = new System.Drawing.Point(3, 86);
            this.txtLocalExperienceKeyCode.Name = "txtLocalExperienceKeyCode";
            this.txtLocalExperienceKeyCode.Size = new System.Drawing.Size(421, 22);
            this.txtLocalExperienceKeyCode.TabIndex = 39;
            // 
            // hsClearLocalExperienceInfo
            // 
            this.hsClearLocalExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsClearLocalExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearLocalExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearLocalExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearLocalExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearLocalExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearLocalExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearLocalExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearLocalExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsClearLocalExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearLocalExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearLocalExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearLocalExperienceInfo.Image = global::FBXpert.Properties.Resources.sweep_ge24x;
            this.hsClearLocalExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearLocalExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearLocalExperienceInfo.ImageToggleOnSelect = true;
            this.hsClearLocalExperienceInfo.Location = new System.Drawing.Point(90, 19);
            this.hsClearLocalExperienceInfo.Marked = false;
            this.hsClearLocalExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearLocalExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearLocalExperienceInfo.MarkedText = "";
            this.hsClearLocalExperienceInfo.MarkMode = false;
            this.hsClearLocalExperienceInfo.Name = "hsClearLocalExperienceInfo";
            this.hsClearLocalExperienceInfo.NonMarkedText = "Clear Fields";
            this.hsClearLocalExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearLocalExperienceInfo.ShowShortcut = false;
            this.hsClearLocalExperienceInfo.Size = new System.Drawing.Size(75, 45);
            this.hsClearLocalExperienceInfo.TabIndex = 37;
            this.hsClearLocalExperienceInfo.Text = "Clear";
            this.hsClearLocalExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearLocalExperienceInfo.ToolTipActive = false;
            this.hsClearLocalExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsClearLocalExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsClearLocalExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearLocalExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearLocalExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsClearLocalExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearLocalExperienceInfo.ToolTipInitialDelay = 500;
            this.hsClearLocalExperienceInfo.ToolTipIsBallon = false;
            this.hsClearLocalExperienceInfo.ToolTipOwnerDraw = false;
            this.hsClearLocalExperienceInfo.ToolTipReshowDelay = 100;
            this.hsClearLocalExperienceInfo.ToolTipShowAlways = false;
            this.hsClearLocalExperienceInfo.ToolTipText = "";
            this.hsClearLocalExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearLocalExperienceInfo.ToolTipTitle = "";
            this.hsClearLocalExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearLocalExperienceInfo.UseVisualStyleBackColor = false;
            this.hsClearLocalExperienceInfo.Click += new System.EventHandler(this.hsClearLocalExperienceInfo_Click);
            // 
            // hsRefreshLocalExperienceInfo
            // 
            this.hsRefreshLocalExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshLocalExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshLocalExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshLocalExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshLocalExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshLocalExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshLocalExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshLocalExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshLocalExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsRefreshLocalExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshLocalExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshLocalExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshLocalExperienceInfo.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshLocalExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshLocalExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshLocalExperienceInfo.ImageToggleOnSelect = true;
            this.hsRefreshLocalExperienceInfo.Location = new System.Drawing.Point(171, 19);
            this.hsRefreshLocalExperienceInfo.Marked = false;
            this.hsRefreshLocalExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshLocalExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshLocalExperienceInfo.MarkedText = "";
            this.hsRefreshLocalExperienceInfo.MarkMode = false;
            this.hsRefreshLocalExperienceInfo.Name = "hsRefreshLocalExperienceInfo";
            this.hsRefreshLocalExperienceInfo.NonMarkedText = "Refresh";
            this.hsRefreshLocalExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshLocalExperienceInfo.ShowShortcut = false;
            this.hsRefreshLocalExperienceInfo.Size = new System.Drawing.Size(89, 45);
            this.hsRefreshLocalExperienceInfo.TabIndex = 33;
            this.hsRefreshLocalExperienceInfo.Text = "Refresh";
            this.hsRefreshLocalExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshLocalExperienceInfo.ToolTipActive = false;
            this.hsRefreshLocalExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsRefreshLocalExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsRefreshLocalExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshLocalExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshLocalExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsRefreshLocalExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshLocalExperienceInfo.ToolTipInitialDelay = 500;
            this.hsRefreshLocalExperienceInfo.ToolTipIsBallon = false;
            this.hsRefreshLocalExperienceInfo.ToolTipOwnerDraw = false;
            this.hsRefreshLocalExperienceInfo.ToolTipReshowDelay = 100;
            this.hsRefreshLocalExperienceInfo.ToolTipShowAlways = false;
            this.hsRefreshLocalExperienceInfo.ToolTipText = "";
            this.hsRefreshLocalExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshLocalExperienceInfo.ToolTipTitle = "";
            this.hsRefreshLocalExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshLocalExperienceInfo.UseVisualStyleBackColor = false;
            this.hsRefreshLocalExperienceInfo.Click += new System.EventHandler(this.hsRefreshLocalExperienceInfo_Click);
            // 
            // hsInsertLoaclExperienceInfo
            // 
            this.hsInsertLoaclExperienceInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsInsertLoaclExperienceInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInsertLoaclExperienceInfo.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInsertLoaclExperienceInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInsertLoaclExperienceInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInsertLoaclExperienceInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInsertLoaclExperienceInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInsertLoaclExperienceInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsInsertLoaclExperienceInfo.FlatAppearance.BorderSize = 0;
            this.hsInsertLoaclExperienceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInsertLoaclExperienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInsertLoaclExperienceInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInsertLoaclExperienceInfo.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsInsertLoaclExperienceInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsInsertLoaclExperienceInfo.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsInsertLoaclExperienceInfo.ImageToggleOnSelect = true;
            this.hsInsertLoaclExperienceInfo.Location = new System.Drawing.Point(6, 19);
            this.hsInsertLoaclExperienceInfo.Marked = false;
            this.hsInsertLoaclExperienceInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsInsertLoaclExperienceInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInsertLoaclExperienceInfo.MarkedText = "";
            this.hsInsertLoaclExperienceInfo.MarkMode = false;
            this.hsInsertLoaclExperienceInfo.Name = "hsInsertLoaclExperienceInfo";
            this.hsInsertLoaclExperienceInfo.NonMarkedText = "Execute";
            this.hsInsertLoaclExperienceInfo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInsertLoaclExperienceInfo.ShowShortcut = false;
            this.hsInsertLoaclExperienceInfo.Size = new System.Drawing.Size(79, 45);
            this.hsInsertLoaclExperienceInfo.TabIndex = 28;
            this.hsInsertLoaclExperienceInfo.Text = "Add";
            this.hsInsertLoaclExperienceInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsInsertLoaclExperienceInfo.ToolTipActive = false;
            this.hsInsertLoaclExperienceInfo.ToolTipAutomaticDelay = 500;
            this.hsInsertLoaclExperienceInfo.ToolTipAutoPopDelay = 5000;
            this.hsInsertLoaclExperienceInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInsertLoaclExperienceInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInsertLoaclExperienceInfo.ToolTipFor4ContextMenu = true;
            this.hsInsertLoaclExperienceInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInsertLoaclExperienceInfo.ToolTipInitialDelay = 500;
            this.hsInsertLoaclExperienceInfo.ToolTipIsBallon = false;
            this.hsInsertLoaclExperienceInfo.ToolTipOwnerDraw = false;
            this.hsInsertLoaclExperienceInfo.ToolTipReshowDelay = 100;
            this.hsInsertLoaclExperienceInfo.ToolTipShowAlways = false;
            this.hsInsertLoaclExperienceInfo.ToolTipText = "";
            this.hsInsertLoaclExperienceInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInsertLoaclExperienceInfo.ToolTipTitle = "";
            this.hsInsertLoaclExperienceInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInsertLoaclExperienceInfo.UseVisualStyleBackColor = false;
            this.hsInsertLoaclExperienceInfo.Click += new System.EventHandler(this.hsInsertLoaclExperienceInfo_Click);
            // 
            // flpLocalExperienceInfo
            // 
            this.flpLocalExperienceInfo.Controls.Add(this.gbLocalDatabase);
            this.flpLocalExperienceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpLocalExperienceInfo.Location = new System.Drawing.Point(3, 3);
            this.flpLocalExperienceInfo.Name = "flpLocalExperienceInfo";
            this.flpLocalExperienceInfo.Size = new System.Drawing.Size(1588, 54);
            this.flpLocalExperienceInfo.TabIndex = 46;
            // 
            // gbLocalDatabase
            // 
            this.gbLocalDatabase.Controls.Add(this.txtLocalDatabase);
            this.gbLocalDatabase.Controls.Add(this.hsLoadLocalDatabasePath);
            this.gbLocalDatabase.Location = new System.Drawing.Point(3, 3);
            this.gbLocalDatabase.Name = "gbLocalDatabase";
            this.gbLocalDatabase.Size = new System.Drawing.Size(606, 47);
            this.gbLocalDatabase.TabIndex = 30;
            this.gbLocalDatabase.TabStop = false;
            this.gbLocalDatabase.Text = "Info Local Database File";
            // 
            // txtLocalDatabase
            // 
            this.txtLocalDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocalDatabase.Location = new System.Drawing.Point(3, 16);
            this.txtLocalDatabase.Name = "txtLocalDatabase";
            this.txtLocalDatabase.Size = new System.Drawing.Size(555, 20);
            this.txtLocalDatabase.TabIndex = 1;
            // 
            // hsLoadLocalDatabasePath
            // 
            this.hsLoadLocalDatabasePath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadLocalDatabasePath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadLocalDatabasePath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadLocalDatabasePath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadLocalDatabasePath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadLocalDatabasePath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadLocalDatabasePath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadLocalDatabasePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadLocalDatabasePath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadLocalDatabasePath.FlatAppearance.BorderSize = 0;
            this.hsLoadLocalDatabasePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadLocalDatabasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadLocalDatabasePath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadLocalDatabasePath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadLocalDatabasePath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadLocalDatabasePath.ImageToggleOnSelect = true;
            this.hsLoadLocalDatabasePath.Location = new System.Drawing.Point(558, 16);
            this.hsLoadLocalDatabasePath.Marked = false;
            this.hsLoadLocalDatabasePath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadLocalDatabasePath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadLocalDatabasePath.MarkedText = "";
            this.hsLoadLocalDatabasePath.MarkMode = false;
            this.hsLoadLocalDatabasePath.Name = "hsLoadLocalDatabasePath";
            this.hsLoadLocalDatabasePath.NonMarkedText = "";
            this.hsLoadLocalDatabasePath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadLocalDatabasePath.ShowShortcut = false;
            this.hsLoadLocalDatabasePath.Size = new System.Drawing.Size(45, 28);
            this.hsLoadLocalDatabasePath.TabIndex = 3;
            this.hsLoadLocalDatabasePath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadLocalDatabasePath.ToolTipActive = false;
            this.hsLoadLocalDatabasePath.ToolTipAutomaticDelay = 500;
            this.hsLoadLocalDatabasePath.ToolTipAutoPopDelay = 5000;
            this.hsLoadLocalDatabasePath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadLocalDatabasePath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadLocalDatabasePath.ToolTipFor4ContextMenu = true;
            this.hsLoadLocalDatabasePath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadLocalDatabasePath.ToolTipInitialDelay = 500;
            this.hsLoadLocalDatabasePath.ToolTipIsBallon = false;
            this.hsLoadLocalDatabasePath.ToolTipOwnerDraw = false;
            this.hsLoadLocalDatabasePath.ToolTipReshowDelay = 100;
            this.hsLoadLocalDatabasePath.ToolTipShowAlways = false;
            this.hsLoadLocalDatabasePath.ToolTipText = "";
            this.hsLoadLocalDatabasePath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadLocalDatabasePath.ToolTipTitle = "";
            this.hsLoadLocalDatabasePath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadLocalDatabasePath.UseVisualStyleBackColor = false;
            this.hsLoadLocalDatabasePath.Click += new System.EventHandler(this.hsLoadLocalDatabasePath_Click);
            // 
            // dgvLocalExperienceInfo
            // 
            this.dgvLocalExperienceInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLocalExperienceInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalExperienceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalExperienceInfo.ContextMenuStrip = this.cmdExperienceInfo;
            this.dgvLocalExperienceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalExperienceInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvLocalExperienceInfo.Name = "dgvLocalExperienceInfo";
            this.dgvLocalExperienceInfo.RowHeadersVisible = false;
            this.dgvLocalExperienceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalExperienceInfo.Size = new System.Drawing.Size(1588, 615);
            this.dgvLocalExperienceInfo.TabIndex = 42;
            this.dgvLocalExperienceInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalExperienceInfo_CellMouseClick);
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
            // helpMain
            // 
            this.helpMain.HelpNamespace = "C:\\Projekte\\HerzogApp\\Help\\HerzogApp.chm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.db";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Database|*.db|All|*.*";
            // 
            // ExperienceInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(1604, 699);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_upper);
            this.helpMain.SetHelpKeyword(this, "Workflow Bestellung");
            this.helpMain.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpMain.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExperienceInfoForm";
            this.helpMain.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experience Infos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExperienceInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.ExperienceInfoForm_Load);
            this.Enter += new System.EventHandler(this.ExperienceInfoForm_Enter);
            this.pnl_upper.ResumeLayout(false);
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.tcSQLCONTROL.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienceInfo)).EndInit();
            this.cmdExperienceInfo.ResumeLayout(false);
            this.pnlExyperienceInfoUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctExperienceInfo)).EndInit();
            this.gbExperienceInfoKey.ResumeLayout(false);
            this.gbExperienceInfoKey.PerformLayout();
            this.flpExperienceInfoUpper.ResumeLayout(false);
            this.tabPageLocalExperience.ResumeLayout(false);
            this.pnlLocalExperienceInfoUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctLocalExperienceInfo)).EndInit();
            this.gbLocalExperienceInfoKey.ResumeLayout(false);
            this.gbLocalExperienceInfoKey.PerformLayout();
            this.flpLocalExperienceInfo.ResumeLayout(false);
            this.gbLocalDatabase.ResumeLayout(false);
            this.gbLocalDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalExperienceInfo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private TabControl tcSQLCONTROL;
        private HelpProvider helpMain;
        private SeControlsLib.HotSpot hsClose;
        private ImageList ilTabControl;
        private GroupBox gbDatabase;
        private TextBox txtDatabase;
        private SeControlsLib.HotSpot hsLoadDatabasePath;
        private TabPage tabPageInfo;
        private Panel pnlExyperienceInfoUpper;
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
        private OpenFileDialog openFileDialog1;
        private FastColoredTextBoxNS.FastColoredTextBox fctExperienceInfo;
        private TabPage tabPageLocalExperience;
        private DataGridView dgvLocalExperienceInfo;
        private FastColoredTextBoxNS.FastColoredTextBox fctLocalExperienceInfo;
        private GroupBox gbLocalExperienceInfoKey;
        private SeControlsLib.HotSpot hsUpdateLocalExperienceInfo;
        private SeControlsLib.HotSpot hsDeleteLocalData;
        private TextBox txtLocalExperienceKeyCode;
        private SeControlsLib.HotSpot hsClearLocalExperienceInfo;
        private SeControlsLib.HotSpot hsRefreshLocalExperienceInfo;
        private SeControlsLib.HotSpot hsInsertLoaclExperienceInfo;
        private Panel pnlLocalExperienceInfoUpper;
        private FlowLayoutPanel flpLocalExperienceInfo;
        private FlowLayoutPanel flpExperienceInfoUpper;
        private GroupBox gbLocalDatabase;
        private TextBox txtLocalDatabase;
        private SeControlsLib.HotSpot hsLoadLocalDatabasePath;
    }
}
