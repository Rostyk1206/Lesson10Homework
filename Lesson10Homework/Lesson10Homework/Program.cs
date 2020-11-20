using System;

namespace Lesson10Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("11.10.20");
            user.login = "Dog";
            user.name = "Roman";
            user.surname = "Fdjfj";
            user.age = 25;
            user.Print();
            Console.WriteLine($"Login:{user.login}, Name:{user.name}, SurName:{user.surname}, Age:{user.age}");
            
        }
    }
}
