using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using OpenPop.Pop3.Exceptions;
using OpenPop.Common.Logging;
using Message = OpenPop.Mime.Message;
using System.Net.Mail;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace MailClient
{
    struct oMessage
    {
        public oMessage(string r, string s, string b,ListViewItem l)
        {
            recipients = r;
            subject = s;
            body = b;
            listItem = l;
        }

        public string recipients;
        public string subject;
        public string body;
        public ListViewItem listItem;
    }


    public partial class MainForm : Form
    {
        Dictionary<string, Message> messages = new Dictionary<string, Message>();
        Pop3Client pop3Client;
        SmtpClient smtpClient;
        List<oMessage> outbox = new List<oMessage>();

        string inServer, inUser, inPass, outServer, outUser, outPass;
        int inPort, outPort;
        bool inSSL, outSSL, loadSaved = true;

        string result;

        private Comparer.ListViewColumnSorter lvwColumnSorter;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.mail;

            pop3Client = new Pop3Client();

            lvwColumnSorter = new Comparer.ListViewColumnSorter();
            this.mailView.ListViewItemSorter = lvwColumnSorter;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Application.UserAppDataPath + "\\Inbox"))
            {
                System.IO.Directory.CreateDirectory(Application.UserAppDataPath + "\\Inbox");
            }

            if (!System.IO.Directory.Exists(Application.UserAppDataPath + "\\Outbox"))
            {
                System.IO.Directory.CreateDirectory(Application.UserAppDataPath + "\\Outbox");
            }

            if (Properties.Settings.Default.inServer != "" | Properties.Settings.Default.outServer != "")
            {
                inServer = Properties.Settings.Default.inServer;
                inUser = Properties.Settings.Default.inUser;
                inPass = Properties.Settings.Default.inPass;
                inPort = Properties.Settings.Default.inPort;
                inSSL = Properties.Settings.Default.inSSL;

                outServer = Properties.Settings.Default.outServer;
                outUser = Properties.Settings.Default.outUser;
                outPass = Properties.Settings.Default.outPass;
                outPort = Properties.Settings.Default.outPort;
                outSSL = Properties.Settings.Default.outSSL;

                paneContainer.Orientation = Properties.Settings.Default.paneOrientation;

                backgroundUpdater.RunWorkerAsync();
            }
        }

        private void configurationButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm confForm = new ConfigurationForm();

            if (confForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Get incoming server settings
                inServer = confForm.getInServer();
                inUser = confForm.getInUser();
                inPass = confForm.getInPass();
                inPort = int.Parse(confForm.getInPort());
                inSSL = confForm.getInSSL();

                // Get outgoing server settings
                outServer = confForm.getOutServer();
                outUser = confForm.getOutUser();
                outPass = confForm.getOutPass();
                outPort = int.Parse(confForm.getOutPort());
                outSSL = confForm.getOutSSL();

                // Create smtp client
                smtpClient = new SmtpClient();
                smtpClient.Host = outServer;
                smtpClient.Port = outPort;
                smtpClient.Credentials = new System.Net.NetworkCredential(outUser, outPass);
                smtpClient.EnableSsl = outSSL;

                // Receive mails
                backgroundUpdater.RunWorkerAsync();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            SendMail("","");
        }

        private void mailView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Group == mailView.Groups[1])
            {
                Message message = messages[e.Item.Tag.ToString()];

                if (message.FindFirstHtmlVersion() == null)
                {
                    contentView.DocumentText = message.FindFirstPlainTextVersion().GetBodyAsText().Replace("\n", "<br />");
                }
                else
                {
                    contentView.DocumentText = message.FindFirstHtmlVersion().GetBodyAsText();
                }
            }
            if (e.Item.Font.Bold)
            {
                e.Item.Font = new Font(e.Item.Font, FontStyle.Regular);
            }
        }

        delegate void AddMailToViewDelegate(ListViewItem item);
        void AddMailToView(ListViewItem item)
        {
            if (mailView.InvokeRequired)
            {
                mailView.Invoke(new AddMailToViewDelegate(AddMailToView), new object[] { item });
            }
            else
            {
                mailView.Items.Add(item);
            }
        }

        delegate void ClearMailsDelegate();
        void ClearMails()
        {
            if (mailView.InvokeRequired)
            {
                mailView.Invoke(new ClearMailsDelegate(ClearMails), new object[] { });
            }
            else
            {
                messages.Clear();
                mailView.Items.Clear();
            }
        }

        private void mailView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mailView.SelectedItems.Count == 0)
            {
                replyButton.Enabled = false;
                forwardButton.Enabled = false;
            }
            else
            {
                replyButton.Enabled = true;
                forwardButton.Enabled = true;
            }
        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            SendMail(mailView.SelectedItems[0].Text, "Re: " + mailView.SelectedItems[0].SubItems[1].Text);
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            SendMail("", "Fw: " + mailView.SelectedItems[0].SubItems[1].Text);
        }


        private void backgroundUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                statusLabel.Text = result;
                toolStripProgressBar1.Visible = false;
            }
            catch (Exception)
            { }
        }

        private void backgroundUpdater_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                ShowProgressbar();

                Message message;

                if (loadSaved)
                {
                    statusLabel.Text = "Loading mails...";
                    foreach (string file in Directory.EnumerateFiles(Application.UserAppDataPath + "\\Inbox","*.eml"))
                    {
                        if (backgroundUpdater.CancellationPending)
                        {
                            return;
                        }
                        
                        message = Message.Load(new FileInfo(file));

                        if (!messages.ContainsKey(message.Headers.MessageId))
                        {
                            AddMessage(message,false,1);
                        }
                    }
                    loadSaved = false;
                }

                // if connected, then disconnect
                if (pop3Client.Connected)
                    pop3Client.Disconnect();

                // Connect & Authenticate
                pop3Client.Connect(inServer, inPort, inSSL);
                pop3Client.Authenticate(inUser, inPass);

                // Get number of messages
                int count = pop3Client.GetMessageCount();
                statusLabel.Text = "Total messages: " + count.ToString();

                int success = 0;
                int fail = 0;
                for (int i = count; i >= 1; i -= 1)
                {
                    if (backgroundUpdater.CancellationPending)
                    {
                        return;
                    }
                    
                    if (!messages.ContainsKey(pop3Client.GetMessageHeaders(i).MessageId))
                    {
                        message = pop3Client.GetMessage(i);
                        AddMessage(message,true,1);
                    }
                    success++;

                    statusLabel.Text = "Checking " + (count-i) + " of " + count + " mails.";
                    backgroundUpdater.ReportProgress(100 - 100 / count * i);
                }
                result = DateTime.Now.ToString() + " - success!";
            }
            catch (InvalidLoginException)
            {
                result = "The server did not accept the user credentials!";
            }
            catch (PopServerNotFoundException)
            {
                result = "The server could not be found";
            }
            catch (PopServerLockedException)
            {
                result = "The mailbox is locked. It might be in use or under maintenance. Are you connected elsewhere?";
            }
            catch (LoginDelayException)
            {
                result = "Login not allowed. Server enforces delay between logins. Have you connected recently?";
            }
            catch (Exception err)
            {
                result = "Error occurred retrieving mail. " + err.Message;
            }

            if (pop3Client.Connected)
                pop3Client.Disconnect();
        }

        private void backgroundUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = e.ProgressPercentage;
            }
            catch (Exception)
            {
            }
        }

        void SendMail(string recipients, string subject)
        {
            if (outServer != null)
            {
                MailForm mailForm = new MailForm();

                mailForm.setRecipients(recipients);
                mailForm.setSubject(subject);

                if (mailForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ListViewItem itemPointer = mailView.Items.Add(mailForm.getRecipients());
                    itemPointer.SubItems.Add(mailForm.getSubject());
                    itemPointer.Group = mailView.Groups[0];

                    outbox.Add(new oMessage(mailForm.getRecipients(), mailForm.getSubject(), mailForm.getMessage(), itemPointer));

                    backgroundSender.RunWorkerAsync();
                }
            }
        }

        private void backgroundSender_DoWork(object sender, DoWorkEventArgs e)
        {
            if (outbox.Count != 0)
            {
                int max = outbox.Count-1;
                for (int i = max; i>=0; i--)
                {
                    //Create message
                    MailMessage message = new MailMessage(
                        outUser,
                        outbox[i].recipients,
                        outbox[i].subject,
                        outbox[i].body
                        );
                    message.IsBodyHtml = false;

                    // Send message
                    try
                    {
                        smtpClient.Send(message);
                        DeleteMail(outbox[i].listItem);
                        outbox.RemoveAt(i);
                    }
                    catch (Exception err)
                    {

                    }
                }
            }
        }


        delegate void DeleteMailDelegate(ListViewItem item);
        void DeleteMail(ListViewItem item)
        {
            if (mailView.InvokeRequired)
            {
                mailView.Invoke(new DeleteMailDelegate(DeleteMail), new object[] { item });
            }
            else
            {
                item.Remove();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundUpdater.CancelAsync();
            //backgroundSender.CancelAsync();

            Properties.Settings.Default.inServer = inServer;
            Properties.Settings.Default.inUser = inUser;
            Properties.Settings.Default.inPass = inPass;
            Properties.Settings.Default.inPort = inPort;
            Properties.Settings.Default.inSSL = inSSL;

            Properties.Settings.Default.outServer = outServer;
            Properties.Settings.Default.outUser = outUser;
            Properties.Settings.Default.outPass = outPass;
            Properties.Settings.Default.outPort = outPort;
            Properties.Settings.Default.outSSL = outSSL;

            Properties.Settings.Default.paneOrientation = paneContainer.Orientation;

            Properties.Settings.Default.Save();
        }

        void AddMessage(Message message, bool unread, int group)
        {
            // Add the message to the dictionary from the messageNumber to the Message
            messages.Add(message.Headers.MessageId, message);

            ListViewItem newItem = new ListViewItem();

            newItem.Text = message.Headers.From.ToString();
            newItem.SubItems.Add(message.Headers.Subject);
            newItem.SubItems.Add(message.Headers.DateSent.ToString("yyyy-MM-dd HH:mm:ss"));
            newItem.Tag = message.Headers.MessageId;
            newItem.Group = mailView.Groups[group];
            if (unread)
            {
                newItem.Font = new Font(newItem.Font, FontStyle.Bold);
            }

            AddMailToView(newItem);

            if (!File.Exists(Application.UserAppDataPath + "\\Inbox\\" + message.Headers.DateSent.ToString("yyyyMMddHHmmssfffffff") + ".eml"))
            {
                message.Save(new FileInfo(Application.UserAppDataPath + "\\Inbox\\" + message.Headers.DateSent.ToString("yyyyMMddHHmmssfffffff") + ".eml"));
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (inServer != "")
            {
                if (!backgroundUpdater.IsBusy)
                {
                    backgroundUpdater.RunWorkerAsync();
                }
            }
        }

        delegate void ShowProgressbarDelegate();
        void ShowProgressbar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ShowProgressbarDelegate(ShowProgressbar), new object[] { });
            }
            else
            {
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe" ,"\"" + Application.UserAppDataPath + "\\Inbox\"");
        }

        private void mailView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.mailView.Sort();

        }

        private void paneOrientationToggleButton_Click(object sender, EventArgs e)
        {
            if (paneContainer.Orientation == Orientation.Horizontal )
            {
                paneContainer.Orientation = Orientation.Vertical;
            }
                else
            { 
                paneContainer.Orientation = Orientation.Horizontal;
            }
        }

    }
}


