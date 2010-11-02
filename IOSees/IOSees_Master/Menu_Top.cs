using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Master
{
    public partial class IOS_Master : Form
    {
        private Config config;

        public IOS_Master()
        {
            InitializeComponent();

            //Get a copy of config
            config = Config.Instance;

            //Output console message so we know where were at
            Console.WriteLine("Client: IOS Master started");
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //config.Client.connection.Disconnect("Master: Exited");
            this.Close();

            Console.WriteLine("Client: IOS Master exited");
            Console.Write("Client: Closing connections to server");

            //Give it time to send message and server do its thing
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }

            config.Client.keep_running = false;
        }

        private void bttnTest_Click(object sender, EventArgs e)
        {
            SendMessage("page:weather");
        }

        private void SendMessage(string msg)
        {
            //Get connection and buffer
            NetClient client = config.Client.connection;
            NetBuffer buffer = client.CreateBuffer();

            buffer.Write(msg);

            client.SendMessage(buffer, NetChannel.ReliableInOrder1);
        }

        private void bttnMetar_Click(object sender, EventArgs e)
        {
            SendMessage("page:metar");
        }
    }
}
