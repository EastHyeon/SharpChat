using DummyClient;
using ServerCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    ServerSession _session = new ServerSession();
    // Start is called before the first frame update

    public void Send(ArraySegment<byte> sendBuffer)
    {
        _session.Send(sendBuffer);
    }

    void Start()
    {
        // DNS (Domain Name System)
        string hostname = Dns.GetHostName();
        IPHostEntry entry = Dns.GetHostEntry(hostname);
        IPAddress ipAddr = entry.AddressList[1];
        IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

        Connector connector = new Connector();

        connector.Connect(
            endPoint,
            () => { return _session; },
            1);
    }

    // Update is called once per frame
    void Update()
    {
        List<IPacket> list = PacketQueue.Instance.PopAll();
        foreach (IPacket packet in list)
            PacketManager.Instance.HandlePacket(_session, packet);
    }
}
