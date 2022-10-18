using System;

namespace Exercise22_TwoDimensionalArrayCircunfOnScreen
{
    /// <summary>
    /// Create a C# program that declares creates a 70x20 two-dimensional array of characters, 
    /// "draws" a circumference or radius 8 inside it, and displays it on screen.
    /// 
    /// Hint: the points in the circumference can be obtained using:
    /// x = xCenter + r* cos angle
    /// y = yCenter + r * sin angle
    /// 
    /// "sin" and "cos" expect the angle to be measured in radians, instead of degrees.
    /// To convert from one unit to the other, you must remember 
    /// that 360 degrees = 2 PI radians(or 180 degrees = PI radians): float radians = (angle * Math.PI / 180.0);
    /// 
    /// You might draw 72 points(as there are 360 degrees in a circumference, 
    /// they would be spaced 5 degreees from each other)
    /// 
    /// Hint: in C#, cosine is Math.Cos, sine is Math.Sin and PI is Math.PI
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad, x, y;

            for (int i = 0; i < 360; i += 5)
            {
                rad = i * Math.PI / 180.0;
                x = 35 + 8 * Math.Cos(rad);
                y = 10 + 8 * Math.Sin(rad);

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write("X");
            }

            Console.SetCursorPosition(1, 20);
        }
    }
}
