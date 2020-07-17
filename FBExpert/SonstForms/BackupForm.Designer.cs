using BasicForms;

namespace FBXpert
{
    partial class BackupForm : BasicEditFormClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.gbBackupLog = new System.Windows.Forms.GroupBox();
            this.lvBackupMessage = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbBackupOptions = new System.Windows.Forms.GroupBox();
            this.lvBackup = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gbConnectionType = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBackupSourceDatabasePath = new System.Windows.Forms.TextBox();
            this.hsChooseDatabase = new SeControlsLib.HotSpot();
            this.rbEmbedded = new System.Windows.Forms.RadioButton();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.rbRemote = new System.Windows.Forms.RadioButton();
            this.cbUseLocalhost = new System.Windows.Forms.CheckBox();
            this.cbBackupExpand = new System.Windows.Forms.CheckBox();
            this.cbBackupOldDescriptions = new System.Windows.Forms.CheckBox();
            this.cbBackupLimbo = new System.Windows.Forms.CheckBox();
            this.cbBackupConvert = new System.Windows.Forms.CheckBox();
            this.cbBackupTransportable = new System.Windows.Forms.CheckBox();
            this.cbBackupGarbageCollect = new System.Windows.Forms.CheckBox();
            this.hsAddBackupFile = new SeControlsLib.HotSpot();
            this.cbBackupIgnoreChecksum = new System.Windows.Forms.CheckBox();
            this.cbBackupMetatdataOnly = new System.Windows.Forms.CheckBox();
            this.cbBackupDisableTriggers = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBackupFileSize = new System.Windows.Forms.TextBox();
            this.hsRemoveBackupFile = new SeControlsLib.HotSpot();
            this.gbBackupLocation = new System.Windows.Forms.GroupBox();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.hsLoadBackupFile = new SeControlsLib.HotSpot();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsBackup = new SeControlsLib.HotSpot();
            this.tabPageRestore = new System.Windows.Forms.TabPage();
            this.pnRestoreCenter = new System.Windows.Forms.Panel();
            this.gbRestoreLog = new System.Windows.Forms.GroupBox();
            this.lvRestoreMessage = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRestoreMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRestoreTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRestoreFiles = new System.Windows.Forms.GroupBox();
            this.lvRestore = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRestoreOptions = new System.Windows.Forms.GroupBox();
            this.cbRestoreInvidualCommit = new System.Windows.Forms.CheckBox();
            this.cbRestoreNoVaildy = new System.Windows.Forms.CheckBox();
            this.gbCreateReplace = new System.Windows.Forms.GroupBox();
            this.rbCreateDatabase = new System.Windows.Forms.RadioButton();
            this.rbReplaceDatabase = new System.Windows.Forms.RadioButton();
            this.cbRestoreUseAllSpace = new System.Windows.Forms.CheckBox();
            this.cbRestoreNoShadows = new System.Windows.Forms.CheckBox();
            this.cbRestoreMetatdataOnly = new System.Windows.Forms.CheckBox();
            this.cbRestoreNoIndices = new System.Windows.Forms.CheckBox();
            this.gbRestoreFileSize = new System.Windows.Forms.GroupBox();
            this.txtRestoreFileSize = new System.Windows.Forms.TextBox();
            this.hsAddRestoreFile = new SeControlsLib.HotSpot();
            this.hsRemoveRestoreFile = new SeControlsLib.HotSpot();
            this.gbRestoreFileName = new System.Windows.Forms.GroupBox();
            this.txtRestoreLocation = new System.Windows.Forms.TextBox();
            this.hsLoadRestoreFile = new SeControlsLib.HotSpot();
            this.dgvDependenciesTo = new System.Windows.Forms.DataGridView();
            this.bsDependenciesTo = new System.Windows.Forms.BindingSource(this.components);
            this.dsDependenciesTo = new System.Data.DataSet();
            this.dataTable5 = new System.Data.DataTable();
            this.pnlRestoreUpper = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRestoreDestinationDatabasePath = new System.Windows.Forms.TextBox();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hsRestore = new SeControlsLib.HotSpot();
            this.dsDependenciesFrom = new System.Data.DataSet();
            this.dataTable6 = new System.Data.DataTable();
            this.bsDependenciesFrom = new System.Windows.Forms.BindingSource(this.components);
            this.ofdBackup = new System.Windows.Forms.OpenFileDialog();
            this.ofdRestore = new System.Windows.Forms.OpenFileDialog();
            this.ofdRestoreFromDatabase = new System.Windows.Forms.OpenFileDialog();
            this.ofdDatabase = new System.Windows.Forms.OpenFileDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.pnlFieldsCenter.SuspendLayout();
            this.gbBackupLog.SuspendLayout();
            this.gbBackupOptions.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbConnectionType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbBackupLocation.SuspendLayout();
            this.pnlFieldUpper.SuspendLayout();
            this.tabPageRestore.SuspendLayout();
            this.pnRestoreCenter.SuspendLayout();
            this.gbRestoreLog.SuspendLayout();
            this.gbRestoreFiles.SuspendLayout();
            this.gbRestoreOptions.SuspendLayout();
            this.gbCreateReplace.SuspendLayout();
            this.gbRestoreFileSize.SuspendLayout();
            this.gbRestoreFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.pnlRestoreUpper.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.lblCaption);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1276, 42);
            this.pnlUpper.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(95, 10);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(89, 20);
            this.lblCaption.TabIndex = 4;
            this.lblCaption.Text = "lblCaption";
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
            this.hsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsClose.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClose.ShowShortcut = false;
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
            // pnlLower
            // 
            this.pnlLower.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 648);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(1276, 32);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1276, 606);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPageBackup);
            this.tabControlFields.Controls.Add(this.tabPageRestore);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(1276, 606);
            this.tabControlFields.TabIndex = 18;
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.pnlFieldsCenter);
            this.tabPageBackup.Controls.Add(this.pnlFieldUpper);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(1268, 580);
            this.tabPageBackup.TabIndex = 0;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldsCenter.Controls.Add(this.gbBackupLog);
            this.pnlFieldsCenter.Controls.Add(this.gbBackupOptions);
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 46);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(1262, 531);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // gbBackupLog
            // 
            this.gbBackupLog.Controls.Add(this.lvBackupMessage);
            this.gbBackupLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBackupLog.Location = new System.Drawing.Point(617, 0);
            this.gbBackupLog.Name = "gbBackupLog";
            this.gbBackupLog.Size = new System.Drawing.Size(641, 527);
            this.gbBackupLog.TabIndex = 9;
            this.gbBackupLog.TabStop = false;
            this.gbBackupLog.Text = "Log";
            // 
            // lvBackupMessage
            // 
            this.lvBackupMessage.BackColor = System.Drawing.SystemColors.Info;
            this.lvBackupMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBackupMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBackupMessage.FullRowSelect = true;
            this.lvBackupMessage.GridLines = true;
            this.lvBackupMessage.HideSelection = false;
            this.lvBackupMessage.Location = new System.Drawing.Point(3, 16);
            this.lvBackupMessage.Name = "lvBackupMessage";
            this.lvBackupMessage.Size = new System.Drawing.Size(635, 508);
            this.lvBackupMessage.TabIndex = 2;
            this.lvBackupMessage.UseCompatibleStateImageBehavior = false;
            this.lvBackupMessage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cnt";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Message";
            this.columnHeader3.Width = 500;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Timestamp";
            this.columnHeader4.Width = 80;
            // 
            // gbBackupOptions
            // 
            this.gbBackupOptions.Controls.Add(this.lvBackup);
            this.gbBackupOptions.Controls.Add(this.groupBox6);
            this.gbBackupOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBackupOptions.Location = new System.Drawing.Point(0, 0);
            this.gbBackupOptions.Name = "gbBackupOptions";
            this.gbBackupOptions.Size = new System.Drawing.Size(617, 527);
            this.gbBackupOptions.TabIndex = 10;
            this.gbBackupOptions.TabStop = false;
            this.gbBackupOptions.Text = "Backup Files";
            // 
            // lvBackup
            // 
            this.lvBackup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colSize});
            this.lvBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBackup.FullRowSelect = true;
            this.lvBackup.GridLines = true;
            this.lvBackup.HideSelection = false;
            this.lvBackup.Location = new System.Drawing.Point(3, 16);
            this.lvBackup.Name = "lvBackup";
            this.lvBackup.Size = new System.Drawing.Size(611, 144);
            this.lvBackup.TabIndex = 0;
            this.lvBackup.UseCompatibleStateImageBehavior = false;
            this.lvBackup.View = System.Windows.Forms.View.Details;
            // 
            // colFile
            // 
            this.colFile.Text = "Backupfile";
            this.colFile.Width = 500;
            // 
            // colSize
            // 
            this.colSize.Text = "Size (kB)";
            this.colSize.Width = 100;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gbConnectionType);
            this.groupBox6.Controls.Add(this.cbUseLocalhost);
            this.groupBox6.Controls.Add(this.cbBackupExpand);
            this.groupBox6.Controls.Add(this.cbBackupOldDescriptions);
            this.groupBox6.Controls.Add(this.cbBackupLimbo);
            this.groupBox6.Controls.Add(this.cbBackupConvert);
            this.groupBox6.Controls.Add(this.cbBackupTransportable);
            this.groupBox6.Controls.Add(this.cbBackupGarbageCollect);
            this.groupBox6.Controls.Add(this.hsAddBackupFile);
            this.groupBox6.Controls.Add(this.cbBackupIgnoreChecksum);
            this.groupBox6.Controls.Add(this.cbBackupMetatdataOnly);
            this.groupBox6.Controls.Add(this.cbBackupDisableTriggers);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.hsRemoveBackupFile);
            this.groupBox6.Controls.Add(this.gbBackupLocation);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 160);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(611, 364);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // gbConnectionType
            // 
            this.gbConnectionType.Controls.Add(this.groupBox2);
            this.gbConnectionType.Controls.Add(this.rbEmbedded);
            this.gbConnectionType.Controls.Add(this.gbServer);
            this.gbConnectionType.Controls.Add(this.rbRemote);
            this.gbConnectionType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbConnectionType.Location = new System.Drawing.Point(3, 217);
            this.gbConnectionType.Name = "gbConnectionType";
            this.gbConnectionType.Size = new System.Drawing.Size(605, 144);
            this.gbConnectionType.TabIndex = 24;
            this.gbConnectionType.TabStop = false;
            this.gbConnectionType.Text = "Database Connectiontype";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBackupSourceDatabasePath);
            this.groupBox2.Controls.Add(this.hsChooseDatabase);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 41);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Databasepath";
            // 
            // txtBackupSourceDatabasePath
            // 
            this.txtBackupSourceDatabasePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackupSourceDatabasePath.Location = new System.Drawing.Point(3, 16);
            this.txtBackupSourceDatabasePath.Name = "txtBackupSourceDatabasePath";
            this.txtBackupSourceDatabasePath.Size = new System.Drawing.Size(564, 20);
            this.txtBackupSourceDatabasePath.TabIndex = 1;
            // 
            // hsChooseDatabase
            // 
            this.hsChooseDatabase.BackColor = System.Drawing.Color.Transparent;
            this.hsChooseDatabase.BackColorHover = System.Drawing.Color.Transparent;
            this.hsChooseDatabase.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsChooseDatabase.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsChooseDatabase.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsChooseDatabase.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsChooseDatabase.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsChooseDatabase.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsChooseDatabase.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsChooseDatabase.FlatAppearance.BorderSize = 0;
            this.hsChooseDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsChooseDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsChooseDatabase.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsChooseDatabase.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsChooseDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsChooseDatabase.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsChooseDatabase.ImageToggleOnSelect = false;
            this.hsChooseDatabase.Location = new System.Drawing.Point(567, 16);
            this.hsChooseDatabase.Marked = false;
            this.hsChooseDatabase.MarkedColor = System.Drawing.Color.Teal;
            this.hsChooseDatabase.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsChooseDatabase.MarkedText = "";
            this.hsChooseDatabase.MarkMode = false;
            this.hsChooseDatabase.Name = "hsChooseDatabase";
            this.hsChooseDatabase.NonMarkedText = "";
            this.hsChooseDatabase.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsChooseDatabase.ShowShortcut = false;
            this.hsChooseDatabase.Size = new System.Drawing.Size(29, 22);
            this.hsChooseDatabase.TabIndex = 4;
            this.hsChooseDatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsChooseDatabase.ToolTipActive = false;
            this.hsChooseDatabase.ToolTipAutomaticDelay = 500;
            this.hsChooseDatabase.ToolTipAutoPopDelay = 5000;
            this.hsChooseDatabase.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsChooseDatabase.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsChooseDatabase.ToolTipFor4ContextMenu = true;
            this.hsChooseDatabase.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsChooseDatabase.ToolTipInitialDelay = 500;
            this.hsChooseDatabase.ToolTipIsBallon = false;
            this.hsChooseDatabase.ToolTipOwnerDraw = false;
            this.hsChooseDatabase.ToolTipReshowDelay = 100;
            this.hsChooseDatabase.ToolTipShowAlways = false;
            this.hsChooseDatabase.ToolTipText = "";
            this.hsChooseDatabase.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsChooseDatabase.ToolTipTitle = "";
            this.hsChooseDatabase.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsChooseDatabase.UseVisualStyleBackColor = false;
            this.hsChooseDatabase.Click += new System.EventHandler(this.hsChooseDatabase_Click);
            // 
            // rbEmbedded
            // 
            this.rbEmbedded.AutoSize = true;
            this.rbEmbedded.Location = new System.Drawing.Point(18, 67);
            this.rbEmbedded.Name = "rbEmbedded";
            this.rbEmbedded.Size = new System.Drawing.Size(76, 17);
            this.rbEmbedded.TabIndex = 8;
            this.rbEmbedded.TabStop = true;
            this.rbEmbedded.Text = "Embedded";
            this.rbEmbedded.UseVisualStyleBackColor = true;
            this.rbEmbedded.CheckedChanged += new System.EventHandler(this.rbEmbedded_CheckedChanged);
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.txtServer);
            this.gbServer.Location = new System.Drawing.Point(101, 43);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(199, 41);
            this.gbServer.TabIndex = 7;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(3, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(193, 20);
            this.txtServer.TabIndex = 1;
            // 
            // rbRemote
            // 
            this.rbRemote.AutoSize = true;
            this.rbRemote.Location = new System.Drawing.Point(18, 43);
            this.rbRemote.Name = "rbRemote";
            this.rbRemote.Size = new System.Drawing.Size(62, 17);
            this.rbRemote.TabIndex = 2;
            this.rbRemote.TabStop = true;
            this.rbRemote.Text = "Remote";
            this.rbRemote.UseVisualStyleBackColor = true;
            this.rbRemote.CheckedChanged += new System.EventHandler(this.rbRemote_CheckedChanged);
            // 
            // cbUseLocalhost
            // 
            this.cbUseLocalhost.AutoSize = true;
            this.cbUseLocalhost.Location = new System.Drawing.Point(187, 194);
            this.cbUseLocalhost.Name = "cbUseLocalhost";
            this.cbUseLocalhost.Size = new System.Drawing.Size(132, 17);
            this.cbUseLocalhost.TabIndex = 23;
            this.cbUseLocalhost.Text = "Use localhost account";
            this.cbUseLocalhost.UseVisualStyleBackColor = true;
            // 
            // cbBackupExpand
            // 
            this.cbBackupExpand.AutoSize = true;
            this.cbBackupExpand.Location = new System.Drawing.Point(188, 171);
            this.cbBackupExpand.Name = "cbBackupExpand";
            this.cbBackupExpand.Size = new System.Drawing.Size(188, 17);
            this.cbBackupExpand.TabIndex = 22;
            this.cbBackupExpand.Text = "Creates an uncompressed backup";
            this.cbBackupExpand.UseVisualStyleBackColor = true;
            // 
            // cbBackupOldDescriptions
            // 
            this.cbBackupOldDescriptions.AutoSize = true;
            this.cbBackupOldDescriptions.Location = new System.Drawing.Point(6, 194);
            this.cbBackupOldDescriptions.Name = "cbBackupOldDescriptions";
            this.cbBackupOldDescriptions.Size = new System.Drawing.Size(103, 17);
            this.cbBackupOldDescriptions.TabIndex = 19;
            this.cbBackupOldDescriptions.Text = "Old Descriptions";
            this.cbBackupOldDescriptions.UseVisualStyleBackColor = true;
            // 
            // cbBackupLimbo
            // 
            this.cbBackupLimbo.AutoSize = true;
            this.cbBackupLimbo.Location = new System.Drawing.Point(6, 125);
            this.cbBackupLimbo.Name = "cbBackupLimbo";
            this.cbBackupLimbo.Size = new System.Drawing.Size(151, 17);
            this.cbBackupLimbo.TabIndex = 21;
            this.cbBackupLimbo.Text = "Ignores limbo transactions ";
            this.cbBackupLimbo.UseVisualStyleBackColor = true;
            // 
            // cbBackupConvert
            // 
            this.cbBackupConvert.AutoSize = true;
            this.cbBackupConvert.Location = new System.Drawing.Point(188, 148);
            this.cbBackupConvert.Name = "cbBackupConvert";
            this.cbBackupConvert.Size = new System.Drawing.Size(219, 17);
            this.cbBackupConvert.TabIndex = 20;
            this.cbBackupConvert.Text = "Converts external tables to internal tables";
            this.cbBackupConvert.UseVisualStyleBackColor = true;
            // 
            // cbBackupTransportable
            // 
            this.cbBackupTransportable.AutoSize = true;
            this.cbBackupTransportable.Location = new System.Drawing.Point(188, 102);
            this.cbBackupTransportable.Name = "cbBackupTransportable";
            this.cbBackupTransportable.Size = new System.Drawing.Size(428, 17);
            this.cbBackupTransportable.TabIndex = 18;
            this.cbBackupTransportable.Text = "Creates a transportable backup (transportable between platforms and server versio" +
    "ns)";
            this.cbBackupTransportable.UseVisualStyleBackColor = true;
            // 
            // cbBackupGarbageCollect
            // 
            this.cbBackupGarbageCollect.AutoSize = true;
            this.cbBackupGarbageCollect.Checked = true;
            this.cbBackupGarbageCollect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackupGarbageCollect.Location = new System.Drawing.Point(6, 171);
            this.cbBackupGarbageCollect.Name = "cbBackupGarbageCollect";
            this.cbBackupGarbageCollect.Size = new System.Drawing.Size(155, 17);
            this.cbBackupGarbageCollect.TabIndex = 17;
            this.cbBackupGarbageCollect.Text = "Perform garbage collection ";
            this.cbBackupGarbageCollect.UseVisualStyleBackColor = true;
            // 
            // hsAddBackupFile
            // 
            this.hsAddBackupFile.BackColor = System.Drawing.Color.Transparent;
            this.hsAddBackupFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddBackupFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddBackupFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddBackupFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddBackupFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddBackupFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddBackupFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddBackupFile.FlatAppearance.BorderSize = 0;
            this.hsAddBackupFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddBackupFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddBackupFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddBackupFile.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddBackupFile.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddBackupFile.ImageToggleOnSelect = true;
            this.hsAddBackupFile.Location = new System.Drawing.Point(9, 10);
            this.hsAddBackupFile.Marked = false;
            this.hsAddBackupFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddBackupFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddBackupFile.MarkedText = "";
            this.hsAddBackupFile.MarkMode = false;
            this.hsAddBackupFile.Name = "hsAddBackupFile";
            this.hsAddBackupFile.NonMarkedText = "";
            this.hsAddBackupFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddBackupFile.ShowShortcut = false;
            this.hsAddBackupFile.Size = new System.Drawing.Size(45, 32);
            this.hsAddBackupFile.TabIndex = 11;
            this.hsAddBackupFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddBackupFile.ToolTipActive = false;
            this.hsAddBackupFile.ToolTipAutomaticDelay = 500;
            this.hsAddBackupFile.ToolTipAutoPopDelay = 5000;
            this.hsAddBackupFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddBackupFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddBackupFile.ToolTipFor4ContextMenu = true;
            this.hsAddBackupFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddBackupFile.ToolTipInitialDelay = 500;
            this.hsAddBackupFile.ToolTipIsBallon = false;
            this.hsAddBackupFile.ToolTipOwnerDraw = false;
            this.hsAddBackupFile.ToolTipReshowDelay = 100;
            this.hsAddBackupFile.ToolTipShowAlways = false;
            this.hsAddBackupFile.ToolTipText = "";
            this.hsAddBackupFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddBackupFile.ToolTipTitle = "";
            this.hsAddBackupFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddBackupFile.UseVisualStyleBackColor = false;
            this.hsAddBackupFile.Click += new System.EventHandler(this.hsAddBackupFile_Click);
            // 
            // cbBackupIgnoreChecksum
            // 
            this.cbBackupIgnoreChecksum.AutoSize = true;
            this.cbBackupIgnoreChecksum.Location = new System.Drawing.Point(6, 148);
            this.cbBackupIgnoreChecksum.Name = "cbBackupIgnoreChecksum";
            this.cbBackupIgnoreChecksum.Size = new System.Drawing.Size(142, 17);
            this.cbBackupIgnoreChecksum.TabIndex = 16;
            this.cbBackupIgnoreChecksum.Text = "Ignores checksum errors";
            this.cbBackupIgnoreChecksum.UseVisualStyleBackColor = true;
            // 
            // cbBackupMetatdataOnly
            // 
            this.cbBackupMetatdataOnly.AutoSize = true;
            this.cbBackupMetatdataOnly.Location = new System.Drawing.Point(188, 125);
            this.cbBackupMetatdataOnly.Name = "cbBackupMetatdataOnly";
            this.cbBackupMetatdataOnly.Size = new System.Drawing.Size(187, 17);
            this.cbBackupMetatdataOnly.TabIndex = 15;
            this.cbBackupMetatdataOnly.Text = "Only backs up metadata (schema)";
            this.cbBackupMetatdataOnly.UseVisualStyleBackColor = true;
            // 
            // cbBackupDisableTriggers
            // 
            this.cbBackupDisableTriggers.AutoSize = true;
            this.cbBackupDisableTriggers.Checked = true;
            this.cbBackupDisableTriggers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackupDisableTriggers.Location = new System.Drawing.Point(6, 102);
            this.cbBackupDisableTriggers.Name = "cbBackupDisableTriggers";
            this.cbBackupDisableTriggers.Size = new System.Drawing.Size(102, 17);
            this.cbBackupDisableTriggers.TabIndex = 14;
            this.cbBackupDisableTriggers.Text = "Disable Triggers";
            this.cbBackupDisableTriggers.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBackupFileSize);
            this.groupBox7.Location = new System.Drawing.Point(504, 53);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(101, 40);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filesize (kb)";
            // 
            // txtBackupFileSize
            // 
            this.txtBackupFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackupFileSize.Location = new System.Drawing.Point(3, 16);
            this.txtBackupFileSize.Name = "txtBackupFileSize";
            this.txtBackupFileSize.Size = new System.Drawing.Size(95, 20);
            this.txtBackupFileSize.TabIndex = 1;
            this.txtBackupFileSize.Text = "4096";
            // 
            // hsRemoveBackupFile
            // 
            this.hsRemoveBackupFile.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveBackupFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveBackupFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveBackupFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveBackupFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveBackupFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveBackupFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveBackupFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveBackupFile.FlatAppearance.BorderSize = 0;
            this.hsRemoveBackupFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveBackupFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRemoveBackupFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveBackupFile.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsRemoveBackupFile.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsRemoveBackupFile.ImageToggleOnSelect = true;
            this.hsRemoveBackupFile.Location = new System.Drawing.Point(57, 10);
            this.hsRemoveBackupFile.Marked = false;
            this.hsRemoveBackupFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveBackupFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveBackupFile.MarkedText = "";
            this.hsRemoveBackupFile.MarkMode = false;
            this.hsRemoveBackupFile.Name = "hsRemoveBackupFile";
            this.hsRemoveBackupFile.NonMarkedText = "";
            this.hsRemoveBackupFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRemoveBackupFile.ShowShortcut = false;
            this.hsRemoveBackupFile.Size = new System.Drawing.Size(45, 32);
            this.hsRemoveBackupFile.TabIndex = 12;
            this.hsRemoveBackupFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveBackupFile.ToolTipActive = false;
            this.hsRemoveBackupFile.ToolTipAutomaticDelay = 500;
            this.hsRemoveBackupFile.ToolTipAutoPopDelay = 5000;
            this.hsRemoveBackupFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveBackupFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveBackupFile.ToolTipFor4ContextMenu = true;
            this.hsRemoveBackupFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveBackupFile.ToolTipInitialDelay = 500;
            this.hsRemoveBackupFile.ToolTipIsBallon = false;
            this.hsRemoveBackupFile.ToolTipOwnerDraw = false;
            this.hsRemoveBackupFile.ToolTipReshowDelay = 100;
            this.hsRemoveBackupFile.ToolTipShowAlways = false;
            this.hsRemoveBackupFile.ToolTipText = "";
            this.hsRemoveBackupFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveBackupFile.ToolTipTitle = "";
            this.hsRemoveBackupFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveBackupFile.UseVisualStyleBackColor = false;
            this.hsRemoveBackupFile.Click += new System.EventHandler(this.hsRemoveFile_Click);
            // 
            // gbBackupLocation
            // 
            this.gbBackupLocation.Controls.Add(this.txtBackupLocation);
            this.gbBackupLocation.Controls.Add(this.hsLoadBackupFile);
            this.gbBackupLocation.Location = new System.Drawing.Point(6, 48);
            this.gbBackupLocation.Name = "gbBackupLocation";
            this.gbBackupLocation.Size = new System.Drawing.Size(492, 48);
            this.gbBackupLocation.TabIndex = 2;
            this.gbBackupLocation.TabStop = false;
            this.gbBackupLocation.Text = "Backup Location";
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackupLocation.Location = new System.Drawing.Point(3, 16);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(457, 20);
            this.txtBackupLocation.TabIndex = 0;
            this.txtBackupLocation.Text = "D:\\temp\\test.fbk";
            // 
            // hsLoadBackupFile
            // 
            this.hsLoadBackupFile.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadBackupFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadBackupFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadBackupFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadBackupFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadBackupFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadBackupFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadBackupFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadBackupFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadBackupFile.FlatAppearance.BorderSize = 0;
            this.hsLoadBackupFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadBackupFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadBackupFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadBackupFile.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadBackupFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoadBackupFile.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadBackupFile.ImageToggleOnSelect = false;
            this.hsLoadBackupFile.Location = new System.Drawing.Point(460, 16);
            this.hsLoadBackupFile.Marked = false;
            this.hsLoadBackupFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadBackupFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadBackupFile.MarkedText = "";
            this.hsLoadBackupFile.MarkMode = false;
            this.hsLoadBackupFile.Name = "hsLoadBackupFile";
            this.hsLoadBackupFile.NonMarkedText = "";
            this.hsLoadBackupFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadBackupFile.ShowShortcut = false;
            this.hsLoadBackupFile.Size = new System.Drawing.Size(29, 29);
            this.hsLoadBackupFile.TabIndex = 3;
            this.hsLoadBackupFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadBackupFile.ToolTipActive = false;
            this.hsLoadBackupFile.ToolTipAutomaticDelay = 500;
            this.hsLoadBackupFile.ToolTipAutoPopDelay = 5000;
            this.hsLoadBackupFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadBackupFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadBackupFile.ToolTipFor4ContextMenu = true;
            this.hsLoadBackupFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadBackupFile.ToolTipInitialDelay = 500;
            this.hsLoadBackupFile.ToolTipIsBallon = false;
            this.hsLoadBackupFile.ToolTipOwnerDraw = false;
            this.hsLoadBackupFile.ToolTipReshowDelay = 100;
            this.hsLoadBackupFile.ToolTipShowAlways = false;
            this.hsLoadBackupFile.ToolTipText = "";
            this.hsLoadBackupFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadBackupFile.ToolTipTitle = "";
            this.hsLoadBackupFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadBackupFile.UseVisualStyleBackColor = false;
            this.hsLoadBackupFile.Click += new System.EventHandler(this.hsLoadBackupFile_Click);
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsBackup);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(1262, 43);
            this.pnlFieldUpper.TabIndex = 1;
            // 
            // hsBackup
            // 
            this.hsBackup.BackColor = System.Drawing.Color.Transparent;
            this.hsBackup.BackColorHover = System.Drawing.Color.Transparent;
            this.hsBackup.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsBackup.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsBackup.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsBackup.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsBackup.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsBackup.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsBackup.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsBackup.FlatAppearance.BorderSize = 0;
            this.hsBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsBackup.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsBackup.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsBackup.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsBackup.ImageToggleOnSelect = false;
            this.hsBackup.Location = new System.Drawing.Point(0, 0);
            this.hsBackup.Marked = false;
            this.hsBackup.MarkedColor = System.Drawing.Color.Teal;
            this.hsBackup.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsBackup.MarkedText = "";
            this.hsBackup.MarkMode = false;
            this.hsBackup.Name = "hsBackup";
            this.hsBackup.NonMarkedText = "Run Backup";
            this.hsBackup.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsBackup.ShowShortcut = false;
            this.hsBackup.Size = new System.Drawing.Size(111, 39);
            this.hsBackup.TabIndex = 1;
            this.hsBackup.Text = "Run Backup";
            this.hsBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsBackup.ToolTipActive = false;
            this.hsBackup.ToolTipAutomaticDelay = 500;
            this.hsBackup.ToolTipAutoPopDelay = 5000;
            this.hsBackup.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsBackup.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsBackup.ToolTipFor4ContextMenu = true;
            this.hsBackup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsBackup.ToolTipInitialDelay = 500;
            this.hsBackup.ToolTipIsBallon = false;
            this.hsBackup.ToolTipOwnerDraw = false;
            this.hsBackup.ToolTipReshowDelay = 100;
            this.hsBackup.ToolTipShowAlways = false;
            this.hsBackup.ToolTipText = "";
            this.hsBackup.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsBackup.ToolTipTitle = "";
            this.hsBackup.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsBackup.UseVisualStyleBackColor = false;
            this.hsBackup.Click += new System.EventHandler(this.hsBackup_Click);
            // 
            // tabPageRestore
            // 
            this.tabPageRestore.Controls.Add(this.pnRestoreCenter);
            this.tabPageRestore.Controls.Add(this.dgvDependenciesTo);
            this.tabPageRestore.Controls.Add(this.pnlRestoreUpper);
            this.tabPageRestore.Location = new System.Drawing.Point(4, 22);
            this.tabPageRestore.Name = "tabPageRestore";
            this.tabPageRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRestore.Size = new System.Drawing.Size(1268, 580);
            this.tabPageRestore.TabIndex = 1;
            this.tabPageRestore.Text = "Restore";
            this.tabPageRestore.UseVisualStyleBackColor = true;
            // 
            // pnRestoreCenter
            // 
            this.pnRestoreCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnRestoreCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnRestoreCenter.Controls.Add(this.gbRestoreLog);
            this.pnRestoreCenter.Controls.Add(this.gbRestoreFiles);
            this.pnRestoreCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRestoreCenter.Location = new System.Drawing.Point(3, 48);
            this.pnRestoreCenter.Name = "pnRestoreCenter";
            this.pnRestoreCenter.Size = new System.Drawing.Size(1262, 529);
            this.pnRestoreCenter.TabIndex = 23;
            // 
            // gbRestoreLog
            // 
            this.gbRestoreLog.Controls.Add(this.lvRestoreMessage);
            this.gbRestoreLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRestoreLog.Location = new System.Drawing.Point(617, 0);
            this.gbRestoreLog.Name = "gbRestoreLog";
            this.gbRestoreLog.Size = new System.Drawing.Size(641, 525);
            this.gbRestoreLog.TabIndex = 9;
            this.gbRestoreLog.TabStop = false;
            this.gbRestoreLog.Text = "Log";
            // 
            // lvRestoreMessage
            // 
            this.lvRestoreMessage.BackColor = System.Drawing.SystemColors.Info;
            this.lvRestoreMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.colRestoreMessage,
            this.colRestoreTime});
            this.lvRestoreMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRestoreMessage.FullRowSelect = true;
            this.lvRestoreMessage.GridLines = true;
            this.lvRestoreMessage.HideSelection = false;
            this.lvRestoreMessage.Location = new System.Drawing.Point(3, 16);
            this.lvRestoreMessage.Name = "lvRestoreMessage";
            this.lvRestoreMessage.Size = new System.Drawing.Size(635, 506);
            this.lvRestoreMessage.TabIndex = 1;
            this.lvRestoreMessage.UseCompatibleStateImageBehavior = false;
            this.lvRestoreMessage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cnt";
            this.columnHeader6.Width = 100;
            // 
            // colRestoreMessage
            // 
            this.colRestoreMessage.Text = "Message";
            this.colRestoreMessage.Width = 500;
            // 
            // colRestoreTime
            // 
            this.colRestoreTime.Text = "Timestamp";
            this.colRestoreTime.Width = 80;
            // 
            // gbRestoreFiles
            // 
            this.gbRestoreFiles.Controls.Add(this.lvRestore);
            this.gbRestoreFiles.Controls.Add(this.gbRestoreOptions);
            this.gbRestoreFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbRestoreFiles.Location = new System.Drawing.Point(0, 0);
            this.gbRestoreFiles.Name = "gbRestoreFiles";
            this.gbRestoreFiles.Size = new System.Drawing.Size(617, 525);
            this.gbRestoreFiles.TabIndex = 14;
            this.gbRestoreFiles.TabStop = false;
            this.gbRestoreFiles.Text = "Restore Files";
            // 
            // lvRestore
            // 
            this.lvRestore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRestore.FullRowSelect = true;
            this.lvRestore.GridLines = true;
            this.lvRestore.HideSelection = false;
            this.lvRestore.Location = new System.Drawing.Point(3, 16);
            this.lvRestore.Name = "lvRestore";
            this.lvRestore.Size = new System.Drawing.Size(611, 255);
            this.lvRestore.TabIndex = 0;
            this.lvRestore.UseCompatibleStateImageBehavior = false;
            this.lvRestore.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Restorefile";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size (kB)";
            this.columnHeader2.Width = 100;
            // 
            // gbRestoreOptions
            // 
            this.gbRestoreOptions.Controls.Add(this.cbRestoreInvidualCommit);
            this.gbRestoreOptions.Controls.Add(this.cbRestoreNoVaildy);
            this.gbRestoreOptions.Controls.Add(this.gbCreateReplace);
            this.gbRestoreOptions.Controls.Add(this.cbRestoreUseAllSpace);
            this.gbRestoreOptions.Controls.Add(this.cbRestoreNoShadows);
            this.gbRestoreOptions.Controls.Add(this.cbRestoreMetatdataOnly);
            this.gbRestoreOptions.Controls.Add(this.cbRestoreNoIndices);
            this.gbRestoreOptions.Controls.Add(this.gbRestoreFileSize);
            this.gbRestoreOptions.Controls.Add(this.hsAddRestoreFile);
            this.gbRestoreOptions.Controls.Add(this.hsRemoveRestoreFile);
            this.gbRestoreOptions.Controls.Add(this.gbRestoreFileName);
            this.gbRestoreOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbRestoreOptions.Location = new System.Drawing.Point(3, 271);
            this.gbRestoreOptions.Name = "gbRestoreOptions";
            this.gbRestoreOptions.Size = new System.Drawing.Size(611, 251);
            this.gbRestoreOptions.TabIndex = 15;
            this.gbRestoreOptions.TabStop = false;
            // 
            // cbRestoreInvidualCommit
            // 
            this.cbRestoreInvidualCommit.AutoSize = true;
            this.cbRestoreInvidualCommit.Location = new System.Drawing.Point(183, 226);
            this.cbRestoreInvidualCommit.Name = "cbRestoreInvidualCommit";
            this.cbRestoreInvidualCommit.Size = new System.Drawing.Size(155, 17);
            this.cbRestoreInvidualCommit.TabIndex = 20;
            this.cbRestoreInvidualCommit.Text = "Put commit after each table";
            this.cbRestoreInvidualCommit.UseVisualStyleBackColor = true;
            // 
            // cbRestoreNoVaildy
            // 
            this.cbRestoreNoVaildy.AutoSize = true;
            this.cbRestoreNoVaildy.Location = new System.Drawing.Point(183, 203);
            this.cbRestoreNoVaildy.Name = "cbRestoreNoVaildy";
            this.cbRestoreNoVaildy.Size = new System.Drawing.Size(193, 17);
            this.cbRestoreNoVaildy.TabIndex = 19;
            this.cbRestoreNoVaildy.Text = "Does not restore validity constraints";
            this.cbRestoreNoVaildy.UseVisualStyleBackColor = true;
            // 
            // gbCreateReplace
            // 
            this.gbCreateReplace.Controls.Add(this.rbCreateDatabase);
            this.gbCreateReplace.Controls.Add(this.rbReplaceDatabase);
            this.gbCreateReplace.Location = new System.Drawing.Point(6, 105);
            this.gbCreateReplace.Name = "gbCreateReplace";
            this.gbCreateReplace.Size = new System.Drawing.Size(160, 74);
            this.gbCreateReplace.TabIndex = 18;
            this.gbCreateReplace.TabStop = false;
            // 
            // rbCreateDatabase
            // 
            this.rbCreateDatabase.AutoSize = true;
            this.rbCreateDatabase.Location = new System.Drawing.Point(6, 42);
            this.rbCreateDatabase.Name = "rbCreateDatabase";
            this.rbCreateDatabase.Size = new System.Drawing.Size(126, 17);
            this.rbCreateDatabase.TabIndex = 1;
            this.rbCreateDatabase.Text = "Create new database";
            this.rbCreateDatabase.UseVisualStyleBackColor = true;
            this.rbCreateDatabase.CheckedChanged += new System.EventHandler(this.rbCreateDatabase_CheckedChanged);
            // 
            // rbReplaceDatabase
            // 
            this.rbReplaceDatabase.AutoSize = true;
            this.rbReplaceDatabase.Checked = true;
            this.rbReplaceDatabase.Location = new System.Drawing.Point(6, 19);
            this.rbReplaceDatabase.Name = "rbReplaceDatabase";
            this.rbReplaceDatabase.Size = new System.Drawing.Size(114, 17);
            this.rbReplaceDatabase.TabIndex = 0;
            this.rbReplaceDatabase.TabStop = true;
            this.rbReplaceDatabase.Text = "Replace Database";
            this.rbReplaceDatabase.UseVisualStyleBackColor = true;
            // 
            // cbRestoreUseAllSpace
            // 
            this.cbRestoreUseAllSpace.AutoSize = true;
            this.cbRestoreUseAllSpace.Checked = true;
            this.cbRestoreUseAllSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRestoreUseAllSpace.Location = new System.Drawing.Point(183, 180);
            this.cbRestoreUseAllSpace.Name = "cbRestoreUseAllSpace";
            this.cbRestoreUseAllSpace.Size = new System.Drawing.Size(275, 17);
            this.cbRestoreUseAllSpace.TabIndex = 17;
            this.cbRestoreUseAllSpace.Text = "Use all space (database pages will be filled to 100 %)";
            this.cbRestoreUseAllSpace.UseVisualStyleBackColor = true;
            // 
            // cbRestoreNoShadows
            // 
            this.cbRestoreNoShadows.AutoSize = true;
            this.cbRestoreNoShadows.Location = new System.Drawing.Point(183, 157);
            this.cbRestoreNoShadows.Name = "cbRestoreNoShadows";
            this.cbRestoreNoShadows.Size = new System.Drawing.Size(266, 17);
            this.cbRestoreNoShadows.TabIndex = 16;
            this.cbRestoreNoShadows.Text = "Not create shadows that are defined in the backup";
            this.cbRestoreNoShadows.UseVisualStyleBackColor = true;
            // 
            // cbRestoreMetatdataOnly
            // 
            this.cbRestoreMetatdataOnly.AutoSize = true;
            this.cbRestoreMetatdataOnly.Location = new System.Drawing.Point(183, 134);
            this.cbRestoreMetatdataOnly.Name = "cbRestoreMetatdataOnly";
            this.cbRestoreMetatdataOnly.Size = new System.Drawing.Size(186, 17);
            this.cbRestoreMetatdataOnly.TabIndex = 15;
            this.cbRestoreMetatdataOnly.Text = "Only restores metadata (schema). ";
            this.cbRestoreMetatdataOnly.UseVisualStyleBackColor = true;
            // 
            // cbRestoreNoIndices
            // 
            this.cbRestoreNoIndices.AutoSize = true;
            this.cbRestoreNoIndices.Checked = true;
            this.cbRestoreNoIndices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRestoreNoIndices.Location = new System.Drawing.Point(183, 111);
            this.cbRestoreNoIndices.Name = "cbRestoreNoIndices";
            this.cbRestoreNoIndices.Size = new System.Drawing.Size(169, 17);
            this.cbRestoreNoIndices.TabIndex = 14;
            this.cbRestoreNoIndices.Text = "Restore all indexes as inactive";
            this.cbRestoreNoIndices.UseVisualStyleBackColor = true;
            // 
            // gbRestoreFileSize
            // 
            this.gbRestoreFileSize.Controls.Add(this.txtRestoreFileSize);
            this.gbRestoreFileSize.Location = new System.Drawing.Point(504, 53);
            this.gbRestoreFileSize.Name = "gbRestoreFileSize";
            this.gbRestoreFileSize.Size = new System.Drawing.Size(101, 40);
            this.gbRestoreFileSize.TabIndex = 13;
            this.gbRestoreFileSize.TabStop = false;
            this.gbRestoreFileSize.Text = "Filesize (kb)";
            // 
            // txtRestoreFileSize
            // 
            this.txtRestoreFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreFileSize.Location = new System.Drawing.Point(3, 16);
            this.txtRestoreFileSize.Name = "txtRestoreFileSize";
            this.txtRestoreFileSize.Size = new System.Drawing.Size(95, 20);
            this.txtRestoreFileSize.TabIndex = 1;
            this.txtRestoreFileSize.Text = "4096";
            // 
            // hsAddRestoreFile
            // 
            this.hsAddRestoreFile.BackColor = System.Drawing.Color.Transparent;
            this.hsAddRestoreFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddRestoreFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddRestoreFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddRestoreFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddRestoreFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddRestoreFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddRestoreFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsAddRestoreFile.FlatAppearance.BorderSize = 0;
            this.hsAddRestoreFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddRestoreFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddRestoreFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddRestoreFile.Image = global::FBXpert.Properties.Resources.plus_gn22x;
            this.hsAddRestoreFile.ImageHover = global::FBXpert.Properties.Resources.plus_blue22x;
            this.hsAddRestoreFile.ImageToggleOnSelect = true;
            this.hsAddRestoreFile.Location = new System.Drawing.Point(9, 9);
            this.hsAddRestoreFile.Marked = false;
            this.hsAddRestoreFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddRestoreFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddRestoreFile.MarkedText = "";
            this.hsAddRestoreFile.MarkMode = false;
            this.hsAddRestoreFile.Name = "hsAddRestoreFile";
            this.hsAddRestoreFile.NonMarkedText = "";
            this.hsAddRestoreFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddRestoreFile.ShowShortcut = false;
            this.hsAddRestoreFile.Size = new System.Drawing.Size(45, 32);
            this.hsAddRestoreFile.TabIndex = 11;
            this.hsAddRestoreFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddRestoreFile.ToolTipActive = false;
            this.hsAddRestoreFile.ToolTipAutomaticDelay = 500;
            this.hsAddRestoreFile.ToolTipAutoPopDelay = 5000;
            this.hsAddRestoreFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddRestoreFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddRestoreFile.ToolTipFor4ContextMenu = true;
            this.hsAddRestoreFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddRestoreFile.ToolTipInitialDelay = 500;
            this.hsAddRestoreFile.ToolTipIsBallon = false;
            this.hsAddRestoreFile.ToolTipOwnerDraw = false;
            this.hsAddRestoreFile.ToolTipReshowDelay = 100;
            this.hsAddRestoreFile.ToolTipShowAlways = false;
            this.hsAddRestoreFile.ToolTipText = "";
            this.hsAddRestoreFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddRestoreFile.ToolTipTitle = "";
            this.hsAddRestoreFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddRestoreFile.UseVisualStyleBackColor = false;
            this.hsAddRestoreFile.Click += new System.EventHandler(this.hsAddRestoreFile_Click);
            // 
            // hsRemoveRestoreFile
            // 
            this.hsRemoveRestoreFile.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveRestoreFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveRestoreFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveRestoreFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveRestoreFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveRestoreFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveRestoreFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveRestoreFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRemoveRestoreFile.FlatAppearance.BorderSize = 0;
            this.hsRemoveRestoreFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveRestoreFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRemoveRestoreFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveRestoreFile.Image = global::FBXpert.Properties.Resources.minus_gn24x;
            this.hsRemoveRestoreFile.ImageHover = global::FBXpert.Properties.Resources.minus_blue24x;
            this.hsRemoveRestoreFile.ImageToggleOnSelect = true;
            this.hsRemoveRestoreFile.Location = new System.Drawing.Point(57, 9);
            this.hsRemoveRestoreFile.Marked = false;
            this.hsRemoveRestoreFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveRestoreFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveRestoreFile.MarkedText = "";
            this.hsRemoveRestoreFile.MarkMode = false;
            this.hsRemoveRestoreFile.Name = "hsRemoveRestoreFile";
            this.hsRemoveRestoreFile.NonMarkedText = "";
            this.hsRemoveRestoreFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRemoveRestoreFile.ShowShortcut = false;
            this.hsRemoveRestoreFile.Size = new System.Drawing.Size(45, 32);
            this.hsRemoveRestoreFile.TabIndex = 12;
            this.hsRemoveRestoreFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveRestoreFile.ToolTipActive = false;
            this.hsRemoveRestoreFile.ToolTipAutomaticDelay = 500;
            this.hsRemoveRestoreFile.ToolTipAutoPopDelay = 5000;
            this.hsRemoveRestoreFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveRestoreFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveRestoreFile.ToolTipFor4ContextMenu = true;
            this.hsRemoveRestoreFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveRestoreFile.ToolTipInitialDelay = 500;
            this.hsRemoveRestoreFile.ToolTipIsBallon = false;
            this.hsRemoveRestoreFile.ToolTipOwnerDraw = false;
            this.hsRemoveRestoreFile.ToolTipReshowDelay = 100;
            this.hsRemoveRestoreFile.ToolTipShowAlways = false;
            this.hsRemoveRestoreFile.ToolTipText = "";
            this.hsRemoveRestoreFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveRestoreFile.ToolTipTitle = "";
            this.hsRemoveRestoreFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveRestoreFile.UseVisualStyleBackColor = false;
            this.hsRemoveRestoreFile.Click += new System.EventHandler(this.hsRemoveRestoreFile_Click);
            // 
            // gbRestoreFileName
            // 
            this.gbRestoreFileName.Controls.Add(this.txtRestoreLocation);
            this.gbRestoreFileName.Controls.Add(this.hsLoadRestoreFile);
            this.gbRestoreFileName.Location = new System.Drawing.Point(6, 48);
            this.gbRestoreFileName.Name = "gbRestoreFileName";
            this.gbRestoreFileName.Size = new System.Drawing.Size(492, 48);
            this.gbRestoreFileName.TabIndex = 2;
            this.gbRestoreFileName.TabStop = false;
            this.gbRestoreFileName.Text = "Restore Location";
            // 
            // txtRestoreLocation
            // 
            this.txtRestoreLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreLocation.Location = new System.Drawing.Point(3, 16);
            this.txtRestoreLocation.Name = "txtRestoreLocation";
            this.txtRestoreLocation.Size = new System.Drawing.Size(457, 20);
            this.txtRestoreLocation.TabIndex = 0;
            this.txtRestoreLocation.Text = "D:\\temp\\test.fbk";
            // 
            // hsLoadRestoreFile
            // 
            this.hsLoadRestoreFile.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadRestoreFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadRestoreFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadRestoreFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadRestoreFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadRestoreFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadRestoreFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadRestoreFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadRestoreFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadRestoreFile.FlatAppearance.BorderSize = 0;
            this.hsLoadRestoreFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadRestoreFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadRestoreFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadRestoreFile.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadRestoreFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoadRestoreFile.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadRestoreFile.ImageToggleOnSelect = false;
            this.hsLoadRestoreFile.Location = new System.Drawing.Point(460, 16);
            this.hsLoadRestoreFile.Marked = false;
            this.hsLoadRestoreFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadRestoreFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadRestoreFile.MarkedText = "";
            this.hsLoadRestoreFile.MarkMode = false;
            this.hsLoadRestoreFile.Name = "hsLoadRestoreFile";
            this.hsLoadRestoreFile.NonMarkedText = "";
            this.hsLoadRestoreFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadRestoreFile.ShowShortcut = false;
            this.hsLoadRestoreFile.Size = new System.Drawing.Size(29, 29);
            this.hsLoadRestoreFile.TabIndex = 3;
            this.hsLoadRestoreFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadRestoreFile.ToolTipActive = false;
            this.hsLoadRestoreFile.ToolTipAutomaticDelay = 500;
            this.hsLoadRestoreFile.ToolTipAutoPopDelay = 5000;
            this.hsLoadRestoreFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadRestoreFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadRestoreFile.ToolTipFor4ContextMenu = true;
            this.hsLoadRestoreFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadRestoreFile.ToolTipInitialDelay = 500;
            this.hsLoadRestoreFile.ToolTipIsBallon = false;
            this.hsLoadRestoreFile.ToolTipOwnerDraw = false;
            this.hsLoadRestoreFile.ToolTipReshowDelay = 100;
            this.hsLoadRestoreFile.ToolTipShowAlways = false;
            this.hsLoadRestoreFile.ToolTipText = "";
            this.hsLoadRestoreFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadRestoreFile.ToolTipTitle = "";
            this.hsLoadRestoreFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadRestoreFile.UseVisualStyleBackColor = false;
            this.hsLoadRestoreFile.Click += new System.EventHandler(this.hsLoadRestoreFile_Click);
            // 
            // dgvDependenciesTo
            // 
            this.dgvDependenciesTo.AllowUserToAddRows = false;
            this.dgvDependenciesTo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.dgvDependenciesTo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDependenciesTo.AutoGenerateColumns = false;
            this.dgvDependenciesTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDependenciesTo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependenciesTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependenciesTo.DataSource = this.bsDependenciesTo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependenciesTo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDependenciesTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependenciesTo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDependenciesTo.EnableHeadersVisualStyles = false;
            this.dgvDependenciesTo.Location = new System.Drawing.Point(3, 48);
            this.dgvDependenciesTo.MultiSelect = false;
            this.dgvDependenciesTo.Name = "dgvDependenciesTo";
            this.dgvDependenciesTo.ReadOnly = true;
            this.dgvDependenciesTo.RowHeadersVisible = false;
            this.dgvDependenciesTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDependenciesTo.Size = new System.Drawing.Size(1262, 529);
            this.dgvDependenciesTo.TabIndex = 22;
            // 
            // bsDependenciesTo
            // 
            this.bsDependenciesTo.DataSource = this.dsDependenciesTo;
            this.bsDependenciesTo.Position = 0;
            // 
            // dsDependenciesTo
            // 
            this.dsDependenciesTo.DataSetName = "NewDataSet";
            this.dsDependenciesTo.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable5});
            // 
            // dataTable5
            // 
            this.dataTable5.TableName = "Table";
            // 
            // pnlRestoreUpper
            // 
            this.pnlRestoreUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRestoreUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRestoreUpper.Controls.Add(this.groupBox1);
            this.pnlRestoreUpper.Controls.Add(this.hsRestore);
            this.pnlRestoreUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRestoreUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlRestoreUpper.Name = "pnlRestoreUpper";
            this.pnlRestoreUpper.Size = new System.Drawing.Size(1262, 45);
            this.pnlRestoreUpper.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRestoreDestinationDatabasePath);
            this.groupBox1.Controls.Add(this.hotSpot1);
            this.groupBox1.Location = new System.Drawing.Point(186, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 38);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Location";
            // 
            // txtRestoreDestinationDatabasePath
            // 
            this.txtRestoreDestinationDatabasePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreDestinationDatabasePath.Location = new System.Drawing.Point(3, 16);
            this.txtRestoreDestinationDatabasePath.Name = "txtRestoreDestinationDatabasePath";
            this.txtRestoreDestinationDatabasePath.Size = new System.Drawing.Size(457, 20);
            this.txtRestoreDestinationDatabasePath.TabIndex = 0;
            this.txtRestoreDestinationDatabasePath.Text = "D:\\temp\\test.fbk";
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
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hotSpot1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hotSpot1.ImageToggleOnSelect = false;
            this.hotSpot1.Location = new System.Drawing.Point(460, 16);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(29, 19);
            this.hotSpot1.TabIndex = 3;
            this.hotSpot1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // hsRestore
            // 
            this.hsRestore.BackColor = System.Drawing.Color.Transparent;
            this.hsRestore.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRestore.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRestore.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRestore.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRestore.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRestore.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRestore.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRestore.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRestore.FlatAppearance.BorderSize = 0;
            this.hsRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRestore.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRestore.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRestore.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsRestore.ImageToggleOnSelect = false;
            this.hsRestore.Location = new System.Drawing.Point(0, 0);
            this.hsRestore.Marked = false;
            this.hsRestore.MarkedColor = System.Drawing.Color.Teal;
            this.hsRestore.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRestore.MarkedText = "";
            this.hsRestore.MarkMode = false;
            this.hsRestore.Name = "hsRestore";
            this.hsRestore.NonMarkedText = "Run Restore";
            this.hsRestore.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRestore.ShowShortcut = false;
            this.hsRestore.Size = new System.Drawing.Size(105, 41);
            this.hsRestore.TabIndex = 2;
            this.hsRestore.Text = "Run Restore";
            this.hsRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRestore.ToolTipActive = false;
            this.hsRestore.ToolTipAutomaticDelay = 500;
            this.hsRestore.ToolTipAutoPopDelay = 5000;
            this.hsRestore.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRestore.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRestore.ToolTipFor4ContextMenu = true;
            this.hsRestore.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRestore.ToolTipInitialDelay = 500;
            this.hsRestore.ToolTipIsBallon = false;
            this.hsRestore.ToolTipOwnerDraw = false;
            this.hsRestore.ToolTipReshowDelay = 100;
            this.hsRestore.ToolTipShowAlways = false;
            this.hsRestore.ToolTipText = "";
            this.hsRestore.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRestore.ToolTipTitle = "";
            this.hsRestore.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRestore.UseVisualStyleBackColor = false;
            this.hsRestore.Click += new System.EventHandler(this.hsRestore_Click);
            // 
            // dsDependenciesFrom
            // 
            this.dsDependenciesFrom.DataSetName = "NewDataSet";
            this.dsDependenciesFrom.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable6});
            // 
            // dataTable6
            // 
            this.dataTable6.TableName = "Table";
            // 
            // bsDependenciesFrom
            // 
            this.bsDependenciesFrom.DataSource = this.dsDependenciesFrom;
            this.bsDependenciesFrom.Position = 0;
            // 
            // ofdBackup
            // 
            this.ofdBackup.CheckFileExists = false;
            this.ofdBackup.DefaultExt = "*.fbk";
            this.ofdBackup.FileName = "ofdDBLocation";
            this.ofdBackup.Filter = "Firebird Backup|*.fbk|All|*.*";
            // 
            // ofdRestore
            // 
            this.ofdRestore.CheckFileExists = false;
            this.ofdRestore.CheckPathExists = false;
            this.ofdRestore.FileName = "openFileDialog2";
            // 
            // ofdRestoreFromDatabase
            // 
            this.ofdRestoreFromDatabase.DefaultExt = "*.fdb";
            this.ofdRestoreFromDatabase.Filter = "*.fdb|Firebird DB|*.*|All";
            this.ofdRestoreFromDatabase.Multiselect = true;
            // 
            // ofdDatabase
            // 
            this.ofdDatabase.CheckFileExists = false;
            this.ofdDatabase.DefaultExt = "*.fbd";
            this.ofdDatabase.FileName = "ofdDBLocation";
            this.ofdDatabase.Filter = "Firebird Database|*.fdb|All|*.*";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 680);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupForm";
            this.Text = "BackupForm";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageBackup.ResumeLayout(false);
            this.pnlFieldsCenter.ResumeLayout(false);
            this.gbBackupLog.ResumeLayout(false);
            this.gbBackupOptions.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbConnectionType.ResumeLayout(false);
            this.gbConnectionType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbBackupLocation.ResumeLayout(false);
            this.gbBackupLocation.PerformLayout();
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabPageRestore.ResumeLayout(false);
            this.pnRestoreCenter.ResumeLayout(false);
            this.gbRestoreLog.ResumeLayout(false);
            this.gbRestoreFiles.ResumeLayout(false);
            this.gbRestoreOptions.ResumeLayout(false);
            this.gbRestoreOptions.PerformLayout();
            this.gbCreateReplace.ResumeLayout(false);
            this.gbCreateReplace.PerformLayout();
            this.gbRestoreFileSize.ResumeLayout(false);
            this.gbRestoreFileSize.PerformLayout();
            this.gbRestoreFileName.ResumeLayout(false);
            this.gbRestoreFileName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.pnlRestoreUpper.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDependenciesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDependenciesFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.GroupBox gbBackupLog;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private SeControlsLib.HotSpot hsBackup;
        private System.Windows.Forms.TabPage tabPageRestore;
        private System.Windows.Forms.DataGridView dgvDependenciesTo;
        private System.Windows.Forms.Panel pnlRestoreUpper;
        private System.Windows.Forms.BindingSource bsDependenciesTo;
        private System.Data.DataSet dsDependenciesTo;
        private System.Data.DataTable dataTable5;
        private System.Data.DataSet dsDependenciesFrom;
        private System.Data.DataTable dataTable6;
        private System.Windows.Forms.BindingSource bsDependenciesFrom;
        private System.Windows.Forms.GroupBox gbBackupLocation;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private SeControlsLib.HotSpot hsLoadBackupFile;
        private System.Windows.Forms.OpenFileDialog ofdBackup;
        private System.Windows.Forms.Panel pnRestoreCenter;
        private System.Windows.Forms.GroupBox gbRestoreLog;
        private SeControlsLib.HotSpot hsRestore;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbBackupMetatdataOnly;
        private System.Windows.Forms.CheckBox cbBackupDisableTriggers;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBackupFileSize;
        private SeControlsLib.HotSpot hsAddBackupFile;
        private SeControlsLib.HotSpot hsRemoveBackupFile;
        private System.Windows.Forms.GroupBox gbBackupOptions;
        private System.Windows.Forms.CheckBox cbBackupIgnoreChecksum;
        private System.Windows.Forms.CheckBox cbBackupGarbageCollect;
        private System.Windows.Forms.ListView lvBackup;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.GroupBox gbRestoreOptions;
        private System.Windows.Forms.CheckBox cbRestoreUseAllSpace;
        private System.Windows.Forms.CheckBox cbRestoreNoShadows;
        private System.Windows.Forms.CheckBox cbRestoreMetatdataOnly;
        private System.Windows.Forms.CheckBox cbRestoreNoIndices;
        private System.Windows.Forms.GroupBox gbRestoreFileSize;
        private System.Windows.Forms.TextBox txtRestoreFileSize;
        private SeControlsLib.HotSpot hsAddRestoreFile;
        private SeControlsLib.HotSpot hsRemoveRestoreFile;
        private System.Windows.Forms.GroupBox gbRestoreFileName;
        private System.Windows.Forms.TextBox txtRestoreLocation;
        private SeControlsLib.HotSpot hsLoadRestoreFile;
        private System.Windows.Forms.GroupBox gbRestoreFiles;
        private System.Windows.Forms.ListView lvRestore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox cbBackupTransportable;
        private System.Windows.Forms.CheckBox cbBackupOldDescriptions;
        private System.Windows.Forms.CheckBox cbBackupConvert;
        private System.Windows.Forms.CheckBox cbBackupLimbo;
        private System.Windows.Forms.CheckBox cbBackupExpand;
        private System.Windows.Forms.GroupBox gbCreateReplace;
        private System.Windows.Forms.RadioButton rbCreateDatabase;
        private System.Windows.Forms.RadioButton rbReplaceDatabase;
        private System.Windows.Forms.CheckBox cbRestoreNoVaildy;
        private System.Windows.Forms.CheckBox cbRestoreInvidualCommit;
        private System.Windows.Forms.ListView lvRestoreMessage;
        private System.Windows.Forms.ColumnHeader colRestoreMessage;
        private System.Windows.Forms.ColumnHeader colRestoreTime;
        private System.Windows.Forms.ListView lvBackupMessage;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRestoreDestinationDatabasePath;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.OpenFileDialog ofdRestore;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.OpenFileDialog ofdRestoreFromDatabase;
        private System.Windows.Forms.CheckBox cbUseLocalhost;
        private System.Windows.Forms.GroupBox gbConnectionType;
        private System.Windows.Forms.RadioButton rbEmbedded;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.RadioButton rbRemote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBackupSourceDatabasePath;
        private SeControlsLib.HotSpot hsChooseDatabase;
        private System.Windows.Forms.OpenFileDialog ofdDatabase;
    }
}