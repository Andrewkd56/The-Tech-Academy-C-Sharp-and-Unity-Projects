using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            int line = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Operator();
            var result = operatorObject.GetAdd(line);

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Enter input:");
            line = Convert.ToInt32(Console.ReadLine());

            operatorObject = new Operator();
            result = operatorObject.GetSubtract(line);

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Enter input:");
            line = Convert.ToInt32(Console.ReadLine());

            operatorObject = new Operator();
            result = operatorObject.GetDivide(line);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
