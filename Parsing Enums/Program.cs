using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 Console.WriteLine("Write the current day of the week");
                string dayofweek = Console.ReadLine();
                Day day = (Day)Enum.Parse(typeof(Day), dayofweek);
                Console.WriteLine("Today is " + day);
                Console.ReadLine();

            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
           
        }
    }
    public enum Day
        {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
