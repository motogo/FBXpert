namespace FBXpert
{
    partial class DBMonitoringForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBMonitoringForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.gbTick = new System.Windows.Forms.GroupBox();
            this.txtTick = new System.Windows.Forms.TextBox();
            this.cbTick = new System.Windows.Forms.CheckBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMonitorConnections = new System.Windows.Forms.TabPage();
            this.dgvMonConnections = new System.Windows.Forms.DataGridView();
            this.bsMonConnections = new System.Windows.Forms.BindingSource(this.components);
            this.dsMonConnections = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hsCloseConnection = new SeControlsLib.HotSpot();
            this.cbAllConnections = new System.Windows.Forms.CheckBox();
            this.cbRefreshActiveConnections = new System.Windows.Forms.CheckBox();
            this.hsRefreshDependenciesTo = new SeControlsLib.HotSpot();
            this.tabPageConnections = new System.Windows.Forms.TabPage();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.colCONNECTIONNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOPEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlUpper.SuspendLayout();
            this.gbTick.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMonitorConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageConnections.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.gbTick);
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(765, 44);
            this.pnlUpper.TabIndex = 2;
            // 
            // gbTick
            // 
            this.gbTick.Controls.Add(this.txtTick);
            this.gbTick.Controls.Add(this.cbTick);
            this.gbTick.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTick.ForeColor = System.Drawing.Color.Yellow;
            this.gbTick.Location = new System.Drawing.Point(608, 0);
            this.gbTick.Name = "gbTick";
            this.gbTick.Size = new System.Drawing.Size(112, 44);
            this.gbTick.TabIndex = 3;
            this.gbTick.TabStop = false;
            this.gbTick.Text = "Refresh Intervall (s)";
            // 
            // txtTick
            // 
            this.txtTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTick.Location = new System.Drawing.Point(3, 16);
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
            this.cbTick.Location = new System.Drawing.Point(94, 16);
            this.cbTick.Name = "cbTick";
            this.cbTick.Size = new System.Drawing.Size(15, 25);
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
            this.lblTableName.Size = new System.Drawing.Size(124, 20);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "DB-Monitoring";
            // 
            // hsRefresh
            // 
            this.hsRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsRefresh.BackColorHover = System.Drawing.Color.Transparent;
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
            this.hsRefresh.Location = new System.Drawing.Point(720, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            
            this.hsRefresh.Size = new System.Drawing.Size(45, 44);
            this.hsRefresh.TabIndex = 1;
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
            
            this.hsClose.Size = new System.Drawing.Size(45, 44);
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
            this.pnlLower.Location = new System.Drawing.Point(0, 441);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(765, 18);
            this.pnlLower.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlMain);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 44);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(765, 397);
            this.pnlCenter.TabIndex = 4;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMonitorConnections);
            this.tabControlMain.Controls.Add(this.tabPageConnections);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(765, 397);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMonitorConnections
            // 
            this.tabPageMonitorConnections.Controls.Add(this.dgvMonConnections);
            this.tabPageMonitorConnections.Controls.Add(this.panel1);
            this.tabPageMonitorConnections.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitorConnections.Name = "tabPageMonitorConnections";
            this.tabPageMonitorConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonitorConnections.Size = new System.Drawing.Size(757, 371);
            this.tabPageMonitorConnections.TabIndex = 0;
            this.tabPageMonitorConnections.Text = "Monitor Connections";
            this.tabPageMonitorConnections.UseVisualStyleBackColor = true;
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
            this.dgvMonConnections.DataSource = this.bsMonConnections;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonConnections.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonConnections.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvMonConnections.EnableHeadersVisualStyles = false;
            this.dgvMonConnections.Location = new System.Drawing.Point(3, 34);
            this.dgvMonConnections.MultiSelect = false;
            this.dgvMonConnections.Name = "dgvMonConnections";
            this.dgvMonConnections.ReadOnly = true;
            this.dgvMonConnections.RowHeadersVisible = false;
            this.dgvMonConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMonConnections.Size = new System.Drawing.Size(751, 334);
            this.dgvMonConnections.TabIndex = 24;
            // 
            // bsMonConnections
            // 
            this.bsMonConnections.DataSource = this.dsMonConnections;
            this.bsMonConnections.Position = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.hsCloseConnection);
            this.panel1.Controls.Add(this.cbAllConnections);
            this.panel1.Controls.Add(this.cbRefreshActiveConnections);
            this.panel1.Controls.Add(this.hsRefreshDependenciesTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 31);
            this.panel1.TabIndex = 23;
            // 
            // hsCloseConnection
            // 
            this.hsCloseConnection.BackColor = System.Drawing.Color.Transparent;
            this.hsCloseConnection.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCloseConnection.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCloseConnection.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCloseConnection.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCloseConnection.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCloseConnection.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCloseConnection.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCloseConnection.FlatAppearance.BorderSize = 0;
            this.hsCloseConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCloseConnection.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCloseConnection.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.hsCloseConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsCloseConnection.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsCloseConnection.ImageToggleOnSelect = true;
            this.hsCloseConnection.Location = new System.Drawing.Point(0, 0);
            this.hsCloseConnection.Marked = false;
            this.hsCloseConnection.MarkedColor = System.Drawing.Color.Teal;
            this.hsCloseConnection.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCloseConnection.MarkedText = "";
            this.hsCloseConnection.MarkMode = false;
            this.hsCloseConnection.Name = "hsCloseConnection";
            this.hsCloseConnection.NonMarkedText = "Close all Connections";
            
            this.hsCloseConnection.Size = new System.Drawing.Size(150, 31);
            this.hsCloseConnection.TabIndex = 7;
            this.hsCloseConnection.Text = "Close all Connections";
            this.hsCloseConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsCloseConnection.ToolTipActive = false;
            this.hsCloseConnection.ToolTipAutomaticDelay = 500;
            this.hsCloseConnection.ToolTipAutoPopDelay = 5000;
            this.hsCloseConnection.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCloseConnection.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCloseConnection.ToolTipFor4ContextMenu = true;
            this.hsCloseConnection.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCloseConnection.ToolTipInitialDelay = 500;
            this.hsCloseConnection.ToolTipIsBallon = false;
            this.hsCloseConnection.ToolTipOwnerDraw = false;
            this.hsCloseConnection.ToolTipReshowDelay = 100;
            
            this.hsCloseConnection.ToolTipShowAlways = false;
            this.hsCloseConnection.ToolTipText = "";
            this.hsCloseConnection.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCloseConnection.ToolTipTitle = "";
            this.hsCloseConnection.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCloseConnection.UseVisualStyleBackColor = false;
            this.hsCloseConnection.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // cbAllConnections
            // 
            this.cbAllConnections.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbAllConnections.Location = new System.Drawing.Point(499, 0);
            this.cbAllConnections.Name = "cbAllConnections";
            this.cbAllConnections.Size = new System.Drawing.Size(119, 31);
            this.cbAllConnections.TabIndex = 6;
            this.cbAllConnections.Text = "All connections";
            this.cbAllConnections.UseVisualStyleBackColor = true;
            this.cbAllConnections.CheckedChanged += new System.EventHandler(this.cbAllConnections_CheckedChanged);
            // 
            // cbRefreshActiveConnections
            // 
            this.cbRefreshActiveConnections.AutoSize = true;
            this.cbRefreshActiveConnections.Checked = true;
            this.cbRefreshActiveConnections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefreshActiveConnections.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbRefreshActiveConnections.Location = new System.Drawing.Point(618, 0);
            this.cbRefreshActiveConnections.Name = "cbRefreshActiveConnections";
            this.cbRefreshActiveConnections.Size = new System.Drawing.Size(88, 31);
            this.cbRefreshActiveConnections.TabIndex = 5;
            this.cbRefreshActiveConnections.Text = "Auto Refresh";
            this.cbRefreshActiveConnections.UseVisualStyleBackColor = true;
            // 
            // hsRefreshDependenciesTo
            // 
            this.hsRefreshDependenciesTo.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDependenciesTo.BackColorHover = System.Drawing.Color.Transparent;
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
            this.hsRefreshDependenciesTo.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependenciesTo.ImageToggleOnSelect = true;
            this.hsRefreshDependenciesTo.Location = new System.Drawing.Point(706, 0);
            this.hsRefreshDependenciesTo.Marked = false;
            this.hsRefreshDependenciesTo.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependenciesTo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependenciesTo.MarkedText = "";
            this.hsRefreshDependenciesTo.MarkMode = false;
            this.hsRefreshDependenciesTo.Name = "hsRefreshDependenciesTo";
            this.hsRefreshDependenciesTo.NonMarkedText = "";
            
            this.hsRefreshDependenciesTo.Size = new System.Drawing.Size(45, 31);
            this.hsRefreshDependenciesTo.TabIndex = 2;
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
            // tabPageConnections
            // 
            this.tabPageConnections.Controls.Add(this.lvConnections);
            this.tabPageConnections.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnections.Name = "tabPageConnections";
            this.tabPageConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnections.Size = new System.Drawing.Size(757, 371);
            this.tabPageConnections.TabIndex = 1;
            this.tabPageConnections.Text = "Connections";
            this.tabPageConnections.UseVisualStyleBackColor = true;
            // 
            // lvConnections
            // 
            this.lvConnections.AllowColumnReorder = true;
            this.lvConnections.AutoArrange = false;
            this.lvConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCONNECTIONNAME,
            this.colOPEN,
            this.colTYPE});
            this.lvConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConnections.FullRowSelect = true;
            this.lvConnections.GridLines = true;
            this.lvConnections.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvConnections.Location = new System.Drawing.Point(3, 3);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(751, 365);
            this.lvConnections.TabIndex = 1;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // colCONNECTIONNAME
            // 
            this.colCONNECTIONNAME.Text = "ConnectionName";
            this.colCONNECTIONNAME.Width = 300;
            // 
            // colOPEN
            // 
            this.colOPEN.Text = "Open";
            this.colOPEN.Width = 100;
            // 
            // colTYPE
            // 
            this.colTYPE.Text = "FieldType";
            this.colTYPE.Width = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DBMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 459);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBMonitoringForm";
            this.Text = "DBMonitoringForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBMonitoringForm_FormClosing);
            this.Load += new System.EventHandler(this.DBMonitoringForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.gbTick.ResumeLayout(false);
            this.gbTick.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMonitorConnections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageConnections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Label lblTableName;
        private SeControlsLib.HotSpot hsRefresh;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMonitorConnections;
        private System.Windows.Forms.TabPage tabPageConnections;
        private System.Windows.Forms.DataGridView dgvMonConnections;
        private System.Windows.Forms.BindingSource bsMonConnections;
        private System.Data.DataSet dsMonConnections;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Panel panel1;
        private SeControlsLib.HotSpot hsRefreshDependenciesTo;
        private System.Windows.Forms.GroupBox gbTick;
        private System.Windows.Forms.CheckBox cbTick;
        private System.Windows.Forms.TextBox txtTick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbRefreshActiveConnections;
        private System.Windows.Forms.CheckBox cbAllConnections;
        private SeControlsLib.HotSpot hsCloseConnection;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader colCONNECTIONNAME;
        private System.Windows.Forms.ColumnHeader colOPEN;
        private System.Windows.Forms.ColumnHeader colTYPE;
    }
}