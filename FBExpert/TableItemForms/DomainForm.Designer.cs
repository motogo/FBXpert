using BasicForms;

namespace FBExpert
{
    partial class DomainForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DomainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsAddDomain = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fctDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlProcedureAttributesUpper = new System.Windows.Forms.Panel();
            this.gbCharSet = new System.Windows.Forms.GroupBox();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.gbCollate = new System.Windows.Forms.GroupBox();
            this.cbCollate = new System.Windows.Forms.ComboBox();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.hsSelectDefault = new SeControlsLib.HotSpot();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.ckCheck = new System.Windows.Forms.CheckBox();
            this.gbLength = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.gbDefault = new System.Windows.Forms.GroupBox();
            this.txtDefault = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsCreate = new SeControlsLib.HotSpot();
            this.tabExamples = new System.Windows.Forms.TabPage();
            this.fcbExamples = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.tabPageDependencies = new System.Windows.Forms.TabPage();
            this.dgvDependenciesTo = new System.Windows.Forms.DataGridView();
            this.pnlDependenciesUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hotSpot3 = new SeControlsLib.HotSpot();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).BeginInit();
            this.pnlProcedureAttributesUpper.SuspendLayout();
            this.gbCharSet.SuspendLayout();
            this.gbCollate.SuspendLayout();
            this.gbCheck.SuspendLayout();
            this.gbLength.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbTypes.SuspendLayout();
            this.gbDefault.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.gbSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.tabExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbExamples)).BeginInit();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageDependencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).BeginInit();
            this.pnlDependenciesUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessagesUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1474, 65);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(266, 15);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(145, 29);
            this.lblTableName.TabIndex = 8;
            this.lblTableName.Text = "Tablename";
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
            this.hsRefresh.Location = new System.Drawing.Point(1406, 0);
            this.hsRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Size = new System.Drawing.Size(68, 65);
            this.hsRefresh.TabIndex = 2;
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
            this.hsClose.ImageHover = global::FBXpert.Properties.Resources.go_left_blue32x;
            this.hsClose.ImageToggleOnSelect = true;
            this.hsClose.Location = new System.Drawing.Point(0, 0);
            this.hsClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Size = new System.Drawing.Size(68, 65);
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
            // hsAddDomain
            // 
            this.hsAddDomain.BackColor = System.Drawing.Color.Transparent;
            this.hsAddDomain.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddDomain.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddDomain.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddDomain.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddDomain.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddDomain.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddDomain.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddDomain.FlatAppearance.BorderSize = 0;
            this.hsAddDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddDomain.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddDomain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsAddDomain.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddDomain.ImageToggleOnSelect = true;
            this.hsAddDomain.Location = new System.Drawing.Point(4, 5);
            this.hsAddDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsAddDomain.Marked = false;
            this.hsAddDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddDomain.MarkedText = "";
            this.hsAddDomain.MarkMode = false;
            this.hsAddDomain.Name = "hsAddDomain";
            this.hsAddDomain.NonMarkedText = "New";
            this.hsAddDomain.Size = new System.Drawing.Size(68, 52);
            this.hsAddDomain.TabIndex = 7;
            this.hsAddDomain.Text = "New";
            this.hsAddDomain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddDomain.ToolTipActive = false;
            this.hsAddDomain.ToolTipAutomaticDelay = 500;
            this.hsAddDomain.ToolTipAutoPopDelay = 5000;
            this.hsAddDomain.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddDomain.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddDomain.ToolTipFor4ContextMenu = true;
            this.hsAddDomain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddDomain.ToolTipInitialDelay = 500;
            this.hsAddDomain.ToolTipIsBallon = false;
            this.hsAddDomain.ToolTipOwnerDraw = false;
            this.hsAddDomain.ToolTipReshowDelay = 100;
            this.hsAddDomain.ToolTipShowAlways = false;
            this.hsAddDomain.ToolTipText = "";
            this.hsAddDomain.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddDomain.ToolTipTitle = "";
            this.hsAddDomain.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddDomain.UseVisualStyleBackColor = false;
            this.hsAddDomain.Click += new System.EventHandler(this.hsAddDomain_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 65);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1474, 775);
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
            this.tabControlFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1474, 775);
            this.tabControlFields.TabIndex = 19;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldUpper);
            this.tabPageFieldEdit.ImageIndex = 8;
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 29);
            this.tabPageFieldEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1466, 742);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.splitContainer1);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(4, 64);
            this.pnlFieldsCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1458, 673);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pnlProcedureAttributesUpper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1458, 673);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fctDescription);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 440);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(479, 233);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // fctDescription
            // 
            this.fctDescription.AutoCompleteBracketsList = new char[] {
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
            this.fctDescription.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.fctDescription.BackBrush = null;
            this.fctDescription.BackColor = System.Drawing.SystemColors.Window;
            this.fctDescription.CharHeight = 22;
            this.fctDescription.CharWidth = 12;
            this.fctDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctDescription.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctDescription.IsReplaceMode = false;
            this.fctDescription.Location = new System.Drawing.Point(4, 24);
            this.fctDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fctDescription.Name = "fctDescription";
            this.fctDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctDescription.ServiceColors")));
            this.fctDescription.Size = new System.Drawing.Size(471, 204);
            this.fctDescription.TabIndex = 7;
            this.fctDescription.Zoom = 100;
            this.fctDescription.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctDescription_TextChanged);
            // 
            // pnlProcedureAttributesUpper
            // 
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbCharSet);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbCollate);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbCheck);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbLength);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbName);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbTypes);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbDefault);
            this.pnlProcedureAttributesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcedureAttributesUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlProcedureAttributesUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProcedureAttributesUpper.Name = "pnlProcedureAttributesUpper";
            this.pnlProcedureAttributesUpper.Size = new System.Drawing.Size(479, 440);
            this.pnlProcedureAttributesUpper.TabIndex = 0;
            // 
            // gbCharSet
            // 
            this.gbCharSet.Controls.Add(this.cbCharSet);
            this.gbCharSet.Location = new System.Drawing.Point(4, 169);
            this.gbCharSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCharSet.Name = "gbCharSet";
            this.gbCharSet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCharSet.Size = new System.Drawing.Size(176, 60);
            this.gbCharSet.TabIndex = 9;
            this.gbCharSet.TabStop = false;
            this.gbCharSet.Text = "CharSet";
            // 
            // cbCharSet
            // 
            this.cbCharSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharSet.FormattingEnabled = true;
            this.cbCharSet.Items.AddRange(new object[] {
            "NONE",
            "UTF8",
            "ASCII"});
            this.cbCharSet.Location = new System.Drawing.Point(4, 24);
            this.cbCharSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(168, 28);
            this.cbCharSet.TabIndex = 2;
            this.cbCharSet.Text = "NONE";
            this.cbCharSet.SelectedIndexChanged += new System.EventHandler(this.cbCharSet_SelectedIndexChanged);
            // 
            // gbCollate
            // 
            this.gbCollate.Controls.Add(this.cbCollate);
            this.gbCollate.Location = new System.Drawing.Point(189, 169);
            this.gbCollate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCollate.Name = "gbCollate";
            this.gbCollate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCollate.Size = new System.Drawing.Size(194, 60);
            this.gbCollate.TabIndex = 10;
            this.gbCollate.TabStop = false;
            this.gbCollate.Text = "Collate";
            // 
            // cbCollate
            // 
            this.cbCollate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCollate.FormattingEnabled = true;
            this.cbCollate.Items.AddRange(new object[] {
            "NONE",
            "UTF8",
            "ASCII"});
            this.cbCollate.Location = new System.Drawing.Point(4, 24);
            this.cbCollate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCollate.Name = "cbCollate";
            this.cbCollate.Size = new System.Drawing.Size(186, 28);
            this.cbCollate.TabIndex = 2;
            this.cbCollate.Text = "NONE";
            this.cbCollate.SelectedIndexChanged += new System.EventHandler(this.cbCollate_SelectedIndexChanged);
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.hsSelectDefault);
            this.gbCheck.Controls.Add(this.txtCheck);
            this.gbCheck.Controls.Add(this.ckCheck);
            this.gbCheck.Location = new System.Drawing.Point(9, 368);
            this.gbCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCheck.Size = new System.Drawing.Size(350, 63);
            this.gbCheck.TabIndex = 8;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Check";
            // 
            // hsSelectDefault
            // 
            this.hsSelectDefault.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectDefault.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectDefault.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectDefault.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectDefault.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectDefault.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectDefault.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectDefault.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSelectDefault.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectDefault.FlatAppearance.BorderSize = 0;
            this.hsSelectDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSelectDefault.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectDefault.Image = global::FBXpert.Properties.Resources.font_x24;
            this.hsSelectDefault.ImageHover = global::FBXpert.Properties.Resources.font2_x24;
            this.hsSelectDefault.ImageToggleOnSelect = true;
            this.hsSelectDefault.Location = new System.Drawing.Point(292, 24);
            this.hsSelectDefault.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.hsSelectDefault.Marked = false;
            this.hsSelectDefault.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectDefault.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectDefault.MarkedText = "";
            this.hsSelectDefault.MarkMode = false;
            this.hsSelectDefault.Name = "hsSelectDefault";
            this.hsSelectDefault.NonMarkedText = "";
            this.hsSelectDefault.Size = new System.Drawing.Size(54, 34);
            this.hsSelectDefault.TabIndex = 6;
            this.hsSelectDefault.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSelectDefault.ToolTipActive = false;
            this.hsSelectDefault.ToolTipAutomaticDelay = 500;
            this.hsSelectDefault.ToolTipAutoPopDelay = 5000;
            this.hsSelectDefault.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectDefault.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectDefault.ToolTipFor4ContextMenu = true;
            this.hsSelectDefault.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectDefault.ToolTipInitialDelay = 500;
            this.hsSelectDefault.ToolTipIsBallon = false;
            this.hsSelectDefault.ToolTipOwnerDraw = false;
            this.hsSelectDefault.ToolTipReshowDelay = 100;
            this.hsSelectDefault.ToolTipShowAlways = false;
            this.hsSelectDefault.ToolTipText = "";
            this.hsSelectDefault.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectDefault.ToolTipTitle = "";
            this.hsSelectDefault.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectDefault.UseVisualStyleBackColor = false;
            this.hsSelectDefault.Click += new System.EventHandler(this.hsSelectDefault_Click);
            // 
            // txtCheck
            // 
            this.txtCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCheck.Location = new System.Drawing.Point(4, 24);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(232, 26);
            this.txtCheck.TabIndex = 4;
            this.txtCheck.Text = "VALUE IS NOT NULL";
            this.txtCheck.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // ckCheck
            // 
            this.ckCheck.AutoSize = true;
            this.ckCheck.Location = new System.Drawing.Point(248, 29);
            this.ckCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckCheck.Name = "ckCheck";
            this.ckCheck.Size = new System.Drawing.Size(22, 21);
            this.ckCheck.TabIndex = 5;
            this.ckCheck.UseVisualStyleBackColor = true;
            this.ckCheck.CheckedChanged += new System.EventHandler(this.cbNotNull_CheckedChanged);
            // 
            // gbLength
            // 
            this.gbLength.Controls.Add(this.txtLength);
            this.gbLength.Location = new System.Drawing.Point(249, 97);
            this.gbLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLength.Name = "gbLength";
            this.gbLength.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLength.Size = new System.Drawing.Size(135, 63);
            this.gbLength.TabIndex = 6;
            this.gbLength.TabStop = false;
            this.gbLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLength.Location = new System.Drawing.Point(4, 24);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(127, 26);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtName);
            this.gbName.Location = new System.Drawing.Point(4, 9);
            this.gbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbName.Size = new System.Drawing.Size(312, 63);
            this.gbName.TabIndex = 3;
            this.gbName.TabStop = false;
            this.gbName.Text = "Domain";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(4, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 26);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.cbTypes);
            this.gbTypes.Location = new System.Drawing.Point(4, 97);
            this.gbTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTypes.Size = new System.Drawing.Size(236, 63);
            this.gbTypes.TabIndex = 2;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "FieldType";
            // 
            // cbTypes
            // 
            this.cbTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(4, 24);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(228, 28);
            this.cbTypes.TabIndex = 1;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // gbDefault
            // 
            this.gbDefault.Controls.Add(this.txtDefault);
            this.gbDefault.Location = new System.Drawing.Point(4, 255);
            this.gbDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDefault.Name = "gbDefault";
            this.gbDefault.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDefault.Size = new System.Drawing.Size(378, 63);
            this.gbDefault.TabIndex = 4;
            this.gbDefault.TabStop = false;
            this.gbDefault.Text = "Default";
            // 
            // txtDefault
            // 
            this.txtDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefault.Location = new System.Drawing.Point(4, 24);
            this.txtDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefault.Name = "txtDefault";
            this.txtDefault.Size = new System.Drawing.Size(370, 26);
            this.txtDefault.TabIndex = 4;
            this.txtDefault.TextChanged += new System.EventHandler(this.txtDefault_TextChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageSQL);
            this.tabControl2.Controls.Add(this.tabExamples);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ImageList = this.ilTabControl;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(973, 673);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.gbSQL);
            this.tabPageSQL.Controls.Add(this.pnlSQLUpper);
            this.tabPageSQL.ImageIndex = 5;
            this.tabPageSQL.Location = new System.Drawing.Point(4, 29);
            this.tabPageSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSQL.Size = new System.Drawing.Size(965, 640);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.fctSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(4, 64);
            this.gbSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSQL.Size = new System.Drawing.Size(957, 571);
            this.gbSQL.TabIndex = 9;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "SQL";
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fctSQL.CharHeight = 18;
            this.fctSQL.CharWidth = 10;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(4, 24);
            this.fctSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(949, 542);
            this.fctSQL.TabIndex = 0;
            this.fctSQL.Zoom = 100;
            this.fctSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctSQL_KeyDown);
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Controls.Add(this.hsCreate);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(4, 5);
            this.pnlSQLUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(957, 59);
            this.pnlSQLUpper.TabIndex = 10;
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
            this.hsLoadSQL.Location = new System.Drawing.Point(224, 0);
            this.hsLoadSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(123, 55);
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
            this.hsSaveSQL.Location = new System.Drawing.Point(104, 0);
            this.hsSaveSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Size = new System.Drawing.Size(120, 55);
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
            this.hsSaveSQL.Click += new System.EventHandler(this.hsSaveSQL_Click);
            // 
            // hsCreate
            // 
            this.hsCreate.BackColor = System.Drawing.Color.Transparent;
            this.hsCreate.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCreate.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCreate.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCreate.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCreate.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCreate.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreate.FlatAppearance.BorderSize = 0;
            this.hsCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCreate.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreate.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCreate.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsCreate.ImageToggleOnSelect = true;
            this.hsCreate.Location = new System.Drawing.Point(0, 0);
            this.hsCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsCreate.Marked = false;
            this.hsCreate.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreate.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreate.MarkedText = "";
            this.hsCreate.MarkMode = false;
            this.hsCreate.Name = "hsCreate";
            this.hsCreate.NonMarkedText = "Execute";
            this.hsCreate.Size = new System.Drawing.Size(104, 55);
            this.hsCreate.TabIndex = 1;
            this.hsCreate.Text = "Execute";
            this.hsCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCreate.ToolTipActive = false;
            this.hsCreate.ToolTipAutomaticDelay = 500;
            this.hsCreate.ToolTipAutoPopDelay = 5000;
            this.hsCreate.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCreate.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCreate.ToolTipFor4ContextMenu = true;
            this.hsCreate.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCreate.ToolTipInitialDelay = 500;
            this.hsCreate.ToolTipIsBallon = false;
            this.hsCreate.ToolTipOwnerDraw = false;
            this.hsCreate.ToolTipReshowDelay = 100;
            this.hsCreate.ToolTipShowAlways = false;
            this.hsCreate.ToolTipText = "";
            this.hsCreate.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCreate.ToolTipTitle = "";
            this.hsCreate.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCreate.UseVisualStyleBackColor = false;
            this.hsCreate.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // tabExamples
            // 
            this.tabExamples.Controls.Add(this.fcbExamples);
            this.tabExamples.Location = new System.Drawing.Point(4, 29);
            this.tabExamples.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabExamples.Name = "tabExamples";
            this.tabExamples.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabExamples.Size = new System.Drawing.Size(961, 630);
            this.tabExamples.TabIndex = 2;
            this.tabExamples.Text = "Examples";
            this.tabExamples.UseVisualStyleBackColor = true;
            // 
            // fcbExamples
            // 
            this.fcbExamples.AutoCompleteBracketsList = new char[] {
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
            this.fcbExamples.AutoIndentCharsPatterns = "";
            this.fcbExamples.AutoScrollMinSize = new System.Drawing.Size(1001, 18);
            this.fcbExamples.BackBrush = null;
            this.fcbExamples.BackColor = System.Drawing.SystemColors.Info;
            this.fcbExamples.CharHeight = 18;
            this.fcbExamples.CharWidth = 10;
            this.fcbExamples.CommentPrefix = "--";
            this.fcbExamples.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbExamples.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbExamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbExamples.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fcbExamples.IsReplaceMode = false;
            this.fcbExamples.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbExamples.LeftBracket = '(';
            this.fcbExamples.Location = new System.Drawing.Point(4, 5);
            this.fcbExamples.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fcbExamples.Name = "fcbExamples";
            this.fcbExamples.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbExamples.RightBracket = ')';
            this.fcbExamples.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbExamples.ServiceColors = null;
            this.fcbExamples.Size = new System.Drawing.Size(953, 620);
            this.fcbExamples.TabIndex = 1;
            this.fcbExamples.Text = "CREATE DOMAIN <domainname> AS VARCHAR(2048) CHARACTER SET UTF8 COLLATE UTF8; /* c" +
    "reates domain */";
            this.fcbExamples.Zoom = 100;
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
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsAddDomain);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(4, 5);
            this.pnlFieldUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1458, 59);
            this.pnlFieldUpper.TabIndex = 1;
            // 
            // tabPageDependencies
            // 
            this.tabPageDependencies.Controls.Add(this.dgvDependenciesTo);
            this.tabPageDependencies.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageDependencies.ImageIndex = 16;
            this.tabPageDependencies.Location = new System.Drawing.Point(4, 29);
            this.tabPageDependencies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDependencies.Name = "tabPageDependencies";
            this.tabPageDependencies.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDependencies.Size = new System.Drawing.Size(1466, 742);
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
            this.dgvDependenciesTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependenciesTo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependenciesTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvDependenciesTo.Location = new System.Drawing.Point(4, 60);
            this.dgvDependenciesTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.RowHeadersWidth = 62;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1458, 677);
            this.dgvDependenciesTo.TabIndex = 22;
            // 
            // pnlDependenciesUpper
            // 
            this.pnlDependenciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDependenciesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(4, 5);
            this.pnlDependenciesUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1458, 55);
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
            this.hsRefreshDependencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshDependencies.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependencies.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependencies.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependencies.ImageToggleOnSelect = true;
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1386, 0);
            this.hsRefreshDependencies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Size = new System.Drawing.Size(68, 51);
            this.hsRefreshDependencies.TabIndex = 2;
            this.hsRefreshDependencies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.tabPageMessages.Location = new System.Drawing.Point(4, 29);
            this.tabPageMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMessages.Size = new System.Drawing.Size(1466, 742);
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
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(2, 22);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 22;
            this.fctMessages.CharWidth = 12;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(4, 60);
            this.fctMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1458, 677);
            this.fctMessages.TabIndex = 30;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hotSpot3);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(4, 5);
            this.pnlMessagesUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1458, 55);
            this.pnlMessagesUpper.TabIndex = 29;
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
            this.hotSpot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot3.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot3.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot3.ImageToggleOnSelect = true;
            this.hotSpot3.Location = new System.Drawing.Point(1386, 0);
            this.hotSpot3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "";
            this.hotSpot3.Size = new System.Drawing.Size(68, 51);
            this.hotSpot3.TabIndex = 2;
            this.hotSpot3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // DomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 840);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DomainForm";
            this.Text = "3";
            this.Load += new System.EventHandler(this.DomainForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).EndInit();
            this.pnlProcedureAttributesUpper.ResumeLayout(false);
            this.gbCharSet.ResumeLayout(false);
            this.gbCollate.ResumeLayout(false);
            this.gbCheck.ResumeLayout(false);
            this.gbCheck.PerformLayout();
            this.gbLength.ResumeLayout(false);
            this.gbLength.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbTypes.ResumeLayout(false);
            this.gbDefault.ResumeLayout(false);
            this.gbDefault.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.tabExamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbExamples)).EndInit();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageDependencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).EndInit();
            this.pnlDependenciesUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessagesUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.GroupBox gbDefault;
        private System.Windows.Forms.TextBox txtDefault;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtName;
        private SeControlsLib.HotSpot hsAddDomain;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FastColoredTextBoxNS.FastColoredTextBox fctDescription;
        private System.Windows.Forms.Panel pnlProcedureAttributesUpper;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.GroupBox gbSQL;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsCreate;
        private System.Windows.Forms.TabPage tabPageDependencies;
        private System.Windows.Forms.DataGridView dgvDependenciesTo;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private System.Windows.Forms.TabPage tabPageMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hotSpot3;
        private System.Windows.Forms.CheckBox ckCheck;
        private System.Windows.Forms.GroupBox gbLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.TabPage tabExamples;
        private FastColoredTextBoxNS.FastColoredTextBox fcbExamples;
        private System.Windows.Forms.GroupBox gbCharSet;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.GroupBox gbCollate;
        private System.Windows.Forms.ComboBox cbCollate;
        private SeControlsLib.HotSpot hsSelectDefault;
    }
}