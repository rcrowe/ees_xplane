using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Master
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
