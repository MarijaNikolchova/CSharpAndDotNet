using System;

namespace Exercise02_MultiplyIfNotZero
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for a number; if it is not zero, 
        /// then it will ask for a second number and display their product; otherwise, it will display "0".
        /// </summary>
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("enter x:");
            x = System.Convert.ToInt32(System.Console.ReadLine());

            if (x != 0)
            {
                Console.Write("enter y:");
                y = System.Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine("the product of {0} and {1} is {2}",
                x, y, x * y);
            }

            if (x == 0)
                Console.Write("0");
        }
    }
}
