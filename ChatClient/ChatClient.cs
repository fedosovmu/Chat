using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public class ChatClient
    {
        public event Action<string> Connected;
        public event Action<string> ConnectedError;
        public event Action Disconnected;
        public event Action<string> MessageReceived;
        private TcpClient tcpClient;
        public static readonly int DefaultPort = 703;


        public ChatClient()
        {
            tcpClient = new TcpClient();
        }

        public void Connect(String ip, int port)
        {
            try
            {
                tcpClient.Connect(ip, port);
                Connected(ip + ":" + port);
            }
            catch (SocketException)
            {
                ConnectedError(ip + ":" + port + " ");
            }
        }

        public void Disconnect()
        {
            Disconnected();
        }

        public void SendMessage(String text)
        {
            MessageReceived(text);
        }
    }
}
