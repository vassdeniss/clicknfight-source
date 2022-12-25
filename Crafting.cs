using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class Crafting : Form
    {
        public Crafting()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void craftBR_Click(object sender, EventArgs e)
        {
            if (Engine.waterRunes >= 5 && Engine.mindRunes >= 2) 
            {
                SoundPlayer craft = new SoundPlayer(Properties.Resources.metal);
                craft.Play();
                Thread.Sleep(400);
                SoundPlayer craft2 = new SoundPlayer(Properties.Resources.metal);
                craft2.Play();
                Thread.Sleep(400);
                SoundPlayer craft3 = new SoundPlayer(Properties.Resources.metal);
                craft3.Play();
                Engine.waterRunes = Engine.waterRunes - 5;
                Engine.mindRunes = Engine.mindRunes - 2;
                Engine.bloodRunes++;
            }
            else
            {
                noCraft.Visible = true;
            }
        }

        private void craftCR_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 2 && Engine.lavaRunes >= 5 && Engine.mindRunes >= 2)
            {
                SoundPlayer craft = new SoundPlayer(Properties.Resources.metal);
                craft.Play();
                Thread.Sleep(400);
                SoundPlayer craft2 = new SoundPlayer(Properties.Resources.metal);
                craft2.Play();
                Thread.Sleep(400);
                SoundPlayer craft3 = new SoundPlayer(Properties.Resources.metal);
                craft3.Play();
                Engine.airRunes = Engine.airRunes - 2;
                Engine.lavaRunes = Engine.lavaRunes - 5;
                Engine.mindRunes = Engine.mindRunes - 2;
                Engine.cosmicRunes++;
            }
            else
            {
                noCraft.Visible = true;
            }
        }

        private void craftLR_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 3 && Engine.natureRunes >= 6 && Engine.mindRunes >= 3)
            {
                SoundPlayer craft = new SoundPlayer(Properties.Resources.metal);
                craft.Play();
                Thread.Sleep(400);
                SoundPlayer craft2 = new SoundPlayer(Properties.Resources.metal);
                craft2.Play();
                Thread.Sleep(400);
                SoundPlayer craft3 = new SoundPlayer(Properties.Resources.metal);
                craft3.Play();
                Engine.airRunes = Engine.airRunes - 3;
                Engine.natureRunes = Engine.natureRunes - 6;
                Engine.mindRunes = Engine.mindRunes - 3;
                Engine.lifeRunes++;
            }
            else
            {
                noCraft.Visible = true;
            }
        }

        private void craftWR_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 4 && Engine.electricRunes >= 1 && Engine.mindRunes >= 4 && Engine.bloodRunes >= 7) 
            {
                SoundPlayer craft = new SoundPlayer(Properties.Resources.metal);
                craft.Play();
                Thread.Sleep(400);
                SoundPlayer craft2 = new SoundPlayer(Properties.Resources.metal);
                craft2.Play();
                Thread.Sleep(400);
                SoundPlayer craft3 = new SoundPlayer(Properties.Resources.metal);
                craft3.Play();
                Engine.airRunes = Engine.airRunes - 4;
                Engine.electricRunes = Engine.electricRunes - 1;
                Engine.mindRunes = Engine.mindRunes - 4;
                Engine.bloodRunes = Engine.bloodRunes - 7;
                Engine.wrathRunes++; 
            }
            else
            {
                noCraft.Visible = true;
            }
        }

        private void craftSR_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 5 && Engine.steamRunes >= 1 && Engine.mindRunes >= 5 && Engine.cosmicRunes >= 8)
            {
                SoundPlayer craft = new SoundPlayer(Properties.Resources.metal);
                craft.Play();
                Thread.Sleep(400);
                SoundPlayer craft2 = new SoundPlayer(Properties.Resources.metal);
                craft2.Play();
                Thread.Sleep(400);
                SoundPlayer craft3 = new SoundPlayer(Properties.Resources.metal);
                craft3.Play();
                Engine.airRunes = Engine.airRunes - 5;
                Engine.steamRunes = Engine.steamRunes - 1;
                Engine.mindRunes = Engine.mindRunes - 5;
                Engine.cosmicRunes = Engine.cosmicRunes - 8;
                Engine.astralRunes++;
            }
            else
            {
                noCraft.Visible = true;
                
            }
        }

        private void craftSoS_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 5 && Engine.mindRunes >= 5 && Engine.reviveRunes >= 1 && Engine.lifeRunes >= 8)
            {
                SoundPlayer craft = new SoundPlayer(Properties.Resources.metal);
                craft.Play();
                Thread.Sleep(400);
                SoundPlayer craft2 = new SoundPlayer(Properties.Resources.metal);
                craft2.Play();
                Thread.Sleep(400);
                SoundPlayer craft3 = new SoundPlayer(Properties.Resources.metal);
                craft3.Play();
                Engine.airRunes = Engine.airRunes - 5;
                Engine.reviveRunes = Engine.reviveRunes - 1;
                Engine.mindRunes = Engine.mindRunes - 5;
                Engine.lifeRunes = Engine.lifeRunes - 7;
                Engine.soulRunes ++; 
            }
            else
            {
                noCraft.Visible = true;

            }
        }
    }
}