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
    public partial class MiningOres : Form
    {
        public MiningOres()
        {
            InitializeComponent();
        }

        private void MiningOres_Load(object sender, EventArgs e)
        {
            mine.Interval = 1000;
            mine.Enabled = true;
            progressBar1.Value = 0;
        }

        private void mine_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                mine.Enabled = false;
                this.Close();
            }
        }
    }
}
