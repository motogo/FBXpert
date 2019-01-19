namespace FBXpert.SonstForms
{
    partial class BinariesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinariesForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsRun = new SeControlsLib.HotSpot();
            this.tcCenter = new System.Windows.Forms.TabControl();
            this.tabISQL = new System.Windows.Forms.TabPage();
            this.gbArgumentsInfo = new System.Windows.Forms.GroupBox();
            this.rtfCommands = new System.Windows.Forms.RichTextBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.txtISQLParameters = new System.Windows.Forms.TextBox();
            this.gbISQLOptions = new System.Windows.Forms.GroupBox();
            this.hsSelectFolderInputFile = new SeControlsLib.HotSpot();
            this.hsSelectFolderOutputFile = new SeControlsLib.HotSpot();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.cbInputFile = new System.Windows.Forms.CheckBox();
            this.cbOutputFile = new System.Windows.Forms.CheckBox();
            this.cbNoWarnings = new System.Windows.Forms.CheckBox();
            this.cbNoAutocommit = new System.Windows.Forms.CheckBox();
            this.cbISQLNoFireTriggers = new System.Windows.Forms.CheckBox();
            this.gbISQLPassword = new System.Windows.Forms.GroupBox();
            this.txtISQLPassword = new System.Windows.Forms.TextBox();
            this.gbISQLUser = new System.Windows.Forms.GroupBox();
            this.txtISQLUser = new System.Windows.Forms.TextBox();
            this.tabGFIX = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbGFIXArguments = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGFIXParameters = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fctGFIXOutput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.tabGSTAT = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbGSTATArgument = new System.Windows.Forms.RichTextBox();
            this.gbGSTATParameters = new System.Windows.Forms.GroupBox();
            this.txtGSTATParameters = new System.Windows.Forms.TextBox();
            this.gbGStatOut = new System.Windows.Forms.GroupBox();
            this.fctGSTATOutput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlGStatUpper = new System.Windows.Forms.Panel();
            this.hsSaveGStatToFile = new SeControlsLib.HotSpot();
            this.tabGBAK = new System.Windows.Forms.TabPage();
            this.gbGBAKParameterInfo = new System.Windows.Forms.GroupBox();
            this.rtbGBAKArguments = new System.Windows.Forms.RichTextBox();
            this.gbGBAKParameters = new System.Windows.Forms.GroupBox();
            this.txtGBAKParameters = new System.Windows.Forms.TextBox();
            this.pnlGBAKUpper = new System.Windows.Forms.Panel();
            this.cbBackupType = new System.Windows.Forms.ComboBox();
            this.gbBAKUser = new System.Windows.Forms.GroupBox();
            this.txtGBAKUser = new System.Windows.Forms.TextBox();
            this.gbBAKPassword = new System.Windows.Forms.GroupBox();
            this.txtGBAKPassword = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlUpper.SuspendLayout();
            this.tcCenter.SuspendLayout();
            this.tabISQL.SuspendLayout();
            this.gbArgumentsInfo.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.gbISQLOptions.SuspendLayout();
            this.gbISQLPassword.SuspendLayout();
            this.gbISQLUser.SuspendLayout();
            this.tabGFIX.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctGFIXOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabGSTAT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGSTATParameters.SuspendLayout();
            this.gbGStatOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctGSTATOutput)).BeginInit();
            this.pnlGStatUpper.SuspendLayout();
            this.tabGBAK.SuspendLayout();
            this.gbGBAKParameterInfo.SuspendLayout();
            this.gbGBAKParameters.SuspendLayout();
            this.pnlGBAKUpper.SuspendLayout();
            this.gbBAKUser.SuspendLayout();
            this.gbBAKPassword.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Controls.Add(this.hsRun);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1284, 48);
            this.pnlUpper.TabIndex = 2;
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
            this.hsClose.Size = new System.Drawing.Size(45, 48);
            this.hsClose.TabIndex = 0;
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
            // hsRun
            // 
            this.hsRun.BackColor = System.Drawing.Color.Transparent;
            this.hsRun.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRun.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRun.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRun.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRun.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRun.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRun.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsRun.FlatAppearance.BorderSize = 0;
            this.hsRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRun.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRun.Image = global::FBXpert.Properties.Resources.console_x32;
            this.hsRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRun.ImageHover = global::FBXpert.Properties.Resources.console2_x32;
            this.hsRun.ImageToggleOnSelect = true;
            this.hsRun.Location = new System.Drawing.Point(51, 0);
            this.hsRun.Marked = false;
            this.hsRun.MarkedColor = System.Drawing.Color.Teal;
            this.hsRun.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRun.MarkedText = "";
            this.hsRun.MarkMode = false;
            this.hsRun.Name = "hsRun";
            this.hsRun.NonMarkedText = "Run";
            this.hsRun.Size = new System.Drawing.Size(75, 48);
            this.hsRun.TabIndex = 5;
            this.hsRun.Text = "Run";
            this.hsRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRun.ToolTipActive = false;
            this.hsRun.ToolTipAutomaticDelay = 500;
            this.hsRun.ToolTipAutoPopDelay = 5000;
            this.hsRun.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRun.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRun.ToolTipFor4ContextMenu = true;
            this.hsRun.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRun.ToolTipInitialDelay = 500;
            this.hsRun.ToolTipIsBallon = false;
            this.hsRun.ToolTipOwnerDraw = false;
            this.hsRun.ToolTipReshowDelay = 100;
            
            this.hsRun.ToolTipShowAlways = false;
            this.hsRun.ToolTipText = "";
            this.hsRun.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRun.ToolTipTitle = "";
            this.hsRun.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRun.UseVisualStyleBackColor = false;
            this.hsRun.Click += new System.EventHandler(this.hsRUN_Click);
            // 
            // tcCenter
            // 
            this.tcCenter.Controls.Add(this.tabISQL);
            this.tcCenter.Controls.Add(this.tabGFIX);
            this.tcCenter.Controls.Add(this.tabGSTAT);
            this.tcCenter.Controls.Add(this.tabGBAK);
            this.tcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCenter.Location = new System.Drawing.Point(0, 48);
            this.tcCenter.Name = "tcCenter";
            this.tcCenter.SelectedIndex = 0;
            this.tcCenter.Size = new System.Drawing.Size(1284, 576);
            this.tcCenter.TabIndex = 3;
            // 
            // tabISQL
            // 
            this.tabISQL.Controls.Add(this.gbArgumentsInfo);
            this.tabISQL.Controls.Add(this.gbParameters);
            this.tabISQL.Controls.Add(this.gbISQLOptions);
            this.tabISQL.Controls.Add(this.gbISQLPassword);
            this.tabISQL.Controls.Add(this.gbISQLUser);
            this.tabISQL.Location = new System.Drawing.Point(4, 22);
            this.tabISQL.Name = "tabISQL";
            this.tabISQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabISQL.Size = new System.Drawing.Size(1276, 550);
            this.tabISQL.TabIndex = 0;
            this.tabISQL.Text = "ISQL";
            this.tabISQL.UseVisualStyleBackColor = true;
            // 
            // gbArgumentsInfo
            // 
            this.gbArgumentsInfo.Controls.Add(this.rtfCommands);
            this.gbArgumentsInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbArgumentsInfo.Location = new System.Drawing.Point(3, 163);
            this.gbArgumentsInfo.Name = "gbArgumentsInfo";
            this.gbArgumentsInfo.Size = new System.Drawing.Size(1270, 384);
            this.gbArgumentsInfo.TabIndex = 10;
            this.gbArgumentsInfo.TabStop = false;
            this.gbArgumentsInfo.Text = "Arguments info";
            // 
            // rtfCommands
            // 
            this.rtfCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfCommands.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfCommands.Location = new System.Drawing.Point(3, 16);
            this.rtfCommands.Name = "rtfCommands";
            this.rtfCommands.Size = new System.Drawing.Size(1264, 365);
            this.rtfCommands.TabIndex = 0;
            this.rtfCommands.Text = resources.GetString("rtfCommands.Text");
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.txtISQLParameters);
            this.gbParameters.Location = new System.Drawing.Point(8, 55);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(640, 96);
            this.gbParameters.TabIndex = 9;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // txtISQLParameters
            // 
            this.txtISQLParameters.BackColor = System.Drawing.SystemColors.Info;
            this.txtISQLParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtISQLParameters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISQLParameters.Location = new System.Drawing.Point(3, 16);
            this.txtISQLParameters.Multiline = true;
            this.txtISQLParameters.Name = "txtISQLParameters";
            this.txtISQLParameters.Size = new System.Drawing.Size(634, 77);
            this.txtISQLParameters.TabIndex = 0;
            // 
            // gbISQLOptions
            // 
            this.gbISQLOptions.Controls.Add(this.hsSelectFolderInputFile);
            this.gbISQLOptions.Controls.Add(this.hsSelectFolderOutputFile);
            this.gbISQLOptions.Controls.Add(this.txtInputFile);
            this.gbISQLOptions.Controls.Add(this.txtOutputFile);
            this.gbISQLOptions.Controls.Add(this.cbInputFile);
            this.gbISQLOptions.Controls.Add(this.cbOutputFile);
            this.gbISQLOptions.Controls.Add(this.cbNoWarnings);
            this.gbISQLOptions.Controls.Add(this.cbNoAutocommit);
            this.gbISQLOptions.Controls.Add(this.cbISQLNoFireTriggers);
            this.gbISQLOptions.Location = new System.Drawing.Point(654, 23);
            this.gbISQLOptions.Name = "gbISQLOptions";
            this.gbISQLOptions.Size = new System.Drawing.Size(498, 127);
            this.gbISQLOptions.TabIndex = 8;
            this.gbISQLOptions.TabStop = false;
            this.gbISQLOptions.Text = "Options";
            // 
            // hsSelectFolderInputFile
            // 
            this.hsSelectFolderInputFile.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectFolderInputFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectFolderInputFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectFolderInputFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectFolderInputFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectFolderInputFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectFolderInputFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectFolderInputFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectFolderInputFile.FlatAppearance.BorderSize = 0;
            this.hsSelectFolderInputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectFolderInputFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectFolderInputFile.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsSelectFolderInputFile.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsSelectFolderInputFile.ImageToggleOnSelect = true;
            this.hsSelectFolderInputFile.Location = new System.Drawing.Point(441, 81);
            this.hsSelectFolderInputFile.Marked = false;
            this.hsSelectFolderInputFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectFolderInputFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectFolderInputFile.MarkedText = "";
            this.hsSelectFolderInputFile.MarkMode = false;
            this.hsSelectFolderInputFile.Name = "hsSelectFolderInputFile";
            this.hsSelectFolderInputFile.NonMarkedText = "";
            this.hsSelectFolderInputFile.Size = new System.Drawing.Size(45, 21);
            this.hsSelectFolderInputFile.TabIndex = 8;
            this.hsSelectFolderInputFile.ToolTipActive = false;
            this.hsSelectFolderInputFile.ToolTipAutomaticDelay = 500;
            this.hsSelectFolderInputFile.ToolTipAutoPopDelay = 5000;
            this.hsSelectFolderInputFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectFolderInputFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectFolderInputFile.ToolTipFor4ContextMenu = true;
            this.hsSelectFolderInputFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectFolderInputFile.ToolTipInitialDelay = 500;
            this.hsSelectFolderInputFile.ToolTipIsBallon = false;
            this.hsSelectFolderInputFile.ToolTipOwnerDraw = false;
            this.hsSelectFolderInputFile.ToolTipReshowDelay = 100;
            
            this.hsSelectFolderInputFile.ToolTipShowAlways = false;
            this.hsSelectFolderInputFile.ToolTipText = "";
            this.hsSelectFolderInputFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectFolderInputFile.ToolTipTitle = "";
            this.hsSelectFolderInputFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectFolderInputFile.UseVisualStyleBackColor = false;
            this.hsSelectFolderInputFile.Click += new System.EventHandler(this.hsSelectFolderInputFile_Click);
            // 
            // hsSelectFolderOutputFile
            // 
            this.hsSelectFolderOutputFile.BackColor = System.Drawing.Color.Transparent;
            this.hsSelectFolderOutputFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSelectFolderOutputFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSelectFolderOutputFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSelectFolderOutputFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSelectFolderOutputFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSelectFolderOutputFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSelectFolderOutputFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSelectFolderOutputFile.FlatAppearance.BorderSize = 0;
            this.hsSelectFolderOutputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSelectFolderOutputFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSelectFolderOutputFile.Image = global::FBXpert.Properties.Resources.folder_open_22x;
            this.hsSelectFolderOutputFile.ImageHover = global::FBXpert.Properties.Resources.folder_closed_22x;
            this.hsSelectFolderOutputFile.ImageToggleOnSelect = true;
            this.hsSelectFolderOutputFile.Location = new System.Drawing.Point(441, 48);
            this.hsSelectFolderOutputFile.Marked = false;
            this.hsSelectFolderOutputFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsSelectFolderOutputFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSelectFolderOutputFile.MarkedText = "";
            this.hsSelectFolderOutputFile.MarkMode = false;
            this.hsSelectFolderOutputFile.Name = "hsSelectFolderOutputFile";
            this.hsSelectFolderOutputFile.NonMarkedText = "";
            this.hsSelectFolderOutputFile.Size = new System.Drawing.Size(45, 21);
            this.hsSelectFolderOutputFile.TabIndex = 7;
            this.hsSelectFolderOutputFile.ToolTipActive = false;
            this.hsSelectFolderOutputFile.ToolTipAutomaticDelay = 500;
            this.hsSelectFolderOutputFile.ToolTipAutoPopDelay = 5000;
            this.hsSelectFolderOutputFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSelectFolderOutputFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSelectFolderOutputFile.ToolTipFor4ContextMenu = true;
            this.hsSelectFolderOutputFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSelectFolderOutputFile.ToolTipInitialDelay = 500;
            this.hsSelectFolderOutputFile.ToolTipIsBallon = false;
            this.hsSelectFolderOutputFile.ToolTipOwnerDraw = false;
            this.hsSelectFolderOutputFile.ToolTipReshowDelay = 100;
            
            this.hsSelectFolderOutputFile.ToolTipShowAlways = false;
            this.hsSelectFolderOutputFile.ToolTipText = "";
            this.hsSelectFolderOutputFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSelectFolderOutputFile.ToolTipTitle = "";
            this.hsSelectFolderOutputFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSelectFolderOutputFile.UseVisualStyleBackColor = false;
            this.hsSelectFolderOutputFile.Click += new System.EventHandler(this.hsSelectFolderOutputFile_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(94, 81);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.PasswordChar = '*';
            this.txtInputFile.Size = new System.Drawing.Size(341, 20);
            this.txtInputFile.TabIndex = 6;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(94, 49);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.PasswordChar = '*';
            this.txtOutputFile.Size = new System.Drawing.Size(341, 20);
            this.txtOutputFile.TabIndex = 5;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // cbInputFile
            // 
            this.cbInputFile.AutoSize = true;
            this.cbInputFile.Location = new System.Drawing.Point(14, 87);
            this.cbInputFile.Name = "cbInputFile";
            this.cbInputFile.Size = new System.Drawing.Size(74, 17);
            this.cbInputFile.TabIndex = 4;
            this.cbInputFile.Text = "Output file";
            this.cbInputFile.UseVisualStyleBackColor = true;
            // 
            // cbOutputFile
            // 
            this.cbOutputFile.AutoSize = true;
            this.cbOutputFile.Location = new System.Drawing.Point(14, 55);
            this.cbOutputFile.Name = "cbOutputFile";
            this.cbOutputFile.Size = new System.Drawing.Size(74, 17);
            this.cbOutputFile.TabIndex = 3;
            this.cbOutputFile.Text = "Output file";
            this.cbOutputFile.UseVisualStyleBackColor = true;
            this.cbOutputFile.CheckedChanged += new System.EventHandler(this.cbOutputFile_CheckedChanged);
            // 
            // cbNoWarnings
            // 
            this.cbNoWarnings.AutoSize = true;
            this.cbNoWarnings.Location = new System.Drawing.Point(229, 24);
            this.cbNoWarnings.Name = "cbNoWarnings";
            this.cbNoWarnings.Size = new System.Drawing.Size(85, 17);
            this.cbNoWarnings.TabIndex = 2;
            this.cbNoWarnings.Text = "No warnings";
            this.cbNoWarnings.UseVisualStyleBackColor = true;
            // 
            // cbNoAutocommit
            // 
            this.cbNoAutocommit.AutoSize = true;
            this.cbNoAutocommit.Location = new System.Drawing.Point(126, 24);
            this.cbNoAutocommit.Name = "cbNoAutocommit";
            this.cbNoAutocommit.Size = new System.Drawing.Size(97, 17);
            this.cbNoAutocommit.TabIndex = 1;
            this.cbNoAutocommit.Text = "No autocommit";
            this.cbNoAutocommit.UseVisualStyleBackColor = true;
            this.cbNoAutocommit.CheckedChanged += new System.EventHandler(this.cbISQLOptions_CheckedChanged);
            // 
            // cbISQLNoFireTriggers
            // 
            this.cbISQLNoFireTriggers.AutoSize = true;
            this.cbISQLNoFireTriggers.Location = new System.Drawing.Point(14, 24);
            this.cbISQLNoFireTriggers.Name = "cbISQLNoFireTriggers";
            this.cbISQLNoFireTriggers.Size = new System.Drawing.Size(97, 17);
            this.cbISQLNoFireTriggers.TabIndex = 0;
            this.cbISQLNoFireTriggers.Text = "Not fire triggers";
            this.cbISQLNoFireTriggers.UseVisualStyleBackColor = true;
            this.cbISQLNoFireTriggers.CheckedChanged += new System.EventHandler(this.cbISQLOptions_CheckedChanged);
            // 
            // gbISQLPassword
            // 
            this.gbISQLPassword.Controls.Add(this.txtISQLPassword);
            this.gbISQLPassword.Location = new System.Drawing.Point(233, 6);
            this.gbISQLPassword.Name = "gbISQLPassword";
            this.gbISQLPassword.Size = new System.Drawing.Size(219, 43);
            this.gbISQLPassword.TabIndex = 7;
            this.gbISQLPassword.TabStop = false;
            this.gbISQLPassword.Text = "Passwort";
            // 
            // txtISQLPassword
            // 
            this.txtISQLPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtISQLPassword.Location = new System.Drawing.Point(3, 16);
            this.txtISQLPassword.Name = "txtISQLPassword";
            this.txtISQLPassword.PasswordChar = '*';
            this.txtISQLPassword.Size = new System.Drawing.Size(213, 20);
            this.txtISQLPassword.TabIndex = 0;
            // 
            // gbISQLUser
            // 
            this.gbISQLUser.Controls.Add(this.txtISQLUser);
            this.gbISQLUser.Location = new System.Drawing.Point(8, 6);
            this.gbISQLUser.Name = "gbISQLUser";
            this.gbISQLUser.Size = new System.Drawing.Size(219, 43);
            this.gbISQLUser.TabIndex = 6;
            this.gbISQLUser.TabStop = false;
            this.gbISQLUser.Text = "User";
            // 
            // txtISQLUser
            // 
            this.txtISQLUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtISQLUser.Location = new System.Drawing.Point(3, 16);
            this.txtISQLUser.Name = "txtISQLUser";
            this.txtISQLUser.Size = new System.Drawing.Size(213, 20);
            this.txtISQLUser.TabIndex = 0;
            // 
            // tabGFIX
            // 
            this.tabGFIX.Controls.Add(this.groupBox2);
            this.tabGFIX.Controls.Add(this.groupBox3);
            this.tabGFIX.Controls.Add(this.groupBox4);
            this.tabGFIX.Location = new System.Drawing.Point(4, 22);
            this.tabGFIX.Name = "tabGFIX";
            this.tabGFIX.Padding = new System.Windows.Forms.Padding(3);
            this.tabGFIX.Size = new System.Drawing.Size(1276, 550);
            this.tabGFIX.TabIndex = 1;
            this.tabGFIX.Text = "GFIX";
            this.tabGFIX.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbGFIXArguments);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 434);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arguments info";
            // 
            // rtbGFIXArguments
            // 
            this.rtbGFIXArguments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGFIXArguments.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGFIXArguments.Location = new System.Drawing.Point(3, 16);
            this.rtbGFIXArguments.Name = "rtbGFIXArguments";
            this.rtbGFIXArguments.Size = new System.Drawing.Size(637, 415);
            this.rtbGFIXArguments.TabIndex = 0;
            this.rtbGFIXArguments.Text = resources.GetString("rtbGFIXArguments.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGFIXParameters);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 95);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // txtGFIXParameters
            // 
            this.txtGFIXParameters.BackColor = System.Drawing.SystemColors.Info;
            this.txtGFIXParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGFIXParameters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGFIXParameters.Location = new System.Drawing.Point(3, 16);
            this.txtGFIXParameters.Multiline = true;
            this.txtGFIXParameters.Name = "txtGFIXParameters";
            this.txtGFIXParameters.Size = new System.Drawing.Size(637, 76);
            this.txtGFIXParameters.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fctGFIXOutput);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(646, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 544);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // fctGFIXOutput
            // 
            this.fctGFIXOutput.AutoCompleteBracketsList = new char[] {
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
            this.fctGFIXOutput.AutoIndentCharsPatterns = "";
            this.fctGFIXOutput.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctGFIXOutput.BackBrush = null;
            this.fctGFIXOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctGFIXOutput.CharHeight = 14;
            this.fctGFIXOutput.CharWidth = 7;
            this.fctGFIXOutput.CommentPrefix = "--";
            this.fctGFIXOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctGFIXOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctGFIXOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctGFIXOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctGFIXOutput.IsReplaceMode = false;
            this.fctGFIXOutput.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctGFIXOutput.LeftBracket = '(';
            this.fctGFIXOutput.Location = new System.Drawing.Point(3, 58);
            this.fctGFIXOutput.Name = "fctGFIXOutput";
            this.fctGFIXOutput.Paddings = new System.Windows.Forms.Padding(0);
            this.fctGFIXOutput.ReadOnly = true;
            this.fctGFIXOutput.RightBracket = ')';
            this.fctGFIXOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctGFIXOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctGFIXOutput.ServiceColors")));
            this.fctGFIXOutput.Size = new System.Drawing.Size(621, 483);
            this.fctGFIXOutput.TabIndex = 24;
            this.fctGFIXOutput.WordWrap = true;
            this.fctGFIXOutput.Zoom = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.hotSpot1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 42);
            this.panel1.TabIndex = 23;
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
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hotSpot1.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hotSpot1.ImageToggleOnSelect = true;
            this.hotSpot1.Location = new System.Drawing.Point(0, 0);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Size = new System.Drawing.Size(37, 42);
            this.hotSpot1.TabIndex = 6;
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
            // tabGSTAT
            // 
            this.tabGSTAT.Controls.Add(this.groupBox1);
            this.tabGSTAT.Controls.Add(this.gbGSTATParameters);
            this.tabGSTAT.Controls.Add(this.gbGStatOut);
            this.tabGSTAT.Location = new System.Drawing.Point(4, 22);
            this.tabGSTAT.Name = "tabGSTAT";
            this.tabGSTAT.Padding = new System.Windows.Forms.Padding(3);
            this.tabGSTAT.Size = new System.Drawing.Size(1276, 550);
            this.tabGSTAT.TabIndex = 2;
            this.tabGSTAT.Text = "GSTAT";
            this.tabGSTAT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbGSTATArgument);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 230);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arguments info";
            // 
            // rtbGSTATArgument
            // 
            this.rtbGSTATArgument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGSTATArgument.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGSTATArgument.Location = new System.Drawing.Point(3, 16);
            this.rtbGSTATArgument.Name = "rtbGSTATArgument";
            this.rtbGSTATArgument.Size = new System.Drawing.Size(637, 211);
            this.rtbGSTATArgument.TabIndex = 0;
            this.rtbGSTATArgument.Text = resources.GetString("rtbGSTATArgument.Text");
            // 
            // gbGSTATParameters
            // 
            this.gbGSTATParameters.Controls.Add(this.txtGSTATParameters);
            this.gbGSTATParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGSTATParameters.Location = new System.Drawing.Point(3, 3);
            this.gbGSTATParameters.Name = "gbGSTATParameters";
            this.gbGSTATParameters.Size = new System.Drawing.Size(643, 95);
            this.gbGSTATParameters.TabIndex = 10;
            this.gbGSTATParameters.TabStop = false;
            this.gbGSTATParameters.Text = "Parameters";
            // 
            // txtGSTATParameters
            // 
            this.txtGSTATParameters.BackColor = System.Drawing.SystemColors.Info;
            this.txtGSTATParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGSTATParameters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSTATParameters.Location = new System.Drawing.Point(3, 16);
            this.txtGSTATParameters.Multiline = true;
            this.txtGSTATParameters.Name = "txtGSTATParameters";
            this.txtGSTATParameters.Size = new System.Drawing.Size(637, 76);
            this.txtGSTATParameters.TabIndex = 0;
            // 
            // gbGStatOut
            // 
            this.gbGStatOut.Controls.Add(this.fctGSTATOutput);
            this.gbGStatOut.Controls.Add(this.pnlGStatUpper);
            this.gbGStatOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbGStatOut.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGStatOut.Location = new System.Drawing.Point(646, 3);
            this.gbGStatOut.Name = "gbGStatOut";
            this.gbGStatOut.Size = new System.Drawing.Size(627, 544);
            this.gbGStatOut.TabIndex = 0;
            this.gbGStatOut.TabStop = false;
            this.gbGStatOut.Text = "Output";
            // 
            // fctGSTATOutput
            // 
            this.fctGSTATOutput.AutoCompleteBracketsList = new char[] {
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
            this.fctGSTATOutput.AutoIndentCharsPatterns = "";
            this.fctGSTATOutput.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctGSTATOutput.BackBrush = null;
            this.fctGSTATOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctGSTATOutput.CharHeight = 14;
            this.fctGSTATOutput.CharWidth = 7;
            this.fctGSTATOutput.CommentPrefix = "--";
            this.fctGSTATOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctGSTATOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctGSTATOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctGSTATOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctGSTATOutput.IsReplaceMode = false;
            this.fctGSTATOutput.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctGSTATOutput.LeftBracket = '(';
            this.fctGSTATOutput.Location = new System.Drawing.Point(3, 58);
            this.fctGSTATOutput.Name = "fctGSTATOutput";
            this.fctGSTATOutput.Paddings = new System.Windows.Forms.Padding(0);
            this.fctGSTATOutput.ReadOnly = true;
            this.fctGSTATOutput.RightBracket = ')';
            this.fctGSTATOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctGSTATOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctGSTATOutput.ServiceColors")));
            this.fctGSTATOutput.Size = new System.Drawing.Size(621, 483);
            this.fctGSTATOutput.TabIndex = 24;
            this.fctGSTATOutput.WordWrap = true;
            this.fctGSTATOutput.Zoom = 100;
            // 
            // pnlGStatUpper
            // 
            this.pnlGStatUpper.BackColor = System.Drawing.Color.DarkGray;
            this.pnlGStatUpper.Controls.Add(this.hsSaveGStatToFile);
            this.pnlGStatUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGStatUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlGStatUpper.Name = "pnlGStatUpper";
            this.pnlGStatUpper.Size = new System.Drawing.Size(621, 42);
            this.pnlGStatUpper.TabIndex = 23;
            // 
            // hsSaveGStatToFile
            // 
            this.hsSaveGStatToFile.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveGStatToFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveGStatToFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveGStatToFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveGStatToFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveGStatToFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveGStatToFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveGStatToFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveGStatToFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hsSaveGStatToFile.FlatAppearance.BorderSize = 0;
            this.hsSaveGStatToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveGStatToFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveGStatToFile.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hsSaveGStatToFile.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hsSaveGStatToFile.ImageToggleOnSelect = true;
            this.hsSaveGStatToFile.Location = new System.Drawing.Point(0, 0);
            this.hsSaveGStatToFile.Marked = false;
            this.hsSaveGStatToFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveGStatToFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveGStatToFile.MarkedText = "";
            this.hsSaveGStatToFile.MarkMode = false;
            this.hsSaveGStatToFile.Name = "hsSaveGStatToFile";
            this.hsSaveGStatToFile.NonMarkedText = "";
            this.hsSaveGStatToFile.Size = new System.Drawing.Size(37, 42);
            this.hsSaveGStatToFile.TabIndex = 6;
            this.hsSaveGStatToFile.ToolTipActive = false;
            this.hsSaveGStatToFile.ToolTipAutomaticDelay = 500;
            this.hsSaveGStatToFile.ToolTipAutoPopDelay = 5000;
            this.hsSaveGStatToFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveGStatToFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveGStatToFile.ToolTipFor4ContextMenu = true;
            this.hsSaveGStatToFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveGStatToFile.ToolTipInitialDelay = 500;
            this.hsSaveGStatToFile.ToolTipIsBallon = false;
            this.hsSaveGStatToFile.ToolTipOwnerDraw = false;
            this.hsSaveGStatToFile.ToolTipReshowDelay = 100;
            
            this.hsSaveGStatToFile.ToolTipShowAlways = false;
            this.hsSaveGStatToFile.ToolTipText = "";
            this.hsSaveGStatToFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveGStatToFile.ToolTipTitle = "";
            this.hsSaveGStatToFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveGStatToFile.UseVisualStyleBackColor = false;
            // 
            // tabGBAK
            // 
            this.tabGBAK.Controls.Add(this.gbGBAKParameterInfo);
            this.tabGBAK.Controls.Add(this.gbGBAKParameters);
            this.tabGBAK.Controls.Add(this.pnlGBAKUpper);
            this.tabGBAK.Controls.Add(this.groupBox7);
            this.tabGBAK.Location = new System.Drawing.Point(4, 22);
            this.tabGBAK.Name = "tabGBAK";
            this.tabGBAK.Padding = new System.Windows.Forms.Padding(3);
            this.tabGBAK.Size = new System.Drawing.Size(1276, 550);
            this.tabGBAK.TabIndex = 3;
            this.tabGBAK.Text = "GBAK";
            this.tabGBAK.UseVisualStyleBackColor = true;
            // 
            // gbGBAKParameterInfo
            // 
            this.gbGBAKParameterInfo.Controls.Add(this.rtbGBAKArguments);
            this.gbGBAKParameterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGBAKParameterInfo.Location = new System.Drawing.Point(3, 156);
            this.gbGBAKParameterInfo.Name = "gbGBAKParameterInfo";
            this.gbGBAKParameterInfo.Size = new System.Drawing.Size(643, 391);
            this.gbGBAKParameterInfo.TabIndex = 17;
            this.gbGBAKParameterInfo.TabStop = false;
            this.gbGBAKParameterInfo.Text = "Arguments info";
            // 
            // rtbGBAKArguments
            // 
            this.rtbGBAKArguments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGBAKArguments.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGBAKArguments.Location = new System.Drawing.Point(3, 16);
            this.rtbGBAKArguments.Name = "rtbGBAKArguments";
            this.rtbGBAKArguments.Size = new System.Drawing.Size(637, 372);
            this.rtbGBAKArguments.TabIndex = 0;
            this.rtbGBAKArguments.Text = resources.GetString("rtbGBAKArguments.Text");
            // 
            // gbGBAKParameters
            // 
            this.gbGBAKParameters.Controls.Add(this.txtGBAKParameters);
            this.gbGBAKParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGBAKParameters.Location = new System.Drawing.Point(3, 61);
            this.gbGBAKParameters.Name = "gbGBAKParameters";
            this.gbGBAKParameters.Size = new System.Drawing.Size(643, 95);
            this.gbGBAKParameters.TabIndex = 16;
            this.gbGBAKParameters.TabStop = false;
            this.gbGBAKParameters.Text = "Parameters";
            // 
            // txtGBAKParameters
            // 
            this.txtGBAKParameters.BackColor = System.Drawing.SystemColors.Info;
            this.txtGBAKParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGBAKParameters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGBAKParameters.Location = new System.Drawing.Point(3, 16);
            this.txtGBAKParameters.Multiline = true;
            this.txtGBAKParameters.Name = "txtGBAKParameters";
            this.txtGBAKParameters.Size = new System.Drawing.Size(637, 76);
            this.txtGBAKParameters.TabIndex = 0;
            // 
            // pnlGBAKUpper
            // 
            this.pnlGBAKUpper.Controls.Add(this.groupBox5);
            this.pnlGBAKUpper.Controls.Add(this.gbBAKUser);
            this.pnlGBAKUpper.Controls.Add(this.gbBAKPassword);
            this.pnlGBAKUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGBAKUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlGBAKUpper.Name = "pnlGBAKUpper";
            this.pnlGBAKUpper.Size = new System.Drawing.Size(643, 58);
            this.pnlGBAKUpper.TabIndex = 21;
            // 
            // cbBackupType
            // 
            this.cbBackupType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBackupType.FormattingEnabled = true;
            this.cbBackupType.Items.AddRange(new object[] {
            "Backup",
            "Restore",
            "Version"});
            this.cbBackupType.Location = new System.Drawing.Point(3, 16);
            this.cbBackupType.Name = "cbBackupType";
            this.cbBackupType.Size = new System.Drawing.Size(127, 21);
            this.cbBackupType.TabIndex = 20;
            this.cbBackupType.Text = "Version";
            this.cbBackupType.SelectedIndexChanged += new System.EventHandler(this.cbBackupType_SelectedIndexChanged);
            // 
            // gbBAKUser
            // 
            this.gbBAKUser.Controls.Add(this.txtGBAKUser);
            this.gbBAKUser.Location = new System.Drawing.Point(6, 6);
            this.gbBAKUser.Name = "gbBAKUser";
            this.gbBAKUser.Size = new System.Drawing.Size(219, 43);
            this.gbBAKUser.TabIndex = 18;
            this.gbBAKUser.TabStop = false;
            this.gbBAKUser.Text = "User";
            // 
            // txtGBAKUser
            // 
            this.txtGBAKUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGBAKUser.Location = new System.Drawing.Point(3, 16);
            this.txtGBAKUser.Name = "txtGBAKUser";
            this.txtGBAKUser.Size = new System.Drawing.Size(213, 20);
            this.txtGBAKUser.TabIndex = 0;
            // 
            // gbBAKPassword
            // 
            this.gbBAKPassword.Controls.Add(this.txtGBAKPassword);
            this.gbBAKPassword.Location = new System.Drawing.Point(228, 6);
            this.gbBAKPassword.Name = "gbBAKPassword";
            this.gbBAKPassword.Size = new System.Drawing.Size(219, 43);
            this.gbBAKPassword.TabIndex = 19;
            this.gbBAKPassword.TabStop = false;
            this.gbBAKPassword.Text = "Passwort";
            // 
            // txtGBAKPassword
            // 
            this.txtGBAKPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGBAKPassword.Location = new System.Drawing.Point(3, 16);
            this.txtGBAKPassword.Name = "txtGBAKPassword";
            this.txtGBAKPassword.PasswordChar = '*';
            this.txtGBAKPassword.Size = new System.Drawing.Size(213, 20);
            this.txtGBAKPassword.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.panel2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(646, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(627, 544);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(621, 483);
            this.textBox1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.hotSpot2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 42);
            this.panel2.TabIndex = 23;
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
            this.hotSpot2.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::FBXpert.Properties.Resources.floppy_x24;
            this.hotSpot2.ImageHover = global::FBXpert.Properties.Resources.floppy2_x24;
            this.hotSpot2.ImageToggleOnSelect = true;
            this.hotSpot2.Location = new System.Drawing.Point(0, 0);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "";
            this.hotSpot2.Size = new System.Drawing.Size(37, 42);
            this.hotSpot2.TabIndex = 6;
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
            // ofdFiles
            // 
            this.ofdFiles.DefaultExt = "*.txt";
            this.ofdFiles.Filter = "Text|*.txt|All|*.*";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbBackupType);
            this.groupBox5.Location = new System.Drawing.Point(453, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 44);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Typ";
            // 
            // BinariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 624);
            this.Controls.Add(this.tcCenter);
            this.Controls.Add(this.pnlUpper);
            this.Name = "BinariesForm";
            this.Text = "BinariesForm";
            this.Load += new System.EventHandler(this.BinariesForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.tcCenter.ResumeLayout(false);
            this.tabISQL.ResumeLayout(false);
            this.gbArgumentsInfo.ResumeLayout(false);
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbISQLOptions.ResumeLayout(false);
            this.gbISQLOptions.PerformLayout();
            this.gbISQLPassword.ResumeLayout(false);
            this.gbISQLPassword.PerformLayout();
            this.gbISQLUser.ResumeLayout(false);
            this.gbISQLUser.PerformLayout();
            this.tabGFIX.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctGFIXOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabGSTAT.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbGSTATParameters.ResumeLayout(false);
            this.gbGSTATParameters.PerformLayout();
            this.gbGStatOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctGSTATOutput)).EndInit();
            this.pnlGStatUpper.ResumeLayout(false);
            this.tabGBAK.ResumeLayout(false);
            this.gbGBAKParameterInfo.ResumeLayout(false);
            this.gbGBAKParameters.ResumeLayout(false);
            this.gbGBAKParameters.PerformLayout();
            this.pnlGBAKUpper.ResumeLayout(false);
            this.gbBAKUser.ResumeLayout(false);
            this.gbBAKUser.PerformLayout();
            this.gbBAKPassword.ResumeLayout(false);
            this.gbBAKPassword.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.TabControl tcCenter;
        private System.Windows.Forms.TabPage tabISQL;
        private System.Windows.Forms.TabPage tabGFIX;
        private SeControlsLib.HotSpot hsRun;
        private System.Windows.Forms.GroupBox gbISQLUser;
        private System.Windows.Forms.TextBox txtISQLUser;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.TextBox txtISQLParameters;
        private System.Windows.Forms.GroupBox gbISQLOptions;
        private System.Windows.Forms.CheckBox cbISQLNoFireTriggers;
        private System.Windows.Forms.GroupBox gbISQLPassword;
        private System.Windows.Forms.TextBox txtISQLPassword;
        private System.Windows.Forms.GroupBox gbArgumentsInfo;
        private System.Windows.Forms.RichTextBox rtfCommands;
        private System.Windows.Forms.TabPage tabGSTAT;
        private System.Windows.Forms.GroupBox gbGStatOut;
        private System.Windows.Forms.GroupBox gbGSTATParameters;
        private System.Windows.Forms.TextBox txtGSTATParameters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbGSTATArgument;
        private System.Windows.Forms.CheckBox cbNoAutocommit;
        private FastColoredTextBoxNS.FastColoredTextBox fctGSTATOutput;
        private System.Windows.Forms.Panel pnlGStatUpper;
        private SeControlsLib.HotSpot hsSaveGStatToFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbGFIXArguments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGFIXParameters;
        private System.Windows.Forms.GroupBox groupBox4;
        private FastColoredTextBoxNS.FastColoredTextBox fctGFIXOutput;
        private System.Windows.Forms.Panel panel1;
        private SeControlsLib.HotSpot hotSpot1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.CheckBox cbInputFile;
        private System.Windows.Forms.CheckBox cbOutputFile;
        private System.Windows.Forms.CheckBox cbNoWarnings;
        private SeControlsLib.HotSpot hsSelectFolderInputFile;
        private SeControlsLib.HotSpot hsSelectFolderOutputFile;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
        private System.Windows.Forms.TabPage tabGBAK;
        private System.Windows.Forms.GroupBox gbGBAKParameterInfo;
        private System.Windows.Forms.RichTextBox rtbGBAKArguments;
        private System.Windows.Forms.GroupBox gbGBAKParameters;
        private System.Windows.Forms.TextBox txtGBAKParameters;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel2;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.GroupBox gbBAKPassword;
        private System.Windows.Forms.TextBox txtGBAKPassword;
        private System.Windows.Forms.GroupBox gbBAKUser;
        private System.Windows.Forms.TextBox txtGBAKUser;
        private System.Windows.Forms.ComboBox cbBackupType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlGBAKUpper;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}