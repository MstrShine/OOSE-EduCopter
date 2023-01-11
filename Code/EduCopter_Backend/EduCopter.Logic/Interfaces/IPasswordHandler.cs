using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Interfaces
{
    public interface IPasswordHandler
    {
        Task<bool> CheckPassword(string savedPassword, string toCheck);

        Task<string> CreatePassword(string password);
    }
}
