namespace FBXpert.SonstForms
{
    partial class Form1
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
            this.cmsNotNulls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditNotNull = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteNotNull = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotNulls.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsNotNulls
            // 
            this.cmsNotNulls.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNotNulls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditNotNull,
            this.tsmiDeleteNotNull});
            this.cmsNotNulls.Name = "contextMenuStrip1";
            this.cmsNotNulls.Size = new System.Drawing.Size(209, 78);
            // 
            // tsmiEditNotNull
            // 
            this.tsmiEditNotNull.Image = global::FBXpert.Properties.Resources.format_text_direction_x22;
            this.tsmiEditNotNull.Name = "tsmiEditNotNull";
            this.tsmiEditNotNull.Size = new System.Drawing.Size(208, 26);
            this.tsmiEditNotNull.Text = "Edit Not Null constraint";
            // 
            // tsmiDeleteNotNull
            // 
            this.tsmiDeleteNotNull.Image = global::FBXpert.Properties.Resources.cross_red_x20;
            this.tsmiDeleteNotNull.Name = "tsmiDeleteNotNull";
            this.tsmiDeleteNotNull.Size = new System.Drawing.Size(208, 26);
            this.tsmiDeleteNotNull.Text = "Drop Not Null constraint";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsNotNulls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsNotNulls;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditNotNull;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteNotNull;
    }
}