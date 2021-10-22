using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousincomeprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourlyRate1 = 17;
            int hourlyRate2 = 22;

            int annualSalary1 = hourlyRate1 * 45 * 52;
            int annualSalary2 = hourlyRate2 * 40 * 52;
            bool isMore = annualSalary1 > annualSalary2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("hourly rate?");
            Console.WriteLine(hourlyRate1);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(45);

            Console.WriteLine("Person 2");
            Console.WriteLine("hourly rate?");
            Console.WriteLine(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(40);

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(isMore);
            Console.ReadLine();

        }
    }
}
