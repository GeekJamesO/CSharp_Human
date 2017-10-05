namespace HumanProj
{
    class Samurai : Human
    {
        private static int NumberOfSamarais = 0;
        public Samurai(string name) : base(name, 3, 3, 3, 200)
        {
            Samurai.NumberOfSamarais += 1;
        }
        public void DeathBlow(Human Enemy)
        {
            if ((Enemy.health <= 50) && (Enemy.health > 0))
            {
                System.Console.WriteLine($"Ninja '{this.name}' applys the death blow to '{Enemy.name}' for {Enemy.health} point(s).");
                Enemy.health = 0;
            }
        }
        public void Meditate()
        {
            int healing = this.maxHealth - this.health;
            System.Console.WriteLine($"{this.name} quietly meditates for a moment and gains back {healing} points.");
            this.health = base.maxHealth;
        }
        public int how_many()
        {
            return Samurai.NumberOfSamarais;
        }
        public override void Print()
        {
            System.Console.WriteLine(" Samurai [" + this.ToString() + "]");
        }
    }
}