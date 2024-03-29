﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using ServerCore;

namespace SharpChat
{
	public delegate void StrAddHandler(string args);
	class ServerSession : PacketSession
	{
		public static event StrAddHandler itemStr;
		public override void OnConnected(EndPoint endPoint)
		{
			itemStr($"OnConnected : {endPoint}");
		}

		public override void OnDisconnected(EndPoint endPoint)
		{
			Console.WriteLine($"OnDisconnected : {endPoint}");
		}

		public override void OnRecvPacket(ArraySegment<byte> buffer)
		{
			PacketManager.Instance.OnRecvPacket(this, buffer);
		}

		public override void OnSend(int numOfBytes)
		{
			//Console.WriteLine($"Transferred bytes: {numOfBytes}");
		}
	}
}
