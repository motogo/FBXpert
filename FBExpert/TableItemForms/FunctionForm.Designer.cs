using BasicForms;

namespace FBXpert
{
    partial class FunctionForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionForm));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.pnlFormUpper = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbGenDescription = new System.Windows.Forms.GroupBox();
            this.fctGenDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlProcedureAttributes = new System.Windows.Forms.Panel();
            this.gbGenName = new System.Windows.Forms.GroupBox();
            this.txtFuncName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsCreate = new SeControlsLib.HotSpot();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.tabProcedureDefinition = new System.Windows.Forms.TabPage();
            this.spcProcedureSQL = new System.Windows.Forms.SplitContainer();
            this.lvFields = new System.Windows.Forms.ListView();
            this.colTYP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPARAMETER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPARTYP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsParameters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddInputParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddOutputParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDropParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlParameterLower = new System.Windows.Forms.Panel();
            this.gbParamTyp = new System.Windows.Forms.GroupBox();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.cbDatatype = new System.Windows.Forms.ComboBox();
            this.txtDatatypeLength = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVAR = new System.Windows.Forms.RadioButton();
            this.rbOUT = new System.Windows.Forms.RadioButton();
            this.rbIN = new System.Windows.Forms.RadioButton();
            this.gbParameterName = new System.Windows.Forms.GroupBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.gbProcedureDefinitionSQL = new System.Windows.Forms.GroupBox();
            this.fcbFunctionDefinitionSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsNew = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.bsDependenciesTo = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependenciesTo = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.dsDependenciesFrom = new System.Data.DataSet();
            this.dataTable6 = new System.Data.DataTable();
            this.bsDependenciesFrom = new System.Windows.Forms.BindingSource(this.components);
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.pnlFormUpper.SuspendLayout();
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
            this.pnlProcedureAttributes.SuspendLayout();
            this.gbGenName.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.gbSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.tabProcedureDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcProcedureSQL)).BeginInit();
            this.spcProcedureSQL.Panel1.SuspendLayout();
            this.spcProcedureSQL.Panel2.SuspendLayout();
            this.spcProcedureSQL.SuspendLayout();
            this.cmsParameters.SuspendLayout();
            this.pnlParameterLower.SuspendLayout();
            this.gbParamTyp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbParameterName.SuspendLayout();
            this.gbProcedureDefinitionSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbFunctionDefinitionSQL)).BeginInit();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessagesUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormUpper
            // 
            this.pnlFormUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFormUpper.Controls.Add(this.lblCaption);
            this.pnlFormUpper.Controls.Add(this.hsClose);
            this.pnlFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUpper.Name = "pnlFormUpper";
            this.pnlFormUpper.Size = new System.Drawing.Size(1229, 45);
            this.pnlFormUpper.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(71, 11);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(135, 20);
            this.lblCaption.TabIndex = 4;
            this.lblCaption.Text = "Procedurename";
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
            this.hsClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsClose.ShortcutNewline = false;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(45, 45);
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
            this.pnlCenter.Location = new System.Drawing.Point(0, 45);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1229, 726);
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
            this.tabControlFields.Size = new System.Drawing.Size(1229, 726);
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
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1221, 699);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.splitContainer1);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 46);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1215, 650);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbGenDescription);
            this.splitContainer1.Panel1.Controls.Add(this.pnlProcedureAttributes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1215, 650);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 19;
            // 
            // gbGenDescription
            // 
            this.gbGenDescription.Controls.Add(this.fctGenDescription);
            this.gbGenDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGenDescription.Location = new System.Drawing.Point(0, 389);
            this.gbGenDescription.Name = "gbGenDescription";
            this.gbGenDescription.Size = new System.Drawing.Size(312, 257);
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
            this.fctGenDescription.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);";
            this.fctGenDescription.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctGenDescription.BackBrush = null;
            this.fctGenDescription.BackColor = System.Drawing.SystemColors.Window;
            this.fctGenDescription.CharHeight = 14;
            this.fctGenDescription.CharWidth = 8;
            this.fctGenDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctGenDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctGenDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctGenDescription.IsReplaceMode = false;
            this.fctGenDescription.Location = new System.Drawing.Point(3, 18);
            this.fctGenDescription.Name = "fctGenDescription";
            this.fctGenDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctGenDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctGenDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctGenDescription.ServiceColors")));
            this.fctGenDescription.Size = new System.Drawing.Size(306, 236);
            this.fctGenDescription.TabIndex = 7;
            this.fctGenDescription.Zoom = 100;
            this.fctGenDescription.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctGenDescription_TextChanged);
            // 
            // pnlProcedureAttributes
            // 
            this.pnlProcedureAttributes.Controls.Add(this.gbGenName);
            this.pnlProcedureAttributes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcedureAttributes.Location = new System.Drawing.Point(0, 0);
            this.pnlProcedureAttributes.Name = "pnlProcedureAttributes";
            this.pnlProcedureAttributes.Size = new System.Drawing.Size(312, 389);
            this.pnlProcedureAttributes.TabIndex = 0;
            // 
            // gbGenName
            // 
            this.gbGenName.Controls.Add(this.txtFuncName);
            this.gbGenName.Location = new System.Drawing.Point(3, 6);
            this.gbGenName.Name = "gbGenName";
            this.gbGenName.Size = new System.Drawing.Size(310, 45);
            this.gbGenName.TabIndex = 0;
            this.gbGenName.TabStop = false;
            this.gbGenName.Text = "Function name";
            // 
            // txtFuncName
            // 
            this.txtFuncName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFuncName.Location = new System.Drawing.Point(3, 18);
            this.txtFuncName.Name = "txtFuncName";
            this.txtFuncName.Size = new System.Drawing.Size(304, 22);
            this.txtFuncName.TabIndex = 0;
            this.txtFuncName.Text = "NEW_PROC";
            this.txtFuncName.TextChanged += new System.EventHandler(this.txtGenName_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabProcedureDefinition);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ilTabControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 646);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.gbSQL);
            this.tabPageSQL.Controls.Add(this.pnlSQLUpper);
            this.tabPageSQL.ImageIndex = 5;
            this.tabPageSQL.Location = new System.Drawing.Point(4, 23);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(883, 619);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.fctSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(3, 49);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(877, 567);
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
            this.fctSQL.Location = new System.Drawing.Point(3, 18);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(871, 546);
            this.fctSQL.TabIndex = 0;
            this.fctSQL.Zoom = 100;
            this.fctSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctSQL_KeyDown);
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlSQLUpper.Controls.Add(this.hsCreate);
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(877, 46);
            this.pnlSQLUpper.TabIndex = 10;
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
            this.hsCreate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCreate.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreate.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCreate.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsCreate.ImageToggleOnSelect = true;
            this.hsCreate.Location = new System.Drawing.Point(162, 0);
            this.hsCreate.Marked = false;
            this.hsCreate.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreate.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreate.MarkedText = "";
            this.hsCreate.MarkMode = false;
            this.hsCreate.Name = "hsCreate";
            this.hsCreate.NonMarkedText = "Execute";
            this.hsCreate.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCreate.ShortcutNewline = false;
            this.hsCreate.ShowShortcut = false;
            this.hsCreate.Size = new System.Drawing.Size(94, 46);
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
            this.hsCreate.Click += new System.EventHandler(this.hsSave_Click);
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
            this.hsLoadSQL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsLoadSQL.ShortcutNewline = false;
            this.hsLoadSQL.ShowShortcut = false;
            this.hsLoadSQL.Size = new System.Drawing.Size(82, 46);
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
            this.hsSaveSQL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsSaveSQL.ShortcutNewline = false;
            this.hsSaveSQL.ShowShortcut = false;
            this.hsSaveSQL.Size = new System.Drawing.Size(80, 46);
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
            // tabProcedureDefinition
            // 
            this.tabProcedureDefinition.Controls.Add(this.spcProcedureSQL);
            this.tabProcedureDefinition.ImageIndex = 8;
            this.tabProcedureDefinition.Location = new System.Drawing.Point(4, 23);
            this.tabProcedureDefinition.Name = "tabProcedureDefinition";
            this.tabProcedureDefinition.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedureDefinition.Size = new System.Drawing.Size(883, 619);
            this.tabProcedureDefinition.TabIndex = 1;
            this.tabProcedureDefinition.Text = "Function Definition";
            this.tabProcedureDefinition.UseVisualStyleBackColor = true;
            // 
            // spcProcedureSQL
            // 
            this.spcProcedureSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcProcedureSQL.Location = new System.Drawing.Point(3, 3);
            this.spcProcedureSQL.Name = "spcProcedureSQL";
            // 
            // spcProcedureSQL.Panel1
            // 
            this.spcProcedureSQL.Panel1.Controls.Add(this.lvFields);
            this.spcProcedureSQL.Panel1.Controls.Add(this.pnlParameterLower);
            // 
            // spcProcedureSQL.Panel2
            // 
            this.spcProcedureSQL.Panel2.Controls.Add(this.gbProcedureDefinitionSQL);
            this.spcProcedureSQL.Size = new System.Drawing.Size(877, 613);
            this.spcProcedureSQL.SplitterDistance = 358;
            this.spcProcedureSQL.TabIndex = 11;
            // 
            // lvFields
            // 
            this.lvFields.AllowColumnReorder = true;
            this.lvFields.AutoArrange = false;
            this.lvFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTYP,
            this.colPARAMETER,
            this.colPARTYP});
            this.lvFields.ContextMenuStrip = this.cmsParameters;
            this.lvFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFields.FullRowSelect = true;
            this.lvFields.GridLines = true;
            this.lvFields.HideSelection = false;
            this.lvFields.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvFields.Location = new System.Drawing.Point(0, 0);
            this.lvFields.Name = "lvFields";
            this.lvFields.Size = new System.Drawing.Size(358, 460);
            this.lvFields.TabIndex = 1;
            this.lvFields.UseCompatibleStateImageBehavior = false;
            this.lvFields.View = System.Windows.Forms.View.Details;
            this.lvFields.SelectedIndexChanged += new System.EventHandler(this.lvFields_SelectedIndexChanged);
            // 
            // colTYP
            // 
            this.colTYP.Text = "I-O";
            this.colTYP.Width = 40;
            // 
            // colPARAMETER
            // 
            this.colPARAMETER.Text = "Parameter";
            this.colPARAMETER.Width = 140;
            // 
            // colPARTYP
            // 
            this.colPARTYP.Text = "Parameter-Typ";
            this.colPARTYP.Width = 140;
            // 
            // cmsParameters
            // 
            this.cmsParameters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddInputParameter,
            this.tsmiAddOutputParameter,
            this.toolStripSeparator1,
            this.tsmiDropParameter});
            this.cmsParameters.Name = "contextMenuStrip1";
            this.cmsParameters.Size = new System.Drawing.Size(193, 76);
            this.cmsParameters.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsParameters_ItemClicked);
            // 
            // tsmiAddInputParameter
            // 
            this.tsmiAddInputParameter.Image = global::FBXpert.Properties.Resources.plus_blue22x;
            this.tsmiAddInputParameter.Name = "tsmiAddInputParameter";
            this.tsmiAddInputParameter.Size = new System.Drawing.Size(192, 22);
            this.tsmiAddInputParameter.Text = "Add input parameter";
            // 
            // tsmiAddOutputParameter
            // 
            this.tsmiAddOutputParameter.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.tsmiAddOutputParameter.Name = "tsmiAddOutputParameter";
            this.tsmiAddOutputParameter.Size = new System.Drawing.Size(192, 22);
            this.tsmiAddOutputParameter.Text = "Add output parameter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // tsmiDropParameter
            // 
            this.tsmiDropParameter.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDropParameter.Name = "tsmiDropParameter";
            this.tsmiDropParameter.Size = new System.Drawing.Size(192, 22);
            this.tsmiDropParameter.Text = "Drop parameter";
            // 
            // pnlParameterLower
            // 
            this.pnlParameterLower.Controls.Add(this.gbParamTyp);
            this.pnlParameterLower.Controls.Add(this.groupBox1);
            this.pnlParameterLower.Controls.Add(this.gbParameterName);
            this.pnlParameterLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlParameterLower.Location = new System.Drawing.Point(0, 460);
            this.pnlParameterLower.Name = "pnlParameterLower";
            this.pnlParameterLower.Size = new System.Drawing.Size(358, 153);
            this.pnlParameterLower.TabIndex = 2;
            // 
            // gbParamTyp
            // 
            this.gbParamTyp.Controls.Add(this.txtPrecision);
            this.gbParamTyp.Controls.Add(this.cbDatatype);
            this.gbParamTyp.Controls.Add(this.txtDatatypeLength);
            this.gbParamTyp.Location = new System.Drawing.Point(6, 100);
            this.gbParamTyp.Name = "gbParamTyp";
            this.gbParamTyp.Size = new System.Drawing.Size(351, 45);
            this.gbParamTyp.TabIndex = 3;
            this.gbParamTyp.TabStop = false;
            this.gbParamTyp.Text = "Datatype                    Length          Precision";
            // 
            // txtPrecision
            // 
            this.txtPrecision.Location = new System.Drawing.Point(177, 17);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Size = new System.Drawing.Size(61, 22);
            this.txtPrecision.TabIndex = 2;
            // 
            // cbDatatype
            // 
            this.cbDatatype.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDatatype.FormattingEnabled = true;
            this.cbDatatype.Items.AddRange(new object[] {
            "INTEGER",
            "DOUBLE PRECISION",
            "VARCHAR"});
            this.cbDatatype.Location = new System.Drawing.Point(3, 18);
            this.cbDatatype.Name = "cbDatatype";
            this.cbDatatype.Size = new System.Drawing.Size(101, 22);
            this.cbDatatype.TabIndex = 1;
            this.cbDatatype.Text = "INTEGER";
            // 
            // txtDatatypeLength
            // 
            this.txtDatatypeLength.Location = new System.Drawing.Point(110, 17);
            this.txtDatatypeLength.Name = "txtDatatypeLength";
            this.txtDatatypeLength.Size = new System.Drawing.Size(61, 22);
            this.txtDatatypeLength.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVAR);
            this.groupBox1.Controls.Add(this.rbOUT);
            this.groupBox1.Controls.Add(this.rbIN);
            this.groupBox1.Location = new System.Drawing.Point(257, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter name";
            // 
            // rbVAR
            // 
            this.rbVAR.AutoSize = true;
            this.rbVAR.Location = new System.Drawing.Point(22, 64);
            this.rbVAR.Name = "rbVAR";
            this.rbVAR.Size = new System.Drawing.Size(42, 18);
            this.rbVAR.TabIndex = 2;
            this.rbVAR.Text = "Var";
            this.rbVAR.UseVisualStyleBackColor = true;
            // 
            // rbOUT
            // 
            this.rbOUT.AutoSize = true;
            this.rbOUT.Location = new System.Drawing.Point(22, 44);
            this.rbOUT.Name = "rbOUT";
            this.rbOUT.Size = new System.Drawing.Size(47, 18);
            this.rbOUT.TabIndex = 1;
            this.rbOUT.Text = "OUT";
            this.rbOUT.UseVisualStyleBackColor = true;
            // 
            // rbIN
            // 
            this.rbIN.AutoSize = true;
            this.rbIN.Checked = true;
            this.rbIN.Location = new System.Drawing.Point(22, 26);
            this.rbIN.Name = "rbIN";
            this.rbIN.Size = new System.Drawing.Size(37, 18);
            this.rbIN.TabIndex = 0;
            this.rbIN.TabStop = true;
            this.rbIN.Text = "IN";
            this.rbIN.UseVisualStyleBackColor = true;
            // 
            // gbParameterName
            // 
            this.gbParameterName.Controls.Add(this.txtParameter);
            this.gbParameterName.Location = new System.Drawing.Point(3, 48);
            this.gbParameterName.Name = "gbParameterName";
            this.gbParameterName.Size = new System.Drawing.Size(174, 45);
            this.gbParameterName.TabIndex = 1;
            this.gbParameterName.TabStop = false;
            this.gbParameterName.Text = "Parameter name";
            // 
            // txtParameter
            // 
            this.txtParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParameter.Location = new System.Drawing.Point(3, 18);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(168, 22);
            this.txtParameter.TabIndex = 0;
            // 
            // gbProcedureDefinitionSQL
            // 
            this.gbProcedureDefinitionSQL.Controls.Add(this.fcbFunctionDefinitionSQL);
            this.gbProcedureDefinitionSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProcedureDefinitionSQL.Location = new System.Drawing.Point(0, 0);
            this.gbProcedureDefinitionSQL.Name = "gbProcedureDefinitionSQL";
            this.gbProcedureDefinitionSQL.Size = new System.Drawing.Size(515, 613);
            this.gbProcedureDefinitionSQL.TabIndex = 10;
            this.gbProcedureDefinitionSQL.TabStop = false;
            this.gbProcedureDefinitionSQL.Text = "Procedure - SQL";
            // 
            // fcbFunctionDefinitionSQL
            // 
            this.fcbFunctionDefinitionSQL.AutoCompleteBracketsList = new char[] {
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
            this.fcbFunctionDefinitionSQL.AutoIndentCharsPatterns = "";
            this.fcbFunctionDefinitionSQL.AutoScrollMinSize = new System.Drawing.Size(25, 12);
            this.fcbFunctionDefinitionSQL.BackBrush = null;
            this.fcbFunctionDefinitionSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fcbFunctionDefinitionSQL.CharHeight = 12;
            this.fcbFunctionDefinitionSQL.CharWidth = 7;
            this.fcbFunctionDefinitionSQL.CommentPrefix = "--";
            this.fcbFunctionDefinitionSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbFunctionDefinitionSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbFunctionDefinitionSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbFunctionDefinitionSQL.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fcbFunctionDefinitionSQL.IsReplaceMode = false;
            this.fcbFunctionDefinitionSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbFunctionDefinitionSQL.LeftBracket = '(';
            this.fcbFunctionDefinitionSQL.Location = new System.Drawing.Point(3, 18);
            this.fcbFunctionDefinitionSQL.Name = "fcbFunctionDefinitionSQL";
            this.fcbFunctionDefinitionSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbFunctionDefinitionSQL.RightBracket = ')';
            this.fcbFunctionDefinitionSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbFunctionDefinitionSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbFunctionDefinitionSQL.ServiceColors")));
            this.fcbFunctionDefinitionSQL.Size = new System.Drawing.Size(509, 592);
            this.fcbFunctionDefinitionSQL.TabIndex = 0;
            this.fcbFunctionDefinitionSQL.Zoom = 100;
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
            this.pnlFieldUpper.Size = new System.Drawing.Size(1215, 43);
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
            this.hsNew.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsNew.ShortcutNewline = false;
            this.hsNew.ShowShortcut = false;
            this.hsNew.Size = new System.Drawing.Size(52, 39);
            this.hsNew.TabIndex = 3;
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
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1221, 699);
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
            this.fctMessages.CharWidth = 8;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(3, 57);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.ReadOnly = true;
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1215, 639);
            this.fctMessages.TabIndex = 22;
            this.fctMessages.WordWrap = true;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessagesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1215, 54);
            this.pnlMessagesUpper.TabIndex = 21;
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
            this.hsClearMessages.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsClearMessages.ShortcutNewline = false;
            this.hsClearMessages.ShowShortcut = false;
            this.hsClearMessages.Size = new System.Drawing.Size(45, 50);
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
            this.hsRefreshDependencies.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshDependencies.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependencies.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependencies.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependencies.ImageToggleOnSelect = true;
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1166, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshDependencies.ShortcutNewline = false;
            this.hsRefreshDependencies.ShowShortcut = false;
            this.hsRefreshDependencies.Size = new System.Drawing.Size(45, 50);
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
            // FunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 771);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlFormUpper);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FunctionForm";
            this.Text = "FunctionForm";
            this.Load += new System.EventHandler(this.FunctionForm_Load);
            this.pnlFormUpper.ResumeLayout(false);
            this.pnlFormUpper.PerformLayout();
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
            this.pnlProcedureAttributes.ResumeLayout(false);
            this.gbGenName.ResumeLayout(false);
            this.gbGenName.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.tabProcedureDefinition.ResumeLayout(false);
            this.spcProcedureSQL.Panel1.ResumeLayout(false);
            this.spcProcedureSQL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcProcedureSQL)).EndInit();
            this.spcProcedureSQL.ResumeLayout(false);
            this.cmsParameters.ResumeLayout(false);
            this.pnlParameterLower.ResumeLayout(false);
            this.gbParamTyp.ResumeLayout(false);
            this.gbParamTyp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbParameterName.ResumeLayout(false);
            this.gbParameterName.PerformLayout();
            this.gbProcedureDefinitionSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbFunctionDefinitionSQL)).EndInit();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessagesUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.GroupBox gbGenName;
        private System.Windows.Forms.TextBox txtFuncName;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.GroupBox gbGenDescription;
        private FastColoredTextBoxNS.FastColoredTextBox fctGenDescription;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsCreate;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private System.Windows.Forms.BindingSource bsDependenciesTo;
        private System.Data.DataSet dsDependenciesTo;
        private System.Data.DataTable dataTable5;
        private System.Data.DataSet dsDependenciesFrom;
        private System.Data.DataTable dataTable6;
        private System.Windows.Forms.BindingSource bsDependenciesFrom;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlProcedureAttributes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.TabPage tabProcedureDefinition;
        private System.Windows.Forms.GroupBox gbProcedureDefinitionSQL;
        private FastColoredTextBoxNS.FastColoredTextBox fcbFunctionDefinitionSQL;
        private System.Windows.Forms.SplitContainer spcProcedureSQL;
        private System.Windows.Forms.ListView lvFields;
        private System.Windows.Forms.ColumnHeader colPARAMETER;
        private System.Windows.Forms.ColumnHeader colTYP;
        private System.Windows.Forms.ImageList ilTabControl;
        private SeControlsLib.HotSpot hsClearMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.ColumnHeader colPARTYP;
        private System.Windows.Forms.ContextMenuStrip cmsParameters;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddInputParameter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddOutputParameter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropParameter;
        private System.Windows.Forms.Panel pnlParameterLower;
        private System.Windows.Forms.GroupBox gbParameterName;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.GroupBox gbParamTyp;
        private System.Windows.Forms.ComboBox cbDatatype;
        private System.Windows.Forms.TextBox txtDatatypeLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVAR;
        private System.Windows.Forms.RadioButton rbOUT;
        private System.Windows.Forms.RadioButton rbIN;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.Label lblCaption;
        private SeControlsLib.HotSpot hsNew;
    }
}