using System;

namespace Exercise08_FunctionDouble
{
    /// <summary>
    /// Create a function named "Double" to calculate and return an integer number doubled. 
    /// For example. Double(7) should return 14.
    /// </summary>
    internal class Program
    {
        public static int Double(int number)
        {
            return number * 2;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Double of {0} is {1}", number, Double(number));
        }
    }
}
