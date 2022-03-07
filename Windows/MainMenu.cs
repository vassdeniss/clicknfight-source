using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace ClickNFight.Windows
{
    public partial class MainMenu : Form
    {
        readonly SoundPlayer main = new SoundPlayer(Properties.Resources.mainMenu);

        public MainMenu()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.D)
            {
                Engine.devTools = true;
                dev.Visible = true;
            }
            else
            {
                Engine.devTools = false;
            }

            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.G)
            {
                MessageBox.Show("You have cracked the riddle! Enjoy the extra gamemode!", "Congratulations!", MessageBoxButtons.OK);
                clickerGame.Visible = true;
                ExitButton.Location = new Point(439, 306);
                PatchNotesButton.Location = new Point(12, 306);
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void PatchNotesButton_Click(object sender, EventArgs e)
        {
            new PatchNotes().Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            main.Stop();
            new Form1().ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            new Name().ShowDialog();
            main.Play(); 
        }

        private void ClickerGame_CLick(object sender, EventArgs e)
        {
            Hide();
            main.Stop();
            new Clicker().ShowDialog();
        }
    }
}
