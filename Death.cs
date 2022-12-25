using System.Windows.Forms;

namespace ClickNFight
{
    public partial class Death : Form
    {
        public Death()
        {
            this.InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void Death_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}