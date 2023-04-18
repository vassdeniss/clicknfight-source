namespace ClickNFight.Items.Consumables
{
    public class SuperHealthPotion : Consumable
    {
        public SuperHealthPotion()
        {
            this.Name = ConsumableSettings.SuperHealthPotionName;
            this.HealAmount = ConsumableSettings.SuperHealthPotionHealAmount;
            this.BuyPrice = ConsumableSettings.SuperHealthPotionBuyPrice;
            this.Limit = ConsumableSettings.SuperHealthPotionLimit;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }
    }
}
