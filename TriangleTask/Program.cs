using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3, 4, 5);
            t1.Print(); 
            Console.WriteLine($"Perimeter is {t1.Perimeter}");
            Console.WriteLine($"Area is {t1.GetArea()}");
            Console.WriteLine();

            try
            {
                t1.SideA = -3;
                t1.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();


            try
            {
                t1.SideA = 20;
                t1.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();


            try
            {
                Triangle t2 = new Triangle(18, 1, 1);
                t2.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();


            try
            {
                Triangle t3 = new Triangle(4, -1, 5);
                t3.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}
