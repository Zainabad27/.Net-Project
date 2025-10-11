using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.Data;
using zainProject.FieldValidators;

namespace zainProject.views
{
    public class MainView : IView
    {
        public IFieldValidator FieldValidator => null;
        IView _register = null;
        IView _login = null;


        public MainView(IView r, IView l) { 
            _register=r; _login=l;  
        
        }

        public void runView()
        {
            Console.WriteLine("Enter L to go to Login Page. \nEnter R to go to Register Page. \nPress Anyother Key to Exit. \n");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;


            if (key==ConsoleKey.R) {
                CommonOutputText.WriteRegisterHeading();
                _register.runView();
                _login.runView();
            }
            else if (key == ConsoleKey.L) { 
                
                CommonOutputText.WriteLoginHeading();
                _login.runView();
            }
            else
            {
                Console.Clear();

            }
        }
    }
}
