using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the weight of your package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Sorry, your package is to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What is your package width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth + packageLength + packageHeight > 50)
            {
                Console.WriteLine("Package to big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            int shippingQuote = (packageHeight * packageLength * packageWidth * packageWeight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote);
            Console.ReadLine();
        }
    }
}
