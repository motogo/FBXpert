namespace FBXpert.KonfigurationForms
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    partial class XMLTreeForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel pnlFormUpper;
        private System.Windows.Forms.Panel pnl_center;


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer erzeugter Code
        /// <summary>
        /// Erforderliche Methode zur Unterstützung des Designers -
        /// ändern Sie die Methode nicht mit dem Quelltext-Editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.pnlFormUpper = new System.Windows.Forms.Panel();
            this.hsReload = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.xmlEdit = new XMLSimlpeEdit.XMLEditSimpleUserControl();
            this.pnlFormUpper.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormUpper
            // 
            this.pnlFormUpper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFormUpper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormUpper.Controls.Add(this.hsReload);
            this.pnlFormUpper.Controls.Add(this.hsClose);
            this.pnlFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUpper.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUpper.Name = "pnlFormUpper";
            this.pnlFormUpper.Size = new System.Drawing.Size(802, 42);
            this.pnlFormUpper.TabIndex = 0;
            // 
            // hsReload
            // 
            this.hsReload.BackColor = System.Drawing.Color.Transparent;
            this.hsReload.BackColorHover = System.Drawing.Color.Transparent;
            this.hsReload.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsReload.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsReload.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsReload.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsReload.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsReload.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsReload.FlatAppearance.BorderSize = 0;
            this.hsReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsReload.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsReload.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsReload.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsReload.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsReload.ImageToggleOnSelect = false;
            this.hsReload.Location = new System.Drawing.Point(45, 0);
            this.hsReload.Marked = false;
            this.hsReload.MarkedColor = System.Drawing.Color.Teal;
            this.hsReload.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsReload.MarkedText = "";
            this.hsReload.MarkMode = false;
            this.hsReload.Name = "hsReload";
            this.hsReload.NonMarkedText = "";
            this.hsReload.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsReload.ShortcutNewline = false;
            this.hsReload.ShowShortcut = false;
            this.hsReload.Size = new System.Drawing.Size(45, 40);
            this.hsReload.TabIndex = 89;
            this.hsReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsReload.ToolTipActive = false;
            this.hsReload.ToolTipAutomaticDelay = 500;
            this.hsReload.ToolTipAutoPopDelay = 5000;
            this.hsReload.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsReload.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsReload.ToolTipFor4ContextMenu = true;
            this.hsReload.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsReload.ToolTipInitialDelay = 500;
            this.hsReload.ToolTipIsBallon = false;
            this.hsReload.ToolTipOwnerDraw = false;
            this.hsReload.ToolTipReshowDelay = 100;
            this.hsReload.ToolTipShowAlways = false;
            this.hsReload.ToolTipText = "Formular schließen";
            this.hsReload.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsReload.ToolTipTitle = "";
            this.hsReload.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsReload.UseVisualStyleBackColor = true;
            this.hsReload.Click += new System.EventHandler(this.hsReload_Click);
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
            this.hsClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsClose.Image = global::FBXpert.Properties.Resources.go_previous22x;
            this.hsClose.ImageHover = global::FBXpert.Properties.Resources.go_previous22x;
            this.hsClose.ImageToggleOnSelect = false;
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
            this.hsClose.Size = new System.Drawing.Size(45, 40);
            this.hsClose.TabIndex = 88;
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
            this.hsClose.ToolTipText = "Formular schließen";
            this.hsClose.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsClose.ToolTipTitle = "";
            this.hsClose.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClose.UseVisualStyleBackColor = true;
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click);
            // 
            // pnl_center
            // 
            this.pnl_center.BackColor = System.Drawing.Color.Wheat;
            this.pnl_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_center.Controls.Add(this.xmlEdit);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(0, 42);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(802, 671);
            this.pnl_center.TabIndex = 2;
            // 
            // xmlEdit
            // 
            this.xmlEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xmlEdit.Caption = "Input File";
            this.xmlEdit.DefaultExt = "xml";
            this.xmlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlEdit.EditorFont = new System.Drawing.Font("Courier New", 10F);
            this.xmlEdit.Filter = "XML files|*.xml|Schema files|*.xds|All files|*.*";
            this.xmlEdit.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlEdit.KeyName = "XmlFile";
            this.xmlEdit.LastXmlDirKey = "LastXmlDir";
            this.xmlEdit.Location = new System.Drawing.Point(0, 0);
            this.xmlEdit.Margin = new System.Windows.Forms.Padding(0);
            this.xmlEdit.MinimumSize = new System.Drawing.Size(200, 100);
            this.xmlEdit.Name = "xmlEdit";
            this.xmlEdit.Size = new System.Drawing.Size(800, 669);
            this.xmlEdit.TabIndex = 0;
            // 
            // XMLTreeForm
            // 
            this.ClientSize = new System.Drawing.Size(802, 713);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnlFormUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "XMLTreeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML-Tree";
            this.Load += new System.EventHandler(this.XMLTreeForm_Load);
            this.pnlFormUpper.ResumeLayout(false);
            this.pnl_center.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        //private IContainer components;
        private System.ComponentModel.Container components = null;
        private XMLSimlpeEdit.XMLEditSimpleUserControl xmlEdit;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsReload;
    }
}
