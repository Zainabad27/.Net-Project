using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zainProject.Data
{
    public interface IRegister
    {
        bool registerUser(string[] Fields);
        bool EmailExists(string Email);
    }
}
