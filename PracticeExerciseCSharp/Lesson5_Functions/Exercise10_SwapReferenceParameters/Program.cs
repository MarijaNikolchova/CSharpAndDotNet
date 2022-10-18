using System;

namespace Exercise10_SwapReferenceParameters
{
    /// <summary>
    /// Create a function named "Swap" to swap the values of two integer numbers, which are passed by reference.
    /// 
    /// An example of use might be:
    /// 
    /// int x = 5, y = 3;
    /// Swap(ref x, ref y);
    /// Console.WriteLine("x={0}, y={1}", x, y);
    /// (which should write "x=3, y=5")
    /// </summary>
    internal class Program
    {
        public static void Swap(ref int x, ref int y)
        {
            int swap;

            swap = x;
            x = y;
            y = swap;
        }

        public static void Main()
        {
            int x = 5;
            int y = 3;

            Swap(ref x, ref y);

            Console.WriteLine("x: {0} , y: {1}", x, y);
        }
    }
}
