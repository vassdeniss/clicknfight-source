using ClickNFight.CampResources;
using ClickNFight.Spells;
using ClickNFight.Spells.Defence;
using ClickNFight.Spells.Heal;
using ClickNFight.Spells.Offensive;

using System.Collections.Generic;
using System.Linq;

namespace ClickNFight
{
    public class Hero
    {
        private double _health;

        public Hero()
        {
            this.Level = 1;
            this.MaxHealth = 200;
            this.Health = 200;
            this.Defence = 0;
            this.Cps = 1;
            this.DamageReduction = 0;
            this.CurrentXp = 549;
            this.TotalXp = 500;
            this.MonstersSlain = 0.0;
            this.Clickerency = 1000000;

            this.Inventory = new HeroInventory();
            this.MineStats = new Dictionary<string, int>();
            this.Spells = new HashSet<Spell>
            {
                new FireBolt(),
                new DefenceUp(),
                new Healara(),
            };
            this.Resources = new Dictionary<Resource, int>
            {
                { new Stick(), 0 }
            };
        }

        public int Level { get; set; }

        public int MaxHealth { get; set; }

        public double Health
        {
            get => this._health;
            set
            {
                if (value > this.MaxHealth)
                {
                    value = this.MaxHealth;
                }

                this._health = value;
            }
        }

        public int Defence { get; set; }

        public int DamageReduction { get; set; }

        public int CurrentXp { get; set; }

        public int TotalXp { get; set; }

        public double Cps { get; set; }

        public double MonstersSlain { get; set; }

        public double Clickerency { get; set; }

        public HeroInventory Inventory { get; set; }

        public IDictionary<string, int> MineStats { get; set; }

        public ISet<Spell> Spells { get; set; }

        public Spell ActiveSpell { get; set; }

        public IDictionary<Resource, int> Resources { get; set; }

        public double CalculateWeaponCps()
        {
            return this.Inventory.Weapons
                .Sum(kvp => kvp.Key.DamageMultiplier * kvp.Value);
        }
    }
}
