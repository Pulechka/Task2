using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Line(new Point(0, 0), new Point(2, 2)));
            figures.Add(new Circle(3, new Point(0, 2)));
            figures.Add(new Rectangle(5, 6, new Point(1,1)));
            figures.Add(new Round(3, -10,-10));
            figures.Add(new Ring(4,5,new Point(5,5)));

            foreach (var figure in figures)
            {
                figure.Print();
            }
        }
    }
}
