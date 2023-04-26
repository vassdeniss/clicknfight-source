using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using ClickNFight.Items.Runes;

namespace ClickNFight.Spells
{
    public abstract class Spell
    {
        public string Name { get; set; }

        public IDictionary<Rune, int> Cost { get; set; }

        public int DurationMilliseconds { get; set; }

        public int CooldownMilliseconds { get; set; }

        public bool IsCast { get; set; }

        public bool IsCooldown { get; set; }

        public void Cast(Hero hero)
        {
            // Pay with runes

            Thread cast = new Thread(() =>
            {
                this.IsCast = true;
                Thread.Sleep(this.DurationMilliseconds);
                this.IsCast = false;
                MessageBox.Show(
                    $"{this.Name} expired!",
                    "Warning!",
                    MessageBoxButtons.OK);
            });

            cast.Start();

            Thread cooldown = new Thread(() =>
            {
                cast.Join();
                this.IsCooldown = true;
                Thread.Sleep(this.CooldownMilliseconds);
                this.IsCooldown = false;
                MessageBox.Show(
                    $"{this.Name} is no longer on cooldown!",
                    "Warning!",
                    MessageBoxButtons.OK);
            });

            cooldown.Start();
        }
    }
}
