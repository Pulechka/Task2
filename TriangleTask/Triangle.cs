using System;

namespace TriangleTask
{
    public class Triangle
    {
        private double sideA, sideB, sideC;

        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side should be bigger 0");
                if (!IsPossibleTriangle(value, sideB, sideC))
                    throw new ArgumentException("Side can'be bigger than sum of two others sides");
                sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side should be bigger 0");
                if (!IsPossibleTriangle(sideA, value, sideC))
                    throw new ArgumentException("Side can'be bigger than sum of two others sides");
                sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side should be bigger 0");
                if (!IsPossibleTriangle(sideA, sideB, value))
                    throw new ArgumentException("Side can'be bigger than sum of two others sides");
                sideC = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (!IsPossibleTriangle(a, b, c))
                throw new ArgumentException("Can't create triangle with these sides");
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public static bool IsPossibleTriangle(double a, double b, double c)
        {
            return (a < b + c) && (b < a + c) && (c < a + b);
        }

        public double Perimeter => sideA + sideB + sideC;

        public double GetArea()
        {
            double p = Perimeter / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle has sides: {sideA}, {sideB}, {sideC}");
        }
    }
}
