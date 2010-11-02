using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lidgren.Network;

namespace IOSees_Server
{
    class SlaveHandler
    {
        public SlaveHandler()
        {
        }

        public static void Process(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            Config config = Config.Instance;

            List<NetConnection> connections = server.Connections;

            //Lets send that message onto any plugin clients
            foreach (NetConnection connection in connections)
            {
                if (config.Server.client_connections.ContainsKey(connection.RemoteEndpoint.ToString()))
                {
                    string client_type = (string)config.Server.client_connections[connection.RemoteEndpoint.ToString()];

                    if (client_type.ToLower() == "plugin")
                    {
                        string msg = buffer.ReadString();

                        Console.WriteLine("Slave: Data sent - " + msg);

                        NetBuffer slavebuf = server.CreateBuffer();

                        slavebuf.Write(msg);

                        server.SendMessage(slavebuf, connection, NetChannel.ReliableInOrder4);
                    }
                }
            }
        }
    }
}
