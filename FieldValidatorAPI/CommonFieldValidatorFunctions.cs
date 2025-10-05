using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldValidatorAPI { 
        public delegate bool RequiredValidDel(string FieldVal);
        public delegate bool StringLengthValidDel(string FieldVal);
        public delegate bool DateValidDel(string FieldVal);
        public delegate bool PatternMatchDel(string FieldVal);
        public delegate bool CompareFieldsValidDel(string FieldVal);

    public class CommonFieldValidatorFunctions
    {

        public static bool RequiredFieldValid(string FieldValue) {
            if (string.IsNullOrEmpty(FieldValue)) { return false; }



            return true;
        }
        public static bool StringLengthValid(string FieldValue,int min,int max) {
            if (FieldValue.Length < min || FieldValue.Length > max) return false;
            return true;
        }


    }
}
