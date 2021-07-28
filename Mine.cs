using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idle_Game
{
    public partial class Mine : Form
    {

        // camping in one form 

        bool isCopperPickEquipped = false;
        bool isSilverPickEquipped = false;
        bool isGoldPickEquipped = false;
        bool isPlatinumPickEquipped = false;
        bool isCobaltPickEquipped = false;
        bool isStarPickEquipped = false;

        bool isSilverOrePicked = false;
        bool isGoldOrePicked = false;
        bool isPlatinumOrePicked = false;
        bool isCobaltOrePicked = false;
        bool isStarOrePicked = false;

        Random silverOreTakeRandom = new Random();
        Random goldOreTakeRandom = new Random();
        Random platOreTakeRandom = new Random();
        Random cobOreTakeRandom = new Random();
        Random starOreTakeRancom = new Random();

        int silverOreTake;
        int goldOreTake;
        int platOreTake;
        int cobOreTake;
        int starOreTake;

        public Mine()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;

            cbPick.Items.Add("Copper Pickaxe");
            cbOre.Items.Add("Silver Ore");

            if (Engine.level >= 4)
            {
                cbOre.Items.Add("Gold Ore");
            }

            if (Engine.level >= 5)
            {
                cbOre.Items.Add("Platinum Ore");
            }

            if (Engine.level >= 6)
            {
                cbOre.Items.Add("Cobalt Ore");
            }

            if (Engine.level >= 7)
            {
                cbOre.Items.Add("Stardust Ore");
            }

            if (Engine.silverPick == true)
            {
                cbPick.Items.Add("Silver Pickaxe");
            }

            if (Engine.goldPick == true)
            {
                cbPick.Items.Add("Gold Pickaxe");
            }

            if (Engine.platPick == true)
            {
                cbPick.Items.Add("Platinum Pickaxe");
            }

            if (Engine.cobPick == true)
            {
                cbPick.Items.Add("Cobalt Pickaxe");
            }

            if (Engine.starPick == true)
            {
                cbPick.Items.Add("Star Pickaxe");
            }
        }

        private void pickPick_Click(object sender, EventArgs e)
        {

            if (cbPick.SelectedIndex > -1)
            {
                if (cbPick.SelectedItem.ToString() == "Copper Pickaxe")
                {
                    isCopperPickEquipped = true;
                    if (isCopperPickEquipped == true)
                    {
                        txPick.Text = "Pickaxe Equipped: Copper Pickaxe";
                    }
                }
                else isCopperPickEquipped = false;

                if (cbPick.SelectedItem.ToString() == "Silver Pickaxe")
                {
                    isSilverPickEquipped = true;
                    if (isSilverPickEquipped == true)
                    {
                        txPick.Text = "Pickaxe Equipped: Silver Pickaxe";
                    }
                }
                else isSilverPickEquipped = false;

                if (cbPick.SelectedItem.ToString() == "Gold Pickaxe")
                {
                    isGoldPickEquipped = true;
                    if (isGoldPickEquipped == true)
                    {
                        txPick.Text = "Pickaxe Equipped: Gold Pickaxe";
                    }
                }
                else isGoldOrePicked = false;

                if (cbPick.SelectedItem.ToString() == "Platinum Pickaxe")
                {
                    isPlatinumPickEquipped = true;
                    if (isPlatinumPickEquipped == true)
                    {
                        txPick.Text = "Pickaxe Equipped: Platinum Pickaxe";
                    }
                }
                else isPlatinumPickEquipped = false;

                if (cbPick.SelectedItem.ToString() == "Cobalt Pickaxe")
                {
                    isCobaltPickEquipped = true;
                    if (isCobaltPickEquipped == true)
                    {
                        txPick.Text = "Pickaxe Equipped: Cobalt Pickaxe";
                    }
                }
                else isCobaltPickEquipped = false;

                if (cbPick.SelectedItem.ToString() == "Star Pickaxe")
                {
                    isStarPickEquipped = true;
                    if (isStarPickEquipped == true)
                    {
                        txPick.Text = "Pickaxe Equipped: Star Pickaxe";
                    }
                }
                else isStarPickEquipped = false;
            }
        }

        private void orePicker_Click(object sender, EventArgs e)
        {
            if (cbOre.SelectedIndex > -1)
            {
                if (cbOre.SelectedItem.ToString() == "Silver Ore")
                {
                    isSilverOrePicked = true;
                    if (isSilverOrePicked == true)
                    {
                        lbOre.Text = "Silver Ore"; 
                        txOre.Text = "Ore Picked: Silver Ore";
                    }
                }
                else isSilverOrePicked = false;

                if (cbOre.SelectedItem.ToString() == "Gold Ore")
                {
                    isGoldOrePicked = true;
                    if (isGoldOrePicked == true)
                    {
                        lbOre.Text = "Gold Ore";
                        txOre.Text = "Ore Picked: Gold Ore";
                    }
                }
                else isGoldOrePicked = false;

                if (cbOre.SelectedItem.ToString() == "Platinum Ore")
                {
                    isPlatinumOrePicked = true;
                    if (isPlatinumOrePicked == true)
                    {
                        lbOre.Text = "Platinum Ore";
                        txOre.Text = "Ore Picked: Platinum Ore";
                    }
                }
                else isPlatinumOrePicked = false;

                if (cbOre.SelectedItem.ToString() == "Cobalt Ore")
                {
                    isCobaltOrePicked = true;
                    if (isCobaltOrePicked == true)
                    {
                        lbOre.Text = "Cobalt Ore";
                        txOre.Text = "Ore Picked: Cobalt Ore";
                    }
                }
                else isCobaltOrePicked = false;

                if (cbOre.SelectedItem.ToString() == "Stardust Ore")
                {
                    isStarOrePicked = true;
                    if (isStarOrePicked == true)
                    {
                        lbOre.Text = "Stardust Ore";
                        txOre.Text = "Ore Picked: Stardust Ore";
                    }
                }
                else isStarOrePicked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Copper on SIlver = Good 
            // Copper on Gold = Bad 
            // Copper on Platinum = Bad
            // Copper on Cobalt = Bad 
            // Cooper on Star = Bad

            // Silver on SIlver = Better
            // Silver on Gold = Good 
            // Silver on Platinum = Bad
            // Silver on Cobalt = Bad 
            // Silver on Star = Bad

            // GOld on Silver = Amazing
            // Gold on Gold = Better 
            // Gold on Plat = Good
            // Gold on Cobalt = Bad 
            // Gold on Star = Bad

            // Platinum on Silver = Godlike
            // Platinum on Gold = Amazing 
            // Platinum on Platium = Better 
            // Platinum on Cobalt = Good
            // Platinum on Star = Bad

            // Cobalt on Silver = Unstoppable 
            // Cobalt on Gold = Godlike 
            // Cobalt on Platinum = Amazing
            // Cobalt on Cobalt = Better 
            // Cobalt on Star = Good

            // Star on Silver = Perfect 
            // Star on Gold = Unstoppable
            // Star on Platinum = Godlike
            // Star on Cobalt = Amazing
            // Star on Star = Better

            if (isCopperPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 120;
                mining.oreName.Text = "Mining Silver (Copper Pickaxe)";
                mining.ShowDialog();
                Engine.silverOreTotal++;
                silverOreTake = silverOreTakeRandom.Next(1, 6);
                Engine.silverOreTake = Engine.silverOreTake + silverOreTake;
                if (silverOreTake < 2)
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isCopperPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 140;
                mining.oreName.Text = "Mining Gold (Copper Pickaxe)";
                mining.ShowDialog();
                Engine.goldOreTotal++;
                MessageBox.Show("You have gained 0 Gold Ingots!", "Mined!", MessageBoxButtons.OK);
                totalGold.Text = "Gold Ore Mine: " + Engine.goldOreTotal;
            }
            else if (isCopperPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 160;
                mining.oreName.Text = "Mining Platinum (Copper Pickaxe)";
                mining.ShowDialog();
                Engine.platinumOreTotal++;
                MessageBox.Show("You have gained 0 Platinum Ingots!", "Mined!", MessageBoxButtons.OK);
                platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isCopperPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 180;
                mining.oreName.Text = "Mining Cobalt (Copper Pickaxe)";
                mining.ShowDialog();
                Engine.cobaltOreTotal++;
                MessageBox.Show("You have gained 0 Cobalt Ingots!", "Mined!", MessageBoxButtons.OK);
                cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.cobaltOreTotal;
            }
            else if (isCopperPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 200;
                mining.oreName.Text = "Mining Star (Copper Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                MessageBox.Show("You have gained 0 Star Ingots!", "Mined!", MessageBoxButtons.OK);
                starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isSilverPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 100;
                mining.oreName.Text = "Mining Silver (Silver Pickaxe)";
                mining.ShowDialog();
                Engine.silverOreTotal++;
                silverOreTake = silverOreTakeRandom.Next(1, 6);
                Engine.silverOreTake = Engine.silverOreTake + silverOreTake;
                if (silverOreTake < 2)
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isSilverPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 120;
                mining.oreName.Text = "Mining Gold (Silver Pickaxe)";
                mining.ShowDialog();
                Engine.goldOreTotal++;
                goldOreTake = goldOreTakeRandom.Next(1, 6);
                Engine.goldOreTake = Engine.goldOreTake + goldOreTake;
                if (goldOreTake < 2)
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                totalGold.Text = "Gold Ore Mine: " + Engine.goldOreTotal;
            }
            else if (isSilverPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 140;
                mining.oreName.Text = "Mining Platinum (Silver Pickaxe)";
                mining.ShowDialog();
                Engine.platinumOreTotal++;
                MessageBox.Show("You have gained 0 Platinum Ingots!", "Mined!", MessageBoxButtons.OK);
                platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isSilverPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 160;
                mining.oreName.Text = "Mining Cobalt (Silver Pickaxe)";
                mining.ShowDialog();
                Engine.cobaltOreTotal++;
                MessageBox.Show("You have gained 0 Cobalt Ingots!", "Mined!", MessageBoxButtons.OK);
                cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.cobaltOreTotal;
            }
            else if (isSilverPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 180;
                mining.oreName.Text = "Mining Star (Silver Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                MessageBox.Show("You have gained 0 Star Ingots!", "Mined!", MessageBoxButtons.OK);
                starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isGoldPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 80;
                mining.oreName.Text = "Mining Silver (Gold Pickaxe)";
                mining.ShowDialog();
                Engine.silverOreTotal++;
                silverOreTake = silverOreTakeRandom.Next(1, 6);
                Engine.silverOreTake = Engine.silverOreTake + silverOreTake;
                if (silverOreTake < 2)
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isGoldPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 100;
                mining.oreName.Text = "Mining Gold (Gold Pickaxe)";
                mining.ShowDialog();
                Engine.goldOreTotal++;
                goldOreTake = goldOreTakeRandom.Next(1, 6);
                Engine.goldOreTake = Engine.goldOreTake + goldOreTake;
                if (goldOreTake < 2)
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isGoldPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 120;
                mining.oreName.Text = "Mining Platinum (Gold Pickaxe)";
                mining.ShowDialog();
                Engine.platinumOreTotal++;
                platOreTake = platOreTakeRandom.Next(1, 6);
                Engine.platinumOreTake = Engine.platinumOreTake + platOreTake;
                if (platOreTake < 2)
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isGoldPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 140;
                mining.oreName.Text = "Mining Cobalt (Gold Pickaxe)";
                mining.ShowDialog();
                Engine.cobaltOreTotal++;
                MessageBox.Show("You have gained 0 Cobalt Ingots!", "Mined!", MessageBoxButtons.OK);
                cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.cobaltOreTotal;
            }
            else if (isGoldPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 160;
                mining.oreName.Text = "Mining Star (Gold Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                MessageBox.Show("You have gained 0 Star Ingots!", "Mined!", MessageBoxButtons.OK);
                starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 60;
                mining.oreName.Text = "Mining Silver (Platinum Pickaxe)";
                mining.ShowDialog();
                Engine.silverOreTotal++;
                silverOreTake = silverOreTakeRandom.Next(1, 6);
                Engine.silverOreTake = Engine.silverOreTake + silverOreTake;
                if (silverOreTake < 2)
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 80;
                mining.oreName.Text = "Mining Gold (Platinum Pickaxe)";
                mining.ShowDialog();
                Engine.goldOreTotal++;
                goldOreTake = goldOreTakeRandom.Next(1, 6);
                Engine.goldOreTake = Engine.goldOreTake + goldOreTake;
                if (goldOreTake < 2)
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 100;
                mining.oreName.Text = "Mining Platinum (Platinum Pickaxe)";
                mining.ShowDialog();
                Engine.platinumOreTotal++;
                platOreTake = platOreTakeRandom.Next(1, 6);
                Engine.platinumOreTake = Engine.platinumOreTake + platOreTake;
                if (platOreTake < 2)
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 120;
                mining.oreName.Text = "Mining Cobalt (Platinum Pickaxe)";
                mining.ShowDialog();
                Engine.cobaltOreTotal++;
                cobOreTake = cobOreTakeRandom.Next(1, 6);
                Engine.cobaltOreTake = Engine.cobaltOreTake + cobOreTake;
                if (cobOreTake < 2)
                {
                    MessageBox.Show("You have gained " + cobOreTake + " Cobalt Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + cobOreTake + " Cobalt Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 140;
                mining.oreName.Text = "Mining Star (Platinum Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                MessageBox.Show("You have gained 0 Star Ingots!", "Mined!", MessageBoxButtons.OK);
                starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isCobaltPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 40;
                mining.oreName.Text = "Mining Silver (Cobalt Pickaxe)";
                mining.ShowDialog();
                Engine.silverOreTotal++;
                silverOreTake = silverOreTakeRandom.Next(1, 6);
                Engine.silverOreTake = Engine.silverOreTake + silverOreTake;
                if (silverOreTake < 2)
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isCobaltPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 60;
                mining.oreName.Text = "Mining Gold (Cobalt Pickaxe)";
                mining.ShowDialog();
                Engine.goldOreTotal++;
                goldOreTake = goldOreTakeRandom.Next(1, 6);
                Engine.goldOreTake = Engine.goldOreTake + goldOreTake;
                if (goldOreTake < 2)
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isCobaltPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 80;
                mining.oreName.Text = "Mining Platinum (Cobalt Pickaxe)";
                mining.ShowDialog();
                Engine.platinumOreTotal++;
                platOreTake = platOreTakeRandom.Next(1, 6);
                Engine.platinumOreTake = Engine.platinumOreTake + platOreTake;
                if (platOreTake < 2)
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isCobaltPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 100;
                mining.oreName.Text = "Mining Cobalt (Cobalt Pickaxe)";
                mining.ShowDialog();
                Engine.cobaltOreTotal++;
                cobOreTake = cobOreTakeRandom.Next(1, 6);
                Engine.cobaltOreTake = Engine.cobaltOreTake + cobOreTake;
                if (cobOreTake < 2)
                {
                    MessageBox.Show("You have gained " + cobOreTake + " Cobalt Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + cobOreTake + " Cobalt Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isCobaltPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 120;
                mining.oreName.Text = "Mining Star (Cobalt Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                starOreTake = starOreTakeRancom.Next(1, 6);
                Engine.starOreTake = Engine.starOreTake + starOreTake;
                if (starOreTake < 2)
                {
                    MessageBox.Show("You have gained " + starOreTake + " Star Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + starOreTake + " Star Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isStarPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 20;
                mining.oreName.Text = "Mining Silver (Star Pickaxe)";
                mining.ShowDialog();
                Engine.silverOreTotal++;
                silverOreTake = silverOreTakeRandom.Next(1, 6);
                Engine.silverOreTake = Engine.silverOreTake + silverOreTake;
                if (silverOreTake < 2)
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + silverOreTake + " SIlver Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isStarPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 40;
                mining.oreName.Text = "Mining Gold (Star Pickaxe)";
                mining.ShowDialog();
                Engine.goldOreTotal++;
                goldOreTake = goldOreTakeRandom.Next(1, 6);
                Engine.goldOreTake = Engine.goldOreTake + goldOreTake;
                if (goldOreTake < 2)
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + goldOreTake + " Gold Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isStarPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 60;
                mining.oreName.Text = "Mining Platinum (Star Pickaxe)";
                mining.ShowDialog();
                Engine.platinumOreTotal++;
                platOreTake = platOreTakeRandom.Next(1, 6);
                Engine.platinumOreTake = Engine.platinumOreTake + platOreTake;
                if (platOreTake < 2)
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + platOreTake + " Platinum Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isStarPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 80;
                mining.oreName.Text = "Mining Cobalt (Star Pickaxe)";
                mining.ShowDialog();
                Engine.cobaltOreTotal++;
                cobOreTake = cobOreTakeRandom.Next(1, 6);
                Engine.cobaltOreTake = Engine.cobaltOreTake + cobOreTake;
                if (cobOreTake < 2)
                {
                    MessageBox.Show("You have gained " + cobOreTake + " Cobalt Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + cobOreTake + " Cobalt Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isStarPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.progressBar1.Maximum = 100;
                mining.oreName.Text = "Mining Star (Star Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                starOreTake = starOreTakeRancom.Next(1, 6);
                Engine.starOreTake = Engine.starOreTake + starOreTake;
                if (starOreTake < 2)
                {
                    MessageBox.Show("You have gained " + starOreTake + " Star Ingot!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You have gained " + starOreTake + " Star Ingots!" + "\r\n"
                    + "Added to Invetory!", "Mined!", MessageBoxButtons.OK);
                }
                starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else
            {
                var notEquipped = MessageBox.Show("You haven't equipped a pickaxe or chosen an ore", "Warning!", MessageBoxButtons.OK);
            }

            if (Engine.silverOreTotal == 100)
            {
                if (Engine.silverSword == false)
                {
                    Engine.silverSword = true;
                    Engine.silverSwordAdd = 1;
                    if (newSwords != null)
                    {
                        newSwords.UpdadeScreen();
                    }
                    var yay = MessageBox.Show("You have unlocked The SIlver Sword!", "Congratulations!", MessageBoxButtons.OK);
                }
            }
            else if (Engine.goldOreTotal == 100)
            {
                if (Engine.goldSword == false)
                {
                    Engine.goldSword = true;
                    Engine.goldSwordAdd = 2;
                    var yay = MessageBox.Show("You have unlocked The Gold Sword!", "Congratulations!", MessageBoxButtons.OK);
                    if (newSwords != null)
                    {
                        newSwords.UpdadeScreen();
                    }
                }
            }
            else if (Engine.platinumOreTotal == 100)
            {
                if (Engine.platinumSword == false)
                {
                    Engine.platinumSword = true;
                    Engine.platinumSwordAdd = 3;
                    var yay = MessageBox.Show("You have unlocked The Platinum Sword!", "Congratulations!", MessageBoxButtons.OK);
                    if (newSwords != null)
                    {
                        newSwords.UpdadeScreen();
                    }
                }
            }
            else if (Engine.cobaltOreTotal == 100)
            {
                if (Engine.cobaltSword == false)
                {
                    Engine.cobaltSword = true;
                    Engine.cobaltSwordAdd = 4;
                    var yay = MessageBox.Show("You have unlocked The Cobalt Sword!", "Congratulations!", MessageBoxButtons.OK);
                    if (newSwords != null)
                    {
                        newSwords.UpdadeScreen();
                    }
                }
            }
            else if (Engine.starOreTotal == 100)
            {
                if (Engine.starSword == false)
                {
                    Engine.starSword = true;
                    Engine.starSwordAdd = 5;
                    var yay = MessageBox.Show("You have unlocked The Star Sword!", "Congratulations!", MessageBoxButtons.OK);
                    if (newSwords != null)
                    {
                        newSwords.UpdadeScreen();
                    }
                }
            }
        }

        private void Mine_Load(object sender, EventArgs e)
        {
            titalSilver.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.cobaltOreTotal;
            starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
        }

        public Interfaces newSwords;
    }
} 