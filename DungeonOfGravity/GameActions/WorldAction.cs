using DungeonOfGravity.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonOfGravity.Creatures.Monsters;
using DungeonOfGravity.Extensions;
using NUnit.Framework.Internal;

namespace DungeonOfGravity.GameActions
{
    class WorldAction
    {
        readonly Dungeon _dungeon = new Dungeon();
       
        public Dungeon CreateWorld(int height, int width)
        {

            _dungeon.Rooms = new Room[height, width];
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Room room = new Room();
                    _dungeon.Rooms[row, col] = room;

                    if (RandomExtensions.Chance(20))
                    {
                        if (RandomExtensions.Chance(60))
                        {
                            
                            //60% chanse for item

                        }
                        else
                        {
                            int chance = RandomExtensions.GetValue(0, 100);
                            //40% chanse for monster
                            if (chance < 30)
                            {
                                room.CreatureInRoom = new Goblin(1, 10, 5, 1);
                            }
                            else
                            {
                                room.CreatureInRoom = new Ogre(2, 5, 10,3);
                            }
                        }
                    }
                }
            }

            return _dungeon;
        }
    }
}
