using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10Homework
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        public int age;
        public string date;

        public User(string date)
        {
            this.date = date;
        }
        public void Print()
        {
            Console.WriteLine($"Date:{date}");
        }

    }
}
