using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zroject.Models;
using zainProject.FieldValidators;
using Microsoft.EntityFrameworkCore;
using Zroject.Data;

namespace zainProject.Data
{
    public class RegisterUser : IRegister
    {
        public bool EmailExists(string Email)
        {
            throw new NotImplementedException();
        }

       public  bool registerUser(string[] Fields)
        {
            using (var DbContext = new ClubMemberShipDbContext()) {
                User AddingUser = new User
                {

                    Email = Fields[(int)FieldConstants.UserRegisterationFields.Email],
                    FirstName = Fields[(int)FieldConstants.UserRegisterationFields.FirstName],
                    LastName = Fields[(int)FieldConstants.UserRegisterationFields.LastName],
                    Password = Fields[(int)FieldConstants.UserRegisterationFields.Password],
                    DOB = DateTime.Parse(Fields[(int)FieldConstants.UserRegisterationFields.DOB]),
                    PostCode = Fields[(int)FieldConstants.UserRegisterationFields.PostalCode],
                    AddressCity = Fields[(int)FieldConstants.UserRegisterationFields.AddressCity],
                    AddressFirstLine = Fields[(int)FieldConstants.UserRegisterationFields.AddressFirstLine],
                    AddressSecondLine = Fields[(int)FieldConstants.UserRegisterationFields.AddressLastLine],




                };


                DbContext.UserModel.Add(AddingUser);
                DbContext.SaveChanges();

            }
                
            return true;    
            
        }

       
    }
}
