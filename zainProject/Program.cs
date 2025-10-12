using zainProject;
using zainProject.views;

class Program { 
 static void Main(string[] args) {

        IView mainView = Factory.GetMainView();
        mainView.runView();



    }

}