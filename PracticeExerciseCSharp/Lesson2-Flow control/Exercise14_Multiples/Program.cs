using System;

namespace Exercise14_Multiples
{
    internal class Program
    {
        /// <summary>
        /// Create a program to write on screen the numbers from 1 to 500 that are multiples 
        /// of 3 and also multiples of 5 (hint: use the remainder of the division).
        /// </summary>
        static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
        }

        /// <summary>
        /// Multiples 3 and 5.
        /// </summary>
        static void Example1()
        {
            int i = 1;

            while (i <= 500)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.Write("{0} ", i);

                i++;
            }
        }

        /// <summary>
        /// Multiples 3 and 5 for
        /// </summary>
        static void Example2()
        {
            int i = 1;

            for (i = 1; i <= 500; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.Write("{0} ", i);
            }
        }

        /// <summary>
        /// Multiples 3 and 5 for step 15.
        /// </summary>
        static void Example3()
        {
            for (int i = 15; i <= 500; i += 15)
                Console.Write("{0} ", i);
        }
    }
}
