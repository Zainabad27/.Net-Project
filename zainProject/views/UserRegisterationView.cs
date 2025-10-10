using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.Data;
using zainProject.FieldValidators;

namespace zainProject.views
{
    public class UserRegisterationView : IView
    {
        IRegister _register = null;
        IFieldValidator _fieldValidator = null;

        public UserRegisterationView(IRegister R,IFieldValidator f) { 
        
        _register= R;   
        _fieldValidator= f;       
        }
        public IFieldValidator FieldValidator { get => _fieldValidator; }

        public void runView()
        {
            CommonOutputText.WriteRegisterHeading();

            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.Email] = GetUserInput(FieldConstants.UserRegisterationFields.Email, "Please Enter Your Email.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.FirstName] = GetUserInput(FieldConstants.UserRegisterationFields.FirstName, "Please Enter Your FirstName.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.LastName] = GetUserInput(FieldConstants.UserRegisterationFields.LastName, "Please Enter Your LastName.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.Password] = GetUserInput(FieldConstants.UserRegisterationFields.Password, "Please Enter Your Password.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.PasswordCompare] = GetUserInput(FieldConstants.UserRegisterationFields.PasswordCompare, "Please Enter Your Password Again.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.DOB] = GetUserInput(FieldConstants.UserRegisterationFields.DOB, "Please Enter Your Date Of Birth.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.PhoneNumber] = GetUserInput(FieldConstants.UserRegisterationFields.PhoneNumber, "Please Enter Your PhoneNumber.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.AddressFirstLine] = GetUserInput(FieldConstants.UserRegisterationFields.AddressFirstLine, "Please Enter Your AddressFirstLine.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.AddressLastLine] = GetUserInput(FieldConstants.UserRegisterationFields.AddressLastLine, "Please Enter Your AddressLastLine.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.AddressCity] = GetUserInput(FieldConstants.UserRegisterationFields.AddressCity, "Please Enter Your AddressCity.");
            _fieldValidator.FieldArray[(int)FieldConstants.UserRegisterationFields.PostalCode] = GetUserInput(FieldConstants.UserRegisterationFields.PostalCode, "Please Enter Your PostalCode.");


            //RegisterUser.registerUser(_fieldValidator.FieldArray);
            Registeruser(_fieldValidator.FieldArray);


        }

        private void Registeruser(string[] Fieldarray) {
            _register.registerUser(Fieldarray);
            CommonOutputFormat.ChangeConsoleTheme(FontTheme.success);
            Console.WriteLine("You have successfully Registered a User.");
            CommonOutputFormat.ChangeConsoleTheme(FontTheme.Normal);
            Console.ReadLine();
        }

        private string GetUserInput(FieldConstants.UserRegisterationFields field,string promptText)
        {

            string fieldVal = "";
            do {
                Console.WriteLine(promptText);
                fieldVal = Console.ReadLine();

            }while(!(ValidField(field,fieldVal))) ;



            return fieldVal;    
        }

        private bool ValidField(FieldConstants.UserRegisterationFields fieldnum,string fieldVal)  {

           bool IsValid= _fieldValidator.ValidatorDel((int)fieldnum, fieldVal, _fieldValidator.FieldArray, out string InvalidMSG);

            if (IsValid)
            {
                CommonOutputFormat.ChangeConsoleTheme(FontTheme.Danger);
                Console.WriteLine(InvalidMSG);
                CommonOutputFormat.ChangeConsoleTheme(FontTheme.Normal);

                return false;

            }

            return true;    





        }
    }
}
