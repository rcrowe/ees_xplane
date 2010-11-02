using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Server
{
    class Program
    {
        private static NetworkEvents netevent;

        static void Main(string[] args)
        {
            netevent = new NetworkEvents();

            netevent.DebugMessage += new DebugRecievedHandler(EventHandler.DebugMessageHandler);
            netevent.DebugVerboseMessage += new DebugVerboseRecievedHandler(EventHandler.DebugVerboseMessageHandler);
            netevent.ClientApproval += new ClientApprovalHandler(EventHandler.ClientApproveHandler);
            netevent.StatusChanged += new StatusChangedHandler(EventHandler.StatusChangeHandler);
            netevent.DataRecieved += new DataRecievedHandler(EventHandler.DataHandler);

            //Start the server
            StartServer();
        }

        private static void StartServer()
        {
            // create a configuration for the server
            NetConfiguration config = new NetConfiguration("EES");
            config.MaxConnections = 128;
            config.Port = 14242;

            // create server and start listening for connections
            NetServer server = new NetServer(config);
            server.SetMessageTypeEnabled(NetMessageType.DebugMessage, false);
            server.SetMessageTypeEnabled(NetMessageType.ConnectionApproval, true);
            server.Start();

            // create a buffer to read data into
            NetBuffer buffer = server.CreateBuffer();

            // keep running until the user presses a key
            Console.WriteLine("Press ESC to quit server");
            bool keepRunning = true;
            while (keepRunning)
            {
                NetMessageType type;
                NetConnection sender;

                // check if any messages has been received
                while (server.ReadMessage(buffer, out type, out sender))
                {
                    switch (type)
                    {
                        case NetMessageType.DebugMessage:
                            netevent.fireDebugMessage(buffer.ReadString());
                            break;

                        case NetMessageType.ConnectionApproval:
                            netevent.fireClientApproval(server, buffer, sender);
                            break;

                        case NetMessageType.StatusChanged:
                            netevent.fireStatusChanged(server, buffer, sender);
                            break;

                        case NetMessageType.Data:
                            netevent.fireDataRecieved(server, buffer, sender);
                            break;
                    }
                }

                // User pressed ESC?
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();

                    if (info.Key == ConsoleKey.Escape)
                    {
                        keepRunning = false;
                    }
                    else if (info.Key == ConsoleKey.I)
                    {
                        //Create line
                        Console.WriteLine("");
                        
                        //Get config
                        Config server_config = Config.Instance;

                        foreach (DictionaryEntry entry in server_config.Server.client_connections)
                        {
                            Console.WriteLine("Client: '" + entry.Value + "' from: " + entry.Key);
                        }
                    }
                }

                Thread.Sleep(1);
            }

            server.Shutdown("Server exiting");
        }
    }
}
