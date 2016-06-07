using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Items.FoodItems
{
    class Food : Item
    {
        public Food(string name, int weight) : base(name, weight)
        {

        }
        public int HealthRegeneration { get; set; }
        public int OverTime { get; set; }
    }
}
