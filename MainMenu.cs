using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class MainMenu : Form
    {
        SoundPlayer main = new SoundPlayer(Properties.Resources.mainMenu);

        public MainMenu()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.icon;
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.D)
            //{
            //    Engine.devTools = true;
            //    if (Engine.devTools == true)
            //    {
            //        dev.Visible = true;
            //    }
            //}
            //else
            //{
            //    Engine.devTools = false;
            //}

            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.G)
            {
                MessageBox.Show("You have cracked the riddle! Enjoy the extra gamemode!", "Congratulations!", MessageBoxButtons.OK);
                clickerGame.Visible = true;
                button3.Location = new Point(439, 306);
                button2.Location = new Point(12, 306);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatchNotes notes = new PatchNotes();
            notes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            this.Hide();
            main.Stop();
            game.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Name nameSelect = new Name();
            nameSelect.ShowDialog();
            this.main.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clicker click = new Clicker();
            this.Hide();
            main.Stop();
            click.ShowDialog();
        }
    }
}
