using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10Homework4
{
    class Employee
    {
        public string name;
        public string surname;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void SalaryEmployee(int experience, string job)
        {
            if(job=="Director" && experience<5)
            {
                double salary = 25000;
                double tax=salary*0.20;
                double salary1 = salary - tax;
                Console.WriteLine($"Experience of {job} is:{experience} year.Salary is:{salary1} and tax is:{tax};");
            }
            else if (job == "Director" && experience >= 5)
            {
                double salary = 40000;
                double tax = salary * 0.20;
                double salary1 = salary - tax;
                Console.WriteLine($"Experience of {job} is:{experience} year.Salary is:{salary1} and tax is:{tax};");
            }
            else if (job == "Babysitter" && experience < 5)
            {
                double salary = 4000;
                double tax = salary * 0.20;
                double salary1 = salary - tax;
                Console.WriteLine($"Experience of {job} is:{experience} year.Salary is:{salary1} and tax is:{tax};");
            }
            else if (job == "Babysitter" && experience >= 5)
            {
                double salary = 10000;
                double tax = salary * 0.20;
                double salary1 = salary - tax;
                Console.WriteLine($"Experience of {job} is:{experience} year.Salary is:{salary1} and tax is:{tax};");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Name:{name} Surname:{surname}");
        }
    }
}
