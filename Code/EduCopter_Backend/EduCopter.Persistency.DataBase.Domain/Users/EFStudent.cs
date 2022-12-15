namespace EduCopter.Persistency.DataBase.Domain.Users
{
    public class EFStudent : EFEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
