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
        public List<Connection> Connections;



        public ChatServer ()
        {
            Connections = new List<Connection>();
        }



        public void Listen()
        {
            var tcpListener = new TcpListener(IPAddress.Any, DefaultPort);
            tcpListener.Start();
            Console.WriteLine("Server is started. Listening...");

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            var connection = new Connection(tcpClient, this);
            Thread connectionThread = new Thread(new ThreadStart(connection.Process));
            connectionThread.Start();          
        }



        public void BroadcastMessage(String message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            Parallel.For(0, Connections.Count, i =>
            {
                Connections[i].Stream.Write(data, 0, data.Length);
            });                   
        }
    }
}
