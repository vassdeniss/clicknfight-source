using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Weapons;
using ClickNFight.Windows.Other;

namespace ClickNFight.Windows.Menus
{
    public partial class Mine : Form
    {
        private const int Base = 120;
        private const int Step = 20;

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

            this.SwordCheck();
        }

        private void UpdateTotal(int mined)
        {
            if (!this.hero.MineStats.ContainsKey(this.currentOre.MineString))
            {
                this.hero.MineStats.Add(this.currentOre.MineString, 0);
            }

            this.hero.MineStats[this.currentOre.MineString] += mined;
        }

        private void SwordCheck()
        {
            Weapon weapon = Utils.MineSwords[(int)this.currentOre.Type];
            if (this.hero.MineStats[this.currentOre.MineString] < 100 || this.hero.Inventory.HasItem(weapon))
            {
                return;
            }

            this.hero.Inventory.UnlockItem(weapon, 1);
            MessageBox.Show(
                $"You unlocked the {weapon.Name}",
                "Congratulations!",
                MessageBoxButtons.OK);
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
