using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Models
{
    public class LoginResponseModel : LoginRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool Valid { get; set; }
        public DateTime Date {get; set;}
    }
}
