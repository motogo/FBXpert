using BasicForms;

namespace FBXpert
{
    partial class ReplicationDesignForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplicationDesignForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.tabPageDependencies = new System.Windows.Forms.TabPage();
            this.dgvDependenciesTo = new System.Windows.Forms.DataGridView();
            this.bsDependenciesTo = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependenciesTo = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.pnlDependenciesUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hotSpot3 = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.dsDependenciesFrom = new System.Data.DataSet();
            this.dataTable6 = new System.Data.DataTable();
            this.bsDependenciesFrom = new System.Windows.Forms.BindingSource(this.components);
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageDependencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.pnlDependenciesUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessagesUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1119, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(83, 10);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 4;
            this.lblTableName.Text = "Tablename";
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
            this.hsClose.Size = new System.Drawing.Size(45, 42);
            this.hsClose.TabIndex = 1;
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
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1119, 546);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPageFieldEdit);
            this.tabControlFields.Controls.Add(this.tabPageDependencies);
            this.tabControlFields.Controls.Add(this.tabPageMessages);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.ImageList = this.ilTabControl;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1119, 546);
            this.tabControlFields.TabIndex = 18;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldUpper);
            this.tabPageFieldEdit.ImageIndex = 8;
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 23);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1111, 519);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.groupBox1);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 35);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1105, 481);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fctSQL);
            this.groupBox1.Location = new System.Drawing.Point(457, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 361);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL";
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(395, 112);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fctSQL.CharHeight = 14;
            this.fctSQL.CharWidth = 8;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(3, 16);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(616, 342);
            this.fctSQL.TabIndex = 1;
            this.fctSQL.Text = resources.GetString("fctSQL.Text");
            this.fctSQL.Zoom = 100;
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFieldUpper.Controls.Add(this.hotSpot2);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1105, 32);
            this.pnlFieldUpper.TabIndex = 1;
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
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.applications_system;
            this.hotSpot2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_32x;
            this.hotSpot2.ImageToggleOnSelect = true;
            this.hotSpot2.Location = new System.Drawing.Point(0, 0);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "Execute";
            this.hotSpot2.Size = new System.Drawing.Size(93, 32);
            this.hotSpot2.TabIndex = 1;
            this.hotSpot2.Text = "Execute";
            this.hotSpot2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.hotSpot2.Click += new System.EventHandler(this.hotSpot2_Click);
            // 
            // tabPageDependencies
            // 
            this.tabPageDependencies.Controls.Add(this.dgvDependenciesTo);
            this.tabPageDependencies.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageDependencies.ImageIndex = 16;
            this.tabPageDependencies.Location = new System.Drawing.Point(4, 23);
            this.tabPageDependencies.Name = "tabPageDependencies";
            this.tabPageDependencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependencies.Size = new System.Drawing.Size(1111, 519);
            this.tabPageDependencies.TabIndex = 1;
            this.tabPageDependencies.Text = "Dependencies";
            this.tabPageDependencies.UseVisualStyleBackColor = true;
            // 
            // dgvDependenciesTo
            // 
            this.dgvDependenciesTo.AllowUserToAddRows = false;
            this.dgvDependenciesTo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dgvDependenciesTo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDependenciesTo.AutoGenerateColumns = false;
            this.dgvDependenciesTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependenciesTo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependenciesTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependenciesTo.DataSource = this.bsDependenciesTo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependenciesTo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDependenciesTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependenciesTo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDependenciesTo.EnableHeadersVisualStyles = false;
            this.dgvDependenciesTo.Location = new System.Drawing.Point(3, 40);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1105, 476);
            this.dgvDependenciesTo.TabIndex = 22;
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
            // pnlDependenciesUpper
            // 
            this.pnlDependenciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1105, 37);
            this.pnlDependenciesUpper.TabIndex = 21;
            // 
            // hsRefreshDependencies
            // 
            this.hsRefreshDependencies.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshDependencies.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshDependencies.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshDependencies.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshDependencies.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshDependencies.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshDependencies.FlatAppearance.BorderSize = 0;
            this.hsRefreshDependencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshDependencies.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependencies.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependencies.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependencies.ImageToggleOnSelect = true;
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1060, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Size = new System.Drawing.Size(45, 37);
            this.hsRefreshDependencies.TabIndex = 2;
            this.hsRefreshDependencies.ToolTipActive = false;
            this.hsRefreshDependencies.ToolTipAutomaticDelay = 500;
            this.hsRefreshDependencies.ToolTipAutoPopDelay = 5000;
            this.hsRefreshDependencies.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshDependencies.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshDependencies.ToolTipFor4ContextMenu = true;
            this.hsRefreshDependencies.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshDependencies.ToolTipInitialDelay = 500;
            this.hsRefreshDependencies.ToolTipIsBallon = false;
            this.hsRefreshDependencies.ToolTipOwnerDraw = false;
            this.hsRefreshDependencies.ToolTipReshowDelay = 100;
            
            this.hsRefreshDependencies.ToolTipShowAlways = false;
            this.hsRefreshDependencies.ToolTipText = "";
            this.hsRefreshDependencies.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDependencies.ToolTipTitle = "";
            this.hsRefreshDependencies.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDependencies.UseVisualStyleBackColor = false;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.fctMessages);
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1111, 519);
            this.tabPageMessages.TabIndex = 2;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
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
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 14;
            this.fctMessages.CharWidth = 8;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(3, 40);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1105, 476);
            this.fctMessages.TabIndex = 28;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.Controls.Add(this.hotSpot3);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1105, 37);
            this.pnlMessagesUpper.TabIndex = 27;
            // 
            // hotSpot3
            // 
            this.hotSpot3.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot3.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot3.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot3.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot3.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot3.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotSpot3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot3.FlatAppearance.BorderSize = 0;
            this.hotSpot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot3.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot3.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot3.ImageToggleOnSelect = true;
            this.hotSpot3.Location = new System.Drawing.Point(1060, 0);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "";
            this.hotSpot3.Size = new System.Drawing.Size(45, 37);
            this.hotSpot3.TabIndex = 2;
            this.hotSpot3.ToolTipActive = false;
            this.hotSpot3.ToolTipAutomaticDelay = 500;
            this.hotSpot3.ToolTipAutoPopDelay = 5000;
            this.hotSpot3.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot3.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot3.ToolTipFor4ContextMenu = true;
            this.hotSpot3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot3.ToolTipInitialDelay = 500;
            this.hotSpot3.ToolTipIsBallon = false;
            this.hotSpot3.ToolTipOwnerDraw = false;
            this.hotSpot3.ToolTipReshowDelay = 100;
            
            this.hotSpot3.ToolTipShowAlways = false;
            this.hotSpot3.ToolTipText = "";
            this.hotSpot3.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot3.ToolTipTitle = "";
            this.hotSpot3.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot3.UseVisualStyleBackColor = false;
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
            this.ilTabControl.Images.SetKeyName(16, "media_playlist_shuffle_x32.png");
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
            // bsDependenciesFrom
            // 
            this.bsDependenciesFrom.DataSource = this.dsDependenciesFrom;
            this.bsDependenciesFrom.Position = 0;
            // 
            // ReplicationDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 588);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplicationDesignForm";
            this.Text = "ReplicationDesignForm";
            this.Load += new System.EventHandler(this.ReplicationDesignForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageDependencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.pnlDependenciesUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessagesUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.TabPage tabPageDependencies;
        private System.Windows.Forms.BindingSource bsDependenciesTo;
        private System.Data.DataSet dsDependenciesTo;
        private System.Data.DataTable dataTable5;
        private System.Data.DataSet dsDependenciesFrom;
        private System.Data.DataTable dataTable6;
        private System.Windows.Forms.BindingSource bsDependenciesFrom;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.DataGridView dgvDependenciesTo;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private System.Windows.Forms.TabPage tabPageMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hotSpot3;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.Label lblTableName;
    }
}