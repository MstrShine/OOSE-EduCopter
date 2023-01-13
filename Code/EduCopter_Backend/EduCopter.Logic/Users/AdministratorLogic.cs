using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Users
{
    public class AdministratorLogic : BaseEntityLogic<Administrator, EFAdministrator>
    {
        public AdministratorLogic(IEntityRepository<EFAdministrator> repository) : base(repository)
        {
        }

        protected override Administrator Convert(EFAdministrator entity)
        {
            throw new NotImplementedException();
        }

        protected override EFAdministrator Convert(Administrator entity)
        {
            throw new NotImplementedException();
        }
    }
}
