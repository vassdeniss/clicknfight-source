using System;
using System.Text;

namespace ClickNFight.Items.Weapons
{
    public abstract class Weapon : Item
    {
        public abstract double DamageMultiplier { get; set; }

        public override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Increases clicks by {this.DamageMultiplier:f1}");
            sb.AppendLine($"{this.BuyPrice} Clicks");
            sb.AppendLine($"Buy limit: {this.Limit}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}Damage Multiplier: {this.DamageMultiplier:f1}{Environment.NewLine}Limit: {this.Limit}";
        }
    }
}
