using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class FactorialOfNumber
    {
        public int getFactorialOfNumber(int num)
        {
            int factorial = 1;
            while (num > 0)
            {
                factorial *= num;
                num--;
            }

            return factorial;
        }
    }
}
