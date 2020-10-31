using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private  float cgpa;

        public Student(string Name,string Id,string Department,float Cgpa)
        {
            this.name = Name;
            this.id =Id;
            this.department = Department;
            this.cgpa = Cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("your name is : " + name);
            Console.WriteLine("your id is : " + id);
            Console.WriteLine("your department is : " + department);
            Console.WriteLine("your  cgpa is : " + cgpa);
        }
    }
}
