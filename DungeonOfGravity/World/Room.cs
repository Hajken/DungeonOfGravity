using DungeonOfGravity.Creatures;
using DungeonOfGravity.Extensions;
using DungeonOfGravity.Items;
using System.Collections.Generic;
using DungeonOfGravity.Creatures.Monsters;


namespace DungeonOfGravity.World
{
    class Room
    {
        public Room()
        {
           
        }
        public Monster CreatureInRoom { get; set; }
        public Item TreasuresInRoom { get; set; }
    }
}
