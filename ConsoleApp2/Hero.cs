using System;

namespace ConsoleApp2
{
    public abstract class Hero
    {   public string Name { get; protected set; }
        public int Level { get; protected set; }

       
        protected Hero(string name, int level = 1)
        {
            Name = name;
            Level = level;
        }

        
        public abstract void UseAbility();

        public virtual void LevelUp()
        {
            Level++;
        }
    }
}
