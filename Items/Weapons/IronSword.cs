namespace ClickNFight.Items.Weapons
{
    public class IronSword : Weapon
    {
        public IronSword()
        {
            this.Name = WeaponsSettings.IronSwordName;
            this.Limit = WeaponsSettings.IronSwordLimit;
            this.DamageMultiplier = WeaponsSettings.IronSwordMultiplier;
            this.BuyPrice = WeaponsSettings.IronSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
