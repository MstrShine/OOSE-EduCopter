using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Providers;

namespace EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions
{
    public interface IEntityRepositorySession<EF> : IDisposable, IEFEntityProvider<EF> where EF : EFEntity
    {
    }
}
