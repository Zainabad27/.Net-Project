using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.Data;
using zainProject.FieldValidators;
using zainProject.views;

namespace zainProject
{
    public static class Factory
    {
        public static IView GetMainView()
        {
            ILogin Login = new LoginUser();
            IRegister Register = new RegisterUser();
            IFieldValidator userRegisterationValidator = new UserRegisterationValidator(Register);

            userRegisterationValidator.InitializesValidatorDelegates();

            IView UserLoginV = new UserLoginView(Login);
            IView UserRegisterV = new UserRegisterationView(Register, userRegisterationValidator);

            IView MView = new MainView(UserRegisterV, UserLoginV);

            return MView;
        }

    }
}
