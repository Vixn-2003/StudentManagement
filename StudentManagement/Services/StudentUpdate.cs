using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    internal class StudentUpdate
    {
        private InputData inputData = new InputData();
        public void UpdateFullName(ref Student student)
        {
            Console.Clear();
            
            student.Name = inputData.InputFullName();
        }
        public void UpdateAddress(ref Student student)
        {
            Console.Clear();
            student.Address = inputData.InputAddress();
        }
        public void UpdateStudentID(ref Student student)
        {
            Console.Clear();
            student.StudentId = inputData.InputStudentId();
        }
        public void UpdateNameSchool(ref Student student)
        {
            Console.Clear();
            Console.Clear();
            student.School = inputData.InputNameSchool();
        }
        public void UpdateDateOfBirth(ref Student student)
        {
            Console.Clear();
            student.BirthDate = inputData.InputDateOfBirth();

        }
        public void UpdateHeight(ref Student student)
        {
            Console.Clear();
            student.Height = inputData.InputHeight();
        }
        public void UpdateWeight(ref Student student)
        {
            Console.Clear();
            student.Weight = inputData.InputWeight();
        }
        public void UpdateStartYear(ref Student student)
        {
            Console.Clear();
            student.StartYear = inputData.InputStartYear();
        }
        public void UpdateGPA(ref Student student)
        {
            Console.Clear();
            student.GPA = inputData.InputGPA();
        }

    }
}
