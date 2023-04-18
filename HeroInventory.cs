using System.Collections.Generic;
using System.Linq;

using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Pickaxes;
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
                { new Potion(), 1 },
                { new UpgradedHealthPotion(), 2 },
                { new SuperHealthPotion(), 3 },
                { new UltraHealthPotion(), 4 },
                { new WoodenSword(), 5 },
                { new StoneSword(), 0 },
                { new IronSword(), 0 },
                { new DiamondSword(), 1 },
                { new CopperPickaxe(), 1 },
            };
        }
        
        public ICollection<Item> Items => this.inventory.Keys.ToList();

        public IDictionary<Consumable, int> Consumables
            => this.inventory
                .Where((kv) => kv.Key is Consumable && kv.Value > 0)
                .ToDictionary((kv) => (Consumable)kv.Key, kv => kv.Value);

        public IDictionary<Weapon, int> Weapons
            => this.inventory
                .Where((kv) => kv.Key is Weapon && kv.Value > 0)
                .ToDictionary((kv) => (Weapon)kv.Key, kv => kv.Value);

        public IEnumerable<Pickaxe> Pickaxes
            => this.inventory
                .Where((kv) => kv.Key is Pickaxe && kv.Value > 0)
                .Select((kv) => (Pickaxe)kv.Key)
                .ToList();

        public void UnlockItem(Item item, int count = 0)
        {
            this.inventory.Add(item, count);
        }

        public void Add(Item item)
        {
            this.inventory[item]++;
        }

        public void Remove(Item item)
        {
            this.inventory[item]--;
        }

        public bool HasCapacity(Item item)
        {
            return item.Limit == -1 
                || this.inventory[item] < item.Limit;
        }

        //public T GetItem<T>(string name)
        //    where T : class
        //{
        //    return this.inventory.Keys.First((x) => x.Name == name) as T;
        //}
    }
}
