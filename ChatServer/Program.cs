using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Программа запущена");

			IPHostEntry host1 = Dns.GetHostEntry("google.ru");
			Console.WriteLine(host1.HostName);
			foreach (IPAddress ip in host1.AddressList)
				Console.WriteLine(ip.ToString());
			
			Console.ReadKey();
		}
	}
}
