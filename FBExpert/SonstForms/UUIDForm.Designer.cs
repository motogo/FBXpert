namespace FBXpert
{
    partial class UUIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UUIDForm));
            this.gbUUID = new System.Windows.Forms.GroupBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsCreate = new SeControlsLib.HotSpot();
            this.gbUUID.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUUID
            // 
            this.gbUUID.Controls.Add(this.txtUUID);
            this.gbUUID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUUID.Location = new System.Drawing.Point(120, 0);
            this.gbUUID.Name = "gbUUID";
            this.gbUUID.Size = new System.Drawing.Size(426, 87);
            this.gbUUID.TabIndex = 0;
            this.gbUUID.TabStop = false;
            this.gbUUID.Text = "GUID";
            // 
            // txtUUID
            // 
            this.txtUUID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUUID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUUID.Location = new System.Drawing.Point(3, 57);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(420, 27);
            this.txtUUID.TabIndex = 0;
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
            this.hsClose.Margin = new System.Windows.Forms.Padding(4);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            
            this.hsClose.Size = new System.Drawing.Size(60, 87);
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
            // hsCreate
            // 
            this.hsCreate.BackColor = System.Drawing.Color.Transparent;
            this.hsCreate.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCreate.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCreate.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCreate.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCreate.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreate.FlatAppearance.BorderSize = 0;
            this.hsCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreate.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreate.Image = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsCreate.ImageHover = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsCreate.ImageToggleOnSelect = true;
            this.hsCreate.Location = new System.Drawing.Point(60, 0);
            this.hsCreate.Margin = new System.Windows.Forms.Padding(4);
            this.hsCreate.Marked = false;
            this.hsCreate.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreate.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreate.MarkedText = "";
            this.hsCreate.MarkMode = false;
            this.hsCreate.Name = "hsCreate";
            this.hsCreate.NonMarkedText = "";
            
            this.hsCreate.Size = new System.Drawing.Size(60, 87);
            this.hsCreate.TabIndex = 3;
            this.hsCreate.ToolTipActive = false;
            this.hsCreate.ToolTipAutomaticDelay = 500;
            this.hsCreate.ToolTipAutoPopDelay = 5000;
            this.hsCreate.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCreate.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCreate.ToolTipFor4ContextMenu = true;
            this.hsCreate.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCreate.ToolTipInitialDelay = 500;
            this.hsCreate.ToolTipIsBallon = false;
            this.hsCreate.ToolTipOwnerDraw = false;
            this.hsCreate.ToolTipReshowDelay = 100;
            
            this.hsCreate.ToolTipShowAlways = false;
            this.hsCreate.ToolTipText = "";
            this.hsCreate.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCreate.ToolTipTitle = "";
            this.hsCreate.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCreate.UseVisualStyleBackColor = false;
            this.hsCreate.Click += new System.EventHandler(this.hsCreate_Click);
            // 
            // UUIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 87);
            this.ControlBox = false;
            this.Controls.Add(this.gbUUID);
            this.Controls.Add(this.hsCreate);
            this.Controls.Add(this.hsClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UUIDForm";
            this.Text = "Create UUID";
            this.Load += new System.EventHandler(this.UUIDForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UUIDForm_MouseMove);
            this.gbUUID.ResumeLayout(false);
            this.gbUUID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUUID;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsCreate;
        private System.Windows.Forms.TextBox txtUUID;
    }
}