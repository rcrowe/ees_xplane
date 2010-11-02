using System;
using System.Collections.Generic;
using System.Text;

using Lidgren.Network;

namespace IOSees_Server
{
    //Debug events
    public delegate void DebugRecievedHandler(string msg);
    public delegate void DebugVerboseRecievedHandler(string msg);

    //Client connection approval
    public delegate void ClientApprovalHandler(NetServer server, NetBuffer buffer, NetConnection sender);

    //Client status changed
    public delegate void StatusChangedHandler(NetServer server, NetBuffer buffer, NetConnection sender);

    //Data recieved
    public delegate void DataRecievedHandler(NetServer server, NetBuffer buffer, NetConnection sender);

    public class NetworkEvents
    {
        public event DebugRecievedHandler DebugMessage;
        public event DebugVerboseRecievedHandler DebugVerboseMessage;
        public event ClientApprovalHandler ClientApproval;
        public event StatusChangedHandler StatusChanged;
        public event DataRecievedHandler DataRecieved;

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

        public void fireClientApproval(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            if (ClientApproval != null)
            {
                ClientApproval(server, buffer, sender);
            }
        }

        public void fireStatusChanged(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            if (StatusChanged != null)
            {
                StatusChanged(server, buffer, sender);
            }
        }

        public void fireDataRecieved(NetServer server, NetBuffer buffer, NetConnection sender)
        {
            if (DataRecieved != null)
            {
                DataRecieved(server, buffer, sender);
            }
        }
    }
}
