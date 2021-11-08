using BasicForms;

namespace FBXpert.SonstForms
{
    partial class AppSettingsForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsForm));
            this.pnlFormUpper = new System.Windows.Forms.Panel();
            this.hsSave = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPagePathSettings = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbSQLHistoryPath = new System.Windows.Forms.GroupBox();
            this.txtSQLHistoryPath = new System.Windows.Forms.TextBox();
            this.hsSQLHistoryPath = new SeControlsLib.HotSpot();
            this.gbSQLExportPath = new System.Windows.Forms.GroupBox();
            this.txtSQLExportPath = new System.Windows.Forms.TextBox();
            this.hsLoadSQLExportPath = new SeControlsLib.HotSpot();
            this.gbInfoPath = new System.Windows.Forms.GroupBox();
            this.txtInfoPath = new System.Windows.Forms.TextBox();
            this.hsLoadInfoPath = new SeControlsLib.HotSpot();
            this.gbExportPath = new System.Windows.Forms.GroupBox();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.hsLoadExportPath = new SeControlsLib.HotSpot();
            this.dbDatabaseConfigFile = new System.Windows.Forms.GroupBox();
            this.txtDatabasesConfigFile = new System.Windows.Forms.TextBox();
            this.hsDatabaseConfigFile = new SeControlsLib.HotSpot();
            this.gbDatabasesConfigPath = new System.Windows.Forms.GroupBox();
            this.txtDatabasesConfigPath = new System.Windows.Forms.TextBox();
            this.hsDatabasesConfigPath = new SeControlsLib.HotSpot();
            this.gbTempPath = new System.Windows.Forms.GroupBox();
            this.txtTemporaryPath = new System.Windows.Forms.TextBox();
            this.hsTemporaryPath = new SeControlsLib.HotSpot();
            this.gbScriptingPath = new System.Windows.Forms.GroupBox();
            this.txtScriptingPath = new System.Windows.Forms.TextBox();
            this.hsScriptingPath = new SeControlsLib.HotSpot();
            this.pnlPathSettingsUpper = new System.Windows.Forms.Panel();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.tabSQLVariables = new System.Windows.Forms.TabPage();
            this.pnlSQLVariables = new System.Windows.Forms.Panel();
            this.gbSQLInitialTerminator = new System.Windows.Forms.GroupBox();
            this.txtSQLInitialTerminator = new System.Windows.Forms.TextBox();
            this.gbSQLAlternativeTerminator = new System.Windows.Forms.GroupBox();
            this.txtSQLAlternativeTerminator = new System.Windows.Forms.TextBox();
            this.gbSQLSingleLineCommand = new System.Windows.Forms.GroupBox();
            this.txtSQLSingleLineCommand = new System.Windows.Forms.TextBox();
            this.gbSQLMaxRowSelect = new System.Windows.Forms.GroupBox();
            this.txtSQLMaxRowForSelect = new System.Windows.Forms.TextBox();
            this.gbSkipForSelect = new System.Windows.Forms.GroupBox();
            this.txtSkipForSelect = new System.Windows.Forms.TextBox();
            this.gbSQLNewLine = new System.Windows.Forms.GroupBox();
            this.txtSQLNewLine = new System.Windows.Forms.TextBox();
            this.gbSQLCommentEnd = new System.Windows.Forms.GroupBox();
            this.txtSQLCommentEnd = new System.Windows.Forms.TextBox();
            this.gbSQLCommentStart = new System.Windows.Forms.GroupBox();
            this.txtSQLCommentStart = new System.Windows.Forms.TextBox();
            this.pnlSQLVariablesUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.tabDatabaseDefaults = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbOpenDatabasesCount = new System.Windows.Forms.GroupBox();
            this.numOpenDatabaseCount = new System.Windows.Forms.NumericUpDown();
            this.gbDefaultPort = new System.Windows.Forms.GroupBox();
            this.numDefaultPort = new System.Windows.Forms.NumericUpDown();
            this.gbDefaultPassword = new System.Windows.Forms.GroupBox();
            this.txtDefaultPassword = new System.Windows.Forms.TextBox();
            this.gbDefaulUser = new System.Windows.Forms.GroupBox();
            this.txtDefaulUser = new System.Windows.Forms.TextBox();
            this.gbDefaultPacketSize = new System.Windows.Forms.GroupBox();
            this.numDefaultPacketSize = new System.Windows.Forms.NumericUpDown();
            this.pnlDatabseDefaultsUpper = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlFormUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPagePathSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbSQLHistoryPath.SuspendLayout();
            this.gbSQLExportPath.SuspendLayout();
            this.gbInfoPath.SuspendLayout();
            this.gbExportPath.SuspendLayout();
            this.dbDatabaseConfigFile.SuspendLayout();
            this.gbDatabasesConfigPath.SuspendLayout();
            this.gbTempPath.SuspendLayout();
            this.gbScriptingPath.SuspendLayout();
            this.pnlPathSettingsUpper.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldUpper.SuspendLayout();
            this.tabSQLVariables.SuspendLayout();
            this.pnlSQLVariables.SuspendLayout();
            this.gbSQLInitialTerminator.SuspendLayout();
            this.gbSQLAlternativeTerminator.SuspendLayout();
            this.gbSQLSingleLineCommand.SuspendLayout();
            this.gbSQLMaxRowSelect.SuspendLayout();
            this.gbSkipForSelect.SuspendLayout();
            this.gbSQLNewLine.SuspendLayout();
            this.gbSQLCommentEnd.SuspendLayout();
            this.gbSQLCommentStart.SuspendLayout();
            this.pnlSQLVariablesUpper.SuspendLayout();
            this.tabDatabaseDefaults.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbOpenDatabasesCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpenDatabaseCount)).BeginInit();
            this.gbDefaultPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPort)).BeginInit();
            this.gbDefaultPassword.SuspendLayout();
            this.gbDefaulUser.SuspendLayout();
            this.gbDefaultPacketSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPacketSize)).BeginInit();
            this.pnlDatabseDefaultsUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormUpper
            // 
            this.pnlFormUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFormUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFormUpper.Controls.Add(this.hsSave);
            this.pnlFormUpper.Controls.Add(this.hsClose);
            this.pnlFormUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUpper.Name = "pnlFormUpper";
            this.pnlFormUpper.Size = new System.Drawing.Size(935, 45);
            this.pnlFormUpper.TabIndex = 0;
            // 
            // hsSave
            // 
            this.hsSave.BackColor = System.Drawing.Color.Transparent;
            this.hsSave.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSave.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSave.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSave.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSave.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSave.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSave.FlatAppearance.BorderSize = 0;
            this.hsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSave.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSave.Image = global::FBXpert.Properties.Resources.ok_gn32x;
            this.hsSave.ImageHover = global::FBXpert.Properties.Resources.ok_blue32x;
            this.hsSave.ImageToggleOnSelect = true;
            this.hsSave.Location = new System.Drawing.Point(45, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "";
            this.hsSave.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSave.ShortcutNewline = false;
            this.hsSave.ShowShortcut = false;
            this.hsSave.Size = new System.Drawing.Size(45, 41);
            this.hsSave.TabIndex = 4;
            this.hsSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSave.ToolTipActive = false;
            this.hsSave.ToolTipAutomaticDelay = 500;
            this.hsSave.ToolTipAutoPopDelay = 5000;
            this.hsSave.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSave.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSave.ToolTipFor4ContextMenu = true;
            this.hsSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSave.ToolTipInitialDelay = 500;
            this.hsSave.ToolTipIsBallon = false;
            this.hsSave.ToolTipOwnerDraw = false;
            this.hsSave.ToolTipReshowDelay = 100;
            this.hsSave.ToolTipShowAlways = false;
            this.hsSave.ToolTipText = "";
            this.hsSave.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSave.ToolTipTitle = "";
            this.hsSave.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSave.UseVisualStyleBackColor = false;
            this.hsSave.Click += new System.EventHandler(this.hsSave_Click);
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
            this.hsClose.ShortcutNewline = false;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(45, 41);
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
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 45);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(935, 513);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPagePathSettings);
            this.tabControlFields.Controls.Add(this.tabPageFieldEdit);
            this.tabControlFields.Controls.Add(this.tabSQLVariables);
            this.tabControlFields.Controls.Add(this.tabDatabaseDefaults);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(931, 509);
            this.tabControlFields.TabIndex = 18;
            // 
            // tabPagePathSettings
            // 
            this.tabPagePathSettings.Controls.Add(this.panel4);
            this.tabPagePathSettings.Controls.Add(this.pnlPathSettingsUpper);
            this.tabPagePathSettings.Location = new System.Drawing.Point(4, 23);
            this.tabPagePathSettings.Name = "tabPagePathSettings";
            this.tabPagePathSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePathSettings.Size = new System.Drawing.Size(923, 482);
            this.tabPagePathSettings.TabIndex = 3;
            this.tabPagePathSettings.Text = "Path settings";
            this.tabPagePathSettings.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.gbSQLHistoryPath);
            this.panel4.Controls.Add(this.gbSQLExportPath);
            this.panel4.Controls.Add(this.gbInfoPath);
            this.panel4.Controls.Add(this.gbExportPath);
            this.panel4.Controls.Add(this.dbDatabaseConfigFile);
            this.panel4.Controls.Add(this.gbDatabasesConfigPath);
            this.panel4.Controls.Add(this.gbTempPath);
            this.panel4.Controls.Add(this.gbScriptingPath);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 430);
            this.panel4.TabIndex = 4;
            // 
            // gbSQLHistoryPath
            // 
            this.gbSQLHistoryPath.Controls.Add(this.txtSQLHistoryPath);
            this.gbSQLHistoryPath.Controls.Add(this.hsSQLHistoryPath);
            this.gbSQLHistoryPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSQLHistoryPath.Location = new System.Drawing.Point(0, 364);
            this.gbSQLHistoryPath.Name = "gbSQLHistoryPath";
            this.gbSQLHistoryPath.Size = new System.Drawing.Size(917, 52);
            this.gbSQLHistoryPath.TabIndex = 10;
            this.gbSQLHistoryPath.TabStop = false;
            this.gbSQLHistoryPath.Text = "SQL Histroy Path";
            // 
            // txtSQLHistoryPath
            // 
            this.txtSQLHistoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLHistoryPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLHistoryPath.Location = new System.Drawing.Point(3, 18);
            this.txtSQLHistoryPath.Name = "txtSQLHistoryPath";
            this.txtSQLHistoryPath.Size = new System.Drawing.Size(853, 20);
            this.txtSQLHistoryPath.TabIndex = 0;
            // 
            // hsSQLHistoryPath
            // 
            this.hsSQLHistoryPath.BackColor = System.Drawing.Color.Transparent;
            this.hsSQLHistoryPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSQLHistoryPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSQLHistoryPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSQLHistoryPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSQLHistoryPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSQLHistoryPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSQLHistoryPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSQLHistoryPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSQLHistoryPath.FlatAppearance.BorderSize = 0;
            this.hsSQLHistoryPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSQLHistoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSQLHistoryPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSQLHistoryPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsSQLHistoryPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsSQLHistoryPath.ImageToggleOnSelect = false;
            this.hsSQLHistoryPath.Location = new System.Drawing.Point(856, 18);
            this.hsSQLHistoryPath.Marked = false;
            this.hsSQLHistoryPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsSQLHistoryPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSQLHistoryPath.MarkedText = "";
            this.hsSQLHistoryPath.MarkMode = false;
            this.hsSQLHistoryPath.Name = "hsSQLHistoryPath";
            this.hsSQLHistoryPath.NonMarkedText = "...";
            this.hsSQLHistoryPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSQLHistoryPath.ShortcutNewline = false;
            this.hsSQLHistoryPath.ShowShortcut = false;
            this.hsSQLHistoryPath.Size = new System.Drawing.Size(58, 31);
            this.hsSQLHistoryPath.TabIndex = 3;
            this.hsSQLHistoryPath.Text = "...";
            this.hsSQLHistoryPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSQLHistoryPath.ToolTipActive = false;
            this.hsSQLHistoryPath.ToolTipAutomaticDelay = 500;
            this.hsSQLHistoryPath.ToolTipAutoPopDelay = 5000;
            this.hsSQLHistoryPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSQLHistoryPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSQLHistoryPath.ToolTipFor4ContextMenu = true;
            this.hsSQLHistoryPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSQLHistoryPath.ToolTipInitialDelay = 500;
            this.hsSQLHistoryPath.ToolTipIsBallon = false;
            this.hsSQLHistoryPath.ToolTipOwnerDraw = false;
            this.hsSQLHistoryPath.ToolTipReshowDelay = 100;
            this.hsSQLHistoryPath.ToolTipShowAlways = false;
            this.hsSQLHistoryPath.ToolTipText = "";
            this.hsSQLHistoryPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSQLHistoryPath.ToolTipTitle = "";
            this.hsSQLHistoryPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSQLHistoryPath.UseVisualStyleBackColor = false;
            this.hsSQLHistoryPath.Click += new System.EventHandler(this.hsSQLHistoryPath_Click);
            // 
            // gbSQLExportPath
            // 
            this.gbSQLExportPath.Controls.Add(this.txtSQLExportPath);
            this.gbSQLExportPath.Controls.Add(this.hsLoadSQLExportPath);
            this.gbSQLExportPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSQLExportPath.Location = new System.Drawing.Point(0, 312);
            this.gbSQLExportPath.Name = "gbSQLExportPath";
            this.gbSQLExportPath.Size = new System.Drawing.Size(917, 52);
            this.gbSQLExportPath.TabIndex = 9;
            this.gbSQLExportPath.TabStop = false;
            this.gbSQLExportPath.Text = "SQL Export Path";
            // 
            // txtSQLExportPath
            // 
            this.txtSQLExportPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLExportPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLExportPath.Location = new System.Drawing.Point(3, 18);
            this.txtSQLExportPath.Name = "txtSQLExportPath";
            this.txtSQLExportPath.Size = new System.Drawing.Size(853, 20);
            this.txtSQLExportPath.TabIndex = 0;
            // 
            // hsLoadSQLExportPath
            // 
            this.hsLoadSQLExportPath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadSQLExportPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadSQLExportPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadSQLExportPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadSQLExportPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadSQLExportPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadSQLExportPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadSQLExportPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadSQLExportPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadSQLExportPath.FlatAppearance.BorderSize = 0;
            this.hsLoadSQLExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadSQLExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadSQLExportPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadSQLExportPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadSQLExportPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadSQLExportPath.ImageToggleOnSelect = false;
            this.hsLoadSQLExportPath.Location = new System.Drawing.Point(856, 18);
            this.hsLoadSQLExportPath.Marked = false;
            this.hsLoadSQLExportPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadSQLExportPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadSQLExportPath.MarkedText = "";
            this.hsLoadSQLExportPath.MarkMode = false;
            this.hsLoadSQLExportPath.Name = "hsLoadSQLExportPath";
            this.hsLoadSQLExportPath.NonMarkedText = "...";
            this.hsLoadSQLExportPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadSQLExportPath.ShortcutNewline = false;
            this.hsLoadSQLExportPath.ShowShortcut = false;
            this.hsLoadSQLExportPath.Size = new System.Drawing.Size(58, 31);
            this.hsLoadSQLExportPath.TabIndex = 3;
            this.hsLoadSQLExportPath.Text = "...";
            this.hsLoadSQLExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsLoadSQLExportPath.ToolTipActive = false;
            this.hsLoadSQLExportPath.ToolTipAutomaticDelay = 500;
            this.hsLoadSQLExportPath.ToolTipAutoPopDelay = 5000;
            this.hsLoadSQLExportPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadSQLExportPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadSQLExportPath.ToolTipFor4ContextMenu = true;
            this.hsLoadSQLExportPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadSQLExportPath.ToolTipInitialDelay = 500;
            this.hsLoadSQLExportPath.ToolTipIsBallon = false;
            this.hsLoadSQLExportPath.ToolTipOwnerDraw = false;
            this.hsLoadSQLExportPath.ToolTipReshowDelay = 100;
            this.hsLoadSQLExportPath.ToolTipShowAlways = false;
            this.hsLoadSQLExportPath.ToolTipText = "";
            this.hsLoadSQLExportPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadSQLExportPath.ToolTipTitle = "";
            this.hsLoadSQLExportPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadSQLExportPath.UseVisualStyleBackColor = false;
            this.hsLoadSQLExportPath.Click += new System.EventHandler(this.hsLoadSQLExportPath_Click);
            // 
            // gbInfoPath
            // 
            this.gbInfoPath.Controls.Add(this.txtInfoPath);
            this.gbInfoPath.Controls.Add(this.hsLoadInfoPath);
            this.gbInfoPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfoPath.Location = new System.Drawing.Point(0, 260);
            this.gbInfoPath.Name = "gbInfoPath";
            this.gbInfoPath.Size = new System.Drawing.Size(917, 52);
            this.gbInfoPath.TabIndex = 8;
            this.gbInfoPath.TabStop = false;
            this.gbInfoPath.Text = "Info Path";
            // 
            // txtInfoPath
            // 
            this.txtInfoPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfoPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPath.Location = new System.Drawing.Point(3, 18);
            this.txtInfoPath.Name = "txtInfoPath";
            this.txtInfoPath.Size = new System.Drawing.Size(853, 20);
            this.txtInfoPath.TabIndex = 0;
            // 
            // hsLoadInfoPath
            // 
            this.hsLoadInfoPath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadInfoPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadInfoPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadInfoPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadInfoPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadInfoPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadInfoPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadInfoPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadInfoPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadInfoPath.FlatAppearance.BorderSize = 0;
            this.hsLoadInfoPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadInfoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadInfoPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadInfoPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadInfoPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadInfoPath.ImageToggleOnSelect = false;
            this.hsLoadInfoPath.Location = new System.Drawing.Point(856, 18);
            this.hsLoadInfoPath.Marked = false;
            this.hsLoadInfoPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadInfoPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadInfoPath.MarkedText = "";
            this.hsLoadInfoPath.MarkMode = false;
            this.hsLoadInfoPath.Name = "hsLoadInfoPath";
            this.hsLoadInfoPath.NonMarkedText = "...";
            this.hsLoadInfoPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadInfoPath.ShortcutNewline = false;
            this.hsLoadInfoPath.ShowShortcut = false;
            this.hsLoadInfoPath.Size = new System.Drawing.Size(58, 31);
            this.hsLoadInfoPath.TabIndex = 3;
            this.hsLoadInfoPath.Text = "...";
            this.hsLoadInfoPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsLoadInfoPath.ToolTipActive = false;
            this.hsLoadInfoPath.ToolTipAutomaticDelay = 500;
            this.hsLoadInfoPath.ToolTipAutoPopDelay = 5000;
            this.hsLoadInfoPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadInfoPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadInfoPath.ToolTipFor4ContextMenu = true;
            this.hsLoadInfoPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadInfoPath.ToolTipInitialDelay = 500;
            this.hsLoadInfoPath.ToolTipIsBallon = false;
            this.hsLoadInfoPath.ToolTipOwnerDraw = false;
            this.hsLoadInfoPath.ToolTipReshowDelay = 100;
            this.hsLoadInfoPath.ToolTipShowAlways = false;
            this.hsLoadInfoPath.ToolTipText = "";
            this.hsLoadInfoPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadInfoPath.ToolTipTitle = "";
            this.hsLoadInfoPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadInfoPath.UseVisualStyleBackColor = false;
            this.hsLoadInfoPath.Click += new System.EventHandler(this.hsLoadInfoPath_Click);
            // 
            // gbExportPath
            // 
            this.gbExportPath.Controls.Add(this.txtExportPath);
            this.gbExportPath.Controls.Add(this.hsLoadExportPath);
            this.gbExportPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbExportPath.Location = new System.Drawing.Point(0, 208);
            this.gbExportPath.Name = "gbExportPath";
            this.gbExportPath.Size = new System.Drawing.Size(917, 52);
            this.gbExportPath.TabIndex = 7;
            this.gbExportPath.TabStop = false;
            this.gbExportPath.Text = "Export Path";
            // 
            // txtExportPath
            // 
            this.txtExportPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExportPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportPath.Location = new System.Drawing.Point(3, 18);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(853, 20);
            this.txtExportPath.TabIndex = 0;
            // 
            // hsLoadExportPath
            // 
            this.hsLoadExportPath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadExportPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadExportPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadExportPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadExportPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadExportPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadExportPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadExportPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadExportPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadExportPath.FlatAppearance.BorderSize = 0;
            this.hsLoadExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadExportPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadExportPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadExportPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadExportPath.ImageToggleOnSelect = false;
            this.hsLoadExportPath.Location = new System.Drawing.Point(856, 18);
            this.hsLoadExportPath.Marked = false;
            this.hsLoadExportPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadExportPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadExportPath.MarkedText = "";
            this.hsLoadExportPath.MarkMode = false;
            this.hsLoadExportPath.Name = "hsLoadExportPath";
            this.hsLoadExportPath.NonMarkedText = "...";
            this.hsLoadExportPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadExportPath.ShortcutNewline = false;
            this.hsLoadExportPath.ShowShortcut = false;
            this.hsLoadExportPath.Size = new System.Drawing.Size(58, 31);
            this.hsLoadExportPath.TabIndex = 3;
            this.hsLoadExportPath.Text = "...";
            this.hsLoadExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsLoadExportPath.ToolTipActive = false;
            this.hsLoadExportPath.ToolTipAutomaticDelay = 500;
            this.hsLoadExportPath.ToolTipAutoPopDelay = 5000;
            this.hsLoadExportPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadExportPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadExportPath.ToolTipFor4ContextMenu = true;
            this.hsLoadExportPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadExportPath.ToolTipInitialDelay = 500;
            this.hsLoadExportPath.ToolTipIsBallon = false;
            this.hsLoadExportPath.ToolTipOwnerDraw = false;
            this.hsLoadExportPath.ToolTipReshowDelay = 100;
            this.hsLoadExportPath.ToolTipShowAlways = false;
            this.hsLoadExportPath.ToolTipText = "";
            this.hsLoadExportPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadExportPath.ToolTipTitle = "";
            this.hsLoadExportPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadExportPath.UseVisualStyleBackColor = false;
            this.hsLoadExportPath.Click += new System.EventHandler(this.hsLoadExportPath_Click);
            // 
            // dbDatabaseConfigFile
            // 
            this.dbDatabaseConfigFile.Controls.Add(this.txtDatabasesConfigFile);
            this.dbDatabaseConfigFile.Controls.Add(this.hsDatabaseConfigFile);
            this.dbDatabaseConfigFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbDatabaseConfigFile.Location = new System.Drawing.Point(0, 156);
            this.dbDatabaseConfigFile.Name = "dbDatabaseConfigFile";
            this.dbDatabaseConfigFile.Size = new System.Drawing.Size(917, 52);
            this.dbDatabaseConfigFile.TabIndex = 6;
            this.dbDatabaseConfigFile.TabStop = false;
            this.dbDatabaseConfigFile.Text = "Databases config file";
            // 
            // txtDatabasesConfigFile
            // 
            this.txtDatabasesConfigFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabasesConfigFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasesConfigFile.Location = new System.Drawing.Point(3, 18);
            this.txtDatabasesConfigFile.Name = "txtDatabasesConfigFile";
            this.txtDatabasesConfigFile.Size = new System.Drawing.Size(853, 20);
            this.txtDatabasesConfigFile.TabIndex = 0;
            // 
            // hsDatabaseConfigFile
            // 
            this.hsDatabaseConfigFile.BackColor = System.Drawing.Color.Transparent;
            this.hsDatabaseConfigFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDatabaseConfigFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDatabaseConfigFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDatabaseConfigFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDatabaseConfigFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDatabaseConfigFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDatabaseConfigFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDatabaseConfigFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDatabaseConfigFile.FlatAppearance.BorderSize = 0;
            this.hsDatabaseConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDatabaseConfigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDatabaseConfigFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDatabaseConfigFile.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsDatabaseConfigFile.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsDatabaseConfigFile.ImageToggleOnSelect = false;
            this.hsDatabaseConfigFile.Location = new System.Drawing.Point(856, 18);
            this.hsDatabaseConfigFile.Marked = false;
            this.hsDatabaseConfigFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsDatabaseConfigFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDatabaseConfigFile.MarkedText = "";
            this.hsDatabaseConfigFile.MarkMode = false;
            this.hsDatabaseConfigFile.Name = "hsDatabaseConfigFile";
            this.hsDatabaseConfigFile.NonMarkedText = "...";
            this.hsDatabaseConfigFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDatabaseConfigFile.ShortcutNewline = false;
            this.hsDatabaseConfigFile.ShowShortcut = false;
            this.hsDatabaseConfigFile.Size = new System.Drawing.Size(58, 31);
            this.hsDatabaseConfigFile.TabIndex = 3;
            this.hsDatabaseConfigFile.Text = "...";
            this.hsDatabaseConfigFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDatabaseConfigFile.ToolTipActive = false;
            this.hsDatabaseConfigFile.ToolTipAutomaticDelay = 500;
            this.hsDatabaseConfigFile.ToolTipAutoPopDelay = 5000;
            this.hsDatabaseConfigFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDatabaseConfigFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDatabaseConfigFile.ToolTipFor4ContextMenu = true;
            this.hsDatabaseConfigFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDatabaseConfigFile.ToolTipInitialDelay = 500;
            this.hsDatabaseConfigFile.ToolTipIsBallon = false;
            this.hsDatabaseConfigFile.ToolTipOwnerDraw = false;
            this.hsDatabaseConfigFile.ToolTipReshowDelay = 100;
            this.hsDatabaseConfigFile.ToolTipShowAlways = false;
            this.hsDatabaseConfigFile.ToolTipText = "";
            this.hsDatabaseConfigFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDatabaseConfigFile.ToolTipTitle = "";
            this.hsDatabaseConfigFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDatabaseConfigFile.UseVisualStyleBackColor = false;
            this.hsDatabaseConfigFile.Click += new System.EventHandler(this.hsDatabaseConfigFile_Click);
            // 
            // gbDatabasesConfigPath
            // 
            this.gbDatabasesConfigPath.Controls.Add(this.txtDatabasesConfigPath);
            this.gbDatabasesConfigPath.Controls.Add(this.hsDatabasesConfigPath);
            this.gbDatabasesConfigPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatabasesConfigPath.Location = new System.Drawing.Point(0, 104);
            this.gbDatabasesConfigPath.Name = "gbDatabasesConfigPath";
            this.gbDatabasesConfigPath.Size = new System.Drawing.Size(917, 52);
            this.gbDatabasesConfigPath.TabIndex = 5;
            this.gbDatabasesConfigPath.TabStop = false;
            this.gbDatabasesConfigPath.Text = "Databases config path";
            // 
            // txtDatabasesConfigPath
            // 
            this.txtDatabasesConfigPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabasesConfigPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasesConfigPath.Location = new System.Drawing.Point(3, 18);
            this.txtDatabasesConfigPath.Name = "txtDatabasesConfigPath";
            this.txtDatabasesConfigPath.Size = new System.Drawing.Size(853, 20);
            this.txtDatabasesConfigPath.TabIndex = 0;
            // 
            // hsDatabasesConfigPath
            // 
            this.hsDatabasesConfigPath.BackColor = System.Drawing.Color.Transparent;
            this.hsDatabasesConfigPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDatabasesConfigPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDatabasesConfigPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDatabasesConfigPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDatabasesConfigPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDatabasesConfigPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDatabasesConfigPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDatabasesConfigPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsDatabasesConfigPath.FlatAppearance.BorderSize = 0;
            this.hsDatabasesConfigPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDatabasesConfigPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDatabasesConfigPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDatabasesConfigPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsDatabasesConfigPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsDatabasesConfigPath.ImageToggleOnSelect = false;
            this.hsDatabasesConfigPath.Location = new System.Drawing.Point(856, 18);
            this.hsDatabasesConfigPath.Marked = false;
            this.hsDatabasesConfigPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsDatabasesConfigPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDatabasesConfigPath.MarkedText = "";
            this.hsDatabasesConfigPath.MarkMode = false;
            this.hsDatabasesConfigPath.Name = "hsDatabasesConfigPath";
            this.hsDatabasesConfigPath.NonMarkedText = "...";
            this.hsDatabasesConfigPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDatabasesConfigPath.ShortcutNewline = false;
            this.hsDatabasesConfigPath.ShowShortcut = false;
            this.hsDatabasesConfigPath.Size = new System.Drawing.Size(58, 31);
            this.hsDatabasesConfigPath.TabIndex = 3;
            this.hsDatabasesConfigPath.Text = "...";
            this.hsDatabasesConfigPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDatabasesConfigPath.ToolTipActive = false;
            this.hsDatabasesConfigPath.ToolTipAutomaticDelay = 500;
            this.hsDatabasesConfigPath.ToolTipAutoPopDelay = 5000;
            this.hsDatabasesConfigPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDatabasesConfigPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDatabasesConfigPath.ToolTipFor4ContextMenu = true;
            this.hsDatabasesConfigPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDatabasesConfigPath.ToolTipInitialDelay = 500;
            this.hsDatabasesConfigPath.ToolTipIsBallon = false;
            this.hsDatabasesConfigPath.ToolTipOwnerDraw = false;
            this.hsDatabasesConfigPath.ToolTipReshowDelay = 100;
            this.hsDatabasesConfigPath.ToolTipShowAlways = false;
            this.hsDatabasesConfigPath.ToolTipText = "";
            this.hsDatabasesConfigPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDatabasesConfigPath.ToolTipTitle = "";
            this.hsDatabasesConfigPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDatabasesConfigPath.UseVisualStyleBackColor = false;
            this.hsDatabasesConfigPath.Click += new System.EventHandler(this.hsDatabasesConfigPath_Click);
            // 
            // gbTempPath
            // 
            this.gbTempPath.Controls.Add(this.txtTemporaryPath);
            this.gbTempPath.Controls.Add(this.hsTemporaryPath);
            this.gbTempPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTempPath.Location = new System.Drawing.Point(0, 52);
            this.gbTempPath.Name = "gbTempPath";
            this.gbTempPath.Size = new System.Drawing.Size(917, 52);
            this.gbTempPath.TabIndex = 4;
            this.gbTempPath.TabStop = false;
            this.gbTempPath.Text = "Temporary path";
            // 
            // txtTemporaryPath
            // 
            this.txtTemporaryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemporaryPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemporaryPath.Location = new System.Drawing.Point(3, 18);
            this.txtTemporaryPath.Name = "txtTemporaryPath";
            this.txtTemporaryPath.Size = new System.Drawing.Size(853, 20);
            this.txtTemporaryPath.TabIndex = 0;
            // 
            // hsTemporaryPath
            // 
            this.hsTemporaryPath.BackColor = System.Drawing.Color.Transparent;
            this.hsTemporaryPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsTemporaryPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsTemporaryPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsTemporaryPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsTemporaryPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsTemporaryPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsTemporaryPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsTemporaryPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsTemporaryPath.FlatAppearance.BorderSize = 0;
            this.hsTemporaryPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsTemporaryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsTemporaryPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsTemporaryPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsTemporaryPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsTemporaryPath.ImageToggleOnSelect = false;
            this.hsTemporaryPath.Location = new System.Drawing.Point(856, 18);
            this.hsTemporaryPath.Marked = false;
            this.hsTemporaryPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsTemporaryPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsTemporaryPath.MarkedText = "";
            this.hsTemporaryPath.MarkMode = false;
            this.hsTemporaryPath.Name = "hsTemporaryPath";
            this.hsTemporaryPath.NonMarkedText = "...";
            this.hsTemporaryPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsTemporaryPath.ShortcutNewline = false;
            this.hsTemporaryPath.ShowShortcut = false;
            this.hsTemporaryPath.Size = new System.Drawing.Size(58, 31);
            this.hsTemporaryPath.TabIndex = 3;
            this.hsTemporaryPath.Text = "...";
            this.hsTemporaryPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsTemporaryPath.ToolTipActive = false;
            this.hsTemporaryPath.ToolTipAutomaticDelay = 500;
            this.hsTemporaryPath.ToolTipAutoPopDelay = 5000;
            this.hsTemporaryPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsTemporaryPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsTemporaryPath.ToolTipFor4ContextMenu = true;
            this.hsTemporaryPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsTemporaryPath.ToolTipInitialDelay = 500;
            this.hsTemporaryPath.ToolTipIsBallon = false;
            this.hsTemporaryPath.ToolTipOwnerDraw = false;
            this.hsTemporaryPath.ToolTipReshowDelay = 100;
            this.hsTemporaryPath.ToolTipShowAlways = false;
            this.hsTemporaryPath.ToolTipText = "";
            this.hsTemporaryPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsTemporaryPath.ToolTipTitle = "";
            this.hsTemporaryPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsTemporaryPath.UseVisualStyleBackColor = false;
            this.hsTemporaryPath.Click += new System.EventHandler(this.hsTemporaryPath_Click);
            // 
            // gbScriptingPath
            // 
            this.gbScriptingPath.Controls.Add(this.txtScriptingPath);
            this.gbScriptingPath.Controls.Add(this.hsScriptingPath);
            this.gbScriptingPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbScriptingPath.Location = new System.Drawing.Point(0, 0);
            this.gbScriptingPath.Name = "gbScriptingPath";
            this.gbScriptingPath.Size = new System.Drawing.Size(917, 52);
            this.gbScriptingPath.TabIndex = 3;
            this.gbScriptingPath.TabStop = false;
            this.gbScriptingPath.Text = "Scripting path";
            // 
            // txtScriptingPath
            // 
            this.txtScriptingPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptingPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptingPath.Location = new System.Drawing.Point(3, 18);
            this.txtScriptingPath.Name = "txtScriptingPath";
            this.txtScriptingPath.Size = new System.Drawing.Size(853, 20);
            this.txtScriptingPath.TabIndex = 0;
            // 
            // hsScriptingPath
            // 
            this.hsScriptingPath.BackColor = System.Drawing.Color.Transparent;
            this.hsScriptingPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsScriptingPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsScriptingPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsScriptingPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsScriptingPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsScriptingPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsScriptingPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsScriptingPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsScriptingPath.FlatAppearance.BorderSize = 0;
            this.hsScriptingPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsScriptingPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsScriptingPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsScriptingPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsScriptingPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsScriptingPath.ImageToggleOnSelect = false;
            this.hsScriptingPath.Location = new System.Drawing.Point(856, 18);
            this.hsScriptingPath.Marked = false;
            this.hsScriptingPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsScriptingPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsScriptingPath.MarkedText = "";
            this.hsScriptingPath.MarkMode = false;
            this.hsScriptingPath.Name = "hsScriptingPath";
            this.hsScriptingPath.NonMarkedText = "...";
            this.hsScriptingPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsScriptingPath.ShortcutNewline = false;
            this.hsScriptingPath.ShowShortcut = false;
            this.hsScriptingPath.Size = new System.Drawing.Size(58, 31);
            this.hsScriptingPath.TabIndex = 3;
            this.hsScriptingPath.Text = "...";
            this.hsScriptingPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsScriptingPath.ToolTipActive = false;
            this.hsScriptingPath.ToolTipAutomaticDelay = 500;
            this.hsScriptingPath.ToolTipAutoPopDelay = 5000;
            this.hsScriptingPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsScriptingPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsScriptingPath.ToolTipFor4ContextMenu = true;
            this.hsScriptingPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsScriptingPath.ToolTipInitialDelay = 500;
            this.hsScriptingPath.ToolTipIsBallon = false;
            this.hsScriptingPath.ToolTipOwnerDraw = false;
            this.hsScriptingPath.ToolTipReshowDelay = 100;
            this.hsScriptingPath.ToolTipShowAlways = false;
            this.hsScriptingPath.ToolTipText = "";
            this.hsScriptingPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsScriptingPath.ToolTipTitle = "";
            this.hsScriptingPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsScriptingPath.UseVisualStyleBackColor = false;
            this.hsScriptingPath.Click += new System.EventHandler(this.hsScriptingPath_Click);
            // 
            // pnlPathSettingsUpper
            // 
            this.pnlPathSettingsUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPathSettingsUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPathSettingsUpper.Controls.Add(this.hotSpot2);
            this.pnlPathSettingsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPathSettingsUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlPathSettingsUpper.Name = "pnlPathSettingsUpper";
            this.pnlPathSettingsUpper.Size = new System.Drawing.Size(917, 46);
            this.pnlPathSettingsUpper.TabIndex = 3;
            // 
            // hotSpot2
            // 
            this.hotSpot2.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot2.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot2.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot2.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot2.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot2.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot2.ImageToggleOnSelect = true;
            this.hotSpot2.Location = new System.Drawing.Point(868, 0);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "";
            this.hotSpot2.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot2.ShortcutNewline = false;
            this.hotSpot2.ShowShortcut = false;
            this.hotSpot2.Size = new System.Drawing.Size(45, 42);
            this.hotSpot2.TabIndex = 3;
            this.hotSpot2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot2.ToolTipActive = false;
            this.hotSpot2.ToolTipAutomaticDelay = 500;
            this.hotSpot2.ToolTipAutoPopDelay = 5000;
            this.hotSpot2.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot2.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot2.ToolTipFor4ContextMenu = true;
            this.hotSpot2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot2.ToolTipInitialDelay = 500;
            this.hotSpot2.ToolTipIsBallon = false;
            this.hotSpot2.ToolTipOwnerDraw = false;
            this.hotSpot2.ToolTipReshowDelay = 100;
            this.hotSpot2.ToolTipShowAlways = false;
            this.hotSpot2.ToolTipText = "";
            this.hotSpot2.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot2.ToolTipTitle = "";
            this.hotSpot2.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot2.UseVisualStyleBackColor = false;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldUpper);
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 23);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(923, 482);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 53);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(917, 426);
            this.pnlFieldsCenter.TabIndex = 2;
            // 
            // pnlFieldUpper
            // 
            this.pnlFieldUpper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFieldUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFieldUpper.Controls.Add(this.hsRefresh);
            this.pnlFieldUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldUpper.Name = "pnlFieldUpper";
            this.pnlFieldUpper.Size = new System.Drawing.Size(917, 50);
            this.pnlFieldUpper.TabIndex = 1;
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
            this.hsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefresh.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(868, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefresh.ShortcutNewline = false;
            this.hsRefresh.ShowShortcut = false;
            this.hsRefresh.Size = new System.Drawing.Size(45, 46);
            this.hsRefresh.TabIndex = 3;
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
            // tabSQLVariables
            // 
            this.tabSQLVariables.Controls.Add(this.pnlSQLVariables);
            this.tabSQLVariables.Controls.Add(this.pnlSQLVariablesUpper);
            this.tabSQLVariables.Location = new System.Drawing.Point(4, 23);
            this.tabSQLVariables.Name = "tabSQLVariables";
            this.tabSQLVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQLVariables.Size = new System.Drawing.Size(923, 482);
            this.tabSQLVariables.TabIndex = 1;
            this.tabSQLVariables.Text = "SQL Variables";
            this.tabSQLVariables.UseVisualStyleBackColor = true;
            // 
            // pnlSQLVariables
            // 
            this.pnlSQLVariables.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSQLVariables.Controls.Add(this.gbSQLInitialTerminator);
            this.pnlSQLVariables.Controls.Add(this.gbSQLAlternativeTerminator);
            this.pnlSQLVariables.Controls.Add(this.gbSQLSingleLineCommand);
            this.pnlSQLVariables.Controls.Add(this.gbSQLMaxRowSelect);
            this.pnlSQLVariables.Controls.Add(this.gbSkipForSelect);
            this.pnlSQLVariables.Controls.Add(this.gbSQLNewLine);
            this.pnlSQLVariables.Controls.Add(this.gbSQLCommentEnd);
            this.pnlSQLVariables.Controls.Add(this.gbSQLCommentStart);
            this.pnlSQLVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSQLVariables.Location = new System.Drawing.Point(3, 48);
            this.pnlSQLVariables.Name = "pnlSQLVariables";
            this.pnlSQLVariables.Size = new System.Drawing.Size(917, 431);
            this.pnlSQLVariables.TabIndex = 22;
            // 
            // gbSQLInitialTerminator
            // 
            this.gbSQLInitialTerminator.Controls.Add(this.txtSQLInitialTerminator);
            this.gbSQLInitialTerminator.Location = new System.Drawing.Point(255, 170);
            this.gbSQLInitialTerminator.Name = "gbSQLInitialTerminator";
            this.gbSQLInitialTerminator.Size = new System.Drawing.Size(191, 50);
            this.gbSQLInitialTerminator.TabIndex = 9;
            this.gbSQLInitialTerminator.TabStop = false;
            this.gbSQLInitialTerminator.Text = "Initial Terminator";
            // 
            // txtSQLInitialTerminator
            // 
            this.txtSQLInitialTerminator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLInitialTerminator.Location = new System.Drawing.Point(3, 18);
            this.txtSQLInitialTerminator.Name = "txtSQLInitialTerminator";
            this.txtSQLInitialTerminator.Size = new System.Drawing.Size(185, 22);
            this.txtSQLInitialTerminator.TabIndex = 0;
            // 
            // gbSQLAlternativeTerminator
            // 
            this.gbSQLAlternativeTerminator.Controls.Add(this.txtSQLAlternativeTerminator);
            this.gbSQLAlternativeTerminator.Location = new System.Drawing.Point(252, 103);
            this.gbSQLAlternativeTerminator.Name = "gbSQLAlternativeTerminator";
            this.gbSQLAlternativeTerminator.Size = new System.Drawing.Size(191, 50);
            this.gbSQLAlternativeTerminator.TabIndex = 8;
            this.gbSQLAlternativeTerminator.TabStop = false;
            this.gbSQLAlternativeTerminator.Text = "Alternative Terminator";
            // 
            // txtSQLAlternativeTerminator
            // 
            this.txtSQLAlternativeTerminator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLAlternativeTerminator.Location = new System.Drawing.Point(3, 18);
            this.txtSQLAlternativeTerminator.Name = "txtSQLAlternativeTerminator";
            this.txtSQLAlternativeTerminator.Size = new System.Drawing.Size(185, 22);
            this.txtSQLAlternativeTerminator.TabIndex = 0;
            // 
            // gbSQLSingleLineCommand
            // 
            this.gbSQLSingleLineCommand.Controls.Add(this.txtSQLSingleLineCommand);
            this.gbSQLSingleLineCommand.Location = new System.Drawing.Point(252, 17);
            this.gbSQLSingleLineCommand.Name = "gbSQLSingleLineCommand";
            this.gbSQLSingleLineCommand.Size = new System.Drawing.Size(191, 50);
            this.gbSQLSingleLineCommand.TabIndex = 7;
            this.gbSQLSingleLineCommand.TabStop = false;
            this.gbSQLSingleLineCommand.Text = "Single Line Command";
            // 
            // txtSQLSingleLineCommand
            // 
            this.txtSQLSingleLineCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLSingleLineCommand.Location = new System.Drawing.Point(3, 18);
            this.txtSQLSingleLineCommand.Name = "txtSQLSingleLineCommand";
            this.txtSQLSingleLineCommand.Size = new System.Drawing.Size(185, 22);
            this.txtSQLSingleLineCommand.TabIndex = 0;
            // 
            // gbSQLMaxRowSelect
            // 
            this.gbSQLMaxRowSelect.Controls.Add(this.txtSQLMaxRowForSelect);
            this.gbSQLMaxRowSelect.Location = new System.Drawing.Point(18, 263);
            this.gbSQLMaxRowSelect.Name = "gbSQLMaxRowSelect";
            this.gbSQLMaxRowSelect.Size = new System.Drawing.Size(242, 50);
            this.gbSQLMaxRowSelect.TabIndex = 6;
            this.gbSQLMaxRowSelect.TabStop = false;
            this.gbSQLMaxRowSelect.Text = "Table/View SELECT MaxRows (0=all rows)";
            // 
            // txtSQLMaxRowForSelect
            // 
            this.txtSQLMaxRowForSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLMaxRowForSelect.Location = new System.Drawing.Point(3, 18);
            this.txtSQLMaxRowForSelect.Name = "txtSQLMaxRowForSelect";
            this.txtSQLMaxRowForSelect.Size = new System.Drawing.Size(236, 22);
            this.txtSQLMaxRowForSelect.TabIndex = 0;
            // 
            // gbSkipForSelect
            // 
            this.gbSkipForSelect.Controls.Add(this.txtSkipForSelect);
            this.gbSkipForSelect.Location = new System.Drawing.Point(15, 195);
            this.gbSkipForSelect.Name = "gbSkipForSelect";
            this.gbSkipForSelect.Size = new System.Drawing.Size(191, 50);
            this.gbSkipForSelect.TabIndex = 5;
            this.gbSkipForSelect.TabStop = false;
            this.gbSkipForSelect.Text = "Skip for Select";
            // 
            // txtSkipForSelect
            // 
            this.txtSkipForSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSkipForSelect.Location = new System.Drawing.Point(3, 18);
            this.txtSkipForSelect.Name = "txtSkipForSelect";
            this.txtSkipForSelect.Size = new System.Drawing.Size(185, 22);
            this.txtSkipForSelect.TabIndex = 0;
            // 
            // gbSQLNewLine
            // 
            this.gbSQLNewLine.Controls.Add(this.txtSQLNewLine);
            this.gbSQLNewLine.Location = new System.Drawing.Point(15, 17);
            this.gbSQLNewLine.Name = "gbSQLNewLine";
            this.gbSQLNewLine.Size = new System.Drawing.Size(191, 50);
            this.gbSQLNewLine.TabIndex = 4;
            this.gbSQLNewLine.TabStop = false;
            this.gbSQLNewLine.Text = "SQL NewLine";
            // 
            // txtSQLNewLine
            // 
            this.txtSQLNewLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLNewLine.Location = new System.Drawing.Point(3, 18);
            this.txtSQLNewLine.Name = "txtSQLNewLine";
            this.txtSQLNewLine.Size = new System.Drawing.Size(185, 22);
            this.txtSQLNewLine.TabIndex = 0;
            // 
            // gbSQLCommentEnd
            // 
            this.gbSQLCommentEnd.Controls.Add(this.txtSQLCommentEnd);
            this.gbSQLCommentEnd.Location = new System.Drawing.Point(15, 139);
            this.gbSQLCommentEnd.Name = "gbSQLCommentEnd";
            this.gbSQLCommentEnd.Size = new System.Drawing.Size(191, 50);
            this.gbSQLCommentEnd.TabIndex = 3;
            this.gbSQLCommentEnd.TabStop = false;
            this.gbSQLCommentEnd.Text = "Comment End";
            // 
            // txtSQLCommentEnd
            // 
            this.txtSQLCommentEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLCommentEnd.Location = new System.Drawing.Point(3, 18);
            this.txtSQLCommentEnd.Name = "txtSQLCommentEnd";
            this.txtSQLCommentEnd.Size = new System.Drawing.Size(185, 22);
            this.txtSQLCommentEnd.TabIndex = 0;
            // 
            // gbSQLCommentStart
            // 
            this.gbSQLCommentStart.Controls.Add(this.txtSQLCommentStart);
            this.gbSQLCommentStart.Location = new System.Drawing.Point(12, 83);
            this.gbSQLCommentStart.Name = "gbSQLCommentStart";
            this.gbSQLCommentStart.Size = new System.Drawing.Size(191, 50);
            this.gbSQLCommentStart.TabIndex = 2;
            this.gbSQLCommentStart.TabStop = false;
            this.gbSQLCommentStart.Text = "Comment Start";
            // 
            // txtSQLCommentStart
            // 
            this.txtSQLCommentStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLCommentStart.Location = new System.Drawing.Point(3, 18);
            this.txtSQLCommentStart.Name = "txtSQLCommentStart";
            this.txtSQLCommentStart.Size = new System.Drawing.Size(185, 22);
            this.txtSQLCommentStart.TabIndex = 0;
            // 
            // pnlSQLVariablesUpper
            // 
            this.pnlSQLVariablesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSQLVariablesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSQLVariablesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlSQLVariablesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLVariablesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLVariablesUpper.Name = "pnlSQLVariablesUpper";
            this.pnlSQLVariablesUpper.Size = new System.Drawing.Size(917, 45);
            this.pnlSQLVariablesUpper.TabIndex = 21;
            // 
            // hsRefreshDependencies
            // 
            this.hsRefreshDependencies.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshDependencies.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshDependencies.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshDependencies.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshDependencies.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshDependencies.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsRefreshDependencies.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRefreshDependencies.FlatAppearance.BorderSize = 0;
            this.hsRefreshDependencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshDependencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshDependencies.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshDependencies.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hsRefreshDependencies.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hsRefreshDependencies.ImageToggleOnSelect = true;
            this.hsRefreshDependencies.Location = new System.Drawing.Point(868, 0);
            this.hsRefreshDependencies.Marked = false;
            this.hsRefreshDependencies.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshDependencies.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshDependencies.MarkedText = "";
            this.hsRefreshDependencies.MarkMode = false;
            this.hsRefreshDependencies.Name = "hsRefreshDependencies";
            this.hsRefreshDependencies.NonMarkedText = "";
            this.hsRefreshDependencies.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshDependencies.ShortcutNewline = false;
            this.hsRefreshDependencies.ShowShortcut = false;
            this.hsRefreshDependencies.Size = new System.Drawing.Size(45, 41);
            this.hsRefreshDependencies.TabIndex = 2;
            this.hsRefreshDependencies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefreshDependencies.ToolTipActive = false;
            this.hsRefreshDependencies.ToolTipAutomaticDelay = 500;
            this.hsRefreshDependencies.ToolTipAutoPopDelay = 5000;
            this.hsRefreshDependencies.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshDependencies.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshDependencies.ToolTipFor4ContextMenu = true;
            this.hsRefreshDependencies.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshDependencies.ToolTipInitialDelay = 500;
            this.hsRefreshDependencies.ToolTipIsBallon = false;
            this.hsRefreshDependencies.ToolTipOwnerDraw = false;
            this.hsRefreshDependencies.ToolTipReshowDelay = 100;
            this.hsRefreshDependencies.ToolTipShowAlways = false;
            this.hsRefreshDependencies.ToolTipText = "";
            this.hsRefreshDependencies.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshDependencies.ToolTipTitle = "";
            this.hsRefreshDependencies.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshDependencies.UseVisualStyleBackColor = false;
            // 
            // tabDatabaseDefaults
            // 
            this.tabDatabaseDefaults.Controls.Add(this.panel2);
            this.tabDatabaseDefaults.Controls.Add(this.pnlDatabseDefaultsUpper);
            this.tabDatabaseDefaults.Location = new System.Drawing.Point(4, 23);
            this.tabDatabaseDefaults.Name = "tabDatabaseDefaults";
            this.tabDatabaseDefaults.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabaseDefaults.Size = new System.Drawing.Size(923, 482);
            this.tabDatabaseDefaults.TabIndex = 2;
            this.tabDatabaseDefaults.Text = "Database defaults";
            this.tabDatabaseDefaults.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.gbOpenDatabasesCount);
            this.panel2.Controls.Add(this.gbDefaultPort);
            this.panel2.Controls.Add(this.gbDefaultPassword);
            this.panel2.Controls.Add(this.gbDefaulUser);
            this.panel2.Controls.Add(this.gbDefaultPacketSize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 424);
            this.panel2.TabIndex = 24;
            // 
            // gbOpenDatabasesCount
            // 
            this.gbOpenDatabasesCount.Controls.Add(this.numOpenDatabaseCount);
            this.gbOpenDatabasesCount.Location = new System.Drawing.Point(231, 6);
            this.gbOpenDatabasesCount.Name = "gbOpenDatabasesCount";
            this.gbOpenDatabasesCount.Size = new System.Drawing.Size(166, 44);
            this.gbOpenDatabasesCount.TabIndex = 19;
            this.gbOpenDatabasesCount.TabStop = false;
            this.gbOpenDatabasesCount.Text = "Reopen Databases Count";
            // 
            // numOpenDatabaseCount
            // 
            this.numOpenDatabaseCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOpenDatabaseCount.Location = new System.Drawing.Point(3, 18);
            this.numOpenDatabaseCount.Name = "numOpenDatabaseCount";
            this.numOpenDatabaseCount.Size = new System.Drawing.Size(160, 22);
            this.numOpenDatabaseCount.TabIndex = 3;
            this.numOpenDatabaseCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbDefaultPort
            // 
            this.gbDefaultPort.Controls.Add(this.numDefaultPort);
            this.gbDefaultPort.Location = new System.Drawing.Point(3, 184);
            this.gbDefaultPort.Name = "gbDefaultPort";
            this.gbDefaultPort.Size = new System.Drawing.Size(151, 44);
            this.gbDefaultPort.TabIndex = 3;
            this.gbDefaultPort.TabStop = false;
            this.gbDefaultPort.Text = "Default Port";
            // 
            // numDefaultPort
            // 
            this.numDefaultPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDefaultPort.Location = new System.Drawing.Point(3, 18);
            this.numDefaultPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDefaultPort.Name = "numDefaultPort";
            this.numDefaultPort.Size = new System.Drawing.Size(145, 22);
            this.numDefaultPort.TabIndex = 2;
            this.numDefaultPort.Value = new decimal(new int[] {
            3050,
            0,
            0,
            0});
            // 
            // gbDefaultPassword
            // 
            this.gbDefaultPassword.Controls.Add(this.txtDefaultPassword);
            this.gbDefaultPassword.Location = new System.Drawing.Point(3, 62);
            this.gbDefaultPassword.Name = "gbDefaultPassword";
            this.gbDefaultPassword.Size = new System.Drawing.Size(191, 50);
            this.gbDefaultPassword.TabIndex = 2;
            this.gbDefaultPassword.TabStop = false;
            this.gbDefaultPassword.Text = "Default Password";
            // 
            // txtDefaultPassword
            // 
            this.txtDefaultPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaultPassword.Location = new System.Drawing.Point(3, 18);
            this.txtDefaultPassword.Name = "txtDefaultPassword";
            this.txtDefaultPassword.Size = new System.Drawing.Size(185, 22);
            this.txtDefaultPassword.TabIndex = 0;
            this.txtDefaultPassword.Text = "masterkey";
            // 
            // gbDefaulUser
            // 
            this.gbDefaulUser.Controls.Add(this.txtDefaulUser);
            this.gbDefaulUser.Location = new System.Drawing.Point(3, 6);
            this.gbDefaulUser.Name = "gbDefaulUser";
            this.gbDefaulUser.Size = new System.Drawing.Size(191, 50);
            this.gbDefaulUser.TabIndex = 1;
            this.gbDefaulUser.TabStop = false;
            this.gbDefaulUser.Text = "Default User";
            // 
            // txtDefaulUser
            // 
            this.txtDefaulUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaulUser.Location = new System.Drawing.Point(3, 18);
            this.txtDefaulUser.Name = "txtDefaulUser";
            this.txtDefaulUser.Size = new System.Drawing.Size(185, 22);
            this.txtDefaulUser.TabIndex = 0;
            this.txtDefaulUser.Text = "SYSDBA";
            // 
            // gbDefaultPacketSize
            // 
            this.gbDefaultPacketSize.Controls.Add(this.numDefaultPacketSize);
            this.gbDefaultPacketSize.Location = new System.Drawing.Point(3, 118);
            this.gbDefaultPacketSize.Name = "gbDefaultPacketSize";
            this.gbDefaultPacketSize.Size = new System.Drawing.Size(151, 50);
            this.gbDefaultPacketSize.TabIndex = 0;
            this.gbDefaultPacketSize.TabStop = false;
            this.gbDefaultPacketSize.Text = "Default Packetsize";
            // 
            // numDefaultPacketSize
            // 
            this.numDefaultPacketSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDefaultPacketSize.Location = new System.Drawing.Point(3, 18);
            this.numDefaultPacketSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numDefaultPacketSize.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numDefaultPacketSize.Name = "numDefaultPacketSize";
            this.numDefaultPacketSize.Size = new System.Drawing.Size(145, 22);
            this.numDefaultPacketSize.TabIndex = 1;
            this.numDefaultPacketSize.Value = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            // 
            // pnlDatabseDefaultsUpper
            // 
            this.pnlDatabseDefaultsUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDatabseDefaultsUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatabseDefaultsUpper.Controls.Add(this.hotSpot1);
            this.pnlDatabseDefaultsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatabseDefaultsUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDatabseDefaultsUpper.Name = "pnlDatabseDefaultsUpper";
            this.pnlDatabseDefaultsUpper.Size = new System.Drawing.Size(917, 52);
            this.pnlDatabseDefaultsUpper.TabIndex = 23;
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
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.view_refresh22x;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.view_refresh_2_22x;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(868, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShortcutNewline = false;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(45, 48);
            this.hotSpot1.TabIndex = 2;
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
            // 
            // AppSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlFormUpper);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppSettingsForm";
            this.Text = "AppSettingsForm";
            this.Load += new System.EventHandler(this.AppSettingsForm_Load);
            this.pnlFormUpper.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPagePathSettings.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbSQLHistoryPath.ResumeLayout(false);
            this.gbSQLHistoryPath.PerformLayout();
            this.gbSQLExportPath.ResumeLayout(false);
            this.gbSQLExportPath.PerformLayout();
            this.gbInfoPath.ResumeLayout(false);
            this.gbInfoPath.PerformLayout();
            this.gbExportPath.ResumeLayout(false);
            this.gbExportPath.PerformLayout();
            this.dbDatabaseConfigFile.ResumeLayout(false);
            this.dbDatabaseConfigFile.PerformLayout();
            this.gbDatabasesConfigPath.ResumeLayout(false);
            this.gbDatabasesConfigPath.PerformLayout();
            this.gbTempPath.ResumeLayout(false);
            this.gbTempPath.PerformLayout();
            this.gbScriptingPath.ResumeLayout(false);
            this.gbScriptingPath.PerformLayout();
            this.pnlPathSettingsUpper.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabSQLVariables.ResumeLayout(false);
            this.pnlSQLVariables.ResumeLayout(false);
            this.gbSQLInitialTerminator.ResumeLayout(false);
            this.gbSQLInitialTerminator.PerformLayout();
            this.gbSQLAlternativeTerminator.ResumeLayout(false);
            this.gbSQLAlternativeTerminator.PerformLayout();
            this.gbSQLSingleLineCommand.ResumeLayout(false);
            this.gbSQLSingleLineCommand.PerformLayout();
            this.gbSQLMaxRowSelect.ResumeLayout(false);
            this.gbSQLMaxRowSelect.PerformLayout();
            this.gbSkipForSelect.ResumeLayout(false);
            this.gbSkipForSelect.PerformLayout();
            this.gbSQLNewLine.ResumeLayout(false);
            this.gbSQLNewLine.PerformLayout();
            this.gbSQLCommentEnd.ResumeLayout(false);
            this.gbSQLCommentEnd.PerformLayout();
            this.gbSQLCommentStart.ResumeLayout(false);
            this.gbSQLCommentStart.PerformLayout();
            this.pnlSQLVariablesUpper.ResumeLayout(false);
            this.tabDatabaseDefaults.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbOpenDatabasesCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOpenDatabaseCount)).EndInit();
            this.gbDefaultPort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPort)).EndInit();
            this.gbDefaultPassword.ResumeLayout(false);
            this.gbDefaultPassword.PerformLayout();
            this.gbDefaulUser.ResumeLayout(false);
            this.gbDefaulUser.PerformLayout();
            this.gbDefaultPacketSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPacketSize)).EndInit();
            this.pnlDatabseDefaultsUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private System.Windows.Forms.TabPage tabSQLVariables;
        private System.Windows.Forms.Panel pnlSQLVariablesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.Panel pnlSQLVariables;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabDatabaseDefaults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbDefaultPacketSize;
        private System.Windows.Forms.Panel pnlDatabseDefaultsUpper;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.GroupBox gbDefaultPassword;
        private System.Windows.Forms.TextBox txtDefaultPassword;
        private System.Windows.Forms.GroupBox gbDefaulUser;
        private System.Windows.Forms.TextBox txtDefaulUser;
        private System.Windows.Forms.TabPage tabPagePathSettings;
        private System.Windows.Forms.Panel pnlPathSettingsUpper;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.GroupBox gbSQLCommentEnd;
        private System.Windows.Forms.TextBox txtSQLCommentEnd;
        private System.Windows.Forms.GroupBox gbSQLCommentStart;
        private System.Windows.Forms.TextBox txtSQLCommentStart;
        private System.Windows.Forms.GroupBox gbSQLNewLine;
        private System.Windows.Forms.TextBox txtSQLNewLine;
        private System.Windows.Forms.GroupBox gbSQLMaxRowSelect;
        private System.Windows.Forms.TextBox txtSQLMaxRowForSelect;
        private System.Windows.Forms.GroupBox gbSkipForSelect;
        private System.Windows.Forms.TextBox txtSkipForSelect;
        private System.Windows.Forms.GroupBox gbSQLSingleLineCommand;
        private System.Windows.Forms.TextBox txtSQLSingleLineCommand;
        private System.Windows.Forms.GroupBox gbSQLAlternativeTerminator;
        private System.Windows.Forms.TextBox txtSQLAlternativeTerminator;
        private System.Windows.Forms.GroupBox gbSQLInitialTerminator;
        private System.Windows.Forms.TextBox txtSQLInitialTerminator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbSQLHistoryPath;
        private System.Windows.Forms.TextBox txtSQLHistoryPath;
        private SeControlsLib.HotSpot hsSQLHistoryPath;
        private System.Windows.Forms.GroupBox gbSQLExportPath;
        private System.Windows.Forms.TextBox txtSQLExportPath;
        private SeControlsLib.HotSpot hsLoadSQLExportPath;
        private System.Windows.Forms.GroupBox gbInfoPath;
        private System.Windows.Forms.TextBox txtInfoPath;
        private SeControlsLib.HotSpot hsLoadInfoPath;
        private System.Windows.Forms.GroupBox gbExportPath;
        private System.Windows.Forms.TextBox txtExportPath;
        private SeControlsLib.HotSpot hsLoadExportPath;
        private System.Windows.Forms.GroupBox dbDatabaseConfigFile;
        private System.Windows.Forms.TextBox txtDatabasesConfigFile;
        private SeControlsLib.HotSpot hsDatabaseConfigFile;
        private System.Windows.Forms.GroupBox gbDatabasesConfigPath;
        private System.Windows.Forms.TextBox txtDatabasesConfigPath;
        private SeControlsLib.HotSpot hsDatabasesConfigPath;
        private System.Windows.Forms.GroupBox gbTempPath;
        private System.Windows.Forms.TextBox txtTemporaryPath;
        private SeControlsLib.HotSpot hsTemporaryPath;
        private System.Windows.Forms.GroupBox gbScriptingPath;
        private System.Windows.Forms.TextBox txtScriptingPath;
        private SeControlsLib.HotSpot hsScriptingPath;
        private System.Windows.Forms.GroupBox gbDefaultPort;
        private System.Windows.Forms.NumericUpDown numDefaultPort;
        private System.Windows.Forms.NumericUpDown numDefaultPacketSize;
        private System.Windows.Forms.GroupBox gbOpenDatabasesCount;
        private System.Windows.Forms.NumericUpDown numOpenDatabaseCount;
    }
}