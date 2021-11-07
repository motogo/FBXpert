using System.ComponentModel.Design;

namespace FBXpert.ValuesEditForms
{
    partial class BlobEditForm
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bv = new System.ComponentModel.Design.ByteViewer();
            this.pnlUpperContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hsShowAsImage = new SeControlsLib.HotSpot();
            this.hsEXCEL = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsText = new SeControlsLib.HotSpot();
            this.hsPDF = new SeControlsLib.HotSpot();
            this.pnlCenter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlUpperContent.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.groupBox1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 58);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(708, 601);
            this.pnlCenter.TabIndex = 0;
            this.pnlCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCenter_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bv);
            this.groupBox1.Controls.Add(this.pnlUpperContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 601);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bv
            // 
            this.bv.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.bv.ColumnCount = 1;
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bv.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.bv.Location = new System.Drawing.Point(3, 44);
            this.bv.Name = "bv";
            this.bv.RowCount = 1;
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bv.Size = new System.Drawing.Size(702, 554);
            this.bv.TabIndex = 1;
            // 
            // pnlUpperContent
            // 
            this.pnlUpperContent.Controls.Add(this.label3);
            this.pnlUpperContent.Controls.Add(this.label2);
            this.pnlUpperContent.Controls.Add(this.label1);
            this.pnlUpperContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpperContent.Location = new System.Drawing.Point(3, 16);
            this.pnlUpperContent.Name = "pnlUpperContent";
            this.pnlUpperContent.Size = new System.Drawing.Size(702, 28);
            this.pnlUpperContent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HEX (Base 16)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASCII";
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.hotSpot1);
            this.pnlUpper.Controls.Add(this.hsShowAsImage);
            this.pnlUpper.Controls.Add(this.hsEXCEL);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Controls.Add(this.hsText);
            this.pnlUpper.Controls.Add(this.hsPDF);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(708, 58);
            this.pnlUpper.TabIndex = 2;
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
            this.hotSpot1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.edit_select_all_x32;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.edit_select_all_blue_x32;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(319, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "Word (doc)";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShortcutNewline = false;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(83, 58);
            this.hotSpot1.TabIndex = 6;
            this.hotSpot1.Text = "Word (doc)";
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
            // hsShowAsImage
            // 
            this.hsShowAsImage.BackColor = System.Drawing.Color.Transparent;
            this.hsShowAsImage.BackColorHover = System.Drawing.Color.Transparent;
            this.hsShowAsImage.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsShowAsImage.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsShowAsImage.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsShowAsImage.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsShowAsImage.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsShowAsImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsShowAsImage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsShowAsImage.FlatAppearance.BorderSize = 0;
            this.hsShowAsImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsShowAsImage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsShowAsImage.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsShowAsImage.Image = global::FBXpert.Properties.Resources.camera_photo_32;
            this.hsShowAsImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsShowAsImage.ImageHover = global::FBXpert.Properties.Resources.camera_photo_flash_32;
            this.hsShowAsImage.ImageToggleOnSelect = true;
            this.hsShowAsImage.Location = new System.Drawing.Point(402, 0);
            this.hsShowAsImage.Marked = false;
            this.hsShowAsImage.MarkedColor = System.Drawing.Color.Teal;
            this.hsShowAsImage.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsShowAsImage.MarkedText = "";
            this.hsShowAsImage.MarkMode = false;
            this.hsShowAsImage.Name = "hsShowAsImage";
            this.hsShowAsImage.NonMarkedText = "Image";
            this.hsShowAsImage.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsShowAsImage.ShortcutNewline = false;
            this.hsShowAsImage.ShowShortcut = false;
            this.hsShowAsImage.Size = new System.Drawing.Size(83, 58);
            this.hsShowAsImage.TabIndex = 5;
            this.hsShowAsImage.Text = "Image";
            this.hsShowAsImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsShowAsImage.ToolTipActive = false;
            this.hsShowAsImage.ToolTipAutomaticDelay = 500;
            this.hsShowAsImage.ToolTipAutoPopDelay = 5000;
            this.hsShowAsImage.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsShowAsImage.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsShowAsImage.ToolTipFor4ContextMenu = true;
            this.hsShowAsImage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsShowAsImage.ToolTipInitialDelay = 500;
            this.hsShowAsImage.ToolTipIsBallon = false;
            this.hsShowAsImage.ToolTipOwnerDraw = false;
            this.hsShowAsImage.ToolTipReshowDelay = 100;
            this.hsShowAsImage.ToolTipShowAlways = false;
            this.hsShowAsImage.ToolTipText = "";
            this.hsShowAsImage.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsShowAsImage.ToolTipTitle = "";
            this.hsShowAsImage.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsShowAsImage.UseVisualStyleBackColor = false;
            this.hsShowAsImage.Click += new System.EventHandler(this.hsShowAsImage_Click);
            // 
            // hsEXCEL
            // 
            this.hsEXCEL.BackColor = System.Drawing.Color.Transparent;
            this.hsEXCEL.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEXCEL.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsEXCEL.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEXCEL.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsEXCEL.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEXCEL.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEXCEL.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsEXCEL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEXCEL.FlatAppearance.BorderSize = 0;
            this.hsEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEXCEL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsEXCEL.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsEXCEL.Image = global::FBXpert.Properties.Resources.Table_x32;
            this.hsEXCEL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsEXCEL.ImageHover = global::FBXpert.Properties.Resources.Table_select_x32;
            this.hsEXCEL.ImageToggleOnSelect = true;
            this.hsEXCEL.Location = new System.Drawing.Point(485, 0);
            this.hsEXCEL.Marked = false;
            this.hsEXCEL.MarkedColor = System.Drawing.Color.Teal;
            this.hsEXCEL.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEXCEL.MarkedText = "";
            this.hsEXCEL.MarkMode = false;
            this.hsEXCEL.Name = "hsEXCEL";
            this.hsEXCEL.NonMarkedText = "Excel";
            this.hsEXCEL.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsEXCEL.ShortcutNewline = false;
            this.hsEXCEL.ShowShortcut = false;
            this.hsEXCEL.Size = new System.Drawing.Size(83, 58);
            this.hsEXCEL.TabIndex = 4;
            this.hsEXCEL.Text = "Excel";
            this.hsEXCEL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEXCEL.ToolTipActive = false;
            this.hsEXCEL.ToolTipAutomaticDelay = 500;
            this.hsEXCEL.ToolTipAutoPopDelay = 5000;
            this.hsEXCEL.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEXCEL.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEXCEL.ToolTipFor4ContextMenu = true;
            this.hsEXCEL.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEXCEL.ToolTipInitialDelay = 500;
            this.hsEXCEL.ToolTipIsBallon = false;
            this.hsEXCEL.ToolTipOwnerDraw = false;
            this.hsEXCEL.ToolTipReshowDelay = 100;
            this.hsEXCEL.ToolTipShowAlways = false;
            this.hsEXCEL.ToolTipText = "";
            this.hsEXCEL.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsEXCEL.ToolTipTitle = "";
            this.hsEXCEL.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEXCEL.UseVisualStyleBackColor = false;
            this.hsEXCEL.Click += new System.EventHandler(this.hsExcel_Click);
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
            this.hsClose.Size = new System.Drawing.Size(45, 58);
            this.hsClose.TabIndex = 0;
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
            // hsText
            // 
            this.hsText.BackColor = System.Drawing.Color.Transparent;
            this.hsText.BackColorHover = System.Drawing.Color.Transparent;
            this.hsText.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsText.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsText.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsText.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsText.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsText.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsText.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsText.FlatAppearance.BorderSize = 0;
            this.hsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsText.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsText.Image = global::FBXpert.Properties.Resources.documents_blue_x32;
            this.hsText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsText.ImageHover = global::FBXpert.Properties.Resources.documents_32x;
            this.hsText.ImageToggleOnSelect = true;
            this.hsText.Location = new System.Drawing.Point(568, 0);
            this.hsText.Marked = false;
            this.hsText.MarkedColor = System.Drawing.Color.Teal;
            this.hsText.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsText.MarkedText = "";
            this.hsText.MarkMode = false;
            this.hsText.Name = "hsText";
            this.hsText.NonMarkedText = "Text";
            this.hsText.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsText.ShortcutNewline = false;
            this.hsText.ShowShortcut = false;
            this.hsText.Size = new System.Drawing.Size(69, 58);
            this.hsText.TabIndex = 3;
            this.hsText.Text = "Text";
            this.hsText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsText.ToolTipActive = false;
            this.hsText.ToolTipAutomaticDelay = 500;
            this.hsText.ToolTipAutoPopDelay = 5000;
            this.hsText.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsText.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsText.ToolTipFor4ContextMenu = true;
            this.hsText.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsText.ToolTipInitialDelay = 500;
            this.hsText.ToolTipIsBallon = false;
            this.hsText.ToolTipOwnerDraw = false;
            this.hsText.ToolTipReshowDelay = 100;
            this.hsText.ToolTipShowAlways = false;
            this.hsText.ToolTipText = "";
            this.hsText.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsText.ToolTipTitle = "";
            this.hsText.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsText.UseVisualStyleBackColor = false;
            this.hsText.Click += new System.EventHandler(this.hsText_Click);
            // 
            // hsPDF
            // 
            this.hsPDF.BackColor = System.Drawing.Color.Transparent;
            this.hsPDF.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPDF.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPDF.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPDF.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPDF.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPDF.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsPDF.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsPDF.FlatAppearance.BorderSize = 0;
            this.hsPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPDF.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPDF.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPDF.Image = global::FBXpert.Properties.Resources.PDF_blue_32x;
            this.hsPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPDF.ImageHover = global::FBXpert.Properties.Resources.PDF_32x;
            this.hsPDF.ImageToggleOnSelect = true;
            this.hsPDF.Location = new System.Drawing.Point(637, 0);
            this.hsPDF.Marked = false;
            this.hsPDF.MarkedColor = System.Drawing.Color.Teal;
            this.hsPDF.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPDF.MarkedText = "";
            this.hsPDF.MarkMode = false;
            this.hsPDF.Name = "hsPDF";
            this.hsPDF.NonMarkedText = "PDF";
            this.hsPDF.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsPDF.ShortcutNewline = false;
            this.hsPDF.ShowShortcut = false;
            this.hsPDF.Size = new System.Drawing.Size(71, 58);
            this.hsPDF.TabIndex = 2;
            this.hsPDF.Text = "PDF";
            this.hsPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPDF.ToolTipActive = false;
            this.hsPDF.ToolTipAutomaticDelay = 500;
            this.hsPDF.ToolTipAutoPopDelay = 5000;
            this.hsPDF.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPDF.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPDF.ToolTipFor4ContextMenu = true;
            this.hsPDF.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPDF.ToolTipInitialDelay = 500;
            this.hsPDF.ToolTipIsBallon = false;
            this.hsPDF.ToolTipOwnerDraw = false;
            this.hsPDF.ToolTipReshowDelay = 100;
            this.hsPDF.ToolTipShowAlways = false;
            this.hsPDF.ToolTipText = "";
            this.hsPDF.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPDF.ToolTipTitle = "";
            this.hsPDF.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPDF.UseVisualStyleBackColor = false;
            this.hsPDF.Click += new System.EventHandler(this.hsPDF_Click);
            // 
            // BlobEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 659);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Name = "BlobEditForm";
            this.Text = "BlobEditForm";
            this.pnlCenter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlUpperContent.ResumeLayout(false);
            this.pnlUpperContent.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private ByteViewer bv;
        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsPDF;
        private SeControlsLib.HotSpot hsText;
        private SeControlsLib.HotSpot hsEXCEL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlUpperContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SeControlsLib.HotSpot hsShowAsImage;
        private SeControlsLib.HotSpot hotSpot1;
    }
}