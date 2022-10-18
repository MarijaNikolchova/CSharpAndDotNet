using System;

namespace Exercise09_TimesTable
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for a number and 
        /// display its multiplication table, using a "while" statement.
        /// </summary>
        static void Main(string[] args)
        {
            int num, multiplier = 1;

            Console.Write("Insert a number to multiply: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (multiplier <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}",
                    num, multiplier, num * multiplier);
                multiplier++;
            }
        }
    }
}
