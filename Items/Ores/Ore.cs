using System.Text;

namespace ClickNFight.Items.Ores
{
    public abstract class Ore : SellableItem
    {
        protected Ore(OreType type)
        {
            this.Type = type;

            this.Name = $"{type} Ingots";
            this.Limit = -1;
            this.Strength = (int)type;
            this.SellPrice = (int)type * 10;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override int SellPrice { get; set; }

        public OreType Type { get; set; }

        public int Strength { get; set; }

        public string MineString => $"{this.Type} Ore";

        public override string ShopInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Sell Price: {this.SellPrice} Clicks");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
