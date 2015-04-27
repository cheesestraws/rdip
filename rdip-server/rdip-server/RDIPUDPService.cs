using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace rdip_server
{
    class RDIPUDPService
    {
        private Boolean running;
        private UdpClient udp;
        private List<IPacketReceiver> receivers;

        // constructor
        public RDIPUDPService()
        {
            this.running = false;
            this.receivers = new List<IPacketReceiver>();
        }

        // Adds a packet receiver
        public void AddPacketReceiver(IPacketReceiver r)
        {
            receivers.Add(r);
        }

        private void PacketHandler(IAsyncResult result)
        {
            IPEndPoint e = new IPEndPoint(IPAddress.Any, 0);
            byte[] payload;
            try
            {
                payload = this.udp.EndReceive(result, ref e);
            }
            catch (ObjectDisposedException exc)
            {
                // Seriously, is there no better way of doing this?
                // Exceptions as flow control? ugh.
                return;
            }

            // At this point we know this isn't the result of a
            // .close() on the UdpClient, because otherwise the
            // exception handler above would have fired
            String s = Encoding.UTF8.GetString(payload);

            foreach (IPacketReceiver p in receivers)
            {
                p.receivePacket(e.Address.ToString(), e.Port, s);
            }

            // and set up the recv for the next packet
            udp.BeginReceive(new AsyncCallback(PacketHandler), null);
        }
    
        // Start listening for UDP packets
        public void Start()
        {
            if (!running)
            {
                udp = new UdpClient(Properties.Settings.Default.Port);
                udp.BeginReceive(new AsyncCallback(PacketHandler), null);
            }
            running = true;
        }

        // Stop listening for UDP packets
        public void Stop()
        {
            if (running)
            {
                udp.Close();
                udp = null;
            }
            running = false;
        }
    }
}
