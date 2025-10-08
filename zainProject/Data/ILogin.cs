using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zroject.Models;

namespace zainProject.Data
{
    public interface ILogin
    {
        User Login(string Email,string Password);
    }
}
