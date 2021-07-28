using LoginInformation.Models;
using LoginInformation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService _loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public LoginResponseModel Login([FromBody] LoginRequestModel login)
        {
            Debug.Assert(login.Validate());
            return _loginService.Login(login);
        }
        
        [HttpPost]
        [Route("logout")]
        public void Logout([FromBody] SoloIdModel userId)
        {
            _loginService.Logout(userId);
        }

        [HttpPost]
        [Route("/forgot-password")]
        public string ForgotPassword([FromBody] string mail)
        {
            return _loginService.ForgotPassword(mail);
        }
    }
}
