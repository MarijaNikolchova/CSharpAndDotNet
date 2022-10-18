using System;

namespace Exercise09_ArrayOfStruct
{
    /// <summary>
    /// Expand the previous exercise (struct point), so that up to 1.000 points can be stored, 
    /// using an "array of struct". Ask the user for data for the first two points and then display them.
    /// </summary>
    internal class Program
    {
        struct point
        {
            public short x;
            public short y;
            public byte r;
            public byte g;
            public byte b;
        }
        static void Main(string[] args)
        {
            point[] p = new point[1000];

            Console.Write("Enter X for first point: ");
            p[0].x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Y for first point: ");
            p[0].y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Red for first point: ");
            p[0].r = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Green for first point: ");
            p[0].g = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Blue for first point: ");
            p[0].b = Convert.ToByte(Console.ReadLine());


            Console.Write("Enter X for second point: ");
            p[1].x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Y for second point: ");
            p[1].y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Red for second point: ");
            p[1].r = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Green for second point: ");
            p[1].g = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Blue for second point: ");
            p[1].b = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(
                "P1 is located in ({0},{1}), colour ({2},{3},{4})",
                p[0].x, p[0].y, p[0].r, p[0].g, p[0].b);

            Console.WriteLine(
                "P2 is located in ({0},{1}), colour ({2},{3},{4})",
                p[1].x, p[1].y, p[1].r, p[1].g, p[1].b);
        }
    }
}
