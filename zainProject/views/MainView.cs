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
        IView _registerView = null;
        IView _loginView = null;


        public MainView(IView r, IView l) { 
            _registerView=r; _loginView = l;  
        
        }

        public void runView()
        {
            Console.WriteLine("Enter L to go to Login Page. \nEnter R to go to Register Page. \nPress Anyother Key to Exit. \n");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;


            if (key==ConsoleKey.R) {
                CommonOutputText.WriteRegisterHeading();
                _registerView.runView();
                Console.Clear();
                CommonOutputText.WriteLoginHeading();

                _loginView.runView();
            }
            else if (key == ConsoleKey.L) { 
                
                CommonOutputText.WriteLoginHeading();
                _loginView.runView();
            }
            else
            {
                Console.Clear();
                //Console.ReadKey();

            }
        }
    }
}
