using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Employee
    {
        private string name;
        private int id;
        static int getid;
        private double salary;
        private double netsalary;

        public Employee (string name, double salary)
        {
            this.name = name;
            this.salary = salary;
            id = ++getid;
        }
        public double caculatesal()
        {
            netsalary = salary - salary * 0.1;
            return netsalary;
        }
        public void display()
        {
            caculatesal();
            Console.WriteLine(name + " " + salary);

        }
      
    }
}
