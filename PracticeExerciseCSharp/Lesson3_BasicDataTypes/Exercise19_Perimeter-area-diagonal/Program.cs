using System;

namespace Exercise19_Perimeter_area_diagonal
{
    internal class Program
    {
        /// <summary>
        /// Create a program to calculate the perimeter, area and diagonal of a rectangle from its 
        /// width and height (perimeter = sum of the four sides, area = base x height, diagonal using 
        /// the Pythagorean theorem). It must repeat until the user enters 0 for the width.
        /// </summary>
        static void Main(string[] args)
        {
            double width;
            double height;
            double perimeter, area, diagonal;

            do
            {
                Console.Write("Enter the desired width: ");
                width = Convert.ToDouble(Console.ReadLine());

                if (width != 0)
                {

                    Console.Write("Enter the desired height: ");
                    height = Convert.ToDouble(Console.ReadLine());

                    perimeter = width * 2 + height * 2;
                    Console.WriteLine("Perimeter: {0}", perimeter);

                    area = width * height;
                    Console.WriteLine("Area: {0} ", area);

                    diagonal = Math.Sqrt((width * width) + (height * height));
                    Console.WriteLine("Diagonal: {0} ", diagonal);
                }
            }
            while (width != 0);
        }
    }
}
