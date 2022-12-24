using System;
using System.Collections.Generic;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student>();
            List<Worker> workerList = new List<Worker>();
            for(int i = 0; i < 10; i++)
            {
                listStudent.Add(new Student(i+1));
            }
            for(int i = 0; i < 10; i++)
            {
                workerList.Add(new Worker());
            }
        }
    }
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
    class Student : Human
    {
        private int grade;

        public Student()
        {
        }
        public Student (int grade)
        {
            this.grade = grade;
        }

        public int Grade { get => grade; set => grade = value; }
    }
    class Worker : Human
    {
        private float weekSalary;
        private float workHoursPerDay;

        public Worker()
        {
        }

        public float WeekSalary { get => weekSalary; set => weekSalary = value; }
        public float WorkHoursPerDay { get => workHoursPerDay; set => workHoursPerDay = value; }
        public int MoneyPerHour()
        {
            int moneyperhours = 0;
            return moneyperhours;
        }

    }
}
