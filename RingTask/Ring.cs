using System;

namespace RingTask
{
    public class Ring
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

        public Ring(Point center, double innerRadius, double outerRadius)
        {
            if (innerRadius >= outerRadius)
                throw new ArgumentException("Inner radius should be less then outer radius");
            innerRound = new Round(innerRadius, center);
            outerRound = new Round(outerRadius, center);
        }

        public double Area => outerRound.Area - innerRound.Area;

        public double Circumference => innerRound.Circumference + outerRound.Circumference;

        public void Print()
        {
            Console.WriteLine($"Inner radius is {InnerRadius}, outer radius is {OuterRadius}, center in {Center}");
        }
    }
}
