namespace BallonZ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trayZune = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayZune
            // 
            this.trayZune.Icon = ((System.Drawing.Icon)(resources.GetObject("trayZune.Icon")));
            this.trayZune.Visible = true;
            this.trayZune.BalloonTipClosed += new System.EventHandler(this.trayZune_BalloonTipClosed);
            this.trayZune.BalloonTipShown += new System.EventHandler(this.trayZune_BalloonTipShown);
            this.trayZune.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayZune_MouseClick);
            this.trayZune.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trayZune_MouseMove);
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemClose});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(140, 26);
            // 
            // mitemClose
            // 
            this.mitemClose.Name = "mitemClose";
            this.mitemClose.Size = new System.Drawing.Size(139, 22);
            this.mitemClose.Text = "Close BalloZ";
            this.mitemClose.Click += new System.EventHandler(this.mitemClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 213);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayZune;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mitemClose;
        private System.Windows.Forms.Timer timer1;
    }
}

