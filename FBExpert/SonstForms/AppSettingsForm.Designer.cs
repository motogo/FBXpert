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
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsSave = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tabControlFields = new System.Windows.Forms.TabControl();
            this.tabPageFieldEdit = new System.Windows.Forms.TabPage();
            this.pnlFieldsCenter = new System.Windows.Forms.Panel();
            this.pnlFieldUpper = new System.Windows.Forms.Panel();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.tabSourceCodeOptions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDependenciesUpper = new System.Windows.Forms.Panel();
            this.hsRefreshDependencies = new SeControlsLib.HotSpot();
            this.tabDatabaseDefaults = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbDefaultPassword = new System.Windows.Forms.GroupBox();
            this.txtDefaultPassword = new System.Windows.Forms.TextBox();
            this.gbDefaulUser = new System.Windows.Forms.GroupBox();
            this.txtDefaulUser = new System.Windows.Forms.TextBox();
            this.gbDefaultPacketSize = new System.Windows.Forms.GroupBox();
            this.txtDefaultPacketsize = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.tabPagePathSettings = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlUpper.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tabControlFields.SuspendLayout();
            this.tabPageFieldEdit.SuspendLayout();
            this.pnlFieldUpper.SuspendLayout();
            this.tabSourceCodeOptions.SuspendLayout();
            this.pnlDependenciesUpper.SuspendLayout();
            this.tabDatabaseDefaults.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDefaultPassword.SuspendLayout();
            this.gbDefaulUser.SuspendLayout();
            this.gbDefaultPacketSize.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPagePathSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.dbDatabaseConfigFile.SuspendLayout();
            this.gbDatabasesConfigPath.SuspendLayout();
            this.gbTempPath.SuspendLayout();
            this.gbScriptingPath.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpper.Controls.Add(this.hsSave);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(935, 42);
            this.pnlUpper.TabIndex = 0;
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
            this.hsSave.Size = new System.Drawing.Size(45, 38);
            this.hsSave.TabIndex = 4;
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
            this.hsClose.Size = new System.Drawing.Size(45, 38);
            this.hsClose.TabIndex = 1;
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
            this.pnlLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLower.Location = new System.Drawing.Point(0, 541);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(935, 16);
            this.pnlLower.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCenter.Controls.Add(this.tabControlFields);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(935, 499);
            this.pnlCenter.TabIndex = 2;
            // 
            // tabControlFields
            // 
            this.tabControlFields.Controls.Add(this.tabPagePathSettings);
            this.tabControlFields.Controls.Add(this.tabPageFieldEdit);
            this.tabControlFields.Controls.Add(this.tabSourceCodeOptions);
            this.tabControlFields.Controls.Add(this.tabDatabaseDefaults);
            this.tabControlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFields.Location = new System.Drawing.Point(0, 0);
            this.tabControlFields.Name = "tabControlFields";
            this.tabControlFields.SelectedIndex = 0;
            this.tabControlFields.Size = new System.Drawing.Size(931, 495);
            this.tabControlFields.TabIndex = 18;
            // 
            // tabPageFieldEdit
            // 
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldsCenter);
            this.tabPageFieldEdit.Controls.Add(this.pnlFieldUpper);
            this.tabPageFieldEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageFieldEdit.Name = "tabPageFieldEdit";
            this.tabPageFieldEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFieldEdit.Size = new System.Drawing.Size(923, 469);
            this.tabPageFieldEdit.TabIndex = 0;
            this.tabPageFieldEdit.Text = "Field Edit";
            this.tabPageFieldEdit.UseVisualStyleBackColor = true;
            // 
            // pnlFieldsCenter
            // 
            this.pnlFieldsCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFieldsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldsCenter.Location = new System.Drawing.Point(3, 35);
            this.pnlFieldsCenter.Name = "pnlFieldsCenter";
            this.pnlFieldsCenter.Size = new System.Drawing.Size(917, 431);
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
            this.pnlFieldUpper.Size = new System.Drawing.Size(917, 32);
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
            this.hsRefresh.Size = new System.Drawing.Size(45, 28);
            this.hsRefresh.TabIndex = 3;
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
            // tabSourceCodeOptions
            // 
            this.tabSourceCodeOptions.Controls.Add(this.panel1);
            this.tabSourceCodeOptions.Controls.Add(this.pnlDependenciesUpper);
            this.tabSourceCodeOptions.Location = new System.Drawing.Point(4, 22);
            this.tabSourceCodeOptions.Name = "tabSourceCodeOptions";
            this.tabSourceCodeOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSourceCodeOptions.Size = new System.Drawing.Size(923, 469);
            this.tabSourceCodeOptions.TabIndex = 1;
            this.tabSourceCodeOptions.Text = "Source Code Options";
            this.tabSourceCodeOptions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 431);
            this.panel1.TabIndex = 22;
            // 
            // pnlDependenciesUpper
            // 
            this.pnlDependenciesUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDependenciesUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDependenciesUpper.Controls.Add(this.hsRefreshDependencies);
            this.pnlDependenciesUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependenciesUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlDependenciesUpper.Name = "pnlDependenciesUpper";
            this.pnlDependenciesUpper.Size = new System.Drawing.Size(917, 32);
            this.pnlDependenciesUpper.TabIndex = 21;
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
            this.hsRefreshDependencies.Size = new System.Drawing.Size(45, 28);
            this.hsRefreshDependencies.TabIndex = 2;
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
            this.tabDatabaseDefaults.Controls.Add(this.panel3);
            this.tabDatabaseDefaults.Location = new System.Drawing.Point(4, 22);
            this.tabDatabaseDefaults.Name = "tabDatabaseDefaults";
            this.tabDatabaseDefaults.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabaseDefaults.Size = new System.Drawing.Size(923, 469);
            this.tabDatabaseDefaults.TabIndex = 2;
            this.tabDatabaseDefaults.Text = "Database defaults";
            this.tabDatabaseDefaults.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.gbDefaultPassword);
            this.panel2.Controls.Add(this.gbDefaulUser);
            this.panel2.Controls.Add(this.gbDefaultPacketSize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 431);
            this.panel2.TabIndex = 24;
            // 
            // gbDefaultPassword
            // 
            this.gbDefaultPassword.Controls.Add(this.txtDefaultPassword);
            this.gbDefaultPassword.Location = new System.Drawing.Point(13, 119);
            this.gbDefaultPassword.Name = "gbDefaultPassword";
            this.gbDefaultPassword.Size = new System.Drawing.Size(191, 46);
            this.gbDefaultPassword.TabIndex = 2;
            this.gbDefaultPassword.TabStop = false;
            this.gbDefaultPassword.Text = "Default Password";
            // 
            // txtDefaultPassword
            // 
            this.txtDefaultPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaultPassword.Location = new System.Drawing.Point(3, 16);
            this.txtDefaultPassword.Name = "txtDefaultPassword";
            this.txtDefaultPassword.Size = new System.Drawing.Size(185, 20);
            this.txtDefaultPassword.TabIndex = 0;
            this.txtDefaultPassword.Text = "masterkey";
            // 
            // gbDefaulUser
            // 
            this.gbDefaulUser.Controls.Add(this.txtDefaulUser);
            this.gbDefaulUser.Location = new System.Drawing.Point(13, 67);
            this.gbDefaulUser.Name = "gbDefaulUser";
            this.gbDefaulUser.Size = new System.Drawing.Size(191, 46);
            this.gbDefaulUser.TabIndex = 1;
            this.gbDefaulUser.TabStop = false;
            this.gbDefaulUser.Text = "Default User";
            // 
            // txtDefaulUser
            // 
            this.txtDefaulUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaulUser.Location = new System.Drawing.Point(3, 16);
            this.txtDefaulUser.Name = "txtDefaulUser";
            this.txtDefaulUser.Size = new System.Drawing.Size(185, 20);
            this.txtDefaulUser.TabIndex = 0;
            this.txtDefaulUser.Text = "SYSDBA";
            // 
            // gbDefaultPacketSize
            // 
            this.gbDefaultPacketSize.Controls.Add(this.txtDefaultPacketsize);
            this.gbDefaultPacketSize.Location = new System.Drawing.Point(13, 15);
            this.gbDefaultPacketSize.Name = "gbDefaultPacketSize";
            this.gbDefaultPacketSize.Size = new System.Drawing.Size(121, 46);
            this.gbDefaultPacketSize.TabIndex = 0;
            this.gbDefaultPacketSize.TabStop = false;
            this.gbDefaultPacketSize.Text = "Default Packetsize";
            // 
            // txtDefaultPacketsize
            // 
            this.txtDefaultPacketsize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefaultPacketsize.Location = new System.Drawing.Point(3, 16);
            this.txtDefaultPacketsize.Name = "txtDefaultPacketsize";
            this.txtDefaultPacketsize.Size = new System.Drawing.Size(115, 20);
            this.txtDefaultPacketsize.TabIndex = 0;
            this.txtDefaultPacketsize.Text = "8192";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.hotSpot1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 32);
            this.panel3.TabIndex = 23;
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
            this.hotSpot1.Size = new System.Drawing.Size(45, 28);
            this.hotSpot1.TabIndex = 2;
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
            // tabPagePathSettings
            // 
            this.tabPagePathSettings.Controls.Add(this.panel4);
            this.tabPagePathSettings.Controls.Add(this.panel5);
            this.tabPagePathSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPagePathSettings.Name = "tabPagePathSettings";
            this.tabPagePathSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePathSettings.Size = new System.Drawing.Size(923, 469);
            this.tabPagePathSettings.TabIndex = 3;
            this.tabPagePathSettings.Text = "Path settings";
            this.tabPagePathSettings.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.dbDatabaseConfigFile);
            this.panel4.Controls.Add(this.gbDatabasesConfigPath);
            this.panel4.Controls.Add(this.gbTempPath);
            this.panel4.Controls.Add(this.gbScriptingPath);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 431);
            this.panel4.TabIndex = 4;
            // 
            // dbDatabaseConfigFile
            // 
            this.dbDatabaseConfigFile.Controls.Add(this.txtDatabasesConfigFile);
            this.dbDatabaseConfigFile.Controls.Add(this.hsDatabaseConfigFile);
            this.dbDatabaseConfigFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbDatabaseConfigFile.Location = new System.Drawing.Point(0, 144);
            this.dbDatabaseConfigFile.Name = "dbDatabaseConfigFile";
            this.dbDatabaseConfigFile.Size = new System.Drawing.Size(917, 48);
            this.dbDatabaseConfigFile.TabIndex = 6;
            this.dbDatabaseConfigFile.TabStop = false;
            this.dbDatabaseConfigFile.Text = "Databases config file";
            // 
            // txtDatabasesConfigFile
            // 
            this.txtDatabasesConfigFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabasesConfigFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasesConfigFile.Location = new System.Drawing.Point(3, 16);
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
            this.hsDatabaseConfigFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDatabaseConfigFile.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsDatabaseConfigFile.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsDatabaseConfigFile.ImageToggleOnSelect = false;
            this.hsDatabaseConfigFile.Location = new System.Drawing.Point(856, 16);
            this.hsDatabaseConfigFile.Marked = false;
            this.hsDatabaseConfigFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsDatabaseConfigFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDatabaseConfigFile.MarkedText = "";
            this.hsDatabaseConfigFile.MarkMode = false;
            this.hsDatabaseConfigFile.Name = "hsDatabaseConfigFile";
            this.hsDatabaseConfigFile.NonMarkedText = "...";
            this.hsDatabaseConfigFile.Size = new System.Drawing.Size(58, 29);
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
            this.gbDatabasesConfigPath.Location = new System.Drawing.Point(0, 96);
            this.gbDatabasesConfigPath.Name = "gbDatabasesConfigPath";
            this.gbDatabasesConfigPath.Size = new System.Drawing.Size(917, 48);
            this.gbDatabasesConfigPath.TabIndex = 5;
            this.gbDatabasesConfigPath.TabStop = false;
            this.gbDatabasesConfigPath.Text = "Databases config path";
            // 
            // txtDatabasesConfigPath
            // 
            this.txtDatabasesConfigPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatabasesConfigPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasesConfigPath.Location = new System.Drawing.Point(3, 16);
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
            this.hsDatabasesConfigPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDatabasesConfigPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsDatabasesConfigPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsDatabasesConfigPath.ImageToggleOnSelect = false;
            this.hsDatabasesConfigPath.Location = new System.Drawing.Point(856, 16);
            this.hsDatabasesConfigPath.Marked = false;
            this.hsDatabasesConfigPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsDatabasesConfigPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDatabasesConfigPath.MarkedText = "";
            this.hsDatabasesConfigPath.MarkMode = false;
            this.hsDatabasesConfigPath.Name = "hsDatabasesConfigPath";
            this.hsDatabasesConfigPath.NonMarkedText = "...";
            this.hsDatabasesConfigPath.Size = new System.Drawing.Size(58, 29);
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
            this.gbTempPath.Location = new System.Drawing.Point(0, 48);
            this.gbTempPath.Name = "gbTempPath";
            this.gbTempPath.Size = new System.Drawing.Size(917, 48);
            this.gbTempPath.TabIndex = 4;
            this.gbTempPath.TabStop = false;
            this.gbTempPath.Text = "Temporary path";
            // 
            // txtTemporaryPath
            // 
            this.txtTemporaryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemporaryPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemporaryPath.Location = new System.Drawing.Point(3, 16);
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
            this.hsTemporaryPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsTemporaryPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsTemporaryPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsTemporaryPath.ImageToggleOnSelect = false;
            this.hsTemporaryPath.Location = new System.Drawing.Point(856, 16);
            this.hsTemporaryPath.Marked = false;
            this.hsTemporaryPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsTemporaryPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsTemporaryPath.MarkedText = "";
            this.hsTemporaryPath.MarkMode = false;
            this.hsTemporaryPath.Name = "hsTemporaryPath";
            this.hsTemporaryPath.NonMarkedText = "...";
            this.hsTemporaryPath.Size = new System.Drawing.Size(58, 29);
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
            this.gbScriptingPath.Size = new System.Drawing.Size(917, 48);
            this.gbScriptingPath.TabIndex = 3;
            this.gbScriptingPath.TabStop = false;
            this.gbScriptingPath.Text = "Scripting path";
            // 
            // txtScriptingPath
            // 
            this.txtScriptingPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptingPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptingPath.Location = new System.Drawing.Point(3, 16);
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
            this.hsScriptingPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsScriptingPath.Image = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsScriptingPath.ImageHover = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsScriptingPath.ImageToggleOnSelect = false;
            this.hsScriptingPath.Location = new System.Drawing.Point(856, 16);
            this.hsScriptingPath.Marked = false;
            this.hsScriptingPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsScriptingPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsScriptingPath.MarkedText = "";
            this.hsScriptingPath.MarkMode = false;
            this.hsScriptingPath.Name = "hsScriptingPath";
            this.hsScriptingPath.NonMarkedText = "...";
            this.hsScriptingPath.Size = new System.Drawing.Size(58, 29);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.hotSpot2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(917, 32);
            this.panel5.TabIndex = 3;
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
            this.hotSpot2.Size = new System.Drawing.Size(45, 28);
            this.hotSpot2.TabIndex = 3;
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
            // AppSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 557);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppSettingsForm";
            this.Text = "AppSettingsForm";
            this.Load += new System.EventHandler(this.AppSettingsForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.tabControlFields.ResumeLayout(false);
            this.tabPageFieldEdit.ResumeLayout(false);
            this.pnlFieldUpper.ResumeLayout(false);
            this.tabSourceCodeOptions.ResumeLayout(false);
            this.pnlDependenciesUpper.ResumeLayout(false);
            this.tabDatabaseDefaults.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbDefaultPassword.ResumeLayout(false);
            this.gbDefaultPassword.PerformLayout();
            this.gbDefaulUser.ResumeLayout(false);
            this.gbDefaulUser.PerformLayout();
            this.gbDefaultPacketSize.ResumeLayout(false);
            this.gbDefaultPacketSize.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPagePathSettings.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.dbDatabaseConfigFile.ResumeLayout(false);
            this.dbDatabaseConfigFile.PerformLayout();
            this.gbDatabasesConfigPath.ResumeLayout(false);
            this.gbDatabasesConfigPath.PerformLayout();
            this.gbTempPath.ResumeLayout(false);
            this.gbTempPath.PerformLayout();
            this.gbScriptingPath.ResumeLayout(false);
            this.gbScriptingPath.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Panel pnlCenter;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tabControlFields;
        private System.Windows.Forms.TabPage tabPageFieldEdit;
        private System.Windows.Forms.Panel pnlFieldsCenter;
        private System.Windows.Forms.Panel pnlFieldUpper;
        private System.Windows.Forms.TabPage tabSourceCodeOptions;
        private System.Windows.Forms.Panel pnlDependenciesUpper;
        private SeControlsLib.HotSpot hsRefreshDependencies;
        private SeControlsLib.HotSpot hsRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private SeControlsLib.HotSpot hsSave;
        private System.Windows.Forms.TabPage tabDatabaseDefaults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbDefaultPacketSize;
        private System.Windows.Forms.TextBox txtDefaultPacketsize;
        private System.Windows.Forms.Panel panel3;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.GroupBox gbDefaultPassword;
        private System.Windows.Forms.TextBox txtDefaultPassword;
        private System.Windows.Forms.GroupBox gbDefaulUser;
        private System.Windows.Forms.TextBox txtDefaulUser;
        private System.Windows.Forms.TabPage tabPagePathSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.GroupBox gbTempPath;
        private System.Windows.Forms.TextBox txtTemporaryPath;
        private SeControlsLib.HotSpot hsTemporaryPath;
        private System.Windows.Forms.GroupBox gbScriptingPath;
        private System.Windows.Forms.TextBox txtScriptingPath;
        private SeControlsLib.HotSpot hsScriptingPath;
        private System.Windows.Forms.GroupBox gbDatabasesConfigPath;
        private System.Windows.Forms.TextBox txtDatabasesConfigPath;
        private SeControlsLib.HotSpot hsDatabasesConfigPath;
        private System.Windows.Forms.GroupBox dbDatabaseConfigFile;
        private System.Windows.Forms.TextBox txtDatabasesConfigFile;
        private SeControlsLib.HotSpot hsDatabaseConfigFile;
    }
}