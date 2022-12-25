using System.Collections.Generic;

namespace ClickNFight
{
    public class Hero
    {
        public Hero()
        {
            this.Level = 1;
            this.MaxHealth = this.Health = 200;
            this.Defence = 0;
            this.DefenceReduction = 0;
            this.CurrentXp = 0;
            this.TotalXp = 250;
            this.Cps = 0;
            this.MonstersSlain = 0;
            this.Clickerency = 100;

            this.Potions = new List<Consumable>();
            this.Weapons = new List<Weapon>
            {
                new WoodenSword(),
            };
        }

        public int Level { get; set; }

        public int MaxHealth { get; set; }

        public int Health { get; set; }

        public int Defence { get; set; }

        public int DefenceReduction { get; set; }

        public int CurrentXp { get; set; }

        public int TotalXp { get; set; }

        public int Cps { get; set; }

        public int MonstersSlain { get; set; }

        public double Clickerency { get; set; }

        public ICollection<Weapon> Weapons { get; set; }

        public ICollection<Consumable> Potions { get; set; }
    }
}
