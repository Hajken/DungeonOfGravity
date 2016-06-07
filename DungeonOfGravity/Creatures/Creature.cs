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
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Magic { get; set; }
        public int Distance { get; set; }

        public int Health { get; protected set; }

        public bool IsDead { get; set; }
        public int Level { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Item> Inventory { get; set; }

        public Creature(int health, int x, int y)
        {
            Health = health;
            X = x;
            Y = y;
            IsDead = false;
            Inventory = new List<Item>();
        }

        public virtual void Fight(Creature opponent)
        {
            opponent.Health -= 10;
        }
    }
}
