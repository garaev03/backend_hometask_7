using hometask_6.Model;
using System;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace hometask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[0];
        Loop:
            while (true)
            {
                Console.WriteLine("\n--------------------\n1.Create Group\n2.Add Student\n3.Show Groups\n4.Show Students\n0.EXIT\n--------------------\n");
                Console.Write("ENTER KEY: "); int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Group group = new();
                        Console.Write("\n----------SELECED CREATING GROUP\n\nAdd Group limit: "); group.Limit = int.Parse(Console.ReadLine());
                    inCaseNumberExist:
                        Console.Write("\nAdd Group number: "); group.No = int.Parse(Console.ReadLine());
                        if (!CheckGroups(groups, group.No))
                        {
                            Console.WriteLine("\nNew group created!");
                            Array.Resize(ref groups, groups.Length + 1);
                            CreateGroup(groups, group);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nAnother group exists with this number.Do you want cancel group creation or add new number?\n1.Add new number\n2.Cancel group");
                            Console.Write("ENTER KEY: "); int valueCase1 = int.Parse(Console.ReadLine());
                            if (valueCase1 == 1)
                                goto inCaseNumberExist;
                            else
                            {
                                Console.WriteLine("\nYou canceled group creation!");
                                goto Loop;
                            }
                        }
                    case 2:
                        Console.WriteLine("\n----------SELECTED ADDING STUDENT");
                        if (GroupExistence(groups))
                        {
                            Student student = new();
                            Console.Write("Student's name: "); student.Name = Console.ReadLine();
                            Console.Write("Student's surname: "); student.Surname = Console.ReadLine();
                        SelectingGroup:
                            Console.WriteLine("\nTo which group do you want to add student?");
                            GroupsList(groups);
                            Console.Write("\nENTER KEY: "); int value3 = int.Parse(Console.ReadLine());
                            foreach (var item in groups)
                            {
                                if (value3 == Array.IndexOf(groups, item) + 1)
                                {
                                    item.AddStudent(student);
                                    break;
                                }
                                if (Array.IndexOf(groups, item) == groups.Length - 1)
                                {
                                    Console.WriteLine("PLEASE CHOOSE VALID GROUP!");
                                    goto SelectingGroup;
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nThere is no group to add student. Please create a new group!\n...Going back to Menu.");
                            goto Loop;
                        }
                    case 3:
                        Console.WriteLine("\n----------SELECTED SHOW GROUPS LIST\n\nGroup List:");
                        GroupsList(groups);
                        Console.WriteLine("\nAvailable functions(under development)\n1.Delete group\n2.Remove student from group\n0.Go back");
                        break;
                    case 4:
                        Console.WriteLine("\n----------SELECTED SHOW STUDENTS LIST\nStudent List:");
                        StudentsList(groups);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("\nPLEASE CHOOSE VALID FUNCTION!");
                        break;
                }
            }
        }

        static void StudentsList(Group[] groups)
        {
            foreach (var group in groups)
            {
                Console.WriteLine("\nGroup: "+group.No);
                group.GetStudent();
            }
        }
        static void GroupsList(Group[] groups)
        {
            foreach (var group in groups)
            {
                if (group != null)
                    Console.WriteLine($"{Array.IndexOf(groups, group) + 1}. Group: {group.No}");
            }
        }
        static bool GroupExistence(Group[] groups)
        {
            foreach (var group in groups)
            {
                if (group != null)
                {
                    return true;
                }
            }
            return false;
        }
        static bool CheckGroups(Group[] groups, int no)
        {
            foreach (var item in groups)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }
        static void CreateGroup(Group[] groups, Group group)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i] == null)
                {
                    groups[i] = group;
                    break;
                }
            }
        }
    }
}