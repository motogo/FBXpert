namespace FBXpert.SonstForms
{
    partial class ExportProceduresScriptForm
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
            this.pnlFormUpper = new System.Windows.Forms.Panel();
            this.ckDeleteAllFiles = new System.Windows.Forms.CheckBox();
            this.ckCreateProcedure = new System.Windows.Forms.CheckBox();
            this.ckAlterProcedure = new System.Windows.Forms.CheckBox();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsExportProcedures = new SeControlsLib.HotSpot();
            this.gbDefaultSQLExportPath = new System.Windows.Forms.GroupBox();
            this.txtSQLExportPath = new System.Windows.Forms.TextBox();
            this.hsInitialSQLExportPath = new SeControlsLib.HotSpot();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlFormUpper.SuspendLayout();
            this.gbDefaultSQLExportPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormUpper
            // 
            this.pnlFormUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFormUpper.Controls.Add(this.ckDeleteAllFiles);
            this.pnlFormUpper.Controls.Add(this.ckCreateProcedure);
            this.pnlFormUpper.Controls.Add(this.ckAlterProcedure);
            this.pnlFormUpper.Controls.Add(this.hsClose);
            this.pnlFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUpper.Name = "pnlFormUpper";
            this.pnlFormUpper.Size = new System.Drawing.Size(641, 44);
            this.pnlFormUpper.TabIndex = 2;
            // 
            // ckDeleteAllFiles
            // 
            this.ckDeleteAllFiles.AutoSize = true;
            this.ckDeleteAllFiles.Checked = true;
            this.ckDeleteAllFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDeleteAllFiles.Location = new System.Drawing.Point(387, 14);
            this.ckDeleteAllFiles.Name = "ckDeleteAllFiles";
            this.ckDeleteAllFiles.Size = new System.Drawing.Size(150, 17);
            this.ckDeleteAllFiles.TabIndex = 3;
            this.ckDeleteAllFiles.Text = "Delete all SQL files in path";
            this.ckDeleteAllFiles.UseVisualStyleBackColor = true;
            // 
            // ckCreateProcedure
            // 
            this.ckCreateProcedure.AutoSize = true;
            this.ckCreateProcedure.Location = new System.Drawing.Point(227, 12);
            this.ckCreateProcedure.Name = "ckCreateProcedure";
            this.ckCreateProcedure.Size = new System.Drawing.Size(109, 17);
            this.ckCreateProcedure.TabIndex = 2;
            this.ckCreateProcedure.Text = "Create Procedure";
            this.ckCreateProcedure.UseVisualStyleBackColor = true;
            // 
            // ckAlterProcedure
            // 
            this.ckAlterProcedure.AutoSize = true;
            this.ckAlterProcedure.Checked = true;
            this.ckAlterProcedure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAlterProcedure.Location = new System.Drawing.Point(97, 12);
            this.ckAlterProcedure.Name = "ckAlterProcedure";
            this.ckAlterProcedure.Size = new System.Drawing.Size(99, 17);
            this.ckAlterProcedure.TabIndex = 1;
            this.ckAlterProcedure.Text = "Alter Procedure";
            this.ckAlterProcedure.UseVisualStyleBackColor = true;
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
            this.hsClose.ShortcutNewline = false;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(45, 44);
            this.hsClose.TabIndex = 0;
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
            // hsExportProcedures
            // 
            this.hsExportProcedures.BackColor = System.Drawing.Color.Transparent;
            this.hsExportProcedures.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportProcedures.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportProcedures.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportProcedures.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportProcedures.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportProcedures.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportProcedures.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportProcedures.FlatAppearance.BorderSize = 0;
            this.hsExportProcedures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportProcedures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportProcedures.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportProcedures.Image = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsExportProcedures.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportProcedures.ImageHover = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsExportProcedures.ImageToggleOnSelect = true;
            this.hsExportProcedures.Location = new System.Drawing.Point(520, 59);
            this.hsExportProcedures.Marked = false;
            this.hsExportProcedures.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportProcedures.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportProcedures.MarkedText = "";
            this.hsExportProcedures.MarkMode = false;
            this.hsExportProcedures.Name = "hsExportProcedures";
            this.hsExportProcedures.NonMarkedText = "Export";
            this.hsExportProcedures.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExportProcedures.ShortcutNewline = false;
            this.hsExportProcedures.ShowShortcut = false;
            this.hsExportProcedures.Size = new System.Drawing.Size(114, 52);
            this.hsExportProcedures.TabIndex = 3;
            this.hsExportProcedures.Text = "Export Procedures";
            this.hsExportProcedures.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportProcedures.ToolTipActive = false;
            this.hsExportProcedures.ToolTipAutomaticDelay = 500;
            this.hsExportProcedures.ToolTipAutoPopDelay = 5000;
            this.hsExportProcedures.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportProcedures.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportProcedures.ToolTipFor4ContextMenu = true;
            this.hsExportProcedures.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportProcedures.ToolTipInitialDelay = 500;
            this.hsExportProcedures.ToolTipIsBallon = false;
            this.hsExportProcedures.ToolTipOwnerDraw = false;
            this.hsExportProcedures.ToolTipReshowDelay = 100;
            this.hsExportProcedures.ToolTipShowAlways = false;
            this.hsExportProcedures.ToolTipText = "";
            this.hsExportProcedures.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportProcedures.ToolTipTitle = "";
            this.hsExportProcedures.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportProcedures.UseVisualStyleBackColor = false;
            this.hsExportProcedures.Click += new System.EventHandler(this.hsExportViews_Click);
            // 
            // gbDefaultSQLExportPath
            // 
            this.gbDefaultSQLExportPath.Controls.Add(this.txtSQLExportPath);
            this.gbDefaultSQLExportPath.Controls.Add(this.hsInitialSQLExportPath);
            this.gbDefaultSQLExportPath.Location = new System.Drawing.Point(12, 59);
            this.gbDefaultSQLExportPath.Name = "gbDefaultSQLExportPath";
            this.gbDefaultSQLExportPath.Size = new System.Drawing.Size(486, 44);
            this.gbDefaultSQLExportPath.TabIndex = 7;
            this.gbDefaultSQLExportPath.TabStop = false;
            this.gbDefaultSQLExportPath.Text = "Path for SQL exports";
            // 
            // txtSQLExportPath
            // 
            this.txtSQLExportPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLExportPath.Location = new System.Drawing.Point(3, 16);
            this.txtSQLExportPath.Name = "txtSQLExportPath";
            this.txtSQLExportPath.Size = new System.Drawing.Size(435, 20);
            this.txtSQLExportPath.TabIndex = 1;
            // 
            // hsInitialSQLExportPath
            // 
            this.hsInitialSQLExportPath.BackColor = System.Drawing.Color.Transparent;
            this.hsInitialSQLExportPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInitialSQLExportPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInitialSQLExportPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInitialSQLExportPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInitialSQLExportPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInitialSQLExportPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInitialSQLExportPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsInitialSQLExportPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsInitialSQLExportPath.FlatAppearance.BorderSize = 0;
            this.hsInitialSQLExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInitialSQLExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInitialSQLExportPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInitialSQLExportPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsInitialSQLExportPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsInitialSQLExportPath.ImageToggleOnSelect = true;
            this.hsInitialSQLExportPath.Location = new System.Drawing.Point(438, 16);
            this.hsInitialSQLExportPath.Marked = false;
            this.hsInitialSQLExportPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsInitialSQLExportPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInitialSQLExportPath.MarkedText = "";
            this.hsInitialSQLExportPath.MarkMode = false;
            this.hsInitialSQLExportPath.Name = "hsInitialSQLExportPath";
            this.hsInitialSQLExportPath.NonMarkedText = "";
            this.hsInitialSQLExportPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInitialSQLExportPath.ShortcutNewline = false;
            this.hsInitialSQLExportPath.ShowShortcut = false;
            this.hsInitialSQLExportPath.Size = new System.Drawing.Size(45, 25);
            this.hsInitialSQLExportPath.TabIndex = 3;
            this.hsInitialSQLExportPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsInitialSQLExportPath.ToolTipActive = false;
            this.hsInitialSQLExportPath.ToolTipAutomaticDelay = 500;
            this.hsInitialSQLExportPath.ToolTipAutoPopDelay = 5000;
            this.hsInitialSQLExportPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInitialSQLExportPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInitialSQLExportPath.ToolTipFor4ContextMenu = true;
            this.hsInitialSQLExportPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInitialSQLExportPath.ToolTipInitialDelay = 500;
            this.hsInitialSQLExportPath.ToolTipIsBallon = false;
            this.hsInitialSQLExportPath.ToolTipOwnerDraw = false;
            this.hsInitialSQLExportPath.ToolTipReshowDelay = 100;
            this.hsInitialSQLExportPath.ToolTipShowAlways = false;
            this.hsInitialSQLExportPath.ToolTipText = "";
            this.hsInitialSQLExportPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInitialSQLExportPath.ToolTipTitle = "";
            this.hsInitialSQLExportPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInitialSQLExportPath.UseVisualStyleBackColor = false;
            this.hsInitialSQLExportPath.Click += new System.EventHandler(this.hsInitialSQLExportPath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(641, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // ExportProceduresScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 147);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbDefaultSQLExportPath);
            this.Controls.Add(this.hsExportProcedures);
            this.Controls.Add(this.pnlFormUpper);
            this.Name = "ExportProceduresScriptForm";
            this.Text = "ExportProceduresScriptForm";
            this.Load += new System.EventHandler(this.ExportProceduresScriptForm_Load);
            this.pnlFormUpper.ResumeLayout(false);
            this.pnlFormUpper.PerformLayout();
            this.gbDefaultSQLExportPath.ResumeLayout(false);
            this.gbDefaultSQLExportPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormUpper;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsExportProcedures;
        private System.Windows.Forms.GroupBox gbDefaultSQLExportPath;
        private System.Windows.Forms.TextBox txtSQLExportPath;
        private SeControlsLib.HotSpot hsInitialSQLExportPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.CheckBox ckCreateProcedure;
        private System.Windows.Forms.CheckBox ckAlterProcedure;
        private System.Windows.Forms.CheckBox ckDeleteAllFiles;
    }
}