using System;

namespace Exercise25_ReturnValueForMain
{
    /// <summary>
    /// Create a program in which you write a title (using the previous WriteTitle function) 
    /// which the user will specify in command line. If no text is specified, 
    /// your program will display an error message and return a value of 1 to the operatiing system.

    /// </summary>
    internal class Program
    {
        public static void WriteTitle(string text)
        {
            int numOfSpaces = (80 - text.Length * 2) / 2;
            text = text.ToUpper();

            // Upper line
            for (int i = 0; i < numOfSpaces; i++)
                Console.Write(" ");
            for (int i = 0; i < text.Length * 2 - 1; i++)
                Console.Write("-");
            Console.WriteLine();

            // Real title
            for (int i = 0; i < numOfSpaces; i++)
                Console.Write(" ");
            for (int i = 0; i < text.Length; i++)
                Console.Write(text[i] + " ");
            Console.WriteLine();

            // Lower line
            for (int i = 0; i < numOfSpaces; i++)
                Console.Write(" ");
            for (int i = 0; i < text.Length * 2 - 1; i++)
                Console.Write("-");
            Console.WriteLine();
        }

        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("What??!!");
                return 1;
            }

            WriteTitle(args[0]);

            return 0;
        }
    }
}
