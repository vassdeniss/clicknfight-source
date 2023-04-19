namespace ClickNFight.Items
{
    public abstract class BuyableItem : Item
    {
        public abstract int BuyPrice { get; set; }

        public virtual bool CanAfford(Hero hero, out string failMessage)
        {
            if (hero.Clickerency < this.BuyPrice)
            {
                failMessage = "You don't have enough clicks to buy this";
                return false;
            }

            failMessage = string.Empty;
            return true;
        }

        public virtual void BuyItem(Hero hero)
        {
            hero.Clickerency -= this.BuyPrice;
            hero.Inventory.Add(this);
        }
    }
}
