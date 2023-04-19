using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClickNFight.Items.Ores;

namespace ClickNFight.Items.Pickaxes
{
    public abstract class Pickaxe : BuyableItem
    {
        public abstract OreType Mines { get; set; }

        public abstract OreType RequiredOreType { get; set; }

        public abstract int RequiredOre { get; set; }

        public abstract int Strength { get; set; }

        public sealed override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Allows {this.Mines} to be mined");
            sb.AppendLine($"{this.BuyPrice} Clicks and {RequiredOre} {RequiredOreType}");

            return sb.ToString();
        }

        public override bool CanAfford(Hero hero, out string failMessage)
        {
            if (!base.CanAfford(hero, out failMessage))
            {
                return false;
            }

            KeyValuePair<Ore, int> ore = hero.Inventory.Ores
                .FirstOrDefault((kv) => kv.Key.Type == this.RequiredOreType);

            if (ore.Value < this.RequiredOre)
            {
                failMessage = "You don't have enough ore to buy this";
                return false;
            }

            failMessage = string.Empty;
            return true;
        }

        public override void BuyItem(Hero hero)
        {
            Ore ore = hero.Inventory.Ores.Keys
                .FirstOrDefault((o) => o.Type == this.RequiredOreType);

            hero.Inventory.Remove(ore, this.RequiredOre);

            base.BuyItem(hero);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
