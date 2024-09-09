using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student : Person
    {
        private string studentId;
        private string school;
        private int startYear;
        private double gpa;

        public string StudentId { get => studentId; set => studentId = value; }
        public string School { get => school; set => school = value; }
        public int StartYear { get => startYear; set => startYear = value; }
        public double GPA { get => gpa; set => gpa = value; }


        public Student() : base() { }

        public Student(string name, DateTime birthDate,string address, double height, double weight, string  studentId, string school, int startYear, double gpa) : base(name,birthDate,address,height,weight)
        {
            StudentId = studentId;
            School = school;
            StartYear = startYear;
            GPA = gpa;
        }
       
        public override string? ToString()
        {
            return $"{base.ToString()}\n StudentId: {StudentId}; School: {School}; StartYear: {StartYear}; GPA: {GPA}";
        }
    }
}
