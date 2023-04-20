using static ClickNFight.Items.Weapons.WeaponSettings;

namespace ClickNFight.Items.Weapons
{
    public class GoldSword : Weapon
    {
        public GoldSword()
        {
            this.Name = GoldSwordName;
            this.Limit = GoldSwordLimit;
            this.DamageMultiplier = GoldSwordMultiplier;
            this.BuyPrice = GoldSwordBuyPrice;
        }

        public sealed override string Name { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override double DamageMultiplier { get; set; }

        public sealed override int BuyPrice { get; set; }
    }
}
