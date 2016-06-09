using DungeonOfGravity.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController startGame = new GameController();
            startGame.Start();
        }
    }
}
