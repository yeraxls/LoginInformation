using LoginInformation.Models;
using LoginInformation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Services
{
    public class RegisterService
    {
        private readonly UserRepository userRepository;
        public RegisterService()
        {
            userRepository = UserRepository.GetInstance();
        }
        
    }
}
