using System;
using System.Windows.Forms;
namespace BallonZ
{
    public class AppContext : ApplicationContext
    {
        #region " Storage "

        private NotifyIcon Tray;
        private ContextMenuStrip MainMenu;
        private ToolStripMenuItem mnuDisplayForm;
        private ToolStripSeparator mnuSep1;
        private ToolStripMenuItem mnuExit;

        #endregion

        #region " Constructor "

        public void New()
        {
            //Initialize the menus
            mnuDisplayForm = new ToolStripMenuItem("Display form");
            mnuSep1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem("Exit");
            MainMenu = new ContextMenuStrip();
            MainMenu.Items.AddRange(new ToolStripItem[] { mnuDisplayForm, mnuSep1, mnuExit });

            //Initialize the tray
            Tray = new NotifyIcon();
            //Tray.Icon = this.Resources.TrayIcon;
            Tray.ContextMenuStrip = MainMenu;
            Tray.Text = "Formless tray application";

            //Display
            Tray.Visible = true;
        }

        #endregion

        #region " Event handlers "

        private void AppContext_ThreadExit(object sender, EventArgs e) //    Handles Me.ThreadExit
        {
            //Guarantees that the icon will not linger.
            Tray.Visible = false;
        }

        private void mnuDisplayForm_Click(object sender, EventArgs e) //    Handles mnuDisplayForm.Click
        {
            //ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e) //    Handles mnuExit.Click
        {
            //ExitApplication();
        }

        private void Tray_DoubleClick(object sender, EventArgs e) //    Handles Tray.DoubleClick
        {
            //ShowDialog();
        }

        #endregion

    }
}