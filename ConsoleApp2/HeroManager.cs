using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
   
    public class HeroManager<T> where T : Hero
    {
        private List<T> heroes;

        public HeroManager()
        {
            heroes = new List<T>();
        }

        
        public void AddHero(T hero)
        {
            heroes.Add(hero);
        }

       
        public void LevelUpHero(string name)
        {
            T? hero = heroes.FirstOrDefault(h => h.Name == name);
            
            if (hero != null)
            {
                if (GameSettings.IsLevelValid(hero.Level + 1))
                {
                    hero.LevelUp();
                }
                else
                {
                    Console.WriteLine($"Герой {name} не может повысить уровень - достигнут максимум!");
                }
            }
            else
            {
                Console.WriteLine($"Герой с именем {name} не найден!");
            }
        }

        public void DisplayHeroes()
        {
            foreach (var hero in heroes)
            {
                Console.WriteLine($"Герой: {hero.Name}, Уровень: {hero.Level}");
            }
        }
    }
}
