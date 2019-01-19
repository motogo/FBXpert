namespace SQLView
{
    partial class OpenFileForm
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
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.btnPrevPreview = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnLastPreview = new System.Windows.Forms.Button();
            this.btnNextPreview = new System.Windows.Forms.Button();
            this.cbBin = new System.Windows.Forms.CheckBox();
            this.cbWordWrap = new System.Windows.Forms.CheckBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.rtfPreview = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.gbFiles.SuspendLayout();
            this.gbPreview.SuspendLayout();
            this.gbPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiles
            // 
            this.gbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiles.Controls.Add(this.gbPreview);
            this.gbFiles.Controls.Add(this.cbBin);
            this.gbFiles.Controls.Add(this.cbWordWrap);
            this.gbFiles.Controls.Add(this.btnAbort);
            this.gbFiles.Controls.Add(this.rtfPreview);
            this.gbFiles.Controls.Add(this.btnOK);
            this.gbFiles.Controls.Add(this.fileListBox1);
            this.gbFiles.Location = new System.Drawing.Point(6, 196);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(795, 265);
            this.gbFiles.TabIndex = 0;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "groupBox1";
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.btnPrevPreview);
            this.gbPreview.Controls.Add(this.btnPreview);
            this.gbPreview.Controls.Add(this.btnLastPreview);
            this.gbPreview.Controls.Add(this.btnNextPreview);
            this.gbPreview.Location = new System.Drawing.Point(262, 16);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(55, 191);
            this.gbPreview.TabIndex = 8;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "View";
            // 
            // btnPrevPreview
            // 
            this.btnPrevPreview.Image = global::FBXpert.Properties.Resources.go_up;
            this.btnPrevPreview.Location = new System.Drawing.Point(6, 110);
            this.btnPrevPreview.Name = "btnPrevPreview";
            this.btnPrevPreview.Size = new System.Drawing.Size(42, 39);
            this.btnPrevPreview.TabIndex = 8;
            this.btnPrevPreview.UseVisualStyleBackColor = true;
            this.btnPrevPreview.Click += new System.EventHandler(this.btnPrevPreview_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Image = global::FBXpert.Properties.Resources.go_top;
            this.btnPreview.Location = new System.Drawing.Point(6, 19);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(42, 39);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnLastPreview
            // 
            this.btnLastPreview.Image = global::FBXpert.Properties.Resources.go_bottom;
            this.btnLastPreview.Location = new System.Drawing.Point(6, 155);
            this.btnLastPreview.Name = "btnLastPreview";
            this.btnLastPreview.Size = new System.Drawing.Size(42, 40);
            this.btnLastPreview.TabIndex = 9;
            this.btnLastPreview.UseVisualStyleBackColor = true;
            this.btnLastPreview.Click += new System.EventHandler(this.btnLastPreview_Click);
            // 
            // btnNextPreview
            // 
            this.btnNextPreview.Image = global::FBXpert.Properties.Resources.go_down_green;
            this.btnNextPreview.Location = new System.Drawing.Point(6, 64);
            this.btnNextPreview.Name = "btnNextPreview";
            this.btnNextPreview.Size = new System.Drawing.Size(42, 40);
            this.btnNextPreview.TabIndex = 7;
            this.btnNextPreview.UseVisualStyleBackColor = true;
            this.btnNextPreview.Click += new System.EventHandler(this.btnNextPreview_Click);
            // 
            // cbBin
            // 
            this.cbBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBin.AutoSize = true;
            this.cbBin.Location = new System.Drawing.Point(471, 237);
            this.cbBin.Name = "cbBin";
            this.cbBin.Size = new System.Drawing.Size(49, 17);
            this.cbBin.TabIndex = 6;
            this.cbBin.Text = "binär";
            this.cbBin.UseVisualStyleBackColor = true;
            this.cbBin.CheckedChanged += new System.EventHandler(this.cbBin_CheckedChanged);
            // 
            // cbWordWrap
            // 
            this.cbWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWordWrap.AutoSize = true;
            this.cbWordWrap.Location = new System.Drawing.Point(334, 237);
            this.cbWordWrap.Name = "cbWordWrap";
            this.cbWordWrap.Size = new System.Drawing.Size(111, 17);
            this.cbWordWrap.TabIndex = 5;
            this.cbWordWrap.Text = "Zeilen umbrechen";
            this.cbWordWrap.UseVisualStyleBackColor = true;
            this.cbWordWrap.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(253, 237);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Abbruch";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // rtfPreview
            // 
            this.rtfPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfPreview.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfPreview.Location = new System.Drawing.Point(334, 16);
            this.rtfPreview.Name = "rtfPreview";
            this.rtfPreview.Size = new System.Drawing.Size(458, 220);
            this.rtfPreview.TabIndex = 1;
            this.rtfPreview.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(253, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fileListBox1
            // 
            this.fileListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileListBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(3, 16);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.SQL";
            this.fileListBox1.Size = new System.Drawing.Size(244, 238);
            this.fileListBox1.TabIndex = 0;
            // 
            // dirListBox1
            // 
            this.dirListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirListBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(3, 16);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(418, 157);
            this.dirListBox1.TabIndex = 1;
            this.dirListBox1.Change += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged_1);
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.dirListBox1);
            this.gbPath.Location = new System.Drawing.Point(3, 12);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(424, 176);
            this.gbPath.TabIndex = 5;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "groupBox2";
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 473);
            this.Controls.Add(this.gbPath);
            this.Controls.Add(this.gbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OpenFileForm";
            this.Text = "OpeFileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenFileForm_FormClosing);
            this.Load += new System.EventHandler(this.OpenFileForm_Load);
            this.gbFiles.ResumeLayout(false);
            this.gbFiles.PerformLayout();
            this.gbPreview.ResumeLayout(false);
            this.gbPath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.RichTextBox rtfPreview;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.CheckBox cbWordWrap;
        private System.Windows.Forms.CheckBox cbBin;
        private System.Windows.Forms.Button btnNextPreview;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Button btnPrevPreview;
        private System.Windows.Forms.Button btnLastPreview;
    }
}