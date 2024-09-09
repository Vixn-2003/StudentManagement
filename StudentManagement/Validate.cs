using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Validate
    {
        const int MaxNameLength = 100;
        const int MinBirthDate = 1900;
        const int MaxAddressLength = 300;
        const double MinHeight = 50.0;
        const double MaxHeight = 300.0;
        const double MinWeight = 5.0;
        const double MaxWeight = 1000.0;
        const int MinStartYear = 1900;
        const double MinGPA = 0.0;
        const double MaxGPA = 10.0;
        public Boolean isValidPersonId(List<Person> persons,int personId) { 
            // Validate PersonId is positive number and PersonId not duplicate
            return personId > 0 && persons.All(x => x.Id != personId);
        
        }
        public Boolean isValidStudentId(List<Student> students, string studentId) {
            // Validate StudentId is string have 10 character not duplicate, not null

            return !string.IsNullOrEmpty(studentId) && studentId.Length == 10 && students.All(x => x.StudentId != studentId);
        }
        public Boolean isValidName(string name) {  
            // Validate Name is string less than 100 character and not empty
            return !string.IsNullOrEmpty(name) && name.Length <=100;
        }
        public Boolean isValidBirthDate(DateTime birthDate) {
            // Validate BirthDate from 1900
            return birthDate.Year >= 1900;
        }

        public Boolean isValidAddress(string address) { 
            // Validate Address less than 300 characters
            return address.Length < 300 || string.IsNullOrEmpty(address);
        }
        
        public Boolean isValidHeight(double height) {
            // Validate Height greater equal than 50.0(cm) and Height less equal than 300.0(cm)
            return height >= 50.0 && height <= 300.0;
        }

        public Boolean isValidWeight(double weight) {
            // Validate Weight greater equal than 5.0(kg) and Weight less equal than 1000.0 (kg)
            return weight >= 5.0 && weight <= 1000.0;
        }

    }
}
