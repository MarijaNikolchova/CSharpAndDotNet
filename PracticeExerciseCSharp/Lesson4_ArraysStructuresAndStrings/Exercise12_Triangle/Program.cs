using System;

namespace Exercise12_Triangle
{
    /// <summary>
    /// Write a C# program to ask the user for his/her name and display a triangle with it, 
    /// starting with 1 letter and growing until it has the full length:
    /// 
    /// Enter your name: Juan
    /// J
    /// Ju
    /// Jua
    /// Juan
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, ancho, alto;
            int row, column;

            Console.Write("Introduce un número: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la anchura: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            alto = ancho;

            for (row = 0; row < alto; row++)
            {
                for (column = 0; column < ancho; column++)
                    Console.Write(n);

                Console.WriteLine();

                ancho--;
            }
        }
    }
}
