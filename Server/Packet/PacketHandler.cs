using Server;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Text;

class PacketHandler
{
    internal static void C_ChatHandler(PacketSession session, IPacket packet)
    {
        C_Chat chatPacket = packet as C_Chat;
        ClientSession clientSession = session as ClientSession;

        if (clientSession.room == null)
            return;

        Console.WriteLine($"{chatPacket.username}: {chatPacket.chat}");
        clientSession.room.BroadCast(clientSession, chatPacket.username,chatPacket.chat);
    }
}
