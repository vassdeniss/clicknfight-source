using static ClickNFight.Items.Weapons.WeaponSettings;

namespace ClickNFight.Items.Weapons
{
    public class CobaltSword : Weapon
    {
        public CobaltSword()
        {
            this.Name = CobaltSwordName;
            this.Limit = CobaltSwordLimit;
            this.DamageMultiplier = CobaltSwordMultiplier;
            this.BuyPrice = CobaltSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
