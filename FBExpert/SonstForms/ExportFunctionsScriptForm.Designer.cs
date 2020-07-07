namespace FBXpert.SonstForms
{
    partial class ExportFunctionsScriptForm
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
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.ckDeleteAllFiles = new System.Windows.Forms.CheckBox();
            this.ckCreateFunction = new System.Windows.Forms.CheckBox();
            this.ckAlterFunction = new System.Windows.Forms.CheckBox();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsExportFunctions = new SeControlsLib.HotSpot();
            this.gbDefaultSQLExportPath = new System.Windows.Forms.GroupBox();
            this.txtSQLExportPath = new System.Windows.Forms.TextBox();
            this.hsInitialSQLExportPath = new SeControlsLib.HotSpot();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlUpper.SuspendLayout();
            this.gbDefaultSQLExportPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.ckDeleteAllFiles);
            this.pnlUpper.Controls.Add(this.ckCreateFunction);
            this.pnlUpper.Controls.Add(this.ckAlterFunction);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(641, 44);
            this.pnlUpper.TabIndex = 2;
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
            // ckCreateFunction
            // 
            this.ckCreateFunction.AutoSize = true;
            this.ckCreateFunction.Location = new System.Drawing.Point(227, 12);
            this.ckCreateFunction.Name = "ckCreateFunction";
            this.ckCreateFunction.Size = new System.Drawing.Size(109, 17);
            this.ckCreateFunction.TabIndex = 2;
            this.ckCreateFunction.Text = "Create Function";
            this.ckCreateFunction.UseVisualStyleBackColor = true;
            // 
            // ckAlterFunction
            // 
            this.ckAlterFunction.AutoSize = true;
            this.ckAlterFunction.Checked = true;
            this.ckAlterFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAlterFunction.Location = new System.Drawing.Point(97, 12);
            this.ckAlterFunction.Name = "ckAlterFunction";
            this.ckAlterFunction.Size = new System.Drawing.Size(99, 17);
            this.ckAlterFunction.TabIndex = 1;
            this.ckAlterFunction.Text = "Alter Function";
            this.ckAlterFunction.UseVisualStyleBackColor = true;
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
            // hsExportFunctions
            // 
            this.hsExportFunctions.BackColor = System.Drawing.Color.Transparent;
            this.hsExportFunctions.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportFunctions.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportFunctions.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportFunctions.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportFunctions.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportFunctions.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportFunctions.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportFunctions.FlatAppearance.BorderSize = 0;
            this.hsExportFunctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportFunctions.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportFunctions.Image = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsExportFunctions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportFunctions.ImageHover = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsExportFunctions.ImageToggleOnSelect = true;
            this.hsExportFunctions.Location = new System.Drawing.Point(520, 59);
            this.hsExportFunctions.Marked = false;
            this.hsExportFunctions.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportFunctions.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportFunctions.MarkedText = "";
            this.hsExportFunctions.MarkMode = false;
            this.hsExportFunctions.Name = "hsExportFunctions";
            this.hsExportFunctions.NonMarkedText = "Export";
            this.hsExportFunctions.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExportFunctions.ShowShortcut = false;
            this.hsExportFunctions.Size = new System.Drawing.Size(114, 52);
            this.hsExportFunctions.TabIndex = 3;
            this.hsExportFunctions.Text = "Export Functions";
            this.hsExportFunctions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportFunctions.ToolTipActive = false;
            this.hsExportFunctions.ToolTipAutomaticDelay = 500;
            this.hsExportFunctions.ToolTipAutoPopDelay = 5000;
            this.hsExportFunctions.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportFunctions.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportFunctions.ToolTipFor4ContextMenu = true;
            this.hsExportFunctions.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportFunctions.ToolTipInitialDelay = 500;
            this.hsExportFunctions.ToolTipIsBallon = false;
            this.hsExportFunctions.ToolTipOwnerDraw = false;
            this.hsExportFunctions.ToolTipReshowDelay = 100;
            this.hsExportFunctions.ToolTipShowAlways = false;
            this.hsExportFunctions.ToolTipText = "";
            this.hsExportFunctions.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportFunctions.ToolTipTitle = "";
            this.hsExportFunctions.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportFunctions.UseVisualStyleBackColor = false;
            this.hsExportFunctions.Click += new System.EventHandler(this.hsExportViews_Click);
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
            // ExportFunctionsScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 147);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbDefaultSQLExportPath);
            this.Controls.Add(this.hsExportFunctions);
            this.Controls.Add(this.pnlUpper);
            this.Name = "ExportFunctionsScriptForm";
            this.Text = "ExportFunctionsScriptForm";
            this.Load += new System.EventHandler(this.ExportFunctionsScriptForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.gbDefaultSQLExportPath.ResumeLayout(false);
            this.gbDefaultSQLExportPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsExportFunctions;
        private System.Windows.Forms.GroupBox gbDefaultSQLExportPath;
        private System.Windows.Forms.TextBox txtSQLExportPath;
        private SeControlsLib.HotSpot hsInitialSQLExportPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.CheckBox ckCreateFunction;
        private System.Windows.Forms.CheckBox ckAlterFunction;
        private System.Windows.Forms.CheckBox ckDeleteAllFiles;
    }
}