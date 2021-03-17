using System;
using System.Collections.Generic;
using System.Text;

namespace ListStudents
{
    class ListSt
    {

        private Student front;

        public ListSt()
        {
            front = null;
        }

        public void add(string name, string grade)
        {
            Student s = new Student(name, grade);


        }

        public void print()
        {

        }
    }
}
