using System;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class Camping : Form
    {
        // make all dumb cunt

        Random woodTakeRandom = new Random();
        int woodTake;
        Random stoneTakeRandom = new Random();
        int stoneTake;
        Random flintTakeRandom = new Random();
        int flintTake;
        Random steelTakeRandom = new Random();
        int steelTake;

        public Camping()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CampingMaterials material = new CampingMaterials();
            material.gather.Text = "Gathering Wood!";
            material.progressBar1.Maximum = 10;
            material.ShowDialog();
            woodTake = woodTakeRandom.Next(1, 6);
            Engine.wood = Engine.wood + woodTake;
            woodTotal.Text = "Sticks: " + Engine.wood;
            woodCooldown.Interval = 300000;
            getWood.Enabled = false;
            woodCooldown.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CampingMaterials material = new CampingMaterials();
            material.gather.Text = "Gathering Stone!";
            material.progressBar1.Maximum = 15;
            material.ShowDialog();
            stoneTake = stoneTakeRandom.Next(1, 6);
            Engine.stone = Engine.stone + stoneTake;
            stoneTotal.Text = "Stones: " + Engine.stone;
            stoneCooldown.Interval = 420000;
            getStone.Enabled = false;
            stoneCooldown.Enabled = true;
        }

        private void getFlint_Click(object sender, EventArgs e)
        {
            CampingMaterials material = new CampingMaterials();
            material.gather.Text = "Gathering Flint!";
            material.progressBar1.Maximum = 20;
            flintTake = flintTakeRandom.Next(1, 6);
            Engine.flint = Engine.flint + flintTake;
            flintTotal.Text = "Flint: " + Engine.flint;
            flintCooldown.Interval = 540000;
            getFlint.Enabled = false;
            flintCooldown.Enabled = true;
        }

        private void getSteel_Click(object sender, EventArgs e)
        {
            CampingMaterials material = new CampingMaterials();
            material.gather.Text = "Gathering Steel!";
            material.progressBar1.Maximum = 30;
            material.ShowDialog();
            steelTake = steelTakeRandom.Next(1, 6);
            Engine.steel = Engine.steel + steelTake;
            steelTotal.Text = "Steel: " + Engine.steel;
            steelCooldown.Interval = 660000;
            getSteel.Enabled = false;
            steelCooldown.Enabled = true;
        }

        private void Camping_Load(object sender, EventArgs e)
        {
            woodTotal.Text = "Sticks: " + Engine.wood;
            stoneTotal.Text = "Stones: " + Engine.stone;
            flintTotal.Text = "Flint: " + Engine.flint;
            steelTotal.Text = "Steel: " + Engine.steel;
        }

        private void woodCooldown_Tick(object sender, EventArgs e)
        {
            getWood.Enabled = true;
            woodCooldown.Enabled = false;
        }

        private void stoneCooldown_Tick(object sender, EventArgs e)
        {
            getStone.Enabled = true;
            stoneCooldown.Enabled = false;
        }

        private void steelCooldown_Tick(object sender, EventArgs e)
        {
            getSteel.Enabled = true;
            steelCooldown.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Engine.wood >= 30 && Engine.stone >= 20 && Engine.flint >= 10 && Engine.steel >= 5)
            {
                Engine.wood = Engine.wood - 30;
                Engine.stone = Engine.stone - 20;
                Engine.flint = Engine.flint - 10;
                Engine.steel = Engine.steel - 5;
                woodTotal.Text = "Sticks: " + Engine.wood;
                stoneTotal.Text = "Stones: " + Engine.stone;
                flintTotal.Text = "Flint: " + Engine.flint;
                steelTotal.Text = "Steel: " + Engine.steel;
                CampingNight night = new CampingNight();
                night.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dón't have enough materials!", "Warning!", MessageBoxButtons.OK); 
            }
        }
    }
}
