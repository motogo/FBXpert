using BasicForms;

namespace FBExpert
{
    partial class DatabaseConfigForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConfigForm));
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabcontrolConfig = new System.Windows.Forms.TabControl();
            this.tabBasicConf = new System.Windows.Forms.TabPage();
            this.pnlCenterBasicConf = new System.Windows.Forms.Panel();
            this.gbCreateDatabaseLocationFile = new System.Windows.Forms.GroupBox();
            this.txtCreateDatabaseLocationFile = new System.Windows.Forms.TextBox();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.hsCreateDatabase = new SeControlsLib.HotSpot();
            this.gbConnectionString = new System.Windows.Forms.GroupBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.gbCollation = new System.Windows.Forms.GroupBox();
            this.cbCollation = new System.Windows.Forms.ComboBox();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.gbCSet = new System.Windows.Forms.GroupBox();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.gbDatabaseLocation = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.hsChangeFullPath = new SeControlsLib.HotSpot();
            this.hsLoad = new SeControlsLib.HotSpot();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gbPort = new System.Windows.Forms.GroupBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbConnectionType = new System.Windows.Forms.GroupBox();
            this.rbEmbedded = new System.Windows.Forms.RadioButton();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.rbRemote = new System.Windows.Forms.RadioButton();
            this.gbPacketsize = new System.Windows.Forms.GroupBox();
            this.tabXPertUsedAttributes = new System.Windows.Forms.TabPage();
            this.pnlAttributesCenter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbConnectionLifetime = new System.Windows.Forms.GroupBox();
            this.lblConnectionLifetime = new System.Windows.Forms.Label();
            this.txtConnectionLifetime = new System.Windows.Forms.TextBox();
            this.gbMinPoolSize = new System.Windows.Forms.GroupBox();
            this.txtMinPoolSize = new System.Windows.Forms.TextBox();
            this.gbMaxPoolSize = new System.Windows.Forms.GroupBox();
            this.txtMaxPoolSize = new System.Windows.Forms.TextBox();
            this.cbPooling = new System.Windows.Forms.CheckBox();
            this.tabPageSourceControl = new System.Windows.Forms.TabPage();
            this.pnlSouceControlCenter = new System.Windows.Forms.Panel();
            this.gbSourceCodeOutputPath = new System.Windows.Forms.GroupBox();
            this.txtSourcecodeOutputPath = new System.Windows.Forms.TextBox();
            this.hsSourcecodeFolder = new SeControlsLib.HotSpot();
            this.gbDBNamespace = new System.Windows.Forms.GroupBox();
            this.txtDBNamespace = new System.Windows.Forms.TextBox();
            this.gbPrimaryFieldType = new System.Windows.Forms.GroupBox();
            this.rbGenerateUUID = new System.Windows.Forms.RadioButton();
            this.rbGenerateHEXGUID = new System.Windows.Forms.RadioButton();
            this.rbGenerateDBGenerator = new System.Windows.Forms.RadioButton();
            this.rbGenerateGUID = new System.Windows.Forms.RadioButton();
            this.gbSetTerm = new System.Windows.Forms.GroupBox();
            this.lblToReplaceSetTerm = new System.Windows.Forms.Label();
            this.txtAlternativeSetTermCharacter = new System.Windows.Forms.TextBox();
            this.gbAttributesUpper = new System.Windows.Forms.GroupBox();
            this.gbVersion = new System.Windows.Forms.GroupBox();
            this.rb4_64 = new System.Windows.Forms.RadioButton();
            this.rb4_32 = new System.Windows.Forms.RadioButton();
            this.gbClientLibrary = new System.Windows.Forms.GroupBox();
            this.txtClientLibrary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirebirdBinaryPath = new System.Windows.Forms.TextBox();
            this.rb3_64 = new System.Windows.Forms.RadioButton();
            this.rb3_32 = new System.Windows.Forms.RadioButton();
            this.rb25_64 = new System.Windows.Forms.RadioButton();
            this.rb25_32 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDatenbankAlias = new System.Windows.Forms.GroupBox();
            this.txtDatabaseAlias = new System.Windows.Forms.TextBox();
            this.hsConnect = new SeControlsLib.HotSpot();
            this.gbLivettime = new System.Windows.Forms.GroupBox();
            this.txtLifetime = new System.Windows.Forms.TextBox();
            this.pnlConnectState = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsGlobalApplicationSettings = new SeControlsLib.HotSpot();
            this.hsClone = new SeControlsLib.HotSpot();
            this.lblFormName = new System.Windows.Forms.Label();
            this.hsSave = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.numPacketSize = new System.Windows.Forms.NumericUpDown();
            this.pnlFormName = new System.Windows.Forms.Panel();
            this.pnlCenter.SuspendLayout();
            this.tabcontrolConfig.SuspendLayout();
            this.tabBasicConf.SuspendLayout();
            this.pnlCenterBasicConf.SuspendLayout();
            this.gbCreateDatabaseLocationFile.SuspendLayout();
            this.gbConnectionString.SuspendLayout();
            this.gbCollation.SuspendLayout();
            this.gbRole.SuspendLayout();
            this.gbCSet.SuspendLayout();
            this.gbDatabaseLocation.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.gbPort.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.gbConnectionType.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.gbPacketsize.SuspendLayout();
            this.tabXPertUsedAttributes.SuspendLayout();
            this.pnlAttributesCenter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbConnectionLifetime.SuspendLayout();
            this.gbMinPoolSize.SuspendLayout();
            this.gbMaxPoolSize.SuspendLayout();
            this.tabPageSourceControl.SuspendLayout();
            this.pnlSouceControlCenter.SuspendLayout();
            this.gbSourceCodeOutputPath.SuspendLayout();
            this.gbDBNamespace.SuspendLayout();
            this.gbPrimaryFieldType.SuspendLayout();
            this.gbSetTerm.SuspendLayout();
            this.gbAttributesUpper.SuspendLayout();
            this.gbVersion.SuspendLayout();
            this.gbClientLibrary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDatenbankAlias.SuspendLayout();
            this.gbLivettime.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketSize)).BeginInit();
            this.pnlFormName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabcontrolConfig);
            this.pnlCenter.Controls.Add(this.gbAttributesUpper);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 51);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(758, 581);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabcontrolConfig
            // 
            this.tabcontrolConfig.Controls.Add(this.tabBasicConf);
            this.tabcontrolConfig.Controls.Add(this.tabXPertUsedAttributes);
            this.tabcontrolConfig.Controls.Add(this.tabPageSourceControl);
            this.tabcontrolConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolConfig.Location = new System.Drawing.Point(0, 177);
            this.tabcontrolConfig.Name = "tabcontrolConfig";
            this.tabcontrolConfig.SelectedIndex = 0;
            this.tabcontrolConfig.Size = new System.Drawing.Size(758, 404);
            this.tabcontrolConfig.TabIndex = 7;
            // 
            // tabBasicConf
            // 
            this.tabBasicConf.Controls.Add(this.pnlCenterBasicConf);
            this.tabBasicConf.Location = new System.Drawing.Point(4, 22);
            this.tabBasicConf.Name = "tabBasicConf";
            this.tabBasicConf.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicConf.Size = new System.Drawing.Size(750, 378);
            this.tabBasicConf.TabIndex = 0;
            this.tabBasicConf.Text = "Basic configuration";
            this.tabBasicConf.UseVisualStyleBackColor = true;
            // 
            // pnlCenterBasicConf
            // 
            this.pnlCenterBasicConf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCenterBasicConf.Controls.Add(this.gbCreateDatabaseLocationFile);
            this.pnlCenterBasicConf.Controls.Add(this.gbConnectionString);
            this.pnlCenterBasicConf.Controls.Add(this.gbCollation);
            this.pnlCenterBasicConf.Controls.Add(this.gbRole);
            this.pnlCenterBasicConf.Controls.Add(this.gbCSet);
            this.pnlCenterBasicConf.Controls.Add(this.gbDatabaseLocation);
            this.pnlCenterBasicConf.Controls.Add(this.gbPassword);
            this.pnlCenterBasicConf.Controls.Add(this.gbPort);
            this.pnlCenterBasicConf.Controls.Add(this.gbUser);
            this.pnlCenterBasicConf.Controls.Add(this.gbConnectionType);
            this.pnlCenterBasicConf.Controls.Add(this.gbPacketsize);
            this.pnlCenterBasicConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterBasicConf.Location = new System.Drawing.Point(3, 3);
            this.pnlCenterBasicConf.Name = "pnlCenterBasicConf";
            this.pnlCenterBasicConf.Size = new System.Drawing.Size(744, 372);
            this.pnlCenterBasicConf.TabIndex = 0;
            // 
            // gbCreateDatabaseLocationFile
            // 
            this.gbCreateDatabaseLocationFile.Controls.Add(this.txtCreateDatabaseLocationFile);
            this.gbCreateDatabaseLocationFile.Controls.Add(this.hotSpot2);
            this.gbCreateDatabaseLocationFile.Controls.Add(this.hsCreateDatabase);
            this.gbCreateDatabaseLocationFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCreateDatabaseLocationFile.Location = new System.Drawing.Point(0, 193);
            this.gbCreateDatabaseLocationFile.Name = "gbCreateDatabaseLocationFile";
            this.gbCreateDatabaseLocationFile.Size = new System.Drawing.Size(744, 48);
            this.gbCreateDatabaseLocationFile.TabIndex = 14;
            this.gbCreateDatabaseLocationFile.TabStop = false;
            this.gbCreateDatabaseLocationFile.Text = "Database Location for Create Database";
            // 
            // txtCreateDatabaseLocationFile
            // 
            this.txtCreateDatabaseLocationFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreateDatabaseLocationFile.Location = new System.Drawing.Point(3, 16);
            this.txtCreateDatabaseLocationFile.Name = "txtCreateDatabaseLocationFile";
            this.txtCreateDatabaseLocationFile.Size = new System.Drawing.Size(592, 20);
            this.txtCreateDatabaseLocationFile.TabIndex = 0;
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
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hotSpot2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hotSpot2.ImageToggleOnSelect = false;
            this.hotSpot2.Location = new System.Drawing.Point(595, 16);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "Load";
            this.hotSpot2.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot2.ShowShortcut = false;
            this.hotSpot2.Size = new System.Drawing.Size(65, 29);
            this.hotSpot2.TabIndex = 3;
            this.hotSpot2.Text = "Load";
            this.hotSpot2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.hotSpot2.Click += new System.EventHandler(this.hotSpot2_Click);
            // 
            // hsCreateDatabase
            // 
            this.hsCreateDatabase.BackColor = System.Drawing.Color.Transparent;
            this.hsCreateDatabase.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCreateDatabase.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCreateDatabase.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCreateDatabase.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCreateDatabase.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCreateDatabase.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCreateDatabase.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsCreateDatabase.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreateDatabase.FlatAppearance.BorderSize = 0;
            this.hsCreateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCreateDatabase.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreateDatabase.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsCreateDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsCreateDatabase.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsCreateDatabase.ImageToggleOnSelect = false;
            this.hsCreateDatabase.Location = new System.Drawing.Point(660, 16);
            this.hsCreateDatabase.Marked = false;
            this.hsCreateDatabase.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreateDatabase.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreateDatabase.MarkedText = "";
            this.hsCreateDatabase.MarkMode = false;
            this.hsCreateDatabase.Name = "hsCreateDatabase";
            this.hsCreateDatabase.NonMarkedText = "Create";
            this.hsCreateDatabase.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCreateDatabase.ShowShortcut = false;
            this.hsCreateDatabase.Size = new System.Drawing.Size(81, 29);
            this.hsCreateDatabase.TabIndex = 4;
            this.hsCreateDatabase.Text = "Create";
            this.hsCreateDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsCreateDatabase.ToolTipActive = false;
            this.hsCreateDatabase.ToolTipAutomaticDelay = 500;
            this.hsCreateDatabase.ToolTipAutoPopDelay = 5000;
            this.hsCreateDatabase.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCreateDatabase.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCreateDatabase.ToolTipFor4ContextMenu = true;
            this.hsCreateDatabase.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCreateDatabase.ToolTipInitialDelay = 500;
            this.hsCreateDatabase.ToolTipIsBallon = false;
            this.hsCreateDatabase.ToolTipOwnerDraw = false;
            this.hsCreateDatabase.ToolTipReshowDelay = 100;
            this.hsCreateDatabase.ToolTipShowAlways = false;
            this.hsCreateDatabase.ToolTipText = "";
            this.hsCreateDatabase.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCreateDatabase.ToolTipTitle = "";
            this.hsCreateDatabase.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCreateDatabase.UseVisualStyleBackColor = false;
            this.hsCreateDatabase.Click += new System.EventHandler(this.hsCreateDatabase_Click);
            // 
            // gbConnectionString
            // 
            this.gbConnectionString.Controls.Add(this.txtConnectionString);
            this.gbConnectionString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbConnectionString.Location = new System.Drawing.Point(0, 241);
            this.gbConnectionString.Name = "gbConnectionString";
            this.gbConnectionString.Size = new System.Drawing.Size(744, 131);
            this.gbConnectionString.TabIndex = 13;
            this.gbConnectionString.TabStop = false;
            this.gbConnectionString.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.BackColor = System.Drawing.SystemColors.Info;
            this.txtConnectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnectionString.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectionString.Location = new System.Drawing.Point(3, 16);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(738, 112);
            this.txtConnectionString.TabIndex = 1;
            // 
            // gbCollation
            // 
            this.gbCollation.Controls.Add(this.cbCollation);
            this.gbCollation.Location = new System.Drawing.Point(510, 96);
            this.gbCollation.Name = "gbCollation";
            this.gbCollation.Size = new System.Drawing.Size(185, 42);
            this.gbCollation.TabIndex = 10;
            this.gbCollation.TabStop = false;
            this.gbCollation.Text = "Default Collation";
            // 
            // cbCollation
            // 
            this.cbCollation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCollation.FormattingEnabled = true;
            this.cbCollation.Items.AddRange(new object[] {
            "NONE",
            "UTF8",
            "ASCII",
            "UNICODE_FSS",
            "ISO8859_1",
            "WIN1251"});
            this.cbCollation.Location = new System.Drawing.Point(3, 16);
            this.cbCollation.Name = "cbCollation";
            this.cbCollation.Size = new System.Drawing.Size(179, 21);
            this.cbCollation.TabIndex = 3;
            this.cbCollation.Text = "NONE";
            this.cbCollation.TextChanged += new System.EventHandler(this.cbCollation_TextChanged);
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.txtRole);
            this.gbRole.Location = new System.Drawing.Point(415, 143);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(199, 41);
            this.gbRole.TabIndex = 7;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRole.Location = new System.Drawing.Point(3, 16);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(193, 20);
            this.txtRole.TabIndex = 1;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // gbCSet
            // 
            this.gbCSet.Controls.Add(this.cbCharSet);
            this.gbCSet.Location = new System.Drawing.Point(510, 54);
            this.gbCSet.Name = "gbCSet";
            this.gbCSet.Size = new System.Drawing.Size(185, 42);
            this.gbCSet.TabIndex = 2;
            this.gbCSet.TabStop = false;
            this.gbCSet.Text = "Default Charset";
            // 
            // cbCharSet
            // 
            this.cbCharSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharSet.FormattingEnabled = true;
            this.cbCharSet.Items.AddRange(new object[] {
            "NONE",
            "UTF8",
            "ASCII",
            "UNICODE_FSS",
            "ISO8859_1",
            "WIN1250",
            "WIN1251"});
            this.cbCharSet.Location = new System.Drawing.Point(3, 16);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(179, 21);
            this.cbCharSet.TabIndex = 3;
            this.cbCharSet.Text = "NONE";
            this.cbCharSet.SelectedIndexChanged += new System.EventHandler(this.cbCharSet_SelectedIndexChanged);
            this.cbCharSet.TextChanged += new System.EventHandler(this.cbCharSet_TextChanged);
            // 
            // gbDatabaseLocation
            // 
            this.gbDatabaseLocation.Controls.Add(this.txtLocation);
            this.gbDatabaseLocation.Controls.Add(this.hsChangeFullPath);
            this.gbDatabaseLocation.Controls.Add(this.hsLoad);
            this.gbDatabaseLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatabaseLocation.Location = new System.Drawing.Point(0, 0);
            this.gbDatabaseLocation.Name = "gbDatabaseLocation";
            this.gbDatabaseLocation.Size = new System.Drawing.Size(744, 48);
            this.gbDatabaseLocation.TabIndex = 1;
            this.gbDatabaseLocation.TabStop = false;
            this.gbDatabaseLocation.Text = "Database Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Location = new System.Drawing.Point(3, 16);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(637, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // hsChangeFullPath
            // 
            this.hsChangeFullPath.BackColor = System.Drawing.Color.Transparent;
            this.hsChangeFullPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsChangeFullPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsChangeFullPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsChangeFullPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsChangeFullPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsChangeFullPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsChangeFullPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsChangeFullPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsChangeFullPath.FlatAppearance.BorderSize = 0;
            this.hsChangeFullPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsChangeFullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsChangeFullPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsChangeFullPath.Image = global::FBXpert.Properties.Resources.media_playlist_repeat_light_blue_x22;
            this.hsChangeFullPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsChangeFullPath.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsChangeFullPath.ImageToggleOnSelect = false;
            this.hsChangeFullPath.Location = new System.Drawing.Point(640, 16);
            this.hsChangeFullPath.Marked = false;
            this.hsChangeFullPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsChangeFullPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsChangeFullPath.MarkedText = "";
            this.hsChangeFullPath.MarkMode = false;
            this.hsChangeFullPath.Name = "hsChangeFullPath";
            this.hsChangeFullPath.NonMarkedText = "";
            this.hsChangeFullPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsChangeFullPath.ShowShortcut = false;
            this.hsChangeFullPath.Size = new System.Drawing.Size(36, 29);
            this.hsChangeFullPath.TabIndex = 12;
            this.hsChangeFullPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsChangeFullPath.ToolTipActive = false;
            this.hsChangeFullPath.ToolTipAutomaticDelay = 500;
            this.hsChangeFullPath.ToolTipAutoPopDelay = 5000;
            this.hsChangeFullPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsChangeFullPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsChangeFullPath.ToolTipFor4ContextMenu = true;
            this.hsChangeFullPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsChangeFullPath.ToolTipInitialDelay = 500;
            this.hsChangeFullPath.ToolTipIsBallon = false;
            this.hsChangeFullPath.ToolTipOwnerDraw = false;
            this.hsChangeFullPath.ToolTipReshowDelay = 100;
            this.hsChangeFullPath.ToolTipShowAlways = false;
            this.hsChangeFullPath.ToolTipText = "";
            this.hsChangeFullPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsChangeFullPath.ToolTipTitle = "";
            this.hsChangeFullPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsChangeFullPath.UseVisualStyleBackColor = false;
            this.hsChangeFullPath.Click += new System.EventHandler(this.hsChangeFullPath_Click);
            // 
            // hsLoad
            // 
            this.hsLoad.BackColor = System.Drawing.Color.Transparent;
            this.hsLoad.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoad.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoad.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoad.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoad.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoad.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoad.FlatAppearance.BorderSize = 0;
            this.hsLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoad.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoad.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoad.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoad.ImageToggleOnSelect = false;
            this.hsLoad.Location = new System.Drawing.Point(676, 16);
            this.hsLoad.Marked = false;
            this.hsLoad.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoad.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoad.MarkedText = "";
            this.hsLoad.MarkMode = false;
            this.hsLoad.Name = "hsLoad";
            this.hsLoad.NonMarkedText = "Load";
            this.hsLoad.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoad.ShowShortcut = false;
            this.hsLoad.Size = new System.Drawing.Size(65, 29);
            this.hsLoad.TabIndex = 3;
            this.hsLoad.Text = "Load";
            this.hsLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsLoad.ToolTipActive = false;
            this.hsLoad.ToolTipAutomaticDelay = 500;
            this.hsLoad.ToolTipAutoPopDelay = 5000;
            this.hsLoad.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoad.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoad.ToolTipFor4ContextMenu = true;
            this.hsLoad.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoad.ToolTipInitialDelay = 500;
            this.hsLoad.ToolTipIsBallon = false;
            this.hsLoad.ToolTipOwnerDraw = false;
            this.hsLoad.ToolTipReshowDelay = 100;
            this.hsLoad.ToolTipShowAlways = false;
            this.hsLoad.ToolTipText = "";
            this.hsLoad.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoad.ToolTipTitle = "";
            this.hsLoad.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoad.UseVisualStyleBackColor = false;
            this.hsLoad.Click += new System.EventHandler(this.hsLoad_Click);
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Location = new System.Drawing.Point(210, 143);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(199, 41);
            this.gbPassword.TabIndex = 5;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(3, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "masterkey";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // gbPort
            // 
            this.gbPort.Controls.Add(this.numPort);
            this.gbPort.Location = new System.Drawing.Point(319, 54);
            this.gbPort.Name = "gbPort";
            this.gbPort.Size = new System.Drawing.Size(73, 41);
            this.gbPort.TabIndex = 6;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "Port";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.txtUser);
            this.gbUser.Location = new System.Drawing.Point(5, 143);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(199, 41);
            this.gbUser.TabIndex = 4;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Location = new System.Drawing.Point(3, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(193, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "SYSDBA";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // gbConnectionType
            // 
            this.gbConnectionType.Controls.Add(this.rbEmbedded);
            this.gbConnectionType.Controls.Add(this.gbServer);
            this.gbConnectionType.Controls.Add(this.rbRemote);
            this.gbConnectionType.Location = new System.Drawing.Point(5, 54);
            this.gbConnectionType.Name = "gbConnectionType";
            this.gbConnectionType.Size = new System.Drawing.Size(308, 79);
            this.gbConnectionType.TabIndex = 0;
            this.gbConnectionType.TabStop = false;
            this.gbConnectionType.Text = "Database Connectiontype";
            // 
            // rbEmbedded
            // 
            this.rbEmbedded.AutoSize = true;
            this.rbEmbedded.Location = new System.Drawing.Point(11, 49);
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
            this.gbServer.Location = new System.Drawing.Point(100, 31);
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
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // rbRemote
            // 
            this.rbRemote.AutoSize = true;
            this.rbRemote.Location = new System.Drawing.Point(11, 25);
            this.rbRemote.Name = "rbRemote";
            this.rbRemote.Size = new System.Drawing.Size(62, 17);
            this.rbRemote.TabIndex = 2;
            this.rbRemote.TabStop = true;
            this.rbRemote.Text = "Remote";
            this.rbRemote.UseVisualStyleBackColor = true;
            this.rbRemote.CheckedChanged += new System.EventHandler(this.rbRemote_CheckedChanged);
            // 
            // gbPacketsize
            // 
            this.gbPacketsize.Controls.Add(this.numPacketSize);
            this.gbPacketsize.Location = new System.Drawing.Point(398, 54);
            this.gbPacketsize.Name = "gbPacketsize";
            this.gbPacketsize.Size = new System.Drawing.Size(106, 41);
            this.gbPacketsize.TabIndex = 3;
            this.gbPacketsize.TabStop = false;
            this.gbPacketsize.Text = "Packetsize";
            // 
            // tabXPertUsedAttributes
            // 
            this.tabXPertUsedAttributes.Controls.Add(this.pnlAttributesCenter);
            this.tabXPertUsedAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabXPertUsedAttributes.Name = "tabXPertUsedAttributes";
            this.tabXPertUsedAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabXPertUsedAttributes.Size = new System.Drawing.Size(750, 378);
            this.tabXPertUsedAttributes.TabIndex = 1;
            this.tabXPertUsedAttributes.Text = "FBXpert attributes";
            this.tabXPertUsedAttributes.UseVisualStyleBackColor = true;
            // 
            // pnlAttributesCenter
            // 
            this.pnlAttributesCenter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAttributesCenter.Controls.Add(this.panel3);
            this.pnlAttributesCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttributesCenter.Location = new System.Drawing.Point(3, 3);
            this.pnlAttributesCenter.Name = "pnlAttributesCenter";
            this.pnlAttributesCenter.Size = new System.Drawing.Size(744, 372);
            this.pnlAttributesCenter.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.gbConnectionLifetime);
            this.panel3.Controls.Add(this.gbMinPoolSize);
            this.panel3.Controls.Add(this.gbMaxPoolSize);
            this.panel3.Controls.Add(this.cbPooling);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 372);
            this.panel3.TabIndex = 16;
            // 
            // gbConnectionLifetime
            // 
            this.gbConnectionLifetime.Controls.Add(this.lblConnectionLifetime);
            this.gbConnectionLifetime.Controls.Add(this.txtConnectionLifetime);
            this.gbConnectionLifetime.Location = new System.Drawing.Point(7, 131);
            this.gbConnectionLifetime.Name = "gbConnectionLifetime";
            this.gbConnectionLifetime.Size = new System.Drawing.Size(217, 41);
            this.gbConnectionLifetime.TabIndex = 15;
            this.gbConnectionLifetime.TabStop = false;
            this.gbConnectionLifetime.Text = "Connection lifetime (s)";
            // 
            // lblConnectionLifetime
            // 
            this.lblConnectionLifetime.AutoSize = true;
            this.lblConnectionLifetime.Location = new System.Drawing.Point(75, 19);
            this.lblConnectionLifetime.Name = "lblConnectionLifetime";
            this.lblConnectionLifetime.Size = new System.Drawing.Size(127, 13);
            this.lblConnectionLifetime.TabIndex = 16;
            this.lblConnectionLifetime.Text = "0 = default = never expire";
            // 
            // txtConnectionLifetime
            // 
            this.txtConnectionLifetime.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtConnectionLifetime.Location = new System.Drawing.Point(3, 16);
            this.txtConnectionLifetime.Name = "txtConnectionLifetime";
            this.txtConnectionLifetime.Size = new System.Drawing.Size(57, 20);
            this.txtConnectionLifetime.TabIndex = 1;
            this.txtConnectionLifetime.Text = "0";
            this.txtConnectionLifetime.TextChanged += new System.EventHandler(this.txtConnectionLifetime_TextChanged);
            // 
            // gbMinPoolSize
            // 
            this.gbMinPoolSize.Controls.Add(this.txtMinPoolSize);
            this.gbMinPoolSize.Location = new System.Drawing.Point(7, 37);
            this.gbMinPoolSize.Name = "gbMinPoolSize";
            this.gbMinPoolSize.Size = new System.Drawing.Size(70, 41);
            this.gbMinPoolSize.TabIndex = 13;
            this.gbMinPoolSize.TabStop = false;
            this.gbMinPoolSize.Text = "Min pool size";
            // 
            // txtMinPoolSize
            // 
            this.txtMinPoolSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinPoolSize.Location = new System.Drawing.Point(3, 16);
            this.txtMinPoolSize.Name = "txtMinPoolSize";
            this.txtMinPoolSize.Size = new System.Drawing.Size(64, 20);
            this.txtMinPoolSize.TabIndex = 1;
            this.txtMinPoolSize.Text = "0";
            this.txtMinPoolSize.TextChanged += new System.EventHandler(this.txtMinPoolSize_TextChanged);
            // 
            // gbMaxPoolSize
            // 
            this.gbMaxPoolSize.Controls.Add(this.txtMaxPoolSize);
            this.gbMaxPoolSize.Location = new System.Drawing.Point(7, 84);
            this.gbMaxPoolSize.Name = "gbMaxPoolSize";
            this.gbMaxPoolSize.Size = new System.Drawing.Size(70, 41);
            this.gbMaxPoolSize.TabIndex = 14;
            this.gbMaxPoolSize.TabStop = false;
            this.gbMaxPoolSize.Text = "Max pool size";
            // 
            // txtMaxPoolSize
            // 
            this.txtMaxPoolSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxPoolSize.Location = new System.Drawing.Point(3, 16);
            this.txtMaxPoolSize.Multiline = true;
            this.txtMaxPoolSize.Name = "txtMaxPoolSize";
            this.txtMaxPoolSize.Size = new System.Drawing.Size(64, 22);
            this.txtMaxPoolSize.TabIndex = 1;
            this.txtMaxPoolSize.Text = "15";
            this.txtMaxPoolSize.TextChanged += new System.EventHandler(this.txtMaxPoolSize_TextChanged);
            // 
            // cbPooling
            // 
            this.cbPooling.AutoSize = true;
            this.cbPooling.Location = new System.Drawing.Point(10, 9);
            this.cbPooling.Name = "cbPooling";
            this.cbPooling.Size = new System.Drawing.Size(138, 17);
            this.cbPooling.TabIndex = 12;
            this.cbPooling.Text = "Use connection pooling";
            this.cbPooling.UseVisualStyleBackColor = true;
            this.cbPooling.CheckedChanged += new System.EventHandler(this.cbPooling_CheckedChanged);
            // 
            // tabPageSourceControl
            // 
            this.tabPageSourceControl.Controls.Add(this.pnlSouceControlCenter);
            this.tabPageSourceControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceControl.Name = "tabPageSourceControl";
            this.tabPageSourceControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSourceControl.Size = new System.Drawing.Size(750, 378);
            this.tabPageSourceControl.TabIndex = 2;
            this.tabPageSourceControl.Text = "Sourcecode control";
            this.tabPageSourceControl.UseVisualStyleBackColor = true;
            // 
            // pnlSouceControlCenter
            // 
            this.pnlSouceControlCenter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlSouceControlCenter.Controls.Add(this.gbSourceCodeOutputPath);
            this.pnlSouceControlCenter.Controls.Add(this.gbDBNamespace);
            this.pnlSouceControlCenter.Controls.Add(this.gbPrimaryFieldType);
            this.pnlSouceControlCenter.Controls.Add(this.gbSetTerm);
            this.pnlSouceControlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSouceControlCenter.Location = new System.Drawing.Point(3, 3);
            this.pnlSouceControlCenter.Name = "pnlSouceControlCenter";
            this.pnlSouceControlCenter.Size = new System.Drawing.Size(744, 372);
            this.pnlSouceControlCenter.TabIndex = 1;
            // 
            // gbSourceCodeOutputPath
            // 
            this.gbSourceCodeOutputPath.Controls.Add(this.txtSourcecodeOutputPath);
            this.gbSourceCodeOutputPath.Controls.Add(this.hsSourcecodeFolder);
            this.gbSourceCodeOutputPath.Location = new System.Drawing.Point(8, 144);
            this.gbSourceCodeOutputPath.Name = "gbSourceCodeOutputPath";
            this.gbSourceCodeOutputPath.Size = new System.Drawing.Size(724, 40);
            this.gbSourceCodeOutputPath.TabIndex = 12;
            this.gbSourceCodeOutputPath.TabStop = false;
            this.gbSourceCodeOutputPath.Text = "Sourcecode Output Path";
            // 
            // txtSourcecodeOutputPath
            // 
            this.txtSourcecodeOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourcecodeOutputPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourcecodeOutputPath.Location = new System.Drawing.Point(3, 16);
            this.txtSourcecodeOutputPath.Name = "txtSourcecodeOutputPath";
            this.txtSourcecodeOutputPath.Size = new System.Drawing.Size(676, 20);
            this.txtSourcecodeOutputPath.TabIndex = 0;
            // 
            // hsSourcecodeFolder
            // 
            this.hsSourcecodeFolder.BackColor = System.Drawing.Color.Transparent;
            this.hsSourcecodeFolder.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSourcecodeFolder.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSourcecodeFolder.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSourcecodeFolder.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSourcecodeFolder.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSourcecodeFolder.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSourcecodeFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSourcecodeFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSourcecodeFolder.FlatAppearance.BorderSize = 0;
            this.hsSourcecodeFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSourcecodeFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSourcecodeFolder.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSourcecodeFolder.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsSourcecodeFolder.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsSourcecodeFolder.ImageToggleOnSelect = true;
            this.hsSourcecodeFolder.Location = new System.Drawing.Point(679, 16);
            this.hsSourcecodeFolder.Marked = false;
            this.hsSourcecodeFolder.MarkedColor = System.Drawing.Color.Teal;
            this.hsSourcecodeFolder.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSourcecodeFolder.MarkedText = "";
            this.hsSourcecodeFolder.MarkMode = false;
            this.hsSourcecodeFolder.Name = "hsSourcecodeFolder";
            this.hsSourcecodeFolder.NonMarkedText = "Clone";
            this.hsSourcecodeFolder.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSourcecodeFolder.ShowShortcut = false;
            this.hsSourcecodeFolder.Size = new System.Drawing.Size(42, 21);
            this.hsSourcecodeFolder.TabIndex = 5;
            this.hsSourcecodeFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSourcecodeFolder.ToolTipActive = false;
            this.hsSourcecodeFolder.ToolTipAutomaticDelay = 500;
            this.hsSourcecodeFolder.ToolTipAutoPopDelay = 5000;
            this.hsSourcecodeFolder.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSourcecodeFolder.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSourcecodeFolder.ToolTipFor4ContextMenu = true;
            this.hsSourcecodeFolder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSourcecodeFolder.ToolTipInitialDelay = 500;
            this.hsSourcecodeFolder.ToolTipIsBallon = false;
            this.hsSourcecodeFolder.ToolTipOwnerDraw = false;
            this.hsSourcecodeFolder.ToolTipReshowDelay = 100;
            this.hsSourcecodeFolder.ToolTipShowAlways = false;
            this.hsSourcecodeFolder.ToolTipText = "";
            this.hsSourcecodeFolder.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSourcecodeFolder.ToolTipTitle = "";
            this.hsSourcecodeFolder.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSourcecodeFolder.UseVisualStyleBackColor = false;
            this.hsSourcecodeFolder.Click += new System.EventHandler(this.hsSourcecodeFolder_Click);
            // 
            // gbDBNamespace
            // 
            this.gbDBNamespace.Controls.Add(this.txtDBNamespace);
            this.gbDBNamespace.Location = new System.Drawing.Point(8, 59);
            this.gbDBNamespace.Name = "gbDBNamespace";
            this.gbDBNamespace.Size = new System.Drawing.Size(182, 37);
            this.gbDBNamespace.TabIndex = 11;
            this.gbDBNamespace.TabStop = false;
            this.gbDBNamespace.Text = "Namespace";
            // 
            // txtDBNamespace
            // 
            this.txtDBNamespace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDBNamespace.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBNamespace.Location = new System.Drawing.Point(3, 16);
            this.txtDBNamespace.Name = "txtDBNamespace";
            this.txtDBNamespace.Size = new System.Drawing.Size(176, 20);
            this.txtDBNamespace.TabIndex = 0;
            this.txtDBNamespace.Text = "ProjectDatas";
            // 
            // gbPrimaryFieldType
            // 
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateUUID);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateHEXGUID);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateDBGenerator);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateGUID);
            this.gbPrimaryFieldType.Location = new System.Drawing.Point(199, 9);
            this.gbPrimaryFieldType.Name = "gbPrimaryFieldType";
            this.gbPrimaryFieldType.Size = new System.Drawing.Size(291, 129);
            this.gbPrimaryFieldType.TabIndex = 10;
            this.gbPrimaryFieldType.TabStop = false;
            this.gbPrimaryFieldType.Text = "FieldType primary field";
            // 
            // rbGenerateUUID
            // 
            this.rbGenerateUUID.AutoSize = true;
            this.rbGenerateUUID.Location = new System.Drawing.Point(12, 90);
            this.rbGenerateUUID.Name = "rbGenerateUUID";
            this.rbGenerateUUID.Size = new System.Drawing.Size(202, 17);
            this.rbGenerateUUID.TabIndex = 14;
            this.rbGenerateUUID.Text = "String with UUID generation (64 char)";
            this.rbGenerateUUID.UseVisualStyleBackColor = true;
            // 
            // rbGenerateHEXGUID
            // 
            this.rbGenerateHEXGUID.AutoSize = true;
            this.rbGenerateHEXGUID.Location = new System.Drawing.Point(12, 67);
            this.rbGenerateHEXGUID.Name = "rbGenerateHEXGUID";
            this.rbGenerateHEXGUID.Size = new System.Drawing.Size(224, 17);
            this.rbGenerateHEXGUID.TabIndex = 13;
            this.rbGenerateHEXGUID.Text = "String with HEXGUID generation (32 char)";
            this.rbGenerateHEXGUID.UseVisualStyleBackColor = true;
            // 
            // rbGenerateDBGenerator
            // 
            this.rbGenerateDBGenerator.AutoSize = true;
            this.rbGenerateDBGenerator.Checked = true;
            this.rbGenerateDBGenerator.Location = new System.Drawing.Point(12, 22);
            this.rbGenerateDBGenerator.Name = "rbGenerateDBGenerator";
            this.rbGenerateDBGenerator.Size = new System.Drawing.Size(128, 17);
            this.rbGenerateDBGenerator.TabIndex = 1;
            this.rbGenerateDBGenerator.TabStop = true;
            this.rbGenerateDBGenerator.Text = "Integer with generator";
            this.rbGenerateDBGenerator.UseVisualStyleBackColor = true;
            // 
            // rbGenerateGUID
            // 
            this.rbGenerateGUID.AutoSize = true;
            this.rbGenerateGUID.Location = new System.Drawing.Point(12, 43);
            this.rbGenerateGUID.Name = "rbGenerateGUID";
            this.rbGenerateGUID.Size = new System.Drawing.Size(202, 17);
            this.rbGenerateGUID.TabIndex = 0;
            this.rbGenerateGUID.Text = "String with GUID generation (64 char)";
            this.rbGenerateGUID.UseVisualStyleBackColor = true;
            // 
            // gbSetTerm
            // 
            this.gbSetTerm.Controls.Add(this.lblToReplaceSetTerm);
            this.gbSetTerm.Controls.Add(this.txtAlternativeSetTermCharacter);
            this.gbSetTerm.Location = new System.Drawing.Point(8, 9);
            this.gbSetTerm.Name = "gbSetTerm";
            this.gbSetTerm.Size = new System.Drawing.Size(182, 44);
            this.gbSetTerm.TabIndex = 1;
            this.gbSetTerm.TabStop = false;
            this.gbSetTerm.Text = "Alternative SET TERM character";
            // 
            // lblToReplaceSetTerm
            // 
            this.lblToReplaceSetTerm.AutoSize = true;
            this.lblToReplaceSetTerm.Location = new System.Drawing.Point(109, 23);
            this.lblToReplaceSetTerm.Name = "lblToReplaceSetTerm";
            this.lblToReplaceSetTerm.Size = new System.Drawing.Size(58, 13);
            this.lblToReplaceSetTerm.TabIndex = 1;
            this.lblToReplaceSetTerm.Text = "Replaces ;";
            // 
            // txtAlternativeSetTermCharacter
            // 
            this.txtAlternativeSetTermCharacter.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAlternativeSetTermCharacter.Location = new System.Drawing.Point(3, 16);
            this.txtAlternativeSetTermCharacter.Name = "txtAlternativeSetTermCharacter";
            this.txtAlternativeSetTermCharacter.Size = new System.Drawing.Size(100, 20);
            this.txtAlternativeSetTermCharacter.TabIndex = 1;
            this.txtAlternativeSetTermCharacter.TextChanged += new System.EventHandler(this.txtAlternativeSetTermCHaracter_TextChanged);
            // 
            // gbAttributesUpper
            // 
            this.gbAttributesUpper.Controls.Add(this.gbVersion);
            this.gbAttributesUpper.Controls.Add(this.panel1);
            this.gbAttributesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAttributesUpper.Location = new System.Drawing.Point(0, 0);
            this.gbAttributesUpper.Name = "gbAttributesUpper";
            this.gbAttributesUpper.Size = new System.Drawing.Size(758, 177);
            this.gbAttributesUpper.TabIndex = 13;
            this.gbAttributesUpper.TabStop = false;
            // 
            // gbVersion
            // 
            this.gbVersion.Controls.Add(this.rb4_64);
            this.gbVersion.Controls.Add(this.rb4_32);
            this.gbVersion.Controls.Add(this.gbClientLibrary);
            this.gbVersion.Controls.Add(this.groupBox1);
            this.gbVersion.Controls.Add(this.rb3_64);
            this.gbVersion.Controls.Add(this.rb3_32);
            this.gbVersion.Controls.Add(this.rb25_64);
            this.gbVersion.Controls.Add(this.rb25_32);
            this.gbVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVersion.Location = new System.Drawing.Point(3, 78);
            this.gbVersion.Name = "gbVersion";
            this.gbVersion.Size = new System.Drawing.Size(752, 93);
            this.gbVersion.TabIndex = 11;
            this.gbVersion.TabStop = false;
            this.gbVersion.Text = "Version";
            // 
            // rb4_64
            // 
            this.rb4_64.AutoSize = true;
            this.rb4_64.Location = new System.Drawing.Point(216, 44);
            this.rb4_64.Name = "rb4_64";
            this.rb4_64.Size = new System.Drawing.Size(57, 17);
            this.rb4_64.TabIndex = 5;
            this.rb4_64.TabStop = true;
            this.rb4_64.Text = "4 64bit";
            this.rb4_64.UseVisualStyleBackColor = true;
            this.rb4_64.CheckedChanged += new System.EventHandler(this.dbVersion_CheckedChanged);
            // 
            // rb4_32
            // 
            this.rb4_32.AutoSize = true;
            this.rb4_32.Location = new System.Drawing.Point(216, 19);
            this.rb4_32.Name = "rb4_32";
            this.rb4_32.Size = new System.Drawing.Size(57, 17);
            this.rb4_32.TabIndex = 4;
            this.rb4_32.TabStop = true;
            this.rb4_32.Text = "4 32bit";
            this.rb4_32.UseVisualStyleBackColor = true;
            this.rb4_32.CheckedChanged += new System.EventHandler(this.dbVersion_CheckedChanged);
            // 
            // gbClientLibrary
            // 
            this.gbClientLibrary.Controls.Add(this.txtClientLibrary);
            this.gbClientLibrary.Location = new System.Drawing.Point(286, 11);
            this.gbClientLibrary.Name = "gbClientLibrary";
            this.gbClientLibrary.Size = new System.Drawing.Size(461, 38);
            this.gbClientLibrary.TabIndex = 11;
            this.gbClientLibrary.TabStop = false;
            this.gbClientLibrary.Text = "Client Library";
            // 
            // txtClientLibrary
            // 
            this.txtClientLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClientLibrary.Location = new System.Drawing.Point(3, 16);
            this.txtClientLibrary.Name = "txtClientLibrary";
            this.txtClientLibrary.ReadOnly = true;
            this.txtClientLibrary.Size = new System.Drawing.Size(455, 20);
            this.txtClientLibrary.TabIndex = 1;
            this.txtClientLibrary.Text = "fbclient.dll";
            this.txtClientLibrary.TextChanged += new System.EventHandler(this.txtClientLibrary_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirebirdBinaryPath);
            this.groupBox1.Location = new System.Drawing.Point(286, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path for Firebird binaries";
            // 
            // txtFirebirdBinaryPath
            // 
            this.txtFirebirdBinaryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirebirdBinaryPath.Location = new System.Drawing.Point(3, 16);
            this.txtFirebirdBinaryPath.Name = "txtFirebirdBinaryPath";
            this.txtFirebirdBinaryPath.ReadOnly = true;
            this.txtFirebirdBinaryPath.Size = new System.Drawing.Size(457, 20);
            this.txtFirebirdBinaryPath.TabIndex = 1;
            // 
            // rb3_64
            // 
            this.rb3_64.AutoSize = true;
            this.rb3_64.Location = new System.Drawing.Point(123, 44);
            this.rb3_64.Name = "rb3_64";
            this.rb3_64.Size = new System.Drawing.Size(57, 17);
            this.rb3_64.TabIndex = 3;
            this.rb3_64.TabStop = true;
            this.rb3_64.Text = "3 64bit";
            this.rb3_64.UseVisualStyleBackColor = true;
            this.rb3_64.CheckedChanged += new System.EventHandler(this.dbVersion_CheckedChanged);
            // 
            // rb3_32
            // 
            this.rb3_32.AutoSize = true;
            this.rb3_32.Location = new System.Drawing.Point(123, 19);
            this.rb3_32.Name = "rb3_32";
            this.rb3_32.Size = new System.Drawing.Size(57, 17);
            this.rb3_32.TabIndex = 2;
            this.rb3_32.TabStop = true;
            this.rb3_32.Text = "3 32bit";
            this.rb3_32.UseVisualStyleBackColor = true;
            this.rb3_32.CheckedChanged += new System.EventHandler(this.dbVersion_CheckedChanged);
            // 
            // rb25_64
            // 
            this.rb25_64.AutoSize = true;
            this.rb25_64.Location = new System.Drawing.Point(15, 44);
            this.rb25_64.Name = "rb25_64";
            this.rb25_64.Size = new System.Drawing.Size(66, 17);
            this.rb25_64.TabIndex = 1;
            this.rb25_64.TabStop = true;
            this.rb25_64.Text = "2.5 64bit";
            this.rb25_64.UseVisualStyleBackColor = true;
            this.rb25_64.CheckedChanged += new System.EventHandler(this.dbVersion_CheckedChanged);
            // 
            // rb25_32
            // 
            this.rb25_32.AutoSize = true;
            this.rb25_32.Location = new System.Drawing.Point(15, 21);
            this.rb25_32.Name = "rb25_32";
            this.rb25_32.Size = new System.Drawing.Size(66, 17);
            this.rb25_32.TabIndex = 0;
            this.rb25_32.TabStop = true;
            this.rb25_32.Text = "2.5 32bit";
            this.rb25_32.UseVisualStyleBackColor = true;
            this.rb25_32.CheckedChanged += new System.EventHandler(this.dbVersion_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDatenbankAlias);
            this.panel1.Controls.Add(this.hsConnect);
            this.panel1.Controls.Add(this.gbLivettime);
            this.panel1.Controls.Add(this.pnlConnectState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 62);
            this.panel1.TabIndex = 12;
            // 
            // gbDatenbankAlias
            // 
            this.gbDatenbankAlias.Controls.Add(this.txtDatabaseAlias);
            this.gbDatenbankAlias.Location = new System.Drawing.Point(3, 3);
            this.gbDatenbankAlias.Name = "gbDatenbankAlias";
            this.gbDatenbankAlias.Size = new System.Drawing.Size(308, 41);
            this.gbDatenbankAlias.TabIndex = 7;
            this.gbDatenbankAlias.TabStop = false;
            this.gbDatenbankAlias.Text = "Database-Alias";
            // 
            // txtDatabaseAlias
            // 
            this.txtDatabaseAlias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabaseAlias.Location = new System.Drawing.Point(3, 16);
            this.txtDatabaseAlias.Name = "txtDatabaseAlias";
            this.txtDatabaseAlias.Size = new System.Drawing.Size(302, 20);
            this.txtDatabaseAlias.TabIndex = 1;
            this.txtDatabaseAlias.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // hsConnect
            // 
            this.hsConnect.BackColor = System.Drawing.Color.Transparent;
            this.hsConnect.BackColorHover = System.Drawing.Color.Transparent;
            this.hsConnect.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsConnect.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsConnect.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsConnect.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsConnect.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsConnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsConnect.FlatAppearance.BorderSize = 0;
            this.hsConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsConnect.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsConnect.Image = global::FBXpert.Properties.Resources.database1;
            this.hsConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsConnect.ImageHover = global::FBXpert.Properties.Resources.database_check;
            this.hsConnect.ImageToggleOnSelect = true;
            this.hsConnect.Location = new System.Drawing.Point(314, 0);
            this.hsConnect.Marked = false;
            this.hsConnect.MarkedColor = System.Drawing.Color.Teal;
            this.hsConnect.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsConnect.MarkedText = "";
            this.hsConnect.MarkMode = false;
            this.hsConnect.Name = "hsConnect";
            this.hsConnect.NonMarkedText = "Connect";
            this.hsConnect.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsConnect.ShowShortcut = false;
            this.hsConnect.Size = new System.Drawing.Size(96, 53);
            this.hsConnect.TabIndex = 8;
            this.hsConnect.Text = "Connect";
            this.hsConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsConnect.ToolTipActive = false;
            this.hsConnect.ToolTipAutomaticDelay = 500;
            this.hsConnect.ToolTipAutoPopDelay = 5000;
            this.hsConnect.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsConnect.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsConnect.ToolTipFor4ContextMenu = true;
            this.hsConnect.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsConnect.ToolTipInitialDelay = 500;
            this.hsConnect.ToolTipIsBallon = false;
            this.hsConnect.ToolTipOwnerDraw = false;
            this.hsConnect.ToolTipReshowDelay = 100;
            this.hsConnect.ToolTipShowAlways = false;
            this.hsConnect.ToolTipText = "";
            this.hsConnect.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsConnect.ToolTipTitle = "";
            this.hsConnect.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsConnect.UseVisualStyleBackColor = false;
            this.hsConnect.Click += new System.EventHandler(this.hsConnect_Click);
            // 
            // gbLivettime
            // 
            this.gbLivettime.Controls.Add(this.txtLifetime);
            this.gbLivettime.Location = new System.Drawing.Point(465, 3);
            this.gbLivettime.Name = "gbLivettime";
            this.gbLivettime.Size = new System.Drawing.Size(116, 41);
            this.gbLivettime.TabIndex = 10;
            this.gbLivettime.TabStop = false;
            this.gbLivettime.Text = "Lifetime";
            // 
            // txtLifetime
            // 
            this.txtLifetime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLifetime.Enabled = false;
            this.txtLifetime.Location = new System.Drawing.Point(3, 16);
            this.txtLifetime.Name = "txtLifetime";
            this.txtLifetime.Size = new System.Drawing.Size(110, 20);
            this.txtLifetime.TabIndex = 1;
            // 
            // pnlConnectState
            // 
            this.pnlConnectState.Location = new System.Drawing.Point(416, 12);
            this.pnlConnectState.Name = "pnlConnectState";
            this.pnlConnectState.Size = new System.Drawing.Size(42, 41);
            this.pnlConnectState.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.FDB";
            this.openFileDialog1.FileName = "fbclient.dll";
            this.openFileDialog1.Filter = "Firebird|*.fdb|All|*.*";
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.pnlFormName);
            this.pnlUpper.Controls.Add(this.hsGlobalApplicationSettings);
            this.pnlUpper.Controls.Add(this.hsClone);
            this.pnlUpper.Controls.Add(this.hsSave);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(758, 51);
            this.pnlUpper.TabIndex = 3;
            // 
            // hsGlobalApplicationSettings
            // 
            this.hsGlobalApplicationSettings.BackColor = System.Drawing.Color.Transparent;
            this.hsGlobalApplicationSettings.BackColorHover = System.Drawing.Color.Transparent;
            this.hsGlobalApplicationSettings.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsGlobalApplicationSettings.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsGlobalApplicationSettings.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsGlobalApplicationSettings.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsGlobalApplicationSettings.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsGlobalApplicationSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsGlobalApplicationSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsGlobalApplicationSettings.FlatAppearance.BorderSize = 0;
            this.hsGlobalApplicationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsGlobalApplicationSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsGlobalApplicationSettings.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsGlobalApplicationSettings.Image = global::FBXpert.Properties.Resources.preferences_system_x24;
            this.hsGlobalApplicationSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsGlobalApplicationSettings.ImageHover = global::FBXpert.Properties.Resources.preferences_system_blue_x24;
            this.hsGlobalApplicationSettings.ImageToggleOnSelect = true;
            this.hsGlobalApplicationSettings.Location = new System.Drawing.Point(224, 0);
            this.hsGlobalApplicationSettings.Marked = false;
            this.hsGlobalApplicationSettings.MarkedColor = System.Drawing.Color.Teal;
            this.hsGlobalApplicationSettings.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsGlobalApplicationSettings.MarkedText = "";
            this.hsGlobalApplicationSettings.MarkMode = false;
            this.hsGlobalApplicationSettings.Name = "hsGlobalApplicationSettings";
            this.hsGlobalApplicationSettings.NonMarkedText = "Clone";
            this.hsGlobalApplicationSettings.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsGlobalApplicationSettings.ShowShortcut = false;
            this.hsGlobalApplicationSettings.Size = new System.Drawing.Size(150, 51);
            this.hsGlobalApplicationSettings.TabIndex = 5;
            this.hsGlobalApplicationSettings.Text = "Global Application Settings";
            this.hsGlobalApplicationSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsGlobalApplicationSettings.ToolTipActive = false;
            this.hsGlobalApplicationSettings.ToolTipAutomaticDelay = 500;
            this.hsGlobalApplicationSettings.ToolTipAutoPopDelay = 5000;
            this.hsGlobalApplicationSettings.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsGlobalApplicationSettings.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsGlobalApplicationSettings.ToolTipFor4ContextMenu = true;
            this.hsGlobalApplicationSettings.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsGlobalApplicationSettings.ToolTipInitialDelay = 500;
            this.hsGlobalApplicationSettings.ToolTipIsBallon = false;
            this.hsGlobalApplicationSettings.ToolTipOwnerDraw = false;
            this.hsGlobalApplicationSettings.ToolTipReshowDelay = 100;
            this.hsGlobalApplicationSettings.ToolTipShowAlways = false;
            this.hsGlobalApplicationSettings.ToolTipText = "";
            this.hsGlobalApplicationSettings.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsGlobalApplicationSettings.ToolTipTitle = "";
            this.hsGlobalApplicationSettings.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsGlobalApplicationSettings.UseVisualStyleBackColor = false;
            this.hsGlobalApplicationSettings.Click += new System.EventHandler(this.hsGlobalApplicationSettings_Click);
            // 
            // hsClone
            // 
            this.hsClone.BackColor = System.Drawing.Color.Transparent;
            this.hsClone.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClone.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClone.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClone.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClone.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClone.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClone.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClone.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsClone.FlatAppearance.BorderSize = 0;
            this.hsClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClone.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClone.Image = global::FBXpert.Properties.Resources.database_add_24x;
            this.hsClone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsClone.ImageHover = global::FBXpert.Properties.Resources.database_add_24x;
            this.hsClone.ImageToggleOnSelect = true;
            this.hsClone.Location = new System.Drawing.Point(151, 0);
            this.hsClone.Marked = false;
            this.hsClone.MarkedColor = System.Drawing.Color.Teal;
            this.hsClone.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClone.MarkedText = "";
            this.hsClone.MarkMode = false;
            this.hsClone.Name = "hsClone";
            this.hsClone.NonMarkedText = "Clone";
            this.hsClone.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClone.ShowShortcut = false;
            this.hsClone.Size = new System.Drawing.Size(73, 51);
            this.hsClone.TabIndex = 4;
            this.hsClone.Text = "Clone";
            this.hsClone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClone.ToolTipActive = false;
            this.hsClone.ToolTipAutomaticDelay = 500;
            this.hsClone.ToolTipAutoPopDelay = 5000;
            this.hsClone.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClone.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClone.ToolTipFor4ContextMenu = true;
            this.hsClone.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClone.ToolTipInitialDelay = 500;
            this.hsClone.ToolTipIsBallon = false;
            this.hsClone.ToolTipOwnerDraw = false;
            this.hsClone.ToolTipReshowDelay = 100;
            this.hsClone.ToolTipShowAlways = false;
            this.hsClone.ToolTipText = "";
            this.hsClone.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClone.ToolTipTitle = "";
            this.hsClone.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClone.UseVisualStyleBackColor = false;
            this.hsClone.Click += new System.EventHandler(this.hsClone_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(6, 18);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(97, 20);
            this.lblFormName.TabIndex = 3;
            this.lblFormName.Text = "Tablename";
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
            this.hsSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSave.ImageHover = global::FBXpert.Properties.Resources.ok_blue32x;
            this.hsSave.ImageToggleOnSelect = true;
            this.hsSave.Location = new System.Drawing.Point(45, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "Save";
            this.hsSave.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSave.ShowShortcut = false;
            this.hsSave.Size = new System.Drawing.Size(106, 51);
            this.hsSave.TabIndex = 3;
            this.hsSave.Text = "Save";
            this.hsSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSave.ToolTipActive = true;
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
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(45, 51);
            this.hsClose.TabIndex = 1;
            this.hsClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClose.ToolTipActive = true;
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
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click_1);
            // 
            // numPort
            // 
            this.numPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPort.Location = new System.Drawing.Point(3, 16);
            this.numPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(67, 20);
            this.numPort.TabIndex = 3;
            this.numPort.Value = new decimal(new int[] {
            3050,
            0,
            0,
            0});
            // 
            // numPacketSize
            // 
            this.numPacketSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPacketSize.Location = new System.Drawing.Point(3, 16);
            this.numPacketSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPacketSize.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numPacketSize.Name = "numPacketSize";
            this.numPacketSize.Size = new System.Drawing.Size(100, 20);
            this.numPacketSize.TabIndex = 2;
            this.numPacketSize.Value = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            // 
            // pnlFormName
            // 
            this.pnlFormName.Controls.Add(this.lblFormName);
            this.pnlFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormName.Location = new System.Drawing.Point(374, 0);
            this.pnlFormName.Name = "pnlFormName";
            this.pnlFormName.Size = new System.Drawing.Size(384, 51);
            this.pnlFormName.TabIndex = 6;
            // 
            // DatabaseConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 632);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseConfigForm";
            this.Text = "4";
            this.Load += new System.EventHandler(this.DatabaseConfigForm_Load);
            this.pnlCenter.ResumeLayout(false);
            this.tabcontrolConfig.ResumeLayout(false);
            this.tabBasicConf.ResumeLayout(false);
            this.pnlCenterBasicConf.ResumeLayout(false);
            this.gbCreateDatabaseLocationFile.ResumeLayout(false);
            this.gbCreateDatabaseLocationFile.PerformLayout();
            this.gbConnectionString.ResumeLayout(false);
            this.gbConnectionString.PerformLayout();
            this.gbCollation.ResumeLayout(false);
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            this.gbCSet.ResumeLayout(false);
            this.gbDatabaseLocation.ResumeLayout(false);
            this.gbDatabaseLocation.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.gbPort.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbConnectionType.ResumeLayout(false);
            this.gbConnectionType.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbPacketsize.ResumeLayout(false);
            this.tabXPertUsedAttributes.ResumeLayout(false);
            this.pnlAttributesCenter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbConnectionLifetime.ResumeLayout(false);
            this.gbConnectionLifetime.PerformLayout();
            this.gbMinPoolSize.ResumeLayout(false);
            this.gbMinPoolSize.PerformLayout();
            this.gbMaxPoolSize.ResumeLayout(false);
            this.gbMaxPoolSize.PerformLayout();
            this.tabPageSourceControl.ResumeLayout(false);
            this.pnlSouceControlCenter.ResumeLayout(false);
            this.gbSourceCodeOutputPath.ResumeLayout(false);
            this.gbSourceCodeOutputPath.PerformLayout();
            this.gbDBNamespace.ResumeLayout(false);
            this.gbDBNamespace.PerformLayout();
            this.gbPrimaryFieldType.ResumeLayout(false);
            this.gbPrimaryFieldType.PerformLayout();
            this.gbSetTerm.ResumeLayout(false);
            this.gbSetTerm.PerformLayout();
            this.gbAttributesUpper.ResumeLayout(false);
            this.gbVersion.ResumeLayout(false);
            this.gbVersion.PerformLayout();
            this.gbClientLibrary.ResumeLayout(false);
            this.gbClientLibrary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbDatenbankAlias.ResumeLayout(false);
            this.gbDatenbankAlias.PerformLayout();
            this.gbLivettime.ResumeLayout(false);
            this.gbLivettime.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketSize)).EndInit();
            this.pnlFormName.ResumeLayout(false);
            this.pnlFormName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox gbDatabaseLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.GroupBox gbConnectionType;
        private System.Windows.Forms.RadioButton rbRemote;
        private SeControlsLib.HotSpot hsLoad;
        private System.Windows.Forms.GroupBox gbCSet;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.GroupBox gbPacketsize;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.GroupBox gbDatenbankAlias;
        private System.Windows.Forms.TextBox txtDatabaseAlias;
        private System.Windows.Forms.TabControl tabcontrolConfig;
        private System.Windows.Forms.TabPage tabBasicConf;
        private System.Windows.Forms.Panel pnlCenterBasicConf;
        private System.Windows.Forms.TabPage tabXPertUsedAttributes;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.RadioButton rbEmbedded;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.TextBox txtRole;
        private SeControlsLib.HotSpot hsConnect;
        private System.Windows.Forms.Panel pnlConnectState;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbCollation;
        private System.Windows.Forms.ComboBox cbCollation;
        private System.Windows.Forms.CheckBox cbPooling;
        private System.Windows.Forms.GroupBox gbAttributesUpper;
        private System.Windows.Forms.Panel pnlAttributesCenter;
        private System.Windows.Forms.GroupBox gbConnectionLifetime;
        private System.Windows.Forms.Label lblConnectionLifetime;
        private System.Windows.Forms.TextBox txtConnectionLifetime;
        private System.Windows.Forms.GroupBox gbMaxPoolSize;
        private System.Windows.Forms.TextBox txtMaxPoolSize;
        private System.Windows.Forms.GroupBox gbMinPoolSize;
        private System.Windows.Forms.TextBox txtMinPoolSize;
        private System.Windows.Forms.TabPage tabPageSourceControl;
        private System.Windows.Forms.Panel pnlSouceControlCenter;
        private System.Windows.Forms.GroupBox gbSetTerm;
        private System.Windows.Forms.Label lblToReplaceSetTerm;
        private System.Windows.Forms.TextBox txtAlternativeSetTermCharacter;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbLivettime;
        private System.Windows.Forms.TextBox txtLifetime;
        private SeControlsLib.HotSpot hsCreateDatabase;
        private SeControlsLib.HotSpot hsClone;
        private System.Windows.Forms.GroupBox gbClientLibrary;
        private System.Windows.Forms.TextBox txtClientLibrary;
        private SeControlsLib.HotSpot hsChangeFullPath;
        private System.Windows.Forms.GroupBox gbConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.GroupBox gbVersion;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Label lblFormName;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.GroupBox gbDBNamespace;
        private System.Windows.Forms.TextBox txtDBNamespace;
        private System.Windows.Forms.GroupBox gbPrimaryFieldType;
        private System.Windows.Forms.RadioButton rbGenerateDBGenerator;
        private System.Windows.Forms.RadioButton rbGenerateGUID;
        private System.Windows.Forms.GroupBox gbSourceCodeOutputPath;
        private System.Windows.Forms.TextBox txtSourcecodeOutputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirebirdBinaryPath;
        private System.Windows.Forms.RadioButton rb4_64;
        private System.Windows.Forms.RadioButton rb4_32;
        private System.Windows.Forms.RadioButton rb3_64;
        private System.Windows.Forms.RadioButton rb3_32;
        private System.Windows.Forms.RadioButton rb25_64;
        private System.Windows.Forms.RadioButton rb25_32;
        private System.Windows.Forms.RadioButton rbGenerateHEXGUID;
        private SeControlsLib.HotSpot hsSourcecodeFolder;
        private System.Windows.Forms.RadioButton rbGenerateUUID;
        private System.Windows.Forms.GroupBox gbCreateDatabaseLocationFile;
        private System.Windows.Forms.TextBox txtCreateDatabaseLocationFile;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.Panel panel1;
        private SeControlsLib.HotSpot hsGlobalApplicationSettings;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.NumericUpDown numPacketSize;
        private System.Windows.Forms.Panel pnlFormName;
    }
}