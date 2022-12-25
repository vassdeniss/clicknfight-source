namespace ClickNFight
{
    public abstract class Weapon : Item
    {
        public abstract int Limit { get; set; }

        public abstract double DamageMultiplier { get; set; }
    }
}
