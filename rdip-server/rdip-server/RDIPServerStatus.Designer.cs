namespace rdip_server
{
    partial class RDIPServerStatus
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
            this.LogList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.Location = new System.Drawing.Point(0, 0);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(555, 82);
            this.LogList.TabIndex = 0;
            this.LogList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RDIPServerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 273);
            this.Controls.Add(this.LogList);
            this.Name = "RDIPServerStatus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RDIPServerStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LogList;
    }
}

