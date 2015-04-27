using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rdip_server
{
    interface IPacketReceiver
    {
        void receivePacket(string addr, int port, string packet);
    }
}
