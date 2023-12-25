using ClickNFight.Items.Runes;

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickNFight.Spells
{
    public abstract class Spell
    {
        public abstract string Name { get; set; }

        public abstract IDictionary<Rune, int> Cost { get; set; }

        public abstract int DurationMilliseconds { get; set; }

        public abstract int CooldownMilliseconds { get; set; }

        public bool IsOnCooldown { get; set; }

        public bool CanCast(Hero hero, out string failMessage)
        {
            if (this.IsOnCooldown)
            {
                failMessage = $"{this.Name} is on cooldown!";
                return false;
            }

            foreach (KeyValuePair<Rune, int> kvp in this.Cost)
            {
                if (!hero.Inventory.HasItem(kvp.Key) 
                    || hero.Inventory.GetCount(kvp.Key) < kvp.Value)
                {
                    failMessage = $"You don't have the runes to cast {this.Name}!";
                    return false;
                }
            }

            failMessage = string.Empty;
            return true;
        }

        public virtual Task Cast(Hero hero)
        {
            foreach (KeyValuePair<Rune, int> kvp in this.Cost)
            {
                hero.Inventory.Remove(kvp.Key, kvp.Value);
            }

            return Task.Run(async () =>
            {
                this.IsOnCooldown = true;
                await Task.Delay(this.DurationMilliseconds);
                MessageBox.Show(
                    $"{this.Name} expired!",
                    "Warning!",
                    MessageBoxButtons.OK);

                await Task.Delay(this.CooldownMilliseconds);
                this.IsOnCooldown = false;
                MessageBox.Show(
                    $"{this.Name} is no longer on cooldown!",
                    "Warning!",
                    MessageBoxButtons.OK);
            });
        }

        public abstract string Description();
    }
}
