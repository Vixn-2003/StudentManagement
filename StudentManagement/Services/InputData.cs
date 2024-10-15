using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Constants;
using StudentManagement.Validate;
namespace StudentManagement.Services
{
    internal class InputData
    {
        private DataValidation validation = new DataValidation();
        public string InputFullName()
        {
            while (true)
            {
                Console.WriteLine("Input data for the FullName: ");
                string fullName = Console.ReadLine();
                if (validation.CheckInputFullName(fullName))
                {
                    return fullName;
                }
            }
        }
        public string InputAddress()
        {
            while (true)
            {
                Console.WriteLine("Input data for Address: ");
                string address = Console.ReadLine();
                if (validation.CheckInputAddress(address))
                {
                    return address;
                }
            }
            
        }
        public string InputStudentId()
        {
            while (true)
            {
                Console.WriteLine("Input data for studentId: ");
                string studentId = Console.ReadLine();
                if (validation.CheckInputStudentID(studentId))
                {
                    return studentId;
                }
            }

        }
        public string InputNameSchool()
        {
            while (true)
            {
                Console.WriteLine("Input data for school name: ");
                string nameSchool = Console.ReadLine();
                if (validation.CheckNameSchool(nameSchool))
                {
                    return nameSchool;
                }
            }
        }
        public DateTime InputDateOfBirth() 
        {
            while (true)
            {
                Console.WriteLine("Input data for DateOfBirth  (YYYY-MM-DD): ");
                DateTime dateOfBirth = new DateTime();
                string input = Console.ReadLine();
                if (validation.CheckInputDateOfBirth(input, ref dateOfBirth))
                {
                    return dateOfBirth;
                }
            }
        }
        public double InputHeight()
        {
            while (true)
            {
                Console.WriteLine($"Input data for height{ConstantsLimited.MIN_HEIGHT} - {ConstantsLimited.MAX_HEIGHT}");
                double height = 0;
                string input = Console.ReadLine();
                if (validation.CheckInputHeight(input, ref height))
                {
                    return height;
                }
            }
        }
        public double InputWeight()
        {
            while (true)
            {
                Console.WriteLine($"Input data for weight ({ConstantsLimited.MIN_WEIGHT} - {ConstantsLimited.MAX_WEIGHT}): ");
                double weight = 0;
                string input = Console.ReadLine();
                if (validation.CheckInputWeight(input, ref weight))
                {
                    return weight;
                }
            }
        }
        public int InputStartYear()
        {
            while (true)
            {
                int startYear = 0;
                Console.WriteLine($"Input data for start year ({ConstantsLimited.MIN_START_YEAR}): ");
                string input = Console.ReadLine();
                if (validation.CheckStartYear(input, ref startYear))
                {
                    return startYear;
                }
            }
        }
        public double InputGPA()
        {
            while (true)
            {
                double gPA = 0;
                Console.WriteLine($"Input data for GPA({ConstantsLimited.MIN_GPA} - {ConstantsLimited.MAX_GPA}): ");
                string input = Console.ReadLine() ;
                if (validation.CheckInputGPA(input, ref gPA))
                {
                    return gPA;

                }
            }
        }


    }
}
