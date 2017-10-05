using System;
namespace HumanProj
{
    class Wizard : Human
    {
        private Random rnd;
        public Wizard(string person) : base(person, 3, 25, 3, 50)
        {
            rnd = new Random();
            ;
        }
        public void Heal()
        {
            int healing = 10 * intelligence;
            System.Console.WriteLine($"{base.name} heals self for for {healing} points.");
            base.health += healing;
            if (base.health > base.maxHealth)
            {
                Console.WriteLine("Healing capped by max health.");
                base.health = base.maxHealth;
            }
        }
        public void fireball(Human target)
        {
            int damage = rnd.Next(20, 50);
            System.Console.WriteLine($"{base.name} fireballs {target.name} for {damage} points.");
            target.health -= damage;
            if (target.health < 0)
            {
                target.health = 0;
            }
        }
        public override void Print()
        {
            System.Console.WriteLine(" Wizard [" + this.ToString() + "]");
        }
    }
}