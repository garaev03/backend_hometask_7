using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_6.Model
{
    internal class Group
    {
        private int _no;
        private int _limit;
        public int No
        {
            get => _no;
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Please enter valid group number!");
                    Console.Write("ENTER NEW GROUP NUMBER: ");
                    value = int.Parse(Console.ReadLine());
                }
                _no = value;
            }
        }
        public int Limit
        {
            get => _limit;
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Please enter valid group limit!");
                    Console.Write("ENTER NEW GROUP LIMIT: ");
                    value = int.Parse(Console.ReadLine());
                }
                _limit = value;
            }
        }
        private Student[] students = new Student[0];

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            if (Limit < students.Length)
            {
                Array.Resize(ref students, students.Length - 1);
                Console.WriteLine("\nThis group is full!");
            }
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    Console.WriteLine("\nStudent is added!");
                    break;
                }
            }
        }
        public void GetStudent()
        {
            foreach (var stud in students)
            {
                Console.WriteLine($"{Array.IndexOf(students,stud)+1}. {stud.Name} {stud.Surname}");
            }
        }
    }
}
