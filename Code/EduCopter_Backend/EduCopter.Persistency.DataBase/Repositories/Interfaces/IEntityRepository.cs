using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories.Interfaces
{
    public interface IEntityRepository<EF> : IBaseRepository<IEntityRepositorySession<EF>, EF> where EF : EFEntity
    {
    }
}
