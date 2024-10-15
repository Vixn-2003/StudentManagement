using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Model;
namespace StudentManagement.View
{
    internal class DisplayMenu
    {
        public void MenuFunction(IEnumerable<Student> students)
        {
            Console.WriteLine("Menu Function\n");
            if (students.Any())
            {
                Console.WriteLine("1. Create new student");
                Console.WriteLine("2. Read information student by id");
                Console.WriteLine("3. Update information for student by id");
                Console.WriteLine("4. Delete information student by id");
                Console.WriteLine("5. Show list students");
                Console.WriteLine("6. Statistics academic performance of students");
                Console.WriteLine("7. Statistics GPA of students");
                Console.WriteLine("8. Show list students by academic performance");
                Console.WriteLine("Exit(Press any key to exit the program)");
            }
            else
            {
                Console.WriteLine("1. Create new student");
                Console.WriteLine("Exit (Press any key to exit the program)");
            }
            Console.WriteLine("-----------------------------------------");
        }
        public void MenuUpdate()
        {
            Console.WriteLine("-------UPDATE-----\n");
            Console.WriteLine("1 .Update Student Name");
            Console.WriteLine("2 .Update DateOfBirth");
            Console.WriteLine("3 .Update Address");
            Console.WriteLine("4 .Update Height");
            Console.WriteLine("5 .Update Weight");
            Console.WriteLine("6 .Update StudentID");
            Console.WriteLine("7 .Update NameSchool");
            Console.WriteLine("8 .Update Start Year");
            Console.WriteLine("9 .Update GPA");
            Console.WriteLine("Press any key back to main menu");
            Console.WriteLine("------------\n");
        }

    }
}
