using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace MailClient
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.mail;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (recipientsTextbox.Text == "" | subjectTextbox.Text == "" | messageTextbox.Text == "")
            {
                MessageBox.Show(this,"Something is missing","Ops",MessageBoxButtons.OK);
            }
            else
            {
                if (rijndaelToolStripMenuItem.Checked)
                {
                    if (encryptionKey.Text.Length == 16 | encryptionKey.Text.Length == 24 | encryptionKey.Text.Length == 32)
                    {
                        messageTextbox.Text = Convert.ToBase64String(Encryption.EncryptStringToBytes(messageTextbox.Text, Encoding.ASCII.GetBytes(encryptionKey.Text), Encoding.ASCII.GetBytes("1234567890123456")));
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Encryption key has to be 16, 24 or 32 chars in length.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rSAToolStripMenuItem.Checked)
                {
                    try {
                        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                        RSA.FromXmlString(encryptionKey.Text);
                        messageTextbox.Text = Convert.ToBase64String(RSA.Encrypt(Encoding.Unicode.GetBytes(messageTextbox.Text), false));
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        public string getRecipients()
        {
            return recipientsTextbox.Text;
        }

        public string getSubject()
        {
            return subjectTextbox.Text;
        }

        public string getMessage()
        {
            return messageTextbox.Text;
        }

        public void setRecipients(string str)
        {
            recipientsTextbox.Text = str;
        }

        public void setSubject(string str)
        {
            subjectTextbox.Text = str;
        }

        private void MailForm_Load(object sender, EventArgs e)
        {

        }

        private void rijndaelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptionKey.Visible = true;
            encryptionLabel.Visible = true;
            foreach (ToolStripMenuItem item in encryptToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            rijndaelToolStripMenuItem.Checked = true;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptionKey.Visible = false;
            encryptionLabel.Visible = false;
            foreach (ToolStripMenuItem item in encryptToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            noneToolStripMenuItem.Checked = true;
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptionKey.Visible = true;
            encryptionLabel.Visible = true;
            foreach (ToolStripMenuItem item in encryptToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            rSAToolStripMenuItem.Checked = true;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "Name")
            {
                toolStripTextBox1.Text = "";
            }
        }

        private void oKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            File.WriteAllText(Application.UserAppDataPath + "\\RSA\\" + toolStripTextBox1.Text + ".xml", RSA.ToXmlString(true));
            messageTextbox.Text += "Here's your rsa public key: " + RSA.ToXmlString(false);
        }
    }
}
