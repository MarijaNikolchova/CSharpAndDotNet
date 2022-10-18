using System;

namespace Exercise13_CatalogMenu
{
    /// <summary>
    /// Improve the Catalog program, so that "Main" displays a menu to allow 
    /// entering new data of any kind, as well as displaying all the data stored.
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
