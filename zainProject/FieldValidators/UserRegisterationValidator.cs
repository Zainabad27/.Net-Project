using FieldValidatorAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zainProject.FieldValidators
{
    public class UserRegisterationValidator
    {

        const int FirstName_Min_Length = 2;
        const int FirstName_Max_Length = 100;
       
        const int lastName_Min_Length = 2;
        const int lastName_Max_Length = 100;

        delegate bool EmailExists(string Email);


         private FieldValidatorDel _requiredFieldValidDelegate=null;
        private StringLengthValidDel _stringLengthValidDelegate = null;
        private DateValidDel _dateValidDelegate = null;
        private PatternValidDel _patternMatchDelegate = null;
        private CompareTwoFields _compareFieldsValidDelegate = null;
        private FieldValidatorDel IsFieldEmptyDelegate = null;



        
    }
}
