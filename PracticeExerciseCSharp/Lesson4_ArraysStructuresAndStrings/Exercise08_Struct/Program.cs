using System;

namespace Exercise08_Struct
{
    /// <summary>
    /// Create a "struct" to store data of 2D points. The fields for each point will be:
    /// 
    /// x coordinate(short)
    /// y coordinate(short)
    /// r(red colour, byte)
    /// g(green colour, byte)
    /// b(blue colour, byte)
    /// 
    /// Write a program which creates two "points", asks the user for their data, and then displays their content.
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
            point p1, p2;

            Console.Write("Enter X for first point: ");
            p1.x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Y for first point: ");
            p1.y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Red for first point: ");
            p1.r = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Green for first point: ");
            p1.g = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Blue for first point: ");
            p1.b = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter X for second point: ");
            p2.x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Y for second point: ");
            p2.y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Red for second point: ");
            p2.r = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Green for second point: ");
            p2.g = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Blue for second point: ");
            p2.b = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(
                "P1 is located in ({0},{1}), colour ({2},{3},{4})",
                p1.x, p1.y, p1.r, p1.g, p1.b);

            Console.WriteLine(
                "P2 is located in ({0},{1}), colour ({2},{3},{4})",
                p2.x, p2.y, p2.r, p2.g, p2.b);
        }
    }
}
