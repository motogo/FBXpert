namespace FBXpert
{
    partial class DateTimeForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hsCancel = new SeControlsLib.HotSpot();
            this.hsOK = new SeControlsLib.HotSpot();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCenter.Controls.Add(this.dateTime);
            this.pnlCenter.Controls.Add(this.dateTimePicker1);
            this.pnlCenter.Controls.Add(this.hsCancel);
            this.pnlCenter.Controls.Add(this.hsOK);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(304, 122);
            this.pnlCenter.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hsCancel
            // 
            this.hsCancel.BackColor = System.Drawing.Color.Transparent;
            this.hsCancel.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCancel.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCancel.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCancel.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCancel.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCancel.FlatAppearance.BorderSize = 0;
            this.hsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCancel.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancel.Image = global::FBXpertLib.Properties.Resources.cross_red_x32;
            this.hsCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsCancel.ImageHover = global::FBXpertLib.Properties.Resources.cross_blue_x32;
            this.hsCancel.ImageToggleOnSelect = false;
            this.hsCancel.Location = new System.Drawing.Point(159, 67);
            this.hsCancel.Marked = false;
            this.hsCancel.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancel.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancel.MarkedText = "";
            this.hsCancel.MarkMode = false;
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.NonMarkedText = "";
            
            this.hsCancel.Size = new System.Drawing.Size(41, 44);
            this.hsCancel.TabIndex = 23;
            this.hsCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsCancel.ToolTipActive = false;
            this.hsCancel.ToolTipAutomaticDelay = 500;
            this.hsCancel.ToolTipAutoPopDelay = 5000;
            this.hsCancel.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCancel.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCancel.ToolTipFor4ContextMenu = true;
            this.hsCancel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCancel.ToolTipInitialDelay = 500;
            this.hsCancel.ToolTipIsBallon = false;
            this.hsCancel.ToolTipOwnerDraw = false;
            this.hsCancel.ToolTipReshowDelay = 100;
            
            this.hsCancel.ToolTipShowAlways = false;
            this.hsCancel.ToolTipText = "";
            this.hsCancel.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCancel.ToolTipTitle = "";
            this.hsCancel.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCancel.UseVisualStyleBackColor = false;
            this.hsCancel.Click += new System.EventHandler(this.hsCancel_Click);
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
            this.hsOK.Location = new System.Drawing.Point(88, 67);
            this.hsOK.Marked = false;
            this.hsOK.MarkedColor = System.Drawing.Color.Teal;
            this.hsOK.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsOK.MarkedText = "";
            this.hsOK.MarkMode = false;
            this.hsOK.Name = "hsOK";
            this.hsOK.NonMarkedText = "";
            
            this.hsOK.Size = new System.Drawing.Size(47, 44);
            this.hsOK.TabIndex = 22;
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
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(216, 10);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(72, 20);
            this.dateTime.TabIndex = 25;
            // 
            // DateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 122);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DateTimeForm";
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private SeControlsLib.HotSpot hsCancel;
        private SeControlsLib.HotSpot hsOK;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}