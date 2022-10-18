using System;

namespace Exercise10_ArrayOfStructAndMenu
{
    /// <summary>
    /// Expand the previous exercise (array of points), so that it displays a menu, 
    /// in which the user can choose to:
    /// 
    /// - Add data for one point
    /// - Display all the entered points
    /// - Calculate(and display) the average values for x and y
    /// - Exit the program
    /// </summary>
    internal class Program
    {
        struct points
        {
            public byte x;
            public byte y;
        }
        static void Main(string[] args)
        {
            points[] p = new points[1000];
            bool Finish = false;
            int countArray = 0;
            int TotalX = 0;
            int TotalY = 0;
            do
            {
                Console.WriteLine("1.Add data for one point");
                Console.WriteLine("2.Display all the entered points");
                Console.WriteLine("3.Calculate (and display) the average values for x and y");
                Console.WriteLine("0.Exit the program");
                Console.Write("Enter a number: ");
                byte respuesta = Convert.ToByte(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter a number for point x: ");
                        p[countArray].x = Convert.ToByte(Console.ReadLine());
                        TotalX += p[countArray].x;
                        Console.WriteLine();
                        Console.Write("Enter a number for point y: ");
                        p[countArray].y = Convert.ToByte(Console.ReadLine());
                        TotalY += p[countArray].y;
                        Console.WriteLine();
                        countArray++;
                        break;
                    case 2:
                        if (countArray > 0)
                        {
                            for (int i = 0; i < countArray; i++)
                            {
                                Console.WriteLine("Valor x{0}: {1}", i + 1, p[i].x);
                                Console.WriteLine("Valor y{0}: {1}", i + 1, p[i].y);
                            }
                        }
                        else
                            Console.WriteLine("No hay datos");
                        break;
                    case 3:
                        if (countArray > 0)
                        {
                            Console.WriteLine("Average x: {0}", TotalX / countArray);
                            Console.WriteLine("Average y: {0}", TotalY / countArray);
                        }
                        else
                            Console.WriteLine("No hay datos");
                        break;
                    case 0:
                        Finish = true;
                        break;
                    default:
                        break;
                }
            }
            while (!Finish);
        }
    }
}
