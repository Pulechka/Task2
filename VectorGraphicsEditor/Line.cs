using System;

namespace VectorGraphicsEditor
{
    public class Line : IDrawable
    {
        private Point startPoint;
        private Point endPont;

        public Point StartPoint
        {
            get { return startPoint; }
            set
            {
                if (value == endPont)
                    throw new ArgumentException("Start and end of the line can't be in the same point");
                startPoint = value;
            }
        }

        public Point EndPoint
        {
            get { return endPont; }
            set
            {
                if (value == startPoint)
                    throw new ArgumentException("Start and end of the line can't be in the same point");
                endPont = value;
            }
        }

        public double Length => Math.Sqrt((endPont.X - startPoint.X) * (endPont.X - startPoint.X) + (endPont.Y - startPoint.Y) * (endPont.Y - startPoint.Y));

        public Line(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            EndPoint = endPoint;
        }

        public void Draw()
        {
            Console.WriteLine("Figure LINE");
            Console.WriteLine("Start point: " + startPoint);
            Console.WriteLine("End pont: "+endPont);
            Console.WriteLine("Length: {0:.##}",Length);
            Console.WriteLine();
        }
    }
}
