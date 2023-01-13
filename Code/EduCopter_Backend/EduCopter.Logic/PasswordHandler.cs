using EduCopter.Logic.Interfaces;

namespace EduCopter.Logic
{
    public class PasswordHandler : IPasswordHandler
    {
        public async Task<bool> CheckPassword(string savedPassword, string toCheck)
        {
            if (string.IsNullOrEmpty(savedPassword) || string.IsNullOrEmpty(toCheck))
            {
                return false;
            }

            return BCrypt.Net.BCrypt.EnhancedVerify(toCheck, savedPassword);
        }

        public async Task<string> CreatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password));
            }

            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, 10);
        }
    }
}
