using System;

namespace Exercise05_Square
{
    internal class Location
    {
        private double x, y, side;

        internal void SetX(double x)
        {
            this.x = x;
        }

        internal void SetY(double y)
        {
            this.y = y;
        }

        internal void SetSide(double side)
        {
            this.side = side;
        }

        internal double GetSide()
        {
            return side;
        }

        internal double GetX()
        {
            return x;
        }

        internal double GetY()
        {
            return y;
        }
    }
}