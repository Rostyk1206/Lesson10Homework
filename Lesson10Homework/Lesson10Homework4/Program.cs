using System;

namespace Lesson10Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Volodymyr", "Ptyshkin");
            Employee employee2 = new Employee("Maria", "Ptyshkin");

            employee1.Print();
            employee1.SalaryEmployee(10, "Director");

            employee2.Print();
            employee2.SalaryEmployee(3, "Babysitter");

        }
    }
}
