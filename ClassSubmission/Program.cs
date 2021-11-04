using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Class1 class1 = new Class1();
            
            Console.WriteLine("type in a number");
            int int1 = Convert.ToInt32(Console.ReadLine());

            Class1.Division(int1);

            decimal myValue1 = 33.3m;
            Class1.Division(myValue1);

            


            int i;


            Class1.Addition(out i);

            
            Console.WriteLine("The addition of the value is: {0}", i);
            Console.ReadLine();
        }
    }
}
