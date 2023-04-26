namespace ClickNFight.Items
{
    public abstract class SellableItem : Item
    {
        public abstract int SellPrice { get; set; }

        public virtual void SellItem(Hero hero, int count)
        {
            hero.Clickerency += this.SellPrice * count;
            hero.Inventory.Remove(this, count);
        }
    }
}
