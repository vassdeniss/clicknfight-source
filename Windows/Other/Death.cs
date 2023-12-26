using System.Windows.Forms;

namespace ClickNFight.Windows.Other
{
    public partial class Death : Form
    {
        public Death()
        {
            this.InitializeComponent();
        }

        private void Death_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
