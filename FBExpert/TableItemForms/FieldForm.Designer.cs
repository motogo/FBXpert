using BasicForms;

namespace FBExpert
{
    partial class FieldForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsCancel = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.gbSQLText = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsSave = new SeControlsLib.HotSpot();
            this.pnlEditFields = new System.Windows.Forms.Panel();
            this.gbFieldDescription = new System.Windows.Forms.GroupBox();
            this.fctDescription = new FastColoredTextBoxNS.FastColoredTextBox();
            this.gbNULLDefault = new System.Windows.Forms.GroupBox();
            this.txtNULLDefault = new System.Windows.Forms.TextBox();
            this.hsGetNullDatasDefaults = new SeControlsLib.HotSpot();
            this.gbDefault = new System.Windows.Forms.GroupBox();
            this.txtDefault = new System.Windows.Forms.TextBox();
            this.hsSelectDefault = new SeControlsLib.HotSpot();
            this.gbFieldTypes = new System.Windows.Forms.GroupBox();
            this.tabControlFieldTypes = new System.Windows.Forms.TabControl();
            this.tabPageDomain = new System.Windows.Forms.TabPage();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.cbDOMAIN = new System.Windows.Forms.ComboBox();
            this.hsNewDomain = new SeControlsLib.HotSpot();
            this.hsEditDomain = new SeControlsLib.HotSpot();
            this.tabPageFieldType = new System.Windows.Forms.TabPage();
            this.gbBlobProperties = new System.Windows.Forms.GroupBox();
            this.gbBlobSize = new System.Windows.Forms.GroupBox();
            this.txtBlobSize = new System.Windows.Forms.TextBox();
            this.gbBlobType = new System.Windows.Forms.GroupBox();
            this.cbBlobType = new System.Windows.Forms.ComboBox();
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
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.cbFieldTypes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPK = new System.Windows.Forms.TextBox();
            this.cbNotNull = new System.Windows.Forms.CheckBox();
            this.cbPrimaryKey = new System.Windows.Forms.CheckBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.gbFieldName = new System.Windows.Forms.GroupBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsOrg = new SeControlsLib.HotSpot();
            this.hsNew = new SeControlsLib.HotSpot();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessageUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.tabPageDependencies = new System.Windows.Forms.TabPage();
            this.dgvDependenciesTo = new System.Windows.Forms.DataGridView();
            this.bsDependencies = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependencies = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.pnlDependenciesUpper = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.hsToggleNotNull = new SeControlsLib.HotSpot();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            this.gbSQLText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQLUpper.SuspendLayout();
            this.pnlEditFields.SuspendLayout();
            this.gbFieldDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).BeginInit();
            this.gbNULLDefault.SuspendLayout();
            this.gbDefault.SuspendLayout();
            this.gbFieldTypes.SuspendLayout();
            this.tabControlFieldTypes.SuspendLayout();
            this.tabPageDomain.SuspendLayout();
            this.gbDomain.SuspendLayout();
            this.tabPageFieldType.SuspendLayout();
            this.gbBlobProperties.SuspendLayout();
            this.gbBlobSize.SuspendLayout();
            this.gbBlobType.SuspendLayout();
            this.gbTextProperties.SuspendLayout();
            this.gbLength.SuspendLayout();
            this.gbCharSet.SuspendLayout();
            this.gbCollate.SuspendLayout();
            this.gbPrecisionProperties.SuspendLayout();
            this.gbPrecisionLength.SuspendLayout();
            this.gbScale.SuspendLayout();
            this.gbTypes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.gbFieldName.SuspendLayout();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessageUpper.SuspendLayout();
            this.tabPageDependencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.pnlDependenciesUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblCaption);
            this.pnlUpper.Controls.Add(this.hsCancel);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1520, 52);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(182, 19);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(89, 20);
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
            this.hsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCancel.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancel.Image = global::FBXpert.Properties.Resources.go_previous32x;
            this.hsCancel.ImageHover = global::FBXpert.Properties.Resources.go_left_blue32x;
            this.hsCancel.ImageToggleOnSelect = true;
            this.hsCancel.Location = new System.Drawing.Point(0, 0);
            this.hsCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsCancel.Marked = false;
            this.hsCancel.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancel.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancel.MarkedText = "";
            this.hsCancel.MarkMode = false;
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.NonMarkedText = "";
            this.hsCancel.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCancel.ShowShortcut = false;
            this.hsCancel.Size = new System.Drawing.Size(53, 52);
            this.hsCancel.TabIndex = 2;
            this.hsCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 52);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1520, 825);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPageFieldEdit);
            this.tabControlFields.Controls.Add(this.tabPageMessages);
            this.tabControlFields.Controls.Add(this.tabPageDependencies);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.ImageList = this.ilTabControl;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1520, 825);
            this.tabControlFields.TabIndex = 17;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldUpper);
            this.tabPageFieldEdit.ImageIndex = 2;
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 24);
            this.tabPageFieldEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1512, 797);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.gbSQLText);
            this.pnlFieldsCenter.Controls.Add(this.pnlEditFields);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 49);
            this.pnlFieldsCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1506, 744);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // gbSQLText
            // 
            this.gbSQLText.Controls.Add(this.fctSQL);
            this.gbSQLText.Controls.Add(this.pnlSQLUpper);
            this.gbSQLText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQLText.Location = new System.Drawing.Point(585, 0);
            this.gbSQLText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSQLText.Name = "gbSQLText";
            this.gbSQLText.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSQLText.Size = new System.Drawing.Size(921, 744);
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.Color.Bisque;
            this.fctSQL.CharHeight = 14;
            this.fctSQL.CharWidth = 8;
            this.fctSQL.CommentPrefix = "--";
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctSQL.LeftBracket = '(';
            this.fctSQL.Location = new System.Drawing.Point(3, 65);
            this.fctSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(915, 675);
            this.fctSQL.TabIndex = 1;
            this.fctSQL.WordWrap = true;
            this.fctSQL.Zoom = 100;
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLUpper.Controls.Add(this.hsLoadSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSaveSQL);
            this.pnlSQLUpper.Controls.Add(this.hsSave);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 20);
            this.pnlSQLUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(915, 45);
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
            this.hsLoadSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadSQL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQL.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSQL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadSQL.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQL.ImageToggleOnSelect = true;
            this.hsLoadSQL.Location = new System.Drawing.Point(160, 0);
            this.hsLoadSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadSQL.ShowShortcut = false;
            this.hsLoadSQL.Size = new System.Drawing.Size(96, 41);
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
            this.hsSaveSQL.Location = new System.Drawing.Point(67, 0);
            this.hsSaveSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveSQL.ShowShortcut = false;
            this.hsSaveSQL.Size = new System.Drawing.Size(93, 41);
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
            this.hsSave.Location = new System.Drawing.Point(0, 0);
            this.hsSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "Execute";
            this.hsSave.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSave.ShowShortcut = false;
            this.hsSave.Size = new System.Drawing.Size(67, 41);
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
            // pnlEditFields
            // 
            this.pnlEditFields.Controls.Add(this.gbFieldDescription);
            this.pnlEditFields.Controls.Add(this.gbNULLDefault);
            this.pnlEditFields.Controls.Add(this.gbDefault);
            this.pnlEditFields.Controls.Add(this.gbFieldTypes);
            this.pnlEditFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEditFields.Location = new System.Drawing.Point(0, 0);
            this.pnlEditFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEditFields.Name = "pnlEditFields";
            this.pnlEditFields.Size = new System.Drawing.Size(585, 744);
            this.pnlEditFields.TabIndex = 20;
            // 
            // gbFieldDescription
            // 
            this.gbFieldDescription.Controls.Add(this.fctDescription);
            this.gbFieldDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFieldDescription.Location = new System.Drawing.Point(0, 435);
            this.gbFieldDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFieldDescription.Name = "gbFieldDescription";
            this.gbFieldDescription.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFieldDescription.Size = new System.Drawing.Size(585, 309);
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
            this.fctDescription.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctDescription.BackBrush = null;
            this.fctDescription.BackColor = System.Drawing.SystemColors.Window;
            this.fctDescription.CharHeight = 14;
            this.fctDescription.CharWidth = 8;
            this.fctDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctDescription.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctDescription.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctDescription.IsReplaceMode = false;
            this.fctDescription.Location = new System.Drawing.Point(3, 20);
            this.fctDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fctDescription.Name = "fctDescription";
            this.fctDescription.Paddings = new System.Windows.Forms.Padding(0);
            this.fctDescription.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctDescription.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctDescription.ServiceColors")));
            this.fctDescription.Size = new System.Drawing.Size(579, 285);
            this.fctDescription.TabIndex = 7;
            this.fctDescription.Zoom = 100;
            this.fctDescription.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctDescription_TextChanged);
            // 
            // gbNULLDefault
            // 
            this.gbNULLDefault.Controls.Add(this.txtNULLDefault);
            this.gbNULLDefault.Controls.Add(this.hsGetNullDatasDefaults);
            this.gbNULLDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNULLDefault.Location = new System.Drawing.Point(0, 388);
            this.gbNULLDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNULLDefault.Name = "gbNULLDefault";
            this.gbNULLDefault.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNULLDefault.Size = new System.Drawing.Size(585, 47);
            this.gbNULLDefault.TabIndex = 20;
            this.gbNULLDefault.TabStop = false;
            this.gbNULLDefault.Text = "Set NULL Datas with Value";
            // 
            // txtNULLDefault
            // 
            this.txtNULLDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNULLDefault.Location = new System.Drawing.Point(3, 20);
            this.txtNULLDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNULLDefault.Name = "txtNULLDefault";
            this.txtNULLDefault.Size = new System.Drawing.Size(543, 23);
            this.txtNULLDefault.TabIndex = 0;
            this.txtNULLDefault.TextChanged += new System.EventHandler(this.txtNULLDefault_TextChanged);
            // 
            // hsGetNullDatasDefaults
            // 
            this.hsGetNullDatasDefaults.BackColor = System.Drawing.Color.Transparent;
            this.hsGetNullDatasDefaults.BackColorHover = System.Drawing.Color.Transparent;
            this.hsGetNullDatasDefaults.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsGetNullDatasDefaults.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsGetNullDatasDefaults.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsGetNullDatasDefaults.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsGetNullDatasDefaults.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsGetNullDatasDefaults.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsGetNullDatasDefaults.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsGetNullDatasDefaults.FlatAppearance.BorderSize = 0;
            this.hsGetNullDatasDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsGetNullDatasDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsGetNullDatasDefaults.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsGetNullDatasDefaults.Image = global::FBXpert.Properties.Resources.font_x24;
            this.hsGetNullDatasDefaults.ImageHover = global::FBXpert.Properties.Resources.font2_x24;
            this.hsGetNullDatasDefaults.ImageToggleOnSelect = true;
            this.hsGetNullDatasDefaults.Location = new System.Drawing.Point(546, 20);
            this.hsGetNullDatasDefaults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsGetNullDatasDefaults.Marked = false;
            this.hsGetNullDatasDefaults.MarkedColor = System.Drawing.Color.Teal;
            this.hsGetNullDatasDefaults.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsGetNullDatasDefaults.MarkedText = "";
            this.hsGetNullDatasDefaults.MarkMode = false;
            this.hsGetNullDatasDefaults.Name = "hsGetNullDatasDefaults";
            this.hsGetNullDatasDefaults.NonMarkedText = "";
            this.hsGetNullDatasDefaults.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsGetNullDatasDefaults.ShowShortcut = false;
            this.hsGetNullDatasDefaults.Size = new System.Drawing.Size(36, 23);
            this.hsGetNullDatasDefaults.TabIndex = 3;
            this.hsGetNullDatasDefaults.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsGetNullDatasDefaults.ToolTipActive = false;
            this.hsGetNullDatasDefaults.ToolTipAutomaticDelay = 500;
            this.hsGetNullDatasDefaults.ToolTipAutoPopDelay = 5000;
            this.hsGetNullDatasDefaults.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsGetNullDatasDefaults.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsGetNullDatasDefaults.ToolTipFor4ContextMenu = true;
            this.hsGetNullDatasDefaults.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsGetNullDatasDefaults.ToolTipInitialDelay = 500;
            this.hsGetNullDatasDefaults.ToolTipIsBallon = false;
            this.hsGetNullDatasDefaults.ToolTipOwnerDraw = false;
            this.hsGetNullDatasDefaults.ToolTipReshowDelay = 100;
            this.hsGetNullDatasDefaults.ToolTipShowAlways = false;
            this.hsGetNullDatasDefaults.ToolTipText = "";
            this.hsGetNullDatasDefaults.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsGetNullDatasDefaults.ToolTipTitle = "";
            this.hsGetNullDatasDefaults.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsGetNullDatasDefaults.UseVisualStyleBackColor = false;
            this.hsGetNullDatasDefaults.Click += new System.EventHandler(this.hsGetNullDatasDefaults_Click);
            // 
            // gbDefault
            // 
            this.gbDefault.Controls.Add(this.txtDefault);
            this.gbDefault.Controls.Add(this.hsSelectDefault);
            this.gbDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDefault.Location = new System.Drawing.Point(0, 341);
            this.gbDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDefault.Name = "gbDefault";
            this.gbDefault.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDefault.Size = new System.Drawing.Size(585, 47);
            this.gbDefault.TabIndex = 18;
            this.gbDefault.TabStop = false;
            this.gbDefault.Text = "Default";
            // 
            // txtDefault
            // 
            this.txtDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefault.Location = new System.Drawing.Point(3, 20);
            this.txtDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefault.Name = "txtDefault";
            this.txtDefault.Size = new System.Drawing.Size(543, 23);
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
            this.hsSelectDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSelectDefault.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectDefault.Image = global::FBXpert.Properties.Resources.font_x24;
            this.hsSelectDefault.ImageHover = global::FBXpert.Properties.Resources.font2_x24;
            this.hsSelectDefault.ImageToggleOnSelect = true;
            this.hsSelectDefault.Location = new System.Drawing.Point(546, 20);
            this.hsSelectDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsSelectDefault.Marked = false;
            this.hsSelectDefault.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectDefault.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectDefault.MarkedText = "";
            this.hsSelectDefault.MarkMode = false;
            this.hsSelectDefault.Name = "hsSelectDefault";
            this.hsSelectDefault.NonMarkedText = "";
            this.hsSelectDefault.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSelectDefault.ShowShortcut = false;
            this.hsSelectDefault.Size = new System.Drawing.Size(36, 23);
            this.hsSelectDefault.TabIndex = 2;
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
            // gbFieldTypes
            // 
            this.gbFieldTypes.Controls.Add(this.tabControlFieldTypes);
            this.gbFieldTypes.Controls.Add(this.groupBox2);
            this.gbFieldTypes.Controls.Add(this.gbPosition);
            this.gbFieldTypes.Controls.Add(this.gbFieldName);
            this.gbFieldTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFieldTypes.Location = new System.Drawing.Point(0, 0);
            this.gbFieldTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFieldTypes.Name = "gbFieldTypes";
            this.gbFieldTypes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFieldTypes.Size = new System.Drawing.Size(585, 341);
            this.gbFieldTypes.TabIndex = 1;
            this.gbFieldTypes.TabStop = false;
            this.gbFieldTypes.Text = "Fieldtype";
            // 
            // tabControlFieldTypes
            // 
            this.tabControlFieldTypes.Controls.Add(this.tabPageDomain);
            this.tabControlFieldTypes.Controls.Add(this.tabPageFieldType);
            this.tabControlFieldTypes.Location = new System.Drawing.Point(7, 90);
            this.tabControlFieldTypes.Name = "tabControlFieldTypes";
            this.tabControlFieldTypes.SelectedIndex = 0;
            this.tabControlFieldTypes.Size = new System.Drawing.Size(572, 244);
            this.tabControlFieldTypes.TabIndex = 10;
            this.tabControlFieldTypes.SelectedIndexChanged += new System.EventHandler(this.tabControlFieldTypes_SelectedIndexChanged);
            // 
            // tabPageDomain
            // 
            this.tabPageDomain.Controls.Add(this.gbDomain);
            this.tabPageDomain.Location = new System.Drawing.Point(4, 24);
            this.tabPageDomain.Name = "tabPageDomain";
            this.tabPageDomain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDomain.Size = new System.Drawing.Size(564, 216);
            this.tabPageDomain.TabIndex = 0;
            this.tabPageDomain.Text = "Domain";
            this.tabPageDomain.UseVisualStyleBackColor = true;
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.cbDOMAIN);
            this.gbDomain.Controls.Add(this.hsNewDomain);
            this.gbDomain.Controls.Add(this.hsEditDomain);
            this.gbDomain.Location = new System.Drawing.Point(6, 7);
            this.gbDomain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDomain.Size = new System.Drawing.Size(395, 47);
            this.gbDomain.TabIndex = 17;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Domain";
            // 
            // cbDOMAIN
            // 
            this.cbDOMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDOMAIN.FormattingEnabled = true;
            this.cbDOMAIN.Location = new System.Drawing.Point(3, 20);
            this.cbDOMAIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDOMAIN.Name = "cbDOMAIN";
            this.cbDOMAIN.Size = new System.Drawing.Size(317, 23);
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
            this.hsNewDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsNewDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsNewDomain.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsNewDomain.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsNewDomain.ImageToggleOnSelect = true;
            this.hsNewDomain.Location = new System.Drawing.Point(320, 20);
            this.hsNewDomain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsNewDomain.Marked = false;
            this.hsNewDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsNewDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNewDomain.MarkedText = "";
            this.hsNewDomain.MarkMode = false;
            this.hsNewDomain.Name = "hsNewDomain";
            this.hsNewDomain.NonMarkedText = "";
            this.hsNewDomain.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsNewDomain.ShowShortcut = false;
            this.hsNewDomain.Size = new System.Drawing.Size(36, 23);
            this.hsNewDomain.TabIndex = 4;
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
            this.hsEditDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsEditDomain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEditDomain.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.hsEditDomain.ImageHover = global::FBXpert.Properties.Resources.format_text_direction_blue_x22;
            this.hsEditDomain.ImageToggleOnSelect = true;
            this.hsEditDomain.Location = new System.Drawing.Point(356, 20);
            this.hsEditDomain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsEditDomain.Marked = false;
            this.hsEditDomain.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditDomain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditDomain.MarkedText = "";
            this.hsEditDomain.MarkMode = false;
            this.hsEditDomain.Name = "hsEditDomain";
            this.hsEditDomain.NonMarkedText = "";
            this.hsEditDomain.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsEditDomain.ShowShortcut = false;
            this.hsEditDomain.Size = new System.Drawing.Size(36, 23);
            this.hsEditDomain.TabIndex = 2;
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
            // tabPageFieldType
            // 
            this.tabPageFieldType.Controls.Add(this.gbBlobProperties);
            this.tabPageFieldType.Controls.Add(this.gbTextProperties);
            this.tabPageFieldType.Controls.Add(this.gbPrecisionProperties);
            this.tabPageFieldType.Controls.Add(this.gbTypes);
            this.tabPageFieldType.Location = new System.Drawing.Point(4, 24);
            this.tabPageFieldType.Name = "tabPageFieldType";
            this.tabPageFieldType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFieldType.Size = new System.Drawing.Size(564, 216);
            this.tabPageFieldType.TabIndex = 1;
            this.tabPageFieldType.Text = "Fieldtypes";
            this.tabPageFieldType.UseVisualStyleBackColor = true;
            // 
            // gbBlobProperties
            // 
            this.gbBlobProperties.Controls.Add(this.gbBlobSize);
            this.gbBlobProperties.Controls.Add(this.gbBlobType);
            this.gbBlobProperties.Location = new System.Drawing.Point(332, 58);
            this.gbBlobProperties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBlobProperties.Name = "gbBlobProperties";
            this.gbBlobProperties.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBlobProperties.Size = new System.Drawing.Size(220, 73);
            this.gbBlobProperties.TabIndex = 9;
            this.gbBlobProperties.TabStop = false;
            this.gbBlobProperties.Text = "BLOB Properties";
            // 
            // gbBlobSize
            // 
            this.gbBlobSize.Controls.Add(this.txtBlobSize);
            this.gbBlobSize.Location = new System.Drawing.Point(11, 22);
            this.gbBlobSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBlobSize.Name = "gbBlobSize";
            this.gbBlobSize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBlobSize.Size = new System.Drawing.Size(126, 45);
            this.gbBlobSize.TabIndex = 4;
            this.gbBlobSize.TabStop = false;
            this.gbBlobSize.Text = "Size (Bytes)";
            // 
            // txtBlobSize
            // 
            this.txtBlobSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBlobSize.Location = new System.Drawing.Point(3, 20);
            this.txtBlobSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBlobSize.Name = "txtBlobSize";
            this.txtBlobSize.Size = new System.Drawing.Size(120, 23);
            this.txtBlobSize.TabIndex = 0;
            this.txtBlobSize.TextChanged += new System.EventHandler(this.txtBlobSize_TextChanged);
            // 
            // gbBlobType
            // 
            this.gbBlobType.Controls.Add(this.cbBlobType);
            this.gbBlobType.Location = new System.Drawing.Point(141, 22);
            this.gbBlobType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBlobType.Name = "gbBlobType";
            this.gbBlobType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBlobType.Size = new System.Drawing.Size(71, 45);
            this.gbBlobType.TabIndex = 5;
            this.gbBlobType.TabStop = false;
            this.gbBlobType.Text = "Type";
            // 
            // cbBlobType
            // 
            this.cbBlobType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBlobType.FormattingEnabled = true;
            this.cbBlobType.Items.AddRange(new object[] {
            "TEXT",
            "BINARY"});
            this.cbBlobType.Location = new System.Drawing.Point(3, 20);
            this.cbBlobType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBlobType.Name = "cbBlobType";
            this.cbBlobType.Size = new System.Drawing.Size(65, 23);
            this.cbBlobType.TabIndex = 2;
            this.cbBlobType.Text = "TEXT";
            this.cbBlobType.SelectedIndexChanged += new System.EventHandler(this.cbBlobType_SelectedIndexChanged);
            // 
            // gbTextProperties
            // 
            this.gbTextProperties.Controls.Add(this.gbLength);
            this.gbTextProperties.Controls.Add(this.gbCharSet);
            this.gbTextProperties.Controls.Add(this.gbCollate);
            this.gbTextProperties.Location = new System.Drawing.Point(3, 132);
            this.gbTextProperties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTextProperties.Name = "gbTextProperties";
            this.gbTextProperties.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTextProperties.Size = new System.Drawing.Size(449, 77);
            this.gbTextProperties.TabIndex = 7;
            this.gbTextProperties.TabStop = false;
            this.gbTextProperties.Text = "Text Properties";
            // 
            // gbLength
            // 
            this.gbLength.Controls.Add(this.txtLength);
            this.gbLength.Location = new System.Drawing.Point(11, 22);
            this.gbLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLength.Name = "gbLength";
            this.gbLength.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLength.Size = new System.Drawing.Size(118, 45);
            this.gbLength.TabIndex = 4;
            this.gbLength.TabStop = false;
            this.gbLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLength.Location = new System.Drawing.Point(3, 20);
            this.txtLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(112, 23);
            this.txtLength.TabIndex = 0;
            this.txtLength.Text = "8";
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // gbCharSet
            // 
            this.gbCharSet.Controls.Add(this.cbCharSet);
            this.gbCharSet.Location = new System.Drawing.Point(132, 22);
            this.gbCharSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCharSet.Name = "gbCharSet";
            this.gbCharSet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCharSet.Size = new System.Drawing.Size(143, 45);
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
            this.cbCharSet.Location = new System.Drawing.Point(3, 20);
            this.cbCharSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(137, 23);
            this.cbCharSet.TabIndex = 2;
            this.cbCharSet.Text = "NONE";
            this.cbCharSet.SelectedIndexChanged += new System.EventHandler(this.cbCharSet_SelectedIndexChanged);
            // 
            // gbCollate
            // 
            this.gbCollate.Controls.Add(this.cbCollate);
            this.gbCollate.Location = new System.Drawing.Point(279, 22);
            this.gbCollate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCollate.Name = "gbCollate";
            this.gbCollate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCollate.Size = new System.Drawing.Size(155, 45);
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
            this.cbCollate.Location = new System.Drawing.Point(3, 20);
            this.cbCollate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCollate.Name = "cbCollate";
            this.cbCollate.Size = new System.Drawing.Size(149, 23);
            this.cbCollate.TabIndex = 2;
            this.cbCollate.Text = "NONE";
            this.cbCollate.SelectedIndexChanged += new System.EventHandler(this.cbCollate_SelectedIndexChanged);
            // 
            // gbPrecisionProperties
            // 
            this.gbPrecisionProperties.Controls.Add(this.gbPrecisionLength);
            this.gbPrecisionProperties.Controls.Add(this.gbScale);
            this.gbPrecisionProperties.Location = new System.Drawing.Point(6, 54);
            this.gbPrecisionProperties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPrecisionProperties.Name = "gbPrecisionProperties";
            this.gbPrecisionProperties.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPrecisionProperties.Size = new System.Drawing.Size(216, 77);
            this.gbPrecisionProperties.TabIndex = 8;
            this.gbPrecisionProperties.TabStop = false;
            this.gbPrecisionProperties.Text = "Numeric Properties";
            // 
            // gbPrecisionLength
            // 
            this.gbPrecisionLength.Controls.Add(this.txtPrecisionLength);
            this.gbPrecisionLength.Location = new System.Drawing.Point(11, 22);
            this.gbPrecisionLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPrecisionLength.Name = "gbPrecisionLength";
            this.gbPrecisionLength.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPrecisionLength.Size = new System.Drawing.Size(118, 45);
            this.gbPrecisionLength.TabIndex = 4;
            this.gbPrecisionLength.TabStop = false;
            this.gbPrecisionLength.Text = "Precision Length";
            // 
            // txtPrecisionLength
            // 
            this.txtPrecisionLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecisionLength.Location = new System.Drawing.Point(3, 20);
            this.txtPrecisionLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecisionLength.Name = "txtPrecisionLength";
            this.txtPrecisionLength.Size = new System.Drawing.Size(112, 23);
            this.txtPrecisionLength.TabIndex = 0;
            this.txtPrecisionLength.Text = "8";
            this.txtPrecisionLength.TextChanged += new System.EventHandler(this.txtPrecisionLength_TextChanged);
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.txtScale);
            this.gbScale.Location = new System.Drawing.Point(133, 22);
            this.gbScale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScale.Name = "gbScale";
            this.gbScale.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScale.Size = new System.Drawing.Size(70, 45);
            this.gbScale.TabIndex = 5;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "Scale";
            // 
            // txtScale
            // 
            this.txtScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScale.Location = new System.Drawing.Point(3, 20);
            this.txtScale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(64, 23);
            this.txtScale.TabIndex = 0;
            this.txtScale.Text = "3";
            this.txtScale.TextChanged += new System.EventHandler(this.txtScale_TextChanged);
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.cbFieldTypes);
            this.gbTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTypes.Location = new System.Drawing.Point(3, 3);
            this.gbTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTypes.Size = new System.Drawing.Size(558, 47);
            this.gbTypes.TabIndex = 3;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "FieldType";
            // 
            // cbFieldTypes
            // 
            this.cbFieldTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFieldTypes.FormattingEnabled = true;
            this.cbFieldTypes.Location = new System.Drawing.Point(3, 20);
            this.cbFieldTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFieldTypes.Name = "cbFieldTypes";
            this.cbFieldTypes.Size = new System.Drawing.Size(552, 23);
            this.cbFieldTypes.TabIndex = 1;
            this.cbFieldTypes.SelectedIndexChanged += new System.EventHandler(this.cbFieldTypes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hsToggleNotNull);
            this.groupBox2.Controls.Add(this.txtPK);
            this.groupBox2.Controls.Add(this.cbNotNull);
            this.groupBox2.Controls.Add(this.cbPrimaryKey);
            this.groupBox2.Location = new System.Drawing.Point(240, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(255, 72);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // txtPK
            // 
            this.txtPK.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPK.Location = new System.Drawing.Point(103, 20);
            this.txtPK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPK.Name = "txtPK";
            this.txtPK.Size = new System.Drawing.Size(149, 23);
            this.txtPK.TabIndex = 16;
            this.txtPK.Text = "NEW_FIELD";
            this.txtPK.TextChanged += new System.EventHandler(this.txtPK_TextChanged);
            // 
            // cbNotNull
            // 
            this.cbNotNull.AutoSize = true;
            this.cbNotNull.Location = new System.Drawing.Point(7, 41);
            this.cbNotNull.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNotNull.Name = "cbNotNull";
            this.cbNotNull.Size = new System.Drawing.Size(78, 19);
            this.cbNotNull.TabIndex = 14;
            this.cbNotNull.Text = "NOT NULL";
            this.cbNotNull.UseVisualStyleBackColor = true;
            this.cbNotNull.CheckedChanged += new System.EventHandler(this.cbNotNull_CheckedChanged);
            // 
            // cbPrimaryKey
            // 
            this.cbPrimaryKey.AutoSize = true;
            this.cbPrimaryKey.Location = new System.Drawing.Point(8, 17);
            this.cbPrimaryKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPrimaryKey.Name = "cbPrimaryKey";
            this.cbPrimaryKey.Size = new System.Drawing.Size(92, 19);
            this.cbPrimaryKey.TabIndex = 15;
            this.cbPrimaryKey.Text = "Primary Key";
            this.cbPrimaryKey.UseVisualStyleBackColor = true;
            this.cbPrimaryKey.CheckedChanged += new System.EventHandler(this.cbPrimaryKey_CheckedChanged);
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.txtPosition);
            this.gbPosition.Location = new System.Drawing.Point(502, 17);
            this.gbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPosition.Size = new System.Drawing.Size(75, 45);
            this.gbPosition.TabIndex = 21;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPosition.Location = new System.Drawing.Point(12, 20);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(60, 23);
            this.txtPosition.TabIndex = 0;
            this.txtPosition.Text = "1";
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // gbFieldName
            // 
            this.gbFieldName.Controls.Add(this.txtFieldName);
            this.gbFieldName.Location = new System.Drawing.Point(7, 19);
            this.gbFieldName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFieldName.Name = "gbFieldName";
            this.gbFieldName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFieldName.Size = new System.Drawing.Size(226, 52);
            this.gbFieldName.TabIndex = 0;
            this.gbFieldName.TabStop = false;
            this.gbFieldName.Text = "Field Name";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldName.Location = new System.Drawing.Point(3, 20);
            this.txtFieldName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(220, 23);
            this.txtFieldName.TabIndex = 0;
            this.txtFieldName.Text = "NEW_FIELD";
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsOrg);
            this.pnlFieldUpper.Controls.Add(this.hsNew);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 4);
            this.pnlFieldUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1506, 45);
            this.pnlFieldUpper.TabIndex = 1;
            // 
            // hsOrg
            // 
            this.hsOrg.BackColor = System.Drawing.Color.Transparent;
            this.hsOrg.BackColorHover = System.Drawing.Color.Transparent;
            this.hsOrg.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsOrg.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsOrg.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsOrg.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsOrg.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsOrg.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsOrg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsOrg.FlatAppearance.BorderSize = 0;
            this.hsOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsOrg.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsOrg.Image = global::FBXpert.Properties.Resources.edit_undo_blue_x22;
            this.hsOrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsOrg.ImageHover = global::FBXpert.Properties.Resources.edit_undo;
            this.hsOrg.ImageToggleOnSelect = true;
            this.hsOrg.Location = new System.Drawing.Point(64, 0);
            this.hsOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsOrg.Marked = false;
            this.hsOrg.MarkedColor = System.Drawing.Color.Teal;
            this.hsOrg.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsOrg.MarkedText = "";
            this.hsOrg.MarkMode = false;
            this.hsOrg.Name = "hsOrg";
            this.hsOrg.NonMarkedText = "New";
            this.hsOrg.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsOrg.ShowShortcut = false;
            this.hsOrg.Size = new System.Drawing.Size(64, 41);
            this.hsOrg.TabIndex = 6;
            this.hsOrg.Text = "Undo";
            this.hsOrg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsOrg.ToolTipActive = false;
            this.hsOrg.ToolTipAutomaticDelay = 500;
            this.hsOrg.ToolTipAutoPopDelay = 5000;
            this.hsOrg.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsOrg.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsOrg.ToolTipFor4ContextMenu = true;
            this.hsOrg.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsOrg.ToolTipInitialDelay = 500;
            this.hsOrg.ToolTipIsBallon = false;
            this.hsOrg.ToolTipOwnerDraw = false;
            this.hsOrg.ToolTipReshowDelay = 100;
            this.hsOrg.ToolTipShowAlways = false;
            this.hsOrg.ToolTipText = "";
            this.hsOrg.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsOrg.ToolTipTitle = "";
            this.hsOrg.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsOrg.UseVisualStyleBackColor = false;
            this.hsOrg.Click += new System.EventHandler(this.hsOrg_Click);
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
            this.hsNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsNew.Marked = false;
            this.hsNew.MarkedColor = System.Drawing.Color.Teal;
            this.hsNew.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNew.MarkedText = "";
            this.hsNew.MarkMode = false;
            this.hsNew.Name = "hsNew";
            this.hsNew.NonMarkedText = "New";
            this.hsNew.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsNew.ShowShortcut = false;
            this.hsNew.Size = new System.Drawing.Size(64, 41);
            this.hsNew.TabIndex = 5;
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
            this.tabPageMessages.Controls.Add(this.pnlMessageUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 24);
            this.tabPageMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMessages.Size = new System.Drawing.Size(1512, 797);
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
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(2, 14);
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
            this.fctMessages.Location = new System.Drawing.Point(3, 58);
            this.fctMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1506, 735);
            this.fctMessages.TabIndex = 25;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessageUpper
            // 
            this.pnlMessageUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessageUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessageUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessageUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlMessageUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessageUpper.Location = new System.Drawing.Point(3, 4);
            this.pnlMessageUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMessageUpper.Name = "pnlMessageUpper";
            this.pnlMessageUpper.Size = new System.Drawing.Size(1506, 54);
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
            this.hsClearMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearMessages.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearMessages.Image = global::FBXpert.Properties.Resources.seewp_bl24x;
            this.hsClearMessages.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClearMessages.ImageHover = global::FBXpert.Properties.Resources.seewp_ge22x;
            this.hsClearMessages.ImageToggleOnSelect = true;
            this.hsClearMessages.Location = new System.Drawing.Point(0, 0);
            this.hsClearMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsClearMessages.Marked = false;
            this.hsClearMessages.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearMessages.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearMessages.MarkedText = "";
            this.hsClearMessages.MarkMode = false;
            this.hsClearMessages.Name = "hsClearMessages";
            this.hsClearMessages.NonMarkedText = "Clear";
            this.hsClearMessages.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearMessages.ShowShortcut = false;
            this.hsClearMessages.Size = new System.Drawing.Size(53, 50);
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
            this.hsRefreshDependencies.Location = new System.Drawing.Point(1449, 0);
            this.hsRefreshDependencies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshDependencies.ShowShortcut = false;
            this.hsRefreshDependencies.Size = new System.Drawing.Size(53, 50);
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
            this.hsRefreshDependencies.Click += new System.EventHandler(this.hsRefreshDependencies_Click);
            // 
            // tabPageDependencies
            // 
            this.tabPageDependencies.Controls.Add(this.dgvDependenciesTo);
            this.tabPageDependencies.Controls.Add(this.pnlDependenciesUpper);
            this.tabPageDependencies.ImageIndex = 1;
            this.tabPageDependencies.Location = new System.Drawing.Point(4, 24);
            this.tabPageDependencies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDependencies.Name = "tabPageDependencies";
            this.tabPageDependencies.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDependencies.Size = new System.Drawing.Size(1512, 797);
            this.tabPageDependencies.TabIndex = 2;
            this.tabPageDependencies.Text = "Dependencies";
            this.tabPageDependencies.UseVisualStyleBackColor = true;
            // 
            // dgvDependenciesTo
            // 
            this.dgvDependenciesTo.AllowUserToAddRows = false;
            this.dgvDependenciesTo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            this.dgvDependenciesTo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDependenciesTo.AutoGenerateColumns = false;
            this.dgvDependenciesTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependenciesTo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependenciesTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependenciesTo.DataSource = this.bsDependencies;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependenciesTo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDependenciesTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependenciesTo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDependenciesTo.EnableHeadersVisualStyles = false;
            this.dgvDependenciesTo.Location = new System.Drawing.Point(3, 47);
            this.dgvDependenciesTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1506, 746);
            this.dgvDependenciesTo.TabIndex = 24;
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
            // pnlDependenciesUpper
            // 
            this.pnlDependenciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesUpper.Controls.Add(this.hotSpot1);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(3, 4);
            this.pnlDependenciesUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(1506, 43);
            this.pnlDependenciesUpper.TabIndex = 23;
            // 
            // hotSpot1
            // 
            this.hotSpot1.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot1.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot1.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot1.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot1.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(1453, 0);
            this.hotSpot1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(53, 43);
            this.hotSpot1.TabIndex = 2;
            this.hotSpot1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot1.ToolTipActive = false;
            this.hotSpot1.ToolTipAutomaticDelay = 500;
            this.hotSpot1.ToolTipAutoPopDelay = 5000;
            this.hotSpot1.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot1.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot1.ToolTipFor4ContextMenu = true;
            this.hotSpot1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot1.ToolTipInitialDelay = 500;
            this.hotSpot1.ToolTipIsBallon = false;
            this.hotSpot1.ToolTipOwnerDraw = false;
            this.hotSpot1.ToolTipReshowDelay = 100;
            this.hotSpot1.ToolTipShowAlways = false;
            this.hotSpot1.ToolTipText = "";
            this.hotSpot1.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot1.ToolTipTitle = "";
            this.hotSpot1.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot1.UseVisualStyleBackColor = false;
            this.hotSpot1.Click += new System.EventHandler(this.hotSpot1_Click);
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
            // hsToggleNotNull
            // 
            this.hsToggleNotNull.BackColor = System.Drawing.Color.Transparent;
            this.hsToggleNotNull.BackColorHover = System.Drawing.Color.Transparent;
            this.hsToggleNotNull.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsToggleNotNull.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsToggleNotNull.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsToggleNotNull.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsToggleNotNull.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsToggleNotNull.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsToggleNotNull.FlatAppearance.BorderSize = 0;
            this.hsToggleNotNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsToggleNotNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsToggleNotNull.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsToggleNotNull.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsToggleNotNull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsToggleNotNull.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsToggleNotNull.ImageToggleOnSelect = false;
            this.hsToggleNotNull.Location = new System.Drawing.Point(102, 43);
            this.hsToggleNotNull.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsToggleNotNull.Marked = false;
            this.hsToggleNotNull.MarkedColor = System.Drawing.Color.Teal;
            this.hsToggleNotNull.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsToggleNotNull.MarkedText = "";
            this.hsToggleNotNull.MarkMode = false;
            this.hsToggleNotNull.Name = "hsToggleNotNull";
            this.hsToggleNotNull.NonMarkedText = "Toggle";
            this.hsToggleNotNull.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsToggleNotNull.ShowShortcut = false;
            this.hsToggleNotNull.Size = new System.Drawing.Size(70, 29);
            this.hsToggleNotNull.TabIndex = 17;
            this.hsToggleNotNull.Text = "Toggle";
            this.hsToggleNotNull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsToggleNotNull.ToolTipActive = false;
            this.hsToggleNotNull.ToolTipAutomaticDelay = 500;
            this.hsToggleNotNull.ToolTipAutoPopDelay = 5000;
            this.hsToggleNotNull.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsToggleNotNull.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsToggleNotNull.ToolTipFor4ContextMenu = true;
            this.hsToggleNotNull.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsToggleNotNull.ToolTipInitialDelay = 500;
            this.hsToggleNotNull.ToolTipIsBallon = false;
            this.hsToggleNotNull.ToolTipOwnerDraw = false;
            this.hsToggleNotNull.ToolTipReshowDelay = 100;
            this.hsToggleNotNull.ToolTipShowAlways = false;
            this.hsToggleNotNull.ToolTipText = "";
            this.hsToggleNotNull.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsToggleNotNull.ToolTipTitle = "";
            this.hsToggleNotNull.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsToggleNotNull.UseVisualStyleBackColor = false;
            this.hsToggleNotNull.Click += new System.EventHandler(this.hsToggleNotNull_Click);
            // 
            // FieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 877);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FieldForm";
            this.Text = "FieldForm";
            this.Load += new System.EventHandler(this.FieldForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.gbSQLText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQLUpper.ResumeLayout(false);
            this.pnlEditFields.ResumeLayout(false);
            this.gbFieldDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctDescription)).EndInit();
            this.gbNULLDefault.ResumeLayout(false);
            this.gbNULLDefault.PerformLayout();
            this.gbDefault.ResumeLayout(false);
            this.gbDefault.PerformLayout();
            this.gbFieldTypes.ResumeLayout(false);
            this.tabControlFieldTypes.ResumeLayout(false);
            this.tabPageDomain.ResumeLayout(false);
            this.gbDomain.ResumeLayout(false);
            this.tabPageFieldType.ResumeLayout(false);
            this.gbBlobProperties.ResumeLayout(false);
            this.gbBlobSize.ResumeLayout(false);
            this.gbBlobSize.PerformLayout();
            this.gbBlobType.ResumeLayout(false);
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
            this.gbTypes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.gbFieldName.ResumeLayout(false);
            this.gbFieldName.PerformLayout();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessageUpper.ResumeLayout(false);
            this.tabPageDependencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.pnlDependenciesUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox gbFieldName;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.ComboBox cbFieldTypes;
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
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.BindingSource bsDependencies;
        private System.Data.DataSet dsDependencies;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Panel pnlMessageUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private SeControlsLib.HotSpot hsClearMessages;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.GroupBox gbDomain;
        private SeControlsLib.HotSpot hsEditDomain;
        private System.Windows.Forms.TabPage tabPageDependencies;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.DataGridView dgvDependenciesTo;
        private System.Windows.Forms.GroupBox gbDefault;
        private SeControlsLib.HotSpot hsSelectDefault;
        private System.Windows.Forms.TextBox txtDefault;
        private System.Windows.Forms.ComboBox cbDOMAIN;
        private SeControlsLib.HotSpot hsNewDomain;
        private System.Windows.Forms.GroupBox gbFieldTypes;
        private System.Windows.Forms.Panel pnlEditFields;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsNew;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.GroupBox gbBlobProperties;
        private System.Windows.Forms.GroupBox gbBlobSize;
        private System.Windows.Forms.GroupBox gbBlobType;
        private System.Windows.Forms.TextBox txtBlobSize;
        private System.Windows.Forms.ComboBox cbBlobType;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private SeControlsLib.HotSpot hsOrg;
        private System.Windows.Forms.TextBox txtPK;
        private System.Windows.Forms.GroupBox gbNULLDefault;
        private System.Windows.Forms.TextBox txtNULLDefault;
        private SeControlsLib.HotSpot hsGetNullDatasDefaults;
        private System.Windows.Forms.TabControl tabControlFieldTypes;
        private System.Windows.Forms.TabPage tabPageDomain;
        private System.Windows.Forms.TabPage tabPageFieldType;
        private SeControlsLib.HotSpot hsToggleNotNull;
    }
}