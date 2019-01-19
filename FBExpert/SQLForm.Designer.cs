using BasicForms;

namespace FBXpert
{
    partial class SQLForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.pnlCenter1 = new System.Windows.Forms.Panel();
            this.fcbSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlUpper1 = new System.Windows.Forms.Panel();
            this.hsExecuteDB = new SeControlsLib.HotSpot();
            this.hsLoadScript = new SeControlsLib.HotSpot();
            this.hotSpot3 = new SeControlsLib.HotSpot();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.tabPageDependencies = new System.Windows.Forms.TabPage();
            this.pnlCenter2 = new System.Windows.Forms.Panel();
            this.pnlUpper2 = new System.Windows.Forms.Panel();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.ofdSQL = new System.Windows.Forms.OpenFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlSQL.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.pnlCenter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbSQL)).BeginInit();
            this.pnlUpper1.SuspendLayout();
            this.tabPageDependencies.SuspendLayout();
            this.pnlUpper2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(935, 42);
            this.pnlUpper.TabIndex = 0;
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
            this.hsClose.Reserved = false;
            this.hsClose.Size = new System.Drawing.Size(45, 38);
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
            this.hsClose.ToolTipShow = true;
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
            this.pnlLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 372);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(935, 16);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCenter.Controls.Add(this.tabControlSQL);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(935, 330);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageSQL);
            this.tabControlSQL.Controls.Add(this.tabPageDependencies);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(931, 326);
            this.tabControlSQL.TabIndex = 18;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.pnlCenter1);
            this.tabPageSQL.Controls.Add(this.pnlUpper1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(923, 300);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // pnlCenter1
            // 
            this.pnlCenter1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCenter1.Controls.Add(this.fcbSQL);
            this.pnlCenter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter1.Location = new System.Drawing.Point(3, 35);
            this.pnlCenter1.Name = "pnlCenter1";
            this.pnlCenter1.Size = new System.Drawing.Size(917, 262);
            this.pnlCenter1.TabIndex = 2;
            // 
            // fcbSQL
            // 
            this.fcbSQL.AutoCompleteBracketsList = new char[] {
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
            this.fcbSQL.AutoIndentCharsPatterns = "";
            this.fcbSQL.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fcbSQL.BackBrush = null;
            this.fcbSQL.CharHeight = 14;
            this.fcbSQL.CharWidth = 8;
            this.fcbSQL.CommentPrefix = "--";
            this.fcbSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbSQL.IsReplaceMode = false;
            this.fcbSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.fcbSQL.LeftBracket = '(';
            this.fcbSQL.Location = new System.Drawing.Point(0, 0);
            this.fcbSQL.Name = "fcbSQL";
            this.fcbSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbSQL.RightBracket = ')';
            this.fcbSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbSQL.ServiceColors")));
            this.fcbSQL.Size = new System.Drawing.Size(917, 262);
            this.fcbSQL.TabIndex = 0;
            this.fcbSQL.Zoom = 100;
            // 
            // pnlUpper1
            // 
            this.pnlUpper1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlUpper1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpper1.Controls.Add(this.hsExecuteDB);
            this.pnlUpper1.Controls.Add(this.hsLoadScript);
            this.pnlUpper1.Controls.Add(this.hotSpot3);
            this.pnlUpper1.Controls.Add(this.hotSpot1);
            this.pnlUpper1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper1.Location = new System.Drawing.Point(3, 3);
            this.pnlUpper1.Name = "pnlUpper1";
            this.pnlUpper1.Size = new System.Drawing.Size(917, 32);
            this.pnlUpper1.TabIndex = 1;
            // 
            // hsExecuteDB
            // 
            this.hsExecuteDB.BackColor = System.Drawing.Color.Transparent;
            this.hsExecuteDB.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExecuteDB.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExecuteDB.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExecuteDB.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExecuteDB.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExecuteDB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExecuteDB.FlatAppearance.BorderSize = 0;
            this.hsExecuteDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExecuteDB.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExecuteDB.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsExecuteDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsExecuteDB.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsExecuteDB.ImageToggleOnSelect = false;
            this.hsExecuteDB.Location = new System.Drawing.Point(688, 0);
            this.hsExecuteDB.Marked = false;
            this.hsExecuteDB.MarkedColor = System.Drawing.Color.Teal;
            this.hsExecuteDB.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExecuteDB.MarkedText = "";
            this.hsExecuteDB.MarkMode = false;
            this.hsExecuteDB.Name = "hsExecuteDB";
            this.hsExecuteDB.NonMarkedText = "Excecute SQL";
            this.hsExecuteDB.Reserved = false;
            this.hsExecuteDB.Size = new System.Drawing.Size(116, 28);
            this.hsExecuteDB.TabIndex = 9;
            this.hsExecuteDB.Text = "Excecute SQL";
            this.hsExecuteDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsExecuteDB.ToolTipActive = false;
            this.hsExecuteDB.ToolTipAutomaticDelay = 500;
            this.hsExecuteDB.ToolTipAutoPopDelay = 5000;
            this.hsExecuteDB.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExecuteDB.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExecuteDB.ToolTipFor4ContextMenu = true;
            this.hsExecuteDB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExecuteDB.ToolTipInitialDelay = 500;
            this.hsExecuteDB.ToolTipIsBallon = false;
            this.hsExecuteDB.ToolTipOwnerDraw = false;
            this.hsExecuteDB.ToolTipReshowDelay = 100;
            this.hsExecuteDB.ToolTipShow = true;
            this.hsExecuteDB.ToolTipShowAlways = false;
            this.hsExecuteDB.ToolTipText = "";
            this.hsExecuteDB.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExecuteDB.ToolTipTitle = "";
            this.hsExecuteDB.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExecuteDB.UseVisualStyleBackColor = false;
            this.hsExecuteDB.Click += new System.EventHandler(this.hsExecuteDB_Click);
            // 
            // hsLoadScript
            // 
            this.hsLoadScript.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadScript.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadScript.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadScript.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadScript.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadScript.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadScript.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadScript.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadScript.FlatAppearance.BorderSize = 0;
            this.hsLoadScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadScript.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadScript.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoadScript.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadScript.ImageToggleOnSelect = false;
            this.hsLoadScript.Location = new System.Drawing.Point(95, 0);
            this.hsLoadScript.Marked = false;
            this.hsLoadScript.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadScript.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadScript.MarkedText = "";
            this.hsLoadScript.MarkMode = false;
            this.hsLoadScript.Name = "hsLoadScript";
            this.hsLoadScript.NonMarkedText = "Load from File";
            this.hsLoadScript.Reserved = false;
            this.hsLoadScript.Size = new System.Drawing.Size(139, 28);
            this.hsLoadScript.TabIndex = 8;
            this.hsLoadScript.Text = "Load from File";
            this.hsLoadScript.ToolTipActive = false;
            this.hsLoadScript.ToolTipAutomaticDelay = 500;
            this.hsLoadScript.ToolTipAutoPopDelay = 5000;
            this.hsLoadScript.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadScript.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadScript.ToolTipFor4ContextMenu = true;
            this.hsLoadScript.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadScript.ToolTipInitialDelay = 500;
            this.hsLoadScript.ToolTipIsBallon = false;
            this.hsLoadScript.ToolTipOwnerDraw = false;
            this.hsLoadScript.ToolTipReshowDelay = 100;
            this.hsLoadScript.ToolTipShow = true;
            this.hsLoadScript.ToolTipShowAlways = false;
            this.hsLoadScript.ToolTipText = "";
            this.hsLoadScript.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadScript.ToolTipTitle = "";
            this.hsLoadScript.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadScript.UseVisualStyleBackColor = false;
            this.hsLoadScript.Click += new System.EventHandler(this.hsLoadScript_Click);
            // 
            // hotSpot3
            // 
            this.hotSpot3.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot3.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot3.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot3.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot3.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot3.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot3.FlatAppearance.BorderSize = 0;
            this.hotSpot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot3.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hotSpot3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotSpot3.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hotSpot3.ImageToggleOnSelect = false;
            this.hotSpot3.Location = new System.Drawing.Point(0, 0);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "Save to file";
            this.hotSpot3.Reserved = false;
            this.hotSpot3.Size = new System.Drawing.Size(95, 28);
            this.hotSpot3.TabIndex = 7;
            this.hotSpot3.Text = "Save to file";
            this.hotSpot3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.hotSpot3.ToolTipShow = true;
            this.hotSpot3.ToolTipShowAlways = false;
            this.hotSpot3.ToolTipText = "";
            this.hotSpot3.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot3.ToolTipTitle = "";
            this.hotSpot3.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot3.UseVisualStyleBackColor = false;
            // 
            // hotSpot1
            // 
            this.hotSpot1.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot1.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot1.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot1.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot1.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(868, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Reserved = false;
            this.hotSpot1.Size = new System.Drawing.Size(45, 28);
            this.hotSpot1.TabIndex = 3;
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
            this.hotSpot1.ToolTipShow = true;
            this.hotSpot1.ToolTipShowAlways = false;
            this.hotSpot1.ToolTipText = "";
            this.hotSpot1.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot1.ToolTipTitle = "";
            this.hotSpot1.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot1.UseVisualStyleBackColor = false;
            // 
            // tabPageDependencies
            // 
            this.tabPageDependencies.Controls.Add(this.pnlCenter2);
            this.tabPageDependencies.Controls.Add(this.pnlUpper2);
            this.tabPageDependencies.Location = new System.Drawing.Point(4, 22);
            this.tabPageDependencies.Name = "tabPageDependencies";
            this.tabPageDependencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDependencies.Size = new System.Drawing.Size(923, 300);
            this.tabPageDependencies.TabIndex = 1;
            this.tabPageDependencies.Text = "Dependencies";
            this.tabPageDependencies.UseVisualStyleBackColor = true;
            // 
            // pnlCenter2
            // 
            this.pnlCenter2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCenter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter2.Location = new System.Drawing.Point(3, 35);
            this.pnlCenter2.Name = "pnlCenter2";
            this.pnlCenter2.Size = new System.Drawing.Size(917, 262);
            this.pnlCenter2.TabIndex = 22;
            // 
            // pnlUpper2
            // 
            this.pnlUpper2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpper2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpper2.Controls.Add(this.hotSpot2);
            this.pnlUpper2.Controls.Add(this.hsRefreshDependencies);
            this.pnlUpper2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper2.Location = new System.Drawing.Point(3, 3);
            this.pnlUpper2.Name = "pnlUpper2";
            this.pnlUpper2.Size = new System.Drawing.Size(917, 32);
            this.pnlUpper2.TabIndex = 21;
            // 
            // hotSpot2
            // 
            this.hotSpot2.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot2.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot2.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot2.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot2.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot2.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.ok_gn32x;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.ok_blue32x;
            this.hotSpot2.ImageToggleOnSelect = true;
            this.hotSpot2.Location = new System.Drawing.Point(0, 0);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "";
            this.hotSpot2.Reserved = false;
            this.hotSpot2.Size = new System.Drawing.Size(45, 28);
            this.hotSpot2.TabIndex = 3;
            this.hotSpot2.ToolTipActive = false;
            this.hotSpot2.ToolTipAutomaticDelay = 500;
            this.hotSpot2.ToolTipAutoPopDelay = 5000;
            this.hotSpot2.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot2.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot2.ToolTipFor4ContextMenu = true;
            this.hotSpot2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot2.ToolTipInitialDelay = 500;
            this.hotSpot2.ToolTipIsBallon = false;
            this.hotSpot2.ToolTipOwnerDraw = false;
            this.hotSpot2.ToolTipReshowDelay = 100;
            this.hotSpot2.ToolTipShow = true;
            this.hotSpot2.ToolTipShowAlways = false;
            this.hotSpot2.ToolTipText = "";
            this.hotSpot2.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot2.ToolTipTitle = "";
            this.hotSpot2.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot2.UseVisualStyleBackColor = false;
            // 
            // hsRefreshDependencies
            // 
            this.hsRefreshDependencies.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.BackColorHover = System.Drawing.Color.Transparent;
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
            this.hsRefreshDependencies.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependencies.ImageToggleOnSelect = true;
            this.hsRefreshDependencies.Location = new System.Drawing.Point(868, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Reserved = false;
            this.hsRefreshDependencies.Size = new System.Drawing.Size(45, 28);
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
            this.hsRefreshDependencies.ToolTipShow = true;
            this.hsRefreshDependencies.ToolTipShowAlways = false;
            this.hsRefreshDependencies.ToolTipText = "";
            this.hsRefreshDependencies.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDependencies.ToolTipTitle = "";
            this.hsRefreshDependencies.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDependencies.UseVisualStyleBackColor = false;
            // 
            // ofdSQL
            // 
            this.ofdSQL.DefaultExt = "*.sql";
            this.ofdSQL.Filter = "SQL|*.sql|All|*.*";
            this.ofdSQL.Title = "Load script";
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 388);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Name = "SQLForm";
            this.Text = "DefaultForm";
            this.Load += new System.EventHandler(this.DefaultForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.pnlCenter1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbSQL)).EndInit();
            this.pnlUpper1.ResumeLayout(false);
            this.tabPageDependencies.ResumeLayout(false);
            this.pnlUpper2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.Panel pnlCenter1;
        private System.Windows.Forms.Panel pnlUpper1;
        private System.Windows.Forms.TabPage tabPageDependencies;
        private System.Windows.Forms.Panel pnlUpper2;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.Panel pnlCenter2;
        private SeControlsLib.HotSpot hotSpot2;
        private FastColoredTextBoxNS.FastColoredTextBox fcbSQL;
        private SeControlsLib.HotSpot hsExecuteDB;
        private SeControlsLib.HotSpot hsLoadScript;
        private SeControlsLib.HotSpot hotSpot3;
        private System.Windows.Forms.OpenFileDialog ofdSQL;
    }
}