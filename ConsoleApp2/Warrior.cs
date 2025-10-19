using System;

namespace ConsoleApp2
{
    public class Warrior : Hero, IPhysicalFighter
    {
        public Warrior(string name, int level = 1) : base(name, level)
        {
        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} использует боевую способность!");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} атакует противника!");
        }
    }
}
