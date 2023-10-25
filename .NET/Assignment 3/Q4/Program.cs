using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    enum Dept
    {
        MKT,ADMIN,ADV
    }
    internal class Employee
    {
        int id;
        static int getid;
        string name;
        double salary;
        double netsalary;
        Dept dept;

        static float ROI =0.8f;

        public Employee( String name,double salary, Dept dept) 
        { 
            id = ++getid;
            this.salary = salary;
            this.name=name; 
            this.dept = dept;

        }

        public double paytax (double p)
        {
            netsalary = salary - salary * ROI;
            return netsalary;
        }
        public void display() 
        {
            paytax(salary);
            Console.WriteLine(name + " " + salary + dept);
        }



    }
}
