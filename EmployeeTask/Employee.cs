using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    public class Employee : User
    {
        private int workExperience;
        private string post;

        public int WorkExperience
        {
            get { return workExperience; }
            set
            {
                if (value < 0 || value > Age - minAgeForWork)
                    throw new ArgumentException("Invalid work experience");
                workExperience = value;
            }
        }

        public string Post
        {
            get { return post; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid post");
                post = value;
            }
        }

        public Employee()
            : base() { }

        public Employee(string surname, string name, DateTime birthDate, int workExperience, string post)
            : base(surname, name, birthDate)
        {
            WorkExperience = workExperience;
            Post = post;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Work experience (years): {workExperience}");
            Console.WriteLine($"Post: {Post}");
        }

        private const int minAgeForWork = 14;
    }
}
