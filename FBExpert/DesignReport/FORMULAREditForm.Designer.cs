using BasicForms;
using System.Windows.Forms;

namespace FBXpert
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    partial class FORMULAREditForm : BasicEditFormClass
	{
		/// <summary>
		/// Erforderliche Designervariable
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel pnl_upper;
		private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_center;

        /// <summary>
		/// Ressourcen nach der Verwendung bereinigen
		/// </summary>
		protected override void Dispose (bool disposing)
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
            this.pnl_upper = new System.Windows.Forms.Panel();
            this.lblCAPTIOIN = new System.Windows.Forms.Label();
            this.hsFastReport = new SeControlsLib.HotSpot();
            this.hsDesignNew = new SeControlsLib.HotSpot();
            this.hsPrint = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsHELP = new SeControlsLib.HotSpot();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.dbDataSchema = new System.Windows.Forms.GroupBox();
            this.hsEditXSDData = new SeControlsLib.HotSpot();
            this.txtXSDSchemaFile = new System.Windows.Forms.TextBox();
            this.hsLoadSchemaFile = new SeControlsLib.HotSpot();
            this.gbXMLData = new System.Windows.Forms.GroupBox();
            this.hsEditXMLData = new SeControlsLib.HotSpot();
            this.txtXMLDataFile = new System.Windows.Forms.TextBox();
            this.hsLoadXMLDataFile = new SeControlsLib.HotSpot();
            this.gpBEZ = new System.Windows.Forms.GroupBox();
            this.hsXMLReport = new SeControlsLib.HotSpot();
            this.txtREPORTFILE = new System.Windows.Forms.TextBox();
            this.hsReportFileWahl = new SeControlsLib.HotSpot();
            this.ofdReportFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdXMLDataFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdXSDSchemaFile = new System.Windows.Forms.OpenFileDialog();
            this.pnl_upper.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.dbDataSchema.SuspendLayout();
            this.gbXMLData.SuspendLayout();
            this.gpBEZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_upper
            // 
            this.pnl_upper.BackColor = System.Drawing.Color.Orange;
            this.pnl_upper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_upper.Controls.Add(this.lblCAPTIOIN);
            this.pnl_upper.Controls.Add(this.hsFastReport);
            this.pnl_upper.Controls.Add(this.hsDesignNew);
            this.pnl_upper.Controls.Add(this.hsPrint);
            this.pnl_upper.Controls.Add(this.hsClose);
            this.pnl_upper.Controls.Add(this.hsHELP);
            this.pnl_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_upper.Location = new System.Drawing.Point(0, 0);
            this.pnl_upper.Name = "pnl_upper";
            this.pnl_upper.Size = new System.Drawing.Size(801, 62);
            this.pnl_upper.TabIndex = 0;
            // 
            // lblCAPTIOIN
            // 
            this.lblCAPTIOIN.AutoSize = true;
            this.lblCAPTIOIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAPTIOIN.Location = new System.Drawing.Point(62, 8);
            this.lblCAPTIOIN.Name = "lblCAPTIOIN";
            this.lblCAPTIOIN.Size = new System.Drawing.Size(292, 31);
            this.lblCAPTIOIN.TabIndex = 88;
            this.lblCAPTIOIN.Text = "Formulare bearbeiten";
            // 
            // hsFastReport
            // 
            this.hsFastReport.BackColor = System.Drawing.Color.Transparent;
            this.hsFastReport.BackColorHover = System.Drawing.Color.Transparent;
            this.hsFastReport.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsFastReport.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsFastReport.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsFastReport.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsFastReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsFastReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsFastReport.FlatAppearance.BorderSize = 0;
            this.hsFastReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsFastReport.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsFastReport.Image = global::FBXpert.Properties.Resources.edit_select_all_blue_x32;
            this.hsFastReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsFastReport.ImageHover = global::FBXpert.Properties.Resources.edit_select_all_x32;
            this.hsFastReport.ImageToggleOnSelect = false;
            this.hsFastReport.Location = new System.Drawing.Point(398, 0);
            this.hsFastReport.Marked = false;
            this.hsFastReport.MarkedColor = System.Drawing.Color.Teal;
            this.hsFastReport.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsFastReport.MarkedText = "";
            this.hsFastReport.MarkMode = false;
            this.hsFastReport.Name = "hsFastReport";
            this.hsFastReport.NonMarkedText = "Design";
            this.hsFastReport.Size = new System.Drawing.Size(114, 60);
            this.hsFastReport.TabIndex = 83;
            this.hsFastReport.Text = "Design";
            this.hsFastReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsFastReport.ToolTipActive = false;
            this.hsFastReport.ToolTipAutomaticDelay = 500;
            this.hsFastReport.ToolTipAutoPopDelay = 5000;
            this.hsFastReport.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsFastReport.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsFastReport.ToolTipFor4ContextMenu = true;
            this.hsFastReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsFastReport.ToolTipInitialDelay = 500;
            this.hsFastReport.ToolTipIsBallon = false;
            this.hsFastReport.ToolTipOwnerDraw = false;
            this.hsFastReport.ToolTipReshowDelay = 100;
            this.hsFastReport.ToolTipShow = false;
            this.hsFastReport.ToolTipShowAlways = false;
            this.hsFastReport.ToolTipText = "";
            this.hsFastReport.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsFastReport.ToolTipTitle = "";
            this.hsFastReport.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsFastReport.UseVisualStyleBackColor = false;
            this.hsFastReport.Click += new System.EventHandler(this.hsFastReport_Click);
            // 
            // hsDesignNew
            // 
            this.hsDesignNew.BackColor = System.Drawing.Color.Transparent;
            this.hsDesignNew.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDesignNew.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDesignNew.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDesignNew.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDesignNew.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDesignNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDesignNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDesignNew.FlatAppearance.BorderSize = 0;
            this.hsDesignNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDesignNew.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsDesignNew.Image = global::FBXpert.Properties.Resources.documents_blue_x32;
            this.hsDesignNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsDesignNew.ImageHover = global::FBXpert.Properties.Resources.documents_32x;
            this.hsDesignNew.ImageToggleOnSelect = false;
            this.hsDesignNew.Location = new System.Drawing.Point(512, 0);
            this.hsDesignNew.Marked = false;
            this.hsDesignNew.MarkedColor = System.Drawing.Color.Teal;
            this.hsDesignNew.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDesignNew.MarkedText = "";
            this.hsDesignNew.MarkMode = false;
            this.hsDesignNew.Name = "hsDesignNew";
            this.hsDesignNew.NonMarkedText = "Design neu";
            this.hsDesignNew.Size = new System.Drawing.Size(89, 60);
            this.hsDesignNew.TabIndex = 86;
            this.hsDesignNew.Text = "Design neu";
            this.hsDesignNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsDesignNew.ToolTipActive = false;
            this.hsDesignNew.ToolTipAutomaticDelay = 500;
            this.hsDesignNew.ToolTipAutoPopDelay = 5000;
            this.hsDesignNew.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDesignNew.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDesignNew.ToolTipFor4ContextMenu = true;
            this.hsDesignNew.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDesignNew.ToolTipInitialDelay = 500;
            this.hsDesignNew.ToolTipIsBallon = false;
            this.hsDesignNew.ToolTipOwnerDraw = false;
            this.hsDesignNew.ToolTipReshowDelay = 100;
            this.hsDesignNew.ToolTipShow = false;
            this.hsDesignNew.ToolTipShowAlways = false;
            this.hsDesignNew.ToolTipText = "";
            this.hsDesignNew.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsDesignNew.ToolTipTitle = "";
            this.hsDesignNew.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDesignNew.UseVisualStyleBackColor = false;
            this.hsDesignNew.Click += new System.EventHandler(this.hsDesignNew_Click);
            // 
            // hsPrint
            // 
            this.hsPrint.BackColor = System.Drawing.Color.Transparent;
            this.hsPrint.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPrint.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPrint.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPrint.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPrint.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsPrint.FlatAppearance.BorderSize = 0;
            this.hsPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPrint.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsPrint.Image = global::FBXpert.Properties.Resources.printer_32x;
            this.hsPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPrint.ImageHover = global::FBXpert.Properties.Resources.printer_32x;
            this.hsPrint.ImageToggleOnSelect = false;
            this.hsPrint.Location = new System.Drawing.Point(601, 0);
            this.hsPrint.Marked = false;
            this.hsPrint.MarkedColor = System.Drawing.Color.Teal;
            this.hsPrint.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPrint.MarkedText = "";
            this.hsPrint.MarkMode = false;
            this.hsPrint.Name = "hsPrint";
            this.hsPrint.NonMarkedText = "Drucke";
            this.hsPrint.Size = new System.Drawing.Size(127, 60);
            this.hsPrint.TabIndex = 84;
            this.hsPrint.Text = "Drucke";
            this.hsPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPrint.ToolTipActive = false;
            this.hsPrint.ToolTipAutomaticDelay = 500;
            this.hsPrint.ToolTipAutoPopDelay = 5000;
            this.hsPrint.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPrint.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPrint.ToolTipFor4ContextMenu = true;
            this.hsPrint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPrint.ToolTipInitialDelay = 500;
            this.hsPrint.ToolTipIsBallon = false;
            this.hsPrint.ToolTipOwnerDraw = false;
            this.hsPrint.ToolTipReshowDelay = 100;
            this.hsPrint.ToolTipShow = false;
            this.hsPrint.ToolTipShowAlways = false;
            this.hsPrint.ToolTipText = "";
            this.hsPrint.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsPrint.ToolTipTitle = "";
            this.hsPrint.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPrint.UseVisualStyleBackColor = false;
            this.hsPrint.Click += new System.EventHandler(this.hotSpot1_Click);
            // 
            // hsClose
            // 
            this.hsClose.BackColor = System.Drawing.Color.Transparent;
            this.hsClose.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClose.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClose.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClose.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClose.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClose.FlatAppearance.BorderSize = 0;
            this.hsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsClose.Image = global::FBXpert.Properties.Resources.go_previous32x;
            this.hsClose.ImageHover = global::FBXpert.Properties.Resources.go_previous22x;
            this.hsClose.ImageToggleOnSelect = false;
            this.hsClose.Location = new System.Drawing.Point(1, 1);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Size = new System.Drawing.Size(45, 45);
            this.hsClose.TabIndex = 82;
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
            this.hsClose.ToolTipShow = true;
            this.hsClose.ToolTipShowAlways = false;
            this.hsClose.ToolTipText = "Formular schließen";
            this.hsClose.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsClose.ToolTipTitle = "";
            this.hsClose.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClose.UseVisualStyleBackColor = true;
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click);
            // 
            // hsHELP
            // 
            this.hsHELP.BackColor = System.Drawing.Color.Transparent;
            this.hsHELP.BackColorHover = System.Drawing.Color.Transparent;
            this.hsHELP.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsHELP.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsHELP.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsHELP.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsHELP.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsHELP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsHELP.FlatAppearance.BorderSize = 0;
            this.hsHELP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsHELP.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsHELP.Image = global::FBXpert.Properties.Resources.help_browser_22x;
            this.hsHELP.ImageHover = global::FBXpert.Properties.Resources.help_browser_blue_22x;
            this.hsHELP.ImageToggleOnSelect = false;
            this.hsHELP.Location = new System.Drawing.Point(728, 0);
            this.hsHELP.Marked = false;
            this.hsHELP.MarkedColor = System.Drawing.Color.Teal;
            this.hsHELP.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsHELP.MarkedText = "";
            this.hsHELP.MarkMode = false;
            this.hsHELP.Name = "hsHELP";
            this.hsHELP.NonMarkedText = "";
            this.hsHELP.Size = new System.Drawing.Size(71, 60);
            this.hsHELP.TabIndex = 86;
            this.hsHELP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsHELP.ToolTipActive = false;
            this.hsHELP.ToolTipAutomaticDelay = 500;
            this.hsHELP.ToolTipAutoPopDelay = 5000;
            this.hsHELP.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsHELP.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsHELP.ToolTipFor4ContextMenu = true;
            this.hsHELP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsHELP.ToolTipInitialDelay = 500;
            this.hsHELP.ToolTipIsBallon = false;
            this.hsHELP.ToolTipOwnerDraw = false;
            this.hsHELP.ToolTipReshowDelay = 100;
            this.hsHELP.ToolTipShow = true;
            this.hsHELP.ToolTipShowAlways = false;
            this.hsHELP.ToolTipText = "Programmhilfe";
            this.hsHELP.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsHELP.ToolTipTitle = "";
            this.hsHELP.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsHELP.UseVisualStyleBackColor = true;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.Orange;
            this.pnl_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 436);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(801, 32);
            this.pnl_bottom.TabIndex = 1;
            // 
            // pnl_center
            // 
            this.pnl_center.BackColor = System.Drawing.Color.Wheat;
            this.pnl_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_center.Controls.Add(this.dbDataSchema);
            this.pnl_center.Controls.Add(this.gbXMLData);
            this.pnl_center.Controls.Add(this.gpBEZ);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(0, 62);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(801, 374);
            this.pnl_center.TabIndex = 2;
            // 
            // dbDataSchema
            // 
            this.dbDataSchema.Controls.Add(this.hsEditXSDData);
            this.dbDataSchema.Controls.Add(this.txtXSDSchemaFile);
            this.dbDataSchema.Controls.Add(this.hsLoadSchemaFile);
            this.dbDataSchema.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbDataSchema.Location = new System.Drawing.Point(0, 80);
            this.dbDataSchema.Name = "dbDataSchema";
            this.dbDataSchema.Size = new System.Drawing.Size(799, 40);
            this.dbDataSchema.TabIndex = 88;
            this.dbDataSchema.TabStop = false;
            this.dbDataSchema.Text = "Schema (XSD)";
            // 
            // hsEditXSDData
            // 
            this.hsEditXSDData.BackColor = System.Drawing.Color.Transparent;
            this.hsEditXSDData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditXSDData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditXSDData.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsEditXSDData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditXSDData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditXSDData.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsEditXSDData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditXSDData.FlatAppearance.BorderSize = 0;
            this.hsEditXSDData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditXSDData.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsEditXSDData.Image = global::FBXpert.Properties.Resources.document_blue_x24;
            this.hsEditXSDData.ImageHover = global::FBXpert.Properties.Resources.document_x24;
            this.hsEditXSDData.ImageToggleOnSelect = false;
            this.hsEditXSDData.Location = new System.Drawing.Point(740, 16);
            this.hsEditXSDData.Marked = false;
            this.hsEditXSDData.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditXSDData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditXSDData.MarkedText = "";
            this.hsEditXSDData.MarkMode = false;
            this.hsEditXSDData.Name = "hsEditXSDData";
            this.hsEditXSDData.NonMarkedText = "";
            this.hsEditXSDData.Size = new System.Drawing.Size(28, 21);
            this.hsEditXSDData.TabIndex = 90;
            this.hsEditXSDData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEditXSDData.ToolTipActive = false;
            this.hsEditXSDData.ToolTipAutomaticDelay = 500;
            this.hsEditXSDData.ToolTipAutoPopDelay = 5000;
            this.hsEditXSDData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEditXSDData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEditXSDData.ToolTipFor4ContextMenu = true;
            this.hsEditXSDData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEditXSDData.ToolTipInitialDelay = 500;
            this.hsEditXSDData.ToolTipIsBallon = false;
            this.hsEditXSDData.ToolTipOwnerDraw = false;
            this.hsEditXSDData.ToolTipReshowDelay = 100;
            this.hsEditXSDData.ToolTipShow = true;
            this.hsEditXSDData.ToolTipShowAlways = false;
            this.hsEditXSDData.ToolTipText = "Drucken";
            this.hsEditXSDData.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsEditXSDData.ToolTipTitle = "";
            this.hsEditXSDData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEditXSDData.UseVisualStyleBackColor = true;
            this.hsEditXSDData.Click += new System.EventHandler(this.hsEditXSDData_Click);
            // 
            // txtXSDSchemaFile
            // 
            this.txtXSDSchemaFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtXSDSchemaFile.Location = new System.Drawing.Point(3, 16);
            this.txtXSDSchemaFile.Name = "txtXSDSchemaFile";
            this.txtXSDSchemaFile.Size = new System.Drawing.Size(725, 20);
            this.txtXSDSchemaFile.TabIndex = 1;
            // 
            // hsLoadSchemaFile
            // 
            this.hsLoadSchemaFile.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadSchemaFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadSchemaFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadSchemaFile.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsLoadSchemaFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadSchemaFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadSchemaFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadSchemaFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadSchemaFile.FlatAppearance.BorderSize = 0;
            this.hsLoadSchemaFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadSchemaFile.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsLoadSchemaFile.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSchemaFile.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSchemaFile.ImageToggleOnSelect = false;
            this.hsLoadSchemaFile.Location = new System.Drawing.Point(768, 16);
            this.hsLoadSchemaFile.Marked = false;
            this.hsLoadSchemaFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSchemaFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSchemaFile.MarkedText = "";
            this.hsLoadSchemaFile.MarkMode = false;
            this.hsLoadSchemaFile.Name = "hsLoadSchemaFile";
            this.hsLoadSchemaFile.NonMarkedText = "";
            this.hsLoadSchemaFile.Size = new System.Drawing.Size(28, 21);
            this.hsLoadSchemaFile.TabIndex = 88;
            this.hsLoadSchemaFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadSchemaFile.ToolTipActive = false;
            this.hsLoadSchemaFile.ToolTipAutomaticDelay = 500;
            this.hsLoadSchemaFile.ToolTipAutoPopDelay = 5000;
            this.hsLoadSchemaFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadSchemaFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadSchemaFile.ToolTipFor4ContextMenu = true;
            this.hsLoadSchemaFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadSchemaFile.ToolTipInitialDelay = 500;
            this.hsLoadSchemaFile.ToolTipIsBallon = false;
            this.hsLoadSchemaFile.ToolTipOwnerDraw = false;
            this.hsLoadSchemaFile.ToolTipReshowDelay = 100;
            this.hsLoadSchemaFile.ToolTipShow = true;
            this.hsLoadSchemaFile.ToolTipShowAlways = false;
            this.hsLoadSchemaFile.ToolTipText = "Drucken";
            this.hsLoadSchemaFile.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsLoadSchemaFile.ToolTipTitle = "";
            this.hsLoadSchemaFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadSchemaFile.UseVisualStyleBackColor = true;
            this.hsLoadSchemaFile.Click += new System.EventHandler(this.hsLoadSchemaFile_Click);
            // 
            // gbXMLData
            // 
            this.gbXMLData.Controls.Add(this.hsEditXMLData);
            this.gbXMLData.Controls.Add(this.txtXMLDataFile);
            this.gbXMLData.Controls.Add(this.hsLoadXMLDataFile);
            this.gbXMLData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbXMLData.Location = new System.Drawing.Point(0, 40);
            this.gbXMLData.Name = "gbXMLData";
            this.gbXMLData.Size = new System.Drawing.Size(799, 40);
            this.gbXMLData.TabIndex = 87;
            this.gbXMLData.TabStop = false;
            this.gbXMLData.Text = "Datendatei (XML)";
            // 
            // hsEditXMLData
            // 
            this.hsEditXMLData.BackColor = System.Drawing.Color.Transparent;
            this.hsEditXMLData.BackColorHover = System.Drawing.Color.Transparent;
            this.hsEditXMLData.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsEditXMLData.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsEditXMLData.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsEditXMLData.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsEditXMLData.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsEditXMLData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsEditXMLData.FlatAppearance.BorderSize = 0;
            this.hsEditXMLData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsEditXMLData.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsEditXMLData.Image = global::FBXpert.Properties.Resources.document_blue_x24;
            this.hsEditXMLData.ImageHover = global::FBXpert.Properties.Resources.document_x24;
            this.hsEditXMLData.ImageToggleOnSelect = false;
            this.hsEditXMLData.Location = new System.Drawing.Point(740, 16);
            this.hsEditXMLData.Marked = false;
            this.hsEditXMLData.MarkedColor = System.Drawing.Color.Teal;
            this.hsEditXMLData.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsEditXMLData.MarkedText = "";
            this.hsEditXMLData.MarkMode = false;
            this.hsEditXMLData.Name = "hsEditXMLData";
            this.hsEditXMLData.NonMarkedText = "";
            this.hsEditXMLData.Size = new System.Drawing.Size(28, 21);
            this.hsEditXMLData.TabIndex = 90;
            this.hsEditXMLData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsEditXMLData.ToolTipActive = false;
            this.hsEditXMLData.ToolTipAutomaticDelay = 500;
            this.hsEditXMLData.ToolTipAutoPopDelay = 5000;
            this.hsEditXMLData.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsEditXMLData.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsEditXMLData.ToolTipFor4ContextMenu = true;
            this.hsEditXMLData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsEditXMLData.ToolTipInitialDelay = 500;
            this.hsEditXMLData.ToolTipIsBallon = false;
            this.hsEditXMLData.ToolTipOwnerDraw = false;
            this.hsEditXMLData.ToolTipReshowDelay = 100;
            this.hsEditXMLData.ToolTipShow = true;
            this.hsEditXMLData.ToolTipShowAlways = false;
            this.hsEditXMLData.ToolTipText = "Drucken";
            this.hsEditXMLData.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsEditXMLData.ToolTipTitle = "";
            this.hsEditXMLData.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsEditXMLData.UseVisualStyleBackColor = true;
            this.hsEditXMLData.Click += new System.EventHandler(this.hsEditXMLData_Click);
            // 
            // txtXMLDataFile
            // 
            this.txtXMLDataFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtXMLDataFile.Location = new System.Drawing.Point(3, 16);
            this.txtXMLDataFile.Name = "txtXMLDataFile";
            this.txtXMLDataFile.Size = new System.Drawing.Size(725, 20);
            this.txtXMLDataFile.TabIndex = 1;
            // 
            // hsLoadXMLDataFile
            // 
            this.hsLoadXMLDataFile.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadXMLDataFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadXMLDataFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadXMLDataFile.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsLoadXMLDataFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadXMLDataFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadXMLDataFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadXMLDataFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadXMLDataFile.FlatAppearance.BorderSize = 0;
            this.hsLoadXMLDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadXMLDataFile.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsLoadXMLDataFile.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadXMLDataFile.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadXMLDataFile.ImageToggleOnSelect = false;
            this.hsLoadXMLDataFile.Location = new System.Drawing.Point(768, 16);
            this.hsLoadXMLDataFile.Marked = false;
            this.hsLoadXMLDataFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadXMLDataFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadXMLDataFile.MarkedText = "";
            this.hsLoadXMLDataFile.MarkMode = false;
            this.hsLoadXMLDataFile.Name = "hsLoadXMLDataFile";
            this.hsLoadXMLDataFile.NonMarkedText = "";
            this.hsLoadXMLDataFile.Size = new System.Drawing.Size(28, 21);
            this.hsLoadXMLDataFile.TabIndex = 88;
            this.hsLoadXMLDataFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadXMLDataFile.ToolTipActive = false;
            this.hsLoadXMLDataFile.ToolTipAutomaticDelay = 500;
            this.hsLoadXMLDataFile.ToolTipAutoPopDelay = 5000;
            this.hsLoadXMLDataFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadXMLDataFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadXMLDataFile.ToolTipFor4ContextMenu = true;
            this.hsLoadXMLDataFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadXMLDataFile.ToolTipInitialDelay = 500;
            this.hsLoadXMLDataFile.ToolTipIsBallon = false;
            this.hsLoadXMLDataFile.ToolTipOwnerDraw = false;
            this.hsLoadXMLDataFile.ToolTipReshowDelay = 100;
            this.hsLoadXMLDataFile.ToolTipShow = true;
            this.hsLoadXMLDataFile.ToolTipShowAlways = false;
            this.hsLoadXMLDataFile.ToolTipText = "Drucken";
            this.hsLoadXMLDataFile.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsLoadXMLDataFile.ToolTipTitle = "";
            this.hsLoadXMLDataFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadXMLDataFile.UseVisualStyleBackColor = true;
            this.hsLoadXMLDataFile.Click += new System.EventHandler(this.hsLoadXMLDataFile_Click);
            // 
            // gpBEZ
            // 
            this.gpBEZ.Controls.Add(this.hsXMLReport);
            this.gpBEZ.Controls.Add(this.txtREPORTFILE);
            this.gpBEZ.Controls.Add(this.hsReportFileWahl);
            this.gpBEZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpBEZ.Location = new System.Drawing.Point(0, 0);
            this.gpBEZ.Name = "gpBEZ";
            this.gpBEZ.Size = new System.Drawing.Size(799, 40);
            this.gpBEZ.TabIndex = 85;
            this.gpBEZ.TabStop = false;
            this.gpBEZ.Text = "Reportdate (FRX)";
            // 
            // hsXMLReport
            // 
            this.hsXMLReport.BackColor = System.Drawing.Color.Transparent;
            this.hsXMLReport.BackColorHover = System.Drawing.Color.Transparent;
            this.hsXMLReport.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsXMLReport.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsXMLReport.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsXMLReport.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsXMLReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsXMLReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsXMLReport.FlatAppearance.BorderSize = 0;
            this.hsXMLReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsXMLReport.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsXMLReport.Image = global::FBXpert.Properties.Resources.document_blue_x24;
            this.hsXMLReport.ImageHover = global::FBXpert.Properties.Resources.document_x24;
            this.hsXMLReport.ImageToggleOnSelect = false;
            this.hsXMLReport.Location = new System.Drawing.Point(740, 16);
            this.hsXMLReport.Marked = false;
            this.hsXMLReport.MarkedColor = System.Drawing.Color.Teal;
            this.hsXMLReport.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsXMLReport.MarkedText = "";
            this.hsXMLReport.MarkMode = false;
            this.hsXMLReport.Name = "hsXMLReport";
            this.hsXMLReport.NonMarkedText = "";
            this.hsXMLReport.Size = new System.Drawing.Size(28, 21);
            this.hsXMLReport.TabIndex = 89;
            this.hsXMLReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsXMLReport.ToolTipActive = false;
            this.hsXMLReport.ToolTipAutomaticDelay = 500;
            this.hsXMLReport.ToolTipAutoPopDelay = 5000;
            this.hsXMLReport.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsXMLReport.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsXMLReport.ToolTipFor4ContextMenu = true;
            this.hsXMLReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsXMLReport.ToolTipInitialDelay = 500;
            this.hsXMLReport.ToolTipIsBallon = false;
            this.hsXMLReport.ToolTipOwnerDraw = false;
            this.hsXMLReport.ToolTipReshowDelay = 100;
            this.hsXMLReport.ToolTipShow = true;
            this.hsXMLReport.ToolTipShowAlways = false;
            this.hsXMLReport.ToolTipText = "Drucken";
            this.hsXMLReport.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsXMLReport.ToolTipTitle = "";
            this.hsXMLReport.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsXMLReport.UseVisualStyleBackColor = true;
            this.hsXMLReport.Click += new System.EventHandler(this.hsXMLReport_Click);
            // 
            // txtREPORTFILE
            // 
            this.txtREPORTFILE.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtREPORTFILE.Location = new System.Drawing.Point(3, 16);
            this.txtREPORTFILE.Name = "txtREPORTFILE";
            this.txtREPORTFILE.Size = new System.Drawing.Size(725, 20);
            this.txtREPORTFILE.TabIndex = 1;
            // 
            // hsReportFileWahl
            // 
            this.hsReportFileWahl.BackColor = System.Drawing.Color.Transparent;
            this.hsReportFileWahl.BackColorHover = System.Drawing.Color.Transparent;
            this.hsReportFileWahl.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsReportFileWahl.ContextMenuXDirection = SeControlsLib.XDirection.Left;
            this.hsReportFileWahl.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsReportFileWahl.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsReportFileWahl.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsReportFileWahl.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsReportFileWahl.FlatAppearance.BorderSize = 0;
            this.hsReportFileWahl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsReportFileWahl.HoverStyle = SeControlsLib.frameStyle.thinRectangle;
            this.hsReportFileWahl.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsReportFileWahl.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsReportFileWahl.ImageToggleOnSelect = false;
            this.hsReportFileWahl.Location = new System.Drawing.Point(768, 16);
            this.hsReportFileWahl.Marked = false;
            this.hsReportFileWahl.MarkedColor = System.Drawing.Color.Teal;
            this.hsReportFileWahl.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsReportFileWahl.MarkedText = "";
            this.hsReportFileWahl.MarkMode = false;
            this.hsReportFileWahl.Name = "hsReportFileWahl";
            this.hsReportFileWahl.NonMarkedText = "";
            this.hsReportFileWahl.Size = new System.Drawing.Size(28, 21);
            this.hsReportFileWahl.TabIndex = 88;
            this.hsReportFileWahl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsReportFileWahl.ToolTipActive = false;
            this.hsReportFileWahl.ToolTipAutomaticDelay = 500;
            this.hsReportFileWahl.ToolTipAutoPopDelay = 5000;
            this.hsReportFileWahl.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsReportFileWahl.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsReportFileWahl.ToolTipFor4ContextMenu = true;
            this.hsReportFileWahl.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsReportFileWahl.ToolTipInitialDelay = 500;
            this.hsReportFileWahl.ToolTipIsBallon = false;
            this.hsReportFileWahl.ToolTipOwnerDraw = false;
            this.hsReportFileWahl.ToolTipReshowDelay = 100;
            this.hsReportFileWahl.ToolTipShow = true;
            this.hsReportFileWahl.ToolTipShowAlways = false;
            this.hsReportFileWahl.ToolTipText = "Drucken";
            this.hsReportFileWahl.ToolTipTextColor = System.Drawing.Color.Blue;
            this.hsReportFileWahl.ToolTipTitle = "";
            this.hsReportFileWahl.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsReportFileWahl.UseVisualStyleBackColor = true;
            this.hsReportFileWahl.Click += new System.EventHandler(this.hsReportFileWahl_Click);
            // 
            // ofdReportFile
            // 
            this.ofdReportFile.DefaultExt = "*.frx";
            this.ofdReportFile.Filter = "FastReport|*.frx|Alle|*.*";
            this.ofdReportFile.Title = "Lade Report Datei";
            // 
            // ofdXMLDataFile
            // 
            this.ofdXMLDataFile.DefaultExt = "*.xml";
            this.ofdXMLDataFile.Filter = "FastReport|*.xml|Alle|*.*";
            this.ofdXMLDataFile.Title = "Lade Report Datei";
            // 
            // ofdXSDSchemaFile
            // 
            this.ofdXSDSchemaFile.DefaultExt = "*.xsd";
            this.ofdXSDSchemaFile.Filter = "FastReport|*.xsd|Alle|*.*";
            this.ofdXSDSchemaFile.Title = "Lade Report Datei";
            // 
            // FORMULAREditForm
            // 
            this.ClientSize = new System.Drawing.Size(801, 468);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_upper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FORMULAREditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULAREditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORMULAREditForm_FormClosing);
            this.Load += new System.EventHandler(this.FORMULAREditForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FORMULAREditForm_HelpRequested);
            this.pnl_upper.ResumeLayout(false);
            this.pnl_upper.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.dbDataSchema.ResumeLayout(false);
            this.dbDataSchema.PerformLayout();
            this.gbXMLData.ResumeLayout(false);
            this.gbXMLData.PerformLayout();
            this.gpBEZ.ResumeLayout(false);
            this.gpBEZ.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private SeControlsLib.HotSpot hsHELP;
        private SeControlsLib.HotSpot hsClose;
        private Label lblCAPTIOIN;
        private SeControlsLib.HotSpot hsPrint;
        private SeControlsLib.HotSpot hsFastReport;
        private GroupBox gpBEZ;
        private SeControlsLib.HotSpot hsReportFileWahl;
        private TextBox txtREPORTFILE;
        private OpenFileDialog ofdReportFile;
        private SeControlsLib.HotSpot hsDesignNew;
        private GroupBox gbXMLData;
        private TextBox txtXMLDataFile;
        private SeControlsLib.HotSpot hsLoadXMLDataFile;
        private OpenFileDialog ofdXMLDataFile;
        private GroupBox dbDataSchema;
        private TextBox txtXSDSchemaFile;
        private SeControlsLib.HotSpot hsLoadSchemaFile;
        private OpenFileDialog ofdXSDSchemaFile;
        private SeControlsLib.HotSpot hsXMLReport;
        private SeControlsLib.HotSpot hsEditXSDData;
        private SeControlsLib.HotSpot hsEditXMLData;
    }
}
