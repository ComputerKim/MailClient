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
            this.Icon = Properties.Resources.mail;
        }

        public string getInServer()
        {
            return inServer.Text;
        }

        public string getInUser()
        {
            switch (accSelecter.Text)
            {
                case "Gmail":
                case "Hotmail":
                    return accUser.Text;
                case "Other":
                    return inUser.Text;
                default:
                    return "";
            }
        }

        public string getInPass()
        {
            switch (accSelecter.Text)
            {
                case "Gmail":
                case "Hotmail":
                    return accPass.Text;
                case "Other":
                    return inPass.Text;
                default:
                    return "";
            }
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
            switch (accSelecter.Text)
            {
                case "Gmail":
                case "Hotmail":
                    return accUser.Text;
                case "Other":
                    return outUser.Text;
                default:
                    return "";
            }
        }

        public string getOutPass()
        {
            switch (accSelecter.Text)
            {
                case "Gmail":
                case "Hotmail":
                    return accPass.Text;
                case "Other":
                    return outPass.Text;
                default:
                    return "";
            }
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
            accSelecter.SelectedItem = accSelecter.Items[0];
            
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (accSelecter.Text)
                {
                    case "Gmail":
                    case "Hotmail":
                        Properties.Settings.Default.outUser = accUser.Text;
                        Properties.Settings.Default.inUser = accUser.Text;
                        Properties.Settings.Default.outPass = accPass.Text;
                        Properties.Settings.Default.inPass = accPass.Text;
                        break;
                    case "Other":
                        Properties.Settings.Default.outUser = outUser.Text;
                        Properties.Settings.Default.outPass = outPass.Text;
                        Properties.Settings.Default.inUser = inUser.Text;
                        Properties.Settings.Default.inPass = inPass.Text;
                        break;
                    default:
                        MessageBox.Show("Please select an account.");
                        return;
                }

                Properties.Settings.Default.inServer = inServer.Text;
                Properties.Settings.Default.inPort = int.Parse(inPort.Text);
                Properties.Settings.Default.inSSL = inSSL.Checked;

                Properties.Settings.Default.outServer = outServer.Text;
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

        private void accountSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (accSelecter.Text)
            {
                case "Select account...":
                    inGroupBox.Visible = false;
                    outGroupBox.Visible = false;
                    accGroupBox.Visible = false;
                    break;
                case "Gmail":
                    inGroupBox.Visible = false;
                    outGroupBox.Visible = false;
                    accGroupBox.Visible = true;

                    accUser.Text = "@gmail.com";
                    inServer.Text = "pop.gmail.com";
                    inPort.Text = "995";
                    inSSL.Checked = true;
                    outServer.Text = "smtp.gmail.com";
                    outPort.Text = "25";
                    outSSL.Checked = true;
                    break;
                case "Hotmail":
                    inGroupBox.Visible = false;
                    outGroupBox.Visible = false;
                    accGroupBox.Visible = true;

                    accUser.Text = "@hotmail.com";
                    inServer.Text = "pop3.live.com";
                    inPort.Text = "995";
                    inSSL.Checked = true;
                    outServer.Text = "smtp.live.com";
                    outPort.Text = "25";
                    outSSL.Checked = true;
                    break;
                case "Other":
                    inGroupBox.Visible = true;
                    outGroupBox.Visible = true;
                    accGroupBox.Visible = false;
                    break;
            }

        }
    }
}
