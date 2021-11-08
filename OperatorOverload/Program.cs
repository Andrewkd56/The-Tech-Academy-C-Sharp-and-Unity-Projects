using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Kitty";
            example.LastName = "Katz";
            example.ID = 24923;

            Employee example2 = new Employee();
            example2.FirstName = "John";
            example2.LastName = "Dudinsky";
            example2.ID = 39292;

            Console.ReadLine();
        }
    }
}
