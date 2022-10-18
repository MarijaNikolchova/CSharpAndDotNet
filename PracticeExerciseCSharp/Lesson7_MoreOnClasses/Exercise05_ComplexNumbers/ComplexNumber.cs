using System;

namespace Exercise05_ComplexNumbers
{
    internal class ComplexNumber
    {
        protected double a, b;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            a = realPart;
            b = imaginaryPart;
        }

        public double GetReal()
        {
            return a;
        }

        public void SetReal(double a)
        {
            this.a = a;
        }

        public double GetImaginary()
        {
            return b;
        }

        public void SetImaginary(double b)
        {
            this.b = b;
        }

        public new string ToString()
        {
            return "(" + a + "," + b + ")";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(ComplexNumber c2)
        {
            a += c2.GetReal();
            b += c2.GetImaginary();
        }
    }
}