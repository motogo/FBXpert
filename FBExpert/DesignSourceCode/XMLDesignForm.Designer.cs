namespace FBXpert.SonstForms
{
    partial class XmlDesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlDesignForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.pnlSourceCode = new System.Windows.Forms.Panel();
            this.fctSource = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsSourceCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiSearchNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUpperSourceCode = new System.Windows.Forms.Panel();
            this.hsSave = new SeControlsLib.HotSpot();
            this.gbFoundLines = new System.Windows.Forms.GroupBox();
            this.cbFoundLines = new System.Windows.Forms.ComboBox();
            this.gbSearchCode = new System.Windows.Forms.GroupBox();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.hsSearchDown = new SeControlsLib.HotSpot();
            this.hsSearchUp = new SeControlsLib.HotSpot();
            this.hsSeach = new SeControlsLib.HotSpot();
            this.gbDBObjets = new System.Windows.Forms.GroupBox();
            this.selDBObjects = new SEListBox.SEListBox();
            this.gbExportProgress = new System.Windows.Forms.GroupBox();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.pnlDBObjectsParameters = new System.Windows.Forms.Panel();
            this.ckDeleteOldSourceFiles = new System.Windows.Forms.CheckBox();
            this.pnlUpperDBObjects = new System.Windows.Forms.Panel();
            this.hsCreateCVS = new SeControlsLib.HotSpot();
            this.hsSaveSourceCodes = new SeControlsLib.HotSpot();
            this.xmlEditStruktur = new XMLSimlpeEdit.XMLEditSimpleUserControl();
            this.pnlXML_UPPER = new System.Windows.Forms.Panel();
            this.gbSourceCode = new System.Windows.Forms.GroupBox();
            this.txtSourceCodePath = new System.Windows.Forms.TextBox();
            this.hsSelectPath = new SeControlsLib.HotSpot();
            this.hsCreateClasses = new SeControlsLib.HotSpot();
            this.hsSaveXML = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.tabPageCreateAttributes = new System.Windows.Forms.TabPage();
            this.pnlCenterCreateAttributes = new System.Windows.Forms.Panel();
            this.gbDBNamespace = new System.Windows.Forms.GroupBox();
            this.txtDBNamespace = new System.Windows.Forms.TextBox();
            this.gbPrimaryFieldType = new System.Windows.Forms.GroupBox();
            this.rbGUIDHEXGeneration = new System.Windows.Forms.RadioButton();
            this.rbGenerateOID = new System.Windows.Forms.RadioButton();
            this.rbGenerateInrWithGenerator = new System.Windows.Forms.RadioButton();
            this.rbGenerateGUID = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fbdSourcePath = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            this.pnlSourceCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSource)).BeginInit();
            this.cmsSourceCode.SuspendLayout();
            this.pnlUpperSourceCode.SuspendLayout();
            this.gbFoundLines.SuspendLayout();
            this.gbSearchCode.SuspendLayout();
            this.gbDBObjets.SuspendLayout();
            this.gbExportProgress.SuspendLayout();
            this.pnlDBObjectsParameters.SuspendLayout();
            this.pnlUpperDBObjects.SuspendLayout();
            this.pnlXML_UPPER.SuspendLayout();
            this.gbSourceCode.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessagesUpper.SuspendLayout();
            this.tabPageCreateAttributes.SuspendLayout();
            this.pnlCenterCreateAttributes.SuspendLayout();
            this.gbDBNamespace.SuspendLayout();
            this.gbPrimaryFieldType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblCaption);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1601, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(62, 11);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(99, 19);
            this.lblCaption.TabIndex = 5;
            this.lblCaption.Text = "lblCaption";
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
            this.hsRefresh.Image = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(1556, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Size = new System.Drawing.Size(45, 42);
            this.hsRefresh.TabIndex = 3;
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
            this.hsClose.TabIndex = 2;
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
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 718);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(1601, 23);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControl1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1601, 676);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageXML);
            this.tabControl1.Controls.Add(this.tabPageMessages);
            this.tabControl1.Controls.Add(this.tabPageCreateAttributes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ilTabControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1601, 676);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.pnlSourceCode);
            this.tabPageXML.Controls.Add(this.gbDBObjets);
            this.tabPageXML.Controls.Add(this.xmlEditStruktur);
            this.tabPageXML.Controls.Add(this.pnlXML_UPPER);
            this.tabPageXML.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageXML.ImageIndex = 8;
            this.tabPageXML.Location = new System.Drawing.Point(4, 23);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXML.Size = new System.Drawing.Size(1593, 649);
            this.tabPageXML.TabIndex = 0;
            this.tabPageXML.Text = "XML";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // pnlSourceCode
            // 
            this.pnlSourceCode.Controls.Add(this.fctSource);
            this.pnlSourceCode.Controls.Add(this.pnlUpperSourceCode);
            this.pnlSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSourceCode.Location = new System.Drawing.Point(864, 64);
            this.pnlSourceCode.Name = "pnlSourceCode";
            this.pnlSourceCode.Size = new System.Drawing.Size(726, 582);
            this.pnlSourceCode.TabIndex = 6;
            // 
            // fctSource
            // 
            this.fctSource.AutoCompleteBrackets = true;
            this.fctSource.AutoCompleteBracketsList = new char[] {
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
            this.fctSource.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fctSource.AutoScrollMinSize = new System.Drawing.Size(25, 14);
            this.fctSource.BackBrush = null;
            this.fctSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctSource.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctSource.CharHeight = 14;
            this.fctSource.CharWidth = 7;
            this.fctSource.ContextMenuStrip = this.cmsSourceCode;
            this.fctSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSource.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSource.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctSource.IsReplaceMode = false;
            this.fctSource.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctSource.LeftBracket = '(';
            this.fctSource.LeftBracket2 = '{';
            this.fctSource.Location = new System.Drawing.Point(0, 56);
            this.fctSource.Name = "fctSource";
            this.fctSource.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSource.RightBracket = ')';
            this.fctSource.RightBracket2 = '}';
            this.fctSource.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSource.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSource.ServiceColors")));
            this.fctSource.Size = new System.Drawing.Size(726, 526);
            this.fctSource.TabIndex = 3;
            this.fctSource.Zoom = 100;
            this.fctSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctb_KeyDown);
            // 
            // cmsSourceCode
            // 
            this.cmsSourceCode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSourceCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTextSearch,
            this.tsmiSearchNext,
            this.tsmiSearchFirst});
            this.cmsSourceCode.Name = "cmsSourceCode";
            this.cmsSourceCode.Size = new System.Drawing.Size(161, 73);
            this.cmsSourceCode.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSourceCode_ItemClicked);
            // 
            // tsTextSearch
            // 
            this.tsTextSearch.Name = "tsTextSearch";
            this.tsTextSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // tsmiSearchNext
            // 
            this.tsmiSearchNext.Name = "tsmiSearchNext";
            this.tsmiSearchNext.Size = new System.Drawing.Size(160, 22);
            this.tsmiSearchNext.Text = "Search";
            // 
            // tsmiSearchFirst
            // 
            this.tsmiSearchFirst.Name = "tsmiSearchFirst";
            this.tsmiSearchFirst.Size = new System.Drawing.Size(160, 22);
            this.tsmiSearchFirst.Text = "Search first";
            // 
            // pnlUpperSourceCode
            // 
            this.pnlUpperSourceCode.Controls.Add(this.hsSave);
            this.pnlUpperSourceCode.Controls.Add(this.gbFoundLines);
            this.pnlUpperSourceCode.Controls.Add(this.gbSearchCode);
            this.pnlUpperSourceCode.Controls.Add(this.hsSearchDown);
            this.pnlUpperSourceCode.Controls.Add(this.hsSearchUp);
            this.pnlUpperSourceCode.Controls.Add(this.hsSeach);
            this.pnlUpperSourceCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperSourceCode.Location = new System.Drawing.Point(0, 0);
            this.pnlUpperSourceCode.Name = "pnlUpperSourceCode";
            this.pnlUpperSourceCode.Size = new System.Drawing.Size(726, 56);
            this.pnlUpperSourceCode.TabIndex = 4;
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
            this.hsSave.Image = global::FBXpert.Properties.Resources.data_export_blue_x32;
            this.hsSave.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x32;
            this.hsSave.ImageToggleOnSelect = true;
            this.hsSave.Location = new System.Drawing.Point(0, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "";
            this.hsSave.Size = new System.Drawing.Size(37, 56);
            this.hsSave.TabIndex = 11;
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
            this.hsSave.Click += new System.EventHandler(this.hsSave_Click_1);
            // 
            // gbFoundLines
            // 
            this.gbFoundLines.Controls.Add(this.cbFoundLines);
            this.gbFoundLines.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbFoundLines.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoundLines.Location = new System.Drawing.Point(40, 0);
            this.gbFoundLines.Name = "gbFoundLines";
            this.gbFoundLines.Size = new System.Drawing.Size(351, 56);
            this.gbFoundLines.TabIndex = 10;
            this.gbFoundLines.TabStop = false;
            this.gbFoundLines.Text = "FoundLines";
            // 
            // cbFoundLines
            // 
            this.cbFoundLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFoundLines.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoundLines.FormattingEnabled = true;
            this.cbFoundLines.Location = new System.Drawing.Point(3, 16);
            this.cbFoundLines.Name = "cbFoundLines";
            this.cbFoundLines.Size = new System.Drawing.Size(345, 21);
            this.cbFoundLines.TabIndex = 0;
            this.cbFoundLines.SelectedIndexChanged += new System.EventHandler(this.cbFoundLines_SelectedIndexChanged);
            // 
            // gbSearchCode
            // 
            this.gbSearchCode.Controls.Add(this.txtSearchCode);
            this.gbSearchCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbSearchCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchCode.Location = new System.Drawing.Point(391, 0);
            this.gbSearchCode.Name = "gbSearchCode";
            this.gbSearchCode.Size = new System.Drawing.Size(200, 56);
            this.gbSearchCode.TabIndex = 9;
            this.gbSearchCode.TabStop = false;
            this.gbSearchCode.Text = "Search";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCode.Location = new System.Drawing.Point(3, 16);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(194, 20);
            this.txtSearchCode.TabIndex = 0;
            this.txtSearchCode.Text = "get";
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchCode_TextChanged);
            // 
            // hsSearchDown
            // 
            this.hsSearchDown.BackColor = System.Drawing.Color.Transparent;
            this.hsSearchDown.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSearchDown.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSearchDown.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSearchDown.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSearchDown.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSearchDown.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSearchDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSearchDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSearchDown.FlatAppearance.BorderSize = 0;
            this.hsSearchDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSearchDown.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSearchDown.Image = global::FBXpert.Properties.Resources.go_down22x;
            this.hsSearchDown.ImageHover = global::FBXpert.Properties.Resources.go_down_blue_22x;
            this.hsSearchDown.ImageToggleOnSelect = true;
            this.hsSearchDown.Location = new System.Drawing.Point(591, 0);
            this.hsSearchDown.Marked = false;
            this.hsSearchDown.MarkedColor = System.Drawing.Color.Teal;
            this.hsSearchDown.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSearchDown.MarkedText = "";
            this.hsSearchDown.MarkMode = false;
            this.hsSearchDown.Name = "hsSearchDown";
            this.hsSearchDown.NonMarkedText = "";
            this.hsSearchDown.Size = new System.Drawing.Size(45, 56);
            this.hsSearchDown.TabIndex = 8;
            this.hsSearchDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSearchDown.ToolTipActive = false;
            this.hsSearchDown.ToolTipAutomaticDelay = 500;
            this.hsSearchDown.ToolTipAutoPopDelay = 5000;
            this.hsSearchDown.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSearchDown.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSearchDown.ToolTipFor4ContextMenu = true;
            this.hsSearchDown.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSearchDown.ToolTipInitialDelay = 500;
            this.hsSearchDown.ToolTipIsBallon = false;
            this.hsSearchDown.ToolTipOwnerDraw = false;
            this.hsSearchDown.ToolTipReshowDelay = 100;
            this.hsSearchDown.ToolTipShowAlways = false;
            this.hsSearchDown.ToolTipText = "";
            this.hsSearchDown.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSearchDown.ToolTipTitle = "";
            this.hsSearchDown.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSearchDown.UseVisualStyleBackColor = false;
            this.hsSearchDown.Click += new System.EventHandler(this.hsSearchDown_Click);
            // 
            // hsSearchUp
            // 
            this.hsSearchUp.BackColor = System.Drawing.Color.Transparent;
            this.hsSearchUp.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSearchUp.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSearchUp.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSearchUp.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSearchUp.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSearchUp.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSearchUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSearchUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSearchUp.FlatAppearance.BorderSize = 0;
            this.hsSearchUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSearchUp.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSearchUp.Image = global::FBXpert.Properties.Resources.go_up_gn22x;
            this.hsSearchUp.ImageHover = global::FBXpert.Properties.Resources.go_up_blue22x;
            this.hsSearchUp.ImageToggleOnSelect = true;
            this.hsSearchUp.Location = new System.Drawing.Point(636, 0);
            this.hsSearchUp.Marked = false;
            this.hsSearchUp.MarkedColor = System.Drawing.Color.Teal;
            this.hsSearchUp.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSearchUp.MarkedText = "";
            this.hsSearchUp.MarkMode = false;
            this.hsSearchUp.Name = "hsSearchUp";
            this.hsSearchUp.NonMarkedText = "";
            this.hsSearchUp.Size = new System.Drawing.Size(45, 56);
            this.hsSearchUp.TabIndex = 7;
            this.hsSearchUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSearchUp.ToolTipActive = false;
            this.hsSearchUp.ToolTipAutomaticDelay = 500;
            this.hsSearchUp.ToolTipAutoPopDelay = 5000;
            this.hsSearchUp.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSearchUp.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSearchUp.ToolTipFor4ContextMenu = true;
            this.hsSearchUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSearchUp.ToolTipInitialDelay = 500;
            this.hsSearchUp.ToolTipIsBallon = false;
            this.hsSearchUp.ToolTipOwnerDraw = false;
            this.hsSearchUp.ToolTipReshowDelay = 100;
            this.hsSearchUp.ToolTipShowAlways = false;
            this.hsSearchUp.ToolTipText = "";
            this.hsSearchUp.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSearchUp.ToolTipTitle = "";
            this.hsSearchUp.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSearchUp.UseVisualStyleBackColor = false;
            this.hsSearchUp.Click += new System.EventHandler(this.hsSearchUp_Click);
            // 
            // hsSeach
            // 
            this.hsSeach.BackColor = System.Drawing.Color.Transparent;
            this.hsSeach.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSeach.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSeach.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSeach.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSeach.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSeach.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSeach.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSeach.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSeach.FlatAppearance.BorderSize = 0;
            this.hsSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSeach.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSeach.Image = global::FBXpert.Properties.Resources.lupe24x;
            this.hsSeach.ImageHover = global::FBXpert.Properties.Resources.lupe2_24x;
            this.hsSeach.ImageToggleOnSelect = true;
            this.hsSeach.Location = new System.Drawing.Point(681, 0);
            this.hsSeach.Marked = false;
            this.hsSeach.MarkedColor = System.Drawing.Color.Teal;
            this.hsSeach.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSeach.MarkedText = "";
            this.hsSeach.MarkMode = false;
            this.hsSeach.Name = "hsSeach";
            this.hsSeach.NonMarkedText = "";
            this.hsSeach.Size = new System.Drawing.Size(45, 56);
            this.hsSeach.TabIndex = 6;
            this.hsSeach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSeach.ToolTipActive = false;
            this.hsSeach.ToolTipAutomaticDelay = 500;
            this.hsSeach.ToolTipAutoPopDelay = 5000;
            this.hsSeach.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSeach.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSeach.ToolTipFor4ContextMenu = true;
            this.hsSeach.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSeach.ToolTipInitialDelay = 500;
            this.hsSeach.ToolTipIsBallon = false;
            this.hsSeach.ToolTipOwnerDraw = false;
            this.hsSeach.ToolTipReshowDelay = 100;
            this.hsSeach.ToolTipShowAlways = false;
            this.hsSeach.ToolTipText = "";
            this.hsSeach.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSeach.ToolTipTitle = "";
            this.hsSeach.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSeach.UseVisualStyleBackColor = false;
            this.hsSeach.Click += new System.EventHandler(this.hsSeach_Click);
            // 
            // gbDBObjets
            // 
            this.gbDBObjets.Controls.Add(this.selDBObjects);
            this.gbDBObjets.Controls.Add(this.gbExportProgress);
            this.gbDBObjets.Controls.Add(this.pnlDBObjectsParameters);
            this.gbDBObjets.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDBObjets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDBObjets.Location = new System.Drawing.Point(628, 64);
            this.gbDBObjets.Name = "gbDBObjets";
            this.gbDBObjets.Size = new System.Drawing.Size(236, 582);
            this.gbDBObjets.TabIndex = 5;
            this.gbDBObjets.TabStop = false;
            this.gbDBObjets.Text = "DB objects";
            // 
            // selDBObjects
            // 
            this.selDBObjects.AllowMultipleChecks = false;
            this.selDBObjects.AlternatingListEntriesDefaultCellStyle = dataGridViewCellStyle1;
            this.selDBObjects.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.selDBObjects.AutoSizeModeCheck = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selDBObjects.AutoSizeModeID = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selDBObjects.AutoSizeModeText = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selDBObjects.CheckCaption = "chk";
            this.selDBObjects.CheckOnDoubleClick = false;
            this.selDBObjects.CheckOnSelect = false;
            this.selDBObjects.CheckVisible = true;
            this.selDBObjects.CheckWith = 32;
            this.selDBObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selDBObjects.IDVisible = false;
            this.selDBObjects.IDWith = 32;
            this.selDBObjects.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selDBObjects.ListEntriesDefaultCellStyle = dataGridViewCellStyle2;
            this.selDBObjects.Location = new System.Drawing.Point(3, 124);
            this.selDBObjects.Name = "selDBObjects";
            this.selDBObjects.SelectedIndex = -1;
            this.selDBObjects.ShowCaptions = true;
            this.selDBObjects.ShowCellToolTips = true;
            this.selDBObjects.ShowCountInTitle = true;
            this.selDBObjects.ShowSelection = true;
            this.selDBObjects.Size = new System.Drawing.Size(230, 455);
            this.selDBObjects.TabIndex = 4;
            this.selDBObjects.Text = "Object list";
            this.selDBObjects.TextCaption = "text";
            this.selDBObjects.TextWith = 189;
            this.selDBObjects.Title = "";
            this.selDBObjects.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.selDBObjects.ItemSelect += new SEListBox.SEListBox.SelectItemEventHandler(this.selDBObjects_ItemSelect);
            // 
            // gbExportProgress
            // 
            this.gbExportProgress.Controls.Add(this.pbExport);
            this.gbExportProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbExportProgress.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExportProgress.Location = new System.Drawing.Point(3, 90);
            this.gbExportProgress.Name = "gbExportProgress";
            this.gbExportProgress.Size = new System.Drawing.Size(230, 34);
            this.gbExportProgress.TabIndex = 7;
            this.gbExportProgress.TabStop = false;
            this.gbExportProgress.Text = "Progress";
            // 
            // pbExport
            // 
            this.pbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbExport.Location = new System.Drawing.Point(3, 16);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(224, 15);
            this.pbExport.TabIndex = 0;
            // 
            // pnlDBObjectsParameters
            // 
            this.pnlDBObjectsParameters.Controls.Add(this.ckDeleteOldSourceFiles);
            this.pnlDBObjectsParameters.Controls.Add(this.pnlUpperDBObjects);
            this.pnlDBObjectsParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDBObjectsParameters.Location = new System.Drawing.Point(3, 16);
            this.pnlDBObjectsParameters.Name = "pnlDBObjectsParameters";
            this.pnlDBObjectsParameters.Size = new System.Drawing.Size(230, 74);
            this.pnlDBObjectsParameters.TabIndex = 8;
            // 
            // ckDeleteOldSourceFiles
            // 
            this.ckDeleteOldSourceFiles.AutoSize = true;
            this.ckDeleteOldSourceFiles.Checked = true;
            this.ckDeleteOldSourceFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDeleteOldSourceFiles.Location = new System.Drawing.Point(3, 55);
            this.ckDeleteOldSourceFiles.Name = "ckDeleteOldSourceFiles";
            this.ckDeleteOldSourceFiles.Size = new System.Drawing.Size(122, 17);
            this.ckDeleteOldSourceFiles.TabIndex = 8;
            this.ckDeleteOldSourceFiles.Text = "Delete old files";
            this.ckDeleteOldSourceFiles.UseVisualStyleBackColor = true;
            // 
            // pnlUpperDBObjects
            // 
            this.pnlUpperDBObjects.Controls.Add(this.hsCreateCVS);
            this.pnlUpperDBObjects.Controls.Add(this.hsSaveSourceCodes);
            this.pnlUpperDBObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperDBObjects.Location = new System.Drawing.Point(0, 0);
            this.pnlUpperDBObjects.Name = "pnlUpperDBObjects";
            this.pnlUpperDBObjects.Size = new System.Drawing.Size(230, 56);
            this.pnlUpperDBObjects.TabIndex = 7;
            // 
            // hsCreateCVS
            // 
            this.hsCreateCVS.BackColor = System.Drawing.Color.Transparent;
            this.hsCreateCVS.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCreateCVS.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCreateCVS.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCreateCVS.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCreateCVS.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCreateCVS.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCreateCVS.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCreateCVS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreateCVS.FlatAppearance.BorderSize = 0;
            this.hsCreateCVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreateCVS.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreateCVS.Image = global::FBXpert.Properties.Resources.data_export_blue_x32;
            this.hsCreateCVS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCreateCVS.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x32;
            this.hsCreateCVS.ImageToggleOnSelect = true;
            this.hsCreateCVS.Location = new System.Drawing.Point(127, 0);
            this.hsCreateCVS.Marked = false;
            this.hsCreateCVS.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreateCVS.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreateCVS.MarkedText = "";
            this.hsCreateCVS.MarkMode = false;
            this.hsCreateCVS.Name = "hsCreateCVS";
            this.hsCreateCVS.NonMarkedText = "Create CSV";
            this.hsCreateCVS.Size = new System.Drawing.Size(99, 56);
            this.hsCreateCVS.TabIndex = 7;
            this.hsCreateCVS.Text = "Create CSV";
            this.hsCreateCVS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCreateCVS.ToolTipActive = false;
            this.hsCreateCVS.ToolTipAutomaticDelay = 500;
            this.hsCreateCVS.ToolTipAutoPopDelay = 5000;
            this.hsCreateCVS.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCreateCVS.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCreateCVS.ToolTipFor4ContextMenu = true;
            this.hsCreateCVS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCreateCVS.ToolTipInitialDelay = 500;
            this.hsCreateCVS.ToolTipIsBallon = false;
            this.hsCreateCVS.ToolTipOwnerDraw = false;
            this.hsCreateCVS.ToolTipReshowDelay = 100;
            this.hsCreateCVS.ToolTipShowAlways = false;
            this.hsCreateCVS.ToolTipText = "";
            this.hsCreateCVS.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCreateCVS.ToolTipTitle = "";
            this.hsCreateCVS.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCreateCVS.UseVisualStyleBackColor = false;
            this.hsCreateCVS.Click += new System.EventHandler(this.hsCreateCVS_Click);
            // 
            // hsSaveSourceCodes
            // 
            this.hsSaveSourceCodes.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveSourceCodes.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveSourceCodes.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveSourceCodes.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveSourceCodes.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveSourceCodes.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveSourceCodes.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveSourceCodes.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveSourceCodes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveSourceCodes.FlatAppearance.BorderSize = 0;
            this.hsSaveSourceCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveSourceCodes.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveSourceCodes.Image = global::FBXpert.Properties.Resources.data_export_blue_x32;
            this.hsSaveSourceCodes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveSourceCodes.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x32;
            this.hsSaveSourceCodes.ImageToggleOnSelect = true;
            this.hsSaveSourceCodes.Location = new System.Drawing.Point(0, 0);
            this.hsSaveSourceCodes.Marked = false;
            this.hsSaveSourceCodes.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSourceCodes.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSourceCodes.MarkedText = "";
            this.hsSaveSourceCodes.MarkMode = false;
            this.hsSaveSourceCodes.Name = "hsSaveSourceCodes";
            this.hsSaveSourceCodes.NonMarkedText = "Create sourcecode";
            this.hsSaveSourceCodes.Size = new System.Drawing.Size(127, 56);
            this.hsSaveSourceCodes.TabIndex = 6;
            this.hsSaveSourceCodes.Text = "Create sourcecode";
            this.hsSaveSourceCodes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveSourceCodes.ToolTipActive = false;
            this.hsSaveSourceCodes.ToolTipAutomaticDelay = 500;
            this.hsSaveSourceCodes.ToolTipAutoPopDelay = 5000;
            this.hsSaveSourceCodes.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveSourceCodes.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveSourceCodes.ToolTipFor4ContextMenu = true;
            this.hsSaveSourceCodes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveSourceCodes.ToolTipInitialDelay = 500;
            this.hsSaveSourceCodes.ToolTipIsBallon = false;
            this.hsSaveSourceCodes.ToolTipOwnerDraw = false;
            this.hsSaveSourceCodes.ToolTipReshowDelay = 100;
            this.hsSaveSourceCodes.ToolTipShowAlways = false;
            this.hsSaveSourceCodes.ToolTipText = "";
            this.hsSaveSourceCodes.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveSourceCodes.ToolTipTitle = "";
            this.hsSaveSourceCodes.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveSourceCodes.UseVisualStyleBackColor = false;
            this.hsSaveSourceCodes.Click += new System.EventHandler(this.hsSaveSourceCodes_Click);
            // 
            // xmlEditStruktur
            // 
            this.xmlEditStruktur.Caption = "Input File";
            this.xmlEditStruktur.DefaultExt = "xml";
            this.xmlEditStruktur.Dock = System.Windows.Forms.DockStyle.Left;
            this.xmlEditStruktur.EditorFont = new System.Drawing.Font("Courier New", 10F);
            this.xmlEditStruktur.Filter = "Xml files|*.xml|All files|*.*";
            this.xmlEditStruktur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlEditStruktur.KeyName = "XmlFile";
            this.xmlEditStruktur.LastXmlDirKey = "LastXmlDir";
            this.xmlEditStruktur.Location = new System.Drawing.Point(3, 64);
            this.xmlEditStruktur.Margin = new System.Windows.Forms.Padding(0);
            this.xmlEditStruktur.MinimumSize = new System.Drawing.Size(200, 100);
            this.xmlEditStruktur.Name = "xmlEditStruktur";
            this.xmlEditStruktur.Size = new System.Drawing.Size(625, 582);
            this.xmlEditStruktur.StatusBarVisible = false;
            this.xmlEditStruktur.TabIndex = 2;
            // 
            // pnlXML_UPPER
            // 
            this.pnlXML_UPPER.BackColor = System.Drawing.SystemColors.Control;
            this.pnlXML_UPPER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlXML_UPPER.Controls.Add(this.gbSourceCode);
            this.pnlXML_UPPER.Controls.Add(this.hsCreateClasses);
            this.pnlXML_UPPER.Controls.Add(this.hsSaveXML);
            this.pnlXML_UPPER.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXML_UPPER.Location = new System.Drawing.Point(3, 3);
            this.pnlXML_UPPER.Name = "pnlXML_UPPER";
            this.pnlXML_UPPER.Size = new System.Drawing.Size(1587, 61);
            this.pnlXML_UPPER.TabIndex = 1;
            // 
            // gbSourceCode
            // 
            this.gbSourceCode.Controls.Add(this.txtSourceCodePath);
            this.gbSourceCode.Controls.Add(this.hsSelectPath);
            this.gbSourceCode.Location = new System.Drawing.Point(863, 0);
            this.gbSourceCode.Name = "gbSourceCode";
            this.gbSourceCode.Size = new System.Drawing.Size(656, 49);
            this.gbSourceCode.TabIndex = 6;
            this.gbSourceCode.TabStop = false;
            this.gbSourceCode.Text = "Source code path";
            // 
            // txtSourceCodePath
            // 
            this.txtSourceCodePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourceCodePath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceCodePath.Location = new System.Drawing.Point(3, 16);
            this.txtSourceCodePath.Name = "txtSourceCodePath";
            this.txtSourceCodePath.Size = new System.Drawing.Size(585, 20);
            this.txtSourceCodePath.TabIndex = 0;
            this.txtSourceCodePath.Text = "D:\\Temp";
            // 
            // hsSelectPath
            // 
            this.hsSelectPath.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSelectPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectPath.FlatAppearance.BorderSize = 0;
            this.hsSelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsSelectPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsSelectPath.ImageToggleOnSelect = false;
            this.hsSelectPath.Location = new System.Drawing.Point(588, 16);
            this.hsSelectPath.Marked = false;
            this.hsSelectPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectPath.MarkedText = "";
            this.hsSelectPath.MarkMode = false;
            this.hsSelectPath.Name = "hsSelectPath";
            this.hsSelectPath.NonMarkedText = "";
            this.hsSelectPath.Size = new System.Drawing.Size(65, 30);
            this.hsSelectPath.TabIndex = 4;
            this.hsSelectPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSelectPath.ToolTipActive = false;
            this.hsSelectPath.ToolTipAutomaticDelay = 500;
            this.hsSelectPath.ToolTipAutoPopDelay = 5000;
            this.hsSelectPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectPath.ToolTipFor4ContextMenu = true;
            this.hsSelectPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectPath.ToolTipInitialDelay = 500;
            this.hsSelectPath.ToolTipIsBallon = false;
            this.hsSelectPath.ToolTipOwnerDraw = false;
            this.hsSelectPath.ToolTipReshowDelay = 100;
            this.hsSelectPath.ToolTipShowAlways = false;
            this.hsSelectPath.ToolTipText = "";
            this.hsSelectPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectPath.ToolTipTitle = "";
            this.hsSelectPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectPath.UseVisualStyleBackColor = false;
            this.hsSelectPath.Click += new System.EventHandler(this.hsSelectPath_Click);
            // 
            // hsCreateClasses
            // 
            this.hsCreateClasses.BackColor = System.Drawing.Color.Transparent;
            this.hsCreateClasses.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCreateClasses.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCreateClasses.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCreateClasses.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCreateClasses.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCreateClasses.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCreateClasses.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCreateClasses.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreateClasses.FlatAppearance.BorderSize = 0;
            this.hsCreateClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreateClasses.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreateClasses.Image = global::FBXpert.Properties.Resources.applications_system;
            this.hsCreateClasses.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_32x;
            this.hsCreateClasses.ImageToggleOnSelect = true;
            this.hsCreateClasses.Location = new System.Drawing.Point(45, 0);
            this.hsCreateClasses.Marked = false;
            this.hsCreateClasses.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreateClasses.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreateClasses.MarkedText = "";
            this.hsCreateClasses.MarkMode = false;
            this.hsCreateClasses.Name = "hsCreateClasses";
            this.hsCreateClasses.NonMarkedText = "";
            this.hsCreateClasses.Size = new System.Drawing.Size(45, 57);
            this.hsCreateClasses.TabIndex = 5;
            this.hsCreateClasses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCreateClasses.ToolTipActive = false;
            this.hsCreateClasses.ToolTipAutomaticDelay = 500;
            this.hsCreateClasses.ToolTipAutoPopDelay = 5000;
            this.hsCreateClasses.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCreateClasses.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCreateClasses.ToolTipFor4ContextMenu = true;
            this.hsCreateClasses.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCreateClasses.ToolTipInitialDelay = 500;
            this.hsCreateClasses.ToolTipIsBallon = false;
            this.hsCreateClasses.ToolTipOwnerDraw = false;
            this.hsCreateClasses.ToolTipReshowDelay = 100;
            this.hsCreateClasses.ToolTipShowAlways = false;
            this.hsCreateClasses.ToolTipText = "";
            this.hsCreateClasses.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCreateClasses.ToolTipTitle = "";
            this.hsCreateClasses.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCreateClasses.UseVisualStyleBackColor = false;
            this.hsCreateClasses.Click += new System.EventHandler(this.hsCreateClasses_Click);
            // 
            // hsSaveXML
            // 
            this.hsSaveXML.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveXML.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveXML.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveXML.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveXML.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveXML.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveXML.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveXML.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveXML.FlatAppearance.BorderSize = 0;
            this.hsSaveXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveXML.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveXML.Image = global::FBXpert.Properties.Resources.data_export_blue_x32;
            this.hsSaveXML.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x32;
            this.hsSaveXML.ImageToggleOnSelect = true;
            this.hsSaveXML.Location = new System.Drawing.Point(0, 0);
            this.hsSaveXML.Marked = false;
            this.hsSaveXML.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveXML.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveXML.MarkedText = "";
            this.hsSaveXML.MarkMode = false;
            this.hsSaveXML.Name = "hsSaveXML";
            this.hsSaveXML.NonMarkedText = "";
            this.hsSaveXML.Size = new System.Drawing.Size(45, 57);
            this.hsSaveXML.TabIndex = 4;
            this.hsSaveXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveXML.ToolTipActive = false;
            this.hsSaveXML.ToolTipAutomaticDelay = 500;
            this.hsSaveXML.ToolTipAutoPopDelay = 5000;
            this.hsSaveXML.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveXML.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveXML.ToolTipFor4ContextMenu = true;
            this.hsSaveXML.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveXML.ToolTipInitialDelay = 500;
            this.hsSaveXML.ToolTipIsBallon = false;
            this.hsSaveXML.ToolTipOwnerDraw = false;
            this.hsSaveXML.ToolTipReshowDelay = 100;
            this.hsSaveXML.ToolTipShowAlways = false;
            this.hsSaveXML.ToolTipText = "";
            this.hsSaveXML.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveXML.ToolTipTitle = "";
            this.hsSaveXML.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveXML.UseVisualStyleBackColor = false;
            this.hsSaveXML.Click += new System.EventHandler(this.hsSave_Click);
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.fctMessages);
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1593, 649);
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
            this.fctMessages.Location = new System.Drawing.Point(3, 49);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.ReadOnly = true;
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1587, 597);
            this.fctMessages.TabIndex = 2;
            this.fctMessages.WordWrap = true;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1587, 46);
            this.pnlMessagesUpper.TabIndex = 5;
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
            this.hsClearMessages.Size = new System.Drawing.Size(45, 42);
            this.hsClearMessages.TabIndex = 1;
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
            // tabPageCreateAttributes
            // 
            this.tabPageCreateAttributes.Controls.Add(this.pnlCenterCreateAttributes);
            this.tabPageCreateAttributes.Controls.Add(this.panel2);
            this.tabPageCreateAttributes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCreateAttributes.ImageIndex = 3;
            this.tabPageCreateAttributes.Location = new System.Drawing.Point(4, 23);
            this.tabPageCreateAttributes.Name = "tabPageCreateAttributes";
            this.tabPageCreateAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateAttributes.Size = new System.Drawing.Size(1593, 649);
            this.tabPageCreateAttributes.TabIndex = 2;
            this.tabPageCreateAttributes.Text = "Einstellungen";
            this.tabPageCreateAttributes.UseVisualStyleBackColor = true;
            this.tabPageCreateAttributes.Enter += new System.EventHandler(this.tabPageCreateAttributes_Enter);
            this.tabPageCreateAttributes.Leave += new System.EventHandler(this.tabPageCreateAttributes_Leave);
            // 
            // pnlCenterCreateAttributes
            // 
            this.pnlCenterCreateAttributes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCenterCreateAttributes.Controls.Add(this.gbDBNamespace);
            this.pnlCenterCreateAttributes.Controls.Add(this.gbPrimaryFieldType);
            this.pnlCenterCreateAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterCreateAttributes.Location = new System.Drawing.Point(3, 49);
            this.pnlCenterCreateAttributes.Name = "pnlCenterCreateAttributes";
            this.pnlCenterCreateAttributes.Size = new System.Drawing.Size(1587, 597);
            this.pnlCenterCreateAttributes.TabIndex = 7;
            // 
            // gbDBNamespace
            // 
            this.gbDBNamespace.Controls.Add(this.txtDBNamespace);
            this.gbDBNamespace.Location = new System.Drawing.Point(15, 158);
            this.gbDBNamespace.Name = "gbDBNamespace";
            this.gbDBNamespace.Size = new System.Drawing.Size(206, 46);
            this.gbDBNamespace.TabIndex = 9;
            this.gbDBNamespace.TabStop = false;
            this.gbDBNamespace.Text = "Namespace";
            // 
            // txtDBNamespace
            // 
            this.txtDBNamespace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDBNamespace.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBNamespace.Location = new System.Drawing.Point(3, 16);
            this.txtDBNamespace.Name = "txtDBNamespace";
            this.txtDBNamespace.Size = new System.Drawing.Size(200, 20);
            this.txtDBNamespace.TabIndex = 0;
            this.txtDBNamespace.Text = "ProjectDatas";
            this.txtDBNamespace.TextChanged += new System.EventHandler(this.codeAttributes_Changed);
            // 
            // gbPrimaryFieldType
            // 
            this.gbPrimaryFieldType.Controls.Add(this.rbGUIDHEXGeneration);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateOID);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateInrWithGenerator);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateGUID);
            this.gbPrimaryFieldType.Location = new System.Drawing.Point(15, 19);
            this.gbPrimaryFieldType.Name = "gbPrimaryFieldType";
            this.gbPrimaryFieldType.Size = new System.Drawing.Size(267, 133);
            this.gbPrimaryFieldType.TabIndex = 0;
            this.gbPrimaryFieldType.TabStop = false;
            this.gbPrimaryFieldType.Text = "FieldType primary field";
            // 
            // rbGUIDHEXGeneration
            // 
            this.rbGUIDHEXGeneration.AutoSize = true;
            this.rbGUIDHEXGeneration.Location = new System.Drawing.Point(12, 97);
            this.rbGUIDHEXGeneration.Name = "rbGUIDHEXGeneration";
            this.rbGUIDHEXGeneration.Size = new System.Drawing.Size(235, 17);
            this.rbGUIDHEXGeneration.TabIndex = 3;
            this.rbGUIDHEXGeneration.Text = "String(32) with GUID-HEX generation";
            this.rbGUIDHEXGeneration.UseVisualStyleBackColor = true;
            this.rbGUIDHEXGeneration.CheckedChanged += new System.EventHandler(this.codeAttributes_Changed);
            // 
            // rbGenerateOID
            // 
            this.rbGenerateOID.AutoSize = true;
            this.rbGenerateOID.Location = new System.Drawing.Point(12, 74);
            this.rbGenerateOID.Name = "rbGenerateOID";
            this.rbGenerateOID.Size = new System.Drawing.Size(205, 17);
            this.rbGenerateOID.TabIndex = 2;
            this.rbGenerateOID.Text = "BigInteger with OID generation";
            this.rbGenerateOID.UseVisualStyleBackColor = true;
            this.rbGenerateOID.CheckedChanged += new System.EventHandler(this.codeAttributes_Changed);
            // 
            // rbGenerateInrWithGenerator
            // 
            this.rbGenerateInrWithGenerator.AutoSize = true;
            this.rbGenerateInrWithGenerator.Checked = true;
            this.rbGenerateInrWithGenerator.Location = new System.Drawing.Point(12, 28);
            this.rbGenerateInrWithGenerator.Name = "rbGenerateInrWithGenerator";
            this.rbGenerateInrWithGenerator.Size = new System.Drawing.Size(157, 17);
            this.rbGenerateInrWithGenerator.TabIndex = 1;
            this.rbGenerateInrWithGenerator.TabStop = true;
            this.rbGenerateInrWithGenerator.Text = "Integer with generator";
            this.rbGenerateInrWithGenerator.UseVisualStyleBackColor = true;
            this.rbGenerateInrWithGenerator.CheckedChanged += new System.EventHandler(this.codeAttributes_Changed);
            // 
            // rbGenerateGUID
            // 
            this.rbGenerateGUID.AutoSize = true;
            this.rbGenerateGUID.Location = new System.Drawing.Point(12, 51);
            this.rbGenerateGUID.Name = "rbGenerateGUID";
            this.rbGenerateGUID.Size = new System.Drawing.Size(187, 17);
            this.rbGenerateGUID.TabIndex = 0;
            this.rbGenerateGUID.Text = "String with GUID generation";
            this.rbGenerateGUID.UseVisualStyleBackColor = true;
            this.rbGenerateGUID.CheckedChanged += new System.EventHandler(this.codeAttributes_Changed);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1587, 46);
            this.panel2.TabIndex = 6;
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
            // XmlDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 741);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XmlDesignForm";
            this.Text = "XMLDesignForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XMLDesignForm_FormClosing);
            this.Load += new System.EventHandler(this.XMLDesignForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageXML.ResumeLayout(false);
            this.pnlSourceCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSource)).EndInit();
            this.cmsSourceCode.ResumeLayout(false);
            this.cmsSourceCode.PerformLayout();
            this.pnlUpperSourceCode.ResumeLayout(false);
            this.gbFoundLines.ResumeLayout(false);
            this.gbSearchCode.ResumeLayout(false);
            this.gbSearchCode.PerformLayout();
            this.gbDBObjets.ResumeLayout(false);
            this.gbExportProgress.ResumeLayout(false);
            this.pnlDBObjectsParameters.ResumeLayout(false);
            this.pnlDBObjectsParameters.PerformLayout();
            this.pnlUpperDBObjects.ResumeLayout(false);
            this.pnlXML_UPPER.ResumeLayout(false);
            this.gbSourceCode.ResumeLayout(false);
            this.gbSourceCode.PerformLayout();
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessagesUpper.ResumeLayout(false);
            this.tabPageCreateAttributes.ResumeLayout(false);
            this.pnlCenterCreateAttributes.ResumeLayout(false);
            this.gbDBNamespace.ResumeLayout(false);
            this.gbDBNamespace.PerformLayout();
            this.gbPrimaryFieldType.ResumeLayout(false);
            this.gbPrimaryFieldType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsRefresh;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsSaveXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageXML;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.ImageList ilTabControl;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsClearMessages;
        private System.Windows.Forms.Panel pnlXML_UPPER;
        private System.Windows.Forms.Label lblCaption;
        private XMLSimlpeEdit.XMLEditSimpleUserControl xmlEditStruktur;
        private SeControlsLib.HotSpot hsCreateClasses;
        private FastColoredTextBoxNS.FastColoredTextBox fctSource;
        private System.Windows.Forms.GroupBox gbDBObjets;
        private SEListBox.SEListBox selDBObjects;
        private System.Windows.Forms.FolderBrowserDialog fbdSourcePath;
        private SeControlsLib.HotSpot hsSaveSourceCodes;
        private System.Windows.Forms.GroupBox gbExportProgress;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.Windows.Forms.Panel pnlDBObjectsParameters;
        private System.Windows.Forms.TabPage tabPageCreateAttributes;
        private System.Windows.Forms.Panel pnlCenterCreateAttributes;
        private System.Windows.Forms.GroupBox gbPrimaryFieldType;
        private System.Windows.Forms.RadioButton rbGenerateInrWithGenerator;
        private System.Windows.Forms.RadioButton rbGenerateGUID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsSourceCode;
        private System.Windows.Forms.ToolStripTextBox tsTextSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchNext;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchFirst;
        private System.Windows.Forms.Panel pnlSourceCode;
        private System.Windows.Forms.Panel pnlUpperSourceCode;
        private SeControlsLib.HotSpot hsSeach;
        private SeControlsLib.HotSpot hsSearchUp;
        private System.Windows.Forms.GroupBox gbSearchCode;
        private System.Windows.Forms.TextBox txtSearchCode;
        private SeControlsLib.HotSpot hsSearchDown;
        private System.Windows.Forms.GroupBox gbFoundLines;
        private System.Windows.Forms.ComboBox cbFoundLines;
        private System.Windows.Forms.Panel pnlUpperDBObjects;
        private System.Windows.Forms.GroupBox gbDBNamespace;
        private System.Windows.Forms.TextBox txtDBNamespace;
        private System.Windows.Forms.GroupBox gbSourceCode;
        private System.Windows.Forms.TextBox txtSourceCodePath;
        private SeControlsLib.HotSpot hsSelectPath;
        private SeControlsLib.HotSpot hsCreateCVS;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.CheckBox ckDeleteOldSourceFiles;
        private System.Windows.Forms.RadioButton rbGenerateOID;
        private System.Windows.Forms.RadioButton rbGUIDHEXGeneration;
    }
}