using System;

namespace Exercise06_FunctionWriteUnderlined
{
    /// <summary>
    /// Create a function able to write centered on screen the text that is indicated as a parameter 
    /// (supposing a screen width of 80 characters) and then 
    /// underline it (writing several hyphens under that word):
    /// 
    /// WriteUnderlined("Hello!");
    /// </summary>
    internal class Program
    {
        public static void WriteUnder(string text)
        {
            int countSpaces = (80 - text.Length) / 2;
            int i = 0;

            for (; i < countSpaces; i++)
                Console.Write(" ");

            Console.WriteLine(text);

            for (i = 0; i < countSpaces; i++)
                Console.Write(" ");

            for (i = 0; i < text.Length; i++)
                Console.Write("_");
        }

        public static void Main()
        {
            WriteUnder("Hello");
        }
    }
}
