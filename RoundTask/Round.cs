using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTask
{
    public class Round
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

        public double СircumferenceLength => 2 * Math.PI * radius;

        public double Area => Math.PI * radius * radius;

        public void Print()
        {
            Console.WriteLine($"Radius is {Radius}, center in ({Center.X},{Center.Y})");
        }
    }
}
