using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini
{
    class Student
    {
           public int id;
           public char name;
        public DateTime dob;
        public void display()
        {
            Console.WriteLine("Name of the student is: " +name);
            Console.WriteLine("Register no of the Student: " + id);
            Console.WriteLine("Date of birth of student: " + dob);
        }

        public class enroll
        {
            private char student;
            private char course;
            private DateTime enrolldt;
        }
    }
}
