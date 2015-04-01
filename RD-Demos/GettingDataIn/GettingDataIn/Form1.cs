using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GettingDataIn
{
    public partial class Form1 : Form
    {
        private Double throttle;
        private Double delta;

        public Form1()
        {
            InitializeComponent();
            throttle = 0;
            delta = 0.1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throttle = throttle + delta;
            if (throttle > 1.0 - Math.Abs(delta) || throttle < Math.Abs(delta))
            {
                delta = -delta;
            }

            progressBar1.Value = (int) (100 * throttle);
            RailDriver.SetRailSimValue(RailDriver.RDid.Throttle, (float) throttle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RailDriver.SetRailDriverConnected(true);
        }
    }
}
