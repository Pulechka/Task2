using System;

namespace VectorGraphicsEditor
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Point LowerLeftPoint { get; set; }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Width should be positive");
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height of rectangle should be positive");
                height = value;
            }
        }

        public Rectangle(double width, double height, Point lowerLeftPoint)
        {
            Width = width;
            Height = height;
            LowerLeftPoint = lowerLeftPoint;
        }

        public override void Print()
        {
            Console.WriteLine("Figure RECTANGLE");
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Height: "+ height);
            Console.WriteLine("Lower left point: "+ LowerLeftPoint);
            Console.WriteLine("Perimeter: "+ Perimeter);
            Console.WriteLine("Area: {0:.##}", Area);
            Console.WriteLine();
        }

        public double Perimeter => 2 * width + 2 * height;

        public double Area => width * height;
    }
}
