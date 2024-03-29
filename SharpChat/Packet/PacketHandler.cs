﻿using SharpChat;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Text;

class PacketHandler
{
    public static event StrAddHandler itemStr;
    internal static void S_ChatHandler(PacketSession session, IPacket packet)
    {
        S_Chat chatPacket = packet as S_Chat;
        ServerSession serverSession = session as ServerSession;
        Console.WriteLine($"[{chatPacket.username}]: {chatPacket.chat}");
        itemStr($"[{chatPacket.username}]: {chatPacket.chat}");
    }
}
