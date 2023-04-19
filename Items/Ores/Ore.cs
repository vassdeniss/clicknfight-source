using System;

namespace ClickNFight.Items.Ores
{
    public class Ore : Item
    {
        // TODO: Temp
        public Ore(OreType type)
        {
            this.Type = type;

            this.Name = $"{type} Ingots";
            this.Limit = -1;
            this.Strength = (int)type;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public OreType Type { get; set; }

        public int Strength { get; set; }

        public string MineString => $"{this.Type} Ore";

        public override string ShopInformation()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
