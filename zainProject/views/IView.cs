using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zainProject.FieldValidators;

namespace zainProject.views
{
    public interface IView
    {
        void runView();
        IFieldValidator FieldValidator { get;  }

    }
}
