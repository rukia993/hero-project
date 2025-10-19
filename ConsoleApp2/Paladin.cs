using System;

namespace ConsoleApp2
{
    public class Paladin : Hero, IMagicUser, IPhysicalFighter
    {
        public Paladin(string name, int level = 1) : base(name, level)
        {
        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} использует священную способность!");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} произносит священное заклинание!");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} атакует священным оружием!");
        }
    }
}
