﻿using System.Text;

using static ClickNFight.Items.Runes.RuneSettings;

namespace ClickNFight.Items.Runes
{
    public class FireRune : Rune
    {
        public FireRune()
        {
            this.Name = FireRuneName;
            this.BuyPrice = FireRuneBuyPrice;
            this.Limit = FireRuneBuyLimit;
            this.Level = FireRuneLevel;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override RuneLevelType Level { get; set; }
    }
}
