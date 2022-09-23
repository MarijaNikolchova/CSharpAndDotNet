using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClassDiagram
{
    public class Circle : Shape
    {
        protected double radius;
        private double pi = 3.14;

        public Circle(double x, double y) : base(x, y)
        {
        }

        public void SetRadius(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return pi * Math.Pow(radius,2);
        }

        public override double Perimeter()
        {
           return 2 * pi * radius;
        }
    }
}
