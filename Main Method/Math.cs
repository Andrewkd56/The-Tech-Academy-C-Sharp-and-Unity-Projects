using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Math
    {
        public int DoMath(int data)
        {
            data = data + 4;
            return data;
        }

        public int DoMath(decimal data)
        {
           data = Convert.ToInt32(data);
            data = data * 4;
            
            return (int)data;
        }

        public int DoMath (string data)
        {
            //Convert.ToInt32(data);
            int.Parse(data);

            data = data + 4;
            return data;
            
        }
    }
}
