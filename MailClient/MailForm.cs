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
                if (encrypt.Checked)
                {
                    if (encryptionKey.Text.Length == 16 | encryptionKey.Text.Length == 24 | encryptionKey.Text.Length == 32)
                    {
                        messageTextbox.Text = Convert.ToBase64String(Encryption.EncryptStringToBytes(messageTextbox.Text, Encoding.ASCII.GetBytes(encryptionKey.Text), Encoding.ASCII.GetBytes("1234567890123456")));
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Encryption key has to be 16, 24 or 32 chars in length.","Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void encrypt_CheckedChanged(object sender, EventArgs e)
        {
            encryptionKey.Visible = encrypt.Checked;
        }

        private void MailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
