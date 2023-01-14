namespace ClickNFight.Items.Consumables
{
    public class Potion : Consumable
    {
        public Potion()
        {
            this.Name = ConsumablesSettings.PotionName;
            this.HealAmount = ConsumablesSettings.PotionHealAmount;
            this.BuyPrice = ConsumablesSettings.PotionBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int HealAmount { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
