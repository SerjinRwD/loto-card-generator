using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoCardGenerator.Helpers
{
    public class RandomHelper
    {
        private static readonly Random _rnd = new Random();

        public static int Next()
        {
            return _rnd.Next();
        }

        public static int Next(int maxValue)
        {
            return _rnd.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            return _rnd.Next(minValue, maxValue);
        }
    }
}
