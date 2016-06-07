using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items.PotionItems
{
    class EnergyPotion : Item
    {
        public EnergyPotion(string name, int weight) : base(name, weight)
        {

        }
        public int InstantHealthRegeneration { get; set; }

    }
}
