using ClickNFight.Items.Ores;

using static ClickNFight.Items.Pickaxes.PickaxeSettings;

namespace ClickNFight.Items.Pickaxes
{
    public class StartPickaxe : Pickaxe
    {
        public StartPickaxe()
        {
            this.Name = StarPickaxeName;
            this.Limit = StarPickaxeLimit;

            this.BuyPrice = StarPickaxeBuyPrice;
            this.Mines = StarPickaxeMines;
            this.RequiredOreType = StarPickaxeRequiredOreType;
            this.RequiredOre = StarPickaxeRequiredOre;
            this.Strength = StarPickaxeStrength;
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
