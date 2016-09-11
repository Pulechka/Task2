using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Round r1 = new Round { Radius = 1, Center = new Point(0, 0) }; //call default constructor
                r1.Print();
                Console.WriteLine("Round area is {0:.##}", r1.Area);
                Console.WriteLine("Сircumference is {0:.##}", r1.СircumferenceLength);
                Console.WriteLine();

                Round r2 = new Round(5);
                r2.Print();
                Console.WriteLine("Round area is {0:.##}", r2.Area);
                Console.WriteLine("Сircumference is {0:.##}", r2.СircumferenceLength);
                Console.WriteLine();

                Round r3 = new Round(3.8, new Point(-8, 9));
                r3.Print();
                Console.WriteLine("Round area is {0:.##}", r3.Area);
                Console.WriteLine("Сircumference is {0:.##}", r3.СircumferenceLength);
                Console.WriteLine();

                Round r4 = new Round(10, -2, 2);
                r4.Print();
                Console.WriteLine("Round area is {0:.##}", r4.Area);
                Console.WriteLine("Сircumference is {0:.##}", r4.СircumferenceLength);
                Console.WriteLine();

                r4.Radius = 3;
                r4.Center.X = 2;
                r4.Print();
                Console.WriteLine();

                Round r5 = new Round(-4);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
