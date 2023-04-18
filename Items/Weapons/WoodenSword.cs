namespace ClickNFight.Items.Weapons
{
    public class WoodenSword : Weapon
    {
        public WoodenSword()
        {
            this.Name = WeaponSettings.WoodenSwordName;
            this.Limit = WeaponSettings.WoodenSwordLimit;
            this.DamageMultiplier = WeaponSettings.WoodenSwordMultiplier;
            this.BuyPrice = WeaponSettings.WoodenSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
