namespace ClickNFight.Items.Consumables
{
    public class UpgradedHealthPotion : Consumable
    {
        public UpgradedHealthPotion()
        {
            this.Name = ConsumableSettings.UpgradedHealthPotionName;
            this.HealAmount = ConsumableSettings.UpgradedHealthPotionHealAmount;
            this.BuyPrice = ConsumableSettings.UpgradedHealthPotionBuyPrice;
            this.Limit = ConsumableSettings.UpgradedHealthPotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
