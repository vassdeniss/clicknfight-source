using System.Collections.Generic;

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
            };
            this.Consumables = new List<Consumable>
            {
                new Potion(),
                new UpgradedHealthPotion(),
            };
            this.Weapons = new List<Weapon>
            {
                new WoodenSword(),
                new StoneSword(),
                new IronSword(),
            };
        }

        public HashSet<Item> UnlockedItems { get; }

        public ICollection<Consumable> Consumables { get; }

        public ICollection<Weapon> Weapons { get; }

        public void Add(Item item)
        {
            if (item is Consumable consumable)
            {
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
    }
}
