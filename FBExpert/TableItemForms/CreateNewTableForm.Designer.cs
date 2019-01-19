using BasicForms;

namespace FBExpert
{
    partial class CreateNewTableForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTableForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsCancel = new SeControlsLib.HotSpot();
            this.hsSave = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageNewTable = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.gbSQLText = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsCraete = new SeControlsLib.HotSpot();
            this.pnlEditFields = new System.Windows.Forms.Panel();
            this.gbFieldDescription = new System.Windows.Forms.GroupBox();
            this.fctDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbDefault = new System.Windows.Forms.GroupBox();
            this.txtDefault = new System.Windows.Forms.TextBox();
            this.hsSelectDefault = new SeControlsLib.HotSpot();
            this.gbFieldAttributes = new System.Windows.Forms.GroupBox();
            this.tabControlFld = new System.Windows.Forms.TabControl();
            this.tabPageDomain = new System.Windows.Forms.TabPage();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.cbDOMAIN = new System.Windows.Forms.ComboBox();
            this.hsNewDomain = new SeControlsLib.HotSpot();
            this.hsEditDomain = new SeControlsLib.HotSpot();
            this.tabPageField = new System.Windows.Forms.TabPage();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.gbDomainAttributes = new System.Windows.Forms.GroupBox();
            this.gbTextProperties = new System.Windows.Forms.GroupBox();
            this.gbLength = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.gbCharSet = new System.Windows.Forms.GroupBox();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.gbCollate = new System.Windows.Forms.GroupBox();
            this.cbCollate = new System.Windows.Forms.ComboBox();
            this.gbPrecisionProperties = new System.Windows.Forms.GroupBox();
            this.gbPrecisionLength = new System.Windows.Forms.GroupBox();
            this.txtPrecisionLength = new System.Windows.Forms.TextBox();
            this.gbScale = new System.Windows.Forms.GroupBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.cbNotNull = new System.Windows.Forms.CheckBox();
            this.cbPrimaryKey = new System.Windows.Forms.CheckBox();
            this.pnlFieldsUpper = new System.Windows.Forms.Panel();
            this.gbFieldName = new System.Windows.Forms.GroupBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.gbTableName = new System.Windows.Forms.GroupBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessageUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.bsDependencies = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependencies = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageNewTable.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            this.gbSQLText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.pnlEditFields.SuspendLayout();
            this.gbFieldDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).BeginInit();
            this.gbDefault.SuspendLayout();
            this.gbFieldAttributes.SuspendLayout();
            this.tabControlFld.SuspendLayout();
            this.tabPageDomain.SuspendLayout();
            this.gbDomain.SuspendLayout();
            this.tabPageField.SuspendLayout();
            this.gbTypes.SuspendLayout();
            this.gbDomainAttributes.SuspendLayout();
            this.gbTextProperties.SuspendLayout();
            this.gbLength.SuspendLayout();
            this.gbCharSet.SuspendLayout();
            this.gbCollate.SuspendLayout();
            this.gbPrecisionProperties.SuspendLayout();
            this.gbPrecisionLength.SuspendLayout();
            this.gbScale.SuspendLayout();
            this.pnlFieldsUpper.SuspendLayout();
            this.gbFieldName.SuspendLayout();
            this.gbTableName.SuspendLayout();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessageUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblCaption);
            this.pnlUpper.Controls.Add(this.hsCancel);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1505, 55);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(208, 20);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(109, 25);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "lblCaption";
            // 
            // hsCancel
            // 
            this.hsCancel.BackColor = System.Drawing.Color.Transparent;
            this.hsCancel.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCancel.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCancel.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCancel.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCancel.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCancel.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCancel.FlatAppearance.BorderSize = 0;
            this.hsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCancel.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancel.Image = global::FBXpert.Properties.Resources.cross_red_x32;
            this.hsCancel.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x32;
            this.hsCancel.ImageToggleOnSelect = true;
            this.hsCancel.Location = new System.Drawing.Point(0, 0);
            this.hsCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsCancel.Marked = false;
            this.hsCancel.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancel.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancel.MarkedText = "";
            this.hsCancel.MarkMode = false;
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.NonMarkedText = "";
            this.hsCancel.Size = new System.Drawing.Size(60, 55);
            this.hsCancel.TabIndex = 2;
            this.hsCancel.ToolTipActive = false;
            this.hsCancel.ToolTipAutomaticDelay = 500;
            this.hsCancel.ToolTipAutoPopDelay = 5000;
            this.hsCancel.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCancel.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCancel.ToolTipFor4ContextMenu = true;
            this.hsCancel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCancel.ToolTipInitialDelay = 500;
            this.hsCancel.ToolTipIsBallon = false;
            this.hsCancel.ToolTipOwnerDraw = false;
            this.hsCancel.ToolTipReshowDelay = 100;
            
            this.hsCancel.ToolTipShowAlways = false;
            this.hsCancel.ToolTipText = "";
            this.hsCancel.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCancel.ToolTipTitle = "";
            this.hsCancel.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCancel.UseVisualStyleBackColor = false;
            this.hsCancel.Click += new System.EventHandler(this.hsCancel_Click);
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
            this.hsSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "New";
            this.hsSave.Size = new System.Drawing.Size(103, 47);
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
            this.hsSave.Click += new System.EventHandler(this.hsSave_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 55);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1505, 757);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPageNewTable);
            this.tabControlFields.Controls.Add(this.tabPageMessages);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.ImageList = this.ilTabControl;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1505, 757);
            this.tabControlFields.TabIndex = 17;
            // 
            // tabPageNewTable
            // 
            this.tabPageNewTable.Controls.Add(this.pnlFieldsCenter);
            this.tabPageNewTable.Controls.Add(this.pnlFieldUpper);
            this.tabPageNewTable.ImageIndex = 2;
            this.tabPageNewTable.Location = new System.Drawing.Point(4, 25);
            this.tabPageNewTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNewTable.Name = "tabPageNewTable";
            this.tabPageNewTable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNewTable.Size = new System.Drawing.Size(1497, 728);
            this.tabPageNewTable.TabIndex = 0;
            this.tabPageNewTable.Text = "New Table";
            this.tabPageNewTable.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.gbSQLText);
            this.pnlFieldsCenter.Controls.Add(this.pnlSQLUpper);
            this.pnlFieldsCenter.Controls.Add(this.pnlEditFields);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(4, 55);
            this.pnlFieldsCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1489, 669);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // gbSQLText
            // 
            this.gbSQLText.Controls.Add(this.fctSQL);
            this.gbSQLText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQLText.Location = new System.Drawing.Point(544, 51);
            this.gbSQLText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSQLText.Name = "gbSQLText";
            this.gbSQLText.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSQLText.Size = new System.Drawing.Size(945, 618);
            this.gbSQLText.TabIndex = 9;
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fctSQL.CharHeight = 18;
            this.fctSQL.CharWidth = 10;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(4, 19);
            this.fctSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(937, 595);
            this.fctSQL.TabIndex = 1;
            this.fctSQL.Zoom = 100;
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Controls.Add(this.hsCraete);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(544, 0);
            this.pnlSQLUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(945, 51);
            this.pnlSQLUpper.TabIndex = 21;
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
            this.hsLoadSQL.Location = new System.Drawing.Point(210, 0);
            this.hsLoadSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(109, 47);
            this.hsLoadSQL.TabIndex = 13;
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
            this.hsSaveSQL.Location = new System.Drawing.Point(103, 0);
            this.hsSaveSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Size = new System.Drawing.Size(107, 47);
            this.hsSaveSQL.TabIndex = 12;
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
            // hsCraete
            // 
            this.hsCraete.BackColor = System.Drawing.Color.Transparent;
            this.hsCraete.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCraete.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCraete.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCraete.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCraete.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCraete.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCraete.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCraete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCraete.FlatAppearance.BorderSize = 0;
            this.hsCraete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCraete.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCraete.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsCraete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCraete.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsCraete.ImageToggleOnSelect = true;
            this.hsCraete.Location = new System.Drawing.Point(0, 0);
            this.hsCraete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsCraete.Marked = false;
            this.hsCraete.MarkedColor = System.Drawing.Color.Teal;
            this.hsCraete.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCraete.MarkedText = "";
            this.hsCraete.MarkMode = false;
            this.hsCraete.Name = "hsCraete";
            this.hsCraete.NonMarkedText = "Execute";
            this.hsCraete.Size = new System.Drawing.Size(103, 47);
            this.hsCraete.TabIndex = 1;
            this.hsCraete.Text = "Execute";
            this.hsCraete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCraete.ToolTipActive = false;
            this.hsCraete.ToolTipAutomaticDelay = 500;
            this.hsCraete.ToolTipAutoPopDelay = 5000;
            this.hsCraete.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCraete.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCraete.ToolTipFor4ContextMenu = true;
            this.hsCraete.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCraete.ToolTipInitialDelay = 500;
            this.hsCraete.ToolTipIsBallon = false;
            this.hsCraete.ToolTipOwnerDraw = false;
            this.hsCraete.ToolTipReshowDelay = 100;
            
            this.hsCraete.ToolTipShowAlways = false;
            this.hsCraete.ToolTipText = "";
            this.hsCraete.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCraete.ToolTipTitle = "";
            this.hsCraete.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCraete.UseVisualStyleBackColor = false;
            this.hsCraete.Click += new System.EventHandler(this.hsCraete_Click);
            // 
            // pnlEditFields
            // 
            this.pnlEditFields.Controls.Add(this.gbFieldDescription);
            this.pnlEditFields.Controls.Add(this.gbDefault);
            this.pnlEditFields.Controls.Add(this.gbFieldAttributes);
            this.pnlEditFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEditFields.Location = new System.Drawing.Point(0, 0);
            this.pnlEditFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEditFields.Name = "pnlEditFields";
            this.pnlEditFields.Size = new System.Drawing.Size(544, 669);
            this.pnlEditFields.TabIndex = 20;
            // 
            // gbFieldDescription
            // 
            this.gbFieldDescription.Controls.Add(this.fctDescription);
            this.gbFieldDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFieldDescription.Location = new System.Drawing.Point(0, 486);
            this.gbFieldDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFieldDescription.Name = "gbFieldDescription";
            this.gbFieldDescription.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFieldDescription.Size = new System.Drawing.Size(544, 183);
            this.gbFieldDescription.TabIndex = 11;
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
            this.fctDescription.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fctDescription.BackBrush = null;
            this.fctDescription.BackColor = System.Drawing.SystemColors.Window;
            this.fctDescription.CharHeight = 18;
            this.fctDescription.CharWidth = 10;
            this.fctDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctDescription.IsReplaceMode = false;
            this.fctDescription.Location = new System.Drawing.Point(4, 19);
            this.fctDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fctDescription.Name = "fctDescription";
            this.fctDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctDescription.ServiceColors")));
            this.fctDescription.Size = new System.Drawing.Size(536, 160);
            this.fctDescription.TabIndex = 7;
            this.fctDescription.Zoom = 100;
            this.fctDescription.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctDescription_TextChanged);
            // 
            // gbDefault
            // 
            this.gbDefault.Controls.Add(this.txtDefault);
            this.gbDefault.Controls.Add(this.hsSelectDefault);
            this.gbDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDefault.Location = new System.Drawing.Point(0, 426);
            this.gbDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDefault.Name = "gbDefault";
            this.gbDefault.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDefault.Size = new System.Drawing.Size(544, 60);
            this.gbDefault.TabIndex = 18;
            this.gbDefault.TabStop = false;
            this.gbDefault.Text = "Default";
            // 
            // txtDefault
            // 
            this.txtDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefault.Location = new System.Drawing.Point(4, 19);
            this.txtDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDefault.Name = "txtDefault";
            this.txtDefault.Size = new System.Drawing.Size(495, 22);
            this.txtDefault.TabIndex = 0;
            this.txtDefault.TextChanged += new System.EventHandler(this.txtDefault_TextChanged);
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
            this.hsSelectDefault.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectDefault.Image = global::FBXpert.Properties.Resources.font_x24;
            this.hsSelectDefault.ImageHover = global::FBXpert.Properties.Resources.font2_x24;
            this.hsSelectDefault.ImageToggleOnSelect = true;
            this.hsSelectDefault.Location = new System.Drawing.Point(499, 19);
            this.hsSelectDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsSelectDefault.Marked = false;
            this.hsSelectDefault.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectDefault.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectDefault.MarkedText = "";
            this.hsSelectDefault.MarkMode = false;
            this.hsSelectDefault.Name = "hsSelectDefault";
            this.hsSelectDefault.NonMarkedText = "";
            this.hsSelectDefault.Size = new System.Drawing.Size(41, 37);
            this.hsSelectDefault.TabIndex = 2;
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
            // gbFieldAttributes
            // 
            this.gbFieldAttributes.Controls.Add(this.tabControlFld);
            this.gbFieldAttributes.Controls.Add(this.pnlFieldsUpper);
            this.gbFieldAttributes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFieldAttributes.Location = new System.Drawing.Point(0, 0);
            this.gbFieldAttributes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFieldAttributes.Name = "gbFieldAttributes";
            this.gbFieldAttributes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFieldAttributes.Size = new System.Drawing.Size(544, 426);
            this.gbFieldAttributes.TabIndex = 1;
            this.gbFieldAttributes.TabStop = false;
            this.gbFieldAttributes.Text = "Field attributes";
            // 
            // tabControlFld
            // 
            this.tabControlFld.Controls.Add(this.tabPageDomain);
            this.tabControlFld.Controls.Add(this.tabPageField);
            this.tabControlFld.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlFld.Location = new System.Drawing.Point(4, 123);
            this.tabControlFld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlFld.Name = "tabControlFld";
            this.tabControlFld.SelectedIndex = 0;
            this.tabControlFld.Size = new System.Drawing.Size(536, 312);
            this.tabControlFld.TabIndex = 18;
            this.tabControlFld.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageDomain
            // 
            this.tabPageDomain.Controls.Add(this.gbDomain);
            this.tabPageDomain.Location = new System.Drawing.Point(4, 25);
            this.tabPageDomain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDomain.Name = "tabPageDomain";
            this.tabPageDomain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDomain.Size = new System.Drawing.Size(528, 283);
            this.tabPageDomain.TabIndex = 0;
            this.tabPageDomain.Text = "Domain type";
            this.tabPageDomain.UseVisualStyleBackColor = true;
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.cbDOMAIN);
            this.gbDomain.Controls.Add(this.hsNewDomain);
            this.gbDomain.Controls.Add(this.hsEditDomain);
            this.gbDomain.Location = new System.Drawing.Point(8, 20);
            this.gbDomain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDomain.Size = new System.Drawing.Size(367, 48);
            this.gbDomain.TabIndex = 17;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Domain";
            // 
            // cbDOMAIN
            // 
            this.cbDOMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDOMAIN.FormattingEnabled = true;
            this.cbDOMAIN.Location = new System.Drawing.Point(4, 19);
            this.cbDOMAIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDOMAIN.Name = "cbDOMAIN";
            this.cbDOMAIN.Size = new System.Drawing.Size(277, 24);
            this.cbDOMAIN.TabIndex = 3;
            this.cbDOMAIN.SelectedIndexChanged += new System.EventHandler(this.cbDOMAIN_SelectedIndexChanged);
            // 
            // hsNewDomain
            // 
            this.hsNewDomain.BackColor = System.Drawing.Color.Transparent;
            this.hsNewDomain.BackColorHover = System.Drawing.Color.Transparent;
            this.hsNewDomain.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsNewDomain.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsNewDomain.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsNewDomain.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsNewDomain.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsNewDomain.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsNewDomain.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsNewDomain.FlatAppearance.BorderSize = 0;
            this.hsNewDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsNewDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsNewDomain.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsNewDomain.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsNewDomain.ImageToggleOnSelect = true;
            this.hsNewDomain.Location = new System.Drawing.Point(281, 19);
            this.hsNewDomain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsNewDomain.Marked = false;
            this.hsNewDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsNewDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNewDomain.MarkedText = "";
            this.hsNewDomain.MarkMode = false;
            this.hsNewDomain.Name = "hsNewDomain";
            this.hsNewDomain.NonMarkedText = "";
            this.hsNewDomain.Size = new System.Drawing.Size(41, 25);
            this.hsNewDomain.TabIndex = 4;
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
            // hsEditDomain
            // 
            this.hsEditDomain.BackColor = System.Drawing.Color.Transparent;
            this.hsEditDomain.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditDomain.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsEditDomain.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditDomain.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsEditDomain.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditDomain.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditDomain.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsEditDomain.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditDomain.FlatAppearance.BorderSize = 0;
            this.hsEditDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEditDomain.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.hsEditDomain.ImageHover = global::FBXpert.Properties.Resources.format_text_direction_blue_x22;
            this.hsEditDomain.ImageToggleOnSelect = true;
            this.hsEditDomain.Location = new System.Drawing.Point(322, 19);
            this.hsEditDomain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsEditDomain.Marked = false;
            this.hsEditDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditDomain.MarkedText = "";
            this.hsEditDomain.MarkMode = false;
            this.hsEditDomain.Name = "hsEditDomain";
            this.hsEditDomain.NonMarkedText = "";
            this.hsEditDomain.Size = new System.Drawing.Size(41, 25);
            this.hsEditDomain.TabIndex = 2;
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
            // tabPageField
            // 
            this.tabPageField.Controls.Add(this.gbTypes);
            this.tabPageField.Controls.Add(this.gbDomainAttributes);
            this.tabPageField.Controls.Add(this.cbNotNull);
            this.tabPageField.Location = new System.Drawing.Point(4, 25);
            this.tabPageField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageField.Name = "tabPageField";
            this.tabPageField.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageField.Size = new System.Drawing.Size(528, 283);
            this.tabPageField.TabIndex = 1;
            this.tabPageField.Text = "Field type";
            this.tabPageField.UseVisualStyleBackColor = true;
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.cbTypes);
            this.gbTypes.Location = new System.Drawing.Point(3, 21);
            this.gbTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTypes.Size = new System.Drawing.Size(279, 50);
            this.gbTypes.TabIndex = 3;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "FieldType";
            // 
            // cbTypes
            // 
            this.cbTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "VARCHAR",
            "INTEGER",
            "TIMESTAMP",
            "DATE",
            "DOUBLE PRECISION",
            "NUMERIC"});
            this.cbTypes.Location = new System.Drawing.Point(4, 19);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(271, 24);
            this.cbTypes.TabIndex = 1;
            this.cbTypes.Text = "INTEGER";
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // gbDomainAttributes
            // 
            this.gbDomainAttributes.Controls.Add(this.gbTextProperties);
            this.gbDomainAttributes.Controls.Add(this.gbPrecisionProperties);
            this.gbDomainAttributes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDomainAttributes.Location = new System.Drawing.Point(4, 86);
            this.gbDomainAttributes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDomainAttributes.Name = "gbDomainAttributes";
            this.gbDomainAttributes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDomainAttributes.Size = new System.Drawing.Size(520, 193);
            this.gbDomainAttributes.TabIndex = 19;
            this.gbDomainAttributes.TabStop = false;
            this.gbDomainAttributes.Text = "Domain attributes";
            // 
            // gbTextProperties
            // 
            this.gbTextProperties.Controls.Add(this.gbLength);
            this.gbTextProperties.Controls.Add(this.gbCharSet);
            this.gbTextProperties.Controls.Add(this.gbCollate);
            this.gbTextProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTextProperties.Location = new System.Drawing.Point(4, 101);
            this.gbTextProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTextProperties.Name = "gbTextProperties";
            this.gbTextProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTextProperties.Size = new System.Drawing.Size(512, 82);
            this.gbTextProperties.TabIndex = 7;
            this.gbTextProperties.TabStop = false;
            this.gbTextProperties.Text = "Text Properties";
            // 
            // gbLength
            // 
            this.gbLength.Controls.Add(this.txtLength);
            this.gbLength.Location = new System.Drawing.Point(12, 23);
            this.gbLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLength.Name = "gbLength";
            this.gbLength.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLength.Size = new System.Drawing.Size(140, 48);
            this.gbLength.TabIndex = 4;
            this.gbLength.TabStop = false;
            this.gbLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLength.Location = new System.Drawing.Point(4, 19);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(132, 22);
            this.txtLength.TabIndex = 0;
            this.txtLength.Text = "8";
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // gbCharSet
            // 
            this.gbCharSet.Controls.Add(this.cbCharSet);
            this.gbCharSet.Location = new System.Drawing.Point(161, 23);
            this.gbCharSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCharSet.Name = "gbCharSet";
            this.gbCharSet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCharSet.Size = new System.Drawing.Size(152, 48);
            this.gbCharSet.TabIndex = 5;
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
            this.cbCharSet.Location = new System.Drawing.Point(4, 19);
            this.cbCharSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(144, 24);
            this.cbCharSet.TabIndex = 2;
            this.cbCharSet.Text = "NONE";
            this.cbCharSet.SelectedIndexChanged += new System.EventHandler(this.cbCharSet_SelectedIndexChanged);
            // 
            // gbCollate
            // 
            this.gbCollate.Controls.Add(this.cbCollate);
            this.gbCollate.Location = new System.Drawing.Point(321, 23);
            this.gbCollate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCollate.Name = "gbCollate";
            this.gbCollate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCollate.Size = new System.Drawing.Size(172, 48);
            this.gbCollate.TabIndex = 6;
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
            this.cbCollate.Location = new System.Drawing.Point(4, 19);
            this.cbCollate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCollate.Name = "cbCollate";
            this.cbCollate.Size = new System.Drawing.Size(164, 24);
            this.cbCollate.TabIndex = 2;
            this.cbCollate.Text = "NONE";
            this.cbCollate.SelectedIndexChanged += new System.EventHandler(this.cbCollate_SelectedIndexChanged);
            // 
            // gbPrecisionProperties
            // 
            this.gbPrecisionProperties.Controls.Add(this.gbPrecisionLength);
            this.gbPrecisionProperties.Controls.Add(this.gbScale);
            this.gbPrecisionProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPrecisionProperties.Location = new System.Drawing.Point(4, 19);
            this.gbPrecisionProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPrecisionProperties.Name = "gbPrecisionProperties";
            this.gbPrecisionProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPrecisionProperties.Size = new System.Drawing.Size(512, 82);
            this.gbPrecisionProperties.TabIndex = 8;
            this.gbPrecisionProperties.TabStop = false;
            this.gbPrecisionProperties.Text = "Numeric Properties";
            // 
            // gbPrecisionLength
            // 
            this.gbPrecisionLength.Controls.Add(this.txtPrecisionLength);
            this.gbPrecisionLength.Location = new System.Drawing.Point(12, 23);
            this.gbPrecisionLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPrecisionLength.Name = "gbPrecisionLength";
            this.gbPrecisionLength.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPrecisionLength.Size = new System.Drawing.Size(144, 48);
            this.gbPrecisionLength.TabIndex = 4;
            this.gbPrecisionLength.TabStop = false;
            this.gbPrecisionLength.Text = "Precision Length";
            // 
            // txtPrecisionLength
            // 
            this.txtPrecisionLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecisionLength.Location = new System.Drawing.Point(4, 19);
            this.txtPrecisionLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecisionLength.Name = "txtPrecisionLength";
            this.txtPrecisionLength.Size = new System.Drawing.Size(136, 22);
            this.txtPrecisionLength.TabIndex = 0;
            this.txtPrecisionLength.Text = "8";
            this.txtPrecisionLength.TextChanged += new System.EventHandler(this.txtPrecisionLength_TextChanged);
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.txtScale);
            this.gbScale.Location = new System.Drawing.Point(164, 23);
            this.gbScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbScale.Name = "gbScale";
            this.gbScale.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbScale.Size = new System.Drawing.Size(79, 48);
            this.gbScale.TabIndex = 5;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "Scale";
            // 
            // txtScale
            // 
            this.txtScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScale.Location = new System.Drawing.Point(4, 19);
            this.txtScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(71, 22);
            this.txtScale.TabIndex = 0;
            this.txtScale.Text = "3";
            this.txtScale.TextChanged += new System.EventHandler(this.txtScale_TextChanged);
            // 
            // cbNotNull
            // 
            this.cbNotNull.AutoSize = true;
            this.cbNotNull.Location = new System.Drawing.Point(306, 42);
            this.cbNotNull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNotNull.Name = "cbNotNull";
            this.cbNotNull.Size = new System.Drawing.Size(100, 21);
            this.cbNotNull.TabIndex = 14;
            this.cbNotNull.Text = "NOT NULL";
            this.cbNotNull.UseVisualStyleBackColor = true;
            this.cbNotNull.CheckedChanged += new System.EventHandler(this.cbNotNull_CheckedChanged);
            // 
            // cbPrimaryKey
            // 
            this.cbPrimaryKey.AutoSize = true;
            this.cbPrimaryKey.Location = new System.Drawing.Point(201, 68);
            this.cbPrimaryKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrimaryKey.Name = "cbPrimaryKey";
            this.cbPrimaryKey.Size = new System.Drawing.Size(106, 21);
            this.cbPrimaryKey.TabIndex = 15;
            this.cbPrimaryKey.Text = "Primary Key";
            this.cbPrimaryKey.UseVisualStyleBackColor = true;
            this.cbPrimaryKey.CheckedChanged += new System.EventHandler(this.cbPrimaryKey_CheckedChanged);
            // 
            // pnlFieldsUpper
            // 
            this.pnlFieldsUpper.Controls.Add(this.gbFieldName);
            this.pnlFieldsUpper.Controls.Add(this.gbTableName);
            this.pnlFieldsUpper.Controls.Add(this.cbPrimaryKey);
            this.pnlFieldsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldsUpper.Location = new System.Drawing.Point(4, 19);
            this.pnlFieldsUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFieldsUpper.Name = "pnlFieldsUpper";
            this.pnlFieldsUpper.Size = new System.Drawing.Size(536, 104);
            this.pnlFieldsUpper.TabIndex = 19;
            // 
            // gbFieldName
            // 
            this.gbFieldName.Controls.Add(this.txtFieldName);
            this.gbFieldName.Location = new System.Drawing.Point(200, 5);
            this.gbFieldName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFieldName.Name = "gbFieldName";
            this.gbFieldName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFieldName.Size = new System.Drawing.Size(267, 55);
            this.gbFieldName.TabIndex = 0;
            this.gbFieldName.TabStop = false;
            this.gbFieldName.Text = "Field Name";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldName.Location = new System.Drawing.Point(4, 19);
            this.txtFieldName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(259, 22);
            this.txtFieldName.TabIndex = 0;
            this.txtFieldName.Text = "NEW_FIELD";
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // gbTableName
            // 
            this.gbTableName.BackColor = System.Drawing.SystemColors.Control;
            this.gbTableName.Controls.Add(this.txtTableName);
            this.gbTableName.Location = new System.Drawing.Point(9, 5);
            this.gbTableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTableName.Name = "gbTableName";
            this.gbTableName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTableName.Size = new System.Drawing.Size(220, 55);
            this.gbTableName.TabIndex = 2;
            this.gbTableName.TabStop = false;
            this.gbTableName.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableName.Location = new System.Drawing.Point(4, 19);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(212, 22);
            this.txtTableName.TabIndex = 0;
            this.txtTableName.Text = "NEW_FIELD";
            this.txtTableName.TextChanged += new System.EventHandler(this.txtTableName_TextChanged);
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsSave);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(4, 4);
            this.pnlFieldUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1489, 51);
            this.pnlFieldUpper.TabIndex = 1;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.fctMessages);
            this.tabPageMessages.Controls.Add(this.pnlMessageUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 25);
            this.tabPageMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMessages.Size = new System.Drawing.Size(1497, 728);
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
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 18;
            this.fctMessages.CharWidth = 10;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(4, 61);
            this.fctMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1489, 663);
            this.fctMessages.TabIndex = 25;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessageUpper
            // 
            this.pnlMessageUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessageUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessageUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessageUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessageUpper.Location = new System.Drawing.Point(4, 4);
            this.pnlMessageUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMessageUpper.Name = "pnlMessageUpper";
            this.pnlMessageUpper.Size = new System.Drawing.Size(1489, 57);
            this.pnlMessageUpper.TabIndex = 21;
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
            this.hsClearMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hsClearMessages.Marked = false;
            this.hsClearMessages.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearMessages.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearMessages.MarkedText = "";
            this.hsClearMessages.MarkMode = false;
            this.hsClearMessages.Name = "hsClearMessages";
            this.hsClearMessages.NonMarkedText = "Clear";
            this.hsClearMessages.Size = new System.Drawing.Size(60, 53);
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
            // bsDependencies
            // 
            this.bsDependencies.DataMember = "Table";
            this.bsDependencies.DataSource = this.dsDependencies;
            // 
            // dsDependencies
            // 
            this.dsDependencies.DataSetName = "NewDataSet";
            this.dsDependencies.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable5});
            // 
            // dataTable5
            // 
            this.dataTable5.TableName = "Table";
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
            // CreateNewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 812);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateNewTableForm";
            this.Text = "CreateNewTableForm";
            this.Load += new System.EventHandler(this.CreateNewTableForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageNewTable.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.gbSQLText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.pnlEditFields.ResumeLayout(false);
            this.gbFieldDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).EndInit();
            this.gbDefault.ResumeLayout(false);
            this.gbDefault.PerformLayout();
            this.gbFieldAttributes.ResumeLayout(false);
            this.tabControlFld.ResumeLayout(false);
            this.tabPageDomain.ResumeLayout(false);
            this.gbDomain.ResumeLayout(false);
            this.tabPageField.ResumeLayout(false);
            this.tabPageField.PerformLayout();
            this.gbTypes.ResumeLayout(false);
            this.gbDomainAttributes.ResumeLayout(false);
            this.gbTextProperties.ResumeLayout(false);
            this.gbLength.ResumeLayout(false);
            this.gbLength.PerformLayout();
            this.gbCharSet.ResumeLayout(false);
            this.gbCollate.ResumeLayout(false);
            this.gbPrecisionProperties.ResumeLayout(false);
            this.gbPrecisionLength.ResumeLayout(false);
            this.gbPrecisionLength.PerformLayout();
            this.gbScale.ResumeLayout(false);
            this.gbScale.PerformLayout();
            this.pnlFieldsUpper.ResumeLayout(false);
            this.pnlFieldsUpper.PerformLayout();
            this.gbFieldName.ResumeLayout(false);
            this.gbFieldName.PerformLayout();
            this.gbTableName.ResumeLayout(false);
            this.gbTableName.PerformLayout();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessageUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox gbFieldName;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.GroupBox gbLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox gbTextProperties;
        private System.Windows.Forms.GroupBox gbCollate;
        private System.Windows.Forms.GroupBox gbCharSet;
        private System.Windows.Forms.GroupBox gbPrecisionProperties;
        private System.Windows.Forms.GroupBox gbPrecisionLength;
        private System.Windows.Forms.TextBox txtPrecisionLength;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.TextBox txtScale;
        private SeControlsLib.HotSpot hsCancel;
        private System.Windows.Forms.GroupBox gbSQLText;
        private System.Windows.Forms.ComboBox cbCollate;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.GroupBox gbFieldDescription;
        private FastColoredTextBoxNS.FastColoredTextBox fctDescription;
        private System.Windows.Forms.CheckBox cbPrimaryKey;
        private System.Windows.Forms.CheckBox cbNotNull;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageNewTable;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.BindingSource bsDependencies;
        private System.Data.DataSet dsDependencies;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Panel pnlMessageUpper;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private SeControlsLib.HotSpot hsClearMessages;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.GroupBox gbDomain;
        private SeControlsLib.HotSpot hsEditDomain;
        private System.Windows.Forms.GroupBox gbDefault;
        private SeControlsLib.HotSpot hsSelectDefault;
        private System.Windows.Forms.TextBox txtDefault;
        private System.Windows.Forms.ComboBox cbDOMAIN;
        private System.Windows.Forms.GroupBox gbDomainAttributes;
        private SeControlsLib.HotSpot hsNewDomain;
        private System.Windows.Forms.GroupBox gbFieldAttributes;
        private System.Windows.Forms.Panel pnlEditFields;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.GroupBox gbTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TabControl tabControlFld;
        private System.Windows.Forms.TabPage tabPageDomain;
        private System.Windows.Forms.TabPage tabPageField;
        private System.Windows.Forms.Panel pnlFieldsUpper;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsCraete;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
    }
}