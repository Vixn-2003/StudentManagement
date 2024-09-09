using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Manager
    {
        Student[] students = new Student[10];
        public Student createStudent(string studentId) { 
            Student s = new Student();
            return s;

        }
        private void inputData() {
            Validate valid = new Validate();
            Console.WriteLine("Enter information new student: ");
            Console.WriteLine("Id: ");
            string id = Console.ReadLine();
            if (!valid.isValidStudentId(id)) { 
                
            }
        }
    }
}
