using System;

namespace Methods
{
    class student
    {
        string name;
        int percentage;
        string qualification;
        int year;


        public void Setname(string a)
        {
            name = a;
        }
        public string Getname()
        {
            return name;
        }
        public void Setpercentage(int b)
        {
            percentage = b;
        }
        public int Getpercentage()
        {
            return percentage;
        }
        public void setqualification(string c)
        {
            qualification = c;
        }
        public string Getqualification()
        {
            return qualification;
        }
        public void setyear(int year)
        {
            year = 2022;
        }
        public int Getyear()
        {
            return year;
        }

        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "kumar";
            s1.percentage = 89;
            s1.qualification = "BE";
            s1.year = 2019;
            string nm = s1.Getname();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.percentage);
            Console.WriteLine(s1.qualification);
            Console.WriteLine(s1.year);
            Console.WriteLine(s1.Getname());


        }

    } 
}
    




