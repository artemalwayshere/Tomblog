using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomblog.DAL.Model;

namespace Tomblog.DAL.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(int id);
        Task<int> AddUser(User userModel);
    }
}