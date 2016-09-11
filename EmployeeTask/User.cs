using System;

namespace EmployeeTask
{
    public class User
    {
        private string surname;
        private string name;
        private DateTime birthDate;

        public string Surname
        {
            get { return surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname can't be empty or whitespace");
                surname = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name can't be empty or whitespace");
                name = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now || value.Year < DateTime.Now.Year - 150)
                    throw new ArgumentException("Invalid birth date");
                birthDate = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Month < birthDate.Month ||
                    (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
                    age--;
                return age;
            }
            private set { }
        }

        public User() { }

        public User(string surname, string name, DateTime birhtDate)
        {
            Surname = surname;
            Name = name;
            BirthDate = birhtDate;
        }

        public virtual void Show()
        {
            Console.WriteLine($"{surname} {name}");
            Console.WriteLine($"Birth date: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Age is {Age}");
        }
    }
}
