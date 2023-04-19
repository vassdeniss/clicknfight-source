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

        public const string GoldPickaxeName = "Gold Pickaxe";
        public const int GoldPickaxeLimit = 1;
        public const int GoldPickaxeBuyPrice = 200;
        public const int GoldPickaxeRequiredOre = 30;
        public const OreType GoldPickaxeRequiredOreType = OreType.Gold;
        public const OreType GoldPickaxeMines = OreType.Platinum;
        public const int GoldPickaxeStrength = 2;

        public const string PlatinumPickaxeName = "Platinum Pickaxe";
        public const int PlatinumPickaxeLimit = 1;
        public const int PlatinumPickaxeBuyPrice = 300;
        public const int PlatinumPickaxeRequiredOre = 40;
        public const OreType PlatinumPickaxeRequiredOreType = OreType.Platinum;
        public const OreType PlatinumPickaxeMines = OreType.Cobalt;
        public const int PlatinumPickaxeStrength = 3;

        public const string CobaltPickaxeName = "Cobalt Pickaxe";
        public const int CobaltPickaxeLimit = 1;
        public const int CobaltPickaxeBuyPrice = 400;
        public const int CobaltPickaxeRequiredOre = 50;
        public const OreType CobaltPickaxeRequiredOreType = OreType.Cobalt;
        public const OreType CobaltPickaxeMines = OreType.Star;
        public const int CobaltPickaxeStrength = 4;

        public const string StarPickaxeName = "Star Pickaxe";
        public const int StarPickaxeLimit = 1;
        public const int StarPickaxeBuyPrice = 500;
        public const int StarPickaxeRequiredOre = 60;
        public const OreType StarPickaxeRequiredOreType = OreType.Star;
        public const OreType StarPickaxeMines = OreType.All;
        public const int StarPickaxeStrength = 5;
    }
}
