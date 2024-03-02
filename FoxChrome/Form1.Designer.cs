
namespace FoxChrome
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LUPCBtn = new System.Windows.Forms.Button();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseBtn = new System.Windows.Forms.Button();
            this.installBtn = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.profileComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoInstallExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoAcceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockAutomaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askForInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configFileInstallPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableAutomaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockAutomaticallyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.askForInstallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeApplicationFilesAfterInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openChromeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openUserjsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPrefsjsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouztToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LUPCBtn
            // 
            this.LUPCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPCBtn.Location = new System.Drawing.Point(22, 78);
            this.LUPCBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LUPCBtn.Name = "LUPCBtn";
            this.LUPCBtn.Size = new System.Drawing.Size(180, 42);
            this.LUPCBtn.TabIndex = 9;
            this.LUPCBtn.Text = "L.U.P.C.: OFF";
            this.LUPCBtn.UseVisualStyleBackColor = true;
            this.LUPCBtn.Click += new System.EventHandler(this.LUPCBtn_Click);
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(213, 78);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(138, 42);
            this.browseBtn.TabIndex = 8;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(362, 78);
            this.installBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(138, 42);
            this.installBtn.TabIndex = 7;
            this.installBtn.Text = "Install";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 25);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Profile:";
            // 
            // profileComboBox
            // 
            this.profileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.Location = new System.Drawing.Point(22, 27);
            this.profileComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(473, 32);
            this.profileComboBox.TabIndex = 5;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
            this.profileComboBox.DropDownClosed += new System.EventHandler(this.profileComboBox_DropDownClosed);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.profileComboBox);
            this.panel1.Controls.Add(this.LUPCBtn);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.browseBtn);
            this.panel1.Controls.Add(this.installBtn);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 144);
            this.panel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.installToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.abouztToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(517, 40);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.unselectToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.createToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // unselectToolStripMenuItem
            // 
            this.unselectToolStripMenuItem.Name = "unselectToolStripMenuItem";
            this.unselectToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.unselectToolStripMenuItem.Text = "Unselect";
            this.unselectToolStripMenuItem.Click += new System.EventHandler(this.unselectToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.openFolderToolStripMenuItem.Text = "Open File Location";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayNoteToolStripMenuItem,
            this.autoInstallExtensionsToolStripMenuItem,
            this.configFileInstallPromptToolStripMenuItem,
            this.removeApplicationFilesAfterInstallToolStripMenuItem});
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.installToolStripMenuItem.Text = "Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // displayNoteToolStripMenuItem
            // 
            this.displayNoteToolStripMenuItem.Name = "displayNoteToolStripMenuItem";
            this.displayNoteToolStripMenuItem.Size = new System.Drawing.Size(465, 40);
            this.displayNoteToolStripMenuItem.Text = "Display developer note";
            this.displayNoteToolStripMenuItem.Click += new System.EventHandler(this.displayNoteToolStripMenuItem_Click);
            // 
            // autoInstallExtensionsToolStripMenuItem
            // 
            this.autoInstallExtensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoAcceptToolStripMenuItem,
            this.blockAutomaticallyToolStripMenuItem,
            this.askForInstallToolStripMenuItem});
            this.autoInstallExtensionsToolStripMenuItem.Name = "autoInstallExtensionsToolStripMenuItem";
            this.autoInstallExtensionsToolStripMenuItem.Size = new System.Drawing.Size(465, 40);
            this.autoInstallExtensionsToolStripMenuItem.Text = "Extension install prompt";
            this.autoInstallExtensionsToolStripMenuItem.Click += new System.EventHandler(this.autoInstallExtensionsToolStripMenuItem_Click);
            // 
            // autoAcceptToolStripMenuItem
            // 
            this.autoAcceptToolStripMenuItem.Name = "autoAcceptToolStripMenuItem";
            this.autoAcceptToolStripMenuItem.Size = new System.Drawing.Size(323, 40);
            this.autoAcceptToolStripMenuItem.Text = "Enable automatically";
            this.autoAcceptToolStripMenuItem.Click += new System.EventHandler(this.autoAcceptToolStripMenuItem_Click);
            // 
            // blockAutomaticallyToolStripMenuItem
            // 
            this.blockAutomaticallyToolStripMenuItem.Name = "blockAutomaticallyToolStripMenuItem";
            this.blockAutomaticallyToolStripMenuItem.Size = new System.Drawing.Size(323, 40);
            this.blockAutomaticallyToolStripMenuItem.Text = "Block automatically";
            this.blockAutomaticallyToolStripMenuItem.Click += new System.EventHandler(this.blockAutomaticallyToolStripMenuItem_Click);
            // 
            // askForInstallToolStripMenuItem
            // 
            this.askForInstallToolStripMenuItem.Name = "askForInstallToolStripMenuItem";
            this.askForInstallToolStripMenuItem.Size = new System.Drawing.Size(323, 40);
            this.askForInstallToolStripMenuItem.Text = "Ask for install";
            this.askForInstallToolStripMenuItem.Click += new System.EventHandler(this.askForInstallToolStripMenuItem_Click);
            // 
            // configFileInstallPromptToolStripMenuItem
            // 
            this.configFileInstallPromptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableAutomaticallyToolStripMenuItem,
            this.blockAutomaticallyToolStripMenuItem1,
            this.askForInstallToolStripMenuItem1});
            this.configFileInstallPromptToolStripMenuItem.Name = "configFileInstallPromptToolStripMenuItem";
            this.configFileInstallPromptToolStripMenuItem.Size = new System.Drawing.Size(465, 40);
            this.configFileInstallPromptToolStripMenuItem.Text = "Config file install prompt";
            // 
            // enableAutomaticallyToolStripMenuItem
            // 
            this.enableAutomaticallyToolStripMenuItem.Name = "enableAutomaticallyToolStripMenuItem";
            this.enableAutomaticallyToolStripMenuItem.Size = new System.Drawing.Size(323, 40);
            this.enableAutomaticallyToolStripMenuItem.Text = "Enable automatically";
            this.enableAutomaticallyToolStripMenuItem.Click += new System.EventHandler(this.enableAutomaticallyToolStripMenuItem_Click);
            // 
            // blockAutomaticallyToolStripMenuItem1
            // 
            this.blockAutomaticallyToolStripMenuItem1.Name = "blockAutomaticallyToolStripMenuItem1";
            this.blockAutomaticallyToolStripMenuItem1.Size = new System.Drawing.Size(323, 40);
            this.blockAutomaticallyToolStripMenuItem1.Text = "Block automatically";
            this.blockAutomaticallyToolStripMenuItem1.Click += new System.EventHandler(this.blockAutomaticallyToolStripMenuItem1_Click);
            // 
            // askForInstallToolStripMenuItem1
            // 
            this.askForInstallToolStripMenuItem1.Name = "askForInstallToolStripMenuItem1";
            this.askForInstallToolStripMenuItem1.Size = new System.Drawing.Size(323, 40);
            this.askForInstallToolStripMenuItem1.Text = "Ask for install";
            this.askForInstallToolStripMenuItem1.Click += new System.EventHandler(this.askForInstallToolStripMenuItem1_Click);
            // 
            // removeApplicationFilesAfterInstallToolStripMenuItem
            // 
            this.removeApplicationFilesAfterInstallToolStripMenuItem.Name = "removeApplicationFilesAfterInstallToolStripMenuItem";
            this.removeApplicationFilesAfterInstallToolStripMenuItem.Size = new System.Drawing.Size(465, 40);
            this.removeApplicationFilesAfterInstallToolStripMenuItem.Text = "Remove application files after install";
            this.removeApplicationFilesAfterInstallToolStripMenuItem.Click += new System.EventHandler(this.removeApplicationFilesAfterInstallToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openChromeFolderToolStripMenuItem,
            this.openFolderToolStripMenuItem1,
            this.openUserjsToolStripMenuItem,
            this.openPrefsjsToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // openChromeFolderToolStripMenuItem
            // 
            this.openChromeFolderToolStripMenuItem.Name = "openChromeFolderToolStripMenuItem";
            this.openChromeFolderToolStripMenuItem.Size = new System.Drawing.Size(324, 40);
            this.openChromeFolderToolStripMenuItem.Text = "Open Chrome Folder";
            this.openChromeFolderToolStripMenuItem.Click += new System.EventHandler(this.openChromeFolderToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem1
            // 
            this.openFolderToolStripMenuItem1.Name = "openFolderToolStripMenuItem1";
            this.openFolderToolStripMenuItem1.Size = new System.Drawing.Size(324, 40);
            this.openFolderToolStripMenuItem1.Text = "Open Folder";
            this.openFolderToolStripMenuItem1.Click += new System.EventHandler(this.openFolderToolStripMenuItem1_Click);
            // 
            // openUserjsToolStripMenuItem
            // 
            this.openUserjsToolStripMenuItem.Name = "openUserjsToolStripMenuItem";
            this.openUserjsToolStripMenuItem.Size = new System.Drawing.Size(324, 40);
            this.openUserjsToolStripMenuItem.Text = "Open user.js";
            this.openUserjsToolStripMenuItem.Click += new System.EventHandler(this.openUserjsToolStripMenuItem_Click);
            // 
            // openPrefsjsToolStripMenuItem
            // 
            this.openPrefsjsToolStripMenuItem.Name = "openPrefsjsToolStripMenuItem";
            this.openPrefsjsToolStripMenuItem.Size = new System.Drawing.Size(324, 40);
            this.openPrefsjsToolStripMenuItem.Text = "Open prefs.js";
            this.openPrefsjsToolStripMenuItem.Click += new System.EventHandler(this.openPrefsjsToolStripMenuItem_Click);
            // 
            // abouztToolStripMenuItem
            // 
            this.abouztToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.applicationInfoToolStripMenuItem});
            this.abouztToolStripMenuItem.Name = "abouztToolStripMenuItem";
            this.abouztToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.abouztToolStripMenuItem.Text = "About";
            this.abouztToolStripMenuItem.Click += new System.EventHandler(this.abouztToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Visible = false;
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // applicationInfoToolStripMenuItem
            // 
            this.applicationInfoToolStripMenuItem.Name = "applicationInfoToolStripMenuItem";
            this.applicationInfoToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.applicationInfoToolStripMenuItem.Text = "Application info";
            this.applicationInfoToolStripMenuItem.Click += new System.EventHandler(this.applicationInfoToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 198);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoxChrome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button LUPCBtn;
        internal System.Windows.Forms.Timer ProcessTimer;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Button browseBtn;
        internal System.Windows.Forms.Button installBtn;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox profileComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouztToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openChromeFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openUserjsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPrefsjsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoInstallExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoAcceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockAutomaticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askForInstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configFileInstallPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableAutomaticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockAutomaticallyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem askForInstallToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeApplicationFilesAfterInstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

