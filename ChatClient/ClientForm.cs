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

            this.ConnectButton.Click += (object sender, EventArgs e) =>
            {
                ConnectButton.Visible = false;
                DisconnectButton.Visible = true;
                IpBox.Enabled = false;
                PortBox.Enabled = false;
                NameBox.Enabled = false;
                // <---- Connecting this
                SendMessageButton.Enabled = true;
            };

            this.DisconnectButton.Click += (sender, e) =>
            {
                // <---- Disconnecting this
                DisconnectButton.Visible = false;
                ConnectButton.Visible = true;
                NameBox.Enabled = true;
                IpBox.Enabled = true;
                PortBox.Enabled = true;
                SendMessageButton.Enabled = false;
            };

            this.SendMessageButton.Click += (sender, e) =>
            {
                SendMessageBox.Text = "";
                SendMessageBox.Select();
            };
        }

        private void InitializeData()
        {
            var random = new Random();
            int x = random.Next() % 1000;
            NameBox.Text = "user" + x;
            IpBox.Text = "127.0.0.1";
            PortBox.Text = "7899";
            SendMessageBox.Text = "Hello";

            MessagesBox.
        }
    }
}
