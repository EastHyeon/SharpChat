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
            Console.Write("닉네임을 입력하십시오: ");
            string userName = Console.ReadLine();

            // DNS (Domain Name System)
			IPAddress ipAddr = IPAddress.Parse("220.76.143.34");
			IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

			Connector connector = new Connector();

			connector.Connect(endPoint, () => { return SessionManager.Instance.Generate(); });

			while (true)
			{
				try
				{
					SessionManager.Instance.Send(userName, Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
		}
	}
}
