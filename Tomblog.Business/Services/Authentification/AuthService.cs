using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomblog.DAL.Model;
using Tomblog.DAL.Repositories.Interfaces;

namespace Tomblog.Business.Services.Authentification
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepo;
        public AuthService(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        public async Task CreateUser(User userModel)
        {
            await _authRepo.AddUserAsync(userModel);
            await _authRepo.SaveChangesAsync();
        }
    }
}
