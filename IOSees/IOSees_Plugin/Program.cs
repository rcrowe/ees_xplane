using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics;

using Lidgren.Network;

namespace IOSees_Plugin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config client_config = Config.Instance;

            client_config = Config.Instance;

            client_config.Client.net_events = new NetworkEvents();

            client_config.Client.net_events.DebugMessage += new DebugRecievedHandler(EventHandler.DebugMessageHandler);
            client_config.Client.net_events.DebugVerboseMessage += new DebugVerboseRecievedHandler(EventHandler.DebugVerboseMessageHandler);
            client_config.Client.net_events.StatusChanged += new StatusChangedHandler(EventHandler.StatusChangeHandler);
            client_config.Client.net_events.DataRecieved += new DataRecievedHandler(EventHandler.DataHandler);
            client_config.Client.net_events.ServerDiscovered += new ServerDiscoveredHandler(EventHandler.ServerDiscoveredHandler);
            client_config.Client.net_events.ConnectionRejected += new ConnectionRejectedHandler(EventHandler.ConnectionRejectedHandler);

            client_config.Client.thread = new Thread(new ThreadStart(StartClient));
            client_config.Client.thread.IsBackground = false;
            client_config.Client.thread.Start();
        }

        static void StartClient()
        {
            Config client_config = Config.Instance;

            // create a client with a default configuration
            NetConfiguration config = new NetConfiguration("EES");

            client_config.Client.connection = new NetClient(config);
            client_config.Client.connection.SetMessageTypeEnabled(NetMessageType.ConnectionRejected, true);
            client_config.Client.connection.SetMessageTypeEnabled(NetMessageType.DebugMessage, true);
            client_config.Client.connection.SetMessageTypeEnabled(NetMessageType.VerboseDebugMessage, true);
            client_config.Client.connection.Start();

            // Wait half a second to allow server to start up if run via Visual Studio
            Thread.Sleep(500);

            // Emit discovery signal
            client_config.Client.connection.DiscoverLocalServers(14242);

            // create a buffer to read data into
            NetBuffer buffer = client_config.Client.connection.CreateBuffer();

            // keep running until the user presses a key
            client_config.Client.keep_running = true;
            while (client_config.Client.keep_running)
            {
                NetMessageType type;

                // check if any messages has been received
                while (client_config.Client.connection.ReadMessage(buffer, out type))
                {
                    switch (type)
                    {
                        case NetMessageType.ServerDiscovered:
                            client_config.Client.net_events.fireServerDiscovered(client_config.Client.connection, buffer);
                            break;

                        case NetMessageType.ConnectionRejected:
                            client_config.Client.net_events.fireConnectionRejected(client_config.Client.connection, buffer);
                            break;

                        case NetMessageType.DebugMessage:
                            client_config.Client.net_events.fireDebugMessage(buffer.ReadString());
                            break;

                        case NetMessageType.VerboseDebugMessage:
                            client_config.Client.net_events.fireDebugVerboseMessage(buffer.ReadString());
                            break;

                        case NetMessageType.StatusChanged:
                            client_config.Client.net_events.fireStatusChanged(client_config.Client.connection, buffer);
                            break;

                        case NetMessageType.Data:
                            client_config.Client.net_events.fireDataRecieved(client_config.Client.connection, buffer);
                            break;

                        default:
                            break;
                    }
                }

                Thread.Sleep(1);
            }

            client_config.Client.connection.Shutdown("IOS:master exiting");
        }
    }
}
