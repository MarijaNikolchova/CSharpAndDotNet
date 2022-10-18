using System;

namespace Exercise17_TriangleRightSide
{
    /// <summary>
    /// Create a program that asks the user for a string and displays a right-aligned triangle:
    /// 
    /// ____n
    /// ___an
    /// __uan
    /// Juan
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell a string:");
            string Entry = Console.ReadLine();
            string content = "";
            int j = 1;
            for (int i = Entry.Length; i <= 0; i--)
            {
                for (int c = 0; c <= Entry.Length; c--)
                {
                    Console.Write("_");
                    content = Convert.ToString(Entry.Substring(i, j));
                    j++;
                    Console.Write(content);
                }
                Console.WriteLine();
            }
        }
    }
}
