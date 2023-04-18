namespace ClickNFight.Items.Weapons
{
    public class DiamondSword : Weapon
    {
        public DiamondSword()
        {
            this.Name = WeaponsSettings.DiamondSwordName;
            this.Limit = WeaponsSettings.DiamondSwordLimit;
            this.DamageMultiplier = WeaponsSettings.DiamondSwordMultiplier;
            this.BuyPrice = WeaponsSettings.DiamondSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
