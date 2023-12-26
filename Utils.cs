using System;
using System.Collections.Generic;

using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Runes;
using ClickNFight.Items.Weapons;
using ClickNFight.Spells;
using ClickNFight.Spells.Defence;
using ClickNFight.Spells.Offensive;

namespace ClickNFight
{
    public class Utils
    {
        public static IDictionary<int, Item[]> ItemsPerLevel = new Dictionary<int, Item[]>()
        {
            { 2, new Item[] { new WoodenSword() } },
            { 3, new Item[] { new StoneSword(), new UpgradedHealthPotion(), new CopperPickaxe(), new SilverOre() } },
            { 4, new Item[] { new SilverPickaxe(), new GoldOre(), new IronSword() } },
            { 5, new Item[] { new GoldPickaxe(), new PlatinumOre(), new SuperHealthPotion(), new AirRune(), new FireRune() } },
            { 6, new Item[] { new PlatinumPickaxe(), new EarthRune(), new DiamondSword() } }
            //{ 2, new Item[] { new WoodenSword() } },
            //{ 2, new Item[] { new WoodenSword() } },
            //{ 2, new Item[] { new WoodenSword() } },
        };

        public static IDictionary<int, Spell[]> SpellsPerLevel = new Dictionary<int, Spell[]>
        {
            { 5, new Spell[] { new FireBolt() } },
            { 6, new Spell[] { new DefenceUp() } },
        };

        public static IDictionary<int, Weapon> MineSwords = new Dictionary<int, Weapon>()
        {
            { 1, new SilverSword() },
            { 2, new GoldSword() },
            { 3, new PlatinumSword() },
            { 4, new CobaltSword() },
            { 5, new StarSword() },
        };

        public static event Action UiUpdated;

        public static void InvokeUiUpdate()
        {
            UiUpdated?.Invoke();
        }
    }
}
