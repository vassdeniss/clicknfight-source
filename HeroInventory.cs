using System.Collections.Generic;
using System.Net.Http.Headers;

using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Weapons;

namespace ClickNFight
{
    public class HeroInventory
    {
        public HeroInventory()
        {
            this.UnlockedItems = new HashSet<Item>
            {
                new Potion(),
                new UpgradedHealthPotion(),
                new SuperHealthPotion(),
                new UltraHealthPotion(),
                new WoodenSword(),
                new StoneSword(),
                new IronSword(),
            };
            this.Consumables = new List<Consumable>
            {
                new Potion(),
                new UpgradedHealthPotion(),
                new SuperHealthPotion(),
                new UltraHealthPotion(),
            };
            this.Weapons = new List<Weapon>
            {
                new WoodenSword(),
                new StoneSword(),
                new IronSword(),
            };
            this.ConsumablesTest = new Dictionary<Consumable, int>();
            this.test_items_new = new Dictionary<Item, int>()
            {
                {
                    new Potion(), 0
                },
                {
                    new WoodenSword(), 0
                }
            };
        }

        public HashSet<Item> UnlockedItems { get; }

        public IDictionary<Item, int> test_items_new { get; }

        public IDictionary<Consumable, int> ConsumablesTest { get; }

        public ICollection<Consumable> Consumables { get; }

        public ICollection<Weapon> Weapons { get; }

        public void Add(Item item)
        {
            this.test_items_new[item]++;

            if (item is Consumable consumable)
            {
                if (!this.ConsumablesTest.ContainsKey(consumable))
                {
                    this.ConsumablesTest.Add(consumable, 0);
                }

                this.ConsumablesTest[consumable]++;

                this.Consumables.Add(consumable);
            }
            else if (item is Weapon weapon)
            {
                this.Weapons.Add(weapon);
            }
        }

        public void Remove(Item item)
        {
            if (item is Consumable consumable)
            {
                this.Consumables.Remove(consumable);
            }
            else if (item is Weapon weapon)
            {
                this.Weapons.Remove(weapon);
            }
        }

        public bool HasCapacity(Item item)
        {
            return this.test_items_new[item] == -1 
                || this.test_items_new[item] < item.Limit;
        }
    }
}
