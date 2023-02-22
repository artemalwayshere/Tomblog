using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomblog.DAL.Model;
using Tomblog.DAL.Repositories.Interfaces;

namespace Tomblog.DAL.Repositories.Implementations
{
    public class AuthRepository : IAuthRepository
    {
        public Task<int> AddUser(User userModel)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
