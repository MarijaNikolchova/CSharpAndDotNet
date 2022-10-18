using System;

namespace Exercise13_Rectangle
{
    /// <summary>
    /// Write a C# program to ask the user for his/her name and a size, 
    /// and display a hollow rectangle with it:
    /// 
    /// Enter your name: Yo
    /// Enter size: 4
    /// YoYoYoYo
    /// Yo____Yo
    /// Yo____Yo
    /// YoYoYoYo
    /// 
    /// (note: the underscores _ should not be displayed on screen; 
    /// you program should display blank spaces inside the rectangle)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, width, height;
            int row, column;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired height: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (row = 0; row < height; row++)
            {
                for (column = 0; column < width; column++)
                    Console.Write(n);
                Console.WriteLine();
            }
        }
    }
}
