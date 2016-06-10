using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Creatures.Monsters
{
    class Ogre : Monster
    {
        public Ogre(int level, int health, int experienceWhenKilled, int attackDamage) : base(level,health, experienceWhenKilled, attackDamage)
        {

        }

        public override void Fight(Creature opponent)
        {
            opponent.Health -= 10;
        }
    }
}
