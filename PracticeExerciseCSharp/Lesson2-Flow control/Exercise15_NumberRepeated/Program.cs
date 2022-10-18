using System;

namespace Exercise15_NumberRepeated
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a number and an amount, and shows that number repeated as many times as the user has indicated, as in the following example:
        /// 
        /// Enter a number: 4
        /// Enter an amount: 5
        /// 
        /// 44444
        /// 
        /// You must display it three times: first using "while", then "do-while" and finally "for".
        /// </summary>
        static void Main(string[] args)
        {
            int num, amount;
            int i;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < amount; i++)
                Console.Write(num);


            Console.WriteLine();

            i = 0;
            while (i < amount)
            {
                Console.Write(num);
                i++;
            }


            Console.WriteLine();

            i = 0;
            do
            {
                Console.Write(num);
                i++;
            }
            while (i < amount);
        }
    }
}
