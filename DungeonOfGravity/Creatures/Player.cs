using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Creatures
{
    class Player : Creature
    {
        //when create player the player starts at lvl 1.
        public Player(string userName, int x, int y) : base(1000, 1, x, y)
        {
            Name = userName;
            PlayerClss = "Rookie";
            Experience = 0;
            Strength = 10;
            Agility = 10;
            Distance = 10;
            Magic = 0;
        }

        public string Name { get; set; }

        public int Experience { get; set; }

        //in future his will not be string
        public string PlayerClss { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Magic { get; set; }

        public int Distance { get; set; }

    }
}
