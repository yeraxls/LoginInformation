using LoginInformation.Models;

namespace LoginInformation.Repositories
{
    public interface IUserRepository
    {
        LoginResponseModel Login(LoginRequestModel login);
        void UpdateConectionUser(int userId, int isOnline);
    }
}