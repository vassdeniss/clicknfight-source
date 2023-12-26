namespace ClickNFight.Spells.Heal
{
    public abstract class HealingSpell : Spell
    {
        public abstract int HealthIncrease { get; set; }

        public override string ToString()
        {
            return "Heal: ";
        }
    }
}
