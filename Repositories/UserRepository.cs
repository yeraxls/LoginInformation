using LoginInformation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LoginInformation.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static UserRepository repository = null;
        public static UserRepository GetInstance()
        {
            if (repository == null)
                repository = new UserRepository();
            return repository;
        }
        private string database = "server=(localdb)\\Prueba;database=LoginInfo;Integrated Security= true";
        private UserRepository()
        {

        }

        public LoginResponseModel Login(LoginRequestModel login)
        {
            LoginResponseModel user = new LoginResponseModel();
            var query = $"SELECT * FROM [LoginInfo].[dbo].[User] where Mail = '{login.Mail}' AND Password = '{login.Password}' AND IsOnline = 0";
            using (SqlConnection connection = new SqlConnection(database))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var data = command.ExecuteReader();
                if (!data.HasRows)
                    return new LoginResponseModel { Valid = false };
                while (data.Read())
                {
                    user = new LoginResponseModel
                    (
                        (int)data["Id"],
                        data["Name"].ToString(),
                        data["LastName"].ToString(),
                        data["Mail"].ToString(),
                        data["Password"].ToString()
                    );
                }
                command.Connection.Close();
                return user;
            }
        } 
        
        public void UpdateConectionUser(int userId, int isOnline)
        {
            var query = $"update [LoginInfo].[dbo].[User] set IsOnline = {isOnline}, LastConection = '{DateTime.Now}' where Id = {userId}";
            using (SqlConnection connection = new SqlConnection(database))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var data = command.ExecuteReader();
                command.Connection.Close();
            }
        }
    }
}
