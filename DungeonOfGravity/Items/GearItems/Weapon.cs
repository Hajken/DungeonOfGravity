using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items.GearItems
{
    class Weapon : Gear
    {
        public Weapon(string name, int weight) : base(name, weight)
        {

        }

        public int Damage { get; set; }
        public bool TwoHanded { get; set; }

    }
}
