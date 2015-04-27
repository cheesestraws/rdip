using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rdip_server
{
    class RDIPProtocolImplementation : IPacketReceiver
    {
        /* This class implements the backend of the protocol.  It receives payloads and turns them into
         * raildriver.dll calls.
         * 
         * This is separate from the UDP code because I want to add RD-over-HTTP as well fairly shortly,
         * so that we can control Train Simulator from a mobile or tablet. */

        public void receivePacket(string addr, int port, string packet)
        {
            /* Here we can ignore addr and port for the moment.  They are here because:
             * 1. good for logging
             * 2. later, adding some kind of ACL would be sensible.
             */

            // If a packet contains an = sign, it's an assignment
            if (packet.Contains('='))
            {
                string[] parts = packet.Split('=');
                if (parts.Length != 2)
                {
                    // TODO: Some error logging here.
                    return;
                }
                string name = parts[0];
                RailDriver.RDid rdid = (RailDriver.RDid) 0;
                float value = 0.0f;

                try
                {
                    value = float.Parse(parts[1]);
                    rdid = (RailDriver.RDid)Enum.Parse(typeof(RailDriver.RDid), name);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Malformed packet: bad name.");
                    return;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Malformed packet: bad value.");
                    return;
                }

                Console.WriteLine(rdid.ToString() + " => " + value.ToString());
                RailDriver.SetRailSimValue(rdid, value);
            }

        }
    }
}
