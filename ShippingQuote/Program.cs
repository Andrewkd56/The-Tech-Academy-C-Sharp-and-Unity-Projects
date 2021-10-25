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

            Console.WriteLine("Please enter the package weight: ");
            int Packageweight = Convert.ToInt32(Console.ReadLine());

            if (Packageweight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
           

            Console.WriteLine("Please enter the package width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth + packageLength + packageHeight >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            int Quote = packageHeight * packageLength * packageWidth * Packageweight / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + Quote);
            Console.WriteLine("Thank you!");
            Console.ReadLine();


        }
    }
}
