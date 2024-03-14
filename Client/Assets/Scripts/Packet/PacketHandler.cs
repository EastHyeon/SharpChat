using DummyClient;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

class PacketHandler
{
    internal static void S_ChatHandler(PacketSession session, IPacket packet)
    {
        S_Chat chatPacket = packet as S_Chat;
        ServerSession serverSession = session as ServerSession;
        //Console.WriteLine($"[{chatPacket.username}]: {chatPacket.chat}");

        Debug.Log($"{chatPacket.username}: {chatPacket.chat}");

        GameObject go = GameObject.Find("Player");
        if (go == null)
            Debug.Log("Player not founded");
        else
            Debug.Log("Player founded");
    }
}
