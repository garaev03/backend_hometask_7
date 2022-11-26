using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_6.Model
{
    internal class Student
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get => _name;

            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Please enter valid name!");
                    Console.Write("ENTER NEW NAME: ");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }
        public string Surname
        {
            get => _surname;

            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Please enter valid surname!");
                    Console.Write("ENTER NEW SURNAME: ");
                    value = Console.ReadLine();
                }
                _surname = value;
            }
        }
    }
}


