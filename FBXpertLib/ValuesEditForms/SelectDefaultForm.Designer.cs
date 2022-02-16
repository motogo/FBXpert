namespace FBXpert
{
    partial class SelectDefaultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDefaultForm));
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.cbDefaults = new System.Windows.Forms.ComboBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.hsABORT = new SeControlsLib.HotSpot();
            this.hsOK = new SeControlsLib.HotSpot();
            this.pnlLower.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLower.Controls.Add(this.hsOK);
            this.pnlLower.Controls.Add(this.hsABORT);
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 49);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(252, 43);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.cbDefaults);
            this.pnlCenter.Controls.Add(this.rtbInfo);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(252, 49);
            this.pnlCenter.TabIndex = 2;
            // 
            // cbDefaults
            // 
            this.cbDefaults.FormattingEnabled = true;
            this.cbDefaults.Location = new System.Drawing.Point(12, 12);
            this.cbDefaults.Name = "cbDefaults";
            this.cbDefaults.Size = new System.Drawing.Size(223, 21);
            this.cbDefaults.TabIndex = 1;
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInfo.DetectUrls = false;
            this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(252, 49);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // hsABORT
            // 
            this.hsABORT.BackColor = System.Drawing.Color.Transparent;
            this.hsABORT.BackColorHover = System.Drawing.Color.Transparent;
            this.hsABORT.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsABORT.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsABORT.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsABORT.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsABORT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsABORT.FlatAppearance.BorderSize = 0;
            this.hsABORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsABORT.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsABORT.Image = global::FBXpertLib.Properties.Resources.cross_red_x32;
            this.hsABORT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsABORT.ImageHover = global::FBXpertLib.Properties.Resources.cross_blue_x32;
            this.hsABORT.ImageToggleOnSelect = false;
            this.hsABORT.Location = new System.Drawing.Point(126, 0);
            this.hsABORT.Marked = false;
            this.hsABORT.MarkedColor = System.Drawing.Color.Teal;
            this.hsABORT.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsABORT.MarkedText = "";
            this.hsABORT.MarkMode = false;
            this.hsABORT.Name = "hsABORT";
            this.hsABORT.NonMarkedText = "";
            
            this.hsABORT.Size = new System.Drawing.Size(41, 40);
            this.hsABORT.TabIndex = 4;
            this.hsABORT.ToolTipActive = false;
            this.hsABORT.ToolTipAutomaticDelay = 500;
            this.hsABORT.ToolTipAutoPopDelay = 5000;
            this.hsABORT.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsABORT.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsABORT.ToolTipFor4ContextMenu = true;
            this.hsABORT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsABORT.ToolTipInitialDelay = 500;
            this.hsABORT.ToolTipIsBallon = false;
            this.hsABORT.ToolTipOwnerDraw = false;
            this.hsABORT.ToolTipReshowDelay = 100;
            
            this.hsABORT.ToolTipShowAlways = false;
            this.hsABORT.ToolTipText = "";
            this.hsABORT.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsABORT.ToolTipTitle = "";
            this.hsABORT.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsABORT.UseVisualStyleBackColor = false;
            this.hsABORT.Click += new System.EventHandler(this.hsABORT_Click);
            // 
            // hsOK
            // 
            this.hsOK.BackColor = System.Drawing.Color.Transparent;
            this.hsOK.BackColorHover = System.Drawing.Color.Transparent;
            this.hsOK.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsOK.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsOK.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsOK.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsOK.FlatAppearance.BorderSize = 0;
            this.hsOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsOK.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsOK.Image = global::FBXpertLib.Properties.Resources.ok_gn32x;
            this.hsOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsOK.ImageHover = global::FBXpertLib.Properties.Resources.ok_blue32x;
            this.hsOK.ImageToggleOnSelect = false;
            this.hsOK.Location = new System.Drawing.Point(70, 0);
            this.hsOK.Marked = false;
            this.hsOK.MarkedColor = System.Drawing.Color.Teal;
            this.hsOK.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsOK.MarkedText = "";
            this.hsOK.MarkMode = false;
            this.hsOK.Name = "hsOK";
            this.hsOK.NonMarkedText = "";
            
            this.hsOK.Size = new System.Drawing.Size(41, 40);
            this.hsOK.TabIndex = 5;
            this.hsOK.ToolTipActive = false;
            this.hsOK.ToolTipAutomaticDelay = 500;
            this.hsOK.ToolTipAutoPopDelay = 5000;
            this.hsOK.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsOK.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsOK.ToolTipFor4ContextMenu = true;
            this.hsOK.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsOK.ToolTipInitialDelay = 500;
            this.hsOK.ToolTipIsBallon = false;
            this.hsOK.ToolTipOwnerDraw = false;
            this.hsOK.ToolTipReshowDelay = 100;
            
            this.hsOK.ToolTipShowAlways = false;
            this.hsOK.ToolTipText = "";
            this.hsOK.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsOK.ToolTipTitle = "";
            this.hsOK.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsOK.UseVisualStyleBackColor = false;
            this.hsOK.Click += new System.EventHandler(this.hsOK_Click);
            // 
            // SelectDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 92);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDefaultForm";
            this.Text = "SelectDefaultForm";
            this.pnlLower.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ComboBox cbDefaults;
        private SeControlsLib.HotSpot hsOK;
        private SeControlsLib.HotSpot hsABORT;
    }
}