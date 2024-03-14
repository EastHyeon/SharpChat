using ServerCore;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DummyClient
{
	

	class Program
	{
		static void Main(string[] args)
		{
            string userName = "test";

            // DNS (Domain Name System)
            string hostname = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostEntry(hostname);
            IPAddress ipAddr = entry.AddressList[1];
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

			Connector connector = new Connector();

			connector.Connect(
				endPoint, 
				() => { return SessionManager.Instance.Generate(); }, 
				500);

			while (true)
			{
				try
				{
					SessionManager.Instance.SendForEach(userName, "");
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}

                Thread.Sleep(250);
            }
		}
	}
}
