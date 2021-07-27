using LoginInformation.Models;

namespace LoginInformation.Services
{
    public interface ILoginService
    {
        LoginResponseModel Login(LoginRequestModel login);
        bool Logout(SoloIdModel userId);
        string ForgotPassword(string mail);
    }
}