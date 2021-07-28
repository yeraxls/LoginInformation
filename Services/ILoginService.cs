using LoginInformation.Models;

namespace LoginInformation.Services
{
    public interface ILoginService
    {
        LoginResponseModel Login(LoginRequestModel login);
        void Logout(SoloIdModel userId);
        string ForgotPassword(string mail);
    }
}