using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GettingDataOut
{
    public partial class frmSpeedRecorder : Form
    {
        public frmSpeedRecorder()
        {
            InitializeComponent();
        }

        private void frmSpeedRecorder_Load(object sender, EventArgs e)
        {
            // When our application gets its backside into gear, tell the DLL we're ready to talk.
            RailDriver.SetRailDriverConnected(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Single speed = RailDriver.GetRailSimValue(RailDriver.RDid.Speedometer, RailDriver.RDmod.Current);
            String when = DateTime.Now.ToString();

            listBox1.Items.Insert(0, when + " -> " + speed.ToString());
        }

        
    }
}
