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
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try 
            {
                Properties.Settings.Default.inServer = inServer.Text;
                Properties.Settings.Default.inUser = inUser.Text;
                Properties.Settings.Default.inPass = inPass.Text;
                Properties.Settings.Default.inPort = int.Parse(inPort.Text);
                Properties.Settings.Default.inSSL = inSSL.Checked;

                Properties.Settings.Default.outServer = outServer.Text;
                Properties.Settings.Default.outUser = outUser.Text;
                Properties.Settings.Default.outPass = outPass.Text;
                Properties.Settings.Default.outPort = int.Parse(outPort.Text);
                Properties.Settings.Default.outSSL = outSSL.Checked;

                Properties.Settings.Default.Save();
                
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save configuration.");    
            }
        }

        public string getInServer()
        {
            return inServer.Text;
        }

        public string getInUser()
        {
            return inUser.Text;
        }

        public string getInPass()
        {
            return inPass.Text;
        }

        public string getInPort()
        {
            return inPort.Text;
        }

        public bool getInSSL()
        {
            return inSSL.Checked;
        }

        public string getOutServer()
        {
            return outServer.Text;
        }

        public string getOutUser()
        {
            return outUser.Text;
        }

        public string getOutPass()
        {
            return outPass.Text;
        }

        public string getOutPort()
        {
            return outPort.Text;
        }

        public bool getOutSSL()
        {
            return outSSL.Checked;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            inServer.Text = Properties.Settings.Default.inServer;
            inUser.Text = Properties.Settings.Default.inUser;
            inPass.Text = Properties.Settings.Default.inPass;
            inPort.Text = Properties.Settings.Default.inPort.ToString();
            inSSL.Checked = Properties.Settings.Default.inSSL;

            outServer.Text = Properties.Settings.Default.outServer;
            outUser.Text = Properties.Settings.Default.outUser;
            outPass.Text = Properties.Settings.Default.outPass;
            outPort.Text = Properties.Settings.Default.outPort.ToString();
            outSSL.Checked = Properties.Settings.Default.outSSL;
        }
    }
}
