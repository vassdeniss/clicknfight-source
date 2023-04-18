namespace ClickNFight.Items.Consumables
{
    public class Potion : Consumable
    {
        public Potion()
        {
            this.Name = ConsumableSettings.PotionName;
            this.HealAmount = ConsumableSettings.PotionHealAmount;
            this.BuyPrice = ConsumableSettings.PotionBuyPrice;
            this.Limit = ConsumableSettings.PotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
