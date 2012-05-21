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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Outbox", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Inbox", System.Windows.Forms.HorizontalAlignment.Left);
            this.panel1 = new System.Windows.Forms.Panel();
            this.browseButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.configurationButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.replyButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.paneContainer = new System.Windows.Forms.SplitContainer();
            this.mailView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentView = new System.Windows.Forms.WebBrowser();
            this.backgroundUpdater = new System.ComponentModel.BackgroundWorker();
            this.backgroundSender = new System.ComponentModel.BackgroundWorker();
            this.paneOrientationToggleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paneContainer)).BeginInit();
            this.paneContainer.Panel1.SuspendLayout();
            this.paneContainer.Panel2.SuspendLayout();
            this.paneContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paneOrientationToggleButton);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.configurationButton);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.replyButton);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 99);
            this.panel1.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(546, 64);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(297, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 75);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Send/Receive";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // configurationButton
            // 
            this.configurationButton.Location = new System.Drawing.Point(627, 12);
            this.configurationButton.Name = "configurationButton";
            this.configurationButton.Size = new System.Drawing.Size(127, 75);
            this.configurationButton.TabIndex = 3;
            this.configurationButton.Text = "Configuration";
            this.configurationButton.UseVisualStyleBackColor = true;
            this.configurationButton.Click += new System.EventHandler(this.configurationButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Enabled = false;
            this.forwardButton.Location = new System.Drawing.Point(174, 12);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 75);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // replyButton
            // 
            this.replyButton.Enabled = false;
            this.replyButton.Location = new System.Drawing.Point(93, 12);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(75, 75);
            this.replyButton.TabIndex = 1;
            this.replyButton.Text = "Reply";
            this.replyButton.UseVisualStyleBackColor = true;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 75);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
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
            // paneContainer
            // 
            this.paneContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneContainer.Location = new System.Drawing.Point(0, 99);
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
            this.paneContainer.Size = new System.Drawing.Size(766, 363);
            this.paneContainer.SplitterDistance = 150;
            this.paneContainer.TabIndex = 4;
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
            listViewGroup1.Header = "Outbox";
            listViewGroup1.Name = "listViewGroup2";
            listViewGroup2.Header = "Inbox";
            listViewGroup2.Name = "listViewGroup1";
            this.mailView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.mailView.Location = new System.Drawing.Point(0, 0);
            this.mailView.MultiSelect = false;
            this.mailView.Name = "mailView";
            this.mailView.Size = new System.Drawing.Size(766, 150);
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
            // contentView
            // 
            this.contentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentView.Location = new System.Drawing.Point(0, 0);
            this.contentView.MinimumSize = new System.Drawing.Size(20, 20);
            this.contentView.Name = "contentView";
            this.contentView.Size = new System.Drawing.Size(766, 209);
            this.contentView.TabIndex = 0;
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
            // paneOrientationToggleButton
            // 
            this.paneOrientationToggleButton.Location = new System.Drawing.Point(423, 64);
            this.paneOrientationToggleButton.Name = "paneOrientationToggleButton";
            this.paneOrientationToggleButton.Size = new System.Drawing.Size(117, 23);
            this.paneOrientationToggleButton.TabIndex = 6;
            this.paneOrientationToggleButton.Text = "Pane orientation";
            this.paneOrientationToggleButton.UseVisualStyleBackColor = true;
            this.paneOrientationToggleButton.Click += new System.EventHandler(this.paneOrientationToggleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 484);
            this.Controls.Add(this.paneContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Kim\'s Mail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.paneContainer.Panel1.ResumeLayout(false);
            this.paneContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paneContainer)).EndInit();
            this.paneContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button configurationButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button replyButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer paneContainer;
        private System.Windows.Forms.ListView mailView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.WebBrowser contentView;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button updateButton;
        private System.ComponentModel.BackgroundWorker backgroundUpdater;
        private System.ComponentModel.BackgroundWorker backgroundSender;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button paneOrientationToggleButton;

    }
}

