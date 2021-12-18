using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currenttime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please enter a number");
            int hour = Convert.ToInt32(Console.ReadLine());
            
            TimeSpan hours = new TimeSpan(0,hour,0,0,0);
            Console.Write("The time later will be : " + now.Add(hours));
            now.Add(hours);
            Console.ReadLine();

        }
    }
}
