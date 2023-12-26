using System;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class GatheringResources : Form
    {
        public GatheringResources()
        {
            this.InitializeComponent();
        }

        private void GatheringResources_Load(object sender, EventArgs e)
        {
            this.gatherTimer.Interval = 1000;
            this.gatherTimer.Enabled = true;
            this.gatheringBar.Value = 0;
        }

        private void GatherTimer_Tick(object sender, EventArgs e)
        {
            if (this.gatheringBar.Value < this.gatheringBar.Maximum)
            {
                this.gatheringBar.Value++;
            }
            else
            {
                this.gatherTimer.Enabled = false;
                this.Close(); 
            }
        }
    }
}
