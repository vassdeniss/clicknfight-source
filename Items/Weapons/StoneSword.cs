namespace ClickNFight.Items.Weapons
{
    public class StoneSword : Weapon
    {
        public StoneSword()
        {
            this.Name = WeaponsSettings.StoneSwordName;
            this.Limit = WeaponsSettings.StoneSwordLimit;
            this.DamageMultiplier = WeaponsSettings.StoneSwordMultiplier;
            this.BuyPrice = WeaponsSettings.StoneSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
