namespace FBXDesigns
{
    partial class DatabaseDesignForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsSaveDesign = new SeControlsLib.HotSpot();
            this.cbDebug = new System.Windows.Forms.CheckBox();
            this.hsRefreshStruktur = new SeControlsLib.HotSpot();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObjectZoom = new System.Windows.Forms.TextBox();
            this.hsZoomMinus = new SeControlsLib.HotSpot();
            this.hsZoomPlus = new SeControlsLib.HotSpot();
            this.hsZoomDesingMinus = new SeControlsLib.HotSpot();
            this.hsZoomCanvasPlus = new SeControlsLib.HotSpot();
            this.hsAddNewTable = new SeControlsLib.HotSpot();
            this.pbDesign = new System.Windows.Forms.PictureBox();
            this.tabCtrlDesign = new System.Windows.Forms.TabControl();
            this.tabStruktur = new System.Windows.Forms.TabPage();
            this.tabXMLDefinition = new System.Windows.Forms.TabPage();
            this.pnlXMLDefinitionCenter = new System.Windows.Forms.Panel();
            this.xmlEditDefinition = new XMLSimlpeEdit.XMLEditSimpleUserControl();
            this.pnlXMLDefintionUpper = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlDatas = new System.Windows.Forms.Panel();
            this.pnlDBObjectsCenter = new System.Windows.Forms.Panel();
            this.selDBObjects = new SEListBox.SEListBox();
            this.pnlDBObjectsUpper = new System.Windows.Forms.Panel();
            this.pnlDatabaseDesignUpper = new System.Windows.Forms.Panel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlUpper.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesign)).BeginInit();
            this.tabCtrlDesign.SuspendLayout();
            this.tabStruktur.SuspendLayout();
            this.tabXMLDefinition.SuspendLayout();
            this.pnlXMLDefinitionCenter.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlDatas.SuspendLayout();
            this.pnlDBObjectsCenter.SuspendLayout();
            this.pnlDatabaseDesignUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.AutoScroll = true;
            this.pnlUpper.Controls.Add(this.hsSaveDesign);
            this.pnlUpper.Controls.Add(this.cbDebug);
            this.pnlUpper.Controls.Add(this.hsRefreshStruktur);
            this.pnlUpper.Controls.Add(this.groupBox1);
            this.pnlUpper.Controls.Add(this.hsZoomDesingMinus);
            this.pnlUpper.Controls.Add(this.hsZoomCanvasPlus);
            this.pnlUpper.Controls.Add(this.hsAddNewTable);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(2394, 34);
            this.pnlUpper.TabIndex = 1;
            // 
            // hsSaveDesign
            // 
            this.hsSaveDesign.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveDesign.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveDesign.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveDesign.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveDesign.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsSaveDesign.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveDesign.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveDesign.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveDesign.FlatAppearance.BorderSize = 0;
            this.hsSaveDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveDesign.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveDesign.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hsSaveDesign.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hsSaveDesign.ImageToggleOnSelect = true;
            this.hsSaveDesign.Location = new System.Drawing.Point(798, 5);
            this.hsSaveDesign.Marked = false;
            this.hsSaveDesign.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveDesign.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveDesign.MarkedText = "";
            this.hsSaveDesign.MarkMode = false;
            this.hsSaveDesign.Name = "hsSaveDesign";
            this.hsSaveDesign.NonMarkedText = "";
            this.hsSaveDesign.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveDesign.ShowShortcut = false;
            this.hsSaveDesign.Size = new System.Drawing.Size(45, 26);
            this.hsSaveDesign.TabIndex = 9;
            this.hsSaveDesign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveDesign.ToolTipActive = false;
            this.hsSaveDesign.ToolTipAutomaticDelay = 500;
            this.hsSaveDesign.ToolTipAutoPopDelay = 5000;
            this.hsSaveDesign.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveDesign.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveDesign.ToolTipFor4ContextMenu = true;
            this.hsSaveDesign.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveDesign.ToolTipInitialDelay = 500;
            this.hsSaveDesign.ToolTipIsBallon = false;
            this.hsSaveDesign.ToolTipOwnerDraw = false;
            this.hsSaveDesign.ToolTipReshowDelay = 100;
            this.hsSaveDesign.ToolTipShowAlways = false;
            this.hsSaveDesign.ToolTipText = "";
            this.hsSaveDesign.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveDesign.ToolTipTitle = "";
            this.hsSaveDesign.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveDesign.UseVisualStyleBackColor = false;
            this.hsSaveDesign.Click += new System.EventHandler(this.hsSaveDesign_Click);
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.Location = new System.Drawing.Point(639, 6);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(56, 17);
            this.cbDebug.TabIndex = 8;
            this.cbDebug.Text = "debug";
            this.cbDebug.UseVisualStyleBackColor = true;
            this.cbDebug.CheckedChanged += new System.EventHandler(this.CbDebug_CheckedChanged);
            // 
            // hsRefreshStruktur
            // 
            this.hsRefreshStruktur.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshStruktur.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshStruktur.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshStruktur.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshStruktur.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsRefreshStruktur.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshStruktur.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshStruktur.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshStruktur.FlatAppearance.BorderSize = 0;
            this.hsRefreshStruktur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshStruktur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshStruktur.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshStruktur.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshStruktur.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshStruktur.ImageToggleOnSelect = true;
            this.hsRefreshStruktur.Location = new System.Drawing.Point(1175, 4);
            this.hsRefreshStruktur.Marked = false;
            this.hsRefreshStruktur.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshStruktur.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshStruktur.MarkedText = "";
            this.hsRefreshStruktur.MarkMode = false;
            this.hsRefreshStruktur.Name = "hsRefreshStruktur";
            this.hsRefreshStruktur.NonMarkedText = "";
            this.hsRefreshStruktur.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshStruktur.ShowShortcut = false;
            this.hsRefreshStruktur.Size = new System.Drawing.Size(45, 26);
            this.hsRefreshStruktur.TabIndex = 7;
            this.hsRefreshStruktur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshStruktur.ToolTipActive = false;
            this.hsRefreshStruktur.ToolTipAutomaticDelay = 500;
            this.hsRefreshStruktur.ToolTipAutoPopDelay = 5000;
            this.hsRefreshStruktur.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshStruktur.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshStruktur.ToolTipFor4ContextMenu = true;
            this.hsRefreshStruktur.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshStruktur.ToolTipInitialDelay = 500;
            this.hsRefreshStruktur.ToolTipIsBallon = false;
            this.hsRefreshStruktur.ToolTipOwnerDraw = false;
            this.hsRefreshStruktur.ToolTipReshowDelay = 100;
            this.hsRefreshStruktur.ToolTipShowAlways = false;
            this.hsRefreshStruktur.ToolTipText = "";
            this.hsRefreshStruktur.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshStruktur.ToolTipTitle = "";
            this.hsRefreshStruktur.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshStruktur.UseVisualStyleBackColor = false;
            this.hsRefreshStruktur.Click += new System.EventHandler(this.hsRefreshStruktur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObjectZoom);
            this.groupBox1.Controls.Add(this.hsZoomMinus);
            this.groupBox1.Controls.Add(this.hsZoomPlus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 34);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Zoom";
            // 
            // txtObjectZoom
            // 
            this.txtObjectZoom.Location = new System.Drawing.Point(66, 12);
            this.txtObjectZoom.Name = "txtObjectZoom";
            this.txtObjectZoom.Size = new System.Drawing.Size(61, 20);
            this.txtObjectZoom.TabIndex = 6;
            this.txtObjectZoom.Text = "1";
            // 
            // hsZoomMinus
            // 
            this.hsZoomMinus.BackColor = System.Drawing.Color.Transparent;
            this.hsZoomMinus.BackColorHover = System.Drawing.Color.Transparent;
            this.hsZoomMinus.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsZoomMinus.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsZoomMinus.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsZoomMinus.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsZoomMinus.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsZoomMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsZoomMinus.FlatAppearance.BorderSize = 0;
            this.hsZoomMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsZoomMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsZoomMinus.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsZoomMinus.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsZoomMinus.ImageHover = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsZoomMinus.ImageToggleOnSelect = true;
            this.hsZoomMinus.Location = new System.Drawing.Point(149, 13);
            this.hsZoomMinus.Marked = false;
            this.hsZoomMinus.MarkedColor = System.Drawing.Color.Teal;
            this.hsZoomMinus.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsZoomMinus.MarkedText = "";
            this.hsZoomMinus.MarkMode = false;
            this.hsZoomMinus.Name = "hsZoomMinus";
            this.hsZoomMinus.NonMarkedText = "";
            this.hsZoomMinus.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsZoomMinus.ShowShortcut = false;
            this.hsZoomMinus.Size = new System.Drawing.Size(45, 14);
            this.hsZoomMinus.TabIndex = 5;
            this.hsZoomMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsZoomMinus.ToolTipActive = false;
            this.hsZoomMinus.ToolTipAutomaticDelay = 500;
            this.hsZoomMinus.ToolTipAutoPopDelay = 5000;
            this.hsZoomMinus.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsZoomMinus.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsZoomMinus.ToolTipFor4ContextMenu = true;
            this.hsZoomMinus.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsZoomMinus.ToolTipInitialDelay = 500;
            this.hsZoomMinus.ToolTipIsBallon = false;
            this.hsZoomMinus.ToolTipOwnerDraw = false;
            this.hsZoomMinus.ToolTipReshowDelay = 100;
            this.hsZoomMinus.ToolTipShowAlways = false;
            this.hsZoomMinus.ToolTipText = "";
            this.hsZoomMinus.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsZoomMinus.ToolTipTitle = "";
            this.hsZoomMinus.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsZoomMinus.UseVisualStyleBackColor = false;
            this.hsZoomMinus.Click += new System.EventHandler(this.hsZoomMinus_Click);
            // 
            // hsZoomPlus
            // 
            this.hsZoomPlus.BackColor = System.Drawing.Color.Transparent;
            this.hsZoomPlus.BackColorHover = System.Drawing.Color.Transparent;
            this.hsZoomPlus.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsZoomPlus.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsZoomPlus.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsZoomPlus.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsZoomPlus.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsZoomPlus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsZoomPlus.FlatAppearance.BorderSize = 0;
            this.hsZoomPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsZoomPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsZoomPlus.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsZoomPlus.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsZoomPlus.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsZoomPlus.ImageToggleOnSelect = true;
            this.hsZoomPlus.Location = new System.Drawing.Point(6, 15);
            this.hsZoomPlus.Marked = false;
            this.hsZoomPlus.MarkedColor = System.Drawing.Color.Teal;
            this.hsZoomPlus.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsZoomPlus.MarkedText = "";
            this.hsZoomPlus.MarkMode = false;
            this.hsZoomPlus.Name = "hsZoomPlus";
            this.hsZoomPlus.NonMarkedText = "";
            this.hsZoomPlus.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsZoomPlus.ShowShortcut = false;
            this.hsZoomPlus.Size = new System.Drawing.Size(45, 13);
            this.hsZoomPlus.TabIndex = 4;
            this.hsZoomPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsZoomPlus.ToolTipActive = false;
            this.hsZoomPlus.ToolTipAutomaticDelay = 500;
            this.hsZoomPlus.ToolTipAutoPopDelay = 5000;
            this.hsZoomPlus.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsZoomPlus.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsZoomPlus.ToolTipFor4ContextMenu = true;
            this.hsZoomPlus.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsZoomPlus.ToolTipInitialDelay = 500;
            this.hsZoomPlus.ToolTipIsBallon = false;
            this.hsZoomPlus.ToolTipOwnerDraw = false;
            this.hsZoomPlus.ToolTipReshowDelay = 100;
            this.hsZoomPlus.ToolTipShowAlways = false;
            this.hsZoomPlus.ToolTipText = "";
            this.hsZoomPlus.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsZoomPlus.ToolTipTitle = "";
            this.hsZoomPlus.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsZoomPlus.UseVisualStyleBackColor = false;
            this.hsZoomPlus.Click += new System.EventHandler(this.hsZoomPlus_Click);
            // 
            // hsZoomDesingMinus
            // 
            this.hsZoomDesingMinus.BackColor = System.Drawing.Color.Transparent;
            this.hsZoomDesingMinus.BackColorHover = System.Drawing.Color.Transparent;
            this.hsZoomDesingMinus.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsZoomDesingMinus.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsZoomDesingMinus.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsZoomDesingMinus.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsZoomDesingMinus.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsZoomDesingMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsZoomDesingMinus.FlatAppearance.BorderSize = 0;
            this.hsZoomDesingMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsZoomDesingMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsZoomDesingMinus.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsZoomDesingMinus.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsZoomDesingMinus.ImageHover = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsZoomDesingMinus.ImageToggleOnSelect = true;
            this.hsZoomDesingMinus.Location = new System.Drawing.Point(428, 6);
            this.hsZoomDesingMinus.Marked = false;
            this.hsZoomDesingMinus.MarkedColor = System.Drawing.Color.Teal;
            this.hsZoomDesingMinus.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsZoomDesingMinus.MarkedText = "";
            this.hsZoomDesingMinus.MarkMode = false;
            this.hsZoomDesingMinus.Name = "hsZoomDesingMinus";
            this.hsZoomDesingMinus.NonMarkedText = "";
            this.hsZoomDesingMinus.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsZoomDesingMinus.ShowShortcut = false;
            this.hsZoomDesingMinus.Size = new System.Drawing.Size(45, 26);
            this.hsZoomDesingMinus.TabIndex = 3;
            this.hsZoomDesingMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsZoomDesingMinus.ToolTipActive = false;
            this.hsZoomDesingMinus.ToolTipAutomaticDelay = 500;
            this.hsZoomDesingMinus.ToolTipAutoPopDelay = 5000;
            this.hsZoomDesingMinus.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsZoomDesingMinus.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsZoomDesingMinus.ToolTipFor4ContextMenu = true;
            this.hsZoomDesingMinus.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsZoomDesingMinus.ToolTipInitialDelay = 500;
            this.hsZoomDesingMinus.ToolTipIsBallon = false;
            this.hsZoomDesingMinus.ToolTipOwnerDraw = false;
            this.hsZoomDesingMinus.ToolTipReshowDelay = 100;
            this.hsZoomDesingMinus.ToolTipShowAlways = false;
            this.hsZoomDesingMinus.ToolTipText = "";
            this.hsZoomDesingMinus.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsZoomDesingMinus.ToolTipTitle = "";
            this.hsZoomDesingMinus.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsZoomDesingMinus.UseVisualStyleBackColor = false;
            this.hsZoomDesingMinus.Click += new System.EventHandler(this.hsZoomDesingMinus_Click);
            // 
            // hsZoomCanvasPlus
            // 
            this.hsZoomCanvasPlus.BackColor = System.Drawing.Color.Transparent;
            this.hsZoomCanvasPlus.BackColorHover = System.Drawing.Color.Transparent;
            this.hsZoomCanvasPlus.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsZoomCanvasPlus.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsZoomCanvasPlus.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsZoomCanvasPlus.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsZoomCanvasPlus.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsZoomCanvasPlus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsZoomCanvasPlus.FlatAppearance.BorderSize = 0;
            this.hsZoomCanvasPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsZoomCanvasPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsZoomCanvasPlus.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsZoomCanvasPlus.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsZoomCanvasPlus.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsZoomCanvasPlus.ImageToggleOnSelect = true;
            this.hsZoomCanvasPlus.Location = new System.Drawing.Point(377, 7);
            this.hsZoomCanvasPlus.Marked = false;
            this.hsZoomCanvasPlus.MarkedColor = System.Drawing.Color.Teal;
            this.hsZoomCanvasPlus.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsZoomCanvasPlus.MarkedText = "";
            this.hsZoomCanvasPlus.MarkMode = false;
            this.hsZoomCanvasPlus.Name = "hsZoomCanvasPlus";
            this.hsZoomCanvasPlus.NonMarkedText = "";
            this.hsZoomCanvasPlus.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsZoomCanvasPlus.ShowShortcut = false;
            this.hsZoomCanvasPlus.Size = new System.Drawing.Size(45, 26);
            this.hsZoomCanvasPlus.TabIndex = 2;
            this.hsZoomCanvasPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsZoomCanvasPlus.ToolTipActive = false;
            this.hsZoomCanvasPlus.ToolTipAutomaticDelay = 500;
            this.hsZoomCanvasPlus.ToolTipAutoPopDelay = 5000;
            this.hsZoomCanvasPlus.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsZoomCanvasPlus.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsZoomCanvasPlus.ToolTipFor4ContextMenu = true;
            this.hsZoomCanvasPlus.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsZoomCanvasPlus.ToolTipInitialDelay = 500;
            this.hsZoomCanvasPlus.ToolTipIsBallon = false;
            this.hsZoomCanvasPlus.ToolTipOwnerDraw = false;
            this.hsZoomCanvasPlus.ToolTipReshowDelay = 100;
            this.hsZoomCanvasPlus.ToolTipShowAlways = false;
            this.hsZoomCanvasPlus.ToolTipText = "";
            this.hsZoomCanvasPlus.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsZoomCanvasPlus.ToolTipTitle = "";
            this.hsZoomCanvasPlus.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsZoomCanvasPlus.UseVisualStyleBackColor = false;
            this.hsZoomCanvasPlus.Click += new System.EventHandler(this.hsZoomCanvasPlus_Click);
            // 
            // hsAddNewTable
            // 
            this.hsAddNewTable.BackColor = System.Drawing.Color.Transparent;
            this.hsAddNewTable.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddNewTable.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddNewTable.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddNewTable.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddNewTable.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddNewTable.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddNewTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddNewTable.FlatAppearance.BorderSize = 0;
            this.hsAddNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddNewTable.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddNewTable.Image = null;
            this.hsAddNewTable.ImageHover = null;
            this.hsAddNewTable.ImageToggleOnSelect = true;
            this.hsAddNewTable.Location = new System.Drawing.Point(505, 7);
            this.hsAddNewTable.Marked = false;
            this.hsAddNewTable.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddNewTable.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddNewTable.MarkedText = "";
            this.hsAddNewTable.MarkMode = false;
            this.hsAddNewTable.Name = "hsAddNewTable";
            this.hsAddNewTable.NonMarkedText = "New Table";
            this.hsAddNewTable.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddNewTable.ShowShortcut = false;
            this.hsAddNewTable.Size = new System.Drawing.Size(86, 26);
            this.hsAddNewTable.TabIndex = 1;
            this.hsAddNewTable.Text = "New Table";
            this.hsAddNewTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddNewTable.ToolTipActive = false;
            this.hsAddNewTable.ToolTipAutomaticDelay = 500;
            this.hsAddNewTable.ToolTipAutoPopDelay = 5000;
            this.hsAddNewTable.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddNewTable.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddNewTable.ToolTipFor4ContextMenu = true;
            this.hsAddNewTable.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddNewTable.ToolTipInitialDelay = 500;
            this.hsAddNewTable.ToolTipIsBallon = false;
            this.hsAddNewTable.ToolTipOwnerDraw = false;
            this.hsAddNewTable.ToolTipReshowDelay = 100;
            this.hsAddNewTable.ToolTipShowAlways = false;
            this.hsAddNewTable.ToolTipText = "";
            this.hsAddNewTable.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddNewTable.ToolTipTitle = "";
            this.hsAddNewTable.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddNewTable.UseVisualStyleBackColor = false;
            this.hsAddNewTable.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // pbDesign
            // 
            this.pbDesign.BackColor = System.Drawing.SystemColors.Info;
            this.pbDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDesign.Location = new System.Drawing.Point(0, 40);
            this.pbDesign.Name = "pbDesign";
            this.pbDesign.Size = new System.Drawing.Size(2400, 3160);
            this.pbDesign.TabIndex = 2;
            this.pbDesign.TabStop = false;
            // 
            // tabCtrlDesign
            // 
            this.tabCtrlDesign.Controls.Add(this.tabStruktur);
            this.tabCtrlDesign.Controls.Add(this.tabXMLDefinition);
            this.tabCtrlDesign.Controls.Add(this.tabPage3);
            this.tabCtrlDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlDesign.Location = new System.Drawing.Point(0, 34);
            this.tabCtrlDesign.Name = "tabCtrlDesign";
            this.tabCtrlDesign.SelectedIndex = 0;
            this.tabCtrlDesign.Size = new System.Drawing.Size(1269, 637);
            this.tabCtrlDesign.TabIndex = 4;
            // 
            // tabStruktur
            // 
            this.tabStruktur.AutoScroll = true;
            this.tabStruktur.Controls.Add(this.pbDesign);
            this.tabStruktur.Controls.Add(this.pnlUpper);
            this.tabStruktur.Location = new System.Drawing.Point(4, 22);
            this.tabStruktur.Name = "tabStruktur";
            this.tabStruktur.Padding = new System.Windows.Forms.Padding(3);
            this.tabStruktur.Size = new System.Drawing.Size(1261, 611);
            this.tabStruktur.TabIndex = 0;
            this.tabStruktur.Text = "Struktur";
            this.tabStruktur.UseVisualStyleBackColor = true;
            this.tabStruktur.ClientSizeChanged += new System.EventHandler(this.tabPage1_ClientSizeChanged);
            // 
            // tabXMLDefinition
            // 
            this.tabXMLDefinition.Controls.Add(this.pnlXMLDefinitionCenter);
            this.tabXMLDefinition.Controls.Add(this.pnlXMLDefintionUpper);
            this.tabXMLDefinition.Location = new System.Drawing.Point(4, 22);
            this.tabXMLDefinition.Name = "tabXMLDefinition";
            this.tabXMLDefinition.Padding = new System.Windows.Forms.Padding(3);
            this.tabXMLDefinition.Size = new System.Drawing.Size(1261, 611);
            this.tabXMLDefinition.TabIndex = 1;
            this.tabXMLDefinition.Text = "Definition";
            this.tabXMLDefinition.UseVisualStyleBackColor = true;
            // 
            // pnlXMLDefinitionCenter
            // 
            this.pnlXMLDefinitionCenter.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlXMLDefinitionCenter.Controls.Add(this.xmlEditDefinition);
            this.pnlXMLDefinitionCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlXMLDefinitionCenter.Location = new System.Drawing.Point(3, 37);
            this.pnlXMLDefinitionCenter.Name = "pnlXMLDefinitionCenter";
            this.pnlXMLDefinitionCenter.Size = new System.Drawing.Size(1255, 571);
            this.pnlXMLDefinitionCenter.TabIndex = 0;
            // 
            // xmlEditDefinition
            // 
            this.xmlEditDefinition.Caption = "Input File";
            this.xmlEditDefinition.DefaultExt = "xml";
            this.xmlEditDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlEditDefinition.EditorFont = new System.Drawing.Font("Courier New", 10F);
            this.xmlEditDefinition.Filter = "Xml files|*.xml|All files|*.*";
            this.xmlEditDefinition.KeyName = "XmlFile";
            this.xmlEditDefinition.LastXmlDirKey = "LastXmlDir";
            this.xmlEditDefinition.Location = new System.Drawing.Point(0, 0);
            this.xmlEditDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.xmlEditDefinition.MinimumSize = new System.Drawing.Size(200, 100);
            this.xmlEditDefinition.Name = "xmlEditDefinition";
            this.xmlEditDefinition.Size = new System.Drawing.Size(1255, 571);
            this.xmlEditDefinition.StatusBarVisible = false;
            this.xmlEditDefinition.TabIndex = 0;
            this.xmlEditDefinition.Load += new System.EventHandler(this.xmlEditDefinition_Load);
            // 
            // pnlXMLDefintionUpper
            // 
            this.pnlXMLDefintionUpper.AutoScroll = true;
            this.pnlXMLDefintionUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlXMLDefintionUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLDefintionUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlXMLDefintionUpper.Name = "pnlXMLDefintionUpper";
            this.pnlXMLDefintionUpper.Size = new System.Drawing.Size(1255, 34);
            this.pnlXMLDefintionUpper.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlDatas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1261, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlDatas
            // 
            this.pnlDatas.BackColor = System.Drawing.Color.LightGray;
            this.pnlDatas.Controls.Add(this.pnlDBObjectsCenter);
            this.pnlDatas.Controls.Add(this.pnlDBObjectsUpper);
            this.pnlDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatas.Location = new System.Drawing.Point(3, 3);
            this.pnlDatas.Name = "pnlDatas";
            this.pnlDatas.Size = new System.Drawing.Size(1255, 605);
            this.pnlDatas.TabIndex = 0;
            // 
            // pnlDBObjectsCenter
            // 
            this.pnlDBObjectsCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlDBObjectsCenter.Controls.Add(this.selDBObjects);
            this.pnlDBObjectsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDBObjectsCenter.Location = new System.Drawing.Point(0, 40);
            this.pnlDBObjectsCenter.Name = "pnlDBObjectsCenter";
            this.pnlDBObjectsCenter.Size = new System.Drawing.Size(1255, 565);
            this.pnlDBObjectsCenter.TabIndex = 1;
            this.pnlDBObjectsCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDBObjectsCenter_Paint);
            // 
            // selDBObjects
            // 
            this.selDBObjects.AlloweColumnFilterIndexChange = false;
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
            this.selDBObjects.ColumnFilterIndex = 2;
            this.selDBObjects.FilterText = "";
            this.selDBObjects.IDVisible = false;
            this.selDBObjects.IDWith = 32;
            this.selDBObjects.ItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selDBObjects.ListEntriesDefaultCellStyle = dataGridViewCellStyle2;
            this.selDBObjects.Location = new System.Drawing.Point(452, 66);
            this.selDBObjects.MarkingColor = System.Drawing.Color.LightGreen;
            this.selDBObjects.Name = "selDBObjects";
            this.selDBObjects.SelectedIndex = -1;
            this.selDBObjects.ShowCaptions = true;
            this.selDBObjects.ShowCellToolTips = true;
            this.selDBObjects.ShowCountInTitle = true;
            this.selDBObjects.ShowSelection = true;
            this.selDBObjects.Size = new System.Drawing.Size(230, 469);
            this.selDBObjects.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
            this.selDBObjects.SQLKonjunktion = "AND";
            this.selDBObjects.TabIndex = 5;
            this.selDBObjects.Text = "Object list";
            this.selDBObjects.TextCaption = "text";
            this.selDBObjects.TextWith = 189;
            this.selDBObjects.Title = "";
            this.selDBObjects.UseFiltering = false;
            this.selDBObjects.UseFilteringAutocomplete = false;
            this.selDBObjects.WordWrap = System.Windows.Forms.DataGridViewTriState.NotSet;
            // 
            // pnlDBObjectsUpper
            // 
            this.pnlDBObjectsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDBObjectsUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlDBObjectsUpper.Name = "pnlDBObjectsUpper";
            this.pnlDBObjectsUpper.Size = new System.Drawing.Size(1255, 40);
            this.pnlDBObjectsUpper.TabIndex = 0;
            // 
            // pnlDatabaseDesignUpper
            // 
            this.pnlDatabaseDesignUpper.Controls.Add(this.hsClose);
            this.pnlDatabaseDesignUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatabaseDesignUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlDatabaseDesignUpper.Name = "pnlDatabaseDesignUpper";
            this.pnlDatabaseDesignUpper.Size = new System.Drawing.Size(1269, 34);
            this.pnlDatabaseDesignUpper.TabIndex = 5;
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
            this.hsClose.Size = new System.Drawing.Size(45, 34);
            this.hsClose.TabIndex = 3;
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
            // DatabaseDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 671);
            this.Controls.Add(this.tabCtrlDesign);
            this.Controls.Add(this.pnlDatabaseDesignUpper);
            this.Name = "DatabaseDesignForm";
            this.Text = "DesignerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesignerForm_FormClosing);
            this.Load += new System.EventHandler(this.DesignerForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DesignerForm_MouseMove);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesign)).EndInit();
            this.tabCtrlDesign.ResumeLayout(false);
            this.tabStruktur.ResumeLayout(false);
            this.tabXMLDefinition.ResumeLayout(false);
            this.pnlXMLDefinitionCenter.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlDatas.ResumeLayout(false);
            this.pnlDBObjectsCenter.ResumeLayout(false);
            this.pnlDatabaseDesignUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsAddNewTable;
        private System.Windows.Forms.PictureBox pbDesign;
        private SeControlsLib.HotSpot hsZoomCanvasPlus;
        private SeControlsLib.HotSpot hsZoomDesingMinus;
        private System.Windows.Forms.TabControl tabCtrlDesign;
        private System.Windows.Forms.TabPage tabStruktur;
        private System.Windows.Forms.TabPage tabXMLDefinition;
        private System.Windows.Forms.Panel pnlXMLDefintionUpper;
        private System.Windows.Forms.Panel pnlXMLDefinitionCenter;
        private XMLSimlpeEdit.XMLEditSimpleUserControl xmlEditDefinition;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlDatas;
        private SeControlsLib.HotSpot hsZoomMinus;
        private SeControlsLib.HotSpot hsZoomPlus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObjectZoom;
        private System.Windows.Forms.Panel pnlDBObjectsCenter;
        private System.Windows.Forms.Panel pnlDBObjectsUpper;
        private SEListBox.SEListBox selDBObjects;
        private System.Windows.Forms.Panel pnlDatabaseDesignUpper;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefreshStruktur;
        private System.Windows.Forms.CheckBox cbDebug;
        private SeControlsLib.HotSpot hsSaveDesign;
    }
}