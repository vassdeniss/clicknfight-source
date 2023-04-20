using ClickNFight.Items.Ores;

using static ClickNFight.Items.Pickaxes.PickaxeSettings;

namespace ClickNFight.Items.Pickaxes
{
    public class CobaltPickaxe : Pickaxe
    {
        public CobaltPickaxe()
        {
            this.Name = CobaltPickaxeName;
            this.Limit = CobaltPickaxeLimit;

            this.BuyPrice = CobaltPickaxeBuyPrice;
            this.Mines = CobaltPickaxeMines;
            this.RequiredOreType = CobaltPickaxeRequiredOreType;
            this.RequiredOre = CobaltPickaxeRequiredOre;
            this.Strength = CobaltPickaxeStrength;
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
