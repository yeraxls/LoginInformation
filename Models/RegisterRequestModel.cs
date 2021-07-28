using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Models
{
    public class RegisterRequestModel
    {
        public string Mail { get; set; } = "";
        public string Password { get; set; } = "";
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";

        public bool Validate()
        {
            return Mail.Length > 0 && Password.Length > 0;
        }
    }
}
