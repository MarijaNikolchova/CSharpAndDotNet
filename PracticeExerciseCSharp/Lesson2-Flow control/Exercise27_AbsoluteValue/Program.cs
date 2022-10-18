using System;

namespace Exercise27_AbsoluteValue
{
    internal class Program
    {
        /// <summary>
        /// Write a program to calculate (and display) the absolute value of a number x: 
        /// if the number is positive, its absolute value is exactly the number x; 
        /// if it is negative, its absolute value is -x. 
        /// 
        /// Do it in two different ways in the same program: using "if" and using the 
        /// "conditional operator" (?)
        /// </summary>
        static void Main(string[] args)
        {
            int n, abs;
            Console.Write("Enter a number: ");

            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
                abs = -n;
            else
                abs = n;

            Console.WriteLine("Absolute value is {0}", abs);

            abs = n < 0 ? -n : n;

            Console.WriteLine("And also {0}", abs);
        }
    }
}
