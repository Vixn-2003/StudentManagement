using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Constants
{
    public class ConstantsMessages
    {
        
        public const string INPUT_NULL_OR_WHITE_SPACE = "THE INPUT IS NULL";
        public const string INPUT_CONTAIN_DIGITS = "THE INPUT CONTAIN DIGITS";
        public const string INPUT_CONTAIN_LETTERS = "THE INPUT CONTAIN LETTERS";
        public const string INPUT_CONTAIN_SPECIAL_CHARATERS = "THE INPUT CONTAIN SPECIAL CHARACTERS";
        public const string LENGTH_EXCEEDS_DEFINED_LIMIT = "THE LENGTH INPUT EXCEEDS DEFINED LIMIT";
        public const string INVALID_DATE_TIME =" -THE DAY IS LESS EQUAL THAN TO THE NUMBER OF DAYS IN THE MONTH.\n" +
                                               " -THE MONTH IS BETWEEN 1 TO 12. \n" +
                                               " -THE DATE FORMATE SHOULD BE (YYYY-MM-DD)";
        public const string INPUT_CONTAIN_DUPLICATE_CHARACTERS = "STUDENT ID CONTAIN DUPLICATE CHARACTERS";
        public const string INVALID_DUPLICATE_STUDENT_ID = "STUDENT ID IS EXIST";
        public const string INVALID_ID = "ID DOES NOT EXISTS";
        public readonly string TIME_EXCEEDS_DEFINED_LIMIT = $"THE TIME INPUT EXCEEDS DEFINED LIMIT\n-THE YEAR MUST BE GREATER THAN {ConstantsLimited.MIN_START_YEAR}";
        public readonly string INVALID_STUDENT_ID_LENGTH = $"STUDENT ID MUST HAVE {ConstantsLimited.MAX_STUDENTID_LENGTH} ";
        public readonly string HEIGHT_OUT_OF_RANGE_ERROR = $"HEIGHT MUST BE BETWEEN {ConstantsLimited.MIN_HEIGHT} AND {ConstantsLimited.MAX_HEIGHT}";
        public readonly string WEIGHT_OUT_OF_RANGE_ERROR = $"WEIGHT MUST BE BETWEEN {ConstantsLimited.MIN_WEIGHT} AND {ConstantsLimited.MAX_WEIGHT}";
        public readonly string GPA_OUT_OF_RANGE_ERROR = $"GPA MUST BE BETWEEN {ConstantsLimited.MIN_GPA} AND {ConstantsLimited.MAX_GPA}";
    }
}
