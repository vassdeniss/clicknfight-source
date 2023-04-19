using ClickNFight.Items.Ores;

using static ClickNFight.Items.Pickaxes.PickaxeSettings;

namespace ClickNFight.Items.Pickaxes
{
    public class SilverPickaxe : Pickaxe
    {
        public SilverPickaxe()
        {
            this.Name = SilverPickaxeName;
            this.Limit = SilverPickaxeLimit;

            this.BuyPrice = SilverPickaxeBuyPrice;
            this.Mines = SilverPickaxeMines;
            this.RequiredOreType = SilverPickaxeRequiredOreType;
            this.RequiredOre = SilverPickaxeRequiredOre;
            this.Strength = SilverPickaxeStrength;
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
