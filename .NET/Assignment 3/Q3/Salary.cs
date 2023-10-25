using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    public class Salary1
    {
    static void Main ()
    {
             
    Employee s1 = new Employee("Akshay", 45340);
    s1.display();
      Employee s2 = new Employee(" Sahil", 12000);
    s2.display();
       Employee s3 = new Employee("Prathamesh", 75000);
    s3.display();

     }
    }
 }
