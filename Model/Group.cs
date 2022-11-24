using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace hometask_6.Model
{
    internal class Group
    {
        private int i = 0;
        public int No;
        public bool IsFull = false;
        public static int Limit = 5;
        protected Student[] students = new Student[0];



        public void AddStudent(Student student)
        {
            Array.Resize(ref students, Limit);
            if (i < Limit)
            {
                students[i] = student;
                i++;
                if (i == Limit)
                {
                    IsFull = true;
                    Console.WriteLine("\nTHIS GROUP IS FULL  NOW!");
                }
            }
        }
        public void GetStudents()
        {
            foreach (var item in students)
            {
                if (item == null)
                {
                    break;
                }
                else
                    Console.WriteLine($"{Array.IndexOf(students, item) + 1}. {item.Name} {item.Surname} ");

            }
        }

    }
}

