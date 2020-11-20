using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10Homework5
{
    class Invoice
    {
        public int account;
        public string customer;
        public string provider;
        private string article;
        private int quantity;
        
        public Invoice(int account,string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        public void WithTax(string clothing)
        {
            if (clothing == "T-Shirt")
            {
                int k = 3500;
                double tax = k * 0.2;
                double price_with_tax = k + tax;
                Console.WriteLine($"The price with tax of {clothing} is {price_with_tax}");
            }
            if (clothing == "Coat")
            {
                int k = 10000;
                double tax = k * 0.2;
                double price_with_tax = k + tax;
                Console.WriteLine($"The price with tax of {clothing} is {price_with_tax}");
            }
        }
        public void WithoutTax(string clothing)
        { 
            if (clothing == "T-Shirt")
            {
                int k = 3500;
                double tax = k * 0.2;
                double price_with_tax = k - tax;
                Console.WriteLine($"The price without tax of {clothing} is {price_with_tax}");
            }
            
            else if (clothing == "Coat")
            {
                int k = 10000;
                double tax = k * 0.2;
                double price_with_tax = k - tax;
                Console.WriteLine($"The price without tax of {clothing} is {price_with_tax}");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Account:{account},Customer:{customer}, Provider:{provider}, Article:{article}, Quantity:{quantity}");
        }
    }
}
