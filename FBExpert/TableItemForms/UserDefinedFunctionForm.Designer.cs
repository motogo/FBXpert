using BasicForms;

namespace FBXpert
{
    partial class UserDefinedFunctionForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDefinedFunctionForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQL_UPPER = new System.Windows.Forms.Panel();
            this.gbUsedMilliseconds = new System.Windows.Forms.GroupBox();
            this.lblUsedMs = new System.Windows.Forms.Label();
            this.hsLoadSQL = new SeControlsLib.HotSpot();
            this.hsSaveSQL = new SeControlsLib.HotSpot();
            this.hsRunStatement = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.cmsParameters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddInputParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddOutputParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDropParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.bsDependenciesTo = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependenciesTo = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.dsDependenciesFrom = new System.Data.DataSet();
            this.dataTable6 = new System.Data.DataTable();
            this.bsDependenciesFrom = new System.Windows.Forms.BindingSource(this.components);
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.saveSQLFile = new System.Windows.Forms.SaveFileDialog();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hsClearMessages = new SeControlsLib.HotSpot();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.gbSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.pnlSQL_UPPER.SuspendLayout();
            this.gbUsedMilliseconds.SuspendLayout();
            this.cmsParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).BeginInit();
            this.tabPageMessages.SuspendLayout();
            this.pnlMessagesUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblCaption);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1229, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(71, 10);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(182, 20);
            this.lblCaption.TabIndex = 4;
            this.lblCaption.Text = "User defined function";
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
            this.pnlCenter.Size = new System.Drawing.Size(1229, 674);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPageFieldEdit);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.ImageList = this.ilTabControl;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1229, 674);
            this.tabControlFields.TabIndex = 18;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.ImageIndex = 8;
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 23);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(1221, 647);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.splitContainer1);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1215, 641);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1215, 641);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabPageMessages);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ilTabControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 637);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.gbSQL);
            this.tabPageSQL.Controls.Add(this.pnlSQL_UPPER);
            this.tabPageSQL.ImageIndex = 5;
            this.tabPageSQL.Location = new System.Drawing.Point(4, 23);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(1159, 610);
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
            this.gbSQL.Size = new System.Drawing.Size(1153, 564);
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
            this.fctSQL.ReadOnly = true;
            this.fctSQL.RightBracket = ')';
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(1147, 545);
            this.fctSQL.TabIndex = 0;
            this.fctSQL.Zoom = 100;
            this.fctSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctSQL_KeyDown);
            // 
            // pnlSQL_UPPER
            // 
            this.pnlSQL_UPPER.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSQL_UPPER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQL_UPPER.Controls.Add(this.gbUsedMilliseconds);
            this.pnlSQL_UPPER.Controls.Add(this.hsLoadSQL);
            this.pnlSQL_UPPER.Controls.Add(this.hsSaveSQL);
            this.pnlSQL_UPPER.Controls.Add(this.hsRunStatement);
            this.pnlSQL_UPPER.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQL_UPPER.Location = new System.Drawing.Point(3, 3);
            this.pnlSQL_UPPER.Name = "pnlSQL_UPPER";
            this.pnlSQL_UPPER.Size = new System.Drawing.Size(1153, 40);
            this.pnlSQL_UPPER.TabIndex = 10;
            // 
            // gbUsedMilliseconds
            // 
            this.gbUsedMilliseconds.Controls.Add(this.lblUsedMs);
            this.gbUsedMilliseconds.Location = new System.Drawing.Point(361, 3);
            this.gbUsedMilliseconds.Name = "gbUsedMilliseconds";
            this.gbUsedMilliseconds.Size = new System.Drawing.Size(126, 31);
            this.gbUsedMilliseconds.TabIndex = 32;
            this.gbUsedMilliseconds.TabStop = false;
            this.gbUsedMilliseconds.Text = "Costs in milliseconds";
            // 
            // lblUsedMs
            // 
            this.lblUsedMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsedMs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedMs.Location = new System.Drawing.Point(3, 16);
            this.lblUsedMs.Name = "lblUsedMs";
            this.lblUsedMs.Size = new System.Drawing.Size(120, 12);
            this.lblUsedMs.TabIndex = 0;
            this.lblUsedMs.Text = "0";
            this.lblUsedMs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.hsLoadSQL.Marked = false;
            this.hsLoadSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQL.MarkedText = "";
            this.hsLoadSQL.MarkMode = false;
            this.hsLoadSQL.Name = "hsLoadSQL";
            this.hsLoadSQL.NonMarkedText = "Load SQL";
            this.hsLoadSQL.Size = new System.Drawing.Size(124, 36);
            this.hsLoadSQL.TabIndex = 8;
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
            this.hsSaveSQL.Location = new System.Drawing.Point(90, 0);
            this.hsSaveSQL.Marked = false;
            this.hsSaveSQL.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveSQL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveSQL.MarkedText = "";
            this.hsSaveSQL.MarkMode = false;
            this.hsSaveSQL.Name = "hsSaveSQL";
            this.hsSaveSQL.NonMarkedText = "Save SQL";
            this.hsSaveSQL.Size = new System.Drawing.Size(120, 36);
            this.hsSaveSQL.TabIndex = 7;
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
            // 
            // hsRunStatement
            // 
            this.hsRunStatement.BackColor = System.Drawing.Color.Transparent;
            this.hsRunStatement.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunStatement.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunStatement.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunStatement.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunStatement.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunStatement.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunStatement.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRunStatement.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRunStatement.FlatAppearance.BorderSize = 0;
            this.hsRunStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunStatement.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunStatement.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsRunStatement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunStatement.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsRunStatement.ImageToggleOnSelect = true;
            this.hsRunStatement.Location = new System.Drawing.Point(0, 0);
            this.hsRunStatement.Marked = false;
            this.hsRunStatement.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunStatement.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunStatement.MarkedText = "";
            this.hsRunStatement.MarkMode = false;
            this.hsRunStatement.Name = "hsRunStatement";
            this.hsRunStatement.NonMarkedText = "Execute";
            this.hsRunStatement.Size = new System.Drawing.Size(90, 36);
            this.hsRunStatement.TabIndex = 6;
            this.hsRunStatement.Text = "Execute";
            this.hsRunStatement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunStatement.ToolTipActive = false;
            this.hsRunStatement.ToolTipAutomaticDelay = 500;
            this.hsRunStatement.ToolTipAutoPopDelay = 5000;
            this.hsRunStatement.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunStatement.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunStatement.ToolTipFor4ContextMenu = true;
            this.hsRunStatement.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunStatement.ToolTipInitialDelay = 500;
            this.hsRunStatement.ToolTipIsBallon = false;
            this.hsRunStatement.ToolTipOwnerDraw = false;
            this.hsRunStatement.ToolTipReshowDelay = 100;
            this.hsRunStatement.ToolTipShowAlways = false;
            this.hsRunStatement.ToolTipText = "";
            this.hsRunStatement.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunStatement.ToolTipTitle = "";
            this.hsRunStatement.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunStatement.UseVisualStyleBackColor = false;
            this.hsRunStatement.Click += new System.EventHandler(this.hsRunStatement_Click);
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
            // cmsParameters
            // 
            this.cmsParameters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddInputParameter,
            this.tsmiAddOutputParameter,
            this.toolStripSeparator1,
            this.tsmiDropParameter});
            this.cmsParameters.Name = "contextMenuStrip1";
            this.cmsParameters.Size = new System.Drawing.Size(193, 76);
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
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.Controls.Add(this.fctMessages);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1159, 610);
            this.tabPageMessages.TabIndex = 1;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hsClearMessages);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1153, 40);
            this.pnlMessagesUpper.TabIndex = 6;
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
            this.hsClearMessages.Size = new System.Drawing.Size(100, 36);
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
            this.fctMessages.Location = new System.Drawing.Point(3, 3);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.ReadOnly = true;
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctMessages.ServiceColors")));
            this.fctMessages.Size = new System.Drawing.Size(1153, 604);
            this.fctMessages.TabIndex = 5;
            this.fctMessages.WordWrap = true;
            this.fctMessages.Zoom = 100;
            // 
            // UserDefinedFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 716);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDefinedFunctionForm";
            this.Text = "UserDefinedFunctionForm";
            this.Load += new System.EventHandler(this.UserDefinedFunctionForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.pnlSQL_UPPER.ResumeLayout(false);
            this.gbUsedMilliseconds.ResumeLayout(false);
            this.cmsParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).EndInit();
            this.tabPageMessages.ResumeLayout(false);
            this.pnlMessagesUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.BindingSource bsDependenciesTo;
        private System.Data.DataSet dsDependenciesTo;
        private System.Data.DataTable dataTable5;
        private System.Data.DataSet dsDependenciesFrom;
        private System.Data.DataTable dataTable6;
        private System.Windows.Forms.BindingSource bsDependenciesFrom;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.ContextMenuStrip cmsParameters;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddInputParameter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddOutputParameter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDropParameter;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
        private System.Windows.Forms.SaveFileDialog saveSQLFile;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.GroupBox gbSQL;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
        private System.Windows.Forms.Panel pnlSQL_UPPER;
        private System.Windows.Forms.GroupBox gbUsedMilliseconds;
        private System.Windows.Forms.Label lblUsedMs;
        private SeControlsLib.HotSpot hsLoadSQL;
        private SeControlsLib.HotSpot hsSaveSQL;
        private SeControlsLib.HotSpot hsRunStatement;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hsClearMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
    }
}