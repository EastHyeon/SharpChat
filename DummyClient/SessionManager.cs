using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyClient
{
    internal class SessionManager
    {
        static SessionManager _instance;
        public static SessionManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SessionManager();
                return _instance;
            }
        }

        List<ServerSession> _sessions = new List<ServerSession>();
        object _lock = new object();

        public ServerSession Generate()
        {
            lock (_lock)
            {
                ServerSession session = new ServerSession();
                _sessions.Add(session);
                return session;
            }
        }

        internal void Send(string name, string msg)
        {
            lock ( _lock)
            {
                foreach (ServerSession session in _sessions)
                {
                    C_Chat chatPacket = new C_Chat();
                    chatPacket.username = name;
                    chatPacket.chat = msg;
                    ArraySegment<byte> data = chatPacket.Write();

                    session.Send(data);
                }
            }
        }
    }
}
