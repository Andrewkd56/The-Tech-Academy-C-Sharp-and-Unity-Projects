using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Class1
    {
        private static string msg = "Hello world";

        public static class nestedStaticClass
        {
            public static void printMessage()
            {
                Console.WriteLine(msg);
            }

        }

        public static void Division(int int1)
        {
            int quotient = int1 / 2;

            Console.WriteLine(int1 + " divided by " + 2 + " equals " + quotient);
        }
        public static void Division(decimal int1)
        {
            int quotient1 = Convert.ToInt32(int1) / 3;

            Console.WriteLine(quotient1);

        }

        public static void Addition(out int i)
        {
            i = 30;
            i += i;
        }

    }
}

    
