using System;

namespace Exercise05_ComplexNumbers
{
    /// <summary>
    /// A complex number has two parts: the real part and the imaginary part. 
    /// In a number such as a+bi (2-3i, for example) the real part would be "a" (2) and 
    /// the imaginary part would be "b" (-3).
    /// 
    /// Create a class ComplexNumber with:
    /// A constructor to set the values for the real part and the imaginary part.
    /// Setters and getters for both.
    /// A method "ToString", which would return "(2,-3)"
    /// A method "GetMagnitude" to return the magnitude of the complex number(square root of a2+b2)
    /// A method "Add", to sum two complex numbers(the real part will be the sum of both real parts, 
    /// and the imaginary part will be the sum of both imaginary parts)
    /// Create a test program, to try these capabilities.
    /// </summary>
    internal class ComplexTest
    {
        static void Main(string[] args)
        {
            bool debug = false;

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

            if (debug)
                Console.ReadLine();
        }
    }
}
