using ClickNFight.Items.Runes;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickNFight.Spells.Defence
{
    public class DefenceUp : DefensiveSpell
    {
        public DefenceUp()
        {
            this.Name = "Defence Up";
            this.Cost = new Dictionary<Rune, int>
            {
                { new AirRune(), 3 },
                { new EarthRune(), 4 },
            };
            this.DurationMilliseconds = 60000;
            this.CooldownMilliseconds = 300000;
            this.DefenceIncrease = 1;
        }

        public override string Name { get; set; }

        public override IDictionary<Rune, int> Cost { get; set; }

        public override int DurationMilliseconds { get; set; }

        public override int CooldownMilliseconds { get; set; }

        public override int DefenceIncrease { get; set; }

        public override async Task Cast(Hero hero)
        {
            hero.DamageReduction += this.DefenceIncrease;
            hero.Defence += this.DefenceIncrease;
            await base.Cast(hero);
            hero.DamageReduction -= this.DefenceIncrease;
            hero.Defence -= this.DefenceIncrease;
            await base.Cooldown();
        }

        public override string Description()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Join(", ", this.Cost.Select(kvp => $"{kvp.Value} {kvp.Key}")));
            sb.AppendLine($"+{this.DefenceIncrease} Damage Reduction");
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
