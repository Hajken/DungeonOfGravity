using DungeonOfGravity.Items;
using System.Collections.Generic;


namespace DungeonOfGravity.Creatures
{
    public abstract class Creature
    {

        public int Health { get;  set; }

        //add this later
       // public int MovementSpeed { get; protected set; }

        public bool IsDead { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; }

        protected Creature(int health,int level)
        {
            Health = health;
            Level = level;
            IsDead = false;
            Inventory = new List<Item>();
        }

        public virtual void Fight(Creature opponent)
        {
            opponent.Health -= 10;
        }
    }
}
