using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories.Interfaces
{
    public interface IBaseRepository<S, EF> where S : IEntityRepositorySession<EF> where EF : EFEntity
    {
        S CreateSession();
    }
}
