using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        int add (int x, int y) 
        {
            return x + y; 
        }

        int product (int x, int y)
        {
             return x * y;   
        }
        static void Main(string[] args)
        { 
            Calculator c = new Calculator();
            int sum = c.add(10, 3);
            Console.WriteLine(sum);
            int pro = c.product(20, 10);
                Console.WriteLine(pro);
        }
    }
}
