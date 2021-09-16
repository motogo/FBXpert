using BasicForms;
using System.ComponentModel;
using System.Windows.Forms;

namespace SQLView
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
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
        /// Erforderliche Methode zur Unterstützung des Designers -
        /// ändern Sie die Methode nicht mit dem Quelltext-Editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperienceInfoForm));
            this.pnl_upper = new System.Windows.Forms.Panel();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.hsLoadDatabasePath = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.tcSQLCONTROL = new System.Windows.Forms.TabControl();
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
            this.helpMain = new System.Windows.Forms.HelpProvider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_upper.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.tcSQLCONTROL.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienceInfo)).BeginInit();
            this.cmdExperienceInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExperienceInfo)).BeginInit();
            this.gbExperienceInfoKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_upper
            // 
            this.pnl_upper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_upper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_upper.Controls.Add(this.gbDatabase);
            this.pnl_upper.Controls.Add(this.hsClose);
            this.pnl_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_upper.Location = new System.Drawing.Point(0, 0);
            this.pnl_upper.Name = "pnl_upper";
            this.pnl_upper.Size = new System.Drawing.Size(1604, 49);
            this.pnl_upper.TabIndex = 0;
            // 
            // gbDatabase
            // 
            this.gbDatabase.Controls.Add(this.txtDatabase);
            this.gbDatabase.Controls.Add(this.hsLoadDatabasePath);
            this.gbDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDatabase.Location = new System.Drawing.Point(45, 0);
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
            this.txtExperienceInfo.TabIndex = 41;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLViewForm_FormClosing);
            this.Load += new System.EventHandler(this.SQLViewForm_Load);
            this.Enter += new System.EventHandler(this.ExperienceInfoForm_Enter);
            this.pnl_upper.ResumeLayout(false);
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.tcSQLCONTROL.ResumeLayout(false);
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
        private TabControl tcSQLCONTROL;
        private HelpProvider helpMain;
        private SeControlsLib.HotSpot hsClose;
        private ImageList ilTabControl;
        private GroupBox gbDatabase;
        private TextBox txtDatabase;
        private SeControlsLib.HotSpot hsLoadDatabasePath;
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
        private OpenFileDialog openFileDialog1;
        private FastColoredTextBoxNS.FastColoredTextBox txtExperienceInfo;
    }
}
