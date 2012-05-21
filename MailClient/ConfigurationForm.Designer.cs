namespace MailClient
{
    partial class ConfigurationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inPort = new System.Windows.Forms.TextBox();
            this.inSSL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inServer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outPort = new System.Windows.Forms.TextBox();
            this.outSSL = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outServer = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inPort);
            this.groupBox1.Controls.Add(this.inSSL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inServer);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incoming server";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Port:";
            // 
            // inPort
            // 
            this.inPort.Location = new System.Drawing.Point(66, 107);
            this.inPort.Name = "inPort";
            this.inPort.Size = new System.Drawing.Size(156, 20);
            this.inPort.TabIndex = 7;
            // 
            // inSSL
            // 
            this.inSSL.AutoSize = true;
            this.inSSL.Checked = true;
            this.inSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inSSL.Location = new System.Drawing.Point(228, 110);
            this.inSSL.Name = "inSSL";
            this.inSSL.Size = new System.Drawing.Size(68, 17);
            this.inSSL.TabIndex = 6;
            this.inSSL.Text = "Use SSL";
            this.inSSL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // inPass
            // 
            this.inPass.Location = new System.Drawing.Point(66, 81);
            this.inPass.Name = "inPass";
            this.inPass.PasswordChar = '#';
            this.inPass.Size = new System.Drawing.Size(230, 20);
            this.inPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // inUser
            // 
            this.inUser.Location = new System.Drawing.Point(66, 55);
            this.inUser.Name = "inUser";
            this.inUser.Size = new System.Drawing.Size(230, 20);
            this.inUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // inServer
            // 
            this.inServer.Location = new System.Drawing.Point(66, 28);
            this.inServer.Name = "inServer";
            this.inServer.Size = new System.Drawing.Size(230, 20);
            this.inServer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.outPort);
            this.groupBox2.Controls.Add(this.outSSL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.outPass);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.outUser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.outServer);
            this.groupBox2.Location = new System.Drawing.Point(10, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outgoing server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Port:";
            // 
            // outPort
            // 
            this.outPort.Location = new System.Drawing.Point(74, 98);
            this.outPort.Name = "outPort";
            this.outPort.Size = new System.Drawing.Size(156, 20);
            this.outPort.TabIndex = 14;
            // 
            // outSSL
            // 
            this.outSSL.AutoSize = true;
            this.outSSL.Checked = true;
            this.outSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outSSL.Location = new System.Drawing.Point(236, 101);
            this.outSSL.Name = "outSSL";
            this.outSSL.Size = new System.Drawing.Size(68, 17);
            this.outSSL.TabIndex = 13;
            this.outSSL.Text = "Use SSL";
            this.outSSL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // outPass
            // 
            this.outPass.Location = new System.Drawing.Point(74, 72);
            this.outPass.Name = "outPass";
            this.outPass.PasswordChar = '#';
            this.outPass.Size = new System.Drawing.Size(230, 20);
            this.outPass.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // outUser
            // 
            this.outUser.Location = new System.Drawing.Point(74, 46);
            this.outUser.Name = "outUser";
            this.outUser.Size = new System.Drawing.Size(230, 20);
            this.outUser.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Server:";
            // 
            // outServer
            // 
            this.outServer.Location = new System.Drawing.Point(74, 19);
            this.outServer.Name = "outServer";
            this.outServer.Size = new System.Drawing.Size(230, 20);
            this.outServer.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(254, 298);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 329);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox inSSL;
        private System.Windows.Forms.CheckBox outSSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outServer;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outPort;
    }
}