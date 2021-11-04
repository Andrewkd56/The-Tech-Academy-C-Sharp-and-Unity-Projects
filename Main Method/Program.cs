using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Program
    {
       
       public static void Main(string[] args)
        {
            Math math = new Math();
            
            int myValue = 12;
            int myResult = math.DoMath(myValue);
            
            Console.WriteLine(myResult);

            decimal myValue2 = 33.3m;
            int myResult1 = math.DoMath(myValue2);
            Console.WriteLine(myResult1);

            string myValue3 = "3";
            
            int myResult2 = math.DoMath(myValue3);
            Console.WriteLine(myResult2);

            
            Console.ReadLine();
        }
    }
}
