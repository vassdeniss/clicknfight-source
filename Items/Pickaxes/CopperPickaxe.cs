using ClickNFight.Items.Ores;

using static ClickNFight.Items.Pickaxes.PickaxeSettings;

namespace ClickNFight.Items.Pickaxes
{
    public class CopperPickaxe : Pickaxe
    {
        public CopperPickaxe()
        {
            this.Name = CopperPickaxeName;
            this.Limit = CopperPickaxeLimit;

            this.BuyPrice = CopperPickaxeBuyPrice;
            this.Mines = CopperPickaxeMines;
            this.RequiredOreType = CopperPickaxeRequiredOreType;
            this.RequiredOre = CopperPickaxeRequiredOre;
            this.Strength = CopperPickaxeStrength;
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
