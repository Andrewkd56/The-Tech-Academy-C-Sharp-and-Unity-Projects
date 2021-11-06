using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    
    public class Employee: Person, IQuittable
    {
        public int id { get; set; }

        
        

    public void Quit(Employee employee)
    {
            Console.WriteLine("I quit");
    }
    }
    
}
