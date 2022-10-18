using System;

namespace Exercise38_FunctionSquareRoot
{
    /// <summary>
    /// Create a function SquareRoot, to calculate and return the approximated Square Root of an integer number, 
    /// between two specified values:
    /// 
    /// Console.Write( SquareRoot(82, 2, 12) );
    /// 
    /// would try to find the square root of 82, trying values between 2 and 12, so it would return 9
    /// </summary>
    internal class Program
    {
        public static int SquareRoot(int number, int min, int max)
        {
            int result = 0;
            for (int i = min; i <= max; i++)
                if ((i * i) <= number)
                    result = i;

            return result;
        }

        public static void Main()
        {
            Console.WriteLine(SquareRoot(82, 2, 12));
            Console.WriteLine(SquareRoot(99, 2, 12));
            Console.WriteLine(SquareRoot(100, 2, 12));
            Console.WriteLine(SquareRoot(101, 2, 12));
        }
    }
}
