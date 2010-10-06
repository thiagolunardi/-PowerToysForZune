using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace BallonZ
{
    public partial class Form1 : Form
    {
        private NowPlaying LastNP;
        private bool IsShowingBallon = false;
        Process pZuneNowPlaying;

        public Form1()
        {
            InitializeComponent();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            pZuneNowPlaying = Process.Start(appPath + @"\ZuneNowPlaying\ZuneNowPlaying.exe");
        }

        private void mitemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            NowPlaying np = GetNowPlaying();
            if (np.Artist != LastNP.Artist ||
                np.Album != LastNP.Album ||
                np.Title != LastNP.Title)
            {
                LastNP = np;
                ShowBallon(true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void trayZune_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                mnuContext.Show(Cursor.Position);
            else if(e.Button == MouseButtons.Left)
            {
                ShowBallon();
            }
        }
        private void ShowBallon() { ShowBallon(false); }
        private void ShowBallon(bool force)
        {
            if (IsShowingBallon && !force) return;
            NowPlaying np = GetNowPlaying();
            if (np.IsPlaying || force)
            {
                trayZune.BalloonTipTitle = np.Artist.ToUpper();
                trayZune.BalloonTipText = np.Album + "\r\n" + np.Title;
            }
            else
            {
                trayZune.BalloonTipTitle = "Zune Stopped";
                trayZune.BalloonTipText = "No song is been played";
            }
                trayZune.ShowBalloonTip(100);
        }

        private NowPlaying GetNowPlaying()
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\ZuneNowPlaying");
            NowPlaying np;
            np.Album = reg.GetValue("Album").ToString();
            np.Title = reg.GetValue("Title").ToString();
            np.Artist = reg.GetValue("Artist").ToString();
            np.IsPlaying = reg.GetValue("Playing").ToString() == "1";
            return np;
        }

        private struct NowPlaying
        {
            public string Title;
            public string Album;
            public string Artist;
            public bool IsPlaying;
        }

        private void trayZune_MouseMove(object sender, MouseEventArgs e)
        {            
            ShowBallon();
        }

        private void trayZune_BalloonTipShown(object sender, EventArgs e)
        {
            IsShowingBallon = true;
        }

        private void trayZune_BalloonTipClosed(object sender, EventArgs e)
        {
            IsShowingBallon = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pZuneNowPlaying.Kill();
            pZuneNowPlaying.Dispose();

        }

    }
}
