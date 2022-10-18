using System;

namespace Exercise05_FunctionWriteCentered
{
    /// <summary>
    /// Create a function to write centered on screen the text that is indicated as a parameter 
    /// (supposing a screen width of 80 characters):
    /// 
    /// WriteCentered("Hello!");
    /// </summary>
    internal class Program
    {
        public static void WriteCentered(string text)
        {
            int i = 0;

            for (; i < 17; i++)
                Console.WriteLine();

            for (i = 0; i < 36; i++)
                Console.Write(" ");

            Console.Write(text);

            for (i = 0; i < 14; i++)
                Console.WriteLine();
        }

        static void Main(string[] args)
        {
            WriteCentered("Hello");
        }
    }
}
