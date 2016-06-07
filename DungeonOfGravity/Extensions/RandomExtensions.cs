using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonOfGravity.Extensions
{
    static class RandomExtensions
    {
        static Random random = new Random();

        public static int GenerateNumber(this int from, int to)
        {
            return random.Next(from, to + 1);

        }
    }
}
