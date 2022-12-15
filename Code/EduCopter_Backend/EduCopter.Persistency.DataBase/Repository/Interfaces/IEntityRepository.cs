using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Persistency.DataBase.Repository.Interfaces
{
    public interface IEntityRepository<EF> : IBaseRepository<IEntityRepositorySession<EF>, EF> where EF : EFEntity
    {
    }
}
