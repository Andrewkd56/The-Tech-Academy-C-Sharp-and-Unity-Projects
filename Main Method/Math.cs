using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Math
    {
        public double GetAdd(int data)
        {
            data = data + 4;
            return data;
        }

        public decimal GetMultiply(decimal data)
        {
            data = data * 4;
            return data;
        }

        public double GetSubtract (int data)
        {
            data = data - 4;
            return data;
        }
    }
}
