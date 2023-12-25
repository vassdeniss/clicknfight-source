using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Runes;
using ClickNFight.Items.Weapons;

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClickNFight
{
    public class HeroInventory
    {
        private readonly IDictionary<Type, int> _inventory;
        private readonly ISet<Item> _items;

        public HeroInventory()
        {
            this._items = new HashSet<Item>
            {
                new HealthPotion(),
                new UpgradedHealthPotion(),
                new SuperHealthPotion(),
                new UltraHealthPotion(),
                new WoodenSword(),
                new StoneSword(),
                new IronSword(),
                new DiamondSword(),
                new CopperPickaxe(),
                new SilverPickaxe(),
                new GoldPickaxe(),
                new PlatinumPickaxe(),
                new CobaltPickaxe(),
                new StartPickaxe(),
                new SilverOre(),
                new GoldOre(),
                new PlatinumOre(),
                new CobaltOre(),
                new StarOre(),
                new SilverSword(),
                new GoldSword(),
                new PlatinumSword(),
                new StarSword(),
                new AirRune(),
                new FireRune(),
                new EarthRune()
            };

            this._inventory = new Dictionary<Type, int>
            {
                { typeof(HealthPotion), 1 },
                { typeof(UpgradedHealthPotion), 2 },
                { typeof(SuperHealthPotion), 3 },
                { typeof(UltraHealthPotion), 4 },
                { typeof(WoodenSword), 5 },
                { typeof(StoneSword), 0 },
                { typeof(IronSword), 0 },
                { typeof(DiamondSword), 1 },
                { typeof(CopperPickaxe), 1 },
                { typeof(SilverPickaxe), 1 },
                { typeof(GoldPickaxe), 1 },
                { typeof(PlatinumPickaxe), 1 },
                { typeof(CobaltPickaxe), 1 },
                { typeof(StartPickaxe), 1 },
                { typeof(SilverOre), 99 },
                { typeof(GoldOre), 0 },
                { typeof(PlatinumOre), 0 },
                { typeof(CobaltOre), 2 },
                { typeof(StarOre), 0 },
                { typeof(SilverSword), 1 },
                { typeof(GoldSword), 1 },
                { typeof(PlatinumSword), 1 },
                { typeof(StarSword), 1 },
                { typeof(AirRune), 50 },
                { typeof(FireRune), 10 },
                { typeof(EarthRune), 20 }
            };
        }

        public ICollection<BuyableItem> BuyableItems =>
            this._items.OfType<BuyableItem>().ToList();

        public ICollection<SellableItem> SellableItems =>
            this._items.OfType<SellableItem>().ToList();

        public IDictionary<Consumable, int> Consumables =>
            this._items
                .Where(item => item is Consumable && this._inventory[item.GetType()] > 0)
                .ToDictionary(item => (Consumable)item, item => this._inventory[item.GetType()]);

        public IDictionary<Weapon, int> Weapons =>
            this._items
                .Where(item => item is Weapon && this._inventory[item.GetType()] > 0)
                .ToDictionary(item => (Weapon)item, item => this._inventory[item.GetType()
                ]);

        public IEnumerable<Pickaxe> Pickaxes =>
            this._items
                .Where(item => item is Pickaxe && this._inventory[item.GetType()] > 0)
                .Select(item => (Pickaxe)item)
                .ToList();

        public IDictionary<Ore, int> Ores =>
            this._items
                .Where(item => item is Ore && this._inventory[item.GetType()] > 0)
                .ToDictionary(item => (Ore)item, item => this._inventory[item.GetType()]);

        public IDictionary<Rune, int> Runes =>
            this._items
                .Where(item => item is Rune && this._inventory[item.GetType()] > 0)
                .ToDictionary(item => (Rune)item, item => this._inventory[item.GetType()]);

        public void UnlockItem(Item item, int count = 0)
        {
            if (this._inventory.ContainsKey(item.GetType()))
            {
                return;
            }

            this._items.Add(item);
            this._inventory.Add(item.GetType(), count);
        }

        public void Add(Item item, int count = 1)
        {
            this._inventory[item.GetType()] += count;
        }

        public void Remove(Item item, int count = 1)
        {
            this._inventory[item.GetType()] -= count;
            if (this._inventory[item.GetType()] < 0)
            {
                this._inventory[item.GetType()] = 0;
            }
        }

        public bool HasItem(Item item)
        {
            return this._inventory.ContainsKey(item.GetType()) && this._inventory[item.GetType()] > 0;
        }

        public bool HasCapacity(Item item)
        {
            return item.Limit == -1 || this._inventory[item.GetType()] < item.Limit;
        }

        public int GetCount(Item item)
        {
            if (!this.HasItem(item))
            {
                throw new InvalidOperationException();
            }

            return this._inventory[item.GetType()];
        }
    }
}
