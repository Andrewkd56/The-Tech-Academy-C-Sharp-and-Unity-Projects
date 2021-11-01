using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Operator
    {
        public double GetAdd(int data)
        {
            data = data + 4;
            return data;
        }

        public double GetSubtract(int data)
        {
            data = data - 4;
            return data;
        }

        public double GetDivide(int data)
        {
            data = data / 1;
            return data;
        }
    }
}
