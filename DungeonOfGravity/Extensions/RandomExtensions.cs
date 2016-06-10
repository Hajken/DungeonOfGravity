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

        public static int GenerateNumber(int from, int to)
        {
            return random.Next(from, to + 1);

        }

        /// <summary>
        /// Gets a random value from 0 to one less then maxValue
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GetValue(int maxValue)
        {
            return random.Next(maxValue);
        }

        /// <summary>
        /// Gets a random value from minValue to one less then maxValue
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GetValue(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }


        public static bool Chance(int probability)
        {
            var result = random.Next(100);
            return result < probability;
        }
    }
}
