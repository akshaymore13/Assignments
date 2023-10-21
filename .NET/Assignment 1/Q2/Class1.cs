using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public int fact(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
