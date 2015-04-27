using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TinyUDP
{
    public partial class frmTinyUDP : Form
    {
        UdpClient udp;

        public frmTinyUDP()
        {
            InitializeComponent();

            udp = new UdpClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // send packet       
            byte[] Payload = Encoding.UTF8.GetBytes(txtPayload.Text);
            int Port = Int32.Parse(txtPort.Text);
            udp.Send(Payload, Payload.Length, txtAddress.Text, Port);

            // write log line
            string logline = txtAddress.Text + ":" + txtPort.Text + " <- " + txtPayload.Text;
            lstLog.Items.Insert(0, logline);
        }
    }
}
