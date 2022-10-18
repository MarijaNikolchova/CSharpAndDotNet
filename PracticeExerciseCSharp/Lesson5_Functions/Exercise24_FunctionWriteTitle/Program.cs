using System;

namespace Exercise24_FunctionWriteTitle
{
    /// <summary>
    /// Create a function named "WriteTitle" to write a text centered on screen, 
    /// uppercase,with extra spaces and with a line over it and another line under it:
    /// 
    /// WriteTitle("Welcome!");
    /// 
    /// would write on screen(centered on 80 columns):
    /// 
    /// --------------- W E L C O M E ! ---------------
    /// 
    /// (Obviously, the number of hyphens should depend on the length of the text).
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

        public static void Main()
        {
            WriteTitle("Welcome!");

            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            WriteTitle(text);
        }
    }
}
