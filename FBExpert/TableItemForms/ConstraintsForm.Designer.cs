using BasicForms;

namespace FBXpert
{
    partial class ConstraintsForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstraintsForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.pnlSQL = new System.Windows.Forms.Panel();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsCreate = new SeControlsLib.HotSpot();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.gbConstraintTyp = new System.Windows.Forms.GroupBox();
            this.rbChecks = new System.Windows.Forms.RadioButton();
            this.rbForeignkey = new System.Windows.Forms.RadioButton();
            this.rbUnique = new System.Windows.Forms.RadioButton();
            this.rbPrimaryKey = new System.Windows.Forms.RadioButton();
            this.gbUsingIndex = new System.Windows.Forms.GroupBox();
            this.txtINDEXName = new System.Windows.Forms.TextBox();
            this.gbGenDescription = new System.Windows.Forms.GroupBox();
            this.fctGenDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbFieldList = new System.Windows.Forms.GroupBox();
            this.lvFields = new System.Windows.Forms.ListView();
            this.colFIELDNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAddRemoveFields = new System.Windows.Forms.GroupBox();
            this.hsRemoveField = new SeControlsLib.HotSpot();
            this.hsAddField = new SeControlsLib.HotSpot();
            this.cbFields = new System.Windows.Forms.ComboBox();
            this.gbChecksCode = new System.Windows.Forms.GroupBox();
            this.fcbChecksCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbConstraintName = new System.Windows.Forms.GroupBox();
            this.txtConstraintName = new System.Windows.Forms.TextBox();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsNew = new SeControlsLib.HotSpot();
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
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            this.pnlSQL.SuspendLayout();
            this.gbSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.gbConstraintTyp.SuspendLayout();
            this.gbUsingIndex.SuspendLayout();
            this.gbGenDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctGenDescription)).BeginInit();
            this.gbFieldList.SuspendLayout();
            this.gbAddRemoveFields.SuspendLayout();
            this.gbChecksCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbChecksCode)).BeginInit();
            this.gbConstraintName.SuspendLayout();
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
            this.lblTableName.Location = new System.Drawing.Point(96, 10);
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
            this.pnlCenter.Size = new System.Drawing.Size(1119, 598);
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
            this.tabControlFields.Size = new System.Drawing.Size(1119, 598);
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
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1111, 571);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.pnlSQL);
            this.pnlFieldsCenter.Controls.Add(this.pnlFields);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 48);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1105, 520);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // pnlSQL
            // 
            this.pnlSQL.Controls.Add(this.gbSQL);
            this.pnlSQL.Controls.Add(this.pnlSQLUpper);
            this.pnlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSQL.Location = new System.Drawing.Point(480, 0);
            this.pnlSQL.Name = "pnlSQL";
            this.pnlSQL.Size = new System.Drawing.Size(625, 520);
            this.pnlSQL.TabIndex = 29;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.fctSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(0, 45);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(625, 475);
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(27, 14);
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
            this.fctSQL.Size = new System.Drawing.Size(619, 456);
            this.fctSQL.TabIndex = 1;
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
            this.pnlSQLUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(625, 45);
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
            this.hsLoadSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQL.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(169, 0);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(82, 41);
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
            this.hsSaveSQL.Location = new System.Drawing.Point(89, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Size = new System.Drawing.Size(80, 41);
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
            this.hsCreate.Size = new System.Drawing.Size(89, 41);
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
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.gbConstraintTyp);
            this.pnlFields.Controls.Add(this.gbUsingIndex);
            this.pnlFields.Controls.Add(this.gbGenDescription);
            this.pnlFields.Controls.Add(this.gbFieldList);
            this.pnlFields.Controls.Add(this.gbChecksCode);
            this.pnlFields.Controls.Add(this.gbConstraintName);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(480, 520);
            this.pnlFields.TabIndex = 28;
            // 
            // gbConstraintTyp
            // 
            this.gbConstraintTyp.Controls.Add(this.rbChecks);
            this.gbConstraintTyp.Controls.Add(this.rbForeignkey);
            this.gbConstraintTyp.Controls.Add(this.rbUnique);
            this.gbConstraintTyp.Controls.Add(this.rbPrimaryKey);
            this.gbConstraintTyp.Location = new System.Drawing.Point(267, 9);
            this.gbConstraintTyp.Name = "gbConstraintTyp";
            this.gbConstraintTyp.Size = new System.Drawing.Size(162, 137);
            this.gbConstraintTyp.TabIndex = 22;
            this.gbConstraintTyp.TabStop = false;
            this.gbConstraintTyp.Text = "Constraint Typ";
            // 
            // rbChecks
            // 
            this.rbChecks.AutoSize = true;
            this.rbChecks.Location = new System.Drawing.Point(6, 88);
            this.rbChecks.Name = "rbChecks";
            this.rbChecks.Size = new System.Drawing.Size(61, 17);
            this.rbChecks.TabIndex = 25;
            this.rbChecks.TabStop = true;
            this.rbChecks.Text = "Checks";
            this.rbChecks.UseVisualStyleBackColor = true;
            this.rbChecks.CheckedChanged += new System.EventHandler(this.ConstraintEditChanged);
            // 
            // rbForeignkey
            // 
            this.rbForeignkey.AutoSize = true;
            this.rbForeignkey.Location = new System.Drawing.Point(6, 19);
            this.rbForeignkey.Name = "rbForeignkey";
            this.rbForeignkey.Size = new System.Drawing.Size(81, 17);
            this.rbForeignkey.TabIndex = 24;
            this.rbForeignkey.TabStop = true;
            this.rbForeignkey.Text = "Foreign Key";
            this.rbForeignkey.UseVisualStyleBackColor = true;
            this.rbForeignkey.CheckedChanged += new System.EventHandler(this.ConstraintEditChanged);
            // 
            // rbUnique
            // 
            this.rbUnique.AutoSize = true;
            this.rbUnique.Location = new System.Drawing.Point(6, 65);
            this.rbUnique.Name = "rbUnique";
            this.rbUnique.Size = new System.Drawing.Size(59, 17);
            this.rbUnique.TabIndex = 23;
            this.rbUnique.TabStop = true;
            this.rbUnique.Text = "Unique";
            this.rbUnique.UseVisualStyleBackColor = true;
            this.rbUnique.CheckedChanged += new System.EventHandler(this.ConstraintEditChanged);
            // 
            // rbPrimaryKey
            // 
            this.rbPrimaryKey.AutoSize = true;
            this.rbPrimaryKey.Location = new System.Drawing.Point(6, 42);
            this.rbPrimaryKey.Name = "rbPrimaryKey";
            this.rbPrimaryKey.Size = new System.Drawing.Size(80, 17);
            this.rbPrimaryKey.TabIndex = 22;
            this.rbPrimaryKey.TabStop = true;
            this.rbPrimaryKey.Text = "Primary Key";
            this.rbPrimaryKey.UseVisualStyleBackColor = true;
            this.rbPrimaryKey.CheckedChanged += new System.EventHandler(this.ConstraintEditChanged);
            // 
            // gbUsingIndex
            // 
            this.gbUsingIndex.Controls.Add(this.txtINDEXName);
            this.gbUsingIndex.Location = new System.Drawing.Point(267, 152);
            this.gbUsingIndex.Name = "gbUsingIndex";
            this.gbUsingIndex.Size = new System.Drawing.Size(162, 46);
            this.gbUsingIndex.TabIndex = 26;
            this.gbUsingIndex.TabStop = false;
            this.gbUsingIndex.Text = "Using Index";
            // 
            // txtINDEXName
            // 
            this.txtINDEXName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtINDEXName.Location = new System.Drawing.Point(3, 16);
            this.txtINDEXName.Name = "txtINDEXName";
            this.txtINDEXName.Size = new System.Drawing.Size(156, 20);
            this.txtINDEXName.TabIndex = 1;
            this.txtINDEXName.TextChanged += new System.EventHandler(this.ConstraintEditChanged);
            // 
            // gbGenDescription
            // 
            this.gbGenDescription.Controls.Add(this.fctGenDescription);
            this.gbGenDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbGenDescription.Location = new System.Drawing.Point(0, 431);
            this.gbGenDescription.Name = "gbGenDescription";
            this.gbGenDescription.Size = new System.Drawing.Size(480, 89);
            this.gbGenDescription.TabIndex = 11;
            this.gbGenDescription.TabStop = false;
            this.gbGenDescription.Text = "Gen Description";
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
            this.fctGenDescription.Size = new System.Drawing.Size(474, 70);
            this.fctGenDescription.TabIndex = 7;
            this.fctGenDescription.Zoom = 100;
            this.fctGenDescription.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.ConstraintEditChanged);
            // 
            // gbFieldList
            // 
            this.gbFieldList.Controls.Add(this.lvFields);
            this.gbFieldList.Controls.Add(this.gbAddRemoveFields);
            this.gbFieldList.Location = new System.Drawing.Point(7, 120);
            this.gbFieldList.Name = "gbFieldList";
            this.gbFieldList.Size = new System.Drawing.Size(245, 230);
            this.gbFieldList.TabIndex = 25;
            this.gbFieldList.TabStop = false;
            this.gbFieldList.Text = "Constraints->Fields";
            // 
            // lvFields
            // 
            this.lvFields.AllowColumnReorder = true;
            this.lvFields.AutoArrange = false;
            this.lvFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFIELDNAME});
            this.lvFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFields.FullRowSelect = true;
            this.lvFields.GridLines = true;
            this.lvFields.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvFields.Location = new System.Drawing.Point(3, 16);
            this.lvFields.Name = "lvFields";
            this.lvFields.Size = new System.Drawing.Size(239, 144);
            this.lvFields.TabIndex = 2;
            this.lvFields.UseCompatibleStateImageBehavior = false;
            this.lvFields.View = System.Windows.Forms.View.Details;
            this.lvFields.SelectedIndexChanged += new System.EventHandler(this.lvFields_SelectedIndexChanged);
            // 
            // colFIELDNAME
            // 
            this.colFIELDNAME.Text = "FieldName";
            this.colFIELDNAME.Width = 220;
            // 
            // gbAddRemoveFields
            // 
            this.gbAddRemoveFields.Controls.Add(this.hsRemoveField);
            this.gbAddRemoveFields.Controls.Add(this.hsAddField);
            this.gbAddRemoveFields.Controls.Add(this.cbFields);
            this.gbAddRemoveFields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbAddRemoveFields.Location = new System.Drawing.Point(3, 160);
            this.gbAddRemoveFields.Name = "gbAddRemoveFields";
            this.gbAddRemoveFields.Size = new System.Drawing.Size(239, 67);
            this.gbAddRemoveFields.TabIndex = 24;
            this.gbAddRemoveFields.TabStop = false;
            // 
            // hsRemoveField
            // 
            this.hsRemoveField.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveField.FlatAppearance.BorderSize = 0;
            this.hsRemoveField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveField.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsRemoveField.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsRemoveField.ImageToggleOnSelect = true;
            this.hsRemoveField.Location = new System.Drawing.Point(3, 6);
            this.hsRemoveField.Marked = false;
            this.hsRemoveField.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveField.MarkedText = "";
            this.hsRemoveField.MarkMode = false;
            this.hsRemoveField.Name = "hsRemoveField";
            this.hsRemoveField.NonMarkedText = "";
            this.hsRemoveField.Size = new System.Drawing.Size(45, 27);
            this.hsRemoveField.TabIndex = 21;
            this.hsRemoveField.ToolTipActive = false;
            this.hsRemoveField.ToolTipAutomaticDelay = 500;
            this.hsRemoveField.ToolTipAutoPopDelay = 5000;
            this.hsRemoveField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveField.ToolTipFor4ContextMenu = true;
            this.hsRemoveField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveField.ToolTipInitialDelay = 500;
            this.hsRemoveField.ToolTipIsBallon = false;
            this.hsRemoveField.ToolTipOwnerDraw = false;
            this.hsRemoveField.ToolTipReshowDelay = 100;
            
            this.hsRemoveField.ToolTipShowAlways = false;
            this.hsRemoveField.ToolTipText = "";
            this.hsRemoveField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveField.ToolTipTitle = "";
            this.hsRemoveField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveField.UseVisualStyleBackColor = false;
            this.hsRemoveField.Click += new System.EventHandler(this.hsRemoveField_Click_1);
            // 
            // hsAddField
            // 
            this.hsAddField.BackColor = System.Drawing.Color.Transparent;
            this.hsAddField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddField.FlatAppearance.BorderSize = 0;
            this.hsAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddField.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddField.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddField.ImageToggleOnSelect = true;
            this.hsAddField.Location = new System.Drawing.Point(54, 6);
            this.hsAddField.Marked = false;
            this.hsAddField.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddField.MarkedText = "";
            this.hsAddField.MarkMode = false;
            this.hsAddField.Name = "hsAddField";
            this.hsAddField.NonMarkedText = "";
            this.hsAddField.Size = new System.Drawing.Size(45, 27);
            this.hsAddField.TabIndex = 20;
            this.hsAddField.ToolTipActive = false;
            this.hsAddField.ToolTipAutomaticDelay = 500;
            this.hsAddField.ToolTipAutoPopDelay = 5000;
            this.hsAddField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddField.ToolTipFor4ContextMenu = true;
            this.hsAddField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddField.ToolTipInitialDelay = 500;
            this.hsAddField.ToolTipIsBallon = false;
            this.hsAddField.ToolTipOwnerDraw = false;
            this.hsAddField.ToolTipReshowDelay = 100;
            
            this.hsAddField.ToolTipShowAlways = false;
            this.hsAddField.ToolTipText = "";
            this.hsAddField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddField.ToolTipTitle = "";
            this.hsAddField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddField.UseVisualStyleBackColor = false;
            this.hsAddField.Click += new System.EventHandler(this.hsAddField_Click_1);
            // 
            // cbFields
            // 
            this.cbFields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbFields.FormattingEnabled = true;
            this.cbFields.Location = new System.Drawing.Point(3, 43);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(233, 21);
            this.cbFields.TabIndex = 19;
            // 
            // gbChecksCode
            // 
            this.gbChecksCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChecksCode.Controls.Add(this.fcbChecksCode);
            this.gbChecksCode.Location = new System.Drawing.Point(267, 210);
            this.gbChecksCode.Name = "gbChecksCode";
            this.gbChecksCode.Size = new System.Drawing.Size(196, 188);
            this.gbChecksCode.TabIndex = 27;
            this.gbChecksCode.TabStop = false;
            this.gbChecksCode.Text = "Checks code";
            // 
            // fcbChecksCode
            // 
            this.fcbChecksCode.AutoCompleteBracketsList = new char[] {
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
            this.fcbChecksCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fcbChecksCode.BackBrush = null;
            this.fcbChecksCode.BackColor = System.Drawing.SystemColors.Window;
            this.fcbChecksCode.CharHeight = 14;
            this.fcbChecksCode.CharWidth = 8;
            this.fcbChecksCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbChecksCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbChecksCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbChecksCode.IsReplaceMode = false;
            this.fcbChecksCode.Location = new System.Drawing.Point(3, 16);
            this.fcbChecksCode.Name = "fcbChecksCode";
            this.fcbChecksCode.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbChecksCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbChecksCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbChecksCode.ServiceColors")));
            this.fcbChecksCode.Size = new System.Drawing.Size(190, 169);
            this.fcbChecksCode.TabIndex = 7;
            this.fcbChecksCode.Zoom = 100;
            // 
            // gbConstraintName
            // 
            this.gbConstraintName.Controls.Add(this.txtConstraintName);
            this.gbConstraintName.Location = new System.Drawing.Point(4, 9);
            this.gbConstraintName.Name = "gbConstraintName";
            this.gbConstraintName.Size = new System.Drawing.Size(245, 45);
            this.gbConstraintName.TabIndex = 0;
            this.gbConstraintName.TabStop = false;
            this.gbConstraintName.Text = "Constraint Name";
            // 
            // txtConstraintName
            // 
            this.txtConstraintName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConstraintName.Location = new System.Drawing.Point(3, 16);
            this.txtConstraintName.Name = "txtConstraintName";
            this.txtConstraintName.Size = new System.Drawing.Size(239, 20);
            this.txtConstraintName.TabIndex = 0;
            this.txtConstraintName.Text = "NEW_CNSTR";
            this.txtConstraintName.TextChanged += new System.EventHandler(this.ConstraintNameChanged);
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsNew);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1105, 45);
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
            this.hsNew.Size = new System.Drawing.Size(89, 41);
            this.hsNew.TabIndex = 1;
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
            this.hsNew.Click += new System.EventHandler(this.hsNEWClick);
            // 
            // tabPageDependencies
            // 
            this.tabPageDependencies.Controls.Add(this.dgvDependenciesTo);
            this.tabPageDependencies.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageDependencies.ImageIndex = 16;
            this.tabPageDependencies.Location = new System.Drawing.Point(4, 23);
            this.tabPageDependencies.Name = "tabPageDependencies";
            this.tabPageDependencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependencies.Size = new System.Drawing.Size(1111, 571);
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
            this.dgvDependenciesTo.Location = new System.Drawing.Point(3, 48);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1105, 520);
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
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1105, 45);
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
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1028, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "Refresh";
            this.hsRefreshDependencies.Size = new System.Drawing.Size(73, 41);
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
            this.tabPageMessages.Size = new System.Drawing.Size(1111, 571);
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
            this.fctMessages.Location = new System.Drawing.Point(3, 48);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1105, 520);
            this.fctMessages.TabIndex = 28;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hotSpot3);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1105, 45);
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
            this.hotSpot3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot3.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot3.ImageToggleOnSelect = true;
            this.hotSpot3.Location = new System.Drawing.Point(1012, 0);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "Refresh";
            this.hotSpot3.Size = new System.Drawing.Size(89, 41);
            this.hotSpot3.TabIndex = 2;
            this.hotSpot3.Text = "Refresh";
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
            // ConstraintsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 640);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConstraintsForm";
            this.Text = "ConstraintsForm";
            this.Load += new System.EventHandler(this.ConstraintsForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.pnlSQL.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.gbConstraintTyp.ResumeLayout(false);
            this.gbConstraintTyp.PerformLayout();
            this.gbUsingIndex.ResumeLayout(false);
            this.gbUsingIndex.PerformLayout();
            this.gbGenDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctGenDescription)).EndInit();
            this.gbFieldList.ResumeLayout(false);
            this.gbAddRemoveFields.ResumeLayout(false);
            this.gbChecksCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbChecksCode)).EndInit();
            this.gbConstraintName.ResumeLayout(false);
            this.gbConstraintName.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbConstraintName;
        private System.Windows.Forms.TextBox txtConstraintName;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.GroupBox gbGenDescription;
        private FastColoredTextBoxNS.FastColoredTextBox fctGenDescription;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsNew;
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
        private System.Windows.Forms.GroupBox gbConstraintTyp;
        private System.Windows.Forms.RadioButton rbUnique;
        private System.Windows.Forms.RadioButton rbPrimaryKey;
        private System.Windows.Forms.GroupBox gbFieldList;
        private System.Windows.Forms.ListView lvFields;
        private System.Windows.Forms.ColumnHeader colFIELDNAME;
        private System.Windows.Forms.GroupBox gbAddRemoveFields;
        private SeControlsLib.HotSpot hsRemoveField;
        private SeControlsLib.HotSpot hsAddField;
        private System.Windows.Forms.ComboBox cbFields;
        private System.Windows.Forms.GroupBox gbUsingIndex;
        private System.Windows.Forms.RadioButton rbForeignkey;
        private System.Windows.Forms.TextBox txtINDEXName;
        private System.Windows.Forms.GroupBox gbChecksCode;
        private FastColoredTextBoxNS.FastColoredTextBox fcbChecksCode;
        private System.Windows.Forms.RadioButton rbChecks;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel pnlSQL;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsCreate;
        private System.Windows.Forms.Panel pnlFields;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
    }
}