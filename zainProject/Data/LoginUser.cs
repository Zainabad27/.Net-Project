using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zroject.Data;
using Zroject.Models;

namespace zainProject.Data
{
    public class LoginUser : ILogin
    {
        public User Login(string Eml, string Pass)
        {
            using (var Dbcontext = new ClubMemberShipDbContext())
            {
                var user=Dbcontext.UserModel.FirstOrDefault(u=>(u.Email==Eml && u.Password==Pass));

                return user;
            }
        }
    }
}
