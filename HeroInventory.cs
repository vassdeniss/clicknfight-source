using System;
using System.Collections.Generic;
using System.Linq;

using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Ores;
using ClickNFight.Items.Pickaxes;
using ClickNFight.Items.Runes;
using ClickNFight.Items.Weapons;

namespace ClickNFight
{
    public class HeroInventory
    {
        private readonly IDictionary<Item, int> inventory;

        public HeroInventory()
        {
            this.inventory = new Dictionary<Item, int>()
            {
                { new HealthPotion(), 1 },
                { new UpgradedHealthPotion(), 2 },
                { new SuperHealthPotion(), 3 },
                { new UltraHealthPotion(), 4 },
                { new WoodenSword(), 5 },
                { new StoneSword(), 0 },
                { new IronSword(), 0 },
                { new DiamondSword(), 1 },
                { new CopperPickaxe(), 1 },
                { new SilverPickaxe(), 1 },
                { new GoldPickaxe(), 1 },
                { new PlatinumPickaxe(), 1 },
                { new CobaltPickaxe(), 1 },
                { new StartPickaxe(), 1 },
                { new Ore(OreType.Silver), 99 },
                { new Ore(OreType.Gold), 0 },
                { new Ore(OreType.Platinum), 0 },
                { new Ore(OreType.Cobalt), 2 },
                { new Ore(OreType.Star), 0 },
                { new SilverSword(), 1 },
                { new GoldSword(), 1 },
                { new PlatinumSword(), 1 },
                { new CobaltPickaxe(), 1 },
                { new StarSword(), 1 },
                { new AirRune(), 50 }
            };
        }

        public ICollection<BuyableItem> BuyableItems =>
            this.inventory.Keys.OfType<BuyableItem>().ToList();

        public ICollection<SellableItem> SellableItems =>
            this.inventory.Keys.OfType<SellableItem>().ToList();

        public IDictionary<Consumable, int> Consumables =>
            this.inventory
                .Where((kv) => kv.Key is Consumable && kv.Value > 0)
                .ToDictionary((kv) => (Consumable)kv.Key, kv => kv.Value);

        public IDictionary<Weapon, int> Weapons =>
            this.inventory
                .Where((kv) => kv.Key is Weapon && kv.Value > 0)
                .ToDictionary((kv) => (Weapon)kv.Key, kv => kv.Value);

        public IEnumerable<Pickaxe> Pickaxes =>
            this.inventory
                .Where((kv) => kv.Key is Pickaxe && kv.Value > 0)
                .Select((kv) => (Pickaxe)kv.Key)
                .ToList();

        public IDictionary<Ore, int> Ores =>
            this.inventory
                .Where((kv) => kv.Key is Ore)
                .ToDictionary((kv) => (Ore)kv.Key, (kv) => kv.Value);

        public IDictionary<Rune, int> Runes =>
            this.inventory
                .Where((kv) => kv.Key is Rune)
                .ToDictionary((kv) => (Rune)kv.Key, (kv) => kv.Value);

        public void UnlockItem(Item item, int count = 0)
        {
            if (this.inventory.ContainsKey(item))
            {
                return;
            }

            this.inventory.Add(item, count);
        }

        public void Add(Item item, int count = 1)
        {
            this.inventory[item] += count;
        }

        public void Remove(Item item, int count = 1)
        {
            this.inventory[item] -= count;
            if (this.inventory[item] < 0)
            {
                this.inventory[item] = 0;
            }
        }

        public bool HasItem(Item item)
        {
            return this.inventory.ContainsKey(item) && this.inventory[item] > 0;
        }

        public bool HasCapacity(Item item)
        {
            return item.Limit == -1 || this.inventory[item] < item.Limit;
        }

        public int GetCount(Item item)
        {
            if (!this.HasItem(item))
            {
                throw new InvalidOperationException();
            }

            return this.inventory[item];
        }
    }
}
