using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories.Interfaces
{
    public interface IStudentMissionRepository
    {
        IStudentMissionRepositorySession CreateSession();
    }
}
