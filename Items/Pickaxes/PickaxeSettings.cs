using ClickNFight.Items.Ores;

namespace ClickNFight.Items.Pickaxes
{
    public static class PickaxeSettings
    {
        public const string CopperPickaxeName = "Copper Pickaxe";
        public const int CopperPickaxeLimit = 1;
        public const int CopperPickaxeBuyPrice = -1;
        public const int CopperPickaxeRequiredOre = -1;
        public const OreType CopperPickaxeRequiredOreType = OreType.NoType;
        public const OreType CopperPickaxeMines = OreType.Silver;
        public const int CopperPickaxeStrength = 0;

        public const string SilverPickaxeName = "Silver Pickaxe";
        public const int SilverPickaxeLimit = 1;
        public const int SilverPickaxeBuyPrice = 100;
        public const int SilverPickaxeRequiredOre = 20;
        public const OreType SilverPickaxeRequiredOreType = OreType.Silver;
        public const OreType SilverPickaxeMines = OreType.Gold;
        public const int SilverPickaxeStrength = 1;

    }
}
