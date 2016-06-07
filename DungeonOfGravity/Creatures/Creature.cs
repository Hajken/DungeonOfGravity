using DungeonOfGravity.Extensions;
using DungeonOfGravity.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Creatures
{
    abstract class Creature
    {

        public int Health { get;  set; }

        //add this later
       // public int MovementSpeed { get; protected set; }

        public bool IsDead { get; set; }
        public int Level { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Item> Inventory { get; set; }

        public Creature(int health,int level, int x, int y)
        {
            Health = health;
            Level = level;
            IsDead = false;
            X = x;
            Y = y;
            Inventory = new List<Item>();
        }

        public virtual void Fight(Creature opponent)
        {
            opponent.Health -= 10;
        }
    }
}
