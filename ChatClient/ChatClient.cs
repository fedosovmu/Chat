using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public class ChatClient
    {
        public static readonly int DefaultPort = 703;
        public event Action<string> Connected;
        public event Action<string> ConnectedError;
        public event Action<string> MessageReceived;
        public event Action Disconnected;

        public NetworkStream Stream;
        public String Name;
        private TcpClient _tcpClient;

        public ChatClient()
        {
            _tcpClient = new TcpClient();
        }



        public void Connect(String name, String ip, int port)
        {
            
        }



        public void Disconnect()
        {
            
        }



        public void SendMessage(String message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            Stream.Write(data, 0, data.Length);
        }



        public void ReceiveMessage()
        {

        }
    }
}
