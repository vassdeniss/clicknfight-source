using System;
using System.Text;

namespace ClickNFight.Items.Consumables
{
    public abstract class Consumable : Item
    {
        public abstract int HealAmount { get; set; }
    
        public sealed override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Regenerates health by {this.HealAmount} points");
            sb.AppendLine($"{this.BuyPrice} Clicks");
            sb.AppendLine("No buy limit");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}Heal Amount: {this.HealAmount}";
        }
    }
}
