using static ClickNFight.Items.Weapons.WeaponSettings;

namespace ClickNFight.Items.Weapons
{
    public class PlatinumSword : Weapon
    {
        public PlatinumSword()
        {
            this.Name = PlatinumSwordName;
            this.Limit = PlatinumSwordLimit;
            this.DamageMultiplier = PlatinumSwordMultiplier;
            this.BuyPrice = PlatinumSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
