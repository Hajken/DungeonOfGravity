using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items
{
    class Boots : Gear
    {
        public Boots(string name, int weight) : base(name, weight)
        {

        }

        public int Protection { get; set; }
        public int SpeedBoost { get; set; }

    }
}
