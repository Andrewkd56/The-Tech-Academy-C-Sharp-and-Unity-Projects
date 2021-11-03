using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            int int1 = 33;
            Math.computeSum(int1, 22);
            Console.ReadLine();

        }
    }
}
