using System;

namespace HumanProj
{
    public class Human
    {
        public string name;
        protected int maxHealth;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            maxHealth = health;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
            maxHealth = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                var damage = strength * 5;
                System.Console.WriteLine($"{this.name} attacks {enemy.name} for {damage}.");
                enemy.health -= damage;
                //TODO cap at zero?
            }
        }
        public override string ToString()
        {
            return $"'{this.name}' Str:{this.strength}, Int:{this.intelligence}, Dex:{this.dexterity}, HP:{this.health} ";
        }
        public virtual void Print()
        {
            System.Console.WriteLine(" Human [" + this.ToString() + "]");
        }
    }
}