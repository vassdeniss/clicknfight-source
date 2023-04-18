namespace ClickNFight.Items.Weapons
{
    public class DiamondSword : Weapon
    {
        public DiamondSword()
        {
            this.Name = WeaponSettings.DiamondSwordName;
            this.Limit = WeaponSettings.DiamondSwordLimit;
            this.DamageMultiplier = WeaponSettings.DiamondSwordMultiplier;
            this.BuyPrice = WeaponSettings.DiamondSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
