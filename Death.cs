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
    public partial class Death : Form
    {
        public Death()
        {
            InitializeComponent();
            this.Icon = ClickNFight.Properties.Resources.icon;
        }

        private void Death_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}