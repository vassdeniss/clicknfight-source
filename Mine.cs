using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;

namespace ClickNFight
{
    public partial class Mine : Form
    {
        private const int Base = 120;
        private const int Step = 20;

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

        private readonly Hero hero;
        private Pickaxe currentPick;
        private Ore currentOre;

        public Mine()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.icon;
        }

        public Mine(Hero hero)
            : this()
        {
            this.hero = hero;

            foreach (Pickaxe pick in this.hero.Inventory.Pickaxes)
            {
                this.pickaxeComboBox.Items.Add(pick);
            }
            this.pickaxeComboBox.Text = "Choose a pickaxe";
            this.currentPick = null;

            foreach (Ore ore in this.hero.Inventory.Ores.Keys)
            {
                this.oreComboBox.Items.Add(ore);
            }
            this.oreComboBox.Text = "Choose an ore";
            this.oreComboBox.DisplayMember = "MineString";
            this.currentOre = null;

            this.UpdateUi();
        }

        private void PickaxeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.pickaxeComboBox.SelectedIndex is -1)
            {
                MessageBox.Show(
                    "Select a pickaxe from the list",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            this.currentPick = this.pickaxeComboBox.SelectedItem as Pickaxe;
            this.pickLabel.Text = $"Pickaxe Equipped: {this.currentPick.Name}";
        }

        private void OreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.oreComboBox.SelectedIndex is -1)
            {
                MessageBox.Show(
                    "Select an ore from the list",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            this.currentOre = this.oreComboBox.SelectedItem as Ore;
            this.oreLabel.Text = $"Ore Picked: {this.currentOre.MineString}";
        }

        private void UpdateTotal(int mined)
        {
            if (!this.hero.MineStats.ContainsKey(this.currentOre.Name))
            {
                this.hero.MineStats.Add(this.currentOre.MineString, 0);
            }

            this.hero.MineStats[this.currentOre.MineString] += mined;
        }

        private void MineButton_Click(object sender, EventArgs e)
        {
            if (this.currentPick is null || this.currentOre is null)
            {
                MessageBox.Show(
                    "Please select pickaxe and ore",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            MiningOres miner = new MiningOres();
            int strength = this.currentPick.Strength - this.currentOre.Strength;
            miner.miningBar.Maximum = Base - Step * (strength + 1);
            miner.oreName.Text = $"Mining {this.currentOre.Type} ({this.currentPick.Name})";
            miner.ShowDialog();

            Random randomYield = new Random();
            int yield = strength < -1 ? 0 : randomYield.Next(1, 6);
            
            this.hero.Inventory.Add(this.currentOre, yield);
            this.UpdateTotal(yield);
            this.UpdateUi();

            string plural = yield == 1 ? "Ingot" : "Ingots";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"You have gained {yield} {this.currentOre.Type} {plural}!");
            sb.AppendLine("Added to inventory!");

            MessageBox.Show(sb.ToString(), "Mined!", MessageBoxButtons.OK);
            return;

            if (isPlatinumPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 60;
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
                oreStatsLabel.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 80;
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
                //totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 100;
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
                //platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 120;
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
                //cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isPlatinumPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 140;
                mining.oreName.Text = "Mining Star (Platinum Pickaxe)";
                mining.ShowDialog();
                Engine.starOreTotal++;
                MessageBox.Show("You have gained 0 Star Ingots!", "Mined!", MessageBoxButtons.OK);
                //starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isCobaltPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 40;
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
                oreStatsLabel.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isCobaltPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 60;
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
                //totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isCobaltPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 80;
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
                //platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isCobaltPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 100;
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
                //cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isCobaltPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 120;
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
                //starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }
            else if (isStarPickEquipped == true && isSilverOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 20;
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
                oreStatsLabel.Text = "Silver Ore Mined: " + Engine.silverOreTotal;
            }
            else if (isStarPickEquipped == true && isGoldOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 40;
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
                //totalGold.Text = "Gold Ore Mined: " + Engine.goldOreTotal;
            }
            else if (isStarPickEquipped == true && isPlatinumOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 60;
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
                //platinumTotal.Text = "Platinum Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isStarPickEquipped == true && isCobaltOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 80;
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
                //cobaltTotal.Text = "Cobalt Ore Mined: " + Engine.platinumOreTotal;
            }
            else if (isStarPickEquipped == true && isStarOrePicked == true)
            {
                MiningOres mining = new MiningOres();
                mining.miningBar.Maximum = 100;
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
                //starTotal.Text = "Stardust Ore Mined: " + Engine.starOreTotal;
            }

            if (Engine.silverOreTotal == 100)
            {
                if (Engine.silverSword == false)
                {
                    Engine.silverSword = true;
                    Engine.silverSwordAdd = 1;
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
                }
            }
            else if (Engine.platinumOreTotal == 100)
            {
                if (Engine.platinumSword == false)
                {
                    Engine.platinumSword = true;
                    Engine.platinumSwordAdd = 3;
                    var yay = MessageBox.Show("You have unlocked The Platinum Sword!", "Congratulations!", MessageBoxButtons.OK);
                }
            }
            else if (Engine.cobaltOreTotal == 100)
            {
                if (Engine.cobaltSword == false)
                {
                    Engine.cobaltSword = true;
                    Engine.cobaltSwordAdd = 4;
                    var yay = MessageBox.Show("You have unlocked The Cobalt Sword!", "Congratulations!", MessageBoxButtons.OK);
                }
            }
            else if (Engine.starOreTotal == 100)
            {
                if (Engine.starSword == false)
                {
                    Engine.starSword = true;
                    Engine.starSwordAdd = 5;
                    var yay = MessageBox.Show("You have unlocked The Star Sword!", "Congratulations!", MessageBoxButtons.OK);
                }
            }
        }

        private void UpdateUi()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> ore in this.hero.MineStats)
            {
                sb.AppendLine($"{ore.Key} Mined: {ore.Value}");
            }

            this.oreStatsLabel.Text = sb.ToString();
        }
    }
} 
