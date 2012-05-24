namespace MailClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Outbox", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Inbox", System.Windows.Forms.HorizontalAlignment.Left);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundUpdater = new System.ComponentModel.BackgroundWorker();
            this.backgroundSender = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rijndaelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newButton = new System.Windows.Forms.ToolStripMenuItem();
            this.replyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.updateButton = new System.Windows.Forms.ToolStripSplitButton();
            this.sendMailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneContainer = new System.Windows.Forms.SplitContainer();
            this.mailView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contentView = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paneContainer)).BeginInit();
            this.paneContainer.Panel1.SuspendLayout();
            this.paneContainer.Panel2.SuspendLayout();
            this.paneContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(649, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // backgroundUpdater
            // 
            this.backgroundUpdater.WorkerReportsProgress = true;
            this.backgroundUpdater.WorkerSupportsCancellation = true;
            this.backgroundUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundUpdater_DoWork);
            this.backgroundUpdater.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundUpdater_ProgressChanged);
            this.backgroundUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundUpdater_RunWorkerCompleted);
            // 
            // backgroundSender
            // 
            this.backgroundSender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSender_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripSeparator6,
            this.newButton,
            this.replyButton,
            this.forwardButton,
            this.toolStripSeparator7,
            this.updateButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationButton,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // configurationButton
            // 
            this.configurationButton.Name = "configurationButton";
            this.configurationButton.Size = new System.Drawing.Size(148, 22);
            this.configurationButton.Text = "Configuration";
            this.configurationButton.Click += new System.EventHandler(this.configurationButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readingPaneToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // readingPaneToolStripMenuItem
            // 
            this.readingPaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.hiddenToolStripMenuItem});
            this.readingPaneToolStripMenuItem.Name = "readingPaneToolStripMenuItem";
            this.readingPaneToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.readingPaneToolStripMenuItem.Text = "Reading pane";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // hiddenToolStripMenuItem
            // 
            this.hiddenToolStripMenuItem.Name = "hiddenToolStripMenuItem";
            this.hiddenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hiddenToolStripMenuItem.Text = "Hidden";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseButton,
            this.decryptButton});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // browseButton
            // 
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(152, 22);
            this.browseButton.Text = "Browse";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAToolStripMenuItem,
            this.rijndaelToolStripMenuItem});
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(152, 22);
            this.decryptButton.Text = "Decrypt";
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // rijndaelToolStripMenuItem
            // 
            this.rijndaelToolStripMenuItem.Name = "rijndaelToolStripMenuItem";
            this.rijndaelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rijndaelToolStripMenuItem.Text = "Rijndael";
            this.rijndaelToolStripMenuItem.Click += new System.EventHandler(this.rijndaelToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // newButton
            // 
            this.newButton.Image = global::MailClient.Properties.Resources.mail_light_new_2;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(59, 23);
            this.newButton.Text = "&New";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // replyButton
            // 
            this.replyButton.Enabled = false;
            this.replyButton.Image = global::MailClient.Properties.Resources.mail_light_left;
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(64, 23);
            this.replyButton.Text = "&Reply";
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Enabled = false;
            this.forwardButton.Image = global::MailClient.Properties.Resources.mail_light_right;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(78, 23);
            this.forwardButton.Text = "&Forward";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // updateButton
            // 
            this.updateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMailsToolStripMenuItem,
            this.updateMailsToolStripMenuItem});
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 20);
            this.updateButton.Text = "Send / Receive";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // sendMailsToolStripMenuItem
            // 
            this.sendMailsToolStripMenuItem.Name = "sendMailsToolStripMenuItem";
            this.sendMailsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sendMailsToolStripMenuItem.Text = "Send mails";
            // 
            // updateMailsToolStripMenuItem
            // 
            this.updateMailsToolStripMenuItem.Name = "updateMailsToolStripMenuItem";
            this.updateMailsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.updateMailsToolStripMenuItem.Text = "Update mails";
            // 
            // paneContainer
            // 
            this.paneContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneContainer.Location = new System.Drawing.Point(0, 27);
            this.paneContainer.Name = "paneContainer";
            this.paneContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // paneContainer.Panel1
            // 
            this.paneContainer.Panel1.Controls.Add(this.mailView);
            // 
            // paneContainer.Panel2
            // 
            this.paneContainer.Panel2.Controls.Add(this.contentView);
            this.paneContainer.Size = new System.Drawing.Size(766, 435);
            this.paneContainer.SplitterDistance = 178;
            this.paneContainer.TabIndex = 8;
            // 
            // mailView
            // 
            this.mailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailView.FullRowSelect = true;
            this.mailView.GridLines = true;
            listViewGroup3.Header = "Outbox";
            listViewGroup3.Name = "listViewGroup2";
            listViewGroup4.Header = "Inbox";
            listViewGroup4.Name = "listViewGroup1";
            this.mailView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.mailView.Location = new System.Drawing.Point(0, 0);
            this.mailView.MultiSelect = false;
            this.mailView.Name = "mailView";
            this.mailView.Size = new System.Drawing.Size(766, 178);
            this.mailView.SmallImageList = this.imageList1;
            this.mailView.TabIndex = 0;
            this.mailView.UseCompatibleStateImageBehavior = false;
            this.mailView.View = System.Windows.Forms.View.Details;
            this.mailView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.mailView_ColumnClick);
            this.mailView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mailView_ItemSelectionChanged);
            this.mailView.SelectedIndexChanged += new System.EventHandler(this.mailView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 261;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 129;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mail_light.png");
            this.imageList1.Images.SetKeyName(1, "mail_light_stuffed.png");
            this.imageList1.Images.SetKeyName(2, "mail_light_up.png");
            // 
            // contentView
            // 
            this.contentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentView.Location = new System.Drawing.Point(0, 0);
            this.contentView.MinimumSize = new System.Drawing.Size(20, 20);
            this.contentView.Name = "contentView";
            this.contentView.Size = new System.Drawing.Size(766, 253);
            this.contentView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 484);
            this.Controls.Add(this.paneContainer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Kim\'s Mail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paneContainer.Panel1.ResumeLayout(false);
            this.paneContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paneContainer)).EndInit();
            this.paneContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.ComponentModel.BackgroundWorker backgroundUpdater;
        private System.ComponentModel.BackgroundWorker backgroundSender;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem newButton;
        private System.Windows.Forms.ToolStripMenuItem replyButton;
        private System.Windows.Forms.ToolStripMenuItem forwardButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSplitButton updateButton;
        private System.Windows.Forms.ToolStripMenuItem sendMailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMailsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer paneContainer;
        private System.Windows.Forms.ListView mailView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.WebBrowser contentView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptButton;
        private System.Windows.Forms.ToolStripMenuItem browseButton;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rijndaelToolStripMenuItem;

    }
}

