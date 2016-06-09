using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Creatures.Monsters
{
    class Goblin: Monster
    {
        public Goblin(int level, int health, int experienceWhenKilled, int attackDamage) : base(level,health, experienceWhenKilled, attackDamage)
        {

        }

        public override void Fight(Creature opponent)
        {
            opponent.Health -= 10;
        }
    }
}
