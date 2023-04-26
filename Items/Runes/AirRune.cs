using System.CodeDom;
using System.Text;

using static ClickNFight.Items.Runes.RuneSettings;

namespace ClickNFight.Items.Runes
{
    public class AirRune : Rune
    {
        public AirRune()
        {
            this.Name = AirRuneName;
            this.BuyPrice = AirRuneBuyPrice;
            this.Limit = AirRuneBuyLimit;
            this.Level = AirRuneLevel;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override RuneLevelType Level { get; set; }

        public override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine("Used for casting magic spells");
            sb.AppendLine($"{this.BuyPrice} Clicks");
            sb.AppendLine("No buy limit");

            return sb.ToString();
        }
    }
}
