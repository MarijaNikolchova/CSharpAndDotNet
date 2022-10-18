using System;

namespace Exercise26_DrawParallelogram
{
    /// <summary>
    /// Create a function which draws a parallelogram, with the width, height and character specified as parameters:
    /// 
    /// DrawParallelogram(10,4,'*');
    /// 
    /// would display
    /// 
    /// **********
    /// _**********
    /// __**********
    /// ___**********
    /// 
    /// (The symbol _ means a position where a blank space must be displayed)
    /// </summary>
    internal class Program
    {
        static void DrawParallelogram(int width, int height, char character)
        {
            for (int i = 0; i < height; i++)
            {
                // Write character
                for (int j = 0; j < width; j++)
                    Console.Write(character);
                Console.WriteLine();
                // Write spaces
                for (int c = 0; c <= i; c++)
                    Console.Write(" ");
            }
        }
        static void Main()
        {
            DrawParallelogram(10, 4, '*');
        }
    }
}
