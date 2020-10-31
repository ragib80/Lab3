using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Course
    {
         
         string courseName;
        string courseCode;
        int courseCradit;

        public Course(string CourseName,string CourseCode,int CourseCradit)
        {
            this.courseName = CourseName;
            this.courseCode = CourseCode;
            this.courseCradit = CourseCradit;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course name is : " + courseName);
            Console.WriteLine("your id is : " + courseCode);
            Console.WriteLine("your department is : " + courseCradit);
           
        }
    }
}

   