using System;

namespace Exercise21_BreakAndContinue
{
    internal class Program
    {
        /// <summary>
        /// Create a program to write the even numbers from 10 to 20, both included, 
        /// except 16, in 3 different ways:
        /// 
        /// - Incrementing 2 in each step(use "continue" to skip 16)
        /// - Incrementing 1 in each step(use "continue")
        /// - With and endless loop(using "break" & "continue")
        /// </summary>
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i += 2)
            {
                if (i == 16)
                    continue;
                Console.WriteLine(i);
            }

            for (int i = 10; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                if (i == 16)
                    continue;
                Console.WriteLine(i);
            }

            for (int i = 10; ; i += 2)
            {
                if (i == 16)
                    continue;
                if (i > 20)
                    break;
                Console.WriteLine(i);

            }
        }
    }
}
