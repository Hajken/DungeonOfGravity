using DungeonOfGravity.Creatures;
using DungeonOfGravity.GameActions;
using DungeonOfGravity.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Game
{
    class GameController
    {
        int _worldWidth;
        int _worldHeight;
        Player _player;
        Dungeon _dungeon = new Dungeon();
        PlayerAction _playerAction = new PlayerAction();
        string userName;


        public void Start()
        {
            Console.WriteLine("Welcome to Dungeon Of Gravity!");
            Console.WriteLine("Pick a UserName: ");
            userName = Console.ReadLine();
            _player=_playerAction.CreatePlayer(userName);

        }
    }
}
