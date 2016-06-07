using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.World
{
    class Dungeon
    {
        public const int Height = 10;
        public const int Width = Height;

        public Room[,] Rooms { get; private set; }

        internal Dungeon()
        {
            Rooms = new Room[Height, Width];
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    Rooms[row, col] = new Room();
                }
            }

        }

    }
}
