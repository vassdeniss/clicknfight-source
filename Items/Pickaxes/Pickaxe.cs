using System.Text;

namespace ClickNFight.Items.Pickaxes
{
    public abstract class Pickaxe : Item
    {
        public sealed override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            // TODO:

            sb.AppendLine(this.Name);
            sb.AppendLine($"Regenerates health by {this.HealAmount} points");
            sb.AppendLine($"{this.BuyPrice} Clicks");
            sb.AppendLine("No buy limit");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
