using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
	class Program
	{
        static void Main(string[] args)
		{
            var server = new ChatServer();
            var listenThread = new Thread(new ThreadStart(server.Listen));
            listenThread.Start();
		}
	}
}
