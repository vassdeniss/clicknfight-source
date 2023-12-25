using System.Collections.Generic;
using System.Text;

namespace ClickNFight.Items.Runes
{
    public abstract class Rune : BuyableItem
    {
        public abstract RuneLevelType Level { get; set; }

        public override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine(this.Level == RuneLevelType.None ? "Used for casting magic" : $"Used for casting {this.Level.ToString().ToLower()} level magic");
            sb.AppendLine($"{this.BuyPrice} Clicks");
            sb.AppendLine("No buy limit");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
