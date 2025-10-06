using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FieldValidatorAPI { 
        public delegate bool FieldValidatorDel(string FieldVal);
        public delegate bool DateValidDel(string FieldVal,out DateTime ValidDate);
        public delegate bool PatternValidDel(string FieldVal,string pattern);
        public delegate bool CompareTwoFields(string FieldVal1,string FieldVal2);
        public delegate bool StringLengthValidDel(string FieldVal,int min,int max);
       



    public class CommonFieldValidatorFunctions
    {
        private FieldValidatorDel _requiredFieldValidDelegate=null;
        private StringLengthValidDel _stringLengthValidDelegate = null;
        private DateValidDel _dateValidDelegate = null;
        private PatternValidDel _patternMatchDelegate = null;
        private CompareTwoFields _compareFieldsValidDelegate = null;
        private FieldValidatorDel IsFieldEmptyDelegate = null;



        public FieldValidatorDel RequiredFieldValidDelegate
        {
            get {
                if (_requiredFieldValidDelegate == null)
                {
                    _requiredFieldValidDelegate = RequiredFieldValid;
                }
                    return _requiredFieldValidDelegate;

            }
        }
        public StringLengthValidDel StringLengthValidDelegate
        {
            get {
                if (_stringLengthValidDelegate == null)
                {
                    _stringLengthValidDelegate = StringLengthValid;
                }
                    return _stringLengthValidDelegate;

            }
        }
        public DateValidDel DateValidDelegate
        {
            get {
                if (_dateValidDelegate == null)
                {
                    _dateValidDelegate = DateFieldValid;
                }
                    return _dateValidDelegate;

            }
        }
        public PatternValidDel FieldPatternValidDelegate
        {
            get {
                if (_patternMatchDelegate == null)
                {
                    _patternMatchDelegate = FieldPatternValid;
                }
                    return _patternMatchDelegate;

            }
        }
        public CompareTwoFields CompareFieldsValidDelegate
        {
            get {
                if (_compareFieldsValidDelegate == null)
                {
                    _compareFieldsValidDelegate = CompareFieldsWithEachOther;
                }
                    return _compareFieldsValidDelegate;

            }
        }
        public FieldValidatorDel FieldEmptyDelegate
        {
            get {
                if (IsFieldEmptyDelegate == null)
                {
                    IsFieldEmptyDelegate = IsFieldEmpty;
                }
                    return IsFieldEmptyDelegate;

            }
        }

        private static bool IsFieldEmpty(string field) {
            if (string.IsNullOrEmpty(field)) {  return false; }
            return true;
        }

        private static bool RequiredFieldValid(string FieldValue) {
            return (string.IsNullOrEmpty(FieldValue));



            
        }
        private static bool StringLengthValid(string FieldValue,int min,int max) {
            if (FieldValue.Length < min || FieldValue.Length > max) return false;
            return true;
        }


        private static bool DateFieldValid(string datetime, out DateTime ValidDateTime) {
            if (DateTime.TryParse(datetime, out ValidDateTime))
             {return true;}


            return false;
              
        
        }

        private static bool FieldPatternValid(String FieldValue,string RegularExpressionPattern) {
        
        Regex regPattern=new Regex(RegularExpressionPattern);


            return (regPattern.IsMatch(FieldValue));
           
        
        }



        private static bool CompareFieldsWithEachOther(string Field1,string Field2) {
            return (Field1.Equals(Field2)) ;
           
        
        }





        public static void Main()
        {

        }


    }
}
