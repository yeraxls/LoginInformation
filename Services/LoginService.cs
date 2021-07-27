using LoginInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Services
{
    public class LoginService : ILoginService
    {
        public LoginResponseModel Login(LoginRequestModel login)
        {

            return new LoginResponseModel { Date = DateTime.Now };
        }
        public bool Logout(SoloIdModel userId)
        {
            return true;
        }
        public string ForgotPassword(string mail)
        {
            return "Done";
        }
    }
}
