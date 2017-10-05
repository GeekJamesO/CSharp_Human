using System;
namespace HumanProj
{
    class Ninja : Human
    {
        private Random rnd;
        public Ninja(string person) : base(person, 3, 3, 175, 50)
        {
            ;
        }
        public void Steal()
        {
            var healing = 10;
            System.Console.WriteLine($"{base.name} steals food and heals {healing} points.");
            base.health += healing;
            if (base.health > base.maxHealth)
            {
                Console.WriteLine("Healing capped by max health.");
                base.health = base.maxHealth;
            }
        }
        public void get_away(Human target)
        {
            int damage = 15;
            System.Console.WriteLine($"{base.name} gets away at a cost of {damage} points.");
            target.health -= damage;
            if (target.health < 0)
            {
                target.health = 0;
            }
        }
        public override void Print()
        {
            System.Console.WriteLine(" Ninja [" + this.ToString() + "]");
        }

    }
}