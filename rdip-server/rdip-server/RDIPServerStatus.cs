using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rdip_server
{
    public partial class RDIPServerStatus : Form, IPacketReceiver
    {
        private RDIPUDPService udp;

        public RDIPServerStatus()
        {
            InitializeComponent();
            udp = new RDIPUDPService();
            udp.AddPacketReceiver(this);
            udp.AddPacketReceiver(new RDIPProtocolImplementation());
            udp.Start();
        }

        public void receivePacket(string addr, int port, string packet)
        {
            this.Invoke(new Action(() => LogList.Items.Insert(0, addr + ":" + port.ToString() + " -> " + packet)));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RDIPServerStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
