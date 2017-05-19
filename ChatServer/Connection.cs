using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Connection
    {
        public NetworkStream Stream;
        public String Name = "";
        private TcpClient _tcpClient;
        private ChatServer _chatServer;

        public Connection(TcpClient tcpClient, ChatServer chatServer)
        {
            this._tcpClient = tcpClient;
            this._chatServer = chatServer;
        }



        public void Process()
        {
            Stream = _tcpClient.GetStream();
            var message = GetMessage();

        }



        private String GetMessage()
        {
            var data = new byte[256];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }
    }
}
