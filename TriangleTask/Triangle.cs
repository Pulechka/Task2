using System;

namespace TriangleTask
{
    public class Triangle
    {
        private double a, b, c;

        public double SideA
        {
            get
            {
                return a;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side should be bigger 0");
                if (!IsPossibleTriangle(value, b, c))
                    throw new ArgumentException("Side can'be bigger than sum of two others sides");
                a = value;
            }
        }

        public double SideB
        {
            get
            {
                return b;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side should be bigger 0");
                if (!IsPossibleTriangle(a, value, c))
                    throw new ArgumentException("Side can'be bigger than sum of two others sides");
                b = value;
            }
        }

        public double SideC
        {
            get
            {
                return c;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side should be bigger 0");
                if (!IsPossibleTriangle(a, b, value))
                    throw new ArgumentException("Side can'be bigger than sum of two others sides");
                c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (!IsPossibleTriangle(a, b, c))
                throw new ArgumentException("Can't create triangle with these sides");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static bool IsPossibleTriangle(double a, double b, double c)
        {
            return (a < b + c) && (b < a + c) && (c < a + b);
        }

        public double Perimeter => a + b + c;

        public double GetArea()
        {
            double p = Perimeter / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle has sides: {a}, {b}, {c}");
        }
    }
}
