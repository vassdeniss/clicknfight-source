namespace ClickNFight.Items.Consumables
{
    public class UpgradedHealthPotion : Consumable
    {
        public UpgradedHealthPotion()
        {
            this.Name = ConsumablesSettings.UpgradedHealthPotionName;
            this.HealAmount = ConsumablesSettings.UpgradedHealthPotionHealAmount;
            this.BuyPrice = ConsumablesSettings.UpgradedHealthPotionBuyPrice;
            this.Limit = ConsumablesSettings.UpgradedHealthPotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }
    
        public sealed override int Limit { get; set; }
    }
}
