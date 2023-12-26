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

        private readonly Hero _hero;
        private Pickaxe _currentPick;
        private Ore _currentOre;

        public Mine()
        {
            this.InitializeComponent();
        }

        public Mine(Hero hero)
            : this()
        {
            this._hero = hero;

            foreach (Pickaxe pick in this._hero.Inventory.Pickaxes)
            {
                this.pickaxeComboBox.Items.Add(pick);
            }
            this.pickaxeComboBox.Text = "Choose a pickaxe";
            this._currentPick = null;

            foreach (Ore ore in this._hero.Inventory.Ores.Keys)
            {
                this.oreComboBox.Items.Add(ore);
            }
            this.oreComboBox.Text = "Choose an ore";
            this.oreComboBox.DisplayMember = "MineString";
            this._currentOre = null;

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

            this._currentPick = this.pickaxeComboBox.SelectedItem as Pickaxe;
            this.pickLabel.Text = $"Pickaxe Equipped: {this._currentPick.Name}";
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

            this._currentOre = this.oreComboBox.SelectedItem as Ore;
            this.oreLabel.Text = $"Ore Picked: {this._currentOre.MineString}";
        }

        private void MineButton_Click(object sender, EventArgs e)
        {
            if (this._currentPick is null || this._currentOre is null)
            {
                MessageBox.Show(
                    "Please select pickaxe and ore",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            MiningOres miner = new MiningOres();
            int strength = this._currentPick.Strength - this._currentOre.Strength;
            miner.miningBar.Maximum = Base - Step * (strength + 1);
            miner.oreName.Text = $"Mining {this._currentOre.Type} ({this._currentPick.Name})";
            miner.ShowDialog();

            Random randomYield = new Random();
            int yield = strength < -1 ? 0 : randomYield.Next(1, 6);

            this._hero.Inventory.Add(this._currentOre, yield);
            this.UpdateTotal(yield);
            this.UpdateUi();

            string plural = yield == 1 ? "Ingot" : "Ingots";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"You have gained {yield} {this._currentOre.Type} {plural}!");
            sb.AppendLine("Added to inventory!");

            MessageBox.Show(sb.ToString(), "Mined!", MessageBoxButtons.OK);

            this.SwordCheck();
        }

        private void UpdateTotal(int mined)
        {
            if (!this._hero.MineStats.ContainsKey(this._currentOre.MineString))
            {
                this._hero.MineStats.Add(this._currentOre.MineString, 0);
            }

            this._hero.MineStats[this._currentOre.MineString] += mined;
        }

        private void SwordCheck()
        {
            Weapon weapon = Utils.MineSwords[(int)this._currentOre.Type];
            if (this._hero.MineStats[this._currentOre.MineString] < 100 || this._hero.Inventory.HasItem(weapon))
            {
                return;
            }

            this._hero.Inventory.UnlockItem(weapon, 1);
            MessageBox.Show(
                $"You unlocked the {weapon.Name}",
                "Congratulations!",
                MessageBoxButtons.OK);
        }

        private void UpdateUi()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> ore in this._hero.MineStats)
            {
                sb.AppendLine($"{ore.Key} Mined: {ore.Value}");
            }

            this.oreStatsLabel.Text = sb.ToString();
        }
    }
} 
