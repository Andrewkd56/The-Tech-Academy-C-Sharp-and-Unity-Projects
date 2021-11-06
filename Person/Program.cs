using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee1 = new Employee();
            Employee employee = new Employee();
            employee.fName = "Sample";
            employee.lName = "Student";
            employee.SayName();
            employee1.Quit(employee);

            
            

            Console.ReadLine();

        }
    }
}
