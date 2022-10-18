using System;

namespace Exercise01_ReverseArray
{
    /// <summary>
    /// Create a program to ask the user for 5 numbers, 
    /// store them in an array and show them in reverse order.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0} =  ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 4; i >= 0; i--)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
