namespace ClickNFight.CampResources
{
    public class Stick : Resource
    {
        public Stick()
        {
            this.Name = "Sticks";
            this.SecondsToGather = 10;
            this.MinDrop = 1;
            this.MaxDrop = 6;
            this.CooldownMilliseconds = 300000;
        }

        public override string Name { get; set; }

        public override int SecondsToGather { get; set; }

        public override int MinDrop { get; set; }

        public override int MaxDrop { get; set; }

        public override int CooldownMilliseconds { get; set; }
    }
}
