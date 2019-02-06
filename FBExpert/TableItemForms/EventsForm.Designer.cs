using BasicForms;

namespace FBExpert
{
    partial class EventsForm : BasicEditFormClass
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlEvents = new System.Windows.Forms.TabControl();
            this.tabPageEventTracking = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlProcedureAttributesUpper = new System.Windows.Forms.Panel();
            this.hsTracking = new SeControlsLib.HotSpot();
            this.gbEventList = new System.Windows.Forms.GroupBox();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.colEVENTNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbEventNames = new System.Windows.Forms.GroupBox();
            this.hsRemoveField = new SeControlsLib.HotSpot();
            this.hsAddField = new SeControlsLib.HotSpot();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.tabControlText = new System.Windows.Forms.TabControl();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.pnlSQLUpper = new System.Windows.Forms.Panel();
            this.hsLoadTRACKING = new SeControlsLib.HotSpot();
            this.hsSaveTRACKING = new SeControlsLib.HotSpot();
            this.ilTabControl = new System.Windows.Forms.ImageList(this.components);
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.fctMessages = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMessagesUpper = new System.Windows.Forms.Panel();
            this.hotSpot3 = new SeControlsLib.HotSpot();
            this.saveTRACKINGFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdTRACKING = new System.Windows.Forms.OpenFileDialog();
            this.fctSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlEvents.SuspendLayout();
            this.tabPageEventTracking.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlProcedureAttributesUpper.SuspendLayout();
            this.gbEventList.SuspendLayout();
            this.gbEventNames.SuspendLayout();
            this.tabControlText.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.gbSQL.SuspendLayout();
            this.pnlSQLUpper.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).BeginInit();
            this.pnlMessagesUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1240, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(177, 10);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 8;
            this.lblTableName.Text = "Tablename";
            // 
            // hsRefresh
            // 
            this.hsRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefresh.FlatAppearance.BorderSize = 0;
            this.hsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::FBXpert.Properties.Resources.view_refresh32x;
            this.hsRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_32x;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(1195, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Size = new System.Drawing.Size(45, 42);
            this.hsRefresh.TabIndex = 2;
            this.hsRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefresh.ToolTipActive = false;
            this.hsRefresh.ToolTipAutomaticDelay = 500;
            this.hsRefresh.ToolTipAutoPopDelay = 5000;
            this.hsRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefresh.ToolTipFor4ContextMenu = true;
            this.hsRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefresh.ToolTipInitialDelay = 500;
            this.hsRefresh.ToolTipIsBallon = false;
            this.hsRefresh.ToolTipOwnerDraw = false;
            this.hsRefresh.ToolTipReshowDelay = 100;
            this.hsRefresh.ToolTipShowAlways = false;
            this.hsRefresh.ToolTipText = "";
            this.hsRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefresh.ToolTipTitle = "";
            this.hsRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefresh.UseVisualStyleBackColor = false;
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
            this.hsClose.Size = new System.Drawing.Size(45, 42);
            this.hsClose.TabIndex = 1;
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
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlEvents);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1240, 594);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlEvents
            // 
            this.tabControlEvents.Controls.Add(this.tabPageEventTracking);
            this.tabControlEvents.Controls.Add(this.tabPageMessages);
            this.tabControlEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEvents.ImageList = this.ilTabControl;
            this.tabControlEvents.Location = new System.Drawing.Point(0, 0);
            this.tabControlEvents.Name = "tabControlEvents";
            this.tabControlEvents.SelectedIndex = 0;
            this.tabControlEvents.Size = new System.Drawing.Size(1240, 594);
            this.tabControlEvents.TabIndex = 19;
            // 
            // tabPageEventTracking
            // 
            this.tabPageEventTracking.Controls.Add(this.pnlFieldsCenter);
            this.tabPageEventTracking.Controls.Add(this.pnlFieldUpper);
            this.tabPageEventTracking.ImageIndex = 8;
            this.tabPageEventTracking.Location = new System.Drawing.Point(4, 23);
            this.tabPageEventTracking.Name = "tabPageEventTracking";
            this.tabPageEventTracking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventTracking.Size = new System.Drawing.Size(1232, 567);
            this.tabPageEventTracking.TabIndex = 0;
            this.tabPageEventTracking.Text = "Events Tracking Definition";
            this.tabPageEventTracking.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Controls.Add(this.splitContainer1);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 43);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1226, 521);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlProcedureAttributesUpper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlText);
            this.splitContainer1.Size = new System.Drawing.Size(1226, 521);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 19;
            // 
            // pnlProcedureAttributesUpper
            // 
            this.pnlProcedureAttributesUpper.Controls.Add(this.hsTracking);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbEventList);
            this.pnlProcedureAttributesUpper.Controls.Add(this.gbEventNames);
            this.pnlProcedureAttributesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcedureAttributesUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlProcedureAttributesUpper.Name = "pnlProcedureAttributesUpper";
            this.pnlProcedureAttributesUpper.Size = new System.Drawing.Size(403, 433);
            this.pnlProcedureAttributesUpper.TabIndex = 0;
            // 
            // hsTracking
            // 
            this.hsTracking.BackColor = System.Drawing.Color.Red;
            this.hsTracking.BackColorHover = System.Drawing.Color.Red;
            this.hsTracking.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsTracking.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsTracking.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsTracking.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsTracking.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsTracking.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsTracking.FlatAppearance.BorderSize = 0;
            this.hsTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsTracking.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsTracking.Image = null;
            this.hsTracking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsTracking.ImageHover = null;
            this.hsTracking.ImageToggleOnSelect = true;
            this.hsTracking.Location = new System.Drawing.Point(286, 44);
            this.hsTracking.Marked = false;
            this.hsTracking.MarkedColor = System.Drawing.Color.SpringGreen;
            this.hsTracking.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsTracking.MarkedText = "Tracking ON";
            this.hsTracking.MarkMode = true;
            this.hsTracking.Name = "hsTracking";
            this.hsTracking.NonMarkedText = "Tracking OFF";
            this.hsTracking.Size = new System.Drawing.Size(82, 64);
            this.hsTracking.TabIndex = 22;
            this.hsTracking.Text = "Tracking";
            this.hsTracking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsTracking.ToolTipActive = false;
            this.hsTracking.ToolTipAutomaticDelay = 500;
            this.hsTracking.ToolTipAutoPopDelay = 5000;
            this.hsTracking.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsTracking.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsTracking.ToolTipFor4ContextMenu = true;
            this.hsTracking.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsTracking.ToolTipInitialDelay = 500;
            this.hsTracking.ToolTipIsBallon = false;
            this.hsTracking.ToolTipOwnerDraw = false;
            this.hsTracking.ToolTipReshowDelay = 100;
            this.hsTracking.ToolTipShowAlways = false;
            this.hsTracking.ToolTipText = "";
            this.hsTracking.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsTracking.ToolTipTitle = "";
            this.hsTracking.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsTracking.UseVisualStyleBackColor = false;
            this.hsTracking.Click += new System.EventHandler(this.hsTracking_Click);
            // 
            // gbEventList
            // 
            this.gbEventList.Controls.Add(this.lvEvents);
            this.gbEventList.Location = new System.Drawing.Point(5, 82);
            this.gbEventList.Name = "gbEventList";
            this.gbEventList.Size = new System.Drawing.Size(245, 324);
            this.gbEventList.TabIndex = 21;
            this.gbEventList.TabStop = false;
            this.gbEventList.Text = "Events to observe";
            // 
            // lvEvents
            // 
            this.lvEvents.AllowColumnReorder = true;
            this.lvEvents.AutoArrange = false;
            this.lvEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEVENTNAME});
            this.lvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvEvents.Location = new System.Drawing.Point(3, 16);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(239, 305);
            this.lvEvents.TabIndex = 2;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // colEVENTNAME
            // 
            this.colEVENTNAME.Text = "Event Name";
            this.colEVENTNAME.Width = 160;
            // 
            // gbEventNames
            // 
            this.gbEventNames.Controls.Add(this.hsRemoveField);
            this.gbEventNames.Controls.Add(this.hsAddField);
            this.gbEventNames.Controls.Add(this.cbEvents);
            this.gbEventNames.Location = new System.Drawing.Point(5, 28);
            this.gbEventNames.Name = "gbEventNames";
            this.gbEventNames.Size = new System.Drawing.Size(245, 46);
            this.gbEventNames.TabIndex = 20;
            this.gbEventNames.TabStop = false;
            this.gbEventNames.Text = "Event Name";
            // 
            // hsRemoveField
            // 
            this.hsRemoveField.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveField.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRemoveField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveField.FlatAppearance.BorderSize = 0;
            this.hsRemoveField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveField.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsRemoveField.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsRemoveField.ImageToggleOnSelect = true;
            this.hsRemoveField.Location = new System.Drawing.Point(152, 16);
            this.hsRemoveField.Marked = false;
            this.hsRemoveField.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveField.MarkedText = "";
            this.hsRemoveField.MarkMode = false;
            this.hsRemoveField.Name = "hsRemoveField";
            this.hsRemoveField.NonMarkedText = "";
            this.hsRemoveField.Size = new System.Drawing.Size(45, 27);
            this.hsRemoveField.TabIndex = 21;
            this.hsRemoveField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveField.ToolTipActive = false;
            this.hsRemoveField.ToolTipAutomaticDelay = 500;
            this.hsRemoveField.ToolTipAutoPopDelay = 5000;
            this.hsRemoveField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveField.ToolTipFor4ContextMenu = true;
            this.hsRemoveField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveField.ToolTipInitialDelay = 500;
            this.hsRemoveField.ToolTipIsBallon = false;
            this.hsRemoveField.ToolTipOwnerDraw = false;
            this.hsRemoveField.ToolTipReshowDelay = 100;
            this.hsRemoveField.ToolTipShowAlways = false;
            this.hsRemoveField.ToolTipText = "";
            this.hsRemoveField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveField.ToolTipTitle = "";
            this.hsRemoveField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveField.UseVisualStyleBackColor = false;
            // 
            // hsAddField
            // 
            this.hsAddField.BackColor = System.Drawing.Color.Transparent;
            this.hsAddField.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddField.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddField.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddField.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddField.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddField.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddField.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsAddField.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddField.FlatAppearance.BorderSize = 0;
            this.hsAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddField.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddField.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddField.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddField.ImageToggleOnSelect = true;
            this.hsAddField.Location = new System.Drawing.Point(197, 16);
            this.hsAddField.Marked = false;
            this.hsAddField.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddField.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddField.MarkedText = "";
            this.hsAddField.MarkMode = false;
            this.hsAddField.Name = "hsAddField";
            this.hsAddField.NonMarkedText = "";
            this.hsAddField.Size = new System.Drawing.Size(45, 27);
            this.hsAddField.TabIndex = 20;
            this.hsAddField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddField.ToolTipActive = false;
            this.hsAddField.ToolTipAutomaticDelay = 500;
            this.hsAddField.ToolTipAutoPopDelay = 5000;
            this.hsAddField.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddField.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddField.ToolTipFor4ContextMenu = true;
            this.hsAddField.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddField.ToolTipInitialDelay = 500;
            this.hsAddField.ToolTipIsBallon = false;
            this.hsAddField.ToolTipOwnerDraw = false;
            this.hsAddField.ToolTipReshowDelay = 100;
            this.hsAddField.ToolTipShowAlways = false;
            this.hsAddField.ToolTipText = "";
            this.hsAddField.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddField.ToolTipTitle = "";
            this.hsAddField.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddField.UseVisualStyleBackColor = false;
            this.hsAddField.Click += new System.EventHandler(this.hsAddField_Click);
            // 
            // cbEvents
            // 
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(6, 19);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(140, 21);
            this.cbEvents.TabIndex = 19;
            // 
            // tabControlText
            // 
            this.tabControlText.Controls.Add(this.tabPageEvents);
            this.tabControlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlText.ImageList = this.ilTabControl;
            this.tabControlText.Location = new System.Drawing.Point(0, 0);
            this.tabControlText.Name = "tabControlText";
            this.tabControlText.SelectedIndex = 0;
            this.tabControlText.Size = new System.Drawing.Size(819, 521);
            this.tabControlText.TabIndex = 11;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.gbSQL);
            this.tabPageEvents.Controls.Add(this.pnlSQLUpper);
            this.tabPageEvents.ImageIndex = 5;
            this.tabPageEvents.Location = new System.Drawing.Point(4, 23);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(811, 494);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events Tracking";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.fctSQL);
            this.gbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSQL.Location = new System.Drawing.Point(3, 43);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(805, 448);
            this.gbSQL.TabIndex = 9;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "SQL";
            // 
            // pnlSQLUpper
            // 
            this.pnlSQLUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlSQLUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLUpper.Controls.Add(this.hsLoadTRACKING);
            this.pnlSQLUpper.Controls.Add(this.hsSaveTRACKING);
            this.pnlSQLUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLUpper.Name = "pnlSQLUpper";
            this.pnlSQLUpper.Size = new System.Drawing.Size(805, 40);
            this.pnlSQLUpper.TabIndex = 10;
            // 
            // hsLoadTRACKING
            // 
            this.hsLoadTRACKING.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadTRACKING.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadTRACKING.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadTRACKING.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadTRACKING.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadTRACKING.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadTRACKING.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadTRACKING.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoadTRACKING.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadTRACKING.FlatAppearance.BorderSize = 0;
            this.hsLoadTRACKING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadTRACKING.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadTRACKING.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadTRACKING.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsLoadTRACKING.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadTRACKING.ImageToggleOnSelect = true;
            this.hsLoadTRACKING.Location = new System.Drawing.Point(237, 0);
            this.hsLoadTRACKING.Marked = false;
            this.hsLoadTRACKING.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadTRACKING.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadTRACKING.MarkedText = "";
            this.hsLoadTRACKING.MarkMode = false;
            this.hsLoadTRACKING.Name = "hsLoadTRACKING";
            this.hsLoadTRACKING.NonMarkedText = "Load SQL";
            this.hsLoadTRACKING.Size = new System.Drawing.Size(211, 36);
            this.hsLoadTRACKING.TabIndex = 9;
            this.hsLoadTRACKING.Text = "Load tracking";
            this.hsLoadTRACKING.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadTRACKING.ToolTipActive = false;
            this.hsLoadTRACKING.ToolTipAutomaticDelay = 500;
            this.hsLoadTRACKING.ToolTipAutoPopDelay = 5000;
            this.hsLoadTRACKING.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadTRACKING.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadTRACKING.ToolTipFor4ContextMenu = true;
            this.hsLoadTRACKING.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadTRACKING.ToolTipInitialDelay = 500;
            this.hsLoadTRACKING.ToolTipIsBallon = false;
            this.hsLoadTRACKING.ToolTipOwnerDraw = false;
            this.hsLoadTRACKING.ToolTipReshowDelay = 100;
            this.hsLoadTRACKING.ToolTipShowAlways = false;
            this.hsLoadTRACKING.ToolTipText = "";
            this.hsLoadTRACKING.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadTRACKING.ToolTipTitle = "";
            this.hsLoadTRACKING.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadTRACKING.UseVisualStyleBackColor = false;
            this.hsLoadTRACKING.Click += new System.EventHandler(this.hsLoadSQL_Click);
            // 
            // hsSaveTRACKING
            // 
            this.hsSaveTRACKING.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveTRACKING.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveTRACKING.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveTRACKING.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveTRACKING.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveTRACKING.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveTRACKING.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveTRACKING.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveTRACKING.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveTRACKING.FlatAppearance.BorderSize = 0;
            this.hsSaveTRACKING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveTRACKING.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveTRACKING.Image = global::FBXpert.Properties.Resources.data_export_blue_x24;
            this.hsSaveTRACKING.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveTRACKING.ImageHover = global::FBXpert.Properties.Resources.data_export_gn_x24;
            this.hsSaveTRACKING.ImageToggleOnSelect = true;
            this.hsSaveTRACKING.Location = new System.Drawing.Point(0, 0);
            this.hsSaveTRACKING.Marked = false;
            this.hsSaveTRACKING.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveTRACKING.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveTRACKING.MarkedText = "";
            this.hsSaveTRACKING.MarkMode = false;
            this.hsSaveTRACKING.Name = "hsSaveTRACKING";
            this.hsSaveTRACKING.NonMarkedText = "Save SQL";
            this.hsSaveTRACKING.Size = new System.Drawing.Size(237, 36);
            this.hsSaveTRACKING.TabIndex = 8;
            this.hsSaveTRACKING.Text = "Save tracking";
            this.hsSaveTRACKING.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveTRACKING.ToolTipActive = false;
            this.hsSaveTRACKING.ToolTipAutomaticDelay = 500;
            this.hsSaveTRACKING.ToolTipAutoPopDelay = 5000;
            this.hsSaveTRACKING.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveTRACKING.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveTRACKING.ToolTipFor4ContextMenu = true;
            this.hsSaveTRACKING.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveTRACKING.ToolTipInitialDelay = 500;
            this.hsSaveTRACKING.ToolTipIsBallon = false;
            this.hsSaveTRACKING.ToolTipOwnerDraw = false;
            this.hsSaveTRACKING.ToolTipReshowDelay = 100;
            this.hsSaveTRACKING.ToolTipShowAlways = false;
            this.hsSaveTRACKING.ToolTipText = "";
            this.hsSaveTRACKING.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveTRACKING.ToolTipTitle = "";
            this.hsSaveTRACKING.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveTRACKING.UseVisualStyleBackColor = false;
            this.hsSaveTRACKING.Click += new System.EventHandler(this.hsSaveSQL_Click);
            // 
            // ilTabControl
            // 
            this.ilTabControl.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilTabControl.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTabControl.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1226, 40);
            this.pnlFieldUpper.TabIndex = 1;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.fctMessages);
            this.tabPageMessages.Controls.Add(this.pnlMessagesUpper);
            this.tabPageMessages.ImageIndex = 9;
            this.tabPageMessages.Location = new System.Drawing.Point(4, 23);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1232, 567);
            this.tabPageMessages.TabIndex = 2;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // fctMessages
            // 
            this.fctMessages.AutoCompleteBracketsList = new char[] {
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
            this.fctMessages.AutoIndentCharsPatterns = "";
            this.fctMessages.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctMessages.BackBrush = null;
            this.fctMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctMessages.CharHeight = 14;
            this.fctMessages.CharWidth = 8;
            this.fctMessages.CommentPrefix = "--";
            this.fctMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctMessages.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctMessages.IsReplaceMode = false;
            this.fctMessages.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctMessages.LeftBracket = '(';
            this.fctMessages.Location = new System.Drawing.Point(3, 40);
            this.fctMessages.Name = "fctMessages";
            this.fctMessages.Paddings = new System.Windows.Forms.Padding(0);
            this.fctMessages.RightBracket = ')';
            this.fctMessages.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctMessages.ServiceColors = null;
            this.fctMessages.Size = new System.Drawing.Size(1226, 524);
            this.fctMessages.TabIndex = 30;
            this.fctMessages.Zoom = 100;
            // 
            // pnlMessagesUpper
            // 
            this.pnlMessagesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessagesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessagesUpper.Controls.Add(this.hotSpot3);
            this.pnlMessagesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessagesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMessagesUpper.Name = "pnlMessagesUpper";
            this.pnlMessagesUpper.Size = new System.Drawing.Size(1226, 37);
            this.pnlMessagesUpper.TabIndex = 29;
            // 
            // hotSpot3
            // 
            this.hotSpot3.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot3.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot3.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot3.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot3.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot3.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotSpot3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot3.FlatAppearance.BorderSize = 0;
            this.hotSpot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot3.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot3.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot3.ImageToggleOnSelect = true;
            this.hotSpot3.Location = new System.Drawing.Point(1177, 0);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "";
            this.hotSpot3.Size = new System.Drawing.Size(45, 33);
            this.hotSpot3.TabIndex = 2;
            this.hotSpot3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot3.ToolTipActive = false;
            this.hotSpot3.ToolTipAutomaticDelay = 500;
            this.hotSpot3.ToolTipAutoPopDelay = 5000;
            this.hotSpot3.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot3.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot3.ToolTipFor4ContextMenu = true;
            this.hotSpot3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot3.ToolTipInitialDelay = 500;
            this.hotSpot3.ToolTipIsBallon = false;
            this.hotSpot3.ToolTipOwnerDraw = false;
            this.hotSpot3.ToolTipReshowDelay = 100;
            this.hotSpot3.ToolTipShowAlways = false;
            this.hotSpot3.ToolTipText = "";
            this.hotSpot3.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot3.ToolTipTitle = "";
            this.hotSpot3.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot3.UseVisualStyleBackColor = false;
            // 
            // saveTRACKINGFile
            // 
            this.saveTRACKINGFile.DefaultExt = "*.sql";
            this.saveTRACKINGFile.Filter = "Event Tracking|*.trk|All|*.*";
            this.saveTRACKINGFile.Title = "Save Eventtracking";
            // 
            // ofdTRACKING
            // 
            this.ofdTRACKING.Filter = "Event Tracking|*.trk|All|*.*";
            this.ofdTRACKING.Title = "Load Eventtracking";
            // 
            // fctSQL
            // 
            this.fctSQL.AutoCompleteBracketsList = new char[] {
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
            this.fctSQL.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.fctSQL.BackBrush = null;
            this.fctSQL.BackColor = System.Drawing.SystemColors.Info;
            this.fctSQL.CharHeight = 14;
            this.fctSQL.CharWidth = 8;
            this.fctSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSQL.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctSQL.IsReplaceMode = false;
            this.fctSQL.Location = new System.Drawing.Point(3, 16);
            this.fctSQL.Name = "fctSQL";
            this.fctSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.fctSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSQL.ServiceColors")));
            this.fctSQL.Size = new System.Drawing.Size(799, 429);
            this.fctSQL.TabIndex = 0;
            this.fctSQL.Text = "fastColoredTextBox1";
            this.fctSQL.Zoom = 100;
            this.fctSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctSQL_KeyDown);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 636);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Name = "EventsForm";
            this.Text = "3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventsForm_FormClosing);
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlEvents.ResumeLayout(false);
            this.tabPageEventTracking.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlProcedureAttributesUpper.ResumeLayout(false);
            this.gbEventList.ResumeLayout(false);
            this.gbEventNames.ResumeLayout(false);
            this.tabControlText.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.gbSQL.ResumeLayout(false);
            this.pnlSQLUpper.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctMessages)).EndInit();
            this.pnlMessagesUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.TabControl tabControlEvents;
        private System.Windows.Forms.TabPage tabPageEventTracking;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlProcedureAttributesUpper;
        private System.Windows.Forms.TabControl tabControlText;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private System.Windows.Forms.TabPage tabPageMessages;
        private FastColoredTextBoxNS.FastColoredTextBox fctMessages;
        private System.Windows.Forms.Panel pnlMessagesUpper;
        private SeControlsLib.HotSpot hotSpot3;
        private System.Windows.Forms.ImageList ilTabControl;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel pnlSQLUpper;
        private SeControlsLib.HotSpot hsLoadTRACKING;
        private SeControlsLib.HotSpot hsSaveTRACKING;
        private System.Windows.Forms.SaveFileDialog saveTRACKINGFile;
        private System.Windows.Forms.OpenFileDialog ofdTRACKING;
        private System.Windows.Forms.GroupBox gbEventList;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader colEVENTNAME;
        private System.Windows.Forms.GroupBox gbEventNames;
        private SeControlsLib.HotSpot hsRemoveField;
        private SeControlsLib.HotSpot hsAddField;
        private System.Windows.Forms.ComboBox cbEvents;
        private SeControlsLib.HotSpot hsTracking;
        private FastColoredTextBoxNS.FastColoredTextBox fctSQL;
    }
}