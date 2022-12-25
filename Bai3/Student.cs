using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student : Human
    {
        private int grade;

        public Student()
        {
        }
        public Student(int grade)
        {
            this.grade = grade;
        }

        public int Grade { get => grade; set => grade = value; }
    }
}
