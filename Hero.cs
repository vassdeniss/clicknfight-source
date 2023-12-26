using System.Collections.Generic;

using ClickNFight.Spells;
using ClickNFight.Spells.Defence;
using ClickNFight.Spells.Offensive;

namespace ClickNFight
{
    public class Hero
    {
        private int _health;

        public Hero()
        {
            this.Level = 1;
            this.MaxHealth = 200;
            this.Health = 200;
            this.Defence = 0;
            this.DamageReduction = 0;
            this.CurrentXp = 549;
            this.TotalXp = 500;
            this.Cps = 0;
            this.MonstersSlain = 0.0;
            this.Clickerency = 1000000;

            this.Inventory = new HeroInventory();
            this.MineStats = new Dictionary<string, int>();
            this.Spells = new HashSet<Spell>
            {
                new FireBolt(),
                new DefenceUp()
            };
        }

        public int Level { get; set; }

        public int MaxHealth { get; set; }

        public int Health
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

        public int Cps { get; set; }

        public double MonstersSlain { get; set; }

        public double Clickerency { get; set; }

        public HeroInventory Inventory { get; set; }

        public IDictionary<string, int> MineStats { get; set; }

        public ISet<Spell> Spells { get; set; }

        public Spell ActiveSpell { get; set; }
    }
}
