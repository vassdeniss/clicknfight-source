using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ClickNFight.Items.Consumables;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Weapons;

namespace ClickNFight
{
    public partial class Inventory : Form
    {
        private readonly Hero hero;

        public Inventory()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.icon;
        }

        public Inventory(Hero hero)
            : this()
        {
            this.hero = hero;

            this.potionsTextBox.Text = this.GenerateText<Consumable>("Consumables:", this.hero.Inventory.Consumables);
            this.weaponsTextBox.Text = this.GenerateText<Weapon>("Weapons:", this.hero.Inventory.Weapons);
            this.picksTextBox.Text = this.GenerateText<Pickaxe>("Pickaxes:", this.hero.Inventory.Pickaxes);

            this.runesTextBox.Text = "Runes:";
            this.ores.Text = "Ingots:";
            //this.picks.Text = "Pickaxes:";

            // "Silver Sword" "Total Damage: 1";
            // "Gold Sword" "Total Damage: 2";
            // "Platinum Sword" "Total Damage: 3";
            // "Cobalt Sword" "Total Damage: 4";
            // "Star Sword""Total Damage: 5";
            // "Excalibur" "Total Damage: 999";

            if (Engine.airRunes > 0)
            {
                string invAR = "\r\n" + "Air Runes" + "\r\n" + "Count: " + Engine.airRunes + "\r\n";
                runesTextBox.Text += invAR;
            }

            if (Engine.fireRunes > 0)
            {
                string invFR = "\r\n" + "Fire Runes" + "\r\n" + "Count: " + Engine.fireRunes + "\r\n";
                runesTextBox.Text += invFR;
            }

            if (Engine.earthRunes > 0)
            {
                string invER = "\r\n" + "Earth Runes" + "\r\n" + "Count: " + Engine.earthRunes + "\r\n";
                runesTextBox.Text += invER;
            }

            if (Engine.mindRunes > 0)
            {
                string invMR = "\r\n" + "Mind Runes" + "\r\n" + "Count: " + Engine.mindRunes + "\r\n";
                runesTextBox.Text += invMR;
            }

            if (Engine.waterRunes > 0)
            {
                string invWR = "\r\n" + "Water Runes" + "\r\n" + "Count: " + Engine.waterRunes + "\r\n";
                runesTextBox.Text += invWR;
            }

            if (Engine.lavaRunes > 0)
            {
                string invLR = "\r\n" + "Lava Runes" + "\r\n" + "Count: " + Engine.lavaRunes + "\r\n";
                runesTextBox.Text += invLR;
            }

            if (Engine.natureRunes > 0)
            {
                string invNR = "\r\n" + "Nature Runes" + "\r\n" + "Count: " + Engine.natureRunes + "\r\n";
                runesTextBox.Text += invNR;
            }

            if (Engine.electricRunes > 0)
            {
                string invElR = "\r\n" + "Electric Runes" + "\r\n" + "Count: " + Engine.electricRunes + "\r\n";
                runesTextBox.Text += invElR;
            }

            if (Engine.steamRunes > 0)
            {
                string invSR = "\r\n" + "Steam Runes" + "\r\n" + "Count: " + Engine.steamRunes + "\r\n";
                runesTextBox.Text += invSR;
            }

            if (Engine.reviveRunes > 0)
            {
                string invRR = "\r\n" + "Revive Runes" + "\r\n" + "Count: " + Engine.reviveRunes + "\r\n";
                runesTextBox.Text += invRR;
            }

            if (Engine.bloodRunes > 0)
            {
                string invBR = "\r\n" + "Blood Runes" + "\r\n" + "Count: " + Engine.bloodRunes + "\r\n";
                runesTextBox.Text += invBR;
            }

            if (Engine.cosmicRunes > 0)
            {
                string invCR = "\r\n" + "Cosmic Runes" + "\r\n" + "Count: " + Engine.cosmicRunes + "\r\n";
                runesTextBox.Text += invCR;
            }

            if (Engine.lifeRunes > 0)
            {
                string invLR = "\r\n" + "Life Runes" + "\r\n" + "Count: " + Engine.lifeRunes + "\r\n";
                runesTextBox.Text += invLR;
            }

            if (Engine.wrathRunes > 0)
            {
                string invWR = "\r\n" + "Wrath Runes" + "\r\n" + "Count: " + Engine.wrathRunes + "\r\n";
                runesTextBox.Text += invWR;
            }

            if (Engine.astralRunes > 0)
            {
                string invAAR = "\r\n" + "Astral Runes" + "\r\n" + "Count: " + Engine.astralRunes + "\r\n";
                runesTextBox.Text += invAAR;
            }

            if (Engine.soulRunes > 0)
            {
                string invSoS = "\r\n" + "Soul Runes" + "\r\n" + "Count: " + Engine.soulRunes + "\r\n";
                runesTextBox.Text += invSoS;
            }

            if (Engine.silverPick == true)
            {
                string invSP = "\r\n" + "Silver Pickaxe" + "\r\n";
                picksTextBox.Text += invSP;
            }

            if (Engine.goldPick == true)
            {
                string invSP = "\r\n" + "Gold Pickaxe" + "\r\n";
                picksTextBox.Text += invSP;
            }

            if (Engine.platPick == true)
            {
                string invPP = "\r\n" + "Platinum Pickaxe" + "\r\n";
                picksTextBox.Text += invPP;
            }

            if (Engine.cobPick == true)
            {
                string invCP = "\r\n" + "Cobalt Pickaxe" + "\r\n";
                picksTextBox.Text += invCP;
            }

            if (Engine.starPick == true)
            {
                string invSP = "\r\n" + "Star Pickaxe" + "\r\n";
                picksTextBox.Text += invSP;
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

        private string GenerateText<T>(string labelText, IDictionary<T, int> collection)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(labelText);

            foreach (KeyValuePair<T, int> item in collection)
            {
                sb.AppendLine(item.Key.ToString());
                sb.AppendLine($"Count: {item.Value}");
            }

            return sb.ToString();
        }

        private string GenerateText<T>(string labelText, IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(labelText);

            foreach (T item in collection)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}