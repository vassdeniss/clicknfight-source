using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idle_Game
{
    public partial class PatchNotes : Form
    {
        public PatchNotes()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vassdeniss.itch.io/click-n-fight-the-fantasy-clicker-rpg/devlog/211059/release-v32-is-out");
        }
    }
}
