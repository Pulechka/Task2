using System;

namespace RingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point(0, 0);

            Ring r1 = new Ring(center, 4, 7);
            r1.Print();
            Console.WriteLine($"Area is {r1.Area:.##}");
            Console.WriteLine($"Circumference is {r1.Circumference:.##}");
            Console.WriteLine();

            try
            {
                Ring r2 = new Ring(new Point(0, 0), 5, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}
