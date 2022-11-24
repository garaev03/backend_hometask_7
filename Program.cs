using hometask_6.Model;

namespace hometask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Console.Write("ADD GROUP LIMIT: ");
            Group.Limit = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("\nFUNCTIONS");
                Console.WriteLine("1. ADD GROUP");
                Console.WriteLine("1. SEE STUDENTS");
                Console.WriteLine("3. EXIT\n");
                Console.Write("ENTER KEY: ");
                int value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    Console.Write("\nENTER GROUP NO: ");
                    group = new Group
                    {
                        No = Convert.ToInt32(Console.ReadLine())
                    };
                }
                else if (value == 2)
                {
                    Console.WriteLine("GROUP NO: "+group.No+" ");
                    group.GetStudents();
                }
                else if (value == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nPLEASE ENTER VALID KEY");
                    continue;
                }
                if (value == 1)
                {
                    while (!group.IsFull)
                    {
                        Console.WriteLine("\n1. ADD STUDENTS");
                        Console.WriteLine("2. GO BACK\n");
                        Console.Write("ENTER KEY: ");
                        int value2 = Convert.ToInt32(Console.ReadLine());
                        if (value2 == 1)
                        {
                            Student student = new();
                            Console.WriteLine("\nENTER STUDENTS' INFO");
                            Console.Write("ENTER STUDENT NAME: ");
                            student.Name = Console.ReadLine();
                            Console.Write("ENTER STUDENT SURNAME: ");
                            student.Surname = Console.ReadLine();
                            Console.WriteLine();
                            group.AddStudent(student);
                        }
                        else if (value2 == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nPLEASE ENTER VALID KEY");
                        }
                    }
                }
            }
        }
    }
}