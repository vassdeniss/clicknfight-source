namespace ClickNFight.Items.Consumables
{
    public class UltraHealthPotion : Consumable
    {
        public UltraHealthPotion()
        {
            this.Name = ConsumablesSettings.UltraHealthPotionName;
            this.HealAmount = ConsumablesSettings.UltraHealthPotionHealAmount;
            this.BuyPrice = ConsumablesSettings.UltraHealthPotionBuyPrice;
            this.Limit = ConsumablesSettings.UltraHealthPotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
