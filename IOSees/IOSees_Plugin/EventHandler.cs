using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Plugin
{
    public class EventHandler
    {
        public static void DebugMessageHandler(string msg)
        {
            
        }

        public static void DebugVerboseMessageHandler(string msg)
        {
            
        }

        public static void ClientApproveHandler(NetClient client, NetBuffer buffer)
        {
            
        }

        public static void StatusChangeHandler(NetClient client, NetBuffer buffer)
        {
            string status_msg = buffer.ReadString();
            NetConnectionStatus status = (NetConnectionStatus)buffer.ReadByte();
            
            if (status == NetConnectionStatus.Connected)
            {
                Console.WriteLine("Plugin: Connected");
            }

            if (status == NetConnectionStatus.Disconnected)
            {
                Console.WriteLine("Plugin: Disconnected");
            }
        }

        public static void DataHandler(NetClient client, NetBuffer buffer)
        {
            Console.WriteLine("Plugin: Data recieved");
            Console.WriteLine("Data: " + buffer.ReadString());
        }

        public static void ServerDiscoveredHandler(NetClient client, NetBuffer buffer)
        {
            System.Net.IPEndPoint buffer_copier = buffer.ReadIPEndPoint();

            //Just connect to the first server we find
            Console.WriteLine("Plugin: Connecting to server: " + buffer_copier.ToString());

            //Let server know the type of IOS client connecting
            NetBuffer buf = client.CreateBuffer();
            buf.Write("Plugin");

            //Connect
            client.Connect(buffer_copier, buf.ToArray());
        }

        public static void ConnectionRejectedHandler(NetClient client, NetBuffer buffer)
        {
            Console.WriteLine("Client rejected");
        }
    }
}
