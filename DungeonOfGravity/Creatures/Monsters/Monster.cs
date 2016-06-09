using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Creatures.Monsters
{
    abstract class Monster: Creature
    {
        public Monster( int level, int health,int experienceWhenKilled, int attackDamage) : base(health, level)
        {
            ExperienceWhenKilled = experienceWhenKilled;
            AttackDamage = attackDamage;
        }

        public int AttackDamage { get; set; }
        public int ExperienceWhenKilled { get; set; }

    }
}
