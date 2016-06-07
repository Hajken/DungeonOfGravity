using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items.GearItems
{
    class Armor:Gear
    {
        public Armor(string name, int weight) : base(name, weight)
        {

        }

        public int Protection { get; set; }
    }
}
