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
}
