using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Slave
{
    public sealed class Config
    {
        static Config instance = null;
        static readonly object padlock = new object();

        public struct ConfigClient
        {
            public Process process;
            public Thread thread;
            public NetClient connection;
            public NetworkEvents net_events;
            public bool keep_running;

            public string form_active;

            public Thread form_thread;
            /* FORMS */
            public Forms.IOSees_Slave_Metar.MainForm metar_form;    //Metar
            public IOSees_Slave_Wind.MainForm wind_form;                     //Wind
        }
        public ConfigClient Client;

        public Config()
        {
        }

        public static Config Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Config();
                    }
                    return instance;
                }
            }
        }
    }
}
