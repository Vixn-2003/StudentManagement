using StudentManagement.Services;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model
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

        public Student(string name, DateTime birthDate, string address, double height, double weight, string studentId, string school, int startYear, double gpa)
            : base(name, birthDate, address, height, weight)
        {
            this.studentId = studentId;
            this.school = school;
            this.startYear = startYear;
            this.gpa = gpa;
        }
        //AcademicPerformance
        enum AcademicPerformance
        {
            Kém,
            Yếu,
            TrungBình,
            Khá,
            Giỏi,
            XuấtSắc
        }

        public string CheckAcademicPerformance(double gpa)
        {
            switch (gpa)
            {
                case var unused when gpa < 3.0:
                    return AcademicPerformance.Kém.ToString();
                case var unused when gpa < 5.0:
                    return AcademicPerformance.Yếu.ToString();
                case var unused when gpa < 6.5:
                    return AcademicPerformance.TrungBình.ToString();
                case var unused when gpa < 7.5:
                    return AcademicPerformance.Khá.ToString();
                case var unused when gpa < 9.0:
                    return AcademicPerformance.Giỏi.ToString();
                default:
                    return AcademicPerformance.XuấtSắc.ToString();
            }
        }
        public override void Input()
        {
            base.Input();
            InputData inputData = new InputData();
            StudentId = inputData.InputStudentId();
            School = inputData.InputNameSchool();
            StartYear = inputData.InputStartYear();
            GPA = inputData.InputGPA();
        }

        public override string? ToString()
        {
            return base.ToString() + $"\nStudentId: {this.studentId};" +
                                     $" School: {this.school};" +
                                     $" StartYear: {this.startYear};" +
                                     $" GPA: {this.gpa}" +
                                     $" AcademicPerformance: {CheckAcademicPerformance(this.gpa)}";
        }
    }
}
