using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Student
    {
        string name;
        int age;
        int percent;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public int Percent
        {
            set { percent = value; }
            get { return percent; }
        }

        static void Main (string[]args)
        {
            Student S1 = new Student();
            S1.name = "Kumar patil";
            S1.age = 24;
            S1.percent = 90;
            Console.WriteLine("Name :" + S1.name);
            Console.WriteLine("Age :" + S1.age);
            Console.WriteLine("Percent :" + S1.percent);



        }
        

    }
}
