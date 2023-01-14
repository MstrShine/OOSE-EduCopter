using EduCopter.Persistency.DataBase.Repositories.Interfaces;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories
{
    public class StudentMissionRepository : IStudentMissionRepository
    {
        private readonly IServiceProvider _service;

        public StudentMissionRepository(IServiceProvider service)
        {
            _service = service;
        }

        public IStudentMissionRepositorySession CreateSession()
        {
            return (IStudentMissionRepositorySession)_service.GetService(typeof(IStudentMissionRepositorySession));
        }
    }
}
