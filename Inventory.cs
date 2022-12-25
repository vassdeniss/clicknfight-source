﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class Inventory : Form
    {
        private readonly Hero hero;

        public Inventory()
        {
            this.InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        public Inventory(Hero hero)
            : this()
        {
            this.hero = hero;

            this.potionsTextBox.Text = this.GenerateText<Consumable>("Consumables:", this.hero.Potions);
            this.weaponsTextBox.Text = this.GenerateText<Weapon>("Weapons:", this.hero.Weapons);

            runes.Text = "Runes:";
            ores.Text = "Ingots:";
            picks.Text = "Pickaxes:";

            // "Upgraded Health Potion" "Heal Value: 25"
            // "Super Health Potion" "Heal Value: 55"
            // "Ultra Health Potion" "Heal Value: 115"

            // "Wooden Sword" "Total Damage: " + Engine.woodenSword * 0.5, 10
            // "Stone Sword" "Total Damage: " + Engine.stoneSword * 1, 7
            // "Iron Sword" "Total Damage: " + Engine.ironSword * 2, 5;
            // "Diamond Sword" "Total Damage: " + Engine.diamondSword * 4, 3;

            if (Engine.silverSword == true)
            {
                string invSS = "\r\n" + "Silver Sword" + "\r\n" + "Total Damage: 1" + "\r\n";
                weaponsTextBox.Text += invSS;
            }

            if (Engine.goldSword == true)
            {
                string invGS = "\r\n" + "Gold Sword" + "\r\n" + "Total Damage: 2" + "\r\n";
                weaponsTextBox.Text += invGS;
            }

            if (Engine.platinumSword == true)
            {
                string invPS = "\r\n" + "Platinum Sword" + "\r\n" + "Total Damage: 3" + "\r\n";
                weaponsTextBox.Text += invPS;
            }

            if (Engine.cobaltSword == true)
            {
                string invCS = "\r\n" + "Cobalt Sword" + "\r\n" + "Total Damage: 4" + "\r\n";
                weaponsTextBox.Text += invCS;
            }

            if (Engine.starSword == true)
            {
                string invSS = "\r\n" + "Star Sword" + "\r\n" + "Total Damage: 5" + "\r\n";
                weaponsTextBox.Text += invSS;
            }

            if (Engine.excalibur > 0)
            {
                string invEX = "\r\n" + "Excalibur" + "\r\n" + "Total Damage: 999" + "\r\n";
                weaponsTextBox.Text += invEX;
            }

            if (Engine.airRunes > 0)
            {
                string invAR = "\r\n" + "Air Runes" + "\r\n" + "Count: " + Engine.airRunes + "\r\n";
                runes.Text += invAR;
            }

            if (Engine.fireRunes > 0)
            {
                string invFR = "\r\n" + "Fire Runes" + "\r\n" + "Count: " + Engine.fireRunes + "\r\n";
                runes.Text += invFR;
            }

            if (Engine.earthRunes > 0)
            {
                string invER = "\r\n" + "Earth Runes" + "\r\n" + "Count: " + Engine.earthRunes + "\r\n";
                runes.Text += invER;
            }

            if (Engine.mindRunes > 0)
            {
                string invMR = "\r\n" + "Mind Runes" + "\r\n" + "Count: " + Engine.mindRunes + "\r\n";
                runes.Text += invMR;
            }

            if (Engine.waterRunes > 0)
            {
                string invWR = "\r\n" + "Water Runes" + "\r\n" + "Count: " + Engine.waterRunes + "\r\n";
                runes.Text += invWR;
            }

            if (Engine.lavaRunes > 0)
            {
                string invLR = "\r\n" + "Lava Runes" + "\r\n" + "Count: " + Engine.lavaRunes + "\r\n";
                runes.Text += invLR;
            }

            if (Engine.natureRunes > 0)
            {
                string invNR = "\r\n" + "Nature Runes" + "\r\n" + "Count: " + Engine.natureRunes + "\r\n";
                runes.Text += invNR;
            }

            if (Engine.electricRunes > 0)
            {
                string invElR = "\r\n" + "Electric Runes" + "\r\n" + "Count: " + Engine.electricRunes + "\r\n";
                runes.Text += invElR;
            }

            if (Engine.steamRunes > 0)
            {
                string invSR = "\r\n" + "Steam Runes" + "\r\n" + "Count: " + Engine.steamRunes + "\r\n";
                runes.Text += invSR;
            }

            if (Engine.reviveRunes > 0)
            {
                string invRR = "\r\n" + "Revive Runes" + "\r\n" + "Count: " + Engine.reviveRunes + "\r\n";
                runes.Text += invRR;
            }

            if (Engine.bloodRunes > 0)
            {
                string invBR = "\r\n" + "Blood Runes" + "\r\n" + "Count: " + Engine.bloodRunes + "\r\n";
                runes.Text += invBR;
            }

            if (Engine.cosmicRunes > 0)
            {
                string invCR = "\r\n" + "Cosmic Runes" + "\r\n" + "Count: " + Engine.cosmicRunes + "\r\n";
                runes.Text += invCR;
            }

            if (Engine.lifeRunes > 0)
            {
                string invLR = "\r\n" + "Life Runes" + "\r\n" + "Count: " + Engine.lifeRunes + "\r\n";
                runes.Text += invLR;
            }

            if (Engine.wrathRunes > 0)
            {
                string invWR = "\r\n" + "Wrath Runes" + "\r\n" + "Count: " + Engine.wrathRunes + "\r\n";
                runes.Text += invWR;
            }

            if (Engine.astralRunes > 0)
            {
                string invAAR = "\r\n" + "Astral Runes" + "\r\n" + "Count: " + Engine.astralRunes + "\r\n";
                runes.Text += invAAR;
            }

            if (Engine.soulRunes > 0)
            {
                string invSoS = "\r\n" + "Soul Runes" + "\r\n" + "Count: " + Engine.soulRunes + "\r\n";
                runes.Text += invSoS;
            }

            if (Engine.level >= 3)
            {
                string invCP = "\r\n" + "Copper Pickaxe" + "\r\n";
                picks.Text += invCP;
            }

            if (Engine.silverPick == true)
            {
                string invSP = "\r\n" + "Silver Pickaxe" + "\r\n";
                picks.Text += invSP;
            }

            if (Engine.goldPick == true)
            {
                string invSP = "\r\n" + "Gold Pickaxe" + "\r\n";
                picks.Text += invSP;
            }

            if (Engine.platPick == true)
            {
                string invPP = "\r\n" + "Platinum Pickaxe" + "\r\n";
                picks.Text += invPP;
            }

            if (Engine.cobPick == true)
            {
                string invCP = "\r\n" + "Cobalt Pickaxe" + "\r\n";
                picks.Text += invCP;
            }

            if (Engine.starPick == true)
            {
                string invSP = "\r\n" + "Star Pickaxe" + "\r\n";
                picks.Text += invSP;
            }

            if (Engine.silverOreTake > 0)
            {
                string invSO = "\r\n" + "Silver Ingots" + "\r\n" + "Count: " + Engine.silverOreTake + "\r\n";
                ores.Text += invSO;
            }

            if (Engine.goldOreTake > 0)
            {
                string invGO = "\r\n" + "Gold Ingots" + "\r\n" + "Count: " + Engine.goldOreTake + "\r\n";
                ores.Text += invGO;
            }

            if (Engine.platinumOreTake > 0)
            {
                string invGO = "\r\n" + "Platinum Ingots" + "\r\n" + "Count: " + Engine.platinumOreTake + "\r\n";
                ores.Text += invGO;
            }

            if (Engine.cobaltOreTake > 0)
            {
                string invCO = "\r\n" + "Cobalt Ingots" + "\r\n" + "Count: " + Engine.cobaltOreTake + "\r\n";
                ores.Text += invCO;
            }

            if (Engine.starOreTake > 0)
            {
                string invSO = "\r\n" + "Star Ingots" + "\r\n" + "Count: " + Engine.starOreTake + "\r\n";
                ores.Text += invSO;
            }
        }

        private string GenerateText<T>(string labelText, ICollection<T> collection)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(labelText);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (T item in collection)
            {
                if (!dic.ContainsKey(item.ToString()))
                {
                    dic.Add(item.ToString(), 0);
                }

                dic[item.ToString()]++;
            }

            foreach (KeyValuePair<string, int> descriptionCount in dic)
            {
                sb.AppendLine(descriptionCount.Key);
                sb.AppendLine($"Count: {descriptionCount.Value}");
            }

            return sb.ToString();
        }
    }
}