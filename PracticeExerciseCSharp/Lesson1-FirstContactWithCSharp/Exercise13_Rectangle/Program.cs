using System;

namespace Exercise13_Rectangle
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for a number and then display a rectangle 3 columns wide and 5 rows tall using that digit. For example:
        /// 
        /// Enter a digit: 3
        /// 333
        /// 3 3
        /// 3 3
        /// 3 3
        /// 333.
        /// </summary>
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
    }
}
