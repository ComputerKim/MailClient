namespace MailClient
{
    partial class MailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.CheckBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.recipientsTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.encryptionKey);
            this.panel1.Controls.Add(this.encrypt);
            this.panel1.Controls.Add(this.subjectTextbox);
            this.panel1.Controls.Add(this.recipientsTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 81);
            this.panel1.TabIndex = 0;
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(155, 57);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(421, 20);
            this.encryptionKey.TabIndex = 6;
            this.encryptionKey.Text = "Encryption key (has to be 16, 24 or 32 chars)";
            this.encryptionKey.Visible = false;
            // 
            // encrypt
            // 
            this.encrypt.AutoSize = true;
            this.encrypt.Location = new System.Drawing.Point(87, 59);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(62, 17);
            this.encrypt.TabIndex = 5;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.CheckedChanged += new System.EventHandler(this.encrypt_CheckedChanged);
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(136, 31);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(440, 20);
            this.subjectTextbox.TabIndex = 4;
            // 
            // recipientsTextbox
            // 
            this.recipientsTextbox.Location = new System.Drawing.Point(136, 6);
            this.recipientsTextbox.Name = "recipientsTextbox";
            this.recipientsTextbox.Size = new System.Drawing.Size(440, 20);
            this.recipientsTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(3, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 75);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextbox
            // 
            this.messageTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextbox.Location = new System.Drawing.Point(0, 81);
            this.messageTextbox.Multiline = true;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Size = new System.Drawing.Size(588, 305);
            this.messageTextbox.TabIndex = 1;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 386);
            this.Controls.Add(this.messageTextbox);
            this.Controls.Add(this.panel1);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.TextBox recipientsTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextbox;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.CheckBox encrypt;
    }
}