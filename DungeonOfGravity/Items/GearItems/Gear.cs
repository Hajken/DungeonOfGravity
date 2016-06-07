using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items.GearItems
{
    class Gear: Item    
    {
        public Gear(string name, int weight) : base(name, weight)
        {

        }


        //witch class can wear this item
        public string ForClass { get; set; }

    }
}
