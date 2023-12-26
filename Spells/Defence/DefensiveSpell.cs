namespace ClickNFight.Spells.Defence
{
    public abstract class DefensiveSpell : Spell
    {
        public abstract int DefenceIncrease { get; set; }

        public override string ToString()
        {
            return "Defence: ";
        }
    }
}
