using static ClickNFight.Items.Weapons.WeaponSettings;

namespace ClickNFight.Items.Weapons
{
    public class SilverSword : Weapon
    {
        public SilverSword()
        {
            this.Name = SilverSwordName;
            this.Limit = SilverSwordLimit;
            this.DamageMultiplier = SilverSwordMultiplier;
            this.BuyPrice = SilverSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
