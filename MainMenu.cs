using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Idle_Game
{
    public partial class MainMenu : Form
    {
        SoundPlayer main = new SoundPlayer(Idle_Game.Properties.Resources.mainMenu);

        public MainMenu()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.D)
            {
                Engine.devTools = true;
                if (Engine.devTools == true)
                {
                    dev.Visible = true;
                }
            }
            else
            {
                Engine.devTools = false;
            }

            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.G)
            {
                MessageBox.Show("You have cracked the riddle! Enjoy the extra gamemode!", "Congratulations!", MessageBoxButtons.OK);
                clickerGame.Visible = true;
                button3.Location = new Point(439, 306);
                button2.Location = new Point(12, 306);
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
            main.Play(); 
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
