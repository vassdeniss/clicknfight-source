using System;

namespace ClickNFight
{
    public class WoodenSword : Weapon
    {
        public WoodenSword()
        {
            this.Name = "Wooden Sword";
            this.Limit = 10;
            this.DamageMultiplier = 0.5;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}Total Damage: {this.DamageMultiplier:f1}{Environment.NewLine}Limit: {this.Limit}";
        }
    }
}
