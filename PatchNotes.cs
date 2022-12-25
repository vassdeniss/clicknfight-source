using System;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class PatchNotes : Form
    {
        public PatchNotes()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vassdeniss.itch.io/click-n-fight-the-fantasy-clicker-rpg/devlog/211059/release-v32-is-out");
        }
    }
}
