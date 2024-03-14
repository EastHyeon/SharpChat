using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServerCore;

namespace Server
{
    class Program
	{
		static Listener _listener = new Listener();
		public static GameRoom Room = new GameRoom();

		static void ExecuteRoom()
		{
			Room.Push(() => Room.Execute());

			JobTimer.Instance.Push(ExecuteRoom, 250);
		}

		static void Main(string[] args)
		{
			// DNS (Domain Name System)
			string hostname = Dns.GetHostName();
			IPHostEntry entry = Dns.GetHostEntry(hostname);
			IPAddress ipAddr = entry.AddressList[1];
			IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

			_listener.Init(endPoint, () => { return SessionManager.Instance.Generate(); });
			Console.WriteLine("Listening...");

			ExecuteRoom();

            while (true)
			{
				JobTimer.Instance.Execute();
			}
		}
	}
}
