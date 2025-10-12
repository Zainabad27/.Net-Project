using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.FieldValidators;
using Zroject.Models;

namespace zainProject.views
{
    public class WelcomeUserView : IView
    {
        User _user = null;
        public IFieldValidator FieldValidator => null;
        public WelcomeUserView(User U)
        {
            _user = U;  

        }

        public void runView()
        {
            CommonOutputFormat.ChangeConsoleTheme(FontTheme.success);
            Console.WriteLine($"Welcome {_user.FirstName} to the Cycling Club Application.");
            CommonOutputFormat.ChangeConsoleTheme(FontTheme.Normal);
            Console.ReadLine();
        }
    }
}
