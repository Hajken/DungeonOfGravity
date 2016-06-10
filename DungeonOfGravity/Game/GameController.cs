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
        const int WorldWidth = 10;
        const int WorldHeight= 10;
        Player _player;

        //The dungeon 
        Dungeon _dungeon = new Dungeon();

        //this will call all actions
        readonly PlayerAction _playerAction = new PlayerAction();
        readonly WorldAction _worldAction = new WorldAction();
        string _userName;


        public void Start()
        {
            Console.WriteLine("Welcome to Dungeon Of Gravity!");

            CreateWorld();
            Console.WriteLine("The Dungeon is waiting for you!!!");

            CreatePlayer();

        }

        private void CreateWorld()
        {
            _dungeon = _worldAction.CreateWorld(WorldHeight, WorldWidth);
        }

        private void CreatePlayer()
        {
            Console.WriteLine("Pick a UserName: ");
            _userName = Console.ReadLine();
            _player = _playerAction.CreatePlayer(_userName);
        }


    }
}
