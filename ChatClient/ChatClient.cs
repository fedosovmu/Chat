using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public class ChatClient
    {
        public static readonly int DefaultPort = 703;
        public event Action<string> Connected;
        public event Action<string> ConnectedError;
        public event Action<string> MessageRecived;
        public event Action MessageSended;
        public event Action Disconnected;
        public event Action<string> ParticipantConnected;
        public event Action<string> ParticipantDisconnected;

        public NetworkStream Stream;
        public String Name;
        public String Host;
        public int Port;
        private TcpClient _tcpClient;

        public ChatClient()
        {
            _tcpClient = new TcpClient();
        }



        public void Connect(String name, String ip, int port)
        {
            _tcpClient = new TcpClient();
            Name = name;
            Host = ip;
            Port = port;
            try
            {
                _tcpClient.Connect(Host, Port);
                Stream = _tcpClient.GetStream();

                string message = Name;
                byte[] data = Encoding.Unicode.GetBytes(message);
                Stream.Write(data, 0, data.Length);

                Connected(Host + " : " + Port);
            }
            catch (Exception ex)
            {
                ConnectedError(Host + " : " + Port);
            }
        }



        public void ReceiveMessage()
        {
            var client = new ChatClient();

            while (true)
            {
                try
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = Stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (Stream.DataAvailable);

                    var informaton = (builder.ToString()).Split('#');
                    String command = informaton[0];

                    if (command == "connect")
                    {
                        ParticipantConnected(informaton[1]);
                    }
                    else if (command == "disconnect")
                    {
                        ParticipantDisconnected(informaton[1]);
                    }
                    else if (command == "say")
                    {
                        MessageRecived(informaton[1]);
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
        }



        public void Disconnect()
        {
            Disconnected();
        }



        public void SendMessage(String message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            Stream.Write(data, 0, data.Length);
            MessageSended();
        }
    }
}
