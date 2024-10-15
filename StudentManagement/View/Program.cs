using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Model;
using StudentManagement.Services;
namespace StudentManagement.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Manager manager = new Manager();
            DisplayMenu menu = new DisplayMenu();
            
            List<Student> students = new List<Student>();
            manager.GetListStudents(students);
            Statistic statistic = new Statistic(manager);
            menu.MenuFunction(students);

            Console.WriteLine("Input choice: ");
            string choice;
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    manager.Create();
                    break;
                default:
                    goto END;
            }
            while (true)
            {
                menu.MenuFunction(students);
                Console.WriteLine("Input choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        manager.Create();
                        break;
                    case "2":
                        manager.ReadById();
                        break;
                    case "3":
                        manager.Read();
                        manager.Update();
                        break;
                    case "4":
                        manager.Read();
                        manager.Delete();
                        break;
                    case "5":
                        manager.Read();
                        break;
                    case "6":
                        statistic.AcademicPerformace();
                        break;
                    case "7":
                        statistic.GPA();
                        break;
                    case "8":
                        manager.ReadByAcademicPerformance();
                        break;
                    default:
                        goto END;

                }
            }
        END:
            manager.SaveFile();

        }

    }
}