using DummyClient;
using ServerCore;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    ServerSession _session = new ServerSession();
    // Start is called before the first frame update
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
        
    }
}
