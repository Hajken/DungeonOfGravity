using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items
{
    class Item
    {
        public Item(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public bool CanPickup { get; set; }
        public string Name { get; private set; }
        public int Weight { get; private set; }
    }
}
