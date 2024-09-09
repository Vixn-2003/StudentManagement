using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student : Person
    {
        public string StudentId { get; set; }
        public string School { get; set; }

        public int StartYear { get; set; }

        public double GPA { get; set; }


        public Student() { }

        public Student(int id, string name, DateTime birthDate, string address, double height, double width) : base(id, name, birthDate, address, height, width)
        {

        }

        public override string? ToString()
        {
            return $"{base.ToString()}\n StudentId: {StudentId}; School: {School}; StartYear: {StartYear}; GPA: {GPA}";
        }
    }
}
