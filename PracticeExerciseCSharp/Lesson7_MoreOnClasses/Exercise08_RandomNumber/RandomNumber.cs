using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_RandomNumber
{
    internal class RandomNumber
    {
        private static int m = 233280;
        private static int a = 9301;
        private static int c = 49297;
        private static int seed = 1;

        public static float GetFloat()
        {
            seed = (seed * a + c) % m;
            return Math.Abs(seed / m);
        }

        public static int GetInt(int max)
        {
            return 0;
        }

        public static int GetInt(int min, int max)
        {
            return 0;
        }
    }
}
