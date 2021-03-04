using BasicForms;

namespace FBXpert
{
    partial class FbXpertMainForm : BasicEditFormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FbXpertMainForm));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiShowWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUtilities = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDesignEarth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesignGray = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDatabaseDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCreateUUID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScripting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabasRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.testMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJapanese = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLastLoadedDefinition = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.cmsView.SuspendLayout();
            this.cmsNotifications.SuspendLayout();
            this.cmsUtilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowWindows,
            this.tsmiNotifications,
            this.tsmiUtilities});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.tsmiShowWindows;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1113, 28);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "Main";
            // 
            // tsmiShowWindows
            // 
            this.tsmiShowWindows.DropDown = this.cmsView;
            this.tsmiShowWindows.Image = global::FBXpert.Properties.Resources.windows_lightblue_x22;
            this.tsmiShowWindows.Name = "tsmiShowWindows";
            this.tsmiShowWindows.Size = new System.Drawing.Size(120, 24);
            this.tsmiShowWindows.Text = "Show Windows";
            // 
            // cmsView
            // 
            this.cmsView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsmiExit});
            this.cmsView.Name = "contextMenuStrip1";
            this.cmsView.OwnerItem = this.tsmiShowWindows;
            this.cmsView.Size = new System.Drawing.Size(142, 36);
            this.cmsView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::FBXpert.Properties.Resources.go_previous22x;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(141, 26);
            this.tsmiExit.Text = "Exit FBXpert";
            // 
            // tsmiNotifications
            // 
            this.tsmiNotifications.DropDown = this.cmsNotifications;
            this.tsmiNotifications.Image = global::FBXpert.Properties.Resources.info_22x1;
            this.tsmiNotifications.Name = "tsmiNotifications";
            this.tsmiNotifications.Size = new System.Drawing.Size(107, 24);
            this.tsmiNotifications.Text = "Notifications";
            // 
            // cmsNotifications
            // 
            this.cmsNotifications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNotes,
            this.tsmiErrors});
            this.cmsNotifications.Name = "contextMenuStrip1";
            this.cmsNotifications.OwnerItem = this.tsmiNotifications;
            this.cmsNotifications.Size = new System.Drawing.Size(123, 48);
            this.cmsNotifications.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsNotifications_ItemClicked);
            // 
            // tsmiNotes
            // 
            this.tsmiNotes.Name = "tsmiNotes";
            this.tsmiNotes.Size = new System.Drawing.Size(122, 22);
            this.tsmiNotes.Text = "Notes (0)";
            // 
            // tsmiErrors
            // 
            this.tsmiErrors.Name = "tsmiErrors";
            this.tsmiErrors.Size = new System.Drawing.Size(122, 22);
            this.tsmiErrors.Text = "Errors (0)";
            // 
            // tsmiUtilities
            // 
            this.tsmiUtilities.DropDown = this.cmsUtilities;
            this.tsmiUtilities.Image = global::FBXpert.Properties.Resources.preferences_system_x24;
            this.tsmiUtilities.Name = "tsmiUtilities";
            this.tsmiUtilities.Size = new System.Drawing.Size(78, 24);
            this.tsmiUtilities.Text = "Utilities";
            // 
            // cmsUtilities
            // 
            this.cmsUtilities.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUtilities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDesignEarth,
            this.tsmiDesignGray,
            this.tsmiAppSettings,
            this.toolStripSeparator4,
            this.tsmiDatabaseDesign,
            this.toolStripSeparator3,
            this.tsmiCreateUUID,
            this.tsmiScripting,
            this.tsmiDatabasRegistration,
            this.testMToolStripMenuItem,
            this.toolStripSeparator5,
            this.tsmiLanguage,
            this.tsmiGerman,
            this.tsmiEnglish,
            this.tsmiJapanese});
            this.cmsUtilities.Name = "contextMenuStrip1";
            this.cmsUtilities.OwnerItem = this.tsmiUtilities;
            this.cmsUtilities.Size = new System.Drawing.Size(190, 334);
            this.cmsUtilities.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // tsmiDesignEarth
            // 
            this.tsmiDesignEarth.Name = "tsmiDesignEarth";
            this.tsmiDesignEarth.Size = new System.Drawing.Size(189, 26);
            this.tsmiDesignEarth.Text = "Design Earth";
            // 
            // tsmiDesignGray
            // 
            this.tsmiDesignGray.Name = "tsmiDesignGray";
            this.tsmiDesignGray.Size = new System.Drawing.Size(189, 26);
            this.tsmiDesignGray.Text = "Design Gray";
            // 
            // tsmiAppSettings
            // 
            this.tsmiAppSettings.Name = "tsmiAppSettings";
            this.tsmiAppSettings.Size = new System.Drawing.Size(189, 26);
            this.tsmiAppSettings.Text = "Application Settings";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiDatabaseDesign
            // 
            this.tsmiDatabaseDesign.Image = global::FBXpert.Properties.Resources.database_gr_24x;
            this.tsmiDatabaseDesign.Name = "tsmiDatabaseDesign";
            this.tsmiDatabaseDesign.Size = new System.Drawing.Size(189, 26);
            this.tsmiDatabaseDesign.Text = "Database design";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiCreateUUID
            // 
            this.tsmiCreateUUID.Image = global::FBXpert.Properties.Resources.font2_x241;
            this.tsmiCreateUUID.Name = "tsmiCreateUUID";
            this.tsmiCreateUUID.Size = new System.Drawing.Size(189, 26);
            this.tsmiCreateUUID.Text = "Create UUID";
            // 
            // tsmiScripting
            // 
            this.tsmiScripting.Image = global::FBXpert.Properties.Resources.SQL_blue_x24;
            this.tsmiScripting.Name = "tsmiScripting";
            this.tsmiScripting.Size = new System.Drawing.Size(189, 26);
            this.tsmiScripting.Text = "Scripting";
            // 
            // tsmiDatabasRegistration
            // 
            this.tsmiDatabasRegistration.Image = global::FBXpert.Properties.Resources.database_gr_24x;
            this.tsmiDatabasRegistration.Name = "tsmiDatabasRegistration";
            this.tsmiDatabasRegistration.Size = new System.Drawing.Size(189, 26);
            this.tsmiDatabasRegistration.Text = "Database registration";
            // 
            // testMToolStripMenuItem
            // 
            this.testMToolStripMenuItem.Name = "testMToolStripMenuItem";
            this.testMToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.testMToolStripMenuItem.Text = "TestM";
            this.testMToolStripMenuItem.Click += new System.EventHandler(this.testMToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiLanguage
            // 
            this.tsmiLanguage.Enabled = false;
            this.tsmiLanguage.Name = "tsmiLanguage";
            this.tsmiLanguage.Size = new System.Drawing.Size(189, 26);
            this.tsmiLanguage.Text = "Language";
            // 
            // tsmiGerman
            // 
            this.tsmiGerman.Image = global::FBXpert.Properties.Resources.de;
            this.tsmiGerman.Name = "tsmiGerman";
            this.tsmiGerman.Size = new System.Drawing.Size(189, 26);
            this.tsmiGerman.Text = "Deutsch";
            // 
            // tsmiEnglish
            // 
            this.tsmiEnglish.Image = global::FBXpert.Properties.Resources.gb;
            this.tsmiEnglish.Name = "tsmiEnglish";
            this.tsmiEnglish.Size = new System.Drawing.Size(189, 26);
            this.tsmiEnglish.Text = "English";
            // 
            // tsmiJapanese
            // 
            this.tsmiJapanese.Image = global::FBXpert.Properties.Resources.jp;
            this.tsmiJapanese.Name = "tsmiJapanese";
            this.tsmiJapanese.Size = new System.Drawing.Size(189, 26);
            this.tsmiJapanese.Text = "Japanisch (TEST)";
            // 
            // lblLastLoadedDfinition
            // 
            this.lblLastLoadedDefinition.AutoSize = true;
            this.lblLastLoadedDefinition.Location = new System.Drawing.Point(384, 9);
            this.lblLastLoadedDefinition.Name = "lblLastLoadedDfinition";
            this.lblLastLoadedDefinition.Size = new System.Drawing.Size(101, 13);
            this.lblLastLoadedDefinition.TabIndex = 5;
            this.lblLastLoadedDefinition.Text = "lastLoadedDefintion";
            // 
            // FbXpertMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 636);
            this.Controls.Add(this.lblLastLoadedDefinition);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FbXpertMainForm";
            this.Text = "FBXpert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBXpertMainForm_FormClosing);
            this.Load += new System.EventHandler(this.FBXpertMainForm_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.cmsView.ResumeLayout(false);
            this.cmsNotifications.ResumeLayout(false);
            this.cmsUtilities.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWindows;
        private System.Windows.Forms.ContextMenuStrip cmsView;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtilities;
        private System.Windows.Forms.ContextMenuStrip cmsUtilities;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesignEarth;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesignGray;
        private System.Windows.Forms.ToolStripMenuItem tsmiAppSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabaseDesign;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotifications;
        private System.Windows.Forms.ContextMenuStrip cmsNotifications;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotes;
        private System.Windows.Forms.ToolStripMenuItem tsmiErrors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateUUID;
        private System.Windows.Forms.ToolStripMenuItem tsmiScripting;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabasRegistration;
        private System.Windows.Forms.ToolStripMenuItem testMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGerman;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnglish;
        private System.Windows.Forms.ToolStripMenuItem tsmiJapanese;
        private System.Windows.Forms.Label lblLastLoadedDefinition;
    }
}

