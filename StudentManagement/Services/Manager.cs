using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using StudentManagement.Constants;
using StudentManagement.Model;
using StudentManagement.Validate;
using StudentManagement.View;

namespace StudentManagement.Services
{
    internal class Manager
    {
      public List<Student> students = new List<Student>();
      public void GetListStudents(List<Student> getListStudents)
        {
            students = getListStudents;
        }
        public void Create()
        {
            Console.Clear();
            Student student = new Student();
            student.Input();
            students.Add(student);
        }
        public void Read()
        {
            Console.Clear();
            students.ForEach(student => Console.WriteLine(student));
        }
        public int InputSearchId()
        {
            int searchId;
            string input;
            while (true)
            {
                Console.WriteLine("Input id: ");
                input = Console.ReadLine();
                DataValidation validation = new DataValidation();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                    continue;
                }
                if (validation.ContainsLetter(input))
                {
                    Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_LETTERS);
                    continue;
                }
                if (validation.ContainsSpecialCharacters(input))
                {
                    Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                    continue;
                }
                searchId = int.Parse(input);
                if (!students.Any(student => student.Id == searchId))
                {
                    Console.WriteLine(ConstantsMessages.INVALID_ID);
                }
                break;
            }
            return searchId;
        }
        public int ReadById()
        {
            Console.Clear() ;
            int searchId = InputSearchId();
            students.Where(student  => student.Id == searchId).ToList().ForEach(student => Console.WriteLine(student));
            return searchId;
        }
        public void ReadByAcademicPerformance()
        {

            Console.Clear();
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Search with Academic Performance ( Kém, Yếu, TrungBình, Khá, Giỏi, XuấtSắc):");
           
            string input = Console.ReadLine();
            var result = students.FindAll(student =>
                         string.Equals(student.CheckAcademicPerformance(student.GPA),
                         input, StringComparison.OrdinalIgnoreCase));

            if (result.Count == 0)
            {
                Console.WriteLine("Academic Performance does not exist.\n");
            }
            else
            {
                result.ToList().ForEach(student => Console.WriteLine(student));
            }
        }
        public void Update()
        {
            int searchId = ReadById();
            Student studentToUpdate = students.SingleOrDefault(student => student.Id == searchId);
            if (studentToUpdate != null)
            {
                DisplayMenu displayMenu = new DisplayMenu();
                displayMenu.MenuUpdate();
                Console.WriteLine("Input choice: ");
                string choice = Console.ReadLine()?.Trim();
                StudentUpdate update = new StudentUpdate();
                switch (choice)
                {
                    case "1":
                        update.UpdateFullName(ref studentToUpdate);
                        break;
                    case "2":
                        update.UpdateDateOfBirth(ref studentToUpdate);
                        break;
                    case "3":
                        update.UpdateAddress(ref studentToUpdate);
                        break;
                    case "4":
                        update.UpdateHeight(ref studentToUpdate);
                        break;
                    case "5":
                        update.UpdateWeight(ref studentToUpdate);
                        break;
                    case "6":
                        update.UpdateStudentID(ref studentToUpdate);
                        break;
                    case "7":
                        update.UpdateNameSchool(ref studentToUpdate);
                        break;
                    case "8":
                        update.UpdateStartYear(ref studentToUpdate);
                        break;
                    case "9":
                        update.UpdateGPA(ref studentToUpdate);
                        break;
                    default:
                        Console.Clear();
                        break;

                }
                Console.WriteLine(studentToUpdate);
            }
        }
        public void Delete()
        {
            Console.WriteLine("Input id to Delete: ");
            int searchId = InputSearchId();
            int index = students.FindIndex(student => student.Id == searchId);         
            if (index >= 0)
            {
                
                for (int i = index; i < students.Count; i++)
                {
                    --students[i].Id;
                }
                students.RemoveAt(index);

                Student.nextId = students.Count;
                Console.Clear();
                Console.WriteLine("Delete successful\n");
            }
            else
            {
                Console.WriteLine("Student ID not found.");
            }
        }
        public void SaveFile()
        {
            students.ForEach(student => File.AppendAllText("Dynamic_Array_txt", student.ToString()));
        }
    
    }
}
