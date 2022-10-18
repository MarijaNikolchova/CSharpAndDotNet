using System;

namespace Exercise39_FunctionGetMinMax
{
    /// <summary>
    /// Create a function named "GetMinMax", which will ask the user for a minimum value (a number) 
    /// and a maximum value (another number). It should be called in a similar way to
    /// 
    /// GetMinMax(n1, n2);
    /// 
    /// which would behave like this:
    /// Enter the minimum value: 5
    /// Enter the maximum value: 3.5
    /// Incorrect.Should be 5 or more.
    /// Enter the maximum value: 7
    /// 
    /// That is: it should ask for the minimum value and then for the maximum. 
    /// If the maximum is less than the minimum, it must be reentered. It must return both values.
    /// </summary>
    internal class Program
    {
        public static void GetMinMax(ref float number1, ref float number2)
        {
            Console.Write("Enter the minimum value: ");
            number1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the maximum value: ");
            number2 = Convert.ToSingle(Console.ReadLine());

            while (number2 < number1)
            {
                Console.WriteLine("Incorrect. Should be {0} or more.", number1);
                Console.Write("Enter the maximum value: ");
                number2 = Convert.ToSingle(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            float number1 = 000000000.00f, number2 = 000000000.00f;
            GetMinMax(ref number1, ref number2);
        }
    }
}
