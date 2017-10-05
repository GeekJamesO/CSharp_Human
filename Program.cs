using System;

namespace HumanProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Human fred = new Human("fred");
            fred.Print();
            Wizard Godozo = new Wizard("Godozo");
            fred.attack(Godozo);
            Godozo.Print();
            Godozo.Heal();
            Godozo.Print();
            Godozo.fireball(fred);
            if (fred.health > 50)
            {
                Godozo.fireball(fred);
            }
            fred.Print();

            Ninja ned = new Ninja("Ned");
            ned.Print();

            var sam = new Samurai("Sam");
            sam.DeathBlow(fred);
            fred.Print();
            var samBo = new Samurai("SamBo");

            System.Console.WriteLine($"There has been {sam.how_many()} Samurai's so far...");


        }
    }
}
