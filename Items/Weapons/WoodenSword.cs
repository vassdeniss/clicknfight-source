namespace ClickNFight.Items.Weapons
{
    public class WoodenSword : Weapon
    {
        public WoodenSword()
        {
            this.Name = WeaponsSettings.WoodenSwordName;
            this.Limit = WeaponsSettings.WoodenSwordLimit;
            this.DamageMultiplier = WeaponsSettings.WoodenSwordMultiplier;
            this.BuyPrice = WeaponsSettings.WoodenSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
