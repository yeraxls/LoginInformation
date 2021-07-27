using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Models
{
    public class LoginRequestModel
    {
        public string Mail { get; set; } = "";
        public string Password { get; set; } = "";


        public bool Validate()
        {
            return Mail.Length > 0 && Password.Length > 0;
        }
    }
}
