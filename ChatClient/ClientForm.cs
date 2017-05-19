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
        private ChatClient chatClient;

        public ClientForm(ChatClient chatClient)
        {
            this.chatClient = chatClient;
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
            PortBox.Text = ChatClient.DefaultPort.ToString();
            SendMessageBox.Text = "Hello";
            var toolTip = new ToolTip();
            toolTip.SetToolTip(SendMessageButton, "Доступна клавиша Enter");
        }



        private void InitializeEvents()
        {
            this.ConnectButton.Click += (object sender, EventArgs e) =>
            {
                chatClient.Connect(NameBox.Text, IpBox.Text, Convert.ToInt32(PortBox.Text)); // <---- Connecting this
            };

            chatClient.Connected += (endPoint) =>
            {
                MessagesBox.Items.Add("Connected to " + endPoint);
                ConnectButton.Visible = false;
                DisconnectButton.Visible = true;
                IpBox.Enabled = false;
                PortBox.Enabled = false;
                NameBox.Enabled = false;
                SendMessageButton.Enabled = true;
            };

            chatClient.ConnectedError += (endPoint) =>
            {
                MessagesBox.Items.Add("Unsuccessful connection to " + endPoint);
            };

            this.DisconnectButton.Click += (sender, e) =>
            {
                chatClient.Disconnect(); // <---- Disconnecting this
            };

            chatClient.Disconnected += () =>
            {
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
                chatClient.SendMessage(NameBox.Text + ": " + SendMessageBox.Text); // <---- Send message (1/2)
            };

            this.SendMessageBox.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;                   
                    chatClient.SendMessage(NameBox.Text + ": " + SendMessageBox.Text); // <---- Send message (2/2)   
                }
            };

            chatClient.MessageReceived += (text) =>
            {
                MessagesBox.Items.Add(text);
                SendMessageBox.Text = "";
                SendMessageBox.Select();
            };
        }

    }
}
