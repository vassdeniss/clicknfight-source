namespace ClickNFight.Items.Consumables
{
    public class UltraHealthPotion : Consumable
    {
        public UltraHealthPotion()
        {
            this.Name = ConsumableSettings.UltraHealthPotionName;
            this.HealAmount = ConsumableSettings.UltraHealthPotionHealAmount;
            this.BuyPrice = ConsumableSettings.UltraHealthPotionBuyPrice;
            this.Limit = ConsumableSettings.UltraHealthPotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
