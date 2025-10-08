using FieldValidatorAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.Data;

namespace zainProject.FieldValidators
{
    public class UserRegisterationValidator:IFieldValidator
    {
        private IRegister _register=null;
       public UserRegisterationValidator(IRegister Register) {
            _register=Register;

        
        }

        const int FirstName_Min_Length = 2;
        const int FirstName_Max_Length = 100;

        const int lastName_Min_Length = 2;
        const int lastName_Max_Length = 100;

        delegate bool EmailExistsDel(string Email);

        private FieldValidatorDelegateInterface _fieldValidatorDel = null;

        private FieldValidatorDel _requiredFieldValidDelegate = null;
        private StringLengthValidDel _stringLengthValidDelegate = null;
        private DateValidDel _dateValidDelegate = null;
        private PatternValidDel _patternMatchDelegate = null;
        private CompareTwoFields _compareFieldsValidDelegate = null;

        EmailExistsDel _emailExistsDel = null;

        private string[] _fieldArray = null;
        string[] FieldArray {
            get {
                if (_fieldArray == null)
                
                    _fieldArray = new string[Enum.GetValues(typeof(FieldConstants.UserRegisterationFields)).Length];
                
                return _fieldArray;

            
            }
        
        }

        string[] IFieldValidator.FieldArray => FieldArray;

        public FieldValidatorDelegateInterface ValidatorDel => _fieldValidatorDel;

        public void InitializesValidatorDelegates()
        {

            _fieldValidatorDel = ValidField;

            _emailExistsDel = _register.EmailExists;

            _requiredFieldValidDelegate = CommonFieldValidatorFunctions.RequiredFieldValidDelegate;
            _stringLengthValidDelegate = CommonFieldValidatorFunctions.StringLengthValidDelegate;
            _dateValidDelegate = CommonFieldValidatorFunctions.DateValidDelegate;
            _patternMatchDelegate = CommonFieldValidatorFunctions.FieldPatternValidDelegate;
            _compareFieldsValidDelegate = CommonFieldValidatorFunctions.CompareFieldsValidDelegate;


        }
         
        

        private bool ValidField(int FieldIndex, string FieldValue, string[] FieldArray, out string FieldInvalidMsg)
        {
            FieldInvalidMsg = "";

            FieldConstants.UserRegisterationFields Field = (FieldConstants.UserRegisterationFields) FieldIndex;

            switch (Field)
            {
                case FieldConstants.UserRegisterationFields.Email:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Email cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;
                    FieldInvalidMsg = (_patternMatchDelegate(FieldValue, CommonRegularExpressionValidationPatterns.Email_Address_RegEx_Pattern)) ? $"" : "Invalid Email Pattern, Please Writedown the correct Email.";
                    if (FieldInvalidMsg != "") break;
                    FieldInvalidMsg = (_emailExistsDel(FieldValue)) ? "Email Already In use Please Enter a different Email." : "";
                    break;
                case FieldConstants.UserRegisterationFields.FirstName:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"FirstName cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;

                    FieldInvalidMsg = (_stringLengthValidDelegate(FieldValue, FirstName_Min_Length,FirstName_Max_Length)) ? $"" : "Invalid Length.";

                    break;
                case FieldConstants.UserRegisterationFields.LastName:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"LastName cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;

                    FieldInvalidMsg = (_stringLengthValidDelegate(FieldValue, FirstName_Min_Length, FirstName_Max_Length)) ? $"" : "Invalid Length.";

                    break;
                case FieldConstants.UserRegisterationFields.Password:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Password cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;

                    FieldInvalidMsg = (_patternMatchDelegate(FieldValue, CommonRegularExpressionValidationPatterns.Strong_Password_RegEx_Pattern)) ? $"" : "Password Too Weak";

                    break;
                case FieldConstants.UserRegisterationFields.PasswordCompare:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Confirm-Password cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;

                    FieldInvalidMsg = (_compareFieldsValidDelegate(FieldValue, FieldArray[(int)FieldConstants.UserRegisterationFields.PasswordCompare])) ? $"" : "Password Does not Match the previos one.";

                    break;
                case FieldConstants.UserRegisterationFields.DOB:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Date of Birth cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;

                    FieldInvalidMsg = (_dateValidDelegate(FieldValue,out DateTime validDate)) ? $"" : "Invalid Date Format";

                    break;
                case FieldConstants.UserRegisterationFields.PhoneNumber:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Phone Number cannot Be Empty" : "";
                    if (FieldInvalidMsg != "") break;

                    FieldInvalidMsg = (_patternMatchDelegate(FieldValue,CommonRegularExpressionValidationPatterns.Uk_PhoneNumber_RegEx_Pattern)) ? $"" : "Invalid Phone Number, Please Enter a valid Phone Number.";

                    break;
                case FieldConstants.UserRegisterationFields.AddressFirstLine:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Address cannot Be Empty" : "";
                  
                    break;
                case FieldConstants.UserRegisterationFields.AddressLastLine:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Address cannot Be Empty" : "";
                  
                    break;
                case FieldConstants.UserRegisterationFields.AddressCity:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Address-City cannot Be Empty" : "";
                  
                    break;
                case FieldConstants.UserRegisterationFields.PostalCode:
                    FieldInvalidMsg = (_requiredFieldValidDelegate(FieldValue)) ? $"Address-City cannot Be Empty" : "";
                    FieldInvalidMsg = (_patternMatchDelegate(FieldValue, CommonRegularExpressionValidationPatterns.Uk_Post_Code_RegEx_Pattern)) ? $"" : "Invalid Postal code, Please Enter a valid Postal Code.";

                    break;

                default:
                    throw new ArgumentException("This Field Does not Exists.");
            }

            return (FieldInvalidMsg == "");


        }
       
    }
}
