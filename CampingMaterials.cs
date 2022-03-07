using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class CampingMaterials : Form
    {
        public CampingMaterials()
        {
            InitializeComponent();
        }

        private void CampingWood_Load(object sender, EventArgs e)
        {
            cut.Interval = 1000;
            cut.Enabled = true;
            progressBar1.Value = 0;
        }

        private void cut_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                cut.Enabled = false;
                this.Close(); 
            }
        }
    }
}
