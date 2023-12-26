using System;
using ClickNFight.Items.Runes;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickNFight.Spells.Heal
{
    public class Healara : HealingSpell
    {
        public Healara()
        {
            this.Name = "Healara";
            this.Cost = new Dictionary<Rune, int>
            {
                { new AirRune(), 3 },
                { new MindRune(), 4 },
            };
            this.DurationMilliseconds = 6000;
            this.CooldownMilliseconds = 300000;
            this.HealthIncrease = 10;
        }

        public override string Name { get; set; }

        public override IDictionary<Rune, int> Cost { get; set; }

        public override int DurationMilliseconds { get; set; }

        public override int CooldownMilliseconds { get; set; }

        public override int HealthIncrease { get; set; }

        public override async Task Cast(Hero hero)
        {
            hero.MaxHealth += this.HealthIncrease;
            await base.Cast(hero);
            hero.MaxHealth -= this.HealthIncrease;
            await base.Cooldown();
        }

        public override string Description()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Join(", ", this.Cost.Select(kvp => $"{kvp.Value} {kvp.Key}")));
            sb.AppendLine($"+{this.HealthIncrease} Max Health");
            sb.AppendLine($"Duration: {this.DurationMilliseconds / 1000} seconds");
            sb.AppendLine($"Cooldown: {this.CooldownMilliseconds / 1000} seconds");

            return sb.ToString().Trim();
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.Name}";
        }
    }
}
