using System;
using System.Windows.Forms;

namespace GameDataSwitcher
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About GameData Switcher");
            /*↓↓↓↓↓change the version number here↓↓↓↓↓↓*/
            /*here→→→*/label3.Text = "V1.0.5";/*←←←here*/
            /*↑↑↑↑↑change the version number here↑↑↑↑↑↑*/
        }

        private void buttonOJBK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Icecovery/Game-Data-Switcher/");
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.kerbalspaceprogram.com/index.php?/topic/170323-*");
        }

        private void buttonSpaceDock_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://spacedock.info/mod/1684/Game%20Data%20Switcher");
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Icecovery/Game-Data-Switcher/issues/new"); 
        }

        private void buttonPatron_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/Icecovery");
        }
    }
}
