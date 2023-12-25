using System.Text;

using static ClickNFight.Items.Runes.RuneSettings;

namespace ClickNFight.Items.Runes
{
    public class EarthRune : Rune
    {
        public EarthRune()
        {
            this.Name = EarthRuneName;
            this.BuyPrice = EarthRuneBuyPrice;
            this.Limit = EarthRuneBuyLimit;
            this.Level = EarthRuneLevel;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override RuneLevelType Level { get; set; }
    }
}
