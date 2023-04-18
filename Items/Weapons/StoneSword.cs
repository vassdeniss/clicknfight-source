namespace ClickNFight.Items.Weapons
{
    public class StoneSword : Weapon
    {
        public StoneSword()
        {
            this.Name = WeaponSettings.StoneSwordName;
            this.Limit = WeaponSettings.StoneSwordLimit;
            this.DamageMultiplier = WeaponSettings.StoneSwordMultiplier;
            this.BuyPrice = WeaponSettings.StoneSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
