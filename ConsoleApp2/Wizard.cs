using System;

namespace ConsoleApp2
{
    public class Wizard : Hero, IMagicUser
    {
        public Wizard(string name, int level = 1) : base(name, level)
        {
        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} использует магическую способность!");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} произносит заклинание!");
        }
    }
}
