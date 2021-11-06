using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        
        public string fName { get; set; }
        public string lName { get; set; }

        public void SayName()
        {
            Console.WriteLine(fName + lName);
            Console.ReadLine();
        }

        
    }
}
