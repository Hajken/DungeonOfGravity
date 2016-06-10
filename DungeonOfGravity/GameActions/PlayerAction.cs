using DungeonOfGravity.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.GameActions
{
    public class PlayerAction
    {
        Player _player;


        //if create new player set class to rookie an
        public Player CreatePlayer(string userName)
        {
            _player = new Player(userName, 100,1);
            return _player;
        }



    }
}
