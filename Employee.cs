using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Employee
    {
        int id;
        string name;
        int salary;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set{ name = value; }
            get { return name; }
        }   
        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        static void Main(string[]ags)

        {
            Employee E1 = new Employee();
            E1.Id = 101;
            E1.name = "Kumar jadhav";
            E1.salary = 51000;
            Console.WriteLine("Id :" + E1.Id);
            Console.WriteLine("Name :" + E1.name);
            Console.WriteLine("Salary :" + E1.salary);
        }


    }
}
