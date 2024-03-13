﻿using System;
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

		static void Main(string[] args)
		{
			// DNS (Domain Name System)
			IPAddress ipAddr = IPAddress.Parse("220.76.143.34");
			IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);


			_listener.Init(endPoint, () => { return SessionManager.Instance.Generate(); });
			Console.WriteLine("Listening...");
			
			while (true)
			{
				
				Room.Push(() => Room.Execute());
				Thread.Sleep(250);
			}
		}
	}
}
