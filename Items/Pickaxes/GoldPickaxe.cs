using ClickNFight.Items.Ores;

using static ClickNFight.Items.Pickaxes.PickaxeSettings;

namespace ClickNFight.Items.Pickaxes
{
    public class GoldPickaxe : Pickaxe
    {
        public GoldPickaxe()
        {
            this.Name = GoldPickaxeName;
            this.Limit = GoldPickaxeLimit;

            this.BuyPrice = GoldPickaxeBuyPrice;
            this.Mines = GoldPickaxeMines;
            this.RequiredOreType = GoldPickaxeRequiredOreType;
            this.RequiredOre = GoldPickaxeRequiredOre;
            this.Strength = GoldPickaxeStrength;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override OreType Mines { get; set; }

        public sealed override int RequiredOre { get; set; }

        public sealed override OreType RequiredOreType { get; set; }

        public sealed override int Strength { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
