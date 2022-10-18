using System;

namespace Exercise33_ConditionalOperator
{
    internal class Program
    {
        /// <summary>
        /// Do it in two different ways: first using "if" and then using the "conditional operator" (?)
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, amountOfPositives;

            Console.Write("Enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if ((a > 0) && (b > 0))
                amountOfPositives = 2;
            else
                if ((a > 0) || (b > 0))
                amountOfPositives = 1;
            else
                amountOfPositives = 0;
            Console.WriteLine("{0} positives.", amountOfPositives);

            amountOfPositives = ((a > 0) && (b > 0)) ? 2 :
                ((a > 0) || (b > 0)) ? 1 : 0;
            Console.WriteLine("{0} positives.", amountOfPositives);
        }
    }
}
