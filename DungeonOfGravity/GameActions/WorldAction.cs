using DungeonOfGravity.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.GameActions
{
    class WorldAction
    {
        Dungeon _dungeon = new Dungeon();
       
        public Dungeon CreateWorld(int height, int width)
        {

            _dungeon.Rooms = new Room[height, width];
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    _dungeon.Rooms[row, col] = new Room();
                }
            }

            return _dungeon;
        }
    }
}
