using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StudentManagement.Model;
using StudentManagement.Constants;

namespace StudentManagement.Validate
{
    internal class DataValidation
    {
        public bool ContainsNumber(string input) => Regex.IsMatch(input, @"\d");
        public bool ContainsLetter(string input) => Regex.IsMatch(input, @"[a-zA-Z]");
        public bool ContainsSpecialCharacters(string input) => Regex.IsMatch(input, @"[^\w\s]");
        private ConstantsMessages messages = new ConstantsMessages();
        private ConstantsLimited limit = new ConstantsLimited();
        public bool CheckInputFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;
            }
            if (ContainsNumber(fullName))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_DIGITS);
                return false;
            }
            if (ContainsSpecialCharacters(fullName))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;
            }
            if (fullName.Length > ConstantsLimited.MAX_NAME_LENGTH)
            {
                Console.WriteLine(ConstantsMessages.LENGTH_EXCEEDS_DEFINED_LIMIT);
            }
            return true;
        }
        public bool CheckInputAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;
            }
            if (address.Length > ConstantsLimited.MAX_ADDRESS_LENGTH)
            {
                Console.WriteLine(ConstantsMessages.LENGTH_EXCEEDS_DEFINED_LIMIT);
                return false;
            }
            return true;
        }
        public bool CheckNameSchool(string nameSchool)
        {
            if (string.IsNullOrWhiteSpace(nameSchool))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;
            }
            if (ContainsSpecialCharacters(nameSchool))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;
            }
            if (nameSchool.Length > ConstantsLimited.MAX_SCHOOL_LENGHT)
            {
                Console.WriteLine(ConstantsMessages.LENGTH_EXCEEDS_DEFINED_LIMIT);
                return false;
            }
            return true;
        }
        public bool CheckInputStudentID(string studentID)
        {
            if (string.IsNullOrWhiteSpace(studentID))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;

            }
            if (ContainsSpecialCharacters(studentID))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;
            }
            if (studentID.Length != 10)
            {
                Console.WriteLine(messages.INVALID_STUDENT_ID_LENGTH);
                return false;
            }
            if (studentID.Distinct().Count() != studentID.Length)
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_DUPLICATE_CHARACTERS);
                return false;
            }
            return true;
        }

        public bool CheckInputDateOfBirth(string input, ref DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;
            }
            if (ContainsLetter(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_LETTERS);
                return false;
            }
            if (!DateTime.TryParse(input, out dateOfBirth))
            {
                Console.WriteLine(ConstantsMessages.INVALID_DATE_TIME);
                return false;
            }
            if (dateOfBirth.Year < ConstantsLimited.MIN_START_YEAR || DateTime.Now < dateOfBirth)
            {
                Console.WriteLine(messages.TIME_EXCEEDS_DEFINED_LIMIT);
                return false;
            }
            return true;
        }
        public bool CheckInputHeight(string input, ref double height)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;

            }
            if (ContainsLetter(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_LETTERS);
                return false;
            }
            if (ContainsSpecialCharacters(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;
            }
            double.TryParse(input, out height);
            if (height < ConstantsLimited.MIN_HEIGHT || height > ConstantsLimited.MAX_HEIGHT)
            {
                Console.WriteLine(messages.HEIGHT_OUT_OF_RANGE_ERROR);
                return false;
            }
            return true; 
        }
        public bool CheckInputWeight(string input, ref double weight)
        {
            if(string.IsNullOrWhiteSpace(input)){
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;
            }
            if (ContainsLetter(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_LETTERS);
                return false;
            }
            if (ContainsSpecialCharacters(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;
            }
            double.TryParse(input, out weight);
            if (weight < ConstantsLimited.MIN_WEIGHT || weight > ConstantsLimited.MAX_WEIGHT)
            {
                Console.WriteLine(messages.WEIGHT_OUT_OF_RANGE_ERROR);
                return false;
            }
            return true;
        }
        public bool CheckStartYear(string input, ref int startYear)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false ;
            }
            if (ContainsLetter(input)) {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_LETTERS);
                return false;
            }
            if (ContainsSpecialCharacters(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;

            }
            int.TryParse(input, out startYear);
            if (startYear < ConstantsLimited.MIN_START_YEAR)
            {
                Console.WriteLine(messages.TIME_EXCEEDS_DEFINED_LIMIT);
                return false;
            }
            return true;
        }
        public bool CheckInputGPA(string input, ref double GPA) {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_NULL_OR_WHITE_SPACE);
                return false;
            }
            if (ContainsLetter(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_LETTERS);
                return false;
            }
            if (!ContainsSpecialCharacters(input))
            {
                Console.WriteLine(ConstantsMessages.INPUT_CONTAIN_SPECIAL_CHARATERS);
                return false;

            }
            double.TryParse(input, out GPA);
            if (GPA < ConstantsLimited.MIN_GPA || GPA > ConstantsLimited.MAX_GPA)
            {
                Console.WriteLine(messages.GPA_OUT_OF_RANGE_ERROR);
                return false;
            }
            return true;
        }
    }
}