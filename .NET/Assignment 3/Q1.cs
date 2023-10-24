using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Student
    {
        string name;
        int math;
        int science;
        int english;
        public Student(string name, int math, int science, int english)
        {
            this.name = name;
            this.math = math;
            this.science = science;
            this.english = english;
        }
        private int get_marks()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Math:{math}\nScience:{science}\nEnglish:{english}");
            return math + science + english;

        }
        public void display()
        {
            Console.WriteLine($"Total marks:{get_marks()}");

        }

        static void Main(string[] args)
        {

            Student s1 = new Student("Akshay", 88,98,78);
            Student s2 = new Student("Kunal", 89,78,67);

            s1.display();
            s2.display();
        }
    }
}
