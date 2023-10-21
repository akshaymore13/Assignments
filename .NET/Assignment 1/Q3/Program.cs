using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    class student
    {
        public void add ()
        {
            Console.WriteLine("Dac student is added");
        }
        
    }
}

namespace DBDA
{
    class student
    {
        public void add()
        {
            Console.WriteLine("DBDA student is added");
            
        }
    }
}
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAC.student w1 = new DAC.student();
            w1.add();
            DBDA.student w2 = new DBDA.student();   
            w2.add();   
        }
    }
}
