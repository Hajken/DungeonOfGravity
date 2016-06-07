using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items
{
    class Legs : Gear
    {
        public Legs(string name, int weight) : base(name, weight)
        {

        }
        public int Protection { get; set; }
    }
}
