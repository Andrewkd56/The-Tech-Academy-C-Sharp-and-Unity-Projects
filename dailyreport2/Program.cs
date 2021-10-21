using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyreport2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int Pagenumber = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? please answer true or false");
            string Help = Console.ReadLine();
            bool help = Convert.ToBoolean(Help);
            Console.WriteLine(Help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int Studyhours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day");
            Console.ReadLine();

        }
    }
}
