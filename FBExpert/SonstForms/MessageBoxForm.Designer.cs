namespace FBXpert
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 128);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(715, 55);
            this.pnlButtons.TabIndex = 2;
            // 
            // pnlUpper
            // 
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(715, 35);
            this.pnlUpper.TabIndex = 5;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.Info;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(0, 35);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(626, 93);
            this.rtbText.TabIndex = 6;
            this.rtbText.Text = "";
            // 
            // pbInfo
            // 
            this.pbInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbInfo.Location = new System.Drawing.Point(626, 35);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(89, 93);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbInfo.TabIndex = 7;
            this.pbInfo.TabStop = false;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 183);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoxForm";
            this.Text = "MessageBoxForm";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.PictureBox pbInfo;
    }
}