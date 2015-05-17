using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDShark
{

    public partial class RDSharkWindow : Form
    {
        /* Controlled by the 'follow new messages' menu item: if true, the list box scrolls to the bottom whenever a new
           line is added. */
        private bool alwaysScrollToBottom = true;

        public RDSharkWindow()
        {
            InitializeComponent();
            RailDriver.SetRailSimConnected(true);
        }

        private void log(string str)
        {
            string datestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            requestLog.Items.Add(datestamp + ": " + str);
            if (alwaysScrollToBottom)
            {
                requestLog.TopIndex = requestLog.Items.Count - 1;
            }
        }

        private void pollTimer_Tick(object sender, EventArgs e)
        {
            // First check for "set" messages
            RailDriver.RDid id = RailDriver.RDid.None;
            float value = 0.0f;
            do {
                id = RailDriver.GetNextRailDriverId(id);
                value = RailDriver.GetRailDriverValue(id);
                if (id != RailDriver.RDid.None)
                {
                    log("SET: " + id.ToString() + "(" + ((int)id) + ") => " + value.ToString());
                }
            } while (id != RailDriver.RDid.None);

            // Now check for a 'get' message.
            id = RailDriver.GetRailDriverGetId();
            // GetRailDriverGetId returns -1 if nothing to get...
            if (id != RailDriver.RDid.None)
            {
                RailDriver.RDmod mod = RailDriver.GetRailDriverGetType();
                // return a dummy value to the driver
                RailDriver.SetRailDriverValue(id, 42.0f);
                log("GET: " + mod.ToString() + id.ToString() + "(" + ((int)id) + ")");
            }
        }

        private void followNewRequestsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.alwaysScrollToBottom = followNewRequestsToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (requestLog.SelectedIndex > -1)
            {
                System.Windows.Forms.Clipboard.SetText((string)requestLog.SelectedItem);
            }
        }

        private void sendLocoClick(object sender, EventArgs e)
        {
            /* This event handler belongs both to the 'Change Loco -> Combined' and 'Change Loco -> Separate'
             * menu items.  It gets whether the throttle and brake are combined from the tag of the ToolStripItem
             * that invoked this event handler.  The tag can be either "true" or "false" (Tags set through the form
             * designer are always strings).  If the tag is not either true or false then this event handler tries to
             * display a *slightly* saner error than the default. */
            try
            {
                bool combinedThrottleAndBrake = bool.Parse((string) ((ToolStripItem)sender).Tag);
                RailDriver.SetRailDriverLocoChanged(combinedThrottleAndBrake);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Internal error: sendLocoClick was called from a ToolStripItem whose tag could not be parsed to a boolean.  Check that the Tag properties of all ToolStripItems that call this event handler are set.");
                throw exc;
            }
        }

        private void aboutRDSharkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog(this);
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files|*.txt|All files|*.*";
            dialog.ShowDialog(this);
            if (dialog.FileName != "")
            {
                System.IO.StreamWriter output = new System.IO.StreamWriter(dialog.OpenFile());
                foreach (string line in this.requestLog.Items)
                {
                    output.WriteLine(line);
                }
                output.Close();
            }
        }
    }
}
