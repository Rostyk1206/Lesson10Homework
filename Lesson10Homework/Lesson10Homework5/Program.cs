using System;

namespace Lesson10Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(1,"Ivan","King Cross","Hermes",1);
            Invoice invoice2 = new Invoice(1, "Rostyk", "King Cross", "FC", 1);

            invoice1.Print();
            invoice1.WithTax("T-Shirt");
            invoice1.WithoutTax("T-Shirt");

            invoice2.Print();
            invoice2.WithTax("Coat");
            invoice2.WithoutTax("Coat");
        }
    }
}
