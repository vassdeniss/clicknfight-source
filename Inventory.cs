using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClickNFight.Items.Consumables;
using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Runes;
using ClickNFight.Items.Weapons;

namespace ClickNFight
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.icon;
        }

        public Inventory(HeroInventory inventory)
            : this()
        {
            this.potionsTextBox.Text = this.GenerateText<Consumable>("Consumables:", inventory.Consumables);
            this.weaponsTextBox.Text = this.GenerateText<Weapon>("Weapons:", inventory.Weapons);
            this.runesTextBox.Text = this.GenerateText<Rune>("Runes", inventory.Runes);
            this.picksTextBox.Text = this.GenerateText<Pickaxe>("Pickaxes:", inventory.Pickaxes);
            this.oresTextBox.Text = this.GenerateText<Ore>(
                "Ingots:",
                inventory.Ores
                    .Where((kv) => kv.Value > 0)
                    .ToDictionary((kv) => kv.Key, (kv) => kv.Value));

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

            return sb.ToString().Trim();
        }

        private string GenerateText<T>(string labelText, IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(labelText);

            foreach (T item in collection)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
