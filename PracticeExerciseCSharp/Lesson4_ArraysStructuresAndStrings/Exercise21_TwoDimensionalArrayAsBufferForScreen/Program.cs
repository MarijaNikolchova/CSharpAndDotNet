using System;

namespace Exercise21_TwoDimensionalArrayAsBufferForScreen
{
    /// <summary>
    /// Create a C# program that declares a 70x20 two-dimensional array of characters, 
    /// "draws" 80 letters (X, for example) in random positions and displays the content of the array on screen.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] position = new char[20, 70];

            Random generator = new Random();
            int i = 0;

            for (; i < 80; i++)
                position[generator.Next(0, 20), generator.Next(0, 70)] = 'X';

            for (i = 0; i < 20; i++)
            {
                for (int j = 0; j < 70; j++)
                    Console.Write(position[i, j]);

                Console.WriteLine();
            }
        }
    }
}
