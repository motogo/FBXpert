namespace FBXpert
{
    partial class DatabaseStatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseStatisticsForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDatabases = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlStatistik = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pnlInfoUpper = new System.Windows.Forms.Panel();
            this.tabPageGStat = new System.Windows.Forms.TabPage();
            this.pnlGStatUpper = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.fctTableStatistics = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlStatistik.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.pnlInfoUpper.SuspendLayout();
            this.tabPageGStat.SuspendLayout();
            this.pnlGStatUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctTableStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(715, 46);
            this.pnlUpper.TabIndex = 0;
            // 
            // hsRefreshDatabases
            // 
            this.hsRefreshDatabases.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDatabases.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDatabases.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDatabases.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshDatabases.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshDatabases.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshDatabases.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshDatabases.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRefreshDatabases.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshDatabases.FlatAppearance.BorderSize = 0;
            this.hsRefreshDatabases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshDatabases.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDatabases.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDatabases.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDatabases.ImageToggleOnSelect = true;
            this.hsRefreshDatabases.Location = new System.Drawing.Point(0, 0);
            this.hsRefreshDatabases.Marked = false;
            this.hsRefreshDatabases.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDatabases.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDatabases.MarkedText = "";
            this.hsRefreshDatabases.MarkMode = false;
            this.hsRefreshDatabases.Name = "hsRefreshDatabases";
            this.hsRefreshDatabases.NonMarkedText = "";
            this.hsRefreshDatabases.Size = new System.Drawing.Size(37, 42);
            this.hsRefreshDatabases.TabIndex = 5;
            this.hsRefreshDatabases.ToolTipActive = false;
            this.hsRefreshDatabases.ToolTipAutomaticDelay = 500;
            this.hsRefreshDatabases.ToolTipAutoPopDelay = 5000;
            this.hsRefreshDatabases.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshDatabases.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshDatabases.ToolTipFor4ContextMenu = true;
            this.hsRefreshDatabases.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshDatabases.ToolTipInitialDelay = 500;
            this.hsRefreshDatabases.ToolTipIsBallon = false;
            this.hsRefreshDatabases.ToolTipOwnerDraw = false;
            this.hsRefreshDatabases.ToolTipReshowDelay = 100;
            
            this.hsRefreshDatabases.ToolTipShowAlways = false;
            this.hsRefreshDatabases.ToolTipText = "";
            this.hsRefreshDatabases.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDatabases.ToolTipTitle = "";
            this.hsRefreshDatabases.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDatabases.UseVisualStyleBackColor = false;
            this.hsRefreshDatabases.Click += new System.EventHandler(this.hsRefreshDatabases_Click);
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
            this.hsClose.Size = new System.Drawing.Size(45, 46);
            this.hsClose.TabIndex = 2;
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
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 356);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(715, 19);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlStatistik);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 46);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(715, 310);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlStatistik
            // 
            this.tabControlStatistik.Controls.Add(this.tabPageInfo);
            this.tabControlStatistik.Controls.Add(this.tabPageGStat);
            this.tabControlStatistik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStatistik.Location = new System.Drawing.Point(0, 0);
            this.tabControlStatistik.Name = "tabControlStatistik";
            this.tabControlStatistik.SelectedIndex = 0;
            this.tabControlStatistik.Size = new System.Drawing.Size(715, 310);
            this.tabControlStatistik.TabIndex = 1;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.rtbInfo);
            this.tabPageInfo.Controls.Add(this.pnlInfoUpper);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(707, 284);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInfo.DetectUrls = false;
            this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfo.Location = new System.Drawing.Point(3, 45);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(701, 236);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            this.rtbInfo.WordWrap = false;
            // 
            // pnlInfoUpper
            // 
            this.pnlInfoUpper.BackColor = System.Drawing.Color.DarkGray;
            this.pnlInfoUpper.Controls.Add(this.hsRefreshDatabases);
            this.pnlInfoUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlInfoUpper.Name = "pnlInfoUpper";
            this.pnlInfoUpper.Size = new System.Drawing.Size(701, 42);
            this.pnlInfoUpper.TabIndex = 1;
            // 
            // tabPageGStat
            // 
            this.tabPageGStat.Controls.Add(this.fctTableStatistics);
            this.tabPageGStat.Controls.Add(this.pnlGStatUpper);
            this.tabPageGStat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageGStat.Location = new System.Drawing.Point(4, 22);
            this.tabPageGStat.Name = "tabPageGStat";
            this.tabPageGStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGStat.Size = new System.Drawing.Size(707, 284);
            this.tabPageGStat.TabIndex = 0;
            this.tabPageGStat.Text = "GStat-Functions";
            this.tabPageGStat.UseVisualStyleBackColor = true;
            // 
            // pnlGStatUpper
            // 
            this.pnlGStatUpper.BackColor = System.Drawing.Color.DarkGray;
            this.pnlGStatUpper.Controls.Add(this.hotSpot1);
            this.pnlGStatUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGStatUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlGStatUpper.Name = "pnlGStatUpper";
            this.pnlGStatUpper.Size = new System.Drawing.Size(701, 42);
            this.pnlGStatUpper.TabIndex = 2;
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
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(0, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Size = new System.Drawing.Size(37, 42);
            this.hotSpot1.TabIndex = 6;
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
            // fctTableStatistics
            // 
            this.fctTableStatistics.AutoCompleteBracketsList = new char[] {
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
            this.fctTableStatistics.AutoIndentCharsPatterns = "";
            this.fctTableStatistics.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctTableStatistics.BackBrush = null;
            this.fctTableStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctTableStatistics.CharHeight = 14;
            this.fctTableStatistics.CharWidth = 7;
            this.fctTableStatistics.CommentPrefix = "--";
            this.fctTableStatistics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctTableStatistics.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctTableStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctTableStatistics.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctTableStatistics.IsReplaceMode = false;
            this.fctTableStatistics.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctTableStatistics.LeftBracket = '(';
            this.fctTableStatistics.Location = new System.Drawing.Point(3, 45);
            this.fctTableStatistics.Name = "fctTableStatistics";
            this.fctTableStatistics.Paddings = new System.Windows.Forms.Padding(0);
            this.fctTableStatistics.ReadOnly = true;
            this.fctTableStatistics.RightBracket = ')';
            this.fctTableStatistics.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctTableStatistics.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctTableStatistics.ServiceColors")));
            this.fctTableStatistics.Size = new System.Drawing.Size(701, 236);
            this.fctTableStatistics.TabIndex = 22;
            this.fctTableStatistics.WordWrap = true;
            this.fctTableStatistics.Zoom = 100;
            // 
            // DatabaseStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 375);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseStatisticsForm";
            this.Text = "DatabaseStatisticsForm";
            this.Load += new System.EventHandler(this.DatabaseStatisticsForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.tabControlStatistik.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.pnlInfoUpper.ResumeLayout(false);
            this.tabPageGStat.ResumeLayout(false);
            this.pnlGStatUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctTableStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefreshDatabases;
        private System.Windows.Forms.TabControl tabControlStatistik;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.Panel pnlInfoUpper;
        private System.Windows.Forms.TabPage tabPageGStat;
        private System.Windows.Forms.Panel pnlGStatUpper;
        private SeControlsLib.HotSpot hotSpot1;
        private FastColoredTextBoxNS.FastColoredTextBox fctTableStatistics;
    }
}