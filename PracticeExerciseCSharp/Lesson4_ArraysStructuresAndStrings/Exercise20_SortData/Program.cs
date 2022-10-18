using System;

namespace Exercise20_SortData
{
    /// <summary>
    /// Create a program to ask the user for 10 integer numbers (from -1000 to 1000), 
    /// sort them and display them sorted.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 9;
            int[] data = new int[total];
            int i, j, aux;

            for (i = 0; i < total; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < total - 1; i++)
            {
                for (j = i + 1; j < total; j++)
                {
                    if (data[i] > data[j])
                    {
                        aux = data[i];
                        data[i] = data[j];
                        data[j] = aux;
                    }
                }
            }
            Console.Write("Sorted:");
            foreach (int valor in data)
                Console.Write("{0} ", valor);
        }
    }
}
