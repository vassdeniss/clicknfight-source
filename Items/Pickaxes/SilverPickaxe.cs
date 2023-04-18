namespace ClickNFight.Items.Pickaxes
{
    public class SilverPickaxe : Pickaxe
    {
        public SilverPickaxe()
        {
            this.Name = PickaxeSettings.SilverPickaxeName;
            this.BuyPrice = PickaxeSettings.SilverPickaxeBuyPrice;
            this.Limit = PickaxeSettings.SilverPickaxeLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
