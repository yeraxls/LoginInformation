using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Models
{
    public class LoginResponseModel : LoginRequestModel
    {
        public LoginResponseModel() { }
        public LoginResponseModel(int id, string name, string lastName, string mail, string password)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Mail = mail;
            Password = password;
            OtorgaValores();
        }

        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool Valid { get; set; }
        public DateTime Date { get; set; }

        private void OtorgaValores()
        {
            Valid = Id != 0;
            Date = DateTime.Now;
        }
    }
}
