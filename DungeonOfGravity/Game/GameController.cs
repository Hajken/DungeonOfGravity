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
        const int _worldWidth = 10;
        const int _worldHeight= 10;
        Player _player;

        //The dungeon 
        Dungeon _dungeon = new Dungeon();

        //this will call all actions
        PlayerAction _playerAction = new PlayerAction();
        WorldAction _worldAction = new WorldAction();
        string userName;


        public GameController()
        {

        }

        public void Start()
        {
            Console.WriteLine("Welcome to Dungeon Of Gravity!");

            CreateWorld();
            Console.WriteLine("The Dungeon is waiting for you!!!");

            CreatePlayer();

        }

        private void CreateWorld()
        {
            _dungeon = _worldAction.CreateWorld(_worldHeight, _worldWidth);
        }

        private void CreatePlayer()
        {
            Console.WriteLine("Pick a UserName: ");
            userName = Console.ReadLine();
            _player = _playerAction.CreatePlayer(userName);
        }


    }
}
