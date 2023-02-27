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
        User GetUserByEmail(string email);
        User GetUserById(int id);
        Task AddUserAsync(User userModel);
        Task<bool> SaveChangesAsync();
    }
}