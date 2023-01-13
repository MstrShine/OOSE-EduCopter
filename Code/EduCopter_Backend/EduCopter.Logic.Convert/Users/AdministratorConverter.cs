using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Domain.Users;

namespace EduCopter.Logic.Convert.Users
{
    public static class AdministratorConverter
    {
        public static Administrator Convert(EFAdministrator ef)
        {
            return new()
            {
                Id = ef.Id,
                Username = ef.Username,
                Password = ef.Password,
            };
        }

        public static EFAdministrator Convert(Administrator e)
        {
            return new()
            {
                Id = e.Id,
                Username = e.Username,
                Password = e.Password
            };
        }
    }
}
