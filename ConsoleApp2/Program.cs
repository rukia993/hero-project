using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Система управления героями ===");
            Console.WriteLine();

            Wizard wizard = new Wizard("Мерлин");
            Warrior warrior = new Warrior("Александр");
            Paladin paladin = new Paladin("Артур");

            HeroManager<Hero> heroManager = new HeroManager<Hero>();
            heroManager.AddHero(wizard);
            heroManager.AddHero(warrior);
            heroManager.AddHero(paladin);

            Console.WriteLine("Герои в системе:");
            heroManager.DisplayHeroes();
            Console.WriteLine();

            Console.WriteLine("Использование способностей:");
            wizard.UseAbility();
            warrior.UseAbility();
            paladin.UseAbility();
            Console.WriteLine();

            Console.WriteLine("Использование интерфейсных методов:");
            wizard.CastSpell();
            warrior.Attack();
            paladin.CastSpell();
            paladin.Attack();
            Console.WriteLine();

            Console.WriteLine("Повышение уровней:");
            heroManager.LevelUpHero("Мерлин");
            heroManager.LevelUpHero("Александр");
            heroManager.LevelUpHero("Артур");
            Console.WriteLine();

            Console.WriteLine("Герои после повышения уровня:");
            heroManager.DisplayHeroes();
            Console.WriteLine();

            Console.WriteLine($"Максимальный уровень: {GameSettings.MaxLevel}");

            for (int i = 0; i < 102; i++)
            {
                heroManager.LevelUpHero("Мерлин");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
