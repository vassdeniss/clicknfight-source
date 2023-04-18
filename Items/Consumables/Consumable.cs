using System;
using System.Text;

namespace ClickNFight.Items.Consumables
{
    public class Consumable : Item
    {
        public Consumable(
            ConsumableType type, 
            string name, 
            int healAmount, 
            int buyPrice, 
            int limit)
        {
            this.Name = name;
            this.HealAmount = healAmount;
            this.BuyPrice = buyPrice;
            this.Limit = limit;

            this.Type = type;
            this.HealAmount = healAmount;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public ConsumableType Type { get; set; }

        public int HealAmount { get; set; }

        public sealed override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Regenerates health by {this.HealAmount} points");
            sb.AppendLine($"{this.BuyPrice} Clicks");
            sb.AppendLine("No buy limit");

            return sb.ToString();
        }

        public string ShortToString => $"{this.Name} {this.HealAmount}HP";

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}Heal Amount: {this.HealAmount}";
        }
    }
}
