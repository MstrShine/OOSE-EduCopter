using EduCopter.Domain.Users;

namespace EduCopter.API.JWT
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserInfo user);
        bool ValidateToken(string key, string issuer, string audience, string token, out string user);
    }
}
