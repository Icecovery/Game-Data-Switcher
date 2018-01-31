using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDataSwitcher
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About GameData Switcher");
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
            System.Diagnostics.Process.Start("https://forum.kerbalspaceprogram.com/index.php?/profile/168058-icecovery/");
        }

        private void buttonSpaceDock_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://spacedock.info/profile/IcecoveryStudio");
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
