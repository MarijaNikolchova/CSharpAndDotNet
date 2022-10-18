using System;

namespace Exercise11_ComplexImproved
{
    /// <summary>
    /// Improve the "ComplexNumber" class, so that it overloads the operators + and - to add and subtract numbers.
    /// </summary>
    internal class ComplexTest
    {
        static void Main(string[] args)
        {
            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());
        }
    }
}
