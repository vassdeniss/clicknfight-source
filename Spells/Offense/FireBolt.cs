using ClickNFight.Items.Runes;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickNFight.Spells.Offensive
{
    public class FireBolt : OffensiveSpell
    {
        public FireBolt()
        {
            this.Name = "Fire Bolt";
            this.Cost = new Dictionary<Rune, int>
            {
                { new AirRune(), 2 },
                { new FireRune(), 3 }
            };
            this.DurationMilliseconds = 60000;
            this.CooldownMilliseconds = 300000;
            this.CpsIncrease = 5;
        }

        public override string Name { get; set; }

        public override IDictionary<Rune, int> Cost { get; set; }

        public override int DurationMilliseconds { get; set; }

        public override int CooldownMilliseconds { get; set; }

        public override int CpsIncrease { get; set; }

        public override async Task Cast(Hero hero)
        {
            hero.Cps += this.CpsIncrease;
            await base.Cast(hero);
            hero.Cps -= this.CpsIncrease;
            await base.Cooldown();
        }

        public override string Description()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Join(", ", this.Cost.Select(kvp => $"{kvp.Value} {kvp.Key}")));
            sb.AppendLine($"+{this.CpsIncrease} CPS");
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
