using System;
using System.Collections.Generic;
using System.Text;

namespace ListStudents
{
    class Student
    {
        private string name;
        private string grade;
        public Student next;
        public Student(string n, string g)
        {
            name = n;
            grade = g;
        }
    }
}
