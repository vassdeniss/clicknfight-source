using System.Collections.Generic;

using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Weapons;

namespace ClickNFight
{
    public class Utils
    {
        // TODO: auto unlock copper pick
        public static IDictionary<int, Item[]> ItemsPerLevel = new Dictionary<int, Item[]>()
        {
            { 2, new Item[] { new WoodenSword() } },
            { 3, new Item[] { new StoneSword(), new UpgradedHealthPotion(), new CopperPickaxe(), new Ore(OreType.Silver) } },
            { 4, new Item[] { new SilverPickaxe(), new Ore(OreType.Gold), new IronSword() } },
            { 5, new Item[] { new GoldPickaxe(), new Ore(OreType.Platinum), new SuperHealthPotion() } },
            //{ 2, new Item[] { new WoodenSword() } },
            //{ 2, new Item[] { new WoodenSword() } },
            //{ 2, new Item[] { new WoodenSword() } },
        };

        public static IDictionary<int, Weapon> MineSwords = new Dictionary<int, Weapon>()
        {
            { 1, new SilverSword() },
            { 2, new GoldSword() },
            { 3, new PlatinumSword() },
            { 4, new CobaltSword() },
            { 5, new StarSword() },
        };
    }
}
