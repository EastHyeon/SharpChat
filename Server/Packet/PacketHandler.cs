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

        if (clientSession.Room == null)
            return;

        GameRoom room = clientSession.Room;
        room.Push(
            () => clientSession.Room.BroadCast(clientSession, chatPacket.username, chatPacket.chat)
        );

        //Console.WriteLine($"{chatPacket.username}/{clientSession.SessionID}: {chatPacket.chat}");
    }
}
