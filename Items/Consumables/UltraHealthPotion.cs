namespace ClickNFight.Items.Consumables
{
    public class UltraHealthPotion : Consumable
    {
        public UltraHealthPotion()
        {
            this.Name = ConsumablesSettings.UltraHealthPotionName;
            this.HealAmount = ConsumablesSettings.UltraHealthPotionHealAmount;
            this.BuyPrice = ConsumablesSettings.UltraHealthPotionBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
