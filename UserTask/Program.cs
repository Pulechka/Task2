using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Vasilenko", "Anna", new DateTime(1994, 04, 11));
            user1.Show();
            Console.WriteLine();

            User user2 = new User();
            user2.Surname = "Haisanov";
            user2.Name = "Salovat";
            user2.BirthDate = new DateTime(1981, 02, 14);
            user2.Show();
            Console.WriteLine();

            try
            {
                User user3 = new User("", "Sasha", new DateTime(1997, 09, 18));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                User user3 = new User("Vasilenko", "", new DateTime(1997, 09, 18));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            try
            {
                User user3 = new User("Vasilenko", "Sasha", new DateTime(1850, 09, 18));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}
