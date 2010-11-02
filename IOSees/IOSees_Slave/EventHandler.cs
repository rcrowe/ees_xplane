using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Slave
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
            }

            if (status == NetConnectionStatus.Disconnected)
            {
                Console.WriteLine("Client: Disconnected");
            }
        }

        public static void DataHandler(NetClient client, NetBuffer buffer)
        {
            //Check which page to load
            string[] requested_page = buffer.ReadString().Split(':');
            string page = requested_page[1];

            Console.WriteLine("Requested page: " + page);

            Config config = Config.Instance;

            //Close any running forms
            if (config.Client.form_thread != null)
            {
                config.Client.form_thread.Abort();

                if (config.Client.form_active == "metar")
                {
                    config.Client.metar_form.Close();
                }

                if (config.Client.form_active == "wind")
                {
                    config.Client.wind_form.Close();
                }
            }

            if (page == "metar")
            {
                config.Client.form_active = "metar";

                config.Client.form_thread = new Thread(new ThreadStart(RunForm));
                config.Client.form_thread.Start();
            }

            if (page == "wind")
            {
                config.Client.form_active = "wind";

                config.Client.form_thread = new Thread(new ThreadStart(RunForm));
                config.Client.form_thread.Start();
            }
        }

        private static void RunForm()
        {
            Config config = Config.Instance;

            if (config.Client.form_active == "metar")
            {
                config.Client.metar_form = new Forms.IOSees_Slave_Metar.MainForm();
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.Run(config.Client.metar_form);
            }

            if (config.Client.form_active == "wind")
            {
                config.Client.wind_form = new IOSees_Slave_Wind.MainForm();
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.Run(config.Client.wind_form);
            }
        }

        public static void ServerDiscoveredHandler(NetClient client, NetBuffer buffer)
        {
            System.Net.IPEndPoint buffer_copier = buffer.ReadIPEndPoint();

            //Just connect to the first server we find
            Console.WriteLine("Client: Connecting to server: " + buffer_copier.ToString());

            //Let server know the type of IOS client connecting
            NetBuffer buf = client.CreateBuffer();
            buf.Write("Slave");

            //Connect
            client.Connect(buffer_copier, buf.ToArray());
        }

        public static void ConnectionRejectedHandler(NetClient client, NetBuffer buffer)
        {
            Console.WriteLine("Client rejected");
        }
    }
}
