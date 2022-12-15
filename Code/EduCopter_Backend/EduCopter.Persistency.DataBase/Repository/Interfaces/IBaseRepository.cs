using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Persistency.DataBase.Repository.Interfaces
{
    public interface IBaseRepository<S, EF> where S : IEntityRepositorySession<EF> where EF : EFEntity
    {
        S CreateSession();
    }
}
