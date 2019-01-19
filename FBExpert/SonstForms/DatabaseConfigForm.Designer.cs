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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConfigForm));
            this.hsClone = new SeControlsLib.HotSpot();
            this.hsSave = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabcontrolConfig = new System.Windows.Forms.TabControl();
            this.tabBasicConf = new System.Windows.Forms.TabPage();
            this.pnlCenterBasicConf = new System.Windows.Forms.Panel();
            this.gbConnectionString = new System.Windows.Forms.GroupBox();
            this.txtConnectioString = new System.Windows.Forms.TextBox();
            this.gbClientLibrary = new System.Windows.Forms.GroupBox();
            this.hsLoadClientLib = new SeControlsLib.HotSpot();
            this.txtClientLibrary = new System.Windows.Forms.TextBox();
            this.hsCreateDatabase = new SeControlsLib.HotSpot();
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbConnectionType = new System.Windows.Forms.GroupBox();
            this.rbEmbedded = new System.Windows.Forms.RadioButton();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.rbRemote = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.gbPacketsize = new System.Windows.Forms.GroupBox();
            this.txtPacketsize = new System.Windows.Forms.TextBox();
            this.tabXPertUsedAttributes = new System.Windows.Forms.TabPage();
            this.pnlAttributesCenter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbTableMaxRows = new System.Windows.Forms.GroupBox();
            this.txtTableMaxRows = new System.Windows.Forms.TextBox();
            this.gbSkipForSelect = new System.Windows.Forms.GroupBox();
            this.txtSkipForSelect = new System.Windows.Forms.TextBox();
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
            this.gbDBNamespace = new System.Windows.Forms.GroupBox();
            this.txtDBNamespace = new System.Windows.Forms.TextBox();
            this.gbPrimaryFieldType = new System.Windows.Forms.GroupBox();
            this.rbGenerateInrWithGenerator = new System.Windows.Forms.RadioButton();
            this.rbGenerateUUID = new System.Windows.Forms.RadioButton();
            this.gbSetTerm = new System.Windows.Forms.GroupBox();
            this.lblToReplaceSetTerm = new System.Windows.Forms.Label();
            this.txtAlternativeSetTermCharacter = new System.Windows.Forms.TextBox();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.pnlMisc = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirebirdBinaryPath = new System.Windows.Forms.TextBox();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.gbDefaultReportPath = new System.Windows.Forms.GroupBox();
            this.txtDefaultReportPath = new System.Windows.Forms.TextBox();
            this.hsLoadDefaultReportPath = new SeControlsLib.HotSpot();
            this.gbDefaultScriptPath = new System.Windows.Forms.GroupBox();
            this.txtDefaultScriptPath = new System.Windows.Forms.TextBox();
            this.hsLoadDefaultScriptPath = new SeControlsLib.HotSpot();
            this.tabCreateSQL = new System.Windows.Forms.TabPage();
            this.fcbSQLCreate = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlSQLCreateUpper = new System.Windows.Forms.Panel();
            this.hsCreate = new SeControlsLib.HotSpot();
            this.gbAttributesUpper = new System.Windows.Forms.GroupBox();
            this.gbVersion = new System.Windows.Forms.GroupBox();
            this.gbLivettime = new System.Windows.Forms.GroupBox();
            this.txtLifetime = new System.Windows.Forms.TextBox();
            this.gbDatenbankAlias = new System.Windows.Forms.GroupBox();
            this.txtDatabaseAlias = new System.Windows.Forms.TextBox();
            this.hsConnect = new SeControlsLib.HotSpot();
            this.pnlConnectState = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hsClose = new SeControlsLib.HotSpot();
            this.rb25_32 = new System.Windows.Forms.RadioButton();
            this.rb25_64 = new System.Windows.Forms.RadioButton();
            this.rb3_32 = new System.Windows.Forms.RadioButton();
            this.rb3_64 = new System.Windows.Forms.RadioButton();
            this.rb4_32 = new System.Windows.Forms.RadioButton();
            this.rb4_64 = new System.Windows.Forms.RadioButton();
            this.pnlCenter.SuspendLayout();
            this.tabcontrolConfig.SuspendLayout();
            this.tabBasicConf.SuspendLayout();
            this.pnlCenterBasicConf.SuspendLayout();
            this.gbConnectionString.SuspendLayout();
            this.gbClientLibrary.SuspendLayout();
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
            this.gbTableMaxRows.SuspendLayout();
            this.gbSkipForSelect.SuspendLayout();
            this.gbConnectionLifetime.SuspendLayout();
            this.gbMinPoolSize.SuspendLayout();
            this.gbMaxPoolSize.SuspendLayout();
            this.tabPageSourceControl.SuspendLayout();
            this.pnlSouceControlCenter.SuspendLayout();
            this.gbSourceCodeOutputPath.SuspendLayout();
            this.gbDBNamespace.SuspendLayout();
            this.gbPrimaryFieldType.SuspendLayout();
            this.gbSetTerm.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.pnlMisc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDefaultReportPath.SuspendLayout();
            this.gbDefaultScriptPath.SuspendLayout();
            this.tabCreateSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcbSQLCreate)).BeginInit();
            this.pnlSQLCreateUpper.SuspendLayout();
            this.gbAttributesUpper.SuspendLayout();
            this.gbVersion.SuspendLayout();
            this.gbLivettime.SuspendLayout();
            this.gbDatenbankAlias.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.SuspendLayout();
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
            // pnlLower
            // 
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 699);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(855, 23);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabcontrolConfig);
            this.pnlCenter.Controls.Add(this.gbAttributesUpper);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 51);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(855, 648);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabcontrolConfig
            // 
            this.tabcontrolConfig.Controls.Add(this.tabBasicConf);
            this.tabcontrolConfig.Controls.Add(this.tabXPertUsedAttributes);
            this.tabcontrolConfig.Controls.Add(this.tabPageSourceControl);
            this.tabcontrolConfig.Controls.Add(this.tabMisc);
            this.tabcontrolConfig.Controls.Add(this.tabCreateSQL);
            this.tabcontrolConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolConfig.Location = new System.Drawing.Point(0, 184);
            this.tabcontrolConfig.Name = "tabcontrolConfig";
            this.tabcontrolConfig.SelectedIndex = 0;
            this.tabcontrolConfig.Size = new System.Drawing.Size(855, 464);
            this.tabcontrolConfig.TabIndex = 7;
            // 
            // tabBasicConf
            // 
            this.tabBasicConf.Controls.Add(this.pnlCenterBasicConf);
            this.tabBasicConf.Location = new System.Drawing.Point(4, 22);
            this.tabBasicConf.Name = "tabBasicConf";
            this.tabBasicConf.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicConf.Size = new System.Drawing.Size(847, 438);
            this.tabBasicConf.TabIndex = 0;
            this.tabBasicConf.Text = "Basic configuration";
            this.tabBasicConf.UseVisualStyleBackColor = true;
            // 
            // pnlCenterBasicConf
            // 
            this.pnlCenterBasicConf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCenterBasicConf.Controls.Add(this.gbConnectionString);
            this.pnlCenterBasicConf.Controls.Add(this.gbClientLibrary);
            this.pnlCenterBasicConf.Controls.Add(this.hsCreateDatabase);
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
            this.pnlCenterBasicConf.Size = new System.Drawing.Size(841, 432);
            this.pnlCenterBasicConf.TabIndex = 0;
            // 
            // gbConnectionString
            // 
            this.gbConnectionString.Controls.Add(this.txtConnectioString);
            this.gbConnectionString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbConnectionString.Location = new System.Drawing.Point(0, 301);
            this.gbConnectionString.Name = "gbConnectionString";
            this.gbConnectionString.Size = new System.Drawing.Size(841, 131);
            this.gbConnectionString.TabIndex = 13;
            this.gbConnectionString.TabStop = false;
            this.gbConnectionString.Text = "Connection String";
            // 
            // txtConnectioString
            // 
            this.txtConnectioString.BackColor = System.Drawing.SystemColors.Info;
            this.txtConnectioString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnectioString.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectioString.Location = new System.Drawing.Point(3, 16);
            this.txtConnectioString.Multiline = true;
            this.txtConnectioString.Name = "txtConnectioString";
            this.txtConnectioString.Size = new System.Drawing.Size(835, 112);
            this.txtConnectioString.TabIndex = 1;
            // 
            // gbClientLibrary
            // 
            this.gbClientLibrary.Controls.Add(this.hsLoadClientLib);
            this.gbClientLibrary.Controls.Add(this.txtClientLibrary);
            this.gbClientLibrary.Location = new System.Drawing.Point(319, 197);
            this.gbClientLibrary.Name = "gbClientLibrary";
            this.gbClientLibrary.Size = new System.Drawing.Size(291, 41);
            this.gbClientLibrary.TabIndex = 11;
            this.gbClientLibrary.TabStop = false;
            this.gbClientLibrary.Text = "Client Library";
            // 
            // hsLoadClientLib
            // 
            this.hsLoadClientLib.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadClientLib.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadClientLib.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadClientLib.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadClientLib.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadClientLib.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadClientLib.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadClientLib.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadClientLib.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadClientLib.FlatAppearance.BorderSize = 0;
            this.hsLoadClientLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadClientLib.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadClientLib.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadClientLib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoadClientLib.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadClientLib.ImageToggleOnSelect = false;
            this.hsLoadClientLib.Location = new System.Drawing.Point(223, 16);
            this.hsLoadClientLib.Marked = false;
            this.hsLoadClientLib.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadClientLib.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadClientLib.MarkedText = "";
            this.hsLoadClientLib.MarkMode = false;
            this.hsLoadClientLib.Name = "hsLoadClientLib";
            this.hsLoadClientLib.NonMarkedText = "Load";
            this.hsLoadClientLib.Size = new System.Drawing.Size(65, 22);
            this.hsLoadClientLib.TabIndex = 4;
            this.hsLoadClientLib.Text = "Load";
            this.hsLoadClientLib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsLoadClientLib.ToolTipActive = false;
            this.hsLoadClientLib.ToolTipAutomaticDelay = 500;
            this.hsLoadClientLib.ToolTipAutoPopDelay = 5000;
            this.hsLoadClientLib.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadClientLib.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadClientLib.ToolTipFor4ContextMenu = true;
            this.hsLoadClientLib.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadClientLib.ToolTipInitialDelay = 500;
            this.hsLoadClientLib.ToolTipIsBallon = false;
            this.hsLoadClientLib.ToolTipOwnerDraw = false;
            this.hsLoadClientLib.ToolTipReshowDelay = 100;
            this.hsLoadClientLib.ToolTipShowAlways = false;
            this.hsLoadClientLib.ToolTipText = "";
            this.hsLoadClientLib.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadClientLib.ToolTipTitle = "";
            this.hsLoadClientLib.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadClientLib.UseVisualStyleBackColor = false;
            this.hsLoadClientLib.Click += new System.EventHandler(this.hsLoadClientLib_Click);
            // 
            // txtClientLibrary
            // 
            this.txtClientLibrary.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtClientLibrary.Location = new System.Drawing.Point(3, 16);
            this.txtClientLibrary.Name = "txtClientLibrary";
            this.txtClientLibrary.Size = new System.Drawing.Size(179, 20);
            this.txtClientLibrary.TabIndex = 1;
            this.txtClientLibrary.Text = "fbclient.dll";
            this.txtClientLibrary.TextChanged += new System.EventHandler(this.txtClientLibrary_TextChanged);
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
            this.hsCreateDatabase.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreateDatabase.FlatAppearance.BorderSize = 0;
            this.hsCreateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreateDatabase.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreateDatabase.Image = global::FBXpert.Properties.Resources.applications_system_22x;
            this.hsCreateDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsCreateDatabase.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsCreateDatabase.ImageToggleOnSelect = false;
            this.hsCreateDatabase.Location = new System.Drawing.Point(614, 65);
            this.hsCreateDatabase.Marked = false;
            this.hsCreateDatabase.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreateDatabase.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreateDatabase.MarkedText = "";
            this.hsCreateDatabase.MarkMode = false;
            this.hsCreateDatabase.Name = "hsCreateDatabase";
            this.hsCreateDatabase.NonMarkedText = "Create new Database";
            this.hsCreateDatabase.Size = new System.Drawing.Size(150, 29);
            this.hsCreateDatabase.TabIndex = 4;
            this.hsCreateDatabase.Text = "Create new Database";
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
            // gbCollation
            // 
            this.gbCollation.Controls.Add(this.cbCollation);
            this.gbCollation.Location = new System.Drawing.Point(320, 144);
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
            this.gbRole.Location = new System.Drawing.Point(5, 244);
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
            this.gbCSet.Location = new System.Drawing.Point(319, 96);
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
            "WIN1251"});
            this.cbCharSet.Location = new System.Drawing.Point(3, 16);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(179, 21);
            this.cbCharSet.TabIndex = 3;
            this.cbCharSet.Text = "NONE";
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
            this.gbDatabaseLocation.Size = new System.Drawing.Size(841, 48);
            this.gbDatabaseLocation.TabIndex = 1;
            this.gbDatabaseLocation.TabStop = false;
            this.gbDatabaseLocation.Text = "Database Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Location = new System.Drawing.Point(3, 16);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(734, 20);
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
            this.hsChangeFullPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsChangeFullPath.Image = global::FBXpert.Properties.Resources.media_playlist_repeat_light_blue_x22;
            this.hsChangeFullPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsChangeFullPath.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_22x;
            this.hsChangeFullPath.ImageToggleOnSelect = false;
            this.hsChangeFullPath.Location = new System.Drawing.Point(737, 16);
            this.hsChangeFullPath.Marked = false;
            this.hsChangeFullPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsChangeFullPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsChangeFullPath.MarkedText = "";
            this.hsChangeFullPath.MarkMode = false;
            this.hsChangeFullPath.Name = "hsChangeFullPath";
            this.hsChangeFullPath.NonMarkedText = "";
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
            this.hsLoad.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoad.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsLoad.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoad.ImageToggleOnSelect = false;
            this.hsLoad.Location = new System.Drawing.Point(773, 16);
            this.hsLoad.Marked = false;
            this.hsLoad.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoad.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoad.MarkedText = "";
            this.hsLoad.MarkMode = false;
            this.hsLoad.Name = "hsLoad";
            this.hsLoad.NonMarkedText = "Load";
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
            this.gbPassword.Location = new System.Drawing.Point(5, 197);
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
            // 
            // gbPort
            // 
            this.gbPort.Controls.Add(this.txtPort);
            this.gbPort.Location = new System.Drawing.Point(319, 54);
            this.gbPort.Name = "gbPort";
            this.gbPort.Size = new System.Drawing.Size(73, 41);
            this.gbPort.TabIndex = 6;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(3, 16);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(67, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.txtUser);
            this.gbUser.Location = new System.Drawing.Point(5, 152);
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
            this.gbConnectionType.Controls.Add(this.rbLocal);
            this.gbConnectionType.Location = new System.Drawing.Point(5, 54);
            this.gbConnectionType.Name = "gbConnectionType";
            this.gbConnectionType.Size = new System.Drawing.Size(308, 92);
            this.gbConnectionType.TabIndex = 0;
            this.gbConnectionType.TabStop = false;
            this.gbConnectionType.Text = "Database Connectiontype";
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
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
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
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(18, 19);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 1;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbLocal_CheckedChanged);
            // 
            // gbPacketsize
            // 
            this.gbPacketsize.Controls.Add(this.txtPacketsize);
            this.gbPacketsize.Location = new System.Drawing.Point(398, 54);
            this.gbPacketsize.Name = "gbPacketsize";
            this.gbPacketsize.Size = new System.Drawing.Size(106, 41);
            this.gbPacketsize.TabIndex = 3;
            this.gbPacketsize.TabStop = false;
            this.gbPacketsize.Text = "Packetsize";
            // 
            // txtPacketsize
            // 
            this.txtPacketsize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPacketsize.Location = new System.Drawing.Point(3, 16);
            this.txtPacketsize.Name = "txtPacketsize";
            this.txtPacketsize.Size = new System.Drawing.Size(100, 20);
            this.txtPacketsize.TabIndex = 1;
            this.txtPacketsize.TextChanged += new System.EventHandler(this.txtPacketsize_TextChanged);
            // 
            // tabXPertUsedAttributes
            // 
            this.tabXPertUsedAttributes.Controls.Add(this.pnlAttributesCenter);
            this.tabXPertUsedAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabXPertUsedAttributes.Name = "tabXPertUsedAttributes";
            this.tabXPertUsedAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabXPertUsedAttributes.Size = new System.Drawing.Size(847, 461);
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
            this.pnlAttributesCenter.Size = new System.Drawing.Size(841, 455);
            this.pnlAttributesCenter.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.gbTableMaxRows);
            this.panel3.Controls.Add(this.gbSkipForSelect);
            this.panel3.Controls.Add(this.gbConnectionLifetime);
            this.panel3.Controls.Add(this.gbMinPoolSize);
            this.panel3.Controls.Add(this.gbMaxPoolSize);
            this.panel3.Controls.Add(this.cbPooling);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 455);
            this.panel3.TabIndex = 16;
            // 
            // gbTableMaxRows
            // 
            this.gbTableMaxRows.Controls.Add(this.txtTableMaxRows);
            this.gbTableMaxRows.Location = new System.Drawing.Point(23, 245);
            this.gbTableMaxRows.Name = "gbTableMaxRows";
            this.gbTableMaxRows.Size = new System.Drawing.Size(202, 41);
            this.gbTableMaxRows.TabIndex = 17;
            this.gbTableMaxRows.TabStop = false;
            this.gbTableMaxRows.Text = "Table/View SELECT MaxRows (0=all rows)";
            // 
            // txtTableMaxRows
            // 
            this.txtTableMaxRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableMaxRows.Location = new System.Drawing.Point(3, 16);
            this.txtTableMaxRows.Name = "txtTableMaxRows";
            this.txtTableMaxRows.Size = new System.Drawing.Size(196, 20);
            this.txtTableMaxRows.TabIndex = 1;
            this.txtTableMaxRows.Text = "0";
            // 
            // gbSkipForSelect
            // 
            this.gbSkipForSelect.Controls.Add(this.txtSkipForSelect);
            this.gbSkipForSelect.Location = new System.Drawing.Point(23, 198);
            this.gbSkipForSelect.Name = "gbSkipForSelect";
            this.gbSkipForSelect.Size = new System.Drawing.Size(106, 41);
            this.gbSkipForSelect.TabIndex = 16;
            this.gbSkipForSelect.TabStop = false;
            this.gbSkipForSelect.Text = "Skip for SELECT";
            // 
            // txtSkipForSelect
            // 
            this.txtSkipForSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSkipForSelect.Location = new System.Drawing.Point(3, 16);
            this.txtSkipForSelect.Name = "txtSkipForSelect";
            this.txtSkipForSelect.Size = new System.Drawing.Size(100, 20);
            this.txtSkipForSelect.TabIndex = 1;
            this.txtSkipForSelect.Text = "1000";
            this.txtSkipForSelect.TextChanged += new System.EventHandler(this.txtSkipForSelect_TextChanged);
            // 
            // gbConnectionLifetime
            // 
            this.gbConnectionLifetime.Controls.Add(this.lblConnectionLifetime);
            this.gbConnectionLifetime.Controls.Add(this.txtConnectionLifetime);
            this.gbConnectionLifetime.Location = new System.Drawing.Point(23, 138);
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
            this.gbMinPoolSize.Location = new System.Drawing.Point(23, 44);
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
            this.gbMaxPoolSize.Location = new System.Drawing.Point(23, 91);
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
            this.cbPooling.Location = new System.Drawing.Point(26, 16);
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
            this.tabPageSourceControl.Size = new System.Drawing.Size(847, 461);
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
            this.pnlSouceControlCenter.Size = new System.Drawing.Size(841, 455);
            this.pnlSouceControlCenter.TabIndex = 1;
            // 
            // gbSourceCodeOutputPath
            // 
            this.gbSourceCodeOutputPath.Controls.Add(this.txtSourcecodeOutputPath);
            this.gbSourceCodeOutputPath.Location = new System.Drawing.Point(19, 257);
            this.gbSourceCodeOutputPath.Name = "gbSourceCodeOutputPath";
            this.gbSourceCodeOutputPath.Size = new System.Drawing.Size(376, 46);
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
            this.txtSourcecodeOutputPath.Size = new System.Drawing.Size(370, 20);
            this.txtSourcecodeOutputPath.TabIndex = 0;
            this.txtSourcecodeOutputPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbDBNamespace
            // 
            this.gbDBNamespace.Controls.Add(this.txtDBNamespace);
            this.gbDBNamespace.Location = new System.Drawing.Point(19, 205);
            this.gbDBNamespace.Name = "gbDBNamespace";
            this.gbDBNamespace.Size = new System.Drawing.Size(206, 46);
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
            this.txtDBNamespace.Size = new System.Drawing.Size(200, 20);
            this.txtDBNamespace.TabIndex = 0;
            this.txtDBNamespace.Text = "ProjectDatas";
            // 
            // gbPrimaryFieldType
            // 
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateInrWithGenerator);
            this.gbPrimaryFieldType.Controls.Add(this.rbGenerateUUID);
            this.gbPrimaryFieldType.Location = new System.Drawing.Point(22, 95);
            this.gbPrimaryFieldType.Name = "gbPrimaryFieldType";
            this.gbPrimaryFieldType.Size = new System.Drawing.Size(206, 92);
            this.gbPrimaryFieldType.TabIndex = 10;
            this.gbPrimaryFieldType.TabStop = false;
            this.gbPrimaryFieldType.Text = "FieldType primary field";
            // 
            // rbGenerateInrWithGenerator
            // 
            this.rbGenerateInrWithGenerator.AutoSize = true;
            this.rbGenerateInrWithGenerator.Checked = true;
            this.rbGenerateInrWithGenerator.Location = new System.Drawing.Point(12, 28);
            this.rbGenerateInrWithGenerator.Name = "rbGenerateInrWithGenerator";
            this.rbGenerateInrWithGenerator.Size = new System.Drawing.Size(128, 17);
            this.rbGenerateInrWithGenerator.TabIndex = 1;
            this.rbGenerateInrWithGenerator.TabStop = true;
            this.rbGenerateInrWithGenerator.Text = "Integer with generator";
            this.rbGenerateInrWithGenerator.UseVisualStyleBackColor = true;
            // 
            // rbGenerateUUID
            // 
            this.rbGenerateUUID.AutoSize = true;
            this.rbGenerateUUID.Location = new System.Drawing.Point(12, 51);
            this.rbGenerateUUID.Name = "rbGenerateUUID";
            this.rbGenerateUUID.Size = new System.Drawing.Size(157, 17);
            this.rbGenerateUUID.TabIndex = 0;
            this.rbGenerateUUID.Text = "String with UUID generation";
            this.rbGenerateUUID.UseVisualStyleBackColor = true;
            // 
            // gbSetTerm
            // 
            this.gbSetTerm.Controls.Add(this.lblToReplaceSetTerm);
            this.gbSetTerm.Controls.Add(this.txtAlternativeSetTermCharacter);
            this.gbSetTerm.Location = new System.Drawing.Point(19, 26);
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
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.pnlMisc);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(847, 461);
            this.tabMisc.TabIndex = 3;
            this.tabMisc.Text = "Misc";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // pnlMisc
            // 
            this.pnlMisc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMisc.Controls.Add(this.groupBox1);
            this.pnlMisc.Controls.Add(this.gbDefaultReportPath);
            this.pnlMisc.Controls.Add(this.gbDefaultScriptPath);
            this.pnlMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMisc.Location = new System.Drawing.Point(3, 3);
            this.pnlMisc.Name = "pnlMisc";
            this.pnlMisc.Size = new System.Drawing.Size(841, 455);
            this.pnlMisc.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirebirdBinaryPath);
            this.groupBox1.Controls.Add(this.hotSpot1);
            this.groupBox1.Location = new System.Drawing.Point(15, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path for Firebird binaries";
            // 
            // txtFirebirdBinaryPath
            // 
            this.txtFirebirdBinaryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirebirdBinaryPath.Location = new System.Drawing.Point(3, 16);
            this.txtFirebirdBinaryPath.Name = "txtFirebirdBinaryPath";
            this.txtFirebirdBinaryPath.Size = new System.Drawing.Size(435, 20);
            this.txtFirebirdBinaryPath.TabIndex = 1;
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
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(438, 16);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Size = new System.Drawing.Size(45, 25);
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
            // 
            // gbDefaultReportPath
            // 
            this.gbDefaultReportPath.Controls.Add(this.txtDefaultReportPath);
            this.gbDefaultReportPath.Controls.Add(this.hsLoadDefaultReportPath);
            this.gbDefaultReportPath.Location = new System.Drawing.Point(15, 88);
            this.gbDefaultReportPath.Name = "gbDefaultReportPath";
            this.gbDefaultReportPath.Size = new System.Drawing.Size(486, 44);
            this.gbDefaultReportPath.TabIndex = 3;
            this.gbDefaultReportPath.TabStop = false;
            this.gbDefaultReportPath.Text = "Default path fo rreports";
            // 
            // txtDefaultReportPath
            // 
            this.txtDefaultReportPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaultReportPath.Location = new System.Drawing.Point(3, 16);
            this.txtDefaultReportPath.Name = "txtDefaultReportPath";
            this.txtDefaultReportPath.Size = new System.Drawing.Size(435, 20);
            this.txtDefaultReportPath.TabIndex = 1;
            // 
            // hsLoadDefaultReportPath
            // 
            this.hsLoadDefaultReportPath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadDefaultReportPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefaultReportPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefaultReportPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadDefaultReportPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadDefaultReportPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadDefaultReportPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadDefaultReportPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadDefaultReportPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadDefaultReportPath.FlatAppearance.BorderSize = 0;
            this.hsLoadDefaultReportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadDefaultReportPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadDefaultReportPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadDefaultReportPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadDefaultReportPath.ImageToggleOnSelect = true;
            this.hsLoadDefaultReportPath.Location = new System.Drawing.Point(438, 16);
            this.hsLoadDefaultReportPath.Marked = false;
            this.hsLoadDefaultReportPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadDefaultReportPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadDefaultReportPath.MarkedText = "";
            this.hsLoadDefaultReportPath.MarkMode = false;
            this.hsLoadDefaultReportPath.Name = "hsLoadDefaultReportPath";
            this.hsLoadDefaultReportPath.NonMarkedText = "";
            this.hsLoadDefaultReportPath.Size = new System.Drawing.Size(45, 25);
            this.hsLoadDefaultReportPath.TabIndex = 3;
            this.hsLoadDefaultReportPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadDefaultReportPath.ToolTipActive = false;
            this.hsLoadDefaultReportPath.ToolTipAutomaticDelay = 500;
            this.hsLoadDefaultReportPath.ToolTipAutoPopDelay = 5000;
            this.hsLoadDefaultReportPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadDefaultReportPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadDefaultReportPath.ToolTipFor4ContextMenu = true;
            this.hsLoadDefaultReportPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadDefaultReportPath.ToolTipInitialDelay = 500;
            this.hsLoadDefaultReportPath.ToolTipIsBallon = false;
            this.hsLoadDefaultReportPath.ToolTipOwnerDraw = false;
            this.hsLoadDefaultReportPath.ToolTipReshowDelay = 100;
            this.hsLoadDefaultReportPath.ToolTipShowAlways = false;
            this.hsLoadDefaultReportPath.ToolTipText = "";
            this.hsLoadDefaultReportPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadDefaultReportPath.ToolTipTitle = "";
            this.hsLoadDefaultReportPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadDefaultReportPath.UseVisualStyleBackColor = false;
            this.hsLoadDefaultReportPath.Click += new System.EventHandler(this.hsLoadDefaultReportPath_Click);
            // 
            // gbDefaultScriptPath
            // 
            this.gbDefaultScriptPath.Controls.Add(this.txtDefaultScriptPath);
            this.gbDefaultScriptPath.Controls.Add(this.hsLoadDefaultScriptPath);
            this.gbDefaultScriptPath.Location = new System.Drawing.Point(15, 29);
            this.gbDefaultScriptPath.Name = "gbDefaultScriptPath";
            this.gbDefaultScriptPath.Size = new System.Drawing.Size(486, 44);
            this.gbDefaultScriptPath.TabIndex = 2;
            this.gbDefaultScriptPath.TabStop = false;
            this.gbDefaultScriptPath.Text = "Defaut path for scripts";
            // 
            // txtDefaultScriptPath
            // 
            this.txtDefaultScriptPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaultScriptPath.Location = new System.Drawing.Point(3, 16);
            this.txtDefaultScriptPath.Name = "txtDefaultScriptPath";
            this.txtDefaultScriptPath.Size = new System.Drawing.Size(435, 20);
            this.txtDefaultScriptPath.TabIndex = 1;
            this.txtDefaultScriptPath.TextChanged += new System.EventHandler(this.txtDefaultScriptPath_TextChanged);
            // 
            // hsLoadDefaultScriptPath
            // 
            this.hsLoadDefaultScriptPath.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadDefaultScriptPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefaultScriptPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadDefaultScriptPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadDefaultScriptPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadDefaultScriptPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadDefaultScriptPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadDefaultScriptPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadDefaultScriptPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsLoadDefaultScriptPath.FlatAppearance.BorderSize = 0;
            this.hsLoadDefaultScriptPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadDefaultScriptPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadDefaultScriptPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsLoadDefaultScriptPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsLoadDefaultScriptPath.ImageToggleOnSelect = true;
            this.hsLoadDefaultScriptPath.Location = new System.Drawing.Point(438, 16);
            this.hsLoadDefaultScriptPath.Marked = false;
            this.hsLoadDefaultScriptPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadDefaultScriptPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadDefaultScriptPath.MarkedText = "";
            this.hsLoadDefaultScriptPath.MarkMode = false;
            this.hsLoadDefaultScriptPath.Name = "hsLoadDefaultScriptPath";
            this.hsLoadDefaultScriptPath.NonMarkedText = "";
            this.hsLoadDefaultScriptPath.Size = new System.Drawing.Size(45, 25);
            this.hsLoadDefaultScriptPath.TabIndex = 3;
            this.hsLoadDefaultScriptPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadDefaultScriptPath.ToolTipActive = false;
            this.hsLoadDefaultScriptPath.ToolTipAutomaticDelay = 500;
            this.hsLoadDefaultScriptPath.ToolTipAutoPopDelay = 5000;
            this.hsLoadDefaultScriptPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadDefaultScriptPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadDefaultScriptPath.ToolTipFor4ContextMenu = true;
            this.hsLoadDefaultScriptPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadDefaultScriptPath.ToolTipInitialDelay = 500;
            this.hsLoadDefaultScriptPath.ToolTipIsBallon = false;
            this.hsLoadDefaultScriptPath.ToolTipOwnerDraw = false;
            this.hsLoadDefaultScriptPath.ToolTipReshowDelay = 100;
            this.hsLoadDefaultScriptPath.ToolTipShowAlways = false;
            this.hsLoadDefaultScriptPath.ToolTipText = "";
            this.hsLoadDefaultScriptPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadDefaultScriptPath.ToolTipTitle = "";
            this.hsLoadDefaultScriptPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadDefaultScriptPath.UseVisualStyleBackColor = false;
            this.hsLoadDefaultScriptPath.Click += new System.EventHandler(this.hsLoadDefaultScriptPath_Click);
            // 
            // tabCreateSQL
            // 
            this.tabCreateSQL.Controls.Add(this.fcbSQLCreate);
            this.tabCreateSQL.Controls.Add(this.pnlSQLCreateUpper);
            this.tabCreateSQL.Location = new System.Drawing.Point(4, 22);
            this.tabCreateSQL.Name = "tabCreateSQL";
            this.tabCreateSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateSQL.Size = new System.Drawing.Size(847, 461);
            this.tabCreateSQL.TabIndex = 4;
            this.tabCreateSQL.Text = "SQL";
            this.tabCreateSQL.UseVisualStyleBackColor = true;
            // 
            // fcbSQLCreate
            // 
            this.fcbSQLCreate.AutoCompleteBracketsList = new char[] {
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
            this.fcbSQLCreate.AutoScrollMinSize = new System.Drawing.Size(666, 14);
            this.fcbSQLCreate.BackBrush = null;
            this.fcbSQLCreate.CharHeight = 14;
            this.fcbSQLCreate.CharWidth = 8;
            this.fcbSQLCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcbSQLCreate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcbSQLCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcbSQLCreate.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fcbSQLCreate.IsReplaceMode = false;
            this.fcbSQLCreate.Location = new System.Drawing.Point(3, 35);
            this.fcbSQLCreate.Name = "fcbSQLCreate";
            this.fcbSQLCreate.Paddings = new System.Windows.Forms.Padding(0);
            this.fcbSQLCreate.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcbSQLCreate.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcbSQLCreate.ServiceColors")));
            this.fcbSQLCreate.Size = new System.Drawing.Size(841, 423);
            this.fcbSQLCreate.TabIndex = 0;
            this.fcbSQLCreate.Text = "CREATE DATABASE \'C:\\Temp\\Test.db\' page_size 8192 user \'SYSDBA\' password \'masterke" +
    "y\'";
            this.fcbSQLCreate.Zoom = 100;
            // 
            // pnlSQLCreateUpper
            // 
            this.pnlSQLCreateUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSQLCreateUpper.Controls.Add(this.hsCreate);
            this.pnlSQLCreateUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSQLCreateUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlSQLCreateUpper.Name = "pnlSQLCreateUpper";
            this.pnlSQLCreateUpper.Size = new System.Drawing.Size(841, 32);
            this.pnlSQLCreateUpper.TabIndex = 1;
            // 
            // hsCreate
            // 
            this.hsCreate.BackColor = System.Drawing.Color.Transparent;
            this.hsCreate.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCreate.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCreate.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCreate.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCreate.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCreate.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsCreate.FlatAppearance.BorderSize = 0;
            this.hsCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCreate.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCreate.Image = global::FBXpert.Properties.Resources.applications_system;
            this.hsCreate.ImageHover = global::FBXpert.Properties.Resources.applications_system_blue_32x;
            this.hsCreate.ImageToggleOnSelect = true;
            this.hsCreate.Location = new System.Drawing.Point(0, 0);
            this.hsCreate.Marked = false;
            this.hsCreate.MarkedColor = System.Drawing.Color.Teal;
            this.hsCreate.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCreate.MarkedText = "";
            this.hsCreate.MarkMode = false;
            this.hsCreate.Name = "hsCreate";
            this.hsCreate.NonMarkedText = "";
            this.hsCreate.Size = new System.Drawing.Size(45, 32);
            this.hsCreate.TabIndex = 4;
            this.hsCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCreate.ToolTipActive = false;
            this.hsCreate.ToolTipAutomaticDelay = 500;
            this.hsCreate.ToolTipAutoPopDelay = 5000;
            this.hsCreate.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCreate.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCreate.ToolTipFor4ContextMenu = true;
            this.hsCreate.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCreate.ToolTipInitialDelay = 500;
            this.hsCreate.ToolTipIsBallon = false;
            this.hsCreate.ToolTipOwnerDraw = false;
            this.hsCreate.ToolTipReshowDelay = 100;
            this.hsCreate.ToolTipShowAlways = false;
            this.hsCreate.ToolTipText = "";
            this.hsCreate.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCreate.ToolTipTitle = "";
            this.hsCreate.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCreate.UseVisualStyleBackColor = false;
            // 
            // gbAttributesUpper
            // 
            this.gbAttributesUpper.Controls.Add(this.gbVersion);
            this.gbAttributesUpper.Controls.Add(this.gbLivettime);
            this.gbAttributesUpper.Controls.Add(this.gbDatenbankAlias);
            this.gbAttributesUpper.Controls.Add(this.hsConnect);
            this.gbAttributesUpper.Controls.Add(this.pnlConnectState);
            this.gbAttributesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAttributesUpper.Location = new System.Drawing.Point(0, 0);
            this.gbAttributesUpper.Name = "gbAttributesUpper";
            this.gbAttributesUpper.Size = new System.Drawing.Size(855, 184);
            this.gbAttributesUpper.TabIndex = 13;
            this.gbAttributesUpper.TabStop = false;
            // 
            // gbVersion
            // 
            this.gbVersion.Controls.Add(this.rb4_64);
            this.gbVersion.Controls.Add(this.rb4_32);
            this.gbVersion.Controls.Add(this.rb3_64);
            this.gbVersion.Controls.Add(this.rb3_32);
            this.gbVersion.Controls.Add(this.rb25_64);
            this.gbVersion.Controls.Add(this.rb25_32);
            this.gbVersion.Location = new System.Drawing.Point(728, 19);
            this.gbVersion.Name = "gbVersion";
            this.gbVersion.Size = new System.Drawing.Size(115, 159);
            this.gbVersion.TabIndex = 11;
            this.gbVersion.TabStop = false;
            this.gbVersion.Text = "Version";
            // 
            // gbLivettime
            // 
            this.gbLivettime.Controls.Add(this.txtLifetime);
            this.gbLivettime.Location = new System.Drawing.Point(514, 19);
            this.gbLivettime.Name = "gbLivettime";
            this.gbLivettime.Size = new System.Drawing.Size(199, 41);
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
            this.txtLifetime.Size = new System.Drawing.Size(193, 20);
            this.txtLifetime.TabIndex = 1;
            // 
            // gbDatenbankAlias
            // 
            this.gbDatenbankAlias.Controls.Add(this.txtDatabaseAlias);
            this.gbDatenbankAlias.Location = new System.Drawing.Point(6, 15);
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
            this.hsConnect.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsConnect.Image = global::FBXpert.Properties.Resources.database1;
            this.hsConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsConnect.ImageHover = global::FBXpert.Properties.Resources.database_check;
            this.hsConnect.ImageToggleOnSelect = true;
            this.hsConnect.Location = new System.Drawing.Point(360, 10);
            this.hsConnect.Marked = false;
            this.hsConnect.MarkedColor = System.Drawing.Color.Teal;
            this.hsConnect.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsConnect.MarkedText = "";
            this.hsConnect.MarkMode = false;
            this.hsConnect.Name = "hsConnect";
            this.hsConnect.NonMarkedText = "Connect";
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
            // pnlConnectState
            // 
            this.pnlConnectState.Location = new System.Drawing.Point(466, 22);
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
            this.pnlUpper.Controls.Add(this.hsClone);
            this.pnlUpper.Controls.Add(this.lblTableName);
            this.pnlUpper.Controls.Add(this.hsSave);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(855, 51);
            this.pnlUpper.TabIndex = 3;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(326, 10);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(97, 20);
            this.lblTableName.TabIndex = 3;
            this.lblTableName.Text = "Tablename";
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
            // 
            // rb3_32
            // 
            this.rb3_32.AutoSize = true;
            this.rb3_32.Location = new System.Drawing.Point(15, 67);
            this.rb3_32.Name = "rb3_32";
            this.rb3_32.Size = new System.Drawing.Size(57, 17);
            this.rb3_32.TabIndex = 2;
            this.rb3_32.TabStop = true;
            this.rb3_32.Text = "3 32bit";
            this.rb3_32.UseVisualStyleBackColor = true;
            // 
            // rb3_64
            // 
            this.rb3_64.AutoSize = true;
            this.rb3_64.Location = new System.Drawing.Point(15, 90);
            this.rb3_64.Name = "rb3_64";
            this.rb3_64.Size = new System.Drawing.Size(57, 17);
            this.rb3_64.TabIndex = 3;
            this.rb3_64.TabStop = true;
            this.rb3_64.Text = "3 64bit";
            this.rb3_64.UseVisualStyleBackColor = true;
            // 
            // rb4_32
            // 
            this.rb4_32.AutoSize = true;
            this.rb4_32.Location = new System.Drawing.Point(16, 113);
            this.rb4_32.Name = "rb4_32";
            this.rb4_32.Size = new System.Drawing.Size(57, 17);
            this.rb4_32.TabIndex = 4;
            this.rb4_32.TabStop = true;
            this.rb4_32.Text = "4 32bit";
            this.rb4_32.UseVisualStyleBackColor = true;
            // 
            // rb4_64
            // 
            this.rb4_64.AutoSize = true;
            this.rb4_64.Location = new System.Drawing.Point(16, 136);
            this.rb4_64.Name = "rb4_64";
            this.rb4_64.Size = new System.Drawing.Size(57, 17);
            this.rb4_64.TabIndex = 5;
            this.rb4_64.TabStop = true;
            this.rb4_64.Text = "4 64bit";
            this.rb4_64.UseVisualStyleBackColor = true;
            // 
            // DatabaseConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 722);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
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
            this.gbConnectionString.ResumeLayout(false);
            this.gbConnectionString.PerformLayout();
            this.gbClientLibrary.ResumeLayout(false);
            this.gbClientLibrary.PerformLayout();
            this.gbCollation.ResumeLayout(false);
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            this.gbCSet.ResumeLayout(false);
            this.gbDatabaseLocation.ResumeLayout(false);
            this.gbDatabaseLocation.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.gbPort.ResumeLayout(false);
            this.gbPort.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbConnectionType.ResumeLayout(false);
            this.gbConnectionType.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbPacketsize.ResumeLayout(false);
            this.gbPacketsize.PerformLayout();
            this.tabXPertUsedAttributes.ResumeLayout(false);
            this.pnlAttributesCenter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbTableMaxRows.ResumeLayout(false);
            this.gbTableMaxRows.PerformLayout();
            this.gbSkipForSelect.ResumeLayout(false);
            this.gbSkipForSelect.PerformLayout();
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
            this.tabMisc.ResumeLayout(false);
            this.pnlMisc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDefaultReportPath.ResumeLayout(false);
            this.gbDefaultReportPath.PerformLayout();
            this.gbDefaultScriptPath.ResumeLayout(false);
            this.gbDefaultScriptPath.PerformLayout();
            this.tabCreateSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcbSQLCreate)).EndInit();
            this.pnlSQLCreateUpper.ResumeLayout(false);
            this.gbAttributesUpper.ResumeLayout(false);
            this.gbVersion.ResumeLayout(false);
            this.gbVersion.PerformLayout();
            this.gbLivettime.ResumeLayout(false);
            this.gbLivettime.PerformLayout();
            this.gbDatenbankAlias.ResumeLayout(false);
            this.gbDatenbankAlias.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox gbDatabaseLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.GroupBox gbConnectionType;
        private System.Windows.Forms.RadioButton rbRemote;
        private System.Windows.Forms.RadioButton rbLocal;
        private SeControlsLib.HotSpot hsLoad;
        private System.Windows.Forms.GroupBox gbCSet;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.GroupBox gbPacketsize;
        private System.Windows.Forms.TextBox txtPacketsize;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.TextBox txtPort;
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
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.Panel pnlMisc;
        private System.Windows.Forms.GroupBox gbDefaultScriptPath;
        private System.Windows.Forms.TextBox txtDefaultScriptPath;
        private SeControlsLib.HotSpot hsLoadDefaultScriptPath;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbSkipForSelect;
        private System.Windows.Forms.TextBox txtSkipForSelect;
        private System.Windows.Forms.GroupBox gbLivettime;
        private System.Windows.Forms.TextBox txtLifetime;
        private System.Windows.Forms.TabPage tabCreateSQL;
        private System.Windows.Forms.Panel pnlSQLCreateUpper;
        private SeControlsLib.HotSpot hsCreate;
        private FastColoredTextBoxNS.FastColoredTextBox fcbSQLCreate;
        private SeControlsLib.HotSpot hsCreateDatabase;
        private SeControlsLib.HotSpot hsClone;
        private System.Windows.Forms.GroupBox gbClientLibrary;
        private System.Windows.Forms.TextBox txtClientLibrary;
        private SeControlsLib.HotSpot hsChangeFullPath;
        private System.Windows.Forms.GroupBox gbConnectionString;
        private System.Windows.Forms.TextBox txtConnectioString;
        private SeControlsLib.HotSpot hsLoadClientLib;
        private System.Windows.Forms.GroupBox gbVersion;
        private System.Windows.Forms.GroupBox gbTableMaxRows;
        private System.Windows.Forms.TextBox txtTableMaxRows;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Label lblTableName;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.GroupBox gbDefaultReportPath;
        private System.Windows.Forms.TextBox txtDefaultReportPath;
        private SeControlsLib.HotSpot hsLoadDefaultReportPath;
        private System.Windows.Forms.GroupBox gbDBNamespace;
        private System.Windows.Forms.TextBox txtDBNamespace;
        private System.Windows.Forms.GroupBox gbPrimaryFieldType;
        private System.Windows.Forms.RadioButton rbGenerateInrWithGenerator;
        private System.Windows.Forms.RadioButton rbGenerateUUID;
        private System.Windows.Forms.GroupBox gbSourceCodeOutputPath;
        private System.Windows.Forms.TextBox txtSourcecodeOutputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirebirdBinaryPath;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.RadioButton rb4_64;
        private System.Windows.Forms.RadioButton rb4_32;
        private System.Windows.Forms.RadioButton rb3_64;
        private System.Windows.Forms.RadioButton rb3_32;
        private System.Windows.Forms.RadioButton rb25_64;
        private System.Windows.Forms.RadioButton rb25_32;
    }
}