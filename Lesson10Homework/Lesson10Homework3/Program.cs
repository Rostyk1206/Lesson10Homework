using System;

namespace Lesson10Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter convert1 = new Converter(27.5, 29.5, 6.5);

            convert1.ConvertGrivna(1000.0);
            convert1.DollarGrivna(100.0);
            convert1.EuroGrivna(100.0);
            convert1.ZlotyjGrivna(100.0);

        }
    }
}
