using static ClickNFight.Items.Weapons.WeaponSettings;

namespace ClickNFight.Items.Weapons
{
    public class StarSword : Weapon
    {
        public StarSword()
        {
            this.Name = StarSwordName;
            this.Limit = StarSwordLimit;
            this.DamageMultiplier = StarSwordMultiplier;
            this.BuyPrice = StarSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
