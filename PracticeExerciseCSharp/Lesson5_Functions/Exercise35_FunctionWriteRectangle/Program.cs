using System;

namespace Exercise35_FunctionWriteRectangle
{
    /// <summary>
    /// Create a function WriteRectangle to display a (filled) rectangle on the screen, 
    /// with the width and height indicated as parameters, using asterisks. 
    /// Complete the test program with a Main function:
    /// 
    /// WriteRectangle(4,3);
    /// 
    /// should display
    /// ****
    /// ****
    /// ****
    /// 
    /// Create also a function WriteHollowRectangle to display only the border of the rectangle:
    /// WriteHollowRectangle(3,4);
    /// 
    /// should display
    /// ***
    /// **
    /// **
    /// ***
    /// </summary>
    internal class Program
    {
        static void WriteRectangle(int width, int height)
        {
            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= height; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void WriteHollowRectangle(int width, int height)
        {

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if ((i == 1) || (i == height))
                        Console.Write("*");
                    else
                    {
                        if ((j == 1) || (j == width))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            WriteRectangle(4, 3);
            Console.WriteLine();
            WriteHollowRectangle(3, 4);
            Console.ReadLine();
        }
    }
}
