using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public List<Employee> Employees { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }

        public void SayName()
        {
            Console.WriteLine(fName + lName);
            Console.ReadLine();
        }

        
    }
}
