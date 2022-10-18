using System;

namespace Exercise07_Double
{
    internal class Program
    {
        /// <summary>
        /// Calculate the perimeter, area and diagonal of a rectangle, given its width and its height.
        /// 
        /// (Hint: use y = Math.Sqrt(x) to calculate a square root)
        /// </summary>
        static void Main(string[] args)
        {
            double a, b;
            double area, perimeter, diagonal;

            Console.Write("Enter the width: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            b = Convert.ToDouble(Console.ReadLine());

            perimeter = a * 2 + b * 2;
            Console.WriteLine("Perimeter: {0}", perimeter);

            area = a * b;
            Console.WriteLine("Area: {0}", area);

            diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Diagonal: {0}", diagonal);
        }
    }
}
