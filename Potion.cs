using System;

namespace ClickNFight
{
    public class Potion : Consumable
    {
        public Potion()
        {
            this.Name = "Health Potion";
            this.HealAmount = 10;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}Heal Amount: {this.HealAmount}";
        }
    }
}
