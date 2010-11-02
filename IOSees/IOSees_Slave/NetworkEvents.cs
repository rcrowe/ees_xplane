using System;
using System.Collections.Generic;
using System.Text;

using Lidgren.Network;

namespace IOSees_Slave
{
    //Debug events
    public delegate void DebugRecievedHandler(string msg);
    public delegate void DebugVerboseRecievedHandler(string msg);

    //Client status changed
    public delegate void StatusChangedHandler(NetClient client, NetBuffer buffer);

    //Data recieved
    public delegate void DataRecievedHandler(NetClient client, NetBuffer buffer);

    //Server discovered
    public delegate void ServerDiscoveredHandler(NetClient client, NetBuffer buffer);

    //Connection rejected
    public delegate void ConnectionRejectedHandler(NetClient client, NetBuffer buffer);

    public class NetworkEvents
    {
        public event DebugRecievedHandler DebugMessage;
        public event DebugVerboseRecievedHandler DebugVerboseMessage;
        public event StatusChangedHandler StatusChanged;
        public event DataRecievedHandler DataRecieved;
        public event ServerDiscoveredHandler ServerDiscovered;
        public event ConnectionRejectedHandler ConnectionRejected;

        public NetworkEvents()
        {
        }

        public void fireDebugMessage(string msg)
        {
            if (DebugMessage != null)
            {
                DebugMessage(msg);
            }
        }

        public void fireDebugVerboseMessage(string msg)
        {
            if (DebugVerboseMessage != null)
            {
                DebugVerboseMessage(msg);
            }
        }

        public void fireStatusChanged(NetClient client, NetBuffer buffer)
        {
            if (StatusChanged != null)
            {
                StatusChanged(client, buffer);
            }
        }

        public void fireDataRecieved(NetClient client, NetBuffer buffer)
        {
            if (DataRecieved != null)
            {
                DataRecieved(client, buffer);
            }
        }

        public void fireServerDiscovered(NetClient client, NetBuffer buffer)
        {
            if (ServerDiscovered != null)
            {
                ServerDiscovered(client, buffer);
            }
        }

        public void fireConnectionRejected(NetClient client, NetBuffer buffer)
        {
            if (ConnectionRejected != null)
            {
                ConnectionRejected(client, buffer);
            }
        }
    }
}
