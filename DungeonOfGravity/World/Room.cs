using DungeonOfGravity.Creatures;
using DungeonOfGravity.Extensions;
using DungeonOfGravity.Items;
using System.Collections.Generic;


namespace DungeonOfGravity.World
{
    class Room
    {
        public Room()
        {
           
        }
        public List<Creature> CreatureInRoom { get; set; }
        public List<Item> TreasuresInRoom { get; set; }
    }
}
