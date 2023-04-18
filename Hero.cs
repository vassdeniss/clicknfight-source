namespace ClickNFight
{
    public class Hero
    {
        private int health;

        public Hero()
        {
            this.Level = 1;
            this.MaxHealth = 200;
            this.Health = 200;
            this.Defence = 0;
            this.DefenceReduction = 0;
            this.CurrentXp = 0;
            this.TotalXp = 250;
            this.Cps = 0;
            this.MonstersSlain = 0.0;
            this.Clickerency = 1000000;

            this.Inventory = new HeroInventory();
        }

        public int Level { get; set; }

        public int MaxHealth { get; set; }

        public int Health
        {
            get => this.health;
            set
            {
                if (value > this.MaxHealth)
                {
                    value = this.MaxHealth;
                }

                this.health = value;
            }
        }

        public int Defence { get; set; }

        public int DefenceReduction { get; set; }

        public int CurrentXp { get; set; }

        public int TotalXp { get; set; }

        public int Cps { get; set; }

        public double MonstersSlain { get; set; }

        public double Clickerency { get; set; }

        public HeroInventory Inventory { get; set; }
    }
}
