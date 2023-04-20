using ClickNFight.Items.Ores;

using static ClickNFight.Items.Pickaxes.PickaxeSettings;

namespace ClickNFight.Items.Pickaxes
{
    public class PlatinumPickaxe : Pickaxe
    {
        public PlatinumPickaxe()
        {
            this.Name = PlatinumPickaxeName;
            this.Limit = PlatinumPickaxeLimit;

            this.BuyPrice = PlatinumPickaxeBuyPrice;
            this.Mines = PlatinumPickaxeMines;
            this.RequiredOreType = PlatinumPickaxeRequiredOreType;
            this.RequiredOre = PlatinumPickaxeRequiredOre;
            this.Strength = PlatinumPickaxeStrength;
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
