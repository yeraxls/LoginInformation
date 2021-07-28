using LoginInformation.Models;
using LoginInformation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Services
{
    public class LoginService : ILoginService
    {
        private readonly UserRepository userRepository;
        public LoginService()
        {
            userRepository = UserRepository.GetInstance();
        }
        public LoginResponseModel Login(LoginRequestModel login)
        {
            var user = userRepository.Login(login);
            if (user.Valid) userRepository.UpdateConectionUser(user.Id, 1);
            return user;
        }
        public void Logout(SoloIdModel userId)
        {
            userRepository.UpdateConectionUser(userId.Id, 0);
        }
        public string ForgotPassword(string mail)
        {
            return "Done";
        }
    }
}
