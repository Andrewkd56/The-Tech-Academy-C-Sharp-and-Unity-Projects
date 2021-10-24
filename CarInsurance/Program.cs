using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? please write true or false");
            string dui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(tickets);

            Console.WriteLine(Age > 15 && Tickets <= 3 && !DUI);

            //bool qualified = DUI = false && Tickets < 3 && Age > 15;
            //Console.WriteLine(qualified);
            Console.ReadLine();



        }
    }
}
