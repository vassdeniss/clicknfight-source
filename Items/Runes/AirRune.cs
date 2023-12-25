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
    }
}
