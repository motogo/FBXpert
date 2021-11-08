namespace FBXpert
{
    partial class SaveFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveFileForm));
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.hsAbort = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.gbFileName = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.hsSelectFolder = new SeControlsLib.HotSpot();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.pnlCenter.SuspendLayout();
            this.gbFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.hsAbort);
            this.pnlCenter.Controls.Add(this.hsClose);
            this.pnlCenter.Controls.Add(this.gbFileName);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 17);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(715, 132);
            this.pnlCenter.TabIndex = 2;
            // 
            // hsAbort
            // 
            this.hsAbort.BackColor = System.Drawing.Color.Transparent;
            this.hsAbort.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAbort.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAbort.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAbort.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAbort.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAbort.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAbort.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAbort.FlatAppearance.BorderSize = 0;
            this.hsAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAbort.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAbort.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAbort.Image = global::FBXpert.Properties.Resources.cross_red_x32;
            this.hsAbort.ImageHover = global::FBXpert.Properties.Resources.cross_blue_x32;
            this.hsAbort.ImageToggleOnSelect = true;
            this.hsAbort.Location = new System.Drawing.Point(345, 66);
            this.hsAbort.Marked = false;
            this.hsAbort.MarkedColor = System.Drawing.Color.Teal;
            this.hsAbort.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAbort.MarkedText = "";
            this.hsAbort.MarkMode = false;
            this.hsAbort.Name = "hsAbort";
            this.hsAbort.NonMarkedText = "";
            this.hsAbort.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAbort.ShortcutNewline = false;
            this.hsAbort.ShowShortcut = false;
            this.hsAbort.Size = new System.Drawing.Size(45, 46);
            this.hsAbort.TabIndex = 4;
            this.hsAbort.ToolTipActive = false;
            this.hsAbort.ToolTipAutomaticDelay = 500;
            this.hsAbort.ToolTipAutoPopDelay = 5000;
            this.hsAbort.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAbort.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAbort.ToolTipFor4ContextMenu = true;
            this.hsAbort.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAbort.ToolTipInitialDelay = 500;
            this.hsAbort.ToolTipIsBallon = false;
            this.hsAbort.ToolTipOwnerDraw = false;
            this.hsAbort.ToolTipReshowDelay = 100;
            this.hsAbort.ToolTipShowAlways = false;
            this.hsAbort.ToolTipText = "";
            this.hsAbort.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAbort.ToolTipTitle = "";
            this.hsAbort.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAbort.UseVisualStyleBackColor = false;
            this.hsAbort.Click += new System.EventHandler(this.hsAbort_Click);
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
            this.hsClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClose.Image = global::FBXpert.Properties.Resources.ok_gn32x;
            this.hsClose.ImageHover = global::FBXpert.Properties.Resources.ok_blue32x;
            this.hsClose.ImageToggleOnSelect = true;
            this.hsClose.Location = new System.Drawing.Point(294, 66);
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
            this.hsClose.TabIndex = 3;
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
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click_1);
            // 
            // gbFileName
            // 
            this.gbFileName.Controls.Add(this.txtFileName);
            this.gbFileName.Controls.Add(this.hsSelectFolder);
            this.gbFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFileName.Location = new System.Drawing.Point(0, 0);
            this.gbFileName.Name = "gbFileName";
            this.gbFileName.Size = new System.Drawing.Size(715, 40);
            this.gbFileName.TabIndex = 0;
            this.gbFileName.TabStop = false;
            this.gbFileName.Text = "File";
            // 
            // txtFileName
            // 
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileName.Location = new System.Drawing.Point(3, 16);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(664, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // hsSelectFolder
            // 
            this.hsSelectFolder.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectFolder.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectFolder.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectFolder.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectFolder.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectFolder.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectFolder.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSelectFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectFolder.FlatAppearance.BorderSize = 0;
            this.hsSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectFolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSelectFolder.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectFolder.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsSelectFolder.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsSelectFolder.ImageToggleOnSelect = true;
            this.hsSelectFolder.Location = new System.Drawing.Point(667, 16);
            this.hsSelectFolder.Marked = false;
            this.hsSelectFolder.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectFolder.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectFolder.MarkedText = "";
            this.hsSelectFolder.MarkMode = false;
            this.hsSelectFolder.Name = "hsSelectFolder";
            this.hsSelectFolder.NonMarkedText = "";
            this.hsSelectFolder.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSelectFolder.ShortcutNewline = false;
            this.hsSelectFolder.ShowShortcut = false;
            this.hsSelectFolder.Size = new System.Drawing.Size(45, 21);
            this.hsSelectFolder.TabIndex = 3;
            this.hsSelectFolder.ToolTipActive = false;
            this.hsSelectFolder.ToolTipAutomaticDelay = 500;
            this.hsSelectFolder.ToolTipAutoPopDelay = 5000;
            this.hsSelectFolder.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectFolder.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectFolder.ToolTipFor4ContextMenu = true;
            this.hsSelectFolder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectFolder.ToolTipInitialDelay = 500;
            this.hsSelectFolder.ToolTipIsBallon = false;
            this.hsSelectFolder.ToolTipOwnerDraw = false;
            this.hsSelectFolder.ToolTipReshowDelay = 100;
            this.hsSelectFolder.ToolTipShowAlways = false;
            this.hsSelectFolder.ToolTipText = "";
            this.hsSelectFolder.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectFolder.ToolTipTitle = "";
            this.hsSelectFolder.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectFolder.UseVisualStyleBackColor = false;
            this.hsSelectFolder.Click += new System.EventHandler(this.hsSelectFolder_Click);
            // 
            // pnlUpper
            // 
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(715, 17);
            this.pnlUpper.TabIndex = 5;
            // 
            // sfdFile
            // 
            this.sfdFile.CreatePrompt = true;
            this.sfdFile.DefaultExt = "*.sql";
            this.sfdFile.Filter = "SQL|*.sql|All|*.*";
            this.sfdFile.Title = "SQL File";
            // 
            // SaveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 149);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveFileForm";
            this.Text = "SaveFileForm";
            this.Load += new System.EventHandler(this.SaveFileForm_Load);
            this.pnlCenter.ResumeLayout(false);
            this.gbFileName.ResumeLayout(false);
            this.gbFileName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.GroupBox gbFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private SeControlsLib.HotSpot hsSelectFolder;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private SeControlsLib.HotSpot hsAbort;
    }
}