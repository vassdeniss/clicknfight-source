namespace ClickNFight.Items.Consumables
{
    public class Potion : Consumable
    {
        public Potion()
        {
            this.Name = ConsumablesSettings.PotionName;
            this.HealAmount = ConsumablesSettings.PotionHealAmount;
            this.BuyPrice = ConsumablesSettings.PotionBuyPrice;
            this.Limit = ConsumablesSettings.PotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
