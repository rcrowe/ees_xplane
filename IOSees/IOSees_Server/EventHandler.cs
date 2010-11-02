using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Lidgren.Network;

namespace IOSees_Server
{
    public class EventHandler
    {
        public static void DebugMessageHandler(string msg)
        {
            Console.WriteLine("Debug: " + msg);
        }

        public static void DebugVerboseMessageHandler(string msg)
        {
            Console.WriteLine("Debug Verbose: " + msg);
        }

        public static void ClientApproveHandler(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            Config config = Config.Instance;

            string client_type = buffer.ReadString();
            string ip_addr     = sender.RemoteEndpoint.ToString();

            //Check that an incorrect type isnt connecting
            if (client_type != "Master" && client_type != "Slave" && client_type != "Plugin")
            {
                sender.Disapprove("Unknown client type");
                return;
            }

            if (config.Server.client_connections.ContainsKey(ip_addr))
            {
                sender.Disapprove("Client already connected from host");
                return;
            }
            else
            {
                config.Server.client_connections.Add(ip_addr, client_type);
            }


            if (EventHandler.MessageTypeEnabled(server.EnabledMessageTypes.ToString(), "DebugMessage"))
            {
                //Output message
                Console.WriteLine("Client hail from: " + client_type + " - " + ip_addr);
            }

            //Allow client to connect
            sender.Approve();
        }

        public static void StatusChangeHandler(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            //Lets see if we have the clients name
            Config config = Config.Instance;
            string ip_addr = sender.RemoteEndpoint.ToString();

            string client_name;

            if (config.Server.client_connections.ContainsKey(ip_addr))
            {
                client_name = config.Server.client_connections[ip_addr].ToString();
            }
            else
            {
                client_name = "Unknown client";
            }

            //Output status unless its disconnecting and connecting
            if (sender.Status != NetConnectionStatus.Connecting && sender.Status != NetConnectionStatus.Disconnecting)
            {
                Console.WriteLine(client_name + ": " + sender.Status.ToString());
            }

            //Client has now disconnected so lets remove it from the list of clients connected
            if (sender.Status == NetConnectionStatus.Disconnected)
            {
                config.Server.client_connections.Remove(ip_addr);
            }
        }

        public static void DataHandler(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            Config config = Config.Instance;

            if (config.Server.client_connections.ContainsKey(sender.RemoteEndpoint.ToString()))
            {
                string client_type = (string)config.Server.client_connections[sender.RemoteEndpoint.ToString()];

                if (client_type.ToLower() == "master")
                {
                    //Msg recieved from 'master' client
                    //we need to send this forward to the 'slave' clients
                    MasterHandler.Process(server, buffer, sender);
                }
                else if (client_type.ToLower() == "slave")
                {
                    //Msg recieved from 'slave' client
                    //forward on to plugin
                    SlaveHandler.Process(server, buffer, sender);
                }
                else
                {
                    Console.WriteLine("Client: Unknown data recieved");
                }
            }
            else
            {
                Console.WriteLine("Client: Unknown data recieved");
            }
        }

        static bool MessageTypeEnabled(string types_enabled, string check_type)
        {
            bool type_enabled = false;
            string[] enabled_types = types_enabled.Split(',');

            foreach (string type in enabled_types)
            {
                if (type.Trim() == check_type)
                {
                    type_enabled = true;
                }
            }

            return type_enabled;
        }
    }
}
