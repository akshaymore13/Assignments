using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 s1 = new Class1();

            int fact = s1.fact(4);
            Console.WriteLine(fact);
        }
    }
}
