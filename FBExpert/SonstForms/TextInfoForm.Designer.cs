namespace FBXpert
{
    partial class TextInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInfoForm));
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.fctInfo = new FastColoredTextBoxNS.FastColoredTextBox();
            this.flpFormUpper = new System.Windows.Forms.FlowLayoutPanel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsFindPattern = new SeControlsLib.HotSpot();
            this.gbSearchPattern = new System.Windows.Forms.GroupBox();
            this.txtSearchPattern = new System.Windows.Forms.TextBox();
            this.gbNavigate = new System.Windows.Forms.GroupBox();
            this.hsSearchLast = new SeControlsLib.HotSpot();
            this.hsFindNext = new SeControlsLib.HotSpot();
            this.label1 = new System.Windows.Forms.Label();
            this.hsPrev = new SeControlsLib.HotSpot();
            this.hsSearchNextFromStart = new SeControlsLib.HotSpot();
            this.gbSearchAttributes = new System.Windows.Forms.GroupBox();
            this.ckWholeWords = new System.Windows.Forms.CheckBox();
            this.ckCaseSensitive = new System.Windows.Forms.CheckBox();
            this.hsSaveText = new SeControlsLib.HotSpot();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctInfo)).BeginInit();
            this.flpFormUpper.SuspendLayout();
            this.gbSearchPattern.SuspendLayout();
            this.gbNavigate.SuspendLayout();
            this.gbSearchAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 723);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(1248, 19);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.fctInfo);
            this.pnlCenter.Controls.Add(this.flpFormUpper);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1248, 723);
            this.pnlCenter.TabIndex = 2;
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
            this.fctInfo.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);";
            this.fctInfo.AutoScrollMinSize = new System.Drawing.Size(25, 13);
            this.fctInfo.BackBrush = null;
            this.fctInfo.CharHeight = 13;
            this.fctInfo.CharWidth = 7;
            this.fctInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctInfo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctInfo.Font = new System.Drawing.Font("Courier New", 9F);
            this.fctInfo.IsReplaceMode = false;
            this.fctInfo.Location = new System.Drawing.Point(0, 56);
            this.fctInfo.Name = "fctInfo";
            this.fctInfo.Paddings = new System.Windows.Forms.Padding(0);
            this.fctInfo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctInfo.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctInfo.ServiceColors")));
            this.fctInfo.Size = new System.Drawing.Size(1248, 667);
            this.fctInfo.TabIndex = 0;
            this.fctInfo.Zoom = 100;
            // 
            // flpFormUpper
            // 
            this.flpFormUpper.Controls.Add(this.hsClose);
            this.flpFormUpper.Controls.Add(this.hsFindPattern);
            this.flpFormUpper.Controls.Add(this.gbSearchPattern);
            this.flpFormUpper.Controls.Add(this.gbNavigate);
            this.flpFormUpper.Controls.Add(this.gbSearchAttributes);
            this.flpFormUpper.Controls.Add(this.hsSaveText);
            this.flpFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFormUpper.Location = new System.Drawing.Point(0, 0);
            this.flpFormUpper.Name = "flpFormUpper";
            this.flpFormUpper.Size = new System.Drawing.Size(1248, 56);
            this.flpFormUpper.TabIndex = 1;
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
            this.hsClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClose.FlatAppearance.BorderSize = 0;
            this.hsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClose.Image = global::FBXpert.Properties.Resources.go_previous32x;
            this.hsClose.ImageHover = global::FBXpert.Properties.Resources.go_left_blue32x;
            this.hsClose.ImageToggleOnSelect = true;
            this.hsClose.Location = new System.Drawing.Point(3, 3);
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
            this.hsClose.Size = new System.Drawing.Size(45, 46);
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
            // hsFindPattern
            // 
            this.hsFindPattern.BackColor = System.Drawing.Color.Transparent;
            this.hsFindPattern.BackColorHover = System.Drawing.Color.Transparent;
            this.hsFindPattern.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsFindPattern.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsFindPattern.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsFindPattern.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsFindPattern.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsFindPattern.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsFindPattern.FlatAppearance.BorderSize = 0;
            this.hsFindPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsFindPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsFindPattern.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsFindPattern.Image = global::FBXpert.Properties.Resources.lupe24x;
            this.hsFindPattern.ImageHover = global::FBXpert.Properties.Resources.lupe2_24x;
            this.hsFindPattern.ImageToggleOnSelect = true;
            this.hsFindPattern.Location = new System.Drawing.Point(54, 3);
            this.hsFindPattern.Marked = false;
            this.hsFindPattern.MarkedColor = System.Drawing.Color.Teal;
            this.hsFindPattern.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsFindPattern.MarkedText = "";
            this.hsFindPattern.MarkMode = false;
            this.hsFindPattern.Name = "hsFindPattern";
            this.hsFindPattern.NonMarkedText = "";
            this.hsFindPattern.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsFindPattern.ShortcutNewline = false;
            this.hsFindPattern.ShowShortcut = false;
            this.hsFindPattern.Size = new System.Drawing.Size(45, 46);
            this.hsFindPattern.TabIndex = 3;
            this.hsFindPattern.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsFindPattern.ToolTipActive = false;
            this.hsFindPattern.ToolTipAutomaticDelay = 500;
            this.hsFindPattern.ToolTipAutoPopDelay = 5000;
            this.hsFindPattern.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsFindPattern.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsFindPattern.ToolTipFor4ContextMenu = true;
            this.hsFindPattern.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsFindPattern.ToolTipInitialDelay = 500;
            this.hsFindPattern.ToolTipIsBallon = false;
            this.hsFindPattern.ToolTipOwnerDraw = false;
            this.hsFindPattern.ToolTipReshowDelay = 100;
            this.hsFindPattern.ToolTipShowAlways = false;
            this.hsFindPattern.ToolTipText = "";
            this.hsFindPattern.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsFindPattern.ToolTipTitle = "";
            this.hsFindPattern.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsFindPattern.UseVisualStyleBackColor = false;
            this.hsFindPattern.Click += new System.EventHandler(this.hsFindPattern_Click);
            // 
            // gbSearchPattern
            // 
            this.gbSearchPattern.Controls.Add(this.txtSearchPattern);
            this.gbSearchPattern.Location = new System.Drawing.Point(105, 3);
            this.gbSearchPattern.Name = "gbSearchPattern";
            this.gbSearchPattern.Size = new System.Drawing.Size(200, 46);
            this.gbSearchPattern.TabIndex = 4;
            this.gbSearchPattern.TabStop = false;
            this.gbSearchPattern.Text = "Searchpattern";
            // 
            // txtSearchPattern
            // 
            this.txtSearchPattern.Location = new System.Drawing.Point(6, 19);
            this.txtSearchPattern.Name = "txtSearchPattern";
            this.txtSearchPattern.Size = new System.Drawing.Size(188, 20);
            this.txtSearchPattern.TabIndex = 0;
            this.txtSearchPattern.TextChanged += new System.EventHandler(this.txtSearchPattern_TextChanged);
            this.txtSearchPattern.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchPattern_KeyUp);
            // 
            // gbNavigate
            // 
            this.gbNavigate.Controls.Add(this.hsSearchLast);
            this.gbNavigate.Controls.Add(this.hsFindNext);
            this.gbNavigate.Controls.Add(this.label1);
            this.gbNavigate.Controls.Add(this.hsPrev);
            this.gbNavigate.Controls.Add(this.hsSearchNextFromStart);
            this.gbNavigate.Location = new System.Drawing.Point(311, 3);
            this.gbNavigate.Name = "gbNavigate";
            this.gbNavigate.Size = new System.Drawing.Size(245, 47);
            this.gbNavigate.TabIndex = 11;
            this.gbNavigate.TabStop = false;
            this.gbNavigate.Text = "Navigate";
            // 
            // hsSearchLast
            // 
            this.hsSearchLast.BackColor = System.Drawing.Color.Transparent;
            this.hsSearchLast.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSearchLast.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSearchLast.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSearchLast.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSearchLast.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSearchLast.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSearchLast.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSearchLast.FlatAppearance.BorderSize = 0;
            this.hsSearchLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSearchLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSearchLast.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSearchLast.Image = global::FBXpert.Properties.Resources.go_last_green24x;
            this.hsSearchLast.ImageHover = global::FBXpert.Properties.Resources.go_last_blue24x;
            this.hsSearchLast.ImageToggleOnSelect = true;
            this.hsSearchLast.Location = new System.Drawing.Point(194, 17);
            this.hsSearchLast.Marked = false;
            this.hsSearchLast.MarkedColor = System.Drawing.Color.Teal;
            this.hsSearchLast.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSearchLast.MarkedText = "";
            this.hsSearchLast.MarkMode = false;
            this.hsSearchLast.Name = "hsSearchLast";
            this.hsSearchLast.NonMarkedText = "";
            this.hsSearchLast.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSearchLast.ShortcutNewline = false;
            this.hsSearchLast.ShowShortcut = false;
            this.hsSearchLast.Size = new System.Drawing.Size(37, 24);
            this.hsSearchLast.TabIndex = 9;
            this.hsSearchLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSearchLast.ToolTipActive = false;
            this.hsSearchLast.ToolTipAutomaticDelay = 500;
            this.hsSearchLast.ToolTipAutoPopDelay = 5000;
            this.hsSearchLast.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSearchLast.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSearchLast.ToolTipFor4ContextMenu = true;
            this.hsSearchLast.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSearchLast.ToolTipInitialDelay = 500;
            this.hsSearchLast.ToolTipIsBallon = false;
            this.hsSearchLast.ToolTipOwnerDraw = false;
            this.hsSearchLast.ToolTipReshowDelay = 100;
            this.hsSearchLast.ToolTipShowAlways = false;
            this.hsSearchLast.ToolTipText = "";
            this.hsSearchLast.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSearchLast.ToolTipTitle = "";
            this.hsSearchLast.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSearchLast.UseVisualStyleBackColor = false;
            this.hsSearchLast.Click += new System.EventHandler(this.hsSearchLast_Click);
            // 
            // hsFindNext
            // 
            this.hsFindNext.BackColor = System.Drawing.Color.Transparent;
            this.hsFindNext.BackColorHover = System.Drawing.Color.Transparent;
            this.hsFindNext.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsFindNext.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsFindNext.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsFindNext.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsFindNext.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsFindNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsFindNext.FlatAppearance.BorderSize = 0;
            this.hsFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsFindNext.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsFindNext.Image = global::FBXpert.Properties.Resources.go_next24x;
            this.hsFindNext.ImageHover = global::FBXpert.Properties.Resources.go_next_blue24x;
            this.hsFindNext.ImageToggleOnSelect = true;
            this.hsFindNext.Location = new System.Drawing.Point(150, 17);
            this.hsFindNext.Marked = false;
            this.hsFindNext.MarkedColor = System.Drawing.Color.Teal;
            this.hsFindNext.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsFindNext.MarkedText = "";
            this.hsFindNext.MarkMode = false;
            this.hsFindNext.Name = "hsFindNext";
            this.hsFindNext.NonMarkedText = "";
            this.hsFindNext.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsFindNext.ShortcutNewline = false;
            this.hsFindNext.ShowShortcut = false;
            this.hsFindNext.Size = new System.Drawing.Size(38, 24);
            this.hsFindNext.TabIndex = 5;
            this.hsFindNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsFindNext.ToolTipActive = false;
            this.hsFindNext.ToolTipAutomaticDelay = 500;
            this.hsFindNext.ToolTipAutoPopDelay = 5000;
            this.hsFindNext.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsFindNext.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsFindNext.ToolTipFor4ContextMenu = true;
            this.hsFindNext.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsFindNext.ToolTipInitialDelay = 500;
            this.hsFindNext.ToolTipIsBallon = false;
            this.hsFindNext.ToolTipOwnerDraw = false;
            this.hsFindNext.ToolTipReshowDelay = 100;
            this.hsFindNext.ToolTipShowAlways = false;
            this.hsFindNext.ToolTipText = "";
            this.hsFindNext.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsFindNext.ToolTipTitle = "";
            this.hsFindNext.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsFindNext.UseVisualStyleBackColor = false;
            this.hsFindNext.Click += new System.EventHandler(this.hsFindNext_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hsPrev
            // 
            this.hsPrev.BackColor = System.Drawing.Color.Transparent;
            this.hsPrev.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPrev.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPrev.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPrev.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPrev.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPrev.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPrev.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsPrev.FlatAppearance.BorderSize = 0;
            this.hsPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPrev.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPrev.Image = global::FBXpert.Properties.Resources.go_previous22x;
            this.hsPrev.ImageHover = global::FBXpert.Properties.Resources.go_left_blue22x;
            this.hsPrev.ImageToggleOnSelect = true;
            this.hsPrev.Location = new System.Drawing.Point(47, 17);
            this.hsPrev.Marked = false;
            this.hsPrev.MarkedColor = System.Drawing.Color.Teal;
            this.hsPrev.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPrev.MarkedText = "";
            this.hsPrev.MarkMode = false;
            this.hsPrev.Name = "hsPrev";
            this.hsPrev.NonMarkedText = "";
            this.hsPrev.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsPrev.ShortcutNewline = false;
            this.hsPrev.ShowShortcut = false;
            this.hsPrev.Size = new System.Drawing.Size(38, 24);
            this.hsPrev.TabIndex = 6;
            this.hsPrev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPrev.ToolTipActive = false;
            this.hsPrev.ToolTipAutomaticDelay = 500;
            this.hsPrev.ToolTipAutoPopDelay = 5000;
            this.hsPrev.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPrev.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPrev.ToolTipFor4ContextMenu = true;
            this.hsPrev.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPrev.ToolTipInitialDelay = 500;
            this.hsPrev.ToolTipIsBallon = false;
            this.hsPrev.ToolTipOwnerDraw = false;
            this.hsPrev.ToolTipReshowDelay = 100;
            this.hsPrev.ToolTipShowAlways = false;
            this.hsPrev.ToolTipText = "";
            this.hsPrev.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPrev.ToolTipTitle = "";
            this.hsPrev.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPrev.UseVisualStyleBackColor = false;
            this.hsPrev.Click += new System.EventHandler(this.hsPrev_Click);
            // 
            // hsSearchNextFromStart
            // 
            this.hsSearchNextFromStart.BackColor = System.Drawing.Color.Transparent;
            this.hsSearchNextFromStart.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSearchNextFromStart.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSearchNextFromStart.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSearchNextFromStart.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSearchNextFromStart.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSearchNextFromStart.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSearchNextFromStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSearchNextFromStart.FlatAppearance.BorderSize = 0;
            this.hsSearchNextFromStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSearchNextFromStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSearchNextFromStart.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSearchNextFromStart.Image = global::FBXpert.Properties.Resources.go_first_green24x;
            this.hsSearchNextFromStart.ImageHover = global::FBXpert.Properties.Resources.go_first_blue24x;
            this.hsSearchNextFromStart.ImageToggleOnSelect = true;
            this.hsSearchNextFromStart.Location = new System.Drawing.Point(7, 17);
            this.hsSearchNextFromStart.Marked = false;
            this.hsSearchNextFromStart.MarkedColor = System.Drawing.Color.Teal;
            this.hsSearchNextFromStart.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSearchNextFromStart.MarkedText = "";
            this.hsSearchNextFromStart.MarkMode = false;
            this.hsSearchNextFromStart.Name = "hsSearchNextFromStart";
            this.hsSearchNextFromStart.NonMarkedText = "";
            this.hsSearchNextFromStart.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSearchNextFromStart.ShortcutNewline = false;
            this.hsSearchNextFromStart.ShowShortcut = false;
            this.hsSearchNextFromStart.Size = new System.Drawing.Size(38, 24);
            this.hsSearchNextFromStart.TabIndex = 8;
            this.hsSearchNextFromStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSearchNextFromStart.ToolTipActive = false;
            this.hsSearchNextFromStart.ToolTipAutomaticDelay = 500;
            this.hsSearchNextFromStart.ToolTipAutoPopDelay = 5000;
            this.hsSearchNextFromStart.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSearchNextFromStart.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSearchNextFromStart.ToolTipFor4ContextMenu = true;
            this.hsSearchNextFromStart.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSearchNextFromStart.ToolTipInitialDelay = 500;
            this.hsSearchNextFromStart.ToolTipIsBallon = false;
            this.hsSearchNextFromStart.ToolTipOwnerDraw = false;
            this.hsSearchNextFromStart.ToolTipReshowDelay = 100;
            this.hsSearchNextFromStart.ToolTipShowAlways = false;
            this.hsSearchNextFromStart.ToolTipText = "";
            this.hsSearchNextFromStart.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSearchNextFromStart.ToolTipTitle = "";
            this.hsSearchNextFromStart.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSearchNextFromStart.UseVisualStyleBackColor = false;
            this.hsSearchNextFromStart.Click += new System.EventHandler(this.hsSearchNextFromStart_Click);
            // 
            // gbSearchAttributes
            // 
            this.gbSearchAttributes.Controls.Add(this.ckWholeWords);
            this.gbSearchAttributes.Controls.Add(this.ckCaseSensitive);
            this.gbSearchAttributes.Location = new System.Drawing.Point(562, 3);
            this.gbSearchAttributes.Name = "gbSearchAttributes";
            this.gbSearchAttributes.Size = new System.Drawing.Size(215, 46);
            this.gbSearchAttributes.TabIndex = 7;
            this.gbSearchAttributes.TabStop = false;
            this.gbSearchAttributes.Text = "Search Attributes";
            // 
            // ckWholeWords
            // 
            this.ckWholeWords.AutoSize = true;
            this.ckWholeWords.Location = new System.Drawing.Point(116, 22);
            this.ckWholeWords.Name = "ckWholeWords";
            this.ckWholeWords.Size = new System.Drawing.Size(88, 17);
            this.ckWholeWords.TabIndex = 1;
            this.ckWholeWords.Text = "Whole words";
            this.ckWholeWords.UseVisualStyleBackColor = true;
            this.ckWholeWords.CheckedChanged += new System.EventHandler(this.ckWholeWords_CheckedChanged);
            // 
            // ckCaseSensitive
            // 
            this.ckCaseSensitive.AutoSize = true;
            this.ckCaseSensitive.Location = new System.Drawing.Point(6, 22);
            this.ckCaseSensitive.Name = "ckCaseSensitive";
            this.ckCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.ckCaseSensitive.TabIndex = 0;
            this.ckCaseSensitive.Text = "Case sensitive";
            this.ckCaseSensitive.UseVisualStyleBackColor = true;
            this.ckCaseSensitive.CheckedChanged += new System.EventHandler(this.ckCaseSensitive_CheckedChanged);
            // 
            // hsSaveText
            // 
            this.hsSaveText.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveText.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveText.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveText.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveText.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveText.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveText.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveText.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveText.FlatAppearance.BorderSize = 0;
            this.hsSaveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveText.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveText.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hsSaveText.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hsSaveText.ImageToggleOnSelect = true;
            this.hsSaveText.Location = new System.Drawing.Point(783, 3);
            this.hsSaveText.Marked = false;
            this.hsSaveText.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveText.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveText.MarkedText = "";
            this.hsSaveText.MarkMode = false;
            this.hsSaveText.Name = "hsSaveText";
            this.hsSaveText.NonMarkedText = "";
            this.hsSaveText.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveText.ShortcutNewline = false;
            this.hsSaveText.ShowShortcut = false;
            this.hsSaveText.Size = new System.Drawing.Size(45, 46);
            this.hsSaveText.TabIndex = 10;
            this.hsSaveText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveText.ToolTipActive = false;
            this.hsSaveText.ToolTipAutomaticDelay = 500;
            this.hsSaveText.ToolTipAutoPopDelay = 5000;
            this.hsSaveText.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveText.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveText.ToolTipFor4ContextMenu = true;
            this.hsSaveText.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveText.ToolTipInitialDelay = 500;
            this.hsSaveText.ToolTipIsBallon = false;
            this.hsSaveText.ToolTipOwnerDraw = false;
            this.hsSaveText.ToolTipReshowDelay = 100;
            this.hsSaveText.ToolTipShowAlways = false;
            this.hsSaveText.ToolTipText = "";
            this.hsSaveText.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveText.ToolTipTitle = "";
            this.hsSaveText.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveText.UseVisualStyleBackColor = false;
            this.hsSaveText.Click += new System.EventHandler(this.hsSaveText_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sql";
            this.saveFileDialog1.Filter = "*.sql|SQL|*.txt|TXT|*.*|All";
            // 
            // TextInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 742);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextInfoForm";
            this.Text = "TextInfoForm";
            this.Load += new System.EventHandler(this.TextInfoForm_Load);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctInfo)).EndInit();
            this.flpFormUpper.ResumeLayout(false);
            this.gbSearchPattern.ResumeLayout(false);
            this.gbSearchPattern.PerformLayout();
            this.gbNavigate.ResumeLayout(false);
            this.gbSearchAttributes.ResumeLayout(false);
            this.gbSearchAttributes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private FastColoredTextBoxNS.FastColoredTextBox fctInfo;
        private SeControlsLib.HotSpot hsFindPattern;
        private System.Windows.Forms.FlowLayoutPanel flpFormUpper;
        private System.Windows.Forms.GroupBox gbSearchPattern;
        private System.Windows.Forms.TextBox txtSearchPattern;
        private SeControlsLib.HotSpot hsFindNext;
        private SeControlsLib.HotSpot hsPrev;
        private System.Windows.Forms.GroupBox gbSearchAttributes;
        private System.Windows.Forms.CheckBox ckCaseSensitive;
        private SeControlsLib.HotSpot hsSearchNextFromStart;
        private SeControlsLib.HotSpot hsSearchLast;
        private SeControlsLib.HotSpot hsSaveText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox ckWholeWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNavigate;
    }
}