using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Logic.Interfaces
{
    public interface IEntityLogic<E, EF> where E : Entity where EF : EFEntity
    {

    }
}
