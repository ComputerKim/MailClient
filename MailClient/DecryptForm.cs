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
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16 | textBox1.Text.Length == 24 | textBox1.Text.Length == 32)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Key has to be 16, 24 or 32 chars in length.","Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getKey()
        {
            return textBox1.Text;
        }
    }
}
