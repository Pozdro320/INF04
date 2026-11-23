using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmEuklidesa
{
    internal class Euklides
    {
        public int ObliczNWD(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }
    }
}
