namespace EduCopter.Logic.Interfaces
{
    public interface IPasswordHandler
    {
        Task<bool> CheckPassword(string savedPassword, string toCheck);

        Task<string> CreatePassword(string password);
    }
}
