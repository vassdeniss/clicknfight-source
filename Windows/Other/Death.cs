using System.Windows.Forms;

namespace ClickNFight.Windows.Other
{
    public partial class Death : Form
    {
        public Death()
        {
            this.InitializeComponent();
            this.Icon = Properties.Resources.icon;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Death_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}