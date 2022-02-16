namespace FBXpert
{
    partial class DBUserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBUserManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormUpper = new System.Windows.Forms.Panel();
            this.gbTick = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTick = new System.Windows.Forms.TextBox();
            this.cbTick = new System.Windows.Forms.CheckBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMonitorConnections = new System.Windows.Forms.TabPage();
            this.gbSQLText = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsExecute = new SeControlsLib.HotSpot();
            this.dgvMonConnections = new System.Windows.Forms.DataGridView();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.dsMonConnections = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.gbUsersLeft = new System.Windows.Forms.GroupBox();
            this.txtOpenResult = new System.Windows.Forms.TextBox();
            this.pnlConnectState = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUserActive = new System.Windows.Forms.RadioButton();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.rbIsAdmin = new System.Windows.Forms.RadioButton();
            this.gbPlugin = new System.Windows.Forms.GroupBox();
            this.rbSrp = new System.Windows.Forms.RadioButton();
            this.rbLegacy = new System.Windows.Forms.RadioButton();
            this.gbLastName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.gbUserMiddleName = new System.Windows.Forms.GroupBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.gbFirstName = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbUserName = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlUsersUpper = new System.Windows.Forms.Panel();
            this.hsClearData = new SeControlsLib.HotSpot();
            this.hsUpdateUser = new SeControlsLib.HotSpot();
            this.hsDropUser = new SeControlsLib.HotSpot();
            this.hsAddUser = new SeControlsLib.HotSpot();
            this.cbRefreshActiveConnections = new System.Windows.Forms.CheckBox();
            this.hsRefreshDependenciesTo = new SeControlsLib.HotSpot();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlFormUpper.SuspendLayout();
            this.gbTick.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMonitorConnections.SuspendLayout();
            this.gbSQLText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.gbUsersLeft.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbPlugin.SuspendLayout();
            this.gbLastName.SuspendLayout();
            this.gbUserMiddleName.SuspendLayout();
            this.gbFirstName.SuspendLayout();
            this.gbUserName.SuspendLayout();
            this.pnlUsersUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormUpper
            // 
            this.pnlFormUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFormUpper.Controls.Add(this.gbTick);
            this.pnlFormUpper.Controls.Add(this.lblTableName);
            this.pnlFormUpper.Controls.Add(this.hsRefresh);
            this.pnlFormUpper.Controls.Add(this.hsClose);
            this.pnlFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUpper.Name = "pnlFormUpper";
            this.pnlFormUpper.Size = new System.Drawing.Size(1750, 45);
            this.pnlFormUpper.TabIndex = 2;
            // 
            // gbTick
            // 
            this.gbTick.Controls.Add(this.panel1);
            this.gbTick.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTick.ForeColor = System.Drawing.Color.Yellow;
            this.gbTick.Location = new System.Drawing.Point(1593, 0);
            this.gbTick.Name = "gbTick";
            this.gbTick.Size = new System.Drawing.Size(112, 45);
            this.gbTick.TabIndex = 3;
            this.gbTick.TabStop = false;
            this.gbTick.Text = "Refresh Intervall (s)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTick);
            this.panel1.Controls.Add(this.cbTick);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 22);
            this.panel1.TabIndex = 4;
            // 
            // txtTick
            // 
            this.txtTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTick.Location = new System.Drawing.Point(0, 0);
            this.txtTick.Name = "txtTick";
            this.txtTick.Size = new System.Drawing.Size(91, 20);
            this.txtTick.TabIndex = 0;
            this.txtTick.Text = "10";
            this.txtTick.TextChanged += new System.EventHandler(this.txtTick_TextChanged);
            // 
            // cbTick
            // 
            this.cbTick.AutoSize = true;
            this.cbTick.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbTick.Location = new System.Drawing.Point(91, 0);
            this.cbTick.Name = "cbTick";
            this.cbTick.Size = new System.Drawing.Size(15, 22);
            this.cbTick.TabIndex = 4;
            this.cbTick.UseVisualStyleBackColor = true;
            this.cbTick.CheckedChanged += new System.EventHandler(this.cbTick_CheckedChanged);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(175, 16);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(188, 20);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "DB-User-Management";
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
            this.hsRefresh.Location = new System.Drawing.Point(1705, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefresh.ShortcutNewline = false;
            this.hsRefresh.ShowShortcut = false;
            this.hsRefresh.Size = new System.Drawing.Size(45, 45);
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
            this.hsRefresh.Click += new System.EventHandler(this.hsRefresh_Click);
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
            this.hsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.hsClose.ShortcutNewline = false;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(45, 45);
            this.hsClose.TabIndex = 0;
            this.hsClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.pnlLower.Location = new System.Drawing.Point(0, 708);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(1750, 18);
            this.pnlLower.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlMain);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 45);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1750, 663);
            this.pnlCenter.TabIndex = 4;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMonitorConnections);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1750, 663);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMonitorConnections
            // 
            this.tabPageMonitorConnections.Controls.Add(this.gbSQLText);
            this.tabPageMonitorConnections.Controls.Add(this.dgvMonConnections);
            this.tabPageMonitorConnections.Controls.Add(this.gbUsersLeft);
            this.tabPageMonitorConnections.Controls.Add(this.pnlUsersUpper);
            this.tabPageMonitorConnections.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitorConnections.Name = "tabPageMonitorConnections";
            this.tabPageMonitorConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonitorConnections.Size = new System.Drawing.Size(1742, 637);
            this.tabPageMonitorConnections.TabIndex = 0;
            this.tabPageMonitorConnections.Text = "Monitor Connections";
            this.tabPageMonitorConnections.UseVisualStyleBackColor = true;
            // 
            // gbSQLText
            // 
            this.gbSQLText.Controls.Add(this.fctSQL);
            this.gbSQLText.Controls.Add(this.pnlSQLUpper);
            this.gbSQLText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQLText.Location = new System.Drawing.Point(1204, 52);
            this.gbSQLText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSQLText.Name = "gbSQLText";
            this.gbSQLText.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSQLText.Size = new System.Drawing.Size(535, 582);
            this.gbSQLText.TabIndex = 26;
            this.gbSQLText.TabStop = false;
            this.gbSQLText.Text = "SQL";
            // 
            // fctSQL
            // 
            this.fctSQL.AutoCompleteBracketsList = new char[] {
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
            this.fctSQL.AutoIndentCharsPatterns = "";
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.Color.Bisque;
            this.fctSQL.CharHeight = 14;
            this.fctSQL.CharWidth = 8;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(3, 62);
            this.fctSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(529, 516);
            this.fctSQL.TabIndex = 1;
            this.fctSQL.WordWrap = true;
            this.fctSQL.Zoom = 100;
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Controls.Add(this.hsExecute);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 17);
            this.pnlSQLUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(529, 45);
            this.pnlSQLUpper.TabIndex = 2;
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
            this.hsLoadSQL.Location = new System.Drawing.Point(160, 0);
            this.hsLoadSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.hsLoadSQL.Size = new System.Drawing.Size(96, 41);
            this.hsLoadSQL.TabIndex = 9;
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
            this.hsSaveSQL.Location = new System.Drawing.Point(67, 0);
            this.hsSaveSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.hsSaveSQL.Size = new System.Drawing.Size(93, 41);
            this.hsSaveSQL.TabIndex = 8;
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
            // 
            // hsExecute
            // 
            this.hsExecute.BackColor = System.Drawing.Color.Transparent;
            this.hsExecute.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExecute.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExecute.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExecute.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExecute.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExecute.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExecute.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsExecute.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExecute.FlatAppearance.BorderSize = 0;
            this.hsExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExecute.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExecute.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsExecute.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExecute.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsExecute.ImageToggleOnSelect = false;
            this.hsExecute.Location = new System.Drawing.Point(0, 0);
            this.hsExecute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsExecute.Marked = false;
            this.hsExecute.MarkedColor = System.Drawing.Color.Teal;
            this.hsExecute.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExecute.MarkedText = "";
            this.hsExecute.MarkMode = false;
            this.hsExecute.Name = "hsExecute";
            this.hsExecute.NonMarkedText = "Execute";
            this.hsExecute.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExecute.ShortcutNewline = false;
            this.hsExecute.ShowShortcut = false;
            this.hsExecute.Size = new System.Drawing.Size(67, 41);
            this.hsExecute.TabIndex = 1;
            this.hsExecute.Text = "Execute";
            this.hsExecute.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExecute.ToolTipActive = false;
            this.hsExecute.ToolTipAutomaticDelay = 500;
            this.hsExecute.ToolTipAutoPopDelay = 5000;
            this.hsExecute.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExecute.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExecute.ToolTipFor4ContextMenu = true;
            this.hsExecute.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExecute.ToolTipInitialDelay = 500;
            this.hsExecute.ToolTipIsBallon = false;
            this.hsExecute.ToolTipOwnerDraw = false;
            this.hsExecute.ToolTipReshowDelay = 100;
            this.hsExecute.ToolTipShowAlways = false;
            this.hsExecute.ToolTipText = "";
            this.hsExecute.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExecute.ToolTipTitle = "";
            this.hsExecute.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExecute.UseVisualStyleBackColor = false;
            this.hsExecute.Click += new System.EventHandler(this.hsSave_Click);
            // 
            // dgvMonConnections
            // 
            this.dgvMonConnections.AllowUserToAddRows = false;
            this.dgvMonConnections.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dgvMonConnections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonConnections.AutoGenerateColumns = false;
            this.dgvMonConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMonConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMonConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonConnections.DataSource = this.bsUsers;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonConnections.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonConnections.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMonConnections.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvMonConnections.EnableHeadersVisualStyles = false;
            this.dgvMonConnections.Location = new System.Drawing.Point(243, 52);
            this.dgvMonConnections.MultiSelect = false;
            this.dgvMonConnections.Name = "dgvMonConnections";
            this.dgvMonConnections.ReadOnly = true;
            this.dgvMonConnections.RowHeadersVisible = false;
            this.dgvMonConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonConnections.Size = new System.Drawing.Size(961, 582);
            this.dgvMonConnections.TabIndex = 24;
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = this.dsMonConnections;
            this.bsUsers.Position = 0;
            this.bsUsers.CurrentChanged += new System.EventHandler(this.bsMonConnections_CurrentChanged);
            // 
            // dsMonConnections
            // 
            this.dsMonConnections.DataSetName = "NewDataSet";
            this.dsMonConnections.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable5});
            // 
            // dataTable5
            // 
            this.dataTable5.TableName = "Table";
            // 
            // gbUsersLeft
            // 
            this.gbUsersLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.gbUsersLeft.Controls.Add(this.txtOpenResult);
            this.gbUsersLeft.Controls.Add(this.pnlConnectState);
            this.gbUsersLeft.Controls.Add(this.hotSpot1);
            this.gbUsersLeft.Controls.Add(this.gbPassword);
            this.gbUsersLeft.Controls.Add(this.groupBox1);
            this.gbUsersLeft.Controls.Add(this.gbAdmin);
            this.gbUsersLeft.Controls.Add(this.gbPlugin);
            this.gbUsersLeft.Controls.Add(this.gbLastName);
            this.gbUsersLeft.Controls.Add(this.gbUserMiddleName);
            this.gbUsersLeft.Controls.Add(this.gbFirstName);
            this.gbUsersLeft.Controls.Add(this.gbUserName);
            this.gbUsersLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbUsersLeft.Location = new System.Drawing.Point(3, 52);
            this.gbUsersLeft.Name = "gbUsersLeft";
            this.gbUsersLeft.Size = new System.Drawing.Size(240, 582);
            this.gbUsersLeft.TabIndex = 25;
            this.gbUsersLeft.TabStop = false;
            // 
            // txtOpenResult
            // 
            this.txtOpenResult.Location = new System.Drawing.Point(10, 327);
            this.txtOpenResult.Name = "txtOpenResult";
            this.txtOpenResult.Size = new System.Drawing.Size(220, 20);
            this.txtOpenResult.TabIndex = 10;
            // 
            // pnlConnectState
            // 
            this.pnlConnectState.Location = new System.Drawing.Point(78, 280);
            this.pnlConnectState.Name = "pnlConnectState";
            this.pnlConnectState.Size = new System.Drawing.Size(42, 41);
            this.pnlConnectState.TabIndex = 10;
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
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.database_logon_x24;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.database_logon2_x24;
            this.hotSpot1.ImageToggleOnSelect = false;
            this.hotSpot1.Location = new System.Drawing.Point(10, 280);
            this.hotSpot1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Execute";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShortcutNewline = false;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(67, 49);
            this.hotSpot1.TabIndex = 9;
            this.hotSpot1.Text = "Test";
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
            this.hotSpot1.Click += new System.EventHandler(this.hotSpot1_Click_1);
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Location = new System.Drawing.Point(7, 216);
            this.gbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPassword.Size = new System.Drawing.Size(226, 42);
            this.gbPassword.TabIndex = 8;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(3, 17);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUserActive);
            this.groupBox1.Location = new System.Drawing.Point(9, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 35);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbUserActive
            // 
            this.rbUserActive.AutoSize = true;
            this.rbUserActive.Location = new System.Drawing.Point(6, 12);
            this.rbUserActive.Name = "rbUserActive";
            this.rbUserActive.Size = new System.Drawing.Size(55, 17);
            this.rbUserActive.TabIndex = 6;
            this.rbUserActive.Text = "Aktive";
            this.rbUserActive.UseVisualStyleBackColor = true;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.rbIsAdmin);
            this.gbAdmin.Location = new System.Drawing.Point(9, 501);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(129, 35);
            this.gbAdmin.TabIndex = 6;
            this.gbAdmin.TabStop = false;
            // 
            // rbIsAdmin
            // 
            this.rbIsAdmin.AutoSize = true;
            this.rbIsAdmin.Location = new System.Drawing.Point(6, 9);
            this.rbIsAdmin.Name = "rbIsAdmin";
            this.rbIsAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbIsAdmin.TabIndex = 8;
            this.rbIsAdmin.Text = "Admin";
            this.rbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbPlugin
            // 
            this.gbPlugin.Controls.Add(this.rbSrp);
            this.gbPlugin.Controls.Add(this.rbLegacy);
            this.gbPlugin.Location = new System.Drawing.Point(9, 364);
            this.gbPlugin.Name = "gbPlugin";
            this.gbPlugin.Size = new System.Drawing.Size(216, 79);
            this.gbPlugin.TabIndex = 6;
            this.gbPlugin.TabStop = false;
            this.gbPlugin.Text = "Plugin";
            // 
            // rbSrp
            // 
            this.rbSrp.AutoSize = true;
            this.rbSrp.Checked = true;
            this.rbSrp.Location = new System.Drawing.Point(6, 54);
            this.rbSrp.Name = "rbSrp";
            this.rbSrp.Size = new System.Drawing.Size(41, 17);
            this.rbSrp.TabIndex = 7;
            this.rbSrp.TabStop = true;
            this.rbSrp.Text = "Srp";
            this.rbSrp.UseVisualStyleBackColor = true;
            // 
            // rbLegacy
            // 
            this.rbLegacy.AutoSize = true;
            this.rbLegacy.Location = new System.Drawing.Point(6, 20);
            this.rbLegacy.Name = "rbLegacy";
            this.rbLegacy.Size = new System.Drawing.Size(105, 17);
            this.rbLegacy.TabIndex = 6;
            this.rbLegacy.Text = "Legacy Manager";
            this.rbLegacy.UseVisualStyleBackColor = true;
            // 
            // gbLastName
            // 
            this.gbLastName.Controls.Add(this.txtLastName);
            this.gbLastName.Location = new System.Drawing.Point(7, 162);
            this.gbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLastName.Name = "gbLastName";
            this.gbLastName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLastName.Size = new System.Drawing.Size(226, 42);
            this.gbLastName.TabIndex = 4;
            this.gbLastName.TabStop = false;
            this.gbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(3, 17);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(220, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // gbUserMiddleName
            // 
            this.gbUserMiddleName.Controls.Add(this.txtMiddleName);
            this.gbUserMiddleName.Location = new System.Drawing.Point(6, 108);
            this.gbUserMiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUserMiddleName.Name = "gbUserMiddleName";
            this.gbUserMiddleName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUserMiddleName.Size = new System.Drawing.Size(226, 42);
            this.gbUserMiddleName.TabIndex = 3;
            this.gbUserMiddleName.TabStop = false;
            this.gbUserMiddleName.Text = "Middle Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMiddleName.Location = new System.Drawing.Point(3, 17);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(220, 20);
            this.txtMiddleName.TabIndex = 0;
            // 
            // gbFirstName
            // 
            this.gbFirstName.Controls.Add(this.txtFirstName);
            this.gbFirstName.Location = new System.Drawing.Point(6, 59);
            this.gbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFirstName.Name = "gbFirstName";
            this.gbFirstName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFirstName.Size = new System.Drawing.Size(226, 42);
            this.gbFirstName.TabIndex = 2;
            this.gbFirstName.TabStop = false;
            this.gbFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(3, 17);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // gbUserName
            // 
            this.gbUserName.Controls.Add(this.txtUserName);
            this.gbUserName.Location = new System.Drawing.Point(6, 12);
            this.gbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUserName.Name = "gbUserName";
            this.gbUserName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUserName.Size = new System.Drawing.Size(226, 42);
            this.gbUserName.TabIndex = 1;
            this.gbUserName.TabStop = false;
            this.gbUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(3, 17);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(220, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // pnlUsersUpper
            // 
            this.pnlUsersUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUsersUpper.Controls.Add(this.hsClearData);
            this.pnlUsersUpper.Controls.Add(this.hsUpdateUser);
            this.pnlUsersUpper.Controls.Add(this.hsDropUser);
            this.pnlUsersUpper.Controls.Add(this.hsAddUser);
            this.pnlUsersUpper.Controls.Add(this.cbRefreshActiveConnections);
            this.pnlUsersUpper.Controls.Add(this.hsRefreshDependenciesTo);
            this.pnlUsersUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsersUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlUsersUpper.Name = "pnlUsersUpper";
            this.pnlUsersUpper.Size = new System.Drawing.Size(1736, 49);
            this.pnlUsersUpper.TabIndex = 23;
            // 
            // hsClearData
            // 
            this.hsClearData.BackColor = System.Drawing.Color.Transparent;
            this.hsClearData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearData.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearData.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearData.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearData.FlatAppearance.BorderSize = 0;
            this.hsClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearData.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearData.Image = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hsClearData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearData.ImageHover = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearData.ImageToggleOnSelect = false;
            this.hsClearData.Location = new System.Drawing.Point(213, 0);
            this.hsClearData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsClearData.Marked = false;
            this.hsClearData.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearData.MarkedText = "";
            this.hsClearData.MarkMode = false;
            this.hsClearData.Name = "hsClearData";
            this.hsClearData.NonMarkedText = "Execute";
            this.hsClearData.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearData.ShortcutNewline = false;
            this.hsClearData.ShowShortcut = false;
            this.hsClearData.Size = new System.Drawing.Size(79, 49);
            this.hsClearData.TabIndex = 9;
            this.hsClearData.Text = "Clear Data";
            this.hsClearData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearData.ToolTipActive = false;
            this.hsClearData.ToolTipAutomaticDelay = 500;
            this.hsClearData.ToolTipAutoPopDelay = 5000;
            this.hsClearData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearData.ToolTipFor4ContextMenu = true;
            this.hsClearData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearData.ToolTipInitialDelay = 500;
            this.hsClearData.ToolTipIsBallon = false;
            this.hsClearData.ToolTipOwnerDraw = false;
            this.hsClearData.ToolTipReshowDelay = 100;
            this.hsClearData.ToolTipShowAlways = false;
            this.hsClearData.ToolTipText = "";
            this.hsClearData.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearData.ToolTipTitle = "";
            this.hsClearData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearData.UseVisualStyleBackColor = false;
            this.hsClearData.Click += new System.EventHandler(this.hsClearData_Click);
            // 
            // hsUpdateUser
            // 
            this.hsUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.hsUpdateUser.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateUser.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateUser.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUpdateUser.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUpdateUser.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUpdateUser.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUpdateUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsUpdateUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsUpdateUser.FlatAppearance.BorderSize = 0;
            this.hsUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsUpdateUser.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUpdateUser.Image = global::FBXpert.Properties.Resources.ok_gn32x;
            this.hsUpdateUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUpdateUser.ImageHover = global::FBXpert.Properties.Resources.ok_blue32x;
            this.hsUpdateUser.ImageToggleOnSelect = false;
            this.hsUpdateUser.Location = new System.Drawing.Point(134, 0);
            this.hsUpdateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsUpdateUser.Marked = false;
            this.hsUpdateUser.MarkedColor = System.Drawing.Color.Teal;
            this.hsUpdateUser.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUpdateUser.MarkedText = "";
            this.hsUpdateUser.MarkMode = false;
            this.hsUpdateUser.Name = "hsUpdateUser";
            this.hsUpdateUser.NonMarkedText = "Execute";
            this.hsUpdateUser.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUpdateUser.ShortcutNewline = false;
            this.hsUpdateUser.ShowShortcut = false;
            this.hsUpdateUser.Size = new System.Drawing.Size(79, 49);
            this.hsUpdateUser.TabIndex = 8;
            this.hsUpdateUser.Text = "Update User";
            this.hsUpdateUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUpdateUser.ToolTipActive = false;
            this.hsUpdateUser.ToolTipAutomaticDelay = 500;
            this.hsUpdateUser.ToolTipAutoPopDelay = 5000;
            this.hsUpdateUser.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUpdateUser.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUpdateUser.ToolTipFor4ContextMenu = true;
            this.hsUpdateUser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUpdateUser.ToolTipInitialDelay = 500;
            this.hsUpdateUser.ToolTipIsBallon = false;
            this.hsUpdateUser.ToolTipOwnerDraw = false;
            this.hsUpdateUser.ToolTipReshowDelay = 100;
            this.hsUpdateUser.ToolTipShowAlways = false;
            this.hsUpdateUser.ToolTipText = "";
            this.hsUpdateUser.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUpdateUser.ToolTipTitle = "";
            this.hsUpdateUser.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUpdateUser.UseVisualStyleBackColor = false;
            this.hsUpdateUser.Click += new System.EventHandler(this.hsUpdateUser_Click);
            // 
            // hsDropUser
            // 
            this.hsDropUser.BackColor = System.Drawing.Color.Transparent;
            this.hsDropUser.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDropUser.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDropUser.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDropUser.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDropUser.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDropUser.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDropUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsDropUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDropUser.FlatAppearance.BorderSize = 0;
            this.hsDropUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDropUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDropUser.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDropUser.Image = global::FBXpert.Properties.Resources.minus_blau32x;
            this.hsDropUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDropUser.ImageHover = global::FBXpert.Properties.Resources.minus_gn32x;
            this.hsDropUser.ImageToggleOnSelect = false;
            this.hsDropUser.Location = new System.Drawing.Point(67, 0);
            this.hsDropUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsDropUser.Marked = false;
            this.hsDropUser.MarkedColor = System.Drawing.Color.Teal;
            this.hsDropUser.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDropUser.MarkedText = "";
            this.hsDropUser.MarkMode = false;
            this.hsDropUser.Name = "hsDropUser";
            this.hsDropUser.NonMarkedText = "Execute";
            this.hsDropUser.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDropUser.ShortcutNewline = false;
            this.hsDropUser.ShowShortcut = false;
            this.hsDropUser.Size = new System.Drawing.Size(67, 49);
            this.hsDropUser.TabIndex = 7;
            this.hsDropUser.Text = "Drop User";
            this.hsDropUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDropUser.ToolTipActive = false;
            this.hsDropUser.ToolTipAutomaticDelay = 500;
            this.hsDropUser.ToolTipAutoPopDelay = 5000;
            this.hsDropUser.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDropUser.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDropUser.ToolTipFor4ContextMenu = true;
            this.hsDropUser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDropUser.ToolTipInitialDelay = 500;
            this.hsDropUser.ToolTipIsBallon = false;
            this.hsDropUser.ToolTipOwnerDraw = false;
            this.hsDropUser.ToolTipReshowDelay = 100;
            this.hsDropUser.ToolTipShowAlways = false;
            this.hsDropUser.ToolTipText = "";
            this.hsDropUser.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDropUser.ToolTipTitle = "";
            this.hsDropUser.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDropUser.UseVisualStyleBackColor = false;
            this.hsDropUser.Click += new System.EventHandler(this.hsDropUser_Click);
            // 
            // hsAddUser
            // 
            this.hsAddUser.BackColor = System.Drawing.Color.Transparent;
            this.hsAddUser.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddUser.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddUser.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddUser.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddUser.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddUser.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsAddUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddUser.FlatAppearance.BorderSize = 0;
            this.hsAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddUser.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddUser.Image = global::FBXpert.Properties.Resources.plus_gn32x;
            this.hsAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsAddUser.ImageHover = global::FBXpert.Properties.Resources.plus_blue32x;
            this.hsAddUser.ImageToggleOnSelect = false;
            this.hsAddUser.Location = new System.Drawing.Point(0, 0);
            this.hsAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsAddUser.Marked = false;
            this.hsAddUser.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddUser.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddUser.MarkedText = "";
            this.hsAddUser.MarkMode = false;
            this.hsAddUser.Name = "hsAddUser";
            this.hsAddUser.NonMarkedText = "Execute";
            this.hsAddUser.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddUser.ShortcutNewline = false;
            this.hsAddUser.ShowShortcut = false;
            this.hsAddUser.Size = new System.Drawing.Size(67, 49);
            this.hsAddUser.TabIndex = 6;
            this.hsAddUser.Text = "Add User";
            this.hsAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddUser.ToolTipActive = false;
            this.hsAddUser.ToolTipAutomaticDelay = 500;
            this.hsAddUser.ToolTipAutoPopDelay = 5000;
            this.hsAddUser.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddUser.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddUser.ToolTipFor4ContextMenu = true;
            this.hsAddUser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddUser.ToolTipInitialDelay = 500;
            this.hsAddUser.ToolTipIsBallon = false;
            this.hsAddUser.ToolTipOwnerDraw = false;
            this.hsAddUser.ToolTipReshowDelay = 100;
            this.hsAddUser.ToolTipShowAlways = false;
            this.hsAddUser.ToolTipText = "";
            this.hsAddUser.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddUser.ToolTipTitle = "";
            this.hsAddUser.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddUser.UseVisualStyleBackColor = false;
            this.hsAddUser.Click += new System.EventHandler(this.hsAddUser_Click);
            // 
            // cbRefreshActiveConnections
            // 
            this.cbRefreshActiveConnections.AutoSize = true;
            this.cbRefreshActiveConnections.Checked = true;
            this.cbRefreshActiveConnections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefreshActiveConnections.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbRefreshActiveConnections.Location = new System.Drawing.Point(1603, 0);
            this.cbRefreshActiveConnections.Name = "cbRefreshActiveConnections";
            this.cbRefreshActiveConnections.Size = new System.Drawing.Size(88, 49);
            this.cbRefreshActiveConnections.TabIndex = 5;
            this.cbRefreshActiveConnections.Text = "Auto Refresh";
            this.cbRefreshActiveConnections.UseVisualStyleBackColor = true;
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
            this.hsRefreshDependenciesTo.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependenciesTo.ImageToggleOnSelect = true;
            this.hsRefreshDependenciesTo.Location = new System.Drawing.Point(1691, 0);
            this.hsRefreshDependenciesTo.Marked = false;
            this.hsRefreshDependenciesTo.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependenciesTo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependenciesTo.MarkedText = "";
            this.hsRefreshDependenciesTo.MarkMode = false;
            this.hsRefreshDependenciesTo.Name = "hsRefreshDependenciesTo";
            this.hsRefreshDependenciesTo.NonMarkedText = "";
            this.hsRefreshDependenciesTo.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshDependenciesTo.ShortcutNewline = false;
            this.hsRefreshDependenciesTo.ShowShortcut = false;
            this.hsRefreshDependenciesTo.Size = new System.Drawing.Size(45, 49);
            this.hsRefreshDependenciesTo.TabIndex = 2;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DBUserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 726);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlFormUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBUserManagementForm";
            this.Text = "DBUserManagementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBUserManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.DBUserManagementForm_Load);
            this.pnlFormUpper.ResumeLayout(false);
            this.pnlFormUpper.PerformLayout();
            this.gbTick.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMonitorConnections.ResumeLayout(false);
            this.gbSQLText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.gbUsersLeft.ResumeLayout(false);
            this.gbUsersLeft.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbPlugin.ResumeLayout(false);
            this.gbPlugin.PerformLayout();
            this.gbLastName.ResumeLayout(false);
            this.gbLastName.PerformLayout();
            this.gbUserMiddleName.ResumeLayout(false);
            this.gbUserMiddleName.PerformLayout();
            this.gbFirstName.ResumeLayout(false);
            this.gbFirstName.PerformLayout();
            this.gbUserName.ResumeLayout(false);
            this.gbUserName.PerformLayout();
            this.pnlUsersUpper.ResumeLayout(false);
            this.pnlUsersUpper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormUpper;
        private System.Windows.Forms.Label lblTableName;
        private SeControlsLib.HotSpot hsRefresh;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMonitorConnections;
        private System.Windows.Forms.DataGridView dgvMonConnections;
        private System.Windows.Forms.BindingSource bsUsers;
        private System.Data.DataSet dsMonConnections;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Panel pnlUsersUpper;
        private SeControlsLib.HotSpot hsRefreshDependenciesTo;
        private System.Windows.Forms.GroupBox gbTick;
        private System.Windows.Forms.CheckBox cbTick;
        private System.Windows.Forms.TextBox txtTick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbRefreshActiveConnections;
        private System.Windows.Forms.GroupBox gbUsersLeft;
        private System.Windows.Forms.GroupBox gbFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox gbLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox gbUserMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.GroupBox gbPlugin;
        private System.Windows.Forms.RadioButton rbSrp;
        private System.Windows.Forms.RadioButton rbLegacy;
        private System.Windows.Forms.RadioButton rbIsAdmin;
        private System.Windows.Forms.RadioButton rbUserActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.GroupBox gbSQLText;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private SeControlsLib.HotSpot hsExecute;
        private SeControlsLib.HotSpot hsAddUser;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private SeControlsLib.HotSpot hsDropUser;
        private SeControlsLib.HotSpot hsUpdateUser;
        private SeControlsLib.HotSpot hsClearData;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.Panel pnlConnectState;
        private System.Windows.Forms.TextBox txtOpenResult;
        private System.Windows.Forms.Panel panel1;
    }
}