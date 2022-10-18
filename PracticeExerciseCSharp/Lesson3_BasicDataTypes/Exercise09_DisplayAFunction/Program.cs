using System;

namespace Exercise09_DisplayAFunction
{
    internal class Program
    {
        /// <summary>
        /// Create a program to "draw" the graphic of the function y = (x-4)2 for integer values 
        /// of x ranging -1 to 8. It will show as many asterisks on screen as the value obtained 
        /// for "y", like this:
        /// 
        /// *************************
        /// ****************
        /// *********
        /// ****
        /// *
        /// 
        /// *
        /// ****
        /// *********
        /// ****************
        /// </summary>
        static void Main(string[] args)
        {
            int x, y, j;
            for (x = -1; x <= 8; x++)
            {
                y = (x - 4) * (x - 4);

                for (j = 0; j < y; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
