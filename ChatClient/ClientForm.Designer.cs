﻿namespace ChatClient
{
    partial class ClientForm
    {
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.ipLable = new System.Windows.Forms.Label();
            this.portLable = new System.Windows.Forms.Label();
            this.SendMessageBox = new System.Windows.Forms.TextBox();
            this.MessagesBox = new System.Windows.Forms.ListBox();
            this.UsersBox = new System.Windows.Forms.ListBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.nameLable = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(426, 88);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(155, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Enabled = false;
            this.SendMessageButton.Location = new System.Drawing.Point(12, 493);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.SendMessageButton.TabIndex = 1;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(426, 39);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(155, 20);
            this.IpBox.TabIndex = 2;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(426, 62);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(155, 20);
            this.PortBox.TabIndex = 3;
            // 
            // ipLable
            // 
            this.ipLable.AutoSize = true;
            this.ipLable.Location = new System.Drawing.Point(395, 39);
            this.ipLable.Name = "ipLable";
            this.ipLable.Size = new System.Drawing.Size(15, 13);
            this.ipLable.TabIndex = 4;
            this.ipLable.Text = "ip";
            // 
            // portLable
            // 
            this.portLable.AutoSize = true;
            this.portLable.Location = new System.Drawing.Point(395, 64);
            this.portLable.Name = "portLable";
            this.portLable.Size = new System.Drawing.Size(25, 13);
            this.portLable.TabIndex = 5;
            this.portLable.Text = "port";
            // 
            // SendMessageBox
            // 
            this.SendMessageBox.Location = new System.Drawing.Point(93, 495);
            this.SendMessageBox.Name = "SendMessageBox";
            this.SendMessageBox.Size = new System.Drawing.Size(493, 20);
            this.SendMessageBox.TabIndex = 6;
            // 
            // MessagesBox
            // 
            this.MessagesBox.FormattingEnabled = true;
            this.MessagesBox.Location = new System.Drawing.Point(12, 15);
            this.MessagesBox.Name = "MessagesBox";
            this.MessagesBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.MessagesBox.Size = new System.Drawing.Size(377, 472);
            this.MessagesBox.TabIndex = 7;
            // 
            // UsersBox
            // 
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(395, 119);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UsersBox.Size = new System.Drawing.Size(191, 368);
            this.UsersBox.TabIndex = 8;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(426, 88);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(155, 23);
            this.DisconnectButton.TabIndex = 9;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Visible = false;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(392, 18);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(35, 13);
            this.nameLable.TabIndex = 10;
            this.nameLable.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(426, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(155, 20);
            this.NameBox.TabIndex = 11;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 519);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.MessagesBox);
            this.Controls.Add(this.SendMessageBox);
            this.Controls.Add(this.portLable);
            this.Controls.Add(this.ipLable);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IpBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.ConnectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label ipLable;
        private System.Windows.Forms.Label portLable;
        public System.Windows.Forms.Button ConnectButton;
        public System.Windows.Forms.Button SendMessageButton;
        public System.Windows.Forms.TextBox IpBox;
        public System.Windows.Forms.TextBox PortBox;
        public System.Windows.Forms.TextBox SendMessageBox;
        public System.Windows.Forms.ListBox MessagesBox;
        public System.Windows.Forms.ListBox UsersBox;
        public System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label nameLable;
        public System.Windows.Forms.TextBox NameBox;
    }
}