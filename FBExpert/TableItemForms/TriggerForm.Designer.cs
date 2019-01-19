using BasicForms;

namespace FBXpert
{
    partial class TriggerForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.fctGenDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlProcedureAttributesUpper = new System.Windows.Forms.Panel();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.gbTriggerName = new System.Windows.Forms.GroupBox();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.gbTriggerTyp = new System.Windows.Forms.GroupBox();
            this.cbDELETE = new System.Windows.Forms.CheckBox();
            this.cbUPDATE = new System.Windows.Forms.CheckBox();
            this.cbINSERT = new System.Windows.Forms.CheckBox();
            this.rbAFTER = new System.Windows.Forms.RadioButton();
            this.rbBEFORE = new System.Windows.Forms.RadioButton();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.txtGenValue = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsCreate = new SeControlsLib.HotSpot();
            this.tabProcedureDefinition = new System.Windows.Forms.TabPage();
            this.spcProcedureSQL = new System.Windows.Forms.SplitContainer();
            this.gbProcedureDefinitionSQL = new System.Windows.Forms.GroupBox();
            this.fcbTriggerDefinitionSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsSave = new SeControlsLib.HotSpot();
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
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.dsDependenciesFrom = new System.Data.DataSet();
            this.dataTable6 = new System.Data.DataTable();
            this.bsDependenciesFrom = new System.Windows.Forms.BindingSource(this.components);
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
            this.gbDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctGenDescription)).BeginInit();
            this.pnlProcedureAttributesUpper.SuspendLayout();
            this.gbTable.SuspendLayout();
            this.gbTriggerName.SuspendLayout();
            this.gbTriggerTyp.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.gbSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.tabProcedureDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcProcedureSQL)).BeginInit();
            this.spcProcedureSQL.Panel2.SuspendLayout();
            this.spcProcedureSQL.SuspendLayout();
            this.gbProcedureDefinitionSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbTriggerDefinitionSQL)).BeginInit();
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
            this.pnlUpper.Size = new System.Drawing.Size(1276, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(75, 10);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 3;
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
            this.pnlCenter.Size = new System.Drawing.Size(1276, 609);
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
            this.tabControlFields.Size = new System.Drawing.Size(1276, 609);
            this.tabControlFields.TabIndex = 18;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldUpper);
            this.tabPageFieldEdit.ImageIndex = 2;
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 23);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1268, 582);
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
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1262, 536);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbDescription);
            this.splitContainer1.Panel1.Controls.Add(this.pnlProcedureAttributesUpper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 536);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 19;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.fctGenDescription);
            this.gbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDescription.Location = new System.Drawing.Point(0, 253);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(282, 283);
            this.gbDescription.TabIndex = 11;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Description";
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
            this.fctGenDescription.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctGenDescription.BackBrush = null;
            this.fctGenDescription.BackColor = System.Drawing.SystemColors.Window;
            this.fctGenDescription.CharHeight = 14;
            this.fctGenDescription.CharWidth = 8;
            this.fctGenDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctGenDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctGenDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctGenDescription.IsReplaceMode = false;
            this.fctGenDescription.Location = new System.Drawing.Point(3, 16);
            this.fctGenDescription.Name = "fctGenDescription";
            this.fctGenDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctGenDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctGenDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctGenDescription.ServiceColors")));
            this.fctGenDescription.Size = new System.Drawing.Size(276, 264);
            this.fctGenDescription.TabIndex = 7;
            this.fctGenDescription.Zoom = 100;
            this.fctGenDescription.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.TextChanged);
            // 
            // pnlProcedureAttributesUpper
            // 
            this.pnlProcedureAttributesUpper.Controls.Add(this.cbIsActive);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbTable);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbTriggerName);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbTriggerTyp);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbPosition);
            this.pnlProcedureAttributesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcedureAttributesUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlProcedureAttributesUpper.Name = "pnlProcedureAttributesUpper";
            this.pnlProcedureAttributesUpper.Size = new System.Drawing.Size(282, 253);
            this.pnlProcedureAttributesUpper.TabIndex = 0;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(220, 22);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(56, 17);
            this.cbIsActive.TabIndex = 18;
            this.cbIsActive.Text = "Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            this.cbIsActive.CheckedChanged += new System.EventHandler(this.TextChanged);
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.cbTable);
            this.gbTable.Location = new System.Drawing.Point(3, 54);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(204, 42);
            this.gbTable.TabIndex = 3;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Table";
            // 
            // cbTable
            // 
            this.cbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(3, 16);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(198, 21);
            this.cbTable.TabIndex = 1;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.TextChanged);
            // 
            // gbTriggerName
            // 
            this.gbTriggerName.Controls.Add(this.txtTriggerName);
            this.gbTriggerName.Location = new System.Drawing.Point(3, 6);
            this.gbTriggerName.Name = "gbTriggerName";
            this.gbTriggerName.Size = new System.Drawing.Size(200, 42);
            this.gbTriggerName.TabIndex = 0;
            this.gbTriggerName.TabStop = false;
            this.gbTriggerName.Text = "Trigger name";
            
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTriggerName.Location = new System.Drawing.Point(3, 16);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.Size = new System.Drawing.Size(194, 20);
            this.txtTriggerName.TabIndex = 0;
            this.txtTriggerName.Text = "NEW_TRG";
            this.txtTriggerName.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // gbTriggerTyp
            // 
            this.gbTriggerTyp.Controls.Add(this.cbDELETE);
            this.gbTriggerTyp.Controls.Add(this.cbUPDATE);
            this.gbTriggerTyp.Controls.Add(this.cbINSERT);
            this.gbTriggerTyp.Controls.Add(this.rbAFTER);
            this.gbTriggerTyp.Controls.Add(this.rbBEFORE);
            this.gbTriggerTyp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbTriggerTyp.Location = new System.Drawing.Point(0, 155);
            this.gbTriggerTyp.Name = "gbTriggerTyp";
            this.gbTriggerTyp.Size = new System.Drawing.Size(282, 98);
            this.gbTriggerTyp.TabIndex = 2;
            this.gbTriggerTyp.TabStop = false;
            this.gbTriggerTyp.Text = "Trigger FieldType";
            // 
            // cbDELETE
            // 
            this.cbDELETE.AutoSize = true;
            this.cbDELETE.Location = new System.Drawing.Point(155, 65);
            this.cbDELETE.Name = "cbDELETE";
            this.cbDELETE.Size = new System.Drawing.Size(57, 17);
            this.cbDELETE.TabIndex = 4;
            this.cbDELETE.Text = "Delete";
            this.cbDELETE.UseVisualStyleBackColor = true;
            this.cbDELETE.CheckedChanged += new System.EventHandler(this.TextChanged);
            // 
            // cbUPDATE
            // 
            this.cbUPDATE.AutoSize = true;
            this.cbUPDATE.Location = new System.Drawing.Point(155, 42);
            this.cbUPDATE.Name = "cbUPDATE";
            this.cbUPDATE.Size = new System.Drawing.Size(61, 17);
            this.cbUPDATE.TabIndex = 3;
            this.cbUPDATE.Text = "Update";
            this.cbUPDATE.UseVisualStyleBackColor = true;
            this.cbUPDATE.CheckedChanged += new System.EventHandler(this.TextChanged);
            // 
            // cbINSERT
            // 
            this.cbINSERT.AutoSize = true;
            this.cbINSERT.Checked = true;
            this.cbINSERT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbINSERT.Location = new System.Drawing.Point(155, 19);
            this.cbINSERT.Name = "cbINSERT";
            this.cbINSERT.Size = new System.Drawing.Size(52, 17);
            this.cbINSERT.TabIndex = 2;
            this.cbINSERT.Text = "Insert";
            this.cbINSERT.UseVisualStyleBackColor = true;
            this.cbINSERT.CheckedChanged += new System.EventHandler(this.TextChanged);
            // 
            // rbAFTER
            // 
            this.rbAFTER.AutoSize = true;
            this.rbAFTER.Location = new System.Drawing.Point(9, 41);
            this.rbAFTER.Name = "rbAFTER";
            this.rbAFTER.Size = new System.Drawing.Size(47, 17);
            this.rbAFTER.TabIndex = 1;
            this.rbAFTER.Text = "After";
            this.rbAFTER.UseVisualStyleBackColor = true;
            this.rbAFTER.CheckedChanged += new System.EventHandler(this.TextChanged);
            // 
            // rbBEFORE
            // 
            this.rbBEFORE.AutoSize = true;
            this.rbBEFORE.Checked = true;
            this.rbBEFORE.Location = new System.Drawing.Point(9, 18);
            this.rbBEFORE.Name = "rbBEFORE";
            this.rbBEFORE.Size = new System.Drawing.Size(56, 17);
            this.rbBEFORE.TabIndex = 0;
            this.rbBEFORE.TabStop = true;
            this.rbBEFORE.Text = "Before";
            this.rbBEFORE.UseVisualStyleBackColor = true;
            this.rbBEFORE.CheckedChanged += new System.EventHandler(this.TextChanged);
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.txtGenValue);
            this.gbPosition.Location = new System.Drawing.Point(216, 54);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(60, 45);
            this.gbPosition.TabIndex = 17;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Position";
            
            // 
            // txtGenValue
            // 
            this.txtGenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGenValue.Location = new System.Drawing.Point(3, 16);
            this.txtGenValue.Name = "txtGenValue";
            this.txtGenValue.Size = new System.Drawing.Size(54, 20);
            this.txtGenValue.TabIndex = 0;
            this.txtGenValue.Text = "0";
            this.txtGenValue.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabProcedureDefinition);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 536);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.gbSQL);
            this.tabPageSQL.Controls.Add(this.pnlSQLUpper);
            this.tabPageSQL.ImageIndex = 5;
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(968, 510);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.fctSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(3, 43);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(962, 464);
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(25, 12);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fctSQL.CharHeight = 12;
            this.fctSQL.CharWidth = 7;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(3, 16);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(956, 445);
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
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(962, 40);
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
            this.hsLoadSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQL.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(159, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(82, 36);
            this.hsLoadSQL.TabIndex = 11;
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
            this.hsSaveSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveSQL.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSaveSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveSQL.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSaveSQL.ImageToggleOnSelect = true;
            this.hsSaveSQL.Location = new System.Drawing.Point(79, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Size = new System.Drawing.Size(80, 36);
            this.hsSaveSQL.TabIndex = 10;
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
            this.hsCreate.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreate.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCreate.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsCreate.ImageToggleOnSelect = true;
            this.hsCreate.Location = new System.Drawing.Point(0, 0);
            this.hsCreate.Marked = false;
            this.hsCreate.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreate.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreate.MarkedText = "";
            this.hsCreate.MarkMode = false;
            this.hsCreate.Name = "hsCreate";
            this.hsCreate.NonMarkedText = "Execute";
            this.hsCreate.Size = new System.Drawing.Size(79, 36);
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
            this.hsCreate.Click += new System.EventHandler(this.hsCreate_Click);
            // 
            // tabProcedureDefinition
            // 
            this.tabProcedureDefinition.Controls.Add(this.spcProcedureSQL);
            this.tabProcedureDefinition.ImageIndex = 8;
            this.tabProcedureDefinition.Location = new System.Drawing.Point(4, 22);
            this.tabProcedureDefinition.Name = "tabProcedureDefinition";
            this.tabProcedureDefinition.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedureDefinition.Size = new System.Drawing.Size(968, 510);
            this.tabProcedureDefinition.TabIndex = 1;
            this.tabProcedureDefinition.Text = "Procedure Definition";
            this.tabProcedureDefinition.UseVisualStyleBackColor = true;
            // 
            // spcProcedureSQL
            // 
            this.spcProcedureSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcProcedureSQL.Location = new System.Drawing.Point(3, 3);
            this.spcProcedureSQL.Name = "spcProcedureSQL";
            // 
            // spcProcedureSQL.Panel2
            // 
            this.spcProcedureSQL.Panel2.Controls.Add(this.gbProcedureDefinitionSQL);
            this.spcProcedureSQL.Size = new System.Drawing.Size(962, 504);
            this.spcProcedureSQL.SplitterDistance = 308;
            this.spcProcedureSQL.TabIndex = 11;
            // 
            // gbProcedureDefinitionSQL
            // 
            this.gbProcedureDefinitionSQL.Controls.Add(this.fcbTriggerDefinitionSQL);
            this.gbProcedureDefinitionSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProcedureDefinitionSQL.Location = new System.Drawing.Point(0, 0);
            this.gbProcedureDefinitionSQL.Name = "gbProcedureDefinitionSQL";
            this.gbProcedureDefinitionSQL.Size = new System.Drawing.Size(650, 504);
            this.gbProcedureDefinitionSQL.TabIndex = 10;
            this.gbProcedureDefinitionSQL.TabStop = false;
            this.gbProcedureDefinitionSQL.Text = "SQL";
            // 
            // fcbTriggerDefinitionSQL
            // 
            this.fcbTriggerDefinitionSQL.AutoCompleteBracketsList = new char[] {
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
            this.fcbTriggerDefinitionSQL.AutoIndentCharsPatterns = "";
            this.fcbTriggerDefinitionSQL.AutoScrollMinSize = new System.Drawing.Size(2, 12);
            this.fcbTriggerDefinitionSQL.BackBrush = null;
            this.fcbTriggerDefinitionSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fcbTriggerDefinitionSQL.CharHeight = 12;
            this.fcbTriggerDefinitionSQL.CharWidth = 7;
            this.fcbTriggerDefinitionSQL.CommentPrefix = "--";
            this.fcbTriggerDefinitionSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbTriggerDefinitionSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbTriggerDefinitionSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbTriggerDefinitionSQL.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fcbTriggerDefinitionSQL.IsReplaceMode = false;
            this.fcbTriggerDefinitionSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbTriggerDefinitionSQL.LeftBracket = '(';
            this.fcbTriggerDefinitionSQL.Location = new System.Drawing.Point(3, 16);
            this.fcbTriggerDefinitionSQL.Name = "fcbTriggerDefinitionSQL";
            this.fcbTriggerDefinitionSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbTriggerDefinitionSQL.RightBracket = ')';
            this.fcbTriggerDefinitionSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbTriggerDefinitionSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbTriggerDefinitionSQL.ServiceColors")));
            this.fcbTriggerDefinitionSQL.Size = new System.Drawing.Size(644, 485);
            this.fcbTriggerDefinitionSQL.TabIndex = 0;
            this.fcbTriggerDefinitionSQL.Zoom = 100;
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsSave);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1262, 40);
            this.pnlFieldUpper.TabIndex = 1;
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
            this.hsSave.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSave.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsSave.ImageToggleOnSelect = true;
            this.hsSave.Location = new System.Drawing.Point(0, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "New";
            this.hsSave.Size = new System.Drawing.Size(79, 36);
            this.hsSave.TabIndex = 1;
            this.hsSave.Text = "New";
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
            
            // 
            // tabPageDependencies
            // 
            this.tabPageDependencies.Controls.Add(this.dgvDependenciesTo);
            this.tabPageDependencies.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageDependencies.ImageIndex = 11;
            this.tabPageDependencies.Location = new System.Drawing.Point(4, 23);
            this.tabPageDependencies.Name = "tabPageDependencies";
            this.tabPageDependencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependencies.Size = new System.Drawing.Size(1268, 582);
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
            this.dgvDependenciesTo.Location = new System.Drawing.Point(3, 43);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1262, 536);
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
            this.pnlDependenciesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDependenciesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1262, 40);
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
            this.hsRefreshDependencies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefreshDependencies.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependencies.ImageToggleOnSelect = true;
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1173, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "Refresh";
            this.hsRefreshDependencies.Size = new System.Drawing.Size(85, 36);
            this.hsRefreshDependencies.TabIndex = 2;
            this.hsRefreshDependencies.Text = "Refresh";
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
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1268, 582);
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
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 14;
            this.fctMessages.CharWidth = 8;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(3, 43);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1262, 536);
            this.fctMessages.TabIndex = 30;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsRefresh);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1262, 40);
            this.pnlMessagesUpper.TabIndex = 29;
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
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(1171, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "Refresh";
            this.hsRefresh.Size = new System.Drawing.Size(87, 36);
            this.hsRefresh.TabIndex = 2;
            this.hsRefresh.Text = "Refresh";
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
            this.ilTabControl.Images.SetKeyName(11, "media_playlist_shuffle_x32.png");
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
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 651);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TriggerForm";
            this.Text = "TriggerForm";
            this.Load += new System.EventHandler(this.TriggerForm_Load);
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
            this.gbDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctGenDescription)).EndInit();
            this.pnlProcedureAttributesUpper.ResumeLayout(false);
            this.pnlProcedureAttributesUpper.PerformLayout();
            this.gbTable.ResumeLayout(false);
            this.gbTriggerName.ResumeLayout(false);
            this.gbTriggerName.PerformLayout();
            this.gbTriggerTyp.ResumeLayout(false);
            this.gbTriggerTyp.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.tabProcedureDefinition.ResumeLayout(false);
            this.spcProcedureSQL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcProcedureSQL)).EndInit();
            this.spcProcedureSQL.ResumeLayout(false);
            this.gbProcedureDefinitionSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbTriggerDefinitionSQL)).EndInit();
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
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.TextBox txtGenValue;
        private System.Windows.Forms.GroupBox gbTriggerName;
        private System.Windows.Forms.TextBox txtTriggerName;
        private System.Windows.Forms.GroupBox gbDescription;
        private FastColoredTextBoxNS.FastColoredTextBox fctGenDescription;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabPageDependencies;
        private System.Windows.Forms.DataGridView dgvDependenciesTo;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private System.Windows.Forms.BindingSource bsDependenciesTo;
        private System.Data.DataSet dsDependenciesTo;
        private System.Data.DataTable dataTable5;
        private System.Data.DataSet dsDependenciesFrom;
        private System.Data.DataTable dataTable6;
        private System.Windows.Forms.BindingSource bsDependenciesFrom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlProcedureAttributesUpper;
        private System.Windows.Forms.TabPage tabPageMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.GroupBox gbTriggerTyp;
        private System.Windows.Forms.CheckBox cbDELETE;
        private System.Windows.Forms.CheckBox cbUPDATE;
        private System.Windows.Forms.CheckBox cbINSERT;
        private System.Windows.Forms.RadioButton rbAFTER;
        private System.Windows.Forms.RadioButton rbBEFORE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.GroupBox gbSQL;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.TabPage tabProcedureDefinition;
        private System.Windows.Forms.SplitContainer spcProcedureSQL;
        private System.Windows.Forms.GroupBox gbProcedureDefinitionSQL;
        private FastColoredTextBoxNS.FastColoredTextBox fcbTriggerDefinitionSQL;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsCreate;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
    }
}