using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeEvents();
        }



        private void InitializeData()
        {
            var random = new Random();
            int x = random.Next() % 1000;
            NameBox.Text = "user" + x;
            IpBox.Text = "127.0.0.1";
            PortBox.Text = "7899";
            SendMessageBox.Text = "Hello";
            var toolTip = new ToolTip();
            toolTip.SetToolTip(SendMessageButton, "Доступна клавиша Enter");
        }



        private void InitializeEvents()
        {
            this.ConnectButton.Click += (object sender, EventArgs e) =>
            {
                // <---- Connecting this
                MessagesBox.Items.Add("Connected to " + IpBox.Text);
                ConnectButton.Visible = false;
                DisconnectButton.Visible = true;
                IpBox.Enabled = false;
                PortBox.Enabled = false;
                NameBox.Enabled = false;
                SendMessageButton.Enabled = true;
            };

            this.DisconnectButton.Click += (sender, e) =>
            {
                // <---- Disconnecting this
                MessagesBox.Items.Add("Disconnected.");
                DisconnectButton.Visible = false;
                ConnectButton.Visible = true;
                NameBox.Enabled = true;
                IpBox.Enabled = true;
                PortBox.Enabled = true;
                SendMessageButton.Enabled = false;
            };

            this.SendMessageButton.Click += (sender, e) =>
            {
                // <---- Send message this (1/2)
                MessagesBox.Items.Add(NameBox.Text + ": " + SendMessageBox.Text); // <---- delete this
                SendMessageBox.Text = "";
                SendMessageBox.Select();
            };

            this.SendMessageBox.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    if (SendMessageButton.Enabled)
                    {
                        // <---- Send message this (2/2)            
                        MessagesBox.Items.Add(NameBox.Text + ": " + SendMessageBox.Text); // <---- delete this
                        SendMessageBox.Text = "";
                    }
                }
            };
        }
    }
}
