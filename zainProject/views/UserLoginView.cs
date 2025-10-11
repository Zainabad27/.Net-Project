using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.Data;
using zainProject.FieldValidators;
using Zroject.Models;

namespace zainProject.views
{
    public class UserLoginView : IView
    {
        private ILogin _login;
        public IFieldValidator FieldValidator => null;

        public UserLoginView(ILogin LoginObj)
        {
            _login = LoginObj;

        }



        public void runView()
        {
            Console.WriteLine("Write Your Email Address.");
            string Email = Console.ReadLine();
            Console.WriteLine("Write Your Password.");
            string Password = Console.ReadLine();

            if (Email == null || Password == null)
            {
                Console.WriteLine("Invalid input.");
                return;

            }


            User user = _login.Login(Email, Password);

            if (user != null)
            {


                WelcomeUserView WelcomeUser = new WelcomeUserView(user);
                WelcomeUser.runView();
                return;


            }
            Console.WriteLine("Invalid Credentials Or User Does Not Exists.");
        }
    }
}
