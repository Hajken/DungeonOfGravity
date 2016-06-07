using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items
{
    class Shield : Gear
    {
        public Shield(string name, int weight) : base(name, weight)
        {

        }

        public int BlockRate { get; set; }

    }
}
