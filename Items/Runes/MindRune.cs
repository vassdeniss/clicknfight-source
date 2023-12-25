using static ClickNFight.Items.Runes.RuneSettings;

namespace ClickNFight.Items.Runes
{
    public class MindRune : Rune
    {
        public MindRune()
        {
            this.Name = MindRuneName;
            this.BuyPrice = MindRuneBuyPrice;
            this.Limit = MindRuneBuyLimit;
            this.Level = MindRuneLevel;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override RuneLevelType Level { get; set; }
    }
}
