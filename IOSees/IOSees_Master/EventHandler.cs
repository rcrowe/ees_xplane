using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Master
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
                Console.WriteLine("Client: Connected");

                Console.Write("Client: Starting IOS");

                int i;
                for (i = 0; i < 10; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                }
                Console.WriteLine("");

                //Show the IOS Master form
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                System.Windows.Forms.Application.Run(new MasterForm());
            }

            if (status == NetConnectionStatus.Disconnected)
            {
                Console.WriteLine("Client: Disconnected - " + status_msg);
            }
        }

        public static void DataHandler(NetClient client, NetBuffer buffer)
        {
            
        }

        public static void ServerDiscoveredHandler(NetClient client, NetBuffer buffer)
        {
            System.Net.IPEndPoint buffer_copier = buffer.ReadIPEndPoint();

            //Just connect to the first server we find
            Console.WriteLine("Client: Connecting to server: " + buffer_copier.ToString());

            //Let server know the type of IOS client connecting
            NetBuffer buf = client.CreateBuffer();
            buf.Write("Master");

            //Connect
            client.Connect(buffer_copier, buf.ToArray());
        }

        public static void ConnectionRejectedHandler(NetClient client, NetBuffer buffer)
        {

        }
    }
}
