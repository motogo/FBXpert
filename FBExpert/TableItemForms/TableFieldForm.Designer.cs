namespace FBExpert
{
    partial class TableFieldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableFieldForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsInfo = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.hsNewDomain = new SeControlsLib.HotSpot();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDomainInfo = new System.Windows.Forms.TabPage();
            this.pnlDomainCenter = new System.Windows.Forms.Panel();
            this.cbUnique = new System.Windows.Forms.CheckBox();
            this.cbPrimaryKey = new System.Windows.Forms.CheckBox();
            this.cbNotNull = new System.Windows.Forms.CheckBox();
            this.gbFieldDescription = new System.Windows.Forms.GroupBox();
            this.fctDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbFieldCollate = new System.Windows.Forms.GroupBox();
            this.txtFieldCollate = new System.Windows.Forms.TextBox();
            this.gbFieldCharSet = new System.Windows.Forms.GroupBox();
            this.txtFieldCharSet = new System.Windows.Forms.TextBox();
            this.gbFieldRawType = new System.Windows.Forms.GroupBox();
            this.txtFieldRawType = new System.Windows.Forms.TextBox();
            this.gbFieldScale = new System.Windows.Forms.GroupBox();
            this.txtFieldScale = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFieldType = new System.Windows.Forms.TextBox();
            this.gbFieldLength = new System.Windows.Forms.GroupBox();
            this.txtFieldLength = new System.Windows.Forms.TextBox();
            this.pnlDomainUpper = new System.Windows.Forms.Panel();
            this.tabConstraints = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.Table = new System.Data.DataTable();
            this.pnlIndiciesUpper = new System.Windows.Forms.Panel();
            this.hsEditDomain = new SeControlsLib.HotSpot();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.gbFieldName = new System.Windows.Forms.GroupBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDomainInfo.SuspendLayout();
            this.pnlDomainCenter.SuspendLayout();
            this.gbFieldDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).BeginInit();
            this.gbFieldCollate.SuspendLayout();
            this.gbFieldCharSet.SuspendLayout();
            this.gbFieldRawType.SuspendLayout();
            this.gbFieldScale.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFieldLength.SuspendLayout();
            this.tabConstraints.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.gbDomain.SuspendLayout();
            this.gbFieldName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsInfo);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(783, 44);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(68, 11);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 4;
            this.lblTableName.Text = "Tablename";
            // 
            // hsInfo
            // 
            this.hsInfo.BackColor = System.Drawing.Color.Transparent;
            this.hsInfo.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInfo.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInfo.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInfo.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInfo.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsInfo.FlatAppearance.BorderSize = 0;
            this.hsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInfo.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInfo.Image = global::FBXpert.Properties.Resources.dialog_information_x32;
            this.hsInfo.ImageHover = global::FBXpert.Properties.Resources.dialog_information_lightning_x32;
            this.hsInfo.ImageToggleOnSelect = true;
            this.hsInfo.Location = new System.Drawing.Point(738, 0);
            this.hsInfo.Marked = false;
            this.hsInfo.MarkedColor = System.Drawing.Color.Teal;
            this.hsInfo.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInfo.MarkedText = "";
            this.hsInfo.MarkMode = false;
            this.hsInfo.Name = "hsInfo";
            this.hsInfo.NonMarkedText = "";
            this.hsInfo.Size = new System.Drawing.Size(45, 44);
            this.hsInfo.TabIndex = 2;
            this.hsInfo.ToolTipActive = false;
            this.hsInfo.ToolTipAutomaticDelay = 500;
            this.hsInfo.ToolTipAutoPopDelay = 5000;
            this.hsInfo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInfo.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInfo.ToolTipFor4ContextMenu = true;
            this.hsInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInfo.ToolTipInitialDelay = 500;
            this.hsInfo.ToolTipIsBallon = false;
            this.hsInfo.ToolTipOwnerDraw = false;
            this.hsInfo.ToolTipReshowDelay = 100;
            
            this.hsInfo.ToolTipShowAlways = false;
            this.hsInfo.ToolTipText = "";
            this.hsInfo.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInfo.ToolTipTitle = "";
            this.hsInfo.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInfo.UseVisualStyleBackColor = false;
            this.hsInfo.Click += new System.EventHandler(this.hsInfo_Click);
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
            this.pnlCenter.Controls.Add(this.hsNewDomain);
            this.pnlCenter.Controls.Add(this.tabControl1);
            this.pnlCenter.Controls.Add(this.hsEditDomain);
            this.pnlCenter.Controls.Add(this.gbDomain);
            this.pnlCenter.Controls.Add(this.gbFieldName);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 44);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(783, 562);
            this.pnlCenter.TabIndex = 2;
            // 
            // hsNewDomain
            // 
            this.hsNewDomain.BackColor = System.Drawing.Color.Transparent;
            this.hsNewDomain.BackColorHover = System.Drawing.Color.Transparent;
            this.hsNewDomain.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsNewDomain.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsNewDomain.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsNewDomain.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsNewDomain.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsNewDomain.FlatAppearance.BorderSize = 0;
            this.hsNewDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsNewDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsNewDomain.Image = global::FBXpert.Properties.Resources.documents_plus_32x;
            this.hsNewDomain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsNewDomain.ImageHover = global::FBXpert.Properties.Resources.documents_blue_x32;
            this.hsNewDomain.ImageToggleOnSelect = true;
            this.hsNewDomain.Location = new System.Drawing.Point(349, 77);
            this.hsNewDomain.Marked = false;
            this.hsNewDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsNewDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNewDomain.MarkedText = "";
            this.hsNewDomain.MarkMode = false;
            this.hsNewDomain.Name = "hsNewDomain";
            this.hsNewDomain.NonMarkedText = "New Domain";
            this.hsNewDomain.Size = new System.Drawing.Size(78, 58);
            this.hsNewDomain.TabIndex = 8;
            this.hsNewDomain.Text = "New Domain";
            this.hsNewDomain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsNewDomain.ToolTipActive = false;
            this.hsNewDomain.ToolTipAutomaticDelay = 500;
            this.hsNewDomain.ToolTipAutoPopDelay = 5000;
            this.hsNewDomain.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsNewDomain.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsNewDomain.ToolTipFor4ContextMenu = true;
            this.hsNewDomain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsNewDomain.ToolTipInitialDelay = 500;
            this.hsNewDomain.ToolTipIsBallon = false;
            this.hsNewDomain.ToolTipOwnerDraw = false;
            this.hsNewDomain.ToolTipReshowDelay = 100;
            
            this.hsNewDomain.ToolTipShowAlways = false;
            this.hsNewDomain.ToolTipText = "";
            this.hsNewDomain.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsNewDomain.ToolTipTitle = "";
            this.hsNewDomain.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsNewDomain.UseVisualStyleBackColor = false;
            this.hsNewDomain.Click += new System.EventHandler(this.hsNewDomain_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDomainInfo);
            this.tabControl1.Controls.Add(this.tabConstraints);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 180);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 382);
            this.tabControl1.TabIndex = 7;
            // 
            // tabDomainInfo
            // 
            this.tabDomainInfo.Controls.Add(this.pnlDomainCenter);
            this.tabDomainInfo.Controls.Add(this.pnlDomainUpper);
            this.tabDomainInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDomainInfo.Name = "tabDomainInfo";
            this.tabDomainInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDomainInfo.Size = new System.Drawing.Size(775, 356);
            this.tabDomainInfo.TabIndex = 0;
            this.tabDomainInfo.Text = "Domain Info";
            this.tabDomainInfo.UseVisualStyleBackColor = true;
            // 
            // pnlDomainCenter
            // 
            this.pnlDomainCenter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDomainCenter.Controls.Add(this.cbUnique);
            this.pnlDomainCenter.Controls.Add(this.cbPrimaryKey);
            this.pnlDomainCenter.Controls.Add(this.cbNotNull);
            this.pnlDomainCenter.Controls.Add(this.gbFieldDescription);
            this.pnlDomainCenter.Controls.Add(this.gbFieldCollate);
            this.pnlDomainCenter.Controls.Add(this.gbFieldCharSet);
            this.pnlDomainCenter.Controls.Add(this.gbFieldRawType);
            this.pnlDomainCenter.Controls.Add(this.gbFieldScale);
            this.pnlDomainCenter.Controls.Add(this.groupBox1);
            this.pnlDomainCenter.Controls.Add(this.gbFieldLength);
            this.pnlDomainCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDomainCenter.Location = new System.Drawing.Point(3, 32);
            this.pnlDomainCenter.Name = "pnlDomainCenter";
            this.pnlDomainCenter.Size = new System.Drawing.Size(769, 321);
            this.pnlDomainCenter.TabIndex = 1;
            // 
            // cbUnique
            // 
            this.cbUnique.AutoSize = true;
            this.cbUnique.Location = new System.Drawing.Point(234, 84);
            this.cbUnique.Name = "cbUnique";
            this.cbUnique.Size = new System.Drawing.Size(60, 17);
            this.cbUnique.TabIndex = 13;
            this.cbUnique.Text = "Unique";
            this.cbUnique.UseVisualStyleBackColor = true;
            // 
            // cbPrimaryKey
            // 
            this.cbPrimaryKey.AutoSize = true;
            this.cbPrimaryKey.Location = new System.Drawing.Point(234, 61);
            this.cbPrimaryKey.Name = "cbPrimaryKey";
            this.cbPrimaryKey.Size = new System.Drawing.Size(81, 17);
            this.cbPrimaryKey.TabIndex = 12;
            this.cbPrimaryKey.Text = "Primary Key";
            this.cbPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // cbNotNull
            // 
            this.cbNotNull.AutoSize = true;
            this.cbNotNull.Location = new System.Drawing.Point(234, 38);
            this.cbNotNull.Name = "cbNotNull";
            this.cbNotNull.Size = new System.Drawing.Size(80, 17);
            this.cbNotNull.TabIndex = 11;
            this.cbNotNull.Text = "NOT NULL";
            this.cbNotNull.UseVisualStyleBackColor = true;
            // 
            // gbFieldDescription
            // 
            this.gbFieldDescription.Controls.Add(this.fctDescription);
            this.gbFieldDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbFieldDescription.Location = new System.Drawing.Point(342, 0);
            this.gbFieldDescription.Name = "gbFieldDescription";
            this.gbFieldDescription.Size = new System.Drawing.Size(427, 321);
            this.gbFieldDescription.TabIndex = 10;
            this.gbFieldDescription.TabStop = false;
            this.gbFieldDescription.Text = "Field Description";
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
            this.fctDescription.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctDescription.BackBrush = null;
            this.fctDescription.BackColor = System.Drawing.SystemColors.Info;
            this.fctDescription.CharHeight = 14;
            this.fctDescription.CharWidth = 8;
            this.fctDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctDescription.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctDescription.IsReplaceMode = false;
            this.fctDescription.Location = new System.Drawing.Point(3, 16);
            this.fctDescription.Name = "fctDescription";
            this.fctDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctDescription.ServiceColors")));
            this.fctDescription.Size = new System.Drawing.Size(421, 302);
            this.fctDescription.TabIndex = 7;
            this.fctDescription.Zoom = 100;
            // 
            // gbFieldCollate
            // 
            this.gbFieldCollate.Controls.Add(this.txtFieldCollate);
            this.gbFieldCollate.Location = new System.Drawing.Point(8, 276);
            this.gbFieldCollate.Name = "gbFieldCollate";
            this.gbFieldCollate.Size = new System.Drawing.Size(200, 42);
            this.gbFieldCollate.TabIndex = 9;
            this.gbFieldCollate.TabStop = false;
            this.gbFieldCollate.Text = "Field Collate";
            // 
            // txtFieldCollate
            // 
            this.txtFieldCollate.BackColor = System.Drawing.SystemColors.Info;
            this.txtFieldCollate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldCollate.Location = new System.Drawing.Point(3, 16);
            this.txtFieldCollate.Name = "txtFieldCollate";
            this.txtFieldCollate.Size = new System.Drawing.Size(194, 20);
            this.txtFieldCollate.TabIndex = 0;
            // 
            // gbFieldCharSet
            // 
            this.gbFieldCharSet.Controls.Add(this.txtFieldCharSet);
            this.gbFieldCharSet.Location = new System.Drawing.Point(11, 228);
            this.gbFieldCharSet.Name = "gbFieldCharSet";
            this.gbFieldCharSet.Size = new System.Drawing.Size(200, 42);
            this.gbFieldCharSet.TabIndex = 8;
            this.gbFieldCharSet.TabStop = false;
            this.gbFieldCharSet.Text = "Field Charset";
            // 
            // txtFieldCharSet
            // 
            this.txtFieldCharSet.BackColor = System.Drawing.SystemColors.Info;
            this.txtFieldCharSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldCharSet.Location = new System.Drawing.Point(3, 16);
            this.txtFieldCharSet.Name = "txtFieldCharSet";
            this.txtFieldCharSet.Size = new System.Drawing.Size(194, 20);
            this.txtFieldCharSet.TabIndex = 0;
            // 
            // gbFieldRawType
            // 
            this.gbFieldRawType.Controls.Add(this.txtFieldRawType);
            this.gbFieldRawType.Location = new System.Drawing.Point(8, 176);
            this.gbFieldRawType.Name = "gbFieldRawType";
            this.gbFieldRawType.Size = new System.Drawing.Size(200, 42);
            this.gbFieldRawType.TabIndex = 6;
            this.gbFieldRawType.TabStop = false;
            this.gbFieldRawType.Text = "Field RAW FieldType";
            // 
            // txtFieldRawType
            // 
            this.txtFieldRawType.BackColor = System.Drawing.SystemColors.Info;
            this.txtFieldRawType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldRawType.Location = new System.Drawing.Point(3, 16);
            this.txtFieldRawType.Name = "txtFieldRawType";
            this.txtFieldRawType.Size = new System.Drawing.Size(194, 20);
            this.txtFieldRawType.TabIndex = 0;
            // 
            // gbFieldScale
            // 
            this.gbFieldScale.Controls.Add(this.txtFieldScale);
            this.gbFieldScale.Location = new System.Drawing.Point(11, 118);
            this.gbFieldScale.Name = "gbFieldScale";
            this.gbFieldScale.Size = new System.Drawing.Size(200, 42);
            this.gbFieldScale.TabIndex = 5;
            this.gbFieldScale.TabStop = false;
            this.gbFieldScale.Text = "Field Scale";
            // 
            // txtFieldScale
            // 
            this.txtFieldScale.BackColor = System.Drawing.SystemColors.Info;
            this.txtFieldScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldScale.Location = new System.Drawing.Point(3, 16);
            this.txtFieldScale.Name = "txtFieldScale";
            this.txtFieldScale.Size = new System.Drawing.Size(194, 20);
            this.txtFieldScale.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFieldType);
            this.groupBox1.Location = new System.Drawing.Point(11, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field FieldType";
            // 
            // txtFieldType
            // 
            this.txtFieldType.BackColor = System.Drawing.SystemColors.Info;
            this.txtFieldType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldType.Location = new System.Drawing.Point(3, 16);
            this.txtFieldType.Name = "txtFieldType";
            this.txtFieldType.Size = new System.Drawing.Size(194, 20);
            this.txtFieldType.TabIndex = 0;
            // 
            // gbFieldLength
            // 
            this.gbFieldLength.Controls.Add(this.txtFieldLength);
            this.gbFieldLength.Location = new System.Drawing.Point(11, 70);
            this.gbFieldLength.Name = "gbFieldLength";
            this.gbFieldLength.Size = new System.Drawing.Size(200, 42);
            this.gbFieldLength.TabIndex = 2;
            this.gbFieldLength.TabStop = false;
            this.gbFieldLength.Text = "Field Length";
            // 
            // txtFieldLength
            // 
            this.txtFieldLength.BackColor = System.Drawing.SystemColors.Info;
            this.txtFieldLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldLength.Location = new System.Drawing.Point(3, 16);
            this.txtFieldLength.Name = "txtFieldLength";
            this.txtFieldLength.Size = new System.Drawing.Size(194, 20);
            this.txtFieldLength.TabIndex = 0;
            // 
            // pnlDomainUpper
            // 
            this.pnlDomainUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDomainUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDomainUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDomainUpper.Name = "pnlDomainUpper";
            this.pnlDomainUpper.Size = new System.Drawing.Size(769, 29);
            this.pnlDomainUpper.TabIndex = 0;
            // 
            // tabConstraints
            // 
            this.tabConstraints.Controls.Add(this.panel1);
            this.tabConstraints.Controls.Add(this.pnlIndiciesUpper);
            this.tabConstraints.Location = new System.Drawing.Point(4, 22);
            this.tabConstraints.Name = "tabConstraints";
            this.tabConstraints.Padding = new System.Windows.Forms.Padding(3);
            this.tabConstraints.Size = new System.Drawing.Size(775, 356);
            this.tabConstraints.TabIndex = 1;
            this.tabConstraints.Text = "Constraints";
            this.tabConstraints.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 317);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 317);
            this.dataGridView1.TabIndex = 18;
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
            // pnlIndiciesUpper
            // 
            this.pnlIndiciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlIndiciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIndiciesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlIndiciesUpper.Name = "pnlIndiciesUpper";
            this.pnlIndiciesUpper.Size = new System.Drawing.Size(769, 33);
            this.pnlIndiciesUpper.TabIndex = 0;
            // 
            // hsEditDomain
            // 
            this.hsEditDomain.BackColor = System.Drawing.Color.Transparent;
            this.hsEditDomain.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditDomain.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditDomain.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsEditDomain.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditDomain.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditDomain.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditDomain.FlatAppearance.BorderSize = 0;
            this.hsEditDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEditDomain.Image = global::FBXpert.Properties.Resources.documents_32x;
            this.hsEditDomain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsEditDomain.ImageHover = global::FBXpert.Properties.Resources.documents_blue_x32;
            this.hsEditDomain.ImageToggleOnSelect = true;
            this.hsEditDomain.Location = new System.Drawing.Point(243, 77);
            this.hsEditDomain.Marked = false;
            this.hsEditDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditDomain.MarkedText = "";
            this.hsEditDomain.MarkMode = false;
            this.hsEditDomain.Name = "hsEditDomain";
            this.hsEditDomain.NonMarkedText = "Edit Domain";
            this.hsEditDomain.Size = new System.Drawing.Size(78, 58);
            this.hsEditDomain.TabIndex = 4;
            this.hsEditDomain.Text = "Edit Domain";
            this.hsEditDomain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEditDomain.ToolTipActive = false;
            this.hsEditDomain.ToolTipAutomaticDelay = 500;
            this.hsEditDomain.ToolTipAutoPopDelay = 5000;
            this.hsEditDomain.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEditDomain.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEditDomain.ToolTipFor4ContextMenu = true;
            this.hsEditDomain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEditDomain.ToolTipInitialDelay = 500;
            this.hsEditDomain.ToolTipIsBallon = false;
            this.hsEditDomain.ToolTipOwnerDraw = false;
            this.hsEditDomain.ToolTipReshowDelay = 100;
            
            this.hsEditDomain.ToolTipShowAlways = false;
            this.hsEditDomain.ToolTipText = "";
            this.hsEditDomain.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsEditDomain.ToolTipTitle = "";
            this.hsEditDomain.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEditDomain.UseVisualStyleBackColor = false;
            this.hsEditDomain.Click += new System.EventHandler(this.hsEditDomain_Click);
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.txtDomain);
            this.gbDomain.Location = new System.Drawing.Point(24, 77);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Size = new System.Drawing.Size(200, 42);
            this.gbDomain.TabIndex = 3;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Field Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDomain.Location = new System.Drawing.Point(3, 16);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(194, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // gbFieldName
            // 
            this.gbFieldName.Controls.Add(this.txtFieldName);
            this.gbFieldName.Location = new System.Drawing.Point(21, 18);
            this.gbFieldName.Name = "gbFieldName";
            this.gbFieldName.Size = new System.Drawing.Size(200, 42);
            this.gbFieldName.TabIndex = 0;
            this.gbFieldName.TabStop = false;
            this.gbFieldName.Text = "Field Name";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldName.Location = new System.Drawing.Point(3, 16);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(194, 20);
            this.txtFieldName.TabIndex = 0;
            // 
            // TableFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 606);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableFieldForm";
            this.Text = "TableFieldForm";
            this.Load += new System.EventHandler(this.TableFieldForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDomainInfo.ResumeLayout(false);
            this.pnlDomainCenter.ResumeLayout(false);
            this.pnlDomainCenter.PerformLayout();
            this.gbFieldDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).EndInit();
            this.gbFieldCollate.ResumeLayout(false);
            this.gbFieldCollate.PerformLayout();
            this.gbFieldCharSet.ResumeLayout(false);
            this.gbFieldCharSet.PerformLayout();
            this.gbFieldRawType.ResumeLayout(false);
            this.gbFieldRawType.PerformLayout();
            this.gbFieldScale.ResumeLayout(false);
            this.gbFieldScale.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFieldLength.ResumeLayout(false);
            this.gbFieldLength.PerformLayout();
            this.tabConstraints.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.gbDomain.ResumeLayout(false);
            this.gbDomain.PerformLayout();
            this.gbFieldName.ResumeLayout(false);
            this.gbFieldName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox gbFieldLength;
        private System.Windows.Forms.TextBox txtFieldLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFieldType;
        private System.Windows.Forms.GroupBox gbFieldName;
        private System.Windows.Forms.TextBox txtFieldName;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.GroupBox gbDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private SeControlsLib.HotSpot hsEditDomain;
        private System.Windows.Forms.GroupBox gbFieldScale;
        private System.Windows.Forms.TextBox txtFieldScale;
        private System.Windows.Forms.GroupBox gbFieldRawType;
        private System.Windows.Forms.TextBox txtFieldRawType;
        private SeControlsLib.HotSpot hsNewDomain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDomainInfo;
        private System.Windows.Forms.Panel pnlDomainCenter;
        private System.Windows.Forms.Panel pnlDomainUpper;
        private System.Windows.Forms.TabPage tabConstraints;
        private FastColoredTextBoxNS.FastColoredTextBox fctDescription;
        private System.Windows.Forms.GroupBox gbFieldDescription;
        private System.Windows.Forms.GroupBox gbFieldCollate;
        private System.Windows.Forms.TextBox txtFieldCollate;
        private System.Windows.Forms.GroupBox gbFieldCharSet;
        private System.Windows.Forms.TextBox txtFieldCharSet;
        private SeControlsLib.HotSpot hsInfo;
        private System.Windows.Forms.CheckBox cbNotNull;
        private System.Windows.Forms.CheckBox cbUnique;
        private System.Windows.Forms.CheckBox cbPrimaryKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIndiciesUpper;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable Table;
        private System.Windows.Forms.Label lblTableName;
    }
}