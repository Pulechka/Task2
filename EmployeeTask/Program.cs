using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Surname = "Vasilenko";
            employee1.Name = "Anna";
            employee1.BirthDate = new DateTime(1994, 4, 11);
            employee1.WorkExperience = 1;
            employee1.Post = "Junior C# developer";
            employee1.Show();
            Console.WriteLine();

            Employee employee2 = new Employee("Chigireva", "Irina", new DateTime(1997, 1, 8), 0, "Manager");
            employee2.Show();
            Console.WriteLine();

            try
            {
                Employee employee3 = new Employee("Cvetkov", "Anatoliy", new DateTime(1992, 8, 19), 11, "Director");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
