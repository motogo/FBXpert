namespace FBXpert.SonstForms
{
    partial class ExportViewsSQLForm
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
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsExportViews = new SeControlsLib.HotSpot();
            this.gbDefaultSQLExportPath = new System.Windows.Forms.GroupBox();
            this.txtSQLExportPath = new System.Windows.Forms.TextBox();
            this.hsInitialSQLExportPath = new SeControlsLib.HotSpot();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.ckAlterView = new System.Windows.Forms.CheckBox();
            this.ckCreateView = new System.Windows.Forms.CheckBox();
            this.ckDeleteAllFiles = new System.Windows.Forms.CheckBox();
            this.pnlUpper.SuspendLayout();
            this.gbDefaultSQLExportPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.ckDeleteAllFiles);
            this.pnlUpper.Controls.Add(this.ckCreateView);
            this.pnlUpper.Controls.Add(this.ckAlterView);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(641, 44);
            this.pnlUpper.TabIndex = 2;
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
            // hsExportViews
            // 
            this.hsExportViews.BackColor = System.Drawing.Color.Transparent;
            this.hsExportViews.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExportViews.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExportViews.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExportViews.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExportViews.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExportViews.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExportViews.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsExportViews.FlatAppearance.BorderSize = 0;
            this.hsExportViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExportViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExportViews.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExportViews.Image = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsExportViews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExportViews.ImageHover = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsExportViews.ImageToggleOnSelect = true;
            this.hsExportViews.Location = new System.Drawing.Point(520, 59);
            this.hsExportViews.Marked = false;
            this.hsExportViews.MarkedColor = System.Drawing.Color.Teal;
            this.hsExportViews.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExportViews.MarkedText = "";
            this.hsExportViews.MarkMode = false;
            this.hsExportViews.Name = "hsExportViews";
            this.hsExportViews.NonMarkedText = "Export";
            this.hsExportViews.Size = new System.Drawing.Size(114, 52);
            this.hsExportViews.TabIndex = 3;
            this.hsExportViews.Text = "Export Views";
            this.hsExportViews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExportViews.ToolTipActive = false;
            this.hsExportViews.ToolTipAutomaticDelay = 500;
            this.hsExportViews.ToolTipAutoPopDelay = 5000;
            this.hsExportViews.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExportViews.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExportViews.ToolTipFor4ContextMenu = true;
            this.hsExportViews.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExportViews.ToolTipInitialDelay = 500;
            this.hsExportViews.ToolTipIsBallon = false;
            this.hsExportViews.ToolTipOwnerDraw = false;
            this.hsExportViews.ToolTipReshowDelay = 100;
            this.hsExportViews.ToolTipShowAlways = false;
            this.hsExportViews.ToolTipText = "";
            this.hsExportViews.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExportViews.ToolTipTitle = "";
            this.hsExportViews.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExportViews.UseVisualStyleBackColor = false;
            this.hsExportViews.Click += new System.EventHandler(this.hsExportViews_Click);
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
            // ckAlterView
            // 
            this.ckAlterView.AutoSize = true;
            this.ckAlterView.Checked = true;
            this.ckAlterView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAlterView.Location = new System.Drawing.Point(97, 12);
            this.ckAlterView.Name = "ckAlterView";
            this.ckAlterView.Size = new System.Drawing.Size(73, 17);
            this.ckAlterView.TabIndex = 1;
            this.ckAlterView.Text = "Alter View";
            this.ckAlterView.UseVisualStyleBackColor = true;
            // 
            // ckCreateView
            // 
            this.ckCreateView.AutoSize = true;
            this.ckCreateView.Location = new System.Drawing.Point(284, 14);
            this.ckCreateView.Name = "ckCreateView";
            this.ckCreateView.Size = new System.Drawing.Size(73, 17);
            this.ckCreateView.TabIndex = 2;
            this.ckCreateView.Text = "Alter View";
            this.ckCreateView.UseVisualStyleBackColor = true;
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
            // ExportViewsSQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 147);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbDefaultSQLExportPath);
            this.Controls.Add(this.hsExportViews);
            this.Controls.Add(this.pnlUpper);
            this.Name = "ExportViewsSQLForm";
            this.Text = "ExportViewsSQLForm";
            this.Load += new System.EventHandler(this.ExportViewsSQLForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.gbDefaultSQLExportPath.ResumeLayout(false);
            this.gbDefaultSQLExportPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsExportViews;
        private System.Windows.Forms.GroupBox gbDefaultSQLExportPath;
        private System.Windows.Forms.TextBox txtSQLExportPath;
        private SeControlsLib.HotSpot hsInitialSQLExportPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.CheckBox ckCreateView;
        private System.Windows.Forms.CheckBox ckAlterView;
        private System.Windows.Forms.CheckBox ckDeleteAllFiles;
    }
}