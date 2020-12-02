using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what the product name ?");
            string productName = Console.ReadLine();
            Console.WriteLine("what your product price whitout VAT ");
            string price = Console.ReadLine();
            int priceHt = Int32.Parse(price);
            double ttc = 1.19;
            double priceTtc = priceHt * ttc;
            Console.WriteLine("Your product name is " + productName + " " + "and your price with VAT is " + priceTtc);
        }
    }
}
