using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Persistency.DataBase.Providers
{
    public interface IEntityProvider<EF> where EF : EFEntity
    {
        Task<List<EF>> GetAll();

        Task<EF> Get(Guid id);

        Task<EF> SaveOrUpdate(EF entity);

        Task Delete(Guid id);
    }
}
