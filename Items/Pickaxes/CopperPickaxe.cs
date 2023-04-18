namespace ClickNFight.Items.Pickaxes
{
    public class CopperPickaxe : Pickaxe
    {
        public CopperPickaxe()
        {
            this.Name = PickaxeSettings.CopperPickaxeName;
            this.BuyPrice = PickaxeSettings.CopperPickaxeBuyPrice;
            this.Limit = PickaxeSettings.CopperPickaxeLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override string ShopInformation()
        {
            return string.Empty;
        }
    }
}
