using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            int line = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Math();
            var result = operatorObject.GetAdd(line);

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Enter input:");
            decimal line1 = Convert.ToDecimal(Console.ReadLine());

            operatorObject = new Math();
            result = (double)operatorObject.GetMultiply(line1);

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Enter input:");
            int line2 = Convert.ToInt32(Console.ReadLine());

            operatorObject = new Math();
            result = (double)operatorObject.GetMultiply(line2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
