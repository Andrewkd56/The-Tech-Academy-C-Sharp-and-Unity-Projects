using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int ID { get; set; }
        public Employee(string firstName, string lastName, int IDs)
        {
            firstname = firstName;
            lastname = lastName;
            ID = IDs;
        }

        
    }
}
