using System;

namespace VectorGraphicsEditor
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius should be positive");
                radius = value;
            }
        }

        public Point Center { get; set; }

        public Circle(double radius, Point center)
        {
            Center = center;
            Radius = radius;
        }

        public double Circumference => 2 * Math.PI * radius;

        public override void Print()
        {
            Console.WriteLine("Figure CIRCLE");
            Console.WriteLine("Center: " + Center);
            Console.WriteLine("Radius: {0:.##}", radius);
            Console.WriteLine("Circumference: {0:.##}", Circumference);
            Console.WriteLine();
        }
    }
}
