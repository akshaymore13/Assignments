using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class tax
    {
  
            static void Main(string[] args)
            {
                Employee s1 = new Employee("Omkar", 89000, Dept.ADMIN);
                s1.display();
                Employee s2 = new Employee("Om", 99000, Dept.MKT);
                s2.display();
                Employee s3 = new Employee("action", 75000, Dept.ADV);
                s3.display();
            }
        }
    }
