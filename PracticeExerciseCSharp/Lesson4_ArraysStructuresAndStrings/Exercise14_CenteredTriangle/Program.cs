using System;

namespace Exercise14_CenteredTriangle
{
    /// <summary>
    /// Display a centered triangle from a string entered by the user:
    /// 
    /// __a__
    /// _uan_
    /// Juan
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            if (name.Length % 2 == 0)
                name += " ";

            int position = name.Length / 2;
            int maxRows = name.Length / 2 + 1;
            int amount = 1;

            for (int i = 0; i < maxRows; i++)
            {
                for (int j = 0; j < position; j++)
                    Console.Write(" ");
                Console.WriteLine(name.Substring(position, amount));
                position--;
                amount += 2;
            }
        }
    }
}
