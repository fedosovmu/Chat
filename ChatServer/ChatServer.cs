using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    class ChatServer
    {
        public static readonly int DefaultPort = 703;

        public ChatServer()
        {         

        }

        public void Listen()
        {
            var tcpListener = new TcpListener(IPAddress.Any, 8888);
            tcpListener.Start();
            Console.WriteLine("Server is started. Listening...");

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            //var connectedClient = new ConnectedClient(tcpClient, this);
            //Thread clientThread = new Thread(new ThreadStart(connectedClient.Process));
            //clientThread.Start();
        }

        public void BroadcastMessage(string message, string id)
        {

        }
    }
}
