using System;

namespace Exercise23_RepetitiveStructures
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for two numbers and display 
        /// the numbers between them (both included), three times: using "for", 
        /// using "while" and using "do..while"
        /// 
        /// Enter first number: 6
        /// Enter last number 12
        /// 
        /// 6 7 8 9 10 11 12
        /// 6 7 8 9 10 11 12
        /// 6 7 8 9 10 11 12
        /// </summary>
        static void Main(string[] args)
        {
            int number, number2;
            int i;

            Console.Write("Enter first number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter last number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            for (i = number; i <= number2; i++)
                Console.Write("{0} ", i);

            Console.WriteLine();

            i = number;
            while (i <= number2)
            {
                Console.Write("{0} ", i);
                i++;
            }
            Console.WriteLine();


            i = number;
            do
            {
                Console.Write("{0} ", i);
                i++;
            }
            while (i <= number2);

            Console.WriteLine();
        }
    }
}
