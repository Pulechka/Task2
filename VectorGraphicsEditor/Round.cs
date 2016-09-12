using System;

namespace VectorGraphicsEditor
{
    public class Round : Figure
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

        public Round() {}

        public Round(double radius)
        {
            Radius = radius;
            Center = new Point(0, 0);
        }

        public Round(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public Round(double radius, int x, int y)
        {
            Radius = radius;
            Center = new Point(x, y);
        }

        public double Circumference => 2 * Math.PI * radius;

        public double Area => Math.PI * radius * radius;

        public override void Print()
        {
            Console.WriteLine("Figure ROUND");
            Console.WriteLine("Center: " + Center);
            Console.WriteLine("Radius: {0:.##}", radius);
            Console.WriteLine("Circumference: {0:.##}", Circumference);
            Console.WriteLine("Area: {0:.##}", Area);
            Console.WriteLine();
        }
    }
}
