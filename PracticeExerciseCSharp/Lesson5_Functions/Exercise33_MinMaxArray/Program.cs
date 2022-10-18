using System;

namespace Exercise33_MinMaxArray
{
    /// <summary>
    /// Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, 
    /// using reference parameters:
    /// 
    /// float[] data = { 1.5f, 0.7f, 8.0f }
    /// MinMaxArray(data, ref minimum, ref maximum);
    /// (after that call, minimum would contain 0.7, and maximum would contain 8.0)
    /// </summary>
    internal class Program
    {
        public static void MinMaxArray(float[] number, ref float min, ref float max)
        {
            max = number[0];
            min = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] > max)
                    max = number[i];
                if (number[i] < min)
                    min = number[i];
            }

        }

        public static void Main(string[] args)
        {
            float[] data = { 3.5f, 0.5f, 9, 0f };
            float min = 0.0f;
            float max = 0.0f;

            MinMaxArray(data, ref min, ref max);

            Console.WriteLine("Minimun: {0} - Maximun: {1}", min, max);
        }
    }
}
