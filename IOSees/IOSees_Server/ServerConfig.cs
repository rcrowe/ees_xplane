using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOSees_Server
{
    public sealed class Config
    {
        static Config instance = null;
        static readonly object padlock = new object();

        public struct ConfigServer
        {
            public Hashtable client_connections;
        }
        public ConfigServer Server;

        public Config()
        {
            Server.client_connections = new Hashtable(2);
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
