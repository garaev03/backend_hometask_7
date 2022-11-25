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
        public bool IsFull = false;
        private int s = 0;
        public static int g = -1;
        public int No;
        public static int groups=2;
        public static int Limit=1;
        private  static Student[,] students = new Student[groups, Limit];

        public void AddStudent(Student student)
        {
            if (s < Limit)
            {
                students[g, s] = student;
                s++;                                    
                if (s == Limit)
                {
                    IsFull = true;
                    Console.WriteLine("\nTHIS GROUP IS FULL  NOW!");
                }
            }
        }
        public  void GetStudents()
        {
            for (int i = 0; i < groups; i++)
            {
                Console.WriteLine("\nGROUP NO: " + No);
                for (int j = 0; j < Limit; j++)
                {
                    Console.WriteLine($"{j+1}. {students[i, j].Surname}");
                }
            }
        }


    }
}


