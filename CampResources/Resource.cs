using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickNFight.CampResources
{
    public abstract class Resource
    {
        public bool IsOnCooldown { get; set; }

        public abstract string Name { get; set; }

        public abstract int SecondsToGather { get; set; }

        public abstract int MinDrop { get; set; }

        public abstract int MaxDrop { get; set; }

        public abstract int CooldownMilliseconds { get; set; }

        public Task Cooldown()
        {
            return Task.Run(async () =>
            {
                this.IsOnCooldown = true;
                await Task.Delay(this.CooldownMilliseconds);
                this.IsOnCooldown = false;
                MessageBox.Show(
                    $"{this.Name} can be gathered again!",
                    "Warning!",
                    MessageBoxButtons.OK);
            });
        }

        public override string ToString()
        {
            return $"{this.Name}: Gather {this.SecondsToGather} sec: Cooldown: {this.CooldownMilliseconds / 1000} sec";
        }
    }
}
