using System;

namespace Exercise06_TwoDimensionalArray
{
    /// <summary>
    /// Write a C# program to ask the user for marks for 20 pupils 
    /// (2 groups of 10, using a two-dimensional array), and display the average for each group.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] puntuations = new float[10, 10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the puntuation {0} group {1}: ", j + 1, i + 1);
                    puntuations[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
        }
    }
}
