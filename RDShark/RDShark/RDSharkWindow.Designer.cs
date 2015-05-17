namespace RDShark
{
    partial class RDSharkWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.requestLog = new System.Windows.Forms.ListBox();
            this.pollTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followNewRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeOfLocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinedThrottleAndBrakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateThrottleAndBrakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRDSharkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestLog
            // 
            this.requestLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.requestLog.FormattingEnabled = true;
            this.requestLog.Location = new System.Drawing.Point(0, 27);
            this.requestLog.Name = "requestLog";
            this.requestLog.Size = new System.Drawing.Size(641, 251);
            this.requestLog.TabIndex = 0;
            // 
            // pollTimer
            // 
            this.pollTimer.Enabled = true;
            this.pollTimer.Tick += new System.EventHandler(this.pollTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAs,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followNewRequestsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // followNewRequestsToolStripMenuItem
            // 
            this.followNewRequestsToolStripMenuItem.Checked = true;
            this.followNewRequestsToolStripMenuItem.CheckOnClick = true;
            this.followNewRequestsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.followNewRequestsToolStripMenuItem.Name = "followNewRequestsToolStripMenuItem";
            this.followNewRequestsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.followNewRequestsToolStripMenuItem.Text = "Follow new requests";
            this.followNewRequestsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.followNewRequestsToolStripMenuItem_CheckedChanged);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeOfLocoToolStripMenuItem});
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sendToolStripMenuItem.Text = "&Send";
            // 
            // changeOfLocoToolStripMenuItem
            // 
            this.changeOfLocoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combinedThrottleAndBrakeToolStripMenuItem,
            this.separateThrottleAndBrakeToolStripMenuItem});
            this.changeOfLocoToolStripMenuItem.Name = "changeOfLocoToolStripMenuItem";
            this.changeOfLocoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.changeOfLocoToolStripMenuItem.Text = "Change of Loco";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRDSharkToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // combinedThrottleAndBrakeToolStripMenuItem
            // 
            this.combinedThrottleAndBrakeToolStripMenuItem.Name = "combinedThrottleAndBrakeToolStripMenuItem";
            this.combinedThrottleAndBrakeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.combinedThrottleAndBrakeToolStripMenuItem.Tag = "true";
            this.combinedThrottleAndBrakeToolStripMenuItem.Text = "Combined Throttle and Brake";
            this.combinedThrottleAndBrakeToolStripMenuItem.Click += new System.EventHandler(this.sendLocoClick);
            // 
            // separateThrottleAndBrakeToolStripMenuItem
            // 
            this.separateThrottleAndBrakeToolStripMenuItem.Name = "separateThrottleAndBrakeToolStripMenuItem";
            this.separateThrottleAndBrakeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.separateThrottleAndBrakeToolStripMenuItem.Tag = "false";
            this.separateThrottleAndBrakeToolStripMenuItem.Text = "Separate Throttle and Brake";
            this.separateThrottleAndBrakeToolStripMenuItem.Click += new System.EventHandler(this.sendLocoClick);
            // 
            // aboutRDSharkToolStripMenuItem
            // 
            this.aboutRDSharkToolStripMenuItem.Name = "aboutRDSharkToolStripMenuItem";
            this.aboutRDSharkToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutRDSharkToolStripMenuItem.Text = "&About RDShark";
            this.aboutRDSharkToolStripMenuItem.Click += new System.EventHandler(this.aboutRDSharkToolStripMenuItem_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(152, 22);
            this.saveAs.Text = "Save As...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // RDSharkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 273);
            this.Controls.Add(this.requestLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RDSharkWindow";
            this.Text = "RDShark";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox requestLog;
        private System.Windows.Forms.Timer pollTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followNewRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeOfLocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combinedThrottleAndBrakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separateThrottleAndBrakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRDSharkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
    }
}

