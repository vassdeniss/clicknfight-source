using System;
using System.Windows.Forms;

namespace ClickNFight.Windows.Other
{
    public partial class MiningOres : Form
    {
        public MiningOres()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.icon;
        }

        private void MiningOres_Load(object sender, EventArgs e)
        {
            this.mineTimer.Interval = 1000;
            this.mineTimer.Enabled = true;
            this.miningBar.Value = 0;
        }

        private void MineTimer_Tick(object sender, EventArgs e)
        {
            if (this.miningBar.Value < this.miningBar.Maximum)
            {
                this.miningBar.Value++;
            }
            else
            {
                this.mineTimer.Enabled = false;
                this.Close();
            }
        }
    }
}
