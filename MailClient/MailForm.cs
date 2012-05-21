using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
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
    }
}
