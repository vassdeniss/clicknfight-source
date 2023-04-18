namespace ClickNFight.Items.Weapons
{
    public class IronSword : Weapon
    {
        public IronSword()
        {
            this.Name = WeaponSettings.IronSwordName;
            this.Limit = WeaponSettings.IronSwordLimit;
            this.DamageMultiplier = WeaponSettings.IronSwordMultiplier;
            this.BuyPrice = WeaponSettings.IronSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
