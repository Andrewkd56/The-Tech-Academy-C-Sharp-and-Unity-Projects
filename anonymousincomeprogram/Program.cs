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
            

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("hourly rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1: ");
            int annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2: ");
            int annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = annualSalary1 > annualSalary2;
            Console.WriteLine(isMore);
            Console.ReadLine();
            

        }
    }
}
