namespace ClickNFight.Items.Consumables
{
    public class SuperHealthPotion : Consumable
    {
        public SuperHealthPotion()
        {
            this.Name = ConsumablesSettings.SuperHealthPotionName;
            this.HealAmount = ConsumablesSettings.SuperHealthPotionHealAmount;
            this.BuyPrice = ConsumablesSettings.SuperHealthPotionBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
