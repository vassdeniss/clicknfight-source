namespace ClickNFight.Spells.Offensive
{
    public abstract class OffensiveSpell : Spell
    {
        public abstract int CpsIncrease { get; set; }

        public override string ToString()
        {
            return "Offense: ";
        }
    }
}
