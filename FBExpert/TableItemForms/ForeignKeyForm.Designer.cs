using BasicForms;

namespace FBXpert
{
    partial class ForeignKeyForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForeignKeyForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblProcedureName = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbGenDescription = new System.Windows.Forms.GroupBox();
            this.fctGenDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlProcedureAttributesUpper = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIndexName = new System.Windows.Forms.TextBox();
            this.hsAddSourceField = new SeControlsLib.HotSpot();
            this.hsRemoveSourceField = new SeControlsLib.HotSpot();
            this.gbSourceFieldNames = new System.Windows.Forms.GroupBox();
            this.lvSourceFields = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSourceTable = new System.Windows.Forms.GroupBox();
            this.cbSourceTable = new System.Windows.Forms.ComboBox();
            this.gbDestinationTable = new System.Windows.Forms.GroupBox();
            this.cbDestinationTable = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrimaryKey = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbDestinationTableFields = new System.Windows.Forms.ComboBox();
            this.hsAddDestField = new SeControlsLib.HotSpot();
            this.hsRemoveDestField = new SeControlsLib.HotSpot();
            this.gbDestinationFields = new System.Windows.Forms.GroupBox();
            this.lvDestFields = new System.Windows.Forms.ListView();
            this.colPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.cbSourceTableFields = new System.Windows.Forms.ComboBox();
            this.gbConstraintName = new System.Windows.Forms.GroupBox();
            this.txtConstraintName = new System.Windows.Forms.TextBox();
            this.hsDropFK = new SeControlsLib.HotSpot();
            this.tabSyntax = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsSave = new SeControlsLib.HotSpot();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.fctInfo = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsNew = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlDependenciesUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbGenDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctGenDescription)).BeginInit();
            this.pnlProcedureAttributesUpper.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSourceFieldNames.SuspendLayout();
            this.gbSourceTable.SuspendLayout();
            this.gbDestinationTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDestinationFields.SuspendLayout();
            this.gbTypes.SuspendLayout();
            this.gbConstraintName.SuspendLayout();
            this.tabSyntax.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.gbSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctInfo)).BeginInit();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlDependenciesUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblProcedureName);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1374, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblProcedureName
            // 
            this.lblProcedureName.AutoSize = true;
            this.lblProcedureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedureName.Location = new System.Drawing.Point(71, 10);
            this.lblProcedureName.Name = "lblProcedureName";
            this.lblProcedureName.Size = new System.Drawing.Size(135, 20);
            this.lblProcedureName.TabIndex = 4;
            this.lblProcedureName.Text = "Procedurename";
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
            this.hsClose.Size = new System.Drawing.Size(45, 42);
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
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1374, 588);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPageFieldEdit);
            this.tabControlFields.Controls.Add(this.tabPageMessages);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.ImageList = this.ilTabControl;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1374, 588);
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
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1366, 561);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.splitContainer1);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 43);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1360, 515);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbGenDescription);
            this.splitContainer1.Panel1.Controls.Add(this.pnlProcedureAttributesUpper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabSyntax);
            this.splitContainer1.Size = new System.Drawing.Size(1360, 515);
            this.splitContainer1.SplitterDistance = 558;
            this.splitContainer1.TabIndex = 19;
            // 
            // gbGenDescription
            // 
            this.gbGenDescription.Controls.Add(this.fctGenDescription);
            this.gbGenDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGenDescription.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenDescription.Location = new System.Drawing.Point(0, 344);
            this.gbGenDescription.Name = "gbGenDescription";
            this.gbGenDescription.Size = new System.Drawing.Size(554, 167);
            this.gbGenDescription.TabIndex = 11;
            this.gbGenDescription.TabStop = false;
            this.gbGenDescription.Text = "Procedure description";
            // 
            // fctGenDescription
            // 
            this.fctGenDescription.AutoCompleteBracketsList = new char[] {
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
            this.fctGenDescription.AutoScrollMinSize = new System.Drawing.Size(2, 15);
            this.fctGenDescription.BackBrush = null;
            this.fctGenDescription.BackColor = System.Drawing.SystemColors.Window;
            this.fctGenDescription.CharHeight = 15;
            this.fctGenDescription.CharWidth = 7;
            this.fctGenDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctGenDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctGenDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctGenDescription.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fctGenDescription.IsReplaceMode = false;
            this.fctGenDescription.Location = new System.Drawing.Point(3, 16);
            this.fctGenDescription.Name = "fctGenDescription";
            this.fctGenDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctGenDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctGenDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctGenDescription.ServiceColors")));
            this.fctGenDescription.Size = new System.Drawing.Size(548, 148);
            this.fctGenDescription.TabIndex = 7;
            this.fctGenDescription.Zoom = 100;
            // 
            // pnlProcedureAttributesUpper
            // 
            this.pnlProcedureAttributesUpper.Controls.Add(this.groupBox2);
            this.pnlProcedureAttributesUpper.Controls.Add(this.hsAddSourceField);
            this.pnlProcedureAttributesUpper.Controls.Add(this.hsRemoveSourceField);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbSourceFieldNames);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbSourceTable);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbDestinationTable);
            this.pnlProcedureAttributesUpper.Controls.Add(this.groupBox1);
            this.pnlProcedureAttributesUpper.Controls.Add(this.groupBox4);
            this.pnlProcedureAttributesUpper.Controls.Add(this.hsAddDestField);
            this.pnlProcedureAttributesUpper.Controls.Add(this.hsRemoveDestField);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbDestinationFields);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbTypes);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbConstraintName);
            this.pnlProcedureAttributesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcedureAttributesUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlProcedureAttributesUpper.Name = "pnlProcedureAttributesUpper";
            this.pnlProcedureAttributesUpper.Size = new System.Drawing.Size(554, 344);
            this.pnlProcedureAttributesUpper.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIndexName);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(187, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 39);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Index Name";
            // 
            // txtIndexName
            // 
            this.txtIndexName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIndexName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIndexName.Location = new System.Drawing.Point(3, 16);
            this.txtIndexName.Name = "txtIndexName";
            this.txtIndexName.ReadOnly = true;
            this.txtIndexName.Size = new System.Drawing.Size(122, 20);
            this.txtIndexName.TabIndex = 0;
            this.txtIndexName.TextChanged += new System.EventHandler(this.txtIndexName_TextChanged);
            // 
            // hsAddSourceField
            // 
            this.hsAddSourceField.BackColor = System.Drawing.Color.Transparent;
            this.hsAddSourceField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddSourceField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddSourceField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddSourceField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddSourceField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddSourceField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddSourceField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddSourceField.FlatAppearance.BorderSize = 0;
            this.hsAddSourceField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddSourceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddSourceField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddSourceField.Image = global::FBXpert.Properties.Resources.plus_gn32x;
            this.hsAddSourceField.ImageHover = global::FBXpert.Properties.Resources.plus_blue32x;
            this.hsAddSourceField.ImageToggleOnSelect = true;
            this.hsAddSourceField.Location = new System.Drawing.Point(187, 97);
            this.hsAddSourceField.Marked = false;
            this.hsAddSourceField.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddSourceField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddSourceField.MarkedText = "";
            this.hsAddSourceField.MarkMode = false;
            this.hsAddSourceField.Name = "hsAddSourceField";
            this.hsAddSourceField.NonMarkedText = "";
            this.hsAddSourceField.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddSourceField.ShowShortcut = false;
            this.hsAddSourceField.Size = new System.Drawing.Size(45, 42);
            this.hsAddSourceField.TabIndex = 15;
            this.hsAddSourceField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddSourceField.ToolTipActive = false;
            this.hsAddSourceField.ToolTipAutomaticDelay = 500;
            this.hsAddSourceField.ToolTipAutoPopDelay = 5000;
            this.hsAddSourceField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddSourceField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddSourceField.ToolTipFor4ContextMenu = true;
            this.hsAddSourceField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddSourceField.ToolTipInitialDelay = 500;
            this.hsAddSourceField.ToolTipIsBallon = false;
            this.hsAddSourceField.ToolTipOwnerDraw = false;
            this.hsAddSourceField.ToolTipReshowDelay = 100;
            this.hsAddSourceField.ToolTipShowAlways = false;
            this.hsAddSourceField.ToolTipText = "";
            this.hsAddSourceField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddSourceField.ToolTipTitle = "";
            this.hsAddSourceField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddSourceField.UseVisualStyleBackColor = false;
            this.hsAddSourceField.Click += new System.EventHandler(this.hsAddSourceField_Click);
            // 
            // hsRemoveSourceField
            // 
            this.hsRemoveSourceField.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveSourceField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveSourceField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveSourceField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveSourceField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveSourceField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveSourceField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveSourceField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveSourceField.FlatAppearance.BorderSize = 0;
            this.hsRemoveSourceField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveSourceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRemoveSourceField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveSourceField.Image = global::FBXpert.Properties.Resources.minus_gn32x;
            this.hsRemoveSourceField.ImageHover = global::FBXpert.Properties.Resources.minus_blau32x;
            this.hsRemoveSourceField.ImageToggleOnSelect = true;
            this.hsRemoveSourceField.Location = new System.Drawing.Point(231, 97);
            this.hsRemoveSourceField.Marked = false;
            this.hsRemoveSourceField.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveSourceField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveSourceField.MarkedText = "";
            this.hsRemoveSourceField.MarkMode = false;
            this.hsRemoveSourceField.Name = "hsRemoveSourceField";
            this.hsRemoveSourceField.NonMarkedText = "";
            this.hsRemoveSourceField.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRemoveSourceField.ShowShortcut = false;
            this.hsRemoveSourceField.Size = new System.Drawing.Size(45, 42);
            this.hsRemoveSourceField.TabIndex = 14;
            this.hsRemoveSourceField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveSourceField.ToolTipActive = false;
            this.hsRemoveSourceField.ToolTipAutomaticDelay = 500;
            this.hsRemoveSourceField.ToolTipAutoPopDelay = 5000;
            this.hsRemoveSourceField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveSourceField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveSourceField.ToolTipFor4ContextMenu = true;
            this.hsRemoveSourceField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveSourceField.ToolTipInitialDelay = 500;
            this.hsRemoveSourceField.ToolTipIsBallon = false;
            this.hsRemoveSourceField.ToolTipOwnerDraw = false;
            this.hsRemoveSourceField.ToolTipReshowDelay = 100;
            this.hsRemoveSourceField.ToolTipShowAlways = false;
            this.hsRemoveSourceField.ToolTipText = "";
            this.hsRemoveSourceField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveSourceField.ToolTipTitle = "";
            this.hsRemoveSourceField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveSourceField.UseVisualStyleBackColor = false;
            this.hsRemoveSourceField.Click += new System.EventHandler(this.hsRemoveSourceField_Click);
            // 
            // gbSourceFieldNames
            // 
            this.gbSourceFieldNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSourceFieldNames.Controls.Add(this.lvSourceFields);
            this.gbSourceFieldNames.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSourceFieldNames.Location = new System.Drawing.Point(321, 6);
            this.gbSourceFieldNames.Name = "gbSourceFieldNames";
            this.gbSourceFieldNames.Size = new System.Drawing.Size(230, 156);
            this.gbSourceFieldNames.TabIndex = 13;
            this.gbSourceFieldNames.TabStop = false;
            this.gbSourceFieldNames.Text = "Source fields";
            // 
            // lvSourceFields
            // 
            this.lvSourceFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSourceFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSourceFields.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSourceFields.FullRowSelect = true;
            this.lvSourceFields.GridLines = true;
            this.lvSourceFields.HideSelection = false;
            this.lvSourceFields.Location = new System.Drawing.Point(3, 16);
            this.lvSourceFields.Name = "lvSourceFields";
            this.lvSourceFields.Size = new System.Drawing.Size(224, 137);
            this.lvSourceFields.TabIndex = 0;
            this.lvSourceFields.UseCompatibleStateImageBehavior = false;
            this.lvSourceFields.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fieldname";
            this.columnHeader2.Width = 200;
            // 
            // gbSourceTable
            // 
            this.gbSourceTable.Controls.Add(this.cbSourceTable);
            this.gbSourceTable.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSourceTable.Location = new System.Drawing.Point(6, 50);
            this.gbSourceTable.Name = "gbSourceTable";
            this.gbSourceTable.Size = new System.Drawing.Size(270, 41);
            this.gbSourceTable.TabIndex = 12;
            this.gbSourceTable.TabStop = false;
            this.gbSourceTable.Text = "Source Table";
            // 
            // cbSourceTable
            // 
            this.cbSourceTable.BackColor = System.Drawing.SystemColors.Info;
            this.cbSourceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSourceTable.FormattingEnabled = true;
            this.cbSourceTable.Location = new System.Drawing.Point(3, 16);
            this.cbSourceTable.Name = "cbSourceTable";
            this.cbSourceTable.Size = new System.Drawing.Size(264, 21);
            this.cbSourceTable.TabIndex = 1;
            this.cbSourceTable.SelectedIndexChanged += new System.EventHandler(this.cbSourceTable_SelectedIndexChanged);
            this.cbSourceTable.TextChanged += new System.EventHandler(this.edit_TextChanged);
            // 
            // gbDestinationTable
            // 
            this.gbDestinationTable.Controls.Add(this.cbDestinationTable);
            this.gbDestinationTable.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestinationTable.Location = new System.Drawing.Point(6, 168);
            this.gbDestinationTable.Name = "gbDestinationTable";
            this.gbDestinationTable.Size = new System.Drawing.Size(271, 41);
            this.gbDestinationTable.TabIndex = 11;
            this.gbDestinationTable.TabStop = false;
            this.gbDestinationTable.Text = "Destination Table";
            // 
            // cbDestinationTable
            // 
            this.cbDestinationTable.BackColor = System.Drawing.SystemColors.Info;
            this.cbDestinationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDestinationTable.FormattingEnabled = true;
            this.cbDestinationTable.Location = new System.Drawing.Point(3, 16);
            this.cbDestinationTable.Name = "cbDestinationTable";
            this.cbDestinationTable.Size = new System.Drawing.Size(265, 21);
            this.cbDestinationTable.TabIndex = 1;
            this.cbDestinationTable.SelectedIndexChanged += new System.EventHandler(this.cbDestinationTable_SelectedIndexChanged);
            this.cbDestinationTable.TextChanged += new System.EventHandler(this.edit_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrimaryKey);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 41);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary Key";
            // 
            // txtPrimaryKey
            // 
            this.txtPrimaryKey.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrimaryKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrimaryKey.Location = new System.Drawing.Point(3, 16);
            this.txtPrimaryKey.Name = "txtPrimaryKey";
            this.txtPrimaryKey.ReadOnly = true;
            this.txtPrimaryKey.Size = new System.Drawing.Size(169, 20);
            this.txtPrimaryKey.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDestinationTableFields);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 41);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination Field";
            // 
            // cbDestinationTableFields
            // 
            this.cbDestinationTableFields.BackColor = System.Drawing.SystemColors.Info;
            this.cbDestinationTableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDestinationTableFields.FormattingEnabled = true;
            this.cbDestinationTableFields.Location = new System.Drawing.Point(3, 16);
            this.cbDestinationTableFields.Name = "cbDestinationTableFields";
            this.cbDestinationTableFields.Size = new System.Drawing.Size(169, 21);
            this.cbDestinationTableFields.TabIndex = 1;
            // 
            // hsAddDestField
            // 
            this.hsAddDestField.BackColor = System.Drawing.Color.Transparent;
            this.hsAddDestField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddDestField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddDestField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddDestField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddDestField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddDestField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddDestField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddDestField.FlatAppearance.BorderSize = 0;
            this.hsAddDestField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddDestField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddDestField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddDestField.Image = global::FBXpert.Properties.Resources.plus_gn32x;
            this.hsAddDestField.ImageHover = global::FBXpert.Properties.Resources.plus_blue32x;
            this.hsAddDestField.ImageToggleOnSelect = true;
            this.hsAddDestField.Location = new System.Drawing.Point(184, 214);
            this.hsAddDestField.Marked = false;
            this.hsAddDestField.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddDestField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddDestField.MarkedText = "";
            this.hsAddDestField.MarkMode = false;
            this.hsAddDestField.Name = "hsAddDestField";
            this.hsAddDestField.NonMarkedText = "";
            this.hsAddDestField.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddDestField.ShowShortcut = false;
            this.hsAddDestField.Size = new System.Drawing.Size(45, 42);
            this.hsAddDestField.TabIndex = 8;
            this.hsAddDestField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddDestField.ToolTipActive = false;
            this.hsAddDestField.ToolTipAutomaticDelay = 500;
            this.hsAddDestField.ToolTipAutoPopDelay = 5000;
            this.hsAddDestField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddDestField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddDestField.ToolTipFor4ContextMenu = true;
            this.hsAddDestField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddDestField.ToolTipInitialDelay = 500;
            this.hsAddDestField.ToolTipIsBallon = false;
            this.hsAddDestField.ToolTipOwnerDraw = false;
            this.hsAddDestField.ToolTipReshowDelay = 100;
            this.hsAddDestField.ToolTipShowAlways = false;
            this.hsAddDestField.ToolTipText = "";
            this.hsAddDestField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddDestField.ToolTipTitle = "";
            this.hsAddDestField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddDestField.UseVisualStyleBackColor = false;
            this.hsAddDestField.Click += new System.EventHandler(this.hsAddField_Click);
            // 
            // hsRemoveDestField
            // 
            this.hsRemoveDestField.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveDestField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveDestField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveDestField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveDestField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveDestField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveDestField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveDestField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveDestField.FlatAppearance.BorderSize = 0;
            this.hsRemoveDestField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveDestField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRemoveDestField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveDestField.Image = global::FBXpert.Properties.Resources.minus_gn32x;
            this.hsRemoveDestField.ImageHover = global::FBXpert.Properties.Resources.minus_blau32x;
            this.hsRemoveDestField.ImageToggleOnSelect = true;
            this.hsRemoveDestField.Location = new System.Drawing.Point(232, 213);
            this.hsRemoveDestField.Marked = false;
            this.hsRemoveDestField.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveDestField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveDestField.MarkedText = "";
            this.hsRemoveDestField.MarkMode = false;
            this.hsRemoveDestField.Name = "hsRemoveDestField";
            this.hsRemoveDestField.NonMarkedText = "";
            this.hsRemoveDestField.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRemoveDestField.ShowShortcut = false;
            this.hsRemoveDestField.Size = new System.Drawing.Size(45, 42);
            this.hsRemoveDestField.TabIndex = 7;
            this.hsRemoveDestField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveDestField.ToolTipActive = false;
            this.hsRemoveDestField.ToolTipAutomaticDelay = 500;
            this.hsRemoveDestField.ToolTipAutoPopDelay = 5000;
            this.hsRemoveDestField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveDestField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveDestField.ToolTipFor4ContextMenu = true;
            this.hsRemoveDestField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveDestField.ToolTipInitialDelay = 500;
            this.hsRemoveDestField.ToolTipIsBallon = false;
            this.hsRemoveDestField.ToolTipOwnerDraw = false;
            this.hsRemoveDestField.ToolTipReshowDelay = 100;
            this.hsRemoveDestField.ToolTipShowAlways = false;
            this.hsRemoveDestField.ToolTipText = "";
            this.hsRemoveDestField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveDestField.ToolTipTitle = "";
            this.hsRemoveDestField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveDestField.UseVisualStyleBackColor = false;
            this.hsRemoveDestField.Click += new System.EventHandler(this.hsRemoveField_Click);
            // 
            // gbDestinationFields
            // 
            this.gbDestinationFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDestinationFields.Controls.Add(this.lvDestFields);
            this.gbDestinationFields.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestinationFields.Location = new System.Drawing.Point(321, 168);
            this.gbDestinationFields.Name = "gbDestinationFields";
            this.gbDestinationFields.Size = new System.Drawing.Size(230, 160);
            this.gbDestinationFields.TabIndex = 6;
            this.gbDestinationFields.TabStop = false;
            this.gbDestinationFields.Text = "Destination fields";
            // 
            // lvDestFields
            // 
            this.lvDestFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPos,
            this.colFieldName});
            this.lvDestFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDestFields.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDestFields.FullRowSelect = true;
            this.lvDestFields.GridLines = true;
            this.lvDestFields.HideSelection = false;
            this.lvDestFields.Location = new System.Drawing.Point(3, 16);
            this.lvDestFields.Name = "lvDestFields";
            this.lvDestFields.Size = new System.Drawing.Size(224, 141);
            this.lvDestFields.TabIndex = 0;
            this.lvDestFields.UseCompatibleStateImageBehavior = false;
            this.lvDestFields.View = System.Windows.Forms.View.Details;
            // 
            // colPos
            // 
            this.colPos.Text = "Nr";
            this.colPos.Width = 40;
            // 
            // colFieldName
            // 
            this.colFieldName.Text = "Fieldname";
            this.colFieldName.Width = 200;
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.cbSourceTableFields);
            this.gbTypes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTypes.Location = new System.Drawing.Point(6, 94);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Size = new System.Drawing.Size(175, 41);
            this.gbTypes.TabIndex = 4;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Source Field";
            // 
            // cbSourceTableFields
            // 
            this.cbSourceTableFields.BackColor = System.Drawing.SystemColors.Info;
            this.cbSourceTableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSourceTableFields.FormattingEnabled = true;
            this.cbSourceTableFields.Location = new System.Drawing.Point(3, 16);
            this.cbSourceTableFields.Name = "cbSourceTableFields";
            this.cbSourceTableFields.Size = new System.Drawing.Size(169, 21);
            this.cbSourceTableFields.TabIndex = 1;
            this.cbSourceTableFields.TextChanged += new System.EventHandler(this.edit_TextChanged);
            // 
            // gbConstraintName
            // 
            this.gbConstraintName.Controls.Add(this.txtConstraintName);
            this.gbConstraintName.Controls.Add(this.hsDropFK);
            this.gbConstraintName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConstraintName.Location = new System.Drawing.Point(6, 6);
            this.gbConstraintName.Name = "gbConstraintName";
            this.gbConstraintName.Size = new System.Drawing.Size(271, 42);
            this.gbConstraintName.TabIndex = 0;
            this.gbConstraintName.TabStop = false;
            this.gbConstraintName.Text = "Constraint name";
            // 
            // txtConstraintName
            // 
            this.txtConstraintName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConstraintName.Location = new System.Drawing.Point(3, 16);
            this.txtConstraintName.Name = "txtConstraintName";
            this.txtConstraintName.Size = new System.Drawing.Size(207, 20);
            this.txtConstraintName.TabIndex = 0;
            this.txtConstraintName.Text = "NEW_FK";
            this.txtConstraintName.TextChanged += new System.EventHandler(this.txtConstraintName_TextChanged);
            // 
            // hsDropFK
            // 
            this.hsDropFK.BackColor = System.Drawing.Color.Transparent;
            this.hsDropFK.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDropFK.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDropFK.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDropFK.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDropFK.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDropFK.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDropFK.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDropFK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDropFK.FlatAppearance.BorderSize = 0;
            this.hsDropFK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDropFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDropFK.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDropFK.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.hsDropFK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsDropFK.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x22;
            this.hsDropFK.ImageToggleOnSelect = false;
            this.hsDropFK.Location = new System.Drawing.Point(210, 16);
            this.hsDropFK.Marked = false;
            this.hsDropFK.MarkedColor = System.Drawing.Color.Teal;
            this.hsDropFK.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDropFK.MarkedText = "";
            this.hsDropFK.MarkMode = false;
            this.hsDropFK.Name = "hsDropFK";
            this.hsDropFK.NonMarkedText = "Drop";
            this.hsDropFK.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDropFK.ShowShortcut = false;
            this.hsDropFK.Size = new System.Drawing.Size(58, 23);
            this.hsDropFK.TabIndex = 2;
            this.hsDropFK.Text = "Drop";
            this.hsDropFK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDropFK.ToolTipActive = false;
            this.hsDropFK.ToolTipAutomaticDelay = 500;
            this.hsDropFK.ToolTipAutoPopDelay = 5000;
            this.hsDropFK.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDropFK.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDropFK.ToolTipFor4ContextMenu = true;
            this.hsDropFK.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDropFK.ToolTipInitialDelay = 500;
            this.hsDropFK.ToolTipIsBallon = false;
            this.hsDropFK.ToolTipOwnerDraw = false;
            this.hsDropFK.ToolTipReshowDelay = 100;
            this.hsDropFK.ToolTipShowAlways = false;
            this.hsDropFK.ToolTipText = "";
            this.hsDropFK.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDropFK.ToolTipTitle = "";
            this.hsDropFK.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDropFK.UseVisualStyleBackColor = false;
            this.hsDropFK.Click += new System.EventHandler(this.hsDropFK_Click);
            // 
            // tabSyntax
            // 
            this.tabSyntax.Controls.Add(this.tabPageSQL);
            this.tabSyntax.Controls.Add(this.tabInfo);
            this.tabSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSyntax.ImageList = this.ilTabControl;
            this.tabSyntax.Location = new System.Drawing.Point(0, 0);
            this.tabSyntax.Name = "tabSyntax";
            this.tabSyntax.SelectedIndex = 0;
            this.tabSyntax.Size = new System.Drawing.Size(794, 511);
            this.tabSyntax.TabIndex = 10;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.gbSQL);
            this.tabPageSQL.Controls.Add(this.pnlSQLUpper);
            this.tabPageSQL.ImageIndex = 5;
            this.tabPageSQL.Location = new System.Drawing.Point(4, 23);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(786, 484);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.fctSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(3, 46);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(780, 435);
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(25, 14);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fctSQL.CharHeight = 14;
            this.fctSQL.CharWidth = 7;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(3, 16);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(774, 416);
            this.fctSQL.TabIndex = 0;
            this.fctSQL.Zoom = 100;
            this.fctSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctSQL_KeyDown);
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlSQLUpper.Controls.Add(this.hsSave);
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(780, 43);
            this.pnlSQLUpper.TabIndex = 10;
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
            this.hsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSave.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSave.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSave.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsSave.ImageToggleOnSelect = false;
            this.hsSave.Location = new System.Drawing.Point(162, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "Execute";
            this.hsSave.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSave.ShowShortcut = false;
            this.hsSave.Size = new System.Drawing.Size(87, 43);
            this.hsSave.TabIndex = 1;
            this.hsSave.Text = "Execute";
            this.hsSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.hsLoadSQL.Location = new System.Drawing.Point(80, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadSQL.ShowShortcut = false;
            this.hsLoadSQL.Size = new System.Drawing.Size(82, 43);
            this.hsLoadSQL.TabIndex = 7;
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
            this.hsSaveSQL.Location = new System.Drawing.Point(0, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveSQL.ShowShortcut = false;
            this.hsSaveSQL.Size = new System.Drawing.Size(80, 43);
            this.hsSaveSQL.TabIndex = 6;
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
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.fctInfo);
            this.tabInfo.Controls.Add(this.pnlInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 23);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(786, 484);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Info, Syntax";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // fctInfo
            // 
            this.fctInfo.AutoCompleteBracketsList = new char[] {
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
            this.fctInfo.AutoIndentCharsPatterns = "";
            this.fctInfo.AutoScrollMinSize = new System.Drawing.Size(380, 98);
            this.fctInfo.BackBrush = null;
            this.fctInfo.BackColor = System.Drawing.SystemColors.Info;
            this.fctInfo.CharHeight = 14;
            this.fctInfo.CharWidth = 7;
            this.fctInfo.CommentPrefix = "--";
            this.fctInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctInfo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctInfo.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctInfo.IsReplaceMode = false;
            this.fctInfo.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctInfo.LeftBracket = '(';
            this.fctInfo.Location = new System.Drawing.Point(3, 46);
            this.fctInfo.Name = "fctInfo";
            this.fctInfo.Paddings = new System.Windows.Forms.Padding(0);
            this.fctInfo.RightBracket = ')';
            this.fctInfo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctInfo.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctInfo.ServiceColors")));
            this.fctInfo.Size = new System.Drawing.Size(780, 435);
            this.fctInfo.TabIndex = 11;
            this.fctInfo.Text = resources.GetString("fctInfo.Text");
            this.fctInfo.Zoom = 100;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.LightGray;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(780, 43);
            this.pnlInfo.TabIndex = 12;
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
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsNew);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1360, 40);
            this.pnlFieldUpper.TabIndex = 1;
            // 
            // hsNew
            // 
            this.hsNew.BackColor = System.Drawing.Color.Transparent;
            this.hsNew.BackColorHover = System.Drawing.Color.Transparent;
            this.hsNew.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsNew.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsNew.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsNew.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsNew.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsNew.FlatAppearance.BorderSize = 0;
            this.hsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsNew.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsNew.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsNew.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsNew.ImageToggleOnSelect = true;
            this.hsNew.Location = new System.Drawing.Point(0, 0);
            this.hsNew.Marked = false;
            this.hsNew.MarkedColor = System.Drawing.Color.Teal;
            this.hsNew.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNew.MarkedText = "";
            this.hsNew.MarkMode = false;
            this.hsNew.Name = "hsNew";
            this.hsNew.NonMarkedText = "New";
            this.hsNew.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsNew.ShowShortcut = false;
            this.hsNew.Size = new System.Drawing.Size(45, 36);
            this.hsNew.TabIndex = 16;
            this.hsNew.Text = "New";
            this.hsNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsNew.ToolTipActive = false;
            this.hsNew.ToolTipAutomaticDelay = 500;
            this.hsNew.ToolTipAutoPopDelay = 5000;
            this.hsNew.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsNew.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsNew.ToolTipFor4ContextMenu = true;
            this.hsNew.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsNew.ToolTipInitialDelay = 500;
            this.hsNew.ToolTipIsBallon = false;
            this.hsNew.ToolTipOwnerDraw = false;
            this.hsNew.ToolTipReshowDelay = 100;
            this.hsNew.ToolTipShowAlways = false;
            this.hsNew.ToolTipText = "";
            this.hsNew.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsNew.ToolTipTitle = "";
            this.hsNew.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsNew.UseVisualStyleBackColor = false;
            this.hsNew.Click += new System.EventHandler(this.hsNew_Click);
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.fctMessages);
            this.tabPageMessages.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1366, 561);
            this.tabPageMessages.TabIndex = 1;
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
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 14;
            this.fctMessages.CharWidth = 7;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(3, 53);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.ReadOnly = true;
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1360, 505);
            this.fctMessages.TabIndex = 22;
            this.fctMessages.WordWrap = true;
            this.fctMessages.Zoom = 100;
            // 
            // pnlDependenciesUpper
            // 
            this.pnlDependenciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDependenciesUpper.Controls.Add(this.hsClearMessages);
            this.pnlDependenciesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1360, 50);
            this.pnlDependenciesUpper.TabIndex = 21;
            // 
            // hsClearMessages
            // 
            this.hsClearMessages.BackColor = System.Drawing.Color.Transparent;
            this.hsClearMessages.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearMessages.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearMessages.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearMessages.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearMessages.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearMessages.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearMessages.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClearMessages.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClearMessages.FlatAppearance.BorderSize = 0;
            this.hsClearMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearMessages.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearMessages.Image = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearMessages.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearMessages.ImageHover = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hsClearMessages.ImageToggleOnSelect = true;
            this.hsClearMessages.Location = new System.Drawing.Point(0, 0);
            this.hsClearMessages.Marked = false;
            this.hsClearMessages.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearMessages.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearMessages.MarkedText = "";
            this.hsClearMessages.MarkMode = false;
            this.hsClearMessages.Name = "hsClearMessages";
            this.hsClearMessages.NonMarkedText = "Clear";
            this.hsClearMessages.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearMessages.ShowShortcut = false;
            this.hsClearMessages.Size = new System.Drawing.Size(45, 46);
            this.hsClearMessages.TabIndex = 3;
            this.hsClearMessages.Text = "Clear";
            this.hsClearMessages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClearMessages.ToolTipActive = false;
            this.hsClearMessages.ToolTipAutomaticDelay = 500;
            this.hsClearMessages.ToolTipAutoPopDelay = 5000;
            this.hsClearMessages.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearMessages.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearMessages.ToolTipFor4ContextMenu = true;
            this.hsClearMessages.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearMessages.ToolTipInitialDelay = 500;
            this.hsClearMessages.ToolTipIsBallon = false;
            this.hsClearMessages.ToolTipOwnerDraw = false;
            this.hsClearMessages.ToolTipReshowDelay = 100;
            this.hsClearMessages.ToolTipShowAlways = false;
            this.hsClearMessages.ToolTipText = "";
            this.hsClearMessages.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearMessages.ToolTipTitle = "";
            this.hsClearMessages.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearMessages.UseVisualStyleBackColor = false;
            this.hsClearMessages.Click += new System.EventHandler(this.hsClearMessages_Click);
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
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1311, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshDependencies.ShowShortcut = false;
            this.hsRefreshDependencies.Size = new System.Drawing.Size(45, 46);
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
            // ofdSQL
            // 
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
            // 
            // saveSQLFile
            // 
            this.saveSQLFile.DefaultExt = "*.sql";
            this.saveSQLFile.Filter = "SQL|*.sql|All|*.*";
            this.saveSQLFile.Title = "Save SQL ";
            // 
            // ForeignKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 630);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForeignKeyForm";
            this.Text = "ForeignKeyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForeignKeyForm_FormClosing);
            this.Load += new System.EventHandler(this.ForeignKeyForm_Load);
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
            this.gbGenDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctGenDescription)).EndInit();
            this.pnlProcedureAttributesUpper.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSourceFieldNames.ResumeLayout(false);
            this.gbSourceTable.ResumeLayout(false);
            this.gbDestinationTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gbDestinationFields.ResumeLayout(false);
            this.gbTypes.ResumeLayout(false);
            this.gbConstraintName.ResumeLayout(false);
            this.gbConstraintName.PerformLayout();
            this.tabSyntax.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctInfo)).EndInit();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlDependenciesUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.GroupBox gbConstraintName;
        private System.Windows.Forms.TextBox txtConstraintName;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.GroupBox gbGenDescription;
        private FastColoredTextBoxNS.FastColoredTextBox fctGenDescription;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlProcedureAttributesUpper;
        private System.Windows.Forms.TabControl tabSyntax;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.ImageList ilTabControl;
        private SeControlsLib.HotSpot hsClearMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.Label lblProcedureName;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.ComboBox cbSourceTableFields;
        private System.Windows.Forms.GroupBox gbDestinationFields;
        private System.Windows.Forms.ListView lvDestFields;
        private System.Windows.Forms.ColumnHeader colFieldName;
        private System.Windows.Forms.ColumnHeader colPos;
        private SeControlsLib.HotSpot hsAddDestField;
        private SeControlsLib.HotSpot hsRemoveDestField;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbDestinationTableFields;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDestinationTable;
        private System.Windows.Forms.ComboBox cbDestinationTable;
        private System.Windows.Forms.GroupBox gbSourceTable;
        private System.Windows.Forms.ComboBox cbSourceTable;
        private SeControlsLib.HotSpot hsDropFK;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private FastColoredTextBoxNS.FastColoredTextBox fctInfo;
        private SeControlsLib.HotSpot hsAddSourceField;
        private SeControlsLib.HotSpot hsRemoveSourceField;
        private System.Windows.Forms.GroupBox gbSourceFieldNames;
        private System.Windows.Forms.ListView lvSourceFields;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIndexName;
        private SeControlsLib.HotSpot hsNew;
        private System.Windows.Forms.TextBox txtPrimaryKey;
    }
}