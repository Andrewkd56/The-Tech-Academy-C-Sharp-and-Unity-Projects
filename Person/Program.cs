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
            Employee employee2 = new Employee();
            
            employee.fName = "Sample";
            employee.lName = "Student";
            employee2.id = 2;
            employee.id = 1;
            employee.SayName();
            employee1.Quit(employee);

            _ = employee.id == employee2.id;
            

            Console.ReadLine();

        }
    }
}
