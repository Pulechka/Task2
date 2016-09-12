using System;

namespace VectorGraphicsEditor
{
    public class Ring : Figure
    {
        private Round innerRound;
        private Round outerRound;

        public double InnerRadius
        {
            get { return innerRound.Radius; }
            set
            {
                if (value > OuterRadius)
                    throw new Exception("Inner radius should be less then outer radius");
                innerRound.Radius = value;
            }
        }
        
        public double OuterRadius
        {
            get { return outerRound.Radius; }
            set
            {
                if (value < InnerRadius)
                    throw new Exception("Outer radius radius should be bigger then inner radius");
                outerRound.Radius = value;
            }
        }

        public Point Center
        {
            get { return innerRound.Center; }
            set
            {
                innerRound.Center = value;
                outerRound.Center = value;
            }
        }

        public Ring(double innerRadius, double outerRadius, Point center)
        {
            if (innerRadius >= outerRadius)
                throw new ArgumentException("Inner radius should be less then outer radius");
            innerRound = new Round(innerRadius, center);
            outerRound = new Round(outerRadius, center);
        }

        public double Area => outerRound.Area - innerRound.Area;

        public double Circumference => innerRound.Circumference + outerRound.Circumference;

        public override void Print()
        {
            Console.WriteLine("Figure RING");
            Console.WriteLine("Center: " + Center);
            Console.WriteLine("Inner radius: {0:.##}", InnerRadius);
            Console.WriteLine("Outer radius: {0:.##}", OuterRadius);
            Console.WriteLine("Circumference: {0:.##}", Circumference);
            Console.WriteLine("Area: {0:.##}", Area);
            Console.WriteLine();
        }
    }
}
